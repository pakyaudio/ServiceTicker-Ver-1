Imports System.IO
Imports System.Net

Public Class NewVersionFrm
    Private Sub chkup()
        Try
        Dim req As HttpWebRequest = System.Net.HttpWebRequest.Create("http://update.patechgroup.net/latest.txt")
        Dim rep As HttpWebResponse = req.GetResponse()
        Dim str As New StreamReader(rep.GetResponseStream)
        Dim strOut As String = ""
        While str.Peek >= 0
            strOut &= str.ReadLine & vbCrLf
        End While
        Me.txtNVtext.Text = strOut
            str.Close()
        Catch ex As Exception
            Me.txtNVtext.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckUpdateFrm.MdiParent = Mainfrm
        CheckUpdateFrm.Show()
    End Sub

    Private Sub NewVersionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call chkup()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class