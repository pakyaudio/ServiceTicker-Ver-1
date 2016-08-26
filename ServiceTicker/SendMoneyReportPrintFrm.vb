Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Public Class SendMoneyReportPrintFrm
    Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SendMoneyClaimsFrm.Close()
    End Sub
   
    Private Sub SendMoneyReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        'Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.PrinterSettings.Copies = 2
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, ca, ct As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            strSQL = "SELECT com_name,com_address,com_tel,com_fax,com_tax,com_email,com_quotation,images FROM company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cn = Dr.Item("com_name")
            ca = Dr.Item("com_address")
            ct = Dr.Item("com_tel")
        Catch ex As Exception

        End Try

        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        Dim returnid As New ReportParameter("return_id", SendMoneyClaimsFrm.txtRP_ID.Text)
        Dim cid As New ReportParameter("cus_id", SendMoneyClaimsFrm.txtRPcustomerID.Text)
        Dim cname As New ReportParameter("cus_name", SendMoneyClaimsFrm.txtRPcustomerName.Text)
        Dim ctel As New ReportParameter("cus_tel", SendMoneyClaimsFrm.txtRPcustomerTel.Text)
        Dim bc As New ReportParameter("bar_code", SendMoneyClaimsFrm.bar_code)
        Dim np As New ReportParameter("name_pro", SendMoneyClaimsFrm.np)
        Dim pb As New ReportParameter("price_buy", SendMoneyClaimsFrm.price_by)
        Dim tt As New ReportParameter("total", SendMoneyClaimsFrm.total)
        Dim tp As New ReportParameter("total_price", SendMoneyClaimsFrm.total_price)
        Dim ps As New ReportParameter("total_price", SendMoneyClaimsFrm.lblRPproductStatus.Text)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, returnid, cid, cname, ctel, _
                                                                      bc, np, pb, tt, tp, ps})
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class