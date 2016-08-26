Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class Buy_ProReportPrintFrm

    Private Sub Buy_ProReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDBDataSet.buy_pro' table. You can move, or remove it, as needed.
        Me.buy_proTableAdapter.Fill(Me.ReportDBDataSet.buy_pro)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, ca As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            strSQL = "SELECT com_name,com_address FROM company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cn = Dr.Item("com_name")
            ca = Dr.GetString("com_address")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(OrdreFrm.txtORsumMoney.Text))
        Catch ex As Exception
            thaitext = ""
        End Try

        Dim c_name As New ReportParameter("com_name", cn)
        Dim c_address As New ReportParameter("com_address", ca)
        Dim buyid As New ReportParameter("buy_id", OrdreFrm.lblORid.Text)
        Dim em As New ReportParameter("employee", OrdreFrm.lblEmployee.Text)
        Dim ttext As New ReportParameter("thaitext", thaitext)
        Dim toal As New ReportParameter("total_buy", OrdreFrm.txtORsumMoney.Text)
        Dim cbuy As New ReportParameter("company_buy", OrdreFrm.cbbORcompanySelect.Text)
        'Dim c As New ReportParameter("cost", ReportUserRepairFrm.txtRURtotalCost.Text)
        'Dim d As New ReportParameter("discount", ReportUserRepairFrm.txtRURdiscount.Text)
        'Dim p As New ReportParameter("profit", ReportUserRepairFrm.txtRURtotalProfit.Text)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {c_address, c_name, buyid, ttext, toal, cbuy, em})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class