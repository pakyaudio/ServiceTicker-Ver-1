Imports MySql.Data.MySqlClient
Public Class StockFrm
    Private WithEvents songsDataGridView As New System.Windows.Forms.DataGridView
   
    Private Sub addtodgS()
        Dim ColumnTextBox As DataGridViewTextBoxColumn
        '0
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "code_pro"
        ColumnTextBox.HeaderText = "รหัสสินค้า"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 110
        Me.dgStock.Columns.Add(ColumnTextBox)
        '1
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "bar_code"
        ColumnTextBox.HeaderText = "บาร์โค๊ต"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 110
        Me.dgStock.Columns.Add(ColumnTextBox)
        '2
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "name_pro"
        ColumnTextBox.HeaderText = "ชื่อสินค้า"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 227
        Me.dgStock.Columns.Add(ColumnTextBox)
        '3
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "price_cost"
        ColumnTextBox.HeaderText = "ราคาทุน"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 80
        Me.dgStock.Columns.Add(ColumnTextBox)
        '4
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "price_buy"
        ColumnTextBox.HeaderText = "ราคาขาย"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 90
        Me.dgStock.Columns.Add(ColumnTextBox)
        '5
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "unit"
        ColumnTextBox.HeaderText = "หน่วย"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 73
        Me.dgStock.Columns.Add(ColumnTextBox)
        '5
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "count_num"
        ColumnTextBox.HeaderText = "คงเหลือ"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 73
        Me.dgStock.Columns.Add(ColumnTextBox)
    End Sub

    Private Sub StockFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call addtodgS()
    End Sub
    Private Sub countProduct()
        For i = 0 To dgStock.RowCount
            Me.txtScountProduct.Text = i & " รายการ"
        Next
    End Sub
    Private Sub count_num()
        Try
        Me.txtScount_num.Text = "0"
        Dim sum As Double = 0
        Dim count As Integer = 0
        For i = 0 To dgStock.RowCount - 1
            If dgStock.Rows(i).Cells(6).Value > count Then
                sum += dgStock.Rows(i).Cells(4).Value * dgStock.Rows(i).Cells(6).Value
                Me.txtScount_num.Text = sum.ToString("0,0")
            End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub profit()
        Try
        Me.txtSprofit.Text = "0"
            Dim sum As Integer
            For i = 0 To dgStock.RowCount - 1
                If Me.dgStock.Rows(i).Cells(6).Value = "-" Then
                    Me.dgStock.Rows(i).Cells(6).Value = 0
                End If
                sum += (CInt(Me.dgStock.Rows(i).Cells(4).Value) * CInt(Me.dgStock.Rows(i).Cells(6).Value)) - (CInt(Me.dgStock.Rows(i).Cells(3).Value) * CInt(Me.dgStock.Rows(i).Cells(6).Value))
                Me.txtSprofit.Text = sum.ToString("0,0")
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cost()
        Try
            Me.txtScost.Text = "0"
            Dim sum As Integer
            For i = 0 To dgStock.RowCount - 1
                If Me.dgStock.Rows(i).Cells(6).Value = "-" Then
                    Me.dgStock.Rows(i).Cells(6).Value = 0
                End If
                sum += CInt(Me.dgStock.Rows(i).Cells(3).Value) * CInt(Me.dgStock.Rows(i).Cells(6).Value)
                Me.txtScost.Text = sum.ToString("0,0")
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub getDtatToCbbSproTypeSelect()
        Try
            Me.cbbSproType.Items.Clear()
            strSQL = "SELECT prosection_name FROM product_section ORDER BY prosection_name ASC"
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
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getDtatToCbbSproCompanySelect()
        Try
            Me.cbbSsaleCompany.Items.Clear()
            strSQL = "SELECT sale_company_name FROM sale_company"
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
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
    
    Private Sub getDataTocbbSproType()
        Try
            Me.dgStock.Refresh()
            Using dt = New DataTable
                strSQL = "select code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num from product where `type`='" & Me.cbbSproType.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgStock.DataSource = dt
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
    Private Sub getDataTocbbSproCompany()
        Try
            Me.dgStock.Refresh()
            Using dt = New DataTable
                strSQL = "select code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num from product where company_buy='" & Me.cbbSsaleCompany.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgStock.DataSource = dt
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
    Private Sub getDataBycbbSproStatus_all()
        Try
        Me.dgStock.Refresh()
        Using dt = New DataTable
                strSQL = "select code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num from product"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgStock.DataSource = dt
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
    Private Sub getDataBycbbSproStatus_uder_values()
        Try
        Me.dgStock.Refresh()
        Using dt = New DataTable
                strSQL = "select code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num from product where count_num < check_stock"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgStock.DataSource = dt
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
    Private Sub getDataBycbbSproStatus_as_values()
        Try
        Me.dgStock.Refresh()
        Using dt = New DataTable
                strSQL = "select code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num from product where count_num <= check_stock"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgStock.DataSource = dt
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
    Private Sub getDataBycbbSproStatus_upper_values()
        Try
        Me.dgStock.Refresh()
        Using dt = New DataTable
                strSQL = "select code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num from product where count_num > check_stock"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgStock.DataSource = dt
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
    Private Sub SearchData()
        Try
            Me.dgStock.Refresh()
            Using dt = New DataTable
                strSQL = "select code_pro,bar_code,name_pro,price_cost,price_buy,unit,count_num from product where name_pro like '%" & Me.txtSsearchPro.Text & "%'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgStock.DataSource = dt
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
    
    Private Sub cbbSproType_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbSproType.SelectedValueChanged
        Call getDataTocbbSproType()
        Call countProduct()
        Call count_num()
        Call profit()
        Call cost()
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
            Call getDataBycbbSproStatus_all()
        ElseIf cbbSproStatus.SelectedItem = "สินค้าต่ำกว่าจุดเตือน" Then
            Call getDataBycbbSproStatus_uder_values()
        ElseIf cbbSproStatus.SelectedItem = "สินค้าหมด/ขาด" Then
            Call getDataBycbbSproStatus_as_values()
        ElseIf cbbSproStatus.SelectedItem = "สินค้ายังไม่หมด/มี" Then
            Call getDataBycbbSproStatus_upper_values()
        End If
        Call countProduct()
        Call count_num()
        Call profit()
        Call cost()
    End Sub

    Private Sub cbbSsaleCompany_Click(sender As Object, e As EventArgs) Handles cbbSsaleCompany.Click
        Call getDtatToCbbSproCompanySelect()
    End Sub

    Private Sub cbbSsaleCompany_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbSsaleCompany.SelectedValueChanged
        Call getDataTocbbSproCompany()
        Me.cbbSproType.Items.Clear()
        Me.cbbSproStatus.Items.Clear()
        Call countProduct()
        Call count_num()
        Call profit()
        Call cost()
    End Sub

    Private Sub txtSsearchPro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSsearchPro.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call SearchData()
        End If
    End Sub

    Private Sub btnSshowallpro_Click(sender As Object, e As EventArgs) Handles btnSshowallpro.Click
        Call SearchData()
    End Sub

    Private Sub dgStock_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgStock.CellMouseDoubleClick
        Try
            For i As Integer = 0 To OrdreFrm.dgOR.RowCount - 1
                If OrdreFrm.dgOR.Rows(i).Cells(0).Value = dgStock.SelectedCells.Item(1).Value Then
                    MsgBox("มีข้อมูลอยู่แล้ว กรุณาเลือกใหม่", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                End If
            Next
        Catch ex As Exception

        End Try
        Try

            StockSnumFrm.Show()
         
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
    Friend Sub numOK()
        MsgBox("เพิ่มข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
    End Sub
End Class