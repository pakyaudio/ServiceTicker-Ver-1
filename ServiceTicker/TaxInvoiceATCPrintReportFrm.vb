Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing

Public Class TaxInvoiceATCPrintReportFrm
    'Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    TaxInvoiceFrm.restart()
    'End Sub
    
    Private Sub TaxInvoiceATCPrintReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        'TODO: This line of code loads data into the 'TaxInvoiceDataSet.taxinvoice' table. You can move, or remove it, as needed.
        Me.taxinvoiceTableAdapter.Fill(Me.TaxInvoiceDataSet.taxinvoice)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, ca, ct, ims, ctax, cf As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try


            strSQL = "select com_name,com_address,com_tel,com_fax,com_tax,images from company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()

            cn = Dr.Item("com_name")
            ca = Dr.Item("com_address")
            ct = Dr.Item("com_tel")
            cf = Dr.Item("com_fax")
            ctax = Dr.Item("com_tax")
            ims = Dr.Item("images")
        Catch ex As Exception

        End Try
        Call TaxInvoiceFrm.cbs()
        Call TaxInvoiceFrm.selbill()
        Dim HD As New ReportParameter("header", TaxInvoiceFrm.cbbTIselectbill.Text)
        Dim DT As New ReportParameter("datetime", TaxInvoiceFrm.DTPTI1.ToString)
        Dim bid As New ReportParameter("bill_id", TaxInvoiceFrm.txtTIbillID.Text)
        Dim imss As New ReportParameter("imagepath", ims)
        Dim cname As New ReportParameter("com_name", cn)
        Dim caddress As New ReportParameter("com_address", ca)
        Dim ctel As New ReportParameter("com_tel", ct)
        Dim cfax As New ReportParameter("com_fax", cf)
        Dim ctaxx As New ReportParameter("com_tax", ctax)
        Dim cusid As New ReportParameter("cus_id", TaxInvoiceFrm.txtTIcusid.Text)
        Dim cusname As New ReportParameter("cus_name", TaxInvoiceFrm.txtTIcusname.Text)
        Dim cusaddress As New ReportParameter("cus_address", TaxInvoiceFrm.txtTIcusaddress.Text)
        Dim custel As New ReportParameter("cus_tel", TaxInvoiceFrm.txtTIcustel.Text)
        Dim custax As New ReportParameter("cus_tax", TaxInvoiceFrm.txtTItaxNumber.Text)
        Dim cussection As New ReportParameter("cus_section", TaxInvoiceFrm.txtTItaxSection.Text)
        Dim ttext As New ReportParameter("thai_text", TaxInvoiceFrm.txtTItahitext.Text)
        Dim ttal As New ReportParameter("total", TaxInvoiceFrm.txtTItotalPro.Text)
        Dim dcount As New ReportParameter("discount", TaxInvoiceFrm.dc)
        Dim ttax As New ReportParameter("tax_pro", TaxInvoiceFrm.tp)
        Dim ttalll As New ReportParameter("total_all", TaxInvoiceFrm.txtTItotalAll.Text)
        Dim mnumber As New ReportParameter("m_number", TaxInvoiceFrm.txtTIm_number.Text)
        Dim nnoottee As New ReportParameter("note", TaxInvoiceFrm.txtTInote.Text)
        Dim ssp As New ReportParameter("sensendProduct", TaxInvoiceFrm.ssp)
        Dim srp As New ReportParameter("senReproduct", TaxInvoiceFrm.srp)
        Dim kuru As New ReportParameter("kurupnn", TaxInvoiceFrm.txtTIkuru.Text)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {HD, DT, imss, bid, cname, caddress, ctel, cfax, ctaxx, cusid, _
                                                                         cusname, cusaddress, custel, custax, cussection, ttext, ttal, _
                                                                         dcount, ttax, ttalll, nnoottee, ssp, srp, mnumber, kuru})
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class