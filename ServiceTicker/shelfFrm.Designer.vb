<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shelfFrm
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
        Me.btnSFadd = New System.Windows.Forms.Button()
        Me.btnSFedit = New System.Windows.Forms.Button()
        Me.btnSFdelete = New System.Windows.Forms.Button()
        Me.btnSFclose = New System.Windows.Forms.Button()
        Me.txtSF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgSF = New System.Windows.Forms.DataGridView()
        Me.shelf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgSF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSFadd
        '
        Me.btnSFadd.Location = New System.Drawing.Point(12, 12)
        Me.btnSFadd.Name = "btnSFadd"
        Me.btnSFadd.Size = New System.Drawing.Size(75, 23)
        Me.btnSFadd.TabIndex = 0
        Me.btnSFadd.Text = "เพิ่ม"
        Me.btnSFadd.UseVisualStyleBackColor = True
        '
        'btnSFedit
        '
        Me.btnSFedit.Location = New System.Drawing.Point(93, 12)
        Me.btnSFedit.Name = "btnSFedit"
        Me.btnSFedit.Size = New System.Drawing.Size(75, 23)
        Me.btnSFedit.TabIndex = 1
        Me.btnSFedit.Text = "แก้ไข"
        Me.btnSFedit.UseVisualStyleBackColor = True
        '
        'btnSFdelete
        '
        Me.btnSFdelete.Location = New System.Drawing.Point(174, 12)
        Me.btnSFdelete.Name = "btnSFdelete"
        Me.btnSFdelete.Size = New System.Drawing.Size(75, 23)
        Me.btnSFdelete.TabIndex = 2
        Me.btnSFdelete.Text = "ลบ"
        Me.btnSFdelete.UseVisualStyleBackColor = True
        '
        'btnSFclose
        '
        Me.btnSFclose.Location = New System.Drawing.Point(255, 12)
        Me.btnSFclose.Name = "btnSFclose"
        Me.btnSFclose.Size = New System.Drawing.Size(75, 23)
        Me.btnSFclose.TabIndex = 3
        Me.btnSFclose.Text = "ปิด"
        Me.btnSFclose.UseVisualStyleBackColor = True
        '
        'txtSF
        '
        Me.txtSF.Location = New System.Drawing.Point(56, 41)
        Me.txtSF.Name = "txtSF"
        Me.txtSF.Size = New System.Drawing.Size(274, 20)
        Me.txtSF.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ชั้นวาง"
        '
        'dgSF
        '
        Me.dgSF.AllowUserToAddRows = False
        Me.dgSF.AllowUserToDeleteRows = False
        Me.dgSF.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.shelf})
        Me.dgSF.Location = New System.Drawing.Point(4, 67)
        Me.dgSF.Name = "dgSF"
        Me.dgSF.ReadOnly = True
        Me.dgSF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSF.Size = New System.Drawing.Size(326, 273)
        Me.dgSF.TabIndex = 6
        '
        'shelf
        '
        Me.shelf.HeaderText = "ชั้นวาง"
        Me.shelf.Name = "shelf"
        Me.shelf.ReadOnly = True
        Me.shelf.Width = 250
        '
        'shelfFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 352)
        Me.Controls.Add(Me.dgSF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSF)
        Me.Controls.Add(Me.btnSFclose)
        Me.Controls.Add(Me.btnSFdelete)
        Me.Controls.Add(Me.btnSFedit)
        Me.Controls.Add(Me.btnSFadd)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "shelfFrm"
        Me.Text = "จัดการชั้นวาง"
        CType(Me.dgSF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSFadd As System.Windows.Forms.Button
    Friend WithEvents btnSFedit As System.Windows.Forms.Button
    Friend WithEvents btnSFdelete As System.Windows.Forms.Button
    Friend WithEvents btnSFclose As System.Windows.Forms.Button
    Friend WithEvents txtSF As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgSF As System.Windows.Forms.DataGridView
    Friend WithEvents shelf As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
