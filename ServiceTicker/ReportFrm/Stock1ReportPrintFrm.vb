﻿Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class Stock1ReportPrintFrm

    Private Sub Stock1ReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDBDataSet.stock1' table. You can move, or remove it, as needed.
        Me.stock1TableAdapter.Fill(Me.ReportDBDataSet.stock1)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
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
        Dim c_name As New ReportParameter("com_name", cn)
        Dim c_address As New ReportParameter("com_address", ca)
        Dim ttp As New ReportParameter("total_pro", Stock1Frm.txtScountProduct.Text)
        Dim buyy As New ReportParameter("buy", Stock1Frm.txtScount_num.Text)
        Dim co As New ReportParameter("cost", Stock1Frm.txtScost.Text)
        Dim pf As New ReportParameter("profit", Stock1Frm.txtSprofit.Text)
       
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {c_address, c_name, ttp, buyy, co, pf})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class