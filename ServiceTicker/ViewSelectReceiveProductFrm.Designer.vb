﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSelectReceiveProductFrm
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
        Me.dgVSRP = New System.Windows.Forms.DataGridView()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtVSRPbuy_id = New System.Windows.Forms.TextBox()
        Me.txtVSRPsale_company_id = New System.Windows.Forms.TextBox()
        Me.txtVSRPsale_company_name = New System.Windows.Forms.TextBox()
        Me.txtVSRPdatetim_save = New System.Windows.Forms.TextBox()
        Me.txtVSRPemployee = New System.Windows.Forms.TextBox()
        Me.ToolTipVSRP = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtVSRtotalBuy = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgVSRP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgVSRP
        '
        Me.dgVSRP.AllowUserToAddRows = False
        Me.dgVSRP.AllowUserToDeleteRows = False
        Me.dgVSRP.AllowUserToOrderColumns = True
        Me.dgVSRP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgVSRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVSRP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_pro, Me.bar_code, Me.name_pro, Me.price_cost, Me.count_num, Me.total})
        Me.dgVSRP.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgVSRP.Location = New System.Drawing.Point(12, 35)
        Me.dgVSRP.Name = "dgVSRP"
        Me.dgVSRP.ReadOnly = True
        Me.dgVSRP.RowHeadersVisible = False
        Me.dgVSRP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVSRP.Size = New System.Drawing.Size(655, 432)
        Me.dgVSRP.TabIndex = 0
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'bar_code
        '
        Me.bar_code.HeaderText = "บาร์โค๊ต"
        Me.bar_code.Name = "bar_code"
        Me.bar_code.ReadOnly = True
        Me.bar_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 250
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
        Me.price_cost.Width = 70
        '
        'count_num
        '
        DataGridViewCellStyle2.NullValue = "0"
        Me.count_num.DefaultCellStyle = DataGridViewCellStyle2
        Me.count_num.HeaderText = "จำนวน"
        Me.count_num.Name = "count_num"
        Me.count_num.ReadOnly = True
        Me.count_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.count_num.ToolTipText = "จำนวนชิ้น"
        Me.count_num.Width = 70
        '
        'total
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.total.DefaultCellStyle = DataGridViewCellStyle3
        Me.total.HeaderText = "รวมราคา"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total.ToolTipText = "รวมราคา"
        '
        'txtVSRPbuy_id
        '
        Me.txtVSRPbuy_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPbuy_id.Location = New System.Drawing.Point(12, 9)
        Me.txtVSRPbuy_id.Name = "txtVSRPbuy_id"
        Me.txtVSRPbuy_id.Size = New System.Drawing.Size(157, 24)
        Me.txtVSRPbuy_id.TabIndex = 1
        Me.ToolTipVSRP.SetToolTip(Me.txtVSRPbuy_id, "รหัสใบสั่งซื้อ")
        '
        'txtVSRPsale_company_id
        '
        Me.txtVSRPsale_company_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPsale_company_id.Location = New System.Drawing.Point(167, 9)
        Me.txtVSRPsale_company_id.Name = "txtVSRPsale_company_id"
        Me.txtVSRPsale_company_id.Size = New System.Drawing.Size(69, 24)
        Me.txtVSRPsale_company_id.TabIndex = 2
        Me.ToolTipVSRP.SetToolTip(Me.txtVSRPsale_company_id, "รหัสบริษัทที่สั่งซื้อ")
        '
        'txtVSRPsale_company_name
        '
        Me.txtVSRPsale_company_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPsale_company_name.Location = New System.Drawing.Point(235, 9)
        Me.txtVSRPsale_company_name.Name = "txtVSRPsale_company_name"
        Me.txtVSRPsale_company_name.Size = New System.Drawing.Size(227, 24)
        Me.txtVSRPsale_company_name.TabIndex = 3
        Me.ToolTipVSRP.SetToolTip(Me.txtVSRPsale_company_name, "ชื่อบริษัทที่สั่งซื้อ")
        '
        'txtVSRPdatetim_save
        '
        Me.txtVSRPdatetim_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPdatetim_save.Location = New System.Drawing.Point(461, 9)
        Me.txtVSRPdatetim_save.Name = "txtVSRPdatetim_save"
        Me.txtVSRPdatetim_save.Size = New System.Drawing.Size(118, 24)
        Me.txtVSRPdatetim_save.TabIndex = 4
        Me.ToolTipVSRP.SetToolTip(Me.txtVSRPdatetim_save, "วันที่ทำรายการสั่งซื้อ")
        '
        'txtVSRPemployee
        '
        Me.txtVSRPemployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPemployee.Location = New System.Drawing.Point(577, 9)
        Me.txtVSRPemployee.Name = "txtVSRPemployee"
        Me.txtVSRPemployee.Size = New System.Drawing.Size(90, 24)
        Me.txtVSRPemployee.TabIndex = 5
        Me.ToolTipVSRP.SetToolTip(Me.txtVSRPemployee, "พนักงานที่ทำรายการสั่งซื้อ")
        '
        'ToolTipVSRP
        '
        Me.ToolTipVSRP.AutoPopDelay = 5000
        Me.ToolTipVSRP.InitialDelay = 300
        Me.ToolTipVSRP.IsBalloon = True
        Me.ToolTipVSRP.ReshowDelay = 300
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(12, 473)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(185, 23)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "พิมพ์รายการ"
        Me.ToolTipVSRP.SetToolTip(Me.btnPrint, "พิมพ์รายการสั่งซื้อในตารางด้านบน")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtVSRtotalBuy
        '
        Me.txtVSRtotalBuy.Location = New System.Drawing.Point(519, 473)
        Me.txtVSRtotalBuy.Name = "txtVSRtotalBuy"
        Me.txtVSRtotalBuy.ReadOnly = True
        Me.txtVSRtotalBuy.Size = New System.Drawing.Size(148, 20)
        Me.txtVSRtotalBuy.TabIndex = 7
        Me.txtVSRtotalBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(464, 476)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "รวมราคา"
        '
        'ViewSelectReceiveProductFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 501)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVSRtotalBuy)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtVSRPemployee)
        Me.Controls.Add(Me.txtVSRPdatetim_save)
        Me.Controls.Add(Me.txtVSRPsale_company_name)
        Me.Controls.Add(Me.txtVSRPsale_company_id)
        Me.Controls.Add(Me.txtVSRPbuy_id)
        Me.Controls.Add(Me.dgVSRP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewSelectReceiveProductFrm"
        Me.Text = "รายการสินค้าตามใบสั่งซื้อ"
        CType(Me.dgVSRP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgVSRP As System.Windows.Forms.DataGridView
    Friend WithEvents txtVSRPbuy_id As System.Windows.Forms.TextBox
    Friend WithEvents txtVSRPsale_company_id As System.Windows.Forms.TextBox
    Friend WithEvents txtVSRPsale_company_name As System.Windows.Forms.TextBox
    Friend WithEvents txtVSRPdatetim_save As System.Windows.Forms.TextBox
    Friend WithEvents txtVSRPemployee As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipVSRP As System.Windows.Forms.ToolTip
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtVSRtotalBuy As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class