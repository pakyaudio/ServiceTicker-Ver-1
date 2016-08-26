Public Class StatusFrm


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult
        result = ColorDialog1.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            Me.txtSatus.ForeColor = ColorDialog1.Color
            Mainfrm.lblMainStatus.Text = "เปลี่ยนสีตัวอักษร " & ColorDialog1.Color.ToString
        ElseIf result = Windows.Forms.DialogResult.Cancel Then
            Return
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult
        result = ColorDialog2.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            'Set the background color of the picture box = color selected from the color dialog
            Me.txtSatus.BackColor = ColorDialog2.Color
            Mainfrm.lblMainStatus.Text = "เปลี่ยนสีพื้นหลัง " & ColorDialog2.Color.ToString
        ElseIf result = Windows.Forms.DialogResult.Cancel Then
            Return
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult
        result = FontDialog1.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            Me.txtSatus.Font = FontDialog1.Font
            Mainfrm.lblMainStatus.Text = "เปลี่ยนแบบอักษร " & FontDialog1.Font.ToString
        ElseIf result = Windows.Forms.DialogResult.Cancel Then
            Return
        End If
    End Sub
End Class