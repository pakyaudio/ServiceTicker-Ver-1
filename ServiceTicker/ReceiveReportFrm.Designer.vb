<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiveReportFrm
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
        Me.dgVR = New System.Windows.Forms.DataGridView()
        Me.buy_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receive_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bill_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbbVRbuyCompany = New System.Windows.Forms.ComboBox()
        Me.ToolTipRR1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtRRRsum = New System.Windows.Forms.TextBox()
        Me.txtRRRrow = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnRPshowAll = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgVR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVRPviewPro
        '
        Me.btnVRPviewPro.AutoSize = True
        Me.btnVRPviewPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVRPviewPro.Location = New System.Drawing.Point(12, 434)
        Me.btnVRPviewPro.Name = "btnVRPviewPro"
        Me.btnVRPviewPro.Size = New System.Drawing.Size(193, 39)
        Me.btnVRPviewPro.TabIndex = 22
        Me.btnVRPviewPro.Text = "ดูรายการสินค้า"
        Me.btnVRPviewPro.UseVisualStyleBackColor = True
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
        Me.dgVR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.buy_id, Me.receive_id, Me.bill_id, Me.sale_company_id, Me.sale_company_name, Me.datetime_save, Me.employee, Me.total, Me.status})
        Me.dgVR.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgVR.Location = New System.Drawing.Point(12, 39)
        Me.dgVR.MultiSelect = False
        Me.dgVR.Name = "dgVR"
        Me.dgVR.ReadOnly = True
        Me.dgVR.RowHeadersVisible = False
        Me.dgVR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVR.Size = New System.Drawing.Size(851, 389)
        Me.dgVR.TabIndex = 19
        '
        'buy_id
        '
        Me.buy_id.HeaderText = "เลขจัดซื้อ"
        Me.buy_id.Name = "buy_id"
        Me.buy_id.ReadOnly = True
        Me.buy_id.Width = 120
        '
        'receive_id
        '
        Me.receive_id.HeaderText = "เลขรับเข้า"
        Me.receive_id.Name = "receive_id"
        Me.receive_id.ReadOnly = True
        '
        'bill_id
        '
        Me.bill_id.HeaderText = "เลขที่เอกสารรับเข้า"
        Me.bill_id.Name = "bill_id"
        Me.bill_id.ReadOnly = True
        Me.bill_id.Width = 150
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
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่ทำรายการจัดซื้อ"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.Width = 150
        '
        'employee
        '
        Me.employee.HeaderText = "พนักงาน"
        Me.employee.Name = "employee"
        Me.employee.ReadOnly = True
        '
        'total
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.total.DefaultCellStyle = DataGridViewCellStyle1
        Me.total.HeaderText = "ราคารวม"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
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
        Me.cbbVRbuyCompany.Location = New System.Drawing.Point(83, 9)
        Me.cbbVRbuyCompany.Name = "cbbVRbuyCompany"
        Me.cbbVRbuyCompany.Size = New System.Drawing.Size(215, 24)
        Me.cbbVRbuyCompany.TabIndex = 17
        Me.ToolTipRR1.SetToolTip(Me.cbbVRbuyCompany, "บริษัทที่จัดซื้อ")
        '
        'ToolTipRR1
        '
        Me.ToolTipRR1.IsBalloon = True
        '
        'txtRRRsum
        '
        Me.txtRRRsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRRRsum.Location = New System.Drawing.Point(633, 434)
        Me.txtRRRsum.Name = "txtRRRsum"
        Me.txtRRRsum.ReadOnly = True
        Me.txtRRRsum.Size = New System.Drawing.Size(194, 26)
        Me.txtRRRsum.TabIndex = 23
        '
        'txtRRRrow
        '
        Me.txtRRRrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRRRrow.Location = New System.Drawing.Point(433, 434)
        Me.txtRRRrow.Name = "txtRRRrow"
        Me.txtRRRrow.ReadOnly = True
        Me.txtRRRrow.Size = New System.Drawing.Size(194, 26)
        Me.txtRRRrow.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "บริษัทที่จัดซื้อ"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(416, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(156, 20)
        Me.DateTimePicker1.TabIndex = 27
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(603, 13)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(156, 20)
        Me.DateTimePicker2.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(578, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "ถึง"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(385, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "จาก"
        '
        'btnRPshowAll
        '
        Me.btnRPshowAll.Location = New System.Drawing.Point(764, 11)
        Me.btnRPshowAll.Name = "btnRPshowAll"
        Me.btnRPshowAll.Size = New System.Drawing.Size(99, 23)
        Me.btnRPshowAll.TabIndex = 31
        Me.btnRPshowAll.Text = "รวบรวมข้อมูล"
        Me.btnRPshowAll.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(211, 434)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(95, 39)
        Me.btnPrint.TabIndex = 32
        Me.btnPrint.Text = "พิมพ์"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(9, 476)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 33
        Me.lblemployee.Text = "User"
        '
        'ReceiveReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 493)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnRPshowAll)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRRRrow)
        Me.Controls.Add(Me.txtRRRsum)
        Me.Controls.Add(Me.btnVRPviewPro)
        Me.Controls.Add(Me.dgVR)
        Me.Controls.Add(Me.cbbVRbuyCompany)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReceiveReportFrm"
        Me.Text = "รายงานการรับสินค้า"
        CType(Me.dgVR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVRPviewPro As System.Windows.Forms.Button
    Friend WithEvents dgVR As System.Windows.Forms.DataGridView
    Friend WithEvents cbbVRbuyCompany As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTipRR1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtRRRsum As System.Windows.Forms.TextBox
    Friend WithEvents txtRRRrow As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btnRPshowAll As System.Windows.Forms.Button
    Friend WithEvents buy_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents receive_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bill_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
