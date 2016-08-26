Imports MySql.Data.MySqlClient

Public Class ZoomImgFrm
    Private Sub openImages()
        Try
            strSQL = "SELECT picture FROM product WHERE code_pro='" & ProductDetailFrm.txtPDproID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            'Dim picture As Image = Nothing
            Dim pictureData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
            Dim stream As New IO.MemoryStream(pictureData)
            'Read the stream and create an Image object from the data.'
            stream.Write(pictureData, 0, pictureData.Length)
            Dim bitmap As New Bitmap(stream)
            PictureBox1.Image = bitmap

        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
    Private Sub ZoomImgFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call openImages()
    End Sub

    Private Sub btnZIclose_Click(sender As Object, e As EventArgs) Handles btnZIclose.Click
        Me.Close()
    End Sub
End Class