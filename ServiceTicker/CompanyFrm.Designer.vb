<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyFrm
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
        Me.lblCompanyImagePath = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCompanyCancel = New System.Windows.Forms.Button()
        Me.btnCompanyEdit = New System.Windows.Forms.Button()
        Me.txtCompanyTax = New System.Windows.Forms.TextBox()
        Me.txtCompanyFax = New System.Windows.Forms.TextBox()
        Me.txtCompanyTel = New System.Windows.Forms.TextBox()
        Me.txtCompanyAddress = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblCompanyTax = New System.Windows.Forms.Label()
        Me.lblCompanyFax = New System.Windows.Forms.Label()
        Me.lblCompanyTel = New System.Windows.Forms.Label()
        Me.lblCompanyAddress = New System.Windows.Forms.Label()
        Me.lblcompanyname = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTipCompany = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCompanyLine = New System.Windows.Forms.TextBox()
        Me.txtCompanyFacebook = New System.Windows.Forms.TextBox()
        Me.txtCompanyEmail = New System.Windows.Forms.TextBox()
        Me.txtCompanyWebsite = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblEmployee = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCompanyImagePath
        '
        Me.lblCompanyImagePath.AutoSize = True
        Me.lblCompanyImagePath.Location = New System.Drawing.Point(369, 160)
        Me.lblCompanyImagePath.Name = "lblCompanyImagePath"
        Me.lblCompanyImagePath.Size = New System.Drawing.Size(28, 13)
        Me.lblCompanyImagePath.TabIndex = 39
        Me.lblCompanyImagePath.Text = "path"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "โลโก้"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(398, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 135)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        Me.ToolTipCompany.SetToolTip(Me.PictureBox1, "รูปนี้จะปรากฎในบิลต่างๆ")
        '
        'btnCompanyCancel
        '
        Me.btnCompanyCancel.Location = New System.Drawing.Point(279, 373)
        Me.btnCompanyCancel.Name = "btnCompanyCancel"
        Me.btnCompanyCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCompanyCancel.TabIndex = 32
        Me.btnCompanyCancel.Text = "&ยกเลิก"
        Me.btnCompanyCancel.UseVisualStyleBackColor = True
        '
        'btnCompanyEdit
        '
        Me.btnCompanyEdit.Location = New System.Drawing.Point(198, 373)
        Me.btnCompanyEdit.Name = "btnCompanyEdit"
        Me.btnCompanyEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnCompanyEdit.TabIndex = 31
        Me.btnCompanyEdit.Text = "&แก้ไข"
        Me.btnCompanyEdit.UseVisualStyleBackColor = True
        '
        'txtCompanyTax
        '
        Me.txtCompanyTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyTax.Location = New System.Drawing.Point(15, 206)
        Me.txtCompanyTax.Name = "txtCompanyTax"
        Me.txtCompanyTax.Size = New System.Drawing.Size(339, 26)
        Me.txtCompanyTax.TabIndex = 30
        Me.ToolTipCompany.SetToolTip(Me.txtCompanyTax, "หมายเลขผู้เสียภาษีของร้าน บริษัท")
        '
        'txtCompanyFax
        '
        Me.txtCompanyFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyFax.Location = New System.Drawing.Point(15, 160)
        Me.txtCompanyFax.Name = "txtCompanyFax"
        Me.txtCompanyFax.Size = New System.Drawing.Size(339, 26)
        Me.txtCompanyFax.TabIndex = 29
        Me.ToolTipCompany.SetToolTip(Me.txtCompanyFax, "เบอร์แฟกซ์ร้าน บริษัท")
        '
        'txtCompanyTel
        '
        Me.txtCompanyTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyTel.Location = New System.Drawing.Point(15, 115)
        Me.txtCompanyTel.Name = "txtCompanyTel"
        Me.txtCompanyTel.Size = New System.Drawing.Size(339, 26)
        Me.txtCompanyTel.TabIndex = 28
        Me.ToolTipCompany.SetToolTip(Me.txtCompanyTel, "เบอร์โทรศัพท์สำหรับติดต่อร้าน บริษัท")
        '
        'txtCompanyAddress
        '
        Me.txtCompanyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyAddress.Location = New System.Drawing.Point(15, 70)
        Me.txtCompanyAddress.Name = "txtCompanyAddress"
        Me.txtCompanyAddress.Size = New System.Drawing.Size(339, 26)
        Me.txtCompanyAddress.TabIndex = 27
        Me.ToolTipCompany.SetToolTip(Me.txtCompanyAddress, "ที่อยู่ร้าน ที่อยู่บริษัท")
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyName.Location = New System.Drawing.Point(15, 25)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(339, 26)
        Me.txtCompanyName.TabIndex = 26
        Me.ToolTipCompany.SetToolTip(Me.txtCompanyName, "ชื่อร้าน ชื่อบริษัท")
        '
        'lblCompanyTax
        '
        Me.lblCompanyTax.AutoSize = True
        Me.lblCompanyTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCompanyTax.Location = New System.Drawing.Point(12, 190)
        Me.lblCompanyTax.Name = "lblCompanyTax"
        Me.lblCompanyTax.Size = New System.Drawing.Size(95, 13)
        Me.lblCompanyTax.TabIndex = 25
        Me.lblCompanyTax.Text = "หมายเลขผู้เสียภาษี"
        '
        'lblCompanyFax
        '
        Me.lblCompanyFax.AutoSize = True
        Me.lblCompanyFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCompanyFax.Location = New System.Drawing.Point(12, 144)
        Me.lblCompanyFax.Name = "lblCompanyFax"
        Me.lblCompanyFax.Size = New System.Drawing.Size(37, 13)
        Me.lblCompanyFax.TabIndex = 24
        Me.lblCompanyFax.Text = "แฟกซ์"
        '
        'lblCompanyTel
        '
        Me.lblCompanyTel.AutoSize = True
        Me.lblCompanyTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCompanyTel.Location = New System.Drawing.Point(12, 99)
        Me.lblCompanyTel.Name = "lblCompanyTel"
        Me.lblCompanyTel.Size = New System.Drawing.Size(72, 13)
        Me.lblCompanyTel.TabIndex = 23
        Me.lblCompanyTel.Text = "เบอร์โทรศัพท์"
        '
        'lblCompanyAddress
        '
        Me.lblCompanyAddress.AutoSize = True
        Me.lblCompanyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCompanyAddress.Location = New System.Drawing.Point(12, 54)
        Me.lblCompanyAddress.Name = "lblCompanyAddress"
        Me.lblCompanyAddress.Size = New System.Drawing.Size(27, 13)
        Me.lblCompanyAddress.TabIndex = 22
        Me.lblCompanyAddress.Text = "ที่อยู่"
        '
        'lblcompanyname
        '
        Me.lblcompanyname.AutoSize = True
        Me.lblcompanyname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblcompanyname.Location = New System.Drawing.Point(12, 9)
        Me.lblcompanyname.Name = "lblcompanyname"
        Me.lblcompanyname.Size = New System.Drawing.Size(102, 13)
        Me.lblcompanyname.TabIndex = 21
        Me.lblcompanyname.Text = "ชื่อสถานประกอบการ"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolTipCompany
        '
        Me.ToolTipCompany.AutoPopDelay = 5000
        Me.ToolTipCompany.InitialDelay = 300
        Me.ToolTipCompany.IsBalloon = True
        Me.ToolTipCompany.ReshowDelay = 300
        '
        'txtCompanyLine
        '
        Me.txtCompanyLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyLine.Location = New System.Drawing.Point(15, 251)
        Me.txtCompanyLine.MaxLength = 100
        Me.txtCompanyLine.Name = "txtCompanyLine"
        Me.txtCompanyLine.Size = New System.Drawing.Size(163, 26)
        Me.txtCompanyLine.TabIndex = 49
        Me.ToolTipCompany.SetToolTip(Me.txtCompanyLine, "ไลท์ไอดี")
        '
        'txtCompanyFacebook
        '
        Me.txtCompanyFacebook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyFacebook.Location = New System.Drawing.Point(184, 251)
        Me.txtCompanyFacebook.MaxLength = 100
        Me.txtCompanyFacebook.Name = "txtCompanyFacebook"
        Me.txtCompanyFacebook.Size = New System.Drawing.Size(170, 26)
        Me.txtCompanyFacebook.TabIndex = 51
        Me.ToolTipCompany.SetToolTip(Me.txtCompanyFacebook, "เฟสบุ๊คร้าน บริษัท")
        '
        'txtCompanyEmail
        '
        Me.txtCompanyEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyEmail.Location = New System.Drawing.Point(15, 296)
        Me.txtCompanyEmail.MaxLength = 100
        Me.txtCompanyEmail.Name = "txtCompanyEmail"
        Me.txtCompanyEmail.Size = New System.Drawing.Size(339, 26)
        Me.txtCompanyEmail.TabIndex = 53
        Me.ToolTipCompany.SetToolTip(Me.txtCompanyEmail, "อีเมล์สำหรับติดต่อร้าน บริษัท")
        '
        'txtCompanyWebsite
        '
        Me.txtCompanyWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyWebsite.Location = New System.Drawing.Point(15, 341)
        Me.txtCompanyWebsite.MaxLength = 100
        Me.txtCompanyWebsite.Name = "txtCompanyWebsite"
        Me.txtCompanyWebsite.Size = New System.Drawing.Size(339, 26)
        Me.txtCompanyWebsite.TabIndex = 55
        Me.ToolTipCompany.SetToolTip(Me.txtCompanyWebsite, "เว็บไซต์ร้าน บริษัท")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Line ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(181, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Facebook"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "E-Mail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "WebSite"
        '
        'lblEmployee
        '
        Me.lblEmployee.AutoSize = True
        Me.lblEmployee.Location = New System.Drawing.Point(14, 378)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(29, 13)
        Me.lblEmployee.TabIndex = 56
        Me.lblEmployee.Text = "User"
        '
        'CompanyFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 406)
        Me.Controls.Add(Me.lblEmployee)
        Me.Controls.Add(Me.txtCompanyWebsite)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCompanyEmail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCompanyFacebook)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCompanyLine)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblCompanyImagePath)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCompanyCancel)
        Me.Controls.Add(Me.btnCompanyEdit)
        Me.Controls.Add(Me.txtCompanyTax)
        Me.Controls.Add(Me.txtCompanyFax)
        Me.Controls.Add(Me.txtCompanyTel)
        Me.Controls.Add(Me.txtCompanyAddress)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.lblCompanyTax)
        Me.Controls.Add(Me.lblCompanyFax)
        Me.Controls.Add(Me.lblCompanyTel)
        Me.Controls.Add(Me.lblCompanyAddress)
        Me.Controls.Add(Me.lblcompanyname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CompanyFrm"
        Me.Text = "ข้อมูลสถานประกอบการ"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCompanyImagePath As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCompanyCancel As System.Windows.Forms.Button
    Friend WithEvents btnCompanyEdit As System.Windows.Forms.Button
    Friend WithEvents txtCompanyTax As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyFax As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyTel As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents lblCompanyTax As System.Windows.Forms.Label
    Friend WithEvents lblCompanyFax As System.Windows.Forms.Label
    Friend WithEvents lblCompanyTel As System.Windows.Forms.Label
    Friend WithEvents lblCompanyAddress As System.Windows.Forms.Label
    Friend WithEvents lblcompanyname As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTipCompany As System.Windows.Forms.ToolTip
    Friend WithEvents txtCompanyLine As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyFacebook As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyWebsite As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblEmployee As System.Windows.Forms.Label
End Class
