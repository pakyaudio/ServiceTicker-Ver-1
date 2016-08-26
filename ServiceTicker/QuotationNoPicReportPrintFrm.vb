Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Public Class QuotationNoPicReportPrintFrm

    Private Sub QuotationReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QDataSet.quotation' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'QDataSet.quotation' table. You can move, or remove it, as needed.
        Me.quotationTableAdapter.FillQU(Me.QDataSet.quotation)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.PrinterSettings.Copies = 2
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, ca, ct, em, qu, ims, fax, tax, cidcq, qidcq As String
    Dim cusname, cusaddress, cuszipcode, custel As String

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            strSQL = "SELECT customer_name,customer_address,customer_zipcode,customer_tel FROM customer WHERE customer_id='" & PartsWithdrawalFrm.txtPWcusID.Text & "' or customer_id='" & CreateQuotationFrm.txtPWcusID.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cusname = Dr("customer_name")
            cusaddress = Dr("customer_address")
            cuszipcode = Dr("customer_zipcode")
            custel = Dr("customer_tel")
        Catch ex As Exception

        End Try
        strSQL = "select com_name,com_address,com_tel,com_fax,com_tax,com_email,com_quotation,images from company"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Dr = cmd.ExecuteReader
        Dr.Read()
        cn = Dr.Item("com_name")
        ca = Dr.Item("com_address")
        ct = Dr.Item("com_tel")
        fax = Dr.Item("com_fax")
        tax = Dr.Item("com_tax")
        ims = Dr.Item("images")
        em = Dr.Item("com_email")
        qu = Dr.Item("com_quotation")
        qidcq = PartsWithdrawalFrm.qid
        qidcq = CreateQuotationFrm.qid
        cidcq = PartsWithdrawalFrm.txtPWcusID.Text
        cidcq = CreateQuotationFrm.txtPWcusID.Text
        strSQL = "SELECT SUM(multiply) FROM quotation WHERE quotation_id='" & PartsWithdrawalFrm.qid & "' or quotation_id='" & CreateQuotationFrm.qid & "'"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Dr = cmd.ExecuteReader
        Dr.Read()
        Dim msum As String
        msum = Dr(0)
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(msum))
        Catch ex As Exception
            thaitext = ""
        End Try

        ' '' ''Me.ReportViewer1.RefreshReport()          quotation_id
        ' '' ''Dim datasource As ReportDataSource = New ReportDataSource("Snum", dt)

        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        Dim comemail As New ReportParameter("com_email", em)
        Dim comquotation As New ReportParameter("com_quotation", qu)
        Dim imgss As New ReportParameter("imagepath", ims)
        Dim f As New ReportParameter("com_fax", fax)
        Dim t As New ReportParameter("com_tax", tax)
        Dim c_id As New ReportParameter("cus_id", cidcq)
        Dim c_name As New ReportParameter("cus_name", cusname)
        Dim c_address As New ReportParameter("cus_address", cusaddress)
        Dim c_zipcode As New ReportParameter("cus_zipcode", cuszipcode)
        Dim c_tel As New ReportParameter("cus_tel", custel)
        Dim q_id As New ReportParameter("quotation_id", qidcq)
        Dim tx As New ReportParameter("thai_text", thaitext)
        Dim tt As New ReportParameter("total", msum)
        Dim dt As New ReportParameter("datetime", "วันที่................................................")

        'Dr.Close()
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {imgss, comname, comaddress, comtel, comemail, comquotation, f, t, _
                                                                    c_id, c_name, c_address, c_zipcode, c_tel, q_id, tx, tt, dt})
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class