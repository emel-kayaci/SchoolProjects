# Rezerve edilmiş koltuklara check in yapıldıysa işlem kaydı oluşturur. Eğer check_in iptal olduysa işlem kaydını da siler. 
DELIMITER $$
CREATE TRIGGER trigger_transaction_record 
AFTER UPDATE
ON airlinedb.seat_reservation FOR EACH ROW
			BEGIN CASE 
				WHEN NEW.checked_in = 1 THEN 	
				INSERT INTO t_record (passport_number, flight_number, leg_number, date, seat_number)
				VALUES (NEW.passport_number, NEW.flight_number, NEW.leg_number, NEW.date, NEW.seat_number);
				
				WHEN NEW.checked_in = 0 THEN 	
				DELETE FROM t_record WHERE (passport_number = NEW.passport_number) 
                AND (flight_number = NEW.flight_number) AND (leg_number = NEW.leg_number) AND (date = NEW.date) AND (seat_number = NEW.seat_number);
			END CASE;
    END$$
DELIMITER ;

/* İşlem kaydı oluşturulduktan sonra müşterilerin ffp programlarına katılıp ffc sayılabilmesi için uçtukları uçuşun ait olduğu 
şirket bazında toplam millerinin hesaplanması için trigger. */
DELIMITER $$
CREATE TRIGGER trigger_total_mileage_increase
AFTER INSERT
ON airlinedb.t_record FOR EACH ROW
			BEGIN 
            # Uçuşun hangi şirkete ait olduğunu bulur.
            SELECT company_name INTO @company_name FROM flight WHERE flight_number = NEW.flight_number;
           
            # Uçuşun kaç mil olduğunu bulur. 
            SELECT mileage_information INTO @mileage_information FROM flight_leg WHERE flight_number = NEW.flight_number AND leg_number = NEW.leg_number;          

			# Yeni kayıt oluşturuluyorsa insert into ile oluşturulur. Kayıt varsa eski milin üzerine yeni uçuşun mili de eklenir. 
            INSERT INTO total_mileage_tracker(passport_number, company_name, total_mileage)
            VALUES (NEW.passport_number, @company_name, @mileage_information)
            ON DUPLICATE KEY UPDATE total_mileage = total_mileage + @mileage_information;
    END$$
DELIMITER ;

/* T_record kaydı silinirse toplam miller azaltılır. Eğer mil sayısı 0 olursa kayıt total_mileage_tracker tablosundan silinir. 
Şirketin kapanması durumda toplam mil 0 olacağından veri tabanında gereksiz veri saklanmamış olur. */
DELIMITER $$
CREATE TRIGGER trigger_total_mileage_decrease
AFTER DELETE
ON airlinedb.t_record FOR EACH ROW
			BEGIN 
            # Uçuşun hangi şirkete ait olduğunu bulur. Total_mileage_tracker'da pk olduğu için select ile bu veriyi bulmalıyız.
            SELECT company_name INTO @company_name FROM flight WHERE flight_number = OLD.flight_number;
            
			# Uçuşun kaç mil olduğunu bulur. 
            SELECT mileage_information INTO @mileage_information FROM flight_leg WHERE flight_number = OLD.flight_number AND leg_number = OLD.leg_number;          
           
			UPDATE total_mileage_tracker SET total_mileage = total_mileage - @mileage_information WHERE (passport_number = OLD.passport_number) 
            AND (company_name = @company_name);
            
            DELETE FROM total_mileage_tracker WHERE (passport_number = OLD.passport_number) 
            AND (company_name = @company_name) AND total_mileage = 0;
			END$$
DELIMITER ;

# Toplam millere göre müşterilerin ffc konumuna geçirilmesi için total_mileage_tracker tablosuna veri eklendikten sonra çalıştırılan trigger.
DELIMITER $$
CREATE TRIGGER create_ffc
AFTER INSERT
ON airlinedb.total_mileage_tracker FOR EACH ROW
			BEGIN 
				SELECT MAX(Rank_no) INTO @rank_no FROM ffp WHERE (NEW.total_mileage > Minimum_mileage) AND (company_name = NEW.company_name);
                IF @rank_no != 0 THEN INSERT INTO ffc(Passport_number, Company_name, Rank_no)
				VALUES (NEW.passport_number, NEW.company_name, @rank_no)
                ON DUPLICATE KEY UPDATE Rank_no = @rank_no;
                ELSE DELETE FROM ffc WHERE Passport_number = NEW.passport_number AND Company_name = NEW.company_name;
                END IF;
			END$$
DELIMITER ;

# Toplam millere göre müşterilerin ffc konumuna geçirilmesi için total_mileage_tracker tablosunda güncelleme yapıldıktan sonra çalıştırılan trigger.
DELIMITER $$
CREATE TRIGGER create_ffc_update
AFTER UPDATE
ON airlinedb.total_mileage_tracker FOR EACH ROW
			BEGIN 
				SELECT MAX(Rank_no) INTO @rank_no FROM ffp WHERE (NEW.total_mileage > Minimum_mileage) AND (company_name = NEW.company_name);
                # Kayıt eklenmemişse oluşturulur, daha önce kayıt varsa rank_no güncellenir. 
                IF @rank_no != 0 THEN INSERT INTO ffc(Passport_number, Company_name, Rank_no)
				VALUES (NEW.passport_number, NEW.company_name, @rank_no)
                ON DUPLICATE KEY UPDATE Rank_no = @rank_no;
                # Müşterilerin toplam milleri hiçbir programa yetmiyorsa o müşteri ffc kayıtlarından silinir. 
                ELSE DELETE FROM ffc WHERE Passport_number = NEW.passport_number AND Company_name = NEW.company_name;
                END IF;
			END$$
DELIMITER ;

# Uçuşa her check-in yapıldığında müsait koltuk sayısı azaltılır. Eğer check-in geri alınırsa müsait koltuk sayısı da artar.
DELIMITER $$
CREATE TRIGGER decrease_number_of_available_seats
AFTER UPDATE
ON airlinedb.seat_reservation FOR EACH ROW
			BEGIN
				IF (NEW.checked_in = 1) THEN 
				UPDATE leg_instance SET number_of_available_seats = number_of_available_seats - 1
                WHERE flight_number = NEW.flight_number AND leg_number = NEW.leg_number;
			    END IF;
                
                IF (NEW.checked_in = 0) 
                THEN UPDATE leg_instance SET number_of_available_seats = number_of_available_seats + 1
                WHERE flight_number = NEW.flight_number AND leg_number = NEW.leg_number;
                END IF;
           END $$
DELIMITER ;
                
SHOW TRIGGERS;


