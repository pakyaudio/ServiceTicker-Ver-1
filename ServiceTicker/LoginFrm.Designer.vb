<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFrm))
        Me.btnLoginOK = New System.Windows.Forms.Button()
        Me.txtLoginUsername = New System.Windows.Forms.TextBox()
        Me.btnLoginCancel = New System.Windows.Forms.Button()
        Me.txtLoginPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLoginVersion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLoginCompanyname = New System.Windows.Forms.Label()
        Me.ToolTipLogin = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLGshowpass = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoginOK
        '
        Me.btnLoginOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLoginOK.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnLoginOK.Location = New System.Drawing.Point(200, 142)
        Me.btnLoginOK.Name = "btnLoginOK"
        Me.btnLoginOK.Size = New System.Drawing.Size(152, 49)
        Me.btnLoginOK.TabIndex = 2
        Me.btnLoginOK.Text = "ตกลง"
        Me.btnLoginOK.UseVisualStyleBackColor = True
        '
        'txtLoginUsername
        '
        Me.txtLoginUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLoginUsername.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtLoginUsername.Location = New System.Drawing.Point(292, 54)
        Me.txtLoginUsername.Name = "txtLoginUsername"
        Me.txtLoginUsername.Size = New System.Drawing.Size(227, 31)
        Me.txtLoginUsername.TabIndex = 0
        Me.ToolTipLogin.SetToolTip(Me.txtLoginUsername, "ชื่อผู้ใช้งาน")
        '
        'btnLoginCancel
        '
        Me.btnLoginCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLoginCancel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnLoginCancel.Location = New System.Drawing.Point(367, 142)
        Me.btnLoginCancel.Name = "btnLoginCancel"
        Me.btnLoginCancel.Size = New System.Drawing.Size(152, 49)
        Me.btnLoginCancel.TabIndex = 3
        Me.btnLoginCancel.Text = "ยกเลิก"
        Me.btnLoginCancel.UseVisualStyleBackColor = True
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLoginPassword.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtLoginPassword.Location = New System.Drawing.Point(292, 91)
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.Size = New System.Drawing.Size(184, 31)
        Me.txtLoginPassword.TabIndex = 1
        Me.ToolTipLogin.SetToolTip(Me.txtLoginPassword, "รหัสผ่าน")
        Me.txtLoginPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(173, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "UserName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(180, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'lblLoginVersion
        '
        Me.lblLoginVersion.AutoSize = True
        Me.lblLoginVersion.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblLoginVersion.Location = New System.Drawing.Point(12, 199)
        Me.lblLoginVersion.Name = "lblLoginVersion"
        Me.lblLoginVersion.Size = New System.Drawing.Size(13, 13)
        Me.lblLoginVersion.TabIndex = 7
        Me.lblLoginVersion.Text = ".."
        Me.lblLoginVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(9, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'lblLoginCompanyname
        '
        Me.lblLoginCompanyname.AutoSize = True
        Me.lblLoginCompanyname.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLoginCompanyname.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblLoginCompanyname.Location = New System.Drawing.Point(12, 9)
        Me.lblLoginCompanyname.Name = "lblLoginCompanyname"
        Me.lblLoginCompanyname.Size = New System.Drawing.Size(198, 31)
        Me.lblLoginCompanyname.TabIndex = 9
        Me.lblLoginCompanyname.Text = "company name"
        '
        'ToolTipLogin
        '
        Me.ToolTipLogin.AutoPopDelay = 5000
        Me.ToolTipLogin.InitialDelay = 300
        Me.ToolTipLogin.IsBalloon = True
        Me.ToolTipLogin.ReshowDelay = 300
        '
        'btnLGshowpass
        '
        Me.btnLGshowpass.Image = Global.ServiceTicker.My.Resources.Resources.index
        Me.btnLGshowpass.Location = New System.Drawing.Point(482, 91)
        Me.btnLGshowpass.Name = "btnLGshowpass"
        Me.btnLGshowpass.Size = New System.Drawing.Size(37, 31)
        Me.btnLGshowpass.TabIndex = 10
        Me.ToolTipLogin.SetToolTip(Me.btnLGshowpass, "แสดง/ซ่อน รหัสผ่าน")
        Me.btnLGshowpass.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'LoginFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(526, 217)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLGshowpass)
        Me.Controls.Add(Me.lblLoginCompanyname)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblLoginVersion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLoginPassword)
        Me.Controls.Add(Me.btnLoginCancel)
        Me.Controls.Add(Me.txtLoginUsername)
        Me.Controls.Add(Me.btnLoginOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginFrm"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เข้าระบบ"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoginOK As System.Windows.Forms.Button
    Friend WithEvents txtLoginUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnLoginCancel As System.Windows.Forms.Button
    Friend WithEvents txtLoginPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblLoginVersion As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLoginCompanyname As System.Windows.Forms.Label
    Friend WithEvents ToolTipLogin As System.Windows.Forms.ToolTip
    Friend WithEvents btnLGshowpass As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
