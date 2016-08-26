Imports MySql.Data.MySqlClient
Public Class accessoryFrm
   
    Private Sub getData()
        Try
        Mainfrm.lblMainStatus.Text = "โหลด accessory_name"
        strSQL = "SELECT accessory_name FROM accessory"
        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read
                With Me.dgAccessory
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells("accessory_name").Value = Dr.Item("accessory_name")
                End With
            End While
            For sum As Integer = 0 To Me.dgAccessory.Rows.Count - 1
                Me.dgAccessory.Rows(sum).Cells(0).Value = sum + 1
                Mainfrm.lblMainStatus.Text = "สร้างหมายเลข"
            Next
        End Using
            Mainfrm.lblMainStatus.Text = "โหลด accessory_name แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด accessory_name ผิดพลาด"
        End Try
    End Sub
    Private Sub accessoryFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call getData()
    End Sub

    Private Sub btnAccessoryClose_Click(sender As Object, e As EventArgs) Handles btnAccessoryClose.Click
        Me.Close()
    End Sub

    Private Sub dgAccessory_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgAccessory.CellMouseDoubleClick
        Mainfrm.lblMainStatus.Text = "เพิ่ม " & Me.dgAccessory.SelectedCells.Item(1).Value & " แล้ว"
        If Not SaveDataFixFrm.txtSDFfixaccessory.Text = "" Then
            SaveDataFixFrm.txtSDFfixaccessory.Text = SaveDataFixFrm.txtSDFfixaccessory.Text + "," & Me.dgAccessory.SelectedCells.Item(1).Value
        Else
            SaveDataFixFrm.txtSDFfixaccessory.Text = Me.dgAccessory.SelectedCells.Item(1).Value
        End If
    End Sub
End Class