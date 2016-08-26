<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class barcode_snFrm
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
        Me.txtBCSNnumStart = New System.Windows.Forms.TextBox()
        Me.txtBCSNnumEnd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBCSNdesciption = New System.Windows.Forms.TextBox()
        Me.txtBCSNtextFront = New System.Windows.Forms.TextBox()
        Me.btnBCSNcreate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBCSNnumStart
        '
        Me.txtBCSNnumStart.Location = New System.Drawing.Point(58, 12)
        Me.txtBCSNnumStart.Name = "txtBCSNnumStart"
        Me.txtBCSNnumStart.Size = New System.Drawing.Size(100, 20)
        Me.txtBCSNnumStart.TabIndex = 0
        '
        'txtBCSNnumEnd
        '
        Me.txtBCSNnumEnd.Location = New System.Drawing.Point(189, 12)
        Me.txtBCSNnumEnd.Name = "txtBCSNnumEnd"
        Me.txtBCSNnumEnd.Size = New System.Drawing.Size(100, 20)
        Me.txtBCSNnumEnd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ถึง"
        '
        'txtBCSNdesciption
        '
        Me.txtBCSNdesciption.Location = New System.Drawing.Point(11, 38)
        Me.txtBCSNdesciption.Name = "txtBCSNdesciption"
        Me.txtBCSNdesciption.Size = New System.Drawing.Size(278, 20)
        Me.txtBCSNdesciption.TabIndex = 3
        '
        'txtBCSNtextFront
        '
        Me.txtBCSNtextFront.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBCSNtextFront.Location = New System.Drawing.Point(11, 12)
        Me.txtBCSNtextFront.MaxLength = 3
        Me.txtBCSNtextFront.Name = "txtBCSNtextFront"
        Me.txtBCSNtextFront.Size = New System.Drawing.Size(41, 20)
        Me.txtBCSNtextFront.TabIndex = 0
        '
        'btnBCSNcreate
        '
        Me.btnBCSNcreate.Location = New System.Drawing.Point(214, 64)
        Me.btnBCSNcreate.Name = "btnBCSNcreate"
        Me.btnBCSNcreate.Size = New System.Drawing.Size(75, 23)
        Me.btnBCSNcreate.TabIndex = 4
        Me.btnBCSNcreate.Text = "สร้าง"
        Me.btnBCSNcreate.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(323, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(469, 79)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'barcode_snFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 565)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBCSNcreate)
        Me.Controls.Add(Me.txtBCSNtextFront)
        Me.Controls.Add(Me.txtBCSNdesciption)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBCSNnumEnd)
        Me.Controls.Add(Me.txtBCSNnumStart)
        Me.Name = "barcode_snFrm"
        Me.Text = "พิมพ์ป้ายบาร์โค๊ต"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBCSNnumStart As System.Windows.Forms.TextBox
    Friend WithEvents txtBCSNnumEnd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBCSNdesciption As System.Windows.Forms.TextBox
    Friend WithEvents txtBCSNtextFront As System.Windows.Forms.TextBox
    Friend WithEvents btnBCSNcreate As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
