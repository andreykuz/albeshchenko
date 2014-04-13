CREATE DATABASE  IF NOT EXISTS `pgo` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `pgo`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: pgo
-- ------------------------------------------------------
-- Server version	5.6.14-log

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
  PRIMARY KEY (`doc_type`),
  UNIQUE KEY `doc_type_UNIQUE` (`doc_type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='типы документов';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_doc_type`
--

LOCK TABLES `directory_doc_type` WRITE;
/*!40000 ALTER TABLE `directory_doc_type` DISABLE KEYS */;
INSERT INTO `directory_doc_type` VALUES ('паспорт громаданини України'),('посвідчення громадянина України'),('свідоцтво про народження'),('тимчасове посвідчення громадянина України');
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
  PRIMARY KEY (`education_type`),
  UNIQUE KEY `education_type_UNIQUE` (`education_type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_education`
--

LOCK TABLES `directory_education` WRITE;
/*!40000 ALTER TABLE `directory_education` DISABLE KEYS */;
INSERT INTO `directory_education` VALUES ('аспірантура'),('вища освіта'),('докторантура'),('загальна середня освіта'),('незакінчена вища освіта'),('післядипломна освіта'),('професійно-технічна освіта');
/*!40000 ALTER TABLE `directory_education` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directory_lgota`
--

DROP TABLE IF EXISTS `directory_lgota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_lgota` (
  `lgota_type` varchar(40) NOT NULL,
  PRIMARY KEY (`lgota_type`),
  UNIQUE KEY `lgota_type_UNIQUE` (`lgota_type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='льготы, пенсия';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_lgota`
--

LOCK TABLES `directory_lgota` WRITE;
/*!40000 ALTER TABLE `directory_lgota` DISABLE KEYS */;
INSERT INTO `directory_lgota` VALUES ('інвалід І групи'),('інвалід ІІ групи'),('інвалід ІІІ групи'),('інвалід афганець'),('інвалід війни'),('інвалід дитинства'),('інвалід зору'),('інвалід слуху'),('інвалід трудового каліцтва'),('інвалід чорнобилець'),('ветеран праці'),('дитина війни'),('кругла сирота'),('малозабезпечений'),('напів-сирота'),('пенсіонер за віком'),('пенсіонер за вислугою');
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
  PRIMARY KEY (`relationship`),
  UNIQUE KEY `relationship_UNIQUE` (`relationship`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_relationship`
--

LOCK TABLES `directory_relationship` WRITE;
/*!40000 ALTER TABLE `directory_relationship` DISABLE KEYS */;
INSERT INTO `directory_relationship` VALUES ('баба'),('батько'),('брат'),('дід'),('донька'),('дружина'),('дядька'),('зять'),('мати'),('невіска'),('онук'),('онука'),('сват'),('сваха'),('свекор'),('свекруха'),('сестра'),('син'),('тітка'),('тесть'),('теща'),('чоловік');
/*!40000 ALTER TABLE `directory_relationship` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directory_street`
--

DROP TABLE IF EXISTS `directory_street`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_street` (
  `street_name` varchar(50) NOT NULL,
  PRIMARY KEY (`street_name`),
  UNIQUE KEY `street_name_UNIQUE` (`street_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='справочник';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_street`
--

LOCK TABLES `directory_street` WRITE;
/*!40000 ALTER TABLE `directory_street` DISABLE KEYS */;
INSERT INTO `directory_street` VALUES ('Лікарняна'),('Молодіжна'),('Першотравнева'),('Радянська'),('Шевченка');
/*!40000 ALTER TABLE `directory_street` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directory_village`
--

DROP TABLE IF EXISTS `directory_village`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_village` (
  `village_name` varchar(50) NOT NULL,
  PRIMARY KEY (`village_name`),
  UNIQUE KEY `village_name_UNIQUE` (`village_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `directory_village`
--

LOCK TABLES `directory_village` WRITE;
/*!40000 ALTER TABLE `directory_village` DISABLE KEYS */;
INSERT INTO `directory_village` VALUES ('Вербове'),('Миколо-Гулак'),('Тарасівка'),('Тернова'),('Утішне');
/*!40000 ALTER TABLE `directory_village` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `directory_wall`
--

DROP TABLE IF EXISTS `directory_wall`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `directory_wall` (
  `id` int(40) NOT NULL,
  PRIMARY KEY (`id`)
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
  `type` varchar(45) NOT NULL,
  `number` varchar(6) NOT NULL,
  `serya` varchar(2) NOT NULL,
  `kemVudan` varchar(60) DEFAULT NULL,
  `dateStart` date NOT NULL,
  `DateEnd` date DEFAULT NULL,
  `base` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'основной это документ или нет',
  `info` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`iddocument`,`id_people`),
  KEY `fk_doc_people_idx` (`id_people`),
  CONSTRAINT `fk_doc_people` FOREIGN KEY (`id_people`) REFERENCES `people` (`idpeople`) ON DELETE CASCADE ON UPDATE CASCADE
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
  `type` varchar(45) DEFAULT NULL COMMENT 'высшее, среднее..',
  `study` tinyint(1) DEFAULT NULL,
  `institution` varchar(100) DEFAULT NULL COMMENT 'навчальний заклад',
  `startDate` date DEFAULT NULL,
  `endDate` date DEFAULT NULL,
  PRIMARY KEY (`ideducation`,`id_people`),
  KEY `FK_people_idx` (`id_people`),
  CONSTRAINT `FK_people` FOREIGN KEY (`id_people`) REFERENCES `people` (`idpeople`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `education`
--

LOCK TABLES `education` WRITE;
/*!40000 ALTER TABLE `education` DISABLE KEYS */;
INSERT INTO `education` VALUES (1,1,'1',1,'deesdds','2012-09-20',NULL);
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
  `village` varchar(45) DEFAULT NULL,
  `street` varchar(45) DEFAULT NULL,
  `number` varchar(4) DEFAULT NULL,
  PRIMARY KEY (`idhouse`)
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
  `stenu` varchar(45) DEFAULT NULL,
  `pokrivlya` varchar(45) DEFAULT NULL,
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
  CONSTRAINT `fk_house` FOREIGN KEY (`id_house`) REFERENCES `house` (`idhouse`) ON DELETE CASCADE ON UPDATE CASCADE
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
  `village` varchar(50) DEFAULT NULL COMMENT 'код села',
  `street` varchar(50) DEFAULT NULL,
  `fio` varchar(100) NOT NULL COMMENT 'РУКОВОДИТЕЛЬ УЧРЕЖДЕНИЯ',
  `id_tel` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
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
  `arenda` tinyint(1) DEFAULT '0' COMMENT 'Сдана в аренду или нет',
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
  `type` varchar(60) DEFAULT NULL,
  `info` text,
  `kemVudan` varchar(60) DEFAULT NULL COMMENT 'кем выдан',
  `dateEnd` date DEFAULT NULL COMMENT 'дата окончаний. Для льгот',
  `p_ll` tinyint(1) DEFAULT NULL COMMENT 'пенстя или льгота',
  PRIMARY KEY (`id`,`id_people`),
  KEY `FK_people_idx` (`id_people`),
  CONSTRAINT `FK_education` FOREIGN KEY (`id_people`) REFERENCES `people` (`idpeople`) ON DELETE CASCADE ON UPDATE CASCADE
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
  `arenda` binary(1) DEFAULT NULL COMMENT 'взято в аренду',
  `id_people` int(11) DEFAULT NULL,
  `type` varchar(45) DEFAULT NULL COMMENT 'тип права на землю',
  `dolay` varchar(4) DEFAULT NULL COMMENT 'частка которой влаедет человек',
  `square` float unsigned DEFAULT NULL,
  `docement` varchar(255) DEFAULT NULL,
  `dateEnd` date DEFAULT NULL,
  PRIMARY KEY (`date`,`Land_idLand`),
  KEY `fk_ownLand_Land1_idx` (`Land_idLand`),
  KEY `fk_land_PGO_idx` (`id_PGO`,`id_nPGO`),
  KEY `fk_land_people_idx` (`id_people`),
  CONSTRAINT `fk_land` FOREIGN KEY (`Land_idLand`) REFERENCES `land` (`idLand`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_land_people` FOREIGN KEY (`id_people`) REFERENCES `people` (`idpeople`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_land_PGO` FOREIGN KEY (`id_PGO`, `id_nPGO`) REFERENCES `pgo` (`idPGO`, `nPGO`) ON DELETE CASCADE ON UPDATE CASCADE
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
  `name` varchar(30) NOT NULL,
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
  PRIMARY KEY (`idpeople`),
  KEY `FK_PGO_people_idx` (`id_PGO`,`id_nPGO`),
  KEY `fam` (`sename`,`name`,`lastname`),
  KEY `dateb` (`dateBirth`),
  CONSTRAINT `FK_PGO_people` FOREIGN KEY (`id_PGO`, `id_nPGO`) REFERENCES `pgo` (`idPGO`, `nPGO`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `people`
--

LOCK TABLES `people` WRITE;
/*!40000 ALTER TABLE `people` DISABLE KEYS */;
INSERT INTO `people` VALUES (1,'Петров','Петро','Іванович','Кривий Ріг','2012-12-20',NULL,1,1,'жіноча',NULL,1,NULL,NULL,NULL),(2,'Петрова','Тетяна','Іванівна','Кривий Ріг',NULL,NULL,NULL,NULL,'чоловіча',NULL,3,NULL,NULL,NULL);
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
  `idstreet` varchar(50) DEFAULT NULL,
  `idvillage` varchar(50) DEFAULT NULL COMMENT 'дополнительные отметки',
  `memo` longtext,
  `nBookPGO` tinyint(2) DEFAULT NULL,
  `nPage` smallint(4) DEFAULT NULL,
  `num_house` varchar(3) DEFAULT NULL,
  `num_flat` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`idPGO`,`nPGO`),
  KEY `fk_street_idx` (`idstreet`),
  KEY `fk_village_idx` (`idvillage`),
  KEY `fk_type_idx` (`nPGO`),
  KEY `fk_type_id` (`nPGO`),
  KEY `fk_type_pgo_idx` (`nPGO`),
  CONSTRAINT `fk_street` FOREIGN KEY (`idstreet`) REFERENCES `directory_street` (`street_name`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_type_pgo` FOREIGN KEY (`nPGO`) REFERENCES `pgo_type` (`idPGO_type`) ON UPDATE CASCADE,
  CONSTRAINT `fk_village` FOREIGN KEY (`idvillage`) REFERENCES `directory_village` (`village_name`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pgo`
--

LOCK TABLES `pgo` WRITE;
/*!40000 ALTER TABLE `pgo` DISABLE KEYS */;
INSERT INTO `pgo` VALUES (1,1,'Радянська','Миколо-Гулак',NULL,NULL,NULL,'2',NULL),(6,1,'Лікарняна','Миколо-Гулак',NULL,NULL,NULL,'13',NULL),(9,1,'Першотравнева','Миколо-Гулак',NULL,NULL,NULL,'12',NULL),(10,1,'Молодіжна','Миколо-Гулак',NULL,NULL,NULL,'15',NULL);
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
  `type` varchar(70) DEFAULT NULL,
  PRIMARY KEY (`idPGO_type`),
  UNIQUE KEY `idPGO_type_UNIQUE` (`idPGO_type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pgo_type`
--

LOCK TABLES `pgo_type` WRITE;
/*!40000 ALTER TABLE `pgo_type` DISABLE KEYS */;
INSERT INTO `pgo_type` VALUES (1,'Домогосподарство з реєстрацією місця проживання');
/*!40000 ALTER TABLE `pgo_type` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Table structure for table `silrada`
--

DROP TABLE IF EXISTS `silrada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `silrada` (
  `oblast` varchar(30) DEFAULT NULL,
  `region` varchar(45) DEFAULT NULL,
  `zip` varchar(5) NOT NULL DEFAULT '00000',
  `village` varchar(45) DEFAULT NULL,
  `street` varchar(45) DEFAULT NULL,
  `director` varchar(60) NOT NULL,
  `secretary` varchar(60) NOT NULL,
  `zemleyp` varchar(60) DEFAULT NULL,
  `telephone` varchar(15) DEFAULT NULL
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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-11-30 22:02:01
