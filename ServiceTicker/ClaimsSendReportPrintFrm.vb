Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Public Class ClaimsSendReportPrintFrm
    Friend Ctxt As Integer
    Dim CHtxt As String
    Dim CUtxt As String
    Dim CLtxt As String
    Private Sub ClaimsSendReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClaimsSendReportDataSet.claims_send_report' table. You can move, or remove it, as needed.
        Me.claims_send_reportTableAdapter.Fill(Me.ClaimsSendReportDataSet.claims_send_report)

        Me.ReportViewer1.RefreshReport()
        Me.Icon = Mainfrm.Icon
      
    End Sub
  
    Dim cn, ca As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        If Ctxt = 100 Then
            Me.Text = "พิมพ์ใบเตรียมส่งเคลม A4"
            CHtxt = "ใบเตรียมส่งเคลม"
            CUtxt = ClaimsPrepareFrm.lblemployee.Text
        ElseIf Ctxt = 200 Then
            Me.Text = "พิมพ์ใบส่งเคลม A4"
            CHtxt = "ใบส่งเคลม"
            CLtxt = "หมายเลขส่งเคลม " & ClaimsSendGroupFrm.txtCSGlotNum.Text
            CUtxt = ClaimsSendGroupFrm.lblemployee.Text
        ElseIf Ctxt = 300 Then
            Me.Text = "พิมพ์ใบรับสินค้าเคลมเข้า A4"
            CHtxt = "ใบรับสินค้าเคลมเข้า"
            CLtxt = ""
            CUtxt = ClaimsreceiveGroupFrm.lblemployee.Text
        ElseIf Ctxt = 400 Then
            Me.Text = "พิมพ์ใบทดสอบสินค้า A4"
            CHtxt = "ใบทดสอบสินค้า"
            CLtxt = ""
            CUtxt = ClaimsTestResultsFrm.lblemployee.Text
        End If
        Try
            strSQL = "SELECT com_name,com_address FROM company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cn = Dr.Item("com_name")
            ca = Dr.Item("com_address")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim employee As New ReportParameter("login_name", CUtxt)
        Dim textheader As New ReportParameter("header_text", CHtxt)
        Dim CLtext As New ReportParameter("claims_lot", CLtxt)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, employee, textheader, CLtext})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class