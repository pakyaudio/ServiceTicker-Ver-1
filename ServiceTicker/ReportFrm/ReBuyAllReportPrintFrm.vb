Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class ReBuyAllReportPrintFrm

    Private Sub ReBuyAllReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDBDataSet.buy_pro_rewordall' table. You can move, or remove it, as needed.
        Me.buy_pro_rewordallTableAdapter.Fill(Me.ReportDBDataSet.buy_pro_rewordall)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, ca As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            strSQL = "SELECT com_name,com_address FROM company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cn = Dr.Item("com_name")
            ca = Dr.GetString("com_address")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Dim c_name As New ReportParameter("com_name", cn)
        Dim c_address As New ReportParameter("com_address", ca)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {c_address, c_name})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class