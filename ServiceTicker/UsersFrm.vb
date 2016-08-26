Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class UsersFrm
 
    'เสร็จ V2 MySQL 2014/12/27
   
    Private Sub AutoNumberNo()
        Try
            strSQL = "SELECT Max(ID) as ID FROM users_id"
            Mainfrm.lblMainStatus.Text = strSQL
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtUserID.Text = Now.ToString("yyMM") & "01"
            Else
                Dim newID As Integer = CInt(Dr.Item("id"))
                newID += 1
                Me.txtUserID.Text = Now.ToString("yyMM") & newID.ToString("00")
            End If
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
    Private Sub startfrm()
        Me.dgUser.Enabled = True
        Call disableTextBoxes(Me)
        Call ClearTextBoxes(Me)
        Me.btnUserAdd.Enabled = True
        Me.btnUserEdit.Enabled = False
        Me.btnUserDel.Enabled = False
        Me.btnUserCancel.Enabled = True
        Me.RB1.Enabled = False
        Me.RB2.Enabled = False
        Me.RB3.Enabled = False
        Me.RB1.Checked = True
        Me.btnUserCancel.Text = "&ปิด"
    End Sub

    Private Sub GetAllData()
        Me.dgUser.Refresh()
        strSQL = "SELECT user_id AS ID,user_name AS ชื่อ,user_address AS ที่อยู่,user_tel AS เบอร์โทร,user_email AS อีเมล์,user_usernamelogin AS ชื่อเข้าระบบ FROM users ORDER BY ID"
        Mainfrm.lblMainStatus.Text = strSQL
        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        ds = New DataSet
        Call open_connection()
        dtAdapter.Fill(ds, "users")
        Me.dgUser.DataSource = ds
        Me.dgUser.DataMember = "users"
    End Sub

    Private Sub checknullData()
        If txtUsername.Text = "" Then
            MsgBox("กรุณาใส่ชื่อจริง.", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
            txtUsername.Focus()
            txtUsername.BackColor = Color.Salmon
            Exit Sub
        ElseIf txtUserAddress.Text = "" Then
            MsgBox("กรุณาใส่ที่อยู่.", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
            txtUserAddress.Focus()
            txtUserAddress.BackColor = Color.Salmon
            Exit Sub
        ElseIf txtUserTel.Text = "" Then
            MsgBox("กรุณาใส่เบอร์โทรศัพท์", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
            txtUserTel.Focus()
            txtUserTel.BackColor = Color.Salmon
            Exit Sub
        ElseIf txtUserEmail.Text = "" Then
            MsgBox("กรุณาใส่อีเมล์", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
            txtUserEmail.Focus()
            txtUserEmail.BackColor = Color.Salmon
            Exit Sub
        ElseIf txtUsernamelogin.Text = "" Then
            MsgBox("กรุณาใส่ชื่อเข้าระบบ", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
            txtUsernamelogin.Focus()
            txtUsernamelogin.BackColor = Color.Salmon
            Exit Sub
        End If
        'If txtUserPassword.Text = "" Then
        '    MsgBox("กรุณาใส่รหัสผ่าน", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
        '    txtUserPassword.Focus()
        '    txtUserPassword.BackColor = Color.Salmon
        '    Exit Sub
        'End If
    End Sub

    Private Sub checkNewData()
        Try
        'ตรวจสอบชื่อเข้าระบบซ้ำกัน
        Dim intNumRows As Integer
            strSQL = ("SELECT user_usernamelogin FROM users WHERE user_usernamelogin = '" & Me.txtUsernamelogin.Text & "'")
            Mainfrm.lblMainStatus.Text = strSQL
        Call open_connection()
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        intNumRows = cmd.ExecuteScalar()
        If intNumRows > 0 Then
            MsgBox("ชื่อผู้เข้าระบบซ้ำกัน กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            txtUsernamelogin.Focus()
            txtUsernamelogin.BackColor = Color.Salmon
            Exit Sub
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
    Dim leval As String
    Private Sub EditData()
        If RB1.Checked = True Then
            leval = "1"
        ElseIf RB2.Checked = True Then
            leval = "2"
        ElseIf RB3.Checked = True Then
            leval = "3"
        End If
        If Me.txtUserPassword.Text = Me.txtUserPasswordC.Text Then
            Dim UpDateAns As String
            UpDateAns = MsgBox("คุณแน่ใจว่าจะแก้ไขข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            If UpDateAns = System.Windows.Forms.DialogResult.No Then
                MsgBox("การแก้ไขข้อมูลถูกยกเลิก.", MsgBoxStyle.Information, "ยกเลิกการแก้ไข")
            Else
                Try
                    strSQL = "update users set user_id='" & Me.txtUserID.Text & "', user_name='" & Me.txtUsername.Text & "', user_address='" & Me.txtUserAddress.Text & "', user_tel='" & Me.txtUserTel.Text & "', user_email='" & Me.txtUserEmail.Text & "', user_usernamelogin='" & Me.txtUsernamelogin.Text & "', user_password='" & Me.txtUserPassword.Text & "',user_leval='" & leval & "' where user_id='" & Me.dgUser.SelectedCells(0).Value & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว.", MsgBoxStyle.Information, "ยืนยัน")
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = ex.Message
                End Try
                Me.btnUserEdit.Text = "&แก้ไข"
                Me.btnUserCancel.Text = "&ปิด"
                'clear all textbox
                For Each ctl In Controls
                    If TypeOf ctl Is TextBox Then ctl.Text = ""
                Next ctl
                Call startfrm()
                Call GetAllData()
            End If
        Else
            MsgBox("รหัสผ่านไม่ตรงกันกรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "รหัสไม่ตรง")
            Exit Sub
        End If
    End Sub
    Private Sub DeleteData()
        Dim Ans As String
        Ans = MsgBox("คุณแน่ในว่าจะลบข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If Ans = System.Windows.Forms.DialogResult.No Then
            MsgBox("การลบข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
            Me.dgUser.ClearSelection()
            'Exit Sub
        Else
            Try
            strSQL = "DELETE FROM users WHERE user_id='" & Me.txtUserID.Text & "';"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = ex.Message
            End Try
            MsgBox("ลบข้อมูลที่คุณเลือกแล้ว", MsgBoxStyle.Information, "ยืนยัน")
        End If
        'clear all textbox
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
               
    End Sub

    Private Sub btnUserCancel_Click(sender As Object, e As EventArgs) Handles btnUserCancel.Click
        If Me.btnUserCancel.Text = "&ยกเลิก" Then
            Call startfrm()
            If Me.btnUserAdd.Text = "&บันทึก" Then
                Me.btnUserAdd.Text = "&เพิ่ม"
            End If
            If btnUserEdit.Text = "&บันทึก" Then
                Me.btnUserEdit.Text = "&แก้ไข"
            End If
            Me.btnUserCancel.Text = "&ปิด"
        ElseIf Me.btnUserCancel.Text = "&ปิด" Then
            Me.Close()
        End If
       
    End Sub
    Private Sub Userfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
        Me.Icon = Mainfrm.Icon
        Call GetAllData()
    End Sub
    Dim intNumRows As Integer
    Dim result As Integer
    Private Sub btnUserAdd_Click(sender As Object, e As EventArgs) Handles btnUserAdd.Click
        Call AutoNumberNo()
        If Me.btnUserAdd.Text = "&เพิ่ม" Then
            Call enableTextBoxes(Me)
            Me.txtUserID.Enabled = False
            Me.btnUserAdd.Text = "&บันทึก"
            Me.btnUserDel.Enabled = False
            Me.btnUserEdit.Enabled = False
            Me.RB1.Enabled = True
            Me.RB2.Enabled = True
            Me.RB3.Enabled = True
            Me.dgUser.Enabled = False
            Me.btnUserCancel.Text = "&ยกเลิก"
            Exit Sub
        ElseIf Me.btnUserAdd.Text = "&บันทึก" Then
            If txtUsername.Text = "" Then
                MsgBox("กรุณาใส่ชื่อจริง.", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
                txtUsername.Focus()
                txtUsername.BackColor = Color.Salmon
                Exit Sub
            ElseIf txtUserAddress.Text = "" Then
                MsgBox("กรุณาใส่ที่อยู่.", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
                txtUserAddress.Focus()
                txtUserAddress.BackColor = Color.Salmon
                Exit Sub
            ElseIf txtUserTel.Text = "" Then
                MsgBox("กรุณาใส่เบอร์โทรศัพท์", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
                txtUserTel.Focus()
                txtUserTel.BackColor = Color.Salmon
                Exit Sub
            ElseIf txtUserEmail.Text = "" Then
                MsgBox("กรุณาใส่อีเมล์", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
                txtUserEmail.Focus()
                txtUserEmail.BackColor = Color.Salmon
                Exit Sub
            ElseIf txtUsernamelogin.Text = "" Then
                MsgBox("กรุณาใส่ชื่อเข้าระบบ", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
                txtUsernamelogin.Focus()
                txtUsernamelogin.BackColor = Color.Salmon
                Exit Sub
            End If
            'ตรวจชื่อซ้ำ
            If Me.txtUserPassword.Text = Me.txtUserPasswordC.Text Then
                Try
                strSQL = ("SELECT user_usernamelogin FROM users WHERE user_usernamelogin = '" & Me.txtUsernamelogin.Text & "'")
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                intNumRows = cmd.ExecuteScalar()
                If intNumRows > 0 Then
                    MsgBox("ชื่อผู้เข้าระบบซ้ำกัน กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                    Me.txtUsernamelogin.Focus()
                    Me.txtUsernamelogin.BackColor = Color.Salmon
                    Exit Sub
                End If
                If txtUserPassword.Text = "" Then
                    MsgBox("กรุณาใส่รหัสผ่าน", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
                    Me.txtUserPassword.Focus()
                    Me.txtUserPassword.BackColor = Color.Salmon
                    Exit Sub
                End If
            'บันทึกข้อมูล
                If RB1.Checked = True Then
                    leval = "1"
                ElseIf RB2.Checked = True Then
                    leval = "2"
                ElseIf RB3.Checked = True Then
                    leval = "3"
                End If
                strSQL = "INSERT INTO users(user_id, user_name, user_address, user_tel, user_email, user_password, user_usernamelogin, user_leval)" _
                    & "VALUES('" & Me.txtUserID.Text & "','" & Me.txtUsername.Text & "','" & Me.txtUserAddress.Text & "','" & Me.txtUserTel.Text & "','" & Me.txtUserEmail.Text & "','" & Me.txtUserPassword.Text & "','" & Me.txtUsernamelogin.Text & "','" & leval & "' )"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                result = cmd.ExecuteNonQuery()
                strSQL = "INSERT INTO users_id(user_id, user_namelogin,datetime_save)" _
                   & "VALUES('" & Me.txtUserID.Text & "','" & Me.txtUsernamelogin.Text & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "')"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                If result = 1 Then
                    MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, _
                           "การบันทึกข้อมูลสำเร็จ")
                Else
                    MsgBox("ไม่สามารถบันทึกข้อมูล", MsgBoxStyle.Information, _
                           "การบันทึกข้อมูลไม่สำเร็จ")
                    End If
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            Else
                MsgBox("รหัสผ่านไม่ตรงกัน", MsgBoxStyle.Information, "รหัสไม่ตรง")
                Exit Sub
            End If
        End If
        Me.btnUserAdd.Text = "&เพิ่ม"
        Me.btnUserCancel.Text = "&ปิด"
        Call ClearTextBoxes(Me)
        Call startfrm()
        Call GetAllData()
    End Sub
    Private Sub btnUserEdit_Click(sender As Object, e As EventArgs) Handles btnUserEdit.Click
        If Me.btnUserEdit.Text = "&แก้ไข" Then
            Me.btnUserEdit.Text = "&บันทึก"
            Me.btnUserCancel.Text = "&ยกเลิก"
            Me.btnUserDel.Enabled = False
            Me.btnUserAdd.Enabled = False
            Me.RB1.Enabled = True
            Me.RB2.Enabled = True
            Me.RB3.Enabled = True
            Call enableTextBoxes(Me)
            Me.txtUserID.Enabled = False
            Me.dgUser.Enabled = False
            Exit Sub
        ElseIf Me.btnUserEdit.Text = "&บันทึก" Then
            Call EditData()
           
        End If
    
    End Sub
    Private Sub btnUserDel_Click(sender As Object, e As EventArgs) Handles btnUserDel.Click
        Call DeleteData()
        Call GetAllData()
        Call startfrm()
    End Sub
    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgUser.MouseDoubleClick
        Me.btnUserAdd.Enabled = False
        Me.btnUserEdit.Enabled = True
        Me.btnUserDel.Enabled = True
        Me.btnUserCancel.Enabled = True
        Me.txtUserID.Text = Me.dgUser.SelectedCells(0).Value
        Me.btnUserCancel.Text = "&ยกเลิก"
    End Sub

    Private Sub getDatatotxt()
        Try
            strSQL = "SELECT user_name,user_address,user_tel,user_email,user_password,user_usernamelogin,user_leval from users where user_id=@1"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@1", Me.txtUserID.Text)
            Call open_connection()
            Dr = cmd.ExecuteReader
            With Dr
                .Read()
                Me.txtUsername.Text = .Item("user_name")
                Me.txtUserAddress.Text = .Item("user_address")
                Me.txtUserTel.Text = .Item("user_tel")
                Me.txtUserEmail.Text = .Item("user_email")
                Me.txtUserPassword.Text = .Item("user_password")

                Me.txtUsernamelogin.Text = .Item("user_usernamelogin")
                If .Item("user_leval") = "1" Then
                    RB1.Checked = True
                ElseIf .Item("user_leval") = "2" Then
                    RB2.Checked = True
                ElseIf .Item("user_leval") = "3" Then
                    RB3.Checked = True
                End If
            End With
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        Call getDatatotxt()
    End Sub
End Class