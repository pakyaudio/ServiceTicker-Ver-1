<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SNFrm
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
        Me.lblSNNote = New System.Windows.Forms.Label()
        Me.btnSNGetdataall = New System.Windows.Forms.Button()
        Me.btnSNSendToSDF = New System.Windows.Forms.Button()
        Me.dgSN = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Snum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.startdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSNSearch = New System.Windows.Forms.Button()
        Me.txtSNSearch = New System.Windows.Forms.TextBox()
        Me.cbbP_Name = New System.Windows.Forms.ComboBox()
        Me.lblSN = New System.Windows.Forms.Label()
        Me.cbbP_Type = New System.Windows.Forms.ComboBox()
        Me.txtSNNumber = New System.Windows.Forms.TextBox()
        Me.btnSNCancel = New System.Windows.Forms.Button()
        Me.btnSNDel = New System.Windows.Forms.Button()
        Me.btnSNEdit = New System.Windows.Forms.Button()
        Me.btnSNAdd = New System.Windows.Forms.Button()
        Me.ToolTipSN = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbSNautoSN = New System.Windows.Forms.CheckBox()
        Me.cbbP_model = New System.Windows.Forms.ComboBox()
        Me.cbbP_color = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblSNType = New MetroControls.MetroLabel()
        Me.lblSNname = New MetroControls.MetroLabel()
        Me.lblSNmodel = New MetroControls.MetroLabel()
        Me.lblSNcolor = New MetroControls.MetroLabel()
        Me.lblSNcCN = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgSN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSNNote
        '
        Me.lblSNNote.AutoSize = True
        Me.lblSNNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSNNote.ForeColor = System.Drawing.Color.DarkRed
        Me.lblSNNote.Location = New System.Drawing.Point(8, 114)
        Me.lblSNNote.Name = "lblSNNote"
        Me.lblSNNote.Size = New System.Drawing.Size(402, 20)
        Me.lblSNNote.TabIndex = 42
        Me.lblSNNote.Text = "* ดับเบิ๊ลคลิ๊กเพื่อเลือกข้อมูลมาแก้ไขหรือคลิ๊กเลือกแล้วกดลบข้อมูล"
        '
        'btnSNGetdataall
        '
        Me.btnSNGetdataall.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSNGetdataall.Location = New System.Drawing.Point(414, 96)
        Me.btnSNGetdataall.Name = "btnSNGetdataall"
        Me.btnSNGetdataall.Size = New System.Drawing.Size(167, 38)
        Me.btnSNGetdataall.TabIndex = 41
        Me.btnSNGetdataall.Text = "แสดงทั้งหมด"
        Me.btnSNGetdataall.UseVisualStyleBackColor = True
        '
        'btnSNSendToSDF
        '
        Me.btnSNSendToSDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSNSendToSDF.ForeColor = System.Drawing.Color.Maroon
        Me.btnSNSendToSDF.Location = New System.Drawing.Point(237, 494)
        Me.btnSNSendToSDF.Name = "btnSNSendToSDF"
        Me.btnSNSendToSDF.Size = New System.Drawing.Size(352, 33)
        Me.btnSNSendToSDF.TabIndex = 40
        Me.btnSNSendToSDF.Text = "เลือกไปหน้ารับซ่อม"
        Me.btnSNSendToSDF.UseVisualStyleBackColor = True
        '
        'dgSN
        '
        Me.dgSN.AllowUserToAddRows = False
        Me.dgSN.AllowUserToDeleteRows = False
        Me.dgSN.AllowUserToOrderColumns = True
        Me.dgSN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.Snum, Me.p_type, Me.p_name, Me.model, Me.color, Me.startdate})
        Me.dgSN.Location = New System.Drawing.Point(12, 143)
        Me.dgSN.Name = "dgSN"
        Me.dgSN.ReadOnly = True
        Me.dgSN.RowHeadersVisible = False
        Me.dgSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSN.Size = New System.Drawing.Size(577, 345)
        Me.dgSN.TabIndex = 39
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
        Me.no.ToolTipText = "ลำดับ"
        Me.no.Width = 35
        '
        'Snum
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.Snum.DefaultCellStyle = DataGridViewCellStyle2
        Me.Snum.Frozen = True
        Me.Snum.HeaderText = "SN"
        Me.Snum.Name = "Snum"
        Me.Snum.ReadOnly = True
        Me.Snum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Snum.ToolTipText = "หมายเลขประจำเครื่อง"
        '
        'p_type
        '
        Me.p_type.DataPropertyName = "p_type"
        Me.p_type.HeaderText = "ประเภท"
        Me.p_type.Name = "p_type"
        Me.p_type.ReadOnly = True
        Me.p_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.p_type.ToolTipText = "ประเภทสินค้า"
        Me.p_type.Width = 80
        '
        'p_name
        '
        Me.p_name.DataPropertyName = "p_name"
        Me.p_name.HeaderText = "ยี่ห้อ"
        Me.p_name.Name = "p_name"
        Me.p_name.ReadOnly = True
        Me.p_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.p_name.ToolTipText = "ยี่ห้อสินค้า"
        Me.p_name.Width = 80
        '
        'model
        '
        Me.model.DataPropertyName = "model"
        Me.model.HeaderText = "รุ่น"
        Me.model.Name = "model"
        Me.model.ReadOnly = True
        Me.model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.model.ToolTipText = "รุ่นสินค้า"
        '
        'color
        '
        Me.color.DataPropertyName = "color"
        Me.color.HeaderText = "สี"
        Me.color.Name = "color"
        Me.color.ReadOnly = True
        Me.color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.color.ToolTipText = "สีตัวเครื่อง"
        Me.color.Width = 50
        '
        'startdate
        '
        Me.startdate.DataPropertyName = "startdate"
        Me.startdate.HeaderText = "วันที่บันทึก"
        Me.startdate.Name = "startdate"
        Me.startdate.ReadOnly = True
        Me.startdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.startdate.ToolTipText = "วันที่บันทึก"
        '
        'btnSNSearch
        '
        Me.btnSNSearch.Location = New System.Drawing.Point(4, 11)
        Me.btnSNSearch.Name = "btnSNSearch"
        Me.btnSNSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSNSearch.TabIndex = 38
        Me.btnSNSearch.Text = "&ค้นหา"
        Me.btnSNSearch.UseVisualStyleBackColor = True
        '
        'txtSNSearch
        '
        Me.txtSNSearch.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSNSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSNSearch.Location = New System.Drawing.Point(85, 13)
        Me.txtSNSearch.Name = "txtSNSearch"
        Me.txtSNSearch.Size = New System.Drawing.Size(171, 20)
        Me.txtSNSearch.TabIndex = 37
        Me.ToolTipSN.SetToolTip(Me.txtSNSearch, "ค้นหาก่อนทำการเพิ่ม")
        '
        'cbbP_Name
        '
        Me.cbbP_Name.BackColor = System.Drawing.Color.LemonChiffon
        Me.cbbP_Name.FormattingEnabled = True
        Me.cbbP_Name.Location = New System.Drawing.Point(246, 56)
        Me.cbbP_Name.Name = "cbbP_Name"
        Me.cbbP_Name.Size = New System.Drawing.Size(121, 21)
        Me.cbbP_Name.TabIndex = 33
        '
        'lblSN
        '
        Me.lblSN.AutoSize = True
        Me.lblSN.Location = New System.Drawing.Point(9, 40)
        Me.lblSN.Name = "lblSN"
        Me.lblSN.Size = New System.Drawing.Size(70, 13)
        Me.lblSN.TabIndex = 31
        Me.lblSN.Text = "รหัสสินค้า SN"
        '
        'cbbP_Type
        '
        Me.cbbP_Type.BackColor = System.Drawing.Color.LemonChiffon
        Me.cbbP_Type.FormattingEnabled = True
        Me.cbbP_Type.Location = New System.Drawing.Point(119, 56)
        Me.cbbP_Type.Name = "cbbP_Type"
        Me.cbbP_Type.Size = New System.Drawing.Size(121, 21)
        Me.cbbP_Type.TabIndex = 30
        '
        'txtSNNumber
        '
        Me.txtSNNumber.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSNNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSNNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSNNumber.ForeColor = System.Drawing.Color.Black
        Me.txtSNNumber.Location = New System.Drawing.Point(12, 56)
        Me.txtSNNumber.Name = "txtSNNumber"
        Me.txtSNNumber.Size = New System.Drawing.Size(100, 21)
        Me.txtSNNumber.TabIndex = 27
        Me.ToolTipSN.SetToolTip(Me.txtSNNumber, "ใช้รหัสที่ทำเองหรือที่ติดตัวเครื่องอยู่แล้ว ที่ไม่หลุดลอกง่าย")
        '
        'btnSNCancel
        '
        Me.btnSNCancel.Location = New System.Drawing.Point(506, 10)
        Me.btnSNCancel.Name = "btnSNCancel"
        Me.btnSNCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnSNCancel.TabIndex = 26
        Me.btnSNCancel.Text = "&ปิด"
        Me.btnSNCancel.UseVisualStyleBackColor = True
        '
        'btnSNDel
        '
        Me.btnSNDel.Location = New System.Drawing.Point(425, 10)
        Me.btnSNDel.Name = "btnSNDel"
        Me.btnSNDel.Size = New System.Drawing.Size(75, 23)
        Me.btnSNDel.TabIndex = 25
        Me.btnSNDel.Text = "&ลบ"
        Me.btnSNDel.UseVisualStyleBackColor = True
        '
        'btnSNEdit
        '
        Me.btnSNEdit.Location = New System.Drawing.Point(344, 11)
        Me.btnSNEdit.Name = "btnSNEdit"
        Me.btnSNEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnSNEdit.TabIndex = 24
        Me.btnSNEdit.Text = "&แก้ไข"
        Me.btnSNEdit.UseVisualStyleBackColor = True
        '
        'btnSNAdd
        '
        Me.btnSNAdd.Location = New System.Drawing.Point(263, 11)
        Me.btnSNAdd.Name = "btnSNAdd"
        Me.btnSNAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnSNAdd.TabIndex = 23
        Me.btnSNAdd.Text = "&เพิ่ม"
        Me.btnSNAdd.UseVisualStyleBackColor = True
        '
        'ToolTipSN
        '
        Me.ToolTipSN.AutoPopDelay = 5000
        Me.ToolTipSN.InitialDelay = 300
        Me.ToolTipSN.IsBalloon = True
        Me.ToolTipSN.ReshowDelay = 300
        '
        'cbSNautoSN
        '
        Me.cbSNautoSN.AutoSize = True
        Me.cbSNautoSN.Location = New System.Drawing.Point(12, 96)
        Me.cbSNautoSN.Name = "cbSNautoSN"
        Me.cbSNautoSN.Size = New System.Drawing.Size(66, 17)
        Me.cbSNautoSN.TabIndex = 43
        Me.cbSNautoSN.Text = "สร้าง SN"
        Me.cbSNautoSN.UseVisualStyleBackColor = True
        '
        'cbbP_model
        '
        Me.cbbP_model.BackColor = System.Drawing.Color.LemonChiffon
        Me.cbbP_model.FormattingEnabled = True
        Me.cbbP_model.Location = New System.Drawing.Point(373, 56)
        Me.cbbP_model.Name = "cbbP_model"
        Me.cbbP_model.Size = New System.Drawing.Size(107, 21)
        Me.cbbP_model.TabIndex = 44
        '
        'cbbP_color
        '
        Me.cbbP_color.BackColor = System.Drawing.Color.LemonChiffon
        Me.cbbP_color.FormattingEnabled = True
        Me.cbbP_color.Location = New System.Drawing.Point(486, 56)
        Me.cbbP_color.Name = "cbbP_color"
        Me.cbbP_color.Size = New System.Drawing.Size(95, 21)
        Me.cbbP_color.TabIndex = 45
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'Timer2
        '
        '
        'lblSNType
        '
        Me.lblSNType.AutoSize = True
        Me.lblSNType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSNType.ForeColor = System.Drawing.Color.Black
        Me.lblSNType.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lblSNType.ForeColorNormal = System.Drawing.Color.Black
        Me.lblSNType.Location = New System.Drawing.Point(122, 39)
        Me.lblSNType.Name = "lblSNType"
        Me.lblSNType.Size = New System.Drawing.Size(65, 15)
        Me.lblSNType.TabIndex = 46
        Me.lblSNType.Text = "ประเภทสินค้า"
        Me.lblSNType.UseHoverMode = True
        '
        'lblSNname
        '
        Me.lblSNname.AutoSize = True
        Me.lblSNname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSNname.ForeColor = System.Drawing.Color.Black
        Me.lblSNname.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lblSNname.ForeColorNormal = System.Drawing.Color.Black
        Me.lblSNname.Location = New System.Drawing.Point(249, 39)
        Me.lblSNname.Name = "lblSNname"
        Me.lblSNname.Size = New System.Drawing.Size(26, 15)
        Me.lblSNname.TabIndex = 47
        Me.lblSNname.Text = "ยี่ห้อ"
        Me.lblSNname.UseHoverMode = True
        '
        'lblSNmodel
        '
        Me.lblSNmodel.AutoSize = True
        Me.lblSNmodel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSNmodel.ForeColor = System.Drawing.Color.Black
        Me.lblSNmodel.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lblSNmodel.ForeColorNormal = System.Drawing.Color.Black
        Me.lblSNmodel.Location = New System.Drawing.Point(376, 39)
        Me.lblSNmodel.Name = "lblSNmodel"
        Me.lblSNmodel.Size = New System.Drawing.Size(19, 15)
        Me.lblSNmodel.TabIndex = 48
        Me.lblSNmodel.Text = "รุ่น"
        Me.lblSNmodel.UseHoverMode = False
        '
        'lblSNcolor
        '
        Me.lblSNcolor.AutoSize = True
        Me.lblSNcolor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSNcolor.ForeColor = System.Drawing.Color.Black
        Me.lblSNcolor.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.lblSNcolor.ForeColorNormal = System.Drawing.Color.Black
        Me.lblSNcolor.Location = New System.Drawing.Point(489, 39)
        Me.lblSNcolor.Name = "lblSNcolor"
        Me.lblSNcolor.Size = New System.Drawing.Size(13, 15)
        Me.lblSNcolor.TabIndex = 49
        Me.lblSNcolor.Text = "สี"
        Me.lblSNcolor.UseHoverMode = True
        '
        'lblSNcCN
        '
        Me.lblSNcCN.AutoSize = True
        Me.lblSNcCN.Location = New System.Drawing.Point(12, 80)
        Me.lblSNcCN.Name = "lblSNcCN"
        Me.lblSNcCN.Size = New System.Drawing.Size(56, 13)
        Me.lblSNcCN.TabIndex = 50
        Me.lblSNcCN.Text = "Check SN"
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 513)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 51
        Me.lblemployee.Text = "User"
        '
        'SNFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 539)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.lblSNcCN)
        Me.Controls.Add(Me.lblSNcolor)
        Me.Controls.Add(Me.lblSNmodel)
        Me.Controls.Add(Me.lblSNname)
        Me.Controls.Add(Me.lblSNType)
        Me.Controls.Add(Me.cbbP_color)
        Me.Controls.Add(Me.cbbP_model)
        Me.Controls.Add(Me.cbSNautoSN)
        Me.Controls.Add(Me.lblSNNote)
        Me.Controls.Add(Me.btnSNGetdataall)
        Me.Controls.Add(Me.btnSNSendToSDF)
        Me.Controls.Add(Me.dgSN)
        Me.Controls.Add(Me.btnSNSearch)
        Me.Controls.Add(Me.txtSNSearch)
        Me.Controls.Add(Me.cbbP_Name)
        Me.Controls.Add(Me.lblSN)
        Me.Controls.Add(Me.cbbP_Type)
        Me.Controls.Add(Me.txtSNNumber)
        Me.Controls.Add(Me.btnSNCancel)
        Me.Controls.Add(Me.btnSNDel)
        Me.Controls.Add(Me.btnSNEdit)
        Me.Controls.Add(Me.btnSNAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SNFrm"
        Me.Text = "รหัสตัวเครื่อง SN"
        CType(Me.dgSN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSNNote As System.Windows.Forms.Label
    Friend WithEvents btnSNGetdataall As System.Windows.Forms.Button
    Friend WithEvents btnSNSendToSDF As System.Windows.Forms.Button
    Friend WithEvents dgSN As System.Windows.Forms.DataGridView
    Friend WithEvents btnSNSearch As System.Windows.Forms.Button
    Friend WithEvents txtSNSearch As System.Windows.Forms.TextBox
    Friend WithEvents cbbP_Name As System.Windows.Forms.ComboBox
    Friend WithEvents lblSN As System.Windows.Forms.Label
    Friend WithEvents cbbP_Type As System.Windows.Forms.ComboBox
    Friend WithEvents txtSNNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnSNCancel As System.Windows.Forms.Button
    Friend WithEvents btnSNDel As System.Windows.Forms.Button
    Friend WithEvents btnSNEdit As System.Windows.Forms.Button
    Friend WithEvents btnSNAdd As System.Windows.Forms.Button
    Friend WithEvents ToolTipSN As System.Windows.Forms.ToolTip
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Snum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents startdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbSNautoSN As System.Windows.Forms.CheckBox
    Friend WithEvents cbbP_model As System.Windows.Forms.ComboBox
    Friend WithEvents cbbP_color As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblSNType As MetroControls.MetroLabel
    Friend WithEvents lblSNname As MetroControls.MetroLabel
    Friend WithEvents lblSNmodel As MetroControls.MetroLabel
    Friend WithEvents lblSNcolor As MetroControls.MetroLabel
    Friend WithEvents lblSNcCN As System.Windows.Forms.Label
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
