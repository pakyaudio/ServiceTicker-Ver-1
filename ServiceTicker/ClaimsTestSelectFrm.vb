Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class ClaimsTestSelectFrm
    Private Sub getdataClaims()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด sn เคลม"
            strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,datetime_save FROM claims WHERE status='" & "รอทดสอบ" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                While (Dr.Read())
                    Dim r As Integer = Me.dgCTRS.Rows.Count
                    With Me.dgCTRS
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.Item("claims_id")
                        .Rows(r).Cells(1).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(3).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(4).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(5).Value = Dr.Item("datetime_save")
                    End With
                End While
            End If
        Catch ex As Exception

        End Try
        Try
            For x As Integer = 0 To Me.dgCTRS.Rows.Count - 1
                If Me.dgCTRS.Rows(x).Cells(1).Value = "สินค้าจากสต็อก" Then
                    With Me.dgCTRS
                        .Rows(x).Cells(2).Value = "-"
                    End With
                Else
                    strSQL = "SELECT customer_name FROM customer WHERE customer_id='" & Me.dgCTRS.Rows(x).Cells(1).Value & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    If Dr.HasRows Then
                        Dr.Read()

                        With Me.dgCTRS
                            .Rows(x).Cells(2).Value = Dr.Item("customer_name")
                        End With
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClaimsTestResultsSelectSNFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call getdataClaims()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub dgCTRS_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCTRS.CellMouseDoubleClick
        ClaimsTestResultsFrm.txtCTRsearchSN.Text = Me.dgCTRS.SelectedCells.Item(3).Value
        Call ClaimsTestResultsFrm.getDataClaimsSNtoTextBox()
        Me.Close()
    End Sub
End Class
