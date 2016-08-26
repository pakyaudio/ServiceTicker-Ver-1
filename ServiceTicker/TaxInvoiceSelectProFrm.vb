Imports MySql.Data.MySqlClient

Public Class TaxInvoiceSelectProFrm

    Private Sub TaxInvoiceSelectProFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub cbbTISPpro_Click(sender As Object, e As EventArgs) Handles cbbTISPpro.Click
        Try
            Me.cbbTISPpro.Items.Clear()
            strSQL = "SELECT DISTINCT `type` FROM product ORDER BY `type` ASC"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Me.cbbTISPpro.Items.Add(Dr.GetString("type"))
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub cbbTISPpro_TextChanged(sender As Object, e As EventArgs) Handles cbbTISPpro.TextChanged
        Try
            Me.dgTISP.Rows.Clear()
            strSQL = "SELECT code_pro,bar_code,name_pro,price_buy,unit,`type` FROM product WHERE `type`='" & Me.cbbTISPpro.Text & "' ORDER BY name_pro ASC"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgTISP
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("code_pro")
                    .Rows(r).Cells(1).Value = Dr.GetString("bar_code")
                    .Rows(r).Cells(2).Value = Dr.GetString("name_pro")
                    .Rows(r).Cells(3).Value = Dr.GetString("type")
                    .Rows(r).Cells(4).Value = Dr.GetString("unit")
                    .Rows(r).Cells(5).Value = Dr.GetString("price_buy")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnTISPselect_Click(sender As Object, e As EventArgs) Handles btnTISPselect.Click
        Try
            If Me.dgTISP.Rows.Count = 0 Then
            Else
                TaxInvoiceFrm.txtTIsearchBarcode.Text = Me.dgTISP.CurrentRow.Cells(1).Value
                Call TaxInvoiceFrm.getDataProduct()
                TaxInvoiceFrm.txtTIsearchBarcode.Clear()
                TaxInvoiceFrm.txtTIsearchBarcode.Focus()
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
End Class