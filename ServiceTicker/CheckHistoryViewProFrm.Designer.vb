<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckHistoryViewProFrm
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
        Me.dgCHVP = New System.Windows.Forms.DataGridView()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_in = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtVHCPfixid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVHCPcheckVaruntee = New System.Windows.Forms.Button()
        CType(Me.dgCHVP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCHVP
        '
        Me.dgCHVP.AllowUserToAddRows = False
        Me.dgCHVP.AllowUserToDeleteRows = False
        Me.dgCHVP.AllowUserToOrderColumns = True
        Me.dgCHVP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCHVP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCHVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCHVP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_pro, Me.bar_code, Me.sn, Me.name_pro, Me.date_in, Me.datetime_save, Me.employee})
        Me.dgCHVP.Location = New System.Drawing.Point(12, 35)
        Me.dgCHVP.MultiSelect = False
        Me.dgCHVP.Name = "dgCHVP"
        Me.dgCHVP.ReadOnly = True
        Me.dgCHVP.RowHeadersVisible = False
        Me.dgCHVP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCHVP.Size = New System.Drawing.Size(766, 312)
        Me.dgCHVP.TabIndex = 0
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
        'sn
        '
        Me.sn.HeaderText = "SN"
        Me.sn.Name = "sn"
        Me.sn.ReadOnly = True
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        '
        'date_in
        '
        Me.date_in.HeaderText = "วันที่นำเข้าระบบ"
        Me.date_in.Name = "date_in"
        Me.date_in.ReadOnly = True
        Me.date_in.Width = 130
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่ขาย"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        '
        'employee
        '
        Me.employee.HeaderText = "พนักงาน"
        Me.employee.Name = "employee"
        Me.employee.ReadOnly = True
        '
        'txtVHCPfixid
        '
        Me.txtVHCPfixid.Location = New System.Drawing.Point(72, 9)
        Me.txtVHCPfixid.Name = "txtVHCPfixid"
        Me.txtVHCPfixid.ReadOnly = True
        Me.txtVHCPfixid.Size = New System.Drawing.Size(227, 20)
        Me.txtVHCPfixid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "เลขใบซ่อม"
        '
        'btnVHCPcheckVaruntee
        '
        Me.btnVHCPcheckVaruntee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVHCPcheckVaruntee.Location = New System.Drawing.Point(605, 353)
        Me.btnVHCPcheckVaruntee.Name = "btnVHCPcheckVaruntee"
        Me.btnVHCPcheckVaruntee.Size = New System.Drawing.Size(173, 34)
        Me.btnVHCPcheckVaruntee.TabIndex = 3
        Me.btnVHCPcheckVaruntee.Text = "เช็คประกันสินค้า"
        Me.btnVHCPcheckVaruntee.UseVisualStyleBackColor = True
        '
        'CheckHistoryViewProFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 394)
        Me.Controls.Add(Me.btnVHCPcheckVaruntee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVHCPfixid)
        Me.Controls.Add(Me.dgCHVP)
        Me.Name = "CheckHistoryViewProFrm"
        Me.Text = "ดูรายการสินค้า/อะไหล่"
        CType(Me.dgCHVP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgCHVP As System.Windows.Forms.DataGridView
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_in As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtVHCPfixid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVHCPcheckVaruntee As System.Windows.Forms.Button
End Class
