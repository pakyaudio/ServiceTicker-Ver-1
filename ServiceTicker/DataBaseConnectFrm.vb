Imports MySql.Data.MySqlClient
Public Class DataBaseConnectFrm
   
    Private Sub btnDBCsace_Click(sender As Object, e As EventArgs) Handles btnDBCsace.Click
        Try
            Mainfrm.lblMainStatus.Text = "My.Computer.Registry.SetValue "
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "server", Me.txtDBCservername.Text)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "database", Me.txtDBCdatabasename.Text)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "user", Me.txtDBCusername.Text)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "password", Me.txtDBCpassword.Text)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "port", Me.txtDBCport.Text)
            MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "การบันทึก")
        Catch ex As Exception
            MsgBox("ไม่สามารถบันทึกข้อมูลได้", MsgBoxStyle.Critical, "การบันทึก")
        End Try
        MsgBox("โปรแกรมจะปิดตัวเอง กรุณาเปืดโปรแกรมใหม่", MsgBoxStyle.Information, "เปลี่ยนฐานข้อมูล")

        Application.ExitThread()
    End Sub

    Private Sub btnDBCtest_Click(sender As Object, e As EventArgs) Handles btnDBCtest.Click
        Try
            Dim server As String = Me.txtDBCservername.Text
            Dim database As String = Me.txtDBCdatabasename.Text
            Dim user As String = Me.txtDBCusername.Text
            Dim password As String = Me.txtDBCpassword.Text
            Dim port As String = Me.txtDBCport.Text
            Dim testdata As String = "Server='" & server & "';Port='" & port & "';Database='" & database & "';Uid='" & user & "';Pwd='" & password & "';"
            Dim testConnectionDB As New MySqlConnection(testdata)
            testConnectionDB.Open()
            MsgBox("การเชื่อมต่อใช้งานได้", MsgBoxStyle.Information, "เปลี่ยนฐานข้อมูล")
            testConnectionDB.Close()

        Catch myerror As MySqlException
            MsgBox("การเชื่อต่อใช้งานไม่ได้ กรุณาตรวจสอบให้แน่ใจว่าทุกอย่างถูกต้อง", MsgBoxStyle.Exclamation, "เปลี่ยนฐานข้อมูล")
        End Try
    End Sub

    Private Sub btnDBCcancel_Click(sender As Object, e As EventArgs) Handles btnDBCcancel.Click
        Me.Close()
    End Sub

    Private Sub DataBaseConnectFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Try
            Mainfrm.lblMainStatus.Text = "My.Computer.Registry.GetValue "
            Application.DoEvents()
            Me.txtDBCservername.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "server", Nothing)
            Me.txtDBCdatabasename.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "database", Nothing)
            Me.txtDBCusername.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "user", Nothing)
            Me.txtDBCpassword.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "password", Nothing)
            Me.txtDBCport.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "port", Nothing)
        Catch ex As Exception
            MsgBox("ไม่สามารถอ่านข้อมูลได้ เกิดข้อผิดพลาด " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ImportRestoreDatabaseFrm.Show()
    End Sub
End Class