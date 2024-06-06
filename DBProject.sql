-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: MyFitnessApp
-- ------------------------------------------------------
-- Server version	8.0.34

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `activities`
--

DROP TABLE IF EXISTS `activities`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `activities` (
  `ID_Activity` int NOT NULL auto_increment,
  `Name_Activity` varchar(255) NOT NULL,
  `Intensity` varchar(50) NOT NULL,
  `Skill_Level` varchar(50) NOT NULL,
  `Max_Participants` int NOT NULL,
  PRIMARY KEY (`ID_Activity`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `activities`
--

LOCK TABLES `activities` WRITE;
/*!40000 ALTER TABLE `activities` DISABLE KEYS */;
INSERT INTO `activities` 
VALUES (1,'Cardio','High','Intermediate',20),
(2,'Strength','Medium','Advanced',15),
(3,'Yoga','Low','Beginner',25),
(4,'HIIT','Very High','Intermediate',18),
(5,'Dance','High','Advanced',30),
(6,'Pilates','Medium','Beginner',12);
/*!40000 ALTER TABLE `activities` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registered_users`
--

DROP TABLE IF EXISTS `registered_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registered_users` (
  `User_ID` int NOT NULL auto_increment,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `First_Name` varchar(50) NOT NULL,
  `Last_Name` varchar(50) NOT NULL,
  PRIMARY KEY (`User_ID`),
  UNIQUE KEY `Username` (`Username`),
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registered_users`
--

LOCK TABLES `registered_users` WRITE;
/*!40000 ALTER TABLE `registered_users` DISABLE KEYS */;
INSERT INTO `registered_users` VALUES 
(1,'petrov','cGV0cm92MTIz','ivan_petrov@gmail.com','Иван','Петров'),
(2,'ivanovamaria','aXZhbm92YTEyMw==','maria_ivanova@gmail.com','Мария','Иванова'),
(3,'annag','Z2VvcmdpZXZhMTIz','anna_georgieva@gmail.com','Анна','Георгиева'),
(4,'georgidim','ZGltaXRyb3YxMjM=','georgi_dimitrov@gmail.com','Георги','Димитров'),
(5,'emilly','dG9kb3JvdmExMjM=','emilly_todorova@gmail.com','Емили','Тодорова'),
(6,'mihailangelov','YW5nZWxvdjEyMw==','mihail_angelov@gmail.com','Михаил','Ангелов');
/*!40000 ALTER TABLE `registered_users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schedule`
--

DROP TABLE IF EXISTS `schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `schedule` (
  `Schedule_ID` int NOT NULL auto_increment,
  `Day_of_Week` varchar(20) NOT NULL,
  `Start_Time` time NOT NULL,
  `Duration` int NOT NULL,
  `Trainer_ID` int NOT NULL,
  `Activity_ID` int NOT NULL,
  `Room` varchar(50) NOT NULL,
  `Price` int NOT NULL,
  PRIMARY KEY (`Schedule_ID`),
  KEY `schedule_ibfk_1` (`Trainer_ID`),
  KEY `schedule_ibfk_2` (`Activity_ID`),
  CONSTRAINT `schedule_ibfk_1` FOREIGN KEY (`Trainer_ID`) REFERENCES `trainers` (`Trainer_ID`),
  CONSTRAINT `schedule_ibfk_2` FOREIGN KEY (`Activity_ID`) REFERENCES `activities` (`ID_Activity`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schedule`
--

LOCK TABLES `schedule` WRITE;
/*!40000 ALTER TABLE `schedule` DISABLE KEYS */;
INSERT INTO `schedule` 
VALUES (1,'Monday','08:00:00',60,1,1,'Hall 1',10),
(2,'Tuesday','18:00:00',45,2,2,'Hall 5',15),
(3,'Wednesday','12:00:00',30,3,3,'Hall 3',8),
(4,'Thursday','07:30:00',60,4,4,'Hall 5',12),
(5,'Friday','16:00:00',75,5,5,'Hall 2',18),
(6,'Saturday','10:30:00',45,6,6,'Hall 4',20),
(7,'Monday','14:40:00',50,2,1,'Hall 5',10);
/*!40000 ALTER TABLE `schedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trainers`
--

DROP TABLE IF EXISTS `trainers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trainers` (
  `Trainer_ID` int NOT NULL auto_increment,
  `Trainer_Name` varchar(255) NOT NULL,
  `Age` int NOT NULL,
  `Years_Experience` int NOT NULL,
  `Phone_Number` varchar(20) NOT NULL,
  `Specialization` varchar(255) NOT NULL,
  PRIMARY KEY (`Trainer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trainers`
--

LOCK TABLES `trainers` WRITE;
/*!40000 ALTER TABLE `trainers` DISABLE KEYS */;
INSERT INTO `trainers` 
VALUES (1,'Ivan Petrov',30,5,'089-123-4567','Cardio'),
(2,'Maria Ivanova',28,3,'089-987-6543','Strength'),
(3,'Anna Georgieva',35,8,'087-555-1234','Yoga'),
(4,'Georgi Dimitrov',40,10,'088-333-5555','HIIT'),
(5,'Emili Todorova',32,6,'088-444-8888','Dance'),
(6,'Mihail Angelov',45,12,'087-111-2222','Pilates');
/*!40000 ALTER TABLE `trainers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workout_videos`
--

DROP TABLE IF EXISTS `workout_videos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `workout_videos` (
  `Video_ID` int NOT NULL auto_increment,
  `Trainer_ID` int NOT NULL,
  `Video_Title` varchar(255) NOT NULL,
  `Video_URL` varchar(255) NOT NULL,
  PRIMARY KEY (`Video_ID`),
  KEY `workout_videos_ibfk_1` (`Trainer_ID`),
  CONSTRAINT `workout_videos_ibfk_1` FOREIGN KEY (`Trainer_ID`) REFERENCES `trainers` (`Trainer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workout_videos`
--

LOCK TABLES `workout_videos` WRITE;
/*!40000 ALTER TABLE `workout_videos` DISABLE KEYS */;
INSERT INTO `workout_videos` 
VALUES (1,1,'Cardio explosion','https://www.youtube.com/cardio_explosion'),
(2,2,'Basics of strength workout','https://www.youtube.com/strength_training_basics'),
(3,3,'Yoga for beginners','https://www.youtube.com/yoga_beginners'),
(4,4,'HIIT Intense','https://www.youtube.com/hiit_intense'),
(5,5,'Dance for advanced','https://www.youtube.com/dance_advanced'),
(6,6,'Pilates exercises','https://www.youtube.com/pilates_exercises');
/*!40000 ALTER TABLE `workout_videos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workouts_registrations`
--

DROP TABLE IF EXISTS `workouts_registrations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `workouts_registrations` (
  `Workout_ID` int NOT NULL auto_increment,
  `User_ID` int NOT NULL,
  `Trainer_ID` int NOT NULL,
  `Activity_ID` int NOT NULL,
  `Workout_Hour` TIME NOT NULL,
  `Workout_Day` varchar(20) NOT NULL,
  `Duration` int NOT NULL,
  PRIMARY KEY (`Workout_ID`),
  KEY `workouts_registrations_ibfk_1` (`User_ID`),
  KEY `workouts_registrations_ibfk_2` (`Trainer_ID`),
  KEY `workouts_registrations_ibfk_3` (`Activity_ID`),
  CONSTRAINT `workouts_registrations_ibfk_1` FOREIGN KEY (`User_ID`) REFERENCES `registered_users` (`User_ID`),
  CONSTRAINT `workouts_registrations_ibfk_2` FOREIGN KEY (`Trainer_ID`) REFERENCES `trainers` (`Trainer_ID`),
  CONSTRAINT `workouts_registrations_ibfk_3` FOREIGN KEY (`Activity_ID`) REFERENCES `activities` (`ID_Activity`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workouts`
--

LOCK TABLES `workouts_registrations` WRITE;
/*!40000 ALTER TABLE `workouts_registrations` DISABLE KEYS */;
INSERT INTO `workouts_registrations` 
VALUES (1,1,1,1,'08:00:00','Monday',60),
(2,2,2,2,'18:00:00','Tuesday',45),
(3,3,3,3,'12:00:00','Wednesday',30),
(4,4,4,4,'07:30:00','Thursday',60),
(5,5,5,5,'16:00:00','Friday',75),
(6,6,6,6,'10:30:00','Saturday',45);
/*!40000 ALTER TABLE `workouts_registrations` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-12-01 20:08:18
