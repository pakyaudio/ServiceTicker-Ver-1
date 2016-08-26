<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersFrm
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
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblUserNote = New System.Windows.Forms.Label()
        Me.dgUser = New System.Windows.Forms.DataGridView()
        Me.btnUserEdit = New System.Windows.Forms.Button()
        Me.lblUserNameLogin = New System.Windows.Forms.Label()
        Me.txtUsernamelogin = New System.Windows.Forms.TextBox()
        Me.btnUserCancel = New System.Windows.Forms.Button()
        Me.btnUserDel = New System.Windows.Forms.Button()
        Me.btnUserAdd = New System.Windows.Forms.Button()
        Me.lblUserPassword = New System.Windows.Forms.Label()
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.lblUserTel = New System.Windows.Forms.Label()
        Me.lblUserAddress = New System.Windows.Forms.Label()
        Me.txtUserPassword = New System.Windows.Forms.TextBox()
        Me.txtUserEmail = New System.Windows.Forms.TextBox()
        Me.txtUserTel = New System.Windows.Forms.TextBox()
        Me.txtUserAddress = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.ToolTipUser = New System.Windows.Forms.ToolTip(Me.components)
        Me.GBusers = New System.Windows.Forms.GroupBox()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.lblemployee = New System.Windows.Forms.Label()
        Me.txtUserPasswordC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBusers.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(101, 9)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(26, 20)
        Me.lblUserID.TabIndex = 44
        Me.lblUserID.Text = "&ID"
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(133, 6)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(163, 26)
        Me.txtUserID.TabIndex = 43
        '
        'lblUserNote
        '
        Me.lblUserNote.AutoSize = True
        Me.lblUserNote.ForeColor = System.Drawing.Color.Red
        Me.lblUserNote.Location = New System.Drawing.Point(302, 9)
        Me.lblUserNote.Name = "lblUserNote"
        Me.lblUserNote.Size = New System.Drawing.Size(225, 13)
        Me.lblUserNote.TabIndex = 42
        Me.lblUserNote.Text = "*ดับเบิ้ลคลิ๊กเลือกที่ตารางเพื่อแก้ไขหรือลบข้อมูล"
        '
        'dgUser
        '
        Me.dgUser.AllowUserToAddRows = False
        Me.dgUser.AllowUserToDeleteRows = False
        Me.dgUser.AllowUserToOrderColumns = True
        Me.dgUser.AllowUserToResizeColumns = False
        Me.dgUser.AllowUserToResizeRows = False
        Me.dgUser.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUser.Location = New System.Drawing.Point(302, 28)
        Me.dgUser.Name = "dgUser"
        Me.dgUser.ReadOnly = True
        Me.dgUser.RowHeadersVisible = False
        Me.dgUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUser.ShowRowErrors = False
        Me.dgUser.Size = New System.Drawing.Size(362, 196)
        Me.dgUser.TabIndex = 41
        '
        'btnUserEdit
        '
        Me.btnUserEdit.Location = New System.Drawing.Point(427, 273)
        Me.btnUserEdit.Name = "btnUserEdit"
        Me.btnUserEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnUserEdit.TabIndex = 10
        Me.btnUserEdit.Text = "&แก้ไข"
        Me.btnUserEdit.UseVisualStyleBackColor = True
        '
        'lblUserNameLogin
        '
        Me.lblUserNameLogin.AutoSize = True
        Me.lblUserNameLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserNameLogin.Location = New System.Drawing.Point(10, 170)
        Me.lblUserNameLogin.Name = "lblUserNameLogin"
        Me.lblUserNameLogin.Size = New System.Drawing.Size(162, 18)
        Me.lblUserNameLogin.TabIndex = 39
        Me.lblUserNameLogin.Text = "&ชื่อสำหรับเข้าระบบ(อังกฤษ)"
        '
        'txtUsernamelogin
        '
        Me.txtUsernamelogin.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtUsernamelogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUsernamelogin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUsernamelogin.Location = New System.Drawing.Point(178, 166)
        Me.txtUsernamelogin.Name = "txtUsernamelogin"
        Me.txtUsernamelogin.Size = New System.Drawing.Size(118, 26)
        Me.txtUsernamelogin.TabIndex = 4
        Me.ToolTipUser.SetToolTip(Me.txtUsernamelogin, "ชื่อสำหรับเข้าระบบควรใช้ตัวอักษรภาษาอังกฤษหรือตัวเลข")
        '
        'btnUserCancel
        '
        Me.btnUserCancel.Location = New System.Drawing.Point(589, 273)
        Me.btnUserCancel.Name = "btnUserCancel"
        Me.btnUserCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnUserCancel.TabIndex = 12
        Me.btnUserCancel.Text = "&ยกเลิก"
        Me.btnUserCancel.UseVisualStyleBackColor = True
        '
        'btnUserDel
        '
        Me.btnUserDel.Location = New System.Drawing.Point(508, 273)
        Me.btnUserDel.Name = "btnUserDel"
        Me.btnUserDel.Size = New System.Drawing.Size(75, 23)
        Me.btnUserDel.TabIndex = 11
        Me.btnUserDel.Text = "&ลบ"
        Me.btnUserDel.UseVisualStyleBackColor = True
        '
        'btnUserAdd
        '
        Me.btnUserAdd.Location = New System.Drawing.Point(344, 273)
        Me.btnUserAdd.Name = "btnUserAdd"
        Me.btnUserAdd.Size = New System.Drawing.Size(77, 23)
        Me.btnUserAdd.TabIndex = 9
        Me.btnUserAdd.Text = "&เพิ่ม"
        Me.btnUserAdd.UseVisualStyleBackColor = True
        '
        'lblUserPassword
        '
        Me.lblUserPassword.AutoSize = True
        Me.lblUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserPassword.Location = New System.Drawing.Point(49, 198)
        Me.lblUserPassword.Name = "lblUserPassword"
        Me.lblUserPassword.Size = New System.Drawing.Size(58, 20)
        Me.lblUserPassword.TabIndex = 34
        Me.lblUserPassword.Text = "&รหัสผ่าน"
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserEmail.Location = New System.Drawing.Point(86, 137)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(41, 20)
        Me.lblUserEmail.TabIndex = 33
        Me.lblUserEmail.Text = "&อีเมล์"
        '
        'lblUserTel
        '
        Me.lblUserTel.AutoSize = True
        Me.lblUserTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserTel.Location = New System.Drawing.Point(35, 105)
        Me.lblUserTel.Name = "lblUserTel"
        Me.lblUserTel.Size = New System.Drawing.Size(92, 20)
        Me.lblUserTel.TabIndex = 32
        Me.lblUserTel.Text = "&เบอร์โทรศัพท์"
        '
        'lblUserAddress
        '
        Me.lblUserAddress.AutoSize = True
        Me.lblUserAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserAddress.Location = New System.Drawing.Point(92, 73)
        Me.lblUserAddress.Name = "lblUserAddress"
        Me.lblUserAddress.Size = New System.Drawing.Size(35, 20)
        Me.lblUserAddress.TabIndex = 31
        Me.lblUserAddress.Text = "&ที่อยู่"
        '
        'txtUserPassword
        '
        Me.txtUserPassword.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserPassword.Location = New System.Drawing.Point(113, 195)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Size = New System.Drawing.Size(183, 26)
        Me.txtUserPassword.TabIndex = 5
        Me.txtUserPassword.UseSystemPasswordChar = True
        '
        'txtUserEmail
        '
        Me.txtUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserEmail.Location = New System.Drawing.Point(133, 134)
        Me.txtUserEmail.Name = "txtUserEmail"
        Me.txtUserEmail.Size = New System.Drawing.Size(163, 26)
        Me.txtUserEmail.TabIndex = 3
        '
        'txtUserTel
        '
        Me.txtUserTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserTel.Location = New System.Drawing.Point(133, 102)
        Me.txtUserTel.Name = "txtUserTel"
        Me.txtUserTel.Size = New System.Drawing.Size(163, 26)
        Me.txtUserTel.TabIndex = 2
        '
        'txtUserAddress
        '
        Me.txtUserAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserAddress.Location = New System.Drawing.Point(133, 70)
        Me.txtUserAddress.Name = "txtUserAddress"
        Me.txtUserAddress.Size = New System.Drawing.Size(163, 26)
        Me.txtUserAddress.TabIndex = 1
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(79, 41)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(48, 20)
        Me.lblUserName.TabIndex = 26
        Me.lblUserName.Text = "&ชื่อจริง"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(133, 38)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(163, 26)
        Me.txtUsername.TabIndex = 0
        '
        'ToolTipUser
        '
        Me.ToolTipUser.AutoPopDelay = 5000
        Me.ToolTipUser.InitialDelay = 300
        Me.ToolTipUser.IsBalloon = True
        Me.ToolTipUser.ReshowDelay = 300
        '
        'GBusers
        '
        Me.GBusers.Controls.Add(Me.RB3)
        Me.GBusers.Controls.Add(Me.RB2)
        Me.GBusers.Controls.Add(Me.RB1)
        Me.GBusers.Location = New System.Drawing.Point(13, 259)
        Me.GBusers.Name = "GBusers"
        Me.GBusers.Size = New System.Drawing.Size(283, 43)
        Me.GBusers.TabIndex = 48
        Me.GBusers.TabStop = False
        Me.GBusers.Text = "สิทธิการใช้งานระบบ"
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Location = New System.Drawing.Point(199, 20)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(78, 17)
        Me.RB3.TabIndex = 8
        Me.RB3.TabStop = True
        Me.RB3.Text = "ผู้ดูแลระบบ"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Location = New System.Drawing.Point(110, 20)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(58, 17)
        Me.RB2.TabIndex = 7
        Me.RB2.TabStop = True
        Me.RB2.Text = "หัวหน้า"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Checked = True
        Me.RB1.Location = New System.Drawing.Point(6, 20)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(63, 17)
        Me.RB1.TabIndex = 6
        Me.RB1.TabStop = True
        Me.RB1.Text = "ผู้ใช้งาน"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(299, 227)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 50
        Me.lblemployee.Text = "User"
        Me.lblemployee.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtUserPasswordC
        '
        Me.txtUserPasswordC.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtUserPasswordC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserPasswordC.Location = New System.Drawing.Point(113, 227)
        Me.txtUserPasswordC.Name = "txtUserPasswordC"
        Me.txtUserPasswordC.Size = New System.Drawing.Size(183, 26)
        Me.txtUserPasswordC.TabIndex = 51
        Me.txtUserPasswordC.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "&ยืนยันรหัสผ่าน"
        '
        'UsersFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 311)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUserPasswordC)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.GBusers)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblUserNote)
        Me.Controls.Add(Me.dgUser)
        Me.Controls.Add(Me.btnUserEdit)
        Me.Controls.Add(Me.lblUserNameLogin)
        Me.Controls.Add(Me.txtUsernamelogin)
        Me.Controls.Add(Me.btnUserCancel)
        Me.Controls.Add(Me.btnUserDel)
        Me.Controls.Add(Me.btnUserAdd)
        Me.Controls.Add(Me.lblUserPassword)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.lblUserTel)
        Me.Controls.Add(Me.lblUserAddress)
        Me.Controls.Add(Me.txtUserPassword)
        Me.Controls.Add(Me.txtUserEmail)
        Me.Controls.Add(Me.txtUserTel)
        Me.Controls.Add(Me.txtUserAddress)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtUsername)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UsersFrm"
        Me.Text = "ผู้ใช้งานโปรแกรม"
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBusers.ResumeLayout(False)
        Me.GBusers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblUserNote As System.Windows.Forms.Label
    Friend WithEvents dgUser As System.Windows.Forms.DataGridView
    Friend WithEvents btnUserEdit As System.Windows.Forms.Button
    Friend WithEvents lblUserNameLogin As System.Windows.Forms.Label
    Friend WithEvents txtUsernamelogin As System.Windows.Forms.TextBox
    Friend WithEvents btnUserCancel As System.Windows.Forms.Button
    Friend WithEvents btnUserDel As System.Windows.Forms.Button
    Friend WithEvents btnUserAdd As System.Windows.Forms.Button
    Friend WithEvents lblUserPassword As System.Windows.Forms.Label
    Friend WithEvents lblUserEmail As System.Windows.Forms.Label
    Friend WithEvents lblUserTel As System.Windows.Forms.Label
    Friend WithEvents lblUserAddress As System.Windows.Forms.Label
    Friend WithEvents txtUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtUserTel As System.Windows.Forms.TextBox
    Friend WithEvents txtUserAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipUser As System.Windows.Forms.ToolTip
    Friend WithEvents GBusers As System.Windows.Forms.GroupBox
    Friend WithEvents RB3 As System.Windows.Forms.RadioButton
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblemployee As System.Windows.Forms.Label
    Friend WithEvents txtUserPasswordC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
