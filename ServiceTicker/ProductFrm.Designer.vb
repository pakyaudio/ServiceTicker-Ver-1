<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductFrm
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
        Me.lblProductNote = New System.Windows.Forms.Label()
        Me.dgProductType = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_sec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblProductType = New System.Windows.Forms.Label()
        Me.txtProductType = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgProductType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProductNote
        '
        Me.lblProductNote.AutoSize = True
        Me.lblProductNote.ForeColor = System.Drawing.Color.Red
        Me.lblProductNote.Location = New System.Drawing.Point(12, 76)
        Me.lblProductNote.Name = "lblProductNote"
        Me.lblProductNote.Size = New System.Drawing.Size(182, 13)
        Me.lblProductNote.TabIndex = 15
        Me.lblProductNote.Text = "คลิ๊กเลือกตารางเพื่อแก้ไขหรือลบข้อมูล"
        '
        'dgProductType
        '
        Me.dgProductType.AllowUserToAddRows = False
        Me.dgProductType.AllowUserToDeleteRows = False
        Me.dgProductType.AllowUserToOrderColumns = True
        Me.dgProductType.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgProductType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProductType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.product_sec})
        Me.dgProductType.Location = New System.Drawing.Point(10, 95)
        Me.dgProductType.Name = "dgProductType"
        Me.dgProductType.ReadOnly = True
        Me.dgProductType.RowHeadersVisible = False
        Me.dgProductType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProductType.Size = New System.Drawing.Size(323, 283)
        Me.dgProductType.TabIndex = 14
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ID.Width = 40
        '
        'product_sec
        '
        Me.product_sec.HeaderText = "ประเภทสินค้า"
        Me.product_sec.Name = "product_sec"
        Me.product_sec.ReadOnly = True
        Me.product_sec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.product_sec.Width = 260
        '
        'lblProductType
        '
        Me.lblProductType.AutoSize = True
        Me.lblProductType.Location = New System.Drawing.Point(7, 44)
        Me.lblProductType.Name = "lblProductType"
        Me.lblProductType.Size = New System.Drawing.Size(44, 13)
        Me.lblProductType.TabIndex = 13
        Me.lblProductType.Text = "ประเภท"
        '
        'txtProductType
        '
        Me.txtProductType.Location = New System.Drawing.Point(57, 41)
        Me.txtProductType.Name = "txtProductType"
        Me.txtProductType.Size = New System.Drawing.Size(276, 20)
        Me.txtProductType.TabIndex = 12
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(258, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&ปิด"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(177, 12)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 10
        Me.btnDel.Text = "&ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(95, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "&แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "&เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(7, 381)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 16
        Me.lblemployee.Text = "User"
        '
        'ProductFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 400)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.lblProductNote)
        Me.Controls.Add(Me.dgProductType)
        Me.Controls.Add(Me.lblProductType)
        Me.Controls.Add(Me.txtProductType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductFrm"
        Me.Text = "ประเภทสินค้า"
        CType(Me.dgProductType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProductNote As System.Windows.Forms.Label
    Friend WithEvents dgProductType As System.Windows.Forms.DataGridView
    Friend WithEvents lblProductType As System.Windows.Forms.Label
    Friend WithEvents txtProductType As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents product_sec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
