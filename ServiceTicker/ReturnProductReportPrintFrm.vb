Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Public Class ReturnProductReportPrintFrm

    Private Sub ReceiptReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReturnProductDataSet.returnproduct_barcode' table. You can move, or remove it, as needed.
        Me.returnproduct_barcodeTableAdapter.Fill(Me.ReturnProductDataSet.returnproduct_barcode)
        Me.Icon = Mainfrm.Icon
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
        
        

        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        Dim RD_id As New ReportParameter("return_id", ReturnsProductFrm.txtRP_ID.Text)


        'Dim ttall As New ReportParameter("total_all", SendRepairFrm.txtSRfixPrice.Text)
        'Dim tx As New ReportParameter("thai_text", thaitext)
        Dr.Close()
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, RD_id})
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class