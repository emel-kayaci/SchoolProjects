-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: airlinedb
-- ------------------------------------------------------
-- Server version	8.0.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `airline`
--

DROP TABLE IF EXISTS `airline`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `airline` (
  `company_name` varchar(100) NOT NULL,
  `airline_name` varchar(100) NOT NULL,
  PRIMARY KEY (`company_name`,`airline_name`),
  CONSTRAINT `FK_airline_company_name` FOREIGN KEY (`company_name`) REFERENCES `company` (`company_name`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `airline`
--

LOCK TABLES `airline` WRITE;
/*!40000 ALTER TABLE `airline` DISABLE KEYS */;
INSERT INTO `airline` VALUES ('Oneworld','American Airlines'),('Oneworld','British Airways'),('SkyTeam','Aeroflot'),('SkyTeam','China Airlines'),('Star Alliance','Air Canada'),('Star Alliance','Lufthansa'),('Star Alliance','Swiss International Air Lines'),('Star Alliance','Turkish Airlines');
/*!40000 ALTER TABLE `airline` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `airplane`
--

DROP TABLE IF EXISTS `airplane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `airplane` (
  `company_name` varchar(100) NOT NULL,
  `airplane_id` varchar(50) NOT NULL,
  `total_number_of_seats` int DEFAULT NULL,
  `airplane_type_name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`airplane_id`,`company_name`),
  KEY `FK_airplane` (`company_name`),
  KEY `fk_airplane_type_name` (`airplane_type_name`),
  CONSTRAINT `FK_airplane` FOREIGN KEY (`company_name`) REFERENCES `company` (`company_name`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_airplane_airplane_type_name` FOREIGN KEY (`airplane_type_name`) REFERENCES `airplane_type` (`airplane_type_name`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `airplane`
--

LOCK TABLES `airplane` WRITE;
/*!40000 ALTER TABLE `airplane` DISABLE KEYS */;
INSERT INTO `airplane` VALUES ('Boeing','727-100',106,'Civil'),('Boeing','737-8 MAX',210,'Civil'),('Boeing','747 Dreamlifter',2,'Cargo'),('Boeing','777-200ER',400,'Civil'),('Boeing','787-3',330,'Civil'),('Boeing','787-9',290,'Civil'),('Airbus','A300-600ST Beluga',2,'Cargo'),('Airbus','A310 MRTT',214,'Military'),('Airbus','A320 PAX',4,'Cargo'),('Airbus','A330 MRRT',380,'Military'),('Airbus','A330-200',293,'Civil'),('Airbus','A330-300',335,'Civil'),('Airbus','A340-200',239,'Civil'),('Airbus','A350-800',312,'Civil'),('Airbus','A380F',3,'Cargo'),('Airbus','A400M Atlas',144,'Military'),('Boeing','C-32',45,'Military'),('Boeing','VC-25',76,'Military');
/*!40000 ALTER TABLE `airplane` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `airplane_type`
--

DROP TABLE IF EXISTS `airplane_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `airplane_type` (
  `airplane_type_name` varchar(50) NOT NULL,
  `max_seats` int DEFAULT NULL,
  PRIMARY KEY (`airplane_type_name`),
  CONSTRAINT `airplane_type_chk_1` CHECK ((`max_seats` <= 800))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `airplane_type`
--

LOCK TABLES `airplane_type` WRITE;
/*!40000 ALTER TABLE `airplane_type` DISABLE KEYS */;
INSERT INTO `airplane_type` VALUES ('Cargo',10),('Civil',800),('Military',400);
/*!40000 ALTER TABLE `airplane_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `airport`
--

DROP TABLE IF EXISTS `airport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `airport` (
  `airport_code` varchar(3) NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `city` varchar(100) DEFAULT NULL,
  `state` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`airport_code`),
  CONSTRAINT `airport_chk_1` CHECK ((char_length(`airport_code`) = 3))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `airport`
--

LOCK TABLES `airport` WRITE;
/*!40000 ALTER TABLE `airport` DISABLE KEYS */;
INSERT INTO `airport` VALUES ('ADB','Adnan Menderes Airport','Izmir','TR'),('AMS','Amsterdam Schiphol Airport','Amsterdam','NL'),('CDG','Paris Charles de Gaulle Airport','Paris','FR'),('IST','Istanbul Airport','Istanbul','TR'),('JFK','John F. Kennedy International Airport','New York','USA'),('LAX','Los Angeles International Airport','Los Angeles','USA'),('LHR','London Heathrow Airport','London','UK'),('PEK','Beijing Capital International Airport','Beijing','CN'),('SAW','Sabiha Gökçen International Airport','Istanbul','TR'),('SFO','San Francisco International Airport','San Francisco','USA'),('SVO','Moscow Sheremetyevo International Airport','Moscow','RU'),('YYZ','Toronto Pearson International Airport','Toronto','CA'),('ZRH','Zurich International Airport','Zurich ','CH');
/*!40000 ALTER TABLE `airport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `can_land`
--

DROP TABLE IF EXISTS `can_land`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `can_land` (
  `airplane_type_name` varchar(50) NOT NULL,
  `airport_code` varchar(3) NOT NULL,
  PRIMARY KEY (`airplane_type_name`,`airport_code`),
  KEY `FK_airport_code` (`airport_code`),
  CONSTRAINT `FK_airport_code` FOREIGN KEY (`airport_code`) REFERENCES `airport` (`airport_code`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_can_land_airplane_type_name` FOREIGN KEY (`airplane_type_name`) REFERENCES `airplane_type` (`airplane_type_name`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `can_land`
--

LOCK TABLES `can_land` WRITE;
/*!40000 ALTER TABLE `can_land` DISABLE KEYS */;
INSERT INTO `can_land` VALUES ('Cargo','ADB'),('Civil','ADB'),('Civil','AMS'),('Cargo','CDG'),('Civil','CDG'),('Cargo','IST'),('Civil','IST'),('Military','IST'),('Cargo','JFK'),('Civil','JFK'),('Military','JFK'),('Cargo','LAX'),('Civil','LAX'),('Military','LAX'),('Civil','LHR'),('Civil','SFO'),('Military','SFO'),('Cargo','SVO'),('Civil','SVO'),('Military','SVO'),('Civil','YYZ');
/*!40000 ALTER TABLE `can_land` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `company`
--

DROP TABLE IF EXISTS `company`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `company` (
  `company_name` varchar(100) NOT NULL,
  PRIMARY KEY (`company_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `company`
--

LOCK TABLES `company` WRITE;
/*!40000 ALTER TABLE `company` DISABLE KEYS */;
INSERT INTO `company` VALUES ('Airbus'),('Boeing'),('Oneworld'),('SkyTeam'),('Star Alliance');
/*!40000 ALTER TABLE `company` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `passport_number` bigint NOT NULL,
  `name` varchar(80) DEFAULT NULL,
  `phone` varchar(45) DEFAULT NULL,
  `mail` varchar(100) DEFAULT NULL,
  `address` varchar(200) DEFAULT NULL,
  `country` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`passport_number`),
  CONSTRAINT `customer_chk_1` CHECK ((char_length(`passport_number`) <= 20)),
  CONSTRAINT `customer_chk_2` CHECK ((char_length(`passport_number`) <= 11))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (29382,'Alicia Frye','+44 1632 960820','alicia.frye12@gmail.com','9 Doonholm Park, Ayr, KA6 6BH','UK'),(564738,'Ashley Bishop','+44 1632 960323','bishop_ashley@outlook.com','386 Green Lanes, London, N13 5PD ','UK'),(283748322,'Emre Yıldız','+90 533 275 4512','emre_yilmaz@gmail.com','Çınarlı, Ankara Cd. No:15 D:51, 35170 Konak/İzmir','TR'),(293402194,'Ela Yilmaz','+90-545-5587-3890','ela.yilmaz@gmail.com','Sümer, 34146 59/1, Prof. Dr. Turan Güneş Cd., 34025 Zeytinburnu/Istanbul','TR'),(293482173,'Hakan Kara','+90 242 281 5905','hakan.kara10@outlook.com','Kazlıçeşme, Abay Cd. No:56, 34020 Zeytinburnu/İstanbul','TR'),(293847293,'Bjorn de Korte','+31-655-5343-20','bjorn_1994@hotmail.com','Heerhugowaard, Noord-Holland(NH), 1702 LM','NL'),(384927384,'Jack Johnson','+1-202-555-0142','jack.developer@gmail.com','606 W 57th St, New York, NY 10019','USA');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fare`
--

DROP TABLE IF EXISTS `fare`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fare` (
  `flight_number` int NOT NULL,
  `fare_code` varchar(8) NOT NULL,
  `amount` double DEFAULT NULL,
  `restrictions` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`flight_number`,`fare_code`),
  CONSTRAINT `FK_fare` FOREIGN KEY (`flight_number`) REFERENCES `flight` (`flight_number`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fare_chk_1` CHECK ((`amount` >= 0))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fare`
--

LOCK TABLES `fare` WRITE;
/*!40000 ALTER TABLE `fare` DISABLE KEYS */;
INSERT INTO `fare` VALUES (20124,'CH',15,'Child fare'),(20124,'Y',25,'Economy class'),(20972,'F',40,'First class'),(20972,'J',20,'Business class'),(20972,'Y',535,'Economy class'),(21849,'CH',250,'Child fare'),(21849,'F',350,'First class'),(21849,'J',300,'Business class'),(21849,'Y',270,'Economy class'),(21930,'Y',191.39,'Economy class'),(22293,'Y',175,'Economy class'),(23495,'Y',240,'Economy class'),(25384,'Y',400,'Economy class'),(27361,'CH',200,'Child fare'),(27361,'F',300,'First class'),(27361,'J',250,'Business class'),(27361,'Y',230,'Economy class'),(28395,'Y',185,'Economy class'),(29123,'Y',155,'Economy class'),(29364,'Y',400,'Economy class'),(29382,'Y',340,'Economy class'),(29786,'Y',190,'Economy class');
/*!40000 ALTER TABLE `fare` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ffc`
--

DROP TABLE IF EXISTS `ffc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ffc` (
  `Passport_number` bigint NOT NULL,
  `Company_name` varchar(100) NOT NULL,
  `Rank_no` int DEFAULT NULL,
  PRIMARY KEY (`Passport_number`,`Company_name`),
  KEY `fk_ffc` (`Company_name`,`Rank_no`),
  CONSTRAINT `ffc_pass_num` FOREIGN KEY (`Passport_number`) REFERENCES `customer` (`passport_number`),
  CONSTRAINT `fk_ffc` FOREIGN KEY (`Company_name`, `Rank_no`) REFERENCES `ffp` (`Company_name`, `Rank_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ffc`
--

LOCK TABLES `ffc` WRITE;
/*!40000 ALTER TABLE `ffc` DISABLE KEYS */;
INSERT INTO `ffc` VALUES (564738,'Oneworld',1),(29382,'Star Alliance',1),(293847293,'Star Alliance',2);
/*!40000 ALTER TABLE `ffc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ffp`
--

DROP TABLE IF EXISTS `ffp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ffp` (
  `Company_name` varchar(100) NOT NULL,
  `Rank_no` int NOT NULL,
  `Program_name` varchar(50) DEFAULT NULL,
  `Minimum_mileage` decimal(10,2) DEFAULT NULL,
  `Rewards` tinytext,
  PRIMARY KEY (`Company_name`,`Rank_no`),
  CONSTRAINT `fk_ffp` FOREIGN KEY (`Company_name`) REFERENCES `company` (`company_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ffp`
--

LOCK TABLES `ffp` WRITE;
/*!40000 ALTER TABLE `ffp` DISABLE KEYS */;
INSERT INTO `ffp` VALUES ('Oneworld',1,'Ruby',5000.00,'Business Class Priority Check-In, Waitlist Priority'),('Oneworld',2,'Sapphire',50000.00,'Ruby benefits, Access to Business Class lounges, Extra baggage allowance up to 20 kg, Priority Boarding, Priority Baggage Handling'),('Oneworld',3,'Emerald',100000.00,'All previous benefits, Access to First and Business Class lounges, Access to First Class priority check-in, Fast track at select security lanes, Extra baggage allowance up to 30 kg '),('SkyTeam',1,'Elite',30000.00,'Extra baggage allowance up to 20 kg, Priority check-in, Priority baggage drop-off, Priority seating, Priority boarding, Priority airport standby'),('SkyTeam',2,'Elite Plus',90000.00,'All SkyTeam Elite benefits, Extra baggage allowance up to 30 kg, Lounge access, Guaranteed reservations on sold-out flights, SkyPriority recognition, Priority at transfer desks, Priority at immigration and security lanes, Priority baggage handling'),('Star Alliance',1,'Classic',5000.00,'10MB of free WIFI on international Turkish Airlines flights'),('Star Alliance',2,'Classic Plus',10000.00,'Lounge access on Turkish domestic flights, Additional 10kg baggage allowance, 25% more miles on Turkish Airlines business class flights'),('Star Alliance',3,'Elite',50000.00,'Classic Plus benefits, Additional 20kg baggage allowance (instead of 10kg), 50% discount on second paid business class ticket, Free WIFI');
/*!40000 ALTER TABLE `ffp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `first_class`
--

DROP TABLE IF EXISTS `first_class`;
/*!50001 DROP VIEW IF EXISTS `first_class`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `first_class` AS SELECT 
 1 AS `fare_code`,
 1 AS `amount`,
 1 AS `leg_number`,
 1 AS `date`,
 1 AS `no_of_available_seats`,
 1 AS `departure_time`,
 1 AS `arrival_time`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `flight`
--

DROP TABLE IF EXISTS `flight`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `flight` (
  `flight_number` int NOT NULL,
  `company_name` varchar(100) DEFAULT NULL,
  `airline_name` varchar(100) DEFAULT NULL,
  `weekdays` int DEFAULT NULL,
  PRIMARY KEY (`flight_number`),
  KEY `FK_flight` (`company_name`,`airline_name`),
  CONSTRAINT `FK_flight` FOREIGN KEY (`company_name`, `airline_name`) REFERENCES `airline` (`company_name`, `airline_name`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flight`
--

LOCK TABLES `flight` WRITE;
/*!40000 ALTER TABLE `flight` DISABLE KEYS */;
INSERT INTO `flight` VALUES (20124,'Oneworld','British Airways',1111100),(20972,'Star Alliance','Lufthansa',1011101),(21849,'Oneworld','American Airlines',1110110),(21930,'SkyTeam','Aeroflot',1011110),(22293,'Oneworld','British Airways',1101101),(23495,'Star Alliance','Turkish Airlines',1000011),(25384,'Oneworld','American Airlines',1011001),(27361,'Star Alliance','Turkish Airlines',1011111),(28395,'Star Alliance','Lufthansa',1101111),(28693,'Star Alliance','Turkish Airlines',1101111),(29123,'SkyTeam','China Airlines',1111100),(29364,'Star Alliance','Turkish Airlines',1010101),(29382,'Star Alliance','Swiss International Air Lines',1111100),(29786,'Star Alliance','Turkish Airlines',1101111);
/*!40000 ALTER TABLE `flight` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `flight_leg`
--

DROP TABLE IF EXISTS `flight_leg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `flight_leg` (
  `flight_number` int NOT NULL,
  `leg_number` int NOT NULL,
  `mileage_information` decimal(10,2) DEFAULT NULL,
  `departure_airport_code` varchar(3) DEFAULT NULL,
  `scheduled_departure_time` time DEFAULT NULL,
  `arrival_airport_code` varchar(3) DEFAULT NULL,
  `scheduled_arrival_time` time DEFAULT NULL,
  PRIMARY KEY (`flight_number`,`leg_number`),
  KEY `FK_arr_airport_code` (`arrival_airport_code`),
  KEY `FK_dep_airport_code` (`departure_airport_code`),
  CONSTRAINT `FK_arr_airport_code` FOREIGN KEY (`arrival_airport_code`) REFERENCES `airport` (`airport_code`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `FK_dep_airport_code` FOREIGN KEY (`departure_airport_code`) REFERENCES `airport` (`airport_code`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `FK_flight_leg` FOREIGN KEY (`flight_number`) REFERENCES `flight` (`flight_number`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flight_leg`
--

LOCK TABLES `flight_leg` WRITE;
/*!40000 ALTER TABLE `flight_leg` DISABLE KEYS */;
INSERT INTO `flight_leg` VALUES (20124,1,283.40,'LHR','19:00:00','CDG','21:20:00'),(20972,1,5654.00,'CDG','10:15:00','LAX','13:10:00'),(21849,1,2789.40,'JFK','11:10:00','LAX','14:30:00'),(21930,1,2789.40,'LAX','07:10:00','JFK','10:30:00'),(22293,1,1084.00,'ZRH','15:20:00','IST','20:30:00'),(23495,1,2789.40,'JFK','09:00:00','LAX','12:25:00'),(25384,1,5442.57,'LHR','15:30:00','LAX','19:50:00'),(27361,1,1982.60,'ADB','07:20:00','AMS','12:20:00'),(27361,2,316.00,'AMS','20:25:00','CDG','21:45:00'),(27361,3,297.80,'CDG','10:00:00','LHR','10:30:00'),(28395,1,1550.00,'IST','17:00:00','LHR','20:30:00'),(28693,1,1982.60,'AMS','10:20:00','ADB','15:20:00'),(29123,1,1084.00,'ZRH','14:50:00','IST','20:30:00'),(29123,2,1554.00,'IST','08:50:00','LHR','11:00:00'),(29364,1,304.00,'ZRH','07:35:00','CDG','09:00:00'),(29364,2,1379.00,'CDG','13:15:00','IST','18:40:00'),(29364,3,1554.00,'IST','09:50:00','LHR','12:00:00'),(29382,1,1084.00,'ZRH','14:15:00','IST','19:10:00'),(29382,2,1701.00,'IST','21:50:00','CDG','00:50:00'),(29382,3,297.80,'CDG','11:00:00','LHR','11:30:00'),(29786,1,1550.00,'LHR','11:00:00','SAW','14:30:00');
/*!40000 ALTER TABLE `flight_leg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `leg_instance`
--

DROP TABLE IF EXISTS `leg_instance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `leg_instance` (
  `flight_number` int NOT NULL,
  `leg_number` int NOT NULL,
  `date` date NOT NULL,
  `number_of_available_seats` int DEFAULT NULL,
  `departure_airport_code` varchar(3) DEFAULT NULL,
  `departure_time` time DEFAULT NULL,
  `arrival_airport_code` varchar(3) DEFAULT NULL,
  `arrival_time` time DEFAULT NULL,
  PRIMARY KEY (`flight_number`,`leg_number`,`date`),
  KEY `FK_arrival_airport_code` (`arrival_airport_code`),
  KEY `FK_departure_airport_code` (`departure_airport_code`),
  CONSTRAINT `FK_arrival_airport_code` FOREIGN KEY (`arrival_airport_code`) REFERENCES `airport` (`airport_code`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `FK_departure_airport_code` FOREIGN KEY (`departure_airport_code`) REFERENCES `airport` (`airport_code`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `FK_leg_instance` FOREIGN KEY (`flight_number`, `leg_number`) REFERENCES `flight_leg` (`flight_number`, `leg_number`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `leg_instance_chk_1` CHECK ((`date` >= _utf8mb4'1950-01-01')),
  CONSTRAINT `leg_instance_chk_2` CHECK ((`number_of_available_seats` >= 0))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `leg_instance`
--

LOCK TABLES `leg_instance` WRITE;
/*!40000 ALTER TABLE `leg_instance` DISABLE KEYS */;
INSERT INTO `leg_instance` VALUES (20124,1,'2020-05-23',320,'LHR','19:00:00','CDG','21:40:00'),(20972,1,'2021-01-21',208,'CDG','10:15:00','LAX','13:30:00'),(21930,1,'2021-01-30',0,'LAX','07:30:00','JFK','15:55:00'),(23495,1,'2021-02-01',329,'JFK','09:00:00','LAX','12:30:00'),(25384,1,'2021-10-22',249,'LHR','15:30:00','LAX','20:00:00'),(27361,1,'2020-05-22',298,'ADB','07:20:00','AMS','12:25:00'),(27361,2,'2020-05-22',209,'AMS','20:30:00','CDG','21:50:00'),(27361,3,'2020-05-23',297,'CDG','10:00:00','LHR','10:30:00'),(29123,1,'2020-05-23',318,'ZRH','14:50:00','IST','20:30:00'),(29123,2,'2020-05-24',330,'IST','08:50:00','LHR','11:00:00'),(29364,1,'2021-08-09',340,'ZRH','07:40:00','CDG','09:40:00'),(29364,2,'2021-08-10',300,'CDG','13:15:00','IST','18:45:00'),(29364,3,'2021-08-10',320,'IST','10:00:00','LHR','12:00:00'),(29382,1,'2020-05-23',239,'ZRH','14:30:00','IST','19:10:00'),(29382,2,'2020-05-24',199,'IST','21:50:00','CDG','01:00:00'),(29382,3,'2020-05-25',297,'CDG','11:10:00','LHR','11:50:00');
/*!40000 ALTER TABLE `leg_instance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `military_airport`
--

DROP TABLE IF EXISTS `military_airport`;
/*!50001 DROP VIEW IF EXISTS `military_airport`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `military_airport` AS SELECT 
 1 AS `airport_code`,
 1 AS `name`,
 1 AS `city`,
 1 AS `state`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `reservation_info`
--

DROP TABLE IF EXISTS `reservation_info`;
/*!50001 DROP VIEW IF EXISTS `reservation_info`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `reservation_info` AS SELECT 
 1 AS `name`,
 1 AS `phone`,
 1 AS `flight_number`,
 1 AS `leg_number`,
 1 AS `date`,
 1 AS `seat_number`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `seat_reservation`
--

DROP TABLE IF EXISTS `seat_reservation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `seat_reservation` (
  `flight_number` int NOT NULL,
  `leg_number` int NOT NULL,
  `date` date NOT NULL,
  `seat_number` int NOT NULL,
  `passport_number` bigint NOT NULL,
  `checked_in` tinyint DEFAULT NULL,
  PRIMARY KEY (`flight_number`,`leg_number`,`date`,`seat_number`,`passport_number`),
  KEY `PK_seat_reservation` (`flight_number`,`leg_number`,`date`,`seat_number`,`passport_number`),
  KEY `fk_seat_res_pass_num` (`passport_number`),
  CONSTRAINT `fk_seat_res_pass_num` FOREIGN KEY (`passport_number`) REFERENCES `customer` (`passport_number`),
  CONSTRAINT `FK_seat_reservation` FOREIGN KEY (`flight_number`, `leg_number`, `date`) REFERENCES `leg_instance` (`flight_number`, `leg_number`, `date`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seat_reservation`
--

LOCK TABLES `seat_reservation` WRITE;
/*!40000 ALTER TABLE `seat_reservation` DISABLE KEYS */;
INSERT INTO `seat_reservation` VALUES (20972,1,'2021-01-21',2,293847293,1),(20972,1,'2021-01-21',3,29382,1),(21930,1,'2021-01-30',12,293847293,1),(21930,1,'2021-01-30',18,293482173,1),(21930,1,'2021-01-30',22,564738,1),(21930,1,'2021-01-30',30,29382,1),(23495,1,'2021-02-01',5,293847293,1),(25384,1,'2021-10-22',2,564738,1),(27361,1,'2020-05-22',4,293402194,1),(27361,1,'2020-05-22',11,293847293,1),(27361,2,'2020-05-22',1,293847293,1),(27361,2,'2020-05-22',2,293402194,1),(27361,3,'2020-05-23',19,293402194,1),(27361,3,'2020-05-23',19,293847293,1),(27361,3,'2020-05-23',28,564738,1),(29123,1,'2020-05-23',11,29382,1),(29123,1,'2020-05-23',12,293482173,1),(29382,1,'2020-05-23',1,564738,1),(29382,2,'2020-05-24',11,564738,1),(29382,3,'2020-05-25',22,564738,1);
/*!40000 ALTER TABLE `seat_reservation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `star_alliance`
--

DROP TABLE IF EXISTS `star_alliance`;
/*!50001 DROP VIEW IF EXISTS `star_alliance`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `star_alliance` AS SELECT 
 1 AS `airline_name`,
 1 AS `flight_no`,
 1 AS `weekdays`,
 1 AS `leg_number`,
 1 AS `mileage_information`,
 1 AS `departure_airport_code`,
 1 AS `scheduled_departure_time`,
 1 AS `arrival_airport_code`,
 1 AS `scheduled_arrival_time`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `t_record`
--

DROP TABLE IF EXISTS `t_record`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_record` (
  `record_number` int NOT NULL AUTO_INCREMENT,
  `passport_number` bigint NOT NULL,
  `flight_number` int NOT NULL,
  `leg_number` int NOT NULL,
  `date` date NOT NULL,
  `seat_number` int NOT NULL,
  PRIMARY KEY (`passport_number`,`flight_number`,`leg_number`,`date`,`seat_number`),
  UNIQUE KEY `record_number` (`record_number`),
  KEY `FK_t_record_seat_reservation` (`flight_number`,`leg_number`,`date`,`seat_number`,`passport_number`),
  CONSTRAINT `t_record_pass_num` FOREIGN KEY (`passport_number`) REFERENCES `customer` (`passport_number`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_record`
--

LOCK TABLES `t_record` WRITE;
/*!40000 ALTER TABLE `t_record` DISABLE KEYS */;
INSERT INTO `t_record` VALUES (7,293847293,20972,1,'2021-01-21',2),(8,29382,20972,1,'2021-01-21',3),(9,293847293,21930,1,'2021-01-30',12),(10,293482173,21930,1,'2021-01-30',18),(11,564738,21930,1,'2021-01-30',22),(12,29382,21930,1,'2021-01-30',30),(13,293847293,23495,1,'2021-02-01',5),(14,564738,25384,1,'2021-10-22',2),(15,293402194,27361,1,'2020-05-22',4),(16,293847293,27361,1,'2020-05-22',11),(17,293847293,27361,2,'2020-05-22',1),(18,293402194,27361,2,'2020-05-22',2),(19,293402194,27361,3,'2020-05-23',19),(20,293847293,27361,3,'2020-05-23',19),(21,564738,27361,3,'2020-05-23',28),(22,29382,29123,1,'2020-05-23',11),(23,293482173,29123,1,'2020-05-23',12),(24,564738,29382,1,'2020-05-23',1),(25,564738,29382,2,'2020-05-24',11),(26,564738,29382,3,'2020-05-25',22);
/*!40000 ALTER TABLE `t_record` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `total_mileage_tracker`
--

DROP TABLE IF EXISTS `total_mileage_tracker`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `total_mileage_tracker` (
  `passport_number` bigint NOT NULL,
  `company_name` varchar(100) NOT NULL,
  `total_mileage` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`passport_number`,`company_name`),
  KEY `FK_company_name_total_mil_tracker` (`company_name`),
  CONSTRAINT `FK_company_name_total_mil_tracker` FOREIGN KEY (`company_name`) REFERENCES `company` (`company_name`),
  CONSTRAINT `fk_t_mileage_tracker_pass_num` FOREIGN KEY (`passport_number`) REFERENCES `customer` (`passport_number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `total_mileage_tracker`
--

LOCK TABLES `total_mileage_tracker` WRITE;
/*!40000 ALTER TABLE `total_mileage_tracker` DISABLE KEYS */;
INSERT INTO `total_mileage_tracker` VALUES (29382,'SkyTeam',3873.40),(29382,'Star Alliance',5654.00),(564738,'Oneworld',5442.57),(564738,'SkyTeam',2789.40),(564738,'Star Alliance',3380.60),(293402194,'Star Alliance',2596.40),(293482173,'SkyTeam',3873.40),(293847293,'SkyTeam',2789.40),(293847293,'Star Alliance',11039.80);
/*!40000 ALTER TABLE `total_mileage_tracker` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `usa_airports`
--

DROP TABLE IF EXISTS `usa_airports`;
/*!50001 DROP VIEW IF EXISTS `usa_airports`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `usa_airports` AS SELECT 
 1 AS `name`,
 1 AS `city`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `first_class`
--

/*!50001 DROP VIEW IF EXISTS `first_class`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `first_class` AS select `fare`.`fare_code` AS `fare_code`,`fare`.`amount` AS `amount`,`leg_instance`.`leg_number` AS `leg_number`,`leg_instance`.`date` AS `date`,`leg_instance`.`number_of_available_seats` AS `no_of_available_seats`,`leg_instance`.`departure_time` AS `departure_time`,`leg_instance`.`arrival_time` AS `arrival_time` from (`fare` join `leg_instance` on((`fare`.`flight_number` = `leg_instance`.`flight_number`))) where (`fare`.`restrictions` = 'First class') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `military_airport`
--

/*!50001 DROP VIEW IF EXISTS `military_airport`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `military_airport` AS select `airport`.`airport_code` AS `airport_code`,`airport`.`name` AS `name`,`airport`.`city` AS `city`,`airport`.`state` AS `state` from (`can_land` join `airport` on((`can_land`.`airport_code` = `airport`.`airport_code`))) where (`can_land`.`airplane_type_name` = 'Military') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `reservation_info`
--

/*!50001 DROP VIEW IF EXISTS `reservation_info`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `reservation_info` AS select `customer`.`name` AS `name`,`customer`.`phone` AS `phone`,`seat_reservation`.`flight_number` AS `flight_number`,`seat_reservation`.`leg_number` AS `leg_number`,`seat_reservation`.`date` AS `date`,`seat_reservation`.`seat_number` AS `seat_number` from (`seat_reservation` join `customer` on((`seat_reservation`.`passport_number` = `customer`.`passport_number`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `star_alliance`
--

/*!50001 DROP VIEW IF EXISTS `star_alliance`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `star_alliance` AS select `flight`.`airline_name` AS `airline_name`,`flight`.`flight_number` AS `flight_no`,`flight`.`weekdays` AS `weekdays`,`flight_leg`.`leg_number` AS `leg_number`,`flight_leg`.`mileage_information` AS `mileage_information`,`flight_leg`.`departure_airport_code` AS `departure_airport_code`,`flight_leg`.`scheduled_departure_time` AS `scheduled_departure_time`,`flight_leg`.`arrival_airport_code` AS `arrival_airport_code`,`flight_leg`.`scheduled_arrival_time` AS `scheduled_arrival_time` from (`flight` join `flight_leg` on((`flight`.`flight_number` = `flight_leg`.`flight_number`))) where (`flight`.`company_name` = 'Star Alliance') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `usa_airports`
--

/*!50001 DROP VIEW IF EXISTS `usa_airports`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `usa_airports` AS select `airport`.`name` AS `name`,`airport`.`city` AS `city` from `airport` where (`airport`.`state` = 'USA') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-02-13 14:35:58
