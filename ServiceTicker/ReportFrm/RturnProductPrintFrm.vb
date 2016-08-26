Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class RturnProductPrintFrm

    Private Sub RturnProductPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDBDataSet.returnproductall' table. You can move, or remove it, as needed.
        Me.returnproductallTableAdapter.Fill(Me.ReportDBDataSet.returnproductall)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim DateTime, cn As String
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
        If ReturnProdductReportFrm.cbbRRcashstatus.Text = "เครดิต" Then
            DateTime = "คืนแบบเครดิต ระหว่างวันที่ " & ReturnProdductReportFrm.DateTimePicker1.Text & " ถึง " & ReturnProdductReportFrm.DateTimePicker2.Text
        ElseIf ReturnProdductReportFrm.cbbRRcashstatus.Text = "เงินสด" Then
            DateTime = "คืนแบบเงินสด ระหว่างวันที่ " & ReturnProdductReportFrm.DateTimePicker1.Text & " ถึง " & ReturnProdductReportFrm.DateTimePicker2.Text
        ElseIf ReturnProdductReportFrm.cbbRRcashstatus.Text = "ทั้งหมด" Then
            DateTime = "คืนทั้งหมด ระหว่างวันที่ " & ReturnProdductReportFrm.DateTimePicker1.Text & " ถึง " & ReturnProdductReportFrm.DateTimePicker2.Text
        End If

        Dim cnn As New ReportParameter("com_name", cn)
        Dim u_datetime As New ReportParameter("start_end_date", DateTime)
        Dim u_totalpro As New ReportParameter("row", ReturnProdductReportFrm.txtRRrows.Text)
        Dim st_money As New ReportParameter("money", ReturnProdductReportFrm.txtmoney.Text)


        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {cnn, u_datetime, u_totalpro, st_money})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class