<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaxInvoiceSelectProFrm
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
        Me.cbbTISPpro = New System.Windows.Forms.ComboBox()
        Me.dgTISP = New System.Windows.Forms.DataGridView()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTISPselect = New System.Windows.Forms.Button()
        CType(Me.dgTISP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbbTISPpro
        '
        Me.cbbTISPpro.FormattingEnabled = True
        Me.cbbTISPpro.Location = New System.Drawing.Point(12, 12)
        Me.cbbTISPpro.Name = "cbbTISPpro"
        Me.cbbTISPpro.Size = New System.Drawing.Size(218, 21)
        Me.cbbTISPpro.TabIndex = 0
        '
        'dgTISP
        '
        Me.dgTISP.AllowUserToAddRows = False
        Me.dgTISP.AllowUserToDeleteRows = False
        Me.dgTISP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgTISP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTISP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_pro, Me.bar_code, Me.name_pro, Me.type, Me.unit, Me.price_buy})
        Me.dgTISP.Location = New System.Drawing.Point(12, 39)
        Me.dgTISP.MultiSelect = False
        Me.dgTISP.Name = "dgTISP"
        Me.dgTISP.ReadOnly = True
        Me.dgTISP.RowHeadersVisible = False
        Me.dgTISP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTISP.Size = New System.Drawing.Size(582, 310)
        Me.dgTISP.TabIndex = 1
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
        'price_buy
        '
        Me.price_buy.HeaderText = "ราคาปกติ"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        '
        'btnTISPselect
        '
        Me.btnTISPselect.Location = New System.Drawing.Point(519, 12)
        Me.btnTISPselect.Name = "btnTISPselect"
        Me.btnTISPselect.Size = New System.Drawing.Size(75, 23)
        Me.btnTISPselect.TabIndex = 2
        Me.btnTISPselect.Text = "เลือก"
        Me.btnTISPselect.UseVisualStyleBackColor = True
        '
        'TaxInvoiceSelectProFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 361)
        Me.Controls.Add(Me.btnTISPselect)
        Me.Controls.Add(Me.dgTISP)
        Me.Controls.Add(Me.cbbTISPpro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TaxInvoiceSelectProFrm"
        Me.Text = "เลือกสินค้า"
        CType(Me.dgTISP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbbTISPpro As System.Windows.Forms.ComboBox
    Friend WithEvents dgTISP As System.Windows.Forms.DataGridView
    Friend WithEvents btnTISPselect As System.Windows.Forms.Button
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
