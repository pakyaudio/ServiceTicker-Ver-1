Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Public Class ReceiptSalePrintReportFrm
    'Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    CashSaleFrm.Close()
    '    SaleFrm.Close()
    '    SaleFrm.MdiParent = Mainfrm
    '    SaleFrm.Show()
    'End Sub
   
    Private Sub ReceiptSalePrintReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReceiptSaleDataSet.cash_sale_barcode' table. You can move, or remove it, as needed.
        Me.cash_sale_barcodeTableAdapter.Fill(Me.ReceiptSaleDataSet.cash_sale_barcode)
        Me.Icon = Mainfrm.Icon
        'TODO: This line of code loads data into the 'SSTD1DataSet.sale_barcode' table. You can move, or remove it, as needed.
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.PrinterSettings.Copies = 1
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, ca, ct, ctax, imag As String
    Dim tlall As Integer
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            'ข้อมูลเกี่ยวกับบริษัท
            strSQL = "SELECT com_name,com_address,com_tel,com_tax,images FROM company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()

            cn = Dr.Item("com_name")
            ca = Dr.Item("com_address")
            ct = Dr.Item("com_tel")
            ctax = Dr.Item("com_tax")
            imag = Dr.Item("images")
        Catch ex As Exception

        End Try

        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDec(CashSaleFrm.txtCashCash.Text))
        Catch ex As Exception
            thaitext = ""
        End Try

        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        Dim comtax As New ReportParameter("com_tax", ctax)
        Dim ims As New ReportParameter("imagepath", imag)
        Dim ttall As New ReportParameter("total_price", SaleFrm.lblPWgetTotalPrice.Text)
        Dim ttext As New ReportParameter("thai_text", thaitext)
        Dim saleid As New ReportParameter("sale_id", SaleFrm.txtPWsaleID.Text)
        Dim cashid As New ReportParameter("cash_id", CashSaleFrm.txtCScashID.Text)
        Dim cuid As New ReportParameter("cus_id", SaleFrm.txtScusID.Text)
        Dim cuname As New ReportParameter("cus_name", SaleFrm.txtScusName.Text)
        Dim cby As New ReportParameter("cash_by", CashSaleFrm.cashDetail)
        Dim tdt As New ReportParameter("total_tdt", CashSaleFrm.discountDT)
        Dim ttaa As New ReportParameter("ta", CashSaleFrm.txtCashCash.Text)


        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'Dim ttall As New ReportParameter("total_all", SendRepairFrm.txtSRfixPrice.Text)
        'Dim tx As New ReportParameter("thai_text", thaitext)

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, comtax, ims, ttall, ttext, saleid, cashid, cuid, cuname, cby, tdt, ttaa})
        Me.ReportViewer1.RefreshReport()
        'CashSaleFrm.cashDetail = Nothing
        'CashSaleFrm.discountDT = Nothing
    End Sub
End Class