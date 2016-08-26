<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsSendGroupFrm
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
        Me.txtCSGsearchSN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCSGlastSN = New System.Windows.Forms.TextBox()
        Me.txtCSGtotal = New System.Windows.Forms.TextBox()
        Me.txtCSGlotNum = New System.Windows.Forms.TextBox()
        Me.btnCSGsave = New System.Windows.Forms.Button()
        Me.btnCSGprintBoxcover = New System.Windows.Forms.Button()
        Me.dgCSG = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgCSG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCSGsearchSN
        '
        Me.txtCSGsearchSN.Location = New System.Drawing.Point(40, 6)
        Me.txtCSGsearchSN.Name = "txtCSGsearchSN"
        Me.txtCSGsearchSN.Size = New System.Drawing.Size(142, 20)
        Me.txtCSGsearchSN.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtCSGsearchSN, "กรอก SN สินค้าที่จะส่งเคลมไปบริษัทที่จัดซื้อสินค้ามา")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SN"
        '
        'txtCSGlastSN
        '
        Me.txtCSGlastSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCSGlastSN.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCSGlastSN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCSGlastSN.Location = New System.Drawing.Point(278, 412)
        Me.txtCSGlastSN.Name = "txtCSGlastSN"
        Me.txtCSGlastSN.ReadOnly = True
        Me.txtCSGlastSN.Size = New System.Drawing.Size(149, 20)
        Me.txtCSGlastSN.TabIndex = 5
        Me.txtCSGlastSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtCSGlastSN, "SN ล่าสุด")
        '
        'txtCSGtotal
        '
        Me.txtCSGtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCSGtotal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCSGtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCSGtotal.Location = New System.Drawing.Point(73, 412)
        Me.txtCSGtotal.Name = "txtCSGtotal"
        Me.txtCSGtotal.ReadOnly = True
        Me.txtCSGtotal.Size = New System.Drawing.Size(130, 20)
        Me.txtCSGtotal.TabIndex = 6
        Me.txtCSGtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtCSGtotal, "รวมจำนวนของเคลม")
        '
        'txtCSGlotNum
        '
        Me.txtCSGlotNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCSGlotNum.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCSGlotNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCSGlotNum.Location = New System.Drawing.Point(648, 6)
        Me.txtCSGlotNum.Name = "txtCSGlotNum"
        Me.txtCSGlotNum.ReadOnly = True
        Me.txtCSGlotNum.Size = New System.Drawing.Size(113, 20)
        Me.txtCSGlotNum.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtCSGlotNum, "ล็อตที่ส่งเคลม")
        '
        'btnCSGsave
        '
        Me.btnCSGsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCSGsave.Location = New System.Drawing.Point(600, 412)
        Me.btnCSGsave.Name = "btnCSGsave"
        Me.btnCSGsave.Size = New System.Drawing.Size(161, 31)
        Me.btnCSGsave.TabIndex = 3
        Me.btnCSGsave.Text = "บันทึก"
        Me.ToolTip1.SetToolTip(Me.btnCSGsave, "บันทึกส่งเคลม")
        Me.btnCSGsave.UseVisualStyleBackColor = True
        '
        'btnCSGprintBoxcover
        '
        Me.btnCSGprintBoxcover.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCSGprintBoxcover.Location = New System.Drawing.Point(433, 412)
        Me.btnCSGprintBoxcover.Name = "btnCSGprintBoxcover"
        Me.btnCSGprintBoxcover.Size = New System.Drawing.Size(161, 31)
        Me.btnCSGprintBoxcover.TabIndex = 13
        Me.btnCSGprintBoxcover.Text = "พิมพ์ใบปะหน้ากล่อง"
        Me.ToolTip1.SetToolTip(Me.btnCSGprintBoxcover, "พิมพ์ใบปะหน้ากล่องพัสดุ")
        Me.btnCSGprintBoxcover.UseVisualStyleBackColor = True
        '
        'dgCSG
        '
        Me.dgCSG.AllowUserToAddRows = False
        Me.dgCSG.AllowUserToDeleteRows = False
        Me.dgCSG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCSG.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCSG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCSG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.claims_id, Me.cus_id, Me.code_pro, Me.bar_code, Me.sn, Me.name_pro, Me.type, Me.unit, Me.datetime_save})
        Me.dgCSG.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgCSG.Location = New System.Drawing.Point(12, 33)
        Me.dgCSG.Name = "dgCSG"
        Me.dgCSG.ReadOnly = True
        Me.dgCSG.RowHeadersVisible = False
        Me.dgCSG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCSG.Size = New System.Drawing.Size(749, 373)
        Me.dgCSG.TabIndex = 2
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'claims_id
        '
        Me.claims_id.HeaderText = "รหัสเคลม"
        Me.claims_id.Name = "claims_id"
        Me.claims_id.ReadOnly = True
        Me.claims_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.claims_id.Width = 120
        '
        'cus_id
        '
        Me.cus_id.HeaderText = "รหัสลูกค้า"
        Me.cus_id.Name = "cus_id"
        Me.cus_id.ReadOnly = True
        Me.cus_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'sn
        '
        Me.sn.HeaderText = "SN"
        Me.sn.Name = "sn"
        Me.sn.ReadOnly = True
        Me.sn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 200
        '
        'type
        '
        Me.type.HeaderText = "ประเภท"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        Me.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.type.Width = 80
        '
        'unit
        '
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.Width = 70
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.ToolTipText = "วันที่รับเคลม"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 415)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "SN ล่าสุด"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "จำนวนชิ้น"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(574, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "LOT Number"
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 431)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 12
        Me.lblemployee.Text = "User"
        '
        'ClaimsSendGroupFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 453)
        Me.Controls.Add(Me.btnCSGprintBoxcover)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCSGlotNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCSGtotal)
        Me.Controls.Add(Me.txtCSGlastSN)
        Me.Controls.Add(Me.btnCSGsave)
        Me.Controls.Add(Me.dgCSG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCSGsearchSN)
        Me.Name = "ClaimsSendGroupFrm"
        Me.Text = "ส่งสินค้าเคลม"
        CType(Me.dgCSG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCSGsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgCSG As System.Windows.Forms.DataGridView
    Friend WithEvents btnCSGsave As System.Windows.Forms.Button
    Friend WithEvents txtCSGlastSN As System.Windows.Forms.TextBox
    Friend WithEvents txtCSGtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCSGlotNum As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblemployee As System.Windows.Forms.Label
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCSGprintBoxcover As System.Windows.Forms.Button
End Class
