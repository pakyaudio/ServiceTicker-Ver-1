Imports GenCode128
Imports BarcodeLib
Imports MySql.Data.MySqlClient
Public Class barcode_snFrm
    Private Sub createBarcode()
       
        For cbc As Integer = CInt(Me.txtBCSNnumStart.Text) To CInt(Me.txtBCSNnumEnd.Text)

            strSQL = "INSERT INTO barcode_print(barcode_id,barcode_pic)VALUES(@barcode_id,@barcode_pic)"
            cmd = New MySqlCommand(strSQL, ConnectionDB)


            Using stream As New IO.MemoryStream
                PictureBox1.Image = code128.Code128(cbc.ToString, "A")

                PictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Tiff)
                Dim arrImage() As Byte = stream.GetBuffer()
                Application.DoEvents()
                cmd.Parameters.AddWithValue("@barcode_id", cbc)
                'cmd.Parameters.AddWithValue("@name", Me.txtBCSNdesciption.Text)
                cmd.Parameters.AddWithValue("@barcode_pic", arrImage)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
            Mainfrm.lblMainStatus.Text = "กำลังสร้างบาร์โค๊ตหมายเลข " & cbc & "ป้ายชื่อ " & Me.txtBCSNdesciption.Text
        Next
        Mainfrm.lblMainStatus.Text = "สร้างบาร์โค๊ตเสร็จ"
    End Sub
    Private Sub barcode_snFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.lblMainStatus.Text = "เปิดหน้าต่างพิมพ์ป้ายบาร์โค๊ต"
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub btnBCSNcreate_Click(sender As Object, e As EventArgs) Handles btnBCSNcreate.Click
        Call createBarcode()
        PictureBox1.Image = code128.Code128(Me.txtBCSNtextFront.Text + txtBCSNnumStart.Text, "A")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Barcode_printFrm.Show()
    End Sub
End Class