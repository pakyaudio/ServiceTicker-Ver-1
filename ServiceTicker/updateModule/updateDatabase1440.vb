Imports MySql.Data.MySqlClient

Module updateDatabase1440
    Friend Sub updateDatabase_1440()
        Try
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = ConnectionDB
            Call open_connection()
            Application.DoEvents()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ImportFromFile("C:\ServiceTicker\DatabaseUpdate\sql271.sql")
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.8';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Call updateDatabase_1450()
        Call updateDatabase_1500()
    End Sub
End Module
