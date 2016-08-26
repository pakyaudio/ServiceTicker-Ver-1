<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckUpdateFrm
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCUpercencheckupdate = New System.Windows.Forms.Label()
        Me.lblCUcheckupdate = New System.Windows.Forms.Label()
        Me.Download = New System.ComponentModel.BackgroundWorker()
        Me.Progress = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.lblCUpercendownload = New System.Windows.Forms.Label()
        Me.lblCUDownload = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(490, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'Timer1
        '
        '
        'lblCUpercencheckupdate
        '
        Me.lblCUpercencheckupdate.AutoSize = True
        Me.lblCUpercencheckupdate.Location = New System.Drawing.Point(508, 18)
        Me.lblCUpercencheckupdate.Name = "lblCUpercencheckupdate"
        Me.lblCUpercencheckupdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCUpercencheckupdate.Size = New System.Drawing.Size(13, 13)
        Me.lblCUpercencheckupdate.TabIndex = 2
        Me.lblCUpercencheckupdate.Text = "0"
        '
        'lblCUcheckupdate
        '
        Me.lblCUcheckupdate.AutoSize = True
        Me.lblCUcheckupdate.Location = New System.Drawing.Point(12, 38)
        Me.lblCUcheckupdate.Name = "lblCUcheckupdate"
        Me.lblCUcheckupdate.Size = New System.Drawing.Size(102, 13)
        Me.lblCUcheckupdate.TabIndex = 5
        Me.lblCUcheckupdate.Text = "ตรวจสอบการอัพเดท"
        '
        'Download
        '
        '
        'Progress
        '
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(12, 54)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(490, 23)
        Me.ProgressBar2.TabIndex = 6
        '
        'lblCUpercendownload
        '
        Me.lblCUpercendownload.AutoSize = True
        Me.lblCUpercendownload.Location = New System.Drawing.Point(508, 59)
        Me.lblCUpercendownload.Name = "lblCUpercendownload"
        Me.lblCUpercendownload.Size = New System.Drawing.Size(13, 13)
        Me.lblCUpercendownload.TabIndex = 7
        Me.lblCUpercendownload.Text = "0"
        '
        'lblCUDownload
        '
        Me.lblCUDownload.AutoSize = True
        Me.lblCUDownload.Location = New System.Drawing.Point(12, 80)
        Me.lblCUDownload.Name = "lblCUDownload"
        Me.lblCUDownload.Size = New System.Drawing.Size(114, 13)
        Me.lblCUDownload.TabIndex = 8
        Me.lblCUDownload.Text = "กำลังดาวน์โหลดอัพเดท"
        '
        'CheckUpdateFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 97)
        Me.Controls.Add(Me.lblCUDownload)
        Me.Controls.Add(Me.lblCUpercendownload)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.lblCUcheckupdate)
        Me.Controls.Add(Me.lblCUpercencheckupdate)
        Me.Controls.Add(Me.ProgressBar1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CheckUpdateFrm"
        Me.Text = "ตรวจสอบอัพเดทโปรแกรม"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblCUpercencheckupdate As System.Windows.Forms.Label
    Friend WithEvents lblCUcheckupdate As System.Windows.Forms.Label
    Friend WithEvents Download As System.ComponentModel.BackgroundWorker
    Friend WithEvents Progress As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblCUpercendownload As System.Windows.Forms.Label
    Friend WithEvents lblCUDownload As System.Windows.Forms.Label
End Class
