<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductColorFrm
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
        Me.lblProductNameNote = New System.Windows.Forms.Label()
        Me.dgProductName = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProductNameNote
        '
        Me.lblProductNameNote.AutoSize = True
        Me.lblProductNameNote.ForeColor = System.Drawing.Color.Red
        Me.lblProductNameNote.Location = New System.Drawing.Point(14, 79)
        Me.lblProductNameNote.Name = "lblProductNameNote"
        Me.lblProductNameNote.Size = New System.Drawing.Size(202, 13)
        Me.lblProductNameNote.TabIndex = 23
        Me.lblProductNameNote.Text = "คลิ๊กเลือกหน้าตารางเพื่อแก้ไขหรือลบข้อมูล"
        '
        'dgProductName
        '
        Me.dgProductName.AllowUserToAddRows = False
        Me.dgProductName.AllowUserToDeleteRows = False
        Me.dgProductName.AllowUserToOrderColumns = True
        Me.dgProductName.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgProductName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProductName.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.product_color})
        Me.dgProductName.Location = New System.Drawing.Point(12, 98)
        Me.dgProductName.Name = "dgProductName"
        Me.dgProductName.ReadOnly = True
        Me.dgProductName.RowHeadersVisible = False
        Me.dgProductName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProductName.Size = New System.Drawing.Size(323, 283)
        Me.dgProductName.TabIndex = 22
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ID.Width = 40
        '
        'product_color
        '
        Me.product_color.HeaderText = "สีตัวเครื่อง"
        Me.product_color.Name = "product_color"
        Me.product_color.ReadOnly = True
        Me.product_color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.product_color.ToolTipText = "สีตัวเครื่อง"
        Me.product_color.Width = 260
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(40, 47)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(13, 13)
        Me.lblProductName.TabIndex = 21
        Me.lblProductName.Text = "สี"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(59, 44)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(276, 20)
        Me.txtProductName.TabIndex = 20
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(260, 15)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "&ปิด"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(179, 15)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 18
        Me.btnDel.Text = "&ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(97, 15)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "&แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(14, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "&เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(9, 384)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 24
        Me.lblemployee.Text = "User"
        '
        'ProductColorFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 402)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.lblProductNameNote)
        Me.Controls.Add(Me.dgProductName)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductColorFrm"
        Me.Text = "สีตัวเครื่อง"
        CType(Me.dgProductName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProductNameNote As System.Windows.Forms.Label
    Friend WithEvents dgProductName As System.Windows.Forms.DataGridView
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents product_color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
