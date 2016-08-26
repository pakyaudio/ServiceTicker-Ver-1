<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComfixCustomerStatusFrm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgCCcusStatus = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_comfix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgCCproHot = New System.Windows.Forms.DataGridView()
        Me.noph = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCCgetdata = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCCsearch = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblemployee = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgCCcusStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgCCproHot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 464)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgCCcusStatus)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(752, 438)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "สถิติลูกค้า(ซ่อม)"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgCCcusStatus
        '
        Me.dgCCcusStatus.AllowUserToAddRows = False
        Me.dgCCcusStatus.AllowUserToDeleteRows = False
        Me.dgCCcusStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCCcusStatus.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCCcusStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCCcusStatus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.cus_id, Me.cus_name, Me.total_comfix, Me.total_price})
        Me.dgCCcusStatus.Location = New System.Drawing.Point(6, 6)
        Me.dgCCcusStatus.Name = "dgCCcusStatus"
        Me.dgCCcusStatus.RowHeadersVisible = False
        Me.dgCCcusStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCCcusStatus.Size = New System.Drawing.Size(740, 426)
        Me.dgCCcusStatus.TabIndex = 0
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'cus_id
        '
        Me.cus_id.HeaderText = "รหัสลูกค้า"
        Me.cus_id.Name = "cus_id"
        Me.cus_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cus_id.Width = 140
        '
        'cus_name
        '
        Me.cus_name.HeaderText = "ชื่อลูกค้า"
        Me.cus_name.Name = "cus_name"
        Me.cus_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cus_name.Width = 200
        '
        'total_comfix
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.total_comfix.DefaultCellStyle = DataGridViewCellStyle1
        Me.total_comfix.HeaderText = "จำนวนครังที่เข้ารับบริการ"
        Me.total_comfix.Name = "total_comfix"
        Me.total_comfix.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_comfix.Width = 150
        '
        'total_price
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.total_price.DefaultCellStyle = DataGridViewCellStyle2
        Me.total_price.HeaderText = "รวมราคาที่เข้าใช้บริการ"
        Me.total_price.Name = "total_price"
        Me.total_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_price.Width = 150
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgCCproHot)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(752, 442)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "สถิติอะไหล่ขายดี"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgCCproHot
        '
        Me.dgCCproHot.AllowUserToAddRows = False
        Me.dgCCproHot.AllowUserToDeleteRows = False
        Me.dgCCproHot.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCCproHot.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCCproHot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCCproHot.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noph, Me.code_pro, Me.name_pro, Me.total_buy})
        Me.dgCCproHot.Location = New System.Drawing.Point(6, 6)
        Me.dgCCproHot.Name = "dgCCproHot"
        Me.dgCCproHot.RowHeadersVisible = False
        Me.dgCCproHot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCCproHot.Size = New System.Drawing.Size(740, 430)
        Me.dgCCproHot.TabIndex = 0
        '
        'noph
        '
        Me.noph.HeaderText = "No."
        Me.noph.Name = "noph"
        Me.noph.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.noph.Width = 30
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.Width = 150
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 250
        '
        'total_buy
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = "0"
        Me.total_buy.DefaultCellStyle = DataGridViewCellStyle3
        Me.total_buy.HeaderText = "จำนวนที่ขายได้"
        Me.total_buy.Name = "total_buy"
        Me.total_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_buy.Width = 150
        '
        'btnCCgetdata
        '
        Me.btnCCgetdata.Location = New System.Drawing.Point(574, 2)
        Me.btnCCgetdata.Name = "btnCCgetdata"
        Me.btnCCgetdata.Size = New System.Drawing.Size(104, 26)
        Me.btnCCgetdata.TabIndex = 1
        Me.btnCCgetdata.Text = "รวบรวมข้อมูล"
        Me.btnCCgetdata.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Location = New System.Drawing.Point(86, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        Me.DateTimePicker1.Value = New Date(2015, 11, 2, 15, 44, 53, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = ""
        Me.DateTimePicker2.Location = New System.Drawing.Point(317, 3)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ถึง"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(16, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "ตามวันที่"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "แสดงตามวันที่")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnCCsearch
        '
        Me.btnCCsearch.Location = New System.Drawing.Point(524, 2)
        Me.btnCCsearch.Name = "btnCCsearch"
        Me.btnCCsearch.Size = New System.Drawing.Size(44, 26)
        Me.btnCCsearch.TabIndex = 6
        Me.btnCCsearch.Text = "ค้นหา"
        Me.btnCCsearch.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(684, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(88, 26)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "พิมพ์"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(315, 33)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 1
        Me.lblemployee.Text = "User"
        '
        'ComfixCustomerStatusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 502)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCCsearch)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnCCgetdata)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ComfixCustomerStatusFrm"
        Me.Text = "สถิติงานซ่อม"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgCCcusStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgCCproHot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgCCcusStatus As System.Windows.Forms.DataGridView
    Friend WithEvents btnCCgetdata As System.Windows.Forms.Button
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_comfix As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnCCsearch As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgCCproHot As System.Windows.Forms.DataGridView
    Friend WithEvents noph As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
