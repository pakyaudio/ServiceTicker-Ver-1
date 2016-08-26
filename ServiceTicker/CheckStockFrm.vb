Imports MySql.Data.MySqlClient
Imports System.Globalization


Public Class CheckStockFrm

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.txtCSdontCheck.Text = "" Then

        Else
            Try
                strSQL = "UPDATE check_stock_id SET dontcheck='" & Me.txtCSdontCheck.Text & "',checked='" & Me.txtCScheck.Text & "'," & _
                    "datetime_last='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "'" & _
                    " ORDER BY id DESC LIMIT 1"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        End If
        Mainfrm.lblMainStatus.Text = "ปิดหน้าต่างตรวจสอบสต็อกแล้ว"
    End Sub

    Private Sub AutoNumberNo()
        Try
            Mainfrm.lblMainStatus.Text = "SELECT Max(id) as ID"
            strSQL = "SELECT Max(id) as ID FROM check_stock_id"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtCSid.Text = Now.ToString("yyMMddHHmm") & "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("ID"))
                newID += 1
                Me.txtCSid.Text = "CK" & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "SELECT Max(id) as ID ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub CheckStockFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call AutoNumberNo()
        Mainfrm.lblMainStatus.Text = "หน้าต่างตรวจสอบสต็อกถูกเปิด"
        Try
            Mainfrm.lblMainStatus.Text = "SELECT c_stock_id "
            strSQL = "SELECT c_stock_id FROM check_stock LIMIT 10"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Mainfrm.lblMainStatus.Text = "พบข้อมูลการตรวจสอบสต็อก"
                If MessageBox.Show("พบข้อมูลตรวจสอบสต็อกที่ยังตรวจสอบไม่เสร็จ จะทำการตรวจสอบสต็อกต่อหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Call getCheckStock()
                End If
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "SELECT c_stock_id ผิดพลาด " & ex.Message
        End Try
        Dim i As Integer = Me.dgCSDontCheck.Rows.Count
        If i = 0 Then
            Me.Button1.Enabled = False
        Else
            Me.Button1.Enabled = True
        End If
    End Sub
    Private Sub getCheckStock()
        Me.dgCScheck.Rows.Clear()
        Me.dgCSDontCheck.Rows.Clear()
        Try
            strSQL = "SELECT code_pro,serial_pro,name_pro FROM check_stock"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Mainfrm.lblMainStatus.Text = "ดึงข้อมูลที่ยังไม่ถูกตรวจสอบสต็อก"
            While Dr.Read()
                Dim r As Integer
                With Me.dgCSDontCheck
                    Application.DoEvents()
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("serial_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("name_pro")
                    Me.txtCSdontCheck.Text = r + 1
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "SELECT serial_pro,name_pro FROM check_stock_cache"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgCScheck
                    Application.DoEvents()
                    Mainfrm.lblMainStatus.Text = "ดึงข้อมูลที่ถูกตรวจสอบสต็อกแล้ว"
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("serial_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("name_pro")
                    Me.txtCScheck.Text = r + 1
                End With
            End While
            Mainfrm.lblMainStatus.Text = "พร้อมใช้งาน"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Dim ccs As Integer
    Private Sub BGWgetData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWgetData.DoWork
        If MessageBox.Show("การเตรียมข้อมูลอาจจะใช้เวลานานขึ้นอยู่กับปริมาณสินค้า" & vbNewLine & "ต้องการจะทำการเตรียมข้อมูลหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Try
                strSQL = "SELECT c_stock_id FROM check_stock LIMIT 10"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    If MessageBox.Show("- พบข้อมูลตรวจสอบสต็อกที่ยังตรวจสอบไม่เสร็จ จะทำการตรวจสอบสต็อกต่อหรือไม่" & vbNewLine & "- กรุณาทำการตรวจสอบสต็อกให้เสร็จหรือยกเลิกการตรวจสอบสต็อกก่อนจึงจะทำการเตรียมข้อมูลได้", "แจ้งเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
                        Call getCheckStock()
                    Else
                        Exit Sub
                    End If
                Else
                    Try
                        Mainfrm.lblMainStatus.Text = "กำลังเตรียมข้อมูลตรวจสอบสต็อก"
                        Me.btnCSgetdata.Enabled = False
                        strSQL = "INSERT INTO check_stock(code_pro,serial_pro,name_pro)" _
                               & "SELECT code_pro,serial_pro,name_pro FROM product_serial"
                        Mainfrm.lblMainStatus.Text = strSQL
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Mainfrm.lblMainStatus.Text = "นำเข้าเตรียมข้อมูลตรวจสอบสต็อก"
                            Application.DoEvents()
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try

                    Try
                        strSQL = "UPDATE check_stock SET c_stock_id='" & Me.txtCSid.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Mainfrm.lblMainStatus.Text = "อัพเดทข้อมูลตรวจสอบสต็อก"
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try

                    Try
                        strSQL = "SELECT COUNT(code_pro) FROM check_stock"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Mainfrm.lblMainStatus.Text = "นับจำนวนข้อมูลตรวจสอบสต็อก"
                        Call open_connection()
                        Dr = cmd.ExecuteReader
                        Dr.Read()
                        ccs = Dr(0)
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try

                    Try
                        strSQL = "INSERT INTO check_stock_id(c_stock_id,datetime_save,t_stock)VALUES(@c_stock_id,@datetime_save,@t_stock)"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Mainfrm.lblMainStatus.Text = "ดึงข้อมูลตรวจสอบสต็อกมาแสดง"
                        With cmd
                            .Parameters.Add(New MySqlParameter("@c_stock_id", Me.txtCSid.Text))
                            .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                            .Parameters.Add(New MySqlParameter("@t_stock", ccs.ToString))
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End With
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Call getCheckStock()
                    Me.btnCSgetdata.Enabled = True
                    Call AutoNumberNo()
                End If
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            Me.Button1.Enabled = True
        Else
            Mainfrm.lblMainStatus.Text = "ยกเลิกการเตรียมข้อมูลการตรวจสอบสต็อก"
            Exit Sub
        End If

    End Sub

    Private Sub btnCSgetdata_Click(sender As Object, e As EventArgs) Handles btnCSgetdata.Click
        BGWgetData.RunWorkerAsync()
    End Sub
    Friend LL As Integer
    Friend Sub checkleval()
        Try
            Me.Button1.Enabled = False
            Mainfrm.lblMainStatus.Text = "ยืนยันสิทธิ์การใช้งาน"
            strSQL = "SELECT user_leval FROM users where user_usernamelogin='" & Me.lblemployee.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            LL = Dr.GetString("user_leval")
            If LL = 1 Then
                MsgBox("คุณไม่สามารถใช้งานส่วนนี้ได้ ต้องเป็นระดับหัวหน้าหรือผู้ดูแลระบบเท่านั้น", MsgBoxStyle.Information, "แจ้งเตือน")
                Me.Button1.Enabled = False
                MiniLoginClearCheckstockFrm.MdiParent = Mainfrm
                MiniLoginClearCheckstockFrm.Show()
                Exit Sub
            ElseIf LL = 2 Or 3 Then
                If MessageBox.Show("แน่ใจว่าต้องการเคลียร์ข้อมูลการตรวจสอบสต็อก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    strSQL = "TRUNCATE check_stock"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    Me.dgCSDontCheck.Rows.Clear()
                    strSQL = "TRUNCATE check_stock_cache"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    Me.dgCScheck.Rows.Clear()
                    Mainfrm.lblMainStatus.Text = "เคลียร์ข้อมูลการตรวจสอบสต็อกเรียบร้อยแล้ว"
                    Me.Button1.Enabled = False
                Else
                    Mainfrm.lblMainStatus.Text = "ยกเลิกการเคลียร์ข้อมูลการตรวจสอบสต็อก"
                    Me.Button1.Enabled = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call checkleval()
    End Sub
    Private Sub BGWsnNow_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWsnNow.DoWork
        For i As Integer = 0 To Me.dgCSDontCheck.Rows.Count - 1
            If Me.txtCSSSNnow.Text = Me.dgCSDontCheck.Rows(i).Cells(0).Value Then
                Me.dgCScheck.Rows.Add(Me.dgCSDontCheck.Rows(i).Cells(0).Value, Me.dgCSDontCheck.Rows(i).Cells(1).Value)
                Me.txtCScheck.Text = Me.dgCScheck.RowCount
                Try
                    strSQL = "INSERT INTO check_stock_cache(serial_pro,name_pro)VALUES(@serial_pro,@name_pro)"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgCSDontCheck.Rows(i).Cells(0).Value))
                        .Parameters.Add(New MySqlParameter("@name_pro", Me.dgCSDontCheck.Rows(i).Cells(1).Value))
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try

                Try
                    strSQL = "DELETE FROM check_stock WHERE serial_pro='" & Me.dgCSDontCheck.Rows(i).Cells(0).Value & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.ExecuteNonQuery()
                    Me.txtCSsnLast.Text = Me.dgCSDontCheck.Rows(i).Cells(0).Value
                    Me.dgCSDontCheck.Rows.RemoveAt(Me.dgCSDontCheck.Rows(i).Index)
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try

                Try
                    My.Computer.Audio.Play("./ok.wav", AudioPlayMode.Background)
                    Mainfrm.lblMainStatus.Text = "พบข้อมูล"
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try

                Me.dgCSDontCheck.Refresh()
                Me.txtCSdontCheck.Text = Me.dgCSDontCheck.RowCount
                Me.txtCSSSNnow.Clear()
                Me.txtCSSSNnow.Focus()
                Exit Sub
            End If
        Next
        Try
            My.Computer.Audio.Play("./error.wav", AudioPlayMode.Background)
            Mainfrm.lblMainStatus.Text = "ไม่พบข้อมูล"
        Catch ex As Exception
        End Try
        Me.txtCSSSNnow.Clear()
        Me.txtCSSSNnow.Focus()
    End Sub
    Private Sub txtCSSSNnow_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCSSSNnow.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.dgCSDontCheck.Rows.Count <= 0 Then
                Mainfrm.lblMainStatus.Text = "ไม่มีข้อมูล"
                Me.txtCSSSNnow.Clear()
                Me.txtCSSSNnow.Focus()
            Else
                BGWsnNow.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub btnCSenter_Click(sender As Object, e As EventArgs) Handles btnCSenter.Click
        If Me.dgCSDontCheck.Rows.Count <= 0 Then
            Mainfrm.lblMainStatus.Text = "ไม่มีข้อมูล"
            Me.txtCSSSNnow.Clear()
            Me.txtCSSSNnow.Focus()
        Else
            For i As Integer = 0 To Me.dgCSDontCheck.Rows.Count - 1
                Application.DoEvents()
                If Me.txtCSSSNnow.Text = Me.dgCSDontCheck.Rows(i).Cells(0).Value Then
                    Me.dgCScheck.Rows.Add(Me.dgCSDontCheck.Rows(i).Cells(0).Value, Me.dgCSDontCheck.Rows(i).Cells(1).Value)
                    Me.txtCScheck.Text = Me.dgCScheck.RowCount
                    Mainfrm.lblMainStatus.Text = "INSERT INTO check_stock_cache"
                    strSQL = "INSERT INTO check_stock_cache(serial_pro,name_pro)VALUES(@serial_pro,@name_pro)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgCSDontCheck.Rows(i).Cells(0).Value))
                        .Parameters.Add(New MySqlParameter("@name_pro", Me.dgCSDontCheck.Rows(i).Cells(1).Value))
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End With
                    Mainfrm.lblMainStatus.Text = "DELETE FROM check_stock"
                    strSQL = "DELETE FROM check_stock WHERE serial_pro='" & Me.dgCSDontCheck.Rows(i).Cells(0).Value & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.ExecuteNonQuery()
                    Me.txtCSsnLast.Text = Me.dgCSDontCheck.Rows(i).Cells(0).Value
                    Me.dgCSDontCheck.Rows.RemoveAt(Me.dgCSDontCheck.Rows(i).Index)
                    Try
                        My.Computer.Audio.Play("./ok.wav", AudioPlayMode.Background)
                        Mainfrm.lblMainStatus.Text = "พบข้อมูล"
                    Catch ex As Exception
                    End Try
                    Me.dgCSDontCheck.Refresh()
                    Me.txtCSdontCheck.Text = Me.dgCSDontCheck.RowCount
                    Me.txtCSSSNnow.Clear()
                    Me.txtCSSSNnow.Focus()
                    Exit Sub
                End If
            Next
            Try
                My.Computer.Audio.Play("./error.wav", AudioPlayMode.Background)
                Mainfrm.lblMainStatus.Text = "ไม่ข้อมูล"
            Catch ex As Exception
            End Try
            Me.txtCSSSNnow.Clear()
            Me.txtCSSSNnow.Focus()
        End If
    End Sub

    Private Sub btnCSdontCheckPrint_Click(sender As Object, e As EventArgs) Handles btnCSdontCheckPrint.Click
        Mainfrm.lblMainStatus.Text = "พิมพ์ข้อมูลยังไม่ได้ตรวจสอบสต็อก"
        CheckStockPrintReportFrm.Show()
    End Sub

    Private Sub btnCSCheckPrint_Click(sender As Object, e As EventArgs) Handles btnCSCheckPrint.Click
        Mainfrm.lblMainStatus.Text = "พิมพ์ข้อมูลตรวจสอบสต็อกแล้ว"
        CheckedStockReportFrm.Show()
    End Sub





   
End Class