<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleCompanyFrm
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
        Me.btnSCgetallData = New System.Windows.Forms.Button()
        Me.btnSCsearch = New System.Windows.Forms.Button()
        Me.lblSCcontact = New System.Windows.Forms.Label()
        Me.lblSCtel = New System.Windows.Forms.Label()
        Me.lblSCaddress = New System.Windows.Forms.Label()
        Me.lblSCname = New System.Windows.Forms.Label()
        Me.lblSCid = New System.Windows.Forms.Label()
        Me.txtSCsearch = New System.Windows.Forms.TextBox()
        Me.btnSCdel = New System.Windows.Forms.Button()
        Me.btnSCadd = New System.Windows.Forms.Button()
        Me.btnSCedit = New System.Windows.Forms.Button()
        Me.txtSCcontact = New System.Windows.Forms.TextBox()
        Me.txtSCtel = New System.Windows.Forms.TextBox()
        Me.txtSCaddress = New System.Windows.Forms.TextBox()
        Me.txtSCname = New System.Windows.Forms.TextBox()
        Me.txtSCid = New System.Windows.Forms.TextBox()
        Me.dgSC = New System.Windows.Forms.DataGridView()
        Me.sale_company_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_line = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_facebook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_website = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_tax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSCfax = New System.Windows.Forms.TextBox()
        Me.txtSCline = New System.Windows.Forms.TextBox()
        Me.txtSCfacebook = New System.Windows.Forms.TextBox()
        Me.txtSCemail = New System.Windows.Forms.TextBox()
        Me.txtSCwebsite = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSCtax = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgSC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSCgetallData
        '
        Me.btnSCgetallData.Location = New System.Drawing.Point(285, 10)
        Me.btnSCgetallData.Name = "btnSCgetallData"
        Me.btnSCgetallData.Size = New System.Drawing.Size(75, 23)
        Me.btnSCgetallData.TabIndex = 2
        Me.btnSCgetallData.Text = "แสดงทั้งหมด"
        Me.btnSCgetallData.UseVisualStyleBackColor = True
        '
        'btnSCsearch
        '
        Me.btnSCsearch.Location = New System.Drawing.Point(204, 10)
        Me.btnSCsearch.Name = "btnSCsearch"
        Me.btnSCsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSCsearch.TabIndex = 1
        Me.btnSCsearch.Text = "ค้นหา"
        Me.btnSCsearch.UseVisualStyleBackColor = True
        '
        'lblSCcontact
        '
        Me.lblSCcontact.AutoSize = True
        Me.lblSCcontact.Location = New System.Drawing.Point(20, 329)
        Me.lblSCcontact.Name = "lblSCcontact"
        Me.lblSCcontact.Size = New System.Drawing.Size(41, 13)
        Me.lblSCcontact.TabIndex = 31
        Me.lblSCcontact.Text = "ผู้ติดต่อ"
        '
        'lblSCtel
        '
        Me.lblSCtel.AutoSize = True
        Me.lblSCtel.Location = New System.Drawing.Point(36, 355)
        Me.lblSCtel.Name = "lblSCtel"
        Me.lblSCtel.Size = New System.Drawing.Size(25, 13)
        Me.lblSCtel.TabIndex = 30
        Me.lblSCtel.Text = "โทร"
        '
        'lblSCaddress
        '
        Me.lblSCaddress.AutoSize = True
        Me.lblSCaddress.Location = New System.Drawing.Point(34, 303)
        Me.lblSCaddress.Name = "lblSCaddress"
        Me.lblSCaddress.Size = New System.Drawing.Size(27, 13)
        Me.lblSCaddress.TabIndex = 29
        Me.lblSCaddress.Text = "ที่อยู่"
        '
        'lblSCname
        '
        Me.lblSCname.AutoSize = True
        Me.lblSCname.Location = New System.Drawing.Point(13, 277)
        Me.lblSCname.Name = "lblSCname"
        Me.lblSCname.Size = New System.Drawing.Size(48, 13)
        Me.lblSCname.TabIndex = 28
        Me.lblSCname.Text = "ชื่อบริษัท"
        '
        'lblSCid
        '
        Me.lblSCid.AutoSize = True
        Me.lblSCid.Location = New System.Drawing.Point(35, 251)
        Me.lblSCid.Name = "lblSCid"
        Me.lblSCid.Size = New System.Drawing.Size(26, 13)
        Me.lblSCid.TabIndex = 27
        Me.lblSCid.Text = "รหัส"
        '
        'txtSCsearch
        '
        Me.txtSCsearch.Location = New System.Drawing.Point(12, 12)
        Me.txtSCsearch.Name = "txtSCsearch"
        Me.txtSCsearch.Size = New System.Drawing.Size(186, 20)
        Me.txtSCsearch.TabIndex = 0
        '
        'btnSCdel
        '
        Me.btnSCdel.Location = New System.Drawing.Point(447, 508)
        Me.btnSCdel.Name = "btnSCdel"
        Me.btnSCdel.Size = New System.Drawing.Size(75, 23)
        Me.btnSCdel.TabIndex = 14
        Me.btnSCdel.Text = "ลบ"
        Me.btnSCdel.UseVisualStyleBackColor = True
        '
        'btnSCadd
        '
        Me.btnSCadd.Location = New System.Drawing.Point(148, 508)
        Me.btnSCadd.Name = "btnSCadd"
        Me.btnSCadd.Size = New System.Drawing.Size(75, 23)
        Me.btnSCadd.TabIndex = 13
        Me.btnSCadd.Text = "เพิ่ม"
        Me.btnSCadd.UseVisualStyleBackColor = True
        '
        'btnSCedit
        '
        Me.btnSCedit.Location = New System.Drawing.Point(67, 508)
        Me.btnSCedit.Name = "btnSCedit"
        Me.btnSCedit.Size = New System.Drawing.Size(75, 23)
        Me.btnSCedit.TabIndex = 12
        Me.btnSCedit.Text = "แก้ไข"
        Me.btnSCedit.UseVisualStyleBackColor = True
        '
        'txtSCcontact
        '
        Me.txtSCcontact.Location = New System.Drawing.Point(67, 326)
        Me.txtSCcontact.Name = "txtSCcontact"
        Me.txtSCcontact.Size = New System.Drawing.Size(455, 20)
        Me.txtSCcontact.TabIndex = 5
        '
        'txtSCtel
        '
        Me.txtSCtel.Location = New System.Drawing.Point(67, 352)
        Me.txtSCtel.Name = "txtSCtel"
        Me.txtSCtel.Size = New System.Drawing.Size(455, 20)
        Me.txtSCtel.TabIndex = 6
        '
        'txtSCaddress
        '
        Me.txtSCaddress.Location = New System.Drawing.Point(67, 300)
        Me.txtSCaddress.Name = "txtSCaddress"
        Me.txtSCaddress.Size = New System.Drawing.Size(455, 20)
        Me.txtSCaddress.TabIndex = 4
        '
        'txtSCname
        '
        Me.txtSCname.Location = New System.Drawing.Point(67, 274)
        Me.txtSCname.Name = "txtSCname"
        Me.txtSCname.Size = New System.Drawing.Size(456, 20)
        Me.txtSCname.TabIndex = 3
        '
        'txtSCid
        '
        Me.txtSCid.Location = New System.Drawing.Point(67, 248)
        Me.txtSCid.Name = "txtSCid"
        Me.txtSCid.Size = New System.Drawing.Size(98, 20)
        Me.txtSCid.TabIndex = 18
        '
        'dgSC
        '
        Me.dgSC.AllowUserToAddRows = False
        Me.dgSC.AllowUserToDeleteRows = False
        Me.dgSC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sale_company_id, Me.sale_company_name, Me.sale_company_address, Me.sale_company_tel, Me.sale_company_contact, Me.sale_company_fax, Me.sale_company_line, Me.sale_company_email, Me.sale_company_facebook, Me.sale_company_website, Me.sale_company_tax})
        Me.dgSC.Location = New System.Drawing.Point(12, 39)
        Me.dgSC.Name = "dgSC"
        Me.dgSC.ReadOnly = True
        Me.dgSC.RowHeadersVisible = False
        Me.dgSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSC.Size = New System.Drawing.Size(510, 203)
        Me.dgSC.TabIndex = 17
        '
        'sale_company_id
        '
        Me.sale_company_id.HeaderText = "รหัสบริษัท"
        Me.sale_company_id.Name = "sale_company_id"
        Me.sale_company_id.ReadOnly = True
        '
        'sale_company_name
        '
        Me.sale_company_name.HeaderText = "ชื่อบริษัท"
        Me.sale_company_name.Name = "sale_company_name"
        Me.sale_company_name.ReadOnly = True
        '
        'sale_company_address
        '
        Me.sale_company_address.HeaderText = "ที่อยู่"
        Me.sale_company_address.Name = "sale_company_address"
        Me.sale_company_address.ReadOnly = True
        '
        'sale_company_tel
        '
        Me.sale_company_tel.HeaderText = "เบอร์โทร"
        Me.sale_company_tel.Name = "sale_company_tel"
        Me.sale_company_tel.ReadOnly = True
        '
        'sale_company_contact
        '
        Me.sale_company_contact.HeaderText = "ผู้ติดต่อ"
        Me.sale_company_contact.Name = "sale_company_contact"
        Me.sale_company_contact.ReadOnly = True
        '
        'sale_company_fax
        '
        Me.sale_company_fax.HeaderText = "FAX"
        Me.sale_company_fax.Name = "sale_company_fax"
        Me.sale_company_fax.ReadOnly = True
        '
        'sale_company_line
        '
        Me.sale_company_line.HeaderText = "LINE"
        Me.sale_company_line.Name = "sale_company_line"
        Me.sale_company_line.ReadOnly = True
        '
        'sale_company_email
        '
        Me.sale_company_email.HeaderText = "E-Mail"
        Me.sale_company_email.Name = "sale_company_email"
        Me.sale_company_email.ReadOnly = True
        '
        'sale_company_facebook
        '
        Me.sale_company_facebook.HeaderText = "Facebook"
        Me.sale_company_facebook.Name = "sale_company_facebook"
        Me.sale_company_facebook.ReadOnly = True
        '
        'sale_company_website
        '
        Me.sale_company_website.HeaderText = "Web Site"
        Me.sale_company_website.Name = "sale_company_website"
        Me.sale_company_website.ReadOnly = True
        '
        'sale_company_tax
        '
        Me.sale_company_tax.HeaderText = "หมายเลขผู้เสียภาษี"
        Me.sale_company_tax.Name = "sale_company_tax"
        Me.sale_company_tax.ReadOnly = True
        Me.sale_company_tax.Width = 150
        '
        'txtSCfax
        '
        Me.txtSCfax.Location = New System.Drawing.Point(67, 378)
        Me.txtSCfax.Name = "txtSCfax"
        Me.txtSCfax.Size = New System.Drawing.Size(456, 20)
        Me.txtSCfax.TabIndex = 7
        '
        'txtSCline
        '
        Me.txtSCline.Location = New System.Drawing.Point(67, 404)
        Me.txtSCline.Name = "txtSCline"
        Me.txtSCline.Size = New System.Drawing.Size(455, 20)
        Me.txtSCline.TabIndex = 8
        '
        'txtSCfacebook
        '
        Me.txtSCfacebook.Location = New System.Drawing.Point(67, 430)
        Me.txtSCfacebook.Name = "txtSCfacebook"
        Me.txtSCfacebook.Size = New System.Drawing.Size(455, 20)
        Me.txtSCfacebook.TabIndex = 9
        '
        'txtSCemail
        '
        Me.txtSCemail.Location = New System.Drawing.Point(67, 456)
        Me.txtSCemail.Name = "txtSCemail"
        Me.txtSCemail.Size = New System.Drawing.Size(455, 20)
        Me.txtSCemail.TabIndex = 10
        '
        'txtSCwebsite
        '
        Me.txtSCwebsite.Location = New System.Drawing.Point(67, 482)
        Me.txtSCwebsite.Name = "txtSCwebsite"
        Me.txtSCwebsite.Size = New System.Drawing.Size(455, 20)
        Me.txtSCwebsite.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "FAX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 407)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "LINE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 433)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "FaceBook"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 459)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 485)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "WebSite"
        '
        'txtSCtax
        '
        Me.txtSCtax.Location = New System.Drawing.Point(247, 248)
        Me.txtSCtax.Name = "txtSCtax"
        Me.txtSCtax.Size = New System.Drawing.Size(107, 20)
        Me.txtSCtax.TabIndex = 44
        Me.txtSCtax.Text = "0000000000000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(172, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "เลขผู้เสียภาษี"
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(5, 530)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 46
        Me.lblemployee.Text = "User"
        '
        'SaleCompanyFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 546)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSCtax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSCwebsite)
        Me.Controls.Add(Me.txtSCemail)
        Me.Controls.Add(Me.txtSCfacebook)
        Me.Controls.Add(Me.txtSCline)
        Me.Controls.Add(Me.txtSCfax)
        Me.Controls.Add(Me.btnSCgetallData)
        Me.Controls.Add(Me.btnSCsearch)
        Me.Controls.Add(Me.lblSCcontact)
        Me.Controls.Add(Me.lblSCtel)
        Me.Controls.Add(Me.lblSCaddress)
        Me.Controls.Add(Me.lblSCname)
        Me.Controls.Add(Me.lblSCid)
        Me.Controls.Add(Me.txtSCsearch)
        Me.Controls.Add(Me.btnSCdel)
        Me.Controls.Add(Me.btnSCadd)
        Me.Controls.Add(Me.btnSCedit)
        Me.Controls.Add(Me.txtSCcontact)
        Me.Controls.Add(Me.txtSCtel)
        Me.Controls.Add(Me.txtSCaddress)
        Me.Controls.Add(Me.txtSCname)
        Me.Controls.Add(Me.txtSCid)
        Me.Controls.Add(Me.dgSC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SaleCompanyFrm"
        Me.Text = "รายชื่อบริษัทที่สั่งซื้อสินค้า"
        CType(Me.dgSC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSCgetallData As System.Windows.Forms.Button
    Friend WithEvents btnSCsearch As System.Windows.Forms.Button
    Friend WithEvents lblSCcontact As System.Windows.Forms.Label
    Friend WithEvents lblSCtel As System.Windows.Forms.Label
    Friend WithEvents lblSCaddress As System.Windows.Forms.Label
    Friend WithEvents lblSCname As System.Windows.Forms.Label
    Friend WithEvents lblSCid As System.Windows.Forms.Label
    Friend WithEvents txtSCsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSCdel As System.Windows.Forms.Button
    Friend WithEvents btnSCadd As System.Windows.Forms.Button
    Friend WithEvents btnSCedit As System.Windows.Forms.Button
    Friend WithEvents txtSCcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtSCtel As System.Windows.Forms.TextBox
    Friend WithEvents txtSCaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSCname As System.Windows.Forms.TextBox
    Friend WithEvents txtSCid As System.Windows.Forms.TextBox
    Friend WithEvents dgSC As System.Windows.Forms.DataGridView
    Friend WithEvents txtSCfax As System.Windows.Forms.TextBox
    Friend WithEvents txtSCline As System.Windows.Forms.TextBox
    Friend WithEvents txtSCfacebook As System.Windows.Forms.TextBox
    Friend WithEvents txtSCemail As System.Windows.Forms.TextBox
    Friend WithEvents txtSCwebsite As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSCtax As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents sale_company_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_fax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_line As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_facebook As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_website As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_tax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
