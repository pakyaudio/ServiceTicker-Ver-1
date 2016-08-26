Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data.SQLite

Public Class ViewReceiveFrm

    Private Sub ViewReceiveFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub
    Private Sub startfrm()
        Me.btnVRcancelBillbuy.Enabled = False
    End Sub
    Private Sub getDtatTocbbVRbuyCompany()
        Try
            Me.cbbVRbuyCompany.Items.Clear()
            strSQL = "SELECT sale_company_name from sale_company"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand
                cmd.CommandText = strSQL
                cmd.Connection = ConnectionDB
                Call open_connection()
                Dr = cmd.ExecuteReader
                While (Dr.Read())
                    Me.cbbVRbuyCompany.Items.Add(Dr("sale_company_name"))
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getDataTocbbVRbuyCompany()
        Try
            Me.dgVR.Rows.Clear()
            If Me.cbbVRbuyStatus.Text = "ทั้งหมด" Then
                strSQL = "SELECT buy_id,total,status,sale_company_id,sale_company_name,datetime_save,employee FROM buy"
            ElseIf statusC = 100 Then
                strSQL = "SELECT buy_id,`total`,`status`,sale_company_id,sale_company_name,datetime_save,employee " _
               & "FROM buy WHERE sale_company_name='" & Me.cbbVRbuyCompany.Text & "'"
            ElseIf statusC = 200 Then
                strSQL = "SELECT buy_id,`total`,`status`,sale_company_id,sale_company_name,datetime_save,employee " _
              & "FROM buy WHERE status='" & "ยังไม่ได้รับสินค้า" & "'"
            Else
                strSQL = "SELECT buy_id,total,status,sale_company_id,sale_company_name,datetime_save,employee FROM " _
                    & "buy WHERE status='" & Me.cbbVRbuyStatus.Text & "'"
            End If
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgVR
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("buy_id")
                    .Rows(r).Cells(1).Value = Dr.Item("sale_company_id")
                    .Rows(r).Cells(2).Value = Dr.Item("sale_company_name")
                    .Rows(r).Cells(3).Value = Dr.Item("datetime_save")
                    .Rows(r).Cells(4).Value = Dr.Item("employee")
                    .Rows(r).Cells(5).Value = Dr.GetDecimal("total")
                    .Rows(r).Cells(6).Value = Dr.Item("status")
                End With
            End While
            statusC = Nothing
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub cbbSRPbuyCompany_Click(sender As Object, e As EventArgs) Handles cbbVRbuyCompany.Click
        Call getDtatTocbbVRbuyCompany()
    End Sub

    Private Sub cbbSRPbuyCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbVRbuyCompany.SelectedIndexChanged
        statusC = 100
        Call getDataTocbbVRbuyCompany()
    End Sub

    Private Sub cbbVRbuyStatus_Click(sender As Object, e As EventArgs) Handles cbbVRbuyStatus.Click
        Me.cbbVRbuyStatus.Items.Clear()
        Me.cbbVRbuyStatus.Items.Add("ได้รับสินค้าแล้ว")
        Me.cbbVRbuyStatus.Items.Add("ยังไม่ได้รับสินค้า")
        Me.cbbVRbuyStatus.Items.Add("ยกเลิกรายการ")
        Me.cbbVRbuyStatus.Items.Add("ทั้งหมด")
    End Sub
    Dim statusC As Integer
    Private Sub cbbSRPbuyStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbVRbuyStatus.SelectedIndexChanged
        Call getDataTocbbVRbuyCompany()
    End Sub

    Private Sub btnVRcancelBillbuy_Click(sender As Object, e As EventArgs) Handles btnVRcancelBillbuy.Click
        Try
            Dim i As Integer = dgVR.Rows.Count
            If i <= 0 Then
                MsgBox("กรุณาเลือกใบสั่งซื้อที่ต้องการยกเลิก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            Else
                If Me.dgVR.SelectedCells.Item(6).Value = "ได้รับสินค้าแล้ว" Then
                    MsgBox("สถานะได้รับสินค้าแล้ว ไม่สามารถยกเลิกได้อีก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                ElseIf Me.dgVR.SelectedCells.Item(6).Value = "ยังไม่ได้รับสินค้า" Then
                    Try
                        If MessageBox.Show("คุณแน่ใจว่าจะยกเลิกใบสั่งซื้อนี้", "ยืนยัน", MessageBoxButtons.YesNo, _
                                           MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            strSQL = "UPDATE buy SET `status`='ยกเลิกรายการ'," _
                             & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "' " _
                             & "WHERE buy_id='" & Me.dgVR.SelectedCells.Item(0).Value & "'"
                            Mainfrm.lblMainStatus.Text = strSQL
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                            MsgBox("ยกเลิกใบสั่งซื้อแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                            statusC = 200
                            Call getDataTocbbVRbuyCompany()
                        Else
                            Exit Sub
                        End If
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Exit Sub
                ElseIf Me.dgVR.SelectedCells.Item(6).Value = "ยกเลิกรายการ" Then
                    MsgBox("สินค้านี้ถูกยกเลิกไปแล้ว ไม่สามารถยกเลิกได้อีก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                End If

            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub btnVRviewPro_Click(sender As Object, e As EventArgs) Handles btnVRPviewPro.Click
        Dim dgspEmpty As Integer = Me.dgVR.Rows.Count
        If dgspEmpty = 0 Then
            MsgBox("ไม่มีข้อมูล กรุณาเลือกตารางที่ต้องการดูรายการสินค้า", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        Else
            ViewSelectReceiveProductFrm.MdiParent = Mainfrm
            ViewSelectReceiveProductFrm.Show()
            Call ViewSelectReceiveProductFrm.getDataViewReceiveFrm()
        End If
    End Sub
    Private Sub reportPrint()
        If Me.dgVR.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลให้พิมพ์", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        Else
            'แอดทำรีพอร์ต
            Me.Cursor = Cursors.WaitCursor
            Mainfrm.lblMainStatus.Text = "ล้างข้อมูลรายงานเก่า"
            Try
                strSQLite = "DELETE FROM buy_pro_rewordall"
                Mainfrm.lblMainStatus.Text = strSQLite
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            'loop save to database
            For rREPORT As Integer = 0 To Me.dgVR.RowCount - 1
                Try
                    strSQLite = "insert into buy_pro_rewordall(buy_id,salecom_id,salecom_name,datetime,employee,price,`status`) " _
                    & "values(@buy_id,@salecom_id,@salecom_name,@datetime,@employee,@price,@status)"
                    Mainfrm.lblMainStatus.Text = strSQLite
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    With cmdSQLite
                        .Parameters.Add(New SQLiteParameter("@buy_id", Me.dgVR.Rows(rREPORT).Cells(0).Value))
                        .Parameters.Add(New SQLiteParameter("@salecom_id", Me.dgVR.Rows(rREPORT).Cells(1).Value))
                        .Parameters.Add(New SQLiteParameter("@salecom_name", Me.dgVR.Rows(rREPORT).Cells(2).Value))
                        .Parameters.Add(New SQLiteParameter("@datetime", Me.dgVR.Rows(rREPORT).Cells(3).Value))
                        .Parameters.Add(New SQLiteParameter("@employee", Me.dgVR.Rows(rREPORT).Cells(4).Value))
                        .Parameters.Add(New SQLiteParameter("@price", Me.dgVR.Rows(rREPORT).Cells(5).Value))
                        .Parameters.Add(New SQLiteParameter("@status", Me.dgVR.Rows(rREPORT).Cells(6).Value))
                        Call open_connectionSQLite()
                        .ExecuteNonQuery()
                    End With
                    Me.Cursor = Cursors.Default
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    Return
                End Try
            Next
            ReBuyAllReportPrintFrm.Show()

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call reportPrint()
    End Sub
End Class