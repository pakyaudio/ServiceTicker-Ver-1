<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnClaimsFrm
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
        Me.txtRCclaimsID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtRCnote = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRCclaims_money = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRCcencel = New System.Windows.Forms.Button()
        Me.btnRCsave = New System.Windows.Forms.Button()
        Me.txtRCaccessory = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbbRCtel_to_cus = New System.Windows.Forms.ComboBox()
        Me.lblRCtel_to_cus = New System.Windows.Forms.Label()
        Me.btnRCtelCUS = New System.Windows.Forms.Button()
        Me.lblRCtel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtRCclaimsID
        '
        Me.txtRCclaimsID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCclaimsID.Location = New System.Drawing.Point(15, 25)
        Me.txtRCclaimsID.Name = "txtRCclaimsID"
        Me.txtRCclaimsID.ReadOnly = True
        Me.txtRCclaimsID.Size = New System.Drawing.Size(177, 22)
        Me.txtRCclaimsID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "รหัสงานเคลม"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "วันที่ส่งกลับ"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(201, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'txtRCnote
        '
        Me.txtRCnote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCnote.Location = New System.Drawing.Point(15, 66)
        Me.txtRCnote.Name = "txtRCnote"
        Me.txtRCnote.Size = New System.Drawing.Size(769, 22)
        Me.txtRCnote.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "การซ่อมแซมแก้ไขจากทางบริษัท(ถ้ามี หากไม่มีให้ - ไว้)"
        '
        'txtRCclaims_money
        '
        Me.txtRCclaims_money.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCclaims_money.Location = New System.Drawing.Point(15, 108)
        Me.txtRCclaims_money.Name = "txtRCclaims_money"
        Me.txtRCclaims_money.Size = New System.Drawing.Size(132, 22)
        Me.txtRCclaims_money.TabIndex = 6
        Me.txtRCclaims_money.Text = "0"
        Me.txtRCclaims_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ค่าใช้จ่ายในการเคลม (ถ้ามี)"
        '
        'btnRCcencel
        '
        Me.btnRCcencel.Location = New System.Drawing.Point(709, 107)
        Me.btnRCcencel.Name = "btnRCcencel"
        Me.btnRCcencel.Size = New System.Drawing.Size(75, 23)
        Me.btnRCcencel.TabIndex = 8
        Me.btnRCcencel.Text = "ยกเลิก"
        Me.btnRCcencel.UseVisualStyleBackColor = True
        '
        'btnRCsave
        '
        Me.btnRCsave.Location = New System.Drawing.Point(562, 107)
        Me.btnRCsave.Name = "btnRCsave"
        Me.btnRCsave.Size = New System.Drawing.Size(141, 23)
        Me.btnRCsave.TabIndex = 9
        Me.btnRCsave.Text = "บันทึกส่งกลับงานเคลม"
        Me.btnRCsave.UseVisualStyleBackColor = True
        '
        'txtRCaccessory
        '
        Me.txtRCaccessory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCaccessory.Location = New System.Drawing.Point(153, 107)
        Me.txtRCaccessory.Name = "txtRCaccessory"
        Me.txtRCaccessory.ReadOnly = True
        Me.txtRCaccessory.Size = New System.Drawing.Size(403, 22)
        Me.txtRCaccessory.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(329, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "อุปกรณ์ที่นำมาด้วย (กรุณาเช็คอุปกรณ์ที่ลูกค้านำติดมาด้วยให้ครบถ้วน)"
        '
        'cbbRCtel_to_cus
        '
        Me.cbbRCtel_to_cus.FormattingEnabled = True
        Me.cbbRCtel_to_cus.Location = New System.Drawing.Point(407, 25)
        Me.cbbRCtel_to_cus.Name = "cbbRCtel_to_cus"
        Me.cbbRCtel_to_cus.Size = New System.Drawing.Size(248, 21)
        Me.cbbRCtel_to_cus.TabIndex = 12
        '
        'lblRCtel_to_cus
        '
        Me.lblRCtel_to_cus.AutoSize = True
        Me.lblRCtel_to_cus.Location = New System.Drawing.Point(407, 9)
        Me.lblRCtel_to_cus.Name = "lblRCtel_to_cus"
        Me.lblRCtel_to_cus.Size = New System.Drawing.Size(69, 13)
        Me.lblRCtel_to_cus.TabIndex = 13
        Me.lblRCtel_to_cus.Text = "การแจ้งลูกค้า"
        '
        'btnRCtelCUS
        '
        Me.btnRCtelCUS.Location = New System.Drawing.Point(662, 23)
        Me.btnRCtelCUS.Name = "btnRCtelCUS"
        Me.btnRCtelCUS.Size = New System.Drawing.Size(122, 24)
        Me.btnRCtelCUS.TabIndex = 14
        Me.btnRCtelCUS.Text = "ดูเบอร์โทรศัพท์ลูกค้า"
        Me.btnRCtelCUS.UseVisualStyleBackColor = True
        '
        'lblRCtel
        '
        Me.lblRCtel.AutoSize = True
        Me.lblRCtel.Location = New System.Drawing.Point(407, 49)
        Me.lblRCtel.Name = "lblRCtel"
        Me.lblRCtel.Size = New System.Drawing.Size(36, 13)
        Me.lblRCtel.TabIndex = 15
        Me.lblRCtel.Text = "TEL : "
        '
        'ReturnClaimsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 142)
        Me.Controls.Add(Me.lblRCtel)
        Me.Controls.Add(Me.btnRCtelCUS)
        Me.Controls.Add(Me.lblRCtel_to_cus)
        Me.Controls.Add(Me.cbbRCtel_to_cus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRCaccessory)
        Me.Controls.Add(Me.btnRCsave)
        Me.Controls.Add(Me.btnRCcencel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRCclaims_money)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRCnote)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRCclaimsID)
        Me.Name = "ReturnClaimsFrm"
        Me.Text = "ส่งกลับงานเคลม"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRCclaimsID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRCnote As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRCclaims_money As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRCcencel As System.Windows.Forms.Button
    Friend WithEvents btnRCsave As System.Windows.Forms.Button
    Friend WithEvents txtRCaccessory As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbbRCtel_to_cus As System.Windows.Forms.ComboBox
    Friend WithEvents lblRCtel_to_cus As System.Windows.Forms.Label
    Friend WithEvents btnRCtelCUS As System.Windows.Forms.Button
    Friend WithEvents lblRCtel As System.Windows.Forms.Label
End Class
