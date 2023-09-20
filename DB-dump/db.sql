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
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `CustomersID` int NOT NULL,
  `CustomerName` varchar(45) DEFAULT NULL,
  `CustomerAddress` varchar(45) DEFAULT NULL,
  `CustomerMOL` varchar(45) DEFAULT NULL,
  `CustomerECODE` varchar(45) DEFAULT NULL,
  `CustomerVATCODE` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`CustomersID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `invoice_product`
--

DROP TABLE IF EXISTS `invoice_product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoice_product` (
  `INVPRODID` int NOT NULL,
  `PRODUCTMEASURE` varchar(45) DEFAULT NULL,
  `PRODUCTUNITPRICE` varchar(45) DEFAULT NULL,
  `INVOICEQUANTITY` varchar(45) DEFAULT NULL,
  `INVOICEID` int NOT NULL,
  `PRODUCTID` int NOT NULL,
  PRIMARY KEY (`INVPRODID`,`INVOICEID`,`PRODUCTID`),
  KEY `fk_INVOICE_PRODUCT_INVOICES1_idx` (`INVOICEID`),
  KEY `fk_INVOICE_PRODUCT_PRODUCTS1_idx` (`PRODUCTID`),
  CONSTRAINT `fk_INVOICE_PRODUCT_INVOICES1` FOREIGN KEY (`INVOICEID`) REFERENCES `invoices` (`INVOICEID`),
  CONSTRAINT `fk_INVOICE_PRODUCT_PRODUCTS1` FOREIGN KEY (`PRODUCTID`) REFERENCES `products` (`PRODUCTID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `invoices`
--

DROP TABLE IF EXISTS `invoices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoices` (
  `INVOICEID` int NOT NULL,
  `INVOICENUMBER` varchar(45) DEFAULT NULL,
  `INVOICEVATDATE` varchar(45) DEFAULT NULL,
  `INVOICEDEALDATE` varchar(45) DEFAULT NULL,
  `INVOICESUM` decimal(20,2) DEFAULT NULL,
  `INVOICEVAT` decimal(20,2) DEFAULT NULL,
  `INVOICETOTAL` decimal(20,2) DEFAULT NULL,
  `INVOICEVATPERCENT` varchar(45) DEFAULT NULL,
  `CUSTOMERID` int NOT NULL,
  `MYFIRMID` int NOT NULL,
  PRIMARY KEY (`INVOICEID`,`CUSTOMERID`,`MYFIRMID`),
  KEY `fk_INVOICES_Customers_idx` (`CUSTOMERID`),
  KEY `fk_INVOICES_MYFIRMS1_idx` (`MYFIRMID`),
  CONSTRAINT `fk_INVOICES_Customers` FOREIGN KEY (`CUSTOMERID`) REFERENCES `customers` (`CustomersID`),
  CONSTRAINT `fk_INVOICES_MYFIRMS1` FOREIGN KEY (`MYFIRMID`) REFERENCES `myfirms` (`MyFirmID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `myfirms`
--

DROP TABLE IF EXISTS `myfirms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `myfirms` (
  `MyFirmID` int NOT NULL,
  `MyFirmName` varchar(45) DEFAULT NULL,
  `MyFirmAddress` varchar(45) DEFAULT NULL,
  `MyFirmMOL` varchar(45) DEFAULT NULL,
  `MyFirmECODE` varchar(45) DEFAULT NULL,
  `MyFirmVATECODE` varchar(45) DEFAULT NULL,
  `MyFirmIBAN` varchar(45) DEFAULT NULL,
  `MyFirmBANKNAME` varchar(45) DEFAULT NULL,
  `MyFirmBANKCODE` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`MyFirmID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `PRODUCTID` int NOT NULL,
  `PRODUCTCODE` varchar(45) DEFAULT NULL,
  `PRODUCTNAME` varchar(45) DEFAULT NULL,
  `PRODUCTMEASURE` varchar(45) DEFAULT NULL,
  `QUANTITY` varchar(45) DEFAULT '1',
  `PRODUCT_DOST_CENA` varchar(45) DEFAULT NULL,
  `PRODUCT_PROD_CENA` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`PRODUCTID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;