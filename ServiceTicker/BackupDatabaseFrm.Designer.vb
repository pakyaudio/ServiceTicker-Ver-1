<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupDatabaseFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nudBD = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBDsave = New System.Windows.Forms.Button()
        Me.txtBDbackDIR = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnBDselectFolder = New System.Windows.Forms.Button()
        Me.FBD1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ToolTipBD = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbEnableBackup = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.nudBD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(503, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "สำรองฐานข้อมูลเดี๋ยวนี้"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nudBD
        '
        Me.nudBD.Location = New System.Drawing.Point(122, 9)
        Me.nudBD.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudBD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudBD.Name = "nudBD"
        Me.nudBD.Size = New System.Drawing.Size(137, 20)
        Me.nudBD.TabIndex = 35
        Me.ToolTipBD.SetToolTip(Me.nudBD, "ตั้งเวลาสำรองข้อมูล ค่าเป็นชั่วโมง สูงสุด 12 ชั่วโมง")
        Me.nudBD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(265, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(222, 16)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "ตั้งเวลาสำรองข้อมูลอัตโนมัติ (หน่วยเป็นชั่วโมง)"
        '
        'btnBDsave
        '
        Me.btnBDsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBDsave.Image = Global.ServiceTicker.My.Resources.Resources.disk
        Me.btnBDsave.Location = New System.Drawing.Point(122, 76)
        Me.btnBDsave.Name = "btnBDsave"
        Me.btnBDsave.Size = New System.Drawing.Size(137, 25)
        Me.btnBDsave.TabIndex = 37
        Me.ToolTipBD.SetToolTip(Me.btnBDsave, "บันทึกการตั้งค่าทั้งหมด")
        Me.btnBDsave.UseVisualStyleBackColor = True
        '
        'txtBDbackDIR
        '
        Me.txtBDbackDIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBDbackDIR.Location = New System.Drawing.Point(122, 51)
        Me.txtBDbackDIR.Name = "txtBDbackDIR"
        Me.txtBDbackDIR.Size = New System.Drawing.Size(137, 22)
        Me.txtBDbackDIR.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(32, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 16)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "เวลาสำรองข้อมูล"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 16)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "โฟล์เดอร์สำรองข้อมูล"
        '
        'btnBDselectFolder
        '
        Me.btnBDselectFolder.Image = Global.ServiceTicker.My.Resources.Resources.folder
        Me.btnBDselectFolder.Location = New System.Drawing.Point(265, 51)
        Me.btnBDselectFolder.Name = "btnBDselectFolder"
        Me.btnBDselectFolder.Size = New System.Drawing.Size(25, 22)
        Me.btnBDselectFolder.TabIndex = 41
        Me.ToolTipBD.SetToolTip(Me.btnBDselectFolder, "เลือกโฟล์เดอร์ที่จะเก็บไฟล์สำรอง")
        Me.btnBDselectFolder.UseVisualStyleBackColor = True
        '
        'FBD1
        '
        Me.FBD1.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(296, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 16)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "โฟล์เดอร์ที่จะสำรองข้อมูล"
        '
        'ToolTipBD
        '
        Me.ToolTipBD.IsBalloon = True
        '
        'cbEnableBackup
        '
        Me.cbEnableBackup.AutoSize = True
        Me.cbEnableBackup.Location = New System.Drawing.Point(122, 31)
        Me.cbEnableBackup.Name = "cbEnableBackup"
        Me.cbEnableBackup.Size = New System.Drawing.Size(151, 17)
        Me.cbEnableBackup.TabIndex = 44
        Me.cbEnableBackup.Text = "ปิดการสำรองข้อมูลอัตโนมัติ"
        Me.cbEnableBackup.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 158)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 45
        Me.lblemployee.Text = "User"
        '
        'BackupDatabaseFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 176)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.cbEnableBackup)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnBDselectFolder)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtBDbackDIR)
        Me.Controls.Add(Me.btnBDsave)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.nudBD)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BackupDatabaseFrm"
        Me.Text = "สำรองฐานข้อมูล"
        CType(Me.nudBD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nudBD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBDsave As System.Windows.Forms.Button
    Friend WithEvents txtBDbackDIR As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnBDselectFolder As System.Windows.Forms.Button
    Friend WithEvents FBD1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolTipBD As System.Windows.Forms.ToolTip
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbEnableBackup As System.Windows.Forms.CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
