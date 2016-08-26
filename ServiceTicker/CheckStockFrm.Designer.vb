<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckStockFrm
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
        Me.btnCSgetdata = New System.Windows.Forms.Button()
        Me.txtCSSSNnow = New System.Windows.Forms.TextBox()
        Me.dgCSDontCheck = New System.Windows.Forms.DataGridView()
        Me.serial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCScheck = New System.Windows.Forms.DataGridView()
        Me.sn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCSdontCheck = New System.Windows.Forms.TextBox()
        Me.txtCScheck = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTipCS = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCSsnLast = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCSenter = New System.Windows.Forms.Button()
        Me.btnCSCheckPrint = New System.Windows.Forms.Button()
        Me.btnCSdontCheckPrint = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCSid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        Me.BGWgetData = New System.ComponentModel.BackgroundWorker()
        Me.BGWsnNow = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgCSDontCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCScheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCSgetdata
        '
        Me.btnCSgetdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCSgetdata.Location = New System.Drawing.Point(12, 12)
        Me.btnCSgetdata.Name = "btnCSgetdata"
        Me.btnCSgetdata.Size = New System.Drawing.Size(136, 31)
        Me.btnCSgetdata.TabIndex = 1
        Me.btnCSgetdata.Text = "เตรียมข้อมูล"
        Me.ToolTipCS.SetToolTip(Me.btnCSgetdata, "การเตรียมข้อมูลอาจจะใช้เวลาขึ้นอยู่กับจำนวนสินค้าที่มี")
        Me.btnCSgetdata.UseVisualStyleBackColor = True
        '
        'txtCSSSNnow
        '
        Me.txtCSSSNnow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSSSNnow.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCSSSNnow.Location = New System.Drawing.Point(625, 14)
        Me.txtCSSSNnow.Name = "txtCSSSNnow"
        Me.txtCSSSNnow.Size = New System.Drawing.Size(208, 26)
        Me.txtCSSSNnow.TabIndex = 0
        Me.txtCSSSNnow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCS.SetToolTip(Me.txtCSSSNnow, "ยิงรหัส SN ที่นี่")
        '
        'dgCSDontCheck
        '
        Me.dgCSDontCheck.AllowUserToAddRows = False
        Me.dgCSDontCheck.AllowUserToDeleteRows = False
        Me.dgCSDontCheck.AllowUserToOrderColumns = True
        Me.dgCSDontCheck.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgCSDontCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCSDontCheck.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serial, Me.name_pro1})
        Me.dgCSDontCheck.Location = New System.Drawing.Point(12, 132)
        Me.dgCSDontCheck.Name = "dgCSDontCheck"
        Me.dgCSDontCheck.ReadOnly = True
        Me.dgCSDontCheck.RowHeadersVisible = False
        Me.dgCSDontCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCSDontCheck.Size = New System.Drawing.Size(450, 345)
        Me.dgCSDontCheck.TabIndex = 3
        '
        'serial
        '
        Me.serial.DataPropertyName = "serial"
        Me.serial.HeaderText = "Serial"
        Me.serial.Name = "serial"
        Me.serial.ReadOnly = True
        Me.serial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.serial.Width = 170
        '
        'name_pro1
        '
        Me.name_pro1.DataPropertyName = "name_pro1"
        Me.name_pro1.HeaderText = "ชื่อสินค้า"
        Me.name_pro1.Name = "name_pro1"
        Me.name_pro1.ReadOnly = True
        Me.name_pro1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro1.Width = 250
        '
        'dgCScheck
        '
        Me.dgCScheck.AllowUserToAddRows = False
        Me.dgCScheck.AllowUserToDeleteRows = False
        Me.dgCScheck.AllowUserToOrderColumns = True
        Me.dgCScheck.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCScheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCScheck.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sn2, Me.name_pro2})
        Me.dgCScheck.Location = New System.Drawing.Point(484, 132)
        Me.dgCScheck.Name = "dgCScheck"
        Me.dgCScheck.ReadOnly = True
        Me.dgCScheck.RowHeadersVisible = False
        Me.dgCScheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCScheck.Size = New System.Drawing.Size(454, 345)
        Me.dgCScheck.TabIndex = 4
        '
        'sn2
        '
        Me.sn2.HeaderText = "Serial"
        Me.sn2.Name = "sn2"
        Me.sn2.ReadOnly = True
        Me.sn2.Width = 170
        '
        'name_pro2
        '
        Me.name_pro2.DataPropertyName = "name_pro2"
        Me.name_pro2.HeaderText = "ชื่อสินค้า"
        Me.name_pro2.Name = "name_pro2"
        Me.name_pro2.ReadOnly = True
        Me.name_pro2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro2.Width = 250
        '
        'txtCSdontCheck
        '
        Me.txtCSdontCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSdontCheck.ForeColor = System.Drawing.Color.Red
        Me.txtCSdontCheck.Location = New System.Drawing.Point(352, 483)
        Me.txtCSdontCheck.Name = "txtCSdontCheck"
        Me.txtCSdontCheck.ReadOnly = True
        Me.txtCSdontCheck.Size = New System.Drawing.Size(110, 26)
        Me.txtCSdontCheck.TabIndex = 5
        Me.txtCSdontCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCScheck
        '
        Me.txtCScheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCScheck.ForeColor = System.Drawing.Color.Red
        Me.txtCScheck.Location = New System.Drawing.Point(828, 483)
        Me.txtCScheck.Name = "txtCScheck"
        Me.txtCScheck.ReadOnly = True
        Me.txtCScheck.Size = New System.Drawing.Size(110, 26)
        Me.txtCScheck.TabIndex = 6
        Me.txtCScheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 486)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "คงเหลือ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(766, 486)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "คงเหลือ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(145, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ยังไม่ได้ตรวจสอบ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(677, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "ตรวจสอบแล้ว"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(491, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ยิง Serial Number"
        '
        'ToolTipCS
        '
        Me.ToolTipCS.IsBalloon = True
        '
        'txtCSsnLast
        '
        Me.txtCSsnLast.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCSsnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSsnLast.ForeColor = System.Drawing.Color.Maroon
        Me.txtCSsnLast.Location = New System.Drawing.Point(484, 49)
        Me.txtCSsnLast.Name = "txtCSsnLast"
        Me.txtCSsnLast.ReadOnly = True
        Me.txtCSsnLast.Size = New System.Drawing.Size(454, 26)
        Me.txtCSsnLast.TabIndex = 15
        Me.txtCSsnLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipCS.SetToolTip(Me.txtCSsnLast, "Serial Number ล่าสุด")
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(154, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 31)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "เคลียร์ข้อมูลตรวจสอบสต็อก"
        Me.ToolTipCS.SetToolTip(Me.Button1, "ล้างรายการตรวจสอบสต็อกทั้งหมด")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCSenter
        '
        Me.btnCSenter.Image = Global.ServiceTicker.My.Resources.Resources.gray_classic_search_icon
        Me.btnCSenter.Location = New System.Drawing.Point(839, 15)
        Me.btnCSenter.Name = "btnCSenter"
        Me.btnCSenter.Size = New System.Drawing.Size(32, 25)
        Me.btnCSenter.TabIndex = 14
        Me.ToolTipCS.SetToolTip(Me.btnCSenter, "ค้นหา")
        Me.btnCSenter.UseVisualStyleBackColor = True
        '
        'btnCSCheckPrint
        '
        Me.btnCSCheckPrint.Image = Global.ServiceTicker.My.Resources.Resources.print_icon
        Me.btnCSCheckPrint.Location = New System.Drawing.Point(900, 93)
        Me.btnCSCheckPrint.Name = "btnCSCheckPrint"
        Me.btnCSCheckPrint.Size = New System.Drawing.Size(38, 33)
        Me.btnCSCheckPrint.TabIndex = 10
        Me.ToolTipCS.SetToolTip(Me.btnCSCheckPrint, "พิมรายการตรวจสอบแล้ว")
        Me.btnCSCheckPrint.UseVisualStyleBackColor = True
        '
        'btnCSdontCheckPrint
        '
        Me.btnCSdontCheckPrint.Image = Global.ServiceTicker.My.Resources.Resources.print_icon
        Me.btnCSdontCheckPrint.Location = New System.Drawing.Point(419, 93)
        Me.btnCSdontCheckPrint.Name = "btnCSdontCheckPrint"
        Me.btnCSdontCheckPrint.Size = New System.Drawing.Size(43, 33)
        Me.btnCSdontCheckPrint.TabIndex = 9
        Me.ToolTipCS.SetToolTip(Me.btnCSdontCheckPrint, "พิมพ์รายการยังไม่ได้ตรวจสอบ")
        Me.btnCSdontCheckPrint.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(437, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "ล่าสุด"
        '
        'txtCSid
        '
        Me.txtCSid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSid.Location = New System.Drawing.Point(98, 49)
        Me.txtCSid.Name = "txtCSid"
        Me.txtCSid.ReadOnly = True
        Me.txtCSid.Size = New System.Drawing.Size(140, 22)
        Me.txtCSid.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "ChackStock ID"
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 483)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 20
        Me.lblemployee.Text = "User"
        '
        'BGWgetData
        '
        Me.BGWgetData.WorkerReportsProgress = True
        Me.BGWgetData.WorkerSupportsCancellation = True
        '
        'BGWsnNow
        '
        Me.BGWsnNow.WorkerReportsProgress = True
        Me.BGWsnNow.WorkerSupportsCancellation = True
        '
        'CheckStockFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 517)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCSid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCSsnLast)
        Me.Controls.Add(Me.btnCSenter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCSCheckPrint)
        Me.Controls.Add(Me.btnCSdontCheckPrint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCScheck)
        Me.Controls.Add(Me.txtCSdontCheck)
        Me.Controls.Add(Me.dgCScheck)
        Me.Controls.Add(Me.dgCSDontCheck)
        Me.Controls.Add(Me.txtCSSSNnow)
        Me.Controls.Add(Me.btnCSgetdata)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CheckStockFrm"
        Me.Text = "เช็คสต็อก"
        CType(Me.dgCSDontCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCScheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCSgetdata As System.Windows.Forms.Button
    Friend WithEvents txtCSSSNnow As System.Windows.Forms.TextBox
    Friend WithEvents dgCSDontCheck As System.Windows.Forms.DataGridView
    Friend WithEvents dgCScheck As System.Windows.Forms.DataGridView
    Friend WithEvents txtCSdontCheck As System.Windows.Forms.TextBox
    Friend WithEvents txtCScheck As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCSdontCheckPrint As System.Windows.Forms.Button
    Friend WithEvents btnCSCheckPrint As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTipCS As System.Windows.Forms.ToolTip
    Friend WithEvents btnCSenter As System.Windows.Forms.Button
    Friend WithEvents txtCSsnLast As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCSid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents serial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblemployee As System.Windows.Forms.Label
    Friend WithEvents BGWgetData As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGWsnNow As System.ComponentModel.BackgroundWorker
End Class
