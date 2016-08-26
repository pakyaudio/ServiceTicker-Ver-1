Imports MySql.Data.MySqlClient
Public Class PrintSaveDatafixSendRepairFrm
    Dim sf As Integer
    Private Sub GetDataComfix()
        Try
            Me.dgPSDF.Rows.Clear()
            If sf = 100 Then
                strSQL = "SELECT fix_id,date_save,date_get,customer_id,customer_name,`sn`,symptom,managerdata,fixaccessory,fixrepairnote,fixuser,fixnote,`status` FROM " _
                & "comfix WHERE customer_name LIKE '%" & Me.txtSearch.Text & "%' or `sn` LIKE '%" & Me.txtSearch.Text & "%' or symptom LIKE '%" & Me.txtSearch.Text & "%'" _
                & " or fixrepairnote LIKE '%" & Me.txtSearch.Text & "%' or fixuser LIKE '%" & Me.txtSearch.Text & "%'" _
                & " ORDER BY fix_id DESC"
            Else
                strSQL = "SELECT fix_id,date_save,date_get,customer_id,customer_name,sn,symptom,managerdata,fixaccessory,fixrepairnote,fixuser,fixnote,`status` FROM " _
               & "comfix ORDER BY fix_id DESC LIMIT " & NumericUpDown1.Value.ToString & ""
            End If
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While (Dr.Read())
                With Me.dgPSDF
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.GetString("fix_id")
                    .Rows(r).Cells(2).Value = Dr.GetString("date_save")
                    .Rows(r).Cells(3).Value = Dr.GetString("date_get")
                    .Rows(r).Cells(4).Value = Dr.GetString("customer_id")
                    .Rows(r).Cells(5).Value = Dr.GetString("customer_name")
                    .Rows(r).Cells(7).Value = Dr.GetString("sn")
                    .Rows(r).Cells(12).Value = Dr.GetString("symptom")
                    .Rows(r).Cells(13).Value = Dr.GetString("managerdata")
                    .Rows(r).Cells(14).Value = Dr.GetString("fixrepairnote")
                    .Rows(r).Cells(15).Value = Dr.GetString("fixaccessory")
                    .Rows(r).Cells(16).Value = Dr.GetString("fixuser")
                    .Rows(r).Cells(17).Value = Dr.GetString("fixnote")
                    .Rows(r).Cells(18).Value = Dr.GetString("status")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            For sum As Integer = 0 To Me.dgPSDF.Rows.Count - 1
                Me.dgPSDF.Rows(sum).Cells(0).Value = sum + 1
                strSQL = "SELECT p_type,p_name,model,color FROM sn WHERE Snum='" & Me.dgPSDF.Rows(sum).Cells(7).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Dim r As Integer
                With Me.dgPSDF
                    r = .RowCount
                    .Rows(sum).Cells(8).Value = Dr.GetString("p_type")
                    .Rows(sum).Cells(9).Value = Dr.GetString("p_name")
                    .Rows(sum).Cells(10).Value = Dr.GetString("model")
                    .Rows(sum).Cells(11).Value = Dr.GetString("color")
                End With
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            For sum As Integer = 0 To Me.dgPSDF.Rows.Count - 1
                strSQL = "SELECT customer_tel FROM customer WHERE customer_id='" & Me.dgPSDF.Rows(sum).Cells(4).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Dim r As Integer
                With Me.dgPSDF
                    r = .RowCount
                    .Rows(sum).Cells(6).Value = Dr.GetString("customer_tel")
                End With
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        If sf = 100 Then
            Me.txtSearch.Text = Nothing
        End If
        sf = Nothing
    End Sub
    Friend fixid, datesave, dateget, cusid, cusname, custel, snn, pt, pn, md, clo, spt, mdata, frnote, fa, fuser, fnote As String
    Private Sub SelectPrint()
        If Me.dgPSDF.SelectedRows.Count = 0 Then
            Mainfrm.lblMainStatus.Text = "กรุณาเลือกข้อมูลที่ต้องการจะพิมพ์ก่อน"
            Exit Sub
        ElseIf Me.dgPSDF.CurrentRow.Cells(18).Value = "7 คืนเครื่องแล้ว" Then
            With Me.dgPSDF.SelectedCells
                fixid = .Item(1).Value
                datesave = .Item(2).Value
                dateget = .Item(3).Value
                cusid = .Item(4).Value
                cusname = .Item(5).Value
                custel = .Item(6).Value
                snn = .Item(7).Value
                pt = .Item(8).Value
                pn = .Item(9).Value
                md = .Item(10).Value
                clo = .Item(11).Value
                spt = .Item(12).Value
                mdata = .Item(13).Value
                frnote = .Item(14).Value
                fa = .Item(15).Value
                fuser = .Item(16).Value
                fnote = .Item(17).Value
            End With
            ReSendRepairFrm.Show()
        Else
                With Me.dgPSDF.SelectedCells
                    fixid = .Item(1).Value
                    datesave = .Item(2).Value
                    dateget = .Item(3).Value
                    cusid = .Item(4).Value
                    cusname = .Item(5).Value
                    custel = .Item(6).Value
                    snn = .Item(7).Value
                    pt = .Item(8).Value
                    pn = .Item(9).Value
                    md = .Item(10).Value
                    clo = .Item(11).Value
                    spt = .Item(12).Value
                    mdata = .Item(13).Value
                    frnote = .Item(14).Value
                    fa = .Item(15).Value
                    fuser = .Item(16).Value
                    fnote = .Item(17).Value
                End With
            SelectRePrintFrm.Show()
        End If

    End Sub

    Private Sub PrintSaveDatafixSendRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GetDataComfix()
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub btnPSDFrefresh_Click(sender As Object, e As EventArgs) Handles btnPSDFrefresh.Click
        Call GetDataComfix()
    End Sub

    Private Sub btnPSDFprint_Click(sender As Object, e As EventArgs) Handles btnPSDFprint.Click
        Call SelectPrint()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSearch.Text = Nothing Then
                Me.Timer1.Start()
                Me.txtSearch.BackColor = Drawing.Color.Red
            Else
                sf = 100
                Call GetDataComfix()
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Me.txtSearch.Text = Nothing Then
            Me.Timer1.Start()
            Me.txtSearch.BackColor = Drawing.Color.Red
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Timer1.Stop()
        Me.txtSearch.BackColor = Drawing.SystemColors.Window
    End Sub
End Class