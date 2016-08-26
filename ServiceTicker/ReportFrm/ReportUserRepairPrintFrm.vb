﻿Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class ReportUserRepairPrintFrm

    Private Sub ReportUserRepairPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDBDataSet.ReportUserRepair' table. You can move, or remove it, as needed.
        Me.ReportUserRepairTableAdapter.Fill(Me.ReportDBDataSet.ReportUserRepair)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.RefreshReport()
    End Sub
  
    Dim cn As String

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
        Dim u_repair As New ReportParameter("user_repair", ReportUserRepairFrm.cbbRURselectUser.Text)
        Dim s_date As New ReportParameter("start_date", ReportUserRepairFrm.DateTimePicker1.Text)
        Dim e_date As New ReportParameter("end_date", ReportUserRepairFrm.DateTimePicker2.Text)
        Dim ttnf As New ReportParameter("tital_num_fix", ReportUserRepairFrm.txtRURrows.Text)
        Dim b As New ReportParameter("buy", ReportUserRepairFrm.txtRURtotalBuy.Text)
        Dim c As New ReportParameter("cost", ReportUserRepairFrm.txtRURtotalCost.Text)
        Dim d As New ReportParameter("discount", ReportUserRepairFrm.txtRURdiscount.Text)
        Dim p As New ReportParameter("profit", ReportUserRepairFrm.txtRURtotalProfit.Text)
        Dim cnn As New ReportParameter("com_name", cn)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {u_repair, s_date, e_date, ttnf, b, c, d, p, cnn})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class