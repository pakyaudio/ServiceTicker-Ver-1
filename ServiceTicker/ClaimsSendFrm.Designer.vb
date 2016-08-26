<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsSendFrm
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
        Me.txtCSclaims_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTipCS = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCScancel = New System.Windows.Forms.Button()
        Me.btnCSsave = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBCwarning = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCScom_addressZip = New System.Windows.Forms.TextBox()
        Me.txtCScom_addressJJ = New System.Windows.Forms.TextBox()
        Me.txtCScom_addressAOM = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCScom_contect = New System.Windows.Forms.TextBox()
        Me.txtCScom_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCScom_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCScom_address = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCSclaims_id
        '
        Me.txtCSclaims_id.Location = New System.Drawing.Point(12, 25)
        Me.txtCSclaims_id.Name = "txtCSclaims_id"
        Me.txtCSclaims_id.ReadOnly = True
        Me.txtCSclaims_id.Size = New System.Drawing.Size(127, 20)
        Me.txtCSclaims_id.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "หมายเลขเคลม"
        '
        'ToolTipCS
        '
        Me.ToolTipCS.IsBalloon = True
        '
        'btnCScancel
        '
        Me.btnCScancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCScancel.Location = New System.Drawing.Point(609, 186)
        Me.btnCScancel.Name = "btnCScancel"
        Me.btnCScancel.Size = New System.Drawing.Size(93, 40)
        Me.btnCScancel.TabIndex = 12
        Me.btnCScancel.Text = "ยกเลิก"
        Me.ToolTipCS.SetToolTip(Me.btnCScancel, "ค้นหารายชื่อบริษัท")
        Me.btnCScancel.UseVisualStyleBackColor = True
        '
        'btnCSsave
        '
        Me.btnCSsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCSsave.Location = New System.Drawing.Point(510, 186)
        Me.btnCSsave.Name = "btnCSsave"
        Me.btnCSsave.Size = New System.Drawing.Size(93, 40)
        Me.btnCSsave.TabIndex = 13
        Me.btnCSsave.Text = "บันทึก"
        Me.ToolTipCS.SetToolTip(Me.btnCSsave, "บันทึกส่งเคลม")
        Me.btnCSsave.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button4.Location = New System.Drawing.Point(321, 186)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(183, 40)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "พิมพ์ใบปะหน้ากล่อง"
        Me.ToolTipCS.SetToolTip(Me.Button4, "พิมพ์ใบปะหน้ากล่องพัสดุที่ส่งเคลม")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(148, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "วันที่ส่งเคลม"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(151, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(172, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtBCwarning)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCScom_addressZip)
        Me.GroupBox1.Controls.Add(Me.txtCScom_addressJJ)
        Me.GroupBox1.Controls.Add(Me.txtCScom_addressAOM)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCScom_contect)
        Me.GroupBox1.Controls.Add(Me.txtCScom_id)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCScom_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCScom_address)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 129)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายละเอียดบริษัทที่ส่งเคลม"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(485, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "อำเภอ/เขต"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(289, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "จังหวัด"
        '
        'txtBCwarning
        '
        Me.txtBCwarning.Location = New System.Drawing.Point(9, 73)
        Me.txtBCwarning.Name = "txtBCwarning"
        Me.txtBCwarning.Size = New System.Drawing.Size(274, 20)
        Me.txtBCwarning.TabIndex = 16
        Me.txtBCwarning.Text = "ระวังแตก ห้ามโยน"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(485, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "รหัสไปรษณีย์"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ป้ายคำเตือน"
        '
        'txtCScom_addressZip
        '
        Me.txtCScom_addressZip.Location = New System.Drawing.Point(488, 73)
        Me.txtCScom_addressZip.Name = "txtCScom_addressZip"
        Me.txtCScom_addressZip.ReadOnly = True
        Me.txtCScom_addressZip.Size = New System.Drawing.Size(78, 20)
        Me.txtCScom_addressZip.TabIndex = 17
        '
        'txtCScom_addressJJ
        '
        Me.txtCScom_addressJJ.Location = New System.Drawing.Point(289, 73)
        Me.txtCScom_addressJJ.Name = "txtCScom_addressJJ"
        Me.txtCScom_addressJJ.ReadOnly = True
        Me.txtCScom_addressJJ.Size = New System.Drawing.Size(193, 20)
        Me.txtCScom_addressJJ.TabIndex = 11
        '
        'txtCScom_addressAOM
        '
        Me.txtCScom_addressAOM.Location = New System.Drawing.Point(488, 34)
        Me.txtCScom_addressAOM.Name = "txtCScom_addressAOM"
        Me.txtCScom_addressAOM.ReadOnly = True
        Me.txtCScom_addressAOM.Size = New System.Drawing.Size(193, 20)
        Me.txtCScom_addressAOM.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(606, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "ค้นหา"
        Me.ToolTipCS.SetToolTip(Me.Button1, "ค้นหารายชื่อบริษัท")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(569, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "เบอร์โทรศัพท์"
        '
        'txtCScom_contect
        '
        Me.txtCScom_contect.Location = New System.Drawing.Point(572, 73)
        Me.txtCScom_contect.Name = "txtCScom_contect"
        Me.txtCScom_contect.ReadOnly = True
        Me.txtCScom_contect.Size = New System.Drawing.Size(109, 20)
        Me.txtCScom_contect.TabIndex = 9
        '
        'txtCScom_id
        '
        Me.txtCScom_id.Location = New System.Drawing.Point(6, 34)
        Me.txtCScom_id.Name = "txtCScom_id"
        Me.txtCScom_id.ReadOnly = True
        Me.txtCScom_id.Size = New System.Drawing.Size(78, 20)
        Me.txtCScom_id.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ที่อยู่บริษัท ตำบล/แขวง"
        '
        'txtCScom_name
        '
        Me.txtCScom_name.Location = New System.Drawing.Point(90, 34)
        Me.txtCScom_name.Name = "txtCScom_name"
        Me.txtCScom_name.ReadOnly = True
        Me.txtCScom_name.Size = New System.Drawing.Size(193, 20)
        Me.txtCScom_name.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ชื่อบริษัท/ชื่อบุคคล"
        '
        'txtCScom_address
        '
        Me.txtCScom_address.Location = New System.Drawing.Point(289, 34)
        Me.txtCScom_address.Name = "txtCScom_address"
        Me.txtCScom_address.ReadOnly = True
        Me.txtCScom_address.Size = New System.Drawing.Size(193, 20)
        Me.txtCScom_address.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "หมายเลขบริษัท"
        '
        'ClaimsSendFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 236)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnCSsave)
        Me.Controls.Add(Me.btnCScancel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCSclaims_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ClaimsSendFrm"
        Me.Text = "ส่งเคลมไปบริษัทรับเคลมสินค้า"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCSclaims_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTipCS As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCScancel As System.Windows.Forms.Button
    Friend WithEvents btnCSsave As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBCwarning As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCScom_addressZip As System.Windows.Forms.TextBox
    Friend WithEvents txtCScom_addressJJ As System.Windows.Forms.TextBox
    Friend WithEvents txtCScom_addressAOM As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCScom_contect As System.Windows.Forms.TextBox
    Friend WithEvents txtCScom_id As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCScom_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCScom_address As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
