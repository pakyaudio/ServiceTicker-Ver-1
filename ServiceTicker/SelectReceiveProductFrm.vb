Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class SelectReceiveProductFrm
  
   
    Private Sub SelectReceiveProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub
    Private Sub startfrm()
        Me.btnSRPcancelBillbuy.Enabled = False
    End Sub
    Private Sub getDtatTocbbSRPbuyCompany()
        Try
            Me.cbbSRPbuyCompany.Items.Clear()
            Mainfrm.lblMainStatus.Text = "SELECT sale_company_name "
            strSQL = "SELECT sale_company_name from sale_company"
            Using cmd = New MySqlCommand
                cmd.CommandText = strSQL
                cmd.Connection = ConnectionDB
                Call open_connection()
                Dr = cmd.ExecuteReader
                While (Dr.Read())
                    Me.cbbSRPbuyCompany.Items.Add(Dr("sale_company_name"))
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getDataTocbbSRPbuyCompany()
        Try
            Me.dgSRP.Rows.Clear()
            strSQL = "SELECT buy_id,`total`,`status`,sale_company_id,sale_company_name,datetime_save,employee FROM buy WHERE sale_company_name='" & Me.cbbSRPbuyCompany.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgSRP
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("buy_id")
                    .Rows(r).Cells(1).Value = Dr.GetString("sale_company_id")
                    .Rows(r).Cells(2).Value = Dr.GetString("sale_company_name")
                    .Rows(r).Cells(3).Value = Dr.GetString("datetime_save")
                    .Rows(r).Cells(4).Value = Dr.GetString("employee")
                    .Rows(r).Cells(5).Value = Dr.GetDecimal("total")
                    .Rows(r).Cells(6).Value = Dr.GetString("status")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getDataTocbbSRPbuyStatus()

        If Me.cbbSRPbuyStatus.Text = "ทั้งหมด" Then
            Try
                Me.dgSRP.Rows.Clear()
                strSQL = "SELECT buy_id,total,status,sale_company_id,sale_company_name,datetime_save,employee FROM buy"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgSRP
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.GetString("buy_id")
                        .Rows(r).Cells(1).Value = Dr.GetString("sale_company_id")
                        .Rows(r).Cells(2).Value = Dr.GetString("sale_company_name")
                        .Rows(r).Cells(3).Value = Dr.GetString("datetime_save")
                        .Rows(r).Cells(4).Value = Dr.GetString("employee")
                        .Rows(r).Cells(5).Value = Dr.GetDecimal("total")
                        .Rows(r).Cells(6).Value = Dr.GetString("status")
                    End With
                End While
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        Else
            Try
                Me.dgSRP.Rows.Clear()
                strSQL = "SELECT buy_id,`total`,`status`,sale_company_id,sale_company_name,datetime_save,employee FROM buy WHERE `status`='" & Me.cbbSRPbuyStatus.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgSRP
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.GetString("buy_id")
                        .Rows(r).Cells(1).Value = Dr.GetString("sale_company_id")
                        .Rows(r).Cells(2).Value = Dr.GetString("sale_company_name")
                        .Rows(r).Cells(3).Value = Dr.GetString("datetime_save")
                        .Rows(r).Cells(4).Value = Dr.GetString("employee")
                        .Rows(r).Cells(5).Value = Dr.GetDecimal("total")
                        .Rows(r).Cells(6).Value = Dr.GetString("status")
                    End With
                End While
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        End If
        
    End Sub
    Private Sub cbbSRPbuyCompany_Click(sender As Object, e As EventArgs) Handles cbbSRPbuyCompany.Click
        Call getDtatTocbbSRPbuyCompany()
    End Sub

    Private Sub cbbSRPbuyCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbSRPbuyCompany.SelectedIndexChanged
        Call getDataTocbbSRPbuyCompany()
    End Sub

    Private Sub cbbSRPbuyStatus_Click(sender As Object, e As EventArgs) Handles cbbSRPbuyStatus.Click
        Me.cbbSRPbuyStatus.Items.Clear()
        Me.cbbSRPbuyStatus.Items.Add("ได้รับสินค้าแล้ว")
        Me.cbbSRPbuyStatus.Items.Add("ยังไม่ได้รับสินค้า")
        Me.cbbSRPbuyStatus.Items.Add("ยกเลิกรายการ")
        Me.cbbSRPbuyStatus.Items.Add("ทั้งหมด")
    End Sub

    Private Sub cbbSRPbuyStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbSRPbuyStatus.SelectedIndexChanged
        Call getDataTocbbSRPbuyStatus()
    End Sub

    Private Sub btnSRPcancelBillbuy_Click(sender As Object, e As EventArgs) Handles btnSRPcancelBillbuy.Click
        Try
            Dim i As Integer = dgSRP.Rows.Count
            If i <= 0 Then
                MsgBox("กรุณาเลือกใบสั่งซื้อที่ต้องการยกเลิก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            Else

                If Me.dgSRP.SelectedCells.Item(6).Value = "ได้รับสินค้าแล้ว" Then
                    MsgBox("สถานะได้รับสินค้าแล้ว ไม่สามารถยกเลิกได้อีก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                ElseIf Me.dgSRP.SelectedCells.Item(6).Value = "ยังไม่ได้รับสินค้า" Then
                    Try
                        strSQL = "UPDATE buy SET status='ยกเลิกรายการ'," _
                        & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "' " _
                        & "WHERE buy_id='" & Me.dgSRP.SelectedCells.Item(0).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                        MsgBox("ยกเลิกใบสั่งซื้อแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Exit Sub
                ElseIf Me.dgSRP.SelectedCells.Item(6).Value = "ยกเลิกรายการ" Then
                    MsgBox("สินค้านี้ถูกยกเลิกไปแล้ว ไม่สามารถยกเลิกได้อีก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                End If

            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnSRPviewPro_Click(sender As Object, e As EventArgs) Handles btnSRPviewPro.Click
        Dim dgspEmpty As Integer = Me.dgSRP.Rows.Count
        If dgspEmpty = 0 Then
            MsgBox("ไม่มีข้อมูล กรุณาเลือกตารางที่ต้องการดูรายการสินค้า", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        Else
            ViewSelectReceiveProductFrm.MdiParent = Mainfrm
            ViewSelectReceiveProductFrm.Show()
            Call ViewSelectReceiveProductFrm.getDataViewSelectReceiveProductFrm()
        End If
    End Sub

    Private Sub btnSRPselect_Click(sender As Object, e As EventArgs) Handles btnSRPselect.Click
        Dim dgspEmpty As Integer = Me.dgSRP.Rows.Count
        If dgspEmpty = 0 Then
            Exit Sub
        Else
            If Me.dgSRP.SelectedCells.Item(6).Value = "ได้รับสินค้าแล้ว" Then
                MsgBox("ใบสั่งซื้อนี้ได้รับสินค้าแล้ว ไม่สามารถนำเข้าสินค้าได้อีก", MsgBoxStyle.Information, "แจ้งเตือน")
            ElseIf Me.dgSRP.SelectedCells.Item(6).Value = "ยกเลิกรายการ" Then
                MsgBox("ใบสั่งซื้อนี้ได้รับการยกเลิก ไม่สามารถนำเข้าสินค้าได้อีก", MsgBoxStyle.Information, "แจ้งเตือน")
            ElseIf Me.dgSRP.SelectedCells.Item(6).Value = "ยังไม่ได้รับสินค้า" Then
                ReceiveProductFrm.txtRPbuy_id.Text = Me.dgSRP.SelectedCells.Item(0).Value
                ReceiveProductFrm.txtRPsale_company_name.Text = Me.dgSRP.SelectedCells.Item(2).Value
                Me.Close()
            End If
        End If
        
    End Sub

    Private Sub btnSRPprint_Click(sender As Object, e As EventArgs)

    End Sub
End Class