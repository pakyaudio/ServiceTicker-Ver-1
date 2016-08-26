Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class InvoiceSaleReportFrm
    'Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    CashSaleFrm.Close()
    '    SaleFrm.Close()
    '    SaleFrm.MdiParent = Mainfrm
    '    SaleFrm.Show()
    'End Sub
    
    Private Sub InvoiceSaleReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SSTD1DataSet.sale_barcode' table. You can move, or remove it, as needed.
        Me.sale_barcodeTableAdapter.Fill(Me.SSTD1DataSet.sale_barcode)
        Me.Icon = Mainfrm.Icon
        'Me.invoiceReport.Size = New System.Drawing.Size(871, 743)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        'โชว์ print layout
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.PrinterSettings.Copies = 1
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
            thaitext = mne.NumberToThaiWord(CDbl(SaleFrm.lblPWgetTotalPrice.Text))
        Catch ex As Exception
            thaitext = ""
        End Try
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        ''Me.ReportViewer1.RefreshReport()
        ''Dim datasource As ReportDataSource = New ReportDataSource("Snum", dt)

        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        Dim comline As New ReportParameter("com_email", cl)
        Dim cominvoice As New ReportParameter("com_invoice", ci)
        Dim cusid As New ReportParameter("cus_id", SaleFrm.txtScusID.Text)
        Dim cusname As New ReportParameter("cus_name", SaleFrm.txtScusName.Text)
        Dim ttall As New ReportParameter("totalall", SaleFrm.lblPWgetTotalPrice.Text)
        Dim s_id As New ReportParameter("sale_id", SaleFrm.txtPWsaleID.Text)
        Dim tx As New ReportParameter("thaitext", thaitext)
        Dim iii As New ReportParameter("imagepath", imm)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, comline, cominvoice, cusid, cusname, ttall, s_id, tx, iii})
        Me.ReportViewer1.RefreshReport()
        Dr.Close()

    End Sub

End Class