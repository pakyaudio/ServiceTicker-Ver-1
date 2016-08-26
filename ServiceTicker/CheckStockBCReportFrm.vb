Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class CheckStockBCReportFrm

    Private Sub CheckStockReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(0)
    End Sub

    Private Sub searchCheckStock()
        Try
            Using dt = New DataTable
                strSQL = "SELECT datetime_save,total_pro_bc,count_num,disappear,over,datetime_last,employee " _
                    & "FROM check_stock_bc_id WHERE datetime_save LIKE '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM", CultureInfo.CreateSpecificCulture("en-EN")) & "%'"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgCSR.DataSource = dt
            End Using
            For sum As Integer = 0 To Me.dgCSR.Rows.Count - 1
                Me.dgCSR.Rows(sum).Cells(0).Value = sum + 1
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCSRsearch_Click(sender As Object, e As EventArgs) Handles btnCSRsearch.Click
        searchCheckStock()
    End Sub

    Private Sub DateTimePicker1_FormatChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.FormatChanged
        DateTimePicker1.CustomFormat = "MMMM yyyy"
    End Sub


End Class