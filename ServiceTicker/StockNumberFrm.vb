Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class StockNumberFrm
  

    Dim GETwhere As Integer
    Private Sub GetDataProduct()
        Try
            If Me.cbbSNtype.Text = "" And Me.rb1.Checked = True Then
                GETwhere = 100
            ElseIf Me.cbbSNtype.Text = "" And Me.rb2.Checked = True Then
                GETwhere = 200
            ElseIf Me.cbbSNtype.Text = "" And Me.rb3.Checked = True Then
                GETwhere = 300
            ElseIf Me.rb1.Checked = True Then
                GETwhere = 400
            ElseIf Me.rb2.Checked = True Then
                GETwhere = 500
            ElseIf Me.rb3.Checked = True Then
                GETwhere = 600
            End If
            Me.dgSN.Rows.Clear()

            If GETwhere = 100 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members FROM product " _
               & "WHERE count_num > 0"
            ElseIf GETwhere = 200 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members FROM product"
            ElseIf GETwhere = 300 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members FROM product " _
              & "WHERE count_num <= 0"
            ElseIf GETwhere = 400 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members FROM product " _
               & "WHERE type='" & Me.cbbSNtype.Text & "' AND count_num > 0"
            ElseIf GETwhere = 500 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members FROM product " _
               & "WHERE type='" & Me.cbbSNtype.Text & "'"
            ElseIf GETwhere = 600 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,type,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members FROM product " _
             & "WHERE type='" & Me.cbbSNtype.Text & "' AND count_num <= 0"
            End If
            

            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgSN
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.GetString("code_pro")
                    .Rows(r).Cells(2).Value = Dr.GetString("bar_code")
                    .Rows(r).Cells(3).Value = Dr.GetString("name_pro")
                    .Rows(r).Cells(4).Value = Dr.GetString("type")
                    .Rows(r).Cells(8).Value = Dr.GetString("price_cost")
                    .Rows(r).Cells(9).Value = Dr.GetString("price_buy")
                    .Rows(r).Cells(10).Value = Dr.GetString("price_wholesale")
                    .Rows(r).Cells(11).Value = Dr.GetString("price_technician")
                    .Rows(r).Cells(12).Value = Dr.GetString("price_loyal")
                    .Rows(r).Cells(13).Value = Dr.GetString("price_members")
                End With
            End While
            GETwhere = Nothing
        Catch ex As Exception
            'GETwhere = Nothing
            MsgBox(ex.Message)
        End Try

        For f As Integer = 0 To Me.dgSN.Rows.Count - 1
            Me.dgSN.Rows(f).Cells(0).Value = f + 1
        Next

        Try
            For d As Integer = 0 To Me.dgSN.Rows.Count - 1
                strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.dgSN.Rows(d).Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgSN
                    .Rows(d).Cells(5).Value = Dr.Item("count_num")
                End With
            Next
        Catch ex As Exception

        End Try

        Try
            For sum As Integer = 0 To Me.dgSN.Rows.Count - 1
                strSQL = "SELECT count(code_pro) AS code FROM product_serial WHERE code_pro='" & Me.dgSN.Rows(sum).Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgSN
                    .Rows(sum).Cells(6).Value = Dr.Item("code")
                End With
                Me.dgSN.Rows(sum).Cells(7).Value = CDec(Me.dgSN.Rows(sum).Cells(5).Value) - CDec(Me.dgSN.Rows(sum).Cells(6).Value)
                Me.dgSN.Rows(sum).Cells(14).Value = CDec(Me.dgSN.Rows(sum).Cells(8).Value) * CDec(Me.dgSN.Rows(sum).Cells(5).Value)
                Me.dgSN.Rows(sum).Cells(15).Value = CDec(Me.dgSN.Rows(sum).Cells(9).Value) * CDec(Me.dgSN.Rows(sum).Cells(5).Value)
            Next
        Catch ex As Exception

        End Try
        Try

            Dim tot, tot1, tot2 As Decimal
            For s1 As Integer = 0 To Me.dgSN.Rows.Count - 1
                tot += CDec(Me.dgSN.Rows(s1).Cells(7).Value)
                tot1 += CDec(Me.dgSN.Rows(s1).Cells(14).Value)
                tot2 += CDec(Me.dgSN.Rows(s1).Cells(15).Value)
            Next
            Me.txtSNtotal_p.Text = tot.ToString("0,0.00")
            Me.txtSNtotal_costA.Text = tot1.ToString("0,0.00")
            Me.txtSNtotal_buy.Text = tot2.ToString("0,0.00")
        Catch ex As Exception

        End Try
        GETwhere = Nothing

    End Sub

    Private Sub StockNumberFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub btnSNgetdata_Click(sender As Object, e As EventArgs) Handles btnSNgetdata.Click
            Call GetDataProduct()
    End Sub


    Private Sub btnSNgetsn_Click(sender As Object, e As EventArgs) Handles btnSNgetsn.Click
        If Me.dgSN.RowCount = 0 Then
            Mainfrm.lblMainStatus.Text = "กรุณาเลือกสินค้าที่ต้องการดู SN"
        Else
            If Me.dgSN.SelectedCells.Item(6).Value = 0 Then
                Mainfrm.lblMainStatus.Text = "สินค้ามี 0 ชิ้น"
            Else
                StockNumberSNFrm.MdiParent = Mainfrm
                StockNumberSNFrm.Show()
            End If
         
        End If
    End Sub
    Private Sub print()
        Try
            strSQL = "TRUNCATE `stock_number_cache`;"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            For r As Integer = 0 To Me.dgSN.Rows.Count - 1

                strSQL = "INSERT INTO stock_number_cache(number,code_pro,bar_code,name_pro,`type`,price_cost,total_all,total_cost)VALUES(@number,@code_pro,@bar_code,@name_pro,@type,@price_cost,@total_all,@total_cost)"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@number", Me.dgSN.Rows(r).Cells(0).Value)
                    cmd.Parameters.AddWithValue("@code_pro", Me.dgSN.Rows(r).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@bar_code", Me.dgSN.Rows(r).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@name_pro", Me.dgSN.Rows(r).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@type", Me.dgSN.Rows(r).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@price_cost", Me.dgSN.Rows(r).Cells(8).Value)
                    cmd.Parameters.AddWithValue("@total_all", Me.dgSN.Rows(r).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@total_cost", Me.dgSN.Rows(r).Cells(14).Value)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Next
            StockNumberPrintFrm.MdiParent = Mainfrm
            StockNumberPrintFrm.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnSNprint_Click(sender As Object, e As EventArgs) Handles btnSNprint.Click
        Call print()
    End Sub

    Private Sub cbbSNtype_Click(sender As Object, e As EventArgs) Handles cbbSNtype.Click
        If Me.cbSNshowAll.CheckState = CheckState.Checked Then
            Me.cbSNshowAll.CheckState = CheckState.Unchecked
        End If
        Try
            strSQL = "SELECT prosection_name FROM product_section ORDER BY prosection_name ASC"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Me.cbbSNtype.Items.Clear()
            While Dr.Read()
                Me.cbbSNtype.Items.Add(Dr.Item("prosection_name"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbSNshowAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbSNshowAll.CheckedChanged
        If Me.cbSNshowAll.CheckState = CheckState.Checked Then
            Me.cbbSNtype.Items.Clear()
        End If
    End Sub
End Class