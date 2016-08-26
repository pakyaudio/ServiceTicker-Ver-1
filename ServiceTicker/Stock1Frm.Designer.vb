<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock1Frm
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
        Me.cbbSproStatus = New System.Windows.Forms.ComboBox()
        Me.cbbSproType = New System.Windows.Forms.ComboBox()
        Me.cbbSsaleCompany = New System.Windows.Forms.ComboBox()
        Me.txtSsearchPro = New System.Windows.Forms.TextBox()
        Me.dgStock = New System.Windows.Forms.DataGridView()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_num1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSshowallpro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSprofit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtScountProduct = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtScount_num = New System.Windows.Forms.TextBox()
        Me.txtScost = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbPrint = New System.Windows.Forms.PictureBox()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbbSproStatus
        '
        Me.cbbSproStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbSproStatus.FormattingEnabled = True
        Me.cbbSproStatus.Location = New System.Drawing.Point(12, 28)
        Me.cbbSproStatus.Name = "cbbSproStatus"
        Me.cbbSproStatus.Size = New System.Drawing.Size(178, 21)
        Me.cbbSproStatus.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cbbSproStatus, "แสดงรายการสินค้าตามจำนวนสินค้า")
        '
        'cbbSproType
        '
        Me.cbbSproType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbSproType.FormattingEnabled = True
        Me.cbbSproType.Location = New System.Drawing.Point(196, 28)
        Me.cbbSproType.Name = "cbbSproType"
        Me.cbbSproType.Size = New System.Drawing.Size(178, 21)
        Me.cbbSproType.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cbbSproType, "แสดงรายการสินค้าตามประเภท")
        '
        'cbbSsaleCompany
        '
        Me.cbbSsaleCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbSsaleCompany.FormattingEnabled = True
        Me.cbbSsaleCompany.Location = New System.Drawing.Point(380, 28)
        Me.cbbSsaleCompany.Name = "cbbSsaleCompany"
        Me.cbbSsaleCompany.Size = New System.Drawing.Size(178, 21)
        Me.cbbSsaleCompany.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.cbbSsaleCompany, "แสดงสินค้าตามบริษัทที่จัดซื้อ")
        '
        'txtSsearchPro
        '
        Me.txtSsearchPro.Location = New System.Drawing.Point(565, 28)
        Me.txtSsearchPro.Name = "txtSsearchPro"
        Me.txtSsearchPro.Size = New System.Drawing.Size(151, 20)
        Me.txtSsearchPro.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtSsearchPro, "ใส่ชื่อสินค้า กด enter เพื่อค้นหา")
        '
        'dgStock
        '
        Me.dgStock.AllowUserToAddRows = False
        Me.dgStock.AllowUserToDeleteRows = False
        Me.dgStock.AllowUserToOrderColumns = True
        Me.dgStock.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_pro, Me.bar_code, Me.name_pro, Me.price_cost, Me.price_buy, Me.unit, Me.count_num1})
        Me.dgStock.Location = New System.Drawing.Point(12, 55)
        Me.dgStock.Name = "dgStock"
        Me.dgStock.ReadOnly = True
        Me.dgStock.RowHeadersVisible = False
        Me.dgStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgStock.Size = New System.Drawing.Size(786, 434)
        Me.dgStock.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.dgStock, "ดับเบิ้ลคลิ๊กเพื่อเลือกข้อมูล")
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.code_pro.Width = 110
        '
        'bar_code
        '
        Me.bar_code.HeaderText = "บาร์โค๊ต"
        Me.bar_code.Name = "bar_code"
        Me.bar_code.ReadOnly = True
        Me.bar_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.bar_code.Width = 110
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 220
        '
        'price_cost
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.price_cost.DefaultCellStyle = DataGridViewCellStyle1
        Me.price_cost.HeaderText = "ราคาทุน"
        Me.price_cost.Name = "price_cost"
        Me.price_cost.ReadOnly = True
        Me.price_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_cost.Width = 80
        '
        'price_buy
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle2
        Me.price_buy.HeaderText = "ราคาขาย"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.Width = 90
        '
        'unit
        '
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.Width = 73
        '
        'count_num1
        '
        DataGridViewCellStyle3.NullValue = "0"
        Me.count_num1.DefaultCellStyle = DataGridViewCellStyle3
        Me.count_num1.HeaderText = "คงเหลือ"
        Me.count_num1.Name = "count_num1"
        Me.count_num1.ReadOnly = True
        Me.count_num1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.count_num1.Width = 73
        '
        'btnSshowallpro
        '
        Me.btnSshowallpro.Location = New System.Drawing.Point(723, 26)
        Me.btnSshowallpro.Name = "btnSshowallpro"
        Me.btnSshowallpro.Size = New System.Drawing.Size(75, 23)
        Me.btnSshowallpro.TabIndex = 4
        Me.btnSshowallpro.Text = "ค้นหา"
        Me.ToolTip1.SetToolTip(Me.btnSshowallpro, "ค้นหาสินค้า")
        Me.btnSshowallpro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(77, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ตามจำนวน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(264, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ตามประเภท"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(430, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ตามบริษัทที่จัดซื้อ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(627, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ค้นหา"
        '
        'txtSprofit
        '
        Me.txtSprofit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSprofit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtSprofit.Location = New System.Drawing.Point(80, 521)
        Me.txtSprofit.Name = "txtSprofit"
        Me.txtSprofit.ReadOnly = True
        Me.txtSprofit.Size = New System.Drawing.Size(151, 26)
        Me.txtSprofit.TabIndex = 9
        Me.txtSprofit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtSprofit, "จำนวนกำไร(ต้นทุน-ราคาขาย)=กำไร")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(9, 524)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "กำไรคงเหลือ"
        '
        'txtScountProduct
        '
        Me.txtScountProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtScountProduct.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtScountProduct.Location = New System.Drawing.Point(80, 495)
        Me.txtScountProduct.Name = "txtScountProduct"
        Me.txtScountProduct.ReadOnly = True
        Me.txtScountProduct.Size = New System.Drawing.Size(151, 26)
        Me.txtScountProduct.TabIndex = 11
        Me.txtScountProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtScountProduct, "จำนวนรายการสินค้าในตารางด้านบน")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(0, 498)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "จำนวนรายการ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(237, 501)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ยอดขายคงเหลือ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(237, 524)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "ต้นทุนคงเหลือ"
        '
        'txtScount_num
        '
        Me.txtScount_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtScount_num.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtScount_num.Location = New System.Drawing.Point(324, 495)
        Me.txtScount_num.Name = "txtScount_num"
        Me.txtScount_num.ReadOnly = True
        Me.txtScount_num.Size = New System.Drawing.Size(139, 26)
        Me.txtScount_num.TabIndex = 16
        Me.txtScount_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtScount_num, "จำนวนสินค้าคงเหลือในตารางด้านบน")
        '
        'txtScost
        '
        Me.txtScost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtScost.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtScost.Location = New System.Drawing.Point(312, 521)
        Me.txtScost.Name = "txtScost"
        Me.txtScost.ReadOnly = True
        Me.txtScost.Size = New System.Drawing.Size(151, 26)
        Me.txtScost.TabIndex = 15
        Me.txtScost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtScost, "จำนวนต้นทุนของสินค้าในตารางด้านบน")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 200
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 40
        '
        'pbPrint
        '
        Me.pbPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbPrint.Image = Global.ServiceTicker.My.Resources.Resources.print_icon
        Me.pbPrint.Location = New System.Drawing.Point(772, 495)
        Me.pbPrint.Name = "pbPrint"
        Me.pbPrint.Size = New System.Drawing.Size(26, 27)
        Me.pbPrint.TabIndex = 17
        Me.pbPrint.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbPrint, "พิมพ์รายการออกทางเครื่องพิมพ์")
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(470, 533)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 18
        Me.lblemployee.Text = "User"
        '
        'Stock1Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 553)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.pbPrint)
        Me.Controls.Add(Me.txtScount_num)
        Me.Controls.Add(Me.txtScost)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtScountProduct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSprofit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSshowallpro)
        Me.Controls.Add(Me.dgStock)
        Me.Controls.Add(Me.txtSsearchPro)
        Me.Controls.Add(Me.cbbSsaleCompany)
        Me.Controls.Add(Me.cbbSproType)
        Me.Controls.Add(Me.cbbSproStatus)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Stock1Frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานยอดรวมสต็อกสินค้า"
        CType(Me.dgStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbbSproStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cbbSproType As System.Windows.Forms.ComboBox
    Friend WithEvents cbbSsaleCompany As System.Windows.Forms.ComboBox
    Friend WithEvents txtSsearchPro As System.Windows.Forms.TextBox
    Friend WithEvents dgStock As System.Windows.Forms.DataGridView
    Friend WithEvents btnSshowallpro As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSprofit As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtScountProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtScount_num As System.Windows.Forms.TextBox
    Friend WithEvents txtScost As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pbPrint As System.Windows.Forms.PictureBox
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count_num1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
