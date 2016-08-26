Imports MySql.Data.MySqlClient

Public Class StockNumberSNFrm
   
    Private Sub print()
        Try
            strSQL = "TRUNCATE `stock_number_sn_cache`;"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            For r As Integer = 0 To Me.dgSNSN.Rows.Count - 1

                strSQL = "INSERT INTO stock_number_sn_cache(`no`,code_pro,sn,name_pro,datetime)VALUES(@no,@code_pro,@sn,@name_pro,@datetime)"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@no", Me.dgSNSN.Rows(r).Cells(0).Value)
                    cmd.Parameters.AddWithValue("@code_pro", Me.dgSNSN.Rows(r).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@sn", Me.dgSNSN.Rows(r).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@name_pro", Me.dgSNSN.Rows(r).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@datetime", Me.dgSNSN.Rows(r).Cells(4).Value)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Next
            StockNumberSNPrintFrm.MdiParent = Mainfrm
            StockNumberSNPrintFrm.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetDataProductSN()
        Try
            Me.dgSNSN.Rows.Clear()
            strSQL = "SELECT code_pro,serial_pro,name_pro,date_in FROM product_serial WHERE code_pro='" & StockNumberFrm.dgSN.SelectedCells.Item(1).Value & "' ORDER BY date_in ASC"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgSNSN
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.GetString("code_pro")
                    .Rows(r).Cells(2).Value = Dr.GetString("serial_pro")
                    .Rows(r).Cells(3).Value = Dr.GetString("name_pro")
                    .Rows(r).Cells(4).Value = Dr.GetString("date_in")
                End With
            End While
            For sum As Integer = 0 To Me.dgSNSN.Rows.Count - 1
                Me.dgSNSN.Rows(sum).Cells(0).Value = sum + 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub StockNumberSNFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GetDataProductSN()
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub btnSNlistPrint_Click(sender As Object, e As EventArgs) Handles btnSNlistPrint.Click
        Call print()
    End Sub
End Class