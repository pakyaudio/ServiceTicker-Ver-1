<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewOldTaxInvoiceFrm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVOTIsearch = New System.Windows.Forms.Button()
        Me.dgVOTI = New System.Windows.Forms.DataGridView()
        Me.taxinvoice_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taxvoice_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnVOTIdel = New System.Windows.Forms.Button()
        Me.ToolTipVOTI = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgVOTI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(43, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(43, 38)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "จาก"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ถึง"
        '
        'btnVOTIsearch
        '
        Me.btnVOTIsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVOTIsearch.Location = New System.Drawing.Point(270, 14)
        Me.btnVOTIsearch.Name = "btnVOTIsearch"
        Me.btnVOTIsearch.Size = New System.Drawing.Size(144, 39)
        Me.btnVOTIsearch.TabIndex = 4
        Me.btnVOTIsearch.Text = "ค้นหา"
        Me.btnVOTIsearch.UseVisualStyleBackColor = True
        '
        'dgVOTI
        '
        Me.dgVOTI.AllowUserToAddRows = False
        Me.dgVOTI.AllowUserToDeleteRows = False
        Me.dgVOTI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVOTI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.taxinvoice_id, Me.taxvoice_type, Me.customer_id, Me.customer_name, Me.code_pro, Me.name_pro, Me.total, Me.unit, Me.price_buy, Me.datetime_save})
        Me.dgVOTI.Location = New System.Drawing.Point(12, 73)
        Me.dgVOTI.Name = "dgVOTI"
        Me.dgVOTI.ReadOnly = True
        Me.dgVOTI.RowHeadersVisible = False
        Me.dgVOTI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVOTI.Size = New System.Drawing.Size(969, 433)
        Me.dgVOTI.TabIndex = 5
        '
        'taxinvoice_id
        '
        Me.taxinvoice_id.DataPropertyName = "taxinvoice_id"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.taxinvoice_id.DefaultCellStyle = DataGridViewCellStyle2
        Me.taxinvoice_id.Frozen = True
        Me.taxinvoice_id.HeaderText = "เลขที่"
        Me.taxinvoice_id.Name = "taxinvoice_id"
        Me.taxinvoice_id.ReadOnly = True
        Me.taxinvoice_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.taxinvoice_id.ToolTipText = "เลขที่ใบเสร็จ"
        Me.taxinvoice_id.Width = 130
        '
        'taxvoice_type
        '
        Me.taxvoice_type.DataPropertyName = "taxvoice_type"
        Me.taxvoice_type.HeaderText = "ชนิดใบเสร็จ"
        Me.taxvoice_type.Name = "taxvoice_type"
        Me.taxvoice_type.ReadOnly = True
        Me.taxvoice_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'customer_id
        '
        Me.customer_id.DataPropertyName = "customer_id"
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'customer_name
        '
        Me.customer_name.DataPropertyName = "customer_name"
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'code_pro
        '
        Me.code_pro.DataPropertyName = "code_pro"
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 150
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "จำนวน"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total.Width = 50
        '
        'unit
        '
        Me.unit.DataPropertyName = "unit"
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.Width = 50
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        Me.price_buy.HeaderText = "ราคา"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.Width = 50
        '
        'datetime_save
        '
        Me.datetime_save.DataPropertyName = "datetime_save"
        Me.datetime_save.HeaderText = "วันที่"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(837, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 39)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "เลือก"
        Me.ToolTipVOTI.SetToolTip(Me.Button1, "เลือกข้อมูลไปหน้าพิมพ์ข้อมูล")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnVOTIdel
        '
        Me.btnVOTIdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVOTIdel.Location = New System.Drawing.Point(420, 14)
        Me.btnVOTIdel.Name = "btnVOTIdel"
        Me.btnVOTIdel.Size = New System.Drawing.Size(144, 39)
        Me.btnVOTIdel.TabIndex = 7
        Me.btnVOTIdel.Text = "ลบ"
        Me.ToolTipVOTI.SetToolTip(Me.btnVOTIdel, "ลบข้อมูลใบเสร็จ/ใบกำกับภาษี หมายเลขที่เลือกทั้งหมด")
        Me.btnVOTIdel.UseVisualStyleBackColor = True
        '
        'ToolTipVOTI
        '
        Me.ToolTipVOTI.IsBalloon = True
        '
        'ViewOldTaxInvoiceFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 516)
        Me.Controls.Add(Me.btnVOTIdel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgVOTI)
        Me.Controls.Add(Me.btnVOTIsearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewOldTaxInvoiceFrm"
        Me.Text = "ค้นหาใบเสร็จ/ใบกำกับภาษี"
        CType(Me.dgVOTI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnVOTIsearch As System.Windows.Forms.Button
    Friend WithEvents dgVOTI As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents taxinvoice_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents taxvoice_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTipVOTI As System.Windows.Forms.ToolTip
    Friend WithEvents btnVOTIdel As System.Windows.Forms.Button
End Class
