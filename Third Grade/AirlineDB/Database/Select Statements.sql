# USING 2 TABLES

# 1. Ücreti 200'den fazla olan uçuşların ücretlerinin artan sırada gösterilip ayrıca numara, ait olduğu şirket ve havayolu bilgilerini bulunuz.
SELECT amount, flight.flight_number, company_name, airline_name
FROM fare, flight
WHERE fare.flight_number = flight.flight_number 
AND amount > 200
ORDER BY amount ASC;

# 1.1 Yukarıdaki sorgu inner join kullanılarak yazılabilir. 
SELECT amount, flight.flight_number, company_name, airline_name
FROM fare
INNER JOIN flight ON fare.flight_number = flight.flight_number 
WHERE amount > 200
ORDER BY amount ASC;

# 2. Hangi müşterinin hangi uçuşun hangi legine check-in yapmadığını yazdırır.
SELECT CUSTOMER.passport_number, CUSTOMER.name,SEAT_RESERVATION.flight_number, SEAT_RESERVATION.leg_number
FROM CUSTOMER, SEAT_RESERVATION
WHERE CUSTOMER.passport_number = SEAT_RESERVATION.passport_number AND SEAT_RESERVATION.checked_in = 0
ORDER BY passport_number;

# 3. Kalkış ve iniş havaalanı kodları verilen uçuş (rota) kaç uçuş ayağına sahiptir, numarası ve ekonomik bilet ücreti nedir?
SELECT fl1.flight_number, fl1.departure_airport_code, fl3.arrival_airport_code, COUNT(*) number_of_legs, fare.amount
FROM flight_leg fl1
INNER JOIN flight_leg fl2
	ON fl1.flight_number = fl2.flight_number
    AND fl2.departure_airport_code = "ZRH"
INNER JOIN flight_leg fl3
	ON fl1.flight_number = fl3.flight_number
	AND fl3.arrival_airport_code = "LHR"
INNER JOIN fare 
	ON fl1.flight_number = fare.flight_number 
	AND fare.fare_code = "Y"
GROUP BY flight_number;

# 4. Her bir airport için o airporta kaç adet tipte uçak inebilir.
SELECT AIRPORT.airport_code, AIRPORT.name, COUNT(*) AS type_count
FROM AIRPORT, CAN_LAND
WHERE AIRPORT.airport_code = CAN_LAND.airport_code
GROUP BY AIRPORT.airport_code;

# USING 3 TABLES 
# 1. Her bir havaalanına iniş yapabilen uçakların id_numaralarını görüntüler.
SELECT airport.airport_code, airport.name, airplane.airplane_id
FROM airport, can_land, airplane
WHERE airport.airport_code = can_land.airport_code AND can_land.airplane_type_name = airplane.airplane_type_name;

# 2. Her bir airporta iniş yapabilen uçak tiplerini yazdır.
SELECT AIRPORT.airport_code, AIRPORT.name, AIRPLANE_TYPE.airplane_type_name, AIRPLANE_TYPE.max_seats
FROM AIRPLANE_TYPE, CAN_LAND, AIRPORT
WHERE CAN_LAND.airport_code = AIRPORT.airport_code
AND CAN_LAND.airplane_type_name = AIRPLANE_TYPE.airplane_type_name
ORDER BY airport_code;

# 3. Rank'i 2 ve üzeri olan her müşterinin hangi şirketin hangi programında dahil olduğunu yazdırır.
SELECT FFC.passport_number, CUSTOMER.name, FFC.rank_no, FFP.company_name, FFP.program_name
FROM FFC, CUSTOMER, FFP
WHERE FFC.passport_number = CUSTOMER.passport_number AND FFC.company_name = FFP.company_name 
AND FFC.rank_no = FFP.rank_no AND FFC.rank_no >= 2;

# 4. Yalnızca hafta içinde uçan ekonomi ücret kodundaki uçuşların numarası, şirket ve havayolu ismi, ücretleri, toplam uçuş ayağı sayısı nedir?
SELECT flight.flight_number, COUNT(*) total_number_of_legs, company_name, flight.airline_name, fare.fare_code, fare.amount
FROM flight, fare, flight_leg
WHERE SUBSTRING(flight.weekdays, 1, 5) = 11111 AND flight_leg.flight_number = flight.flight_number 
AND fare.flight_number = flight.flight_number AND fare.fare_code = 'Y'
GROUP BY flight_leg.leg_number;

# USING 4 TABLES
# 1. Kalkış havaalanı ile müşterinin yaşadığı ülke aynı olan uçuşların ülkesi, müşterinin ismi, pasaport numarası ve kalkış havaalnı kodu nedir?
SELECT DISTINCT customer.country, customer.name, customer.passport_number, flight_leg.departure_airport_code
FROM customer, seat_reservation, flight_leg, airport
WHERE customer.country = airport.state AND customer.passport_number = seat_reservation.passport_number 
AND seat_reservation.flight_number = flight_leg.flight_number AND flight_leg.departure_airport_code = airport.airport_code
ORDER BY customer.country;

# 2. Ismi verilen müşterinin check-in yaptığı uçuş ve uçuş ayaklarının nosunu, departure ve arrival airport code'unu, airline adını yazdırır. 
SELECT LEG_INSTANCE.departure_airport_code, LEG_INSTANCE.arrival_airport_code, FLIGHT.airline_name, FLIGHT.flight_number,LEG_INSTANCE.leg_number
FROM LEG_INSTANCE, FLIGHT, CUSTOMER, SEAT_RESERVATION
WHERE CUSTOMER.name = 'Bjorn de Korte' AND SEAT_RESERVATION.checked_in = 1
AND CUSTOMER.passport_number = SEAT_RESERVATION.passport_number 
AND SEAT_RESERVATION.flight_number = LEG_INSTANCE.flight_number  AND SEAT_RESERVATION.leg_number = LEG_INSTANCE.leg_number
AND LEG_INSTANCE.flight_number = FLIGHT.flight_number;

# 3. Belirli bir fare tipinde olan uçuşlar için uçuş numaraları ve bu uçuşlara bağlı olan flight_leglerin date ve havalimanı kodlarını yazdırır
SELECT FLIGHT.flight_number, FLIGHT_LEG.leg_number, LEG_INSTANCE.date, FLIGHT.airline_name, FLIGHT_LEG.departure_airport_code, FLIGHT_LEG.arrival_airport_code
FROM FLIGHT, FLIGHT_LEG, FARE, LEG_INSTANCE
WHERE FARE.fare_code = 'Y' AND FLIGHT.flight_number = FARE.flight_number AND FLIGHT.flight_number = FLIGHT_LEG.flight_number
AND FLIGHT_LEG.flight_number = LEG_INSTANCE.flight_number
GROUP BY flight_number, leg_number, date;