<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectReceiveProductFrm
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
        Me.cbbSRPbuyStatus = New System.Windows.Forms.ComboBox()
        Me.cbbSRPbuyCompany = New System.Windows.Forms.ComboBox()
        Me.txtSRPsearch = New System.Windows.Forms.TextBox()
        Me.dgSRP = New System.Windows.Forms.DataGridView()
        Me.ToolTipSRP = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSRPselect = New System.Windows.Forms.Button()
        Me.btnSRPcancelBillbuy = New System.Windows.Forms.Button()
        Me.btnSRPviewPro = New System.Windows.Forms.Button()
        Me.buy_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgSRP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbbSRPbuyStatus
        '
        Me.cbbSRPbuyStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbSRPbuyStatus.FormattingEnabled = True
        Me.cbbSRPbuyStatus.Location = New System.Drawing.Point(12, 12)
        Me.cbbSRPbuyStatus.Name = "cbbSRPbuyStatus"
        Me.cbbSRPbuyStatus.Size = New System.Drawing.Size(299, 24)
        Me.cbbSRPbuyStatus.TabIndex = 0
        Me.ToolTipSRP.SetToolTip(Me.cbbSRPbuyStatus, "ใบสั่งซื้อตามสถานะ")
        '
        'cbbSRPbuyCompany
        '
        Me.cbbSRPbuyCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbSRPbuyCompany.FormattingEnabled = True
        Me.cbbSRPbuyCompany.Location = New System.Drawing.Point(317, 12)
        Me.cbbSRPbuyCompany.Name = "cbbSRPbuyCompany"
        Me.cbbSRPbuyCompany.Size = New System.Drawing.Size(319, 24)
        Me.cbbSRPbuyCompany.TabIndex = 1
        Me.ToolTipSRP.SetToolTip(Me.cbbSRPbuyCompany, "ใบสั่งซื้อตามบริษัท")
        '
        'txtSRPsearch
        '
        Me.txtSRPsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRPsearch.Location = New System.Drawing.Point(642, 12)
        Me.txtSRPsearch.Name = "txtSRPsearch"
        Me.txtSRPsearch.Size = New System.Drawing.Size(134, 24)
        Me.txtSRPsearch.TabIndex = 2
        Me.ToolTipSRP.SetToolTip(Me.txtSRPsearch, "ค้นหา")
        '
        'dgSRP
        '
        Me.dgSRP.AllowUserToAddRows = False
        Me.dgSRP.AllowUserToDeleteRows = False
        Me.dgSRP.AllowUserToOrderColumns = True
        Me.dgSRP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgSRP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSRP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.buy_id, Me.sale_company_id, Me.sale_company_name, Me.datetime_save, Me.employee, Me.total, Me.status})
        Me.dgSRP.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgSRP.Location = New System.Drawing.Point(12, 42)
        Me.dgSRP.MultiSelect = False
        Me.dgSRP.Name = "dgSRP"
        Me.dgSRP.ReadOnly = True
        Me.dgSRP.RowHeadersVisible = False
        Me.dgSRP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSRP.Size = New System.Drawing.Size(779, 389)
        Me.dgSRP.TabIndex = 3
        '
        'ToolTipSRP
        '
        Me.ToolTipSRP.AutoPopDelay = 5000
        Me.ToolTipSRP.InitialDelay = 300
        Me.ToolTipSRP.IsBalloon = True
        Me.ToolTipSRP.ReshowDelay = 300
        '
        'btnSRPselect
        '
        Me.btnSRPselect.AutoSize = True
        Me.btnSRPselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSRPselect.Location = New System.Drawing.Point(565, 437)
        Me.btnSRPselect.Name = "btnSRPselect"
        Me.btnSRPselect.Size = New System.Drawing.Size(225, 39)
        Me.btnSRPselect.TabIndex = 4
        Me.btnSRPselect.Text = "เลือกไปหน้ารับเข้าสินค้า"
        Me.ToolTipSRP.SetToolTip(Me.btnSRPselect, "เลือกใบสั่งซื้อตามที่เลือกไว้")
        Me.btnSRPselect.UseVisualStyleBackColor = True
        '
        'btnSRPcancelBillbuy
        '
        Me.btnSRPcancelBillbuy.AutoSize = True
        Me.btnSRPcancelBillbuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSRPcancelBillbuy.Location = New System.Drawing.Point(12, 437)
        Me.btnSRPcancelBillbuy.Name = "btnSRPcancelBillbuy"
        Me.btnSRPcancelBillbuy.Size = New System.Drawing.Size(148, 39)
        Me.btnSRPcancelBillbuy.TabIndex = 6
        Me.btnSRPcancelBillbuy.Text = "ยกเลิกใบสั่งซื้อนี้"
        Me.ToolTipSRP.SetToolTip(Me.btnSRPcancelBillbuy, "ยกเลิกรายการสินค้าตามใบสั่งซื้อที่เลือก")
        Me.btnSRPcancelBillbuy.UseVisualStyleBackColor = True
        '
        'btnSRPviewPro
        '
        Me.btnSRPviewPro.AutoSize = True
        Me.btnSRPviewPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSRPviewPro.Location = New System.Drawing.Point(166, 437)
        Me.btnSRPviewPro.Name = "btnSRPviewPro"
        Me.btnSRPviewPro.Size = New System.Drawing.Size(193, 39)
        Me.btnSRPviewPro.TabIndex = 7
        Me.btnSRPviewPro.Text = "ดูรายการสินค้า"
        Me.ToolTipSRP.SetToolTip(Me.btnSRPviewPro, "ยกเลิกรายการสินค้าตามใบสั่งซื้อที่เลือก")
        Me.btnSRPviewPro.UseVisualStyleBackColor = True
        '
        'buy_id
        '
        Me.buy_id.HeaderText = "รหัสใบจัดซื้อ"
        Me.buy_id.Name = "buy_id"
        Me.buy_id.ReadOnly = True
        Me.buy_id.Width = 130
        '
        'sale_company_id
        '
        Me.sale_company_id.HeaderText = "รหัสบริษัท"
        Me.sale_company_id.Name = "sale_company_id"
        Me.sale_company_id.ReadOnly = True
        Me.sale_company_id.Width = 80
        '
        'sale_company_name
        '
        Me.sale_company_name.HeaderText = "ชื่อบริษัท"
        Me.sale_company_name.Name = "sale_company_name"
        Me.sale_company_name.ReadOnly = True
        Me.sale_company_name.Width = 200
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่ทำรายการ"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        '
        'employee
        '
        Me.employee.HeaderText = "พนักงาน"
        Me.employee.Name = "employee"
        Me.employee.ReadOnly = True
        Me.employee.Width = 80
        '
        'total
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.total.DefaultCellStyle = DataGridViewCellStyle1
        Me.total.HeaderText = "รวมราคา"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 80
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'SelectReceiveProductFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 488)
        Me.Controls.Add(Me.btnSRPviewPro)
        Me.Controls.Add(Me.btnSRPcancelBillbuy)
        Me.Controls.Add(Me.btnSRPselect)
        Me.Controls.Add(Me.dgSRP)
        Me.Controls.Add(Me.txtSRPsearch)
        Me.Controls.Add(Me.cbbSRPbuyCompany)
        Me.Controls.Add(Me.cbbSRPbuyStatus)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectReceiveProductFrm"
        Me.Text = "รายการใบสั่งซื่้อสินค้า"
        CType(Me.dgSRP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbbSRPbuyStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cbbSRPbuyCompany As System.Windows.Forms.ComboBox
    Friend WithEvents txtSRPsearch As System.Windows.Forms.TextBox
    Friend WithEvents dgSRP As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTipSRP As System.Windows.Forms.ToolTip
    Friend WithEvents btnSRPselect As System.Windows.Forms.Button
    Friend WithEvents btnSRPcancelBillbuy As System.Windows.Forms.Button
    Friend WithEvents btnSRPviewPro As System.Windows.Forms.Button
    Friend WithEvents buy_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
