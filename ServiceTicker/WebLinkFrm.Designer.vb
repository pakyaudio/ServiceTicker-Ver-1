<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebLinkFrm
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.web_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.web = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtWLwebname = New System.Windows.Forms.TextBox()
        Me.txtWLurl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnWLcancel = New System.Windows.Forms.Button()
        Me.btnWLedit = New System.Windows.Forms.Button()
        Me.btnWLadd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(281, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(618, 543)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://google.com", System.UriKind.Absolute)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.web_name, Me.web})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(263, 414)
        Me.DataGridView1.TabIndex = 1
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 20
        '
        'web_name
        '
        Me.web_name.HeaderText = "ชื่อเว็บไซต์"
        Me.web_name.Name = "web_name"
        Me.web_name.ReadOnly = True
        Me.web_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.web_name.ToolTipText = "ชื่อเว็บไซต์"
        Me.web_name.Width = 110
        '
        'web
        '
        Me.web.DataPropertyName = "web"
        Me.web.HeaderText = "URL"
        Me.web.Name = "web"
        Me.web.ReadOnly = True
        Me.web.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.web.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.web.Width = 110
        '
        'txtWLwebname
        '
        Me.txtWLwebname.Location = New System.Drawing.Point(76, 461)
        Me.txtWLwebname.Name = "txtWLwebname"
        Me.txtWLwebname.Size = New System.Drawing.Size(185, 20)
        Me.txtWLwebname.TabIndex = 2
        '
        'txtWLurl
        '
        Me.txtWLurl.Location = New System.Drawing.Point(76, 504)
        Me.txtWLurl.Name = "txtWLurl"
        Me.txtWLurl.Size = New System.Drawing.Size(185, 20)
        Me.txtWLurl.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 464)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ชื่อเว็บไซต์"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 507)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "URL"
        '
        'btnWLcancel
        '
        Me.btnWLcancel.Location = New System.Drawing.Point(186, 526)
        Me.btnWLcancel.Name = "btnWLcancel"
        Me.btnWLcancel.Size = New System.Drawing.Size(75, 23)
        Me.btnWLcancel.TabIndex = 6
        Me.btnWLcancel.Text = "ยกเลิก"
        Me.btnWLcancel.UseVisualStyleBackColor = True
        '
        'btnWLedit
        '
        Me.btnWLedit.Location = New System.Drawing.Point(105, 526)
        Me.btnWLedit.Name = "btnWLedit"
        Me.btnWLedit.Size = New System.Drawing.Size(75, 23)
        Me.btnWLedit.TabIndex = 7
        Me.btnWLedit.Text = "แก้ไข"
        Me.btnWLedit.UseVisualStyleBackColor = True
        '
        'btnWLadd
        '
        Me.btnWLadd.Location = New System.Drawing.Point(24, 526)
        Me.btnWLadd.Name = "btnWLadd"
        Me.btnWLadd.Size = New System.Drawing.Size(75, 23)
        Me.btnWLadd.TabIndex = 8
        Me.btnWLadd.Text = "เพิ่ม"
        Me.btnWLadd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 445)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ตัวอย่าง เอเซอร์, ACER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 488)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ตัวอย่าง google.co.th, acer.co.th"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ดับเบิ้ลคลิ๊กเพื่อเลือก"
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(3, 550)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 12
        Me.lblemployee.Text = "User"
        '
        'WebLinkFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 567)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnWLadd)
        Me.Controls.Add(Me.btnWLedit)
        Me.Controls.Add(Me.btnWLcancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWLurl)
        Me.Controls.Add(Me.txtWLwebname)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "WebLinkFrm"
        Me.Text = "เช็คประกันจากผู้ผลิตสินค้า/จำหน่าย"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtWLwebname As System.Windows.Forms.TextBox
    Friend WithEvents txtWLurl As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnWLcancel As System.Windows.Forms.Button
    Friend WithEvents btnWLedit As System.Windows.Forms.Button
    Friend WithEvents btnWLadd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents web_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents web As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
