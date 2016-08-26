Imports MySql.Data.MySqlClient
Public Class DebtorShowProFrm

    Private Sub txtDSPclose_Click(sender As Object, e As EventArgs) Handles txtDSPclose.Click
        Me.Close()
    End Sub
    Private Sub sumALL()
        For sum As Integer = 0 To Me.dgDSP.Rows.Count - 1
            Me.dgDSP.Rows(sum).Cells(0).Value = sum + 1
        Next
    End Sub
    Private Sub lblShowText_TextChanged(sender As Object, e As EventArgs) Handles lblShowText.TextChanged
        Try
            Me.dgDSP.Rows.Clear()
            strSQL = "SELECT code_pro,name_pro,total_pro,unit,price_buy from sale_barcode where sale_id='" & Me.lblShowText.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim r As Integer
                While Dr.Read
                    With dgDSP
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells("code_pro").Value = Dr.Item("code_pro")
                        .Rows(r).Cells("name_pro").Value = Dr.Item("name_pro")
                        .Rows(r).Cells("total_pro").Value = Dr.Item("total_pro")
                        .Rows(r).Cells("unit").Value = Dr.Item("unit")
                        .Rows(r).Cells("price_buy").Value = Dr.Item("price_buy")
                        .Rows(r).Cells("total_all").Value = .Rows(r).Cells("price_buy").Value * .Rows(r).Cells("total_pro").Value
                    End With
                End While
            End Using
            Call sumALL()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub DebtorShowProFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub
End Class