<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckStockBCReportFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCSRsearch = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dgCSR = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pro_bc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disappear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.over = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_last = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgCSR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCSRsearch
        '
        Me.btnCSRsearch.Location = New System.Drawing.Point(218, 9)
        Me.btnCSRsearch.Name = "btnCSRsearch"
        Me.btnCSRsearch.Size = New System.Drawing.Size(166, 31)
        Me.btnCSRsearch.TabIndex = 1
        Me.btnCSRsearch.Text = "ค้นหา"
        Me.btnCSRsearch.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.CustomFormat = "MMMM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        Me.DateTimePicker1.Value = New Date(2015, 1, 1, 0, 0, 0, 0)
        '
        'dgCSR
        '
        Me.dgCSR.AllowUserToAddRows = False
        Me.dgCSR.AllowUserToDeleteRows = False
        Me.dgCSR.AllowUserToOrderColumns = True
        Me.dgCSR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCSR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCSR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.datetime_save, Me.total_pro_bc, Me.count_num, Me.disappear, Me.over, Me.datetime_last, Me.employee})
        Me.dgCSR.Location = New System.Drawing.Point(12, 46)
        Me.dgCSR.Name = "dgCSR"
        Me.dgCSR.ReadOnly = True
        Me.dgCSR.RowHeadersVisible = False
        Me.dgCSR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCSR.Size = New System.Drawing.Size(760, 327)
        Me.dgCSR.TabIndex = 3
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.no.DefaultCellStyle = DataGridViewCellStyle1
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.ToolTipText = "ลำดับ"
        Me.no.Width = 50
        '
        'datetime_save
        '
        Me.datetime_save.DataPropertyName = "datetime_save"
        Me.datetime_save.HeaderText = "วันที่เตรียมสต็อก"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.ToolTipText = "วันที่เตรียมสต็อก"
        '
        'total_pro_bc
        '
        Me.total_pro_bc.DataPropertyName = "total_pro_bc"
        Me.total_pro_bc.HeaderText = "จำนวนบาร์โค๊ตทั้งหมด"
        Me.total_pro_bc.Name = "total_pro_bc"
        Me.total_pro_bc.ReadOnly = True
        Me.total_pro_bc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_pro_bc.ToolTipText = "จำนวนบาร์โค๊ตทั้งหมด"
        Me.total_pro_bc.Width = 120
        '
        'count_num
        '
        Me.count_num.DataPropertyName = "count_num"
        Me.count_num.HeaderText = "นับได้"
        Me.count_num.Name = "count_num"
        Me.count_num.ReadOnly = True
        Me.count_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.count_num.ToolTipText = "นับได้"
        '
        'disappear
        '
        Me.disappear.DataPropertyName = "disappear"
        Me.disappear.HeaderText = "ขาด"
        Me.disappear.Name = "disappear"
        Me.disappear.ReadOnly = True
        Me.disappear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.disappear.ToolTipText = "ขาด"
        '
        'over
        '
        Me.over.DataPropertyName = "over"
        Me.over.HeaderText = "เกิน"
        Me.over.Name = "over"
        Me.over.ReadOnly = True
        Me.over.ToolTipText = "เกิน"
        '
        'datetime_last
        '
        Me.datetime_last.DataPropertyName = "datetime_last"
        Me.datetime_last.HeaderText = "วันที่ตรวจสอบล่าสุด"
        Me.datetime_last.Name = "datetime_last"
        Me.datetime_last.ReadOnly = True
        Me.datetime_last.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_last.ToolTipText = "วันที่ตรวจสอบล่าสุด"
        '
        'employee
        '
        Me.employee.DataPropertyName = "employee"
        Me.employee.HeaderText = "พนักงานเคลียร์ข้อมูล"
        Me.employee.Name = "employee"
        Me.employee.ReadOnly = True
        Me.employee.Width = 130
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 380)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 4
        Me.lblemployee.Text = "User"
        '
        'CheckStockBCReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 400)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.dgCSR)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnCSRsearch)
        Me.Name = "CheckStockBCReportFrm"
        Me.Text = "รายงานการตรวจสอบสต็อกบาร์โค๊ต"
        CType(Me.dgCSR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCSRsearch As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgCSR As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_pro_bc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents disappear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents over As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_last As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
