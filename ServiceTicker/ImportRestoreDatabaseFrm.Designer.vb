<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportRestoreDatabaseFrm
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
        Me.txtIRDBpath = New System.Windows.Forms.TextBox()
        Me.searchSQLfile = New System.Windows.Forms.Button()
        Me.btnIRDBimport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'txtIRDBpath
        '
        Me.txtIRDBpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtIRDBpath.Location = New System.Drawing.Point(12, 19)
        Me.txtIRDBpath.Name = "txtIRDBpath"
        Me.txtIRDBpath.Size = New System.Drawing.Size(465, 26)
        Me.txtIRDBpath.TabIndex = 0
        '
        'searchSQLfile
        '
        Me.searchSQLfile.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.folder_explore
        Me.searchSQLfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.searchSQLfile.Location = New System.Drawing.Point(483, 7)
        Me.searchSQLfile.Name = "searchSQLfile"
        Me.searchSQLfile.Size = New System.Drawing.Size(44, 38)
        Me.searchSQLfile.TabIndex = 1
        Me.searchSQLfile.UseVisualStyleBackColor = True
        '
        'btnIRDBimport
        '
        Me.btnIRDBimport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnIRDBimport.Location = New System.Drawing.Point(298, 51)
        Me.btnIRDBimport.Name = "btnIRDBimport"
        Me.btnIRDBimport.Size = New System.Drawing.Size(179, 36)
        Me.btnIRDBimport.TabIndex = 2
        Me.btnIRDBimport.Text = "นำเข้าฐานข้อมูล"
        Me.btnIRDBimport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "เลือกไฟล์ฐานข้อมูลที่สำรองไว้ แล้ว นำเข้าฐานข้อมูล"
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 76)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 4
        Me.lblemployee.Text = "User"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ImportRestoreDatabaseFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 98)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIRDBimport)
        Me.Controls.Add(Me.searchSQLfile)
        Me.Controls.Add(Me.txtIRDBpath)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImportRestoreDatabaseFrm"
        Me.ShowIcon = False
        Me.Text = "Import/Restore Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIRDBpath As System.Windows.Forms.TextBox
    Friend WithEvents searchSQLfile As System.Windows.Forms.Button
    Friend WithEvents btnIRDBimport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblemployee As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
