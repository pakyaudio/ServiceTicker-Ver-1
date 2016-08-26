Imports MySql.Data.MySqlClient

Public Class CheckUpdateFrm
    Dim download_size As Long
    Dim downloaded_size As Long
    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://update.patechgroup.net/Version.txt")
    Dim response As System.Net.HttpWebResponse = request.GetResponse()
    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
    Dim newestversion As String = sr.ReadToEnd()
    Dim currentversion As String = Application.ProductVersion
    Dim pa As String = Environ$("SystemDrive")
    Friend filepath As String = pa & "\ServiceTicker\Update\ServiceTicker" & newestversion & ".msi"
    Dim fileDownload As String = "http://update.patechgroup.net/latest/ServiceTicker.msi"

    Public Sub CheckForUpdates()
        Try
            If ProgressBar1.Value = 100 Then
                If newestversion.Contains(currentversion) Then
                    lblCUcheckupdate.Text = ("โปรแกรมเป็นเวอร์ชั่นล่าสุด")
                Else
                    lblCUcheckupdate.Text = ("ดาวน์โหลดอัพเดท")
                    If System.IO.Directory.Exists(pa & "\ServiceTicker\Update") Then
                    Else
                        System.IO.Directory.CreateDirectory(pa & "\ServiceTicker\Update")
                    End If
                  
                    Dim req As System.Net.WebRequest
                    Dim resp As System.Net.WebResponse
                    req = Net.WebRequest.Create(fileDownload)
                    resp = req.GetResponse
                    req.Method = Net.WebRequestMethods.Http.Get
                    download_size = resp.ContentLength
                    ProgressBar2.Maximum = download_size
                    Download.RunWorkerAsync()
                    Progress.Start()
                End If
            End If
        Catch ex As Exception
            MsgBox("ไม่สามารถเชื่อมต่อการอัพเดทได้สำเร็จ", MsgBoxStyle.Exclamation, "ผิดพลาด")
            Me.Close()
        End Try
    End Sub
  
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        lblCUpercencheckupdate.Text = ProgressBar1.Value
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Try
                If newestversion.Contains(currentversion) Then
                    lblCUcheckupdate.Text = ("โปรแกรมเป็นเวอร์ชั่นล่าสุด")
                Else
                    lblCUcheckupdate.Text = ("ดาวน์โหลดอัพเดท")
                    Call CheckForUpdates()
                End If
            Catch ex As Exception
                MsgBox("ไม่สามารถเชื่อมต่อการอัพเดทได้สำเร็จ", MsgBoxStyle.Exclamation, "ผิดพลาด")
                Me.Close()
            End Try
        End If
    End Sub

    Private Sub CheckUpdateFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Application.OpenForms().OfType(Of NewVersionFrm).Any Then
            NewVersionFrm.Close()
        End If
    End Sub

    Private Sub CheckUpdateFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Me.lblCUcheckupdate.Text = "กำลังตรวจสอบอัพเดท..."
        Me.Timer1.Start()
        Me.lblCUpercencheckupdate.Text = Me.ProgressBar1.Value
        Me.lblCUpercendownload.Text = Me.ProgressBar2.Value
        Me.lblCUDownload.Text = "รอการตรวจสอบอัพเดท"
    End Sub

    Private Sub Download_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Download.DoWork
        Try
            My.Computer.Network.DownloadFile(fileDownload, filepath, "", "", False, 360000, True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Progress_Tick(sender As Object, e As EventArgs) Handles Progress.Tick
        downloaded_size = My.Computer.FileSystem.GetFileInfo(filepath).Length
        ProgressBar2.Value = downloaded_size
        Dim kiro As Integer
        kiro = ProgressBar2.Value / 10240
        Me.lblCUpercendownload.Text = kiro & " KB"
        Me.lblCUDownload.Text = "กำลังดาวน์โหลด"
    End Sub

    Private Sub Download_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Download.RunWorkerCompleted
        Me.lblCUDownload.Text = "ดาวน์โหลดเรียบร้อย"
        If MessageBox.Show("ต้องการจะติดตั้งการอัพเดทเลยหรือไม่", "อัพเดทโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            ExitProFrm.Show()
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub


End Class