<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendRepairFrm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSRgetDataByFixID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSRgetDataByFixID = New System.Windows.Forms.Button()
        Me.txtSRfixPrice = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSRfixRepairNote = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSRfixAccessory = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbbSRRcash_status = New System.Windows.Forms.ComboBox()
        Me.lblSRpayment = New System.Windows.Forms.Label()
        Me.btnSRsaveAndSend = New System.Windows.Forms.Button()
        Me.btnSRcancel = New System.Windows.Forms.Button()
        Me.ToolTipSRR = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSRselectcomfix = New System.Windows.Forms.Button()
        Me.txtHideform = New System.Windows.Forms.TextBox()
        Me.txtSRstatus = New System.Windows.Forms.TextBox()
        Me.DateTimePickerSRR = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgSRsale_detail = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSRsale_id = New System.Windows.Forms.TextBox()
        Me.lblSRcusname = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSRcustomerDetail = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgSRsale_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSRgetDataByFixID
        '
        Me.txtSRgetDataByFixID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSRgetDataByFixID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRgetDataByFixID.ForeColor = System.Drawing.Color.Navy
        Me.txtSRgetDataByFixID.Location = New System.Drawing.Point(102, 4)
        Me.txtSRgetDataByFixID.Name = "txtSRgetDataByFixID"
        Me.txtSRgetDataByFixID.Size = New System.Drawing.Size(206, 26)
        Me.txtSRgetDataByFixID.TabIndex = 0
        Me.txtSRgetDataByFixID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipSRR.SetToolTip(Me.txtSRgetDataByFixID, "ใส่เลขที่ใบรับซ่อมสินค้าเพื่อค้นหางานซ่อม")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "เลขใบรับซ่อม"
        '
        'btnSRgetDataByFixID
        '
        Me.btnSRgetDataByFixID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSRgetDataByFixID.Location = New System.Drawing.Point(314, 4)
        Me.btnSRgetDataByFixID.Name = "btnSRgetDataByFixID"
        Me.btnSRgetDataByFixID.Size = New System.Drawing.Size(67, 26)
        Me.btnSRgetDataByFixID.TabIndex = 1
        Me.btnSRgetDataByFixID.Text = "ค้นหา"
        Me.ToolTipSRR.SetToolTip(Me.btnSRgetDataByFixID, "กดเพื่อค้นหาใบรับซ่อม")
        Me.btnSRgetDataByFixID.UseVisualStyleBackColor = True
        '
        'txtSRfixPrice
        '
        Me.txtSRfixPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRfixPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSRfixPrice.Location = New System.Drawing.Point(365, 389)
        Me.txtSRfixPrice.Name = "txtSRfixPrice"
        Me.txtSRfixPrice.ReadOnly = True
        Me.txtSRfixPrice.Size = New System.Drawing.Size(132, 26)
        Me.txtSRfixPrice.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(319, 392)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 20)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "ราคา"
        '
        'txtSRfixRepairNote
        '
        Me.txtSRfixRepairNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRfixRepairNote.Location = New System.Drawing.Point(87, 290)
        Me.txtSRfixRepairNote.Multiline = True
        Me.txtSRfixRepairNote.Name = "txtSRfixRepairNote"
        Me.txtSRfixRepairNote.ReadOnly = True
        Me.txtSRfixRepairNote.Size = New System.Drawing.Size(410, 64)
        Me.txtSRfixRepairNote.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 312)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 20)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "ผลการซ่อม"
        '
        'txtSRfixAccessory
        '
        Me.txtSRfixAccessory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRfixAccessory.Location = New System.Drawing.Point(132, 360)
        Me.txtSRfixAccessory.Name = "txtSRfixAccessory"
        Me.txtSRfixAccessory.ReadOnly = True
        Me.txtSRfixAccessory.Size = New System.Drawing.Size(365, 26)
        Me.txtSRfixAccessory.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 363)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 20)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "อุปกรณ์ที่นำมาด้วย"
        '
        'cbbSRRcash_status
        '
        Me.cbbSRRcash_status.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbbSRRcash_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbSRRcash_status.FormattingEnabled = True
        Me.cbbSRRcash_status.Location = New System.Drawing.Point(360, 423)
        Me.cbbSRRcash_status.Name = "cbbSRRcash_status"
        Me.cbbSRRcash_status.Size = New System.Drawing.Size(137, 21)
        Me.cbbSRRcash_status.TabIndex = 35
        Me.ToolTipSRR.SetToolTip(Me.cbbSRRcash_status, "สถานะการชำระเงิน")
        '
        'lblSRpayment
        '
        Me.lblSRpayment.AutoSize = True
        Me.lblSRpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSRpayment.Location = New System.Drawing.Point(274, 424)
        Me.lblSRpayment.Name = "lblSRpayment"
        Me.lblSRpayment.Size = New System.Drawing.Size(84, 20)
        Me.lblSRpayment.TabIndex = 36
        Me.lblSRpayment.Text = "การชำระเงิน"
        '
        'btnSRsaveAndSend
        '
        Me.btnSRsaveAndSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSRsaveAndSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSRsaveAndSend.Location = New System.Drawing.Point(12, 423)
        Me.btnSRsaveAndSend.Name = "btnSRsaveAndSend"
        Me.btnSRsaveAndSend.Size = New System.Drawing.Size(150, 69)
        Me.btnSRsaveAndSend.TabIndex = 3
        Me.btnSRsaveAndSend.Text = "บันทึก/คืนสินค้า"
        Me.btnSRsaveAndSend.UseVisualStyleBackColor = True
        '
        'btnSRcancel
        '
        Me.btnSRcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSRcancel.Location = New System.Drawing.Point(168, 450)
        Me.btnSRcancel.Name = "btnSRcancel"
        Me.btnSRcancel.Size = New System.Drawing.Size(77, 42)
        Me.btnSRcancel.TabIndex = 38
        Me.btnSRcancel.Text = "ยกเลิก"
        Me.btnSRcancel.UseVisualStyleBackColor = True
        '
        'ToolTipSRR
        '
        Me.ToolTipSRR.IsBalloon = True
        '
        'btnSRselectcomfix
        '
        Me.btnSRselectcomfix.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSRselectcomfix.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSRselectcomfix.ForeColor = System.Drawing.Color.Navy
        Me.btnSRselectcomfix.Location = New System.Drawing.Point(387, 4)
        Me.btnSRselectcomfix.Name = "btnSRselectcomfix"
        Me.btnSRselectcomfix.Size = New System.Drawing.Size(116, 26)
        Me.btnSRselectcomfix.TabIndex = 2
        Me.btnSRselectcomfix.Text = "ค้นหาใบรับซ่อม"
        Me.ToolTipSRR.SetToolTip(Me.btnSRselectcomfix, "ค้นหาโดยละเอียด")
        Me.btnSRselectcomfix.UseVisualStyleBackColor = True
        '
        'txtHideform
        '
        Me.txtHideform.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHideform.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtHideform.ForeColor = System.Drawing.Color.Navy
        Me.txtHideform.Location = New System.Drawing.Point(87, 265)
        Me.txtHideform.Name = "txtHideform"
        Me.txtHideform.ReadOnly = True
        Me.txtHideform.Size = New System.Drawing.Size(271, 26)
        Me.txtHideform.TabIndex = 47
        Me.txtHideform.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipSRR.SetToolTip(Me.txtHideform, "เลขใบรับซ่อม")
        '
        'txtSRstatus
        '
        Me.txtSRstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRstatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSRstatus.Location = New System.Drawing.Point(360, 265)
        Me.txtSRstatus.Name = "txtSRstatus"
        Me.txtSRstatus.ReadOnly = True
        Me.txtSRstatus.Size = New System.Drawing.Size(137, 26)
        Me.txtSRstatus.TabIndex = 46
        Me.ToolTipSRR.SetToolTip(Me.txtSRstatus, "สถานะงานซ่อม")
        '
        'DateTimePickerSRR
        '
        Me.DateTimePickerSRR.Location = New System.Drawing.Point(360, 450)
        Me.DateTimePickerSRR.Name = "DateTimePickerSRR"
        Me.DateTimePickerSRR.Size = New System.Drawing.Size(143, 20)
        Me.DateTimePickerSRR.TabIndex = 39
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(249, 450)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 20)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "วันที่นัดชำระเงิน"
        '
        'dgSRsale_detail
        '
        Me.dgSRsale_detail.AllowUserToAddRows = False
        Me.dgSRsale_detail.AllowUserToDeleteRows = False
        Me.dgSRsale_detail.AllowUserToOrderColumns = True
        Me.dgSRsale_detail.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgSRsale_detail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSRsale_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSRsale_detail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.code_pro, Me.name_pro, Me.total_pro, Me.unit, Me.price_buy, Me.total_all})
        Me.dgSRsale_detail.Cursor = System.Windows.Forms.Cursors.No
        Me.dgSRsale_detail.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgSRsale_detail.Location = New System.Drawing.Point(12, 134)
        Me.dgSRsale_detail.Name = "dgSRsale_detail"
        Me.dgSRsale_detail.ReadOnly = True
        Me.dgSRsale_detail.RowHeadersVisible = False
        Me.dgSRsale_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSRsale_detail.Size = New System.Drawing.Size(491, 125)
        Me.dgSRsale_detail.TabIndex = 41
        '
        'no
        '
        Me.no.Frozen = True
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
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
        Me.code_pro.Width = 80
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.name_pro.DefaultCellStyle = DataGridViewCellStyle2
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.ToolTipText = "ชื่อสินค้า"
        Me.name_pro.Width = 170
        '
        'total_pro
        '
        Me.total_pro.DataPropertyName = "total_pro"
        Me.total_pro.HeaderText = "จำนวน"
        Me.total_pro.Name = "total_pro"
        Me.total_pro.ReadOnly = True
        Me.total_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_pro.ToolTipText = "จำนวนสินค้าที่เบิก"
        Me.total_pro.Width = 50
        '
        'unit
        '
        Me.unit.DataPropertyName = "unit"
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.ToolTipText = "หน่วยนับสินค้า"
        Me.unit.Width = 50
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle3
        Me.price_buy.HeaderText = "ราคา"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.Width = 40
        '
        'total_all
        '
        Me.total_all.DataPropertyName = "total_all"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.total_all.DefaultCellStyle = DataGridViewCellStyle4
        Me.total_all.HeaderText = "รวมราคา"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all.Width = 60
        '
        'txtSRsale_id
        '
        Me.txtSRsale_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRsale_id.Location = New System.Drawing.Point(314, 106)
        Me.txtSRsale_id.Name = "txtSRsale_id"
        Me.txtSRsale_id.ReadOnly = True
        Me.txtSRsale_id.Size = New System.Drawing.Size(189, 22)
        Me.txtSRsale_id.TabIndex = 42
        '
        'lblSRcusname
        '
        Me.lblSRcusname.AutoSize = True
        Me.lblSRcusname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSRcusname.ForeColor = System.Drawing.Color.Navy
        Me.lblSRcusname.Location = New System.Drawing.Point(9, 40)
        Me.lblSRcusname.Name = "lblSRcusname"
        Me.lblSRcusname.Size = New System.Drawing.Size(51, 16)
        Me.lblSRcusname.TabIndex = 43
        Me.lblSRcusname.Text = "ชื่อลูกค้า"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "เลขที่ใบเบิกสินค้า"
        '
        'lblSRcustomerDetail
        '
        Me.lblSRcustomerDetail.AutoSize = True
        Me.lblSRcustomerDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSRcustomerDetail.Location = New System.Drawing.Point(60, 40)
        Me.lblSRcustomerDetail.Name = "lblSRcustomerDetail"
        Me.lblSRcustomerDetail.Size = New System.Drawing.Size(12, 16)
        Me.lblSRcustomerDetail.TabIndex = 45
        Me.lblSRcustomerDetail.Text = "-"
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(253, 478)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 48
        Me.lblemployee.Text = "User"
        '
        'SendRepairFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 503)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.txtHideform)
        Me.Controls.Add(Me.txtSRstatus)
        Me.Controls.Add(Me.lblSRcustomerDetail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSRcusname)
        Me.Controls.Add(Me.txtSRsale_id)
        Me.Controls.Add(Me.dgSRsale_detail)
        Me.Controls.Add(Me.btnSRselectcomfix)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.DateTimePickerSRR)
        Me.Controls.Add(Me.btnSRcancel)
        Me.Controls.Add(Me.btnSRsaveAndSend)
        Me.Controls.Add(Me.lblSRpayment)
        Me.Controls.Add(Me.cbbSRRcash_status)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtSRfixAccessory)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtSRfixRepairNote)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtSRfixPrice)
        Me.Controls.Add(Me.btnSRgetDataByFixID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSRgetDataByFixID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SendRepairFrm"
        Me.Text = "ส่งคืนสินค้า"
        CType(Me.dgSRsale_detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSRgetDataByFixID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSRgetDataByFixID As System.Windows.Forms.Button
    Friend WithEvents txtSRfixPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSRfixRepairNote As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSRfixAccessory As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbbSRRcash_status As System.Windows.Forms.ComboBox
    Friend WithEvents lblSRpayment As System.Windows.Forms.Label
    Friend WithEvents btnSRsaveAndSend As System.Windows.Forms.Button
    Friend WithEvents btnSRcancel As System.Windows.Forms.Button
    Friend WithEvents ToolTipSRR As System.Windows.Forms.ToolTip
    Friend WithEvents DateTimePickerSRR As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnSRselectcomfix As System.Windows.Forms.Button
    Friend WithEvents dgSRsale_detail As System.Windows.Forms.DataGridView
    Friend WithEvents txtSRsale_id As System.Windows.Forms.TextBox
    Friend WithEvents lblSRcusname As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSRcustomerDetail As System.Windows.Forms.Label
    Friend WithEvents txtSRstatus As System.Windows.Forms.TextBox
    Friend WithEvents txtHideform As System.Windows.Forms.TextBox
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
