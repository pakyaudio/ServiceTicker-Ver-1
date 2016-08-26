Imports MySql.Data.MySqlClient

Public Class CheckPriceFrm
   
    Private Sub CheckPriceFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub getDataProPrice()
        Try
            If Me.txtCPsnANDbarcode.Text = "" Then
                Exit Try
            End If
            strSQL = "SELECT name_pro,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members,count_num FROM product WHERE bar_code='" & Me.txtCPsnANDbarcode.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.txtCPsnANDbc.Text = Me.txtCPsnANDbarcode.Text
                Me.txtCPnamePro.Text = Dr.GetString("name_pro")
                Me.txtCPpriceBuy.Text = Dr.GetDecimal("price_buy")
                Me.txtCPwholsale.Text = Dr.GetDecimal("price_wholesale")
                Me.txtCPtechnician.Text = Dr.GetDecimal("price_technician")
                Me.txtCPloyel.Text = Dr.GetDecimal("price_loyal")
                Me.txtCPmember.Text = Dr.GetDecimal("price_members")
                Me.txtCPprice_cost.Text = Dr.GetDecimal("price_cost")
                Me.txtCPcount_num.Text = Dr.GetDecimal("count_num")
                For ck As Integer = 0 To Me.dgCP.Rows.Count - 1
                    If Me.dgCP.Rows(ck).Cells(0).Value = Me.txtCPsnANDbarcode.Text Then
                        Exit Try
                    End If
                Next
                With Me.dgCP
                    Dim ad As Integer
                    ad = .Rows.Count
                    .Rows.Add()
                    .Rows(ad).Cells(0).Value = Me.txtCPsnANDbc.Text
                    .Rows(ad).Cells(1).Value = Me.txtCPnamePro.Text
                    .Rows(ad).Cells(2).Value = Me.txtCPpriceBuy.Text
                    .Rows(ad).Cells(3).Value = Me.txtCPwholsale.Text
                    .Rows(ad).Cells(4).Value = Me.txtCPtechnician.Text
                    .Rows(ad).Cells(5).Value = Me.txtCPloyel.Text
                    .Rows(ad).Cells(6).Value = Me.txtCPmember.Text
                    .Rows(ad).Cells(7).Value = Me.txtCPprice_cost.Text
                    .Rows(ad).Cells(8).Value = Me.txtCPcount_num.Text
                End With
            Else
                strSQL = "SELECT name_pro,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members,count_num FROM product WHERE code_pro IN (SELECT code_pro FROM product_serial WHERE serial_pro='" & Me.txtCPsnANDbarcode.Text & "')"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Me.txtCPsnANDbc.Text = Me.txtCPsnANDbarcode.Text
                Dr.Read()
                If Dr.HasRows Then
                    Me.txtCPsnANDbc.Text = Me.txtCPsnANDbarcode.Text
                    Me.txtCPnamePro.Text = Dr.GetString("name_pro")
                    Me.txtCPpriceBuy.Text = Dr.GetDecimal("price_buy")
                    Me.txtCPwholsale.Text = Dr.GetDecimal("price_wholesale")
                    Me.txtCPtechnician.Text = Dr.GetDecimal("price_technician")
                    Me.txtCPloyel.Text = Dr.GetDecimal("price_loyal")
                    Me.txtCPmember.Text = Dr.GetDecimal("price_members")
                    Me.txtCPprice_cost.Text = Dr.GetDecimal("price_cost")
                    Me.txtCPcount_num.Text = Dr.GetDecimal("count_num")
                    For ck As Integer = 0 To Me.dgCP.Rows.Count - 1
                        If Me.dgCP.Rows(ck).Cells(0).Value = Me.txtCPsnANDbarcode.Text Then
                            Exit Try
                        End If
                    Next
                    With Me.dgCP
                        Dim ad As Integer
                        ad = .Rows.Count
                        .Rows.Add()
                        .Rows(ad).Cells(0).Value = Me.txtCPsnANDbc.Text
                        .Rows(ad).Cells(1).Value = Me.txtCPnamePro.Text
                        .Rows(ad).Cells(2).Value = Me.txtCPpriceBuy.Text
                        .Rows(ad).Cells(3).Value = Me.txtCPwholsale.Text
                        .Rows(ad).Cells(4).Value = Me.txtCPtechnician.Text
                        .Rows(ad).Cells(5).Value = Me.txtCPloyel.Text
                        .Rows(ad).Cells(6).Value = Me.txtCPmember.Text
                        .Rows(ad).Cells(7).Value = Me.txtCPprice_cost.Text
                        .Rows(ad).Cells(8).Value = Me.txtCPcount_num.Text
                    End With
                Else
                    Me.txtCPsnANDbc.Text = Nothing
                    Exit Try
                End If
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Me.txtCPsnANDbarcode.Clear()
    End Sub

    Private Sub txtCPsnANDbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCPsnANDbarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDataProPrice()
        End If
    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        Call getDataProPrice()
    End Sub
End Class