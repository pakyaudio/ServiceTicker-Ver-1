<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckStoclBarcodeFrm
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
        Me.dgCSBC = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sumL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.เพมToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ลบToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ลบแถวToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCSBCsetStart = New System.Windows.Forms.Button()
        Me.txtCSBCenterBC = New System.Windows.Forms.TextBox()
        Me.txtCSBClastBC = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbPrint = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCSBCfull = New System.Windows.Forms.TextBox()
        Me.txtCSBCfail = New System.Windows.Forms.TextBox()
        Me.txtCSBCcNumPro = New System.Windows.Forms.TextBox()
        Me.txtCSBCtotalPro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCSBCid = New System.Windows.Forms.TextBox()
        Me.btnClearStock = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BGWgetDatat = New System.ComponentModel.BackgroundWorker()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgCSBC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.pbPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCSBC
        '
        Me.dgCSBC.AllowUserToAddRows = False
        Me.dgCSBC.AllowUserToDeleteRows = False
        Me.dgCSBC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCSBC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCSBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCSBC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.code_pro, Me.bar_code, Me.name_pro, Me.price_buy, Me.count_num, Me.count, Me.sumL})
        Me.dgCSBC.Location = New System.Drawing.Point(12, 62)
        Me.dgCSBC.MultiSelect = False
        Me.dgCSBC.Name = "dgCSBC"
        Me.dgCSBC.ReadOnly = True
        Me.dgCSBC.RowHeadersVisible = False
        Me.dgCSBC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCSBC.Size = New System.Drawing.Size(705, 373)
        Me.dgCSBC.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.dgCSBC, "คลิ๊กขวาได้")
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 40
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'bar_code
        '
        Me.bar_code.HeaderText = "บาร์โค๊ต"
        Me.bar_code.Name = "bar_code"
        Me.bar_code.ReadOnly = True
        Me.bar_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'price_buy
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle1
        Me.price_buy.HeaderText = "ราคา"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.ToolTipText = "ราคาขายปกติ"
        Me.price_buy.Width = 70
        '
        'count_num
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.count_num.DefaultCellStyle = DataGridViewCellStyle2
        Me.count_num.HeaderText = "สต็อก"
        Me.count_num.Name = "count_num"
        Me.count_num.ReadOnly = True
        Me.count_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.count_num.ToolTipText = "จำนวนที่มีในสต็อก"
        Me.count_num.Width = 70
        '
        'count
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.count.DefaultCellStyle = DataGridViewCellStyle3
        Me.count.HeaderText = "นับได้"
        Me.count.Name = "count"
        Me.count.ReadOnly = True
        Me.count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.count.ToolTipText = "จำนวนที่นับได้จริง"
        Me.count.Width = 70
        '
        'sumL
        '
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.sumL.DefaultCellStyle = DataGridViewCellStyle4
        Me.sumL.HeaderText = "ขาด/เกิน"
        Me.sumL.Name = "sumL"
        Me.sumL.ReadOnly = True
        Me.sumL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.sumL.Width = 70
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.เพมToolStripMenuItem, Me.ลบToolStripMenuItem, Me.ลบแถวToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(179, 70)
        '
        'เพมToolStripMenuItem
        '
        Me.เพมToolStripMenuItem.Name = "เพมToolStripMenuItem"
        Me.เพมToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.เพมToolStripMenuItem.Text = "เพิ่มจำนวนสินค้าที่นับได้"
        '
        'ลบToolStripMenuItem
        '
        Me.ลบToolStripMenuItem.Name = "ลบToolStripMenuItem"
        Me.ลบToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ลบToolStripMenuItem.Text = "ลบจำนวนสินค้าที่นับได้"
        '
        'ลบแถวToolStripMenuItem
        '
        Me.ลบแถวToolStripMenuItem.Name = "ลบแถวToolStripMenuItem"
        Me.ลบแถวToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ลบแถวToolStripMenuItem.Text = "ลบแถว"
        '
        'btnCSBCsetStart
        '
        Me.btnCSBCsetStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCSBCsetStart.Location = New System.Drawing.Point(12, 12)
        Me.btnCSBCsetStart.Name = "btnCSBCsetStart"
        Me.btnCSBCsetStart.Size = New System.Drawing.Size(152, 44)
        Me.btnCSBCsetStart.TabIndex = 2
        Me.btnCSBCsetStart.Text = "เตรียมข้อมูล"
        Me.btnCSBCsetStart.UseVisualStyleBackColor = True
        '
        'txtCSBCenterBC
        '
        Me.txtCSBCenterBC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCSBCenterBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBCenterBC.Location = New System.Drawing.Point(15, 505)
        Me.txtCSBCenterBC.Name = "txtCSBCenterBC"
        Me.txtCSBCenterBC.Size = New System.Drawing.Size(199, 38)
        Me.txtCSBCenterBC.TabIndex = 0
        Me.txtCSBCenterBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCSBClastBC
        '
        Me.txtCSBClastBC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCSBClastBC.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtCSBClastBC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCSBClastBC.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtCSBClastBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBClastBC.ForeColor = System.Drawing.SystemColors.Info
        Me.txtCSBClastBC.Location = New System.Drawing.Point(12, 441)
        Me.txtCSBClastBC.Name = "txtCSBClastBC"
        Me.txtCSBClastBC.ReadOnly = True
        Me.txtCSBClastBC.Size = New System.Drawing.Size(705, 40)
        Me.txtCSBClastBC.TabIndex = 3
        Me.txtCSBClastBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtCSBClastBC, "บาร์โค๊ตล่าสุด")
        '
        'pbPrint
        '
        Me.pbPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbPrint.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.print_icon
        Me.pbPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbPrint.Location = New System.Drawing.Point(366, 25)
        Me.pbPrint.Name = "pbPrint"
        Me.pbPrint.Size = New System.Drawing.Size(30, 29)
        Me.pbPrint.TabIndex = 16
        Me.pbPrint.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbPrint, "พิมพ์รายการเช็คสต็อก")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 484)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ใส่รหัสบาร์โค๊ตสินค้าที่นี่"
        '
        'txtCSBCfull
        '
        Me.txtCSBCfull.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCSBCfull.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBCfull.Location = New System.Drawing.Point(616, 523)
        Me.txtCSBCfull.Name = "txtCSBCfull"
        Me.txtCSBCfull.ReadOnly = True
        Me.txtCSBCfull.Size = New System.Drawing.Size(101, 38)
        Me.txtCSBCfull.TabIndex = 5
        Me.txtCSBCfull.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCSBCfail
        '
        Me.txtCSBCfail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCSBCfail.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBCfail.Location = New System.Drawing.Point(509, 523)
        Me.txtCSBCfail.Name = "txtCSBCfail"
        Me.txtCSBCfail.ReadOnly = True
        Me.txtCSBCfail.Size = New System.Drawing.Size(101, 38)
        Me.txtCSBCfail.TabIndex = 6
        Me.txtCSBCfail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCSBCcNumPro
        '
        Me.txtCSBCcNumPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCSBCcNumPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBCcNumPro.Location = New System.Drawing.Point(402, 523)
        Me.txtCSBCcNumPro.Name = "txtCSBCcNumPro"
        Me.txtCSBCcNumPro.ReadOnly = True
        Me.txtCSBCcNumPro.Size = New System.Drawing.Size(101, 38)
        Me.txtCSBCcNumPro.TabIndex = 7
        Me.txtCSBCcNumPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCSBCtotalPro
        '
        Me.txtCSBCtotalPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCSBCtotalPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBCtotalPro.Location = New System.Drawing.Point(295, 523)
        Me.txtCSBCtotalPro.Name = "txtCSBCtotalPro"
        Me.txtCSBCtotalPro.ReadOnly = True
        Me.txtCSBCtotalPro.Size = New System.Drawing.Size(101, 38)
        Me.txtCSBCtotalPro.TabIndex = 8
        Me.txtCSBCtotalPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 502)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "สินค้าทั้งหมด"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(434, 502)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "นับได้"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(544, 502)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "หาย"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(654, 502)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "เกิน"
        '
        'txtCSBCid
        '
        Me.txtCSBCid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCSBCid.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBCid.Location = New System.Drawing.Point(402, 25)
        Me.txtCSBCid.Name = "txtCSBCid"
        Me.txtCSBCid.ReadOnly = True
        Me.txtCSBCid.Size = New System.Drawing.Size(315, 31)
        Me.txtCSBCid.TabIndex = 13
        Me.txtCSBCid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClearStock
        '
        Me.btnClearStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClearStock.Location = New System.Drawing.Point(170, 12)
        Me.btnClearStock.Name = "btnClearStock"
        Me.btnClearStock.Size = New System.Drawing.Size(186, 44)
        Me.btnClearStock.TabIndex = 14
        Me.btnClearStock.Text = "เคลียร์ข้อมูลตรวจสอบสต็อก"
        Me.btnClearStock.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(399, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "บันทึกล่าสุด"
        '
        'BGWgetDatat
        '
        Me.BGWgetDatat.WorkerReportsProgress = True
        Me.BGWgetDatat.WorkerSupportsCancellation = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(15, 550)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 17
        Me.lblemployee.Text = "User"
        '
        'CheckStoclBarcodeFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 568)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.pbPrint)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClearStock)
        Me.Controls.Add(Me.txtCSBCid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCSBCtotalPro)
        Me.Controls.Add(Me.txtCSBCcNumPro)
        Me.Controls.Add(Me.txtCSBCfail)
        Me.Controls.Add(Me.txtCSBCfull)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCSBClastBC)
        Me.Controls.Add(Me.txtCSBCenterBC)
        Me.Controls.Add(Me.btnCSBCsetStart)
        Me.Controls.Add(Me.dgCSBC)
        Me.Name = "CheckStoclBarcodeFrm"
        Me.Text = "เช็คสต็อกสินค้าบาร์โค๊ต"
        CType(Me.dgCSBC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.pbPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgCSBC As System.Windows.Forms.DataGridView
    Friend WithEvents btnCSBCsetStart As System.Windows.Forms.Button
    Friend WithEvents txtCSBCenterBC As System.Windows.Forms.TextBox
    Friend WithEvents txtCSBClastBC As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCSBCfull As System.Windows.Forms.TextBox
    Friend WithEvents txtCSBCfail As System.Windows.Forms.TextBox
    Friend WithEvents txtCSBCcNumPro As System.Windows.Forms.TextBox
    Friend WithEvents txtCSBCtotalPro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCSBCid As System.Windows.Forms.TextBox
    Friend WithEvents btnClearStock As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents เพมToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ลบToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ลบแถวToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sumL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pbPrint As System.Windows.Forms.PictureBox
    Friend WithEvents BGWgetDatat As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
