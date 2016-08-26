Imports MySql.Data.MySqlClient

Module updateDatabase1210
    Friend Sub updateDatabase_1210()
        Try
            strSQL = "ALTER TABLE `sn` DROP PRIMARY KEY;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `product` ADD COLUMN `varuntee` VARCHAR(45) NULL DEFAULT '-' AFTER `unit`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims_company` ADD COLUMN `company_address1` VARCHAR(500) NULL DEFAULT '-' AFTER `company_address`, ADD COLUMN `company_address2` VARCHAR(500) NULL DEFAULT '-' AFTER `company_address1`,ADD COLUMN `company_zipcode` VARCHAR(500) NULL DEFAULT '-' AFTER `company_address2`;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.2';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

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
