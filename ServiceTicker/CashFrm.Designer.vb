<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashFrm
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
        Me.txtCashPercen = New System.Windows.Forms.TextBox()
        Me.txtCashLowerCash = New System.Windows.Forms.TextBox()
        Me.txtCashCash = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCashCusPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTipCash = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCashFixID = New System.Windows.Forms.TextBox()
        Me.txtCashCusID = New System.Windows.Forms.TextBox()
        Me.txtCashBack = New System.Windows.Forms.TextBox()
        Me.cbbCScreditCardBank = New System.Windows.Forms.ComboBox()
        Me.cbbCScreditCard = New System.Windows.Forms.ComboBox()
        Me.dgCash = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbbCashSelectPayment = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCashByselectPayment = New System.Windows.Forms.TextBox()
        Me.btnCashSave = New System.Windows.Forms.Button()
        Me.lblCashSelectPaymentlbl = New System.Windows.Forms.Label()
        Me.lblCashSelectPayment = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCashpledgeID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblCashDTP = New System.Windows.Forms.Label()
        Me.txtCcreditTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCashPercen
        '
        Me.txtCashPercen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashPercen.Location = New System.Drawing.Point(310, 121)
        Me.txtCashPercen.Name = "txtCashPercen"
        Me.txtCashPercen.Size = New System.Drawing.Size(173, 29)
        Me.txtCashPercen.TabIndex = 1
        Me.txtCashPercen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCash.SetToolTip(Me.txtCashPercen, "ใส่ส่วนลด (ถ้ามี)")
        '
        'txtCashLowerCash
        '
        Me.txtCashLowerCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashLowerCash.Location = New System.Drawing.Point(489, 121)
        Me.txtCashLowerCash.Name = "txtCashLowerCash"
        Me.txtCashLowerCash.Size = New System.Drawing.Size(167, 29)
        Me.txtCashLowerCash.TabIndex = 2
        Me.txtCashLowerCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCash.SetToolTip(Me.txtCashLowerCash, "ใส่ส่วนลด (ถ้ามี)")
        '
        'txtCashCash
        '
        Me.txtCashCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCashCash.Location = New System.Drawing.Point(310, 35)
        Me.txtCashCash.Name = "txtCashCash"
        Me.txtCashCash.ReadOnly = True
        Me.txtCashCash.Size = New System.Drawing.Size(346, 80)
        Me.txtCashCash.TabIndex = 20
        Me.txtCashCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCash.SetToolTip(Me.txtCashCash, "ยอดรวมค่าซ่อม")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ส่วนลด คิดเป็น %"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(522, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ส่วนลด เป็นจำนวนเงิน"
        '
        'txtCashCusPrice
        '
        Me.txtCashCusPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashCusPrice.Location = New System.Drawing.Point(310, 199)
        Me.txtCashCusPrice.Name = "txtCashCusPrice"
        Me.txtCashCusPrice.Size = New System.Drawing.Size(346, 80)
        Me.txtCashCusPrice.TabIndex = 0
        Me.txtCashCusPrice.Text = "0"
        Me.txtCashCusPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCash.SetToolTip(Me.txtCashCusPrice, "ยอดเงินที่ลูกค้าชำระ")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(582, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ยอดเงิน"
        '
        'ToolTipCash
        '
        Me.ToolTipCash.IsBalloon = True
        '
        'txtCashFixID
        '
        Me.txtCashFixID.Location = New System.Drawing.Point(310, 4)
        Me.txtCashFixID.Name = "txtCashFixID"
        Me.txtCashFixID.ReadOnly = True
        Me.txtCashFixID.Size = New System.Drawing.Size(150, 20)
        Me.txtCashFixID.TabIndex = 15
        Me.ToolTipCash.SetToolTip(Me.txtCashFixID, "หมายเลขใบรับซ่อม")
        '
        'txtCashCusID
        '
        Me.txtCashCusID.Location = New System.Drawing.Point(165, 4)
        Me.txtCashCusID.Name = "txtCashCusID"
        Me.txtCashCusID.ReadOnly = True
        Me.txtCashCusID.Size = New System.Drawing.Size(139, 20)
        Me.txtCashCusID.TabIndex = 16
        Me.ToolTipCash.SetToolTip(Me.txtCashCusID, "รหัสลูกค้า")
        '
        'txtCashBack
        '
        Me.txtCashBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashBack.ForeColor = System.Drawing.Color.Maroon
        Me.txtCashBack.Location = New System.Drawing.Point(392, 285)
        Me.txtCashBack.Name = "txtCashBack"
        Me.txtCashBack.ReadOnly = True
        Me.txtCashBack.Size = New System.Drawing.Size(264, 31)
        Me.txtCashBack.TabIndex = 19
        Me.txtCashBack.Text = "0"
        Me.txtCashBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCash.SetToolTip(Me.txtCashBack, "เงินทอน")
        '
        'cbbCScreditCardBank
        '
        Me.cbbCScreditCardBank.Enabled = False
        Me.cbbCScreditCardBank.FormattingEnabled = True
        Me.cbbCScreditCardBank.Location = New System.Drawing.Point(551, 364)
        Me.cbbCScreditCardBank.Name = "cbbCScreditCardBank"
        Me.cbbCScreditCardBank.Size = New System.Drawing.Size(105, 21)
        Me.cbbCScreditCardBank.TabIndex = 56
        Me.ToolTipCash.SetToolTip(Me.cbbCScreditCardBank, "ธนาคารเจ้าของบัตรเครดิต")
        '
        'cbbCScreditCard
        '
        Me.cbbCScreditCard.Enabled = False
        Me.cbbCScreditCard.FormattingEnabled = True
        Me.cbbCScreditCard.Location = New System.Drawing.Point(442, 364)
        Me.cbbCScreditCard.Name = "cbbCScreditCard"
        Me.cbbCScreditCard.Size = New System.Drawing.Size(103, 21)
        Me.cbbCScreditCard.TabIndex = 55
        Me.ToolTipCash.SetToolTip(Me.cbbCScreditCard, "ประเภทบัตรเครดิต")
        '
        'dgCash
        '
        Me.dgCash.AllowUserToAddRows = False
        Me.dgCash.AllowUserToDeleteRows = False
        Me.dgCash.AllowUserToOrderColumns = True
        Me.dgCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCash.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.sale_id, Me.datetime_save, Me.total_all})
        Me.dgCash.Location = New System.Drawing.Point(12, 35)
        Me.dgCash.MultiSelect = False
        Me.dgCash.Name = "dgCash"
        Me.dgCash.ReadOnly = True
        Me.dgCash.RowHeadersVisible = False
        Me.dgCash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCash.Size = New System.Drawing.Size(292, 350)
        Me.dgCash.TabIndex = 7
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ยอดค้างชำระ"
        '
        'cbbCashSelectPayment
        '
        Me.cbbCashSelectPayment.FormattingEnabled = True
        Me.cbbCashSelectPayment.Location = New System.Drawing.Point(315, 322)
        Me.cbbCashSelectPayment.Name = "cbbCashSelectPayment"
        Me.cbbCashSelectPayment.Size = New System.Drawing.Size(121, 21)
        Me.cbbCashSelectPayment.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(310, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "จำนวนที่ชำระ"
        '
        'txtCashByselectPayment
        '
        Me.txtCashByselectPayment.Location = New System.Drawing.Point(442, 323)
        Me.txtCashByselectPayment.Name = "txtCashByselectPayment"
        Me.txtCashByselectPayment.Size = New System.Drawing.Size(103, 20)
        Me.txtCashByselectPayment.TabIndex = 4
        '
        'btnCashSave
        '
        Me.btnCashSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCashSave.Location = New System.Drawing.Point(315, 391)
        Me.btnCashSave.Name = "btnCashSave"
        Me.btnCashSave.Size = New System.Drawing.Size(341, 52)
        Me.btnCashSave.TabIndex = 5
        Me.btnCashSave.Text = "บันทึกจ่ายเงิน"
        Me.btnCashSave.UseVisualStyleBackColor = True
        '
        'lblCashSelectPaymentlbl
        '
        Me.lblCashSelectPaymentlbl.AutoSize = True
        Me.lblCashSelectPaymentlbl.Location = New System.Drawing.Point(324, 346)
        Me.lblCashSelectPaymentlbl.Name = "lblCashSelectPaymentlbl"
        Me.lblCashSelectPaymentlbl.Size = New System.Drawing.Size(101, 13)
        Me.lblCashSelectPaymentlbl.TabIndex = 17
        Me.lblCashSelectPaymentlbl.Text = "รูปแบบการชำระเงิน"
        '
        'lblCashSelectPayment
        '
        Me.lblCashSelectPayment.AutoSize = True
        Me.lblCashSelectPayment.Location = New System.Drawing.Point(439, 346)
        Me.lblCashSelectPayment.Name = "lblCashSelectPayment"
        Me.lblCashSelectPayment.Size = New System.Drawing.Size(22, 13)
        Me.lblCashSelectPayment.TabIndex = 18
        Me.lblCashSelectPayment.Text = "....."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(310, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 25)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "เงินทอน"
        '
        'txtCashpledgeID
        '
        Me.txtCashpledgeID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCashpledgeID.Location = New System.Drawing.Point(80, 423)
        Me.txtCashpledgeID.Name = "txtCashpledgeID"
        Me.txtCashpledgeID.ReadOnly = True
        Me.txtCashpledgeID.Size = New System.Drawing.Size(224, 20)
        Me.txtCashpledgeID.TabIndex = 21
        Me.txtCashpledgeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 426)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "เลขบิลมัดจำ"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(551, 323)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker1.TabIndex = 23
        '
        'lblCashDTP
        '
        Me.lblCashDTP.AutoSize = True
        Me.lblCashDTP.Location = New System.Drawing.Point(551, 346)
        Me.lblCashDTP.Name = "lblCashDTP"
        Me.lblCashDTP.Size = New System.Drawing.Size(22, 13)
        Me.lblCashDTP.TabIndex = 24
        Me.lblCashDTP.Text = "....."
        '
        'txtCcreditTotal
        '
        Me.txtCcreditTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCcreditTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCcreditTotal.Location = New System.Drawing.Point(121, 391)
        Me.txtCcreditTotal.Name = "txtCcreditTotal"
        Me.txtCcreditTotal.ReadOnly = True
        Me.txtCcreditTotal.Size = New System.Drawing.Size(183, 26)
        Me.txtCcreditTotal.TabIndex = 25
        Me.txtCcreditTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "ยอดรวมค้างชำระ"
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(324, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "รายละเอียดบัตรเครดิต"
        '
        'CashFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 452)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbbCScreditCardBank)
        Me.Controls.Add(Me.cbbCScreditCard)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCcreditTotal)
        Me.Controls.Add(Me.lblCashDTP)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCashpledgeID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCashBack)
        Me.Controls.Add(Me.lblCashSelectPayment)
        Me.Controls.Add(Me.lblCashSelectPaymentlbl)
        Me.Controls.Add(Me.txtCashCusID)
        Me.Controls.Add(Me.txtCashFixID)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CashFrm"
        Me.Text = "ชำระเงิน"
        CType(Me.dgCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCashPercen As System.Windows.Forms.TextBox
    Friend WithEvents txtCashLowerCash As System.Windows.Forms.TextBox
    Friend WithEvents txtCashCash As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCashCusPrice As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipCash As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgCash As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbbCashSelectPayment As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCashByselectPayment As System.Windows.Forms.TextBox
    Friend WithEvents btnCashSave As System.Windows.Forms.Button
    Friend WithEvents txtCashFixID As System.Windows.Forms.TextBox
    Friend WithEvents txtCashCusID As System.Windows.Forms.TextBox
    Friend WithEvents lblCashSelectPaymentlbl As System.Windows.Forms.Label
    Friend WithEvents lblCashSelectPayment As System.Windows.Forms.Label
    Friend WithEvents txtCashBack As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCashpledgeID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCashDTP As System.Windows.Forms.Label
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCcreditTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbbCScreditCardBank As System.Windows.Forms.ComboBox
    Friend WithEvents cbbCScreditCard As System.Windows.Forms.ComboBox
End Class
