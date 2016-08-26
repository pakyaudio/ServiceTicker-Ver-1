Imports MySql.Data.MySqlClient

Module updateDatabase1200
    Friend Sub updateDatabase_1200()
        Try
            strSQL = "CREATE TABLE `claims_company_id` (`id` INT NOT NULL AUTO_INCREMENT,`claims_company_id` VARCHAR(50) NULL DEFAULT '0',`datetime_save` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,PRIMARY KEY (`id`))COLLATE='utf8_general_ci'ENGINE = MyISAM;"

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
            strSQL = "UPDATE `database_version` SET `version`='2.1';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

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
