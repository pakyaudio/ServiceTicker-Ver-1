Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing


Public Class BoxCoverPrintFrm1
  
    Private Sub BoxCoverPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        'Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, ca, ct As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load


        strSQL = "SELECT com_name,com_address,com_tel FROM company"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Dr = cmd.ExecuteReader
        Dr.Read()

        cn = Dr.Item("com_name")
        ca = Dr.Item("com_address")
        ct = Dr.Item("com_tel")



        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)

        Dim company_name As New ReportParameter("company_name", BoxCoverFrm.txtCScom_name.Text)
        Dim company_address As New ReportParameter("company_address", BoxCoverFrm.txtCScom_address.Text)
        Dim company_address1 As New ReportParameter("company_address1", BoxCoverFrm.txtCScom_addressAOM.Text)
        Dim company_address2 As New ReportParameter("company_address2", BoxCoverFrm.txtCScom_addressJJ.Text)
        Dim company_zipcode As New ReportParameter("company_zipcode", BoxCoverFrm.txtCScom_addressZip.Text)
        Dim company_tel As New ReportParameter("company_tel", BoxCoverFrm.txtCScom_contect.Text)
        Dim cl_id As New ReportParameter("claims_id", BoxCoverFrm.txtCSclaims_id.Text)
        Dim wn As New ReportParameter("warning", BoxCoverFrm.txtBCwarning.Text)
        Dr.Close()
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, wn, _
                                                                          company_name, company_address, company_address1, company_address2, company_zipcode, company_tel, cl_id})
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class