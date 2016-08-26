Imports MySql.Data.MySqlClient

Module updateDatabase1220
    Friend Sub updateDatabase_1220()
        Try
            strSQL = "ALTER TABLE `company` ADD COLUMN `footer3` VARCHAR(500) NULL DEFAULT '-' AFTER `footer2`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `company` ADD COLUMN `com_sendrepairrow3` VARCHAR(500) NULL DEFAULT '-' AFTER `com_sendrepairrow2`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `company` ADD COLUMN `com_claims` VARCHAR(500) NULL DEFAULT '-' AFTER `com_billing`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `comfix_cache` (`fix_id` VARCHAR(45) NOT NULL, `claims_id` VARCHAR(45) NOT NULL, `date_save` VARCHAR(20) NULL DEFAULT '-', `customer_id` VARCHAR(100) NULL DEFAULT '-', `customer_name` VARCHAR(100) NULL DEFAULT '-', `sn` VARCHAR(50) NULL DEFAULT '-', `symptom` VARCHAR(100) NULL DEFAULT '-', `managerdata` VARCHAR(100) NULL DEFAULT '-', `fixrepairnote` VARCHAR(500) NULL DEFAULT '-', `fixaccessory` VARCHAR(500) NULL DEFAULT '-', `fixnote` VARCHAR(500) NULL DEFAULT '-', `fixtprice` VARCHAR(45) NULL DEFAULT '-', `varuntee` VARCHAR(45) NULL DEFAULT '-', `date_get` VARCHAR(20) NULL DEFAULT '-', `fixuser` VARCHAR(45) NULL DEFAULT '-', `status` VARCHAR(45) NULL DEFAULT '-', `user_repair` VARCHAR(100) NULL DEFAULT '-', `note_repair` VARCHAR(500) NULL DEFAULT '-', `teltocus` VARCHAR(45) NULL DEFAULT '-', `date_send` VARCHAR(45) NULL DEFAULT '-', `datecom_repair` VARCHAR(45) NULL DEFAULT '-', `comfix_barcode` LONGBLOB NULL, PRIMARY KEY (`fix_id`), UNIQUE INDEX `fix_id_UNIQUE` (`fix_id`)) COLLATE='utf8_general_ci'ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_cache` (`claims_id` VARCHAR(100) NULL DEFAULT '-', `customer_id` VARCHAR(100) NULL DEFAULT '-', `serial_pro` VARCHAR(100) NULL DEFAULT '-', `code_pro` VARCHAR(100) NULL DEFAULT '-', `bar_code` VARCHAR(100) NULL DEFAULT '-', `name_pro` VARCHAR(500) NULL DEFAULT '-', `price_buy` VARCHAR(100) NULL DEFAULT '-', `type` VARCHAR(100) NULL DEFAULT '-', `unit` VARCHAR(100) NULL DEFAULT '-', `datetime_sale` VARCHAR(100) NULL DEFAULT '-', `datetime_return` VARCHAR(100) NULL DEFAULT '-', `datetime_edit` VARCHAR(100) NULL DEFAULT '-', `claims_money` VARCHAR(100) NULL DEFAULT '-', `employee_claims_return` VARCHAR(100) NULL DEFAULT '-', `tel_to_cus` VARCHAR(100) NULL DEFAULT '-', `employee_sale` VARCHAR(200) NULL DEFAULT '-', `symptom` VARCHAR(100) NULL DEFAULT '-', `accressory` VARCHAR(500) NULL DEFAULT '-', `note` VARCHAR(1000) NULL DEFAULT '-', `note2` VARCHAR(1000) NULL DEFAULT '-', `status` VARCHAR(50) NULL DEFAULT '-', `employee` VARCHAR(200) NULL DEFAULT '-', `datetime_save` VARCHAR(100) NULL DEFAULT '-', `claims_id_pic` LONGBLOB NULL ) COLLATE='utf8_general_ci'ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.3';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1300()
        Call updateDatabase_1310()
        Call updateDatabase_1350()
        Call updateDatabase_1400()
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
    End Sub
End Module
