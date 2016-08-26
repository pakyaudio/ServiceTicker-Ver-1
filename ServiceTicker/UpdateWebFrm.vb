Imports System.Net
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class UpdateWebFrm
    Private Sub connectftp()
        Try
            Dim request = _
       DirectCast(WebRequest.Create _
       (Me.txtUDWhost.Text + Me.txtUDWfolder.Text), FtpWebRequest)
            request.Credentials = _
            New NetworkCredential(Me.txtUDWusername.Text, Me.txtUDWpassword.Text)
            request.Method = WebRequestMethods.Ftp.ListDirectory
            Using response As FtpWebResponse = _
            DirectCast(request.GetResponse(), FtpWebResponse)
                ' Folder exists here
                MsgBox("เชื่อมต่อได้", MsgBoxStyle.Information, "แจ้งเตือน")
                Call updatedatabase()
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            MsgBox("เชื่อมต่อไม่ได้ " & ex.Message)
        End Try
    End Sub
    Private Sub updatedatabase()
        Try
            strSQL = "UPDATE ftp SET host='" & Me.txtUDWhost.Text & "',folder='" & Me.txtUDWfolder.Text & "',username='" & Me.txtUDWusername.Text & "',password='" & Me.txtUDWpassword.Text & "'"
            Mainfrm.lblMainStatus.Text = "UPDATE ftp SET ************"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Mainfrm.lblMainStatus.Text = "อัพเดทฐานข้อมูลแล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getdatebase()
        Try
            strSQL = "SELECT host,folder,username,password FROM ftp"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                Me.txtUDWhost.Text = Dr.Item("host")
                Me.txtUDWfolder.Text = Dr.Item("folder")
                Me.txtUDWusername.Text = Dr.Item("username")
                Me.txtUDWpassword.Text = Dr.Item("password")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub backupdatabase()
        'Dim di As DirectoryInfo = New DirectoryInfo(Application.StartupPath + "\upload")
        ''*** Create Folder ***'
        'If Not di.Exists Then
        '    di.Create()
        'End If
        Dim file As String
            Mainfrm.lblMainStatus.Text = "กำลังสำรองข้อมูล"

            Me.Enabled = False
            file = "Database.sql"
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = ConnectionDB
            Call open_connection()
        Dim mb As MySqlBackup = New MySqlBackup(cmd)
        Application.DoEvents()
        mb.ExportToFile(file)
        Application.DoEvents()
        Mainfrm.lblMainStatus.Text = "สำรองข้อมูลแล้ว"
    End Sub
    Private Sub upload()
        Try
            'Create Request
            Mainfrm.lblMainStatus.Text = "เชื่อมต่อ host"
            Dim Request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(Me.txtUDWhost.Text + Me.txtUDWfolder.Text + "/Database.sql"), System.Net.FtpWebRequest)
            Application.DoEvents()
            'Upload Properties
            Mainfrm.lblMainStatus.Text = "กำลังอัพโหลด"
            Request.Credentials = New System.Net.NetworkCredential(Me.txtUDWusername.Text, Me.txtUDWpassword.Text)
            Request.Method = System.Net.WebRequestMethods.Ftp.UploadFile
            Application.DoEvents()
            'Read File
            Dim File() As Byte = System.IO.File.ReadAllBytes("Database.sql")
            Application.DoEvents()
            'Upload
            Dim Strz As System.IO.Stream = Request.GetRequestStream()
            Strz.Write(File, 0, File.Length)

            Strz.Close()
            Strz.Dispose()

            Me.Enabled = True
            Mainfrm.lblMainStatus.Text = "อัพโหลดข้อมูลแล้ว"
            MsgBox("อัพเดทข้อมูลขึ้นเว็บเรียบร้อยแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")

        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            MsgBox("ผิดพลาด " & ex.Message, MsgBoxStyle.Information, "แจ้งเตือน")
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call connectftp()
    End Sub

    Private Sub UpdateWebFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getdatebase()
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call backupdatabase()
        Call upload()
    End Sub
End Class