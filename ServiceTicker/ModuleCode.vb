Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.Configuration
Imports System.Data.SQLite

Module ModuleCode
    Friend server As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "server", Nothing)
    Friend database As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "database", Nothing)
    Friend user As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "user", Nothing)
    Friend password As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "password", Nothing)
    Friend port As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "port", Nothing)
    'connect database
    Public data As String = "Server='" & server & "';Port='" & port & "';Database='" & database & "';Uid='" & user & "';Pwd='" & password & "';defaultcommandtimeout=3600;"
    Public ConnectionDB As New MySqlConnection(data)
    Dim constrAppconfig As String = "server=" + server + ";Port=" + port + ";user id=" + user + ";password=" + password + ";persistsecurityinfo=True;database=" + database + ";defaultcommandtimeout=3600;"
    Public strSQL As String
    Public dtAdapter As MySqlDataAdapter
    Public dt As DataTable
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public Dr As MySqlDataReader
    Public dv As DataView

    'SQLite connection
    Friend cnn As String = "Data Source=C:\ServiceTicker\ReportDB.sqlite;Version=3;"
    Public connSQLite As New SQLiteConnection(cnn)
    Public strSQLite As String
    Public dtSQLiteAdapter As SQLiteDataAdapter
    Public dtSQLite As DataTable
    Public dsSQLite As DataSet
    Public cmdSQLite As SQLiteCommand
    Public DrSQLite As SQLiteDataReader

    Public Sub open_connectionSQLite()
        Try
            If connSQLite.State = ConnectionState.Open Then connSQLite.Close()
            connSQLite.Open()
        Catch ex As Exception

        End Try
    End Sub


    Public Sub appconfig()
        Dim s As My.MySettings = My.Settings
        s.Item("servicetickerConnectionString") = constrAppconfig
    End Sub
    Public Sub open_connection()
        Try
            If ConnectionDB.State = ConnectionState.Open Then ConnectionDB.Close()
            ConnectionDB.Open()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ClearTextBoxes(frm As Form)
        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control
    End Sub

    'disable all textbox
    Public Sub disableTextBoxes(frm As Form)
        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.Enabled = False      'diable all text
            End If
        Next Control
    End Sub

    'enable all textbox
    Public Sub enableTextBoxes(frm As Form)
        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.Enabled = True     'Enabled all text
            End If
        Next Control
    End Sub
End Module
