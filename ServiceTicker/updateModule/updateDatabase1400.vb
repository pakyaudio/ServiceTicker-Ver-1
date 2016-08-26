Imports MySql.Data.MySqlClient

Module updateDatabase1400
    Friend Sub updateDatabase_1400()
        Try
            strSQL = "ALTER TABLE `product`" _
                    & " ADD COLUMN `price_wholesale` VARCHAR(45) NULL DEFAULT '-' AFTER `price_buy`," _
                    & " ADD COLUMN `price_technician` VARCHAR(45) NULL DEFAULT '-' AFTER `price_wholesale`," _
                    & " ADD COLUMN `price_loyal` VARCHAR(45) NULL DEFAULT '-' AFTER `price_technician`," _
                    & " ADD COLUMN `price_members` VARCHAR(45) NULL DEFAULT '-' AFTER `price_loyal`," _
                    & " ADD COLUMN `spec` VARCHAR(1000) NULL DEFAULT '-' AFTER `notepro`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `customer` ADD COLUMN `price_level` VARCHAR(10) NOT NULL AFTER `customer_note`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `customer` (`customer_id`, `customer_tax`, `customer_section`, `customer_name`, `customer_address`, `customer_zipcode`, `customer_tel`, `customer_note`, `price_level`) VALUES ('0', '000000000000', '-', 'ลูกค้าเงินสด', 'รับสินค้าเอง', '-', '-', '-', '1');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try


        Try
            strSQL = "ALTER TABLE `product`" _
                & " CHANGE COLUMN `price_buy` `price_buy` VARCHAR(45) NULL DEFAULT '0' AFTER `price_cost`," _
                & " CHANGE COLUMN `price_wholesale` `price_wholesale` VARCHAR(45) NULL DEFAULT '0' AFTER `price_buy`," _
                & " CHANGE COLUMN `price_technician` `price_technician` VARCHAR(45) NULL DEFAULT '0' AFTER `price_wholesale`," _
                & " CHANGE COLUMN `price_loyal` `price_loyal` VARCHAR(45) NULL DEFAULT '0' AFTER `price_technician`," _
                & " CHANGE COLUMN `price_members` `price_members` VARCHAR(45) NULL DEFAULT '0' AFTER `price_loyal`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product` CHANGE COLUMN `price_cost` `price_cost` VARCHAR(45) NULL DEFAULT '0' AFTER `name_pro`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `product_model` ( `p_name` VARCHAR(200) NULL DEFAULT '-',`p_model` VARCHAR(200) NULL DEFAULT '-')COLLATE='utf8_general_ci' ENGINE=MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `product_color` (`id` INT NOT NULL AUTO_INCREMENT, `color` VARCHAR(100) NULL DEFAULT '0', PRIMARY KEY (`id`)) COLLATE='utf8_general_ci' ENGINE=MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `product_color` (`color`) VALUES ('ดำ');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `product_color` (`color`) VALUES ('แดง');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `product_color` (`color`) VALUES ('เทา');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `product_color` (`color`) VALUES ('ฟ้า');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE IF NOT EXISTS `sn_id` (" _
                        & "`id` int(100) unsigned NOT NULL AUTO_INCREMENT," _
                        & "`sn_id` varchar(50) DEFAULT '0'," _
                        & "`datetime_save` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP," _
                        & " PRIMARY KEY (`id`)) ENGINE=MyISAM DEFAULT CHARSET=utf8;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `sn_id` (`sn_id`) VALUES ('start');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`" _
                    & " ADD COLUMN `price_wholesale` VARCHAR(100) NULL DEFAULT '-' AFTER `price_buy`," _
                    & " ADD COLUMN `price_technician` VARCHAR(100) NULL DEFAULT '-' AFTER `price_wholesale`," _
                    & " ADD COLUMN `price_loyal` VARCHAR(100) NULL DEFAULT '-' AFTER `price_technician`," _
                    & " ADD COLUMN `price_members` VARCHAR(100) NULL DEFAULT '-' AFTER `price_loyal`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims_cache`" _
                    & " ADD COLUMN `price_wholesale` VARCHAR(100) NULL DEFAULT '-' AFTER `price_buy`," _
                    & " ADD COLUMN `price_technician` VARCHAR(100) NULL DEFAULT '-' AFTER `price_wholesale`," _
                    & " ADD COLUMN `price_loyal` VARCHAR(100) NULL DEFAULT '-' AFTER `price_technician`," _
                    & " ADD COLUMN `price_members` VARCHAR(100) NULL DEFAULT '-' AFTER `price_loyal`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_send_report` (" _
                & "`claims_id` VARCHAR(100) NULL DEFAULT '-'," _
                & "`customer_id` VARCHAR(100) NULL DEFAULT '-'," _
                & "`serial_pro` VARCHAR(100) NULL DEFAULT '-'," _
                & "`code_pro` VARCHAR(100) NULL DEFAULT '-'," _
                & "`bar_code` VARCHAR(100) NULL DEFAULT '-'," _
                & "`name_pro` VARCHAR(500) NULL DEFAULT '-'," _
                & "`price_buy` VARCHAR(100) NULL DEFAULT '-'," _
                & "`price_wholesale` VARCHAR(100) NULL DEFAULT '-'," _
                & "`price_technician` VARCHAR(100) NULL DEFAULT '-'," _
                & "`price_loyal` VARCHAR(100) NULL DEFAULT '-'," _
                & "`price_members` VARCHAR(100) NULL DEFAULT '-'," _
                & "`type` VARCHAR(100) NULL DEFAULT '-'," _
                & "`unit` VARCHAR(100) NULL DEFAULT '-'," _
                & "`datetime_sale` VARCHAR(100) NULL DEFAULT '-'," _
                & "`datetime_return` VARCHAR(100) NULL DEFAULT '-'," _
                & "`datetime_edit` VARCHAR(100) NULL DEFAULT '-'," _
                & "`claims_money` VARCHAR(100) NULL DEFAULT '-'," _
                & "`employee_claims_return` VARCHAR(100) NULL DEFAULT '-'," _
                & "`tel_to_cus` VARCHAR(100) NULL DEFAULT '-'," _
                & "`employee_sale` VARCHAR(200) NULL DEFAULT '-'," _
                & "`symptom` VARCHAR(100) NULL DEFAULT '-'," _
                & "`accressory` VARCHAR(500) NULL DEFAULT '-'," _
                & "`note` VARCHAR(1000) NULL DEFAULT '-'," _
                & "`note2` VARCHAR(1000) NULL DEFAULT '-'," _
                & "`status` VARCHAR(50) NULL DEFAULT '-'," _
                & "`employee` VARCHAR(200) NULL DEFAULT '-'," _
                & "`datetime_save` VARCHAR(100) NULL DEFAULT '-'," _
                & "`claims_id_pic` LONGBLOB NULL" _
                & ")" _
                & "COLLATE() 'utf8_general_ci' ENGINE=MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims_send` ADD COLUMN `claims_lot` VARCHAR(50) NULL DEFAULT '-' AFTER `claims_send_status`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_lot_id` (`id` INT UNSIGNED NOT NULL AUTO_INCREMENT, `claims_lot` VARCHAR(100) NULL DEFAULT '0', `datetime_save` VARCHAR(100) NULL DEFAULT '0', PRIMARY KEY (`id`)) COLLATE='utf8_general_ci' ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `claims_lot_id` (`id`, `claims_lot`) VALUES (0, 'start');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_test_results` (`claims_id` VARCHAR(50) NULL DEFAULT '-', `fix_by_company` VARCHAR(50) NULL DEFAULT '-'," _
                & " `old_sn` VARCHAR(50) NULL DEFAULT '-', `new_sn` VARCHAR(50) NULL DEFAULT '-', `test_results` VARCHAR(50) NULL DEFAULT '-'," _
                & " `test_note` VARCHAR(500) NULL DEFAULT '-', `datetime_save` VARCHAR(50) NULL DEFAULT '-') COLLATE='utf8_general_ci' ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `customer`" _
                & " CHANGE COLUMN `customer_id` `customer_id` VARCHAR(45) NOT NULL DEFAULT '-' FIRST," _
                & " CHANGE COLUMN `customer_tax` `customer_tax` VARCHAR(45) NOT NULL DEFAULT '0000000000000' AFTER `customer_id`," _
                & " CHANGE COLUMN `customer_section` `customer_section` VARCHAR(100) NOT NULL DEFAULT '-' AFTER `customer_tax`," _
                & " CHANGE COLUMN `customer_name` `customer_name` VARCHAR(100) NOT NULL DEFAULT '-' AFTER `customer_section`," _
                & " CHANGE COLUMN `customer_address` `customer_address` VARCHAR(200) NOT NULL DEFAULT '-' AFTER `customer_name`," _
                & " CHANGE COLUMN `customer_zipcode` `customer_zipcode` VARCHAR(45) NOT NULL DEFAULT '-' AFTER `customer_address`," _
                & " CHANGE COLUMN `customer_tel` `customer_tel` VARCHAR(45) NOT NULL DEFAULT '-' AFTER `customer_zipcode`," _
                & " CHANGE COLUMN `customer_note` `customer_note` VARCHAR(255) NOT NULL DEFAULT '-' AFTER `customer_tel`," _
                & " CHANGE COLUMN `price_level` `price_level` VARCHAR(10) NOT NULL DEFAULT '-' AFTER `customer_note`," _
                & " ADD COLUMN `maturity` VARCHAR(50) NOT NULL DEFAULT '-' AFTER `price_level`," _
                & " ADD COLUMN `date_edit` VARCHAR(50) NOT NULL DEFAULT '-' AFTER `maturity`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `company` ADD COLUMN `com_qjob` VARCHAR(500) NULL DEFAULT '-' AFTER `com_claims`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `company` SET `com_qjob`='แจ้งเตือนมีงานซ่อมด่วนเข้า' WHERE  `ID`=1;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.7';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
    End Sub
End Module
