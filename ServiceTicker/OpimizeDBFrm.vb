Imports MySql.Data.MySqlClient
Public Class OpimizeDBFrm
    Private Sub OpimizeDBFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub bgw_Opti_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw_Opti.DoWork
        Try
            Mainfrm.lblMainStatus.Text = "เพิ่มประสิทธิภาพฐานข้อมูล"
            strSQL = "OPTIMIZE TABLE serviceticker"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Me.Enabled = True
            bgw_Opti.CancelAsync()
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub bgw_repair_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw_repair.DoWork
        Try
            Mainfrm.lblMainStatus.Text = "ซ่อมแซมฐานข้อมูล"
            strSQL = "REPAIR TABLE serviceticker"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Me.Enabled = True
            bgw_repair.CancelAsync()
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnOpt_Click(sender As Object, e As EventArgs) Handles btnOpt.Click
        Me.Enabled = False
        Call BackUpDatabase()
        bgw_Opti.RunWorkerAsync()
    End Sub
    Private Sub btnRepair_Click(sender As Object, e As EventArgs) Handles btnRepair.Click
        Me.Enabled = False
        Call BackUpDatabase()
        bgw_repair.RunWorkerAsync()
    End Sub

    Private Sub bgw_Opti_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw_Opti.RunWorkerCompleted
        MsgBox("เพิ่มประสิทธิภาพฐานข้อมูลเรียบร้อย", MsgBoxStyle.Information, "เสร็จ")
        Me.Enabled = True
    End Sub

    Private Sub bgw_repair_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw_repair.RunWorkerCompleted
        MsgBox("ซ่อมแซมฐานข้อมูลเรียบร้อย", MsgBoxStyle.Information, "เสร็จ")
        Me.Enabled = True
    End Sub
End Class