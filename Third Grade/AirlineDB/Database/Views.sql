#Sadece Amerikadaki havaalanlarını listeler
CREATE or REPLACE VIEW USA_airports AS
SELECT name, city
FROM airport
WHERE state= "USA";

#Müşterilerin iletişim ve rezervasyon bilgilerini listeler
CREATE or REPLACE VIEW reservation_info AS
SELECT 
customer.name AS name,
customer.phone AS phone,
seat_reservation.flight_number AS flight_number,
seat_reservation.leg_number AS leg_number,
seat_reservation.date AS date,
seat_reservation.seat_number AS seat_number
FROM seat_reservation INNER JOIN customer ON (seat_reservation.passport_number = customer.passport_number);

# Sadece first class'a ait uçuşların ucret bilgilerini ve ucus bilgilerini listeler
CREATE or REPLACE VIEW first_class AS
SELECT 
fare.fare_code AS fare_code,
fare.amount AS amount,
leg_instance.leg_number AS leg_number,
leg_instance.date AS date,
leg_instance.number_of_available_seats AS no_of_available_seats,
leg_instance.departure_time AS departure_time,
leg_instance.arrival_time AS arrival_time
FROM fare INNER JOIN leg_instance ON (fare.flight_number = leg_instance.flight_number )
WHERE fare.restrictions ="First class";

# Sadece Star Alliance şirketine ait uçuş kayıt bilgilerini listeler
CREATE or REPLACE VIEW star_alliance AS
SELECT
flight.airline_name AS airline_name,
flight.flight_number AS flight_no,
flight.weekdays AS weekdays,
flight_leg.leg_number AS leg_number,
flight_leg.mileage_information AS mileage_information,
flight_leg.departure_airport_code AS departure_airport_code,
flight_leg.scheduled_departure_time AS scheduled_departure_time,
flight_leg.arrival_airport_code AS arrival_airport_code,
flight_leg.scheduled_arrival_time AS scheduled_arrival_time
FROM flight INNER JOIN flight_leg ON (flight.flight_number = flight_leg.flight_number )
WHERE flight.company_name = "Star Alliance";

#Askeri ucaklarin kalkış ve iniş yapabildigi havaalani bilgilerini listeler
CREATE or REPLACE VIEW military_airport AS
SELECT
airport.airport_code AS airport_code,
airport.name AS name,
airport.city AS city,
airport.state AS state
FROM can_land INNER JOIN airport ON (can_land.airport_code = airport.airport_code )
WHERE can_land.airplane_type_name ="Military" ;

