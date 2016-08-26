Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class InvoiceReportFrm
    
    Private Sub InvoiceReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STDataSet.sale_barcode' table. You can move, or remove it, as needed.
        Me.sale_barcodeTableAdapter.Fillsalebarcode(Me.STDataSet.sale_barcode)
        Me.Icon = Mainfrm.Icon
        'Me.invoiceReport.Size = New System.Drawing.Size(871, 743)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        'โชว์ print layout
        'Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.PrinterSettings.Copies = 2
        Me.ReportViewer1.RefreshReport()
    End Sub

    Dim cn, ca, ct, cl, ci, imm As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            strSQL = "SELECT com_name,com_address,com_tel,com_email,images,com_Invoice FROM company"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()

            cn = Dr.Item("com_name")
            ca = Dr.Item("com_address")
            ct = Dr.Item("com_tel")
            cl = Dr.Item("com_email")
            ci = Dr.Item("com_invoice")
            imm = Dr.Item("images")
        Catch ex As Exception

        End Try

        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(SendRepairFrm.txtSRfixPrice.Text))
        Catch ex As Exception
            thaitext = ""
        End Try
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        ''Me.ReportViewer1.RefreshReport()
        ''Dim datasource As ReportDataSource = New ReportDataSource("Snum", dt)

        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        Dim cominvoice As New ReportParameter("com_invoice", ci)
        Dim cusid As New ReportParameter("cus_id", SendRepairFrm.cusID)
        Dim cusname As New ReportParameter("cus_name", SendRepairFrm.cusName)
        Dim ttall As New ReportParameter("totalall", SendRepairFrm.txtSRfixPrice.Text)
        Dim tx As New ReportParameter("thai_text", thaitext)
        Dim fid As New ReportParameter("fix_id", SendRepairFrm.txtHideform.Text)
        Dim iii As New ReportParameter("imageppp", imm)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, cominvoice, cusid, cusname, ttall, tx, fid _
                                                                     , iii})

        Dr.Close()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class