<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiveProductFrm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgRPorderPro = New System.Windows.Forms.DataGridView()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวนรับSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgRPsn = New System.Windows.Forms.DataGridView()
        Me.serial_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namepro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codepro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRPsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRPStatus = New System.Windows.Forms.Label()
        Me.btnRPselectOrder = New System.Windows.Forms.Button()
        Me.txtRPserialPro = New System.Windows.Forms.TextBox()
        Me.btnRPaddSN = New System.Windows.Forms.Button()
        Me.btnRPdelSN = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRSorderID = New System.Windows.Forms.TextBox()
        Me.txtRPid = New System.Windows.Forms.TextBox()
        Me.cbRPstatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRPsumMoney = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRPsale_company_name = New System.Windows.Forms.TextBox()
        Me.txtRPbillID = New System.Windows.Forms.TextBox()
        Me.lblRPbillID = New System.Windows.Forms.Label()
        Me.DateTimePickerRP = New System.Windows.Forms.DateTimePicker()
        Me.btnRPclear = New System.Windows.Forms.Button()
        Me.ToolTipRP = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtRPbuy_id = New System.Windows.Forms.TextBox()
        Me.txtRPbarcode = New System.Windows.Forms.TextBox()
        Me.btnRPaddBarcode = New System.Windows.Forms.Button()
        Me.btnRPdelBarcode = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRPnamePro = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnRPaddBCnum = New System.Windows.Forms.Button()
        Me.btnRPdelBCnum = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgRPorderPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRPsn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgRPorderPro
        '
        Me.dgRPorderPro.AllowUserToAddRows = False
        Me.dgRPorderPro.AllowUserToDeleteRows = False
        Me.dgRPorderPro.AllowUserToResizeColumns = False
        Me.dgRPorderPro.AllowUserToResizeRows = False
        Me.dgRPorderPro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgRPorderPro.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgRPorderPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRPorderPro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_pro, Me.name_pro, Me.price_cost, Me.price_buy, Me.count_num, Me.จำนวนรับSN, Me.SN, Me.unit, Me.total_all})
        Me.dgRPorderPro.Location = New System.Drawing.Point(12, 89)
        Me.dgRPorderPro.MultiSelect = False
        Me.dgRPorderPro.Name = "dgRPorderPro"
        Me.dgRPorderPro.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRPorderPro.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgRPorderPro.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgRPorderPro.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgRPorderPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRPorderPro.Size = New System.Drawing.Size(674, 220)
        Me.dgRPorderPro.TabIndex = 0
        '
        'code_pro
        '
        Me.code_pro.DataPropertyName = "code_pro"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.code_pro.DefaultCellStyle = DataGridViewCellStyle1
        Me.code_pro.Frozen = True
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.MaxInputLength = 30
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.code_pro.ToolTipText = "รหัสสินค้า"
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.name_pro.DefaultCellStyle = DataGridViewCellStyle2
        Me.name_pro.FillWeight = 250.0!
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.MaxInputLength = 3000
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.ToolTipText = "ชื่อสินค้า"
        Me.name_pro.Width = 200
        '
        'price_cost
        '
        Me.price_cost.DataPropertyName = "price_cost"
        Me.price_cost.FillWeight = 70.0!
        Me.price_cost.HeaderText = "ราคาทุน"
        Me.price_cost.Name = "price_cost"
        Me.price_cost.ReadOnly = True
        Me.price_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_cost.ToolTipText = "ต้นทุนที่ซื้อสินค้ามา"
        Me.price_cost.Width = 70
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        Me.price_buy.FillWeight = 70.0!
        Me.price_buy.HeaderText = "ราคาขาย"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.ToolTipText = "ราคาที่ตั้งขายหน้าร้าน"
        Me.price_buy.Width = 70
        '
        'count_num
        '
        Me.count_num.DataPropertyName = "count_num"
        Me.count_num.FillWeight = 50.0!
        Me.count_num.HeaderText = "จำนวนสั่ง"
        Me.count_num.Name = "count_num"
        Me.count_num.ReadOnly = True
        Me.count_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.count_num.ToolTipText = "จำนวนสินค้าที่สั่งซื้อ"
        Me.count_num.Width = 50
        '
        'จำนวนรับSN
        '
        Me.จำนวนรับSN.DataPropertyName = "bar_code"
        Me.จำนวนรับSN.FillWeight = 50.0!
        Me.จำนวนรับSN.HeaderText = "จำนวนรับบาร์โค๊ต"
        Me.จำนวนรับSN.Name = "จำนวนรับSN"
        Me.จำนวนรับSN.ReadOnly = True
        Me.จำนวนรับSN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.จำนวนรับSN.ToolTipText = "จำนวนสินค้าที่รับเข้าบาร์โค๊ต"
        Me.จำนวนรับSN.Width = 70
        '
        'SN
        '
        Me.SN.DataPropertyName = "SN"
        Me.SN.FillWeight = 50.0!
        Me.SN.HeaderText = "จำนวนรับSN"
        Me.SN.Name = "SN"
        Me.SN.ReadOnly = True
        Me.SN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SN.ToolTipText = "จำนวนรับสินค้าที่เป็น Serial Number"
        Me.SN.Width = 70
        '
        'unit
        '
        Me.unit.DataPropertyName = "unit"
        Me.unit.FillWeight = 50.0!
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.ToolTipText = "หน่วย"
        Me.unit.Width = 50
        '
        'total_all
        '
        Me.total_all.DataPropertyName = "total_all"
        Me.total_all.FillWeight = 70.0!
        Me.total_all.HeaderText = "รวมทุน"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all.ToolTipText = "ราคาทุน x จำนวนที่สั่งซื้อ"
        Me.total_all.Width = 70
        '
        'dgRPsn
        '
        Me.dgRPsn.AllowUserToAddRows = False
        Me.dgRPsn.AllowUserToDeleteRows = False
        Me.dgRPsn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgRPsn.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgRPsn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRPsn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serial_pro, Me.namepro, Me.codepro})
        Me.dgRPsn.Location = New System.Drawing.Point(692, 124)
        Me.dgRPsn.Name = "dgRPsn"
        Me.dgRPsn.ReadOnly = True
        Me.dgRPsn.RowHeadersVisible = False
        Me.dgRPsn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRPsn.Size = New System.Drawing.Size(242, 213)
        Me.dgRPsn.TabIndex = 2
        '
        'serial_pro
        '
        Me.serial_pro.DataPropertyName = "serial_pro"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.serial_pro.DefaultCellStyle = DataGridViewCellStyle5
        Me.serial_pro.Frozen = True
        Me.serial_pro.HeaderText = "SerialNumber"
        Me.serial_pro.Name = "serial_pro"
        Me.serial_pro.ReadOnly = True
        Me.serial_pro.ToolTipText = "หมายเลขประจำตัวสินค้า"
        Me.serial_pro.Width = 80
        '
        'namepro
        '
        Me.namepro.DataPropertyName = "name_pro"
        Me.namepro.HeaderText = "ชื่อสินค้า"
        Me.namepro.Name = "namepro"
        Me.namepro.ReadOnly = True
        Me.namepro.Width = 200
        '
        'codepro
        '
        Me.codepro.DataPropertyName = "code_pro"
        Me.codepro.HeaderText = "รหัสสินค้า"
        Me.codepro.Name = "codepro"
        Me.codepro.ReadOnly = True
        '
        'btnRPsave
        '
        Me.btnRPsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRPsave.Location = New System.Drawing.Point(598, 343)
        Me.btnRPsave.Name = "btnRPsave"
        Me.btnRPsave.Size = New System.Drawing.Size(336, 43)
        Me.btnRPsave.TabIndex = 3
        Me.btnRPsave.Text = "บันทึก"
        Me.ToolTipRP.SetToolTip(Me.btnRPsave, "บันทึกข้อมูลเข้าระบบ จงแน่ใจว่าทุกอย่างถูกต้อง")
        Me.btnRPsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "เลขที่รับเข้า"
        '
        'lblRPStatus
        '
        Me.lblRPStatus.AutoSize = True
        Me.lblRPStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRPStatus.Location = New System.Drawing.Point(538, 15)
        Me.lblRPStatus.Name = "lblRPStatus"
        Me.lblRPStatus.Size = New System.Drawing.Size(39, 16)
        Me.lblRPStatus.TabIndex = 6
        Me.lblRPStatus.Text = "สถานะ"
        '
        'btnRPselectOrder
        '
        Me.btnRPselectOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPselectOrder.Location = New System.Drawing.Point(840, 12)
        Me.btnRPselectOrder.Name = "btnRPselectOrder"
        Me.btnRPselectOrder.Size = New System.Drawing.Size(94, 23)
        Me.btnRPselectOrder.TabIndex = 8
        Me.btnRPselectOrder.Text = "เลือกใบสั่งซื้อ"
        Me.ToolTipRP.SetToolTip(Me.btnRPselectOrder, "ค้นหาใบสั่งซื้อ")
        Me.btnRPselectOrder.UseVisualStyleBackColor = True
        '
        'txtRPserialPro
        '
        Me.txtRPserialPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRPserialPro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRPserialPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPserialPro.Location = New System.Drawing.Point(725, 95)
        Me.txtRPserialPro.Name = "txtRPserialPro"
        Me.txtRPserialPro.Size = New System.Drawing.Size(122, 22)
        Me.txtRPserialPro.TabIndex = 9
        Me.ToolTipRP.SetToolTip(Me.txtRPserialPro, "สินค้าที่มี Serial Number ให้ใส่หมายเลข SN สินค้าที่นี่")
        '
        'btnRPaddSN
        '
        Me.btnRPaddSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPaddSN.Location = New System.Drawing.Point(853, 95)
        Me.btnRPaddSN.Name = "btnRPaddSN"
        Me.btnRPaddSN.Size = New System.Drawing.Size(41, 23)
        Me.btnRPaddSN.TabIndex = 10
        Me.btnRPaddSN.Text = "เพิ่ม"
        Me.ToolTipRP.SetToolTip(Me.btnRPaddSN, "เพิ่มหมายเลข SN")
        Me.btnRPaddSN.UseVisualStyleBackColor = True
        '
        'btnRPdelSN
        '
        Me.btnRPdelSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPdelSN.Location = New System.Drawing.Point(900, 95)
        Me.btnRPdelSN.Name = "btnRPdelSN"
        Me.btnRPdelSN.Size = New System.Drawing.Size(34, 23)
        Me.btnRPdelSN.TabIndex = 11
        Me.btnRPdelSN.Text = "ลบ"
        Me.ToolTipRP.SetToolTip(Me.btnRPdelSN, "ลบหมายเลข SN")
        Me.btnRPdelSN.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(692, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "SN"
        Me.ToolTipRP.SetToolTip(Me.Label4, "หมายเลขประจำสินค้า")
        '
        'txtRSorderID
        '
        Me.txtRSorderID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRSorderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRSorderID.Location = New System.Drawing.Point(710, 12)
        Me.txtRSorderID.Name = "txtRSorderID"
        Me.txtRSorderID.Size = New System.Drawing.Size(124, 22)
        Me.txtRSorderID.TabIndex = 13
        Me.ToolTipRP.SetToolTip(Me.txtRSorderID, "ค้นหาใส่เลขที่ใบสั่งซื้อแล้วกด enter")
        '
        'txtRPid
        '
        Me.txtRPid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPid.Location = New System.Drawing.Point(78, 12)
        Me.txtRPid.Name = "txtRPid"
        Me.txtRPid.ReadOnly = True
        Me.txtRPid.Size = New System.Drawing.Size(167, 22)
        Me.txtRPid.TabIndex = 14
        Me.ToolTipRP.SetToolTip(Me.txtRPid, "เลขที่บิลรับเข้าสร้างอัตโนมัติ")
        '
        'cbRPstatus
        '
        Me.cbRPstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRPstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRPstatus.FormattingEnabled = True
        Me.cbRPstatus.Location = New System.Drawing.Point(583, 12)
        Me.cbRPstatus.Name = "cbRPstatus"
        Me.cbRPstatus.Size = New System.Drawing.Size(121, 21)
        Me.cbRPstatus.TabIndex = 15
        Me.ToolTipRP.SetToolTip(Me.cbRPstatus, "สถานะการจ่ายเงิน")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ซื้อมาจาก"
        '
        'txtRPsumMoney
        '
        Me.txtRPsumMoney.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRPsumMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPsumMoney.Location = New System.Drawing.Point(67, 315)
        Me.txtRPsumMoney.Name = "txtRPsumMoney"
        Me.txtRPsumMoney.ReadOnly = True
        Me.txtRPsumMoney.Size = New System.Drawing.Size(619, 24)
        Me.txtRPsumMoney.TabIndex = 17
        Me.txtRPsumMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipRP.SetToolTip(Me.txtRPsumMoney, "ยอดรวมราคาสินค้าที่สั่งซื้อมา")
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "รวมเงิน"
        '
        'txtRPsale_company_name
        '
        Me.txtRPsale_company_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPsale_company_name.Location = New System.Drawing.Point(68, 40)
        Me.txtRPsale_company_name.Name = "txtRPsale_company_name"
        Me.txtRPsale_company_name.ReadOnly = True
        Me.txtRPsale_company_name.Size = New System.Drawing.Size(177, 22)
        Me.txtRPsale_company_name.TabIndex = 19
        Me.ToolTipRP.SetToolTip(Me.txtRPsale_company_name, "บริษัทที่จัดซื้อสินค้าชุดนี้มา")
        '
        'txtRPbillID
        '
        Me.txtRPbillID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRPbillID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPbillID.Location = New System.Drawing.Point(556, 40)
        Me.txtRPbillID.Name = "txtRPbillID"
        Me.txtRPbillID.Size = New System.Drawing.Size(157, 22)
        Me.txtRPbillID.TabIndex = 20
        Me.txtRPbillID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipRP.SetToolTip(Me.txtRPbillID, "เลขที่บิลที่ซื้อสินค้ามา ถ้าไม่มีให้ - ไว้")
        '
        'lblRPbillID
        '
        Me.lblRPbillID.AutoSize = True
        Me.lblRPbillID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRPbillID.Location = New System.Drawing.Point(457, 43)
        Me.lblRPbillID.Name = "lblRPbillID"
        Me.lblRPbillID.Size = New System.Drawing.Size(93, 16)
        Me.lblRPbillID.TabIndex = 21
        Me.lblRPbillID.Text = "เลขที่เอกสารรับเข้า"
        Me.ToolTipRP.SetToolTip(Me.lblRPbillID, "เลขที่บิลที่ซื้อสินค้ามา ถ้าไม่มีให้ - ไว้")
        '
        'DateTimePickerRP
        '
        Me.DateTimePickerRP.AllowDrop = True
        Me.DateTimePickerRP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePickerRP.Location = New System.Drawing.Point(251, 13)
        Me.DateTimePickerRP.Name = "DateTimePickerRP"
        Me.DateTimePickerRP.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerRP.TabIndex = 22
        Me.ToolTipRP.SetToolTip(Me.DateTimePickerRP, "วันที่รับสินค้าเข้า")
        '
        'btnRPclear
        '
        Me.btnRPclear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRPclear.Location = New System.Drawing.Point(487, 343)
        Me.btnRPclear.Name = "btnRPclear"
        Me.btnRPclear.Size = New System.Drawing.Size(105, 43)
        Me.btnRPclear.TabIndex = 23
        Me.btnRPclear.Text = "ล้างรายการ"
        Me.ToolTipRP.SetToolTip(Me.btnRPclear, "ล้างรายการทั้งหมดในหน้าจอนี้")
        Me.btnRPclear.UseVisualStyleBackColor = True
        '
        'ToolTipRP
        '
        Me.ToolTipRP.AutoPopDelay = 5000
        Me.ToolTipRP.InitialDelay = 300
        Me.ToolTipRP.ReshowDelay = 300
        '
        'txtRPbuy_id
        '
        Me.txtRPbuy_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRPbuy_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPbuy_id.Location = New System.Drawing.Point(251, 40)
        Me.txtRPbuy_id.Name = "txtRPbuy_id"
        Me.txtRPbuy_id.ReadOnly = True
        Me.txtRPbuy_id.Size = New System.Drawing.Size(200, 22)
        Me.txtRPbuy_id.TabIndex = 24
        Me.ToolTipRP.SetToolTip(Me.txtRPbuy_id, "เลขที่ใบสั่งซื่้อ")
        '
        'txtRPbarcode
        '
        Me.txtRPbarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRPbarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRPbarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPbarcode.Location = New System.Drawing.Point(743, 67)
        Me.txtRPbarcode.Name = "txtRPbarcode"
        Me.txtRPbarcode.Size = New System.Drawing.Size(104, 22)
        Me.txtRPbarcode.TabIndex = 25
        Me.ToolTipRP.SetToolTip(Me.txtRPbarcode, "รหัสประจำสินค้า(บาร์โค๊ต)")
        '
        'btnRPaddBarcode
        '
        Me.btnRPaddBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPaddBarcode.Location = New System.Drawing.Point(853, 67)
        Me.btnRPaddBarcode.Name = "btnRPaddBarcode"
        Me.btnRPaddBarcode.Size = New System.Drawing.Size(41, 23)
        Me.btnRPaddBarcode.TabIndex = 26
        Me.btnRPaddBarcode.Text = "เพิ่ม"
        Me.ToolTipRP.SetToolTip(Me.btnRPaddBarcode, "เพิ่มหมายเลข บาร์โค๊ต")
        Me.btnRPaddBarcode.UseVisualStyleBackColor = True
        '
        'btnRPdelBarcode
        '
        Me.btnRPdelBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPdelBarcode.Location = New System.Drawing.Point(900, 67)
        Me.btnRPdelBarcode.Name = "btnRPdelBarcode"
        Me.btnRPdelBarcode.Size = New System.Drawing.Size(34, 23)
        Me.btnRPdelBarcode.TabIndex = 27
        Me.btnRPdelBarcode.Text = "ลบ"
        Me.ToolTipRP.SetToolTip(Me.btnRPdelBarcode, "ลบหมายเลข บาร์โค๊ต")
        Me.btnRPdelBarcode.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(689, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "BarCode"
        Me.ToolTipRP.SetToolTip(Me.Label2, "รหัสประจำสินค้า(บาร์โค๊ต)")
        '
        'txtRPnamePro
        '
        Me.txtRPnamePro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRPnamePro.BackColor = System.Drawing.Color.Black
        Me.txtRPnamePro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRPnamePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPnamePro.ForeColor = System.Drawing.Color.White
        Me.txtRPnamePro.Location = New System.Drawing.Point(12, 64)
        Me.txtRPnamePro.Name = "txtRPnamePro"
        Me.txtRPnamePro.ReadOnly = True
        Me.txtRPnamePro.Size = New System.Drawing.Size(674, 24)
        Me.txtRPnamePro.TabIndex = 29
        Me.txtRPnamePro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipRP.SetToolTip(Me.txtRPnamePro, "คลิ๊กเลือกสินค้าจากตารางด้านซ้ายแล้วใส่ BarCode หรือ SN")
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.Location = New System.Drawing.Point(779, 41)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(68, 20)
        Me.NumericUpDown1.TabIndex = 30
        Me.ToolTipRP.SetToolTip(Me.NumericUpDown1, "กำหนดจำนวนสินค้าที่นำเข้า(สินค้าบาร์โค๊ตเท่านั้น)")
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnRPaddBCnum
        '
        Me.btnRPaddBCnum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPaddBCnum.Location = New System.Drawing.Point(853, 40)
        Me.btnRPaddBCnum.Name = "btnRPaddBCnum"
        Me.btnRPaddBCnum.Size = New System.Drawing.Size(41, 23)
        Me.btnRPaddBCnum.TabIndex = 31
        Me.btnRPaddBCnum.Text = "เพิ่ม"
        Me.ToolTipRP.SetToolTip(Me.btnRPaddBCnum, "เพิ่มจำนวนสินค้าบาร์โค๊ต")
        Me.btnRPaddBCnum.UseVisualStyleBackColor = True
        '
        'btnRPdelBCnum
        '
        Me.btnRPdelBCnum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPdelBCnum.Location = New System.Drawing.Point(900, 40)
        Me.btnRPdelBCnum.Name = "btnRPdelBCnum"
        Me.btnRPdelBCnum.Size = New System.Drawing.Size(34, 23)
        Me.btnRPdelBCnum.TabIndex = 32
        Me.btnRPdelBCnum.Text = "ลบ"
        Me.ToolTipRP.SetToolTip(Me.btnRPdelBCnum, "ลบจำนวนสินค้าบาร์โค๊ต")
        Me.btnRPdelBCnum.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(719, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "จำนวนBC"
        Me.ToolTipRP.SetToolTip(Me.Label3, "รหัสประจำสินค้า(บาร์โค๊ต)")
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 379)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 34
        Me.lblemployee.Text = "User"
        '
        'ReceiveProductFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 401)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRPdelBCnum)
        Me.Controls.Add(Me.btnRPaddBCnum)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.txtRPnamePro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRPdelBarcode)
        Me.Controls.Add(Me.btnRPaddBarcode)
        Me.Controls.Add(Me.txtRPbarcode)
        Me.Controls.Add(Me.txtRPbuy_id)
        Me.Controls.Add(Me.btnRPclear)
        Me.Controls.Add(Me.DateTimePickerRP)
        Me.Controls.Add(Me.lblRPbillID)
        Me.Controls.Add(Me.txtRPbillID)
        Me.Controls.Add(Me.txtRPsale_company_name)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRPsumMoney)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbRPstatus)
        Me.Controls.Add(Me.txtRPid)
        Me.Controls.Add(Me.txtRSorderID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRPdelSN)
        Me.Controls.Add(Me.btnRPaddSN)
        Me.Controls.Add(Me.txtRPserialPro)
        Me.Controls.Add(Me.btnRPselectOrder)
        Me.Controls.Add(Me.lblRPStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRPsave)
        Me.Controls.Add(Me.dgRPsn)
        Me.Controls.Add(Me.dgRPorderPro)
        Me.Name = "ReceiveProductFrm"
        Me.Text = "รับสินค้าเข้าระบบ"
        CType(Me.dgRPorderPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRPsn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgRPorderPro As System.Windows.Forms.DataGridView
    Friend WithEvents dgRPsn As System.Windows.Forms.DataGridView
    Friend WithEvents btnRPsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRPStatus As System.Windows.Forms.Label
    Friend WithEvents btnRPselectOrder As System.Windows.Forms.Button
    Friend WithEvents txtRPserialPro As System.Windows.Forms.TextBox
    Friend WithEvents btnRPaddSN As System.Windows.Forms.Button
    Friend WithEvents btnRPdelSN As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRSorderID As System.Windows.Forms.TextBox
    Friend WithEvents txtRPid As System.Windows.Forms.TextBox
    Friend WithEvents cbRPstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRPsumMoney As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRPsale_company_name As System.Windows.Forms.TextBox
    Friend WithEvents txtRPbillID As System.Windows.Forms.TextBox
    Friend WithEvents lblRPbillID As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerRP As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRPclear As System.Windows.Forms.Button
    Friend WithEvents ToolTipRP As System.Windows.Forms.ToolTip
    Friend WithEvents txtRPbuy_id As System.Windows.Forms.TextBox
    Friend WithEvents txtRPbarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnRPaddBarcode As System.Windows.Forms.Button
    Friend WithEvents btnRPdelBarcode As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents serial_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namepro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codepro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtRPnamePro As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnRPaddBCnum As System.Windows.Forms.Button
    Friend WithEvents btnRPdelBCnum As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents จำนวนรับSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
