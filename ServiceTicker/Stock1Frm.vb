Imports MySql.Data.MySqlClient
Imports System.Data.SQLite

Public Class Stock1Frm
    Private Sub StockFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub
    Private Sub countProduct()
        Try
            For i = 0 To dgStock.RowCount
                Me.txtScountProduct.Text = i & " รายการ"
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub count_num()
        Try
            Me.txtScount_num.Text = "0"
            Dim sum As Decimal = 0
            Dim count As Decimal = 0
            For i = 0 To Me.dgStock.RowCount - 1
                If Me.dgStock.Rows(i).Cells(6).Value > count Then
                    sum += CDec(Me.dgStock.Rows(i).Cells(4).Value) * CDec(Me.dgStock.Rows(i).Cells(6).Value)
                    Me.txtScount_num.Text = sum.ToString("N2")
                End If
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub profit()
        Try
            Me.txtSprofit.Text = "0"
            Dim sum As Decimal = 0
            Dim count As Decimal = 0
            For i = 0 To dgStock.RowCount - 1
                If Me.dgStock.Rows(i).Cells(6).Value > count Then
                    sum += (CDec(Me.dgStock.Rows(i).Cells(4).Value) * CDec(dgStock.Rows(i).Cells(6).Value)) - (CDec(Me.dgStock.Rows(i).Cells(3).Value) * CDec(Me.dgStock.Rows(i).Cells(6).Value))
                    Me.txtSprofit.Text = sum.ToString("N2")
                End If
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub cost()
        Try
        Me.txtScost.Text = "0"
        Dim sum As Decimal = 0
        Dim count As Decimal = 0
        For i = 0 To dgStock.RowCount - 1
            If Me.dgStock.Rows(i).Cells(6).Value > count Then
                sum += CDec(Me.dgStock.Rows(i).Cells(3).Value) * CDec(Me.dgStock.Rows(i).Cells(6).Value)
                Me.txtScost.Text = sum.ToString("N2")
            End If
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getDtatToCbbSproTypeSelect()
        Try
            Me.cbbSproType.Items.Clear()
            strSQL = "SELECT prosection_name from product_section"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand
                cmd.CommandText = strSQL
                cmd.Connection = ConnectionDB
                Call open_connection()
                Dr = cmd.ExecuteReader
                While (Dr.Read())
                    Me.cbbSproType.Items.Add(Dr("prosection_name"))
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getDtatToCbbSproCompanySelect()
        Try
            Me.cbbSsaleCompany.Items.Clear()
            strSQL = "SELECT sale_company_name from sale_company"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand
                cmd.CommandText = strSQL
                cmd.Connection = ConnectionDB
                Call open_connection()
                Dr = cmd.ExecuteReader
                While (Dr.Read())
                    Me.cbbSsaleCompany.Items.Add(Dr("sale_company_name"))
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Dim strselect As Integer

    Private Sub getDataTodg()
        Try
            Me.dgStock.Rows.Clear()
            If strselect = 100 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM product WHERE type='" & Me.cbbSproType.Text & "'"
            ElseIf strselect = 200 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM product WHERE company_buy='" & Me.cbbSsaleCompany.Text & "'"
            ElseIf strselect = 300 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM product"
            ElseIf strselect = 400 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM product WHERE count_num < check_stock"
            ElseIf strselect = 500 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM product WHERE count_num <= check_stock"
            ElseIf strselect = 600 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM product WHERE count_num > check_stock"
            ElseIf strselect = 700 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num FROM product WHERE " & _
                    "name_pro like '%" & Me.txtSsearchPro.Text & "%' OR code_pro like '%" & Me.txtSsearchPro.Text & "%' OR bar_code like '%" & Me.txtSsearchPro.Text & "%'"
            End If
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            While Dr.Read()
                Dim r As Integer
                With Me.dgStock
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("code_pro")
                    .Rows(r).Cells(1).Value = Dr.GetString("bar_code")
                    .Rows(r).Cells(2).Value = Dr.GetString("name_pro")
                    .Rows(r).Cells(3).Value = Dr.GetDecimal("price_cost")
                    .Rows(r).Cells(4).Value = Dr.GetDecimal("price_buy")
                    .Rows(r).Cells(5).Value = Dr.GetString("unit")
                    .Rows(r).Cells(6).Value = Dr.GetDecimal("count_num")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Call countProduct()
        Call count_num()
        Call profit()
        Call cost()
        strselect = Nothing
    End Sub

    Private Sub cbbSproType_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbSproType.SelectedValueChanged
        strselect = 100
        Call getDataTodg()
        Me.cbbSproStatus.Items.Clear()
        Me.cbbSsaleCompany.Items.Clear()
    End Sub
    Private Sub cbbSproType_Click(sender As Object, e As EventArgs) Handles cbbSproType.Click
        Call getDtatToCbbSproTypeSelect()
    End Sub

    Private Sub cbbSproStatus_MouseClick(sender As Object, e As MouseEventArgs) Handles cbbSproStatus.MouseClick
        Me.cbbSproStatus.Items.Clear()
        Me.cbbSproStatus.Items.Add("สินค้ารวม")
        Me.cbbSproStatus.Items.Add("สินค้าต่ำกว่าจุดเตือน")
        Me.cbbSproStatus.Items.Add("สินค้าหมด/ขาด")
        Me.cbbSproStatus.Items.Add("สินค้ายังไม่หมด/มี")
    End Sub

    Private Sub cbbSproStatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbSproStatus.SelectedValueChanged
        Me.cbbSproType.Items.Clear()
        Me.cbbSsaleCompany.Items.Clear()
        If cbbSproStatus.SelectedItem = "สินค้ารวม" Then
            strselect = 300
            Call getDataTodg()
        ElseIf cbbSproStatus.SelectedItem = "สินค้าต่ำกว่าจุดเตือน" Then
            strselect = 400
            Call getDataTodg()
        ElseIf cbbSproStatus.SelectedItem = "สินค้าหมด/ขาด" Then
            strselect = 500
            Call getDataTodg()
        ElseIf cbbSproStatus.SelectedItem = "สินค้ายังไม่หมด/มี" Then
            strselect = 600
            Call getDataTodg()
        End If
    End Sub

    Private Sub cbbSsaleCompany_Click(sender As Object, e As EventArgs) Handles cbbSsaleCompany.Click
        Call getDtatToCbbSproCompanySelect()
    End Sub

    Private Sub cbbSsaleCompany_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbSsaleCompany.SelectedValueChanged
        strselect = 200
        Call getDataTodg()
        Me.cbbSproType.Items.Clear()
        Me.cbbSproStatus.Items.Clear()
    End Sub

    Private Sub txtSsearchPro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSsearchPro.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSsearchPro.Text = Nothing Then
                Mainfrm.lblMainStatus.Text = "ค่าว่างไม่อาจจะค้นหาได้"
            Else
                strselect = 700
                Call getDataTodg()
            End If
        End If
    End Sub

    Private Sub btnSshowallpro_Click(sender As Object, e As EventArgs) Handles btnSshowallpro.Click
        If Me.txtSsearchPro.Text = Nothing Then
            Mainfrm.lblMainStatus.Text = "ค่าว่างไม่อาจจะค้นหาได้"
        Else
            strselect = 700
            Call getDataTodg()
        End If
    End Sub
    Private Sub reportPrint()
        If Me.dgStock.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Me.Cursor = Cursors.WaitCursor
            Mainfrm.lblMainStatus.Text = "ล้างข้อมูลรายงานเก่า"
            Try
                strSQLite = "DELETE FROM stock1"
                Mainfrm.lblMainStatus.Text = strSQLite
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            Mainfrm.lblMainStatus.Text = "สร้างข้อมูลรายงาน"
            Me.Cursor = Cursors.WaitCursor
            For r As Integer = 0 To Me.dgStock.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO stock1(code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num)" _
                     & "VALUES(@code_pro,@bar_code,@name_pro,@price_cost,@price_buy,@unit,@count_num)"
                    Mainfrm.lblMainStatus.Text = strSQLite
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@code_pro", Me.dgStock.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@bar_code", Me.dgStock.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgStock.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@price_cost", Me.dgStock.Rows(r).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@price_buy", Me.dgStock.Rows(r).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@unit", Me.dgStock.Rows(r).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@count_num", Me.dgStock.Rows(r).Cells(6).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            Next
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = "โหลดหน้าพิมพ์รายงาน"
            Stock1ReportPrintFrm.Show()
        End If
    End Sub

    Private Sub pbPrint_Click(sender As Object, e As EventArgs) Handles pbPrint.Click
        Call reportPrint()
    End Sub
End Class