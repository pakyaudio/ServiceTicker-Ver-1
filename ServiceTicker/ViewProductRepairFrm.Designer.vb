﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewProductRepairFrm
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
        Me.dgVPR = New System.Windows.Forms.DataGridView()
        Me.txtVPRfix_id = New System.Windows.Forms.TextBox()
        Me.txtVPRcustomer_id = New System.Windows.Forms.TextBox()
        Me.txtVPRsale_id = New System.Windows.Forms.TextBox()
        Me.txtVPRdatetime_save = New System.Windows.Forms.TextBox()
        Me.ToolTipVPR = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtVPRcustomer_name = New System.Windows.Forms.TextBox()
        Me.txtVPRtotal_all = New System.Windows.Forms.TextBox()
        Me.txtVPRemployee = New System.Windows.Forms.TextBox()
        Me.txtVPRtotalProduct = New System.Windows.Forms.TextBox()
        Me.txtVPRlistCount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgVPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgVPR
        '
        Me.dgVPR.AllowUserToAddRows = False
        Me.dgVPR.AllowUserToDeleteRows = False
        Me.dgVPR.AllowUserToOrderColumns = True
        Me.dgVPR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgVPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVPR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_pro, Me.bar_code, Me.name_pro, Me.total_pro, Me.price_buy, Me.unit, Me.total_all})
        Me.dgVPR.Location = New System.Drawing.Point(12, 61)
        Me.dgVPR.Name = "dgVPR"
        Me.dgVPR.ReadOnly = True
        Me.dgVPR.RowHeadersVisible = False
        Me.dgVPR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVPR.Size = New System.Drawing.Size(588, 402)
        Me.dgVPR.TabIndex = 0
        Me.ToolTipVPR.SetToolTip(Me.dgVPR, "รายการสินค้า/อะไหล่ ที่เบิก")
        '
        'txtVPRfix_id
        '
        Me.txtVPRfix_id.Location = New System.Drawing.Point(12, 12)
        Me.txtVPRfix_id.Name = "txtVPRfix_id"
        Me.txtVPRfix_id.ReadOnly = True
        Me.txtVPRfix_id.Size = New System.Drawing.Size(158, 20)
        Me.txtVPRfix_id.TabIndex = 1
        Me.ToolTipVPR.SetToolTip(Me.txtVPRfix_id, "รหัสใบส่งซ่อม")
        '
        'txtVPRcustomer_id
        '
        Me.txtVPRcustomer_id.Location = New System.Drawing.Point(176, 12)
        Me.txtVPRcustomer_id.Name = "txtVPRcustomer_id"
        Me.txtVPRcustomer_id.ReadOnly = True
        Me.txtVPRcustomer_id.Size = New System.Drawing.Size(158, 20)
        Me.txtVPRcustomer_id.TabIndex = 2
        Me.ToolTipVPR.SetToolTip(Me.txtVPRcustomer_id, "รหัสลูกค้า")
        '
        'txtVPRsale_id
        '
        Me.txtVPRsale_id.Location = New System.Drawing.Point(340, 12)
        Me.txtVPRsale_id.Name = "txtVPRsale_id"
        Me.txtVPRsale_id.ReadOnly = True
        Me.txtVPRsale_id.Size = New System.Drawing.Size(158, 20)
        Me.txtVPRsale_id.TabIndex = 3
        Me.ToolTipVPR.SetToolTip(Me.txtVPRsale_id, "รหัสใบเบิกสินค้า/อะไหล่")
        '
        'txtVPRdatetime_save
        '
        Me.txtVPRdatetime_save.Location = New System.Drawing.Point(504, 12)
        Me.txtVPRdatetime_save.Name = "txtVPRdatetime_save"
        Me.txtVPRdatetime_save.ReadOnly = True
        Me.txtVPRdatetime_save.Size = New System.Drawing.Size(96, 20)
        Me.txtVPRdatetime_save.TabIndex = 4
        Me.ToolTipVPR.SetToolTip(Me.txtVPRdatetime_save, "วันที่ทำรายการเบิก")
        '
        'ToolTipVPR
        '
        Me.ToolTipVPR.AutoPopDelay = 5000
        Me.ToolTipVPR.InitialDelay = 300
        Me.ToolTipVPR.IsBalloon = True
        Me.ToolTipVPR.ReshowDelay = 300
        '
        'txtVPRcustomer_name
        '
        Me.txtVPRcustomer_name.Location = New System.Drawing.Point(57, 35)
        Me.txtVPRcustomer_name.Name = "txtVPRcustomer_name"
        Me.txtVPRcustomer_name.ReadOnly = True
        Me.txtVPRcustomer_name.Size = New System.Drawing.Size(158, 20)
        Me.txtVPRcustomer_name.TabIndex = 9
        Me.ToolTipVPR.SetToolTip(Me.txtVPRcustomer_name, "ชื่อลูกค้า")
        '
        'txtVPRtotal_all
        '
        Me.txtVPRtotal_all.Location = New System.Drawing.Point(295, 35)
        Me.txtVPRtotal_all.Name = "txtVPRtotal_all"
        Me.txtVPRtotal_all.ReadOnly = True
        Me.txtVPRtotal_all.Size = New System.Drawing.Size(147, 20)
        Me.txtVPRtotal_all.TabIndex = 11
        Me.ToolTipVPR.SetToolTip(Me.txtVPRtotal_all, "ยอดรวมราคาสินค้า/อะไหล่")
        '
        'txtVPRemployee
        '
        Me.txtVPRemployee.Location = New System.Drawing.Point(504, 35)
        Me.txtVPRemployee.Name = "txtVPRemployee"
        Me.txtVPRemployee.ReadOnly = True
        Me.txtVPRemployee.Size = New System.Drawing.Size(96, 20)
        Me.txtVPRemployee.TabIndex = 14
        Me.ToolTipVPR.SetToolTip(Me.txtVPRemployee, "พนักงานผู้ทำรายการเบิก")
        '
        'txtVPRtotalProduct
        '
        Me.txtVPRtotalProduct.Location = New System.Drawing.Point(442, 469)
        Me.txtVPRtotalProduct.Name = "txtVPRtotalProduct"
        Me.txtVPRtotalProduct.ReadOnly = True
        Me.txtVPRtotalProduct.Size = New System.Drawing.Size(158, 20)
        Me.txtVPRtotalProduct.TabIndex = 15
        Me.txtVPRtotalProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipVPR.SetToolTip(Me.txtVPRtotalProduct, "จำนวนสินค้าในรายการ")
        '
        'txtVPRlistCount
        '
        Me.txtVPRlistCount.Location = New System.Drawing.Point(278, 469)
        Me.txtVPRlistCount.Name = "txtVPRlistCount"
        Me.txtVPRlistCount.ReadOnly = True
        Me.txtVPRlistCount.Size = New System.Drawing.Size(158, 20)
        Me.txtVPRlistCount.TabIndex = 16
        Me.txtVPRlistCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipVPR.SetToolTip(Me.txtVPRlistCount, "จำนวนรายการทั้งหมด")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ชื่อ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ยอดรวมราคา"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(450, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "พนักงาน"
        '
        'code_pro
        '
        Me.code_pro.DataPropertyName = "code_pro"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.code_pro.DefaultCellStyle = DataGridViewCellStyle1
        Me.code_pro.Frozen = True
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'bar_code
        '
        Me.bar_code.DataPropertyName = "bar_code"
        Me.bar_code.HeaderText = "บาร์โค๊ต"
        Me.bar_code.Name = "bar_code"
        Me.bar_code.ReadOnly = True
        Me.bar_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 250
        '
        'total_pro
        '
        Me.total_pro.DataPropertyName = "total_pro"
        Me.total_pro.HeaderText = "จำนวน"
        Me.total_pro.Name = "total_pro"
        Me.total_pro.ReadOnly = True
        Me.total_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        Me.price_buy.HeaderText = "ราคา"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'total_all
        '
        Me.total_all.DataPropertyName = "total_all"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.total_all.DefaultCellStyle = DataGridViewCellStyle2
        Me.total_all.HeaderText = "รวมราคา"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ViewProductRepairFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 501)
        Me.Controls.Add(Me.txtVPRlistCount)
        Me.Controls.Add(Me.txtVPRtotalProduct)
        Me.Controls.Add(Me.txtVPRemployee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVPRtotal_all)
        Me.Controls.Add(Me.txtVPRcustomer_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVPRdatetime_save)
        Me.Controls.Add(Me.txtVPRsale_id)
        Me.Controls.Add(Me.txtVPRcustomer_id)
        Me.Controls.Add(Me.txtVPRfix_id)
        Me.Controls.Add(Me.dgVPR)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewProductRepairFrm"
        Me.Text = "รายการอะไหล่ที่เบิก"
        CType(Me.dgVPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgVPR As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTipVPR As System.Windows.Forms.ToolTip
    Friend WithEvents txtVPRfix_id As System.Windows.Forms.TextBox
    Friend WithEvents txtVPRcustomer_id As System.Windows.Forms.TextBox
    Friend WithEvents txtVPRsale_id As System.Windows.Forms.TextBox
    Friend WithEvents txtVPRdatetime_save As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVPRcustomer_name As System.Windows.Forms.TextBox
    Friend WithEvents txtVPRtotal_all As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVPRemployee As System.Windows.Forms.TextBox
    Friend WithEvents txtVPRtotalProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtVPRlistCount As System.Windows.Forms.TextBox
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
End Class