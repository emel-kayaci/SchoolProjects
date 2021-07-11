#flight ve flight_leg tablolarini flight'a gore birlestirir, ucusa ait flight_leg bilgisi yoksa -> null
SELECT 
flight.flight_number, flight.company_name, flight.airline_name, flight_leg.leg_number,
flight_leg.mileage_information, flight_leg.departure_airport_code, flight_leg.scheduled_departure_time,
flight_leg.arrival_airport_code, flight_leg.scheduled_arrival_time
FROM flight_leg
RIGHT JOIN flight ON flight.flight_number
 = flight_leg.flight_number;
 
#can_land ve airport tablolarini birlestirilir, tüm uçak tipi bilgileri alinip havaalanları ile eslesme yapilir
SELECT
can_land.airplane_type_name, can_land.airport_code, airport.city, airport.name, airport.state
FROM can_land
LEFT JOIN airport ON can_land.airport_code
 = airport.airport_code;


/*mysql de full outer join olmadigi icin, left join ve right join i birlestirebiliriz.
Birlestirilen iki veya daha fazla tablo için eslesme olsun ya da olmasin,
tablolar birlestirildigi için her tablonun verileri listelenir.
*/
#customer ve seat_reservation tablolarini birlestirme
SELECT * FROM customer
LEFT JOIN seat_reservation ON customer.passport_number = seat_reservation.passport_number
UNION
SELECT * FROM customer
RIGHT JOIN seat_reservation ON customer.passport_number = seat_reservation.passport_number;