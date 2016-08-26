Imports MySql.Data.MySqlClient

Module updateDatabase1350
    Friend Sub updateDatabase_1350()
        Try
            strSQL = "ALTER TABLE `comfix` ADD COLUMN `importune` VARCHAR(45) NULL DEFAULT '-' AFTER `datecom_repair`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `comfix_cache` ADD COLUMN `importune` VARCHAR(45) NULL DEFAULT '-' AFTER `datecom_repair`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `comfix` ADD COLUMN `storage` VARCHAR(100) NULL DEFAULT '-' AFTER `importune`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `sn_id` (`id` INT(100) UNSIGNED NOT NULL AUTO_INCREMENT, `id` VARCHAR(50) NULL DEFAULT '0', `datetime_save` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP, PRIMARY KEY (`id`)) COLLATE() 'utf8_general_ci' ENGINE=MyISAM ROW_FORMAT=DEFAULT; AUTO_INCREMENT=3;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `sn_id` (`sn_id`) VALUES ('01');"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.6';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Call updateDatabase_1400()
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
    End Sub
End Module
