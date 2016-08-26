<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBaseConnectFrm
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
        Me.btnDBCsace = New System.Windows.Forms.Button()
        Me.txtDBCservername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDBCdatabasename = New System.Windows.Forms.TextBox()
        Me.btnDBCtest = New System.Windows.Forms.Button()
        Me.btnDBCcancel = New System.Windows.Forms.Button()
        Me.txtDBCusername = New System.Windows.Forms.TextBox()
        Me.txtDBCpassword = New System.Windows.Forms.TextBox()
        Me.txtDBCport = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblemployee = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDBCsace
        '
        Me.btnDBCsace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDBCsace.Location = New System.Drawing.Point(111, 155)
        Me.btnDBCsace.Name = "btnDBCsace"
        Me.btnDBCsace.Size = New System.Drawing.Size(75, 23)
        Me.btnDBCsace.TabIndex = 0
        Me.btnDBCsace.Text = "บันทึก"
        Me.btnDBCsace.UseVisualStyleBackColor = True
        '
        'txtDBCservername
        '
        Me.txtDBCservername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDBCservername.Location = New System.Drawing.Point(125, 17)
        Me.txtDBCservername.Name = "txtDBCservername"
        Me.txtDBCservername.Size = New System.Drawing.Size(137, 22)
        Me.txtDBCservername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Server Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data Base Name"
        '
        'txtDBCdatabasename
        '
        Me.txtDBCdatabasename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDBCdatabasename.Location = New System.Drawing.Point(125, 43)
        Me.txtDBCdatabasename.Name = "txtDBCdatabasename"
        Me.txtDBCdatabasename.Size = New System.Drawing.Size(137, 22)
        Me.txtDBCdatabasename.TabIndex = 4
        '
        'btnDBCtest
        '
        Me.btnDBCtest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDBCtest.Location = New System.Drawing.Point(30, 155)
        Me.btnDBCtest.Name = "btnDBCtest"
        Me.btnDBCtest.Size = New System.Drawing.Size(75, 23)
        Me.btnDBCtest.TabIndex = 5
        Me.btnDBCtest.Text = "ทดสอบ"
        Me.btnDBCtest.UseVisualStyleBackColor = True
        '
        'btnDBCcancel
        '
        Me.btnDBCcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDBCcancel.Location = New System.Drawing.Point(294, 155)
        Me.btnDBCcancel.Name = "btnDBCcancel"
        Me.btnDBCcancel.Size = New System.Drawing.Size(75, 23)
        Me.btnDBCcancel.TabIndex = 6
        Me.btnDBCcancel.Text = "ยกเลิก"
        Me.btnDBCcancel.UseVisualStyleBackColor = True
        '
        'txtDBCusername
        '
        Me.txtDBCusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDBCusername.Location = New System.Drawing.Point(125, 69)
        Me.txtDBCusername.Name = "txtDBCusername"
        Me.txtDBCusername.Size = New System.Drawing.Size(137, 22)
        Me.txtDBCusername.TabIndex = 7
        '
        'txtDBCpassword
        '
        Me.txtDBCpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDBCpassword.Location = New System.Drawing.Point(125, 95)
        Me.txtDBCpassword.Name = "txtDBCpassword"
        Me.txtDBCpassword.Size = New System.Drawing.Size(137, 22)
        Me.txtDBCpassword.TabIndex = 8
        Me.txtDBCpassword.UseSystemPasswordChar = True
        '
        'txtDBCport
        '
        Me.txtDBCport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDBCport.Location = New System.Drawing.Point(125, 121)
        Me.txtDBCport.Name = "txtDBCport"
        Me.txtDBCport.Size = New System.Drawing.Size(137, 22)
        Me.txtDBCport.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "User Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(87, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Prot"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(267, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(250, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ชื่อเครื่องแม่ข่ายถ้าใช้ในเครื่องกำหนดเป็น localhost"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(267, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "ชื่อฐานข้อมูล ค่าปกติคือ serviceticker"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(267, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "ชื่อล็อกอินฐานข้อมูลค่าปกติคือ root"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(267, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "รหัสผ่าน"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(267, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(228, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "หมายเลขพ็อตที่ใช้เชื่อมต่อปกติกำหนดเป็น 3306"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(192, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "นำเข้าฐานข้อมูล"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(7, 187)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 19
        Me.lblemployee.Text = "User"
        '
        'DataBaseConnectFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 209)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDBCport)
        Me.Controls.Add(Me.txtDBCpassword)
        Me.Controls.Add(Me.txtDBCusername)
        Me.Controls.Add(Me.btnDBCcancel)
        Me.Controls.Add(Me.btnDBCtest)
        Me.Controls.Add(Me.txtDBCdatabasename)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDBCservername)
        Me.Controls.Add(Me.btnDBCsace)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DataBaseConnectFrm"
        Me.Text = "เชื่อมต่อฐานข้อมูล"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDBCsace As System.Windows.Forms.Button
    Friend WithEvents txtDBCservername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDBCdatabasename As System.Windows.Forms.TextBox
    Friend WithEvents btnDBCtest As System.Windows.Forms.Button
    Friend WithEvents btnDBCcancel As System.Windows.Forms.Button
    Friend WithEvents txtDBCusername As System.Windows.Forms.TextBox
    Friend WithEvents txtDBCpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtDBCport As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
