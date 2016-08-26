<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsPrepareFrm
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
        Me.txtCPsearchSN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCPlastSN = New System.Windows.Forms.TextBox()
        Me.txtCPtotal = New System.Windows.Forms.TextBox()
        Me.txtCPclaimCompanyName = New System.Windows.Forms.TextBox()
        Me.txtCPclamCompanyID = New System.Windows.Forms.TextBox()
        Me.dgCP = New System.Windows.Forms.DataGridView()
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
        Me.btnCPsave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgCP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCPsearchSN
        '
        Me.txtCPsearchSN.Location = New System.Drawing.Point(40, 6)
        Me.txtCPsearchSN.Name = "txtCPsearchSN"
        Me.txtCPsearchSN.Size = New System.Drawing.Size(142, 20)
        Me.txtCPsearchSN.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtCPsearchSN, "กรอก SN สินค้าที่จะส่งเคลมไปบริษัทที่จัดซื้อสินค้ามา")
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
        'txtCPlastSN
        '
        Me.txtCPlastSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCPlastSN.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCPlastSN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCPlastSN.Location = New System.Drawing.Point(278, 412)
        Me.txtCPlastSN.Name = "txtCPlastSN"
        Me.txtCPlastSN.ReadOnly = True
        Me.txtCPlastSN.Size = New System.Drawing.Size(149, 20)
        Me.txtCPlastSN.TabIndex = 5
        Me.txtCPlastSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtCPlastSN, "SN ล่าสุด")
        '
        'txtCPtotal
        '
        Me.txtCPtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCPtotal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCPtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCPtotal.Location = New System.Drawing.Point(73, 412)
        Me.txtCPtotal.Name = "txtCPtotal"
        Me.txtCPtotal.ReadOnly = True
        Me.txtCPtotal.Size = New System.Drawing.Size(130, 20)
        Me.txtCPtotal.TabIndex = 6
        Me.txtCPtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtCPtotal, "จำนวนสินค้าส่งเคลม")
        '
        'txtCPclaimCompanyName
        '
        Me.txtCPclaimCompanyName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCPclaimCompanyName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCPclaimCompanyName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCPclaimCompanyName.Location = New System.Drawing.Point(552, 7)
        Me.txtCPclaimCompanyName.Name = "txtCPclaimCompanyName"
        Me.txtCPclaimCompanyName.ReadOnly = True
        Me.txtCPclaimCompanyName.Size = New System.Drawing.Size(209, 20)
        Me.txtCPclaimCompanyName.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtCPclaimCompanyName, "ชื่อบริษัท")
        '
        'txtCPclamCompanyID
        '
        Me.txtCPclamCompanyID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCPclamCompanyID.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCPclamCompanyID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCPclamCompanyID.Location = New System.Drawing.Point(433, 7)
        Me.txtCPclamCompanyID.Name = "txtCPclamCompanyID"
        Me.txtCPclamCompanyID.ReadOnly = True
        Me.txtCPclamCompanyID.Size = New System.Drawing.Size(113, 20)
        Me.txtCPclamCompanyID.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtCPclamCompanyID, "รหัสบริษัท")
        '
        'dgCP
        '
        Me.dgCP.AllowUserToAddRows = False
        Me.dgCP.AllowUserToDeleteRows = False
        Me.dgCP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.claims_id, Me.cus_id, Me.code_pro, Me.bar_code, Me.sn, Me.name_pro, Me.type, Me.unit, Me.datetime_save})
        Me.dgCP.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgCP.Location = New System.Drawing.Point(12, 33)
        Me.dgCP.Name = "dgCP"
        Me.dgCP.ReadOnly = True
        Me.dgCP.RowHeadersVisible = False
        Me.dgCP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCP.Size = New System.Drawing.Size(749, 373)
        Me.dgCP.TabIndex = 2
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
        'btnCPsave
        '
        Me.btnCPsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCPsave.Location = New System.Drawing.Point(600, 412)
        Me.btnCPsave.Name = "btnCPsave"
        Me.btnCPsave.Size = New System.Drawing.Size(161, 31)
        Me.btnCPsave.TabIndex = 3
        Me.btnCPsave.Text = "บันทึก"
        Me.btnCPsave.UseVisualStyleBackColor = True
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
        Me.Label4.Location = New System.Drawing.Point(349, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "บริษัทที่ส่งเคลม"
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
        'ClaimsPrepareFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 453)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCPclamCompanyID)
        Me.Controls.Add(Me.txtCPclaimCompanyName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCPtotal)
        Me.Controls.Add(Me.txtCPlastSN)
        Me.Controls.Add(Me.btnCPsave)
        Me.Controls.Add(Me.dgCP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCPsearchSN)
        Me.Name = "ClaimsPrepareFrm"
        Me.Text = "เตรียมสินค้าเคลม"
        CType(Me.dgCP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCPsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgCP As System.Windows.Forms.DataGridView
    Friend WithEvents btnCPsave As System.Windows.Forms.Button
    Friend WithEvents txtCPlastSN As System.Windows.Forms.TextBox
    Friend WithEvents txtCPtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCPclaimCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents txtCPclamCompanyID As System.Windows.Forms.TextBox
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
End Class
