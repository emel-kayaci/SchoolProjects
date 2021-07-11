/* 1. Correlated nested query: Mil olarak ortalamadan daha fazla olan uçuşların ait olduğu uçuş ve uçuş ayağı numarasını, millerini ve
 ait oldukları şirket ile havayolunu görüntüler. */
SELECT flight_leg.flight_number, flight_leg.leg_number, flight_leg.mileage_information, flight.company_name, flight.airline_name
FROM flight_leg, flight WHERE mileage_information > 
(SELECT AVG(mileage_information) FROM flight_leg) AND flight_leg.flight_number = flight.flight_number;

/* 2. Inline view: Subquery from içerisinde bulunur. Query: En fazla koltuk rezervasyonu bulunan kişinin pasaport numarası ile ne kadar koltuğa rezerve edilmiş
uçuşu olduğunu görüntüler.*/
SELECT customer.passport_number, number_of_reservations
FROM (SELECT passport_number, COUNT(*) as number_of_reservations
FROM seat_reservation 
GROUP BY passport_number) as total_number_per_customer, customer
WHERE customer.passport_number = total_number_per_customer.passport_number
ORDER BY number_of_reservations DESC
LIMIT 1;

# 3. Belirtilen havaalanına inebilen uçak tiplerini dikkate alarak hangi şirkete ait hangi uçağın inebileceğini gösteriniz
SELECT *  FROM airplane
WHERE airplane_type_name IN (SELECT airplane_type_name from can_land WHERE airport_code = "ADB");

# 4. Maksimum sayıda uçuşun indiği havaalanı hakkındaki tüm bilgileri görüntüleyiniz. 
SELECT *
FROM airport 
WHERE airport_code IN (SELECT flight_leg.arrival_airport_code 
FROM flight_leg 
GROUP BY flight_leg.arrival_airport_code  
HAVING COUNT(*)=(SELECT MAX(number_of_flights) 
                 FROM (SELECT COUNT(*) number_of_flights
                       FROM flight_leg 
                       GROUP BY flight_leg.arrival_airport_code) as total_number_of_flights));