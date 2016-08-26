Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ImportRestoreDatabaseFrm

    Private Sub searchSQLfile_Click(sender As Object, e As EventArgs) Handles searchSQLfile.Click
        Dim fpath As New OpenFileDialog
        Mainfrm.lblMainStatus.Text = "OpenFileDialog"
        'fpath.InitialDirectory = "C:\"
        fpath.Filter = "MySQL Dump File|*.sql"
        fpath.FilterIndex = 1
        fpath.RestoreDirectory = True
        If fpath.ShowDialog = Windows.Forms.DialogResult.OK AndAlso fpath.FileName <> "" Then
            Me.txtIRDBpath.Text = fpath.FileName
            Mainfrm.lblMainStatus.Text = "OpenFileDialog" & fpath.FileName
        End If
       
    End Sub

    Private Sub btnIRDBimport_Click(sender As Object, e As EventArgs) Handles btnIRDBimport.Click
        If Me.txtIRDBpath.Text = "" Then
            MsgBox("กรุณาเลือกไฟล์ฐานข้อมูล *.sql ที่สำรองไว้", MsgBoxStyle.Exclamation, "Import")
            Dim fpath As New OpenFileDialog
            Mainfrm.lblMainStatus.Text = "OpenFileDialog"
            'fpath.InitialDirectory = "C:\"
            fpath.Filter = "MySQL Dump File|*.sql"
            fpath.FilterIndex = 1
            fpath.RestoreDirectory = True
            If fpath.ShowDialog = Windows.Forms.DialogResult.OK AndAlso fpath.FileName <> "" Then
                Me.txtIRDBpath.Text = fpath.FileName
                Mainfrm.lblMainStatus.Text = "OpenFileDialog" & fpath.FileName
            End If
        Else
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Me.Enabled = False
            Mainfrm.lblMainStatus.Text = "สำรองฐานข้อมูล"
            Me.Text = "สำรองฐานข้อมูล"
            Call BackUpDatabase()
            Mainfrm.lblMainStatus.Text = "นำเข้าฐานข้อมูล"
            Me.Text = "นำเข้าฐานข้อมูล"
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = ConnectionDB
            Call open_connection()
            Application.DoEvents()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ImportFromFile(Me.txtIRDBpath.Text)
        Catch ex As Exception
            BackgroundWorker1.CancelAsync()
            Mainfrm.lblMainStatus.Text = "ไม่สามารถนำเข้าฐานข้อมูลได้"
            Me.Text = "ไม่สามารถนำเข้าฐานข้อมูลได้"
            MsgBox("ไม่สามารถนำเข้าฐานข้อมูลได้!" & vbNewLine & "เกิดข้อผิดพลาด " & ex.Message, MsgBoxStyle.Exclamation, "Import")
            Me.Enabled = True
            Me.Text = "Import/Restore Database"
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.Enabled = True
        Mainfrm.lblMainStatus.Text = "นำเข้าฐานข้อมูลแล้ว"
        Me.Text = "นำเข้าฐานข้อมูลแล้ว"
        MsgBox("นำเข้าฐานข้อมูลแล้ว!", MsgBoxStyle.Information, "Import")
        Me.Text = "Import/Restore Database"
    End Sub
End Class