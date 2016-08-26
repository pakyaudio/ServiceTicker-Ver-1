Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class ReturnProductBarcodePrintFrm

    Private Sub ReturnProductBarcodePrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDBDataSet.returnproductbarcode' table. You can move, or remove it, as needed.
        Me.returnproductbarcodeTableAdapter.Fill(Me.ReportDBDataSet.returnproductbarcode)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
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
        If ReturnProductbarcodeReportFrm.ComboBox1.Text = "เครดิต" Then
            DateTime = "คืนแบบเครดิต ระหว่างวันที่ " & ReturnProductbarcodeReportFrm.DateTimePicker1.Text & " ถึง " & ReturnProductbarcodeReportFrm.DateTimePicker2.Text
        ElseIf ReturnProductbarcodeReportFrm.ComboBox1.Text = "เงินสด" Then
            DateTime = "คืนแบบเงินสด ระหว่างวันที่ " & ReturnProductbarcodeReportFrm.DateTimePicker1.Text & " ถึง " & ReturnProductbarcodeReportFrm.DateTimePicker2.Text
        ElseIf ReturnProductbarcodeReportFrm.ComboBox1.Text = "ทั้งหมด" Then
            DateTime = "คืนทั้งหมด ระหว่างวันที่ " & ReturnProductbarcodeReportFrm.DateTimePicker1.Text & " ถึง " & ReturnProductbarcodeReportFrm.DateTimePicker2.Text
        End If

        Dim cnn As New ReportParameter("com_name", cn)
        Dim u_datetime As New ReportParameter("start_end_date", DateTime)
        Dim u_totalpro As New ReportParameter("total_pro", ReturnProductbarcodeReportFrm.txtRRrows.Text)
        Dim st_money As New ReportParameter("money", ReturnProductbarcodeReportFrm.txtmoney.Text)


        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {cnn, u_datetime, u_totalpro, st_money})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class