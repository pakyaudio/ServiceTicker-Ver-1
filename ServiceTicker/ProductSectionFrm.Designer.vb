<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductSectionFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPSid = New System.Windows.Forms.Label()
        Me.lblPSSearch = New System.Windows.Forms.Label()
        Me.lblPSname = New System.Windows.Forms.Label()
        Me.txtPSid = New System.Windows.Forms.TextBox()
        Me.txtPSName = New System.Windows.Forms.TextBox()
        Me.btnPSgetall = New System.Windows.Forms.Button()
        Me.btnPSSearch = New System.Windows.Forms.Button()
        Me.txtPSsearch = New System.Windows.Forms.TextBox()
        Me.dgPS = New System.Windows.Forms.DataGridView()
        Me.btnPSadd = New System.Windows.Forms.Button()
        Me.btnPSdel = New System.Windows.Forms.Button()
        Me.btnPSedit = New System.Windows.Forms.Button()
        CType(Me.dgPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(14, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ดับเบิ้ลคลิ๊กเพื่อเลือกข้อมูลมาแก้ไขหรือลบ"
        '
        'lblPSid
        '
        Me.lblPSid.AutoSize = True
        Me.lblPSid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPSid.Location = New System.Drawing.Point(295, 180)
        Me.lblPSid.Name = "lblPSid"
        Me.lblPSid.Size = New System.Drawing.Size(26, 13)
        Me.lblPSid.TabIndex = 24
        Me.lblPSid.Text = "รหัส"
        '
        'lblPSSearch
        '
        Me.lblPSSearch.AutoSize = True
        Me.lblPSSearch.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPSSearch.Location = New System.Drawing.Point(12, 208)
        Me.lblPSSearch.Name = "lblPSSearch"
        Me.lblPSSearch.Size = New System.Drawing.Size(113, 13)
        Me.lblPSSearch.TabIndex = 23
        Me.lblPSSearch.Text = "ค้นหา ใส่ชื่อลงในฃ่องนี้"
        '
        'lblPSname
        '
        Me.lblPSname.AutoSize = True
        Me.lblPSname.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPSname.Location = New System.Drawing.Point(376, 180)
        Me.lblPSname.Name = "lblPSname"
        Me.lblPSname.Size = New System.Drawing.Size(83, 13)
        Me.lblPSname.TabIndex = 22
        Me.lblPSname.Text = "ชื่อประเภทสินค้า"
        '
        'txtPSid
        '
        Me.txtPSid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPSid.Location = New System.Drawing.Point(298, 196)
        Me.txtPSid.Name = "txtPSid"
        Me.txtPSid.Size = New System.Drawing.Size(75, 24)
        Me.txtPSid.TabIndex = 21
        '
        'txtPSName
        '
        Me.txtPSName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPSName.Location = New System.Drawing.Point(379, 196)
        Me.txtPSName.Name = "txtPSName"
        Me.txtPSName.Size = New System.Drawing.Size(165, 24)
        Me.txtPSName.TabIndex = 20
        '
        'btnPSgetall
        '
        Me.btnPSgetall.Location = New System.Drawing.Point(193, 226)
        Me.btnPSgetall.Name = "btnPSgetall"
        Me.btnPSgetall.Size = New System.Drawing.Size(54, 23)
        Me.btnPSgetall.TabIndex = 19
        Me.btnPSgetall.Text = "ทั้งหมด"
        Me.btnPSgetall.UseVisualStyleBackColor = True
        '
        'btnPSSearch
        '
        Me.btnPSSearch.Location = New System.Drawing.Point(133, 226)
        Me.btnPSSearch.Name = "btnPSSearch"
        Me.btnPSSearch.Size = New System.Drawing.Size(54, 23)
        Me.btnPSSearch.TabIndex = 18
        Me.btnPSSearch.Text = "ค้นหา"
        Me.btnPSSearch.UseVisualStyleBackColor = True
        '
        'txtPSsearch
        '
        Me.txtPSsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPSsearch.Location = New System.Drawing.Point(12, 224)
        Me.txtPSsearch.Name = "txtPSsearch"
        Me.txtPSsearch.Size = New System.Drawing.Size(115, 24)
        Me.txtPSsearch.TabIndex = 17
        '
        'dgPS
        '
        Me.dgPS.AllowUserToAddRows = False
        Me.dgPS.AllowUserToDeleteRows = False
        Me.dgPS.AllowUserToOrderColumns = True
        Me.dgPS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPS.Location = New System.Drawing.Point(12, 12)
        Me.dgPS.Name = "dgPS"
        Me.dgPS.ReadOnly = True
        Me.dgPS.RowHeadersVisible = False
        Me.dgPS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPS.Size = New System.Drawing.Size(532, 155)
        Me.dgPS.TabIndex = 16
        '
        'btnPSadd
        '
        Me.btnPSadd.Location = New System.Drawing.Point(298, 226)
        Me.btnPSadd.Name = "btnPSadd"
        Me.btnPSadd.Size = New System.Drawing.Size(75, 23)
        Me.btnPSadd.TabIndex = 15
        Me.btnPSadd.Text = "เพิ่ม"
        Me.btnPSadd.UseVisualStyleBackColor = True
        '
        'btnPSdel
        '
        Me.btnPSdel.Location = New System.Drawing.Point(469, 226)
        Me.btnPSdel.Name = "btnPSdel"
        Me.btnPSdel.Size = New System.Drawing.Size(75, 23)
        Me.btnPSdel.TabIndex = 14
        Me.btnPSdel.Text = "ลบ"
        Me.btnPSdel.UseVisualStyleBackColor = True
        '
        'btnPSedit
        '
        Me.btnPSedit.Location = New System.Drawing.Point(379, 226)
        Me.btnPSedit.Name = "btnPSedit"
        Me.btnPSedit.Size = New System.Drawing.Size(75, 23)
        Me.btnPSedit.TabIndex = 13
        Me.btnPSedit.Text = "แก้ไข"
        Me.btnPSedit.UseVisualStyleBackColor = True
        '
        'ProductSectionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 263)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPSid)
        Me.Controls.Add(Me.lblPSSearch)
        Me.Controls.Add(Me.lblPSname)
        Me.Controls.Add(Me.txtPSid)
        Me.Controls.Add(Me.txtPSName)
        Me.Controls.Add(Me.btnPSgetall)
        Me.Controls.Add(Me.btnPSSearch)
        Me.Controls.Add(Me.txtPSsearch)
        Me.Controls.Add(Me.dgPS)
        Me.Controls.Add(Me.btnPSadd)
        Me.Controls.Add(Me.btnPSdel)
        Me.Controls.Add(Me.btnPSedit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductSectionFrm"
        Me.Text = "ประเภทสินค้า"
        CType(Me.dgPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPSid As System.Windows.Forms.Label
    Friend WithEvents lblPSSearch As System.Windows.Forms.Label
    Friend WithEvents lblPSname As System.Windows.Forms.Label
    Friend WithEvents txtPSid As System.Windows.Forms.TextBox
    Friend WithEvents txtPSName As System.Windows.Forms.TextBox
    Friend WithEvents btnPSgetall As System.Windows.Forms.Button
    Friend WithEvents btnPSSearch As System.Windows.Forms.Button
    Friend WithEvents txtPSsearch As System.Windows.Forms.TextBox
    Friend WithEvents dgPS As System.Windows.Forms.DataGridView
    Friend WithEvents btnPSadd As System.Windows.Forms.Button
    Friend WithEvents btnPSdel As System.Windows.Forms.Button
    Friend WithEvents btnPSedit As System.Windows.Forms.Button
End Class
