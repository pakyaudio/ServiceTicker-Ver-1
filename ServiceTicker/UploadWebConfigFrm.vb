Imports System.Net
Imports System.Net.FtpClient
Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class UploadWebConfigFrm
    Private Sub getFTP()
        Try
            strSQL = "SELECT * FROM ftp"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.txtUWChost.Text = Dr.GetString("host")
            Me.txtUWCdirectory.Text = Dr.GetString("folder")
            Me.txtUWCusername.Text = Dr.GetString("username")
            Me.txtUWCpassword.Text = Dr.GetString("password")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub UploadWebConfigFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call getFTP()
    End Sub

    Dim address As String
    Private Sub btnUWCtest_Click(sender As Object, e As EventArgs) Handles btnUWCtest.Click
        'Try
        address = Me.txtUWChost.Text & Me.txtUWCdirectory.Text
        If Not address.StartsWith("ftp://") Then
            address = "ftp://" & address
        End If

        '    Dim request = DirectCast(WebRequest.Create(address), FtpWebRequest)
        '    request.Credentials = New NetworkCredential(Me.txtUWCusername.Text, Me.txtUWCpassword.Text)
        '    request.Method = WebRequestMethods.Ftp.ListDirectory

        '    Try
        '        Dim response As FtpWebResponse = _
        '     DirectCast(request.GetResponse(), FtpWebResponse)
        '        ' Folder exists here
        '        MsgBox("เชื่อต่อได้")
        '        Dim listResponse As FtpWebResponse = request.GetResponse
        '        Dim reader As StreamReader = New StreamReader(listResponse.GetResponseStream())
        '        While reader.Peek >= 0
        '            lvDirectory.Items.Add(reader.ReadToEnd)
        '        End While
        '        lvDirectory.Sorting = SortOrder.Ascending
        '    Catch ex As WebException
        '        Dim response As FtpWebResponse = _
        '         DirectCast(ex.Response, FtpWebResponse)
        '        'Does not exist
        '        If response.StatusCode = _
        '         FtpStatusCode.ActionNotTakenFileUnavailable Then
        '            MsgBox("เชื่อต่อไม่ได้")
        '        End If
        '    End Try
        'Catch ex As Exception
        '    MsgBox("ผิดพลาด " & ex.Message)
        'End Try
        MsgBox(address)
        UploadFile("C:\ServiceTicker\ReportDB.sqlite", address & "/ReportDB.sqlite", Me.txtUWCusername.Text, Me.txtUWCpassword.Text)
    End Sub

    Public Sub UploadFile(ByVal _FileName As String, ByVal _UploadPath As String, ByVal _FTPUser As String, ByVal _FTPPass As String)
        Dim _FileInfo As New System.IO.FileInfo(_FileName)

        ' Create FtpWebRequest object from the Uri provided
        Dim _FtpWebRequest As System.Net.FtpWebRequest = CType(System.Net.FtpWebRequest.Create(New Uri(_UploadPath)), System.Net.FtpWebRequest)

        ' Provide the WebPermission Credintials
        _FtpWebRequest.Credentials = New System.Net.NetworkCredential(_FTPUser, _FTPPass)

        ' By default KeepAlive is true, where the control connection is not closed
        ' after a command is executed.
        _FtpWebRequest.KeepAlive = False

        ' set timeout for 20 seconds
        _FtpWebRequest.Timeout = 20000

        ' Specify the command to be executed.
        _FtpWebRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile

        ' Specify the data transfer type.
        _FtpWebRequest.UseBinary = True

        ' Notify the server about the size of the uploaded file
        _FtpWebRequest.ContentLength = _FileInfo.Length

        ' The buffer size is set to 2kb
        Dim buffLength As Integer = 2048
        Dim buff(buffLength - 1) As Byte

        ' Opens a file stream (System.IO.FileStream) to read the file to be uploaded
        Dim _FileStream As System.IO.FileStream = _FileInfo.OpenRead()

        Try
            ' Stream to which the file to be upload is written
            Dim _Stream As System.IO.Stream = _FtpWebRequest.GetRequestStream()

            ' Read from the file stream 2kb at a time
            Dim contentLen As Integer = _FileStream.Read(buff, 0, buffLength)

            ' Till Stream content ends
            Do While contentLen <> 0
                ' Write Content from the file stream to the FTP Upload Stream
                _Stream.Write(buff, 0, contentLen)
                contentLen = _FileStream.Read(buff, 0, buffLength)
            Loop

            ' Close the file stream and the Request Stream
            _Stream.Close()
            _Stream.Dispose()
            _FileStream.Close()
            _FileStream.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnUWCsave_Click(sender As Object, e As EventArgs) Handles btnUWCsave.Click
        Try
            strSQL = "UPDATE ftp SET host='" & Me.txtUWChost.Text & "',folder='" & Me.txtUWCdirectory.Text & "'," & _
                "username='" & Me.txtUWCusername.Text & "',password='" & Me.txtUWCpassword.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dim save1 As Integer
            save1 = cmd.ExecuteNonQuery()
            If save1 = 1 Then
                MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งให้ทราบ")
            ElseIf save1 = 0 Then
                MsgBox("บันทึกข้อมูลไม่สำเร็จ", MsgBoxStyle.Information, "แจ้งให้ทราบ")
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnUWCupload_Click(sender As Object, e As EventArgs) Handles btnUWCupload.Click
        address = Me.txtUWChost.Text
        If Not address.StartsWith("ftp://") Then
            address = "ftp://" & address
        End If
        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(address & Me.txtUWCdirectory.Text), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential(Me.txtUWCusername.Text, Me.txtUWCpassword.Text)
        request.Method = System.Net.WebRequestMethods.Ftp.UploadFile

        Dim file() As Byte = System.IO.File.ReadAllBytes("C:\ServiceTicker\patechlogo.ico")

        Dim strz As System.IO.Stream = request.GetRequestStream()
        strz.Write(file, 0, file.Length)
        strz.Close()
        strz.Dispose()
    End Sub
End Class