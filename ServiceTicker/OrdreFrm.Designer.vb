<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdreFrm
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
        Me.txtORcompanyID = New System.Windows.Forms.TextBox()
        Me.txtORcompanyAddress = New System.Windows.Forms.TextBox()
        Me.cbbORcompanySelect = New System.Windows.Forms.ComboBox()
        Me.txtORcompanyTel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblORid = New System.Windows.Forms.Label()
        Me.lblORbarcodePro = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtORbarcodePro = New System.Windows.Forms.TextBox()
        Me.btnORokBarcode = New System.Windows.Forms.Button()
        Me.btnORselectPro = New System.Windows.Forms.Button()
        Me.dgOR = New System.Windows.Forms.DataGridView()
        Me.btnORsave = New System.Windows.Forms.Button()
        Me.btnORdel = New System.Windows.Forms.Button()
        Me.btnORdelAll = New System.Windows.Forms.Button()
        Me.txtORsumMoney = New System.Windows.Forms.TextBox()
        Me.lblORsummoney = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTipOrder = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblEmployee = New System.Windows.Forms.Label()
        CType(Me.dgOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtORcompanyID
        '
        Me.txtORcompanyID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtORcompanyID.Location = New System.Drawing.Point(69, 24)
        Me.txtORcompanyID.Name = "txtORcompanyID"
        Me.txtORcompanyID.Size = New System.Drawing.Size(80, 22)
        Me.txtORcompanyID.TabIndex = 0
        Me.ToolTipOrder.SetToolTip(Me.txtORcompanyID, "ใส่รหัสบริษัทแล้วกด enter")
        '
        'txtORcompanyAddress
        '
        Me.txtORcompanyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtORcompanyAddress.Location = New System.Drawing.Point(69, 52)
        Me.txtORcompanyAddress.Name = "txtORcompanyAddress"
        Me.txtORcompanyAddress.ReadOnly = True
        Me.txtORcompanyAddress.Size = New System.Drawing.Size(274, 22)
        Me.txtORcompanyAddress.TabIndex = 1
        Me.txtORcompanyAddress.TabStop = False
        '
        'cbbORcompanySelect
        '
        Me.cbbORcompanySelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbORcompanySelect.FormattingEnabled = True
        Me.cbbORcompanySelect.Location = New System.Drawing.Point(155, 23)
        Me.cbbORcompanySelect.Name = "cbbORcompanySelect"
        Me.cbbORcompanySelect.Size = New System.Drawing.Size(188, 23)
        Me.cbbORcompanySelect.TabIndex = 2
        Me.ToolTipOrder.SetToolTip(Me.cbbORcompanySelect, "คลิ๊กเพื่อเลือกบริษัทที่จัดซื้อสินค้า")
        '
        'txtORcompanyTel
        '
        Me.txtORcompanyTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtORcompanyTel.Location = New System.Drawing.Point(69, 80)
        Me.txtORcompanyTel.Name = "txtORcompanyTel"
        Me.txtORcompanyTel.ReadOnly = True
        Me.txtORcompanyTel.Size = New System.Drawing.Size(274, 22)
        Me.txtORcompanyTel.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(9, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "รหัสบริษัท"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(14, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "เบอร์โทร"
        '
        'lblORid
        '
        Me.lblORid.AutoSize = True
        Me.lblORid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblORid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblORid.Location = New System.Drawing.Point(552, 9)
        Me.lblORid.Name = "lblORid"
        Me.lblORid.Size = New System.Drawing.Size(168, 18)
        Me.lblORid.TabIndex = 6
        Me.lblORid.Text = "00000000000000000000"
        '
        'lblORbarcodePro
        '
        Me.lblORbarcodePro.AutoSize = True
        Me.lblORbarcodePro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblORbarcodePro.Location = New System.Drawing.Point(379, 84)
        Me.lblORbarcodePro.Name = "lblORbarcodePro"
        Me.lblORbarcodePro.Size = New System.Drawing.Size(70, 13)
        Me.lblORbarcodePro.TabIndex = 7
        Me.lblORbarcodePro.Text = "บาร์โค๊ตสินค้า"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(164, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "เลือกชื่อบริษัท"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(36, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "ที่อยู่"
        '
        'txtORbarcodePro
        '
        Me.txtORbarcodePro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtORbarcodePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtORbarcodePro.ForeColor = System.Drawing.Color.Red
        Me.txtORbarcodePro.Location = New System.Drawing.Point(455, 80)
        Me.txtORbarcodePro.Name = "txtORbarcodePro"
        Me.txtORbarcodePro.Size = New System.Drawing.Size(226, 22)
        Me.txtORbarcodePro.TabIndex = 10
        Me.txtORbarcodePro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipOrder.SetToolTip(Me.txtORbarcodePro, "ใส่หมายเลขบาร์โค๊ตสินค้าที่ต้องการแล้วกด enter")
        '
        'btnORokBarcode
        '
        Me.btnORokBarcode.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnORokBarcode.Location = New System.Drawing.Point(687, 79)
        Me.btnORokBarcode.Name = "btnORokBarcode"
        Me.btnORokBarcode.Size = New System.Drawing.Size(33, 23)
        Me.btnORokBarcode.TabIndex = 11
        Me.btnORokBarcode.Text = "OK"
        Me.ToolTipOrder.SetToolTip(Me.btnORokBarcode, "กดเพื่อค้นหาสินค้าจากรหัสสินค้า")
        Me.btnORokBarcode.UseVisualStyleBackColor = True
        '
        'btnORselectPro
        '
        Me.btnORselectPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnORselectPro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnORselectPro.Location = New System.Drawing.Point(467, 29)
        Me.btnORselectPro.Name = "btnORselectPro"
        Me.btnORselectPro.Size = New System.Drawing.Size(250, 40)
        Me.btnORselectPro.TabIndex = 13
        Me.btnORselectPro.Text = "เลือกสินค้าจากสต็อก"
        Me.ToolTipOrder.SetToolTip(Me.btnORselectPro, "เลือกสินค้าจากตารางสินค้าในสต็อกสินค้า")
        Me.btnORselectPro.UseVisualStyleBackColor = True
        '
        'dgOR
        '
        Me.dgOR.AllowUserToAddRows = False
        Me.dgOR.AllowUserToDeleteRows = False
        Me.dgOR.AllowUserToOrderColumns = True
        Me.dgOR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOR.Location = New System.Drawing.Point(12, 108)
        Me.dgOR.Name = "dgOR"
        Me.dgOR.RowHeadersVisible = False
        Me.dgOR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOR.Size = New System.Drawing.Size(708, 383)
        Me.dgOR.TabIndex = 14
        Me.ToolTipOrder.SetToolTip(Me.dgOR, "ดับเบิ้ลคลิ๊กจำนวนสินค้าเพื่อแก้ไขได้ทันที")
        '
        'btnORsave
        '
        Me.btnORsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnORsave.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnORsave.Location = New System.Drawing.Point(12, 497)
        Me.btnORsave.Name = "btnORsave"
        Me.btnORsave.Size = New System.Drawing.Size(114, 41)
        Me.btnORsave.TabIndex = 15
        Me.btnORsave.Text = "บันทึก"
        Me.ToolTipOrder.SetToolTip(Me.btnORsave, "บันทึกรายการสินค้าที่นำเข้า")
        Me.btnORsave.UseVisualStyleBackColor = True
        '
        'btnORdel
        '
        Me.btnORdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnORdel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnORdel.Location = New System.Drawing.Point(132, 497)
        Me.btnORdel.Name = "btnORdel"
        Me.btnORdel.Size = New System.Drawing.Size(49, 41)
        Me.btnORdel.TabIndex = 16
        Me.btnORdel.Text = "ลบ"
        Me.ToolTipOrder.SetToolTip(Me.btnORdel, "ลบรายการสินค้าทีละหนึ่งรายการ")
        Me.btnORdel.UseVisualStyleBackColor = True
        '
        'btnORdelAll
        '
        Me.btnORdelAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnORdelAll.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnORdelAll.Location = New System.Drawing.Point(187, 497)
        Me.btnORdelAll.Name = "btnORdelAll"
        Me.btnORdelAll.Size = New System.Drawing.Size(114, 41)
        Me.btnORdelAll.TabIndex = 17
        Me.btnORdelAll.Text = "ล้างรายการ"
        Me.ToolTipOrder.SetToolTip(Me.btnORdelAll, "ลบรายการสินค้าทั้งหมด")
        Me.btnORdelAll.UseVisualStyleBackColor = True
        '
        'txtORsumMoney
        '
        Me.txtORsumMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtORsumMoney.Location = New System.Drawing.Point(584, 508)
        Me.txtORsumMoney.Name = "txtORsumMoney"
        Me.txtORsumMoney.ReadOnly = True
        Me.txtORsumMoney.Size = New System.Drawing.Size(136, 26)
        Me.txtORsumMoney.TabIndex = 18
        Me.txtORsumMoney.Text = "0"
        Me.txtORsumMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipOrder.SetToolTip(Me.txtORsumMoney, "ยอดรวมสินค้าในตาราง")
        '
        'lblORsummoney
        '
        Me.lblORsummoney.AutoSize = True
        Me.lblORsummoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblORsummoney.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblORsummoney.Location = New System.Drawing.Point(535, 511)
        Me.lblORsummoney.Name = "lblORsummoney"
        Me.lblORsummoney.Size = New System.Drawing.Size(43, 16)
        Me.lblORsummoney.TabIndex = 19
        Me.lblORsummoney.Text = "รวมเงิน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(464, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "เลขที่ใบสั่งซื้อ"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(349, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "<<add"
        Me.ToolTipOrder.SetToolTip(Me.Button1, "เพิ่มบริษัทที่จัดซื้อ")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTipOrder
        '
        Me.ToolTipOrder.AutoPopDelay = 5000
        Me.ToolTipOrder.InitialDelay = 300
        Me.ToolTipOrder.IsBalloon = True
        Me.ToolTipOrder.ReshowDelay = 300
        '
        'lblEmployee
        '
        Me.lblEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEmployee.AutoSize = True
        Me.lblEmployee.Location = New System.Drawing.Point(9, 541)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(29, 13)
        Me.lblEmployee.TabIndex = 22
        Me.lblEmployee.Text = "User"
        '
        'OrdreFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 560)
        Me.Controls.Add(Me.lblEmployee)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblORsummoney)
        Me.Controls.Add(Me.txtORsumMoney)
        Me.Controls.Add(Me.btnORdelAll)
        Me.Controls.Add(Me.btnORdel)
        Me.Controls.Add(Me.btnORsave)
        Me.Controls.Add(Me.dgOR)
        Me.Controls.Add(Me.btnORselectPro)
        Me.Controls.Add(Me.btnORokBarcode)
        Me.Controls.Add(Me.txtORbarcodePro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblORbarcodePro)
        Me.Controls.Add(Me.lblORid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtORcompanyTel)
        Me.Controls.Add(Me.cbbORcompanySelect)
        Me.Controls.Add(Me.txtORcompanyAddress)
        Me.Controls.Add(Me.txtORcompanyID)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OrdreFrm"
        Me.Text = "สั่งซื้อสินค้า"
        CType(Me.dgOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtORcompanyID As System.Windows.Forms.TextBox
    Friend WithEvents txtORcompanyAddress As System.Windows.Forms.TextBox
    Friend WithEvents cbbORcompanySelect As System.Windows.Forms.ComboBox
    Friend WithEvents txtORcompanyTel As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblORid As System.Windows.Forms.Label
    Friend WithEvents lblORbarcodePro As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtORbarcodePro As System.Windows.Forms.TextBox
    Friend WithEvents btnORokBarcode As System.Windows.Forms.Button
    Friend WithEvents btnORselectPro As System.Windows.Forms.Button
    Friend WithEvents dgOR As System.Windows.Forms.DataGridView
    Friend WithEvents btnORsave As System.Windows.Forms.Button
    Friend WithEvents btnORdel As System.Windows.Forms.Button
    Friend WithEvents btnORdelAll As System.Windows.Forms.Button
    Friend WithEvents txtORsumMoney As System.Windows.Forms.TextBox
    Friend WithEvents lblORsummoney As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTipOrder As System.Windows.Forms.ToolTip
    Friend WithEvents lblEmployee As System.Windows.Forms.Label
End Class
