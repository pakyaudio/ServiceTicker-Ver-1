<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendMoneyClaimsFrm
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblRPSale_id = New System.Windows.Forms.Label()
        Me.dgRPproBarcode = New System.Windows.Forms.DataGridView()
        Me.dgRPsendProBarcode = New System.Windows.Forms.DataGridView()
        Me.txtRP_ID = New System.Windows.Forms.TextBox()
        Me.ToolTipRP = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtRPcustomerName = New System.Windows.Forms.TextBox()
        Me.txtRPcustomerAddress = New System.Windows.Forms.TextBox()
        Me.txtRPcustomerTel = New System.Windows.Forms.TextBox()
        Me.txtRPcustomerID = New System.Windows.Forms.TextBox()
        Me.txtRPsnADD = New System.Windows.Forms.TextBox()
        Me.dgRPproSN = New System.Windows.Forms.DataGridView()
        Me.serial_proSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_proSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_proSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgRPsendProSN = New System.Windows.Forms.DataGridView()
        Me.SN2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codeproSN2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_proSN2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtRPsumall = New System.Windows.Forms.TextBox()
        Me.btnRPsave = New System.Windows.Forms.Button()
        Me.btnRPcancel = New System.Windows.Forms.Button()
        Me.lblRPreturnsSN = New System.Windows.Forms.Label()
        Me.txtRPreturnNote = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRPsearchSN = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRPsnOK = New System.Windows.Forms.Button()
        Me.lblRPStatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblRPreturnNote = New System.Windows.Forms.Label()
        Me.lblRPsale_id_show = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRPproductStatus = New System.Windows.Forms.Label()
        Me.lblRPnoteDetail = New System.Windows.Forms.Label()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codepro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namepro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.countnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.returns = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgRPproBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRPsendProBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRPproSN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRPsendProSN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRPSale_id
        '
        Me.lblRPSale_id.AutoSize = True
        Me.lblRPSale_id.Location = New System.Drawing.Point(12, 5)
        Me.lblRPSale_id.Name = "lblRPSale_id"
        Me.lblRPSale_id.Size = New System.Drawing.Size(133, 13)
        Me.lblRPSale_id.TabIndex = 2
        Me.lblRPSale_id.Text = "เลขที่บิลขาย รหัสขึ้นต้นด้วย"
        '
        'dgRPproBarcode
        '
        Me.dgRPproBarcode.AllowUserToAddRows = False
        Me.dgRPproBarcode.AllowUserToDeleteRows = False
        Me.dgRPproBarcode.AllowUserToOrderColumns = True
        Me.dgRPproBarcode.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgRPproBarcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRPproBarcode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_pro, Me.name_pro, Me.price_buy, Me.total_pro, Me.unit})
        Me.dgRPproBarcode.Location = New System.Drawing.Point(12, 85)
        Me.dgRPproBarcode.MultiSelect = False
        Me.dgRPproBarcode.Name = "dgRPproBarcode"
        Me.dgRPproBarcode.ReadOnly = True
        Me.dgRPproBarcode.RowHeadersVisible = False
        Me.dgRPproBarcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRPproBarcode.Size = New System.Drawing.Size(518, 144)
        Me.dgRPproBarcode.TabIndex = 20
        Me.ToolTipRP.SetToolTip(Me.dgRPproBarcode, "ดับเบิ้ลคลิ๊กสินค้าเพื่อนำสินค้า")
        '
        'dgRPsendProBarcode
        '
        Me.dgRPsendProBarcode.AllowUserToAddRows = False
        Me.dgRPsendProBarcode.AllowUserToDeleteRows = False
        Me.dgRPsendProBarcode.AllowUserToOrderColumns = True
        Me.dgRPsendProBarcode.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dgRPsendProBarcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRPsendProBarcode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codepro, Me.namepro, Me.countnum, Me.returns, Me.unit2, Me.total_all})
        Me.dgRPsendProBarcode.Location = New System.Drawing.Point(12, 251)
        Me.dgRPsendProBarcode.Name = "dgRPsendProBarcode"
        Me.dgRPsendProBarcode.ReadOnly = True
        Me.dgRPsendProBarcode.RowHeadersVisible = False
        Me.dgRPsendProBarcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRPsendProBarcode.Size = New System.Drawing.Size(518, 143)
        Me.dgRPsendProBarcode.TabIndex = 21
        Me.ToolTipRP.SetToolTip(Me.dgRPsendProBarcode, "รายการสินค้าที่ต้องการคืน")
        '
        'txtRP_ID
        '
        Me.txtRP_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRP_ID.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtRP_ID.Location = New System.Drawing.Point(421, 426)
        Me.txtRP_ID.Name = "txtRP_ID"
        Me.txtRP_ID.Size = New System.Drawing.Size(109, 22)
        Me.txtRP_ID.TabIndex = 6
        Me.txtRP_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipRP.SetToolTip(Me.txtRP_ID, "เลขที่คืนสินค้า")
        '
        'ToolTipRP
        '
        Me.ToolTipRP.IsBalloon = True
        '
        'txtRPcustomerName
        '
        Me.txtRPcustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPcustomerName.Location = New System.Drawing.Point(665, 5)
        Me.txtRPcustomerName.Name = "txtRPcustomerName"
        Me.txtRPcustomerName.ReadOnly = True
        Me.txtRPcustomerName.Size = New System.Drawing.Size(168, 22)
        Me.txtRPcustomerName.TabIndex = 7
        Me.ToolTipRP.SetToolTip(Me.txtRPcustomerName, "ชื่อลูกค้า")
        '
        'txtRPcustomerAddress
        '
        Me.txtRPcustomerAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPcustomerAddress.Location = New System.Drawing.Point(483, 26)
        Me.txtRPcustomerAddress.Name = "txtRPcustomerAddress"
        Me.txtRPcustomerAddress.ReadOnly = True
        Me.txtRPcustomerAddress.Size = New System.Drawing.Size(350, 22)
        Me.txtRPcustomerAddress.TabIndex = 8
        Me.ToolTipRP.SetToolTip(Me.txtRPcustomerAddress, "ที่อยู่ลูกค้า")
        '
        'txtRPcustomerTel
        '
        Me.txtRPcustomerTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPcustomerTel.Location = New System.Drawing.Point(483, 47)
        Me.txtRPcustomerTel.Name = "txtRPcustomerTel"
        Me.txtRPcustomerTel.ReadOnly = True
        Me.txtRPcustomerTel.Size = New System.Drawing.Size(350, 22)
        Me.txtRPcustomerTel.TabIndex = 9
        Me.ToolTipRP.SetToolTip(Me.txtRPcustomerTel, "เบอร์โทรศัพท์ลูกค้า")
        '
        'txtRPcustomerID
        '
        Me.txtRPcustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPcustomerID.Location = New System.Drawing.Point(483, 5)
        Me.txtRPcustomerID.Name = "txtRPcustomerID"
        Me.txtRPcustomerID.ReadOnly = True
        Me.txtRPcustomerID.Size = New System.Drawing.Size(155, 22)
        Me.txtRPcustomerID.TabIndex = 10
        Me.ToolTipRP.SetToolTip(Me.txtRPcustomerID, "รหัสลูกค้า")
        '
        'txtRPsnADD
        '
        Me.txtRPsnADD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRPsnADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPsnADD.Location = New System.Drawing.Point(627, 223)
        Me.txtRPsnADD.Name = "txtRPsnADD"
        Me.txtRPsnADD.Size = New System.Drawing.Size(168, 22)
        Me.txtRPsnADD.TabIndex = 0
        Me.txtRPsnADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipRP.SetToolTip(Me.txtRPsnADD, "ป้อน SN สินค้าที่ต้องการคืน")
        '
        'dgRPproSN
        '
        Me.dgRPproSN.AllowUserToAddRows = False
        Me.dgRPproSN.AllowUserToDeleteRows = False
        Me.dgRPproSN.AllowUserToOrderColumns = True
        Me.dgRPproSN.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgRPproSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRPproSN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serial_proSN, Me.code_proSN, Me.name_proSN})
        Me.dgRPproSN.Location = New System.Drawing.Point(543, 85)
        Me.dgRPproSN.Name = "dgRPproSN"
        Me.dgRPproSN.ReadOnly = True
        Me.dgRPproSN.RowHeadersVisible = False
        Me.dgRPproSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRPproSN.Size = New System.Drawing.Size(290, 131)
        Me.dgRPproSN.TabIndex = 22
        Me.ToolTipRP.SetToolTip(Me.dgRPproSN, "รายการสินค้า SN จากรายการบิลขายนี้")
        '
        'serial_proSN
        '
        Me.serial_proSN.DataPropertyName = "serial_pro"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        Me.serial_proSN.DefaultCellStyle = DataGridViewCellStyle6
        Me.serial_proSN.Frozen = True
        Me.serial_proSN.HeaderText = "SN"
        Me.serial_proSN.Name = "serial_proSN"
        Me.serial_proSN.ReadOnly = True
        Me.serial_proSN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'code_proSN
        '
        Me.code_proSN.DataPropertyName = "code_pro"
        Me.code_proSN.HeaderText = "รหัสสินค้า"
        Me.code_proSN.Name = "code_proSN"
        Me.code_proSN.ReadOnly = True
        '
        'name_proSN
        '
        Me.name_proSN.DataPropertyName = "name_pro"
        Me.name_proSN.HeaderText = "ชื่อสินค้า"
        Me.name_proSN.Name = "name_proSN"
        Me.name_proSN.ReadOnly = True
        Me.name_proSN.Width = 200
        '
        'dgRPsendProSN
        '
        Me.dgRPsendProSN.AllowUserToAddRows = False
        Me.dgRPsendProSN.AllowUserToDeleteRows = False
        Me.dgRPsendProSN.AllowUserToOrderColumns = True
        Me.dgRPsendProSN.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dgRPsendProSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRPsendProSN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SN2, Me.codeproSN2, Me.name_proSN2})
        Me.dgRPsendProSN.Location = New System.Drawing.Point(543, 267)
        Me.dgRPsendProSN.Name = "dgRPsendProSN"
        Me.dgRPsendProSN.ReadOnly = True
        Me.dgRPsendProSN.RowHeadersVisible = False
        Me.dgRPsendProSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRPsendProSN.Size = New System.Drawing.Size(290, 197)
        Me.dgRPsendProSN.TabIndex = 23
        Me.ToolTipRP.SetToolTip(Me.dgRPsendProSN, "รายการสินค้า SN ที่ต้องการคืน")
        '
        'SN2
        '
        Me.SN2.DataPropertyName = "serial_pro"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        Me.SN2.DefaultCellStyle = DataGridViewCellStyle7
        Me.SN2.Frozen = True
        Me.SN2.HeaderText = "SN"
        Me.SN2.Name = "SN2"
        Me.SN2.ReadOnly = True
        Me.SN2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SN2.Width = 80
        '
        'codeproSN2
        '
        Me.codeproSN2.DataPropertyName = "code_pro"
        Me.codeproSN2.HeaderText = "รหัสสินค้า"
        Me.codeproSN2.Name = "codeproSN2"
        Me.codeproSN2.ReadOnly = True
        Me.codeproSN2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.codeproSN2.Width = 80
        '
        'name_proSN2
        '
        Me.name_proSN2.DataPropertyName = "name_pro"
        Me.name_proSN2.HeaderText = "ชื่อสินค้า"
        Me.name_proSN2.Name = "name_proSN2"
        Me.name_proSN2.ReadOnly = True
        Me.name_proSN2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_proSN2.Width = 200
        '
        'txtRPsumall
        '
        Me.txtRPsumall.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPsumall.Location = New System.Drawing.Point(665, 470)
        Me.txtRPsumall.Name = "txtRPsumall"
        Me.txtRPsumall.Size = New System.Drawing.Size(168, 31)
        Me.txtRPsumall.TabIndex = 15
        Me.txtRPsumall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipRP.SetToolTip(Me.txtRPsumall, "ยอดรวมสินค้าที่คืน")
        '
        'btnRPsave
        '
        Me.btnRPsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRPsave.Location = New System.Drawing.Point(15, 470)
        Me.btnRPsave.Name = "btnRPsave"
        Me.btnRPsave.Size = New System.Drawing.Size(130, 31)
        Me.btnRPsave.TabIndex = 4
        Me.btnRPsave.Text = "บันทึก"
        Me.ToolTipRP.SetToolTip(Me.btnRPsave, "บันทึกรายการคืนสินค้า")
        Me.btnRPsave.UseVisualStyleBackColor = True
        '
        'btnRPcancel
        '
        Me.btnRPcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRPcancel.Location = New System.Drawing.Point(151, 470)
        Me.btnRPcancel.Name = "btnRPcancel"
        Me.btnRPcancel.Size = New System.Drawing.Size(130, 31)
        Me.btnRPcancel.TabIndex = 19
        Me.btnRPcancel.Text = "ยกเลิก"
        Me.ToolTipRP.SetToolTip(Me.btnRPcancel, "ยกเลิกรายการคืนทั้งหมด")
        Me.btnRPcancel.UseVisualStyleBackColor = True
        '
        'lblRPreturnsSN
        '
        Me.lblRPreturnsSN.AutoSize = True
        Me.lblRPreturnsSN.Location = New System.Drawing.Point(546, 227)
        Me.lblRPreturnsSN.Name = "lblRPreturnsSN"
        Me.lblRPreturnsSN.Size = New System.Drawing.Size(75, 13)
        Me.lblRPreturnsSN.TabIndex = 21
        Me.lblRPreturnsSN.Text = "ป้อน SN สินค้า"
        Me.ToolTipRP.SetToolTip(Me.lblRPreturnsSN, "ป้อน SN สินค้าที่ต้องการคืน")
        '
        'txtRPreturnNote
        '
        Me.txtRPreturnNote.Location = New System.Drawing.Point(77, 400)
        Me.txtRPreturnNote.Name = "txtRPreturnNote"
        Me.txtRPreturnNote.Size = New System.Drawing.Size(453, 20)
        Me.txtRPreturnNote.TabIndex = 30
        Me.ToolTipRP.SetToolTip(Me.txtRPreturnNote, "ระบุสาเหตุที่ต้องคืนสินค้า")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(221, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "ดับเบิ๊ลคลิ๊กจากรายการด้านบนเพื่อนำคืนสินค้า"
        Me.ToolTipRP.SetToolTip(Me.Label8, "(เฉพาะสินค้าที่ขายเป็นบาร์โค๊ตเท่านั้น สินค้าที่เป็น SN ป้อน SN ในช่องด้านขวา)")
        '
        'txtRPsearchSN
        '
        Me.txtRPsearchSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRPsearchSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPsearchSN.Location = New System.Drawing.Point(40, 47)
        Me.txtRPsearchSN.Name = "txtRPsearchSN"
        Me.txtRPsearchSN.ReadOnly = True
        Me.txtRPsearchSN.Size = New System.Drawing.Size(164, 22)
        Me.txtRPsearchSN.TabIndex = 34
        Me.txtRPsearchSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipRP.SetToolTip(Me.txtRPsearchSN, "ค้นหาใบเบิกสินค้าโดย SN")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(546, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(221, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "* ป้อน SN สินค้าในช่องด้านบนเพื่อทำคืนสินค้า"
        Me.ToolTipRP.SetToolTip(Me.Label9, "ป้อน SN สินค้าที่ต้องการคืน")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(644, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ชื่อ"
        '
        'btnRPsnOK
        '
        Me.btnRPsnOK.Location = New System.Drawing.Point(801, 222)
        Me.btnRPsnOK.Name = "btnRPsnOK"
        Me.btnRPsnOK.Size = New System.Drawing.Size(32, 23)
        Me.btnRPsnOK.TabIndex = 20
        Me.btnRPsnOK.Text = "ok"
        Me.btnRPsnOK.UseVisualStyleBackColor = True
        '
        'lblRPStatus
        '
        Me.lblRPStatus.AutoSize = True
        Me.lblRPStatus.Location = New System.Drawing.Point(12, 431)
        Me.lblRPStatus.Name = "lblRPStatus"
        Me.lblRPStatus.Size = New System.Drawing.Size(64, 13)
        Me.lblRPStatus.TabIndex = 22
        Me.lblRPStatus.Text = "สถานะสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(426, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "รหัสลูกค้า"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(450, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "ที่อยู่"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(452, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "โทร"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(615, 473)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "รวม"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(227, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 25)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "รายการสินค้า"
        '
        'lblRPreturnNote
        '
        Me.lblRPreturnNote.AutoSize = True
        Me.lblRPreturnNote.ForeColor = System.Drawing.Color.DarkRed
        Me.lblRPreturnNote.Location = New System.Drawing.Point(12, 403)
        Me.lblRPreturnNote.Name = "lblRPreturnNote"
        Me.lblRPreturnNote.Size = New System.Drawing.Size(59, 13)
        Me.lblRPreturnNote.TabIndex = 31
        Me.lblRPreturnNote.Text = "สาเหตุที่คืน"
        '
        'lblRPsale_id_show
        '
        Me.lblRPsale_id_show.AutoSize = True
        Me.lblRPsale_id_show.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRPsale_id_show.ForeColor = System.Drawing.Color.DarkRed
        Me.lblRPsale_id_show.Location = New System.Drawing.Point(82, 24)
        Me.lblRPsale_id_show.Name = "lblRPsale_id_show"
        Me.lblRPsale_id_show.Size = New System.Drawing.Size(32, 16)
        Me.lblRPsale_id_show.TabIndex = 32
        Me.lblRPsale_id_show.Text = "........"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "เลขที่บิลขาย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "SN"
        '
        'lblRPproductStatus
        '
        Me.lblRPproductStatus.AutoSize = True
        Me.lblRPproductStatus.ForeColor = System.Drawing.Color.DarkRed
        Me.lblRPproductStatus.Location = New System.Drawing.Point(82, 431)
        Me.lblRPproductStatus.Name = "lblRPproductStatus"
        Me.lblRPproductStatus.Size = New System.Drawing.Size(28, 13)
        Me.lblRPproductStatus.TabIndex = 37
        Me.lblRPproductStatus.Text = "......."
        '
        'lblRPnoteDetail
        '
        Me.lblRPnoteDetail.AutoSize = True
        Me.lblRPnoteDetail.ForeColor = System.Drawing.Color.DarkRed
        Me.lblRPnoteDetail.Location = New System.Drawing.Point(82, 451)
        Me.lblRPnoteDetail.Name = "lblRPnoteDetail"
        Me.lblRPnoteDetail.Size = New System.Drawing.Size(28, 13)
        Me.lblRPnoteDetail.TabIndex = 38
        Me.lblRPnoteDetail.Text = "......."
        '
        'code_pro
        '
        Me.code_pro.DataPropertyName = "code_pro"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.code_pro.DefaultCellStyle = DataGridViewCellStyle1
        Me.code_pro.Frozen = True
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.code_pro.ToolTipText = "รหัสสินค้า"
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 200
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle2
        Me.price_buy.HeaderText = "ราคา"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.ToolTipText = "ราคาขายสินค้า"
        Me.price_buy.Width = 50
        '
        'total_pro
        '
        Me.total_pro.DataPropertyName = "total_pro"
        Me.total_pro.HeaderText = "จำนวน"
        Me.total_pro.Name = "total_pro"
        Me.total_pro.ReadOnly = True
        Me.total_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_pro.ToolTipText = "จำนวนสินค้า"
        Me.total_pro.Width = 50
        '
        'unit
        '
        Me.unit.DataPropertyName = "unit"
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.ToolTipText = "หน่วยนับ"
        Me.unit.Width = 50
        '
        'codepro
        '
        Me.codepro.DataPropertyName = "codepro"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.codepro.DefaultCellStyle = DataGridViewCellStyle3
        Me.codepro.Frozen = True
        Me.codepro.HeaderText = "รหัสสินค้า"
        Me.codepro.Name = "codepro"
        Me.codepro.ReadOnly = True
        Me.codepro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'namepro
        '
        Me.namepro.DataPropertyName = "namepro"
        Me.namepro.HeaderText = "ชื่อสินค้า"
        Me.namepro.Name = "namepro"
        Me.namepro.ReadOnly = True
        Me.namepro.Width = 200
        '
        'countnum
        '
        Me.countnum.DataPropertyName = "countnum"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.countnum.DefaultCellStyle = DataGridViewCellStyle4
        Me.countnum.HeaderText = "ราคา"
        Me.countnum.Name = "countnum"
        Me.countnum.ReadOnly = True
        Me.countnum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.countnum.Width = 50
        '
        'returns
        '
        Me.returns.DataPropertyName = "returns"
        Me.returns.HeaderText = "คืน"
        Me.returns.Name = "returns"
        Me.returns.ReadOnly = True
        Me.returns.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.returns.Width = 50
        '
        'unit2
        '
        Me.unit2.DataPropertyName = "unit2"
        Me.unit2.HeaderText = "หน่วย"
        Me.unit2.Name = "unit2"
        Me.unit2.ReadOnly = True
        Me.unit2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit2.Width = 50
        '
        'total_all
        '
        Me.total_all.DataPropertyName = "total_all"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.total_all.DefaultCellStyle = DataGridViewCellStyle5
        Me.total_all.HeaderText = "รวมเงิน"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all.Width = 50
        '
        'SendMoneyClaimsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 513)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblRPnoteDetail)
        Me.Controls.Add(Me.lblRPproductStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRPsearchSN)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblRPsale_id_show)
        Me.Controls.Add(Me.lblRPreturnNote)
        Me.Controls.Add(Me.txtRPreturnNote)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblRPStatus)
        Me.Controls.Add(Me.lblRPreturnsSN)
        Me.Controls.Add(Me.btnRPsnOK)
        Me.Controls.Add(Me.btnRPcancel)
        Me.Controls.Add(Me.btnRPsave)
        Me.Controls.Add(Me.txtRPsumall)
        Me.Controls.Add(Me.dgRPsendProSN)
        Me.Controls.Add(Me.dgRPproSN)
        Me.Controls.Add(Me.txtRPsnADD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRPcustomerID)
        Me.Controls.Add(Me.txtRPcustomerTel)
        Me.Controls.Add(Me.txtRPcustomerAddress)
        Me.Controls.Add(Me.txtRPcustomerName)
        Me.Controls.Add(Me.txtRP_ID)
        Me.Controls.Add(Me.dgRPsendProBarcode)
        Me.Controls.Add(Me.dgRPproBarcode)
        Me.Controls.Add(Me.lblRPSale_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SendMoneyClaimsFrm"
        Me.Text = "คืนสินค้า"
        CType(Me.dgRPproBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRPsendProBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRPproSN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRPsendProSN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRPSale_id As System.Windows.Forms.Label
    Friend WithEvents dgRPproBarcode As System.Windows.Forms.DataGridView
    Friend WithEvents dgRPsendProBarcode As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTipRP As System.Windows.Forms.ToolTip
    Friend WithEvents txtRP_ID As System.Windows.Forms.TextBox
    Friend WithEvents txtRPcustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtRPcustomerAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtRPcustomerTel As System.Windows.Forms.TextBox
    Friend WithEvents txtRPcustomerID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRPsnADD As System.Windows.Forms.TextBox
    Friend WithEvents dgRPproSN As System.Windows.Forms.DataGridView
    Friend WithEvents dgRPsendProSN As System.Windows.Forms.DataGridView
    Friend WithEvents txtRPsumall As System.Windows.Forms.TextBox
    Friend WithEvents btnRPsave As System.Windows.Forms.Button
    Friend WithEvents btnRPcancel As System.Windows.Forms.Button
    Friend WithEvents btnRPsnOK As System.Windows.Forms.Button
    Friend WithEvents lblRPreturnsSN As System.Windows.Forms.Label
    Friend WithEvents lblRPStatus As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents serial_proSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_proSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_proSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SN2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codeproSN2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_proSN2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtRPreturnNote As System.Windows.Forms.TextBox
    Friend WithEvents lblRPreturnNote As System.Windows.Forms.Label
    Friend WithEvents lblRPsale_id_show As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRPsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRPproductStatus As System.Windows.Forms.Label
    Friend WithEvents lblRPnoteDetail As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codepro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namepro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents countnum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents returns As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
