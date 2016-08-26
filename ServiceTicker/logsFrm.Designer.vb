<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logsFrm
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
        Me.dgLOGSdata = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLOGSgetdata = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTipLogs = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgLOGSdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgLOGSdata
        '
        Me.dgLOGSdata.AllowUserToAddRows = False
        Me.dgLOGSdata.AllowUserToDeleteRows = False
        Me.dgLOGSdata.AllowUserToOrderColumns = True
        Me.dgLOGSdata.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgLOGSdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLOGSdata.Location = New System.Drawing.Point(12, 91)
        Me.dgLOGSdata.Name = "dgLOGSdata"
        Me.dgLOGSdata.ReadOnly = True
        Me.dgLOGSdata.RowHeadersVisible = False
        Me.dgLOGSdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLOGSdata.Size = New System.Drawing.Size(672, 436)
        Me.dgLOGSdata.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(148, 22)
        Me.DateTimePicker1.TabIndex = 1
        Me.ToolTipLogs.SetToolTip(Me.DateTimePicker1, "วันที่เริ่มต้น")
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(191, 38)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(157, 22)
        Me.DateTimePicker2.TabIndex = 2
        Me.ToolTipLogs.SetToolTip(Me.DateTimePicker2, "วันที่สิ้นสุด")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ถึง"
        '
        'btnLOGSgetdata
        '
        Me.btnLOGSgetdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLOGSgetdata.Location = New System.Drawing.Point(354, 38)
        Me.btnLOGSgetdata.Name = "btnLOGSgetdata"
        Me.btnLOGSgetdata.Size = New System.Drawing.Size(75, 23)
        Me.btnLOGSgetdata.TabIndex = 4
        Me.btnLOGSgetdata.Text = "ค้นหา"
        Me.btnLOGSgetdata.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "เลือกวันที่เริ่มต้นและวันที่สิ้นสุดของช่วงเวลาที่ต้องการเรียกดูข้อมูล"
        '
        'ToolTipLogs
        '
        Me.ToolTipLogs.AutoPopDelay = 5000
        Me.ToolTipLogs.InitialDelay = 300
        Me.ToolTipLogs.IsBalloon = True
        Me.ToolTipLogs.ReshowDelay = 300
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 62)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 6
        Me.lblemployee.Text = "User"
        '
        'logsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 543)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLOGSgetdata)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.dgLOGSdata)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "logsFrm"
        Me.Text = "บันทึกการเข้าระบบ"
        CType(Me.dgLOGSdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgLOGSdata As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLOGSgetdata As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTipLogs As System.Windows.Forms.ToolTip
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
