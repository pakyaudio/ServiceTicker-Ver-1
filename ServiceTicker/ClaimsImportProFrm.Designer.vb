<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsImportProFrm
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
        Me.txtCIPsearchSN = New System.Windows.Forms.TextBox()
        Me.MetroLabel1 = New MetroControls.MetroLabel()
        Me.MetroLabel2 = New MetroControls.MetroLabel()
        Me.dgCIP = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.old_sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.new_sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.test = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accessory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpCIP = New System.Windows.Forms.TabControl()
        Me.SendToCus = New System.Windows.Forms.TabPage()
        Me.txtCIPtest = New System.Windows.Forms.TextBox()
        Me.MetroLabel4 = New MetroControls.MetroLabel()
        Me.txtCIPnew_sn = New System.Windows.Forms.TextBox()
        Me.MetroLabel6 = New MetroControls.MetroLabel()
        Me.lblCIPclaims_id = New MetroControls.MetroLabel()
        Me.txtCIPold_sn = New System.Windows.Forms.TextBox()
        Me.txtCIPcus_name = New System.Windows.Forms.TextBox()
        Me.txtCIPcus_id = New System.Windows.Forms.TextBox()
        Me.btnCIPsavetoCus = New MetroControls.MetroButton()
        Me.rbCIPreturnToCus = New System.Windows.Forms.RadioButton()
        Me.rbCIPreturnClaims = New System.Windows.Forms.RadioButton()
        Me.lblCIPdetail = New MetroControls.MetroLabel()
        Me.ReturnClaimsMe = New System.Windows.Forms.TabPage()
        Me.lblCIPclaims_idMe = New MetroControls.MetroLabel()
        Me.lblCIPdetailMe = New MetroControls.MetroLabel()
        Me.txtCIPmeTestMe = New System.Windows.Forms.TextBox()
        Me.txtCIPnew_snMe = New System.Windows.Forms.TextBox()
        Me.MetroLabel7 = New MetroControls.MetroLabel()
        Me.rbCIPreturnClaimsMe = New System.Windows.Forms.RadioButton()
        Me.rbCIPreturnStockMe = New System.Windows.Forms.RadioButton()
        Me.MetroLabel8 = New MetroControls.MetroLabel()
        Me.btnCIPsaveMe = New MetroControls.MetroButton()
        Me.txtCIPold_snMe = New System.Windows.Forms.TextBox()
        Me.StartTab = New System.Windows.Forms.TabPage()
        Me.MetroLabel5 = New MetroControls.MetroLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblemployee = New MetroControls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgCIP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCIP.SuspendLayout()
        Me.SendToCus.SuspendLayout()
        Me.ReturnClaimsMe.SuspendLayout()
        Me.StartTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCIPsearchSN
        '
        Me.txtCIPsearchSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCIPsearchSN.Location = New System.Drawing.Point(40, 5)
        Me.txtCIPsearchSN.Name = "txtCIPsearchSN"
        Me.txtCIPsearchSN.Size = New System.Drawing.Size(152, 22)
        Me.txtCIPsearchSN.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel1.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel1.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.MetroLabel1.ForeColorNormal = System.Drawing.Color.Black
        Me.MetroLabel1.Location = New System.Drawing.Point(311, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(461, 15)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "รายการสินค้าเคลมที่ทดสอบเสร็จแล้ว กรุณาใส่หมายเลข SN ในช่องเพื่อจัดการสินค้าเคลมไ" & _
    "ปยังส่วนต่าง ๆ "
        Me.MetroLabel1.UseHoverMode = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel2.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel2.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.MetroLabel2.ForeColorNormal = System.Drawing.Color.Black
        Me.MetroLabel2.Location = New System.Drawing.Point(12, 9)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(22, 15)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "SN"
        Me.MetroLabel2.UseHoverMode = True
        '
        'dgCIP
        '
        Me.dgCIP.AllowUserToAddRows = False
        Me.dgCIP.AllowUserToDeleteRows = False
        Me.dgCIP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCIP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCIP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.claims_id, Me.customer_id, Me.old_sn, Me.new_sn, Me.test, Me.code_pro, Me.name_pro, Me.symptom, Me.accessory})
        Me.dgCIP.Location = New System.Drawing.Point(12, 33)
        Me.dgCIP.MultiSelect = False
        Me.dgCIP.Name = "dgCIP"
        Me.dgCIP.ReadOnly = True
        Me.dgCIP.RowHeadersVisible = False
        Me.dgCIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCIP.Size = New System.Drawing.Size(760, 250)
        Me.dgCIP.TabIndex = 3
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.ToolTipText = "ลำดับ"
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
        'customer_id
        '
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_id.Width = 120
        '
        'old_sn
        '
        Me.old_sn.HeaderText = "SN เก่า"
        Me.old_sn.Name = "old_sn"
        Me.old_sn.ReadOnly = True
        Me.old_sn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.old_sn.ToolTipText = "SN เก่าของตัวสินค้า"
        Me.old_sn.Width = 70
        '
        'new_sn
        '
        Me.new_sn.HeaderText = "SN ใหม่"
        Me.new_sn.Name = "new_sn"
        Me.new_sn.ReadOnly = True
        Me.new_sn.ToolTipText = "SN ใหม่ของตัวสินค้า"
        '
        'test
        '
        Me.test.HeaderText = "ทดสอบ"
        Me.test.Name = "test"
        Me.test.ReadOnly = True
        Me.test.ToolTipText = "ผลการทดสอบ"
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'symptom
        '
        Me.symptom.HeaderText = "อาการเสีย"
        Me.symptom.Name = "symptom"
        Me.symptom.ReadOnly = True
        Me.symptom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'accessory
        '
        Me.accessory.HeaderText = "อุปกรณ์"
        Me.accessory.Name = "accessory"
        Me.accessory.ReadOnly = True
        Me.accessory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.accessory.ToolTipText = "อุปกรณ์ที่นำมาด้วย"
        '
        'tpCIP
        '
        Me.tpCIP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tpCIP.Controls.Add(Me.SendToCus)
        Me.tpCIP.Controls.Add(Me.ReturnClaimsMe)
        Me.tpCIP.Controls.Add(Me.StartTab)
        Me.tpCIP.Location = New System.Drawing.Point(12, 289)
        Me.tpCIP.Name = "tpCIP"
        Me.tpCIP.SelectedIndex = 0
        Me.tpCIP.Size = New System.Drawing.Size(760, 94)
        Me.tpCIP.TabIndex = 4
        '
        'SendToCus
        '
        Me.SendToCus.Controls.Add(Me.txtCIPtest)
        Me.SendToCus.Controls.Add(Me.MetroLabel4)
        Me.SendToCus.Controls.Add(Me.txtCIPnew_sn)
        Me.SendToCus.Controls.Add(Me.MetroLabel6)
        Me.SendToCus.Controls.Add(Me.lblCIPclaims_id)
        Me.SendToCus.Controls.Add(Me.txtCIPold_sn)
        Me.SendToCus.Controls.Add(Me.txtCIPcus_name)
        Me.SendToCus.Controls.Add(Me.txtCIPcus_id)
        Me.SendToCus.Controls.Add(Me.btnCIPsavetoCus)
        Me.SendToCus.Controls.Add(Me.rbCIPreturnToCus)
        Me.SendToCus.Controls.Add(Me.rbCIPreturnClaims)
        Me.SendToCus.Controls.Add(Me.lblCIPdetail)
        Me.SendToCus.Location = New System.Drawing.Point(4, 22)
        Me.SendToCus.Name = "SendToCus"
        Me.SendToCus.Padding = New System.Windows.Forms.Padding(3)
        Me.SendToCus.Size = New System.Drawing.Size(752, 68)
        Me.SendToCus.TabIndex = 0
        Me.SendToCus.Text = "จัดการงานเคลมลูกค้า"
        Me.SendToCus.UseVisualStyleBackColor = True
        '
        'txtCIPtest
        '
        Me.txtCIPtest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCIPtest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCIPtest.Location = New System.Drawing.Point(436, 43)
        Me.txtCIPtest.Name = "txtCIPtest"
        Me.txtCIPtest.ReadOnly = True
        Me.txtCIPtest.Size = New System.Drawing.Size(50, 22)
        Me.txtCIPtest.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txtCIPtest, "ผลการทดสอบสินค้า")
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel4.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel4.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.MetroLabel4.ForeColorNormal = System.Drawing.Color.Black
        Me.MetroLabel4.Location = New System.Drawing.Point(383, 25)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(44, 15)
        Me.MetroLabel4.TabIndex = 14
        Me.MetroLabel4.Text = "SN ใหม่"
        Me.MetroLabel4.UseHoverMode = True
        '
        'txtCIPnew_sn
        '
        Me.txtCIPnew_sn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCIPnew_sn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCIPnew_sn.Location = New System.Drawing.Point(380, 43)
        Me.txtCIPnew_sn.Name = "txtCIPnew_sn"
        Me.txtCIPnew_sn.ReadOnly = True
        Me.txtCIPnew_sn.Size = New System.Drawing.Size(50, 22)
        Me.txtCIPnew_sn.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtCIPnew_sn, "SN ใหม่ของสินค้า")
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel6.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel6.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.MetroLabel6.ForeColorNormal = System.Drawing.Color.Black
        Me.MetroLabel6.Location = New System.Drawing.Point(329, 25)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(40, 15)
        Me.MetroLabel6.TabIndex = 13
        Me.MetroLabel6.Text = "SN เก่า"
        Me.MetroLabel6.UseHoverMode = True
        '
        'lblCIPclaims_id
        '
        Me.lblCIPclaims_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCIPclaims_id.AutoSize = True
        Me.lblCIPclaims_id.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCIPclaims_id.ForeColor = System.Drawing.Color.Black
        Me.lblCIPclaims_id.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lblCIPclaims_id.ForeColorNormal = System.Drawing.Color.Black
        Me.lblCIPclaims_id.Location = New System.Drawing.Point(6, 25)
        Me.lblCIPclaims_id.Name = "lblCIPclaims_id"
        Me.lblCIPclaims_id.Size = New System.Drawing.Size(56, 15)
        Me.lblCIPclaims_id.TabIndex = 11
        Me.lblCIPclaims_id.Text = "Claims id"
        Me.ToolTip1.SetToolTip(Me.lblCIPclaims_id, "รหัสเคลม")
        Me.lblCIPclaims_id.UseHoverMode = True
        '
        'txtCIPold_sn
        '
        Me.txtCIPold_sn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCIPold_sn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCIPold_sn.Location = New System.Drawing.Point(324, 43)
        Me.txtCIPold_sn.Name = "txtCIPold_sn"
        Me.txtCIPold_sn.ReadOnly = True
        Me.txtCIPold_sn.Size = New System.Drawing.Size(50, 22)
        Me.txtCIPold_sn.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtCIPold_sn, "SN เดิมของสินค้า")
        '
        'txtCIPcus_name
        '
        Me.txtCIPcus_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCIPcus_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCIPcus_name.Location = New System.Drawing.Point(167, 43)
        Me.txtCIPcus_name.Name = "txtCIPcus_name"
        Me.txtCIPcus_name.ReadOnly = True
        Me.txtCIPcus_name.Size = New System.Drawing.Size(152, 22)
        Me.txtCIPcus_name.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtCIPcus_name, "ชื่อลูกค้า")
        '
        'txtCIPcus_id
        '
        Me.txtCIPcus_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCIPcus_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCIPcus_id.Location = New System.Drawing.Point(9, 43)
        Me.txtCIPcus_id.Name = "txtCIPcus_id"
        Me.txtCIPcus_id.ReadOnly = True
        Me.txtCIPcus_id.Size = New System.Drawing.Size(152, 22)
        Me.txtCIPcus_id.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtCIPcus_id, "รหัสลูกค้า")
        '
        'btnCIPsavetoCus
        '
        Me.btnCIPsavetoCus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCIPsavetoCus.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnCIPsavetoCus.BackgroundColorNormal = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnCIPsavetoCus.BackgroundColorPressed = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnCIPsavetoCus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnCIPsavetoCus.DrawBorders = True
        Me.btnCIPsavetoCus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCIPsavetoCus.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnCIPsavetoCus.Location = New System.Drawing.Point(606, 12)
        Me.btnCIPsavetoCus.Name = "btnCIPsavetoCus"
        Me.btnCIPsavetoCus.Size = New System.Drawing.Size(120, 42)
        Me.btnCIPsavetoCus.TabIndex = 8
        Me.btnCIPsavetoCus.Text = "บันทึก"
        '
        'rbCIPreturnToCus
        '
        Me.rbCIPreturnToCus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbCIPreturnToCus.AutoSize = True
        Me.rbCIPreturnToCus.Location = New System.Drawing.Point(492, 45)
        Me.rbCIPreturnToCus.Name = "rbCIPreturnToCus"
        Me.rbCIPreturnToCus.Size = New System.Drawing.Size(88, 17)
        Me.rbCIPreturnToCus.TabIndex = 7
        Me.rbCIPreturnToCus.TabStop = True
        Me.rbCIPreturnToCus.Text = "รอส่งคืนลูกค้า"
        Me.rbCIPreturnToCus.UseVisualStyleBackColor = True
        '
        'rbCIPreturnClaims
        '
        Me.rbCIPreturnClaims.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbCIPreturnClaims.AutoSize = True
        Me.rbCIPreturnClaims.Location = New System.Drawing.Point(492, 22)
        Me.rbCIPreturnClaims.Name = "rbCIPreturnClaims"
        Me.rbCIPreturnClaims.Size = New System.Drawing.Size(93, 17)
        Me.rbCIPreturnClaims.TabIndex = 6
        Me.rbCIPreturnClaims.TabStop = True
        Me.rbCIPreturnClaims.Text = "ส่งเคลมอีกรอบ"
        Me.rbCIPreturnClaims.UseVisualStyleBackColor = True
        '
        'lblCIPdetail
        '
        Me.lblCIPdetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCIPdetail.AutoSize = True
        Me.lblCIPdetail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCIPdetail.ForeColor = System.Drawing.Color.Black
        Me.lblCIPdetail.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lblCIPdetail.ForeColorNormal = System.Drawing.Color.Black
        Me.lblCIPdetail.Location = New System.Drawing.Point(6, 3)
        Me.lblCIPdetail.Name = "lblCIPdetail"
        Me.lblCIPdetail.Size = New System.Drawing.Size(49, 15)
        Me.lblCIPdetail.TabIndex = 5
        Me.lblCIPdetail.Text = "คำอธิบาย"
        Me.lblCIPdetail.UseHoverMode = True
        '
        'ReturnClaimsMe
        '
        Me.ReturnClaimsMe.Controls.Add(Me.lblCIPclaims_idMe)
        Me.ReturnClaimsMe.Controls.Add(Me.lblCIPdetailMe)
        Me.ReturnClaimsMe.Controls.Add(Me.txtCIPmeTestMe)
        Me.ReturnClaimsMe.Controls.Add(Me.txtCIPnew_snMe)
        Me.ReturnClaimsMe.Controls.Add(Me.MetroLabel7)
        Me.ReturnClaimsMe.Controls.Add(Me.rbCIPreturnClaimsMe)
        Me.ReturnClaimsMe.Controls.Add(Me.rbCIPreturnStockMe)
        Me.ReturnClaimsMe.Controls.Add(Me.MetroLabel8)
        Me.ReturnClaimsMe.Controls.Add(Me.btnCIPsaveMe)
        Me.ReturnClaimsMe.Controls.Add(Me.txtCIPold_snMe)
        Me.ReturnClaimsMe.Location = New System.Drawing.Point(4, 22)
        Me.ReturnClaimsMe.Name = "ReturnClaimsMe"
        Me.ReturnClaimsMe.Padding = New System.Windows.Forms.Padding(3)
        Me.ReturnClaimsMe.Size = New System.Drawing.Size(752, 68)
        Me.ReturnClaimsMe.TabIndex = 1
        Me.ReturnClaimsMe.Text = "จัดการงานเคลมของร้าน"
        Me.ReturnClaimsMe.UseVisualStyleBackColor = True
        '
        'lblCIPclaims_idMe
        '
        Me.lblCIPclaims_idMe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCIPclaims_idMe.AutoSize = True
        Me.lblCIPclaims_idMe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCIPclaims_idMe.ForeColor = System.Drawing.Color.Black
        Me.lblCIPclaims_idMe.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lblCIPclaims_idMe.ForeColorNormal = System.Drawing.Color.Black
        Me.lblCIPclaims_idMe.Location = New System.Drawing.Point(6, 43)
        Me.lblCIPclaims_idMe.Name = "lblCIPclaims_idMe"
        Me.lblCIPclaims_idMe.Size = New System.Drawing.Size(56, 15)
        Me.lblCIPclaims_idMe.TabIndex = 28
        Me.lblCIPclaims_idMe.Text = "Claims id"
        Me.ToolTip1.SetToolTip(Me.lblCIPclaims_idMe, "รหัสเคลม")
        Me.lblCIPclaims_idMe.UseHoverMode = True
        '
        'lblCIPdetailMe
        '
        Me.lblCIPdetailMe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCIPdetailMe.AutoSize = True
        Me.lblCIPdetailMe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCIPdetailMe.ForeColor = System.Drawing.Color.Black
        Me.lblCIPdetailMe.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lblCIPdetailMe.ForeColorNormal = System.Drawing.Color.Black
        Me.lblCIPdetailMe.Location = New System.Drawing.Point(6, 3)
        Me.lblCIPdetailMe.Name = "lblCIPdetailMe"
        Me.lblCIPdetailMe.Size = New System.Drawing.Size(49, 15)
        Me.lblCIPdetailMe.TabIndex = 27
        Me.lblCIPdetailMe.Text = "คำอธิบาย"
        Me.lblCIPdetailMe.UseHoverMode = True
        '
        'txtCIPmeTestMe
        '
        Me.txtCIPmeTestMe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCIPmeTestMe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCIPmeTestMe.Location = New System.Drawing.Point(446, 40)
        Me.txtCIPmeTestMe.Name = "txtCIPmeTestMe"
        Me.txtCIPmeTestMe.ReadOnly = True
        Me.txtCIPmeTestMe.Size = New System.Drawing.Size(50, 22)
        Me.txtCIPmeTestMe.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.txtCIPmeTestMe, "ผลการทดสอบสินค้า")
        '
        'txtCIPnew_snMe
        '
        Me.txtCIPnew_snMe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCIPnew_snMe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCIPnew_snMe.Location = New System.Drawing.Point(350, 40)
        Me.txtCIPnew_snMe.Name = "txtCIPnew_snMe"
        Me.txtCIPnew_snMe.ReadOnly = True
        Me.txtCIPnew_snMe.Size = New System.Drawing.Size(86, 22)
        Me.txtCIPnew_snMe.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.txtCIPnew_snMe, "SN ใหม่ของสินค้า")
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel7.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel7.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.MetroLabel7.ForeColorNormal = System.Drawing.Color.Black
        Me.MetroLabel7.Location = New System.Drawing.Point(371, 22)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(44, 15)
        Me.MetroLabel7.TabIndex = 25
        Me.MetroLabel7.Text = "SN ใหม่"
        Me.MetroLabel7.UseHoverMode = True
        '
        'rbCIPreturnClaimsMe
        '
        Me.rbCIPreturnClaimsMe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbCIPreturnClaimsMe.AutoSize = True
        Me.rbCIPreturnClaimsMe.Location = New System.Drawing.Point(502, 19)
        Me.rbCIPreturnClaimsMe.Name = "rbCIPreturnClaimsMe"
        Me.rbCIPreturnClaimsMe.Size = New System.Drawing.Size(93, 17)
        Me.rbCIPreturnClaimsMe.TabIndex = 17
        Me.rbCIPreturnClaimsMe.TabStop = True
        Me.rbCIPreturnClaimsMe.Text = "ส่งเคลมอีกรอบ"
        Me.rbCIPreturnClaimsMe.UseVisualStyleBackColor = True
        '
        'rbCIPreturnStockMe
        '
        Me.rbCIPreturnStockMe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbCIPreturnStockMe.AutoSize = True
        Me.rbCIPreturnStockMe.Location = New System.Drawing.Point(502, 42)
        Me.rbCIPreturnStockMe.Name = "rbCIPreturnStockMe"
        Me.rbCIPreturnStockMe.Size = New System.Drawing.Size(78, 17)
        Me.rbCIPreturnStockMe.TabIndex = 18
        Me.rbCIPreturnStockMe.TabStop = True
        Me.rbCIPreturnStockMe.Text = "ส่งเข้าสต็อก"
        Me.rbCIPreturnStockMe.UseVisualStyleBackColor = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel8.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel8.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.MetroLabel8.ForeColorNormal = System.Drawing.Color.Black
        Me.MetroLabel8.Location = New System.Drawing.Point(285, 22)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(40, 15)
        Me.MetroLabel8.TabIndex = 24
        Me.MetroLabel8.Text = "SN เก่า"
        Me.MetroLabel8.UseHoverMode = True
        '
        'btnCIPsaveMe
        '
        Me.btnCIPsaveMe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCIPsaveMe.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnCIPsaveMe.BackgroundColorNormal = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnCIPsaveMe.BackgroundColorPressed = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnCIPsaveMe.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnCIPsaveMe.DrawBorders = True
        Me.btnCIPsaveMe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCIPsaveMe.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnCIPsaveMe.Location = New System.Drawing.Point(616, 9)
        Me.btnCIPsaveMe.Name = "btnCIPsaveMe"
        Me.btnCIPsaveMe.Size = New System.Drawing.Size(120, 42)
        Me.btnCIPsaveMe.TabIndex = 19
        Me.btnCIPsaveMe.Text = "บันทึก"
        '
        'txtCIPold_snMe
        '
        Me.txtCIPold_snMe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCIPold_snMe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCIPold_snMe.Location = New System.Drawing.Point(258, 40)
        Me.txtCIPold_snMe.Name = "txtCIPold_snMe"
        Me.txtCIPold_snMe.ReadOnly = True
        Me.txtCIPold_snMe.Size = New System.Drawing.Size(86, 22)
        Me.txtCIPold_snMe.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.txtCIPold_snMe, "SN เดิมของสินค้า")
        '
        'StartTab
        '
        Me.StartTab.Controls.Add(Me.MetroLabel5)
        Me.StartTab.Location = New System.Drawing.Point(4, 22)
        Me.StartTab.Name = "StartTab"
        Me.StartTab.Padding = New System.Windows.Forms.Padding(3)
        Me.StartTab.Size = New System.Drawing.Size(752, 68)
        Me.StartTab.TabIndex = 2
        Me.StartTab.Text = "เริ่ม"
        Me.StartTab.UseVisualStyleBackColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroLabel5.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel5.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.MetroLabel5.ForeColorNormal = System.Drawing.Color.Black
        Me.MetroLabel5.Location = New System.Drawing.Point(267, 18)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(219, 32)
        Me.MetroLabel5.TabIndex = 0
        Me.MetroLabel5.Text = ".....นำเข้าสินค้าเคลม....."
        Me.MetroLabel5.UseHoverMode = False
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblemployee.ForeColor = System.Drawing.Color.Black
        Me.lblemployee.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lblemployee.ForeColorNormal = System.Drawing.Color.Black
        Me.lblemployee.Location = New System.Drawing.Point(9, 386)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(30, 15)
        Me.lblemployee.TabIndex = 28
        Me.lblemployee.Text = "User"
        Me.lblemployee.UseHoverMode = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(16, 187)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(736, 49)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'ClaimsImportProFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 404)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.tpCIP)
        Me.Controls.Add(Me.dgCIP)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtCIPsearchSN)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ClaimsImportProFrm"
        Me.Text = "นำเข้าสินค้าเคลม"
        CType(Me.dgCIP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCIP.ResumeLayout(False)
        Me.SendToCus.ResumeLayout(False)
        Me.SendToCus.PerformLayout()
        Me.ReturnClaimsMe.ResumeLayout(False)
        Me.ReturnClaimsMe.PerformLayout()
        Me.StartTab.ResumeLayout(False)
        Me.StartTab.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCIPsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents MetroLabel1 As MetroControls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroControls.MetroLabel
    Friend WithEvents dgCIP As System.Windows.Forms.DataGridView
    Friend WithEvents tpCIP As System.Windows.Forms.TabControl
    Friend WithEvents SendToCus As System.Windows.Forms.TabPage
    Friend WithEvents ReturnClaimsMe As System.Windows.Forms.TabPage
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents old_sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents new_sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents test As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accessory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCIPtest As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MetroLabel4 As MetroControls.MetroLabel
    Friend WithEvents txtCIPnew_sn As System.Windows.Forms.TextBox
    Friend WithEvents MetroLabel6 As MetroControls.MetroLabel
    Friend WithEvents lblCIPclaims_id As MetroControls.MetroLabel
    Friend WithEvents txtCIPold_sn As System.Windows.Forms.TextBox
    Friend WithEvents txtCIPcus_name As System.Windows.Forms.TextBox
    Friend WithEvents txtCIPcus_id As System.Windows.Forms.TextBox
    Friend WithEvents btnCIPsavetoCus As MetroControls.MetroButton
    Friend WithEvents rbCIPreturnToCus As System.Windows.Forms.RadioButton
    Friend WithEvents rbCIPreturnClaims As System.Windows.Forms.RadioButton
    Friend WithEvents lblCIPdetail As MetroControls.MetroLabel
    Friend WithEvents StartTab As System.Windows.Forms.TabPage
    Friend WithEvents MetroLabel5 As MetroControls.MetroLabel
    Friend WithEvents txtCIPmeTestMe As System.Windows.Forms.TextBox
    Friend WithEvents txtCIPnew_snMe As System.Windows.Forms.TextBox
    Friend WithEvents MetroLabel7 As MetroControls.MetroLabel
    Friend WithEvents rbCIPreturnClaimsMe As System.Windows.Forms.RadioButton
    Friend WithEvents rbCIPreturnStockMe As System.Windows.Forms.RadioButton
    Friend WithEvents MetroLabel8 As MetroControls.MetroLabel
    Friend WithEvents btnCIPsaveMe As MetroControls.MetroButton
    Friend WithEvents txtCIPold_snMe As System.Windows.Forms.TextBox
    Friend WithEvents lblCIPdetailMe As MetroControls.MetroLabel
    Friend WithEvents lblCIPclaims_idMe As MetroControls.MetroLabel
    Friend WithEvents lblemployee As MetroControls.MetroLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
