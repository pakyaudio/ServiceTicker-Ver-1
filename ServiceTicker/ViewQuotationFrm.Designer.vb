<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewQuotationFrm
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ToolTipVQ = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtVQsearch = New System.Windows.Forms.TextBox()
        Me.txtVQshowDetail = New System.Windows.Forms.TextBox()
        Me.btnVQall = New System.Windows.Forms.Button()
        Me.btnVQdel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVQsearch = New System.Windows.Forms.Button()
        Me.dgVQ = New System.Windows.Forms.DataGridView()
        Me.quotation_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.multiply = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVQprint = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbVQwithOutPic = New System.Windows.Forms.RadioButton()
        Me.rbVQwithPic = New System.Windows.Forms.RadioButton()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgVQ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(43, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.Value = New Date(2015, 2, 2, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(43, 35)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 1
        Me.DateTimePicker2.Value = New Date(2015, 2, 2, 0, 0, 0, 0)
        '
        'ToolTipVQ
        '
        Me.ToolTipVQ.IsBalloon = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(268, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 49)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "แสดงผล"
        Me.ToolTipVQ.SetToolTip(Me.Button1, "แสดงผลตามวันที่")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtVQsearch
        '
        Me.txtVQsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVQsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVQsearch.Location = New System.Drawing.Point(763, 17)
        Me.txtVQsearch.Name = "txtVQsearch"
        Me.txtVQsearch.Size = New System.Drawing.Size(164, 29)
        Me.txtVQsearch.TabIndex = 5
        Me.ToolTipVQ.SetToolTip(Me.txtVQsearch, "ค้นหาใบเสนอราคาตามชื่อสินค้า หมายเลขใบเสนอราคา รหัสลูกค้า")
        '
        'txtVQshowDetail
        '
        Me.txtVQshowDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVQshowDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVQshowDetail.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtVQshowDetail.Location = New System.Drawing.Point(12, 61)
        Me.txtVQshowDetail.Name = "txtVQshowDetail"
        Me.txtVQshowDetail.ReadOnly = True
        Me.txtVQshowDetail.Size = New System.Drawing.Size(958, 29)
        Me.txtVQshowDetail.TabIndex = 8
        Me.txtVQshowDetail.Text = "คลิ๊กที่ตารางเพื่อดูชื่อลูกค้า ดับเบิ๊ลคลิ๊กเพื่อดูข้อมูลใบสินค้าทั้งหมดในใบเสนอร" & _
    "าคาหมายเลขนั้น"
        Me.ToolTipVQ.SetToolTip(Me.txtVQshowDetail, "รายละเอียดลูกค้า")
        '
        'btnVQall
        '
        Me.btnVQall.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVQall.Location = New System.Drawing.Point(430, 6)
        Me.btnVQall.Name = "btnVQall"
        Me.btnVQall.Size = New System.Drawing.Size(156, 49)
        Me.btnVQall.TabIndex = 10
        Me.btnVQall.Text = "แสดงทั้งหมด"
        Me.ToolTipVQ.SetToolTip(Me.btnVQall, "แสดงใบเสนอราคาทั้งหมดที่มี")
        Me.btnVQall.UseVisualStyleBackColor = True
        '
        'btnVQdel
        '
        Me.btnVQdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVQdel.Location = New System.Drawing.Point(592, 6)
        Me.btnVQdel.Name = "btnVQdel"
        Me.btnVQdel.Size = New System.Drawing.Size(156, 49)
        Me.btnVQdel.TabIndex = 11
        Me.btnVQdel.Text = "ลบ"
        Me.ToolTipVQ.SetToolTip(Me.btnVQdel, "ลบใบเสนอราคา")
        Me.btnVQdel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "จาก"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ถึง"
        '
        'btnVQsearch
        '
        Me.btnVQsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVQsearch.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnVQsearch.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.search_icon
        Me.btnVQsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVQsearch.Location = New System.Drawing.Point(933, 17)
        Me.btnVQsearch.Name = "btnVQsearch"
        Me.btnVQsearch.Size = New System.Drawing.Size(37, 29)
        Me.btnVQsearch.TabIndex = 6
        Me.btnVQsearch.UseVisualStyleBackColor = False
        '
        'dgVQ
        '
        Me.dgVQ.AllowUserToAddRows = False
        Me.dgVQ.AllowUserToDeleteRows = False
        Me.dgVQ.AllowUserToOrderColumns = True
        Me.dgVQ.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgVQ.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgVQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVQ.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.quotation_id, Me.customer_id, Me.code_pro, Me.name_pro, Me.unit, Me.total_pro, Me.price_buy, Me.multiply, Me.datetime_save})
        Me.dgVQ.Location = New System.Drawing.Point(12, 96)
        Me.dgVQ.MultiSelect = False
        Me.dgVQ.Name = "dgVQ"
        Me.dgVQ.ReadOnly = True
        Me.dgVQ.RowHeadersVisible = False
        Me.dgVQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVQ.Size = New System.Drawing.Size(958, 379)
        Me.dgVQ.TabIndex = 7
        '
        'quotation_id
        '
        Me.quotation_id.DataPropertyName = "quotation_id"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.quotation_id.DefaultCellStyle = DataGridViewCellStyle1
        Me.quotation_id.Frozen = True
        Me.quotation_id.HeaderText = "เลขที่"
        Me.quotation_id.Name = "quotation_id"
        Me.quotation_id.ReadOnly = True
        Me.quotation_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.quotation_id.ToolTipText = "เลขที่ใบเสนอราคา"
        Me.quotation_id.Width = 120
        '
        'customer_id
        '
        Me.customer_id.DataPropertyName = "customer_id"
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_id.ToolTipText = "รหัสลูกค้า"
        '
        'code_pro
        '
        Me.code_pro.DataPropertyName = "code_pro"
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
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.ToolTipText = "ชื่อสินค้า"
        Me.name_pro.Width = 200
        '
        'unit
        '
        Me.unit.DataPropertyName = "unit"
        Me.unit.HeaderText = "หน่วยนับ"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.ToolTipText = "หน่วยนับ"
        Me.unit.Width = 80
        '
        'total_pro
        '
        Me.total_pro.DataPropertyName = "total_pro"
        DataGridViewCellStyle2.NullValue = "0"
        Me.total_pro.DefaultCellStyle = DataGridViewCellStyle2
        Me.total_pro.HeaderText = "จำนวน"
        Me.total_pro.Name = "total_pro"
        Me.total_pro.ReadOnly = True
        Me.total_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_pro.ToolTipText = "จำนวนสินค้า"
        Me.total_pro.Width = 80
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
        Me.price_buy.Width = 80
        '
        'multiply
        '
        Me.multiply.DataPropertyName = "multiply"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.multiply.DefaultCellStyle = DataGridViewCellStyle4
        Me.multiply.HeaderText = "รวมราคา"
        Me.multiply.Name = "multiply"
        Me.multiply.ReadOnly = True
        Me.multiply.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.multiply.Width = 80
        '
        'datetime_save
        '
        Me.datetime_save.DataPropertyName = "datetime_save"
        Me.datetime_save.HeaderText = "วันที่"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.ToolTipText = "วันที่บันทึก"
        '
        'btnVQprint
        '
        Me.btnVQprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVQprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVQprint.Location = New System.Drawing.Point(12, 481)
        Me.btnVQprint.Name = "btnVQprint"
        Me.btnVQprint.Size = New System.Drawing.Size(156, 49)
        Me.btnVQprint.TabIndex = 9
        Me.btnVQprint.Text = "พิมพ์"
        Me.btnVQprint.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbVQwithOutPic)
        Me.GroupBox1.Controls.Add(Me.rbVQwithPic)
        Me.GroupBox1.Location = New System.Drawing.Point(174, 481)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 49)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกรูปแบบใบเสนอราคา"
        '
        'rbVQwithOutPic
        '
        Me.rbVQwithOutPic.AutoSize = True
        Me.rbVQwithOutPic.Checked = True
        Me.rbVQwithOutPic.Location = New System.Drawing.Point(149, 20)
        Me.rbVQwithOutPic.Name = "rbVQwithOutPic"
        Me.rbVQwithOutPic.Size = New System.Drawing.Size(80, 17)
        Me.rbVQwithOutPic.TabIndex = 1
        Me.rbVQwithOutPic.TabStop = True
        Me.rbVQwithOutPic.Text = "แบบไม่มีรูป"
        Me.rbVQwithOutPic.UseVisualStyleBackColor = True
        '
        'rbVQwithPic
        '
        Me.rbVQwithPic.AutoSize = True
        Me.rbVQwithPic.Location = New System.Drawing.Point(6, 20)
        Me.rbVQwithPic.Name = "rbVQwithPic"
        Me.rbVQwithPic.Size = New System.Drawing.Size(105, 17)
        Me.rbVQwithPic.TabIndex = 0
        Me.rbVQwithPic.Text = "แบบมีรูปประกอบ"
        Me.rbVQwithPic.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(438, 517)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 13
        Me.lblemployee.Text = "User"
        '
        'ViewQuotationFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 539)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVQdel)
        Me.Controls.Add(Me.btnVQall)
        Me.Controls.Add(Me.btnVQprint)
        Me.Controls.Add(Me.txtVQshowDetail)
        Me.Controls.Add(Me.dgVQ)
        Me.Controls.Add(Me.btnVQsearch)
        Me.Controls.Add(Me.txtVQsearch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "ViewQuotationFrm"
        Me.Text = "ค้นหาใบเสนอราคา"
        CType(Me.dgVQ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolTipVQ As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtVQsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnVQsearch As System.Windows.Forms.Button
    Friend WithEvents dgVQ As System.Windows.Forms.DataGridView
    Friend WithEvents txtVQshowDetail As System.Windows.Forms.TextBox
    Friend WithEvents btnVQprint As System.Windows.Forms.Button
    Friend WithEvents btnVQall As System.Windows.Forms.Button
    Friend WithEvents btnVQdel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbVQwithOutPic As System.Windows.Forms.RadioButton
    Friend WithEvents rbVQwithPic As System.Windows.Forms.RadioButton
    Friend WithEvents quotation_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents multiply As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
