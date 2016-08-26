<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateQuotationFrm
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
        Me.lblPWtotalXYZ = New System.Windows.Forms.Label()
        Me.btnPWclose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgPWproMeNoSN = New System.Windows.Forms.DataGridView()
        Me.lblPESerial = New System.Windows.Forms.Label()
        Me.txtPWprobarcode = New System.Windows.Forms.TextBox()
        Me.btnPWchangCus = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPWcusTel = New System.Windows.Forms.TextBox()
        Me.txtPWcusName = New System.Windows.Forms.TextBox()
        Me.txtPWcusID = New System.Windows.Forms.TextBox()
        Me.lblPWdategetbill = New System.Windows.Forms.Label()
        Me.txtPWdateNow = New System.Windows.Forms.TextBox()
        Me.txtPWsaleID = New System.Windows.Forms.TextBox()
        Me.cbbPWgetProSection = New System.Windows.Forms.ComboBox()
        Me.txtPWproSearch = New System.Windows.Forms.TextBox()
        Me.dgPWProsearch = New System.Windows.Forms.DataGridView()
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
        Me.ToolTipCQ = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCQsearceQuotation = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.rbCQpic = New System.Windows.Forms.RadioButton()
        Me.rbCQnoPic = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgPWproMeNoSN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPWProsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPWtotalXYZ
        '
        Me.lblPWtotalXYZ.BackColor = System.Drawing.Color.DarkBlue
        Me.lblPWtotalXYZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWtotalXYZ.ForeColor = System.Drawing.Color.Gold
        Me.lblPWtotalXYZ.Location = New System.Drawing.Point(662, 211)
        Me.lblPWtotalXYZ.Name = "lblPWtotalXYZ"
        Me.lblPWtotalXYZ.Size = New System.Drawing.Size(293, 23)
        Me.lblPWtotalXYZ.TabIndex = 124
        Me.lblPWtotalXYZ.Text = "----------------"
        Me.lblPWtotalXYZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPWclose
        '
        Me.btnPWclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPWclose.Location = New System.Drawing.Point(850, 506)
        Me.btnPWclose.Name = "btnPWclose"
        Me.btnPWclose.Size = New System.Drawing.Size(101, 50)
        Me.btnPWclose.TabIndex = 93
        Me.btnPWclose.Text = "ยกเลิก/ปิด"
        Me.ToolTipCQ.SetToolTip(Me.btnPWclose, "ยกเลิกและปิดหน้าต่างโปรแกรมนี้")
        Me.btnPWclose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "รายการสินค้า"
        '
        'dgPWproMeNoSN
        '
        Me.dgPWproMeNoSN.AllowUserToAddRows = False
        Me.dgPWproMeNoSN.AllowUserToDeleteRows = False
        Me.dgPWproMeNoSN.AllowUserToOrderColumns = True
        Me.dgPWproMeNoSN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPWproMeNoSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPWproMeNoSN.GridColor = System.Drawing.SystemColors.Control
        Me.dgPWproMeNoSN.Location = New System.Drawing.Point(12, 318)
        Me.dgPWproMeNoSN.MultiSelect = False
        Me.dgPWproMeNoSN.Name = "dgPWproMeNoSN"
        Me.dgPWproMeNoSN.RowHeadersVisible = False
        Me.dgPWproMeNoSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPWproMeNoSN.Size = New System.Drawing.Size(939, 182)
        Me.dgPWproMeNoSN.TabIndex = 121
        '
        'lblPESerial
        '
        Me.lblPESerial.AutoSize = True
        Me.lblPESerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPESerial.Location = New System.Drawing.Point(30, 238)
        Me.lblPESerial.Name = "lblPESerial"
        Me.lblPESerial.Size = New System.Drawing.Size(83, 20)
        Me.lblPESerial.TabIndex = 120
        Me.lblPESerial.Text = "SN/บาร์โค๊ต"
        '
        'txtPWprobarcode
        '
        Me.txtPWprobarcode.BackColor = System.Drawing.SystemColors.Control
        Me.txtPWprobarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPWprobarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWprobarcode.Location = New System.Drawing.Point(137, 261)
        Me.txtPWprobarcode.Name = "txtPWprobarcode"
        Me.txtPWprobarcode.ReadOnly = True
        Me.txtPWprobarcode.Size = New System.Drawing.Size(138, 29)
        Me.txtPWprobarcode.TabIndex = 119
        '
        'btnPWchangCus
        '
        Me.btnPWchangCus.Location = New System.Drawing.Point(840, 101)
        Me.btnPWchangCus.Name = "btnPWchangCus"
        Me.btnPWchangCus.Size = New System.Drawing.Size(118, 23)
        Me.btnPWchangCus.TabIndex = 118
        Me.btnPWchangCus.Text = "ค้นหาชื่อลูกค้า"
        Me.btnPWchangCus.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(658, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "เบอร์โทร"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(687, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "ชื่อ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(657, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "รหัสลูกค้า"
        '
        'txtPWcusTel
        '
        Me.txtPWcusTel.Location = New System.Drawing.Point(713, 103)
        Me.txtPWcusTel.Name = "txtPWcusTel"
        Me.txtPWcusTel.ReadOnly = True
        Me.txtPWcusTel.Size = New System.Drawing.Size(121, 20)
        Me.txtPWcusTel.TabIndex = 112
        '
        'txtPWcusName
        '
        Me.txtPWcusName.Location = New System.Drawing.Point(713, 80)
        Me.txtPWcusName.Name = "txtPWcusName"
        Me.txtPWcusName.ReadOnly = True
        Me.txtPWcusName.Size = New System.Drawing.Size(242, 20)
        Me.txtPWcusName.TabIndex = 111
        '
        'txtPWcusID
        '
        Me.txtPWcusID.Location = New System.Drawing.Point(713, 57)
        Me.txtPWcusID.Name = "txtPWcusID"
        Me.txtPWcusID.ReadOnly = True
        Me.txtPWcusID.Size = New System.Drawing.Size(242, 20)
        Me.txtPWcusID.TabIndex = 110
        '
        'lblPWdategetbill
        '
        Me.lblPWdategetbill.AutoSize = True
        Me.lblPWdategetbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWdategetbill.Location = New System.Drawing.Point(713, 20)
        Me.lblPWdategetbill.Name = "lblPWdategetbill"
        Me.lblPWdategetbill.Size = New System.Drawing.Size(90, 18)
        Me.lblPWdategetbill.TabIndex = 109
        Me.lblPWdategetbill.Text = "วันที่ทำรายการ"
        '
        'txtPWdateNow
        '
        Me.txtPWdateNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWdateNow.ForeColor = System.Drawing.Color.DarkRed
        Me.txtPWdateNow.Location = New System.Drawing.Point(809, 18)
        Me.txtPWdateNow.Name = "txtPWdateNow"
        Me.txtPWdateNow.ReadOnly = True
        Me.txtPWdateNow.Size = New System.Drawing.Size(146, 26)
        Me.txtPWdateNow.TabIndex = 107
        Me.txtPWdateNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPWsaleID
        '
        Me.txtPWsaleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWsaleID.ForeColor = System.Drawing.Color.Blue
        Me.txtPWsaleID.Location = New System.Drawing.Point(479, 20)
        Me.txtPWsaleID.Name = "txtPWsaleID"
        Me.txtPWsaleID.ReadOnly = True
        Me.txtPWsaleID.Size = New System.Drawing.Size(229, 22)
        Me.txtPWsaleID.TabIndex = 106
        Me.txtPWsaleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCQ.SetToolTip(Me.txtPWsaleID, "เลขที่ใบเสนอราคา")
        '
        'cbbPWgetProSection
        '
        Me.cbbPWgetProSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbPWgetProSection.FormattingEnabled = True
        Me.cbbPWgetProSection.Location = New System.Drawing.Point(162, 15)
        Me.cbbPWgetProSection.Name = "cbbPWgetProSection"
        Me.cbbPWgetProSection.Size = New System.Drawing.Size(298, 32)
        Me.cbbPWgetProSection.TabIndex = 89
        '
        'txtPWproSearch
        '
        Me.txtPWproSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWproSearch.Location = New System.Drawing.Point(12, 15)
        Me.txtPWproSearch.Name = "txtPWproSearch"
        Me.txtPWproSearch.Size = New System.Drawing.Size(146, 31)
        Me.txtPWproSearch.TabIndex = 88
        Me.ToolTipCQ.SetToolTip(Me.txtPWproSearch, "ค้นหาสินค้า ใส่คำค้นหา เช่น ชื่อ แล้วกด enter")
        '
        'dgPWProsearch
        '
        Me.dgPWProsearch.AllowUserToAddRows = False
        Me.dgPWProsearch.AllowUserToDeleteRows = False
        Me.dgPWProsearch.AllowUserToOrderColumns = True
        Me.dgPWProsearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPWProsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPWProsearch.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPWProsearch.Location = New System.Drawing.Point(12, 57)
        Me.dgPWProsearch.Name = "dgPWProsearch"
        Me.dgPWProsearch.ReadOnly = True
        Me.dgPWProsearch.RowHeadersVisible = False
        Me.dgPWProsearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPWProsearch.Size = New System.Drawing.Size(639, 177)
        Me.dgPWProsearch.TabIndex = 105
        '
        'btnPWdel
        '
        Me.btnPWdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPWdel.Location = New System.Drawing.Point(174, 506)
        Me.btnPWdel.Name = "btnPWdel"
        Me.btnPWdel.Size = New System.Drawing.Size(101, 50)
        Me.btnPWdel.TabIndex = 91
        Me.btnPWdel.Text = "ลบรายการ^"
        Me.ToolTipCQ.SetToolTip(Me.btnPWdel, "ลบรายการสินค้า")
        Me.btnPWdel.UseVisualStyleBackColor = True
        '
        'btnPWbid
        '
        Me.btnPWbid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPWbid.Location = New System.Drawing.Point(696, 506)
        Me.btnPWbid.Name = "btnPWbid"
        Me.btnPWbid.Size = New System.Drawing.Size(145, 50)
        Me.btnPWbid.TabIndex = 92
        Me.btnPWbid.Text = "พิมพ์ใบเสนอราคา"
        Me.ToolTipCQ.SetToolTip(Me.btnPWbid, "พิมพ์ใบเสนอราคา/พร้อมบันทึก")
        Me.btnPWbid.UseVisualStyleBackColor = True
        '
        'lblPwP
        '
        Me.lblPwP.AutoSize = True
        Me.lblPwP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPwP.Location = New System.Drawing.Point(814, 239)
        Me.lblPwP.Name = "lblPwP"
        Me.lblPwP.Size = New System.Drawing.Size(54, 20)
        Me.lblPwP.TabIndex = 104
        Me.lblPwP.Text = "ปริมาณ"
        '
        'lblPWunit
        '
        Me.lblPWunit.AutoSize = True
        Me.lblPWunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWunit.Location = New System.Drawing.Point(730, 239)
        Me.lblPWunit.Name = "lblPWunit"
        Me.lblPWunit.Size = New System.Drawing.Size(42, 20)
        Me.lblPWunit.TabIndex = 103
        Me.lblPWunit.Text = "หน่วย"
        '
        'lblPWprice
        '
        Me.lblPWprice.AutoSize = True
        Me.lblPWprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWprice.Location = New System.Drawing.Point(632, 239)
        Me.lblPWprice.Name = "lblPWprice"
        Me.lblPWprice.Size = New System.Drawing.Size(39, 20)
        Me.lblPWprice.TabIndex = 102
        Me.lblPWprice.Text = "ราคา"
        '
        'lblPWproName
        '
        Me.lblPWproName.AutoSize = True
        Me.lblPWproName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWproName.Location = New System.Drawing.Point(402, 239)
        Me.lblPWproName.Name = "lblPWproName"
        Me.lblPWproName.Size = New System.Drawing.Size(59, 20)
        Me.lblPWproName.TabIndex = 101
        Me.lblPWproName.Text = "ชื่อสินค้า"
        '
        'lblPWcodeORbarcode
        '
        Me.lblPWcodeORbarcode.AutoSize = True
        Me.lblPWcodeORbarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWcodeORbarcode.Location = New System.Drawing.Point(185, 239)
        Me.lblPWcodeORbarcode.Name = "lblPWcodeORbarcode"
        Me.lblPWcodeORbarcode.Size = New System.Drawing.Size(57, 20)
        Me.lblPWcodeORbarcode.TabIndex = 100
        Me.lblPWcodeORbarcode.Text = "บาร์โค๊ต"
        '
        'lblPWgetTotalPrice
        '
        Me.lblPWgetTotalPrice.BackColor = System.Drawing.Color.DarkBlue
        Me.lblPWgetTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWgetTotalPrice.ForeColor = System.Drawing.Color.Gold
        Me.lblPWgetTotalPrice.Location = New System.Drawing.Point(662, 127)
        Me.lblPWgetTotalPrice.Name = "lblPWgetTotalPrice"
        Me.lblPWgetTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPWgetTotalPrice.Size = New System.Drawing.Size(293, 84)
        Me.lblPWgetTotalPrice.TabIndex = 99
        Me.lblPWgetTotalPrice.Text = "-"
        Me.lblPWgetTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPWokTodg
        '
        Me.btnPWokTodg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPWokTodg.Location = New System.Drawing.Point(890, 260)
        Me.btnPWokTodg.Name = "btnPWokTodg"
        Me.btnPWokTodg.Size = New System.Drawing.Size(68, 31)
        Me.btnPWokTodg.TabIndex = 87
        Me.btnPWokTodg.Text = "ตกลง"
        Me.btnPWokTodg.UseVisualStyleBackColor = True
        '
        'txtPWprop
        '
        Me.txtPWprop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWprop.Location = New System.Drawing.Point(802, 261)
        Me.txtPWprop.Name = "txtPWprop"
        Me.txtPWprop.ReadOnly = True
        Me.txtPWprop.Size = New System.Drawing.Size(85, 29)
        Me.txtPWprop.TabIndex = 98
        '
        'txtPWproUnit
        '
        Me.txtPWproUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWproUnit.Location = New System.Drawing.Point(709, 261)
        Me.txtPWproUnit.Name = "txtPWproUnit"
        Me.txtPWproUnit.ReadOnly = True
        Me.txtPWproUnit.Size = New System.Drawing.Size(87, 29)
        Me.txtPWproUnit.TabIndex = 97
        '
        'txtPWproprice
        '
        Me.txtPWproprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWproprice.Location = New System.Drawing.Point(609, 261)
        Me.txtPWproprice.Name = "txtPWproprice"
        Me.txtPWproprice.ReadOnly = True
        Me.txtPWproprice.Size = New System.Drawing.Size(94, 29)
        Me.txtPWproprice.TabIndex = 96
        '
        'txtPWproname
        '
        Me.txtPWproname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWproname.Location = New System.Drawing.Point(281, 261)
        Me.txtPWproname.Name = "txtPWproname"
        Me.txtPWproname.ReadOnly = True
        Me.txtPWproname.Size = New System.Drawing.Size(322, 29)
        Me.txtPWproname.TabIndex = 95
        '
        'txtPWprobarcodeANDsn
        '
        Me.txtPWprobarcodeANDsn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPWprobarcodeANDsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWprobarcodeANDsn.Location = New System.Drawing.Point(11, 261)
        Me.txtPWprobarcodeANDsn.Name = "txtPWprobarcodeANDsn"
        Me.txtPWprobarcodeANDsn.Size = New System.Drawing.Size(120, 29)
        Me.txtPWprobarcodeANDsn.TabIndex = 86
        Me.ToolTipCQ.SetToolTip(Me.txtPWprobarcodeANDsn, "ใส่บาร์โค๊ตหรือ SN ของสินค้า")
        '
        'btnCQsearceQuotation
        '
        Me.btnCQsearceQuotation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCQsearceQuotation.Location = New System.Drawing.Point(11, 506)
        Me.btnCQsearceQuotation.Name = "btnCQsearceQuotation"
        Me.btnCQsearceQuotation.Size = New System.Drawing.Size(158, 50)
        Me.btnCQsearceQuotation.TabIndex = 125
        Me.btnCQsearceQuotation.Text = "ค้นหาใบเสนอราคา"
        Me.ToolTipCQ.SetToolTip(Me.btnCQsearceQuotation, "ค้นหาใบเสนอราคาที่ออกไปแล้ว")
        Me.btnCQsearceQuotation.UseVisualStyleBackColor = True
        '
        'rbCQpic
        '
        Me.rbCQpic.AutoSize = True
        Me.rbCQpic.Checked = True
        Me.rbCQpic.Location = New System.Drawing.Point(587, 512)
        Me.rbCQpic.Name = "rbCQpic"
        Me.rbCQpic.Size = New System.Drawing.Size(90, 17)
        Me.rbCQpic.TabIndex = 126
        Me.rbCQpic.TabStop = True
        Me.rbCQpic.Text = "พิมพ์แบบมีรูป"
        Me.rbCQpic.UseVisualStyleBackColor = True
        '
        'rbCQnoPic
        '
        Me.rbCQnoPic.AutoSize = True
        Me.rbCQnoPic.Location = New System.Drawing.Point(587, 535)
        Me.rbCQnoPic.Name = "rbCQnoPic"
        Me.rbCQnoPic.Size = New System.Drawing.Size(103, 17)
        Me.rbCQnoPic.TabIndex = 127
        Me.rbCQnoPic.Text = "พิมพ์แบบไม่มีรูป"
        Me.rbCQnoPic.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 563)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(320, 13)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "สินค้าจะไม่ถูกตัดจากสต็อกเพียงแต่นำชื่อมาออกใบเสนอราคาเท่านั้น"
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(696, 563)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 129
        Me.lblemployee.Text = "User"
        '
        'CreateQuotationFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 585)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rbCQnoPic)
        Me.Controls.Add(Me.rbCQpic)
        Me.Controls.Add(Me.btnCQsearceQuotation)
        Me.Controls.Add(Me.lblPWtotalXYZ)
        Me.Controls.Add(Me.btnPWclose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgPWproMeNoSN)
        Me.Controls.Add(Me.lblPESerial)
        Me.Controls.Add(Me.txtPWprobarcode)
        Me.Controls.Add(Me.btnPWchangCus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPWcusTel)
        Me.Controls.Add(Me.txtPWcusName)
        Me.Controls.Add(Me.txtPWcusID)
        Me.Controls.Add(Me.lblPWdategetbill)
        Me.Controls.Add(Me.txtPWdateNow)
        Me.Controls.Add(Me.txtPWsaleID)
        Me.Controls.Add(Me.cbbPWgetProSection)
        Me.Controls.Add(Me.txtPWproSearch)
        Me.Controls.Add(Me.dgPWProsearch)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CreateQuotationFrm"
        Me.Text = "สร้างใบเสนอราคา"
        CType(Me.dgPWproMeNoSN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPWProsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPWtotalXYZ As System.Windows.Forms.Label
    Friend WithEvents btnPWclose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgPWproMeNoSN As System.Windows.Forms.DataGridView
    Friend WithEvents lblPESerial As System.Windows.Forms.Label
    Friend WithEvents txtPWprobarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnPWchangCus As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPWcusTel As System.Windows.Forms.TextBox
    Friend WithEvents txtPWcusName As System.Windows.Forms.TextBox
    Friend WithEvents txtPWcusID As System.Windows.Forms.TextBox
    Friend WithEvents lblPWdategetbill As System.Windows.Forms.Label
    Friend WithEvents txtPWdateNow As System.Windows.Forms.TextBox
    Friend WithEvents txtPWsaleID As System.Windows.Forms.TextBox
    Friend WithEvents cbbPWgetProSection As System.Windows.Forms.ComboBox
    Friend WithEvents txtPWproSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgPWProsearch As System.Windows.Forms.DataGridView
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
    Friend WithEvents ToolTipCQ As System.Windows.Forms.ToolTip
    Friend WithEvents btnCQsearceQuotation As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents rbCQpic As System.Windows.Forms.RadioButton
    Friend WithEvents rbCQnoPic As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
