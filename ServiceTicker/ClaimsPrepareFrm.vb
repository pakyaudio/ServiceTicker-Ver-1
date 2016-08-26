Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class ClaimsPrepareFrm

    Private Sub ClaimsPrepareFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call TRUNCATEdata()
    End Sub

    Private Sub ClaimsPrepareFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = Mainfrm.Icon
        Me.lblemployee.Text = Mainfrm.userClaimsPrepare
    End Sub
    Dim staX As String
    Private Sub getDataClaim()
        Mainfrm.lblMainStatus.Text = "ดึงข้อมูลสินค้าเคลม"
        Try
            strSQL = "SELECT `status` FROM claims WHERE serial_pro='" & Me.txtCPsearchSN.Text & "' AND `status`='" & "รับเข้าระบบ" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                staX = Dr.GetString("status")
            Else

                MsgBox("ไม่พบข้อมูล " & Me.txtCPsearchSN.Text, MsgBoxStyle.Information, "แจ้งเตือน")
                Me.txtCPsearchSN.Clear()
                Me.txtCPsearchSN.Focus()
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        If staX = "รับเข้าระบบ" Then
            If Me.txtCPsearchSN.Text = "" Then
            Else
                If Me.dgCP.Rows.Count = 0 Then
                    Try
                        strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,`type`,unit,datetime_save FROM claims WHERE serial_pro='" & Me.txtCPsearchSN.Text & "' AND `status`='" & "รับเข้าระบบ" & "'"
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader()
                            Dim r As Integer
                            While (Dr.Read())
                                With Me.dgCP
                                    r = .RowCount
                                    .Rows.Add()
                                    .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                                    .Rows(r).Cells(3).Value = Dr.Item("code_pro")
                                    .Rows(r).Cells(4).Value = Dr.Item("bar_code")
                                    .Rows(r).Cells(5).Value = Dr.Item("serial_pro")
                                    .Rows(r).Cells(6).Value = Dr.Item("name_pro")
                                    .Rows(r).Cells(7).Value = Dr.Item("type")
                                    .Rows(r).Cells(8).Value = Dr.Item("unit")
                                    .Rows(r).Cells(9).Value = Dr.Item("datetime_save")
                                    Me.txtCPlastSN.Text = Me.txtCPsearchSN.Text
                                End With
                            End While
                        End Using
                    Catch ex As Exception

                    End Try
                    Me.txtCPsearchSN.Clear()
                    Me.txtCPsearchSN.Focus()
                Else
                    For g As Integer = 0 To dgCP.Rows.Count - 1
                        If Me.dgCP.Rows(g).Cells(5).Value = Me.txtCPsearchSN.Text Then
                            MsgBox("มีข้อมูล " & Me.txtCPsearchSN.Text & " อยู่ในตารางแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                            Me.txtCPsearchSN.Clear()
                            Me.txtCPsearchSN.Focus()
                            Exit Sub
                        End If
                    Next
                    Try
                        strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,`type`,unit,datetime_save FROM claims WHERE serial_pro='" & Me.txtCPsearchSN.Text & "' AND `status`='" & "รับเข้าระบบ" & "'"
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader()
                            Dim r As Integer
                            While (Dr.Read())
                                With Me.dgCP
                                    r = .RowCount
                                    .Rows.Add()
                                    .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                                    .Rows(r).Cells(3).Value = Dr.Item("code_pro")
                                    .Rows(r).Cells(4).Value = Dr.Item("bar_code")
                                    .Rows(r).Cells(5).Value = Dr.Item("serial_pro")
                                    .Rows(r).Cells(6).Value = Dr.Item("name_pro")
                                    .Rows(r).Cells(7).Value = Dr.Item("type")
                                    .Rows(r).Cells(8).Value = Dr.Item("unit")
                                    .Rows(r).Cells(9).Value = Dr.Item("datetime_save")
                                    Me.txtCPlastSN.Text = Me.txtCPsearchSN.Text
                                End With
                            End While
                        End Using
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ดึงข้อมูลสินค้าเคลมผิดพลาด " & ex.Message
                    End Try
                    Me.txtCPsearchSN.Clear()
                    Me.txtCPsearchSN.Focus()
                End If
            End If
        Else
            MsgBox("สินค้านี้มีสถานะ " & staX & " สินค้าต้องมีสถานะ รับเข้าระบบ เท่านั้น จึงจะสามารถทำเตรียมส่งเคลมได้", MsgBoxStyle.Critical, "แจ้งเตือน")
            Me.txtCPsearchSN.Clear()
            Me.txtCPsearchSN.Focus()
        End If
        For ggg As Integer = 0 To dgCP.Rows.Count - 1
            Me.dgCP.Rows(ggg).Cells(0).Value = ggg + 1
            Me.txtCPtotal.Text = ggg + 1
        Next
        Mainfrm.lblMainStatus.Text = "ดึงข้อมูลสินค้าเคลมเสร็จ"
    End Sub
    Private Sub InsertData()
        Try
            Mainfrm.lblMainStatus.Text = "เริ่มเปลี่ยนแปลงข้อมูลเคลม"
            For gg As Integer = 0 To dgCP.Rows.Count - 1

                Dim n As String = Me.dgCP.Rows(gg).Cells(1).Value

                'ส่งไป claims_send
                strSQL = "INSERT INTO claims_send(claims_id,claims_company,claims_company_id,claims_note,claims_send_status,datetime_edit,datetime_save,employee)" _
                    & "VALUES(@claims_id,@claims_company,@claims_company_id,@claims_note,@claims_send_status,@datetime_edit,@datetime_save,@employee)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@claims_id", Me.dgCP.Rows(gg).Cells(1).Value)
                    .Parameters.AddWithValue("@claims_company", Me.txtCPclaimCompanyName.Text)
                    .Parameters.AddWithValue("@claims_company_id", Me.txtCPclamCompanyID.Text)
                    .Parameters.AddWithValue("@claims_note", "-")
                    .Parameters.AddWithValue("@claims_send_status", "เตรียมส่งเคลม")
                    .Parameters.AddWithValue("@datetime_edit", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                    .Parameters.AddWithValue("@datetime_save", Me.dgCP.Rows(gg).Cells(9).Value)
                    .Parameters.AddWithValue("@employee", Me.lblemployee.Text)
                End With
                Call open_connection()
                cmd.ExecuteNonQuery()

                'update claims status
                strSQL = "UPDATE claims SET status='" & "เตรียมส่งเคลม" & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & Me.lblemployee.Text & "' WHERE claims_id='" & n & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()

                strSQL = "INSERT INTO claims_send_report(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyal,price_members,`type`,unit,datetime_sale,datetime_return,datetime_edit,claims_money,employee_claims_return,tel_to_cus,employee_sale,symptom,accressory,note,note2,`status`,employee,datetime_save,claims_id_pic)" _
                   & "(SELECT * FROM claims WHERE claims_id='" & n & "')"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                n = Nothing
            Next
            ClaimsSendReportPrintFrm.Ctxt = 100
            ClaimsSendReportPrintFrm.MdiParent = Mainfrm
            ClaimsSendReportPrintFrm.Show()
            MsgBox("บันทึกเตรียมส่งเคลมแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Me.dgCP.Rows.Clear()
        Me.txtCPtotal.Clear()
        Me.txtCPlastSN.Clear()
        Mainfrm.lblMainStatus.Text = "เปลี่ยนแปลงข้อมูลเคลมเสร็จ"
    End Sub
    Private Sub TRUNCATEdata()
        Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมชั่วคราว"
        strSQL = "TRUNCATE `claims_send_report`;"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        cmd.ExecuteNonQuery()
        Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมชั่วคราวเสร็จ"
    End Sub
    Private Sub txtCPsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCPsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDataClaim()
        End If
    End Sub

    Private Sub btnCPsave_Click(sender As Object, e As EventArgs) Handles btnCPsave.Click
        If Me.dgCP.Rows.Count = 0 Then
            MsgBox("ยังไม่มีข้อมูลเคลมในตาราง", MsgBoxStyle.Exclamation, "No Data")
        Else
            If MessageBox.Show("โปรดแน่ใจว่าข้อมูลถูกต้องก่อนการบันทึก คุณต้องการจะบันทึกข้อมูลหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Call InsertData()
            Else
            End If
        End If
    End Sub
End Class