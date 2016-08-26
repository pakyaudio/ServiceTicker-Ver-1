<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReceiveFrm
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
        Me.btnVRPviewPro = New System.Windows.Forms.Button()
        Me.btnVRcancelBillbuy = New System.Windows.Forms.Button()
        Me.dgVR = New System.Windows.Forms.DataGridView()
        Me.buy_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbbVRbuyCompany = New System.Windows.Forms.ComboBox()
        Me.cbbVRbuyStatus = New System.Windows.Forms.ComboBox()
        Me.ToolTipVR = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgVR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVRPviewPro
        '
        Me.btnVRPviewPro.AutoSize = True
        Me.btnVRPviewPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVRPviewPro.Location = New System.Drawing.Point(596, 437)
        Me.btnVRPviewPro.Name = "btnVRPviewPro"
        Me.btnVRPviewPro.Size = New System.Drawing.Size(193, 39)
        Me.btnVRPviewPro.TabIndex = 15
        Me.btnVRPviewPro.Text = "ดูรายการสินค้า"
        Me.ToolTipVR.SetToolTip(Me.btnVRPviewPro, "ดูรายการสินค้าของใบสั่งซื้อ")
        Me.btnVRPviewPro.UseVisualStyleBackColor = True
        '
        'btnVRcancelBillbuy
        '
        Me.btnVRcancelBillbuy.AutoSize = True
        Me.btnVRcancelBillbuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVRcancelBillbuy.Location = New System.Drawing.Point(12, 437)
        Me.btnVRcancelBillbuy.Name = "btnVRcancelBillbuy"
        Me.btnVRcancelBillbuy.Size = New System.Drawing.Size(148, 39)
        Me.btnVRcancelBillbuy.TabIndex = 14
        Me.btnVRcancelBillbuy.Text = "ยกเลิกใบสั่งซื้อนี้"
        Me.ToolTipVR.SetToolTip(Me.btnVRcancelBillbuy, "ยกเลิกใบสั่งซื้อ")
        Me.btnVRcancelBillbuy.UseVisualStyleBackColor = True
        '
        'dgVR
        '
        Me.dgVR.AllowUserToAddRows = False
        Me.dgVR.AllowUserToDeleteRows = False
        Me.dgVR.AllowUserToOrderColumns = True
        Me.dgVR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgVR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.buy_id, Me.sale_company_id, Me.sale_company_name, Me.datetime_save, Me.employee, Me.total, Me.status})
        Me.dgVR.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgVR.Location = New System.Drawing.Point(12, 42)
        Me.dgVR.MultiSelect = False
        Me.dgVR.Name = "dgVR"
        Me.dgVR.ReadOnly = True
        Me.dgVR.RowHeadersVisible = False
        Me.dgVR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVR.Size = New System.Drawing.Size(777, 389)
        Me.dgVR.TabIndex = 11
        '
        'buy_id
        '
        Me.buy_id.HeaderText = "รหัสใบจัดซื้อ"
        Me.buy_id.Name = "buy_id"
        Me.buy_id.ReadOnly = True
        '
        'sale_company_id
        '
        Me.sale_company_id.HeaderText = "รหัสบริษัท"
        Me.sale_company_id.Name = "sale_company_id"
        Me.sale_company_id.ReadOnly = True
        '
        'sale_company_name
        '
        Me.sale_company_name.HeaderText = "ชื่อบริษัท"
        Me.sale_company_name.Name = "sale_company_name"
        Me.sale_company_name.ReadOnly = True
        Me.sale_company_name.Width = 150
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่ทำรายการ"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.Width = 120
        '
        'employee
        '
        Me.employee.HeaderText = "พนักงานทำรายการ"
        Me.employee.Name = "employee"
        Me.employee.ReadOnly = True
        '
        'total
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.total.DefaultCellStyle = DataGridViewCellStyle1
        Me.total.HeaderText = "ราคา"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 70
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'cbbVRbuyCompany
        '
        Me.cbbVRbuyCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbVRbuyCompany.FormattingEnabled = True
        Me.cbbVRbuyCompany.Location = New System.Drawing.Point(392, 12)
        Me.cbbVRbuyCompany.Name = "cbbVRbuyCompany"
        Me.cbbVRbuyCompany.Size = New System.Drawing.Size(397, 24)
        Me.cbbVRbuyCompany.TabIndex = 9
        Me.ToolTipVR.SetToolTip(Me.cbbVRbuyCompany, "เลือกรายการสั่งซื้อตามรายชื่อบริษัท")
        '
        'cbbVRbuyStatus
        '
        Me.cbbVRbuyStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbVRbuyStatus.FormattingEnabled = True
        Me.cbbVRbuyStatus.Location = New System.Drawing.Point(12, 12)
        Me.cbbVRbuyStatus.Name = "cbbVRbuyStatus"
        Me.cbbVRbuyStatus.Size = New System.Drawing.Size(374, 24)
        Me.cbbVRbuyStatus.TabIndex = 8
        Me.ToolTipVR.SetToolTip(Me.cbbVRbuyStatus, "เลือกใบสั่งซื้อตามสถานะ")
        '
        'ToolTipVR
        '
        Me.ToolTipVR.AutoPopDelay = 5000
        Me.ToolTipVR.InitialDelay = 300
        Me.ToolTipVR.IsBalloon = True
        Me.ToolTipVR.ReshowDelay = 300
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(397, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 39)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "พิมพ์รายการสั่งซื้อ"
        Me.ToolTipVR.SetToolTip(Me.Button1, "ดูรายการสินค้าของใบสั่งซื้อ")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 479)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 17
        Me.lblemployee.Text = "User"
        '
        'ViewReceiveFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 495)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnVRPviewPro)
        Me.Controls.Add(Me.btnVRcancelBillbuy)
        Me.Controls.Add(Me.dgVR)
        Me.Controls.Add(Me.cbbVRbuyCompany)
        Me.Controls.Add(Me.cbbVRbuyStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewReceiveFrm"
        Me.Text = "รายการสินค้าสั่งซื้อ"
        CType(Me.dgVR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVRPviewPro As System.Windows.Forms.Button
    Friend WithEvents btnVRcancelBillbuy As System.Windows.Forms.Button
    Friend WithEvents dgVR As System.Windows.Forms.DataGridView
    Friend WithEvents cbbVRbuyCompany As System.Windows.Forms.ComboBox
    Friend WithEvents cbbVRbuyStatus As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTipVR As System.Windows.Forms.ToolTip
    Friend WithEvents buy_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
