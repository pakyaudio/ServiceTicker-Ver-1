<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReceiveReportFrm
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
        Me.txtVSRPemployee = New System.Windows.Forms.TextBox()
        Me.txtVSRPdatetim_save = New System.Windows.Forms.TextBox()
        Me.txtVSRPsale_company_name = New System.Windows.Forms.TextBox()
        Me.txtVSRPsale_company_id = New System.Windows.Forms.TextBox()
        Me.txtVSRPbuy_id = New System.Windows.Forms.TextBox()
        Me.dgVSRP = New System.Windows.Forms.DataGridView()
        Me.ToolTipVRR = New System.Windows.Forms.ToolTip(Me.components)
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgVSRP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtVSRPemployee
        '
        Me.txtVSRPemployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPemployee.Location = New System.Drawing.Point(577, 9)
        Me.txtVSRPemployee.Name = "txtVSRPemployee"
        Me.txtVSRPemployee.Size = New System.Drawing.Size(90, 24)
        Me.txtVSRPemployee.TabIndex = 11
        Me.ToolTipVRR.SetToolTip(Me.txtVSRPemployee, "พนักงานที่ทำรายการจัดซื้อ")
        '
        'txtVSRPdatetim_save
        '
        Me.txtVSRPdatetim_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPdatetim_save.Location = New System.Drawing.Point(461, 9)
        Me.txtVSRPdatetim_save.Name = "txtVSRPdatetim_save"
        Me.txtVSRPdatetim_save.Size = New System.Drawing.Size(118, 24)
        Me.txtVSRPdatetim_save.TabIndex = 10
        Me.ToolTipVRR.SetToolTip(Me.txtVSRPdatetim_save, "วันที่จัดซื้อ")
        '
        'txtVSRPsale_company_name
        '
        Me.txtVSRPsale_company_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPsale_company_name.Location = New System.Drawing.Point(235, 9)
        Me.txtVSRPsale_company_name.Name = "txtVSRPsale_company_name"
        Me.txtVSRPsale_company_name.Size = New System.Drawing.Size(227, 24)
        Me.txtVSRPsale_company_name.TabIndex = 9
        Me.ToolTipVRR.SetToolTip(Me.txtVSRPsale_company_name, "ชื่อบริษัทที่สั่งซื้อ")
        '
        'txtVSRPsale_company_id
        '
        Me.txtVSRPsale_company_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPsale_company_id.Location = New System.Drawing.Point(167, 9)
        Me.txtVSRPsale_company_id.Name = "txtVSRPsale_company_id"
        Me.txtVSRPsale_company_id.Size = New System.Drawing.Size(69, 24)
        Me.txtVSRPsale_company_id.TabIndex = 8
        Me.ToolTipVRR.SetToolTip(Me.txtVSRPsale_company_id, "รหัสบริษัทที่สั่งซื้อ")
        '
        'txtVSRPbuy_id
        '
        Me.txtVSRPbuy_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPbuy_id.Location = New System.Drawing.Point(12, 9)
        Me.txtVSRPbuy_id.Name = "txtVSRPbuy_id"
        Me.txtVSRPbuy_id.Size = New System.Drawing.Size(157, 24)
        Me.txtVSRPbuy_id.TabIndex = 7
        Me.ToolTipVRR.SetToolTip(Me.txtVSRPbuy_id, "เลขที่ใบสั่งซื้อ")
        '
        'dgVSRP
        '
        Me.dgVSRP.AllowUserToAddRows = False
        Me.dgVSRP.AllowUserToDeleteRows = False
        Me.dgVSRP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgVSRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVSRP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.code_pro, Me.bar_code, Me.name_pro, Me.price_cost, Me.count_num, Me.total_price})
        Me.dgVSRP.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgVSRP.Location = New System.Drawing.Point(12, 35)
        Me.dgVSRP.Name = "dgVSRP"
        Me.dgVSRP.RowHeadersVisible = False
        Me.dgVSRP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVSRP.Size = New System.Drawing.Size(655, 393)
        Me.dgVSRP.TabIndex = 6
        Me.ToolTipVRR.SetToolTip(Me.dgVSRP, "รายการสินค้า")
        '
        'ToolTipVRR
        '
        Me.ToolTipVRR.IsBalloon = True
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.Width = 30
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        '
        'bar_code
        '
        Me.bar_code.HeaderText = "บาร์โค๊ต"
        Me.bar_code.Name = "bar_code"
        Me.bar_code.Width = 130
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.Width = 200
        '
        'price_cost
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.price_cost.DefaultCellStyle = DataGridViewCellStyle1
        Me.price_cost.HeaderText = "ราคาทุน"
        Me.price_cost.Name = "price_cost"
        Me.price_cost.Width = 70
        '
        'count_num
        '
        DataGridViewCellStyle2.NullValue = "0"
        Me.count_num.DefaultCellStyle = DataGridViewCellStyle2
        Me.count_num.HeaderText = "จำนวน"
        Me.count_num.Name = "count_num"
        Me.count_num.Width = 50
        '
        'total_price
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.total_price.DefaultCellStyle = DataGridViewCellStyle3
        Me.total_price.HeaderText = "รวมราคา"
        Me.total_price.Name = "total_price"
        Me.total_price.Width = 80
        '
        'ViewReceiveReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 440)
        Me.Controls.Add(Me.txtVSRPemployee)
        Me.Controls.Add(Me.txtVSRPdatetim_save)
        Me.Controls.Add(Me.txtVSRPsale_company_name)
        Me.Controls.Add(Me.txtVSRPsale_company_id)
        Me.Controls.Add(Me.txtVSRPbuy_id)
        Me.Controls.Add(Me.dgVSRP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewReceiveReportFrm"
        Me.Text = "รายการสินค้าตามใบสั่งซื้อ"
        CType(Me.dgVSRP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVSRPemployee As System.Windows.Forms.TextBox
    Friend WithEvents txtVSRPdatetim_save As System.Windows.Forms.TextBox
    Friend WithEvents txtVSRPsale_company_name As System.Windows.Forms.TextBox
    Friend WithEvents txtVSRPsale_company_id As System.Windows.Forms.TextBox
    Friend WithEvents txtVSRPbuy_id As System.Windows.Forms.TextBox
    Friend WithEvents dgVSRP As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTipVRR As System.Windows.Forms.ToolTip
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_price As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
