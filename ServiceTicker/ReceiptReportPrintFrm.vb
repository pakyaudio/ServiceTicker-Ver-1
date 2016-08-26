Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Public Class ReceiptReportPrintFrm
  

    Private Sub ReceiptReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        'TODO: This line of code loads data into the 'ReceiptDataSet.sale_barcode' table. You can move, or remove it, as needed.
        Me.sale_barcodeTableAdapter.Fillreceipt(Me.ReceiptDataSet.sale_barcode)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        'Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.PrinterSettings.Copies = 2
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, ca, ct, ctax, imag, cusid, cusname As String
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
        'รวมราคาใบขาย
        Try
            strSQL = "SELECT SUM(total_all) FROM sale WHERE fix_id='" & CashFrm.txtCashFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            tlall = Dr(0)
        Catch ex As Exception

        End Try
        'ดึงชื่อลูกค้า
        Try
            strSQL = "SELECT customer_id,customer_name FROM sale WHERE fix_id='" & CashFrm.txtCashFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cusid = Dr.Item("customer_id")
            cusname = Dr.Item("customer_name")
        Catch ex As Exception

        End Try

        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(CashFrm.txtCashCash.Text))
        Catch ex As Exception
            thaitext = ""
        End Try

        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        Dim comtax As New ReportParameter("com_tax", ctax)
        Dim ims As New ReportParameter("imagepath", imag)
        Dim ttall As New ReportParameter("total_price", tlall.ToString)
        Dim ttext As New ReportParameter("thai_text", thaitext)
        Dim cashid As New ReportParameter("cash_id", CashFrm.cashID)
        Dim cuid As New ReportParameter("cus_id", cusid)
        Dim cuname As New ReportParameter("cus_name", cusname)
        Dim cby As New ReportParameter("cash_by", CashFrm.cashDetail)
        Dim tdt As New ReportParameter("total_tdt", CashFrm.discountDT)
        Dim ttaa As New ReportParameter("ta", CashFrm.txtCashCash.Text)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'Dim ttall As New ReportParameter("total_all", SendRepairFrm.txtSRfixPrice.Text)
        'Dim tx As New ReportParameter("thai_text", thaitext)
        Dr.Close()
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, comtax, ims, ttall, ttext, _
                                                                          cashid, cuid, cuname, cby, tdt, ttaa})
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class