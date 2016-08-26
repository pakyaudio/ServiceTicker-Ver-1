<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsTestResultsFrm
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
        Me.txtCTRsearchSN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCTRclaims_id = New System.Windows.Forms.TextBox()
        Me.lblCTRclaims_id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCTRclaims_sn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCTRclaims_code_pro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCTR_claims_barcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCTRcus_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCTRcus_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCTRclaims_namepro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCTRclaims_sytom = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCTRclaims_datetime_save = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCTRclaims_datetime_send = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCTRclaims_correction = New System.Windows.Forms.TextBox()
        Me.txtCTRnewSN = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCTRtest_note = New System.Windows.Forms.TextBox()
        Me.rbCTRtestNoPass = New System.Windows.Forms.RadioButton()
        Me.rbCTRtestPass = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MetroPanelCategoryH1 = New MetroControls.MetroPanelCategoryH()
        Me.rbCTRnew_sn = New System.Windows.Forms.RadioButton()
        Me.rbCTRold_sn = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnCTRcancel = New System.Windows.Forms.Button()
        Me.lblCTRWarning = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCTRsave = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MetroLabel1 = New MetroControls.MetroLabel()
        Me.btnCTRsaveAll = New MetroControls.MetroButton()
        Me.dgCTR = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.old_sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.new_sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.test_results = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblemployee = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MetroPanelCategoryH1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgCTR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCTRsearchSN
        '
        Me.txtCTRsearchSN.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCTRsearchSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRsearchSN.Location = New System.Drawing.Point(34, 7)
        Me.txtCTRsearchSN.Name = "txtCTRsearchSN"
        Me.txtCTRsearchSN.Size = New System.Drawing.Size(119, 24)
        Me.txtCTRsearchSN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "SN"
        '
        'txtCTRclaims_id
        '
        Me.txtCTRclaims_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_id.Location = New System.Drawing.Point(85, 19)
        Me.txtCTRclaims_id.Name = "txtCTRclaims_id"
        Me.txtCTRclaims_id.ReadOnly = True
        Me.txtCTRclaims_id.Size = New System.Drawing.Size(150, 24)
        Me.txtCTRclaims_id.TabIndex = 99
        '
        'lblCTRclaims_id
        '
        Me.lblCTRclaims_id.AutoSize = True
        Me.lblCTRclaims_id.Location = New System.Drawing.Point(4, 26)
        Me.lblCTRclaims_id.Name = "lblCTRclaims_id"
        Me.lblCTRclaims_id.Size = New System.Drawing.Size(75, 13)
        Me.lblCTRclaims_id.TabIndex = 99
        Me.lblCTRclaims_id.Text = "หมายเลขเคลม"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "SN"
        '
        'txtCTRclaims_sn
        '
        Me.txtCTRclaims_sn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_sn.Location = New System.Drawing.Point(269, 19)
        Me.txtCTRclaims_sn.Name = "txtCTRclaims_sn"
        Me.txtCTRclaims_sn.ReadOnly = True
        Me.txtCTRclaims_sn.Size = New System.Drawing.Size(131, 24)
        Me.txtCTRclaims_sn.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(406, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "รหัสสินค้า"
        '
        'txtCTRclaims_code_pro
        '
        Me.txtCTRclaims_code_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_code_pro.Location = New System.Drawing.Point(464, 19)
        Me.txtCTRclaims_code_pro.Name = "txtCTRclaims_code_pro"
        Me.txtCTRclaims_code_pro.ReadOnly = True
        Me.txtCTRclaims_code_pro.Size = New System.Drawing.Size(115, 24)
        Me.txtCTRclaims_code_pro.TabIndex = 99
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "บาร์โค๊ต"
        '
        'txtCTR_claims_barcode
        '
        Me.txtCTR_claims_barcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTR_claims_barcode.Location = New System.Drawing.Point(54, 49)
        Me.txtCTR_claims_barcode.Name = "txtCTR_claims_barcode"
        Me.txtCTR_claims_barcode.ReadOnly = True
        Me.txtCTR_claims_barcode.Size = New System.Drawing.Size(120, 24)
        Me.txtCTR_claims_barcode.TabIndex = 99
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "รหัสลูกค้า"
        '
        'txtCTRcus_id
        '
        Me.txtCTRcus_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRcus_id.Location = New System.Drawing.Point(246, 7)
        Me.txtCTRcus_id.Name = "txtCTRcus_id"
        Me.txtCTRcus_id.ReadOnly = True
        Me.txtCTRcus_id.Size = New System.Drawing.Size(131, 24)
        Me.txtCTRcus_id.TabIndex = 99
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(382, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "ชื่อลูกค้า"
        '
        'txtCTRcus_name
        '
        Me.txtCTRcus_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRcus_name.Location = New System.Drawing.Point(428, 7)
        Me.txtCTRcus_name.Name = "txtCTRcus_name"
        Me.txtCTRcus_name.ReadOnly = True
        Me.txtCTRcus_name.Size = New System.Drawing.Size(160, 24)
        Me.txtCTRcus_name.TabIndex = 99
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(180, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "ชื่อสินค้า"
        '
        'txtCTRclaims_namepro
        '
        Me.txtCTRclaims_namepro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_namepro.Location = New System.Drawing.Point(232, 49)
        Me.txtCTRclaims_namepro.Name = "txtCTRclaims_namepro"
        Me.txtCTRclaims_namepro.ReadOnly = True
        Me.txtCTRclaims_namepro.Size = New System.Drawing.Size(347, 24)
        Me.txtCTRclaims_namepro.TabIndex = 99
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "อาการเสีย"
        '
        'txtCTRclaims_sytom
        '
        Me.txtCTRclaims_sytom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_sytom.Location = New System.Drawing.Point(64, 79)
        Me.txtCTRclaims_sytom.Name = "txtCTRclaims_sytom"
        Me.txtCTRclaims_sytom.ReadOnly = True
        Me.txtCTRclaims_sytom.Size = New System.Drawing.Size(259, 24)
        Me.txtCTRclaims_sytom.TabIndex = 99
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(327, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "วันที่รับเคลม"
        '
        'txtCTRclaims_datetime_save
        '
        Me.txtCTRclaims_datetime_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_datetime_save.Location = New System.Drawing.Point(399, 79)
        Me.txtCTRclaims_datetime_save.Name = "txtCTRclaims_datetime_save"
        Me.txtCTRclaims_datetime_save.ReadOnly = True
        Me.txtCTRclaims_datetime_save.Size = New System.Drawing.Size(180, 24)
        Me.txtCTRclaims_datetime_save.TabIndex = 99
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(329, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "วันที่ส่งเคลม"
        '
        'txtCTRclaims_datetime_send
        '
        Me.txtCTRclaims_datetime_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_datetime_send.Location = New System.Drawing.Point(399, 109)
        Me.txtCTRclaims_datetime_send.Name = "txtCTRclaims_datetime_send"
        Me.txtCTRclaims_datetime_send.ReadOnly = True
        Me.txtCTRclaims_datetime_send.Size = New System.Drawing.Size(180, 24)
        Me.txtCTRclaims_datetime_send.TabIndex = 99
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "การแก้ไขจากบริษัท"
        '
        'txtCTRclaims_correction
        '
        Me.txtCTRclaims_correction.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCTRclaims_correction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_correction.Location = New System.Drawing.Point(108, 19)
        Me.txtCTRclaims_correction.Name = "txtCTRclaims_correction"
        Me.txtCTRclaims_correction.Size = New System.Drawing.Size(215, 24)
        Me.txtCTRclaims_correction.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtCTRclaims_correction, "เช่น ซ่อม เปลี่ยนตัว")
        '
        'txtCTRnewSN
        '
        Me.txtCTRnewSN.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCTRnewSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRnewSN.Location = New System.Drawing.Point(48, 26)
        Me.txtCTRnewSN.Name = "txtCTRnewSN"
        Me.txtCTRnewSN.Size = New System.Drawing.Size(203, 24)
        Me.txtCTRnewSN.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 15)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "SN ใหม่"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_id)
        Me.GroupBox1.Controls.Add(Me.lblCTRclaims_id)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_sn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_datetime_send)
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_code_pro)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_datetime_save)
        Me.GroupBox1.Controls.Add(Me.txtCTR_claims_barcode)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_sytom)
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_namepro)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 147)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายละเอียดสินค้า"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCTRtest_note)
        Me.GroupBox2.Controls.Add(Me.rbCTRtestNoPass)
        Me.GroupBox2.Controls.Add(Me.rbCTRtestPass)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtCTRclaims_correction)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.MetroPanelCategoryH1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 88)
        Me.GroupBox2.TabIndex = 99
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายละเอียดการเคลม"
        '
        'txtCTRtest_note
        '
        Me.txtCTRtest_note.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCTRtest_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRtest_note.Location = New System.Drawing.Point(224, 49)
        Me.txtCTRtest_note.Name = "txtCTRtest_note"
        Me.txtCTRtest_note.Size = New System.Drawing.Size(99, 24)
        Me.txtCTRtest_note.TabIndex = 112
        Me.ToolTip1.SetToolTip(Me.txtCTRtest_note, "หมายเหตุ การตรวจสอบกรณีทดสอบไม่ผ่านเพราะ")
        '
        'rbCTRtestNoPass
        '
        Me.rbCTRtestNoPass.AutoSize = True
        Me.rbCTRtestNoPass.Location = New System.Drawing.Point(159, 54)
        Me.rbCTRtestNoPass.Name = "rbCTRtestNoPass"
        Me.rbCTRtestNoPass.Size = New System.Drawing.Size(58, 17)
        Me.rbCTRtestNoPass.TabIndex = 30
        Me.rbCTRtestNoPass.TabStop = True
        Me.rbCTRtestNoPass.Text = "ไม่ผ่าน"
        Me.rbCTRtestNoPass.UseVisualStyleBackColor = True
        '
        'rbCTRtestPass
        '
        Me.rbCTRtestPass.AutoSize = True
        Me.rbCTRtestPass.Location = New System.Drawing.Point(108, 54)
        Me.rbCTRtestPass.Name = "rbCTRtestPass"
        Me.rbCTRtestPass.Size = New System.Drawing.Size(45, 17)
        Me.rbCTRtestPass.TabIndex = 29
        Me.rbCTRtestPass.TabStop = True
        Me.rbCTRtestPass.Text = "ผ่าน"
        Me.rbCTRtestPass.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "ผลการทดสอบ"
        '
        'MetroPanelCategoryH1
        '
        Me.MetroPanelCategoryH1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MetroPanelCategoryH1.BackColorHover = System.Drawing.Color.Transparent
        Me.MetroPanelCategoryH1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.MetroPanelCategoryH1.Controls.Add(Me.rbCTRnew_sn)
        Me.MetroPanelCategoryH1.Controls.Add(Me.Label12)
        Me.MetroPanelCategoryH1.Controls.Add(Me.rbCTRold_sn)
        Me.MetroPanelCategoryH1.Controls.Add(Me.txtCTRnewSN)
        Me.MetroPanelCategoryH1.DrawBorders = True
        Me.MetroPanelCategoryH1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroPanelCategoryH1.ForeColor = System.Drawing.Color.Black
        Me.MetroPanelCategoryH1.HeadlineFont = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.MetroPanelCategoryH1.LineColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.MetroPanelCategoryH1.LineSize = 4
        Me.MetroPanelCategoryH1.Location = New System.Drawing.Point(328, 19)
        Me.MetroPanelCategoryH1.Name = "MetroPanelCategoryH1"
        Me.MetroPanelCategoryH1.Size = New System.Drawing.Size(259, 54)
        Me.MetroPanelCategoryH1.SubTextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroPanelCategoryH1.TabIndex = 28
        Me.MetroPanelCategoryH1.TextHeadline = ""
        Me.MetroPanelCategoryH1.TextSubline = ""
        '
        'rbCTRnew_sn
        '
        Me.rbCTRnew_sn.AutoSize = True
        Me.rbCTRnew_sn.Location = New System.Drawing.Point(149, 4)
        Me.rbCTRnew_sn.Name = "rbCTRnew_sn"
        Me.rbCTRnew_sn.Size = New System.Drawing.Size(62, 19)
        Me.rbCTRnew_sn.TabIndex = 4
        Me.rbCTRnew_sn.Text = "SN ใหม่"
        Me.rbCTRnew_sn.UseVisualStyleBackColor = True
        '
        'rbCTRold_sn
        '
        Me.rbCTRold_sn.AutoSize = True
        Me.rbCTRold_sn.Checked = True
        Me.rbCTRold_sn.Location = New System.Drawing.Point(60, 4)
        Me.rbCTRold_sn.Name = "rbCTRold_sn"
        Me.rbCTRold_sn.Size = New System.Drawing.Size(60, 19)
        Me.rbCTRold_sn.TabIndex = 3
        Me.rbCTRold_sn.TabStop = True
        Me.rbCTRold_sn.Text = "SN เดิม"
        Me.rbCTRold_sn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(623, 349)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCTRcancel)
        Me.TabPage1.Controls.Add(Me.lblCTRWarning)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.btnCTRsave)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.txtCTRsearchSN)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtCTRcus_name)
        Me.TabPage1.Controls.Add(Me.txtCTRcus_id)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(615, 323)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "บันทึกผลการทดสอบ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnCTRcancel
        '
        Me.btnCTRcancel.Location = New System.Drawing.Point(397, 284)
        Me.btnCTRcancel.Name = "btnCTRcancel"
        Me.btnCTRcancel.Size = New System.Drawing.Size(75, 29)
        Me.btnCTRcancel.TabIndex = 113
        Me.btnCTRcancel.Text = "ยกเลิก"
        Me.btnCTRcancel.UseVisualStyleBackColor = True
        Me.btnCTRcancel.Visible = False
        '
        'lblCTRWarning
        '
        Me.lblCTRWarning.AutoSize = True
        Me.lblCTRWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCTRWarning.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCTRWarning.Location = New System.Drawing.Point(13, 292)
        Me.lblCTRWarning.Name = "lblCTRWarning"
        Me.lblCTRWarning.Size = New System.Drawing.Size(58, 16)
        Me.lblCTRWarning.TabIndex = 112
        Me.lblCTRWarning.Text = "Warning"
        Me.lblCTRWarning.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.gray_classic_search_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(159, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 50
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCTRsave
        '
        Me.btnCTRsave.Location = New System.Drawing.Point(473, 284)
        Me.btnCTRsave.Name = "btnCTRsave"
        Me.btnCTRsave.Size = New System.Drawing.Size(129, 29)
        Me.btnCTRsave.TabIndex = 6
        Me.btnCTRsave.Text = "บันทึก"
        Me.btnCTRsave.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MetroLabel1)
        Me.TabPage2.Controls.Add(Me.btnCTRsaveAll)
        Me.TabPage2.Controls.Add(Me.dgCTR)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(615, 323)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "รายการสินค้าที่ทดสอบ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel1.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel1.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.MetroLabel1.ForeColorNormal = System.Drawing.Color.Black
        Me.MetroLabel1.Location = New System.Drawing.Point(6, 302)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(219, 15)
        Me.MetroLabel1.TabIndex = 212
        Me.MetroLabel1.Text = "*กด Delete เพื่อลบข้อมูล, ดับเบิ๊ลคลิ๊กเพื่อแก้ไข"
        Me.MetroLabel1.UseHoverMode = True
        '
        'btnCTRsaveAll
        '
        Me.btnCTRsaveAll.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnCTRsaveAll.BackgroundColorNormal = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnCTRsaveAll.BackgroundColorPressed = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnCTRsaveAll.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnCTRsaveAll.DrawBorders = True
        Me.btnCTRsaveAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCTRsaveAll.ForeColor = System.Drawing.Color.Black
        Me.btnCTRsaveAll.Location = New System.Drawing.Point(504, 297)
        Me.btnCTRsaveAll.Name = "btnCTRsaveAll"
        Me.btnCTRsaveAll.Size = New System.Drawing.Size(105, 20)
        Me.btnCTRsaveAll.TabIndex = 211
        Me.btnCTRsaveAll.Text = "บันทึกทั้งหมด"
        '
        'dgCTR
        '
        Me.dgCTR.AllowUserToAddRows = False
        Me.dgCTR.AllowUserToDeleteRows = False
        Me.dgCTR.AllowUserToOrderColumns = True
        Me.dgCTR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCTR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.claims_id, Me.old_sn, Me.new_sn, Me.code_pro, Me.name_pro, Me.correction, Me.test_results})
        Me.dgCTR.Location = New System.Drawing.Point(6, 6)
        Me.dgCTR.MultiSelect = False
        Me.dgCTR.Name = "dgCTR"
        Me.dgCTR.ReadOnly = True
        Me.dgCTR.RowHeadersVisible = False
        Me.dgCTR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCTR.Size = New System.Drawing.Size(603, 285)
        Me.dgCTR.TabIndex = 210
        Me.ToolTip1.SetToolTip(Me.dgCTR, "ดับเบิ้ลคลิ๊กเพื่อแก้ไข")
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
        Me.claims_id.ToolTipText = "รหัสใบเคลมสินค้า"
        Me.claims_id.Width = 120
        '
        'old_sn
        '
        Me.old_sn.HeaderText = "sn เก่า"
        Me.old_sn.Name = "old_sn"
        Me.old_sn.ReadOnly = True
        Me.old_sn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.old_sn.ToolTipText = "sn เก่า"
        '
        'new_sn
        '
        Me.new_sn.HeaderText = "sn ใหม่"
        Me.new_sn.Name = "new_sn"
        Me.new_sn.ReadOnly = True
        Me.new_sn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.new_sn.ToolTipText = "sn ใหม่"
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
        Me.name_pro.Width = 200
        '
        'correction
        '
        Me.correction.HeaderText = "การแก้ไข"
        Me.correction.Name = "correction"
        Me.correction.ReadOnly = True
        Me.correction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.correction.ToolTipText = "การแก้ไขจากบริษัท"
        '
        'test_results
        '
        Me.test_results.HeaderText = "ผลทดสอบ"
        Me.test_results.Name = "test_results"
        Me.test_results.ReadOnly = True
        Me.test_results.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.test_results.ToolTipText = "ผลการทดสอบสินค้า"
        Me.test_results.Width = 70
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(9, 360)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 7
        Me.lblemployee.Text = "User"
        '
        'ClaimsTestResultsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 374)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ClaimsTestResultsFrm"
        Me.Text = "ทดสอบสินค้าเคลม"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MetroPanelCategoryH1.ResumeLayout(False)
        Me.MetroPanelCategoryH1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgCTR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCTRsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCTRclaims_id As System.Windows.Forms.TextBox
    Friend WithEvents lblCTRclaims_id As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCTRclaims_sn As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCTRclaims_code_pro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCTR_claims_barcode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCTRcus_id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCTRcus_name As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCTRclaims_namepro As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCTRclaims_sytom As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCTRclaims_datetime_save As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCTRclaims_datetime_send As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCTRclaims_correction As System.Windows.Forms.TextBox
    Friend WithEvents txtCTRnewSN As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCTRnew_sn As System.Windows.Forms.RadioButton
    Friend WithEvents rbCTRold_sn As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MetroPanelCategoryH1 As MetroControls.MetroPanelCategoryH
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnCTRsave As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgCTR As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rbCTRtestNoPass As System.Windows.Forms.RadioButton
    Friend WithEvents rbCTRtestPass As System.Windows.Forms.RadioButton
    Friend WithEvents txtCTRtest_note As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblCTRWarning As System.Windows.Forms.Label
    Friend WithEvents btnCTRcancel As System.Windows.Forms.Button
    Friend WithEvents MetroLabel1 As MetroControls.MetroLabel
    Friend WithEvents btnCTRsaveAll As MetroControls.MetroButton
    Friend WithEvents lblemployee As System.Windows.Forms.Label
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents old_sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents new_sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents correction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents test_results As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
