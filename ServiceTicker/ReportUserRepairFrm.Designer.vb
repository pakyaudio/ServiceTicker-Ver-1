<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportUserRepairFrm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportUserRepairFrm))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbbRURselectUser = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRURsearch = New System.Windows.Forms.Button()
        Me.dgRUR = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtRURtotalCost = New System.Windows.Forms.TextBox()
        Me.txtRURtotalBuy = New System.Windows.Forms.TextBox()
        Me.txtRURtotalProfit = New System.Windows.Forms.TextBox()
        Me.lblRURcost = New System.Windows.Forms.Label()
        Me.lblRURbuy = New System.Windows.Forms.Label()
        Me.lblRURprofit = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRURrows = New System.Windows.Forms.TextBox()
        Me.txtRURdiscount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRUprint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgRUR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy MMMM dd"
        Me.DateTimePicker1.Location = New System.Drawing.Point(39, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.Value = New Date(2015, 1, 30, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Location = New System.Drawing.Point(39, 38)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 1
        Me.DateTimePicker2.Value = New Date(2015, 1, 30, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "จาก"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ถึง"
        '
        'cbbRURselectUser
        '
        Me.cbbRURselectUser.FormattingEnabled = True
        Me.cbbRURselectUser.Location = New System.Drawing.Point(311, 11)
        Me.cbbRURselectUser.Name = "cbbRURselectUser"
        Me.cbbRURselectUser.Size = New System.Drawing.Size(155, 21)
        Me.cbbRURselectUser.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ชื่อผู้ซ่อม"
        '
        'btnRURsearch
        '
        Me.btnRURsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRURsearch.Location = New System.Drawing.Point(503, 11)
        Me.btnRURsearch.Name = "btnRURsearch"
        Me.btnRURsearch.Size = New System.Drawing.Size(170, 47)
        Me.btnRURsearch.TabIndex = 6
        Me.btnRURsearch.Text = "ค้นหา"
        Me.btnRURsearch.UseVisualStyleBackColor = True
        '
        'dgRUR
        '
        Me.dgRUR.AllowUserToAddRows = False
        Me.dgRUR.AllowUserToDeleteRows = False
        Me.dgRUR.AllowUserToOrderColumns = True
        Me.dgRUR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgRUR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgRUR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRUR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.fix_id, Me.customer_name, Me.code_pro, Me.name_pro, Me.total_pro, Me.price_cost, Me.price_buy, Me.discount, Me.total_cost, Me.total_buy, Me.datetime_save})
        Me.dgRUR.Location = New System.Drawing.Point(12, 77)
        Me.dgRUR.Name = "dgRUR"
        Me.dgRUR.ReadOnly = True
        Me.dgRUR.RowHeadersVisible = False
        Me.dgRUR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRUR.Size = New System.Drawing.Size(760, 407)
        Me.dgRUR.TabIndex = 7
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
        Me.no.ToolTipText = "ลำดับ"
        Me.no.Width = 30
        '
        'fix_id
        '
        Me.fix_id.DataPropertyName = "fix_id"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.fix_id.DefaultCellStyle = DataGridViewCellStyle2
        Me.fix_id.Frozen = True
        Me.fix_id.HeaderText = "รหัสใบซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.ReadOnly = True
        Me.fix_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fix_id.ToolTipText = "รหัสใบซ่อม"
        Me.fix_id.Width = 120
        '
        'customer_name
        '
        Me.customer_name.DataPropertyName = "customer_name"
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_name.ToolTipText = "ชื่อลูกค้า"
        Me.customer_name.Width = 110
        '
        'code_pro
        '
        Me.code_pro.DataPropertyName = "code_pro"
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.code_pro.ToolTipText = "รหัสสินค้า"
        Me.code_pro.Width = 110
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
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
        Me.total_pro.ToolTipText = "จำนวนสินค้าที่ขาย/เบิก"
        Me.total_pro.Width = 50
        '
        'price_cost
        '
        Me.price_cost.DataPropertyName = "price_cost"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.price_cost.DefaultCellStyle = DataGridViewCellStyle3
        Me.price_cost.HeaderText = "ทุน"
        Me.price_cost.Name = "price_cost"
        Me.price_cost.ReadOnly = True
        Me.price_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_cost.ToolTipText = "ราคาทุน"
        Me.price_cost.Width = 50
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle4
        Me.price_buy.HeaderText = "ขาย"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.ToolTipText = "ราคาขาย"
        Me.price_buy.Width = 50
        '
        'discount
        '
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.discount.DefaultCellStyle = DataGridViewCellStyle5
        Me.discount.HeaderText = "ลด"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        Me.discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.discount.ToolTipText = "ส่วนลดสินค้า/บริการ"
        Me.discount.Width = 40
        '
        'total_cost
        '
        Me.total_cost.DataPropertyName = "total_cost"
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.total_cost.DefaultCellStyle = DataGridViewCellStyle6
        Me.total_cost.HeaderText = "รวมทุน"
        Me.total_cost.Name = "total_cost"
        Me.total_cost.ReadOnly = True
        Me.total_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_cost.ToolTipText = "รวมราคาทุน"
        Me.total_cost.Width = 70
        '
        'total_buy
        '
        Me.total_buy.DataPropertyName = "total_buy"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.total_buy.DefaultCellStyle = DataGridViewCellStyle7
        Me.total_buy.HeaderText = "รวมขาย"
        Me.total_buy.Name = "total_buy"
        Me.total_buy.ReadOnly = True
        Me.total_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_buy.ToolTipText = "รวมราคาขาย"
        Me.total_buy.Width = 70
        '
        'datetime_save
        '
        Me.datetime_save.DataPropertyName = "datetime_save"
        Me.datetime_save.HeaderText = "วันที่"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.ToolTipText = "วันที่ส่งคืนเครื่อง"
        '
        'txtRURtotalCost
        '
        Me.txtRURtotalCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRURtotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRURtotalCost.Location = New System.Drawing.Point(404, 525)
        Me.txtRURtotalCost.Name = "txtRURtotalCost"
        Me.txtRURtotalCost.ReadOnly = True
        Me.txtRURtotalCost.Size = New System.Drawing.Size(108, 29)
        Me.txtRURtotalCost.TabIndex = 8
        Me.txtRURtotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRURtotalBuy
        '
        Me.txtRURtotalBuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRURtotalBuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRURtotalBuy.Location = New System.Drawing.Point(274, 525)
        Me.txtRURtotalBuy.Name = "txtRURtotalBuy"
        Me.txtRURtotalBuy.ReadOnly = True
        Me.txtRURtotalBuy.Size = New System.Drawing.Size(108, 29)
        Me.txtRURtotalBuy.TabIndex = 9
        Me.txtRURtotalBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRURtotalProfit
        '
        Me.txtRURtotalProfit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRURtotalProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRURtotalProfit.Location = New System.Drawing.Point(667, 525)
        Me.txtRURtotalProfit.Name = "txtRURtotalProfit"
        Me.txtRURtotalProfit.ReadOnly = True
        Me.txtRURtotalProfit.Size = New System.Drawing.Size(108, 29)
        Me.txtRURtotalProfit.TabIndex = 10
        Me.txtRURtotalProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRURcost
        '
        Me.lblRURcost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRURcost.AutoSize = True
        Me.lblRURcost.Location = New System.Drawing.Point(427, 556)
        Me.lblRURcost.Name = "lblRURcost"
        Me.lblRURcost.Size = New System.Drawing.Size(64, 13)
        Me.lblRURcost.TabIndex = 11
        Me.lblRURcost.Text = "รวมราคาทุน"
        '
        'lblRURbuy
        '
        Me.lblRURbuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRURbuy.AutoSize = True
        Me.lblRURbuy.Location = New System.Drawing.Point(295, 556)
        Me.lblRURbuy.Name = "lblRURbuy"
        Me.lblRURbuy.Size = New System.Drawing.Size(67, 13)
        Me.lblRURbuy.TabIndex = 12
        Me.lblRURbuy.Text = "รวมราคาขาย"
        '
        'lblRURprofit
        '
        Me.lblRURprofit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRURprofit.AutoSize = True
        Me.lblRURprofit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRURprofit.Location = New System.Drawing.Point(706, 556)
        Me.lblRURprofit.Name = "lblRURprofit"
        Me.lblRURprofit.Size = New System.Drawing.Size(35, 13)
        Me.lblRURprofit.TabIndex = 13
        Me.lblRURprofit.Text = "กำไร"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(648, 535)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "="
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(388, 536)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "-"
        '
        'txtRURrows
        '
        Me.txtRURrows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRURrows.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRURrows.Location = New System.Drawing.Point(11, 525)
        Me.txtRURrows.Name = "txtRURrows"
        Me.txtRURrows.ReadOnly = True
        Me.txtRURrows.Size = New System.Drawing.Size(237, 29)
        Me.txtRURrows.TabIndex = 16
        Me.txtRURrows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRURdiscount
        '
        Me.txtRURdiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRURdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRURdiscount.Location = New System.Drawing.Point(534, 525)
        Me.txtRURdiscount.Name = "txtRURdiscount"
        Me.txtRURdiscount.ReadOnly = True
        Me.txtRURdiscount.Size = New System.Drawing.Size(108, 29)
        Me.txtRURdiscount.TabIndex = 17
        Me.txtRURdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(518, 535)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "-"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(568, 557)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "รวมส่วนลด"
        '
        'btnRUprint
        '
        Me.btnRUprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRUprint.Location = New System.Drawing.Point(667, 490)
        Me.btnRUprint.Name = "btnRUprint"
        Me.btnRUprint.Size = New System.Drawing.Size(108, 29)
        Me.btnRUprint.TabIndex = 21
        Me.btnRUprint.Text = "พิมพ์รายงาน"
        Me.btnRUprint.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(11, 557)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 22
        Me.lblemployee.Text = "User"
        '
        'ReportUserRepairFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 578)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.btnRUprint)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRURdiscount)
        Me.Controls.Add(Me.txtRURrows)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblRURprofit)
        Me.Controls.Add(Me.lblRURbuy)
        Me.Controls.Add(Me.lblRURcost)
        Me.Controls.Add(Me.txtRURtotalProfit)
        Me.Controls.Add(Me.txtRURtotalBuy)
        Me.Controls.Add(Me.txtRURtotalCost)
        Me.Controls.Add(Me.dgRUR)
        Me.Controls.Add(Me.btnRURsearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbbRURselectUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "ReportUserRepairFrm"
        Me.Text = "รายงานการซ่อมตามชื่อผู้ซ่อม"
        CType(Me.dgRUR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbbRURselectUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRURsearch As System.Windows.Forms.Button
    Friend WithEvents dgRUR As System.Windows.Forms.DataGridView
    Friend WithEvents txtRURtotalCost As System.Windows.Forms.TextBox
    Friend WithEvents txtRURtotalBuy As System.Windows.Forms.TextBox
    Friend WithEvents txtRURtotalProfit As System.Windows.Forms.TextBox
    Friend WithEvents lblRURcost As System.Windows.Forms.Label
    Friend WithEvents lblRURbuy As System.Windows.Forms.Label
    Friend WithEvents lblRURprofit As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRURrows As System.Windows.Forms.TextBox
    Friend WithEvents txtRURdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnRUprint As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
