Imports MySql.Data.MySqlClient
Imports System.Data.SQLite

Public Class ViewSelectReceiveProductFrm


    Friend Sub getDataViewSelectReceiveProductFrm()
        Try
            strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,count_num,total FROM buy_pro WHERE buy_id='" & SelectReceiveProductFrm.dgSRP.SelectedCells.Item(0).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgVSRP
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(3).Value = Dr.GetDecimal("price_cost")
                    .Rows(r).Cells(4).Value = Dr.GetDecimal("count_num")
                    .Rows(r).Cells(5).Value = Dr.GetDecimal("total")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            strSQL = "SELECT buy_id,sale_company_id,sale_company_name,datetime_save,employee FROM buy_pro WHERE buy_id='" & SelectReceiveProductFrm.dgSRP.SelectedCells.Item(0).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            With Dr
                .Read()
                Me.txtVSRPbuy_id.Text = .Item("buy_id")
                Me.txtVSRPsale_company_id.Text = .Item("sale_company_id")
                Me.txtVSRPsale_company_name.Text = .Item("sale_company_name")
                Me.txtVSRPdatetim_save.Text = .Item("datetime_save")
                Me.txtVSRPemployee.Text = .Item("employee")
            End With
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        'sum price 
        Try
            Dim pb As Decimal
            For price As Integer = 0 To Me.dgVSRP.Rows.Count - 1
                pb += Me.dgVSRP.Rows(price).Cells(5).Value
            Next
            Me.txtVSRtotalBuy.Text = pb.ToString("N2")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Friend Sub getDataViewReceiveFrm()
        Try
            strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,count_num,total FROM buy_pro WHERE buy_id='" & ViewReceiveFrm.dgVR.SelectedCells.Item(0).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgVSRP
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(3).Value = Dr.GetDecimal("price_cost")
                    .Rows(r).Cells(4).Value = Dr.Item("count_num")
                    .Rows(r).Cells(5).Value = Dr.GetDecimal("total")

                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            strSQL = "SELECT buy_id,sale_company_id,sale_company_name,datetime_save,employee FROM buy_pro WHERE buy_id=@1"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@1", ViewReceiveFrm.dgVR.SelectedCells.Item(0).Value)
                Call open_connection()
                Dr = cmd.ExecuteReader
                With Dr
                    .Read()
                    Me.txtVSRPbuy_id.Text = .Item("buy_id")
                    Me.txtVSRPsale_company_id.Text = .Item("sale_company_id")
                    Me.txtVSRPsale_company_name.Text = .Item("sale_company_name")
                    Me.txtVSRPdatetim_save.Text = .Item("datetime_save")
                    Me.txtVSRPemployee.Text = .Item("employee")
                End With
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        'sum price 
        Try
            Dim pb As Decimal
            For price As Integer = 0 To Me.dgVSRP.Rows.Count - 1
                pb += Me.dgVSRP.Rows(price).Cells(5).Value
            Next
            Me.txtVSRtotalBuy.Text = pb.ToString("N2")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub ViewSelectReceiveProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub
    Private Sub reportPrint()
        If Me.dgVSRP.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลให้พิมพ์", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        Else
            'แอดทำรีพอร์ต
            Me.Cursor = Cursors.WaitCursor
            Mainfrm.lblMainStatus.Text = "ล้างข้อมูลรายงานเก่า"
            Try
                strSQLite = "DELETE FROM buy_pro_reword"
                Mainfrm.lblMainStatus.Text = strSQLite
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            'loop save to database
            For rREPORT As Integer = 0 To Me.dgVSRP.RowCount - 1
                Try
                    strSQLite = "insert into buy_pro_reword(bar_code,name_pro,price_cost,unit,total_cost) " _
                    & "values(@bar_code,@name_pro,@price_cost,@unit,@total_cost)"
                    Mainfrm.lblMainStatus.Text = strSQLite
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    With cmdSQLite
                        .Parameters.Add(New SQLiteParameter("@bar_code", Me.dgVSRP.Rows(rREPORT).Cells(1).Value))
                        .Parameters.Add(New SQLiteParameter("@name_pro", Me.dgVSRP.Rows(rREPORT).Cells(2).Value))
                        .Parameters.Add(New SQLiteParameter("@price_cost", Me.dgVSRP.Rows(rREPORT).Cells(3).Value))
                        .Parameters.Add(New SQLiteParameter("@unit", Me.dgVSRP.Rows(rREPORT).Cells(4).Value))
                        .Parameters.Add(New SQLiteParameter("@total_cost", Me.dgVSRP.Rows(rREPORT).Cells(5).Value))
                        Call open_connectionSQLite()
                        .ExecuteNonQuery()
                    End With
                    Me.Cursor = Cursors.Default
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    Return
                End Try
            Next
            RebuyReportPrintFrm.Show()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call reportPrint()
    End Sub
End Class