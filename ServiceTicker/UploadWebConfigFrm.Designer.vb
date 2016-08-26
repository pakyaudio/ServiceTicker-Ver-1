<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadWebConfigFrm
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
        Me.txtUWChost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUWCport = New System.Windows.Forms.TextBox()
        Me.txtUWCusername = New System.Windows.Forms.TextBox()
        Me.txtUWCpassword = New System.Windows.Forms.TextBox()
        Me.btnUWCtest = New System.Windows.Forms.Button()
        Me.btnUWCsave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtUWCdirectory = New System.Windows.Forms.TextBox()
        Me.lvDirectory = New System.Windows.Forms.ListView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnUWCupload = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUWChost
        '
        Me.txtUWChost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUWChost.Location = New System.Drawing.Point(54, 3)
        Me.txtUWChost.Name = "txtUWChost"
        Me.txtUWChost.Size = New System.Drawing.Size(373, 26)
        Me.txtUWChost.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtUWChost, "เช่น ftp.patechgroup.net")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Host"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "UserName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(273, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(433, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Port"
        '
        'txtUWCport
        '
        Me.txtUWCport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUWCport.Location = New System.Drawing.Point(471, 3)
        Me.txtUWCport.Name = "txtUWCport"
        Me.txtUWCport.Size = New System.Drawing.Size(54, 26)
        Me.txtUWCport.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtUWCport, "เช่น 21")
        '
        'txtUWCusername
        '
        Me.txtUWCusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUWCusername.Location = New System.Drawing.Point(92, 28)
        Me.txtUWCusername.Name = "txtUWCusername"
        Me.txtUWCusername.Size = New System.Drawing.Size(175, 26)
        Me.txtUWCusername.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtUWCusername, "เช่น webmaster@patechgroup.net")
        '
        'txtUWCpassword
        '
        Me.txtUWCpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUWCpassword.Location = New System.Drawing.Point(347, 28)
        Me.txtUWCpassword.Name = "txtUWCpassword"
        Me.txtUWCpassword.Size = New System.Drawing.Size(178, 26)
        Me.txtUWCpassword.TabIndex = 7
        Me.txtUWCpassword.UseSystemPasswordChar = True
        '
        'btnUWCtest
        '
        Me.btnUWCtest.Location = New System.Drawing.Point(369, 60)
        Me.btnUWCtest.Name = "btnUWCtest"
        Me.btnUWCtest.Size = New System.Drawing.Size(75, 23)
        Me.btnUWCtest.TabIndex = 8
        Me.btnUWCtest.Text = "ทดสอบ"
        Me.btnUWCtest.UseVisualStyleBackColor = True
        '
        'btnUWCsave
        '
        Me.btnUWCsave.Location = New System.Drawing.Point(450, 60)
        Me.btnUWCsave.Name = "btnUWCsave"
        Me.btnUWCsave.Size = New System.Drawing.Size(75, 23)
        Me.btnUWCsave.TabIndex = 9
        Me.btnUWCsave.Text = "บันทึก"
        Me.btnUWCsave.UseVisualStyleBackColor = True
        '
        'txtUWCdirectory
        '
        Me.txtUWCdirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUWCdirectory.Location = New System.Drawing.Point(74, 53)
        Me.txtUWCdirectory.Name = "txtUWCdirectory"
        Me.txtUWCdirectory.Size = New System.Drawing.Size(289, 26)
        Me.txtUWCdirectory.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtUWCdirectory, "เช่น webmaster@patechgroup.net")
        '
        'lvDirectory
        '
        Me.lvDirectory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvDirectory.Location = New System.Drawing.Point(9, 177)
        Me.lvDirectory.Name = "lvDirectory"
        Me.lvDirectory.Size = New System.Drawing.Size(516, 188)
        Me.lvDirectory.TabIndex = 10
        Me.lvDirectory.UseCompatibleStateImageBehavior = False
        Me.lvDirectory.View = System.Windows.Forms.View.Details
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Directory"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ไดเรกทอรี่"
        Me.ColumnHeader1.Width = 200
        '
        'btnUWCupload
        '
        Me.btnUWCupload.Location = New System.Drawing.Point(450, 89)
        Me.btnUWCupload.Name = "btnUWCupload"
        Me.btnUWCupload.Size = New System.Drawing.Size(75, 23)
        Me.btnUWCupload.TabIndex = 13
        Me.btnUWCupload.Text = "อัพโหลด"
        Me.btnUWCupload.UseVisualStyleBackColor = True
        '
        'UploadWebConfigFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 377)
        Me.Controls.Add(Me.btnUWCupload)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUWCdirectory)
        Me.Controls.Add(Me.lvDirectory)
        Me.Controls.Add(Me.btnUWCsave)
        Me.Controls.Add(Me.btnUWCtest)
        Me.Controls.Add(Me.txtUWCpassword)
        Me.Controls.Add(Me.txtUWCusername)
        Me.Controls.Add(Me.txtUWCport)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUWChost)
        Me.Name = "UploadWebConfigFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ตั้งค่าการอัพโหลดข้อมูลตรวจสอบสถานะงานซ่อม"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUWChost As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUWCport As System.Windows.Forms.TextBox
    Friend WithEvents txtUWCusername As System.Windows.Forms.TextBox
    Friend WithEvents txtUWCpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnUWCtest As System.Windows.Forms.Button
    Friend WithEvents btnUWCsave As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lvDirectory As System.Windows.Forms.ListView
    Friend WithEvents txtUWCdirectory As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnUWCupload As System.Windows.Forms.Button
End Class
