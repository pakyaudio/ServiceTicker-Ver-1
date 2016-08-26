Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Threading

Public Class LoginFrm
    Private Const AW_BLEND = &H80000
    Private Declare Function AnimateWindow Lib "user32" (ByVal hwnd As Int32, ByVal dwTime As Int32, ByVal dwFlags As Int32) As Boolean
    Dim winHide As Integer = &H10000
    Dim winBlend As Integer = &H80000
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        Try
            AnimateWindow(Me.Handle.ToInt32, CInt(500), winHide Or winBlend)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtLoginUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoginUsername.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLoginPassword.Focus()
        End If
    End Sub

    Private Sub txtLoginPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLoginPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call ok()
        End If
    End Sub

    Private Sub ok()
        If txtLoginUsername.Text = "" Or txtLoginPassword.Text = "" Then
            MessageBox.Show("ใส่ชื่อหรือรหัสผ่านด้วย", "การยืนยันตัวตนผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                strSQL = "SELECT * FROM users WHERE user_usernamelogin='" & Me.txtLoginUsername.Text & "' AND user_password = '" & Me.txtLoginPassword.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dim sqlRead As MySqlDataReader = cmd.ExecuteReader()
                If sqlRead.Read() Then
                    Try
                        strSQL = "SELECT * FROM users WHERE user_usernamelogin='" & Me.txtLoginUsername.Text & "' AND user_password = '" & Me.txtLoginPassword.Text & "'"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader
                        Dr.Read()
                        Dim user_id As String = Dr.Item("user_id")
                        Dim user_name As String = Dr.Item("user_name")
                        Dim user_usernamelogin As String = Dr.Item("user_usernamelogin")
                        Dim date_in As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))
                        strSQL = "insert into applogs(user_id,user_name,user_usernamelogin,note,date_in)values('" & user_id & "','" & user_name & "','" & user_usernamelogin & "','" & "เข้าโปรแกรม" & "','" & date_in & "') "
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                        Mainfrm.Show()
                        Me.Hide()
                    Catch ex As Exception

                    End Try
                Else
                    MessageBox.Show("ชื่อผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง", "การยืนยันตัวตนผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtLoginUsername.Text = ""
                    Me.txtLoginPassword.Text = ""
                    Me.txtLoginUsername.Focus()
                End If
                Dr.Close()
            Catch ex As Exception
                ' MessageBox.Show("ไม่สามารถติดต่อฐานข้อมูลได้", "การเฃื่อมต่อฐานข้อมูลผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub btnLoginOK_Click(sender As Object, e As EventArgs) Handles btnLoginOK.Click
        Call ok()
    End Sub

    Private Sub loadLOGO()
        Try
            Dim imgs As String
            strSQL = "SELECT ver_company,ver_version,ver_imglogin FROM ver_detail"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.lblLoginCompanyname.Text = Dr.GetString("ver_company")
            Me.lblLoginVersion.Text = Dr.GetString("ver_version")
            imgs = Dr.GetString("ver_imglogin")
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(imgs)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 0.01
        If Me.Opacity = 1 Then
            Timer1.Stop()
        End If
    End Sub
    Private Sub ChangRegion()
        If Thread.CurrentThread.CurrentCulture.Name <> "th-TH" Then
            ' Set culture to en-US.
            Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("th-TH")
        End If
    End Sub

    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'start MySQL
        Call ChangRegion()
        Timer1.Start()
        Me.Opacity = 0.01
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "startup", Nothing) Is Nothing Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "startup", "0")
        End If
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "verified", Nothing) Is Nothing Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "verified", "1")
        End If
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "importune", Nothing) Is Nothing Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "importune", "1")
        End If
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "startmysql", Nothing) Is Nothing Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "startmysql", "1")
        End If
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "time_backup", Nothing) Is Nothing Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "time_backup", "5")
        End If
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "enable_backup", Nothing) Is Nothing Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "enable_backup", "yes")
        End If
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "startmysql", Nothing) = "1" Then
            Try
                Dim p() As Process
                p = Process.GetProcessesByName("mysqld.exe")
                If p.Count > 0 Then
                    ' Process is running
                Else
                    Process.Start("C:\ServiceTicker\Mysql\start.exe")
                End If
            Catch ex As Exception

            End Try
        End If

        Application.CurrentCulture = New CultureInfo("th-TH")
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "server", Nothing) Is Nothing Then
            MsgBox("ไม่พบข้อมูลรีจิสเตอร์ของโปรแกรม โปรแกรมจะทำการสร้างข้อมูลรีจิสเตอร์ใหม่แล้วปิดโปรแกรม กรุณาเปิดโปรแกรมใหม่อีกครั้ง", MsgBoxStyle.Exclamation, "พบข้อผิดพลาด")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "server", "localhost")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "database", "serviceticker")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "user", "root")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "password", "Fx1rpB")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "port", "3306")
            Application.Exit()
        Else
            Me.txtLoginUsername.Focus()
            Try
                strSQL = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema='serviceticker'"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    While (reader.Read())
                        Dim count As Integer = reader.GetInt32(0)
                    End While
                End Using

            Catch ex As Exception
                MsgBox("ไม่สามารถเชื่อต่อข้อมูลได้ เกิดข้อผิดพลาด " & ex.Message & vbNewLine & " กรุณาตรวจสอบฐานข้อมูล ตารางในฐานข้อมูลว่าใช้งานได้หรือไม่", MsgBoxStyle.Critical, "การเชื่อมต่อล้มเหลว")
                DataBaseConnectFrm.Show()
                Exit Sub
            End Try
        End If

        Call appconfig()
        Call checkDB()
        Call loadLOGO()
    End Sub

    Private Sub btnLoginCancel_Click(sender As Object, e As EventArgs) Handles btnLoginCancel.Click
        Me.Close()
    End Sub

    Private Sub btnLGshowpass_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLGshowpass.MouseDown
        If txtLoginPassword.UseSystemPasswordChar = True Then
            txtLoginPassword.UseSystemPasswordChar = False
        ElseIf txtLoginPassword.UseSystemPasswordChar = False Then
            txtLoginPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLGshowpass_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLGshowpass.MouseUp
        If txtLoginPassword.UseSystemPasswordChar = True Then
            txtLoginPassword.UseSystemPasswordChar = False
        ElseIf txtLoginPassword.UseSystemPasswordChar = False Then
            txtLoginPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class