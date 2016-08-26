<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaxInvoiceFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtTIcusid = New System.Windows.Forms.TextBox()
        Me.txtTIcusname = New System.Windows.Forms.TextBox()
        Me.txtTIcusaddress = New System.Windows.Forms.TextBox()
        Me.txtTIcustel = New System.Windows.Forms.TextBox()
        Me.cbbTIselectbill = New System.Windows.Forms.ComboBox()
        Me.txtTIbillID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTIsearchBillID = New System.Windows.Forms.TextBox()
        Me.ToolTipTI = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgTI = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTIserachBill = New System.Windows.Forms.Button()
        Me.txtTIsearchBarcode = New System.Windows.Forms.TextBox()
        Me.txtTIdiscount1 = New System.Windows.Forms.TextBox()
        Me.btnTIsearchOldBill = New System.Windows.Forms.Button()
        Me.cbTaxUpdate = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTIsearchBarcode = New System.Windows.Forms.Button()
        Me.txtTInote = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbTI = New System.Windows.Forms.CheckBox()
        Me.txtTItotalPro = New System.Windows.Forms.TextBox()
        Me.txtTItotal = New System.Windows.Forms.TextBox()
        Me.txtTItotalTax = New System.Windows.Forms.TextBox()
        Me.txtTItotalAll = New System.Windows.Forms.TextBox()
        Me.txtTItahitext = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTItaxNumber = New System.Windows.Forms.TextBox()
        Me.txtTItaxSection = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rbTItotaltax = New System.Windows.Forms.RadioButton()
        Me.rbTIuntax = New System.Windows.Forms.RadioButton()
        Me.txtTItaxpercen = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnTIsavePrint = New System.Windows.Forms.Button()
        Me.btnTIcancel = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbTIdiscount = New System.Windows.Forms.CheckBox()
        Me.cbTItexpro = New System.Windows.Forms.CheckBox()
        Me.btnTIsearchCus = New System.Windows.Forms.Button()
        Me.txtTIm_number = New System.Windows.Forms.TextBox()
        Me.cbTIact = New System.Windows.Forms.CheckBox()
        Me.txtTIkuru = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgTI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTIcusid
        '
        Me.txtTIcusid.BackColor = System.Drawing.Color.Moccasin
        Me.txtTIcusid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTIcusid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIcusid.Location = New System.Drawing.Point(80, 0)
        Me.txtTIcusid.Name = "txtTIcusid"
        Me.txtTIcusid.Size = New System.Drawing.Size(120, 26)
        Me.txtTIcusid.TabIndex = 0
        Me.txtTIcusid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTIcusname
        '
        Me.txtTIcusname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIcusname.Location = New System.Drawing.Point(199, 0)
        Me.txtTIcusname.Name = "txtTIcusname"
        Me.txtTIcusname.Size = New System.Drawing.Size(217, 26)
        Me.txtTIcusname.TabIndex = 1
        '
        'txtTIcusaddress
        '
        Me.txtTIcusaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIcusaddress.Location = New System.Drawing.Point(80, 25)
        Me.txtTIcusaddress.Multiline = True
        Me.txtTIcusaddress.Name = "txtTIcusaddress"
        Me.txtTIcusaddress.Size = New System.Drawing.Size(336, 62)
        Me.txtTIcusaddress.TabIndex = 2
        '
        'txtTIcustel
        '
        Me.txtTIcustel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIcustel.Location = New System.Drawing.Point(80, 86)
        Me.txtTIcustel.Name = "txtTIcustel"
        Me.txtTIcustel.Size = New System.Drawing.Size(336, 26)
        Me.txtTIcustel.TabIndex = 3
        '
        'cbbTIselectbill
        '
        Me.cbbTIselectbill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTIselectbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbTIselectbill.FormattingEnabled = True
        Me.cbbTIselectbill.Location = New System.Drawing.Point(579, 12)
        Me.cbbTIselectbill.Name = "cbbTIselectbill"
        Me.cbbTIselectbill.Size = New System.Drawing.Size(255, 28)
        Me.cbbTIselectbill.TabIndex = 4
        '
        'txtTIbillID
        '
        Me.txtTIbillID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIbillID.Location = New System.Drawing.Point(579, 46)
        Me.txtTIbillID.Name = "txtTIbillID"
        Me.txtTIbillID.ReadOnly = True
        Me.txtTIbillID.Size = New System.Drawing.Size(255, 26)
        Me.txtTIbillID.TabIndex = 6
        Me.txtTIbillID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ที่อยู่"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "เบอร์โทร"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(492, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ชนิดใบเสร็จ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(531, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "เลขที่"
        '
        'txtTIsearchBillID
        '
        Me.txtTIsearchBillID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTIsearchBillID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIsearchBillID.Location = New System.Drawing.Point(105, 118)
        Me.txtTIsearchBillID.Name = "txtTIsearchBillID"
        Me.txtTIsearchBillID.Size = New System.Drawing.Size(212, 26)
        Me.txtTIsearchBillID.TabIndex = 12
        Me.txtTIsearchBillID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipTI.SetToolTip(Me.txtTIsearchBillID, "ใส่เลขที่ใบเบิกสินค้า, ใบส่งซ่อม")
        '
        'ToolTipTI
        '
        Me.ToolTipTI.IsBalloon = True
        '
        'dgTI
        '
        Me.dgTI.AllowUserToAddRows = False
        Me.dgTI.AllowUserToDeleteRows = False
        Me.dgTI.AllowUserToOrderColumns = True
        Me.dgTI.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgTI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.code_pro, Me.name_pro, Me.total, Me.unit, Me.price_buy, Me.total_all})
        Me.dgTI.Location = New System.Drawing.Point(12, 150)
        Me.dgTI.Name = "dgTI"
        Me.dgTI.RowHeadersVisible = False
        Me.dgTI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTI.Size = New System.Drawing.Size(822, 241)
        Me.dgTI.TabIndex = 15
        Me.ToolTipTI.SetToolTip(Me.dgTI, "คุณสามารุแก้ไขชื่อ ราคา ของสินค้าได้ตามแบบของคุณเอง")
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.no.DefaultCellStyle = DataGridViewCellStyle1
        Me.no.Frozen = True
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'code_pro
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.code_pro.DefaultCellStyle = DataGridViewCellStyle2
        Me.code_pro.Frozen = True
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.Width = 140
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 300
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "ปริมาณ"
        Me.total.Name = "total"
        Me.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total.Width = 80
        '
        'unit
        '
        Me.unit.DataPropertyName = "unit"
        Me.unit.HeaderText = "หน่วยนับ"
        Me.unit.Name = "unit"
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.Width = 80
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        Me.price_buy.HeaderText = "ราคา"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.Width = 80
        '
        'total_all
        '
        Me.total_all.DataPropertyName = "total_all"
        Me.total_all.HeaderText = "รวมเงิน"
        Me.total_all.Name = "total_all"
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all.Width = 80
        '
        'btnTIserachBill
        '
        Me.btnTIserachBill.Location = New System.Drawing.Point(323, 121)
        Me.btnTIserachBill.Name = "btnTIserachBill"
        Me.btnTIserachBill.Size = New System.Drawing.Size(93, 23)
        Me.btnTIserachBill.TabIndex = 14
        Me.btnTIserachBill.Text = "ค้นหา"
        Me.ToolTipTI.SetToolTip(Me.btnTIserachBill, "ค้นหาใบเบิกสินค้า, ใบส่งซ่อม")
        Me.btnTIserachBill.UseVisualStyleBackColor = True
        '
        'txtTIsearchBarcode
        '
        Me.txtTIsearchBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTIsearchBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIsearchBarcode.Location = New System.Drawing.Point(558, 103)
        Me.txtTIsearchBarcode.Name = "txtTIsearchBarcode"
        Me.txtTIsearchBarcode.Size = New System.Drawing.Size(212, 26)
        Me.txtTIsearchBarcode.TabIndex = 17
        Me.txtTIsearchBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipTI.SetToolTip(Me.txtTIsearchBarcode, "ป้อนรหัสสินค้าหรือบาร์โค๊ตสินค้า")
        '
        'txtTIdiscount1
        '
        Me.txtTIdiscount1.BackColor = System.Drawing.Color.Moccasin
        Me.txtTIdiscount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIdiscount1.Location = New System.Drawing.Point(690, 452)
        Me.txtTIdiscount1.Name = "txtTIdiscount1"
        Me.txtTIdiscount1.Size = New System.Drawing.Size(144, 26)
        Me.txtTIdiscount1.TabIndex = 24
        Me.txtTIdiscount1.Text = "0"
        Me.txtTIdiscount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipTI.SetToolTip(Me.txtTIdiscount1, "ใส่ตัวเลขแล้วกด enter")
        '
        'btnTIsearchOldBill
        '
        Me.btnTIsearchOldBill.Location = New System.Drawing.Point(579, 76)
        Me.btnTIsearchOldBill.Name = "btnTIsearchOldBill"
        Me.btnTIsearchOldBill.Size = New System.Drawing.Size(255, 23)
        Me.btnTIsearchOldBill.TabIndex = 46
        Me.btnTIsearchOldBill.Text = "ค้นหาใบเสร็จ"
        Me.ToolTipTI.SetToolTip(Me.btnTIsearchOldBill, "ค้นหาเอกสารที่บันทึกไว้")
        Me.btnTIsearchOldBill.UseVisualStyleBackColor = True
        '
        'cbTaxUpdate
        '
        Me.cbTaxUpdate.AutoSize = True
        Me.cbTaxUpdate.Location = New System.Drawing.Point(112, 453)
        Me.cbTaxUpdate.Name = "cbTaxUpdate"
        Me.cbTaxUpdate.Size = New System.Drawing.Size(219, 17)
        Me.cbTaxUpdate.TabIndex = 54
        Me.cbTaxUpdate.Text = "บันทึกข้อมูลผู้เสียภาษีไปยังฐานข้อมูลลูกค้า"
        Me.ToolTipTI.SetToolTip(Me.cbTaxUpdate, "บันทึกข้อมูลผู้เสียภาษีไปยังฐานข้อมูลรายชื่อลูกค้าด้วย")
        Me.cbTaxUpdate.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "เลขที่เอกสาร"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(436, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ป้อนบาร์โค๊ตสินค้า"
        '
        'btnTIsearchBarcode
        '
        Me.btnTIsearchBarcode.Location = New System.Drawing.Point(776, 104)
        Me.btnTIsearchBarcode.Name = "btnTIsearchBarcode"
        Me.btnTIsearchBarcode.Size = New System.Drawing.Size(58, 23)
        Me.btnTIsearchBarcode.TabIndex = 18
        Me.btnTIsearchBarcode.Text = "ค้นหา"
        Me.btnTIsearchBarcode.UseVisualStyleBackColor = True
        '
        'txtTInote
        '
        Me.txtTInote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTInote.Location = New System.Drawing.Point(77, 424)
        Me.txtTInote.Name = "txtTInote"
        Me.txtTInote.Size = New System.Drawing.Size(240, 26)
        Me.txtTInote.TabIndex = 19
        Me.txtTInote.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 427)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "หมายเหตุ"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(358, 423)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(194, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'cbTI
        '
        Me.cbTI.AutoSize = True
        Me.cbTI.Checked = True
        Me.cbTI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTI.Location = New System.Drawing.Point(358, 400)
        Me.cbTI.Name = "cbTI"
        Me.cbTI.Size = New System.Drawing.Size(58, 17)
        Me.cbTI.TabIndex = 22
        Me.cbTI.Text = "ลงวันที่"
        Me.cbTI.UseVisualStyleBackColor = True
        '
        'txtTItotalPro
        '
        Me.txtTItotalPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItotalPro.Location = New System.Drawing.Point(690, 427)
        Me.txtTItotalPro.Name = "txtTItotalPro"
        Me.txtTItotalPro.ReadOnly = True
        Me.txtTItotalPro.Size = New System.Drawing.Size(144, 26)
        Me.txtTItotalPro.TabIndex = 23
        Me.txtTItotalPro.Text = "0"
        Me.txtTItotalPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTItotal
        '
        Me.txtTItotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItotal.Location = New System.Drawing.Point(690, 477)
        Me.txtTItotal.Name = "txtTItotal"
        Me.txtTItotal.ReadOnly = True
        Me.txtTItotal.Size = New System.Drawing.Size(144, 26)
        Me.txtTItotal.TabIndex = 25
        Me.txtTItotal.Text = "0"
        Me.txtTItotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTItotalTax
        '
        Me.txtTItotalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItotalTax.Location = New System.Drawing.Point(690, 502)
        Me.txtTItotalTax.Name = "txtTItotalTax"
        Me.txtTItotalTax.ReadOnly = True
        Me.txtTItotalTax.Size = New System.Drawing.Size(144, 26)
        Me.txtTItotalTax.TabIndex = 26
        Me.txtTItotalTax.Text = "0"
        Me.txtTItotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTItotalAll
        '
        Me.txtTItotalAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItotalAll.Location = New System.Drawing.Point(690, 527)
        Me.txtTItotalAll.Name = "txtTItotalAll"
        Me.txtTItotalAll.ReadOnly = True
        Me.txtTItotalAll.Size = New System.Drawing.Size(144, 26)
        Me.txtTItotalAll.TabIndex = 27
        Me.txtTItotalAll.Text = "0"
        Me.txtTItotalAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTItahitext
        '
        Me.txtTItahitext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItahitext.Location = New System.Drawing.Point(367, 552)
        Me.txtTItahitext.Name = "txtTItahitext"
        Me.txtTItahitext.ReadOnly = True
        Me.txtTItahitext.Size = New System.Drawing.Size(467, 26)
        Me.txtTItahitext.TabIndex = 28
        Me.txtTItahitext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(626, 430)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 20)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "ค่าสินค้า"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(634, 455)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 20)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "ส่วนลด"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(626, 480)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 20)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "ยอดเงิน"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(590, 505)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 20)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "ภาษีมูลค่าเพิ่ม"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(624, 530)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 20)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "ยอดสุทธิ"
        '
        'txtTItaxNumber
        '
        Me.txtTItaxNumber.BackColor = System.Drawing.Color.Moccasin
        Me.txtTItaxNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItaxNumber.Location = New System.Drawing.Point(12, 471)
        Me.txtTItaxNumber.Name = "txtTItaxNumber"
        Me.txtTItaxNumber.Size = New System.Drawing.Size(168, 26)
        Me.txtTItaxNumber.TabIndex = 34
        Me.txtTItaxNumber.Text = "0"
        Me.txtTItaxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTItaxSection
        '
        Me.txtTItaxSection.BackColor = System.Drawing.Color.Moccasin
        Me.txtTItaxSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItaxSection.Location = New System.Drawing.Point(179, 471)
        Me.txtTItaxSection.Name = "txtTItaxSection"
        Me.txtTItaxSection.Size = New System.Drawing.Size(138, 26)
        Me.txtTItaxSection.TabIndex = 35
        Me.txtTItaxSection.Text = "สำนักงานใหญ่"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 452)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 16)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "เลขผู้เสียภาษี(ลูกค้า)"
        '
        'rbTItotaltax
        '
        Me.rbTItotaltax.AutoSize = True
        Me.rbTItotaltax.Location = New System.Drawing.Point(367, 460)
        Me.rbTItotaltax.Name = "rbTItotaltax"
        Me.rbTItotaltax.Size = New System.Drawing.Size(52, 17)
        Me.rbTItotaltax.TabIndex = 37
        Me.rbTItotaltax.Text = "มีภาษี"
        Me.rbTItotaltax.UseVisualStyleBackColor = True
        '
        'rbTIuntax
        '
        Me.rbTIuntax.AutoSize = True
        Me.rbTIuntax.Checked = True
        Me.rbTIuntax.Location = New System.Drawing.Point(367, 483)
        Me.rbTIuntax.Name = "rbTIuntax"
        Me.rbTIuntax.Size = New System.Drawing.Size(65, 17)
        Me.rbTIuntax.TabIndex = 38
        Me.rbTIuntax.TabStop = True
        Me.rbTIuntax.Text = "ไม่มีภาษี"
        Me.rbTIuntax.UseVisualStyleBackColor = True
        '
        'txtTItaxpercen
        '
        Me.txtTItaxpercen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItaxpercen.Location = New System.Drawing.Point(440, 471)
        Me.txtTItaxpercen.Name = "txtTItaxpercen"
        Me.txtTItaxpercen.Size = New System.Drawing.Size(38, 26)
        Me.txtTItaxpercen.TabIndex = 39
        Me.txtTItaxpercen.Text = "0"
        Me.txtTItaxpercen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(484, 474)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 20)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "%"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(364, 530)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 16)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "จำนวนเงิน(ตัวอักษร)"
        '
        'btnTIsavePrint
        '
        Me.btnTIsavePrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnTIsavePrint.Location = New System.Drawing.Point(17, 533)
        Me.btnTIsavePrint.Name = "btnTIsavePrint"
        Me.btnTIsavePrint.Size = New System.Drawing.Size(140, 38)
        Me.btnTIsavePrint.TabIndex = 42
        Me.btnTIsavePrint.Text = "บันทึก/พิมพ์"
        Me.btnTIsavePrint.UseVisualStyleBackColor = True
        '
        'btnTIcancel
        '
        Me.btnTIcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnTIcancel.Location = New System.Drawing.Point(163, 533)
        Me.btnTIcancel.Name = "btnTIcancel"
        Me.btnTIcancel.Size = New System.Drawing.Size(140, 38)
        Me.btnTIcancel.TabIndex = 43
        Me.btnTIcancel.Text = "ยกเลิก"
        Me.btnTIcancel.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(14, 503)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(224, 16)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "ขนาดเอกสาร A4 โปรดเตรียมกระดาษให้ถูกต้อง"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(664, 131)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(170, 16)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "ใช้ปุ่ม Delete เพื่อลบรายการสินค้า"
        '
        'cbTIdiscount
        '
        Me.cbTIdiscount.AutoSize = True
        Me.cbTIdiscount.Location = New System.Drawing.Point(422, 400)
        Me.cbTIdiscount.Name = "cbTIdiscount"
        Me.cbTIdiscount.Size = New System.Drawing.Size(85, 17)
        Me.cbTIdiscount.TabIndex = 47
        Me.cbTIdiscount.Text = "แสดงส่วนลด"
        Me.cbTIdiscount.UseVisualStyleBackColor = True
        '
        'cbTItexpro
        '
        Me.cbTItexpro.AutoSize = True
        Me.cbTItexpro.Location = New System.Drawing.Point(513, 400)
        Me.cbTItexpro.Name = "cbTItexpro"
        Me.cbTItexpro.Size = New System.Drawing.Size(117, 17)
        Me.cbTItexpro.TabIndex = 48
        Me.cbTItexpro.Text = "แสดงภาษีมูลค่าเพิ่ม"
        Me.cbTItexpro.UseVisualStyleBackColor = True
        '
        'btnTIsearchCus
        '
        Me.btnTIsearchCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnTIsearchCus.Location = New System.Drawing.Point(2, 0)
        Me.btnTIsearchCus.Name = "btnTIsearchCus"
        Me.btnTIsearchCus.Size = New System.Drawing.Size(78, 23)
        Me.btnTIsearchCus.TabIndex = 49
        Me.btnTIsearchCus.Text = "รหัสลูกค้า"
        Me.btnTIsearchCus.UseVisualStyleBackColor = True
        '
        'txtTIm_number
        '
        Me.txtTIm_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIm_number.Location = New System.Drawing.Point(199, 397)
        Me.txtTIm_number.Name = "txtTIm_number"
        Me.txtTIm_number.Size = New System.Drawing.Size(139, 26)
        Me.txtTIm_number.TabIndex = 50
        Me.txtTIm_number.Text = "-"
        '
        'cbTIact
        '
        Me.cbTIact.AutoSize = True
        Me.cbTIact.Enabled = False
        Me.cbTIact.Location = New System.Drawing.Point(636, 400)
        Me.cbTIact.Name = "cbTIact"
        Me.cbTIact.Size = New System.Drawing.Size(110, 17)
        Me.cbTIact.TabIndex = 52
        Me.cbTIact.Text = "ฟอร์มสำหรับ อบต."
        Me.cbTIact.UseVisualStyleBackColor = True
        Me.cbTIact.Visible = False
        '
        'txtTIkuru
        '
        Me.txtTIkuru.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIkuru.Location = New System.Drawing.Point(12, 397)
        Me.txtTIkuru.Name = "txtTIkuru"
        Me.txtTIkuru.Size = New System.Drawing.Size(181, 26)
        Me.txtTIkuru.TabIndex = 53
        Me.txtTIkuru.Text = "หมายเลขเครื่อง/รหัสครุภัณฑ์"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(17, 574)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 55
        Me.lblemployee.Text = "User"
        '
        'TaxInvoiceFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 587)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.cbTaxUpdate)
        Me.Controls.Add(Me.txtTIkuru)
        Me.Controls.Add(Me.cbTIact)
        Me.Controls.Add(Me.txtTIm_number)
        Me.Controls.Add(Me.btnTIsearchCus)
        Me.Controls.Add(Me.cbTItexpro)
        Me.Controls.Add(Me.cbTIdiscount)
        Me.Controls.Add(Me.btnTIsearchOldBill)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnTIcancel)
        Me.Controls.Add(Me.btnTIsavePrint)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTItaxpercen)
        Me.Controls.Add(Me.rbTIuntax)
        Me.Controls.Add(Me.rbTItotaltax)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTItaxSection)
        Me.Controls.Add(Me.txtTItaxNumber)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTItahitext)
        Me.Controls.Add(Me.txtTItotalAll)
        Me.Controls.Add(Me.txtTItotalTax)
        Me.Controls.Add(Me.txtTItotal)
        Me.Controls.Add(Me.txtTIdiscount1)
        Me.Controls.Add(Me.txtTItotalPro)
        Me.Controls.Add(Me.cbTI)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTInote)
        Me.Controls.Add(Me.btnTIsearchBarcode)
        Me.Controls.Add(Me.txtTIsearchBarcode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgTI)
        Me.Controls.Add(Me.btnTIserachBill)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTIsearchBillID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTIbillID)
        Me.Controls.Add(Me.cbbTIselectbill)
        Me.Controls.Add(Me.txtTIcustel)
        Me.Controls.Add(Me.txtTIcusaddress)
        Me.Controls.Add(Me.txtTIcusname)
        Me.Controls.Add(Me.txtTIcusid)
        Me.Name = "TaxInvoiceFrm"
        Me.Text = "ออกใบเสร็จรับเงิน/ใบกำกับภาษี"
        CType(Me.dgTI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTIcusid As System.Windows.Forms.TextBox
    Friend WithEvents txtTIcusname As System.Windows.Forms.TextBox
    Friend WithEvents txtTIcusaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTIcustel As System.Windows.Forms.TextBox
    Friend WithEvents cbbTIselectbill As System.Windows.Forms.ComboBox
    Friend WithEvents txtTIbillID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTIsearchBillID As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipTI As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnTIserachBill As System.Windows.Forms.Button
    Friend WithEvents dgTI As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnTIsearchBarcode As System.Windows.Forms.Button
    Friend WithEvents txtTIsearchBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtTInote As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbTI As System.Windows.Forms.CheckBox
    Friend WithEvents txtTItotalPro As System.Windows.Forms.TextBox
    Friend WithEvents txtTIdiscount1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTItotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTItotalTax As System.Windows.Forms.TextBox
    Friend WithEvents txtTItotalAll As System.Windows.Forms.TextBox
    Friend WithEvents txtTItahitext As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTItaxNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtTItaxSection As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rbTItotaltax As System.Windows.Forms.RadioButton
    Friend WithEvents rbTIuntax As System.Windows.Forms.RadioButton
    Friend WithEvents txtTItaxpercen As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnTIsavePrint As System.Windows.Forms.Button
    Friend WithEvents btnTIcancel As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnTIsearchOldBill As System.Windows.Forms.Button
    Friend WithEvents cbTIdiscount As System.Windows.Forms.CheckBox
    Friend WithEvents cbTItexpro As System.Windows.Forms.CheckBox
    Friend WithEvents btnTIsearchCus As System.Windows.Forms.Button
    Friend WithEvents txtTIm_number As System.Windows.Forms.TextBox
    Friend WithEvents cbTIact As System.Windows.Forms.CheckBox
    Friend WithEvents txtTIkuru As System.Windows.Forms.TextBox
    Friend WithEvents cbTaxUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
