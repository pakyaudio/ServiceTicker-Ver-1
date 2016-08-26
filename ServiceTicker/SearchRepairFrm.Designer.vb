<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchRepairFrm
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
        Me.txtSRsearch = New System.Windows.Forms.TextBox()
        Me.btnSRsearch = New System.Windows.Forms.Button()
        Me.dgSRshowComfix = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.managerdata = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_get = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note_repair = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.teltocus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTipSR = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtSRcustomerID = New System.Windows.Forms.TextBox()
        Me.txtSRcustomerDetail = New System.Windows.Forms.TextBox()
        Me.txtSRfixSN = New System.Windows.Forms.TextBox()
        Me.txtSRfixSNdetail = New System.Windows.Forms.TextBox()
        Me.txtSRfix_id = New System.Windows.Forms.TextBox()
        Me.txtSRfix_idDetail = New System.Windows.Forms.TextBox()
        Me.txtSRfixStatus = New System.Windows.Forms.TextBox()
        Me.btnSRsearchAll = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbbSRsearchAll = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtRSsaleDetail = New System.Windows.Forms.TextBox()
        Me.txtSRreturnDetail = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgSRshowComfix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSRsearch
        '
        Me.txtSRsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRsearch.Location = New System.Drawing.Point(12, 12)
        Me.txtSRsearch.Name = "txtSRsearch"
        Me.txtSRsearch.Size = New System.Drawing.Size(312, 26)
        Me.txtSRsearch.TabIndex = 0
        Me.ToolTipSR.SetToolTip(Me.txtSRsearch, "ค้นหางานซ่อม ใส่คำค้นหา เช่น ชื่อ ที่อยู่ เบอร์โทร หมายเลขซ่อม ยี่ห้อเครื่อง เป็น" & _
        "ต้น ")
        '
        'btnSRsearch
        '
        Me.btnSRsearch.Location = New System.Drawing.Point(330, 15)
        Me.btnSRsearch.Name = "btnSRsearch"
        Me.btnSRsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSRsearch.TabIndex = 1
        Me.btnSRsearch.Text = "ค้นหา"
        Me.btnSRsearch.UseVisualStyleBackColor = True
        '
        'dgSRshowComfix
        '
        Me.dgSRshowComfix.AllowUserToAddRows = False
        Me.dgSRshowComfix.AllowUserToDeleteRows = False
        Me.dgSRshowComfix.AllowUserToOrderColumns = True
        Me.dgSRshowComfix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgSRshowComfix.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSRshowComfix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSRshowComfix.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.fix_id, Me.customer_id, Me.customer_name, Me.SN, Me.symptom, Me.managerdata, Me.date_save, Me.date_get, Me.status, Me.note_repair, Me.teltocus})
        Me.dgSRshowComfix.Location = New System.Drawing.Point(12, 44)
        Me.dgSRshowComfix.Name = "dgSRshowComfix"
        Me.dgSRshowComfix.ReadOnly = True
        Me.dgSRshowComfix.RowHeadersVisible = False
        Me.dgSRshowComfix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSRshowComfix.Size = New System.Drawing.Size(929, 200)
        Me.dgSRshowComfix.TabIndex = 3
        Me.ToolTipSR.SetToolTip(Me.dgSRshowComfix, "ดับเบิ๊ลคลิ๊กเพื่อดูรายละเอียด")
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.no.DefaultCellStyle = DataGridViewCellStyle1
        Me.no.Frozen = True
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'fix_id
        '
        Me.fix_id.DataPropertyName = "fix_id"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.fix_id.DefaultCellStyle = DataGridViewCellStyle2
        Me.fix_id.Frozen = True
        Me.fix_id.HeaderText = "หมายเลขใบซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.ReadOnly = True
        Me.fix_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fix_id.Width = 120
        '
        'customer_id
        '
        Me.customer_id.DataPropertyName = "customer_id"
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_id.Width = 120
        '
        'customer_name
        '
        Me.customer_name.DataPropertyName = "customer_name"
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SN
        '
        Me.SN.DataPropertyName = "SN"
        Me.SN.HeaderText = "หมายเลขเครื่อง"
        Me.SN.Name = "SN"
        Me.SN.ReadOnly = True
        Me.SN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'symptom
        '
        Me.symptom.DataPropertyName = "symptom"
        Me.symptom.HeaderText = "อาการเสีย"
        Me.symptom.Name = "symptom"
        Me.symptom.ReadOnly = True
        Me.symptom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'managerdata
        '
        Me.managerdata.DataPropertyName = "managerdata"
        Me.managerdata.HeaderText = "การจัดการข้อมูล"
        Me.managerdata.Name = "managerdata"
        Me.managerdata.ReadOnly = True
        Me.managerdata.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_save
        '
        Me.date_save.DataPropertyName = "date_save"
        Me.date_save.HeaderText = "วันที่รับเครื่อง"
        Me.date_save.Name = "date_save"
        Me.date_save.ReadOnly = True
        Me.date_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_get
        '
        Me.date_get.DataPropertyName = "date_get"
        Me.date_get.HeaderText = "นัดรับ"
        Me.date_get.Name = "date_get"
        Me.date_get.ReadOnly = True
        Me.date_get.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_get.ToolTipText = "วันที่นัดรับเครื่องซ่อม"
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.status.Width = 70
        '
        'note_repair
        '
        Me.note_repair.DataPropertyName = "note_repair"
        Me.note_repair.HeaderText = "รายละเอียด"
        Me.note_repair.Name = "note_repair"
        Me.note_repair.ReadOnly = True
        Me.note_repair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.note_repair.ToolTipText = "รายละเอียดที่ช่างได้ซ่อมอะไรไปบ้าง"
        '
        'teltocus
        '
        Me.teltocus.DataPropertyName = "teltocus"
        Me.teltocus.HeaderText = "โทรแจ้ง"
        Me.teltocus.Name = "teltocus"
        Me.teltocus.ReadOnly = True
        Me.teltocus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.teltocus.ToolTipText = "สถานะการโทรแจ้งลูกค้าให้ทราบ"
        Me.teltocus.Width = 80
        '
        'txtSRcustomerID
        '
        Me.txtSRcustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRcustomerID.Location = New System.Drawing.Point(12, 250)
        Me.txtSRcustomerID.Name = "txtSRcustomerID"
        Me.txtSRcustomerID.ReadOnly = True
        Me.txtSRcustomerID.Size = New System.Drawing.Size(154, 26)
        Me.txtSRcustomerID.TabIndex = 4
        Me.ToolTipSR.SetToolTip(Me.txtSRcustomerID, "รหัสลูกค้า")
        '
        'txtSRcustomerDetail
        '
        Me.txtSRcustomerDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSRcustomerDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRcustomerDetail.Location = New System.Drawing.Point(172, 250)
        Me.txtSRcustomerDetail.Name = "txtSRcustomerDetail"
        Me.txtSRcustomerDetail.ReadOnly = True
        Me.txtSRcustomerDetail.Size = New System.Drawing.Size(769, 26)
        Me.txtSRcustomerDetail.TabIndex = 5
        Me.ToolTipSR.SetToolTip(Me.txtSRcustomerDetail, "รายละเอียดข้อมูลลูกค้า")
        '
        'txtSRfixSN
        '
        Me.txtSRfixSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRfixSN.Location = New System.Drawing.Point(12, 282)
        Me.txtSRfixSN.Name = "txtSRfixSN"
        Me.txtSRfixSN.ReadOnly = True
        Me.txtSRfixSN.Size = New System.Drawing.Size(154, 26)
        Me.txtSRfixSN.TabIndex = 6
        Me.ToolTipSR.SetToolTip(Me.txtSRfixSN, "หมายเลขประจะเครื่อง (SN)")
        '
        'txtSRfixSNdetail
        '
        Me.txtSRfixSNdetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSRfixSNdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRfixSNdetail.Location = New System.Drawing.Point(172, 282)
        Me.txtSRfixSNdetail.Name = "txtSRfixSNdetail"
        Me.txtSRfixSNdetail.ReadOnly = True
        Me.txtSRfixSNdetail.Size = New System.Drawing.Size(769, 26)
        Me.txtSRfixSNdetail.TabIndex = 7
        Me.ToolTipSR.SetToolTip(Me.txtSRfixSNdetail, "รายละเอียดตัวเครื่อง")
        '
        'txtSRfix_id
        '
        Me.txtSRfix_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRfix_id.Location = New System.Drawing.Point(12, 314)
        Me.txtSRfix_id.Name = "txtSRfix_id"
        Me.txtSRfix_id.ReadOnly = True
        Me.txtSRfix_id.Size = New System.Drawing.Size(154, 26)
        Me.txtSRfix_id.TabIndex = 8
        Me.ToolTipSR.SetToolTip(Me.txtSRfix_id, "หมายเลขใบรับซ่อม")
        '
        'txtSRfix_idDetail
        '
        Me.txtSRfix_idDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSRfix_idDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRfix_idDetail.Location = New System.Drawing.Point(172, 314)
        Me.txtSRfix_idDetail.Name = "txtSRfix_idDetail"
        Me.txtSRfix_idDetail.ReadOnly = True
        Me.txtSRfix_idDetail.Size = New System.Drawing.Size(769, 26)
        Me.txtSRfix_idDetail.TabIndex = 9
        Me.ToolTipSR.SetToolTip(Me.txtSRfix_idDetail, "รายละเอียดใบรับซ่อม")
        '
        'txtSRfixStatus
        '
        Me.txtSRfixStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSRfixStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRfixStatus.Location = New System.Drawing.Point(787, 346)
        Me.txtSRfixStatus.Name = "txtSRfixStatus"
        Me.txtSRfixStatus.ReadOnly = True
        Me.txtSRfixStatus.Size = New System.Drawing.Size(154, 26)
        Me.txtSRfixStatus.TabIndex = 19
        Me.ToolTipSR.SetToolTip(Me.txtSRfixStatus, "สถานะงานซ่อม")
        '
        'btnSRsearchAll
        '
        Me.btnSRsearchAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSRsearchAll.Location = New System.Drawing.Point(866, 12)
        Me.btnSRsearchAll.Name = "btnSRsearchAll"
        Me.btnSRsearchAll.Size = New System.Drawing.Size(75, 23)
        Me.btnSRsearchAll.TabIndex = 20
        Me.btnSRsearchAll.Text = "แสดงทั้งหมด"
        Me.ToolTipSR.SetToolTip(Me.btnSRsearchAll, "แสดงทั้งหมดจากรายการที่เลือก")
        Me.btnSRsearchAll.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "รายละเอียดสินค้าที่เบิก"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(486, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "รายละเอียดสินค้าที่คืน"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(655, 506)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(286, 47)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "เลือกไปหน้าส่งคืนสินค้า"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbbSRsearchAll
        '
        Me.cbbSRsearchAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbSRsearchAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbSRsearchAll.FormattingEnabled = True
        Me.cbbSRsearchAll.Location = New System.Drawing.Point(632, 13)
        Me.cbbSRsearchAll.Name = "cbbSRsearchAll"
        Me.cbbSRsearchAll.Size = New System.Drawing.Size(228, 21)
        Me.cbbSRsearchAll.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(12, 506)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "ดูรายการเบิกสินค้า"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtRSsaleDetail
        '
        Me.txtRSsaleDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRSsaleDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRSsaleDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRSsaleDetail.Location = New System.Drawing.Point(12, 378)
        Me.txtRSsaleDetail.Multiline = True
        Me.txtRSsaleDetail.Name = "txtRSsaleDetail"
        Me.txtRSsaleDetail.ReadOnly = True
        Me.txtRSsaleDetail.Size = New System.Drawing.Size(461, 122)
        Me.txtRSsaleDetail.TabIndex = 24
        '
        'txtSRreturnDetail
        '
        Me.txtSRreturnDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSRreturnDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRreturnDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSRreturnDetail.Location = New System.Drawing.Point(490, 378)
        Me.txtSRreturnDetail.Multiline = True
        Me.txtSRreturnDetail.Name = "txtSRreturnDetail"
        Me.txtSRreturnDetail.ReadOnly = True
        Me.txtSRreturnDetail.Size = New System.Drawing.Size(451, 122)
        Me.txtSRreturnDetail.TabIndex = 25
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(490, 506)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 23)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "ดูรายการคืนสินค้า"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 543)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 27
        Me.lblemployee.Text = "User"
        '
        'SearchRepairFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 565)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtSRreturnDetail)
        Me.Controls.Add(Me.txtRSsaleDetail)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cbbSRsearchAll)
        Me.Controls.Add(Me.btnSRsearchAll)
        Me.Controls.Add(Me.txtSRfixStatus)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSRfix_idDetail)
        Me.Controls.Add(Me.txtSRfix_id)
        Me.Controls.Add(Me.txtSRfixSNdetail)
        Me.Controls.Add(Me.txtSRfixSN)
        Me.Controls.Add(Me.txtSRcustomerDetail)
        Me.Controls.Add(Me.txtSRcustomerID)
        Me.Controls.Add(Me.dgSRshowComfix)
        Me.Controls.Add(Me.btnSRsearch)
        Me.Controls.Add(Me.txtSRsearch)
        Me.Name = "SearchRepairFrm"
        Me.Text = "ค้นหางานซ่อม"
        CType(Me.dgSRshowComfix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSRsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSRsearch As System.Windows.Forms.Button
    Friend WithEvents dgSRshowComfix As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTipSR As System.Windows.Forms.ToolTip
    Friend WithEvents txtSRcustomerID As System.Windows.Forms.TextBox
    Friend WithEvents txtSRcustomerDetail As System.Windows.Forms.TextBox
    Friend WithEvents txtSRfixSN As System.Windows.Forms.TextBox
    Friend WithEvents txtSRfixSNdetail As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txtSRfix_id As System.Windows.Forms.TextBox
    Friend WithEvents txtSRfix_idDetail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSRfixStatus As System.Windows.Forms.TextBox
    Friend WithEvents btnSRsearchAll As System.Windows.Forms.Button
    Friend WithEvents cbbSRsearchAll As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtRSsaleDetail As System.Windows.Forms.TextBox
    Friend WithEvents txtSRreturnDetail As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents managerdata As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_get As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note_repair As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents teltocus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
