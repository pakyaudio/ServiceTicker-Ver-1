<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartsWithdrawalFrm
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgPWproMeNoSN = New System.Windows.Forms.DataGridView()
        Me.lblPESerial = New System.Windows.Forms.Label()
        Me.txtPWprobarcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPWrepairID = New System.Windows.Forms.TextBox()
        Me.txtPWcusTel = New System.Windows.Forms.TextBox()
        Me.txtPWcusName = New System.Windows.Forms.TextBox()
        Me.txtPWcusID = New System.Windows.Forms.TextBox()
        Me.lblPWdategetbill = New System.Windows.Forms.Label()
        Me.lblPWbillNum = New System.Windows.Forms.Label()
        Me.txtPWdateNow = New System.Windows.Forms.TextBox()
        Me.txtPWsaleID = New System.Windows.Forms.TextBox()
        Me.cbbPWgetProSection = New System.Windows.Forms.ComboBox()
        Me.txtPWproSearch = New System.Windows.Forms.TextBox()
        Me.dgPWProsearch = New System.Windows.Forms.DataGridView()
        Me.btnPWsave = New System.Windows.Forms.Button()
        Me.btnPWdel = New System.Windows.Forms.Button()
        Me.btnPWbid = New System.Windows.Forms.Button()
        Me.lblPwP = New System.Windows.Forms.Label()
        Me.lblPWunit = New System.Windows.Forms.Label()
        Me.lblPWprice = New System.Windows.Forms.Label()
        Me.lblPWproName = New System.Windows.Forms.Label()
        Me.lblPWcodeORbarcode = New System.Windows.Forms.Label()
        Me.lblPWgetTotalPrice = New System.Windows.Forms.Label()
        Me.btnPWokTodg = New System.Windows.Forms.Button()
        Me.txtPWprop = New System.Windows.Forms.TextBox()
        Me.txtPWproUnit = New System.Windows.Forms.TextBox()
        Me.txtPWproprice = New System.Windows.Forms.TextBox()
        Me.txtPWproname = New System.Windows.Forms.TextBox()
        Me.txtPWprobarcodeANDsn = New System.Windows.Forms.TextBox()
        Me.dgPWproMEwSN = New System.Windows.Forms.DataGridView()
        Me.btnPWclose = New System.Windows.Forms.Button()
        Me.lblPWtotalXYZ = New System.Windows.Forms.Label()
        Me.ToolTipPW = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbSmembers = New System.Windows.Forms.RadioButton()
        Me.rbSloyal = New System.Windows.Forms.RadioButton()
        Me.rbStechnician = New System.Windows.Forms.RadioButton()
        Me.rbSwholesale = New System.Windows.Forms.RadioButton()
        Me.rbSbuy = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        Me.mnuCell1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCell = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroLabel2 = New MetroControls.MetroLabel()
        Me.MetroLabel1 = New MetroControls.MetroLabel()
        CType(Me.dgPWproMeNoSN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPWProsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPWproMEwSN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuCell1.SuspendLayout()
        Me.mnuCell.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 13)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "รายการสินค้าแบบมี Serial Number"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "รายการสินค้าแบบไม่มี Serial Number"
        '
        'dgPWproMeNoSN
        '
        Me.dgPWproMeNoSN.AllowUserToAddRows = False
        Me.dgPWproMeNoSN.AllowUserToDeleteRows = False
        Me.dgPWproMeNoSN.AllowUserToOrderColumns = True
        Me.dgPWproMeNoSN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPWproMeNoSN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPWproMeNoSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPWproMeNoSN.GridColor = System.Drawing.SystemColors.Control
        Me.dgPWproMeNoSN.Location = New System.Drawing.Point(228, 310)
        Me.dgPWproMeNoSN.MultiSelect = False
        Me.dgPWproMeNoSN.Name = "dgPWproMeNoSN"
        Me.dgPWproMeNoSN.RowHeadersVisible = False
        Me.dgPWproMeNoSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPWproMeNoSN.Size = New System.Drawing.Size(717, 182)
        Me.dgPWproMeNoSN.TabIndex = 81
        Me.ToolTipPW.SetToolTip(Me.dgPWproMeNoSN, "สามารถลบรายการสินค้าได้โดยใช้ปุ่มลบรายการ")
        '
        'lblPESerial
        '
        Me.lblPESerial.AutoSize = True
        Me.lblPESerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPESerial.Location = New System.Drawing.Point(30, 230)
        Me.lblPESerial.Name = "lblPESerial"
        Me.lblPESerial.Size = New System.Drawing.Size(83, 20)
        Me.lblPESerial.TabIndex = 80
        Me.lblPESerial.Text = "SN/บาร์โค๊ต"
        '
        'txtPWprobarcode
        '
        Me.txtPWprobarcode.BackColor = System.Drawing.SystemColors.Control
        Me.txtPWprobarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPWprobarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWprobarcode.Location = New System.Drawing.Point(137, 253)
        Me.txtPWprobarcode.Name = "txtPWprobarcode"
        Me.txtPWprobarcode.ReadOnly = True
        Me.txtPWprobarcode.Size = New System.Drawing.Size(138, 29)
        Me.txtPWprobarcode.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(657, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "รหัสใบส่งซ่อม"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(714, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "เบอร์โทร"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(743, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "ชื่อ"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(715, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "รหัสลูกค้า"
        '
        'txtPWrepairID
        '
        Me.txtPWrepairID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWrepairID.Enabled = False
        Me.txtPWrepairID.Location = New System.Drawing.Point(735, 61)
        Me.txtPWrepairID.Name = "txtPWrepairID"
        Me.txtPWrepairID.ReadOnly = True
        Me.txtPWrepairID.Size = New System.Drawing.Size(217, 20)
        Me.txtPWrepairID.TabIndex = 73
        '
        'txtPWcusTel
        '
        Me.txtPWcusTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWcusTel.Enabled = False
        Me.txtPWcusTel.Location = New System.Drawing.Point(769, 42)
        Me.txtPWcusTel.Name = "txtPWcusTel"
        Me.txtPWcusTel.ReadOnly = True
        Me.txtPWcusTel.Size = New System.Drawing.Size(183, 20)
        Me.txtPWcusTel.TabIndex = 72
        '
        'txtPWcusName
        '
        Me.txtPWcusName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWcusName.Enabled = False
        Me.txtPWcusName.Location = New System.Drawing.Point(769, 23)
        Me.txtPWcusName.Name = "txtPWcusName"
        Me.txtPWcusName.ReadOnly = True
        Me.txtPWcusName.Size = New System.Drawing.Size(183, 20)
        Me.txtPWcusName.TabIndex = 71
        '
        'txtPWcusID
        '
        Me.txtPWcusID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWcusID.Enabled = False
        Me.txtPWcusID.Location = New System.Drawing.Point(769, 4)
        Me.txtPWcusID.Name = "txtPWcusID"
        Me.txtPWcusID.ReadOnly = True
        Me.txtPWcusID.Size = New System.Drawing.Size(183, 20)
        Me.txtPWcusID.TabIndex = 70
        '
        'lblPWdategetbill
        '
        Me.lblPWdategetbill.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPWdategetbill.AutoSize = True
        Me.lblPWdategetbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWdategetbill.Location = New System.Drawing.Point(460, 27)
        Me.lblPWdategetbill.Name = "lblPWdategetbill"
        Me.lblPWdategetbill.Size = New System.Drawing.Size(76, 13)
        Me.lblPWdategetbill.TabIndex = 69
        Me.lblPWdategetbill.Text = "วันที่ทำรายการ"
        '
        'lblPWbillNum
        '
        Me.lblPWbillNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPWbillNum.AutoSize = True
        Me.lblPWbillNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWbillNum.Location = New System.Drawing.Point(492, 7)
        Me.lblPWbillNum.Name = "lblPWbillNum"
        Me.lblPWbillNum.Size = New System.Drawing.Size(44, 13)
        Me.lblPWbillNum.TabIndex = 68
        Me.lblPWbillNum.Text = "เลขที่บิล"
        '
        'txtPWdateNow
        '
        Me.txtPWdateNow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWdateNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWdateNow.ForeColor = System.Drawing.Color.DarkRed
        Me.txtPWdateNow.Location = New System.Drawing.Point(542, 22)
        Me.txtPWdateNow.Name = "txtPWdateNow"
        Me.txtPWdateNow.ReadOnly = True
        Me.txtPWdateNow.Size = New System.Drawing.Size(170, 21)
        Me.txtPWdateNow.TabIndex = 67
        Me.txtPWdateNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPWsaleID
        '
        Me.txtPWsaleID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWsaleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWsaleID.ForeColor = System.Drawing.Color.Blue
        Me.txtPWsaleID.Location = New System.Drawing.Point(542, 2)
        Me.txtPWsaleID.Name = "txtPWsaleID"
        Me.txtPWsaleID.ReadOnly = True
        Me.txtPWsaleID.Size = New System.Drawing.Size(170, 21)
        Me.txtPWsaleID.TabIndex = 66
        Me.txtPWsaleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbbPWgetProSection
        '
        Me.cbbPWgetProSection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbPWgetProSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbPWgetProSection.FormattingEnabled = True
        Me.cbbPWgetProSection.Location = New System.Drawing.Point(162, 7)
        Me.cbbPWgetProSection.Name = "cbbPWgetProSection"
        Me.cbbPWgetProSection.Size = New System.Drawing.Size(292, 32)
        Me.cbbPWgetProSection.TabIndex = 3
        Me.ToolTipPW.SetToolTip(Me.cbbPWgetProSection, "เลือกสินค้าจากรายการประเภทสินค้า")
        '
        'txtPWproSearch
        '
        Me.txtPWproSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWproSearch.Location = New System.Drawing.Point(12, 7)
        Me.txtPWproSearch.Name = "txtPWproSearch"
        Me.txtPWproSearch.Size = New System.Drawing.Size(146, 31)
        Me.txtPWproSearch.TabIndex = 2
        Me.ToolTipPW.SetToolTip(Me.txtPWproSearch, "ค้นหาสินค้า เช่น ชื่อ ใส่คำค้นหาที่ต้องการแล้วกด enter")
        '
        'dgPWProsearch
        '
        Me.dgPWProsearch.AllowUserToAddRows = False
        Me.dgPWProsearch.AllowUserToDeleteRows = False
        Me.dgPWProsearch.AllowUserToOrderColumns = True
        Me.dgPWProsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPWProsearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPWProsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPWProsearch.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPWProsearch.Location = New System.Drawing.Point(12, 45)
        Me.dgPWProsearch.Name = "dgPWProsearch"
        Me.dgPWProsearch.ReadOnly = True
        Me.dgPWProsearch.RowHeadersVisible = False
        Me.dgPWProsearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPWProsearch.Size = New System.Drawing.Size(633, 181)
        Me.dgPWProsearch.TabIndex = 63
        '
        'btnPWsave
        '
        Me.btnPWsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPWsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPWsave.Location = New System.Drawing.Point(583, 498)
        Me.btnPWsave.Name = "btnPWsave"
        Me.btnPWsave.Size = New System.Drawing.Size(101, 50)
        Me.btnPWsave.TabIndex = 4
        Me.btnPWsave.Text = "บันทึก"
        Me.ToolTipPW.SetToolTip(Me.btnPWsave, "ขอให้แน่ใจว่าสินค้าถูกต้องตามรายการ")
        Me.btnPWsave.UseVisualStyleBackColor = True
        '
        'btnPWdel
        '
        Me.btnPWdel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPWdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPWdel.Location = New System.Drawing.Point(346, 498)
        Me.btnPWdel.Name = "btnPWdel"
        Me.btnPWdel.Size = New System.Drawing.Size(150, 34)
        Me.btnPWdel.TabIndex = 5
        Me.btnPWdel.Text = "ลบรายการทั้งหมด"
        Me.ToolTipPW.SetToolTip(Me.btnPWdel, "ลบรายการสินค้าแบบไม่มี Serial Number")
        Me.btnPWdel.UseVisualStyleBackColor = True
        '
        'btnPWbid
        '
        Me.btnPWbid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPWbid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPWbid.Location = New System.Drawing.Point(690, 498)
        Me.btnPWbid.Name = "btnPWbid"
        Me.btnPWbid.Size = New System.Drawing.Size(145, 50)
        Me.btnPWbid.TabIndex = 6
        Me.btnPWbid.Text = "พิมพ์ใบเสนอราคา"
        Me.ToolTipPW.SetToolTip(Me.btnPWbid, "พิมพ์ใบเสนอราคา")
        Me.btnPWbid.UseVisualStyleBackColor = True
        '
        'lblPwP
        '
        Me.lblPwP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPwP.AutoSize = True
        Me.lblPwP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPwP.Location = New System.Drawing.Point(808, 231)
        Me.lblPwP.Name = "lblPwP"
        Me.lblPwP.Size = New System.Drawing.Size(54, 20)
        Me.lblPwP.TabIndex = 58
        Me.lblPwP.Text = "ปริมาณ"
        '
        'lblPWunit
        '
        Me.lblPWunit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPWunit.AutoSize = True
        Me.lblPWunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWunit.Location = New System.Drawing.Point(724, 231)
        Me.lblPWunit.Name = "lblPWunit"
        Me.lblPWunit.Size = New System.Drawing.Size(42, 20)
        Me.lblPWunit.TabIndex = 57
        Me.lblPWunit.Text = "หน่วย"
        '
        'lblPWprice
        '
        Me.lblPWprice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPWprice.AutoSize = True
        Me.lblPWprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWprice.Location = New System.Drawing.Point(626, 231)
        Me.lblPWprice.Name = "lblPWprice"
        Me.lblPWprice.Size = New System.Drawing.Size(39, 20)
        Me.lblPWprice.TabIndex = 56
        Me.lblPWprice.Text = "ราคา"
        '
        'lblPWproName
        '
        Me.lblPWproName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPWproName.AutoSize = True
        Me.lblPWproName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWproName.Location = New System.Drawing.Point(402, 231)
        Me.lblPWproName.Name = "lblPWproName"
        Me.lblPWproName.Size = New System.Drawing.Size(59, 20)
        Me.lblPWproName.TabIndex = 55
        Me.lblPWproName.Text = "ชื่อสินค้า"
        '
        'lblPWcodeORbarcode
        '
        Me.lblPWcodeORbarcode.AutoSize = True
        Me.lblPWcodeORbarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWcodeORbarcode.Location = New System.Drawing.Point(185, 231)
        Me.lblPWcodeORbarcode.Name = "lblPWcodeORbarcode"
        Me.lblPWcodeORbarcode.Size = New System.Drawing.Size(57, 20)
        Me.lblPWcodeORbarcode.TabIndex = 54
        Me.lblPWcodeORbarcode.Text = "บาร์โค๊ต"
        '
        'lblPWgetTotalPrice
        '
        Me.lblPWgetTotalPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPWgetTotalPrice.BackColor = System.Drawing.Color.DarkBlue
        Me.lblPWgetTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWgetTotalPrice.ForeColor = System.Drawing.Color.Gold
        Me.lblPWgetTotalPrice.Location = New System.Drawing.Point(656, 130)
        Me.lblPWgetTotalPrice.Name = "lblPWgetTotalPrice"
        Me.lblPWgetTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPWgetTotalPrice.Size = New System.Drawing.Size(293, 73)
        Me.lblPWgetTotalPrice.TabIndex = 53
        Me.lblPWgetTotalPrice.Text = "-"
        Me.lblPWgetTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTipPW.SetToolTip(Me.lblPWgetTotalPrice, "รวมราคาสินค้าทั้งหมด")
        '
        'btnPWokTodg
        '
        Me.btnPWokTodg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPWokTodg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPWokTodg.Location = New System.Drawing.Point(884, 252)
        Me.btnPWokTodg.Name = "btnPWokTodg"
        Me.btnPWokTodg.Size = New System.Drawing.Size(68, 31)
        Me.btnPWokTodg.TabIndex = 1
        Me.btnPWokTodg.Text = "ตกลง"
        Me.ToolTipPW.SetToolTip(Me.btnPWokTodg, "นำเข้าสินค้าที่เลือก")
        Me.btnPWokTodg.UseVisualStyleBackColor = True
        '
        'txtPWprop
        '
        Me.txtPWprop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWprop.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPWprop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWprop.Location = New System.Drawing.Point(796, 253)
        Me.txtPWprop.Name = "txtPWprop"
        Me.txtPWprop.Size = New System.Drawing.Size(85, 29)
        Me.txtPWprop.TabIndex = 51
        '
        'txtPWproUnit
        '
        Me.txtPWproUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWproUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWproUnit.Location = New System.Drawing.Point(703, 253)
        Me.txtPWproUnit.Name = "txtPWproUnit"
        Me.txtPWproUnit.ReadOnly = True
        Me.txtPWproUnit.Size = New System.Drawing.Size(87, 29)
        Me.txtPWproUnit.TabIndex = 50
        '
        'txtPWproprice
        '
        Me.txtPWproprice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWproprice.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPWproprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWproprice.Location = New System.Drawing.Point(603, 253)
        Me.txtPWproprice.Name = "txtPWproprice"
        Me.txtPWproprice.Size = New System.Drawing.Size(94, 29)
        Me.txtPWproprice.TabIndex = 49
        '
        'txtPWproname
        '
        Me.txtPWproname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWproname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWproname.Location = New System.Drawing.Point(281, 253)
        Me.txtPWproname.Name = "txtPWproname"
        Me.txtPWproname.ReadOnly = True
        Me.txtPWproname.Size = New System.Drawing.Size(316, 29)
        Me.txtPWproname.TabIndex = 48
        '
        'txtPWprobarcodeANDsn
        '
        Me.txtPWprobarcodeANDsn.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPWprobarcodeANDsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWprobarcodeANDsn.Location = New System.Drawing.Point(11, 253)
        Me.txtPWprobarcodeANDsn.Name = "txtPWprobarcodeANDsn"
        Me.txtPWprobarcodeANDsn.Size = New System.Drawing.Size(120, 29)
        Me.txtPWprobarcodeANDsn.TabIndex = 0
        Me.ToolTipPW.SetToolTip(Me.txtPWprobarcodeANDsn, "ยิงบาร์โค๊ตจากเครื่องอ่านบาร์โค๊ตหรือพิมพ์แล้วกด enter")
        '
        'dgPWproMEwSN
        '
        Me.dgPWproMEwSN.AllowUserToAddRows = False
        Me.dgPWproMEwSN.AllowUserToDeleteRows = False
        Me.dgPWproMEwSN.AllowUserToOrderColumns = True
        Me.dgPWproMEwSN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPWproMEwSN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPWproMEwSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPWproMEwSN.Location = New System.Drawing.Point(12, 310)
        Me.dgPWproMEwSN.Name = "dgPWproMEwSN"
        Me.dgPWproMEwSN.ReadOnly = True
        Me.dgPWproMEwSN.RowHeadersVisible = False
        Me.dgPWproMEwSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPWproMEwSN.Size = New System.Drawing.Size(210, 182)
        Me.dgPWproMEwSN.TabIndex = 46
        Me.ToolTipPW.SetToolTip(Me.dgPWproMEwSN, "สามารถลบรายการสินค้าได้โดยการดับเบิ้ลคลิ๊ก")
        '
        'btnPWclose
        '
        Me.btnPWclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPWclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPWclose.Location = New System.Drawing.Point(844, 498)
        Me.btnPWclose.Name = "btnPWclose"
        Me.btnPWclose.Size = New System.Drawing.Size(101, 50)
        Me.btnPWclose.TabIndex = 7
        Me.btnPWclose.Text = "ปิด"
        Me.ToolTipPW.SetToolTip(Me.btnPWclose, "ยกเลิก/ปิดหน้าต่างนี้ สินค้าที่ทำการเลือกจะไม่ได้รับการบันทึก")
        Me.btnPWclose.UseVisualStyleBackColor = True
        '
        'lblPWtotalXYZ
        '
        Me.lblPWtotalXYZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPWtotalXYZ.BackColor = System.Drawing.Color.DarkBlue
        Me.lblPWtotalXYZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWtotalXYZ.ForeColor = System.Drawing.Color.Gold
        Me.lblPWtotalXYZ.Location = New System.Drawing.Point(656, 203)
        Me.lblPWtotalXYZ.Name = "lblPWtotalXYZ"
        Me.lblPWtotalXYZ.Size = New System.Drawing.Size(293, 23)
        Me.lblPWtotalXYZ.TabIndex = 85
        Me.lblPWtotalXYZ.Text = "----------------"
        Me.lblPWtotalXYZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipPW.SetToolTip(Me.lblPWtotalXYZ, "จำนวนรายการสินค้าและปริมาณ")
        '
        'ToolTipPW
        '
        Me.ToolTipPW.AutoPopDelay = 5000
        Me.ToolTipPW.InitialDelay = 300
        Me.ToolTipPW.IsBalloon = True
        Me.ToolTipPW.ReshowDelay = 300
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(789, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 13)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "ช่องราคาสามารถเปลี่ยนแปลงได้"
        '
        'rbSmembers
        '
        Me.rbSmembers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbSmembers.AutoSize = True
        Me.rbSmembers.Location = New System.Drawing.Point(899, 110)
        Me.rbSmembers.Name = "rbSmembers"
        Me.rbSmembers.Size = New System.Drawing.Size(57, 17)
        Me.rbSmembers.TabIndex = 141
        Me.rbSmembers.Text = "สมาชิก"
        Me.rbSmembers.UseVisualStyleBackColor = True
        '
        'rbSloyal
        '
        Me.rbSloyal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbSloyal.AutoSize = True
        Me.rbSloyal.Location = New System.Drawing.Point(839, 110)
        Me.rbSloyal.Name = "rbSloyal"
        Me.rbSloyal.Size = New System.Drawing.Size(54, 17)
        Me.rbSloyal.TabIndex = 140
        Me.rbSloyal.Text = "ประจำ"
        Me.rbSloyal.UseVisualStyleBackColor = True
        '
        'rbStechnician
        '
        Me.rbStechnician.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbStechnician.AutoSize = True
        Me.rbStechnician.Location = New System.Drawing.Point(791, 110)
        Me.rbStechnician.Name = "rbStechnician"
        Me.rbStechnician.Size = New System.Drawing.Size(42, 17)
        Me.rbStechnician.TabIndex = 139
        Me.rbStechnician.Text = "ช่าง"
        Me.rbStechnician.UseVisualStyleBackColor = True
        '
        'rbSwholesale
        '
        Me.rbSwholesale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbSwholesale.AutoSize = True
        Me.rbSwholesale.Location = New System.Drawing.Point(731, 110)
        Me.rbSwholesale.Name = "rbSwholesale"
        Me.rbSwholesale.Size = New System.Drawing.Size(54, 17)
        Me.rbSwholesale.TabIndex = 138
        Me.rbSwholesale.Text = "ขายส่ง"
        Me.rbSwholesale.UseVisualStyleBackColor = True
        '
        'rbSbuy
        '
        Me.rbSbuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbSbuy.AutoSize = True
        Me.rbSbuy.Checked = True
        Me.rbSbuy.Location = New System.Drawing.Point(679, 110)
        Me.rbSbuy.Name = "rbSbuy"
        Me.rbSbuy.Size = New System.Drawing.Size(46, 17)
        Me.rbSbuy.TabIndex = 137
        Me.rbSbuy.TabStop = True
        Me.rbSbuy.Text = "ปกติ"
        Me.rbSbuy.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(657, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "ระดับราคา"
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 519)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 142
        Me.lblemployee.Text = "User"
        '
        'mnuCell1
        '
        Me.mnuCell1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem1})
        Me.mnuCell1.Name = "mnuCell1"
        Me.mnuCell1.ShowImageMargin = False
        Me.mnuCell1.Size = New System.Drawing.Size(83, 26)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(82, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'mnuCell
        '
        Me.mnuCell.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.mnuCell.Name = "mnuCell"
        Me.mnuCell.ShowImageMargin = False
        Me.mnuCell.Size = New System.Drawing.Size(83, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(82, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel2.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel2.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.MetroLabel2.ForeColorNormal = System.Drawing.Color.Black
        Me.MetroLabel2.Location = New System.Drawing.Point(228, 493)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(112, 15)
        Me.MetroLabel2.TabIndex = 143
        Me.MetroLabel2.Text = "*คลิ๊กขวาเพื่อลบรายการ"
        Me.MetroLabel2.UseHoverMode = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel1.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel1.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.MetroLabel1.ForeColorNormal = System.Drawing.Color.Black
        Me.MetroLabel1.Location = New System.Drawing.Point(9, 493)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(112, 15)
        Me.MetroLabel1.TabIndex = 144
        Me.MetroLabel1.Text = "*คลิ๊กขวาเพื่อลบรายการ"
        Me.MetroLabel1.UseHoverMode = True
        '
        'PartsWithdrawalFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 561)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.rbSmembers)
        Me.Controls.Add(Me.rbSloyal)
        Me.Controls.Add(Me.rbStechnician)
        Me.Controls.Add(Me.rbSwholesale)
        Me.Controls.Add(Me.rbSbuy)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblPWtotalXYZ)
        Me.Controls.Add(Me.btnPWclose)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgPWproMeNoSN)
        Me.Controls.Add(Me.lblPESerial)
        Me.Controls.Add(Me.txtPWprobarcode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPWrepairID)
        Me.Controls.Add(Me.txtPWcusTel)
        Me.Controls.Add(Me.txtPWcusName)
        Me.Controls.Add(Me.txtPWcusID)
        Me.Controls.Add(Me.lblPWdategetbill)
        Me.Controls.Add(Me.lblPWbillNum)
        Me.Controls.Add(Me.txtPWdateNow)
        Me.Controls.Add(Me.txtPWsaleID)
        Me.Controls.Add(Me.cbbPWgetProSection)
        Me.Controls.Add(Me.txtPWproSearch)
        Me.Controls.Add(Me.dgPWProsearch)
        Me.Controls.Add(Me.btnPWsave)
        Me.Controls.Add(Me.btnPWdel)
        Me.Controls.Add(Me.btnPWbid)
        Me.Controls.Add(Me.lblPwP)
        Me.Controls.Add(Me.lblPWunit)
        Me.Controls.Add(Me.lblPWprice)
        Me.Controls.Add(Me.lblPWproName)
        Me.Controls.Add(Me.lblPWcodeORbarcode)
        Me.Controls.Add(Me.lblPWgetTotalPrice)
        Me.Controls.Add(Me.btnPWokTodg)
        Me.Controls.Add(Me.txtPWprop)
        Me.Controls.Add(Me.txtPWproUnit)
        Me.Controls.Add(Me.txtPWproprice)
        Me.Controls.Add(Me.txtPWproname)
        Me.Controls.Add(Me.txtPWprobarcodeANDsn)
        Me.Controls.Add(Me.dgPWproMEwSN)
        Me.HelpButton = True
        Me.Name = "PartsWithdrawalFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "เบิกอะไหล่/สินค้า"
        CType(Me.dgPWproMeNoSN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPWProsearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPWproMEwSN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuCell1.ResumeLayout(False)
        Me.mnuCell.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgPWproMeNoSN As System.Windows.Forms.DataGridView
    Friend WithEvents lblPESerial As System.Windows.Forms.Label
    Friend WithEvents txtPWprobarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPWrepairID As System.Windows.Forms.TextBox
    Friend WithEvents txtPWcusTel As System.Windows.Forms.TextBox
    Friend WithEvents txtPWcusName As System.Windows.Forms.TextBox
    Friend WithEvents txtPWcusID As System.Windows.Forms.TextBox
    Friend WithEvents lblPWdategetbill As System.Windows.Forms.Label
    Friend WithEvents lblPWbillNum As System.Windows.Forms.Label
    Friend WithEvents txtPWdateNow As System.Windows.Forms.TextBox
    Friend WithEvents txtPWsaleID As System.Windows.Forms.TextBox
    Friend WithEvents cbbPWgetProSection As System.Windows.Forms.ComboBox
    Friend WithEvents txtPWproSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgPWProsearch As System.Windows.Forms.DataGridView
    Friend WithEvents btnPWsave As System.Windows.Forms.Button
    Friend WithEvents btnPWdel As System.Windows.Forms.Button
    Friend WithEvents btnPWbid As System.Windows.Forms.Button
    Friend WithEvents lblPwP As System.Windows.Forms.Label
    Friend WithEvents lblPWunit As System.Windows.Forms.Label
    Friend WithEvents lblPWprice As System.Windows.Forms.Label
    Friend WithEvents lblPWproName As System.Windows.Forms.Label
    Friend WithEvents lblPWcodeORbarcode As System.Windows.Forms.Label
    Friend WithEvents lblPWgetTotalPrice As System.Windows.Forms.Label
    Friend WithEvents btnPWokTodg As System.Windows.Forms.Button
    Friend WithEvents txtPWprop As System.Windows.Forms.TextBox
    Friend WithEvents txtPWproUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtPWproprice As System.Windows.Forms.TextBox
    Friend WithEvents txtPWproname As System.Windows.Forms.TextBox
    Friend WithEvents txtPWprobarcodeANDsn As System.Windows.Forms.TextBox
    Friend WithEvents dgPWproMEwSN As System.Windows.Forms.DataGridView
    Friend WithEvents btnPWclose As System.Windows.Forms.Button
    Friend WithEvents lblPWtotalXYZ As System.Windows.Forms.Label
    Friend WithEvents ToolTipPW As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbSmembers As System.Windows.Forms.RadioButton
    Friend WithEvents rbSloyal As System.Windows.Forms.RadioButton
    Friend WithEvents rbStechnician As System.Windows.Forms.RadioButton
    Friend WithEvents rbSwholesale As System.Windows.Forms.RadioButton
    Friend WithEvents rbSbuy As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblemployee As System.Windows.Forms.Label
    Friend WithEvents mnuCell1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCell As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetroLabel2 As MetroControls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroControls.MetroLabel
End Class
