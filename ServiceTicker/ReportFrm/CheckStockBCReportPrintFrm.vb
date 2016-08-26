Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class CheckStockBCReportPrintFrm

    Private Sub CheckStockBCReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDBDataSet.check_stock_bc' table. You can move, or remove it, as needed.
        Me.check_stock_bcTableAdapter.Fill(Me.ReportDBDataSet.check_stock_bc)
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
            ca = Dr.Item("com_address")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

 
        Dim cname As New ReportParameter("com_name", cn)
        Dim caddress As New ReportParameter("com_address", ca)
        Dim cid As New ReportParameter("csbc_id", CheckStoclBarcodeFrm.txtCSBCid.Text)
        Dim ttpo As New ReportParameter("total_pro", CheckStoclBarcodeFrm.txtCSBCtotalPro.Text)
        Dim conum As New ReportParameter("count_num", CheckStoclBarcodeFrm.txtCSBCcNumPro.Text)
        Dim fai As New ReportParameter("fail", CheckStoclBarcodeFrm.txtCSBCfail.Text)
        Dim ov As New ReportParameter("over", CheckStoclBarcodeFrm.txtCSBCfull.Text)
        'Dim d As New ReportParameter("discount", ReportUserRepairFrm.txtRURdiscount.Text)
        'Dim p As New ReportParameter("profit", ReportUserRepairFrm.txtRURtotalProfit.Text)

        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {cname, caddress, cid, ttpo, conum, fai, ov})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class