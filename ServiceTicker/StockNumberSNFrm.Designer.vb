<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockNumberSNFrm
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
        Me.dgSNSN = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_in = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSNlistPrint = New System.Windows.Forms.Button()
        CType(Me.dgSNSN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgSNSN
        '
        Me.dgSNSN.AllowUserToAddRows = False
        Me.dgSNSN.AllowUserToDeleteRows = False
        Me.dgSNSN.AllowUserToOrderColumns = True
        Me.dgSNSN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSNSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSNSN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.code_pro, Me.sn, Me.name_pro, Me.date_in})
        Me.dgSNSN.Location = New System.Drawing.Point(12, 12)
        Me.dgSNSN.Name = "dgSNSN"
        Me.dgSNSN.RowHeadersVisible = False
        Me.dgSNSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSNSN.Size = New System.Drawing.Size(677, 392)
        Me.dgSNSN.TabIndex = 0
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'sn
        '
        Me.sn.HeaderText = "SN"
        Me.sn.Name = "sn"
        Me.sn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 250
        '
        'date_in
        '
        Me.date_in.HeaderText = "วันที่นำเข้า"
        Me.date_in.Name = "date_in"
        Me.date_in.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_in.Width = 150
        '
        'btnSNlistPrint
        '
        Me.btnSNlistPrint.Location = New System.Drawing.Point(614, 410)
        Me.btnSNlistPrint.Name = "btnSNlistPrint"
        Me.btnSNlistPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnSNlistPrint.TabIndex = 1
        Me.btnSNlistPrint.Text = "พิมพ์"
        Me.btnSNlistPrint.UseVisualStyleBackColor = True
        '
        'StockNumberSNFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 439)
        Me.Controls.Add(Me.btnSNlistPrint)
        Me.Controls.Add(Me.dgSNSN)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StockNumberSNFrm"
        Me.Text = "รายการ SN สินค้า"
        CType(Me.dgSNSN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgSNSN As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_in As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSNlistPrint As System.Windows.Forms.Button
End Class
