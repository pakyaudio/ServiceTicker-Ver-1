Imports MySql.Data.MySqlClient

Public Class StatisticsFrm


    Private Sub StatisticsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strSQL = "SELECT * from comfix"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Dr = cmd.ExecuteReader
        While (Dr.Read())

        End While
        Dr.Close()
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Label1.Text = DateTimePicker1.Value
    End Sub

  
End Class