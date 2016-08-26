Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class ReportBarcodeSalePrintFrm

    Private Sub ReportBarcodeSalePrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDBDataSet.reportbarcodesale' table. You can move, or remove it, as needed.
        Me.reportbarcodesaleTableAdapter.Fill(Me.ReportDBDataSet.reportbarcodesale)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, datetime As String

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            strSQL = "SELECT com_name,images FROM company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cn = Dr.Item("com_name")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        If ReportBarcodeFrm.cbbRRcashstatus.Text = "ชำระเงิน(ตามวันที่)" Then
            datetime = "ยอดชำระเงินระหว่างวันที่ " & ReportBarcodeFrm.DateTimePicker1.Text & " ถึง " & ReportBarcodeFrm.DateTimePicker2.Text
        ElseIf ReportBarcodeFrm.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(ตามวันที่)" Then
            datetime = "ยอดยังไม่ได้ชำระเงินระหว่างวันที่ " & ReportBarcodeFrm.DateTimePicker1.Text & " ถึง " & ReportBarcodeFrm.DateTimePicker2.Text
        ElseIf ReportBarcodeFrm.cbbRRcashstatus.Text = "ชำระเงิน(วันนี้)" Then
            datetime = "ยอดชำระเงินวันที่ " & Now.ToString("dd MMMM yyyy")
        ElseIf ReportBarcodeFrm.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(วันนี้)" Then
            datetime = "ยอดยังไม่ได้ชำระเงินระหว่างวันที่ " & Now.ToString("dd MMMM yyyy")
        End If

        Dim cnn As New ReportParameter("com_name", cn)
        Dim u_datetime As New ReportParameter("start_end_date", datetime)
        Dim u_totalpro As New ReportParameter("total_pro", ReportBarcodeFrm.txtRRrows.Text)
        Dim st_money As New ReportParameter("total_money", ReportBarcodeFrm.txtmoney.Text)


        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {cnn, u_datetime, u_totalpro, st_money})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class