CREATE DATABASE  IF NOT EXISTS `libreria_parra` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `libreria_parra`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: libreria_parra
-- ------------------------------------------------------
-- Server version	5.7.18-log

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
-- Table structure for table `bodega`
--

DROP TABLE IF EXISTS `bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bodega` (
  `id_registro` int(11) NOT NULL AUTO_INCREMENT,
  `producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `id_detalle_producto` int(11) NOT NULL,
  PRIMARY KEY (`id_registro`),
  KEY `fk_producto_bodega_idx` (`producto`),
  KEY `fk_detalle_producto_idx` (`id_detalle_producto`),
  KEY `fk_detalle_producto_bodega_idx` (`id_detalle_producto`),
  CONSTRAINT `fk_detalle_producto_bodega` FOREIGN KEY (`id_detalle_producto`) REFERENCES `detalle_producto` (`id_detalle_producto`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_producto_bodega` FOREIGN KEY (`producto`) REFERENCES `productos` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bodega`
--

LOCK TABLES `bodega` WRITE;
/*!40000 ALTER TABLE `bodega` DISABLE KEYS */;
REPLACE INTO `bodega` (`id_registro`, `producto`, `cantidad`, `id_detalle_producto`) VALUES (1,114,1,111),(3,114,1,112),(5,5,2,5),(6,112,1,108);
/*!40000 ALTER TABLE `bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `caja`
--

DROP TABLE IF EXISTS `caja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `caja` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `gastos` float NOT NULL,
  `ventas` float NOT NULL,
  `pagos` float NOT NULL,
  `total` float NOT NULL,
  `fecha` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Estado` set('ABIERTO','CERRADO') COLLATE utf8_unicode_ci NOT NULL DEFAULT 'CERRADO',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caja`
--

LOCK TABLES `caja` WRITE;
/*!40000 ALTER TABLE `caja` DISABLE KEYS */;
REPLACE INTO `caja` (`id`, `gastos`, `ventas`, `pagos`, `total`, `fecha`, `Estado`) VALUES (2,200,7125,3641,3284,'2018-11-04 11:37:29','CERRADO');
/*!40000 ALTER TABLE `caja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
REPLACE INTO `categoria` (`codigo`, `nombre`) VALUES (1,'TECNOLOGIA'),(2,'ESCOLARES'),(3,'OFICINA'),(4,'MANUALIDADES'),(5,'SERVICIOS'),(6,'LIBROS');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `ruc` varchar(30) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `direccion` varchar(100) NOT NULL,
  `telefono` varchar(9) NOT NULL,
  `email` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`ruc`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
REPLACE INTO `cliente` (`ruc`, `nombre`, `direccion`, `telefono`, `email`) VALUES ('1234','CONTADO','LEON','58244180','yesser.miranda@gmail.com'),('123435','PAYLESS','PASEO REAL','2319-5687','PAYLESS@GMAIL.COM'),('17101997','ALMACENES JERUSALEM','CENTRO COMERCIAL PASEO REAL','58244180','alm.jerusalem@gmail.com');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `credito`
--

DROP TABLE IF EXISTS `credito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `credito` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_final` date NOT NULL,
  `empresa` int(11) NOT NULL,
  `total` float NOT NULL,
  `estado` enum('PENDIENTE','PAGADO') DEFAULT NULL,
  `proveedor` varchar(30) NOT NULL,
  PRIMARY KEY (`codigo`),
  KEY `empresafk1` (`empresa`),
  KEY `proveedor_cred_fk_idx` (`proveedor`),
  CONSTRAINT `empresafk1` FOREIGN KEY (`empresa`) REFERENCES `empresa` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `proveedor_cred_fk` FOREIGN KEY (`proveedor`) REFERENCES `proveedor` (`ruc`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `credito`
--

LOCK TABLES `credito` WRITE;
/*!40000 ALTER TABLE `credito` DISABLE KEYS */;
REPLACE INTO `credito` (`codigo`, `fecha_final`, `empresa`, `total`, `estado`, `proveedor`) VALUES (1,'2017-09-03',1,12000,'PAGADO','101092'),(3,'2017-11-02',1,10000,'PAGADO','17101997'),(4,'2017-12-01',1,5000,'PAGADO','8081991'),(5,'2017-12-02',1,2000,'PAGADO','101092'),(6,'2017-12-03',1,3000,'PAGADO','101092'),(7,'2017-10-21',1,20000,'PENDIENTE','101092'),(8,'2017-10-21',1,20000,'PENDIENTE','101092'),(9,'2017-10-22',1,22000,'PAGADO','17101997'),(10,'2017-10-22',1,22000,'PENDIENTE','8081991'),(11,'2017-10-12',1,20000,'PENDIENTE','8081991'),(12,'2018-10-20',1,20000,'PENDIENTE','101092');
/*!40000 ALTER TABLE `credito` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_factura`
--

DROP TABLE IF EXISTS `detalle_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_factura` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `codigo_factura` int(11) NOT NULL,
  `producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `descuento` int(11) DEFAULT NULL,
  `total` float NOT NULL,
  PRIMARY KEY (`codigo`),
  KEY `facturafk` (`codigo_factura`),
  KEY `fk_producto_detalleproducto_idx` (`producto`),
  CONSTRAINT `facturafk` FOREIGN KEY (`codigo_factura`) REFERENCES `factura` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_producto_detalleproducto` FOREIGN KEY (`producto`) REFERENCES `productos` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_factura`
--

LOCK TABLES `detalle_factura` WRITE;
/*!40000 ALTER TABLE `detalle_factura` DISABLE KEYS */;
REPLACE INTO `detalle_factura` (`codigo`, `codigo_factura`, `producto`, `cantidad`, `descuento`, `total`) VALUES (2,54,42,1,100,100),(3,55,105,1,340,340),(5,57,4,1,170,170),(6,58,109,1,15,15),(7,60,6,10,300,-2700),(8,61,7,1,20,650),(9,62,1,1,30,7500),(10,63,9,1,0,220),(11,64,33,1,0,190),(12,65,87,1,20,230),(13,66,5,1,0,450),(14,66,10,1,0,6000),(15,67,16,1,5,300),(16,67,76,1,5,1120),(17,68,109,1,0,15),(18,69,8,1,0,380),(19,69,19,1,0,135),(20,70,21,1,0,510),(21,71,3,1,0,12000),(22,72,2,1,0,8500),(23,73,31,1,0,340),(24,73,17,1,10,135),(25,74,16,1,5,300),(26,75,1,1,10,7500),(28,75,5,1,5,450),(29,76,106,1,0,600),(30,76,13,1,5,250),(32,78,3,1,10,12000),(33,79,1,1,5,7500),(34,80,113,1,0,300),(35,80,114,1,0,300),(36,81,113,1,0,300),(37,82,113,1,0,300),(38,83,113,1,0,300),(39,84,114,1,0,300);
/*!40000 ALTER TABLE `detalle_factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_pedido`
--

DROP TABLE IF EXISTS `detalle_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_pedido` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `codigo_factura` int(11) NOT NULL,
  `producto` varchar(30) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `descuento` int(11) DEFAULT NULL,
  `total` float NOT NULL,
  PRIMARY KEY (`codigo`),
  KEY `facturafk` (`codigo_factura`),
  CONSTRAINT `factura1fk` FOREIGN KEY (`codigo_factura`) REFERENCES `factura` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_pedido`
--

LOCK TABLES `detalle_pedido` WRITE;
/*!40000 ALTER TABLE `detalle_pedido` DISABLE KEYS */;
REPLACE INTO `detalle_pedido` (`codigo`, `codigo_factura`, `producto`, `cantidad`, `descuento`, `total`) VALUES (13,51,'025215723025',1,95,95);
/*!40000 ALTER TABLE `detalle_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_producto`
--

DROP TABLE IF EXISTS `detalle_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_producto` (
  `id_detalle_producto` int(11) NOT NULL AUTO_INCREMENT,
  `ns` varchar(30) DEFAULT NULL,
  `estado_producto` enum('DISPONIBLE','VENDIDO','DEVUELTO','PENDIENTE','ENTREGADO') NOT NULL,
  `codigo_barras` varchar(30) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `stock_individual` int(11) NOT NULL DEFAULT '1',
  `CaracteristicaIndividual` varchar(45) NOT NULL DEFAULT ' ',
  PRIMARY KEY (`id_detalle_producto`),
  UNIQUE KEY `ns_UNIQUE` (`ns`),
  KEY `fk_producto_detalle_idx` (`id_producto`)
) ENGINE=InnoDB AUTO_INCREMENT=113 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_producto`
--

LOCK TABLES `detalle_producto` WRITE;
/*!40000 ALTER TABLE `detalle_producto` DISABLE KEYS */;
REPLACE INTO `detalle_producto` (`id_detalle_producto`, `ns`, `estado_producto`, `codigo_barras`, `id_producto`, `stock_individual`, `CaracteristicaIndividual`) VALUES (1,NULL,'DISPONIBLE','010343918252',1,0,' '),(2,NULL,'DISPONIBLE','010343918283',2,0,' '),(3,NULL,'DISPONIBLE','010343920620',3,0,' '),(4,NULL,'DISPONIBLE','023942440819',4,0,' '),(5,NULL,'DISPONIBLE','023942440833',5,3,' '),(6,NULL,'DISPONIBLE','023942490647',6,0,' '),(7,NULL,'DISPONIBLE','023942490654',7,0,' '),(8,NULL,'DISPONIBLE','023942491767',8,0,' '),(9,NULL,'DISPONIBLE','023942498148',9,0,' '),(10,NULL,'DISPONIBLE','023942531777',10,0,' '),(11,NULL,'DISPONIBLE','023942973959',11,0,' '),(12,NULL,'DISPONIBLE','023942974642',12,0,' '),(13,NULL,'DISPONIBLE','023942985051',13,0,' '),(14,NULL,'DISPONIBLE','023942986720',14,0,' '),(15,NULL,'DISPONIBLE','023942986959',15,0,' '),(16,NULL,'DISPONIBLE','023942991380',16,0,' '),(17,NULL,'DISPONIBLE','025215192968',17,0,' '),(18,NULL,'DISPONIBLE','025215193606',18,0,' '),(19,NULL,'DISPONIBLE','025215197125',19,0,' '),(20,NULL,'DISPONIBLE','025215489617',20,0,' '),(21,NULL,'DISPONIBLE','025215490217',21,0,' '),(22,NULL,'DISPONIBLE','025215491207',22,0,' '),(23,NULL,'DISPONIBLE','025215492891',23,0,' '),(24,NULL,'DISPONIBLE','025215493416',24,0,' '),(25,NULL,'DISPONIBLE','025215494123',25,0,' '),(26,NULL,'DISPONIBLE','025215494147',26,0,' '),(27,NULL,'DISPONIBLE','025215494185',27,0,' '),(28,NULL,'DISPONIBLE','02521549451',28,0,' '),(29,NULL,'DISPONIBLE','025215494888',29,0,' '),(31,NULL,'DISPONIBLE','025215495120',31,0,' '),(32,NULL,'DISPONIBLE','025215496332',32,0,' '),(33,NULL,'DISPONIBLE','025215496424',33,0,' '),(35,NULL,'DISPONIBLE','025215497032',35,0,' '),(36,NULL,'DISPONIBLE','025215497209',36,0,' '),(37,NULL,'DISPONIBLE','025215497292',37,0,' '),(38,NULL,'DISPONIBLE','025215497766',38,0,' '),(39,NULL,'DISPONIBLE','025215497872',39,0,' '),(40,NULL,'DISPONIBLE','025215498152',40,0,' '),(41,NULL,'DISPONIBLE','025215498268',41,0,' '),(42,NULL,'DISPONIBLE','025215721113',42,0,' '),(43,NULL,'DISPONIBLE','025215723025',43,0,' '),(44,NULL,'DISPONIBLE','025215736483',44,0,' '),(45,NULL,'DISPONIBLE','02521579306',45,0,' '),(46,NULL,'DISPONIBLE','025215961724',46,0,' '),(47,NULL,'DISPONIBLE','025215961731',47,0,' '),(48,NULL,'DISPONIBLE','02521597476',48,0,' '),(49,NULL,'DISPONIBLE','4710268238492',49,0,' '),(50,NULL,'DISPONIBLE','4710268243786',50,0,' '),(51,NULL,'DISPONIBLE','4712366962439',51,0,' '),(52,NULL,'DISPONIBLE','4713435797525',52,0,' '),(53,NULL,'DISPONIBLE','798302010369',53,0,' '),(54,NULL,'DISPONIBLE','798302010376',54,0,' '),(55,NULL,'DISPONIBLE','798302034129',55,0,' '),(56,NULL,'DISPONIBLE','798302055223',56,0,' '),(57,NULL,'DISPONIBLE','798302055254',57,0,' '),(58,NULL,'DISPONIBLE','798302061507',58,0,' '),(59,NULL,'DISPONIBLE','798302071629',59,-1,' '),(60,NULL,'DISPONIBLE','798302074859',60,0,' '),(61,NULL,'DISPONIBLE','798302076549',61,0,' '),(62,NULL,'DISPONIBLE','798302076556',62,0,' '),(63,NULL,'DISPONIBLE','798302076617',63,0,' '),(64,NULL,'DISPONIBLE','798302076808',64,0,' '),(65,NULL,'DISPONIBLE','798302076839',65,0,' '),(66,NULL,'DISPONIBLE','798302076853',66,0,' '),(67,NULL,'DISPONIBLE','798302076938',67,0,' '),(68,NULL,'DISPONIBLE','798302077218',68,0,' '),(69,NULL,'DISPONIBLE','798302077225',69,0,' '),(70,NULL,'DISPONIBLE','798302090521',70,0,' '),(71,NULL,'DISPONIBLE','798302100718',71,0,' '),(72,NULL,'DISPONIBLE','798302101739',72,0,' '),(73,NULL,'DISPONIBLE','798302105027',73,0,' '),(74,NULL,'DISPONIBLE','798302107045',74,0,' '),(75,NULL,'DISPONIBLE','798302107069',75,0,' '),(76,NULL,'DISPONIBLE','798302161887',76,0,' '),(77,NULL,'DISPONIBLE','798302162020',77,0,' '),(78,NULL,'DISPONIBLE','798302167148',78,0,' '),(79,NULL,'DISPONIBLE','798302167162',79,0,' '),(80,NULL,'DISPONIBLE','798302167414',80,0,' '),(81,NULL,'DISPONIBLE','798302169883',81,0,' '),(82,NULL,'DISPONIBLE','798302201767',82,0,' '),(83,NULL,'DISPONIBLE','798305101682',83,0,' '),(84,NULL,'DISPONIBLE','811571016518',84,0,' '),(85,NULL,'DISPONIBLE','88654000033',85,0,' '),(86,NULL,'DISPONIBLE','886540001406',86,0,' '),(87,NULL,'DISPONIBLE','886540002724',87,0,' '),(88,NULL,'DISPONIBLE','886540003417',88,0,' '),(89,NULL,'DISPONIBLE','886540003554',89,0,' '),(90,NULL,'DISPONIBLE','886540003578',90,0,' '),(91,NULL,'DISPONIBLE','886540003936',91,0,' '),(92,NULL,'DISPONIBLE','886540004056',92,0,' '),(93,NULL,'DISPONIBLE','886540004087',93,0,' '),(94,NULL,'DISPONIBLE','886540004179',94,0,' '),(95,NULL,'DISPONIBLE','886540004254',95,0,' '),(98,NULL,'DISPONIBLE','798302168343',105,0,' '),(99,NULL,'DISPONIBLE','798323162733',106,0,' '),(102,NULL,'DISPONIBLE','7702018023721',108,1,' '),(103,NULL,'DISPONIBLE','7401007602243',109,0,' '),(104,'A00187','DISPONIBLE','886540004032',110,2,' BK NEGRO'),(105,'A00189','DISPONIBLE','886540004056',110,2,'PK ROSADO'),(107,'INC1608510189','DISPONIBLE','798302071629',112,3,'BK NEGRO'),(108,'INC 1602500569','DISPONIBLE','798302071636',112,1,'WH BLANCO'),(109,'347456','DISPONIBLE','025215495106',113,0,'RED'),(110,'347455','DISPONIBLE','025215495090',113,0,'PNK'),(111,'CEC-5','DISPONIBLE','025215496516',114,4,'COMBO 5'),(112,'CEC-6','DISPONIBLE','025215496523',114,3,'COMBO 6');
/*!40000 ALTER TABLE `detalle_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_servicio`
--

DROP TABLE IF EXISTS `detalle_servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_servicio` (
  `iddetalle_servicio` int(11) NOT NULL AUTO_INCREMENT,
  `Servicio` int(11) DEFAULT '1',
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `total` double DEFAULT '0',
  PRIMARY KEY (`iddetalle_servicio`),
  KEY `fk_servicio_detalle_idx` (`Servicio`),
  CONSTRAINT `fk_servicio_detalle` FOREIGN KEY (`Servicio`) REFERENCES `servicio` (`idServicio`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_servicio`
--

LOCK TABLES `detalle_servicio` WRITE;
/*!40000 ALTER TABLE `detalle_servicio` DISABLE KEYS */;
REPLACE INTO `detalle_servicio` (`iddetalle_servicio`, `Servicio`, `fecha`, `total`) VALUES (8,1,'2018-11-03 18:50:28',200),(10,2,'2018-11-03 19:29:34',82),(11,3,'2018-11-03 19:29:36',50),(12,1,'2018-11-04 20:31:16',25),(13,2,'2018-11-04 20:31:24',25),(14,3,'2018-11-04 20:31:29',82),(15,1,'2018-11-08 18:40:26',12);
/*!40000 ALTER TABLE `detalle_servicio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devolucion`
--

DROP TABLE IF EXISTS `devolucion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `devolucion` (
  `idDevolucion` int(11) NOT NULL AUTO_INCREMENT,
  `Detalle_devolucion` varchar(150) NOT NULL,
  `Identificacion_producto` int(11) NOT NULL,
  `id_factura` int(11) NOT NULL,
  PRIMARY KEY (`idDevolucion`),
  KEY `facturafk_idx` (`id_factura`),
  KEY `factura_dev_fk_idx` (`id_factura`),
  KEY `fk_producto_devolucion_idx` (`Identificacion_producto`),
  CONSTRAINT `fk_factura_devolucion` FOREIGN KEY (`id_factura`) REFERENCES `factura` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_producto_devolucion` FOREIGN KEY (`Identificacion_producto`) REFERENCES `productos` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devolucion`
--

LOCK TABLES `devolucion` WRITE;
/*!40000 ALTER TABLE `devolucion` DISABLE KEYS */;
REPLACE INTO `devolucion` (`idDevolucion`, `Detalle_devolucion`, `Identificacion_producto`, `id_factura`) VALUES (1,'SALIO DESCARGADA',42,53);
/*!40000 ALTER TABLE `devolucion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devolucion_clientes`
--

DROP TABLE IF EXISTS `devolucion_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `devolucion_clientes` (
  `idDevolucionClientes` int(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` varchar(30) NOT NULL,
  `id_devolucion` int(11) NOT NULL,
  PRIMARY KEY (`idDevolucionClientes`),
  KEY `id_cliente` (`id_cliente`),
  KEY `fk_devclientes_devolucion_idx` (`id_devolucion`),
  KEY `fk_devc_dev_ibfk3_idx` (`id_devolucion`),
  CONSTRAINT `devolucion_clientes_ibfk_2` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`ruc`),
  CONSTRAINT `fk_devc_dev_ibfk3` FOREIGN KEY (`id_devolucion`) REFERENCES `devolucion` (`idDevolucion`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1 COMMENT='	';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devolucion_clientes`
--

LOCK TABLES `devolucion_clientes` WRITE;
/*!40000 ALTER TABLE `devolucion_clientes` DISABLE KEYS */;
REPLACE INTO `devolucion_clientes` (`idDevolucionClientes`, `id_cliente`, `id_devolucion`) VALUES (1,'1234',1);
/*!40000 ALTER TABLE `devolucion_clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devolucion_proveedores`
--

DROP TABLE IF EXISTS `devolucion_proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `devolucion_proveedores` (
  `idDevolucionProveedores` int(11) NOT NULL AUTO_INCREMENT,
  `id_proveedor` varchar(30) NOT NULL,
  `id_devolucion` int(11) NOT NULL,
  PRIMARY KEY (`idDevolucionProveedores`),
  KEY `id_proveedor` (`id_proveedor`),
  CONSTRAINT `devolucion_proveedores_ibfk_2` FOREIGN KEY (`id_proveedor`) REFERENCES `proveedor` (`ruc`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devolucion_proveedores`
--

LOCK TABLES `devolucion_proveedores` WRITE;
/*!40000 ALTER TABLE `devolucion_proveedores` DISABLE KEYS */;
REPLACE INTO `devolucion_proveedores` (`idDevolucionProveedores`, `id_proveedor`, `id_devolucion`) VALUES (1,'17101997',6);
/*!40000 ALTER TABLE `devolucion_proveedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresa`
--

DROP TABLE IF EXISTS `empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empresa` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresa`
--

LOCK TABLES `empresa` WRITE;
/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
REPLACE INTO `empresa` (`codigo`, `nombre`) VALUES (1,'LIBRERIA PARRA JUNIOR'),(2,'LIBRERIA PARRA #2');
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_hora` datetime NOT NULL,
  `empresa` int(11) NOT NULL,
  `cliente` varchar(30) NOT NULL,
  `total` float NOT NULL,
  `tipo_pago` enum('CONTADO','TARJETA','PAYPHONE','CHEQUE','CREDITO') NOT NULL,
  `descripcion_pago` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `empresafk` (`empresa`),
  KEY `clientefk` (`cliente`),
  CONSTRAINT `clientefk` FOREIGN KEY (`cliente`) REFERENCES `cliente` (`ruc`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `empresafk` FOREIGN KEY (`empresa`) REFERENCES `empresa` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=85 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
REPLACE INTO `factura` (`codigo`, `fecha_hora`, `empresa`, `cliente`, `total`, `tipo_pago`, `descripcion_pago`) VALUES (35,'2017-08-14 09:51:44',1,'1234',135,'CONTADO','CONTADO'),(36,'2017-08-05 18:31:13',1,'1234',270,'CONTADO','CONTADO'),(37,'2017-08-13 15:05:00',1,'1234',100,'CONTADO','CONTADO'),(38,'2017-08-14 12:19:07',1,'1234',135,'CONTADO','CONTADO'),(39,'2017-08-14 12:42:39',1,'1234',135,'CONTADO','CONTADO'),(40,'2017-08-14 16:52:13',1,'1234',135,'CONTADO','CONTADO'),(41,'2017-08-14 16:53:52',1,'1234',100,'CONTADO','CONTADO'),(42,'2017-08-15 15:43:35',1,'1234',510,'CONTADO','CONTADO'),(43,'2017-08-24 19:55:13',1,'1234',135,'CONTADO','CONTADO'),(44,'2017-08-24 20:15:12',1,'1234',110,'CONTADO','CONTADO'),(45,'2017-08-24 20:24:51',1,'1234',100,'CONTADO','CONTADO'),(46,'2017-09-01 08:36:03',1,'1234',510,'CONTADO','CONTADO'),(47,'2017-09-14 11:14:34',1,'1234',235,'CONTADO','CONTADO'),(48,'2017-09-14 11:19:24',1,'1234',235,'CONTADO','CONTADO'),(49,'2017-09-14 11:22:05',1,'1234',65,'CONTADO','CONTADO'),(50,'2017-09-14 13:06:54',1,'1234',365,'CONTADO','CONTADO'),(51,'2017-09-14 13:13:03',1,'1234',350,'CONTADO','CONTADO'),(52,'2018-10-20 15:15:36',1,'1234',100,'CONTADO','CONTADO'),(53,'2018-10-20 15:17:34',1,'1234',100,'CONTADO','CONTADO'),(54,'2018-10-20 17:46:31',1,'1234',100,'CONTADO','CONTADO'),(55,'2018-10-23 14:57:21',1,'1234',340,'CONTADO','CONTADO'),(56,'2018-10-24 21:42:50',1,'1234',23,'CONTADO','CONTADO'),(57,'2018-10-31 11:42:09',1,'1234',170,'CONTADO','CONTADO'),(58,'2018-10-31 12:24:07',1,'1234',15,'CONTADO','CONTADO'),(59,'2018-11-01 13:08:10',1,'1234',125,'CONTADO','CONTADO'),(60,'2018-11-01 13:30:04',1,'1234',300,'CONTADO','CONTADO'),(61,'2018-11-01 13:33:48',1,'1234',650,'CONTADO','CONTADO'),(62,'2018-11-01 14:10:45',1,'1234',5250,'CONTADO','CONTADO'),(63,'2018-11-01 14:14:59',1,'1234',220,'CONTADO','Tarjeta Tran. No. 150'),(64,'2018-11-01 14:16:06',1,'1234',190,'CONTADO','Payphone Trans. No.1'),(65,'2018-11-01 14:42:14',1,'1234',184,'CONTADO','CONTADO'),(66,'2018-11-01 14:58:07',1,'1234',6450,'CONTADO','CONTADO'),(67,'2018-11-01 15:19:33',1,'1234',1349,'CONTADO','CONTADO'),(68,'2018-11-01 15:31:26',1,'17101997',15,'CONTADO','CREDITO:ALMACENES JERUSALEM'),(69,'2018-11-01 15:55:22',1,'1234',380,'TARJETA','Tarjeta Tran. No. 165'),(70,'2018-11-01 16:07:18',1,'1234',510,'CONTADO','CONTADO'),(71,'2018-11-01 16:10:57',1,'1234',12000,'PAYPHONE','Payphone Trans. No.2'),(72,'2018-11-01 16:37:54',1,'1234',8500,'CONTADO','CONTADO'),(73,'2018-11-03 13:48:57',1,'1234',340,'CONTADO','CONTADO'),(74,'2018-11-03 14:19:17',1,'1234',285,'CONTADO','CONTADO'),(75,'2018-11-03 14:25:46',1,'1234',6750,'CONTADO','CONTADO'),(76,'2018-11-03 16:08:43',1,'1234',600,'CONTADO','CONTADO'),(77,'2018-11-03 16:21:12',1,'1234',413,'CONTADO','CONTADO'),(78,'2018-11-03 16:21:40',1,'1234',10800,'CONTADO','CONTADO'),(79,'2018-11-04 11:36:31',1,'1234',7125,'CONTADO','CONTADO'),(80,'2018-11-08 16:14:02',1,'1234',600,'CONTADO','CONTADO'),(81,'2018-11-08 16:14:54',1,'1234',300,'CONTADO','CONTADO'),(82,'2018-11-08 16:18:53',1,'1234',300,'CONTADO','CONTADO'),(83,'2018-11-08 16:19:19',1,'1234',300,'CONTADO','CONTADO'),(84,'2018-11-08 16:19:55',1,'1234',300,'CONTADO','CONTADO');
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gastos`
--

DROP TABLE IF EXISTS `gastos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gastos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` float NOT NULL,
  `descripción` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gastos`
--

LOCK TABLES `gastos` WRITE;
/*!40000 ALTER TABLE `gastos` DISABLE KEYS */;
REPLACE INTO `gastos` (`id`, `cantidad`, `descripción`, `fecha`) VALUES (1,20,'s','2017-08-13'),(2,1000,'d','2017-08-08'),(3,100,'YESSER PUTITO','2017-08-14'),(4,200,'CAFE','2017-08-14'),(5,30000,'PAGO ALQUILER','2018-10-31'),(6,300,'SE COMPRO LIMPIA PISOS Y LIMPIA VIDRIO CON FACTURA COLONIA 223345','2018-11-03'),(7,200,'SE COMPRO UN AZISTIN CON FACTURA DE LA COLONIA 09867','2018-11-04');
/*!40000 ALTER TABLE `gastos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marca` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
REPLACE INTO `marca` (`codigo`, `nombre`) VALUES (1,'MAXELL'),(2,'SAMSUNG'),(3,'EPSON'),(4,'KLIP EXTREME'),(5,'NEXXT'),(6,'MAPED'),(7,'BARRILITO'),(8,'POINTER'),(9,'TUCAN'),(10,'CASIO'),(11,'KORES'),(12,'PAPERMATE'),(13,'FABER CASTEL'),(14,'VINCI'),(15,'UNIVERSAL'),(16,'MAE'),(17,'XTECH'),(18,'FORZA'),(19,'ARGOM TECH'),(20,'LOGITECH'),(21,'KINGSTON'),(22,'VERBATIM'),(23,'GENIUS'),(24,'GOOGLE'),(25,'ADATA'),(26,'XINWEI'),(27,'STABILO');
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagos`
--

DROP TABLE IF EXISTS `pagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pagos` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `monto` float NOT NULL,
  `codigo_credito` int(11) NOT NULL,
  PRIMARY KEY (`codigo`),
  KEY `creditofk` (`codigo_credito`),
  CONSTRAINT `creditofk` FOREIGN KEY (`codigo_credito`) REFERENCES `credito` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagos`
--

LOCK TABLES `pagos` WRITE;
/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
REPLACE INTO `pagos` (`codigo`, `fecha`, `hora`, `monto`, `codigo_credito`) VALUES (1,'2017-01-02','17:00:00',5000,1),(3,'2017-09-11','16:24:00',7000,1),(5,'2017-01-02','00:00:00',12000,3),(6,'2017-09-21','16:40:00',6000,4),(7,'2017-09-28','17:30:00',2000,5),(8,'2017-09-15','11:32:00',2000,6),(9,'2017-09-29','12:40:00',1000,6),(10,'2017-08-23','17:40:00',10000,8),(11,'2017-09-08','13:16:00',10000,9),(12,'2017-01-02','00:00:00',3000,9),(13,'2017-01-02','00:00:00',9000,9),(14,'2017-01-02','00:00:00',2000,7);
/*!40000 ALTER TABLE `pagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagos_trabajadores`
--

DROP TABLE IF EXISTS `pagos_trabajadores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pagos_trabajadores` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` float NOT NULL,
  `cedula` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `cedula` (`cedula`),
  CONSTRAINT `pagos_trabajadores_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `trabajadores` (`cedula`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagos_trabajadores`
--

LOCK TABLES `pagos_trabajadores` WRITE;
/*!40000 ALTER TABLE `pagos_trabajadores` DISABLE KEYS */;
REPLACE INTO `pagos_trabajadores` (`id`, `cantidad`, `cedula`, `fecha`) VALUES (8,45443,'615-171097-0001W','2017-08-18'),(9,3641,'615-171097-0001W','2018-10-31'),(10,3641,'281-311083-0005Y','2018-11-03'),(11,3641,'615-171097-0001W','2018-11-04');
/*!40000 ALTER TABLE `pagos_trabajadores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productos` (
  `id_producto` int(11) NOT NULL AUTO_INCREMENT,
  `ubicacion` varchar(10) DEFAULT NULL,
  `nombre` varchar(60) NOT NULL,
  `caracteristica` varchar(100) DEFAULT NULL,
  `precio` float NOT NULL,
  `stock` int(11) DEFAULT NULL,
  `marca` int(11) NOT NULL,
  `presentacion` enum('UNIDAD','DOCENA','RESMA','CAJA','PAQUETE','SERVICIOS','OTROS') NOT NULL,
  `proveedor` varchar(30) NOT NULL,
  `categoria` int(11) NOT NULL,
  PRIMARY KEY (`id_producto`),
  KEY `proveedorfk` (`proveedor`),
  KEY `marcafk` (`marca`),
  KEY `fk_pc` (`categoria`),
  CONSTRAINT `fk_producto_categoria` FOREIGN KEY (`categoria`) REFERENCES `categoria` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_producto_marca` FOREIGN KEY (`marca`) REFERENCES `marca` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_producto_proveedor` FOREIGN KEY (`proveedor`) REFERENCES `proveedor` (`ruc`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=115 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
REPLACE INTO `productos` (`id_producto`, `ubicacion`, `nombre`, `caracteristica`, `precio`, `stock`, `marca`, `presentacion`, `proveedor`, `categoria`) VALUES (1,'EST_MAXELL','IMPRESORA L220','IMPRIME, COPIA, ESCANEA',7500,12,3,'UNIDAD','17101997',1),(2,'EST_MAXELL','IMPRESORA L365','INALAMBRICA, IMPRIME, COPIA, ESCANEA',8500,13,3,'UNIDAD','17101997',1),(3,'EST_MAXELL','IMPRESORA L575','INALAMBRICA,  IMPRIME, COPIA, ESCANEA, FAX, ETHERNET',12000,6,3,'UNIDAD','17101997',1),(4,'EST_2','MEMORIA MICRO SD','PREMIUM MICRO, 8 GB, ADAPTADOR SD',170,6,22,'UNIDAD','J0310000543672',1),(5,'EST_2','MEMORIA MICRO SD','32 GB',450,25,22,'UNIDAD','J0310000543672',1),(6,'EST_2','MEMORIA USB PINSTRIPE','32 GB, USB 3.0',300,6,22,'UNIDAD','J0310000543672',1),(7,'EST_2','MEMORIA USB PINSTRIPE','64 GB, USB 2.0',650,6,22,'UNIDAD','J0310000543672',1),(8,'EST_2','MEMORIA USB V3 STORE N GO ','16 GB, USB 3.0',380,6,22,'UNIDAD','J0310000543672',1),(9,'EST_2','MEMORIA USB SWIVEL','16 GB USB 2.0',220,6,22,'UNIDAD','J0310000543672',1),(10,'EST_2','DISCO DURO EXTERNO STORE N GO','2 TB, USB 3.0, 2,5 PULG',6000,6,22,'UNIDAD','17101997',1),(11,'EST_2','DISCO DURO EXTERNO STORE N GO 97395','1 TB, USB 3.0, PORTABLE ',3650,6,22,'UNIDAD','17101997',1),(12,'EST_2','NANO USB FLASH DRIVE STORE N GO ','16 GB, USB 2.0, USB FLASH',180,6,22,'UNIDAD','J0310000543672',1),(13,'EST_2','MEMORIA USB DOG TAG','16 GB ESTILO CADENA ',250,5,22,'UNIDAD','J0310000543672',1),(14,'EST_2','MEMORIA USB DOG TAG','16 GB ESTILO CADENA CON ETIQUETA',370,6,22,'UNIDAD','J0310000543672',1),(15,'EST_2','MEMORIA USB SLIDER','8 GB, USB 2.0',150,6,22,'UNIDAD','J0310000543672',1),(16,'EST_2','MEMORIA USB DUAL STORE N GO ','16 GB, SMARTPHONE Y PC, DISPOSITIVOS CON OTG FLASH',300,5,22,'UNIDAD','17101997',1),(17,'EST_MAXELL','AUDIFONOS JUICY TUNES JT-P','CABLE DE 1.2  CON SENSIBILIDAD DE 100 DB',135,5,1,'UNIDAD','17101997',1),(18,'EST_MAXELL','AUDIFONOS JELLEEZ EB-WT','FONES DE OUVIDIO',125,6,1,'UNIDAD','17101997',1),(19,'EST_MAXELL','AUDIFONOS JINX JEB-WH','SENSIBILIDAD 100DB',135,6,1,'UNIDAD','17101997',1),(20,'EST_MAXELL','AUDIFONOS PLEGABLES H-MIC','MICROFONO DESMONTABLE CONTROL DE PLAYBACK',235,6,1,'UNIDAD','17101997',1),(21,'EST_MAXELL','MOUSE MOWL-200','INALAMBRICO PARA VIAJES Y RECEPTOR MICROUSB',510,6,1,'UNIDAD','17101997',1),(22,'EST_MAXELL','AUDIFONOS PLUGS IN-225','CON BOTON Y SENSIBILIDAD DE 94 DB',110,6,1,'UNIDAD','17101997',1),(23,'EST_MAXELL','AURICULAR ESTEREO EB-95','SONIDO ESTEREO DE BOTON CON SENSIBILIDAD DE 95 DB',65,6,1,'UNIDAD','17101997',1),(24,'EST_MAXELL','MOUSE MOWR-101','OPTICO CON USB 1000 DPI ERGONOMICO',195,6,1,'UNIDAD','17101997',1),(25,'EST_MAXELL','AURICULAR ESTEREO EB-MIC','SONIDO ESTEREO DE BOTON CON MICROFONO',95,6,1,'UNIDAD','17101997',1),(26,'EST_MAXELL','AURICULARES PLUGS MIC IN-MIC','DE BOTONO CON MICROFONO SENSIBILIDAD DE 40DB',135,6,1,'UNIDAD','17101997',1),(27,'EST_2','SISTEMA DE SONIDO SS-400','2.1 CANALES, 200 WATTS PMP0',1050,6,1,'UNIDAD','J0310000543672',1),(28,'EST_MAXELL','CABLE MICROUSB MUSB-600-6FT-CABLEORG','CON ADAPTADOR DE PARED',350,6,1,'UNIDAD','17101997',1),(29,'EST_MAXELL','AUDIFONOS PURE FITNESS EB-ESB','MICROFONO CON CONTROL DE VOLUMEN',395,6,1,'UNIDAD','17101997',1),(31,'EST_MAXELL','AUDIFONOS WUD-5','BAJOS PROFUNDOS CUBIERTA DE MADERA',340,1,1,'UNIDAD','J0310000543672',1),(32,'EST_MAXELL','AURICULARES WIRED RETRO EARPHONES WIR-90','DE OIDO INTERNO CONTROL DE VOLUMEN Y MICROFONO',380,6,1,'UNIDAD','17101997',1),(33,'EST_MAXELL','CARGADOR PORTATIL MUSB-KC','USB A MICROUSB CHARGE & SYNC FLEXIBLE',190,6,1,'UNIDAD','17101997',1),(34,'EST_MAXELL','AUDIFONOS DUAL COLOR','CONECTOR PARA COMPARTIR - EARBUDS COMBO',300,6,1,'UNIDAD','17101997',1),(35,'EST_MAXELL','CONEXION METALICA MUSB-LTR','MICROUSB A USB 15 CM',235,6,1,'UNIDAD','17101997',1),(36,'EST_MAXELL','AUDIFONOS DJ-21','PLEGABLES CON MICROFONO BAJOS PROFUNDOS',460,6,1,'UNIDAD','17101997',1),(37,'EST_MAXELL','AUDIFONOS REFLEKT REFL LIME ','CONTROL MULTIMEDIA MICROFONO BAJOS PROFUNDOS',340,6,1,'UNIDAD','17101997',1),(38,'EST_MAXELL','LUZ LED LIGHT USB','CONECTOR USB PARA PC CON LUZ LED',95,6,1,'UNIDAD','J0310000543672',1),(39,'EST_2','MICROPARLANTES SS-120','1.5 WATTS X 2, USB, 3.5 MM',350,6,1,'UNIDAD','J0310000543672',1),(40,'EST_MAXELL','AURICULARES GRIP HEADPHONES K-100','MICROFONO CON CONTROL DE VOLUMEN CON ALMOHADILLAS',460,6,1,'UNIDAD','17101997',1),(41,'EST_MAXELL','AUDIFONOS SOLID EB-BT100','INALAMBRICO BLUETOOTH CON CONTROL DE MULTIMEDIA',650,6,1,'UNIDAD','17101997',1),(42,'EST_MAXELL','PILAS ALCALINAS 6LF22-1BP','9 VOLTIOS',100,6,1,'UNIDAD','17101997',1),(43,'EST_MAXELL','PILAS ALCALINAS D LR20-2BP','1.5 VOLTIOS',95,6,1,'UNIDAD','17101997',1),(44,'EST_MAXELL','PILAS MICRO-LITHIUM CELL CR2032','3 VOLTIOS',20,6,1,'UNIDAD','17101997',1),(45,'EST_MAXELL','PILAS RECARGABLES AA MH6-2BP','1.2 VOLTIOS',185,6,1,'UNIDAD','17101997',1),(46,'EST_MAXELL','PILAS ALCALINAS AAA LR03-2BP','1.5 VOLTIOS',25,6,1,'UNIDAD','17101997',1),(47,'EST_MAXELL','PILAS ALCALINAS AA LR6-2BP','1.5 VOLTIOS ',25,6,1,'UNIDAD','17101997',1),(48,'EST_MAXELL','AUDIFONOS CONNECT IN-345','MICROFONO SONIDO PRECISO 3.5MM',175,6,1,'UNIDAD','J0310000543672',1),(49,'EST_2','PARLANTES STEREO SP-U115','DIFERENTES COLORES USB',300,6,23,'UNIDAD','J0310000543672',1),(50,'EST_2','PARLANTES MULTIMEDIA XTS120','USB 2.0 4 WATTS 5V 70DB ',155,6,17,'UNIDAD','17101997',1),(51,'EST_2','DISCO DURO EXTERNO HM900','4TB 3.5 PULG ',8250,6,25,'UNIDAD','17101997',1),(52,'EST_2','DISCO DURO EXTERNO HV620 LED','1 TB, 2,5 PULG',3000,6,25,'UNIDAD','17101997',1),(53,'EST_2','REGLETA PS-001B','INTERRUPTOR DE CORTOCIRCUITO, 6 ENTRADAS, PARA PARED',120,6,18,'UNIDAD','101092',1),(54,'EST_2','PROTECTOR DE SOBRETENSION RSO-08T','6 ENTRADAS ROTATIVAS, ORGANIZADOR DE CABLES',640,6,18,'UNIDAD','17101997',1),(55,'EST_2','TARJETA DE RED USB AULUB155U2','USB, VELOCIDAD 150 MBPS, CRIPTOGRAFIA WEP',340,6,5,'UNIDAD','17101997',1),(56,'EST_2','AMPLIFICADOR DE SEÑAL KRONOS 300 AEIEL304U1','CONECCION A CORRIENTE, VELOCIDAD DE 200 MBPS, ALCANCE 300 MTS',1150,6,5,'UNIDAD','17101997',1),(57,'EST_2','AMPLIFICADOR DE RED SPARX200 AEREL204U2','2 ADAPTADORES, VELOCIDAD 200 MBPS, ALCANCE 300 MTS',2000,6,5,'UNIDAD','17101997',1),(58,'EST_2','CONCENTRADOR USB HUB KUH-400','4 PUERTOS USB 2.0, VELOCIDAD ALTA 480 MBPS',240,6,4,'UNIDAD','101092',1),(60,'EST_2','PARLANTES EKLIPSE KES-215C','ESTEREO 2.0',420,6,4,'UNIDAD','101092',1),(61,'EST_2','POWERBANK KBH-170','LINTERNA, 2 PUERTOS USB, CAPACIDAD 7500 MAH',900,6,4,'UNIDAD','17101997',1),(62,'EST_2','PARLANTES VISION AIRE KWS-610','BLUETOOTH 6 WATTS',1580,6,4,'UNIDAD','17101997',1),(63,'EST_2','PARLANTE KWS-602','RESISTENTE AL AGUA',1116,6,4,'UNIDAD','101092',1),(64,'EST_2','RECEPTOR INALAMBRICO ZOUNDKAST KWA-110','BLUETOOTH, 10 MTS2',800,6,4,'UNIDAD','17101997',1),(65,'EST_2','POWERBANK USB DOBLE PARA AUTO KMA-210','BATERIA PORTATIL, ADAPTADOR CA 2500 MAH',800,6,4,'UNIDAD','17101997',1),(66,'EST_2','PARLANTES PRIZM KWS-580','BLUETOOTH, REPRODUCCION 4HRS, RECARGABLE, MANOS LIBRES',580,6,4,'UNIDAD','101092',1),(67,'EST_2','PARLANTE KROMATIK KWS-612','BLUETOOTH, POTENCIA 10 WATTS, 4000 MAH, CARACTERISTICA POWERBANK',2300,6,4,'UNIDAD','101092',1),(68,'EST_2','PARLANTE REFLEXION KWS-608GD ','BLUETOOTH, RICO EN BAJOS, CUBIERTA METALICA',1200,6,4,'UNIDAD','17101997',1),(69,'EST_2','PARLANTE ENKORE KWS-611','BLUETOOTH, LUZ LED NFC',1450,6,4,'UNIDAD','17101997',1),(70,'EST_2','REGULADOR DE VOLTAJE FVR-1211B','8 ENTRADAS, MARGEN DE TENSION: 86-138VCA',460,6,18,'UNIDAD','17101997',1),(71,'EST_2','PROTECTOR DE VOLTAJE ZION-2K30','CORRIENTE DE PROTECCION MAX 18000A, INTERRUPTOR ENCENDIDO/APAGADO, ESPERA 15 SEG',480,6,1,'UNIDAD','101092',1),(72,'EST_2','REGULADOR DE VOLTAJE FVR-3001','4 ENTRADAS, MARGEN DE TENSION: 104-126 VCA',1000,6,18,'UNIDAD','17101997',1),(73,'EST_2','UPS SL-1011LCD','LCD, USB, RESPALDO DE ENERGIA 30 MIN',3950,6,18,'UNIDAD','101092',1),(74,'EST_2','PROTECTOR DE SOBRETENSION 6 SALIDAS FWT-760USB','PUERTOS USB, TAPA DESLIZABLE, 6 TOMACORRIENTES, 300 JULIOS',365,6,18,'UNIDAD','101092',1),(75,'EST_2','PROTECTOR DE SOBRETENSION 6 SALIDAS FWT-660','DUPLEX EN 6 ENTRADAS, POLO TIERRA, CORRIENTE 15A',125,6,18,'UNIDAD','17101997',1),(76,'EST_2','MULTIPLICADOR DE HDMI XHA-410','1 PUERTO HDMI HEMBRA ENTRADA, 4 PUERTOS HDMI HEMBRA DE SALIDA',1120,6,17,'UNIDAD','17101997',1),(77,'EST_2','VISOR DE REALIDAD VIRTUAL XTV-300','PARA SMAARTPHONES, CAPACIDAD DE HASTA 6 PULG, FORMATO SBS VR',480,6,17,'UNIDAD','17101997',1),(78,'EST_2','EXTENSION USB XTC-306','USB 2.0 USB MACHO A HEMBRA 4.5 MTS 480 MBPS',80,6,17,'UNIDAD','101092',1),(79,'EST_2','CABLE VGA XTC-308','30 AWG 720P 1.8 MTS VGA MACHO A MACHO',70,6,17,'UNIDAD','17101997',1),(80,'EST_2','ADAPTADOR HDMI XTC-333','HDMI HEMBRA A HDMI HEMBRA EXTENSION',85,6,17,'UNIDAD','17101997',1),(81,'EST_2','CAMARA WEB PARA COMPUTADORA XTV-100','USB WEBCAM, RESOLUCION 6324X4742, ILUMINACION LED',250,6,17,'UNIDAD','17101997',1),(82,'EST_2','PROTECTOR DE SOBRETENSION FSP-06MN','6 ENTRADAS, TENSION DE ALIMENTACION 120-240',340,6,18,'UNIDAD','17101997',1),(83,'EST_2','PROTECTOR DE VOLTAJE ZION-2K10','PROTECCION DE PICOS, 1800 A, INTERRUPTOR ENCENDIDO/APAGADO, ESPERA 180 SEG',400,6,18,'UNIDAD','101092',1),(84,'EST_2','CHROMECAST NC2-GA5','VIDEO 1080P FULL HD, 24/56HZ DE WIFI, MULTIPLES DISPOSITIVOS',2420,6,24,'UNIDAD','17101997',1),(85,'EST_2','LECTOR DE TARJETAS ARG-CT-0088','LECTOR UNIVERSAL CON DIFERENTES ENTRADAS 88R',200,6,19,'UNIDAD','17101997',1),(86,'EST_2','PARLANTES MULTIMEDIA ARG-SP-1020','USB 2.0 3 WATTS 3.5 MM',250,6,19,'UNIDAD','17101997',1),(87,'EST_2','CAJA PARA DISCO DURO ARG-AC-1030','SATA 2.5, USB 2.0 , VELOCIDAD 480 MBPS',230,6,19,'UNIDAD','17101997',1),(88,'EST_2','BASTON SELFIE ARG-AC-9175L','CABEZAL AJUSTABLE, BLUETOOTH, BASTON EXTENDIBLE',300,6,19,'UNIDAD','17101997',1),(89,'EST_2','CARGADOR USB PARA PARED ARG-AC-0105','DOBLE USB, VOLTAJE 100 - 240 V',200,6,19,'UNIDAD','17101997',1),(90,'EST_2','POWERBANK ARG-AC-0233C','CAPACIDAD 2500MAH, 1 PUERTO USB',250,6,19,'UNIDAD','17101997',1),(91,'EST_2','ADAPTADOR ARG-CB-0054','MICRO HDMI A HDMI 15 CM',350,6,19,'UNIDAD','17101997',1),(93,'EST_2','POWERBANK ARG-PB-1106','CAPACIDAD 6000MAH, 1 PUERTO USB',480,6,19,'UNIDAD','17101997',1),(94,'EST_2','AQUA BEATS ARG-SP-2801','RESISTENTE AL AGUA, 10 MTS',420,6,19,'UNIDAD','17101997',1),(95,'EST_2','PARLANTES ARG-SP-3040','LUCES LED, 1200 MAH BLUETOOTH',950,6,19,'UNIDAD','17101997',1),(96,'EST_2','PRUEBA','PRUEBA',1,6,4,'UNIDAD','17101997',1),(97,'VITRINA_2','LAPICERO BILLE 508N','PUNTA FINA HI FLUX TECHNOLOGY',16,6,27,'UNIDAD','8081991',2),(98,'EST_1','BOTELLA','AZUL',22,6,16,'UNIDAD','101092',2),(99,'EST_2','B','AZUL',22,6,16,'UNIDAD','101092',1),(105,'EST_2','AUTO SWITCH HDMI XTA300','PLUG AND PLAY, 1080 P RESOLUCION, MODO SELECCION AUTOMATICO, 3 ENTRADAS HDMI, 1 SALIDA',340,6,17,'UNIDAD','17101997',1),(106,'EST_2','ADAPTADOR HDMI VGA XTC361','RESOLUCION1080, HDMI MACHO A VGA HEMBRA CON PUERTO MICRO USB',600,5,17,'UNIDAD','17101997',1),(109,'VITRINA_2','GOMA ESCOLAR','DOBLE PUNTA, BLANCO, LAVABLE, NO TOXICO, 50  GMS',15,6,9,'UNIDAD','J0310000543672',2),(110,'EST_2','POWERBANK ARG-PB-1104','4000 MAH, RECARGABLE, PUERTO MICRO USB',435,5,19,'UNIDAD','17101997',1),(112,'EST_2','PARLANTE KWS-605','BLUETOOTH 3.0, NFC',1350,3,4,'UNIDAD','101092',1),(113,'EST_MAXELL','MICRO AUDIFONOS INNE-300','MICROFONO, 4.8MM, ULTRA LIVIANO, COMODO',300,2,1,'UNIDAD','8081991',1),(114,'EST_MAXELL','AUDIFONOS DUAL COLOR','CONECTOR PARA COMPARTIR',300,1,1,'UNIDAD','8081991',1);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedor` (
  `ruc` varchar(30) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `direccion` varchar(100) NOT NULL,
  `telefono` varchar(9) NOT NULL,
  `email` varchar(50) NOT NULL,
  PRIMARY KEY (`ruc`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
REPLACE INTO `proveedor` (`ruc`, `nombre`, `direccion`, `telefono`, `email`) VALUES ('101092','LIBRERIA UNIVERSAL','MANAGUA','2311-6753','LIBRERIA.UNIVERSAL@GMAIL.COM'),('17101997','COMERCIAL ALTASA','MANAGUA','87972337','marlon.altamirano97@gmail'),('2811709810001W','TAIZ','MNAGUA','2311-3453','TAIZ@GMAIL.COM'),('2812005950008R','LIBRERIA PARRA JUNIOR','LEON','23195104','libreriaparrajunior16@gmail.com'),('8081991','LIBRERIA JARDIN','MANAGUA','2311-4567','LIBRERIA.JARDIN@GMAIL.COM'),('J0310000543672','GONPER LIBRERIAS','MANAGUA','2311-6754','CONTACTO@GONPERLIBRERIAS.COM.NI');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicio`
--

DROP TABLE IF EXISTS `servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `servicio` (
  `idServicio` int(11) NOT NULL AUTO_INCREMENT,
  `NombreServicio` varchar(45) NOT NULL,
  `DescripcionServicio` varchar(100) NOT NULL,
  PRIMARY KEY (`idServicio`),
  UNIQUE KEY `NombreServicio_UNIQUE` (`NombreServicio`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicio`
--

LOCK TABLES `servicio` WRITE;
/*!40000 ALTER TABLE `servicio` DISABLE KEYS */;
REPLACE INTO `servicio` (`idServicio`, `NombreServicio`, `DescripcionServicio`) VALUES (1,'IMPRESORA','IMPRESIONES/FOTOCOPIAS/DIGITALIZACIONES'),(2,'INTERNET','LEVANTADO TEXTO/BUSQUEDA IMAGENES/CREACION DOCUMENTOS'),(3,'MANTENIMIENTO','MANTENIMIENTO ELECTRONICO');
/*!40000 ALTER TABLE `servicio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trabajadores`
--

DROP TABLE IF EXISTS `trabajadores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trabajadores` (
  `cedula` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `nombre` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `apellido` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `telefono` varchar(9) COLLATE utf8_unicode_ci NOT NULL,
  `salario` float NOT NULL,
  `fecha_entrada` date NOT NULL,
  PRIMARY KEY (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trabajadores`
--

LOCK TABLES `trabajadores` WRITE;
/*!40000 ALTER TABLE `trabajadores` DISABLE KEYS */;
REPLACE INTO `trabajadores` (`cedula`, `nombre`, `apellido`, `telefono`, `salario`, `fecha_entrada`) VALUES ('281-311083-0005Y','ELSA MASSIEL','ICAZA ZELAYA','81863014',7282,'2018-02-18'),('615-171097-0001W','YESSER JOEL','MIRANDA GUILLEN','8888-8888',7282,'2017-07-22');
/*!40000 ALTER TABLE `trabajadores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `pass` varchar(100) NOT NULL,
  `tipo_usuario` enum('CAJERO','ADMIN') DEFAULT 'CAJERO',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
REPLACE INTO `usuarios` (`id`, `usuario`, `pass`, `tipo_usuario`) VALUES (1,'Yesser','Ingeniero.1','ADMIN'),(3,'Henry','123',''),(5,'ElsaMassiel','123','CAJERO'),(6,'Humberto','89416603','ADMIN');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-10 18:15:37
