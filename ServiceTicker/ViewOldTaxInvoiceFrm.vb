Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ViewOldTaxInvoiceFrm
    Dim ddc As Integer
   
    Private Sub ViewOldTaxInvoiceFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(1)
    End Sub
  
    Private Sub getData()
        Try
            If ddc = 100 Then
                strSQL = "SELECT taxinvoice_id,taxinvoice_type,customer_id,customer_name,code_pro,name_pro,total,unit,price_buy,datetime_save FROM " & _
                    "taxinvoice WHERE datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' and " & _
                    "'" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' ORDER BY taxinvoice_id DESC"
            ElseIf ddc = 200 Then
                strSQL = "SELECT taxinvoice_id,taxinvoice_type,customer_id,customer_name,code_pro,name_pro,total,unit,price_buy,datetime_save FROM " & _
                    "taxinvoice WHERE taxinvoice_id='" & Me.dgVOTI.SelectedCells.Item(0).Value & "' ORDER BY taxinvoice_id DESC"
            End If
            Mainfrm.lblMainStatus.Text = strSQL
            Me.dgVOTI.Rows.Clear()
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgVOTI
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("taxinvoice_id")
                    .Rows(r).Cells(1).Value = Dr.Item("taxinvoice_type")
                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(3).Value = Dr.Item("customer_name")
                    .Rows(r).Cells(4).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(5).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(6).Value = Dr.Item("total")
                    .Rows(r).Cells(7).Value = Dr.Item("unit")
                    .Rows(r).Cells(8).Value = Dr.Item("price_buy")
                    .Rows(r).Cells(9).Value = Dr.Item("datetime_save")
                End With
            End While
            ddc = Nothing
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnVOTIsearch_Click(sender As Object, e As EventArgs) Handles btnVOTIsearch.Click
        ddc = 100
        Call getData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.dgVOTI.Rows.Count = 0 Then
        Else
            TaxInvoiceFrm.chgData = 10
            Call TaxInvoiceFrm.getDataProductByView()
            Me.Close()
        End If
    End Sub

    Private Sub btnVOTIdel_Click(sender As Object, e As EventArgs) Handles btnVOTIdel.Click
        Try
            If Me.dgVOTI.Rows.Count = 0 Then
            Else
                strSQL = "DELETE FROM taxinvoice WHERE taxinvoice_id='" & Me.dgVOTI.SelectedCells.Item(0).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                ddc = 100
                Call getData()
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub dgVOTI_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVOTI.CellDoubleClick
        ddc = 200
        Call getData()
    End Sub
End Class