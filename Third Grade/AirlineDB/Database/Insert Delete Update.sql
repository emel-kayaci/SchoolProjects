# Birden fazla kaydın aynı tabloya ekler.
INSERT INTO airlinedb.customer (`passport_number`, `name`, `phone`, `mail`, `address`, `country`)
VALUES ('374829384', 'Ørjan Larsen', '+47-595-5531-6', 'larsen_aoe@gmail.com', 'Janickeringen 7 2997 Mosjøen', 'NO'),
('593719328', 'Ellie Williams', '+1-202-555-0107', 'ellie_15_williams@hotmail.com', '86 Bohemia Street, Naples, FL 34116', 'USA');

INSERT INTO airlinedb.airport (`airport_code`, `name`, `city`, `state`) 
VALUES ('BRU', 'Brussels Airport', 'Brussel', 'BE');

INSERT INTO airlinedb.flight (`flight_number`, `company_name`, `airline_name`, `weekdays`) 
VALUES ('34921', 'Oneworld', 'British Airways', '1111111');

INSERT INTO airlinedb.flight_leg (`flight_number`, `leg_number`, `mileage_information`, 
`departure_airport_code`, `scheduled_departure_time`, `arrival_airport_code`, `scheduled_arrival_time`) 
VALUES ('34921', '1', '1660', 'BRU', '13:00', 'IST', '18:20');

INSERT INTO airlinedb.leg_instance (`flight_number`, `leg_number`, `date`, `number_of_available_seats`, 
`departure_airport_code`, `departure_time`, `arrival_airport_code`, `arrival_time`) 
VALUES ('34921', '1', '2021.31.01', '300', 'BRU', '13:30', 'IST', '19:00');

# Alfabetik olarak müşterilerin isimlerini sıralayarak ilk üç kaydı siler. 
DELETE FROM airlinedb.customer
ORDER BY airlinedb.customer.name
LIMIT 3;

# WHERE ile herhangi bir koşul eklenmezse belirtilen tablodaki tüm kayıtları siler. 
DELETE FROM airlinedb.fare WHERE (`flight_number` = '20972') and (`fare_code` = 'J');

DELETE FROM airlinedb.leg_instance WHERE (`flight_number` = '27361') and (`leg_number` = '3') and (`date` = '2020-05-23');

DELETE FROM airlinedb.ffc WHERE (`passport_number` = '293842') and (`company_name` = 'Star Alliance') and (`program_name` = 'Elite');

DELETE FROM airlinedb.airport WHERE (`airport_code` = 'CDG');

UPDATE airlinedb.customer SET `address` = 'Kazımdirik, 367/7 Sokak No: 14, 35100 Bornova/İzmir' WHERE (`passport_number` = '293402194');

UPDATE airlinedb.fare SET `amount` = '130' WHERE (`flight_number` = '27361') and (`fare_code` = 'CH');

UPDATE airlinedb.seat_reservation SET `seat_number` = '22'
WHERE (`flight_number` = '21930') and (`leg_number` = '1') and (`date` = '2021-01-30') and (`seat_number` = '30') and (`passport_number` = '293842');

UPDATE airlinedb.airplane SET `total_number_of_seats` = '80' WHERE (`airplane_id` = 'VC-25') and (`company_name` = 'Boeing');

UPDATE airlinedb.ffp SET `information` = '70000' WHERE (`company_name` = 'Oneworld') and (`program_name` = 'Emerald');
