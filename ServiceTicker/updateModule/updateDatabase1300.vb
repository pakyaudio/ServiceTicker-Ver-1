Imports MySql.Data.MySqlClient

Module updateDatabase1300
    Friend Sub updateDatabase_1300()
        Try
            strSQL = "CREATE TABLE `audit_outgoings` (" _
                & "`datetime` VARCHAR(100) NULL DEFAULT '-'," _
                & "`namewiden` VARCHAR(200) NULL DEFAULT '-'," _
                & "`list` VARCHAR(200) NULL DEFAULT '-'," _
                & "`money` VARCHAR(200) NULL DEFAULT '0'," _
                & "`note` VARCHAR(200) NULL DEFAULT '-')COLLATE='utf8_general_ci'ENGINE=MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `audit` (" _
                 & "`datetime` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money1` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money2` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money5` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money10` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money20` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money50` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money100` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money500` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`money1000` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`totalAll` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`check` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`transfer` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`cash` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`charges` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`deliverMorning` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`deliverNoon` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`deliverEvening` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`totalDeliver` VARCHAR(100) NULL DEFAULT '0'," _
                 & "`difference` VARCHAR(100) NULL DEFAULT '0'" _
                 & ")" _
                 & "COLLATE='utf8_general_ci'" _
                 & "ENGINE=MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.4';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Call updateDatabase_1310()
        Call updateDatabase_1350()
        Call updateDatabase_1400()
        Call updateDatabase_1440()
        Call updateDatabase_1450()
        Call updateDatabase_1500()
    End Sub
End Module
