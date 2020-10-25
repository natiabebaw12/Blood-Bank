-- MySqlBackup.NET 2.3.3
-- Dump Time: 2020-10-25 13:51:45
-- --------------------------------------
-- Server version 8.0.18 MySQL Community Server - GPL


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of blood_detail
-- 

DROP TABLE IF EXISTS `blood_detail`;
CREATE TABLE IF NOT EXISTS `blood_detail` (
  `idblood_detail` int(11) NOT NULL,
  `abo_group` varchar(3) DEFAULT NULL,
  `no_of_donation` int(11) DEFAULT NULL,
  `no_of_requisition` int(11) DEFAULT NULL,
  PRIMARY KEY (`idblood_detail`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table blood_detail
-- 

/*!40000 ALTER TABLE `blood_detail` DISABLE KEYS */;
INSERT INTO `blood_detail`(`idblood_detail`,`abo_group`,`no_of_donation`,`no_of_requisition`) VALUES
(1,'A',0,1),
(2,'B',0,1),
(3,'AB',1,0),
(4,'O',0,0);
/*!40000 ALTER TABLE `blood_detail` ENABLE KEYS */;

-- 
-- Definition of donor
-- 

DROP TABLE IF EXISTS `donor`;
CREATE TABLE IF NOT EXISTS `donor` (
  `donor_id` int(50) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(30) DEFAULT NULL,
  `last_name` varchar(30) DEFAULT NULL,
  `sex` varchar(10) DEFAULT NULL,
  `dob` varchar(40) DEFAULT NULL,
  `abo_group` varchar(3) DEFAULT NULL,
  `rh` varchar(3) DEFAULT NULL,
  `weight` float DEFAULT NULL,
  `phone_no` varchar(15) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `address` varchar(65) DEFAULT NULL,
  `occupation` varchar(100) DEFAULT NULL,
  `last_time_donation` varchar(40) DEFAULT NULL,
  `date` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`donor_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table donor
-- 

/*!40000 ALTER TABLE `donor` DISABLE KEYS */;
INSERT INTO `donor`(`donor_id`,`first_name`,`last_name`,`sex`,`dob`,`abo_group`,`rh`,`weight`,`phone_no`,`email`,`address`,`occupation`,`last_time_donation`,`date`) VALUES
(1,'Donor1','Donor1','Male','25 Oct 1980','AB','AB+',100,'1111','test','test','Other','11 Aug 2020','25 Oct 2020');
/*!40000 ALTER TABLE `donor` ENABLE KEYS */;

-- 
-- Definition of patient
-- 

DROP TABLE IF EXISTS `patient`;
CREATE TABLE IF NOT EXISTS `patient` (
  `patient_id` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(30) DEFAULT NULL,
  `last_name` varchar(30) DEFAULT NULL,
  `sex` varchar(10) DEFAULT NULL,
  `dob` varchar(30) DEFAULT NULL,
  `weight` int(11) DEFAULT NULL,
  `abo_group` varchar(3) DEFAULT NULL,
  `rh` varchar(3) DEFAULT NULL,
  `hospital_name` varchar(50) DEFAULT NULL,
  `hospital_phone_no` varchar(15) DEFAULT NULL,
  `patient_regd` varchar(40) DEFAULT NULL,
  `doctor_incharge` varchar(30) DEFAULT NULL,
  `previous_transfusion` varchar(4) DEFAULT NULL,
  `blood_unit` varchar(20) DEFAULT NULL,
  `no_of_unit` int(11) DEFAULT NULL,
  `phone_no` varchar(15) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `patient_address` varchar(100) DEFAULT NULL,
  `date` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`patient_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table patient
-- 

/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient`(`patient_id`,`first_name`,`last_name`,`sex`,`dob`,`weight`,`abo_group`,`rh`,`hospital_name`,`hospital_phone_no`,`patient_regd`,`doctor_incharge`,`previous_transfusion`,`blood_unit`,`no_of_unit`,`phone_no`,`email`,`patient_address`,`date`) VALUES
(1,'patient1','pa1','Male','03 Aug 1990',67,'A','A+','hh','2222','123','dr','Yes','Plasma',100,'111','test','test','25 Oct 2020'),
(2,'patient2','pa2','Female','25 Oct 1993',57,'B','B+','hh','2222','123','dr','Yes','Packed Cells',100,'1111','test','aa','25 Oct 2020');
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2020-10-25 13:51:46
-- Total time: 0:0:0:0:447 (d:h:m:s:ms)
