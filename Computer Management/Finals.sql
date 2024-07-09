/*
SQLyog Ultimate v8.55 
MySQL - 5.0.45-community-nt : Database - final
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`final` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `final`;

/*Table structure for table `register` */

DROP TABLE IF EXISTS `register`;

CREATE TABLE `register` (
  `ID` int(50) NOT NULL auto_increment,
  `Username` varchar(50) NOT NULL default '',
  `Password` varchar(50) NOT NULL default '',
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `register` */

insert  into `register`(`ID`,`Username`,`Password`) values (1,'user','pass'),(2,'max','dog'),(3,'jhun','julani');

/*Table structure for table `returned` */

DROP TABLE IF EXISTS `returned`;

CREATE TABLE `returned` (
  `item_ID` int(50) NOT NULL auto_increment,
  `lastname` varchar(100) NOT NULL,
  `iborrow` varchar(100) NOT NULL,
  `dborrow` varchar(55) NOT NULL,
  `dreturn` varchar(55) NOT NULL,
  `bqnty` int(50) NOT NULL,
  PRIMARY KEY  (`item_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `returned` */

insert  into `returned`(`item_ID`,`lastname`,`iborrow`,`dborrow`,`dreturn`,`bqnty`) values (8,'Jay','Keyboard','14/05/2024','14/05/2024',11);

/*Table structure for table `returnies` */

DROP TABLE IF EXISTS `returnies`;

CREATE TABLE `returnies` (
  `item_ID` int(50) NOT NULL auto_increment,
  `lastname` varchar(100) NOT NULL,
  `iborrow` varchar(100) NOT NULL,
  `dborrow` varchar(100) NOT NULL,
  `dreturn` varchar(100) NOT NULL,
  `bqnty` varchar(100) NOT NULL,
  PRIMARY KEY  (`item_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `returnies` */

insert  into `returnies`(`item_ID`,`lastname`,`iborrow`,`dborrow`,`dreturn`,`bqnty`) values (9,'Yuki','Mouse','15/05/2024','15/05/2024','5');

/*Table structure for table `tblinventory` */

DROP TABLE IF EXISTS `tblinventory`;

CREATE TABLE `tblinventory` (
  `uid` int(20) NOT NULL auto_increment,
  `fname` varchar(100) default NULL,
  `mname` varchar(100) default NULL,
  `lname` varchar(100) default NULL,
  `location` varchar(100) default NULL,
  `contno` varchar(100) default NULL,
  PRIMARY KEY  (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblinventory` */

/*Table structure for table `tblitems` */

DROP TABLE IF EXISTS `tblitems`;

CREATE TABLE `tblitems` (
  `iiid` int(50) NOT NULL auto_increment,
  `itemn` varchar(100) default NULL,
  `desk` varchar(100) default NULL,
  `avail` varchar(100) default NULL,
  `qnty` varchar(100) default NULL,
  PRIMARY KEY  (`iiid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `tblitems` */

insert  into `tblitems`(`iiid`,`itemn`,`desk`,`avail`,`qnty`) values (1,'Mouse','Working','Available','5');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
