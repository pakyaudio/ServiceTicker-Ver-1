<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepairStatusFrm
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
        Me.btnRSPartsWithdrawal = New System.Windows.Forms.Button()
        Me.btnRSstatus1 = New System.Windows.Forms.Button()
        Me.btnRSstatus2 = New System.Windows.Forms.Button()
        Me.btnRSstatus3 = New System.Windows.Forms.Button()
        Me.btnRSstatus4 = New System.Windows.Forms.Button()
        Me.btnRSstatus5 = New System.Windows.Forms.Button()
        Me.btnRSstatus6 = New System.Windows.Forms.Button()
        Me.btnRSstatus7 = New System.Windows.Forms.Button()
        Me.dgRSstatus1 = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_idS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datatime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_idS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_nameS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.snS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptomS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.managerdataS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixrepairnoteS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixaccessoryS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixnoteS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixpriceS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_getS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixuserS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_repairS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note_repairS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.teltocusS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datecom_repair = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importuneS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.storageS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.varuntee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRSteltocus = New System.Windows.Forms.Label()
        Me.cbbRSteltocus = New System.Windows.Forms.ComboBox()
        Me.gbRSdetailIDedit = New System.Windows.Forms.GroupBox()
        Me.txtRScus_tel = New System.Windows.Forms.TextBox()
        Me.txtRScus_name = New System.Windows.Forms.TextBox()
        Me.txtRScus_id = New System.Windows.Forms.TextBox()
        Me.txtRSfix_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRScusName = New System.Windows.Forms.Label()
        Me.lblRSfix_id = New System.Windows.Forms.Label()
        Me.btnRSclose = New System.Windows.Forms.Button()
        Me.btnRSsave = New System.Windows.Forms.Button()
        Me.lblRSrepairdetail = New System.Windows.Forms.Label()
        Me.lblRSvaruntee = New System.Windows.Forms.Label()
        Me.cbbRSvaruntee = New System.Windows.Forms.ComboBox()
        Me.cbbRSuser_repair = New System.Windows.Forms.ComboBox()
        Me.lblRSfixstatus = New System.Windows.Forms.Label()
        Me.cbbRSstatus = New System.Windows.Forms.ComboBox()
        Me.txtRSnote_repair = New System.Windows.Forms.TextBox()
        Me.lblStatusText = New System.Windows.Forms.Label()
        Me.lblRSsaleDetail = New System.Windows.Forms.Label()
        Me.ToolTipRS = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRSviewProduct = New System.Windows.Forms.Button()
        Me.btnRSsend_to_claims = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSRsendRepair = New System.Windows.Forms.Button()
        Me.llblRStechnician = New System.Windows.Forms.LinkLabel()
        Me.llblRSshelf = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRSclaims = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbbRSstorage = New System.Windows.Forms.ComboBox()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgRSstatus1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRSdetailIDedit.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRSPartsWithdrawal
        '
        Me.btnRSPartsWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRSPartsWithdrawal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRSPartsWithdrawal.Location = New System.Drawing.Point(318, 416)
        Me.btnRSPartsWithdrawal.Name = "btnRSPartsWithdrawal"
        Me.btnRSPartsWithdrawal.Size = New System.Drawing.Size(122, 32)
        Me.btnRSPartsWithdrawal.TabIndex = 71
        Me.btnRSPartsWithdrawal.Text = "เบิกอะไหล่/ค่าซ่อม"
        Me.ToolTipRS.SetToolTip(Me.btnRSPartsWithdrawal, "เบิกอะไหล่ ใส่ค่าซ่อมในนี้")
        Me.btnRSPartsWithdrawal.UseVisualStyleBackColor = True
        '
        'btnRSstatus1
        '
        Me.btnRSstatus1.Location = New System.Drawing.Point(30, 12)
        Me.btnRSstatus1.Name = "btnRSstatus1"
        Me.btnRSstatus1.Size = New System.Drawing.Size(117, 26)
        Me.btnRSstatus1.TabIndex = 70
        Me.btnRSstatus1.Text = "รอซ่อม"
        Me.btnRSstatus1.UseVisualStyleBackColor = True
        '
        'btnRSstatus2
        '
        Me.btnRSstatus2.Location = New System.Drawing.Point(153, 12)
        Me.btnRSstatus2.Name = "btnRSstatus2"
        Me.btnRSstatus2.Size = New System.Drawing.Size(117, 26)
        Me.btnRSstatus2.TabIndex = 69
        Me.btnRSstatus2.Text = "กำลังซ่อม"
        Me.btnRSstatus2.UseVisualStyleBackColor = True
        '
        'btnRSstatus3
        '
        Me.btnRSstatus3.Location = New System.Drawing.Point(276, 12)
        Me.btnRSstatus3.Name = "btnRSstatus3"
        Me.btnRSstatus3.Size = New System.Drawing.Size(117, 26)
        Me.btnRSstatus3.TabIndex = 68
        Me.btnRSstatus3.Text = "รออะไหล่/ส่งเคลม"
        Me.btnRSstatus3.UseVisualStyleBackColor = True
        '
        'btnRSstatus4
        '
        Me.btnRSstatus4.Location = New System.Drawing.Point(399, 12)
        Me.btnRSstatus4.Name = "btnRSstatus4"
        Me.btnRSstatus4.Size = New System.Drawing.Size(117, 26)
        Me.btnRSstatus4.TabIndex = 67
        Me.btnRSstatus4.Text = "ซ่อมไม่ได้"
        Me.btnRSstatus4.UseVisualStyleBackColor = True
        '
        'btnRSstatus5
        '
        Me.btnRSstatus5.Location = New System.Drawing.Point(522, 12)
        Me.btnRSstatus5.Name = "btnRSstatus5"
        Me.btnRSstatus5.Size = New System.Drawing.Size(117, 26)
        Me.btnRSstatus5.TabIndex = 66
        Me.btnRSstatus5.Text = "ซ่อมเสร็จ"
        Me.btnRSstatus5.UseVisualStyleBackColor = True
        '
        'btnRSstatus6
        '
        Me.btnRSstatus6.Location = New System.Drawing.Point(645, 12)
        Me.btnRSstatus6.Name = "btnRSstatus6"
        Me.btnRSstatus6.Size = New System.Drawing.Size(117, 26)
        Me.btnRSstatus6.TabIndex = 65
        Me.btnRSstatus6.Text = "ยกเลิกซ่อม"
        Me.btnRSstatus6.UseVisualStyleBackColor = True
        '
        'btnRSstatus7
        '
        Me.btnRSstatus7.Location = New System.Drawing.Point(768, 12)
        Me.btnRSstatus7.Name = "btnRSstatus7"
        Me.btnRSstatus7.Size = New System.Drawing.Size(117, 26)
        Me.btnRSstatus7.TabIndex = 64
        Me.btnRSstatus7.Text = "คืนเครื่องแล้ว"
        Me.btnRSstatus7.UseVisualStyleBackColor = True
        '
        'dgRSstatus1
        '
        Me.dgRSstatus1.AllowUserToAddRows = False
        Me.dgRSstatus1.AllowUserToDeleteRows = False
        Me.dgRSstatus1.AllowUserToOrderColumns = True
        Me.dgRSstatus1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgRSstatus1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgRSstatus1.CausesValidation = False
        Me.dgRSstatus1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRSstatus1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.fix_idS1, Me.datatime_save, Me.customer_idS1, Me.customer_nameS1, Me.snS1, Me.p_type, Me.p_name, Me.model, Me.symptomS1, Me.managerdataS1, Me.fixrepairnoteS1, Me.fixaccessoryS1, Me.fixnoteS1, Me.fixpriceS1, Me.date_getS1, Me.fixuserS1, Me.statusS1, Me.user_repairS1, Me.note_repairS1, Me.teltocusS1, Me.datecom_repair, Me.importuneS1, Me.storageS1, Me.varuntee})
        Me.dgRSstatus1.Location = New System.Drawing.Point(12, 44)
        Me.dgRSstatus1.MultiSelect = False
        Me.dgRSstatus1.Name = "dgRSstatus1"
        Me.dgRSstatus1.ReadOnly = True
        Me.dgRSstatus1.RowHeadersVisible = False
        Me.dgRSstatus1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRSstatus1.Size = New System.Drawing.Size(903, 215)
        Me.dgRSstatus1.TabIndex = 40
        '
        'no
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GreenYellow
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.no.DefaultCellStyle = DataGridViewCellStyle1
        Me.no.Frozen = True
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 30
        '
        'fix_idS1
        '
        Me.fix_idS1.HeaderText = "เลขที่ใบซ่อม"
        Me.fix_idS1.Name = "fix_idS1"
        Me.fix_idS1.ReadOnly = True
        Me.fix_idS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fix_idS1.ToolTipText = "เลขที่ใบซ่อม"
        Me.fix_idS1.Width = 120
        '
        'datatime_save
        '
        Me.datatime_save.HeaderText = "วันที่รับซ่อม"
        Me.datatime_save.Name = "datatime_save"
        Me.datatime_save.ReadOnly = True
        Me.datatime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datatime_save.ToolTipText = "วันที่รับซ่อมเครื่องซ่อม"
        Me.datatime_save.Width = 120
        '
        'customer_idS1
        '
        Me.customer_idS1.HeaderText = "รหัสลูกค้า"
        Me.customer_idS1.Name = "customer_idS1"
        Me.customer_idS1.ReadOnly = True
        Me.customer_idS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_idS1.ToolTipText = "รหัสลูกค้า"
        Me.customer_idS1.Width = 120
        '
        'customer_nameS1
        '
        Me.customer_nameS1.HeaderText = "ชื่อลูกค้า"
        Me.customer_nameS1.Name = "customer_nameS1"
        Me.customer_nameS1.ReadOnly = True
        Me.customer_nameS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_nameS1.ToolTipText = "ชื่อลูกค้า"
        Me.customer_nameS1.Width = 120
        '
        'snS1
        '
        Me.snS1.HeaderText = "SN"
        Me.snS1.Name = "snS1"
        Me.snS1.ReadOnly = True
        Me.snS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.snS1.ToolTipText = "SN"
        '
        'p_type
        '
        Me.p_type.HeaderText = "ประเภท"
        Me.p_type.Name = "p_type"
        Me.p_type.ReadOnly = True
        Me.p_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.p_type.ToolTipText = "ประเภท"
        '
        'p_name
        '
        Me.p_name.HeaderText = "ยี่ห้อ"
        Me.p_name.Name = "p_name"
        Me.p_name.ReadOnly = True
        Me.p_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.p_name.ToolTipText = "ยี่ห้อ"
        '
        'model
        '
        Me.model.HeaderText = "รุ่น"
        Me.model.Name = "model"
        Me.model.ReadOnly = True
        Me.model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.model.ToolTipText = "รุ่น"
        '
        'symptomS1
        '
        Me.symptomS1.HeaderText = "อาการเสีย"
        Me.symptomS1.Name = "symptomS1"
        Me.symptomS1.ReadOnly = True
        Me.symptomS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.symptomS1.ToolTipText = "อาการเสีย"
        '
        'managerdataS1
        '
        Me.managerdataS1.HeaderText = "จัดการข้อมูล"
        Me.managerdataS1.Name = "managerdataS1"
        Me.managerdataS1.ReadOnly = True
        Me.managerdataS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.managerdataS1.ToolTipText = "จัดการข้อมูล"
        '
        'fixrepairnoteS1
        '
        Me.fixrepairnoteS1.HeaderText = "อาการเสียเพิ่มเติม"
        Me.fixrepairnoteS1.Name = "fixrepairnoteS1"
        Me.fixrepairnoteS1.ReadOnly = True
        Me.fixrepairnoteS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fixrepairnoteS1.ToolTipText = "อาการเสียเพิ่มเติม"
        Me.fixrepairnoteS1.Width = 120
        '
        'fixaccessoryS1
        '
        Me.fixaccessoryS1.HeaderText = "อุปกรณ์ที่นำมาด้วย"
        Me.fixaccessoryS1.Name = "fixaccessoryS1"
        Me.fixaccessoryS1.ReadOnly = True
        Me.fixaccessoryS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fixaccessoryS1.ToolTipText = "อุปกรณ์ที่นำมาด้วย"
        '
        'fixnoteS1
        '
        Me.fixnoteS1.HeaderText = "หมายเหตุ"
        Me.fixnoteS1.Name = "fixnoteS1"
        Me.fixnoteS1.ReadOnly = True
        Me.fixnoteS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fixnoteS1.ToolTipText = "หมายเหตุ"
        '
        'fixpriceS1
        '
        Me.fixpriceS1.HeaderText = "ประเมินราคาซ่อม"
        Me.fixpriceS1.Name = "fixpriceS1"
        Me.fixpriceS1.ReadOnly = True
        Me.fixpriceS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fixpriceS1.ToolTipText = "การประเมินราคาก่อนซ่อม"
        Me.fixpriceS1.Width = 120
        '
        'date_getS1
        '
        Me.date_getS1.HeaderText = "นัดรับ"
        Me.date_getS1.Name = "date_getS1"
        Me.date_getS1.ReadOnly = True
        Me.date_getS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_getS1.ToolTipText = "วันที่นัดรับเครื่องซ่อม"
        '
        'fixuserS1
        '
        Me.fixuserS1.HeaderText = "ผู้รับงาน"
        Me.fixuserS1.Name = "fixuserS1"
        Me.fixuserS1.ReadOnly = True
        Me.fixuserS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fixuserS1.ToolTipText = "ผู้รับงานซ่อม"
        '
        'statusS1
        '
        Me.statusS1.HeaderText = "สถานะ"
        Me.statusS1.Name = "statusS1"
        Me.statusS1.ReadOnly = True
        Me.statusS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.statusS1.ToolTipText = "สถานะงานซ่อม"
        '
        'user_repairS1
        '
        Me.user_repairS1.HeaderText = "ช่างซ่อม"
        Me.user_repairS1.Name = "user_repairS1"
        Me.user_repairS1.ReadOnly = True
        Me.user_repairS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.user_repairS1.ToolTipText = "ช่างผู้ซ่อม"
        '
        'note_repairS1
        '
        Me.note_repairS1.HeaderText = "รายละเอียดการซ่อม"
        Me.note_repairS1.Name = "note_repairS1"
        Me.note_repairS1.ReadOnly = True
        Me.note_repairS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.note_repairS1.ToolTipText = "รายละเอียดการซ่อม"
        Me.note_repairS1.Width = 120
        '
        'teltocusS1
        '
        Me.teltocusS1.HeaderText = "แจ้งลูกค้า"
        Me.teltocusS1.Name = "teltocusS1"
        Me.teltocusS1.ReadOnly = True
        Me.teltocusS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.teltocusS1.ToolTipText = "การติดต่อแจ้งลูกค้าเกี่ยวกับงานซ่อม"
        '
        'datecom_repair
        '
        Me.datecom_repair.HeaderText = "ซ่อมเสร็จ"
        Me.datecom_repair.Name = "datecom_repair"
        Me.datecom_repair.ReadOnly = True
        Me.datecom_repair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datecom_repair.ToolTipText = "วันที่ซ่อมเสร็จ"
        '
        'importuneS1
        '
        Me.importuneS1.HeaderText = "เร่งด่วน"
        Me.importuneS1.Name = "importuneS1"
        Me.importuneS1.ReadOnly = True
        Me.importuneS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.importuneS1.ToolTipText = "ความเร่งด่วนของงานซ่อม"
        '
        'storageS1
        '
        Me.storageS1.HeaderText = "ที่เก็บ"
        Me.storageS1.Name = "storageS1"
        Me.storageS1.ReadOnly = True
        Me.storageS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.storageS1.ToolTipText = "ที่เก็บเครื่องซ่อม ชั้นวาง"
        '
        'varuntee
        '
        Me.varuntee.HeaderText = "รับประกัน"
        Me.varuntee.Name = "varuntee"
        Me.varuntee.ReadOnly = True
        Me.varuntee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.varuntee.ToolTipText = "การรับประกัน"
        '
        'lblRSteltocus
        '
        Me.lblRSteltocus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRSteltocus.AutoSize = True
        Me.lblRSteltocus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRSteltocus.ForeColor = System.Drawing.Color.Black
        Me.lblRSteltocus.Location = New System.Drawing.Point(720, 363)
        Me.lblRSteltocus.Name = "lblRSteltocus"
        Me.lblRSteltocus.Size = New System.Drawing.Size(59, 18)
        Me.lblRSteltocus.TabIndex = 63
        Me.lblRSteltocus.Text = "แจ้งลูกค้า"
        '
        'cbbRSteltocus
        '
        Me.cbbRSteltocus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbRSteltocus.FormattingEnabled = True
        Me.cbbRSteltocus.Items.AddRange(New Object() {"ยังไม่ได้แจ้งลูกค้า", "แจ้งลูกค้าแล้ว"})
        Me.cbbRSteltocus.Location = New System.Drawing.Point(785, 364)
        Me.cbbRSteltocus.Name = "cbbRSteltocus"
        Me.cbbRSteltocus.Size = New System.Drawing.Size(121, 21)
        Me.cbbRSteltocus.TabIndex = 62
        Me.ToolTipRS.SetToolTip(Me.cbbRSteltocus, "ระบุว่าโทรแจ้งลูกค้าหรือยัง")
        '
        'gbRSdetailIDedit
        '
        Me.gbRSdetailIDedit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbRSdetailIDedit.BackColor = System.Drawing.SystemColors.Control
        Me.gbRSdetailIDedit.Controls.Add(Me.txtRScus_tel)
        Me.gbRSdetailIDedit.Controls.Add(Me.txtRScus_name)
        Me.gbRSdetailIDedit.Controls.Add(Me.txtRScus_id)
        Me.gbRSdetailIDedit.Controls.Add(Me.txtRSfix_id)
        Me.gbRSdetailIDedit.Controls.Add(Me.Label3)
        Me.gbRSdetailIDedit.Controls.Add(Me.Label2)
        Me.gbRSdetailIDedit.Controls.Add(Me.lblRScusName)
        Me.gbRSdetailIDedit.Controls.Add(Me.lblRSfix_id)
        Me.gbRSdetailIDedit.Location = New System.Drawing.Point(12, 298)
        Me.gbRSdetailIDedit.Name = "gbRSdetailIDedit"
        Me.gbRSdetailIDedit.Size = New System.Drawing.Size(197, 128)
        Me.gbRSdetailIDedit.TabIndex = 59
        Me.gbRSdetailIDedit.TabStop = False
        Me.gbRSdetailIDedit.Text = "ID งานที่กำลังเลือกอยู่ขณะนี้"
        '
        'txtRScus_tel
        '
        Me.txtRScus_tel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRScus_tel.Location = New System.Drawing.Point(73, 90)
        Me.txtRScus_tel.Name = "txtRScus_tel"
        Me.txtRScus_tel.ReadOnly = True
        Me.txtRScus_tel.Size = New System.Drawing.Size(121, 20)
        Me.txtRScus_tel.TabIndex = 80
        Me.ToolTipRS.SetToolTip(Me.txtRScus_tel, "สถานที่เก็บงาซ่อม เช่น ชั้นวาง A1")
        '
        'txtRScus_name
        '
        Me.txtRScus_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRScus_name.Location = New System.Drawing.Point(73, 67)
        Me.txtRScus_name.Name = "txtRScus_name"
        Me.txtRScus_name.ReadOnly = True
        Me.txtRScus_name.Size = New System.Drawing.Size(121, 20)
        Me.txtRScus_name.TabIndex = 79
        Me.ToolTipRS.SetToolTip(Me.txtRScus_name, "สถานที่เก็บงาซ่อม เช่น ชั้นวาง A1")
        '
        'txtRScus_id
        '
        Me.txtRScus_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRScus_id.Location = New System.Drawing.Point(73, 44)
        Me.txtRScus_id.Name = "txtRScus_id"
        Me.txtRScus_id.ReadOnly = True
        Me.txtRScus_id.Size = New System.Drawing.Size(121, 20)
        Me.txtRScus_id.TabIndex = 78
        Me.ToolTipRS.SetToolTip(Me.txtRScus_id, "สถานที่เก็บงาซ่อม เช่น ชั้นวาง A1")
        '
        'txtRSfix_id
        '
        Me.txtRSfix_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRSfix_id.Location = New System.Drawing.Point(73, 21)
        Me.txtRSfix_id.Name = "txtRSfix_id"
        Me.txtRSfix_id.ReadOnly = True
        Me.txtRSfix_id.Size = New System.Drawing.Size(121, 20)
        Me.txtRSfix_id.TabIndex = 78
        Me.ToolTipRS.SetToolTip(Me.txtRSfix_id, "สถานที่เก็บงาซ่อม เช่น ชั้นวาง A1")
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(18, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "เบอร์โทร"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(14, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "รหัสลูกค้า"
        '
        'lblRScusName
        '
        Me.lblRScusName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRScusName.AutoSize = True
        Me.lblRScusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRScusName.ForeColor = System.Drawing.Color.Navy
        Me.lblRScusName.Location = New System.Drawing.Point(22, 68)
        Me.lblRScusName.Name = "lblRScusName"
        Me.lblRScusName.Size = New System.Drawing.Size(45, 16)
        Me.lblRScusName.TabIndex = 40
        Me.lblRScusName.Text = "ชื่อลูกค้า"
        '
        'lblRSfix_id
        '
        Me.lblRSfix_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRSfix_id.AutoSize = True
        Me.lblRSfix_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRSfix_id.ForeColor = System.Drawing.Color.Navy
        Me.lblRSfix_id.Location = New System.Drawing.Point(0, 22)
        Me.lblRSfix_id.Name = "lblRSfix_id"
        Me.lblRSfix_id.Size = New System.Drawing.Size(67, 16)
        Me.lblRSfix_id.TabIndex = 3
        Me.lblRSfix_id.Text = "รหัสงานซ่อม"
        '
        'btnRSclose
        '
        Me.btnRSclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRSclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRSclose.Location = New System.Drawing.Point(789, 417)
        Me.btnRSclose.Name = "btnRSclose"
        Me.btnRSclose.Size = New System.Drawing.Size(117, 31)
        Me.btnRSclose.TabIndex = 56
        Me.btnRSclose.Text = "ปิด"
        Me.btnRSclose.UseVisualStyleBackColor = True
        '
        'btnRSsave
        '
        Me.btnRSsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRSsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRSsave.Location = New System.Drawing.Point(666, 417)
        Me.btnRSsave.Name = "btnRSsave"
        Me.btnRSsave.Size = New System.Drawing.Size(117, 32)
        Me.btnRSsave.TabIndex = 55
        Me.btnRSsave.Text = "บันทึก"
        Me.btnRSsave.UseVisualStyleBackColor = True
        '
        'lblRSrepairdetail
        '
        Me.lblRSrepairdetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRSrepairdetail.AutoSize = True
        Me.lblRSrepairdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRSrepairdetail.ForeColor = System.Drawing.Color.Black
        Me.lblRSrepairdetail.Location = New System.Drawing.Point(537, 286)
        Me.lblRSrepairdetail.Name = "lblRSrepairdetail"
        Me.lblRSrepairdetail.Size = New System.Drawing.Size(118, 18)
        Me.lblRSrepairdetail.TabIndex = 54
        Me.lblRSrepairdetail.Text = "รายละเอียดการซ่อม"
        '
        'lblRSvaruntee
        '
        Me.lblRSvaruntee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRSvaruntee.AutoSize = True
        Me.lblRSvaruntee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRSvaruntee.ForeColor = System.Drawing.Color.Black
        Me.lblRSvaruntee.Location = New System.Drawing.Point(715, 282)
        Me.lblRSvaruntee.Name = "lblRSvaruntee"
        Me.lblRSvaruntee.Size = New System.Drawing.Size(64, 18)
        Me.lblRSvaruntee.TabIndex = 52
        Me.lblRSvaruntee.Text = "รับประกัน"
        '
        'cbbRSvaruntee
        '
        Me.cbbRSvaruntee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbRSvaruntee.FormattingEnabled = True
        Me.cbbRSvaruntee.Location = New System.Drawing.Point(785, 283)
        Me.cbbRSvaruntee.Name = "cbbRSvaruntee"
        Me.cbbRSvaruntee.Size = New System.Drawing.Size(121, 21)
        Me.cbbRSvaruntee.TabIndex = 51
        Me.ToolTipRS.SetToolTip(Me.cbbRSvaruntee, "เลือกการรับประกันหลังการซ่อม")
        '
        'cbbRSuser_repair
        '
        Me.cbbRSuser_repair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbRSuser_repair.FormattingEnabled = True
        Me.cbbRSuser_repair.Location = New System.Drawing.Point(785, 337)
        Me.cbbRSuser_repair.Name = "cbbRSuser_repair"
        Me.cbbRSuser_repair.Size = New System.Drawing.Size(121, 21)
        Me.cbbRSuser_repair.TabIndex = 43
        Me.ToolTipRS.SetToolTip(Me.cbbRSuser_repair, "ระบุช่างผู้ซ่อม")
        '
        'lblRSfixstatus
        '
        Me.lblRSfixstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRSfixstatus.AutoSize = True
        Me.lblRSfixstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRSfixstatus.ForeColor = System.Drawing.Color.Black
        Me.lblRSfixstatus.Location = New System.Drawing.Point(733, 312)
        Me.lblRSfixstatus.Name = "lblRSfixstatus"
        Me.lblRSfixstatus.Size = New System.Drawing.Size(46, 18)
        Me.lblRSfixstatus.TabIndex = 42
        Me.lblRSfixstatus.Text = "สถานะ"
        '
        'cbbRSstatus
        '
        Me.cbbRSstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbRSstatus.FormattingEnabled = True
        Me.cbbRSstatus.Location = New System.Drawing.Point(785, 310)
        Me.cbbRSstatus.Name = "cbbRSstatus"
        Me.cbbRSstatus.Size = New System.Drawing.Size(121, 21)
        Me.cbbRSstatus.TabIndex = 41
        Me.ToolTipRS.SetToolTip(Me.cbbRSstatus, "กรุณาระบุสถานะให้ตรงตามจริงเพื่อง่ายกับการตรวจเช็คงานซ่อม")
        '
        'txtRSnote_repair
        '
        Me.txtRSnote_repair.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRSnote_repair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRSnote_repair.Location = New System.Drawing.Point(540, 307)
        Me.txtRSnote_repair.Multiline = True
        Me.txtRSnote_repair.Name = "txtRSnote_repair"
        Me.txtRSnote_repair.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRSnote_repair.Size = New System.Drawing.Size(174, 104)
        Me.txtRSnote_repair.TabIndex = 53
        Me.txtRSnote_repair.Text = "-"
        Me.ToolTipRS.SetToolTip(Me.txtRSnote_repair, "ระบุรายละเอียดการซ่อม สาเหตุการเสีย ฯลฯ")
        '
        'lblStatusText
        '
        Me.lblStatusText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatusText.AutoSize = True
        Me.lblStatusText.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblStatusText.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblStatusText.Location = New System.Drawing.Point(12, 262)
        Me.lblStatusText.Name = "lblStatusText"
        Me.lblStatusText.Size = New System.Drawing.Size(94, 33)
        Me.lblStatusText.TabIndex = 72
        Me.lblStatusText.Text = "สถานะ"
        '
        'lblRSsaleDetail
        '
        Me.lblRSsaleDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRSsaleDetail.AutoSize = True
        Me.lblRSsaleDetail.Location = New System.Drawing.Point(215, 298)
        Me.lblRSsaleDetail.Name = "lblRSsaleDetail"
        Me.lblRSsaleDetail.Size = New System.Drawing.Size(58, 13)
        Me.lblRSsaleDetail.TabIndex = 73
        Me.lblRSsaleDetail.Text = "Sale Detail"
        '
        'ToolTipRS
        '
        Me.ToolTipRS.AutoPopDelay = 5000
        Me.ToolTipRS.InitialDelay = 300
        Me.ToolTipRS.ReshowDelay = 300
        '
        'btnRSviewProduct
        '
        Me.btnRSviewProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRSviewProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRSviewProduct.Location = New System.Drawing.Point(446, 416)
        Me.btnRSviewProduct.Name = "btnRSviewProduct"
        Me.btnRSviewProduct.Size = New System.Drawing.Size(94, 32)
        Me.btnRSviewProduct.TabIndex = 74
        Me.btnRSviewProduct.Text = "ดูรายการอะไหล่"
        Me.ToolTipRS.SetToolTip(Me.btnRSviewProduct, "ดูรายละเอียดสินค้าที่เบิกมา")
        Me.btnRSviewProduct.UseVisualStyleBackColor = True
        '
        'btnRSsend_to_claims
        '
        Me.btnRSsend_to_claims.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRSsend_to_claims.Enabled = False
        Me.btnRSsend_to_claims.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRSsend_to_claims.Location = New System.Drawing.Point(215, 416)
        Me.btnRSsend_to_claims.Name = "btnRSsend_to_claims"
        Me.btnRSsend_to_claims.Size = New System.Drawing.Size(97, 32)
        Me.btnRSsend_to_claims.TabIndex = 75
        Me.btnRSsend_to_claims.Text = "ส่งกลับงานเคลม"
        Me.ToolTipRS.SetToolTip(Me.btnRSsend_to_claims, "ส่งงานเคลมที่ซ่อมเสร็จกลับสู่ระบบเคลม")
        Me.btnRSsend_to_claims.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.ServiceTicker.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(695, 286)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        Me.ToolTipRS.SetToolTip(Me.PictureBox1, "เลือกรายการรายเอียดการซ่อม")
        '
        'btnSRsendRepair
        '
        Me.btnSRsendRepair.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSRsendRepair.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSRsendRepair.Location = New System.Drawing.Point(546, 416)
        Me.btnSRsendRepair.Name = "btnSRsendRepair"
        Me.btnSRsendRepair.Size = New System.Drawing.Size(114, 32)
        Me.btnSRsendRepair.TabIndex = 81
        Me.btnSRsendRepair.Text = "ส่งคืนงานซ่อม"
        Me.ToolTipRS.SetToolTip(Me.btnSRsendRepair, "ดูรายละเอียดสินค้าที่เบิกมา")
        Me.btnSRsendRepair.UseVisualStyleBackColor = True
        Me.btnSRsendRepair.Visible = False
        '
        'llblRStechnician
        '
        Me.llblRStechnician.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblRStechnician.AutoSize = True
        Me.llblRStechnician.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblRStechnician.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.llblRStechnician.LinkColor = System.Drawing.Color.Black
        Me.llblRStechnician.Location = New System.Drawing.Point(725, 336)
        Me.llblRStechnician.Name = "llblRStechnician"
        Me.llblRStechnician.Size = New System.Drawing.Size(54, 18)
        Me.llblRStechnician.TabIndex = 82
        Me.llblRStechnician.TabStop = True
        Me.llblRStechnician.Text = "ช่างซ่อม"
        Me.ToolTipRS.SetToolTip(Me.llblRStechnician, "เพิ่มผู้ใช้งาน")
        '
        'llblRSshelf
        '
        Me.llblRSshelf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblRSshelf.AutoSize = True
        Me.llblRSshelf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblRSshelf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.llblRSshelf.LinkColor = System.Drawing.Color.Black
        Me.llblRSshelf.Location = New System.Drawing.Point(741, 390)
        Me.llblRSshelf.Name = "llblRSshelf"
        Me.llblRSshelf.Size = New System.Drawing.Size(38, 18)
        Me.llblRSshelf.TabIndex = 83
        Me.llblRSshelf.TabStop = True
        Me.llblRSshelf.Text = "ที่เก็บ"
        Me.ToolTipRS.SetToolTip(Me.llblRSshelf, "เพิ่มชั้นวาง ที่เก็บ")
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(598, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(317, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "ดับเบิ้ลคลิ๊กที่รายชื่อเครื่องซ่อมเพื่อทำการเปลี่ยนแปลงข้อมูลงานซ่อม"
        '
        'lblRSclaims
        '
        Me.lblRSclaims.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRSclaims.AutoSize = True
        Me.lblRSclaims.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRSclaims.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblRSclaims.Location = New System.Drawing.Point(215, 388)
        Me.lblRSclaims.Name = "lblRSclaims"
        Me.lblRSclaims.Size = New System.Drawing.Size(0, 25)
        Me.lblRSclaims.TabIndex = 79
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'cbbRSstorage
        '
        Me.cbbRSstorage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbRSstorage.FormattingEnabled = True
        Me.cbbRSstorage.Location = New System.Drawing.Point(785, 390)
        Me.cbbRSstorage.Name = "cbbRSstorage"
        Me.cbbRSstorage.Size = New System.Drawing.Size(121, 21)
        Me.cbbRSstorage.TabIndex = 84
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 437)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 85
        Me.lblemployee.Text = "User"
        '
        'RepairStatusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 462)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.cbbRSstorage)
        Me.Controls.Add(Me.llblRSshelf)
        Me.Controls.Add(Me.llblRStechnician)
        Me.Controls.Add(Me.btnSRsendRepair)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblRSclaims)
        Me.Controls.Add(Me.btnRSstatus1)
        Me.Controls.Add(Me.btnRSstatus2)
        Me.Controls.Add(Me.btnRSstatus3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRSstatus4)
        Me.Controls.Add(Me.btnRSstatus5)
        Me.Controls.Add(Me.btnRSstatus6)
        Me.Controls.Add(Me.btnRSsend_to_claims)
        Me.Controls.Add(Me.btnRSstatus7)
        Me.Controls.Add(Me.btnRSviewProduct)
        Me.Controls.Add(Me.lblRSsaleDetail)
        Me.Controls.Add(Me.lblStatusText)
        Me.Controls.Add(Me.btnRSPartsWithdrawal)
        Me.Controls.Add(Me.dgRSstatus1)
        Me.Controls.Add(Me.lblRSteltocus)
        Me.Controls.Add(Me.cbbRSteltocus)
        Me.Controls.Add(Me.gbRSdetailIDedit)
        Me.Controls.Add(Me.btnRSclose)
        Me.Controls.Add(Me.btnRSsave)
        Me.Controls.Add(Me.lblRSrepairdetail)
        Me.Controls.Add(Me.txtRSnote_repair)
        Me.Controls.Add(Me.lblRSvaruntee)
        Me.Controls.Add(Me.cbbRSvaruntee)
        Me.Controls.Add(Me.cbbRSuser_repair)
        Me.Controls.Add(Me.lblRSfixstatus)
        Me.Controls.Add(Me.cbbRSstatus)
        Me.Name = "RepairStatusFrm"
        Me.Text = "สถานะงานซ่อม"
        CType(Me.dgRSstatus1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRSdetailIDedit.ResumeLayout(False)
        Me.gbRSdetailIDedit.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRSPartsWithdrawal As System.Windows.Forms.Button
    Friend WithEvents btnRSstatus1 As System.Windows.Forms.Button
    Friend WithEvents btnRSstatus2 As System.Windows.Forms.Button
    Friend WithEvents btnRSstatus3 As System.Windows.Forms.Button
    Friend WithEvents btnRSstatus4 As System.Windows.Forms.Button
    Friend WithEvents btnRSstatus5 As System.Windows.Forms.Button
    Friend WithEvents btnRSstatus6 As System.Windows.Forms.Button
    Friend WithEvents btnRSstatus7 As System.Windows.Forms.Button
    Friend WithEvents dgRSstatus1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblRSteltocus As System.Windows.Forms.Label
    Friend WithEvents cbbRSteltocus As System.Windows.Forms.ComboBox
    Friend WithEvents gbRSdetailIDedit As System.Windows.Forms.GroupBox
    Friend WithEvents lblRScusName As System.Windows.Forms.Label
    Friend WithEvents lblRSfix_id As System.Windows.Forms.Label
    Friend WithEvents btnRSclose As System.Windows.Forms.Button
    Friend WithEvents btnRSsave As System.Windows.Forms.Button
    Friend WithEvents lblRSrepairdetail As System.Windows.Forms.Label
    Friend WithEvents lblRSvaruntee As System.Windows.Forms.Label
    Friend WithEvents cbbRSvaruntee As System.Windows.Forms.ComboBox
    Friend WithEvents cbbRSuser_repair As System.Windows.Forms.ComboBox
    Friend WithEvents lblRSfixstatus As System.Windows.Forms.Label
    Friend WithEvents cbbRSstatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtRSnote_repair As System.Windows.Forms.TextBox
    Friend WithEvents lblStatusText As System.Windows.Forms.Label
    Friend WithEvents lblRSsaleDetail As System.Windows.Forms.Label
    Friend WithEvents ToolTipRS As System.Windows.Forms.ToolTip
    Friend WithEvents btnRSviewProduct As System.Windows.Forms.Button
    Friend WithEvents btnRSsend_to_claims As System.Windows.Forms.Button
    Friend WithEvents txtRScus_tel As System.Windows.Forms.TextBox
    Friend WithEvents txtRScus_name As System.Windows.Forms.TextBox
    Friend WithEvents txtRScus_id As System.Windows.Forms.TextBox
    Friend WithEvents txtRSfix_id As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_idS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datatime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_idS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_nameS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents snS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptomS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents managerdataS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixrepairnoteS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixaccessoryS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixnoteS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixpriceS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_getS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixuserS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents statusS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_repairS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note_repairS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents teltocusS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datecom_repair As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importuneS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents storageS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents varuntee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRSclaims As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSRsendRepair As System.Windows.Forms.Button
    Friend WithEvents llblRStechnician As System.Windows.Forms.LinkLabel
    Friend WithEvents llblRSshelf As System.Windows.Forms.LinkLabel
    Friend WithEvents cbbRSstorage As System.Windows.Forms.ComboBox
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
