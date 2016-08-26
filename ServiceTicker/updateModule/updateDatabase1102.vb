Imports MySql.Data.MySqlClient

Module updateDatabase1102
    Friend Sub updateDatabase_1102()
        Try
            strSQL = "CREATE TABLE `claims` (`claims_id` VARCHAR(100) NULL DEFAULT '-',`customer_id` VARCHAR(100) NULL DEFAULT '-',`serial_pro` VARCHAR(100) NULL DEFAULT '-',`code_pro` VARCHAR(100) NULL DEFAULT '-',`bar_code` VARCHAR(100) NULL DEFAULT '-',`name_pro` VARCHAR(500) NULL DEFAULT '-',`price_buy` VARCHAR(100) NULL DEFAULT '-',`type` VARCHAR(100) NULL DEFAULT '-',`unit` VARCHAR(100) NULL DEFAULT '-',`datetime_sale` VARCHAR(100) NULL DEFAULT '-',`employee_sale` VARCHAR(200) NULL DEFAULT '-',`symptom` VARCHAR(100) NULL DEFAULT '-',`accressory` VARCHAR(500) NULL DEFAULT '-',`note` VARCHAR(1000) NULL DEFAULT '-',`employee` VARCHAR(200) NULL DEFAULT '-',`datetime_save` VARCHAR(100) NULL DEFAULT '-',claims_id_pic LONGBLOB) COLLATE='utf8_general_ci' ENGINE=MyISAM;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_id` (`id` INT UNSIGNED NOT NULL AUTO_INCREMENT,`claims_id` VARCHAR(50) NULL DEFAULT '0',`datetime_save` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,PRIMARY KEY (`id`))COLLATE='utf8_general_ci'ENGINE=MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try


        Try
            strSQL = "INSERT INTO `claims_id` (`claims_id`) VALUES ('01');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `ver_detail` ADD COLUMN `ver_claims` VARCHAR(50) NULL DEFAULT '-' AFTER `ver_cashinvoice`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()

            strSQL = "UPDATE `ver_detail` SET `ver_claims`='CL';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`ADD COLUMN `status` VARCHAR(50) NULL DEFAULT '-' AFTER `note`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_send` (`claims_id` VARCHAR(50) NULL,`claims_company` VARCHAR(500) NULL,`claims_company_id` VARCHAR(50) NULL,`claims_send_status` VARCHAR(50) NULL,`datetime_edit` VARCHAR(100) NULL,`datetime_save` VARCHAR(100) NULL,`employee` VARCHAR(200) NULL)COLLATE='utf8_general_ci'ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_company` (`id` INT UNSIGNED NOT NULL AUTO_INCREMENT,`company_id` VARCHAR(50) NULL DEFAULT '-',`company_name` VARCHAR(500) NULL DEFAULT '-',`company_address` VARCHAR(500) NULL DEFAULT '-',`company_contect` VARCHAR(500) NULL DEFAULT '-',PRIMARY KEY (`id`))COLLATE='utf8_general_ci'ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims_send`CHANGE COLUMN `claims_id` `claims_id` VARCHAR(50) NULL DEFAULT '-' FIRST,CHANGE COLUMN `claims_company` `claims_company` VARCHAR(500) NULL DEFAULT '-' AFTER `claims_id`,CHANGE COLUMN `claims_company_id` `claims_company_id` VARCHAR(50) NULL DEFAULT '-' AFTER `claims_company`,CHANGE COLUMN `claims_send_status` `claims_send_status` VARCHAR(50) NULL DEFAULT '-' AFTER `claims_company_id`,CHANGE COLUMN `datetime_edit` `datetime_edit` VARCHAR(100) NULL DEFAULT '-' AFTER `claims_send_status`,CHANGE COLUMN `datetime_save` `datetime_save` VARCHAR(100) NULL DEFAULT '-' AFTER `datetime_edit`,CHANGE COLUMN `employee` `employee` VARCHAR(200) NULL DEFAULT '-' AFTER `datetime_save`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims_send`ADD COLUMN `claims_note` VARCHAR(50) NULL DEFAULT '-' AFTER `claims_company_id`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `claims_company_id` (`claims_company_id`) VALUES ('start');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`ADD COLUMN `datetime_return` VARCHAR(100) NULL DEFAULT '-' AFTER `datetime_sale`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`ADD COLUMN `claims_money` VARCHAR(100) NULL DEFAULT '-' AFTER `datetime_return`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`ADD COLUMN `employee_claims_return` VARCHAR(100) NULL DEFAULT '-' AFTER `claims_money`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`ADD COLUMN `tel_to_cus` VARCHAR(100) NULL DEFAULT '-' AFTER `employee_claims_return`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims`ADD COLUMN `datetime_edit` VARCHAR(100) NULL DEFAULT '-' AFTER `datetime_return`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `comfix`ADD COLUMN `claims_id` VARCHAR(45) NOT NULL AFTER `fix_id`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `applogs`CHANGE COLUMN `user_id` `user_id` VARCHAR(255) NULL DEFAULT '-' FIRST,CHANGE COLUMN `user_name` `user_name` VARCHAR(255) NULL DEFAULT '-' AFTER `user_id`,CHANGE COLUMN `user_usernamelogin` `user_usernamelogin` VARCHAR(255) NULL DEFAULT '-' AFTER `user_name`,ADD COLUMN `note` VARCHAR(255) NULL DEFAULT '-' AFTER `user_usernamelogin`,CHANGE COLUMN `date_in` `date_in` DATETIME NULL DEFAULT NULL AFTER `note`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims` ADD COLUMN `note2` VARCHAR(1000) NULL DEFAULT '-' AFTER `note`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `claims_copy` (`claims_id` VARCHAR(100) NULL DEFAULT '-',`customer_id` VARCHAR(100) NULL DEFAULT '-',`serial_pro` VARCHAR(100) NULL DEFAULT '-',`code_pro` VARCHAR(100) NULL DEFAULT '-',`bar_code` VARCHAR(100) NULL DEFAULT '-',`name_pro` VARCHAR(500) NULL DEFAULT '-',`price_buy` VARCHAR(100) NULL DEFAULT '-',`type` VARCHAR(100) NULL DEFAULT '-',`unit` VARCHAR(100) NULL DEFAULT '-',`datetime_sale` VARCHAR(100) NULL DEFAULT '-',`datetime_return` VARCHAR(100) NULL DEFAULT '-',`datetime_edit` VARCHAR(100) NULL DEFAULT '-',`claims_money` VARCHAR(100) NULL DEFAULT '-',`employee_claims_return` VARCHAR(100) NULL DEFAULT '-',`tel_to_cus` VARCHAR(100) NULL DEFAULT '-',`employee_sale` VARCHAR(200) NULL DEFAULT '-',`symptom` VARCHAR(100) NULL DEFAULT '-',`accressory` VARCHAR(500) NULL DEFAULT '-',`note` VARCHAR(1000) NULL DEFAULT '-',`note2` VARCHAR(1000) NULL DEFAULT '-',`status` VARCHAR(50) NULL DEFAULT '-',`employee` VARCHAR(200) NULL DEFAULT '-',`datetime_save` VARCHAR(100) NULL DEFAULT '-',claims_id_pic LONGBLOB NULL)COLLATE='utf8_general_ci' ENGINE=MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `database_version` (`version` VARCHAR(50) NULL DEFAULT '0')COLLATE='utf8_general_ci'ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()

            strSQL = "INSERT INTO `database_version` (`version`) VALUES ('2');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1200()
        Call updateDatabase_1210()
        Call updateDatabase_1220()
        Call updateDatabase_1300()
        Call updateDatabase_1310()
        Call updateDatabase_1350()
        Call updateDatabase_1400()
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
    End Sub
End Module
