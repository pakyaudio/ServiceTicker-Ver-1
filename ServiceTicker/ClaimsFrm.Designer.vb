<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsFrm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTipCF = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblemployee = New System.Windows.Forms.Label()
        Me.txtCFstatus = New System.Windows.Forms.TextBox()
        Me.btnCFcancel = New System.Windows.Forms.Button()
        Me.btnCFsave = New System.Windows.Forms.Button()
        Me.txtCFnote = New System.Windows.Forms.TextBox()
        Me.btnCFloadaccessory = New System.Windows.Forms.Button()
        Me.txtCFaccessory = New System.Windows.Forms.TextBox()
        Me.btnCchangCustomer = New System.Windows.Forms.Button()
        Me.txtCFsyptom = New System.Windows.Forms.TextBox()
        Me.txtCFsearchSN = New System.Windows.Forms.TextBox()
        Me.btnClaimsAll = New System.Windows.Forms.Button()
        Me.btnCdepositClaims = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.claims = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCFclaims_id = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtCFprice_members = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCFprice_loyal = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCFprice_technician = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCFprice_wholsale = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCFemployee_sale = New System.Windows.Forms.TextBox()
        Me.lblCFdate = New System.Windows.Forms.Label()
        Me.txtCFdatetime_sale = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCFunit = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCFtype = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCFprice_buy = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCFname_pro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCFbar_code = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCFcode_pro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCFserial_pro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCFcustomer_name = New System.Windows.Forms.TextBox()
        Me.txtCFcustomer_id = New System.Windows.Forms.TextBox()
        Me.btnCFsearchSN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnCRefresh = New System.Windows.Forms.Button()
        Me.dgClaims = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_wholesale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_technician = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_loyel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_member = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accessory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgClaims, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTipCF
        '
        Me.ToolTipCF.IsBalloon = True
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(66, 325)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(43, 13)
        Me.lblemployee.TabIndex = 11
        Me.lblemployee.Text = "ผู้เข้าใช้"
        Me.ToolTipCF.SetToolTip(Me.lblemployee, "ชื่อผู้เข้าใช้งาน")
        '
        'txtCFstatus
        '
        Me.txtCFstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFstatus.Location = New System.Drawing.Point(360, 11)
        Me.txtCFstatus.Name = "txtCFstatus"
        Me.txtCFstatus.ReadOnly = True
        Me.txtCFstatus.Size = New System.Drawing.Size(142, 21)
        Me.txtCFstatus.TabIndex = 15
        Me.ToolTipCF.SetToolTip(Me.txtCFstatus, "สถานะการชำระหรือยังไม่ชำระเงิน")
        '
        'btnCFcancel
        '
        Me.btnCFcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCFcancel.Location = New System.Drawing.Point(700, 183)
        Me.btnCFcancel.Name = "btnCFcancel"
        Me.btnCFcancel.Size = New System.Drawing.Size(89, 37)
        Me.btnCFcancel.TabIndex = 35
        Me.btnCFcancel.Text = "ยกเลิก"
        Me.ToolTipCF.SetToolTip(Me.btnCFcancel, "ยกเลิก")
        Me.btnCFcancel.UseVisualStyleBackColor = True
        '
        'btnCFsave
        '
        Me.btnCFsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCFsave.Location = New System.Drawing.Point(605, 183)
        Me.btnCFsave.Name = "btnCFsave"
        Me.btnCFsave.Size = New System.Drawing.Size(89, 37)
        Me.btnCFsave.TabIndex = 34
        Me.btnCFsave.Text = "บันทึก"
        Me.ToolTipCF.SetToolTip(Me.btnCFsave, "บันทึกการเคลม")
        Me.btnCFsave.UseVisualStyleBackColor = True
        '
        'txtCFnote
        '
        Me.txtCFnote.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFnote.Location = New System.Drawing.Point(611, 153)
        Me.txtCFnote.Name = "txtCFnote"
        Me.txtCFnote.Size = New System.Drawing.Size(178, 24)
        Me.txtCFnote.TabIndex = 34
        Me.ToolTipCF.SetToolTip(Me.txtCFnote, "บันทึกความจำ")
        '
        'btnCFloadaccessory
        '
        Me.btnCFloadaccessory.Location = New System.Drawing.Point(565, 155)
        Me.btnCFloadaccessory.Name = "btnCFloadaccessory"
        Me.btnCFloadaccessory.Size = New System.Drawing.Size(40, 24)
        Me.btnCFloadaccessory.TabIndex = 33
        Me.btnCFloadaccessory.Text = "เลือก"
        Me.ToolTipCF.SetToolTip(Me.btnCFloadaccessory, "เลือกรายการอุปกรณ์ที่นำมาด้วย")
        Me.btnCFloadaccessory.UseVisualStyleBackColor = True
        '
        'txtCFaccessory
        '
        Me.txtCFaccessory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFaccessory.Location = New System.Drawing.Point(373, 154)
        Me.txtCFaccessory.Name = "txtCFaccessory"
        Me.txtCFaccessory.Size = New System.Drawing.Size(186, 24)
        Me.txtCFaccessory.TabIndex = 31
        Me.ToolTipCF.SetToolTip(Me.txtCFaccessory, "เลือกอุปกรณ์ที่ติดมาด้วย")
        '
        'btnCchangCustomer
        '
        Me.btnCchangCustomer.Location = New System.Drawing.Point(688, 18)
        Me.btnCchangCustomer.Name = "btnCchangCustomer"
        Me.btnCchangCustomer.Size = New System.Drawing.Size(101, 24)
        Me.btnCchangCustomer.TabIndex = 30
        Me.btnCchangCustomer.Text = "เปลี่ยนชื่อลูกค้า"
        Me.ToolTipCF.SetToolTip(Me.btnCchangCustomer, "เปลี่ยนชื่อลูกค้าที่ส่งเคลม")
        Me.btnCchangCustomer.UseVisualStyleBackColor = True
        '
        'txtCFsyptom
        '
        Me.txtCFsyptom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFsyptom.Location = New System.Drawing.Point(10, 154)
        Me.txtCFsyptom.Name = "txtCFsyptom"
        Me.txtCFsyptom.Size = New System.Drawing.Size(357, 24)
        Me.txtCFsyptom.TabIndex = 28
        Me.ToolTipCF.SetToolTip(Me.txtCFsyptom, "ระบุการเสียของสิน้คา")
        '
        'txtCFsearchSN
        '
        Me.txtCFsearchSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFsearchSN.Location = New System.Drawing.Point(88, 19)
        Me.txtCFsearchSN.Name = "txtCFsearchSN"
        Me.txtCFsearchSN.Size = New System.Drawing.Size(139, 24)
        Me.txtCFsearchSN.TabIndex = 0
        Me.ToolTipCF.SetToolTip(Me.txtCFsearchSN, "ป้อนหมายเลข SN")
        '
        'btnClaimsAll
        '
        Me.btnClaimsAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClaimsAll.Location = New System.Drawing.Point(630, 328)
        Me.btnClaimsAll.Name = "btnClaimsAll"
        Me.btnClaimsAll.Size = New System.Drawing.Size(213, 37)
        Me.btnClaimsAll.TabIndex = 35
        Me.btnClaimsAll.Text = "บันทึกทั้งหมด"
        Me.ToolTipCF.SetToolTip(Me.btnClaimsAll, "บันทึกการเคลมทั้งหมด")
        Me.btnClaimsAll.UseVisualStyleBackColor = True
        '
        'btnCdepositClaims
        '
        Me.btnCdepositClaims.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCdepositClaims.Location = New System.Drawing.Point(10, 183)
        Me.btnCdepositClaims.Name = "btnCdepositClaims"
        Me.btnCdepositClaims.Size = New System.Drawing.Size(89, 27)
        Me.btnCdepositClaims.TabIndex = 36
        Me.btnCdepositClaims.Text = "ฝากเคลม"
        Me.ToolTipCF.SetToolTip(Me.btnCdepositClaims, "บันทึกการเคลม")
        Me.btnCdepositClaims.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(13, 325)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "ผู้เข้าใช้ : "
        '
        'claims
        '
        Me.claims.Controls.Add(Me.TabPage1)
        Me.claims.Controls.Add(Me.TabPage2)
        Me.claims.Location = New System.Drawing.Point(12, 12)
        Me.claims.Name = "claims"
        Me.claims.SelectedIndex = 0
        Me.claims.Size = New System.Drawing.Size(835, 310)
        Me.claims.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.txtCFstatus)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txtCFclaims_id)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(827, 284)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "รับเคลม"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(316, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "สถานะ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(508, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 24)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "หมายเลขใบเคลม"
        '
        'txtCFclaims_id
        '
        Me.txtCFclaims_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFclaims_id.Location = New System.Drawing.Point(112, 9)
        Me.txtCFclaims_id.Name = "txtCFclaims_id"
        Me.txtCFclaims_id.ReadOnly = True
        Me.txtCFclaims_id.Size = New System.Drawing.Size(185, 24)
        Me.txtCFclaims_id.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtCFprice_members)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtCFprice_loyal)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtCFprice_technician)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtCFprice_wholsale)
        Me.GroupBox1.Controls.Add(Me.btnCdepositClaims)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.btnCFcancel)
        Me.GroupBox1.Controls.Add(Me.btnCFsave)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtCFnote)
        Me.GroupBox1.Controls.Add(Me.btnCFloadaccessory)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCFaccessory)
        Me.GroupBox1.Controls.Add(Me.btnCchangCustomer)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtCFsyptom)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtCFemployee_sale)
        Me.GroupBox1.Controls.Add(Me.lblCFdate)
        Me.GroupBox1.Controls.Add(Me.txtCFdatetime_sale)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCFunit)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCFtype)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCFprice_buy)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCFname_pro)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCFbar_code)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCFcode_pro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCFserial_pro)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCFcustomer_name)
        Me.GroupBox1.Controls.Add(Me.txtCFcustomer_id)
        Me.GroupBox1.Controls.Add(Me.txtCFsearchSN)
        Me.GroupBox1.Controls.Add(Me.btnCFsearchSN)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(799, 228)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รับเคลมสินค้า"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(277, 94)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 13)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "ราคาสมาชิก"
        '
        'txtCFprice_members
        '
        Me.txtCFprice_members.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFprice_members.Location = New System.Drawing.Point(274, 110)
        Me.txtCFprice_members.Name = "txtCFprice_members"
        Me.txtCFprice_members.ReadOnly = True
        Me.txtCFprice_members.Size = New System.Drawing.Size(65, 24)
        Me.txtCFprice_members.TabIndex = 43
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(184, 94)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 13)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "ราคาลูกค้าประจำ"
        '
        'txtCFprice_loyal
        '
        Me.txtCFprice_loyal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFprice_loyal.Location = New System.Drawing.Point(187, 110)
        Me.txtCFprice_loyal.Name = "txtCFprice_loyal"
        Me.txtCFprice_loyal.ReadOnly = True
        Me.txtCFprice_loyal.Size = New System.Drawing.Size(81, 24)
        Me.txtCFprice_loyal.TabIndex = 41
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(131, 94)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 13)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "ราคาช่าง"
        '
        'txtCFprice_technician
        '
        Me.txtCFprice_technician.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFprice_technician.Location = New System.Drawing.Point(128, 110)
        Me.txtCFprice_technician.Name = "txtCFprice_technician"
        Me.txtCFprice_technician.ReadOnly = True
        Me.txtCFprice_technician.Size = New System.Drawing.Size(53, 24)
        Me.txtCFprice_technician.TabIndex = 39
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(66, 94)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 13)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "ราคาขายส่ง"
        '
        'txtCFprice_wholsale
        '
        Me.txtCFprice_wholsale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFprice_wholsale.Location = New System.Drawing.Point(69, 110)
        Me.txtCFprice_wholsale.Name = "txtCFprice_wholsale"
        Me.txtCFprice_wholsale.ReadOnly = True
        Me.txtCFprice_wholsale.Size = New System.Drawing.Size(53, 24)
        Me.txtCFprice_wholsale.TabIndex = 37
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.DarkRed
        Me.Label17.Location = New System.Drawing.Point(105, 183)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(452, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "หากต้องการเช็คว่าลูกค้าซื้อสินค้าไปวันที่เท่าไหร่ ให้ป้อน SN สินค้าลงไปโดยไม่ต้อง" & _
    "กดบันทึกข้อมูล"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(608, 137)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "หมายเหตุ"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(370, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "อุปกรณ์ที่นำมาด้วย"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "อาการเสีย"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(617, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "ผู้ขาย"
        '
        'txtCFemployee_sale
        '
        Me.txtCFemployee_sale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFemployee_sale.Location = New System.Drawing.Point(620, 110)
        Me.txtCFemployee_sale.Name = "txtCFemployee_sale"
        Me.txtCFemployee_sale.ReadOnly = True
        Me.txtCFemployee_sale.Size = New System.Drawing.Size(169, 24)
        Me.txtCFemployee_sale.TabIndex = 26
        '
        'lblCFdate
        '
        Me.lblCFdate.AutoSize = True
        Me.lblCFdate.Location = New System.Drawing.Point(344, 94)
        Me.lblCFdate.Name = "lblCFdate"
        Me.lblCFdate.Size = New System.Drawing.Size(160, 13)
        Me.lblCFdate.TabIndex = 25
        Me.lblCFdate.Text = "วันที่ขายสินค้า(ปี/เดือน/วัน เวลา)"
        '
        'txtCFdatetime_sale
        '
        Me.txtCFdatetime_sale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFdatetime_sale.Location = New System.Drawing.Point(347, 110)
        Me.txtCFdatetime_sale.Name = "txtCFdatetime_sale"
        Me.txtCFdatetime_sale.ReadOnly = True
        Me.txtCFdatetime_sale.Size = New System.Drawing.Size(267, 24)
        Me.txtCFdatetime_sale.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(722, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "หน่วยนับ"
        '
        'txtCFunit
        '
        Me.txtCFunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFunit.Location = New System.Drawing.Point(722, 67)
        Me.txtCFunit.Name = "txtCFunit"
        Me.txtCFunit.ReadOnly = True
        Me.txtCFunit.Size = New System.Drawing.Size(67, 24)
        Me.txtCFunit.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(646, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "ประเภทสินค้า"
        '
        'txtCFtype
        '
        Me.txtCFtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFtype.Location = New System.Drawing.Point(649, 68)
        Me.txtCFtype.Name = "txtCFtype"
        Me.txtCFtype.ReadOnly = True
        Me.txtCFtype.Size = New System.Drawing.Size(67, 24)
        Me.txtCFtype.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "ราคาปกติ"
        '
        'txtCFprice_buy
        '
        Me.txtCFprice_buy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFprice_buy.Location = New System.Drawing.Point(10, 110)
        Me.txtCFprice_buy.Name = "txtCFprice_buy"
        Me.txtCFprice_buy.ReadOnly = True
        Me.txtCFprice_buy.Size = New System.Drawing.Size(53, 24)
        Me.txtCFprice_buy.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(442, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ชื่อสินค้า"
        '
        'txtCFname_pro
        '
        Me.txtCFname_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFname_pro.Location = New System.Drawing.Point(445, 67)
        Me.txtCFname_pro.Name = "txtCFname_pro"
        Me.txtCFname_pro.ReadOnly = True
        Me.txtCFname_pro.Size = New System.Drawing.Size(198, 24)
        Me.txtCFname_pro.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "บาร์โค๊ตสินค้า"
        '
        'txtCFbar_code
        '
        Me.txtCFbar_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFbar_code.Location = New System.Drawing.Point(300, 68)
        Me.txtCFbar_code.Name = "txtCFbar_code"
        Me.txtCFbar_code.ReadOnly = True
        Me.txtCFbar_code.Size = New System.Drawing.Size(139, 24)
        Me.txtCFbar_code.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "รหัสสินค้า"
        '
        'txtCFcode_pro
        '
        Me.txtCFcode_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFcode_pro.Location = New System.Drawing.Point(155, 67)
        Me.txtCFcode_pro.Name = "txtCFcode_pro"
        Me.txtCFcode_pro.ReadOnly = True
        Me.txtCFcode_pro.Size = New System.Drawing.Size(139, 24)
        Me.txtCFcode_pro.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Serial Number"
        '
        'txtCFserial_pro
        '
        Me.txtCFserial_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFserial_pro.Location = New System.Drawing.Point(10, 67)
        Me.txtCFserial_pro.Name = "txtCFserial_pro"
        Me.txtCFserial_pro.ReadOnly = True
        Me.txtCFserial_pro.Size = New System.Drawing.Size(139, 24)
        Me.txtCFserial_pro.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(492, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ชื่อลูกค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "รหัสลูกค้า"
        '
        'txtCFcustomer_name
        '
        Me.txtCFcustomer_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFcustomer_name.Location = New System.Drawing.Point(543, 18)
        Me.txtCFcustomer_name.Name = "txtCFcustomer_name"
        Me.txtCFcustomer_name.ReadOnly = True
        Me.txtCFcustomer_name.Size = New System.Drawing.Size(139, 24)
        Me.txtCFcustomer_name.TabIndex = 7
        '
        'txtCFcustomer_id
        '
        Me.txtCFcustomer_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFcustomer_id.Location = New System.Drawing.Point(347, 18)
        Me.txtCFcustomer_id.Name = "txtCFcustomer_id"
        Me.txtCFcustomer_id.ReadOnly = True
        Me.txtCFcustomer_id.Size = New System.Drawing.Size(139, 24)
        Me.txtCFcustomer_id.TabIndex = 6
        '
        'btnCFsearchSN
        '
        Me.btnCFsearchSN.Location = New System.Drawing.Point(233, 19)
        Me.btnCFsearchSN.Name = "btnCFsearchSN"
        Me.btnCFsearchSN.Size = New System.Drawing.Size(51, 24)
        Me.btnCFsearchSN.TabIndex = 2
        Me.btnCFsearchSN.Text = "ค้นหา"
        Me.btnCFsearchSN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ป้อน SN สินค้า"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.btnCRefresh)
        Me.TabPage2.Controls.Add(Me.dgClaims)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(827, 284)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "รายการรับเคลม"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.DarkRed
        Me.Label20.Location = New System.Drawing.Point(721, 265)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 13)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "กด Del เพื่อลบข้อมูล"
        '
        'btnCRefresh
        '
        Me.btnCRefresh.Location = New System.Drawing.Point(6, 255)
        Me.btnCRefresh.Name = "btnCRefresh"
        Me.btnCRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnCRefresh.TabIndex = 36
        Me.btnCRefresh.Text = "Refresh"
        Me.btnCRefresh.UseVisualStyleBackColor = True
        '
        'dgClaims
        '
        Me.dgClaims.AllowUserToAddRows = False
        Me.dgClaims.AllowUserToDeleteRows = False
        Me.dgClaims.AllowUserToOrderColumns = True
        Me.dgClaims.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClaims.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.claims_id, Me.serial_pro, Me.code_pro, Me.bar_code, Me.name_pro, Me.price_buy, Me.price_wholesale, Me.price_technician, Me.price_loyel, Me.price_member, Me.type, Me.unit, Me.symptom, Me.accessory, Me.employee, Me.datetime_save})
        Me.dgClaims.Location = New System.Drawing.Point(6, 6)
        Me.dgClaims.Name = "dgClaims"
        Me.dgClaims.ReadOnly = True
        Me.dgClaims.RowHeadersVisible = False
        Me.dgClaims.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgClaims.Size = New System.Drawing.Size(815, 243)
        Me.dgClaims.TabIndex = 0
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 30
        '
        'claims_id
        '
        Me.claims_id.HeaderText = "รหัสเคลม"
        Me.claims_id.Name = "claims_id"
        Me.claims_id.ReadOnly = True
        '
        'serial_pro
        '
        Me.serial_pro.HeaderText = "SN"
        Me.serial_pro.Name = "serial_pro"
        Me.serial_pro.ReadOnly = True
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        '
        'bar_code
        '
        Me.bar_code.HeaderText = "บาร์โค๊ต"
        Me.bar_code.Name = "bar_code"
        Me.bar_code.ReadOnly = True
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        '
        'price_buy
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle1
        Me.price_buy.HeaderText = "ปกติ"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.ToolTipText = "ราคาปกติ"
        Me.price_buy.Width = 50
        '
        'price_wholesale
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.price_wholesale.DefaultCellStyle = DataGridViewCellStyle2
        Me.price_wholesale.HeaderText = "ขายส่ง"
        Me.price_wholesale.Name = "price_wholesale"
        Me.price_wholesale.ReadOnly = True
        Me.price_wholesale.ToolTipText = "ราคาขายส่ง"
        Me.price_wholesale.Width = 70
        '
        'price_technician
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.price_technician.DefaultCellStyle = DataGridViewCellStyle3
        Me.price_technician.HeaderText = "ช่าง"
        Me.price_technician.Name = "price_technician"
        Me.price_technician.ReadOnly = True
        Me.price_technician.ToolTipText = "ราคาช่าง"
        Me.price_technician.Width = 50
        '
        'price_loyel
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.price_loyel.DefaultCellStyle = DataGridViewCellStyle4
        Me.price_loyel.HeaderText = "ประจำ"
        Me.price_loyel.Name = "price_loyel"
        Me.price_loyel.ReadOnly = True
        Me.price_loyel.ToolTipText = "ราคาลูกค้าประจำ"
        Me.price_loyel.Width = 50
        '
        'price_member
        '
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.price_member.DefaultCellStyle = DataGridViewCellStyle5
        Me.price_member.HeaderText = "สมาชิก"
        Me.price_member.Name = "price_member"
        Me.price_member.ReadOnly = True
        Me.price_member.ToolTipText = "ราคาสมาชิก"
        '
        'type
        '
        Me.type.HeaderText = "ประเภท"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        '
        'unit
        '
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        '
        'symptom
        '
        Me.symptom.HeaderText = "อาการเสีย"
        Me.symptom.Name = "symptom"
        Me.symptom.ReadOnly = True
        '
        'accessory
        '
        Me.accessory.HeaderText = "อุปกรณ์ที่นำมาด้วย"
        Me.accessory.Name = "accessory"
        Me.accessory.ReadOnly = True
        Me.accessory.Width = 150
        '
        'employee
        '
        Me.employee.HeaderText = "พนักงาน"
        Me.employee.Name = "employee"
        Me.employee.ReadOnly = True
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "เวลาบันทึก"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        '
        'ClaimsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 372)
        Me.Controls.Add(Me.btnClaimsAll)
        Me.Controls.Add(Me.claims)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblemployee)
        Me.MaximizeBox = False
        Me.Name = "ClaimsFrm"
        Me.Text = "เคลมสินค้า/เช็ควันที่ซื้อ"
        Me.claims.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgClaims, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTipCF As System.Windows.Forms.ToolTip
    Friend WithEvents lblemployee As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents claims As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCFstatus As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCFclaims_id As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnCFcancel As System.Windows.Forms.Button
    Friend WithEvents btnCFsave As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCFnote As System.Windows.Forms.TextBox
    Friend WithEvents btnCFloadaccessory As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCFaccessory As System.Windows.Forms.TextBox
    Friend WithEvents btnCchangCustomer As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCFsyptom As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCFemployee_sale As System.Windows.Forms.TextBox
    Friend WithEvents lblCFdate As System.Windows.Forms.Label
    Friend WithEvents txtCFdatetime_sale As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCFunit As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCFtype As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCFprice_buy As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCFname_pro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCFbar_code As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCFcode_pro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCFserial_pro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCFcustomer_name As System.Windows.Forms.TextBox
    Friend WithEvents txtCFcustomer_id As System.Windows.Forms.TextBox
    Friend WithEvents txtCFsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents btnCFsearchSN As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgClaims As System.Windows.Forms.DataGridView
    Friend WithEvents btnClaimsAll As System.Windows.Forms.Button
    Friend WithEvents btnCdepositClaims As System.Windows.Forms.Button
    Friend WithEvents btnCRefresh As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtCFprice_members As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCFprice_loyal As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCFprice_technician As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCFprice_wholsale As System.Windows.Forms.TextBox
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serial_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_wholesale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_technician As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_loyel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_member As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accessory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
