Imports MySql.Data.MySqlClient

Module update
    Friend Sub checkDB()
        Try
            strSQL = "SELECT version FROM database_version"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Dim vers As String
                vers = Dr.GetString("version")
                If vers = "2" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1200()
                ElseIf vers = "2.1" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1210()
                ElseIf vers = "2.2" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1220()
                ElseIf vers = "2.3" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1300()
                ElseIf vers = "2.4" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1310()
                ElseIf vers = "2.5" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1350()
                ElseIf vers = "2.6" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1400()
                ElseIf vers = "2.7" Or vers = "2.7.1" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1440()
                ElseIf vers = "2.8" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1450()
                ElseIf vers = "2.9" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1500()
                ElseIf vers = "3.0" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1511()
                ElseIf vers = "3.1" Then
                    Call BackUpDatabase()
                    Call updateDatabase_1522()
                End If
            ElseIf Not Dr.HasRows Then
                Call updateDatabase_1102()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Module
