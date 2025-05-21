CREATE DATABASE  IF NOT EXISTS `activity2original` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `activity2original`;
-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: activity2original
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `accounts` (
  `userid` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `pass` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `reset_token` varchar(45) DEFAULT NULL,
  `reset_token_expiry` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`userid`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounts`
--

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
INSERT INTO `accounts` VALUES (1,'Carl','123','carl@gmail.com','',''),(2,'Ernest','987','ernest@gmail.com','',''),(3,'sinogba','12345','sinogba@gmail.com','',''),(4,'Carl Ernest','222','sinogbacarlernest@gmail.com',NULL,NULL),(5,'Wete','qwerty','qwerty@gmail.com',NULL,NULL),(7,'Test','test','test@gmailcom',NULL,NULL);
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `address`
--

DROP TABLE IF EXISTS `address`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `address` (
  `address_id` int NOT NULL AUTO_INCREMENT,
  `address_city` varchar(45) NOT NULL,
  PRIMARY KEY (`address_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `address`
--

LOCK TABLES `address` WRITE;
/*!40000 ALTER TABLE `address` DISABLE KEYS */;
INSERT INTO `address` VALUES (1,'Legazpi'),(2,'Tabaco'),(3,'Camalig'),(4,'Daraga'),(5,'Ligao'),(6,'St. Domingo'),(7,'Guinobatan'),(8,'Polangui'),(9,'Naga City'),(10,'Masbate City');
/*!40000 ALTER TABLE `address` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `amount`
--

DROP TABLE IF EXISTS `amount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `amount` (
  `amount_id` int NOT NULL AUTO_INCREMENT,
  `amount` double NOT NULL,
  PRIMARY KEY (`amount_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `amount`
--

LOCK TABLES `amount` WRITE;
/*!40000 ALTER TABLE `amount` DISABLE KEYS */;
INSERT INTO `amount` VALUES (1,500),(2,1000),(3,2000),(4,4000),(5,8000),(6,10000),(7,15000),(8,20000),(9,25000),(10,30000);
/*!40000 ALTER TABLE `amount` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `comaker`
--

DROP TABLE IF EXISTS `comaker`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `comaker` (
  `comaker_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(45) NOT NULL,
  `last_name` varchar(45) NOT NULL,
  PRIMARY KEY (`comaker_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comaker`
--

LOCK TABLES `comaker` WRITE;
/*!40000 ALTER TABLE `comaker` DISABLE KEYS */;
INSERT INTO `comaker` VALUES (1,'Natasha','de Guzman'),(2,'Carlos','de Juan'),(3,'Carla','Elliot'),(4,'Ricardo','Estrada'),(5,'Dale','Santos'),(6,'Emilia','Sanchez'),(7,'Sasha','Yap'),(8,'Isabela','Imperial'),(9,'Kim','Lee'),(10,'Mohammed','Ahmed'),(13,'Juan','Dela Cruz');
/*!40000 ALTER TABLE `comaker` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `comaker_update_log`
--

DROP TABLE IF EXISTS `comaker_update_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `comaker_update_log` (
  `log_id` int NOT NULL AUTO_INCREMENT,
  `comaker_id` int DEFAULT NULL,
  `old_first_name` varchar(45) DEFAULT NULL,
  `old_last_name` varchar(45) DEFAULT NULL,
  `new_first_name` varchar(45) DEFAULT NULL,
  `new_last_name` varchar(45) DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`log_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comaker_update_log`
--

LOCK TABLES `comaker_update_log` WRITE;
/*!40000 ALTER TABLE `comaker_update_log` DISABLE KEYS */;
INSERT INTO `comaker_update_log` VALUES (1,10,'Jamal','Bryan','Jamal','Ahmed','2025-03-23 10:23:04'),(2,10,'Jamal','Ahmed','Mohammed','Ahmed','2025-03-23 10:44:44');
/*!40000 ALTER TABLE `comaker_update_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `customer_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(45) NOT NULL,
  `last_name` varchar(45) NOT NULL,
  `contact_number` varchar(45) NOT NULL,
  `address_id` int NOT NULL,
  PRIMARY KEY (`customer_id`),
  KEY `fk_address_id_idx` (`address_id`),
  CONSTRAINT `fk_address_id` FOREIGN KEY (`address_id`) REFERENCES `address` (`address_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'Jose','de Guzman','09989856523',1),(2,'Juan','dela Cruz','09956323522',3),(3,'Cristina','Santiago','09556485231',5),(4,'John','Rejuso','09475236845',4),(5,'Jesus','Emmanuel','09135846752',2),(6,'Michael','Davis','09756847532',10),(7,'David','Cage','09366986547',8),(8,'Matthew','Abraham','09474474123',6),(9,'Luke','Legazpi','09585750321',9),(10,'Chino','Sid','09547132586',7);
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_archive`
--

DROP TABLE IF EXISTS `customer_archive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer_archive` (
  `customer_id` int DEFAULT NULL,
  `first_name` varchar(45) DEFAULT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  `contact_number` varchar(45) DEFAULT NULL,
  `address_id` int DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_archive`
--

LOCK TABLES `customer_archive` WRITE;
/*!40000 ALTER TABLE `customer_archive` DISABLE KEYS */;
INSERT INTO `customer_archive` VALUES (11,'Dave','Sacramento','2023323625',4,'2025-03-23 10:19:50'),(11,'Harry','Harrison','03632533',1,'2025-03-23 10:46:20');
/*!40000 ALTER TABLE `customer_archive` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `customer_info`
--

DROP TABLE IF EXISTS `customer_info`;
/*!50001 DROP VIEW IF EXISTS `customer_info`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `customer_info` AS SELECT 
 1 AS `id`,
 1 AS `full_name`,
 1 AS `comaker_name`,
 1 AS `address`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `customer_log`
--

DROP TABLE IF EXISTS `customer_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer_log` (
  `log_id` int NOT NULL AUTO_INCREMENT,
  `customer_id` int DEFAULT NULL,
  `first_name` varchar(45) DEFAULT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`log_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_log`
--

LOCK TABLES `customer_log` WRITE;
/*!40000 ALTER TABLE `customer_log` DISABLE KEYS */;
INSERT INTO `customer_log` VALUES (1,11,'Dave','Sacramento','2025-03-23 10:18:22'),(2,11,'Harry','Harrison','2025-03-23 10:45:47');
/*!40000 ALTER TABLE `customer_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department_branch`
--

DROP TABLE IF EXISTS `department_branch`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department_branch` (
  `department_branch_id` int NOT NULL AUTO_INCREMENT,
  `location` varchar(45) NOT NULL,
  PRIMARY KEY (`department_branch_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department_branch`
--

LOCK TABLES `department_branch` WRITE;
/*!40000 ALTER TABLE `department_branch` DISABLE KEYS */;
INSERT INTO `department_branch` VALUES (1,'Legazpi'),(2,'Tabaco'),(3,'Sorsogon'),(4,'Ligao'),(5,'Daraga'),(6,'Camalig'),(7,'Tagaytay'),(8,'Laguna'),(9,'Bulacan'),(10,'Naga');
/*!40000 ALTER TABLE `department_branch` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `employee_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(45) NOT NULL,
  `last_name` varchar(45) NOT NULL,
  `department_branch_id` int NOT NULL,
  PRIMARY KEY (`employee_id`),
  KEY `fk_department_branch_id_idx` (`department_branch_id`),
  CONSTRAINT `fk_department_branch_id` FOREIGN KEY (`department_branch_id`) REFERENCES `department_branch` (`department_branch_id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'Maria','Gonzalez',1),(2,'Charles','Manuel',2),(3,'Bob','Cruz',1),(4,'Chico','Tabagero',6),(5,'Teresa','san Miguel',3),(6,'Harry','Noli',4),(7,'Eli','Reyes',8),(8,'Lee','Tian',9),(9,'Arnold','Bong',7),(10,'Carlos','Santos',10),(19,'Carl','Sinogba',8);
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `employee_receipt_count`
--

DROP TABLE IF EXISTS `employee_receipt_count`;
/*!50001 DROP VIEW IF EXISTS `employee_receipt_count`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `employee_receipt_count` AS SELECT 
 1 AS `employee_id`,
 1 AS `employee_name`,
 1 AS `receipt_count`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `receipt`
--

DROP TABLE IF EXISTS `receipt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `receipt` (
  `receipt_id` int NOT NULL AUTO_INCREMENT,
  `customer_id` int NOT NULL,
  `comaker_id` int NOT NULL,
  `employee_id` int NOT NULL,
  `amount_id` int NOT NULL,
  PRIMARY KEY (`receipt_id`),
  KEY `fk_customer_id_idx` (`customer_id`),
  KEY `fk_comaker_id_idx` (`comaker_id`),
  KEY `fk_employee_id_idx` (`employee_id`) /*!80000 INVISIBLE */,
  KEY `fk_amount_id_idx` (`amount_id`) /*!80000 INVISIBLE */,
  CONSTRAINT `fk_amount_id` FOREIGN KEY (`amount_id`) REFERENCES `amount` (`amount_id`),
  CONSTRAINT `fk_comaker_id` FOREIGN KEY (`comaker_id`) REFERENCES `comaker` (`comaker_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_customer_id` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_employee_id` FOREIGN KEY (`employee_id`) REFERENCES `employee` (`employee_id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receipt`
--

LOCK TABLES `receipt` WRITE;
/*!40000 ALTER TABLE `receipt` DISABLE KEYS */;
INSERT INTO `receipt` VALUES (1,1,1,1,1),(2,2,2,3,2),(3,3,6,7,3),(4,4,4,9,4),(5,5,5,5,5),(6,6,3,8,6),(7,7,7,4,7),(8,8,8,2,8),(9,9,9,3,9),(10,10,10,6,10);
/*!40000 ALTER TABLE `receipt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `receipt_info`
--

DROP TABLE IF EXISTS `receipt_info`;
/*!50001 DROP VIEW IF EXISTS `receipt_info`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `receipt_info` AS SELECT 
 1 AS `receipt_id`,
 1 AS `customer`,
 1 AS `comaker`,
 1 AS `employee`,
 1 AS `amount`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `receipt_summary`
--

DROP TABLE IF EXISTS `receipt_summary`;
/*!50001 DROP VIEW IF EXISTS `receipt_summary`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `receipt_summary` AS SELECT 
 1 AS `receipt_id`,
 1 AS `customer_name`,
 1 AS `comaker_name`,
 1 AS `amount`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `show_customer_comaker`
--

DROP TABLE IF EXISTS `show_customer_comaker`;
/*!50001 DROP VIEW IF EXISTS `show_customer_comaker`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `show_customer_comaker` AS SELECT 
 1 AS `receipt_id`,
 1 AS `customer_comaker`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `unique_customer_addresses`
--

DROP TABLE IF EXISTS `unique_customer_addresses`;
/*!50001 DROP VIEW IF EXISTS `unique_customer_addresses`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `unique_customer_addresses` AS SELECT 
 1 AS `address_city`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `customer_info`
--

/*!50001 DROP VIEW IF EXISTS `customer_info`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `customer_info` AS select `cu`.`customer_id` AS `id`,concat(`cu`.`first_name`,' ',`cu`.`last_name`) AS `full_name`,concat(`co`.`first_name`,' ',`co`.`last_name`) AS `comaker_name`,`a`.`address_city` AS `address` from (((`customer` `cu` join `receipt` `r` on((`cu`.`customer_id` = `r`.`customer_id`))) join `comaker` `co` on((`r`.`comaker_id` = `co`.`comaker_id`))) join `address` `a` on((`cu`.`address_id` = `a`.`address_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `employee_receipt_count`
--

/*!50001 DROP VIEW IF EXISTS `employee_receipt_count`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `employee_receipt_count` AS select `e`.`employee_id` AS `employee_id`,concat(`e`.`first_name`,' ',`e`.`last_name`) AS `employee_name`,count(`r`.`receipt_id`) AS `receipt_count` from (`employee` `e` join `receipt` `r` on((`e`.`employee_id` = `r`.`employee_id`))) group by `e`.`employee_id`,`employee_name` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `receipt_info`
--

/*!50001 DROP VIEW IF EXISTS `receipt_info`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `receipt_info` AS select `r`.`receipt_id` AS `receipt_id`,concat(`c`.`first_name`,' ',`c`.`last_name`) AS `customer`,concat(`co`.`first_name`,' ',`co`.`last_name`) AS `comaker`,concat(`e`.`first_name`,' ',`e`.`last_name`) AS `employee`,`a`.`amount` AS `amount` from ((((`receipt` `r` join `customer` `c` on((`r`.`customer_id` = `c`.`customer_id`))) join `comaker` `co` on((`r`.`comaker_id` = `co`.`comaker_id`))) join `employee` `e` on((`r`.`employee_id` = `e`.`employee_id`))) join `amount` `a` on((`r`.`amount_id` = `a`.`amount_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `receipt_summary`
--

/*!50001 DROP VIEW IF EXISTS `receipt_summary`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `receipt_summary` AS select distinct `r`.`receipt_id` AS `receipt_id`,concat(`cu`.`first_name`,' ',`cu`.`last_name`) AS `customer_name`,concat(`co`.`first_name`,' ',`co`.`last_name`) AS `comaker_name`,`a`.`amount` AS `amount` from (((`receipt` `r` join `customer` `cu` on((`r`.`customer_id` = `cu`.`customer_id`))) join `comaker` `co` on((`r`.`comaker_id` = `co`.`comaker_id`))) join `amount` `a` on((`r`.`amount_id` = `a`.`amount_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `show_customer_comaker`
--

/*!50001 DROP VIEW IF EXISTS `show_customer_comaker`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `show_customer_comaker` AS select `receipt`.`customer_id` AS `receipt_id`,`GET_CUSTOMER_COMAKER`(`receipt`.`customer_id`) AS `customer_comaker` from `receipt` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `unique_customer_addresses`
--

/*!50001 DROP VIEW IF EXISTS `unique_customer_addresses`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `unique_customer_addresses` AS select distinct `a`.`address_city` AS `address_city` from (`address` `a` join `customer` `cu` on((`cu`.`address_id` = `a`.`address_id`))) */;
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

-- Dump completed on 2025-05-21 17:43:02
