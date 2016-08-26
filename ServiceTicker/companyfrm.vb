Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class CompanyFrm

    'V2 เสร็จสมบูรณ์ 20141221
    Private Sub btnCompanyCancel_Click(sender As Object, e As EventArgs) Handles btnCompanyCancel.Click
        Me.Close()
    End Sub
    Private Sub loadimages()
        Try
            Mainfrm.lblMainStatus.Text = "SELECT images"
            strSQL = "SELECT images FROM company"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.lblCompanyImagePath.Text = Dr("images")
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(Me.lblCompanyImagePath.Text)
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "SELECT images ผิดพลาด " & ex.Message
            MsgBox("ไม่พบไฟล์โลโก้", MsgBoxStyle.Critical, "ไฟล์หายไปไหน")
        End Try
    End Sub
   
    Private Sub startfrm()
        Call loadimages()
        Call disableTextBoxes(Me)
        Try
        'get data from database to textbox
        dt = New DataTable
            Mainfrm.lblMainStatus.Text = "SELECT com_name,com_address,com_tel,com_fax,com_tax,com_line,com_facebook,com_email,com_website FROM company"
        strSQL = "SELECT * FROM company"
        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        Call open_connection()
        dtAdapter.Fill(dt)
        If dt.Rows.Count > 0 Then
            Me.txtCompanyName.Text = dt.Rows(0)("com_name")
            Me.txtCompanyAddress.Text = dt.Rows(0)("com_address")
            Me.txtCompanyTel.Text = dt.Rows(0)("com_tel")
            Me.txtCompanyFax.Text = dt.Rows(0)("com_fax")
            Me.txtCompanyTax.Text = dt.Rows(0)("com_tax")
            Me.txtCompanyLine.Text = dt.Rows(0)("com_line")
            Me.txtCompanyFacebook.Text = dt.Rows(0)("com_facebook")
            Me.txtCompanyEmail.Text = dt.Rows(0)("com_email")
            Me.txtCompanyWebsite.Text = dt.Rows(0)("com_website")
     
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "SELECT * FROM company ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub companyfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
        Me.Icon = Mainfrm.Icon
    End Sub
    Private Sub updateData()
        Try
        Mainfrm.lblMainStatus.Text = "UPDATE company"
        'update data to company table
        strSQL = "UPDATE company SET com_name='" & Me.txtCompanyName.Text & "'," _
                                  & "com_address='" & Me.txtCompanyAddress.Text & "'," _
                                  & "com_tel='" & Me.txtCompanyTel.Text & "'," _
                                  & "com_fax='" & Me.txtCompanyFax.Text & "'," _
                                  & "com_tax='" & Me.txtCompanyTax.Text & "'," _
                                  & "com_line='" & Me.txtCompanyLine.Text & "'," _
                                  & "com_facebook='" & Me.txtCompanyFacebook.Text & "'," _
                                  & "com_email='" & Me.txtCompanyEmail.Text & "'," _
                                  & "com_website='" & Me.txtCompanyWebsite.Text & "'"
                             
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Dim result As Integer
        Call open_connection()
        result = cmd.ExecuteNonQuery()
        If result = 1 Then
            MsgBox("ปรับปรุงข้อมูลแล้ว", MsgBoxStyle.Information, _
                   "ปรับปรุงข้อมูลสำเร็จ")
        Else
            MsgBox("ไม่สามารถปรับปรุงข้อมูล", MsgBoxStyle.Information, _
                   "ปรับปรุงข้อมูลไม่สำเร็จ")
        End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "UPDATE company ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnCompanyEdit_Click(sender As Object, e As EventArgs) Handles btnCompanyEdit.Click
        If Me.btnCompanyEdit.Text = "&แก้ไข" Then
            Call enableTextBoxes(Me)
            Me.btnCompanyEdit.Text = "&บันทึก"
            Exit Sub
        ElseIf Me.btnCompanyEdit.Text = "&บันทึก" Then
            Dim textBoxes = Me.Controls.OfType(Of TextBox)()

            For Each t In textBoxes
                If String.IsNullOrEmpty(t.Text) Then
                    MsgBox("กรุณากรอกข้อมูลให้ครบทุกช่อง หากไม่มีให้ - ไว้", MsgBoxStyle.Exclamation, "ตรวจสอบการป้อนข้อมูล")
                    Exit Sub
                End If
            Next t
            
            Call updateData()
            Me.btnCompanyEdit.Text = "&แก้ไข"
        End If
        Call startfrm()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fpath As New OpenFileDialog
        fpath.InitialDirectory = "C:\"
        fpath.Filter = "Picture File|*.jpg;*.jpeg;*.bmp;*.png"
        fpath.FilterIndex = 1
        fpath.RestoreDirectory = True
        If fpath.ShowDialog = Windows.Forms.DialogResult.OK AndAlso fpath.FileName <> "" Then
        End If
        Try
            Mainfrm.lblMainStatus.Text = "UPDATE company "
            strSQL = "update company set images=@im"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.AddWithValue("@im", fpath.FileName)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Call loadimages()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "UPDATE company ผิดพลาด " & ex.Message
        End Try
       
    End Sub
End Class