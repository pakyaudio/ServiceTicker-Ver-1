<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnClaimsToCusFrm
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
        Me.txtRTCTsearchSN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRCTCsearchSN = New System.Windows.Forms.Button()
        Me.dgRCTC = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRTCTrefresh = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgRCTC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRTCTsearchSN
        '
        Me.txtRTCTsearchSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRTCTsearchSN.Location = New System.Drawing.Point(12, 25)
        Me.txtRTCTsearchSN.Name = "txtRTCTsearchSN"
        Me.txtRTCTsearchSN.Size = New System.Drawing.Size(145, 22)
        Me.txtRTCTsearchSN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ใส่หมายเลข SN สินค้าเคลม"
        '
        'btnRCTCsearchSN
        '
        Me.btnRCTCsearchSN.Location = New System.Drawing.Point(163, 25)
        Me.btnRCTCsearchSN.Name = "btnRCTCsearchSN"
        Me.btnRCTCsearchSN.Size = New System.Drawing.Size(75, 23)
        Me.btnRCTCsearchSN.TabIndex = 2
        Me.btnRCTCsearchSN.Text = "ค้นหา"
        Me.btnRCTCsearchSN.UseVisualStyleBackColor = True
        '
        'dgRCTC
        '
        Me.dgRCTC.AllowUserToAddRows = False
        Me.dgRCTC.AllowUserToDeleteRows = False
        Me.dgRCTC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgRCTC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgRCTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRCTC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.claims_id, Me.customer_id, Me.customer_name, Me.serial_pro, Me.name_pro, Me.datetime_save})
        Me.dgRCTC.Location = New System.Drawing.Point(12, 54)
        Me.dgRCTC.MultiSelect = False
        Me.dgRCTC.Name = "dgRCTC"
        Me.dgRCTC.ReadOnly = True
        Me.dgRCTC.RowHeadersVisible = False
        Me.dgRCTC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRCTC.Size = New System.Drawing.Size(876, 304)
        Me.dgRCTC.TabIndex = 3
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
        Me.claims_id.HeaderText = "หมายเลขเคลม"
        Me.claims_id.Name = "claims_id"
        Me.claims_id.ReadOnly = True
        Me.claims_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.claims_id.Width = 150
        '
        'customer_id
        '
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'customer_name
        '
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'serial_pro
        '
        Me.serial_pro.HeaderText = "SN"
        Me.serial_pro.Name = "serial_pro"
        Me.serial_pro.ReadOnly = True
        Me.serial_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.serial_pro.ToolTipText = "หมายเลขประจำตัวสินค้า"
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 220
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่รับเคลม"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.Width = 150
        '
        'btnRTCTrefresh
        '
        Me.btnRTCTrefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRTCTrefresh.Location = New System.Drawing.Point(813, 364)
        Me.btnRTCTrefresh.Name = "btnRTCTrefresh"
        Me.btnRTCTrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRTCTrefresh.TabIndex = 4
        Me.btnRTCTrefresh.Text = "รีเฟรส"
        Me.ToolTip1.SetToolTip(Me.btnRTCTrefresh, "ดึงข้อมูลเคลมจากฐานข้อมูลอีกครั้ง")
        Me.btnRTCTrefresh.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 374)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 5
        Me.lblemployee.Text = "User"
        '
        'ReturnClaimsToCusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 394)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.btnRTCTrefresh)
        Me.Controls.Add(Me.dgRCTC)
        Me.Controls.Add(Me.btnRCTCsearchSN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRTCTsearchSN)
        Me.Name = "ReturnClaimsToCusFrm"
        Me.Text = "คืนสินค้าเคลม"
        CType(Me.dgRCTC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRTCTsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRCTCsearchSN As System.Windows.Forms.Button
    Friend WithEvents dgRCTC As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serial_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRTCTrefresh As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
