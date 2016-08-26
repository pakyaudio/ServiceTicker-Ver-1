Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class CheckedStockReportFrm
   
    Private Sub CheckedStockReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        'TODO: This line of code loads data into the 'CheckedDataSet.check_stock_cache' table. You can move, or remove it, as needed.
        Me.check_stock_cacheTableAdapter.Fill(Me.CheckedDataSet.check_stock_cache)
        Me.ReportViewer1.RefreshReport()
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