Imports MySql.Data.MySqlClient

Public Class ReportRepairViewProductFrm
    
    Private Sub ReportRepairViewProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub
    Protected Friend Sub getData()
        Try
            Me.DataGridView1.Rows.Clear()
            If ReportSaleFrm.selectStatus = 100 Then
                strSQL = "SELECT sale_id,code_pro,name_pro,total_pro,price_buy,unit FROM cash_sale_barcode WHERE sale_id='" & ReportSaleFrm.dgReportRepair.SelectedCells.Item(1).Value & "'"
            ElseIf ReportSaleFrm.selectStatus = 200 Then
                strSQL = "SELECT sale_id,code_pro,name_pro,total_pro,price_buy,unit FROM sale_barcode WHERE sale_id='" & ReportSaleFrm.dgReportRepair.SelectedCells.Item(1).Value & "'"
            ElseIf ReportRepairFrm.selectStatus = 300 Then
                strSQL = "SELECT fix_id,code_pro,name_pro,total_pro,price_buy,unit FROM cash_sale_barcode WHERE sale_id='" & ReportRepairFrm.dgReportRepair.SelectedCells.Item(1).Value & "'"
            ElseIf ReportRepairFrm.selectStatus = 400 Then
                strSQL = "SELECT fix_id,code_pro,name_pro,total_pro,price_buy,unit FROM sale_barcode WHERE sale_id='" & ReportRepairFrm.dgReportRepair.SelectedCells.Item(1).Value & "'"
            End If
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                If ReportSaleFrm.selectStatus = 100 Then
                    lblRRVPshow.Text = "ใบขายสินค้าเลขที่ " & Dr.Item("sale_id")
                ElseIf ReportSaleFrm.selectStatus = 200 Then
                    lblRRVPshow.Text = "ใบขายสินค้าเลขที่ " & Dr.Item("sale_id")
                ElseIf ReportRepairFrm.selectStatus = 300 Then
                    lblRRVPshow.Text = "ใบรับซ่อมเลขที่ " & Dr.Item("fix_id")
                ElseIf ReportRepairFrm.selectStatus = 400 Then
                    lblRRVPshow.Text = "ใบรับซ่อมเลขที่ " & Dr.Item("fix_id")
                End If
                With Me.DataGridView1
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(2).Value = Dr.Item("total_pro")
                    .Rows(r).Cells(3).Value = Dr.Item("unit")
                    .Rows(r).Cells(4).Value = Dr.GetDecimal("price_buy")
                End With
            End While
            ReportRepairFrm.selectStatus = Nothing
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
End Class