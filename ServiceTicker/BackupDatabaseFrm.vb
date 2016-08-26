Imports System.ComponentModel
Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Timers
Imports System.IO
Public Class BackupDatabaseFrm
    'แก้ไขล่าสุด 2015/10/17
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim file As String = Me.txtBDbackDIR.Text & "\Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(file)
        Catch ex As Exception
            Me.Enabled = True
            BackgroundWorker1.CancelAsync()
            Mainfrm.lblMainStatus.Text = "สำรองข้อมูลไม่สำเร็จ " & ex.Message
        End Try
    End Sub
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Mainfrm.lblMainStatus.Text = "กำลังโหลดการสำรองข้อมูล"
        Dim di As DirectoryInfo = New DirectoryInfo(Me.txtBDbackDIR.Text)
        '*** Create Folder ***'
        If Not di.Exists Then
            If MessageBox.Show("ไม่พบโฟล์เดอร์ " & Me.txtBDbackDIR.Text & " ต้องการจะสร้างใหม่หรือไม่ ", "ไม่พบโฟล์เดอร์", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Try
                    di.Create()
                Catch ex As Exception
                    MsgBox("ไม่สามารถสร้างโฟล์เดอร์ " & Me.txtBDbackDIR.Text & " ได้" & vbNewLine & "กรุณาเลือกไดร์ที่ต้องการเก็บไฟล์สำรองข้อมูล", MsgBoxStyle.Critical, "สร้างโฟล์เดอร์ไม่ได้")
                    Exit Sub
                End Try
            Else
                Exit Sub
            End If
        End If
        Mainfrm.lblMainStatus.Text = "กำลังสำรองข้อมูล"
        Me.Enabled = False
        'Call bak()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackupDatabaseFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Me.Icon = Mainfrm.Icon
        Me.nudBD.Value = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "time_backup", Nothing)
        Call getDIR()
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "enable_backup", Nothing) = "yes" Then
            If Me.cbEnableBackup.CheckState = CheckState.Unchecked Then
                Me.cbEnableBackup.CheckState = CheckState.Checked
            End If
        ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "enable_backup", Nothing) = "no" Then
            If Me.cbEnableBackup.CheckState = CheckState.Checked Then
                Me.cbEnableBackup.CheckState = CheckState.Unchecked
            End If
        End If
    End Sub
    Private Sub cbCheckSt()
        If MessageBox.Show("แน่ใจว่าเปลี่ยนแปลงการ สำรองข้อมูลอัตโนมัติ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            If Me.cbEnableBackup.CheckState = CheckState.Unchecked Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "enable_backup", "no")
                Mainfrm.lblMainStatus.Text = "ปิดสำรองข้อมูลอัตโนมัติ"
                Mainfrm.Timer4Backup.Stop()
                Mainfrm.timeBK = 0
            ElseIf Me.cbEnableBackup.CheckState = CheckState.Checked Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "enable_backup", "yes")
                Mainfrm.lblMainStatus.Text = "เปิดสำรองข้อมูลอัตโนมัติ"
                Mainfrm.Timer4Backup.Start()
                Mainfrm.timeBK = 0
            End If
        Else
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "enable_backup", Nothing) = "yes" Then
                If Me.cbEnableBackup.CheckState = CheckState.Unchecked Then
                    Me.cbEnableBackup.CheckState = CheckState.Checked
                    Mainfrm.Timer4Backup.Start()
                End If
            ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "enable_backup", Nothing) = "no" Then
                If Me.cbEnableBackup.CheckState = CheckState.Checked Then
                    Me.cbEnableBackup.CheckState = CheckState.Unchecked
                    Mainfrm.Timer4Backup.Stop()
                End If
            End If
        End If
    End Sub
    Private Sub getDIR()
        Try
            Mainfrm.lblMainStatus.Text = "ค้นหาเส้นทางเก็บข้อมูล"
            strSQL = "SELECT backupdirectory from autobackup"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.txtBDbackDIR.Text = Dr.Item("backupdirectory")
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "SELECT backupdirectory,timer ผิดพลาด" & ex.Message
        End Try
    End Sub

    Private Sub btnBDsave_Click(sender As Object, e As EventArgs) Handles btnBDsave.Click
        Try
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "time_backup", Me.nudBD.Value)
            strSQL = "update autobackup set backupdirectory=@dir"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.AddWithValue("@dir", Me.txtBDbackDIR.Text)
            Call open_connection()
            cmd.ExecuteNonQuery()
            MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "update autobackup ผิดพลาด" & ex.Message
        End Try
    End Sub

    Private Sub btnBDselectFolder_Click(sender As Object, e As EventArgs) Handles btnBDselectFolder.Click
        If (Me.FBD1.ShowDialog() = DialogResult.OK) Then
            Me.txtBDbackDIR.Text = FBD1.SelectedPath
        End If
    End Sub

    Private Sub cbEnableBackup_Click(sender As Object, e As EventArgs) Handles cbEnableBackup.Click
        Call cbCheckSt()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.Enabled = True
        Mainfrm.lblMainStatus.Text = "สำรองข้อมูลแล้ว"
        MsgBox("สำรองข้อมูลเสร็จเรียบร้อย", MsgBoxStyle.Information, "สำรองข้อมูลแล้ว")
    End Sub
End Class