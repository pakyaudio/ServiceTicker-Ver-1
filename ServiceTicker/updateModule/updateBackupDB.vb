Imports MySql.Data.MySqlClient
Imports System.IO


Module updateBackupDB

    Friend Sub BackUpDatabase()
        Try
            Dim di As DirectoryInfo = New DirectoryInfo("C:\ServiceTicker\BackupDB")
            '*** Create Folder ***'
            If Not di.Exists Then
                di.Create()
            End If
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile("C:\ServiceTicker\BackupDB\Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql")
        Catch ex As Exception

        End Try
    End Sub
End Module
