Imports MySql.Data.MySqlClient

Module updateDatabase1310
    Friend Sub updateDatabase_1310()
        Try
            strSQL = "CREATE TABLE `stock_number_cache` (" _
                    & "`number` VARCHAR(50) NULL," _
                    & "`code_pro` VARCHAR(200) NULL," _
                    & "`bar_code` VARCHAR(200) NULL," _
                    & "`name_pro` VARCHAR(500) NULL," _
                    & "`type` VARCHAR(100) NULL," _
                    & "`price_cost` VARCHAR(100) NULL," _
                    & "`total_all` VARCHAR(100) NULL," _
                    & "`total_cost` VARCHAR(100) NULL" _
                    & ")" _
                    & "COLLATE='utf8_general_ci'" _
                    & "ENGINE=MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `stock_number_sn_cache` (" _
                    & "`no` VARCHAR(50) NULL," _
                    & "`code_pro` VARCHAR(100) NULL," _
                    & "`sn` VARCHAR(100) NULL," _
                    & "`name_pro` VARCHAR(500) NULL," _
                    & "`datetime` VARCHAR(100) NULL" _
                    & ")" _
                    & "COLLATE='utf8_general_ci'" _
                    & "ENGINE=MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.5';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1350()
        Call updateDatabase_1400()
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
    End Sub
End Module
