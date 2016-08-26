<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateWebFrm
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
        Me.txtUDWhost = New System.Windows.Forms.TextBox()
        Me.txtUDWusername = New System.Windows.Forms.TextBox()
        Me.txtUDWpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTipUDW = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtUDWfolder = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUDWhost
        '
        Me.txtUDWhost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUDWhost.Location = New System.Drawing.Point(73, 29)
        Me.txtUDWhost.Name = "txtUDWhost"
        Me.txtUDWhost.Size = New System.Drawing.Size(207, 26)
        Me.txtUDWhost.TabIndex = 0
        Me.ToolTipUDW.SetToolTip(Me.txtUDWhost, "ex. ftp://ftp.webhost.com")
        '
        'txtUDWusername
        '
        Me.txtUDWusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUDWusername.Location = New System.Drawing.Point(73, 61)
        Me.txtUDWusername.Name = "txtUDWusername"
        Me.txtUDWusername.Size = New System.Drawing.Size(207, 26)
        Me.txtUDWusername.TabIndex = 1
        Me.ToolTipUDW.SetToolTip(Me.txtUDWusername, "ex. username@webhost.com")
        '
        'txtUDWpassword
        '
        Me.txtUDWpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUDWpassword.Location = New System.Drawing.Point(73, 93)
        Me.txtUDWpassword.Name = "txtUDWpassword"
        Me.txtUDWpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUDWpassword.Size = New System.Drawing.Size(207, 26)
        Me.txtUDWpassword.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Host"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "ทดสอบเชื่อมต่อ"
        Me.ToolTipUDW.SetToolTip(Me.Button1, "ทดสอบผ่านจะบันทึกข้อมูลการเชื่อมต่อลงฐษนข้อมูล")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ข้อมูล FTP Host"
        '
        'ToolTipUDW
        '
        Me.ToolTipUDW.IsBalloon = True
        '
        'txtUDWfolder
        '
        Me.txtUDWfolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUDWfolder.Location = New System.Drawing.Point(328, 29)
        Me.txtUDWfolder.Name = "txtUDWfolder"
        Me.txtUDWfolder.Size = New System.Drawing.Size(207, 26)
        Me.txtUDWfolder.TabIndex = 10
        Me.ToolTipUDW.SetToolTip(Me.txtUDWfolder, "ex. /htdocs/xxx")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Folder"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(73, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "อัพเดทเว็บ"
        Me.ToolTipUDW.SetToolTip(Me.Button2, "ทดสอบผ่านจะบันทึกข้อมูลการเชื่อมต่อลงฐษนข้อมูล")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UpdateWebFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 182)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUDWfolder)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUDWpassword)
        Me.Controls.Add(Me.txtUDWusername)
        Me.Controls.Add(Me.txtUDWhost)
        Me.Name = "UpdateWebFrm"
        Me.Text = "อัพเดทข้อมูลขึ้นเว็บไซต์"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUDWhost As System.Windows.Forms.TextBox
    Friend WithEvents txtUDWusername As System.Windows.Forms.TextBox
    Friend WithEvents txtUDWpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTipUDW As System.Windows.Forms.ToolTip
    Friend WithEvents txtUDWfolder As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
