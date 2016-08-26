-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.5.13 - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL Version:             9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping structure for table serviceticker.accessory
CREATE TABLE IF NOT EXISTS `accessory` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `accessory_name` varchar(50) DEFAULT '-',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.applogs
CREATE TABLE IF NOT EXISTS `applogs` (
  `user_id` varchar(255) DEFAULT '-',
  `user_name` varchar(255) DEFAULT '-',
  `user_usernamelogin` varchar(255) DEFAULT '-',
  `note` varchar(255) DEFAULT '-',
  `date_in` datetime DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.audit
CREATE TABLE IF NOT EXISTS `audit` (
  `datetime` varchar(100) DEFAULT '0',
  `money1` varchar(100) DEFAULT '0',
  `money2` varchar(100) DEFAULT '0',
  `money5` varchar(100) DEFAULT '0',
  `money10` varchar(100) DEFAULT '0',
  `money20` varchar(100) DEFAULT '0',
  `money50` varchar(100) DEFAULT '0',
  `money100` varchar(100) DEFAULT '0',
  `money500` varchar(100) DEFAULT '0',
  `money1000` varchar(100) DEFAULT '0',
  `totalAll` varchar(100) DEFAULT '0',
  `check` varchar(100) DEFAULT '0',
  `transfer` varchar(100) DEFAULT '0',
  `cash` varchar(100) DEFAULT '0',
  `charges` varchar(100) DEFAULT '0',
  `deliverMorning` varchar(100) DEFAULT '0',
  `deliverNoon` varchar(100) DEFAULT '0',
  `deliverEvening` varchar(100) DEFAULT '0',
  `totalDeliver` varchar(100) DEFAULT '0',
  `difference` varchar(100) DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.audit_outgoings
CREATE TABLE IF NOT EXISTS `audit_outgoings` (
  `datetime` varchar(100) DEFAULT '-',
  `namewiden` varchar(200) DEFAULT '-',
  `list` varchar(200) DEFAULT '-',
  `money` varchar(200) DEFAULT '0',
  `note` varchar(200) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.autobackup
CREATE TABLE IF NOT EXISTS `autobackup` (
  `backupdirectory` varchar(200) DEFAULT 'D:\\ข้อมูลสำรองServiceTicker',
  `timer` int(11) DEFAULT '1'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.buy
CREATE TABLE IF NOT EXISTS `buy` (
  `buy_id` varchar(50) NOT NULL,
  `total` varchar(50) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `sale_company_id` varchar(255) DEFAULT NULL,
  `sale_company_name` varchar(255) DEFAULT NULL,
  `datetime_save` varchar(50) DEFAULT NULL,
  `datetime_edit` varchar(50) DEFAULT NULL,
  `employee` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`buy_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.buy_id
CREATE TABLE IF NOT EXISTS `buy_id` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `buy_id` varchar(50) NOT NULL DEFAULT '0',
  `datetime_save` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  KEY `buy_id` (`buy_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.buy_pro
CREATE TABLE IF NOT EXISTS `buy_pro` (
  `buy_id` varchar(50) NOT NULL,
  `sale_company_id` varchar(50) DEFAULT '0',
  `sale_company_name` varchar(100) DEFAULT '0',
  `code_pro` varchar(50) DEFAULT '0',
  `bar_code` varchar(50) DEFAULT '0',
  `name_pro` varchar(255) DEFAULT '0',
  `price_cost` varchar(50) DEFAULT '0',
  `price_buy` varchar(50) DEFAULT NULL,
  `count_num` varchar(50) DEFAULT '0',
  `unit` varchar(50) DEFAULT '0',
  `total` varchar(50) DEFAULT '0',
  `datetime_save` varchar(50) DEFAULT '0',
  `employee` varchar(50) DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.cash_id
CREATE TABLE IF NOT EXISTS `cash_id` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `cash_id` varchar(50) DEFAULT '0',
  `datetime_save` varchar(50) DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.cash_pledge_sale
CREATE TABLE IF NOT EXISTS `cash_pledge_sale` (
  `p_id` varchar(100) DEFAULT '-',
  `cash_id` varchar(100) DEFAULT '-',
  `total1` varchar(50) DEFAULT '0',
  `cash1` varchar(50) DEFAULT '-',
  `transfer1` varchar(50) DEFAULT '-',
  `check1` varchar(50) DEFAULT '-',
  `detail1` varchar(255) DEFAULT '-',
  `customer_id` varchar(50) DEFAULT '-',
  `customer_name` varchar(255) DEFAULT '-',
  `employee` varchar(255) DEFAULT '-',
  `datetime_save` varchar(50) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.cash_sale
CREATE TABLE IF NOT EXISTS `cash_sale` (
  `sale_id` varchar(50) DEFAULT '-',
  `fix_id` varchar(50) DEFAULT '-',
  `cash_id` varchar(50) DEFAULT '-',
  `customer_id` varchar(50) DEFAULT '-',
  `customer_name` varchar(255) DEFAULT '-',
  `total_all` varchar(255) DEFAULT '-',
  `date_in` varchar(50) DEFAULT '-',
  `datetime_save` varchar(50) DEFAULT '-',
  `date_edit` varchar(50) DEFAULT '-',
  `cash` varchar(50) DEFAULT '-',
  `cash_status` varchar(50) DEFAULT '-',
  `employee` varchar(255) DEFAULT '-',
  `return_id` varchar(50) DEFAULT '-',
  `cash_back` varchar(50) DEFAULT '-',
  `cash_detail` varchar(255) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.cash_sale_barcode
CREATE TABLE IF NOT EXISTS `cash_sale_barcode` (
  `sale_id` varchar(100) DEFAULT '0',
  `cash_id` varchar(100) DEFAULT '0',
  `customer_id` varchar(100) DEFAULT '0',
  `fix_id` varchar(100) DEFAULT '0',
  `customer_name` varchar(255) DEFAULT '0',
  `customer_tel` varchar(45) DEFAULT '0',
  `code_pro` varchar(255) DEFAULT '0',
  `bar_code` varchar(255) DEFAULT '0',
  `name_pro` varchar(255) DEFAULT '0',
  `total_pro` varchar(255) DEFAULT '0',
  `price_cost` varchar(50) DEFAULT '0',
  `price_buy` varchar(50) DEFAULT '0',
  `unit` varchar(50) DEFAULT '0',
  `type` varchar(100) DEFAULT '0',
  `date_in` varchar(50) DEFAULT '0',
  `datetime_save` varchar(50) DEFAULT '-',
  `return_id` varchar(50) DEFAULT '0',
  `employee` varchar(255) DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.cash_sale_serial
CREATE TABLE IF NOT EXISTS `cash_sale_serial` (
  `sale_id` varchar(50) DEFAULT '-',
  `fix_id` varchar(100) DEFAULT '-',
  `cash_id` varchar(100) DEFAULT '-',
  `customer_id` varchar(50) DEFAULT '-',
  `customer_name` varchar(255) DEFAULT '-',
  `name_pro` varchar(255) DEFAULT '-',
  `code_pro` varchar(50) DEFAULT '-',
  `bar_code` varchar(50) DEFAULT '-',
  `serial_pro` varchar(50) DEFAULT '-',
  `date_in` varchar(45) DEFAULT '-',
  `datetime_save` varchar(50) DEFAULT '-',
  `employee` varchar(45) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.check_stock
CREATE TABLE IF NOT EXISTS `check_stock` (
  `c_stock_id` varchar(100) DEFAULT '-',
  `code_pro` varchar(100) DEFAULT '-',
  `serial_pro` varchar(100) DEFAULT '-',
  `name_pro` varchar(255) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.check_stock_cache
CREATE TABLE IF NOT EXISTS `check_stock_cache` (
  `serial_pro` varchar(50) DEFAULT '-',
  `name_pro` varchar(50) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.check_stock_id
CREATE TABLE IF NOT EXISTS `check_stock_id` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `c_stock_id` varchar(50) DEFAULT '-',
  `datetime_save` varchar(50) DEFAULT '-',
  `t_stock` varchar(50) DEFAULT '0',
  `dontcheck` varchar(50) DEFAULT '0',
  `checked` varchar(50) DEFAULT '0',
  `datetime_last` varchar(50) DEFAULT '-',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.claims
CREATE TABLE IF NOT EXISTS `claims` (
  `claims_id` varchar(100) DEFAULT '-',
  `customer_id` varchar(100) DEFAULT '-',
  `serial_pro` varchar(100) DEFAULT '-',
  `code_pro` varchar(100) DEFAULT '-',
  `bar_code` varchar(100) DEFAULT '-',
  `name_pro` varchar(500) DEFAULT '-',
  `price_buy` varchar(100) DEFAULT '-',
  `price_wholesale` varchar(100) DEFAULT '-',
  `price_technician` varchar(100) DEFAULT '-',
  `price_loyal` varchar(100) DEFAULT '-',
  `price_members` varchar(100) DEFAULT '-',
  `type` varchar(100) DEFAULT '-',
  `unit` varchar(100) DEFAULT '-',
  `datetime_sale` varchar(100) DEFAULT '-',
  `datetime_return` varchar(100) DEFAULT '-',
  `datetime_edit` varchar(100) DEFAULT '-',
  `claims_money` varchar(100) DEFAULT '-',
  `employee_claims_return` varchar(100) DEFAULT '-',
  `tel_to_cus` varchar(100) DEFAULT '-',
  `employee_sale` varchar(200) DEFAULT '-',
  `symptom` varchar(100) DEFAULT '-',
  `accressory` varchar(500) DEFAULT '-',
  `note` varchar(1000) DEFAULT '-',
  `note2` varchar(1000) DEFAULT '-',
  `status` varchar(50) DEFAULT '-',
  `employee` varchar(200) DEFAULT '-',
  `datetime_save` varchar(100) DEFAULT '-',
  `claims_id_pic` longblob
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.claims_cache
CREATE TABLE IF NOT EXISTS `claims_cache` (
  `claims_id` varchar(100) DEFAULT '-',
  `customer_id` varchar(100) DEFAULT '-',
  `serial_pro` varchar(100) DEFAULT '-',
  `code_pro` varchar(100) DEFAULT '-',
  `bar_code` varchar(100) DEFAULT '-',
  `name_pro` varchar(500) DEFAULT '-',
  `price_buy` varchar(100) DEFAULT '-',
  `price_wholesale` varchar(100) DEFAULT '-',
  `price_technician` varchar(100) DEFAULT '-',
  `price_loyal` varchar(100) DEFAULT '-',
  `price_members` varchar(100) DEFAULT '-',
  `type` varchar(100) DEFAULT '-',
  `unit` varchar(100) DEFAULT '-',
  `datetime_sale` varchar(100) DEFAULT '-',
  `datetime_return` varchar(100) DEFAULT '-',
  `datetime_edit` varchar(100) DEFAULT '-',
  `claims_money` varchar(100) DEFAULT '-',
  `employee_claims_return` varchar(100) DEFAULT '-',
  `tel_to_cus` varchar(100) DEFAULT '-',
  `employee_sale` varchar(200) DEFAULT '-',
  `symptom` varchar(100) DEFAULT '-',
  `accressory` varchar(500) DEFAULT '-',
  `note` varchar(1000) DEFAULT '-',
  `note2` varchar(1000) DEFAULT '-',
  `status` varchar(50) DEFAULT '-',
  `employee` varchar(200) DEFAULT '-',
  `datetime_save` varchar(100) DEFAULT '-',
  `claims_id_pic` longblob
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.claims_company
CREATE TABLE IF NOT EXISTS `claims_company` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `company_id` varchar(50) DEFAULT '-',
  `company_name` varchar(500) DEFAULT '-',
  `company_address` varchar(500) DEFAULT '-',
  `company_address1` varchar(500) DEFAULT '-',
  `company_address2` varchar(500) DEFAULT '-',
  `company_zipcode` varchar(500) DEFAULT '-',
  `company_contect` varchar(500) DEFAULT '-',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.claims_company_id
CREATE TABLE IF NOT EXISTS `claims_company_id` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `claims_company_id` varchar(50) DEFAULT '0',
  `datetime_save` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.claims_copy
CREATE TABLE IF NOT EXISTS `claims_copy` (
  `claims_id` varchar(100) DEFAULT '-',
  `customer_id` varchar(100) DEFAULT '-',
  `serial_pro` varchar(100) DEFAULT '-',
  `code_pro` varchar(100) DEFAULT '-',
  `bar_code` varchar(100) DEFAULT '-',
  `name_pro` varchar(500) DEFAULT '-',
  `price_buy` varchar(100) DEFAULT '-',
  `type` varchar(100) DEFAULT '-',
  `unit` varchar(100) DEFAULT '-',
  `datetime_sale` varchar(100) DEFAULT '-',
  `datetime_return` varchar(100) DEFAULT '-',
  `datetime_edit` varchar(100) DEFAULT '-',
  `claims_money` varchar(100) DEFAULT '-',
  `employee_claims_return` varchar(100) DEFAULT '-',
  `tel_to_cus` varchar(100) DEFAULT '-',
  `employee_sale` varchar(200) DEFAULT '-',
  `symptom` varchar(100) DEFAULT '-',
  `accressory` varchar(500) DEFAULT '-',
  `note` varchar(1000) DEFAULT '-',
  `note2` varchar(1000) DEFAULT '-',
  `status` varchar(50) DEFAULT '-',
  `employee` varchar(200) DEFAULT '-',
  `datetime_save` varchar(100) DEFAULT '-',
  `claims_id_pic` longblob
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.claims_id
CREATE TABLE IF NOT EXISTS `claims_id` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `claims_id` varchar(50) DEFAULT '0',
  `datetime_save` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.claims_lot_id
CREATE TABLE IF NOT EXISTS `claims_lot_id` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `claims_lot` varchar(100) DEFAULT '0',
  `datetime_save` varchar(100) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.claims_send
CREATE TABLE IF NOT EXISTS `claims_send` (
  `claims_id` varchar(50) DEFAULT '-',
  `claims_company` varchar(500) DEFAULT '-',
  `claims_company_id` varchar(50) DEFAULT '-',
  `claims_note` varchar(50) DEFAULT '-',
  `claims_send_status` varchar(50) DEFAULT '-',
  `claims_lot` varchar(50) DEFAULT '-',
  `datetime_edit` varchar(100) DEFAULT '-',
  `datetime_save` varchar(100) DEFAULT '-',
  `employee` varchar(200) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.claims_send_report
CREATE TABLE IF NOT EXISTS `claims_send_report` (
  `claims_id` varchar(100) DEFAULT '-',
  `customer_id` varchar(100) DEFAULT '-',
  `serial_pro` varchar(100) DEFAULT '-',
  `code_pro` varchar(100) DEFAULT '-',
  `bar_code` varchar(100) DEFAULT '-',
  `name_pro` varchar(500) DEFAULT '-',
  `price_buy` varchar(100) DEFAULT '-',
  `price_wholesale` varchar(100) DEFAULT '-',
  `price_technician` varchar(100) DEFAULT '-',
  `price_loyal` varchar(100) DEFAULT '-',
  `price_members` varchar(100) DEFAULT '-',
  `type` varchar(100) DEFAULT '-',
  `unit` varchar(100) DEFAULT '-',
  `datetime_sale` varchar(100) DEFAULT '-',
  `datetime_return` varchar(100) DEFAULT '-',
  `datetime_edit` varchar(100) DEFAULT '-',
  `claims_money` varchar(100) DEFAULT '-',
  `employee_claims_return` varchar(100) DEFAULT '-',
  `tel_to_cus` varchar(100) DEFAULT '-',
  `employee_sale` varchar(200) DEFAULT '-',
  `symptom` varchar(100) DEFAULT '-',
  `accressory` varchar(500) DEFAULT '-',
  `note` varchar(1000) DEFAULT '-',
  `note2` varchar(1000) DEFAULT '-',
  `status` varchar(50) DEFAULT '-',
  `employee` varchar(200) DEFAULT '-',
  `datetime_save` varchar(100) DEFAULT '-',
  `claims_id_pic` longblob
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.claims_test_results
CREATE TABLE IF NOT EXISTS `claims_test_results` (
  `claims_id` varchar(50) DEFAULT '-',
  `fix_by_company` varchar(50) DEFAULT '-',
  `old_sn` varchar(50) DEFAULT '-',
  `new_sn` varchar(50) DEFAULT '-',
  `test_results` varchar(50) DEFAULT '-',
  `test_note` varchar(500) DEFAULT '-',
  `datetime_save` varchar(50) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.comfix
CREATE TABLE IF NOT EXISTS `comfix` (
  `fix_id` varchar(45) NOT NULL,
  `claims_id` varchar(45) NOT NULL,
  `date_save` varchar(20) DEFAULT '-',
  `customer_id` varchar(100) DEFAULT '-',
  `customer_name` varchar(100) DEFAULT '-',
  `sn` varchar(50) DEFAULT '-',
  `symptom` varchar(100) DEFAULT '-',
  `managerdata` varchar(100) DEFAULT '-',
  `fixrepairnote` varchar(500) DEFAULT '-',
  `fixaccessory` varchar(500) DEFAULT '-',
  `fixnote` varchar(500) DEFAULT '-',
  `fixtprice` varchar(45) DEFAULT '-',
  `varuntee` varchar(45) DEFAULT '-',
  `date_get` varchar(20) DEFAULT '-',
  `fixuser` varchar(45) DEFAULT '-',
  `status` varchar(45) DEFAULT '-',
  `user_repair` varchar(100) DEFAULT '-',
  `note_repair` varchar(500) DEFAULT '-',
  `teltocus` varchar(45) DEFAULT '-',
  `date_send` varchar(45) DEFAULT '-',
  `datecom_repair` varchar(45) DEFAULT '-',
  `importune` varchar(45) DEFAULT '-',
  `storage` varchar(100) DEFAULT '-',
  `comfix_barcode` longblob,
  PRIMARY KEY (`fix_id`),
  UNIQUE KEY `fix_id_UNIQUE` (`fix_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.comfix_cache
CREATE TABLE IF NOT EXISTS `comfix_cache` (
  `fix_id` varchar(45) NOT NULL,
  `claims_id` varchar(45) NOT NULL,
  `date_save` varchar(20) DEFAULT '-',
  `customer_id` varchar(100) DEFAULT '-',
  `customer_name` varchar(100) DEFAULT '-',
  `sn` varchar(50) DEFAULT '-',
  `symptom` varchar(100) DEFAULT '-',
  `managerdata` varchar(100) DEFAULT '-',
  `fixrepairnote` varchar(500) DEFAULT '-',
  `fixaccessory` varchar(500) DEFAULT '-',
  `fixnote` varchar(500) DEFAULT '-',
  `fixtprice` varchar(45) DEFAULT '-',
  `varuntee` varchar(45) DEFAULT '-',
  `date_get` varchar(20) DEFAULT '-',
  `fixuser` varchar(45) DEFAULT '-',
  `status` varchar(45) DEFAULT '-',
  `user_repair` varchar(100) DEFAULT '-',
  `note_repair` varchar(500) DEFAULT '-',
  `teltocus` varchar(45) DEFAULT '-',
  `date_send` varchar(45) DEFAULT '-',
  `datecom_repair` varchar(45) DEFAULT '-',
  `importune` varchar(45) DEFAULT '-',
  `comfix_barcode` longblob,
  PRIMARY KEY (`fix_id`),
  UNIQUE KEY `fix_id_UNIQUE` (`fix_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.comfix_id
CREATE TABLE IF NOT EXISTS `comfix_id` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `fix_id` varchar(50) DEFAULT '0',
  `datetime_save` varchar(100) DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.company
CREATE TABLE IF NOT EXISTS `company` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `com_name` varchar(200) DEFAULT '-',
  `com_address` varchar(500) DEFAULT '-',
  `com_tel` varchar(20) DEFAULT '-',
  `com_fax` varchar(45) DEFAULT '-',
  `com_tax` varchar(45) DEFAULT '-',
  `footer1` varchar(500) DEFAULT '-',
  `footer2` varchar(500) DEFAULT '-',
  `footer3` varchar(500) DEFAULT '-',
  `images` varchar(500) DEFAULT '-',
  `com_line` varchar(500) DEFAULT '-',
  `com_facebook` varchar(500) DEFAULT '-',
  `com_email` varchar(500) DEFAULT '-',
  `com_website` varchar(500) DEFAULT '-',
  `com_sendrepairrow1` varchar(500) DEFAULT '-',
  `com_sendrepairrow2` varchar(500) DEFAULT '-',
  `com_sendrepairrow3` varchar(500) DEFAULT '-',
  `com_Invoice` varchar(500) DEFAULT '-',
  `com_quotation` varchar(500) DEFAULT '-',
  `com_billing` varchar(500) DEFAULT '-',
  `com_claims` varchar(500) DEFAULT '-',
  `com_qjob` varchar(500) DEFAULT '-',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.customer
CREATE TABLE IF NOT EXISTS `customer` (
  `customer_id` varchar(45) NOT NULL DEFAULT '-',
  `customer_tax` varchar(45) NOT NULL DEFAULT '0000000000000',
  `customer_section` varchar(100) NOT NULL DEFAULT '-',
  `customer_name` varchar(100) NOT NULL DEFAULT '-',
  `customer_address` varchar(200) NOT NULL DEFAULT '-',
  `customer_zipcode` varchar(45) NOT NULL DEFAULT '-',
  `customer_tel` varchar(45) NOT NULL DEFAULT '-',
  `customer_note` varchar(255) NOT NULL DEFAULT '-',
  `price_level` varchar(10) NOT NULL DEFAULT '-',
  `maturity` varchar(50) NOT NULL DEFAULT '-',
  `date_edit` varchar(50) NOT NULL DEFAULT '-',
  PRIMARY KEY (`customer_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.customer_id
CREATE TABLE IF NOT EXISTS `customer_id` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` varchar(50) DEFAULT '0',
  `datetime_save` varchar(50) DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.database_version
CREATE TABLE IF NOT EXISTS `database_version` (
  `version` varchar(50) DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.discount
CREATE TABLE IF NOT EXISTS `discount` (
  `sale_id` varchar(50) DEFAULT '-',
  `fix_id` varchar(50) DEFAULT '-',
  `cash` varchar(50) DEFAULT '-',
  `cash_back` varchar(50) DEFAULT '-',
  `cash_detail` varchar(100) DEFAULT '-',
  `discount` varchar(50) DEFAULT '-',
  `discount_detail` varchar(100) DEFAULT '-',
  `datetime_save` varchar(50) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.error_logs
CREATE TABLE IF NOT EXISTS `error_logs` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `error` varchar(5000) DEFAULT NULL,
  `datetime` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.fix_com
CREATE TABLE IF NOT EXISTS `fix_com` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `fix_name` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.ftp
CREATE TABLE IF NOT EXISTS `ftp` (
  `host` varchar(200) DEFAULT NULL,
  `folder` varchar(200) DEFAULT NULL,
  `username` varchar(200) DEFAULT NULL,
  `password` varchar(200) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.managerdata
CREATE TABLE IF NOT EXISTS `managerdata` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `mdata` varchar(100) DEFAULT '0',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.pledge_id
CREATE TABLE IF NOT EXISTS `pledge_id` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `pl_id` varchar(100) DEFAULT '0',
  `datetime_save` varchar(100) DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.pledge_sale
CREATE TABLE IF NOT EXISTS `pledge_sale` (
  `p_id` varchar(100) DEFAULT '-',
  `total1` varchar(50) DEFAULT '0',
  `cash1` varchar(50) DEFAULT '-',
  `transfer1` varchar(50) DEFAULT '-',
  `check1` varchar(50) DEFAULT '-',
  `detail1` varchar(255) DEFAULT '-',
  `customer_id` varchar(50) DEFAULT '-',
  `customer_name` varchar(255) DEFAULT '-',
  `employee` varchar(255) DEFAULT '-',
  `datetime_save` varchar(50) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.product
CREATE TABLE IF NOT EXISTS `product` (
  `code_pro` varchar(45) DEFAULT '-',
  `bar_code` varchar(45) DEFAULT '-',
  `name_pro` varchar(255) DEFAULT '-',
  `price_cost` varchar(45) DEFAULT '0',
  `price_buy` varchar(45) DEFAULT '0',
  `price_wholesale` varchar(45) DEFAULT '0',
  `price_technician` varchar(45) DEFAULT '0',
  `price_loyal` varchar(45) DEFAULT '0',
  `price_members` varchar(45) DEFAULT '0',
  `unit` varchar(45) DEFAULT '-',
  `varuntee` varchar(45) DEFAULT '-',
  `check_stock` varchar(45) DEFAULT '-',
  `count_num` varchar(45) DEFAULT '-',
  `type` varchar(255) DEFAULT '-',
  `update_date` varchar(45) DEFAULT '-',
  `company_buy` varchar(255) DEFAULT '-',
  `notepro` varchar(1000) DEFAULT '-',
  `spec` varchar(1000) DEFAULT '-',
  `picture` longblob
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.product_cache
CREATE TABLE IF NOT EXISTS `product_cache` (
  `code_pro` varchar(45) DEFAULT '-',
  `picture` longblob
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.product_color
CREATE TABLE IF NOT EXISTS `product_color` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `color` varchar(100) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.product_id
CREATE TABLE IF NOT EXISTS `product_id` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `code_pro` varchar(50) DEFAULT '0',
  `bar_code` varchar(50) DEFAULT '0',
  `name_pro` varchar(255) DEFAULT '0',
  `datetime_save` varchar(50) DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.product_model
CREATE TABLE IF NOT EXISTS `product_model` (
  `p_name` varchar(200) DEFAULT '-',
  `p_model` varchar(200) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.product_name
CREATE TABLE IF NOT EXISTS `product_name` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `p_name` varchar(45) DEFAULT '-',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.product_section
CREATE TABLE IF NOT EXISTS `product_section` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `prosection_id` varchar(45) DEFAULT '-',
  `prosection_name` varchar(255) DEFAULT '-',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.product_section_id
CREATE TABLE IF NOT EXISTS `product_section_id` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `prosection_id` varchar(45) NOT NULL DEFAULT '0',
  `prosection_name` varchar(255) NOT NULL DEFAULT '0',
  `datetime_save` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`prosection_id`),
  UNIQUE KEY `ID_UNIQUE` (`ID`),
  UNIQUE KEY `prosection_id_UNIQUE` (`prosection_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.product_serial
CREATE TABLE IF NOT EXISTS `product_serial` (
  `code_pro` varchar(255) CHARACTER SET utf8 DEFAULT '-',
  `serial_pro` varchar(255) CHARACTER SET utf8 DEFAULT '-',
  `name_pro` varchar(500) CHARACTER SET utf8 DEFAULT '-',
  `date_in` varchar(45) CHARACTER SET utf8 DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.product_type
CREATE TABLE IF NOT EXISTS `product_type` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `p_type` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.quotation
CREATE TABLE IF NOT EXISTS `quotation` (
  `quotation_id` varchar(50) DEFAULT '-',
  `customer_id` varchar(50) DEFAULT '-',
  `code_pro` varchar(50) DEFAULT '-',
  `name_pro` varchar(255) DEFAULT '-',
  `unit` varchar(50) DEFAULT '-',
  `total_pro` varchar(50) DEFAULT '-',
  `price_buy` varchar(50) DEFAULT '-',
  `multiply` varchar(50) DEFAULT '-',
  `datetime_save` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `picture` longblob
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.quotation_cache
CREATE TABLE IF NOT EXISTS `quotation_cache` (
  `quotation_id` varchar(50) DEFAULT '-',
  `customer_id` varchar(50) DEFAULT '-',
  `code_pro` varchar(50) DEFAULT '-',
  `name_pro` varchar(255) DEFAULT '-',
  `unit` varchar(50) DEFAULT '-',
  `total_pro` varchar(50) DEFAULT '-',
  `price_buy` varchar(50) DEFAULT '-',
  `multiply` varchar(50) DEFAULT '-',
  `datetime_save` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `picture` longblob
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.quotation_id
CREATE TABLE IF NOT EXISTS `quotation_id` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `q_id` varchar(100) DEFAULT '-',
  `datetime_save` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.receive
CREATE TABLE IF NOT EXISTS `receive` (
  `receive_id` varchar(50) DEFAULT NULL,
  `buy_id` varchar(50) NOT NULL,
  `bill_buy_id` varchar(50) NOT NULL,
  `receive_status` varchar(50) NOT NULL,
  `total` varchar(50) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `sale_company_id` varchar(255) DEFAULT NULL,
  `sale_company_name` varchar(255) DEFAULT NULL,
  `datetime_save` varchar(50) DEFAULT NULL,
  `datetime_edit` varchar(50) DEFAULT NULL,
  `employee` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.receive_id
CREATE TABLE IF NOT EXISTS `receive_id` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `receive_id` varchar(50) NOT NULL DEFAULT '0',
  `datetime_save` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.receive_pro
CREATE TABLE IF NOT EXISTS `receive_pro` (
  `receive_id` varchar(50) NOT NULL DEFAULT '0',
  `buy_id` varchar(50) NOT NULL DEFAULT '0',
  `sale_company_name` varchar(100) DEFAULT '0',
  `code_pro` varchar(50) DEFAULT '0',
  `name_pro` varchar(255) DEFAULT '0',
  `price_cost` varchar(50) DEFAULT '0',
  `price_buy` varchar(50) DEFAULT '0',
  `count_num` varchar(50) DEFAULT '0',
  `count_num_barcode` varchar(50) DEFAULT '0',
  `count_num_sn` varchar(50) DEFAULT '0',
  `unit` varchar(50) DEFAULT '0',
  `total_all` varchar(50) DEFAULT '0',
  `datetime_save` varchar(50) DEFAULT '0',
  `employee` varchar(50) DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.repair_status
CREATE TABLE IF NOT EXISTS `repair_status` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.returnproduct
CREATE TABLE IF NOT EXISTS `returnproduct` (
  `return_id` varchar(50) DEFAULT '0',
  `sale_id` varchar(50) DEFAULT '0',
  `fix_id` varchar(50) DEFAULT '0',
  `customer_id` varchar(50) DEFAULT '0',
  `customer_name` varchar(200) DEFAULT '0',
  `total_all` varchar(50) DEFAULT '0',
  `total_barcode` varchar(50) DEFAULT '0',
  `total_sn` varchar(50) DEFAULT '0',
  `return_status` varchar(50) DEFAULT '0',
  `return_note` varchar(500) DEFAULT '0',
  `datetime_save` varchar(50) DEFAULT '0',
  `employee` varchar(100) DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.returnproduct_barcode
CREATE TABLE IF NOT EXISTS `returnproduct_barcode` (
  `return_id` varchar(100) DEFAULT '0',
  `sale_id` varchar(100) DEFAULT '0',
  `fix_id` varchar(100) DEFAULT '0',
  `code_pro` varchar(100) DEFAULT '0',
  `name_pro` varchar(255) DEFAULT '0',
  `unit` varchar(100) DEFAULT '0',
  `price_buy` varchar(100) DEFAULT '0',
  `total` varchar(100) DEFAULT '0',
  `employee` varchar(100) DEFAULT '0',
  `datetime_save` varchar(50) DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.returnproduct_id
CREATE TABLE IF NOT EXISTS `returnproduct_id` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `return_id` varchar(50) NOT NULL DEFAULT '0',
  `datetime_save` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.returnproduct_serial
CREATE TABLE IF NOT EXISTS `returnproduct_serial` (
  `return_id` varchar(50) DEFAULT '0',
  `sale_id` varchar(50) DEFAULT '0',
  `customer_id` varchar(50) DEFAULT '0',
  `fix_id` varchar(50) DEFAULT '0',
  `customer_name` varchar(255) DEFAULT '0',
  `code_pro` varchar(50) DEFAULT '0',
  `name_pro` varchar(255) DEFAULT '0',
  `serial_pro` varchar(255) DEFAULT '0',
  `datetime_save` varchar(50) DEFAULT '0',
  `employee` varchar(100) DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.sale
CREATE TABLE IF NOT EXISTS `sale` (
  `sale_id` varchar(45) DEFAULT '-',
  `fix_id` varchar(100) DEFAULT '-',
  `customer_id` varchar(45) DEFAULT '-',
  `customer_name` varchar(255) DEFAULT '-',
  `total_all` varchar(255) DEFAULT '0',
  `date_in` varchar(45) DEFAULT '-',
  `datetime_save` varchar(50) DEFAULT '-',
  `date_edit` varchar(45) DEFAULT '-',
  `cash` varchar(100) DEFAULT '0',
  `cash_status` varchar(100) DEFAULT '-',
  `employee` varchar(255) DEFAULT '-',
  `return_id` varchar(45) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.sale_barcode
CREATE TABLE IF NOT EXISTS `sale_barcode` (
  `sale_id` varchar(100) DEFAULT '-',
  `customer_id` varchar(100) DEFAULT '-',
  `fix_id` varchar(100) DEFAULT '-',
  `customer_name` varchar(255) DEFAULT '-',
  `customer_tel` varchar(45) DEFAULT '-',
  `code_pro` varchar(255) DEFAULT '-',
  `bar_code` varchar(255) DEFAULT '-',
  `name_pro` varchar(255) DEFAULT '-',
  `total_pro` varchar(255) DEFAULT '-',
  `price_cost` varchar(50) DEFAULT '-',
  `price_buy` varchar(50) DEFAULT '-',
  `unit` varchar(50) DEFAULT '-',
  `type` varchar(100) DEFAULT '-',
  `date_in` varchar(50) DEFAULT '-',
  `datetime_save` varchar(50) DEFAULT '-',
  `return_id` varchar(50) DEFAULT '-',
  `employee` varchar(255) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.sale_company
CREATE TABLE IF NOT EXISTS `sale_company` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `sale_company_id` varchar(45) NOT NULL,
  `sale_company_name` varchar(255) DEFAULT '0',
  `sale_company_address` varchar(500) DEFAULT '0',
  `sale_company_tel` varchar(45) DEFAULT '0',
  `sale_company_fax` varchar(500) DEFAULT '0',
  `sale_company_contact` varchar(255) DEFAULT '0',
  `sale_company_line` varchar(255) DEFAULT '0',
  `sale_company_email` varchar(255) DEFAULT '0',
  `sale_company_facebook` varchar(255) DEFAULT '0',
  `sale_company_website` varchar(255) DEFAULT '0',
  `sale_company_tax` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.sale_company_id
CREATE TABLE IF NOT EXISTS `sale_company_id` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `sale_company_name` varchar(200) DEFAULT '0',
  `sale_company_id` varchar(50) DEFAULT '0',
  `datetime_save` varchar(50) DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.sale_id
CREATE TABLE IF NOT EXISTS `sale_id` (
  `ID` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `sale_id` varchar(45) NOT NULL,
  `fix_id` varchar(100) DEFAULT NULL,
  `customer_id` varchar(50) NOT NULL,
  `customer_name` varchar(255) NOT NULL,
  `date_in` varchar(50) NOT NULL,
  `datetime_save` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`,`sale_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.sale_serial
CREATE TABLE IF NOT EXISTS `sale_serial` (
  `sale_id` varchar(50) DEFAULT '-',
  `fix_id` varchar(100) DEFAULT '-',
  `customer_id` varchar(50) DEFAULT '-',
  `customer_name` varchar(255) DEFAULT '-',
  `name_pro` varchar(255) DEFAULT '-',
  `code_pro` varchar(50) DEFAULT '-',
  `bar_code` varchar(50) DEFAULT '-',
  `serial_pro` varchar(50) DEFAULT '-',
  `date_in` varchar(45) DEFAULT '-',
  `datetime_save` varchar(50) DEFAULT '-',
  `employee` varchar(45) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.sn
CREATE TABLE IF NOT EXISTS `sn` (
  `Snum` varchar(50) NOT NULL DEFAULT '-',
  `p_type` varchar(45) DEFAULT '-',
  `p_name` varchar(45) DEFAULT '-',
  `model` varchar(45) DEFAULT '-',
  `color` varchar(45) DEFAULT '-',
  `startdate` varchar(20) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.sn_id
CREATE TABLE IF NOT EXISTS `sn_id` (
  `id` int(100) unsigned NOT NULL AUTO_INCREMENT,
  `sn_id` varchar(50) DEFAULT '0',
  `datetime_save` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.stock_number_cache
CREATE TABLE IF NOT EXISTS `stock_number_cache` (
  `number` varchar(50) DEFAULT NULL,
  `code_pro` varchar(200) DEFAULT NULL,
  `bar_code` varchar(200) DEFAULT NULL,
  `name_pro` varchar(500) DEFAULT NULL,
  `type` varchar(100) DEFAULT NULL,
  `price_cost` varchar(100) DEFAULT NULL,
  `total_all` varchar(100) DEFAULT NULL,
  `total_cost` varchar(100) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.stock_number_sn_cache
CREATE TABLE IF NOT EXISTS `stock_number_sn_cache` (
  `no` varchar(50) DEFAULT NULL,
  `code_pro` varchar(100) DEFAULT NULL,
  `sn` varchar(100) DEFAULT NULL,
  `name_pro` varchar(500) DEFAULT NULL,
  `datetime` varchar(100) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.taxinvoice
CREATE TABLE IF NOT EXISTS `taxinvoice` (
  `taxinvoice_id` varchar(50) DEFAULT '-',
  `taxinvoice_type` varchar(100) DEFAULT '-',
  `customer_id` varchar(100) DEFAULT '-',
  `customer_name` varchar(200) DEFAULT '-',
  `customer_address` varchar(500) DEFAULT '-',
  `customer_tel` varchar(100) DEFAULT '-',
  `code_pro` varchar(100) DEFAULT '-',
  `name_pro` varchar(255) DEFAULT '-',
  `total` varchar(100) DEFAULT '-',
  `unit` varchar(100) DEFAULT '-',
  `price_buy` varchar(100) DEFAULT '-',
  `note` varchar(300) DEFAULT '-',
  `tax_num` varchar(100) DEFAULT '-',
  `tax_section` varchar(100) DEFAULT '-',
  `datetime_save` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.taxinvoice_id
CREATE TABLE IF NOT EXISTS `taxinvoice_id` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ti_id` varchar(100) DEFAULT NULL,
  `datetime_save` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.unit
CREATE TABLE IF NOT EXISTS `unit` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `unit_p` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.users
CREATE TABLE IF NOT EXISTS `users` (
  `user_id` varchar(45) NOT NULL,
  `user_name` varchar(45) NOT NULL,
  `user_address` varchar(500) NOT NULL,
  `user_tel` varchar(50) NOT NULL,
  `user_email` varchar(100) NOT NULL,
  `user_password` varchar(50) NOT NULL,
  `user_usernamelogin` varchar(45) NOT NULL,
  `user_leval` varchar(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.users_id
CREATE TABLE IF NOT EXISTS `users_id` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` varchar(50) NOT NULL DEFAULT '0',
  `user_namelogin` varchar(100) NOT NULL DEFAULT '0',
  `datetime_save` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.varuntee
CREATE TABLE IF NOT EXISTS `varuntee` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `varuntee_status` varchar(45) NOT NULL,
  `day` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.ver_detail
CREATE TABLE IF NOT EXISTS `ver_detail` (
  `ver_company` varchar(100) DEFAULT '-',
  `ver_version` varchar(100) DEFAULT '-',
  `ver_icon` varchar(100) DEFAULT '-',
  `ver_imglogin` varchar(200) DEFAULT '-',
  `ver_fixid` varchar(50) DEFAULT '-',
  `ver_cusid` varchar(50) DEFAULT '-',
  `ver_productid` varchar(50) DEFAULT '-',
  `ver_PartsWithdrawal` varchar(50) DEFAULT '-',
  `ver_productsectio` varchar(50) DEFAULT '-',
  `ver_barcode` varchar(50) DEFAULT '-',
  `ver_order` varchar(50) DEFAULT '-',
  `ver_receive` varchar(50) DEFAULT '-',
  `ver_returns` varchar(50) DEFAULT '-',
  `ver_debtor` varchar(50) DEFAULT '-',
  `ver_cash` varchar(50) DEFAULT '-',
  `ver_quotation` varchar(50) DEFAULT '-',
  `ver_cashinvoice` varchar(50) DEFAULT '-',
  `ver_claims` varchar(50) DEFAULT '-'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.


-- Dumping structure for table serviceticker.weblink
CREATE TABLE IF NOT EXISTS `weblink` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `web_name` varchar(100) DEFAULT '0',
  `web` varchar(300) DEFAULT NULL,
  `datetime_save` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Data exporting was unselected.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
