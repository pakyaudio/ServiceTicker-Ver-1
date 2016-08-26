Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing

Public Class ClaimsReportPrintFrm
   
    Private Sub ClaimsReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClaimsGroupDataSet.claims_cache' table. You can move, or remove it, as needed.
        Me.claims_cacheTableAdapter.Fill(Me.ClaimsGroupDataSet.claims_cache)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        'Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.PrinterSettings.Copies = 2
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, ca, ct, img, cm As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            'ข้อมูลเกี่ยวกับบริษัท
            strSQL = "SELECT com_name,com_address,com_tel,images,com_claims FROM company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cn = Dr.GetString("com_name")
            ca = Dr.GetString("com_address")
            ct = Dr.GetString("com_tel")
            img = Dr.GetString("images")
            cm = Dr.GetString("com_claims")
        Catch ex As Exception

        End Try
        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        'Dim imsss As New ReportParameter("imagepath", img)
        'Dim c_id As New ReportParameter("claims_id", ClaimsFrm.txtCFclaims_id.Text)
        Dim customer_id As New ReportParameter("cus_id", ClaimsFrm.txtCFcustomer_id.Text)
        Dim customer_name As New ReportParameter("cus_name", ClaimsFrm.txtCFcustomer_name.Text)
        'Dim sn_pro As New ReportParameter("sn", ClaimsFrm.txtCFserial_pro.Text)
        'Dim barcode_pro As New ReportParameter("barcode", ClaimsFrm.txtCFbar_code.Text)
        'Dim name_pro_pro As New ReportParameter("name_pro", ClaimsFrm.txtCFname_pro.Text)
        'Dim sytp As New ReportParameter("symptom", ClaimsFrm.txtCFsyptom.Text)
        'Dim acc As New ReportParameter("accressory", ClaimsFrm.txtCFaccessory.Text)
        'Dim ne As New ReportParameter("note", ClaimsFrm.txtCFnote.Text)
        'Dim emp As New ReportParameter("employee", ClaimsFrm.lblemployee.Text)
        Dim cmp As New ReportParameter("com_claimbill", cm)
       

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, customer_id, customer_name, comtel, cmp})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class