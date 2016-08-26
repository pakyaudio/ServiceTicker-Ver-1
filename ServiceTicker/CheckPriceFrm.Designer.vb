<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckPriceFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtCPsnANDbarcode = New System.Windows.Forms.TextBox()
        Me.txtCPpriceBuy = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCPnamePro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCPwholsale = New System.Windows.Forms.TextBox()
        Me.txtCPtechnician = New System.Windows.Forms.TextBox()
        Me.txtCPloyel = New System.Windows.Forms.TextBox()
        Me.txtCPmember = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtCPsnANDbc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgCP = New System.Windows.Forms.DataGridView()
        Me.sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_wholesale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_technician = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_loyal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_members = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCPprice_cost = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCPcount_num = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgCP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCPsnANDbarcode
        '
        Me.txtCPsnANDbarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCPsnANDbarcode.Location = New System.Drawing.Point(12, 25)
        Me.txtCPsnANDbarcode.Name = "txtCPsnANDbarcode"
        Me.txtCPsnANDbarcode.Size = New System.Drawing.Size(151, 29)
        Me.txtCPsnANDbarcode.TabIndex = 0
        '
        'txtCPpriceBuy
        '
        Me.txtCPpriceBuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCPpriceBuy.Location = New System.Drawing.Point(12, 73)
        Me.txtCPpriceBuy.Name = "txtCPpriceBuy"
        Me.txtCPpriceBuy.ReadOnly = True
        Me.txtCPpriceBuy.Size = New System.Drawing.Size(64, 29)
        Me.txtCPpriceBuy.TabIndex = 1
        Me.txtCPpriceBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ราคาปกติ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SN หรือ บาร์โค๊ต"
        '
        'txtCPnamePro
        '
        Me.txtCPnamePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCPnamePro.Location = New System.Drawing.Point(311, 25)
        Me.txtCPnamePro.Name = "txtCPnamePro"
        Me.txtCPnamePro.ReadOnly = True
        Me.txtCPnamePro.Size = New System.Drawing.Size(225, 29)
        Me.txtCPnamePro.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ชื่อสินค้า"
        '
        'txtCPwholsale
        '
        Me.txtCPwholsale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCPwholsale.Location = New System.Drawing.Point(82, 73)
        Me.txtCPwholsale.Name = "txtCPwholsale"
        Me.txtCPwholsale.ReadOnly = True
        Me.txtCPwholsale.Size = New System.Drawing.Size(65, 29)
        Me.txtCPwholsale.TabIndex = 6
        Me.txtCPwholsale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCPtechnician
        '
        Me.txtCPtechnician.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCPtechnician.Location = New System.Drawing.Point(153, 73)
        Me.txtCPtechnician.Name = "txtCPtechnician"
        Me.txtCPtechnician.ReadOnly = True
        Me.txtCPtechnician.Size = New System.Drawing.Size(65, 29)
        Me.txtCPtechnician.TabIndex = 7
        Me.txtCPtechnician.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCPloyel
        '
        Me.txtCPloyel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCPloyel.Location = New System.Drawing.Point(224, 73)
        Me.txtCPloyel.Name = "txtCPloyel"
        Me.txtCPloyel.ReadOnly = True
        Me.txtCPloyel.Size = New System.Drawing.Size(65, 29)
        Me.txtCPloyel.TabIndex = 8
        Me.txtCPloyel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCPmember
        '
        Me.txtCPmember.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCPmember.Location = New System.Drawing.Point(295, 73)
        Me.txtCPmember.Name = "txtCPmember"
        Me.txtCPmember.ReadOnly = True
        Me.txtCPmember.Size = New System.Drawing.Size(65, 29)
        Me.txtCPmember.TabIndex = 9
        Me.txtCPmember.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(162, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ราคาช่าง"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ราคาขายส่ง"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(221, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ราคาขาประจำ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(295, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ราคาสมาชิก"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(129, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(34, 13)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ค้นหา"
        '
        'txtCPsnANDbc
        '
        Me.txtCPsnANDbc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCPsnANDbc.Location = New System.Drawing.Point(169, 25)
        Me.txtCPsnANDbc.Name = "txtCPsnANDbc"
        Me.txtCPsnANDbc.ReadOnly = True
        Me.txtCPsnANDbc.Size = New System.Drawing.Size(136, 29)
        Me.txtCPsnANDbc.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(172, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "SN/Bar Code"
        '
        'dgCP
        '
        Me.dgCP.AllowUserToAddRows = False
        Me.dgCP.AllowUserToDeleteRows = False
        Me.dgCP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sn, Me.name_pro, Me.price_buy, Me.price_wholesale, Me.price_technician, Me.price_loyal, Me.price_members, Me.price_cost, Me.count_num})
        Me.dgCP.Location = New System.Drawing.Point(12, 129)
        Me.dgCP.Name = "dgCP"
        Me.dgCP.RowHeadersVisible = False
        Me.dgCP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCP.Size = New System.Drawing.Size(524, 140)
        Me.dgCP.TabIndex = 17
        '
        'sn
        '
        Me.sn.HeaderText = "SN/BC"
        Me.sn.Name = "sn"
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        '
        'price_buy
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle1
        Me.price_buy.HeaderText = "ปกติ"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ToolTipText = "ราคาปกติ"
        Me.price_buy.Width = 50
        '
        'price_wholesale
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.price_wholesale.DefaultCellStyle = DataGridViewCellStyle2
        Me.price_wholesale.HeaderText = "ส่ง"
        Me.price_wholesale.Name = "price_wholesale"
        Me.price_wholesale.ToolTipText = "ราคาขายส่ง"
        Me.price_wholesale.Width = 50
        '
        'price_technician
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.price_technician.DefaultCellStyle = DataGridViewCellStyle3
        Me.price_technician.HeaderText = "ช่าง"
        Me.price_technician.Name = "price_technician"
        Me.price_technician.ToolTipText = "ราคาช่าง"
        Me.price_technician.Width = 50
        '
        'price_loyal
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.price_loyal.DefaultCellStyle = DataGridViewCellStyle4
        Me.price_loyal.HeaderText = "ประจำ"
        Me.price_loyal.Name = "price_loyal"
        Me.price_loyal.ToolTipText = "ราคาลูกค้าประจำ"
        Me.price_loyal.Width = 50
        '
        'price_members
        '
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.price_members.DefaultCellStyle = DataGridViewCellStyle5
        Me.price_members.HeaderText = "สมาชิก"
        Me.price_members.Name = "price_members"
        Me.price_members.ToolTipText = "ราคาสมาชิก"
        Me.price_members.Width = 50
        '
        'price_cost
        '
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.price_cost.DefaultCellStyle = DataGridViewCellStyle6
        Me.price_cost.HeaderText = "ทุน"
        Me.price_cost.Name = "price_cost"
        Me.price_cost.ToolTipText = "ราคาทุน"
        Me.price_cost.Width = 50
        '
        'count_num
        '
        DataGridViewCellStyle7.NullValue = "0"
        Me.count_num.DefaultCellStyle = DataGridViewCellStyle7
        Me.count_num.HeaderText = "เหลือ"
        Me.count_num.Name = "count_num"
        Me.count_num.ToolTipText = "จำนวนสินค้าคงเหลือ"
        Me.count_num.Width = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "สินค้าที่หาราคาก่อนหน้านี้"
        '
        'txtCPprice_cost
        '
        Me.txtCPprice_cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCPprice_cost.Location = New System.Drawing.Point(366, 73)
        Me.txtCPprice_cost.Name = "txtCPprice_cost"
        Me.txtCPprice_cost.ReadOnly = True
        Me.txtCPprice_cost.Size = New System.Drawing.Size(65, 29)
        Me.txtCPprice_cost.TabIndex = 19
        Me.txtCPprice_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(376, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "ราคาทุน"
        '
        'txtCPcount_num
        '
        Me.txtCPcount_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCPcount_num.Location = New System.Drawing.Point(437, 73)
        Me.txtCPcount_num.Name = "txtCPcount_num"
        Me.txtCPcount_num.ReadOnly = True
        Me.txtCPcount_num.Size = New System.Drawing.Size(94, 29)
        Me.txtCPcount_num.TabIndex = 21
        Me.txtCPcount_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(461, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "คงเหลือ"
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 273)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 23
        Me.lblemployee.Text = "User"
        '
        'CheckPriceFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 295)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCPcount_num)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCPprice_cost)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgCP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCPsnANDbc)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCPmember)
        Me.Controls.Add(Me.txtCPloyel)
        Me.Controls.Add(Me.txtCPtechnician)
        Me.Controls.Add(Me.txtCPwholsale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCPnamePro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCPpriceBuy)
        Me.Controls.Add(Me.txtCPsnANDbarcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CheckPriceFrm"
        Me.Text = "ตรวจสอบราคา"
        CType(Me.dgCP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCPsnANDbarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtCPpriceBuy As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCPnamePro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCPwholsale As System.Windows.Forms.TextBox
    Friend WithEvents txtCPtechnician As System.Windows.Forms.TextBox
    Friend WithEvents txtCPloyel As System.Windows.Forms.TextBox
    Friend WithEvents txtCPmember As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtCPsnANDbc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgCP As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCPprice_cost As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCPcount_num As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_wholesale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_technician As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_loyal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_members As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
