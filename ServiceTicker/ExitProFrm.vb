Public Class ExitProFrm

    Private Sub ExitProFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Dim cltxt As String = ProgressBar1.Value
        lblEPex.Text = "กำลังจะปิดโปรแกรมใน " & 100 - CInt(cltxt)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Try
                Dim inst As String = CheckUpdateFrm.filepath
                Process.Start(inst)
            Catch ex As Exception
                MsgBox("ไม่พบไฟล์สำหรับติดตั้ง " & ex.Message)
            End Try
            Application.ExitThread()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        Try
            Dim inst As String = CheckUpdateFrm.filepath
            Process.Start(inst)
        Catch ex As Exception
            MsgBox("ไม่พบไฟล์สำหรับติดตั้ง " & ex.Message)
        End Try
        Application.ExitThread()

    End Sub
End Class