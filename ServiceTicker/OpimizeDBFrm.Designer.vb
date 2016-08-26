<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpimizeDBFrm
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
        Me.btnOpt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRepair = New System.Windows.Forms.Button()
        Me.bgw_Opti = New System.ComponentModel.BackgroundWorker()
        Me.bgw_repair = New System.ComponentModel.BackgroundWorker()
        Me.lblemployee = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOpt
        '
        Me.btnOpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOpt.Location = New System.Drawing.Point(12, 32)
        Me.btnOpt.Name = "btnOpt"
        Me.btnOpt.Size = New System.Drawing.Size(354, 38)
        Me.btnOpt.TabIndex = 0
        Me.btnOpt.Text = "เพิ่มประสิทธิภาพฐานข้อมูล"
        Me.btnOpt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ข้อควรปฎิบัติ ควรสำรองข้อมูลก่อนทำการปรับปรุงฐานข้อมูล"
        '
        'btnRepair
        '
        Me.btnRepair.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRepair.Location = New System.Drawing.Point(12, 76)
        Me.btnRepair.Name = "btnRepair"
        Me.btnRepair.Size = New System.Drawing.Size(354, 38)
        Me.btnRepair.TabIndex = 2
        Me.btnRepair.Text = "ซ่อมแซมฐานข้อมูล"
        Me.btnRepair.UseVisualStyleBackColor = True
        '
        'bgw_Opti
        '
        Me.bgw_Opti.WorkerReportsProgress = True
        Me.bgw_Opti.WorkerSupportsCancellation = True
        '
        'bgw_repair
        '
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(9, 117)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 3
        Me.lblemployee.Text = "User"
        '
        'OpimizeDBFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 133)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.btnRepair)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOpt)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpimizeDBFrm"
        Me.Text = "ปรับปรุง/ซ่อมแซม/เพิ่มประสิทธิภาพ ฐานข้อมูล"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRepair As System.Windows.Forms.Button
    Friend WithEvents bgw_Opti As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgw_repair As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
