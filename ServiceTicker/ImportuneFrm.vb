Public Class ImportuneFrm

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Left -= 20
        If Label1.Left <= -Width Then
            Label1.Left = Width
        End If
    End Sub

    Private Sub ImportuneFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label1.Text = "มีงานด่วนรออยู่"
        Label1.AutoSize = True
        Timer1.Start()
        Me.Icon = Mainfrm.Icon
    End Sub
End Class