﻿Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class ReportRepairPrintFrm

    Private Sub ReportRepairPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDBDataSet.reportrepair' table. You can move, or remove it, as needed.
        Me.reportrepairTableAdapter.Fill(Me.ReportDBDataSet.reportrepair)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.RefreshReport()
    End Sub
   
    Dim cn, sed As String

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
        If ReportRepairFrm.cbbRRcashstatus.Text = "ชำระเงิน(เลือกตามวันที่)" Then
            sed = "ระหว่างวันที่  " & ReportRepairFrm.DateTimePicker1.Text & " ถึง " & ReportRepairFrm.DateTimePicker2.Text
        ElseIf ReportRepairFrm.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(เลือกตามวันที่)" Then
            sed = "ระหว่างวันที่  " & ReportRepairFrm.DateTimePicker1.Text & " ถึง " & ReportRepairFrm.DateTimePicker2.Text
        ElseIf ReportRepairFrm.cbbRRcashstatus.Text = "ชำระเงิน(วันนี้)" Then
            sed = "วันที่ " & Now.ToString("dd MMMM yyyy")
        ElseIf ReportRepairFrm.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(วันนี้)" Then
            sed = "วันที่ " & Now.ToString("dd MMMM yyyy")
        End If

       

        Dim s_e_date As New ReportParameter("start_end_date", sed)
        Dim ttp As New ReportParameter("total_pro", ReportRepairFrm.txtRRrows.Text)
        Dim buy_p As New ReportParameter("buy", ReportRepairFrm.txtRRttp.Text)
        Dim d_count As New ReportParameter("discount", ReportRepairFrm.txtRRttd.Text)
        Dim pt As New ReportParameter("profit", ReportRepairFrm.txtmoney.Text)
        'Dim b As New ReportParameter("buy", ReportUserRepairFrm.txtRURtotalBuy.Text)
        'Dim c As New ReportParameter("cost", ReportUserRepairFrm.txtRURtotalCost.Text)
        'Dim d As New ReportParameter("discount", ReportUserRepairFrm.txtRURdiscount.Text)
        'Dim p As New ReportParameter("profit", ReportUserRepairFrm.txtRURtotalProfit.Text)
        Dim cnn As New ReportParameter("com_name", cn)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {cnn, s_e_date, ttp, buy_p, d_count, pt})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class