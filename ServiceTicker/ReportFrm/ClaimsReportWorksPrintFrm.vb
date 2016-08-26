Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class ClaimsReportWorksPrintFrm

    Private Sub ClaimsReportWorksPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDBDataSet.claimsreport' table. You can move, or remove it, as needed.
        Me.claimsreportTableAdapter.Fill(Me.ReportDBDataSet.claimsreport)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim sed, cn As String
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


        sed = "ระหว่างวันที่  " & ClaimsReportFrm.DateTimePicker1.Text & " ถึง " & ClaimsReportFrm.DateTimePicker2.Text



        Dim s_e_date As New ReportParameter("start_end_date", sed)
        'Dim u_repair As New ReportParameter("user_repair", ReportUserRepairFrm.cbbRURselectUser.Text)
        'Dim s_date As New ReportParameter("start_date", ReportUserRepairFrm.DateTimePicker1.Text)
        'Dim e_date As New ReportParameter("end_date", ReportUserRepairFrm.DateTimePicker2.Text)
        'Dim ttnf As New ReportParameter("tital_num_fix", ReportUserRepairFrm.txtRURrows.Text)
        'Dim b As New ReportParameter("buy", ReportUserRepairFrm.txtRURtotalBuy.Text)
        'Dim c As New ReportParameter("cost", ReportUserRepairFrm.txtRURtotalCost.Text)
        'Dim d As New ReportParameter("discount", ReportUserRepairFrm.txtRURdiscount.Text)
        'Dim p As New ReportParameter("profit", ReportUserRepairFrm.txtRURtotalProfit.Text)
        Dim cnn As New ReportParameter("com_name", cn)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {cnn, s_e_date})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class