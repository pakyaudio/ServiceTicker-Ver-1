Imports MySql.Data.MySqlClient
Imports System.Data.SQLite

Public Class Form1
    Friend server As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "server", Nothing)
    Friend database As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "database", Nothing)
    Friend user As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "user", Nothing)
    Friend password As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "password", Nothing)
    Friend port As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "port", Nothing)
    'connect database
    Public data As String = "Server='" & server & "';Port='" & port & "';Database='" & database & "';Uid='" & user & "';Pwd='" & password & "';defaultcommandtimeout=3600;"
    Public ConnectionDB As New MySqlConnection(Data)
    Public strSQL As String
    Public dtAdapter As MySqlDataAdapter
    Public dt As DataTable
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public Dr As MySqlDataReader
    Public dv As DataView
    'SQLite connection
    Friend cnn As String = "Data Source=C:\ServiceTicker\web_ticker\ServiceTickerOnline.sqlite;Version=3;"
    Public connSQLite As New SQLiteConnection(cnn)
    Public strSQLite As String
    Public cmdSQLite As SQLiteCommand


    Public Sub open_connectionSQLite()
        Try
            If connSQLite.State = ConnectionState.Open Then connSQLite.Close()
            connSQLite.Open()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub open_connection()
        Try
            If ConnectionDB.State = ConnectionState.Open Then ConnectionDB.Close()
            ConnectionDB.Open()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.BalloonTipText = "อัพเดทข้อมูลขึ้นเว็บไซต์"
        NotifyIcon1.Text = "ServiceTicker"
        NotifyIcon1.ShowBalloonTip(5500)
        NotifyIcon1.Visible = True
        Try
            strSQL = "SELECT fix_id,date_save,customer_id,customer_name,sn,`status`,datecom_repair " & _
                "FROM comfix WHERE NOT (`status`='7 คืนเครื่องแล้ว')"
            Me.lblStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            While Dr.Read()
                Dim r As Integer
                With Me.DataGridView1
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("fix_id")
                    .Rows(r).Cells(1).Value = Dr.GetString("date_save")
                    .Rows(r).Cells(2).Value = Dr.GetString("customer_id")
                    .Rows(r).Cells(3).Value = Dr.GetString("customer_name")
                    .Rows(r).Cells(4).Value = Dr.GetString("sn")
                    .Rows(r).Cells(5).Value = Dr.GetString("status")
                    .Rows(r).Cells(6).Value = Dr.GetString("datecom_repair")
                End With
            End While
        Catch ex As Exception
            Me.lblStatus.Text = ex.Message
        End Try
        Try
            strSQLite = "DELETE FROM comfix"
            Me.lblStatus.Text = strSQL
            cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
            Call open_connectionSQLite()
            cmdSQLite.ExecuteNonQuery()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Me.lblStatus.Text = ex.Message
        End Try
        Try
            For addD As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                strSQLite = "INSERT INTO comfix (fix_id,date_save,customer_id,customer_name,sn,`status`,datecom_repair )" & _
                    "VALUES(@fix_id,@date_save,@customer_id,@customer_name,@sn,@status,@datecom_repair )"
                Me.lblStatus.Text = strSQL
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                With Me.DataGridView1
                    cmdSQLite.Parameters.AddWithValue("@fix_id", .Rows(addD).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@date_save", .Rows(addD).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@customer_id", .Rows(addD).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@customer_name", .Rows(addD).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@sn", .Rows(addD).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@status", .Rows(addD).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@datecom_repair", .Rows(addD).Cells(6).Value)
                End With
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
            Next
        Catch ex As Exception
            Me.lblStatus.Text = ex.Message
        End Try
        Timer1.Start()
    End Sub
    
    Dim tt As Integer = 10
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblStatus.Text = tt
        tt = tt - 1
        If tt = 0 Then
            Me.Close()
            Timer1.Stop()
            Dispose()
        End If
    End Sub
End Class
