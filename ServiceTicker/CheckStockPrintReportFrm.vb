Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient


Public Class CheckStockPrintReportFrm
   
    Private Sub CheckStockPrintReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        'TODO: This line of code loads data into the 'CheckStockDataSet.check_stock' table. You can move, or remove it, as needed.
        Me.check_stockTableAdapter.Fill(Me.CheckStockDataSet.check_stock)

        'TODO: This line of code loads data into the 'CreditDataSet.pledge_sale' table. You can move, or remove it, as needed.
        Me.ReportViewer1.RefreshReport()
        Application.DoEvents()
    End Sub
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        strSQL = "select com_name from company"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Application.DoEvents()
        Dr = cmd.ExecuteReader
        Dr.Read()
        Dim cn As String
        cn = Dr.Item("com_name")
        Dim comname As New ReportParameter("com_name", cn)
        Dr.Close()
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname})
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer1.Print
        MsgBox("คำแนะนำ : ใช้กระดาษ A4 เท่านั้น", MsgBoxStyle.Information, "แนะนำ")
    End Sub
End Class