ALTER TABLE fare
ADD CHECK (amount >= 0);

ALTER TABLE airplane_type
ADD CHECK (max_seats <= 800);

ALTER TABLE leg_instance
ADD CHECK (date >= '1950-01-01');

ALTER TABLE airport
ADD CHECK (char_length(airport_code) = 3);

ALTER TABLE customer
ADD CHECK (char_length(passport_number) <= 11);

ALTER TABLE leg_instance
ADD CHECK (number_of_available_seats >= 0);


