Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class MiniLoginClearCheckstockBCFrm

    Private Sub MiniLoginUserFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Timer1.Enabled = False
        Me.txtMLUusername.Clear()
        Me.txtMLUpassword.Clear()
    End Sub
    Dim ifc As String
    Dim Lev As String
    Friend Sub ckUser()
        Try
            Mainfrm.lblMainStatus.Text = "SELECT user_leval"
            strSQL = "SELECT user_leval FROM users WHERE user_usernamelogin='" & Me.txtMLUusername.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Lev = Dr.Item("user_leval")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub saveLogs()
        Try
            Dim uid, uname As String
            strSQL = "SELECT user_id,user_name FROM users WHERE user_usernamelogin='" & Me.txtMLUusername.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            With Dr
                .Read()
                uid = .GetString("user_id")
                uname = .GetString("user_name")
            End With

            strSQL = "INSERT INTO applogs(user_id,user_name,user_usernamelogin,note,date_in)VALUES('" & uid & "','" & uname & "','" & Me.txtMLUusername.Text & "','" & "เข้าเคลียร์ข้อมูลเช็คสต็อกบาร์โค๊ต" & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "')"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            uid = Nothing
            uname = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ok()
        Try
            Mainfrm.lblMainStatus.Text = "SELECT user_usernamelogin,user_password"
            strSQL = "SELECT user_usernamelogin,user_password FROM users WHERE user_usernamelogin='" & Me.txtMLUusername.Text & "' AND user_password = '" & Me.txtMLUpassword.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Dim sqlRead As MySqlDataReader = cmd.ExecuteReader()
            If sqlRead.Read Then
                Call ckUser()
                If Lev = "1" Then
                    MsgBox("คุณไม่มีสิทธิ์ใช้งานในส่วนนี้ต้องเป็นระดับหัวหน้าหรือผู้ดูแลระบบเท่านั้น", MsgBoxStyle.Information, "แจ้งเตือน")
                    Me.txtMLUusername.Clear()
                    Me.txtMLUpassword.Clear()
                    Me.txtMLUusername.Focus()
                    Exit Sub
                ElseIf Lev = "2" Or "3" Then
                    If MessageBox.Show("แน่ใจว่าต้องการเคลียร์ข้อมูลการตรวจสอบสต็อก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        Call CheckStoclBarcodeFrm.clearStock()
                        Call saveLogs()
                        Me.txtMLUusername.Clear()
                        Me.txtMLUpassword.Clear()
                        Me.txtMLUusername.Focus()
                        Me.Close()
                    Else
                        Me.txtMLUusername.Clear()
                        Me.txtMLUpassword.Clear()
                        Me.txtMLUusername.Focus()
                        CheckStockFrm.Button1.Enabled = True
                        Mainfrm.lblMainStatus.Text = "ยกเลิกการเคลียร์ข้อมูลการตรวจสอบสต็อก"
                        Exit Sub
                    End If
                End If
            Else
                ifc = "100"
                Timer1.Start()
                Timer2.Start()
                Me.txtMLUpassword.Clear()
                Me.txtMLUpassword.Focus()
            End If
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label1.ForeColor = Color.Red
        If ifc = "100" Then
            Me.Label1.Text = "ชื่อหรือรหัสผ่านไม่ถูกต้อง"
        ElseIf ifc = "200" Then
            Me.Label1.Text = "กรุณาใส่ชื่อผู้ใช้งาน"
        ElseIf ifc = "300" Then
            Me.Label1.Text = "กรุณาใส่รหัสผ่าน"
        End If
        If Me.Label1.Visible = True Then
            Me.Label1.Visible = False
        Else
            Me.Label1.Visible = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Label1.ForeColor = Color.Black
        Me.Label1.Text = "ยืนยันตัวตนก่อนเข้าใช้งานบางส่วนของโปรแกรม"
        ifc = Nothing
        Me.Timer1.Stop()
        Me.Timer2.Stop()
    End Sub


    Private Sub txtMLUusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMLUusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtMLUpassword.Focus()
        End If
    End Sub

    Private Sub btnMLUok_Click(sender As Object, e As EventArgs) Handles btnMLUok.Click
        If Me.txtMLUusername.Text = "" Then
            ifc = "200"
            Me.Timer1.Start()
            Me.Timer2.Start()
        ElseIf Me.txtMLUpassword.Text = "" Then
            ifc = "300"
            Me.Timer1.Start()
            Me.Timer2.Start()
        Else
            Call ok()
        End If
    End Sub

    Private Sub txtMLUpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMLUpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtMLUusername.Text = "" Then
                ifc = "200"
                Me.Timer1.Start()
                Me.Timer2.Start()
            ElseIf Me.txtMLUpassword.Text = "" Then
                ifc = "300"
                Me.Timer1.Start()
                Me.Timer2.Start()
            Else
                Call ok()
            End If
        End If
    End Sub

    Private Sub btnshowpass_MouseDown(sender As Object, e As MouseEventArgs) Handles btnshowpass.MouseDown
        If Me.txtMLUpassword.UseSystemPasswordChar = True Then
            Me.txtMLUpassword.UseSystemPasswordChar = False
        ElseIf Me.txtMLUpassword.UseSystemPasswordChar = False Then
            Me.txtMLUpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnshowpass_MouseUp(sender As Object, e As MouseEventArgs) Handles btnshowpass.MouseUp
        If Me.txtMLUpassword.UseSystemPasswordChar = True Then
            Me.txtMLUpassword.UseSystemPasswordChar = False
        ElseIf Me.txtMLUpassword.UseSystemPasswordChar = False Then
            Me.txtMLUpassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class