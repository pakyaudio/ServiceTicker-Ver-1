Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing

Public Class DebtorBillingPrintFrm
   
    Private Sub DebtorBillingPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        'TODO: This line of code loads data into the 'CreditDataSet.pledge_sale' table. You can move, or remove it, as needed.
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        'Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.PrinterSettings.Copies = 2
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, ca, ct, ctax, imag, cusid, cusname, em As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            'ข้อมูลเกี่ยวกับบริษัท
            strSQL = "SELECT com_name,com_address,com_tel,com_tax,com_email,images FROM company"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()

            cn = Dr.Item("com_name")
            ca = Dr.Item("com_address")
            ct = Dr.Item("com_tel")
            ctax = Dr.Item("com_tax")
            imag = Dr.Item("images")
            em = Dr.Item("com_email")
        Catch ex As Exception

        End Try
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(DebtorFrm.txtDTpaymentsPrice.Text))
        Catch ex As Exception
            thaitext = ""
        End Try
        Dim bname As New ReportParameter("header", DebtorFrm.cANDp.ToString)
        Dim namebb As New ReportParameter("nameb", DebtorFrm.cANDp1.ToString)
        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        Dim ims As New ReportParameter("imagepath", imag)
        Dim pid As New ReportParameter("pledge_id", DebtorFrm.txtDTautonumDT.Text)
        Dim cid As New ReportParameter("cus_id", DebtorFrm.txtDTcustomer_id.Text)
        Dim cname As New ReportParameter("cus_name", DebtorFrm.txtDTcustomer_name.Text)
        Dim cmail As New ReportParameter("com_email", em)
        Dim pdt As New ReportParameter("pledge_detail", DebtorFrm.cbbDTpayments.Text & "/" & DebtorFrm.txtDTpayments.Text & "/" & DebtorFrm.DateTimePicker3.Text)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        Dim ttall As New ReportParameter("pledge_total", DebtorFrm.txtDTpaymentsPrice.Text)
        Dim tx As New ReportParameter("thai_text", thaitext)
        Dr.Close()
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, ims, pid, cid, cname, pdt, _
                                                                          ttall, tx, cmail, bname, namebb})
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class