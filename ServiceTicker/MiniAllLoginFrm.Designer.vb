<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiniAllLoginFrm
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
        Me.ToolTipML = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblMLusername = New System.Windows.Forms.Label()
        Me.btnshowpass = New System.Windows.Forms.Button()
        Me.lblMLpassword = New System.Windows.Forms.Label()
        Me.txtMLUpassword = New System.Windows.Forms.TextBox()
        Me.txtMLUusername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMLUok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ToolTipML
        '
        Me.ToolTipML.AutoPopDelay = 5000
        Me.ToolTipML.InitialDelay = 500
        Me.ToolTipML.IsBalloon = True
        Me.ToolTipML.ReshowDelay = 100
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 6500
        '
        'lblMLusername
        '
        Me.lblMLusername.AutoSize = True
        Me.lblMLusername.Location = New System.Drawing.Point(9, 9)
        Me.lblMLusername.Name = "lblMLusername"
        Me.lblMLusername.Size = New System.Drawing.Size(58, 13)
        Me.lblMLusername.TabIndex = 21
        Me.lblMLusername.Text = "ชื่อผู้ใช้งาน"
        '
        'btnshowpass
        '
        Me.btnshowpass.Location = New System.Drawing.Point(307, 26)
        Me.btnshowpass.Name = "btnshowpass"
        Me.btnshowpass.Size = New System.Drawing.Size(15, 29)
        Me.btnshowpass.TabIndex = 20
        Me.btnshowpass.Text = "<"
        Me.btnshowpass.UseVisualStyleBackColor = True
        '
        'lblMLpassword
        '
        Me.lblMLpassword.AutoSize = True
        Me.lblMLpassword.Location = New System.Drawing.Point(170, 9)
        Me.lblMLpassword.Name = "lblMLpassword"
        Me.lblMLpassword.Size = New System.Drawing.Size(46, 13)
        Me.lblMLpassword.TabIndex = 19
        Me.lblMLpassword.Text = "รหัสผ่าน"
        '
        'txtMLUpassword
        '
        Me.txtMLUpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMLUpassword.Location = New System.Drawing.Point(170, 25)
        Me.txtMLUpassword.Name = "txtMLUpassword"
        Me.txtMLUpassword.Size = New System.Drawing.Size(131, 29)
        Me.txtMLUpassword.TabIndex = 16
        Me.txtMLUpassword.UseSystemPasswordChar = True
        '
        'txtMLUusername
        '
        Me.txtMLUusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMLUusername.Location = New System.Drawing.Point(12, 25)
        Me.txtMLUusername.Name = "txtMLUusername"
        Me.txtMLUusername.Size = New System.Drawing.Size(152, 29)
        Me.txtMLUusername.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ยืนยันตัวตนก่อนเข้าใช้งานบางส่วนของโปรแกรม"
        '
        'btnMLUok
        '
        Me.btnMLUok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMLUok.Location = New System.Drawing.Point(328, 26)
        Me.btnMLUok.Name = "btnMLUok"
        Me.btnMLUok.Size = New System.Drawing.Size(79, 29)
        Me.btnMLUok.TabIndex = 18
        Me.btnMLUok.Text = "ตกลง"
        Me.btnMLUok.UseVisualStyleBackColor = True
        '
        'MiniAllLoginFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 81)
        Me.Controls.Add(Me.lblMLusername)
        Me.Controls.Add(Me.btnshowpass)
        Me.Controls.Add(Me.lblMLpassword)
        Me.Controls.Add(Me.txtMLUpassword)
        Me.Controls.Add(Me.txtMLUusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMLUok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MiniAllLoginFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ยืนยันตัวตน"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTipML As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblMLusername As System.Windows.Forms.Label
    Friend WithEvents btnshowpass As System.Windows.Forms.Button
    Friend WithEvents lblMLpassword As System.Windows.Forms.Label
    Friend WithEvents txtMLUpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtMLUusername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMLUok As System.Windows.Forms.Button
End Class
