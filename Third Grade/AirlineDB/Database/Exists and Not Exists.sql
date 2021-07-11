# Herhangi bir koltuk rezervasyon kaydı bulunmayan müşterilerin tüm bilgilerinin görüntülenmesi
SELECT *
FROM customer
WHERE NOT EXISTS (SELECT passport_number
FROM seat_reservation
WHERE customer.passport_number = seat_reservation.passport_number);

# Birden fazla reservasyon kaydı bulunan müşterilerin tüm bilgilerinin görüntülenmesi
SELECT *
FROM customer
WHERE
    EXISTS (SELECT COUNT(*) AS number_of_reservations FROM seat_reservation
	WHERE  customer.passport_number = seat_reservation.passport_number
	GROUP BY passport_number     
    HAVING number_of_reservations > 1)
ORDER BY customer.name ASC;