Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Public Class ReturnClaimsToCusReportPrintFrm
    Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ReturnClaimstoCus1Frm.Close()
    End Sub
  
    Private Sub ReturnClaimsToCusReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        ' Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.PrinterSettings.Copies = 2
        Me.ReportViewer1.RefreshReport()
        Me.Icon = Mainfrm.Icon
    End Sub
    Dim cn, ca, ct, img As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            'ข้อมูลเกี่ยวกับบริษัท
            strSQL = "SELECT com_name,com_address,com_tel,images FROM company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cn = Dr.Item("com_name")
            ca = Dr.Item("com_address")
            ct = Dr.Item("com_tel")
            img = Dr.Item("images")
        Catch ex As Exception

        End Try
        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        Dim c_id As New ReportParameter("claims_id", ReturnClaimstoCus1Frm.txtRCTC1claims_id.Text)
        Dim customer_id As New ReportParameter("cus_id", ReturnClaimstoCus1Frm.txtRCTC1cus_id.Text)
        Dim customer_name As New ReportParameter("cus_name", ReturnClaimstoCus1Frm.txtRCTC1cus_name.Text)
        Dim customer_tel As New ReportParameter("cus_tel", ReturnClaimstoCus1Frm.txtRCTC1cus_tel.Text)
        Dim sn_pro As New ReportParameter("sn", ReturnClaimstoCus1Frm.txtRCTC1serial_pro.Text)
        Dim barcode_pro As New ReportParameter("barcode", ReturnClaimstoCus1Frm.txtRCTC1bar_code.Text)
        Dim name_pro_pro As New ReportParameter("name_pro", ReturnClaimstoCus1Frm.txtRCTC1name_pro.Text)
        Dim sytp As New ReportParameter("symptom", ReturnClaimstoCus1Frm.txtRCTC1symptom.Text)
        Dim acc As New ReportParameter("accressory", ReturnClaimstoCus1Frm.txtRCTCaccessory.Text)
        Dim ne As New ReportParameter("note", ReturnClaimstoCus1Frm.txtRCTC1fix.Text)
        Dim emp As New ReportParameter("employee", ReturnClaimstoCus1Frm.lblemployee.Text)
        Dim dts As New ReportParameter("datetime_sale", ReturnClaimstoCus1Frm.txtRCTC1datetime_sale.Text)
        Dim dtss As New ReportParameter("datetime_save", ReturnClaimstoCus1Frm.txtRCTC1datetime_save.Text)
        Dim dtr As New ReportParameter("datetime_return", ReturnClaimstoCus1Frm.txtRCTC1datetime_edit.Text)


        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, c_id, customer_id, customer_name, _
                                                                          customer_tel, sn_pro, barcode_pro, name_pro_pro, sytp, acc, ne, emp, _
                                                                          dts, dtss, dtr})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class