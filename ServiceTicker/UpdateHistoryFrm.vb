Public Class UpdateHistoryFrm

    Private Sub UpdateHistoryFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Try
            For Each s As String In System.IO.File.ReadAllLines("C:\ServiceTicker\latest.txt")
                TextBox1.AppendText(s + vbNewLine)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class