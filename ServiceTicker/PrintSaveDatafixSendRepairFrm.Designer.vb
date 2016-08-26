<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintSaveDatafixSendRepairFrm
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
        Me.dgPSDF = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_get = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datesend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ptype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.managerd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixrepairnote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixaccessory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixnote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPSDFrefresh = New System.Windows.Forms.Button()
        Me.ToolTipPSDF = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPSDFprint = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgPSDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPSDF
        '
        Me.dgPSDF.AllowUserToAddRows = False
        Me.dgPSDF.AllowUserToDeleteRows = False
        Me.dgPSDF.AllowUserToOrderColumns = True
        Me.dgPSDF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPSDF.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPSDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPSDF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.fix_id, Me.date_get, Me.datesend, Me.customer_id, Me.customer_name, Me.customer_tel, Me.sn, Me.ptype, Me.pname, Me.model, Me.color, Me.symptom, Me.managerd, Me.fixrepairnote, Me.fixaccessory, Me.employee, Me.fixnote, Me.status})
        Me.dgPSDF.Location = New System.Drawing.Point(12, 38)
        Me.dgPSDF.MultiSelect = False
        Me.dgPSDF.Name = "dgPSDF"
        Me.dgPSDF.ReadOnly = True
        Me.dgPSDF.RowHeadersVisible = False
        Me.dgPSDF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPSDF.Size = New System.Drawing.Size(712, 487)
        Me.dgPSDF.TabIndex = 0
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 30
        '
        'fix_id
        '
        Me.fix_id.HeaderText = "หมายเลขใบซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.ReadOnly = True
        Me.fix_id.Width = 120
        '
        'date_get
        '
        Me.date_get.HeaderText = "วันที่รับ"
        Me.date_get.Name = "date_get"
        Me.date_get.ReadOnly = True
        Me.date_get.ToolTipText = "วันทีรับสินค้าเข้าระบบ"
        '
        'datesend
        '
        Me.datesend.HeaderText = "วันที่นัดคืน"
        Me.datesend.Name = "datesend"
        Me.datesend.ReadOnly = True
        Me.datesend.ToolTipText = "วันที่นัดคืนสินค้า"
        '
        'customer_id
        '
        Me.customer_id.HeaderText = "รหัสสมาชิก"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        '
        'customer_name
        '
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        '
        'customer_tel
        '
        Me.customer_tel.HeaderText = "เบอร์โทร"
        Me.customer_tel.Name = "customer_tel"
        Me.customer_tel.ReadOnly = True
        '
        'sn
        '
        Me.sn.HeaderText = "SN"
        Me.sn.Name = "sn"
        Me.sn.ReadOnly = True
        '
        'ptype
        '
        Me.ptype.HeaderText = "ประเภท"
        Me.ptype.Name = "ptype"
        Me.ptype.ReadOnly = True
        '
        'pname
        '
        Me.pname.HeaderText = "ยี่ห้อ"
        Me.pname.Name = "pname"
        Me.pname.ReadOnly = True
        '
        'model
        '
        Me.model.HeaderText = "รุ่น"
        Me.model.Name = "model"
        Me.model.ReadOnly = True
        '
        'color
        '
        Me.color.HeaderText = "สี"
        Me.color.Name = "color"
        Me.color.ReadOnly = True
        '
        'symptom
        '
        Me.symptom.HeaderText = "อาการเสีย"
        Me.symptom.Name = "symptom"
        Me.symptom.ReadOnly = True
        Me.symptom.Width = 150
        '
        'managerd
        '
        Me.managerd.HeaderText = "จัดการข้อมูล"
        Me.managerd.Name = "managerd"
        Me.managerd.ReadOnly = True
        '
        'fixrepairnote
        '
        Me.fixrepairnote.HeaderText = "เพิ่มเติม"
        Me.fixrepairnote.Name = "fixrepairnote"
        Me.fixrepairnote.ReadOnly = True
        '
        'fixaccessory
        '
        Me.fixaccessory.HeaderText = "อุปกรณ์ที่นำมาด้วย"
        Me.fixaccessory.Name = "fixaccessory"
        Me.fixaccessory.ReadOnly = True
        Me.fixaccessory.Width = 150
        '
        'employee
        '
        Me.employee.HeaderText = "พนักงาน"
        Me.employee.Name = "employee"
        Me.employee.ReadOnly = True
        '
        'fixnote
        '
        Me.fixnote.HeaderText = "หมายเหตุ"
        Me.fixnote.Name = "fixnote"
        Me.fixnote.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'btnPSDFrefresh
        '
        Me.btnPSDFrefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPSDFrefresh.Location = New System.Drawing.Point(630, 530)
        Me.btnPSDFrefresh.Name = "btnPSDFrefresh"
        Me.btnPSDFrefresh.Size = New System.Drawing.Size(94, 23)
        Me.btnPSDFrefresh.TabIndex = 1
        Me.btnPSDFrefresh.Text = "Refresh"
        Me.ToolTipPSDF.SetToolTip(Me.btnPSDFrefresh, "โหลดข้อมูลใหม่อีกรอบ")
        Me.btnPSDFrefresh.UseVisualStyleBackColor = True
        '
        'btnPSDFprint
        '
        Me.btnPSDFprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPSDFprint.Location = New System.Drawing.Point(12, 530)
        Me.btnPSDFprint.Name = "btnPSDFprint"
        Me.btnPSDFprint.Size = New System.Drawing.Size(94, 23)
        Me.btnPSDFprint.TabIndex = 2
        Me.btnPSDFprint.Text = "พิมพ์"
        Me.ToolTipPSDF.SetToolTip(Me.btnPSDFprint, "พิมพ์ใบรับซ่อม")
        Me.btnPSDFprint.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(52, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(175, 20)
        Me.txtSearch.TabIndex = 3
        Me.ToolTipPSDF.SetToolTip(Me.txtSearch, "ค้นหา ชื่อ sn อาการเสีย ผู้ซ่อม หมายเหตุ")
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(504, 531)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 5
        Me.ToolTipPSDF.SetToolTip(Me.NumericUpDown1, "ลิมิตการแสดงผล")
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(233, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(48, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "ค้นหา"
        Me.ToolTipPSDF.SetToolTip(Me.btnSearch, "พิมพ์ใบรับซ่อม")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ค้นหา"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(112, 535)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 7
        Me.lblemployee.Text = "User"
        '
        'PrintSaveDatafixSendRepairFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 561)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnPSDFprint)
        Me.Controls.Add(Me.btnPSDFrefresh)
        Me.Controls.Add(Me.dgPSDF)
        Me.Name = "PrintSaveDatafixSendRepairFrm"
        Me.Text = "พิมพ์ใบรับซ่อม/ใบส่งคืนย้อมหลัง"
        CType(Me.dgPSDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgPSDF As System.Windows.Forms.DataGridView
    Friend WithEvents btnPSDFrefresh As System.Windows.Forms.Button
    Friend WithEvents ToolTipPSDF As System.Windows.Forms.ToolTip
    Friend WithEvents btnPSDFprint As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_get As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datesend As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ptype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents managerd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixrepairnote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixaccessory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixnote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
