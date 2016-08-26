<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashSaleFrm
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
        Me.lblCashDTP = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCashBack = New System.Windows.Forms.TextBox()
        Me.lblCashSelectPayment = New System.Windows.Forms.Label()
        Me.lblCashSelectPaymentlbl = New System.Windows.Forms.Label()
        Me.txtCashCusID = New System.Windows.Forms.TextBox()
        Me.btnCashSave = New System.Windows.Forms.Button()
        Me.txtCashByselectPayment = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbbCashSelectPayment = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgCash = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCashCusPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCashCash = New System.Windows.Forms.TextBox()
        Me.txtCashLowerCash = New System.Windows.Forms.TextBox()
        Me.txtCashPercen = New System.Windows.Forms.TextBox()
        Me.ToolTipCS = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCScusName = New System.Windows.Forms.TextBox()
        Me.txtCScashID = New System.Windows.Forms.TextBox()
        Me.cbbCScreditCard = New System.Windows.Forms.ComboBox()
        Me.cbbCScreditCardBank = New System.Windows.Forms.ComboBox()
        Me.txtCStotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCSsale_id = New System.Windows.Forms.TextBox()
        CType(Me.dgCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCashDTP
        '
        Me.lblCashDTP.AutoSize = True
        Me.lblCashDTP.Location = New System.Drawing.Point(550, 348)
        Me.lblCashDTP.Name = "lblCashDTP"
        Me.lblCashDTP.Size = New System.Drawing.Size(22, 13)
        Me.lblCashDTP.TabIndex = 47
        Me.lblCashDTP.Text = "....."
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(553, 325)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker1.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(312, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 25)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "เงินทอน"
        '
        'txtCashBack
        '
        Me.txtCashBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashBack.ForeColor = System.Drawing.Color.DarkRed
        Me.txtCashBack.Location = New System.Drawing.Point(394, 287)
        Me.txtCashBack.Name = "txtCashBack"
        Me.txtCashBack.ReadOnly = True
        Me.txtCashBack.Size = New System.Drawing.Size(264, 31)
        Me.txtCashBack.TabIndex = 41
        Me.txtCashBack.Text = "0"
        Me.txtCashBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCS.SetToolTip(Me.txtCashBack, "เงินทอน")
        '
        'lblCashSelectPayment
        '
        Me.lblCashSelectPayment.AutoSize = True
        Me.lblCashSelectPayment.Location = New System.Drawing.Point(433, 348)
        Me.lblCashSelectPayment.Name = "lblCashSelectPayment"
        Me.lblCashSelectPayment.Size = New System.Drawing.Size(22, 13)
        Me.lblCashSelectPayment.TabIndex = 40
        Me.lblCashSelectPayment.Text = "....."
        '
        'lblCashSelectPaymentlbl
        '
        Me.lblCashSelectPaymentlbl.AutoSize = True
        Me.lblCashSelectPaymentlbl.Location = New System.Drawing.Point(326, 348)
        Me.lblCashSelectPaymentlbl.Name = "lblCashSelectPaymentlbl"
        Me.lblCashSelectPaymentlbl.Size = New System.Drawing.Size(101, 13)
        Me.lblCashSelectPaymentlbl.TabIndex = 39
        Me.lblCashSelectPaymentlbl.Text = "รูปแบบการชำระเงิน"
        '
        'txtCashCusID
        '
        Me.txtCashCusID.Location = New System.Drawing.Point(167, 11)
        Me.txtCashCusID.Name = "txtCashCusID"
        Me.txtCashCusID.ReadOnly = True
        Me.txtCashCusID.Size = New System.Drawing.Size(139, 20)
        Me.txtCashCusID.TabIndex = 38
        Me.ToolTipCS.SetToolTip(Me.txtCashCusID, "รหัสลูกค้า")
        '
        'btnCashSave
        '
        Me.btnCashSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCashSave.Location = New System.Drawing.Point(317, 386)
        Me.btnCashSave.Name = "btnCashSave"
        Me.btnCashSave.Size = New System.Drawing.Size(341, 59)
        Me.btnCashSave.TabIndex = 32
        Me.btnCashSave.Text = "บันทึกจ่ายเงิน"
        Me.btnCashSave.UseVisualStyleBackColor = True
        '
        'txtCashByselectPayment
        '
        Me.txtCashByselectPayment.Location = New System.Drawing.Point(444, 325)
        Me.txtCashByselectPayment.Name = "txtCashByselectPayment"
        Me.txtCashByselectPayment.Size = New System.Drawing.Size(103, 20)
        Me.txtCashByselectPayment.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(312, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 25)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "จำนวนที่ชำระ"
        '
        'cbbCashSelectPayment
        '
        Me.cbbCashSelectPayment.FormattingEnabled = True
        Me.cbbCashSelectPayment.Location = New System.Drawing.Point(317, 324)
        Me.cbbCashSelectPayment.Name = "cbbCashSelectPayment"
        Me.cbbCashSelectPayment.Size = New System.Drawing.Size(121, 21)
        Me.cbbCashSelectPayment.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "ยอดค้างชำระ"
        '
        'dgCash
        '
        Me.dgCash.AllowUserToAddRows = False
        Me.dgCash.AllowUserToDeleteRows = False
        Me.dgCash.AllowUserToOrderColumns = True
        Me.dgCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCash.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.sale_id, Me.datetime_save, Me.total_all})
        Me.dgCash.Location = New System.Drawing.Point(14, 37)
        Me.dgCash.MultiSelect = False
        Me.dgCash.Name = "dgCash"
        Me.dgCash.ReadOnly = True
        Me.dgCash.RowHeadersVisible = False
        Me.dgCash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCash.Size = New System.Drawing.Size(292, 374)
        Me.dgCash.TabIndex = 34
        Me.ToolTipCS.SetToolTip(Me.dgCash, "ยอดค้างชำระ/มัดจำ")
        '
        'no
        '
        Me.no.Frozen = True
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 30
        '
        'sale_id
        '
        Me.sale_id.Frozen = True
        Me.sale_id.HeaderText = "เลขเอกสาร"
        Me.sale_id.Name = "sale_id"
        Me.sale_id.ReadOnly = True
        Me.sale_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.sale_id.ToolTipText = "เลขเอกสารบิลเบิก/ใบลดหนี้"
        Me.sale_id.Width = 110
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.Width = 70
        '
        'total_all
        '
        Me.total_all.HeaderText = "ยอด"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all.Width = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(584, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "ยอดเงิน"
        '
        'txtCashCusPrice
        '
        Me.txtCashCusPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashCusPrice.Location = New System.Drawing.Point(312, 201)
        Me.txtCashCusPrice.Name = "txtCashCusPrice"
        Me.txtCashCusPrice.Size = New System.Drawing.Size(346, 80)
        Me.txtCashCusPrice.TabIndex = 25
        Me.txtCashCusPrice.Text = "0"
        Me.txtCashCusPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCS.SetToolTip(Me.txtCashCusPrice, "จำนวนที่ชำระ")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(524, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "ส่วนลด เป็นจำนวนเงิน"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(366, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ส่วนลด คิดเป็น %"
        '
        'txtCashCash
        '
        Me.txtCashCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCashCash.Location = New System.Drawing.Point(312, 37)
        Me.txtCashCash.Name = "txtCashCash"
        Me.txtCashCash.ReadOnly = True
        Me.txtCashCash.Size = New System.Drawing.Size(346, 80)
        Me.txtCashCash.TabIndex = 43
        Me.txtCashCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCS.SetToolTip(Me.txtCashCash, "ยอดเงินที่ต้องชำระ")
        '
        'txtCashLowerCash
        '
        Me.txtCashLowerCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashLowerCash.Location = New System.Drawing.Point(491, 123)
        Me.txtCashLowerCash.Name = "txtCashLowerCash"
        Me.txtCashLowerCash.Size = New System.Drawing.Size(167, 29)
        Me.txtCashLowerCash.TabIndex = 27
        Me.txtCashLowerCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCS.SetToolTip(Me.txtCashLowerCash, "ส่วนลดเป็นจำนวนเงิน(บาท)")
        '
        'txtCashPercen
        '
        Me.txtCashPercen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashPercen.Location = New System.Drawing.Point(312, 123)
        Me.txtCashPercen.Name = "txtCashPercen"
        Me.txtCashPercen.Size = New System.Drawing.Size(173, 29)
        Me.txtCashPercen.TabIndex = 26
        Me.txtCashPercen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCS.SetToolTip(Me.txtCashPercen, "ส่วนลดคิดเป็นเปอร์เซ็นต์")
        '
        'txtCScusName
        '
        Me.txtCScusName.Location = New System.Drawing.Point(312, 11)
        Me.txtCScusName.Name = "txtCScusName"
        Me.txtCScusName.ReadOnly = True
        Me.txtCScusName.Size = New System.Drawing.Size(139, 20)
        Me.txtCScusName.TabIndex = 50
        Me.ToolTipCS.SetToolTip(Me.txtCScusName, "ชื่อลูกค้า")
        '
        'txtCScashID
        '
        Me.txtCScashID.Location = New System.Drawing.Point(518, 175)
        Me.txtCScashID.Name = "txtCScashID"
        Me.txtCScashID.ReadOnly = True
        Me.txtCScashID.Size = New System.Drawing.Size(139, 20)
        Me.txtCScashID.TabIndex = 51
        Me.ToolTipCS.SetToolTip(Me.txtCScashID, "หมายเลขชำระเงิน")
        '
        'cbbCScreditCard
        '
        Me.cbbCScreditCard.Enabled = False
        Me.cbbCScreditCard.FormattingEnabled = True
        Me.cbbCScreditCard.Location = New System.Drawing.Point(444, 364)
        Me.cbbCScreditCard.Name = "cbbCScreditCard"
        Me.cbbCScreditCard.Size = New System.Drawing.Size(103, 21)
        Me.cbbCScreditCard.TabIndex = 52
        Me.ToolTipCS.SetToolTip(Me.cbbCScreditCard, "ประเภทบัตร")
        '
        'cbbCScreditCardBank
        '
        Me.cbbCScreditCardBank.Enabled = False
        Me.cbbCScreditCardBank.FormattingEnabled = True
        Me.cbbCScreditCardBank.Location = New System.Drawing.Point(553, 364)
        Me.cbbCScreditCardBank.Name = "cbbCScreditCardBank"
        Me.cbbCScreditCardBank.Size = New System.Drawing.Size(105, 21)
        Me.cbbCScreditCardBank.TabIndex = 53
        Me.ToolTipCS.SetToolTip(Me.cbbCScreditCardBank, "ธนาคารเจ้าของบัตร")
        '
        'txtCStotal
        '
        Me.txtCStotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCStotal.ForeColor = System.Drawing.Color.Red
        Me.txtCStotal.Location = New System.Drawing.Point(189, 417)
        Me.txtCStotal.Name = "txtCStotal"
        Me.txtCStotal.ReadOnly = True
        Me.txtCStotal.Size = New System.Drawing.Size(117, 26)
        Me.txtCStotal.TabIndex = 48
        Me.txtCStotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(72, 420)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "ยอดรวมค้างชำระ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(326, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "รายละเอียดบัตรเครดิต"
        '
        'txtCSsale_id
        '
        Me.txtCSsale_id.Location = New System.Drawing.Point(457, 11)
        Me.txtCSsale_id.Name = "txtCSsale_id"
        Me.txtCSsale_id.ReadOnly = True
        Me.txtCSsale_id.Size = New System.Drawing.Size(130, 20)
        Me.txtCSsale_id.TabIndex = 55
        Me.ToolTipCS.SetToolTip(Me.txtCSsale_id, "รหัสขาย")
        '
        'CashSaleFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 458)
        Me.Controls.Add(Me.txtCSsale_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbbCScreditCardBank)
        Me.Controls.Add(Me.cbbCScreditCard)
        Me.Controls.Add(Me.txtCScashID)
        Me.Controls.Add(Me.txtCScusName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCStotal)
        Me.Controls.Add(Me.lblCashDTP)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCashBack)
        Me.Controls.Add(Me.lblCashSelectPayment)
        Me.Controls.Add(Me.lblCashSelectPaymentlbl)
        Me.Controls.Add(Me.txtCashCusID)
        Me.Controls.Add(Me.btnCashSave)
        Me.Controls.Add(Me.txtCashByselectPayment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbbCashSelectPayment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgCash)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCashCusPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCashCash)
        Me.Controls.Add(Me.txtCashLowerCash)
        Me.Controls.Add(Me.txtCashPercen)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CashSaleFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ชำระเงิน"
        CType(Me.dgCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCashDTP As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCashBack As System.Windows.Forms.TextBox
    Friend WithEvents lblCashSelectPayment As System.Windows.Forms.Label
    Friend WithEvents lblCashSelectPaymentlbl As System.Windows.Forms.Label
    Friend WithEvents txtCashCusID As System.Windows.Forms.TextBox
    Friend WithEvents btnCashSave As System.Windows.Forms.Button
    Friend WithEvents txtCashByselectPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbbCashSelectPayment As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgCash As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCashCusPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCashCash As System.Windows.Forms.TextBox
    Friend WithEvents txtCashLowerCash As System.Windows.Forms.TextBox
    Friend WithEvents txtCashPercen As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipCS As System.Windows.Forms.ToolTip
    Friend WithEvents txtCStotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCScusName As System.Windows.Forms.TextBox
    Friend WithEvents txtCScashID As System.Windows.Forms.TextBox
    Friend WithEvents cbbCScreditCard As System.Windows.Forms.ComboBox
    Friend WithEvents cbbCScreditCardBank As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCSsale_id As System.Windows.Forms.TextBox
End Class
