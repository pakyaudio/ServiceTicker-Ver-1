<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerFrm
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
        Me.lblCustomerSearchNote = New System.Windows.Forms.Label()
        Me.btnCustomerGetall = New System.Windows.Forms.Button()
        Me.btnCustomerSearch = New System.Windows.Forms.Button()
        Me.btnCustomerCancel = New System.Windows.Forms.Button()
        Me.txtCustomerSearch = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.dgCustomerSearch = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tex_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tax_sec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_zip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_leval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cadit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_edit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.txtCustomerZipcode = New System.Windows.Forms.TextBox()
        Me.btnCustomerDel = New System.Windows.Forms.Button()
        Me.lblCustomerZipcode = New System.Windows.Forms.Label()
        Me.txtCustomerTel = New System.Windows.Forms.TextBox()
        Me.btnCustomerEdit = New System.Windows.Forms.Button()
        Me.lblCustomerAddress = New System.Windows.Forms.Label()
        Me.txtCustomerNote = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerTAX = New System.Windows.Forms.TextBox()
        Me.lblCustomerTel = New System.Windows.Forms.Label()
        Me.btnCustomerSave = New System.Windows.Forms.Button()
        Me.lblCustomerTAX = New System.Windows.Forms.Label()
        Me.txtCustomerSection = New System.Windows.Forms.TextBox()
        Me.lblCustomerNote = New System.Windows.Forms.Label()
        Me.lblCustomerSection = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.ToolTipCustomer = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbbCustomerCadit = New System.Windows.Forms.ComboBox()
        Me.lblCusCountNum = New System.Windows.Forms.Label()
        Me.cbbCustomerPrice_level = New System.Windows.Forms.ComboBox()
        Me.lblCUSprice_level = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgCustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCustomerSearchNote
        '
        Me.lblCustomerSearchNote.AutoSize = True
        Me.lblCustomerSearchNote.ForeColor = System.Drawing.Color.Red
        Me.lblCustomerSearchNote.Location = New System.Drawing.Point(11, 237)
        Me.lblCustomerSearchNote.Name = "lblCustomerSearchNote"
        Me.lblCustomerSearchNote.Size = New System.Drawing.Size(165, 13)
        Me.lblCustomerSearchNote.TabIndex = 29
        Me.lblCustomerSearchNote.Text = "* ดับเบิ้ลคลิ๊กตารางเพื่อแก้ไขข้อมูล"
        '
        'btnCustomerGetall
        '
        Me.btnCustomerGetall.Location = New System.Drawing.Point(341, 204)
        Me.btnCustomerGetall.Name = "btnCustomerGetall"
        Me.btnCustomerGetall.Size = New System.Drawing.Size(90, 26)
        Me.btnCustomerGetall.TabIndex = 27
        Me.btnCustomerGetall.Text = "&แสดงทั้งหมด"
        Me.btnCustomerGetall.UseVisualStyleBackColor = True
        '
        'btnCustomerSearch
        '
        Me.btnCustomerSearch.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.search
        Me.btnCustomerSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustomerSearch.Location = New System.Drawing.Point(300, 204)
        Me.btnCustomerSearch.Name = "btnCustomerSearch"
        Me.btnCustomerSearch.Size = New System.Drawing.Size(32, 26)
        Me.btnCustomerSearch.TabIndex = 26
        Me.btnCustomerSearch.UseVisualStyleBackColor = True
        '
        'btnCustomerCancel
        '
        Me.btnCustomerCancel.Location = New System.Drawing.Point(450, 195)
        Me.btnCustomerCancel.Name = "btnCustomerCancel"
        Me.btnCustomerCancel.Size = New System.Drawing.Size(107, 35)
        Me.btnCustomerCancel.TabIndex = 47
        Me.btnCustomerCancel.Text = "&ยกเลิก"
        Me.btnCustomerCancel.UseVisualStyleBackColor = True
        '
        'txtCustomerSearch
        '
        Me.txtCustomerSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCustomerSearch.Location = New System.Drawing.Point(11, 204)
        Me.txtCustomerSearch.Name = "txtCustomerSearch"
        Me.txtCustomerSearch.Size = New System.Drawing.Size(283, 26)
        Me.txtCustomerSearch.TabIndex = 24
        Me.ToolTipCustomer.SetToolTip(Me.txtCustomerSearch, "ค้นหา จาก ชื่อ, ที่อยู่, เบอร์โทร")
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.HideSelection = False
        Me.txtCustomerID.Location = New System.Drawing.Point(109, 11)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(144, 20)
        Me.txtCustomerID.TabIndex = 25
        '
        'dgCustomerSearch
        '
        Me.dgCustomerSearch.AllowUserToAddRows = False
        Me.dgCustomerSearch.AllowUserToDeleteRows = False
        Me.dgCustomerSearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCustomerSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.cus_id, Me.cus_name, Me.tex_num, Me.tax_sec, Me.cus_address, Me.cus_zip, Me.cus_tel, Me.price_leval, Me.cadit, Me.cus_note, Me.date_edit, Me.date_save})
        Me.dgCustomerSearch.Location = New System.Drawing.Point(11, 253)
        Me.dgCustomerSearch.Name = "dgCustomerSearch"
        Me.dgCustomerSearch.ReadOnly = True
        Me.dgCustomerSearch.RowHeadersVisible = False
        Me.dgCustomerSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCustomerSearch.Size = New System.Drawing.Size(546, 260)
        Me.dgCustomerSearch.TabIndex = 22
        '
        'no
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.no.DefaultCellStyle = DataGridViewCellStyle1
        Me.no.Frozen = True
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'cus_id
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cus_id.DefaultCellStyle = DataGridViewCellStyle2
        Me.cus_id.Frozen = True
        Me.cus_id.HeaderText = "รหัสลูกค้า"
        Me.cus_id.Name = "cus_id"
        Me.cus_id.ReadOnly = True
        Me.cus_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cus_name
        '
        Me.cus_name.HeaderText = "ชื่อลูกค้า"
        Me.cus_name.Name = "cus_name"
        Me.cus_name.ReadOnly = True
        Me.cus_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'tex_num
        '
        Me.tex_num.HeaderText = "เลขภาษี"
        Me.tex_num.Name = "tex_num"
        Me.tex_num.ReadOnly = True
        Me.tex_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tex_num.ToolTipText = "หมายเลขผู้เสียภาษี"
        '
        'tax_sec
        '
        Me.tax_sec.HeaderText = "สาขา"
        Me.tax_sec.Name = "tax_sec"
        Me.tax_sec.ReadOnly = True
        Me.tax_sec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cus_address
        '
        Me.cus_address.HeaderText = "ที่อยู่"
        Me.cus_address.Name = "cus_address"
        Me.cus_address.ReadOnly = True
        Me.cus_address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cus_address.Width = 170
        '
        'cus_zip
        '
        Me.cus_zip.HeaderText = "รหัสไปรษณีย์"
        Me.cus_zip.Name = "cus_zip"
        Me.cus_zip.ReadOnly = True
        Me.cus_zip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cus_tel
        '
        Me.cus_tel.HeaderText = "เบอร์โทรศัพท์"
        Me.cus_tel.Name = "cus_tel"
        Me.cus_tel.ReadOnly = True
        Me.cus_tel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'price_leval
        '
        Me.price_leval.HeaderText = "ราคา"
        Me.price_leval.Name = "price_leval"
        Me.price_leval.ReadOnly = True
        Me.price_leval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_leval.ToolTipText = "ระดับราคา"
        '
        'cadit
        '
        Me.cadit.HeaderText = "เครดิต"
        Me.cadit.Name = "cadit"
        Me.cadit.ReadOnly = True
        Me.cadit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cadit.ToolTipText = "ระยะเวลาค้างจ่าย"
        '
        'cus_note
        '
        Me.cus_note.HeaderText = "หมายเหตุ"
        Me.cus_note.Name = "cus_note"
        Me.cus_note.ReadOnly = True
        Me.cus_note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_edit
        '
        Me.date_edit.HeaderText = "แก้ไข"
        Me.date_edit.Name = "date_edit"
        Me.date_edit.ReadOnly = True
        Me.date_edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_edit.ToolTipText = "วันที่แก้ไข"
        Me.date_edit.Width = 130
        '
        'date_save
        '
        Me.date_save.HeaderText = "บันทึก"
        Me.date_save.Name = "date_save"
        Me.date_save.ReadOnly = True
        Me.date_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_save.ToolTipText = "วันที่บันทึก"
        Me.date_save.Width = 130
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New System.Drawing.Point(45, 14)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(58, 13)
        Me.lblCustomerID.TabIndex = 23
        Me.lblCustomerID.Text = "รหัสสมาชิก"
        '
        'txtCustomerZipcode
        '
        Me.txtCustomerZipcode.Location = New System.Drawing.Point(109, 115)
        Me.txtCustomerZipcode.MaxLength = 5
        Me.txtCustomerZipcode.Name = "txtCustomerZipcode"
        Me.txtCustomerZipcode.Size = New System.Drawing.Size(322, 20)
        Me.txtCustomerZipcode.TabIndex = 37
        '
        'btnCustomerDel
        '
        Me.btnCustomerDel.Location = New System.Drawing.Point(450, 154)
        Me.btnCustomerDel.Name = "btnCustomerDel"
        Me.btnCustomerDel.Size = New System.Drawing.Size(107, 35)
        Me.btnCustomerDel.TabIndex = 46
        Me.btnCustomerDel.Text = "&ลบ"
        Me.btnCustomerDel.UseVisualStyleBackColor = True
        '
        'lblCustomerZipcode
        '
        Me.lblCustomerZipcode.AutoSize = True
        Me.lblCustomerZipcode.Location = New System.Drawing.Point(34, 118)
        Me.lblCustomerZipcode.Name = "lblCustomerZipcode"
        Me.lblCustomerZipcode.Size = New System.Drawing.Size(69, 13)
        Me.lblCustomerZipcode.TabIndex = 36
        Me.lblCustomerZipcode.Text = "รหัสไปรษณีย์"
        '
        'txtCustomerTel
        '
        Me.txtCustomerTel.Location = New System.Drawing.Point(109, 141)
        Me.txtCustomerTel.Name = "txtCustomerTel"
        Me.txtCustomerTel.Size = New System.Drawing.Size(223, 20)
        Me.txtCustomerTel.TabIndex = 38
        '
        'btnCustomerEdit
        '
        Me.btnCustomerEdit.Location = New System.Drawing.Point(450, 114)
        Me.btnCustomerEdit.Name = "btnCustomerEdit"
        Me.btnCustomerEdit.Size = New System.Drawing.Size(107, 35)
        Me.btnCustomerEdit.TabIndex = 45
        Me.btnCustomerEdit.Text = "&แก้ไข"
        Me.btnCustomerEdit.UseVisualStyleBackColor = True
        '
        'lblCustomerAddress
        '
        Me.lblCustomerAddress.AutoSize = True
        Me.lblCustomerAddress.Location = New System.Drawing.Point(76, 92)
        Me.lblCustomerAddress.Name = "lblCustomerAddress"
        Me.lblCustomerAddress.Size = New System.Drawing.Size(27, 13)
        Me.lblCustomerAddress.TabIndex = 35
        Me.lblCustomerAddress.Text = "ที่อยู่"
        '
        'txtCustomerNote
        '
        Me.txtCustomerNote.Location = New System.Drawing.Point(109, 167)
        Me.txtCustomerNote.Name = "txtCustomerNote"
        Me.txtCustomerNote.Size = New System.Drawing.Size(322, 20)
        Me.txtCustomerNote.TabIndex = 39
        Me.txtCustomerNote.Text = "-"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(58, 66)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(45, 13)
        Me.lblCustomerName.TabIndex = 33
        Me.lblCustomerName.Text = "ชื่อลูกค้า"
        '
        'txtCustomerTAX
        '
        Me.txtCustomerTAX.Location = New System.Drawing.Point(109, 37)
        Me.txtCustomerTAX.MaxLength = 500
        Me.txtCustomerTAX.Name = "txtCustomerTAX"
        Me.txtCustomerTAX.Size = New System.Drawing.Size(97, 20)
        Me.txtCustomerTAX.TabIndex = 28
        Me.txtCustomerTAX.Text = "0000000000000"
        Me.ToolTipCustomer.SetToolTip(Me.txtCustomerTAX, "หมายเลขผู้เสียภาษีของลูกค้า")
        '
        'lblCustomerTel
        '
        Me.lblCustomerTel.AutoSize = True
        Me.lblCustomerTel.Location = New System.Drawing.Point(31, 144)
        Me.lblCustomerTel.Name = "lblCustomerTel"
        Me.lblCustomerTel.Size = New System.Drawing.Size(72, 13)
        Me.lblCustomerTel.TabIndex = 40
        Me.lblCustomerTel.Text = "เบอร์โทรศัพท์"
        '
        'btnCustomerSave
        '
        Me.btnCustomerSave.Location = New System.Drawing.Point(450, 69)
        Me.btnCustomerSave.Name = "btnCustomerSave"
        Me.btnCustomerSave.Size = New System.Drawing.Size(107, 36)
        Me.btnCustomerSave.TabIndex = 43
        Me.btnCustomerSave.Text = "&สร้างข้อมูลลูกค้าใหม่"
        Me.btnCustomerSave.UseVisualStyleBackColor = True
        '
        'lblCustomerTAX
        '
        Me.lblCustomerTAX.AutoSize = True
        Me.lblCustomerTAX.Location = New System.Drawing.Point(8, 40)
        Me.lblCustomerTAX.Name = "lblCustomerTAX"
        Me.lblCustomerTAX.Size = New System.Drawing.Size(95, 13)
        Me.lblCustomerTAX.TabIndex = 32
        Me.lblCustomerTAX.Text = "หมายเลขผู้เสียภาษี"
        '
        'txtCustomerSection
        '
        Me.txtCustomerSection.Location = New System.Drawing.Point(247, 37)
        Me.txtCustomerSection.Name = "txtCustomerSection"
        Me.txtCustomerSection.Size = New System.Drawing.Size(105, 20)
        Me.txtCustomerSection.TabIndex = 30
        Me.txtCustomerSection.Text = "-"
        Me.ToolTipCustomer.SetToolTip(Me.txtCustomerSection, "ใช้ในกรณีที่มีสาขา")
        '
        'lblCustomerNote
        '
        Me.lblCustomerNote.AutoSize = True
        Me.lblCustomerNote.Location = New System.Drawing.Point(51, 170)
        Me.lblCustomerNote.Name = "lblCustomerNote"
        Me.lblCustomerNote.Size = New System.Drawing.Size(52, 13)
        Me.lblCustomerNote.TabIndex = 41
        Me.lblCustomerNote.Text = "หมายเหตุ"
        '
        'lblCustomerSection
        '
        Me.lblCustomerSection.AutoSize = True
        Me.lblCustomerSection.Location = New System.Drawing.Point(212, 40)
        Me.lblCustomerSection.Name = "lblCustomerSection"
        Me.lblCustomerSection.Size = New System.Drawing.Size(29, 13)
        Me.lblCustomerSection.TabIndex = 42
        Me.lblCustomerSection.Text = "สาขา"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(109, 63)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(195, 20)
        Me.txtCustomerName.TabIndex = 31
        '
        'ToolTipCustomer
        '
        Me.ToolTipCustomer.AutoPopDelay = 5000
        Me.ToolTipCustomer.InitialDelay = 300
        Me.ToolTipCustomer.IsBalloon = True
        Me.ToolTipCustomer.ReshowDelay = 300
        '
        'cbbCustomerCadit
        '
        Me.cbbCustomerCadit.FormattingEnabled = True
        Me.cbbCustomerCadit.Location = New System.Drawing.Point(436, 37)
        Me.cbbCustomerCadit.Name = "cbbCustomerCadit"
        Me.cbbCustomerCadit.Size = New System.Drawing.Size(121, 21)
        Me.cbbCustomerCadit.TabIndex = 51
        Me.ToolTipCustomer.SetToolTip(Me.cbbCustomerCadit, "กำหนดระยะเวลาค้างจ่ายของลูกค้า")
        '
        'lblCusCountNum
        '
        Me.lblCusCountNum.AutoSize = True
        Me.lblCusCountNum.Location = New System.Drawing.Point(338, 144)
        Me.lblCusCountNum.Name = "lblCusCountNum"
        Me.lblCusCountNum.Size = New System.Drawing.Size(10, 13)
        Me.lblCusCountNum.TabIndex = 48
        Me.lblCusCountNum.Text = "."
        '
        'cbbCustomerPrice_level
        '
        Me.cbbCustomerPrice_level.FormattingEnabled = True
        Me.cbbCustomerPrice_level.Location = New System.Drawing.Point(436, 6)
        Me.cbbCustomerPrice_level.Name = "cbbCustomerPrice_level"
        Me.cbbCustomerPrice_level.Size = New System.Drawing.Size(121, 21)
        Me.cbbCustomerPrice_level.TabIndex = 49
        '
        'lblCUSprice_level
        '
        Me.lblCUSprice_level.AutoSize = True
        Me.lblCUSprice_level.Location = New System.Drawing.Point(376, 9)
        Me.lblCUSprice_level.Name = "lblCUSprice_level"
        Me.lblCUSprice_level.Size = New System.Drawing.Size(55, 13)
        Me.lblCUSprice_level.TabIndex = 50
        Me.lblCUSprice_level.Text = "ระดับราคา"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(358, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "กำหนดเครดิต"
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Location = New System.Drawing.Point(110, 90)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(321, 20)
        Me.txtCustomerAddress.TabIndex = 53
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 520)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 54
        Me.lblemployee.Text = "User"
        '
        'CustomerFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 542)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.txtCustomerAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbbCustomerCadit)
        Me.Controls.Add(Me.lblCUSprice_level)
        Me.Controls.Add(Me.cbbCustomerPrice_level)
        Me.Controls.Add(Me.lblCusCountNum)
        Me.Controls.Add(Me.lblCustomerSearchNote)
        Me.Controls.Add(Me.btnCustomerGetall)
        Me.Controls.Add(Me.btnCustomerSearch)
        Me.Controls.Add(Me.btnCustomerCancel)
        Me.Controls.Add(Me.txtCustomerSearch)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.dgCustomerSearch)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.txtCustomerZipcode)
        Me.Controls.Add(Me.btnCustomerDel)
        Me.Controls.Add(Me.lblCustomerZipcode)
        Me.Controls.Add(Me.txtCustomerTel)
        Me.Controls.Add(Me.btnCustomerEdit)
        Me.Controls.Add(Me.lblCustomerAddress)
        Me.Controls.Add(Me.txtCustomerNote)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.txtCustomerTAX)
        Me.Controls.Add(Me.lblCustomerTel)
        Me.Controls.Add(Me.btnCustomerSave)
        Me.Controls.Add(Me.lblCustomerTAX)
        Me.Controls.Add(Me.txtCustomerSection)
        Me.Controls.Add(Me.lblCustomerNote)
        Me.Controls.Add(Me.lblCustomerSection)
        Me.Controls.Add(Me.txtCustomerName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomerFrm"
        Me.Text = "ข้อมูลลูกค้า"
        CType(Me.dgCustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCustomerSearchNote As System.Windows.Forms.Label
    Friend WithEvents btnCustomerGetall As System.Windows.Forms.Button
    Friend WithEvents btnCustomerSearch As System.Windows.Forms.Button
    Friend WithEvents btnCustomerCancel As System.Windows.Forms.Button
    Friend WithEvents txtCustomerSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents dgCustomerSearch As System.Windows.Forms.DataGridView
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents txtCustomerZipcode As System.Windows.Forms.TextBox
    Friend WithEvents btnCustomerDel As System.Windows.Forms.Button
    Friend WithEvents lblCustomerZipcode As System.Windows.Forms.Label
    Friend WithEvents txtCustomerTel As System.Windows.Forms.TextBox
    Friend WithEvents btnCustomerEdit As System.Windows.Forms.Button
    Friend WithEvents lblCustomerAddress As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNote As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerTAX As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerTel As System.Windows.Forms.Label
    Friend WithEvents btnCustomerSave As System.Windows.Forms.Button
    Friend WithEvents lblCustomerTAX As System.Windows.Forms.Label
    Friend WithEvents txtCustomerSection As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerNote As System.Windows.Forms.Label
    Friend WithEvents lblCustomerSection As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipCustomer As System.Windows.Forms.ToolTip
    Friend WithEvents lblCusCountNum As System.Windows.Forms.Label
    Friend WithEvents cbbCustomerPrice_level As System.Windows.Forms.ComboBox
    Friend WithEvents lblCUSprice_level As System.Windows.Forms.Label
    Friend WithEvents cbbCustomerCadit As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tex_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tax_sec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_zip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_leval As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cadit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_edit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCustomerAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
