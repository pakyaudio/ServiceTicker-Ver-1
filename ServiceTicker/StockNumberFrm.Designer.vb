<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockNumberFrm
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgSN = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.snNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_wholesale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_technician = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_loyel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_members = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSNgetsn = New System.Windows.Forms.Button()
        Me.btnSNprint = New System.Windows.Forms.Button()
        Me.btnSNgetdata = New System.Windows.Forms.Button()
        Me.ToolTipSN = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtSNtotal_costA = New System.Windows.Forms.TextBox()
        Me.txtSNtotal_p = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSNtotal_buy = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbSNtype = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.cbSNshowAll = New System.Windows.Forms.CheckBox()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgSN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgSN
        '
        Me.dgSN.AllowUserToAddRows = False
        Me.dgSN.AllowUserToDeleteRows = False
        Me.dgSN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgSN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.code_pro, Me.bar_code, Me.name_pro, Me.p_type, Me.number, Me.snNum, Me.NoSN, Me.price_cost, Me.price_buy, Me.price_wholesale, Me.price_technician, Me.price_loyel, Me.price_members, Me.total_cost, Me.total_price})
        Me.dgSN.Location = New System.Drawing.Point(11, 51)
        Me.dgSN.MultiSelect = False
        Me.dgSN.Name = "dgSN"
        Me.dgSN.RowHeadersVisible = False
        Me.dgSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSN.Size = New System.Drawing.Size(760, 305)
        Me.dgSN.TabIndex = 0
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.code_pro.Width = 120
        '
        'bar_code
        '
        Me.bar_code.HeaderText = "บาร์โค๊ต"
        Me.bar_code.Name = "bar_code"
        Me.bar_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.bar_code.Width = 120
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 200
        '
        'p_type
        '
        Me.p_type.HeaderText = "ประเภท"
        Me.p_type.Name = "p_type"
        Me.p_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.p_type.Width = 70
        '
        'number
        '
        Me.number.HeaderText = "จำนวน"
        Me.number.Name = "number"
        Me.number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.number.ToolTipText = "จำนวนสินค้าทั้งหมด"
        Me.number.Width = 50
        '
        'snNum
        '
        Me.snNum.HeaderText = "SN"
        Me.snNum.Name = "snNum"
        Me.snNum.ToolTipText = "จำนวนสินค้าที่เป็น SN"
        Me.snNum.Width = 50
        '
        'NoSN
        '
        Me.NoSN.HeaderText = "NO SN"
        Me.NoSN.Name = "NoSN"
        Me.NoSN.ToolTipText = "จำนวนสินค้าที่ไม่มี SN"
        Me.NoSN.Width = 70
        '
        'price_cost
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.price_cost.DefaultCellStyle = DataGridViewCellStyle1
        Me.price_cost.HeaderText = "ทุน"
        Me.price_cost.Name = "price_cost"
        Me.price_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_cost.ToolTipText = "ราคาทุน"
        Me.price_cost.Width = 50
        '
        'price_buy
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle2
        Me.price_buy.HeaderText = "ปกติ"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.ToolTipText = "ราคาขายปกติ"
        Me.price_buy.Width = 50
        '
        'price_wholesale
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.price_wholesale.DefaultCellStyle = DataGridViewCellStyle3
        Me.price_wholesale.HeaderText = "ส่ง"
        Me.price_wholesale.Name = "price_wholesale"
        Me.price_wholesale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_wholesale.ToolTipText = "ราคาขายส่ง"
        Me.price_wholesale.Width = 50
        '
        'price_technician
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.price_technician.DefaultCellStyle = DataGridViewCellStyle4
        Me.price_technician.HeaderText = "ช่าง"
        Me.price_technician.Name = "price_technician"
        Me.price_technician.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_technician.ToolTipText = "ราคาช่าง"
        Me.price_technician.Width = 50
        '
        'price_loyel
        '
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.price_loyel.DefaultCellStyle = DataGridViewCellStyle5
        Me.price_loyel.HeaderText = "ประจำ"
        Me.price_loyel.Name = "price_loyel"
        Me.price_loyel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_loyel.ToolTipText = "ราคาลูกค้าประจำ"
        Me.price_loyel.Width = 50
        '
        'price_members
        '
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.price_members.DefaultCellStyle = DataGridViewCellStyle6
        Me.price_members.HeaderText = "สมาชิก"
        Me.price_members.Name = "price_members"
        Me.price_members.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_members.ToolTipText = "ราคาสมาชิก"
        Me.price_members.Width = 50
        '
        'total_cost
        '
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.total_cost.DefaultCellStyle = DataGridViewCellStyle7
        Me.total_cost.HeaderText = "รวมทุน"
        Me.total_cost.Name = "total_cost"
        Me.total_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_cost.Width = 70
        '
        'total_price
        '
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.total_price.DefaultCellStyle = DataGridViewCellStyle8
        Me.total_price.HeaderText = "รวมขาย"
        Me.total_price.Name = "total_price"
        Me.total_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_price.ToolTipText = "รวมราคาขายปกติ"
        '
        'btnSNgetsn
        '
        Me.btnSNgetsn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSNgetsn.Location = New System.Drawing.Point(135, 362)
        Me.btnSNgetsn.Name = "btnSNgetsn"
        Me.btnSNgetsn.Size = New System.Drawing.Size(117, 23)
        Me.btnSNgetsn.TabIndex = 1
        Me.btnSNgetsn.Text = "ดูรายการ SN"
        Me.btnSNgetsn.UseVisualStyleBackColor = True
        '
        'btnSNprint
        '
        Me.btnSNprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSNprint.Location = New System.Drawing.Point(12, 362)
        Me.btnSNprint.Name = "btnSNprint"
        Me.btnSNprint.Size = New System.Drawing.Size(117, 23)
        Me.btnSNprint.TabIndex = 2
        Me.btnSNprint.Text = "พิมพ์"
        Me.btnSNprint.UseVisualStyleBackColor = True
        '
        'btnSNgetdata
        '
        Me.btnSNgetdata.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSNgetdata.Location = New System.Drawing.Point(623, 16)
        Me.btnSNgetdata.Name = "btnSNgetdata"
        Me.btnSNgetdata.Size = New System.Drawing.Size(149, 23)
        Me.btnSNgetdata.TabIndex = 4
        Me.btnSNgetdata.Text = "ตรวจสอบจำนวน"
        Me.ToolTipSN.SetToolTip(Me.btnSNgetdata, "นับจำนวนสินค้าที่มีทั้งหมดในสต็อก")
        Me.btnSNgetdata.UseVisualStyleBackColor = True
        '
        'txtSNtotal_costA
        '
        Me.txtSNtotal_costA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSNtotal_costA.Location = New System.Drawing.Point(557, 362)
        Me.txtSNtotal_costA.Name = "txtSNtotal_costA"
        Me.txtSNtotal_costA.ReadOnly = True
        Me.txtSNtotal_costA.Size = New System.Drawing.Size(104, 20)
        Me.txtSNtotal_costA.TabIndex = 11
        Me.txtSNtotal_costA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSNtotal_p
        '
        Me.txtSNtotal_p.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSNtotal_p.Location = New System.Drawing.Point(447, 362)
        Me.txtSNtotal_p.Name = "txtSNtotal_p"
        Me.txtSNtotal_p.ReadOnly = True
        Me.txtSNtotal_p.Size = New System.Drawing.Size(104, 20)
        Me.txtSNtotal_p.TabIndex = 12
        Me.txtSNtotal_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(451, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "จำนวนสินค้าทั้งหมด"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(568, 385)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "จำนวนทุนทั้งหมด"
        '
        'txtSNtotal_buy
        '
        Me.txtSNtotal_buy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSNtotal_buy.Location = New System.Drawing.Point(667, 362)
        Me.txtSNtotal_buy.Name = "txtSNtotal_buy"
        Me.txtSNtotal_buy.ReadOnly = True
        Me.txtSNtotal_buy.Size = New System.Drawing.Size(104, 20)
        Me.txtSNtotal_buy.TabIndex = 18
        Me.txtSNtotal_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(676, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "รวมราคาขายปกติ"
        '
        'cbbSNtype
        '
        Me.cbbSNtype.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbSNtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbSNtype.FormattingEnabled = True
        Me.cbbSNtype.Location = New System.Drawing.Point(335, 18)
        Me.cbbSNtype.Name = "cbbSNtype"
        Me.cbbSNtype.Size = New System.Drawing.Size(282, 21)
        Me.cbbSNtype.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "ประเภท"
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(27, -2)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(120, 17)
        Me.rb1.TabIndex = 22
        Me.rb1.Text = "เลือกเฉพาะที่มีสินค้า"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Checked = True
        Me.rb2.Location = New System.Drawing.Point(27, 14)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(166, 17)
        Me.rb2.TabIndex = 23
        Me.rb2.TabStop = True
        Me.rb2.Text = "เลือกทั้งที่มีสินค้าและไม่มีสินค้า"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Location = New System.Drawing.Point(27, 30)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(133, 17)
        Me.rb3.TabIndex = 24
        Me.rb3.Text = "เลือกเฉพาะที่ไมีมีสินค้า"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'cbSNshowAll
        '
        Me.cbSNshowAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSNshowAll.AutoSize = True
        Me.cbSNshowAll.Location = New System.Drawing.Point(624, -1)
        Me.cbSNshowAll.Name = "cbSNshowAll"
        Me.cbSNshowAll.Size = New System.Drawing.Size(148, 17)
        Me.cbSNshowAll.TabIndex = 25
        Me.cbSNshowAll.Text = "แสดงสินค้ารวมทุกประเภท"
        Me.cbSNshowAll.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(8, 390)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 26
        Me.lblemployee.Text = "User"
        '
        'StockNumberFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.cbSNshowAll)
        Me.Controls.Add(Me.rb3)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbbSNtype)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSNtotal_buy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSNtotal_p)
        Me.Controls.Add(Me.txtSNtotal_costA)
        Me.Controls.Add(Me.btnSNgetdata)
        Me.Controls.Add(Me.btnSNprint)
        Me.Controls.Add(Me.btnSNgetsn)
        Me.Controls.Add(Me.dgSN)
        Me.Name = "StockNumberFrm"
        Me.Text = "รายงานจำนวนสต็อก"
        CType(Me.dgSN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgSN As System.Windows.Forms.DataGridView
    Friend WithEvents btnSNgetsn As System.Windows.Forms.Button
    Friend WithEvents btnSNprint As System.Windows.Forms.Button
    Friend WithEvents btnSNgetdata As System.Windows.Forms.Button
    Friend WithEvents ToolTipSN As System.Windows.Forms.ToolTip
    Friend WithEvents txtSNtotal_costA As System.Windows.Forms.TextBox
    Friend WithEvents txtSNtotal_p As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSNtotal_buy As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbbSNtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents cbSNshowAll As System.Windows.Forms.CheckBox
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents snNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_wholesale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_technician As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_loyel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_members As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
