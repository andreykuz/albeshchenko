CREATE DATABASE  IF NOT EXISTS `pgo` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `pgo`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: pgo
-- ------------------------------------------------------
-- Server version	5.6.14

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `directory_doc_type`
--

DROP TABLE IF EXISTS `directory_doc_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_doc_type` (
  `doc_type` varchar(50) NOT NULL,
  `id_doc_type` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_doc_type`),
  UNIQUE KEY `doc_type_UNIQUE` (`doc_type`),
  UNIQUE KEY `id_doc_type_UNIQUE` (`id_doc_type`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COMMENT='типы документов';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_doc_type`
--

LOCK TABLES `directory_doc_type` WRITE;
/*!40000 ALTER TABLE `directory_doc_type` DISABLE KEYS */;
INSERT INTO `directory_doc_type` VALUES ('паспорт громаданини України',1),('посвідчення громадянина України',2),('свідоцтво про народження',3),('тимчасове посвідчення громадянина України',4);
/*!40000 ALTER TABLE `directory_doc_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directory_education`
--

DROP TABLE IF EXISTS `directory_education`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_education` (
  `education_type` varchar(30) NOT NULL,
  `id_education` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_education`),
  UNIQUE KEY `education_type_UNIQUE` (`education_type`),
  UNIQUE KEY `id_education_UNIQUE` (`id_education`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_education`
--

LOCK TABLES `directory_education` WRITE;
/*!40000 ALTER TABLE `directory_education` DISABLE KEYS */;
INSERT INTO `directory_education` VALUES ('аспірантура',1),('вища освіта',2),('докторантура',3),('загальна середня освіта',4),('незакінчена вища освіта',5),('післядипломна освіта',6),('професійно-технічна освіта',7);
/*!40000 ALTER TABLE `directory_education` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directory_land`
--

DROP TABLE IF EXISTS `directory_land`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_land` (
  `iddirectory_land` varchar(10) NOT NULL,
  `type_land` varchar(100) NOT NULL,
  PRIMARY KEY (`iddirectory_land`),
  UNIQUE KEY `type_land_UNIQUE` (`type_land`),
  UNIQUE KEY `iddirectory_land_UNIQUE` (`iddirectory_land`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_land`
--

LOCK TABLES `directory_land` WRITE;
/*!40000 ALTER TABLE `directory_land` DISABLE KEYS */;
INSERT INTO `directory_land` VALUES ('інд. с-во','індивідуального садівництва'),('г-во','городництво'),('ж/г.б.','для будівництва, обслуговування житлового будинку, господарських будівель'),('осг','для ведення особистого селянського господарства'),('т.в.','для товарного сільськогосподарського виробництва'),('с/к','сінокосіння і випасання худоби');
/*!40000 ALTER TABLE `directory_land` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directory_lgota`
--

DROP TABLE IF EXISTS `directory_lgota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_lgota` (
  `lgota_type` varchar(40) NOT NULL,
  `id_lgota` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_lgota`),
  UNIQUE KEY `lgota_type_UNIQUE` (`lgota_type`),
  UNIQUE KEY `id_lgota_UNIQUE` (`id_lgota`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 COMMENT='льготы, пенсия';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_lgota`
--

LOCK TABLES `directory_lgota` WRITE;
/*!40000 ALTER TABLE `directory_lgota` DISABLE KEYS */;
INSERT INTO `directory_lgota` VALUES ('інвалід І групи',1),('інвалід ІІ групи',2),('інвалід ІІІ групи',3),('інвалід афганець',4),('інвалід війни',5),('інвалід дитинства',6),('інвалід зору',7),('інвалід слуху',8),('інвалід трудового каліцтва',9),('інвалід чорнобилець',10),('ветеран праці',11),('дитина війни',12),('кругла сирота',13),('малозабезпечений',14),('напів-сирота',15),('пенсіонер за віком',16),('пенсіонер за вислугою',17);
/*!40000 ALTER TABLE `directory_lgota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directory_relationship`
--

DROP TABLE IF EXISTS `directory_relationship`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_relationship` (
  `relationship` varchar(15) NOT NULL,
  `id_relationship` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_relationship`),
  UNIQUE KEY `relationship_UNIQUE` (`relationship`),
  UNIQUE KEY `id_relationship_UNIQUE` (`id_relationship`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_relationship`
--

LOCK TABLES `directory_relationship` WRITE;
/*!40000 ALTER TABLE `directory_relationship` DISABLE KEYS */;
INSERT INTO `directory_relationship` VALUES ('баба',1),('батько',2),('брат',3),('дід',4),('донька',5),('дружина',6),('дядька',7),('зять',8),('мати',9),('невіска',10),('онук',11),('онука',12),('сват',13),('сваха',14),('свекор',15),('свекруха',16),('сестра',17),('син',18),('тітка',19),('тесть',20),('теща',21),('чоловік',22);
/*!40000 ALTER TABLE `directory_relationship` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directory_roof`
--

DROP TABLE IF EXISTS `directory_roof`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_roof` (
  `id_roof` int(11) NOT NULL,
  `type_roof` varchar(100) NOT NULL,
  PRIMARY KEY (`id_roof`),
  UNIQUE KEY `type_roof_UNIQUE` (`type_roof`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='покрытие крыши';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_roof`
--

LOCK TABLES `directory_roof` WRITE;
/*!40000 ALTER TABLE `directory_roof` DISABLE KEYS */;
/*!40000 ALTER TABLE `directory_roof` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directory_street`
--

DROP TABLE IF EXISTS `directory_street`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_street` (
  `street_name` varchar(50) NOT NULL,
  `id_street` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_street`),
  UNIQUE KEY `street_name_UNIQUE` (`street_name`),
  UNIQUE KEY `id_street_UNIQUE` (`id_street`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COMMENT='справочник';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_street`
--

LOCK TABLES `directory_street` WRITE;
/*!40000 ALTER TABLE `directory_street` DISABLE KEYS */;
INSERT INTO `directory_street` VALUES ('Лікарняна',1),('Молодіжна',2),('Першотравнева',3),('Радянська',4),('Шевченка',5);
/*!40000 ALTER TABLE `directory_street` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directory_type_owner`
--

DROP TABLE IF EXISTS `directory_type_owner`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_type_owner` (
  `id_type_owner` int(11) NOT NULL AUTO_INCREMENT,
  `type_owner` varchar(45) NOT NULL,
  PRIMARY KEY (`id_type_owner`),
  UNIQUE KEY `type_owner_UNIQUE` (`type_owner`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_type_owner`
--

LOCK TABLES `directory_type_owner` WRITE;
/*!40000 ALTER TABLE `directory_type_owner` DISABLE KEYS */;
INSERT INTO `directory_type_owner` VALUES (2,'взята в аренду'),(1,'здана в аренду'),(3,'особисте користування');
/*!40000 ALTER TABLE `directory_type_owner` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directory_village`
--

DROP TABLE IF EXISTS `directory_village`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_village` (
  `village_name` varchar(50) NOT NULL,
  `id_village` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_village`),
  UNIQUE KEY `village_name_UNIQUE` (`village_name`),
  UNIQUE KEY `id_village_UNIQUE` (`id_village`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_village`
--

LOCK TABLES `directory_village` WRITE;
/*!40000 ALTER TABLE `directory_village` DISABLE KEYS */;
INSERT INTO `directory_village` VALUES ('Вербове',1),('Миколо-Гулак',2),('Тарасівка',3),('Тернова',4),('Утішне',5);
/*!40000 ALTER TABLE `directory_village` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directory_wall`
--

DROP TABLE IF EXISTS `directory_wall`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_wall` (
  `wall_type` varchar(40) NOT NULL,
  `id_wall` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_wall`),
  UNIQUE KEY `id_wall_UNIQUE` (`id_wall`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='типы покрытия стен';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_wall`
--

LOCK TABLES `directory_wall` WRITE;
/*!40000 ALTER TABLE `directory_wall` DISABLE KEYS */;
/*!40000 ALTER TABLE `directory_wall` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `document`
--

DROP TABLE IF EXISTS `document`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `document` (
  `iddocument` int(11) NOT NULL,
  `id_people` int(11) NOT NULL,
  `type` int(11) NOT NULL,
  `number` varchar(6) NOT NULL,
  `serya` varchar(2) NOT NULL,
  `kemVudan` varchar(60) DEFAULT NULL,
  `dateStart` date NOT NULL,
  `DateEnd` date DEFAULT NULL,
  `base` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'основной это документ или нет',
  `info` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`iddocument`,`id_people`),
  KEY `fk_doc_people_idx` (`id_people`),
  KEY `fk_doc_type_idx` (`type`),
  CONSTRAINT `fk_doc_people` FOREIGN KEY (`id_people`) REFERENCES `people` (`idpeople`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_doc_type` FOREIGN KEY (`type`) REFERENCES `directory_doc_type` (`id_doc_type`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='документы(паспорт , свидетельство о рождении)';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `document`
--

LOCK TABLES `document` WRITE;
/*!40000 ALTER TABLE `document` DISABLE KEYS */;
/*!40000 ALTER TABLE `document` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `education`
--

DROP TABLE IF EXISTS `education`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `education` (
  `ideducation` int(11) NOT NULL AUTO_INCREMENT,
  `id_people` int(11) NOT NULL,
  `type` int(11) NOT NULL COMMENT 'высшее, среднее..',
  `study` tinyint(1) DEFAULT NULL,
  `institution` varchar(100) DEFAULT NULL COMMENT 'навчальний заклад',
  `startDate` date DEFAULT NULL,
  `endDate` date DEFAULT NULL,
  PRIMARY KEY (`ideducation`,`id_people`),
  KEY `FK_people_idx` (`id_people`),
  KEY `fk_type_ed_idx` (`type`),
  CONSTRAINT `FK_people` FOREIGN KEY (`id_people`) REFERENCES `people` (`idpeople`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_type_ed` FOREIGN KEY (`type`) REFERENCES `directory_education` (`id_education`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `education`
--

LOCK TABLES `education` WRITE;
/*!40000 ALTER TABLE `education` DISABLE KEYS */;
/*!40000 ALTER TABLE `education` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `house`
--

DROP TABLE IF EXISTS `house`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `house` (
  `idhouse` int(11) NOT NULL,
  `year` year(4) NOT NULL,
  `village` int(11) DEFAULT NULL,
  `street` int(11) DEFAULT NULL,
  `number` varchar(4) DEFAULT NULL,
  PRIMARY KEY (`idhouse`),
  KEY `fk_village_h_idx` (`village`),
  KEY `fk_street_idx` (`street`),
  KEY `fk_village_house_idx` (`village`),
  KEY `fk_street_house_idx` (`street`),
  CONSTRAINT `fk_street_house` FOREIGN KEY (`street`) REFERENCES `directory_street` (`id_street`) ON UPDATE CASCADE,
  CONSTRAINT `fk_village_house` FOREIGN KEY (`village`) REFERENCES `directory_village` (`id_village`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `house`
--

LOCK TABLES `house` WRITE;
/*!40000 ALTER TABLE `house` DISABLE KEYS */;
/*!40000 ALTER TABLE `house` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `house_info`
--

DROP TABLE IF EXISTS `house_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `house_info` (
  `id_house` int(11) NOT NULL,
  `date` date NOT NULL,
  `info` varchar(255) DEFAULT NULL,
  `stenu` int(11) NOT NULL,
  `pokrivlya` int(11) NOT NULL,
  `pl_litnih_pr` float DEFAULT NULL COMMENT 'площадь летних помещений',
  `osn_pl` float DEFAULT NULL COMMENT 'основная площадь',
  `pl_live` float DEFAULT NULL COMMENT 'площадь жилых помещений',
  `room` tinyint(1) DEFAULT '1',
  `kanaliz` tinyint(1) DEFAULT NULL,
  `opalen` tinyint(1) DEFAULT NULL,
  `gar_voda` tinyint(1) DEFAULT NULL,
  `vanna` tinyint(1) DEFAULT NULL,
  `gaz1` tinyint(1) DEFAULT NULL,
  `gaz2` tinyint(1) DEFAULT NULL,
  `el_pluta` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_house`,`date`),
  KEY `fk_wall_idx` (`stenu`),
  KEY `fk_roof_idx` (`pokrivlya`),
  CONSTRAINT `fk_house` FOREIGN KEY (`id_house`) REFERENCES `house` (`idhouse`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_roof` FOREIGN KEY (`pokrivlya`) REFERENCES `directory_roof` (`id_roof`) ON UPDATE CASCADE,
  CONSTRAINT `fk_wall` FOREIGN KEY (`stenu`) REFERENCES `directory_wall` (`id_wall`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `house_info`
--

LOCK TABLES `house_info` WRITE;
/*!40000 ALTER TABLE `house_info` DISABLE KEYS */;
/*!40000 ALTER TABLE `house_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `institution`
--

DROP TABLE IF EXISTS `institution`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `institution` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(150) NOT NULL,
  `type` text NOT NULL COMMENT 'тип учреждения (подстановка из таблици)',
  `village` int(11) DEFAULT NULL COMMENT 'код села',
  `street` int(11) DEFAULT NULL,
  `fio` varchar(100) NOT NULL COMMENT 'РУКОВОДИТЕЛЬ УЧРЕЖДЕНИЯ',
  `id_tel` int(11) DEFAULT NULL,
  `vukl` tinyint(1) DEFAULT NULL COMMENT 'сключенный с учета',
  `reason` varchar(256) DEFAULT NULL COMMENT 'причина',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  KEY `fk_street_i_idx` (`street`),
  KEY `fk_village_i_idx` (`village`),
  CONSTRAINT `fk_street_i` FOREIGN KEY (`street`) REFERENCES `directory_street` (`id_street`) ON UPDATE CASCADE,
  CONSTRAINT `fk_village_i` FOREIGN KEY (`village`) REFERENCES `directory_village` (`id_village`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='учреждения, которые находятся на территории совета';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `institution`
--

LOCK TABLES `institution` WRITE;
/*!40000 ALTER TABLE `institution` DISABLE KEYS */;
/*!40000 ALTER TABLE `institution` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `land`
--

DROP TABLE IF EXISTS `land`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `land` (
  `idLand` int(11) NOT NULL,
  `number` varchar(15) DEFAULT NULL COMMENT 'кадастровый номер',
  `square` float NOT NULL,
  `type` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idLand`),
  UNIQUE KEY `number_UNIQUE` (`number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `land`
--

LOCK TABLES `land` WRITE;
/*!40000 ALTER TABLE `land` DISABLE KEYS */;
/*!40000 ALTER TABLE `land` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lgota`
--

DROP TABLE IF EXISTS `lgota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lgota` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_people` int(11) NOT NULL,
  `document` varchar(15) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `type` int(11) NOT NULL,
  `info` text,
  `kemVudan` varchar(60) DEFAULT NULL COMMENT 'кем выдан',
  `dateEnd` date DEFAULT NULL COMMENT 'дата окончаний. Для льгот',
  `p_ll` tinyint(1) DEFAULT NULL COMMENT 'пенстя или льгота',
  PRIMARY KEY (`id`,`id_people`),
  KEY `FK_people_idx` (`id_people`),
  KEY `fk_type_lgota_idx` (`type`),
  CONSTRAINT `FK_lgota` FOREIGN KEY (`id_people`) REFERENCES `people` (`idpeople`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_type_lgota` FOREIGN KEY (`type`) REFERENCES `directory_lgota` (`id_lgota`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='льготы';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lgota`
--

LOCK TABLES `lgota` WRITE;
/*!40000 ALTER TABLE `lgota` DISABLE KEYS */;
/*!40000 ALTER TABLE `lgota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ownership`
--

DROP TABLE IF EXISTS `ownership`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ownership` (
  `date` date NOT NULL,
  `pgo_nPGO` int(1) NOT NULL,
  `pgo_idPGO` int(4) NOT NULL,
  `miniTractors` smallint(6) DEFAULT NULL,
  `descriptionAnimal` text,
  `bee` smallint(6) DEFAULT NULL,
  `fur` smallint(6) DEFAULT NULL,
  `rabbitAll` smallint(6) DEFAULT NULL,
  `chickens` smallint(6) DEFAULT NULL,
  `birds` smallint(6) DEFAULT NULL,
  `foals` smallint(6) DEFAULT NULL,
  `mares` smallint(6) DEFAULT NULL,
  `horsesAll` smallint(6) DEFAULT NULL,
  `goats` smallint(6) DEFAULT NULL,
  `goatsAll` smallint(6) DEFAULT NULL,
  `sheep` smallint(6) DEFAULT NULL,
  `sheepAll` smallint(6) DEFAULT NULL,
  `pigles` smallint(6) DEFAULT NULL,
  `pigs1` smallint(6) DEFAULT NULL,
  `pigs` smallint(6) DEFAULT NULL,
  `pigall` smallint(6) DEFAULT NULL,
  `calves` smallint(6) DEFAULT NULL,
  `heifers2` smallint(6) DEFAULT NULL,
  `heifers1` smallint(6) DEFAULT NULL,
  `cows` smallint(6) DEFAULT NULL,
  `bulls` smallint(6) DEFAULT NULL,
  `cattle` smallint(6) DEFAULT NULL,
  `descriptionTech` smallint(6) DEFAULT NULL,
  `grainCombines` smallint(6) DEFAULT NULL,
  `combines` smallint(6) DEFAULT NULL,
  `trucks` smallint(6) DEFAULT NULL,
  `tractors` smallint(6) DEFAULT NULL,
  PRIMARY KEY (`date`,`pgo_nPGO`,`pgo_idPGO`),
  KEY `fk_ownership_pgo1_idx` (`pgo_nPGO`,`pgo_idPGO`),
  CONSTRAINT `fk_own_PGO` FOREIGN KEY (`pgo_nPGO`, `pgo_idPGO`) REFERENCES `pgo` (`idPGO`, `nPGO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ownership`
--

LOCK TABLES `ownership` WRITE;
/*!40000 ALTER TABLE `ownership` DISABLE KEYS */;
/*!40000 ALTER TABLE `ownership` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ownhouse`
--

DROP TABLE IF EXISTS `ownhouse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ownhouse` (
  `idownHouse` int(11) NOT NULL,
  `id_nPGO` int(1) NOT NULL,
  `id_PGO` int(4) NOT NULL,
  `year` year(4) NOT NULL COMMENT 'год учета',
  `info` text,
  `chastka` varchar(3) DEFAULT NULL,
  `square` float DEFAULT NULL,
  `id_people` int(11) DEFAULT NULL COMMENT 'фамилия владельца',
  `baseHouse` tinyint(4) DEFAULT NULL COMMENT 'основний будинок',
  `document` varchar(255) DEFAULT NULL,
  `typeown` varchar(45) DEFAULT NULL COMMENT 'право собственности',
  PRIMARY KEY (`idownHouse`,`id_PGO`,`year`,`id_nPGO`),
  KEY `fk_house_pgo_idx` (`id_nPGO`,`id_PGO`),
  KEY `fk_house_people_idx` (`id_people`),
  KEY `fk_house_idx` (`idownHouse`),
  CONSTRAINT `fk_house_` FOREIGN KEY (`idownHouse`) REFERENCES `house` (`idhouse`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_house_people` FOREIGN KEY (`id_people`) REFERENCES `people` (`idpeople`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_house_pgo` FOREIGN KEY (`id_nPGO`, `id_PGO`) REFERENCES `pgo` (`idPGO`, `nPGO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ownhouse`
--

LOCK TABLES `ownhouse` WRITE;
/*!40000 ALTER TABLE `ownhouse` DISABLE KEYS */;
/*!40000 ALTER TABLE `ownhouse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ownland`
--

DROP TABLE IF EXISTS `ownland`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ownland` (
  `date` date NOT NULL,
  `Land_idLand` int(11) NOT NULL,
  `id_PGO` int(4) DEFAULT NULL,
  `id_nPGO` int(1) DEFAULT NULL,
  `description` text COMMENT 'почему взяли \\сдали в аренду ',
  `id_people` int(11) DEFAULT NULL,
  `id_type` int(11) DEFAULT NULL COMMENT 'тип права на землю аренде, сдана в аренду, личное использование',
  `dolay` varchar(4) DEFAULT NULL COMMENT 'частка которой влаедет человек',
  `square` float unsigned DEFAULT NULL,
  `docement` varchar(256) DEFAULT NULL,
  `dateEnd` date DEFAULT NULL,
  `dateStart` date DEFAULT NULL,
  PRIMARY KEY (`date`,`Land_idLand`),
  KEY `fk_ownLand_Land1_idx` (`Land_idLand`),
  KEY `fk_land_PGO_idx` (`id_PGO`,`id_nPGO`),
  KEY `fk_land_people_idx` (`id_people`),
  KEY `fk_owner_land_type_idx` (`id_type`),
  CONSTRAINT `fk_land` FOREIGN KEY (`Land_idLand`) REFERENCES `land` (`idLand`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_land_people` FOREIGN KEY (`id_people`) REFERENCES `people` (`idpeople`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_land_PGO` FOREIGN KEY (`id_PGO`, `id_nPGO`) REFERENCES `pgo` (`idPGO`, `nPGO`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_owner_land_type` FOREIGN KEY (`id_type`) REFERENCES `directory_type_owner` (`id_type_owner`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ownland`
--

LOCK TABLES `ownland` WRITE;
/*!40000 ALTER TABLE `ownland` DISABLE KEYS */;
/*!40000 ALTER TABLE `ownland` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `people`
--

DROP TABLE IF EXISTS `people`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `people` (
  `idpeople` int(11) NOT NULL AUTO_INCREMENT,
  `sename` varchar(45) NOT NULL,
  `name_` varchar(30) NOT NULL,
  `lastname` varchar(30) NOT NULL,
  `birthplace` varchar(100) DEFAULT NULL,
  `dateBirth` date DEFAULT NULL,
  `INN` varchar(11) DEFAULT NULL,
  `id_PGO` int(4) DEFAULT NULL,
  `id_nPGO` int(1) DEFAULT NULL,
  `stat` enum('жіноча','чоловіча') DEFAULT 'чоловіча',
  `golovaGospod` tinyint(1) DEFAULT NULL,
  `typeReg` tinyint(1) NOT NULL COMMENT 'тимчасо зарегистрированный',
  `typeEcDi` varchar(45) DEFAULT NULL COMMENT 'тип экономической деятельности',
  `dateOfdeath` date DEFAULT NULL,
  `reasonDeath` varchar(45) DEFAULT NULL COMMENT 'причина смерти',
  `address` varchar(256) DEFAULT NULL COMMENT 'дрес регистрации прожиания для третьего типа и 4-го типа владения',
  PRIMARY KEY (`idpeople`),
  KEY `FK_PGO_people_idx` (`id_PGO`,`id_nPGO`),
  KEY `fam` (`sename`,`name_`,`lastname`),
  KEY `dateb` (`dateBirth`),
  CONSTRAINT `FK_PGO_people` FOREIGN KEY (`id_PGO`, `id_nPGO`) REFERENCES `pgo` (`idPGO`, `nPGO`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `people`
--

LOCK TABLES `people` WRITE;
/*!40000 ALTER TABLE `people` DISABLE KEYS */;
INSERT INTO `people` VALUES (1,'Петров','Петро','Петрович',NULL,NULL,NULL,11,1,'чоловіча',1,1,NULL,NULL,NULL,NULL),(2,'Іванов','Тарас','Іванович',NULL,NULL,NULL,12,1,'чоловіча',0,1,NULL,NULL,NULL,NULL),(3,'Іванова','Інна','Миколаївна',NULL,NULL,NULL,12,1,'чоловіча',1,1,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `people` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pgo`
--

DROP TABLE IF EXISTS `pgo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pgo` (
  `idPGO` int(4) NOT NULL AUTO_INCREMENT,
  `nPGO` int(1) NOT NULL,
  `idstreet` int(11) DEFAULT NULL,
  `idvillage` int(11) DEFAULT NULL COMMENT 'дополнительные отметки',
  `memo` longtext,
  `nBookPGO` tinyint(2) DEFAULT NULL,
  `nPage` smallint(4) DEFAULT NULL,
  `num_house` varchar(3) DEFAULT NULL,
  `num_flat` varchar(3) DEFAULT NULL,
  `vukl` tinyint(1) DEFAULT NULL COMMENT 'исключенный из учета или нет ',
  `reason` varchar(256) DEFAULT NULL COMMENT 'ричина исключения с учета',
  PRIMARY KEY (`idPGO`,`nPGO`),
  KEY `fk_type_idx` (`nPGO`),
  KEY `fk_street_idx` (`idstreet`),
  KEY `fk_village_idx` (`idvillage`),
  CONSTRAINT `fk_street` FOREIGN KEY (`idstreet`) REFERENCES `directory_street` (`id_street`) ON UPDATE CASCADE,
  CONSTRAINT `fk_type_pgo` FOREIGN KEY (`nPGO`) REFERENCES `pgo_type` (`idPGO_type`) ON UPDATE CASCADE,
  CONSTRAINT `fk_village` FOREIGN KEY (`idvillage`) REFERENCES `directory_village` (`id_village`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pgo`
--

LOCK TABLES `pgo` WRITE;
/*!40000 ALTER TABLE `pgo` DISABLE KEYS */;
INSERT INTO `pgo` VALUES (11,1,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(12,1,2,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(13,2,1,2,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `pgo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pgo_type`
--

DROP TABLE IF EXISTS `pgo_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pgo_type` (
  `idPGO_type` int(1) NOT NULL,
  `type` varchar(70) NOT NULL,
  PRIMARY KEY (`idPGO_type`),
  UNIQUE KEY `idPGO_type_UNIQUE` (`idPGO_type`),
  UNIQUE KEY `type_UNIQUE` (`type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pgo_type`
--

LOCK TABLES `pgo_type` WRITE;
/*!40000 ALTER TABLE `pgo_type` DISABLE KEYS */;
INSERT INTO `pgo_type` VALUES (2,'Домогосподарство без реєстрації місця проживання'),(1,'Домогосподарство з реєстрацією місця проживання');
/*!40000 ALTER TABLE `pgo_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `pgo_view`
--

DROP TABLE IF EXISTS `pgo_view`;
/*!50001 DROP VIEW IF EXISTS `pgo_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `pgo_view` (
  `ОПГО` tinyint NOT NULL,
  `Адреса` tinyint NOT NULL,
  `Власник` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `registration`
--

DROP TABLE IF EXISTS `registration`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `registration` (
  `idregistration` int(11) NOT NULL,
  `id_people` int(11) NOT NULL,
  `datep` date NOT NULL,
  `datev` date DEFAULT NULL COMMENT 'дата прибытия',
  `tunchV` tinyint(1) DEFAULT '0' COMMENT 'временно отстутствует (учеба, работа...)',
  `goal` varchar(45) DEFAULT NULL COMMENT 'цель прибытия(для хозяйства временного проживания)',
  `reason` varchar(45) DEFAULT NULL COMMENT 'для временно отстутствующий (причина учеба, работа) ',
  `nPGO` varchar(5) DEFAULT NULL COMMENT 'если переместили с одного ПГО в другое',
  PRIMARY KEY (`idregistration`,`id_people`),
  KEY `fk_reg_people_idx` (`id_people`),
  CONSTRAINT `fk_reg_people` FOREIGN KEY (`id_people`) REFERENCES `people` (`idpeople`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registration`
--

LOCK TABLES `registration` WRITE;
/*!40000 ALTER TABLE `registration` DISABLE KEYS */;
/*!40000 ALTER TABLE `registration` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `relationshep`
--

DROP TABLE IF EXISTS `relationshep`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `relationshep` (
  `idrelationShep` int(11) NOT NULL AUTO_INCREMENT,
  `dateR` date DEFAULT NULL,
  `id_pr` int(11) NOT NULL,
  `id_obr` int(11) NOT NULL,
  `type` varchar(20) DEFAULT NULL COMMENT 'родство - сын, мать.....',
  PRIMARY KEY (`idrelationShep`,`id_pr`,`id_obr`),
  KEY `fk_pr_idx` (`id_pr`),
  KEY `fk_obr_idx` (`id_obr`),
  CONSTRAINT `fk_obr` FOREIGN KEY (`id_obr`) REFERENCES `people` (`idpeople`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_pr` FOREIGN KEY (`id_pr`) REFERENCES `people` (`idpeople`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `relationshep`
--

LOCK TABLES `relationshep` WRITE;
/*!40000 ALTER TABLE `relationshep` DISABLE KEYS */;
/*!40000 ALTER TABLE `relationshep` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `report`
--

DROP TABLE IF EXISTS `report`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `report` (
  `idreport` int(11) NOT NULL,
  `reportcol` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idreport`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='инфо о выданных отчетах';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `report`
--

LOCK TABLES `report` WRITE;
/*!40000 ALTER TABLE `report` DISABLE KEYS */;
/*!40000 ALTER TABLE `report` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `silrada`
--

DROP TABLE IF EXISTS `silrada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `silrada` (
  `oblast` varchar(30) DEFAULT NULL,
  `region` varchar(45) DEFAULT NULL,
  `zip` varchar(5) NOT NULL DEFAULT '00000',
  `village` int(11) DEFAULT NULL,
  `street` int(11) DEFAULT NULL,
  `director` varchar(60) NOT NULL,
  `secretary` varchar(60) NOT NULL,
  `zemleyp` varchar(60) DEFAULT NULL,
  `telephone` varchar(15) DEFAULT NULL,
  KEY `fk_street_s_idx` (`street`),
  KEY `fk_village_s_idx` (`village`),
  CONSTRAINT `fk_street_s` FOREIGN KEY (`street`) REFERENCES `directory_street` (`id_street`) ON UPDATE CASCADE,
  CONSTRAINT `fk_village_s` FOREIGN KEY (`village`) REFERENCES `directory_village` (`id_village`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `silrada`
--

LOCK TABLES `silrada` WRITE;
/*!40000 ALTER TABLE `silrada` DISABLE KEYS */;
/*!40000 ALTER TABLE `silrada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `name` varchar(30) NOT NULL,
  `password` varchar(32) NOT NULL,
  `type` tinyint(1) NOT NULL COMMENT 'тип доступа',
  PRIMARY KEY (`name`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('admin','654321',1),('neadmin','123456',0);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `work`
--

DROP TABLE IF EXISTS `work`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `work` (
  `idwork` int(11) NOT NULL AUTO_INCREMENT,
  `id_people` int(11) NOT NULL,
  `post` varchar(45) NOT NULL COMMENT 'должность',
  `workDescription` varchar(255) DEFAULT NULL COMMENT 'место работы . адресс. название учреждения',
  `dateStart` date NOT NULL,
  `dateEnd` date DEFAULT NULL,
  `info` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idwork`,`id_people`),
  KEY `fk_work_people_idx` (`id_people`),
  CONSTRAINT `fk_work_people` FOREIGN KEY (`id_people`) REFERENCES `people` (`idpeople`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='места работы';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `work`
--

LOCK TABLES `work` WRITE;
/*!40000 ALTER TABLE `work` DISABLE KEYS */;
/*!40000 ALTER TABLE `work` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'pgo'
--

--
-- Dumping routines for database 'pgo'
--

--
-- Final view structure for view `pgo_view`
--

/*!50001 DROP TABLE IF EXISTS `pgo_view`*/;
/*!50001 DROP VIEW IF EXISTS `pgo_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `pgo_view` AS select concat(`pgo`.`idPGO`,`pgo`.`nPGO`) AS `ОПГО`,concat('c. ',`directory_village`.`village_name`,' вул. ',`directory_street`.`street_name`) AS `Адреса`,concat(`people`.`sename`,' ',`people`.`name_`,' ',`people`.`lastname`) AS `Власник` from (((`pgo` join `directory_street` on((`pgo`.`idstreet` = `directory_street`.`id_street`))) join `directory_village` on((`pgo`.`idvillage` = `directory_village`.`id_village`))) left join `people` on(((`pgo`.`idPGO` = `people`.`id_PGO`) and (`pgo`.`nPGO` = `people`.`id_nPGO`)))) where ((`people`.`golovaGospod` <> 0) or isnull(`people`.`id_PGO`)) */;
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

-- Dump completed on 2013-12-02 23:12:19
