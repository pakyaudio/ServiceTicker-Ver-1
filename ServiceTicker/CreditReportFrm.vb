Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Public Class CreditReportFrm
    Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CashFrm.Close()
    End Sub
   
    Private Sub CreditReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        'TODO: This line of code loads data into the 'CreditDataSet.pledge_sale' table. You can move, or remove it, as needed.
        Me.pledge_saleTableAdapter.FillCredit(Me.CreditDataSet.pledge_sale)
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
        'ดึงข้อมูลชื่อลูกค้า
        Try
            strSQL = "SELECT customer_id,customer_name FROM sale WHERE fix_id='" & CashFrm.txtCashFixID.Text & "'"
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
            thaitext = mne.NumberToThaiWord(CDbl(CashFrm.txtCashCusPrice.Text))
        Catch ex As Exception
            thaitext = ""
        End Try

        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        Dim ims As New ReportParameter("imagepath", imag)
        Dim pid As New ReportParameter("pledge_id", CashFrm.txtCashpledgeID.Text)
        Dim cid As New ReportParameter("cus_id", cusid)
        Dim cname As New ReportParameter("cus_name", cusname)
        Dim cmail As New ReportParameter("com_email", em)
        Dim pdt As New ReportParameter("pledge_detail", CashFrm.cbbCashSelectPayment.Text & " " & CashFrm.txtCashByselectPayment.Text)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        Dim ttall As New ReportParameter("pledge_total", CashFrm.txtCashCusPrice.Text)
        Dim tx As New ReportParameter("thai_text", thaitext)
        Dr.Close()
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, ims, pid, cid, cname, pdt, _
                                                                          ttall, tx, cmail})
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class