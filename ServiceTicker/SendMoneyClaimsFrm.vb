Imports MySql.Data.MySqlClient
Imports System.Globalization
'edit 2015-11-09
Public Class SendMoneyClaimsFrm
   
    Private Sub AutoNumberNo()
        Try
            Using dt = New DataTable
                strSQL = "SELECT ver_returns FROM ver_detail"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Dim nid As String = dt.Rows(0).Item("ver_returns")
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                strSQL = "SELECT Max(ID) as ID FROM returnproduct_id"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Not Dr.HasRows Then
                    Me.txtRP_ID.Text = nid & Now.ToString("yyMM") & "00001"
                Else
                    Dim newID As Integer = CInt(Dr.Item("ID"))
                    newID += 1
                    Me.txtRP_ID.Text = nid & Now.ToString("yyMM") & newID.ToString("00000")
                End If
                Dr.Close()
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub ReturnsProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call AutoNumberNo()
        Timer1.Enabled = False
    End Sub
   

    Dim ckCSsn As String
    Dim seSN As String
    Friend Sub getDatatodgRPproBySN()
        'หาข้อมูลจาก SN
        strSQL = "select sale_id from sale_serial where serial_pro='" & Me.txtRPsearchSN.Text & "'"
        Mainfrm.lblMainStatus.Text = strSQL
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Dr = cmd.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            ckCSsn = 100
            seSN = Dr.Item("sale_id")
        ElseIf Not Dr.HasRows Then
            strSQL = "select sale_id from cash_sale_serial where serial_pro='" & Me.txtRPsearchSN.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                ckCSsn = 200
                seSN = Dr.Item("sale_id")
            Else
                Mainfrm.lblMainStatus.Text = "ไม่พบข้อมูล "
                Me.txtRPsearchSN.Text = ""
            End If

        End If

        If ckCSsn = 100 Then
            'sale
            Me.dgRPproBarcode.Refresh()
            Using ds = New DataSet
                dt = New DataTable
                Dim r As Integer = 0
                strSQL = "select code_pro,name_pro,price_buy,total_pro,unit from sale_barcode where sale_id='" & seSN & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(ds, "sale_serial")
                Me.dgRPproBarcode.DataSource = ds.Tables(0)
                If Me.dgRPproBarcode.RowCount > 0 Then
                    Timer1.Enabled = True
                    Timer2.Enabled = False
                    Me.lblRPsale_id_show.Text = seSN
                ElseIf Me.dgRPproBarcode.RowCount = 0 Then

                    Timer2.Enabled = True
                    Timer1.Enabled = False
                    Me.txtRPsearchSN.Clear()
                End If
                Dim ds1 As New DataSet
                Dim dt1 As New DataTable
                strSQL = "select serial_pro,code_pro,name_pro from sale_serial where sale_id='" & seSN & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(ds1, "sale_serial")
                Me.dgRPproSN.DataSource = ds1.Tables(0)
            End Using

            Using dt = New DataTable
                strSQL = "SELECT customer_id,fix_id from sale where sale_id='" & seSN & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.txtRPcustomerID.Text = dt.Rows(0).Item("customer_id")
                fixid = dt.Rows(0).Item("fix_id")
            End Using
            Call clear()
            'Call getDataCustomer()
            Me.lblRPproductStatus.Text = "เครดิต"
            Me.lblRPnoteDetail.Text = "เครดิต คือ ลูกค้ายังไม่ได้จ่ายเงิน"
            Me.txtRPsearchSN.Text = ""

        ElseIf ckCSsn = 200 Then
            ' cash sale


            Me.dgRPproBarcode.Refresh()
            Using ds = New DataSet
                dt = New DataTable
                Dim r As Integer = 0
                strSQL = "select code_pro,name_pro,price_buy,total_pro,unit from cash_sale_barcode where sale_id='" & seSN & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(ds, "sale_serial")
                Me.dgRPproBarcode.DataSource = ds.Tables(0)
                If Me.dgRPproBarcode.RowCount > 0 Then
                    Timer1.Enabled = True
                    Timer2.Enabled = False
                    Me.lblRPsale_id_show.Text = seSN
                ElseIf Me.dgRPproBarcode.RowCount = 0 Then

                    Timer2.Enabled = True
                    Timer1.Enabled = False
                    Me.txtRPsearchSN.Clear()
                End If
                Dim ds1 As New DataSet
                Dim dt1 As New DataTable
                strSQL = "select serial_pro,code_pro,name_pro from cash_sale_serial where sale_id='" & seSN & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(ds1, "sale_serial")
                Me.dgRPproSN.DataSource = ds1.Tables(0)
            End Using

            Using dt = New DataTable
                strSQL = "SELECT customer_id,fix_id from cash_sale where sale_id='" & seSN & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.txtRPcustomerID.Text = dt.Rows(0).Item("customer_id")
                fixid = dt.Rows(0).Item("fix_id")
            End Using
            Call clear()
            'Call getDataCustomer()
            Me.lblRPproductStatus.Text = "เงินสด"
            Me.lblRPnoteDetail.Text = "เงินสด คือ ลูกค้าจ่ายเงินแล้ว ต้องทำการคืนเงินสดให้ลูกค้า"
            Me.txtRPsearchSN.Text = ""
        End If



        'seSN = Nothing
    End Sub
   

    Private Sub getDatatodgRPproBySNcash()
        Dim seSNcash As String
        'หาข้อมูลจาก SN
        Try
            strSQL = "select sale_id from cash_sale_serial where serial_pro='" & Me.txtRPsearchSN.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            seSNcash = Dr.Item("sale_id")

            Me.dgRPproBarcode.Refresh()
            Using ds = New DataSet
                dt = New DataTable
                Dim r As Integer = 0
                strSQL = "select code_pro,name_pro,price_buy,total_pro,unit from cash_sale_barcode where sale_id='" & seSNcash & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(ds, "sale_serial")
                Me.dgRPproBarcode.DataSource = ds.Tables(0)
                If Me.dgRPproBarcode.RowCount > 0 Then
                    Timer1.Enabled = True
                    Timer2.Enabled = False
                    Me.lblRPsale_id_show.Text = seSNcash
                ElseIf Me.dgRPproBarcode.RowCount = 0 Then

                    Timer2.Enabled = True
                    Timer1.Enabled = False
                    Me.txtRPsearchSN.Clear()
                End If
                Dim ds1 As New DataSet
                Dim dt1 As New DataTable
                strSQL = "select serial_pro,code_pro,name_pro from cash_sale_serial where sale_id='" & seSNcash & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(ds1, "sale_serial")
                Me.dgRPproSN.DataSource = ds1.Tables(0)
            End Using

            Using dt = New DataTable
                strSQL = "SELECT customer_id,fix_id from cash_sale where sale_id='" & seSNcash & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.txtRPcustomerID.Text = dt.Rows(0).Item("customer_id")
                fixid = dt.Rows(0).Item("fix_id")
            End Using
            Me.txtRPsearchSN.Text = ""
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        seSNcash = Nothing
    End Sub
    'end code
    Private Sub getDataSN()
        Try
            If Me.txtRPsnADD.Text = "" Then
                MsgBox("กรุณาใส่ข้อมูลในช่อง SN", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Me.txtRPsnADD.BackColor = Color.DarkOrange
                Me.txtRPsnADD.Clear()
                Me.txtRPsnADD.Focus()
                Exit Sub
            End If
            For g As Integer = 0 To dgRPsendProSN.Rows.Count - 1
                If Me.dgRPsendProSN.Rows(g).Cells(0).Value = Me.txtRPsnADD.Text Then
                    MsgBox("มีข้อมูล '" & Me.txtRPsnADD.Text & "' อยู่ในตารางแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                    Me.txtRPsnADD.Clear()
                    Me.txtRPsnADD.Focus()
                    Exit Sub
                End If
            Next
            If Me.lblRPproductStatus.Text = "เครดิต" Then
                'ds = New DataSet
                'dt = New DataTable
                Dim r As Integer = 0
                strSQL = "SELECT serial_pro,code_pro,name_pro from sale_serial where serial_pro='" & Me.txtRPsnADD.Text & "' and sale_id='" & Me.lblRPsale_id_show.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    If Dr.HasRows = 0 Then
                        MsgBox("ไม่พบข้อมูล '" & Me.txtRPsnADD.Text & "' ในบิลขายสินค้านี้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                        Me.txtRPsnADD.Clear()
                        Me.txtRPsnADD.Focus()
                        Exit Sub
                    End If
                    While Dr.Read
                        With dgRPsendProSN
                            r = .RowCount
                            .Rows.Add()
                            .Rows(r).Cells(0).Value = Dr.Item(0)
                            .Rows(r).Cells(1).Value = Dr.Item(1)
                            .Rows(r).Cells(2).Value = Dr.Item(2)
                        End With
                    End While
                End Using
                strSQL = "SELECT code_pro from sale_serial where serial_pro='" & Me.txtRPsnADD.Text & "' and sale_id='" & Me.lblRPsale_id_show.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim cp As String
                Dr.Read()
                cp = Dr.Item(0)
                Dim dr1 As MySqlDataReader
                Dim rr As Integer = 0
                strSQL = "SELECT code_pro,name_pro,price_buy,unit from product where code_pro='" & cp & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                dr1 = cmd.ExecuteReader
                dr1.Read()
                For cg As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                    If Me.dgRPsendProBarcode.Rows(cg).Cells(0).Value = cp Then
                        Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value = CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value) + CDec(1)
                        Me.dgRPsendProBarcode.Rows(cg).Cells(5).Value = CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value) * CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(2).Value)
                        Me.txtRPsnADD.Clear()
                        Me.txtRPsnADD.Focus()
                        Call sumDG()
                        Exit Sub
                    End If
                Next
                With Me.dgRPsendProBarcode
                    rr = .RowCount
                    .Rows.Add()
                    .Rows(rr).Cells(0).Value = dr1.Item(0)
                    .Rows(rr).Cells(1).Value = dr1.Item(1)
                    .Rows(rr).Cells(2).Value = dr1.Item(2)
                    .Rows(rr).Cells(3).Value = "1"
                    .Rows(rr).Cells(4).Value = dr1.GetDecimal(3)
                    .Rows(rr).Cells(5).Value = CDec(.Rows(rr).Cells(3).Value) * CDec(.Rows(rr).Cells(2).Value)
                    Call sumDG()
                End With
                Me.txtRPsnADD.Clear()
            ElseIf Me.lblRPproductStatus.Text = "เงินสด" Then
                Dim r As Integer = 0
                strSQL = "SELECT serial_pro,code_pro,name_pro from cash_sale_serial where serial_pro='" & Me.txtRPsnADD.Text & "' and sale_id='" & Me.lblRPsale_id_show.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    If Dr.HasRows = 0 Then
                        MsgBox("ไม่พบข้อมูล '" & Me.txtRPsnADD.Text & "' ในบิลขายสินค้านี้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                        Me.txtRPsnADD.Clear()
                        Me.txtRPsnADD.Focus()
                        Exit Sub
                    End If
                    While Dr.Read
                        With dgRPsendProSN
                            r = .RowCount
                            .Rows.Add()
                            .Rows(r).Cells(0).Value = Dr.Item(0)
                            .Rows(r).Cells(1).Value = Dr.Item(1)
                            .Rows(r).Cells(2).Value = Dr.Item(2)
                        End With
                    End While
                End Using
                strSQL = "SELECT code_pro from cash_sale_serial where serial_pro='" & Me.txtRPsnADD.Text & "' and sale_id='" & Me.lblRPsale_id_show.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim cp As String
                Dr.Read()
                cp = Dr.Item(0)
                Dim dr1 As MySqlDataReader
                Dim rr As Integer = 0
                strSQL = "SELECT code_pro,name_pro,price_buy,unit from product where code_pro='" & cp & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                dr1 = cmd.ExecuteReader
                dr1.Read()
                For cg As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                    If Me.dgRPsendProBarcode.Rows(cg).Cells(0).Value = cp Then
                        Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value = CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value) + CDec(1)
                        Me.dgRPsendProBarcode.Rows(cg).Cells(5).Value = CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value) * CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(2).Value)
                        Me.txtRPsnADD.Clear()
                        Me.txtRPsnADD.Focus()
                        Call sumDG()
                        Exit Sub
                    End If
                Next
                With Me.dgRPsendProBarcode
                    rr = .RowCount
                    .Rows.Add()
                    .Rows(rr).Cells(0).Value = dr1.Item(0)
                    .Rows(rr).Cells(1).Value = dr1.Item(1)
                    .Rows(rr).Cells(2).Value = dr1.Item(2)
                    .Rows(rr).Cells(3).Value = "1"
                    .Rows(rr).Cells(4).Value = dr1.GetDecimal(3)
                    .Rows(rr).Cells(5).Value = CDec(.Rows(rr).Cells(3).Value) * CDec(.Rows(rr).Cells(2).Value)
                    Call sumDG()
                End With
                Me.txtRPsnADD.Clear()
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Public Sub sumDG()
        Dim oop As Decimal = 0
        For index As Integer = 0 To dgRPsendProBarcode.RowCount - 1
            oop += CDec(Me.dgRPsendProBarcode.Rows(index).Cells(5).Value)
        Next
        Me.txtRPsumall.Text = oop.ToString("N2")
    End Sub
    Private Sub clear()
        Me.txtRPsumall.Clear()
        Me.dgRPsendProBarcode.Rows.Clear()
        Me.dgRPsendProSN.Rows.Clear()
    End Sub
    Dim fixid As String
    'Private Sub getDataCustomer()
    '    Try
    '        If Me.lblRPproductStatus.Text = "เครดิต" Then
    '            Using dt = New DataTable
    '                strSQL = "SELECT customer_id,fix_id from sale where sale_id='" & Me.txtRPsale_id.Text & "'"
    '                Mainfrm.lblMainStatus.Text = strSQL
    '                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
    '                Call open_connection()
    '                dtAdapter.Fill(dt)
    '                Me.txtRPcustomerID.Text = dt.Rows(0).Item("customer_id")
    '                fixid = dt.Rows(0).Item("fix_id")
    '                Me.txtRPsale_id.Clear()
    '            End Using
    '        ElseIf Me.lblRPproductStatus.Text = "เงินสด" Then
    '            Using dt = New DataTable
    '                strSQL = "SELECT customer_id,fix_id from cash_sale where sale_id='" & Me.txtRPsale_id.Text & "'"
    '                Mainfrm.lblMainStatus.Text = strSQL
    '                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
    '                Call open_connection()
    '                dtAdapter.Fill(dt)
    '                Me.txtRPcustomerID.Text = dt.Rows(0).Item("customer_id")
    '                fixid = dt.Rows(0).Item("fix_id")
    '                Me.txtRPsale_id.Clear()
    '            End Using
    '        End If
    '    Catch ex As Exception
    '        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
    '    End Try
    'End Sub
    'Dim ckCS As String
    'Private Sub txtRPsale_id_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        Try
    '            strSQL = "SELECT sale_id FROM sale WHERE sale_id='" & Me.txtRPsale_id.Text & "'"
    '            Mainfrm.lblMainStatus.Text = strSQL
    '            cmd = New MySqlCommand(strSQL, ConnectionDB)
    '            Call open_connection()
    '            Dr = cmd.ExecuteReader
    '            Dr.Read()
    '            If Dr.HasRows Then
    '                Call clear()
    '                Call getDatatodgRPproBarcode()
    '                Call getDataCustomer()
    '            Else
    '                Call clear()
    '                Call getDatatodgRPproBarcodeCash()
    '                Call getDataCustomer()
    '            End If


    'If ckCS = 100 Then
    '    Call clear()
    '    Call getDataCustomer()
    '    Call getDatatodgRPproBarcode()
    '    Me.lblRPproductStatus.Text = "เครดิต"
    '    Me.lblRPnoteDetail.Text = "เครดิต คือ ลูกค้ายังไม่ได้จ่ายเงิน"
    '    Me.txtRPsale_id.Clear()
    'ElseIf ckCS = 200 Then
    '    Call clear()
    '    Call getDataCustomer()
    '    Call getDatatodgRPproBarcodeCash()
    '    Me.lblRPproductStatus.Text = "เงินสด"
    '    Me.lblRPnoteDetail.Text = "เงินสด คือ ลูกค้าจ่ายเงินแล้ว ต้องทำการคืนเงินสดให้ลูกค้า"
    '    Me.txtRPsale_id.Clear()
    'End If

    '        Catch ex As Exception
    '            Call clear()
    '            Mainfrm.lblMainStatus.Text = "ไม่พบข้อมูลxxxxxxxx " & ex.Message
    '            Me.txtRPsale_id.Text = ""
    '            Exit Sub
    '        End Try
    ''ckCS = Nothing
    '    End If
    'End Sub

    Private Sub txtRPcustomerID_TextChanged(sender As Object, e As EventArgs) Handles txtRPcustomerID.TextChanged
        Try
            Using dt = New DataTable
                strSQL = "SELECT customer_name,customer_address,customer_tel from customer where customer_id='" & Me.txtRPcustomerID.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                'Me.txtRPcustomerID.Text = dt.Rows(0).Item("customer_id")
                Me.txtRPcustomerName.Text = dt.Rows(0).Item("customer_name")
                Me.txtRPcustomerAddress.Text = dt.Rows(0).Item("customer_address")
                Me.txtRPcustomerTel.Text = dt.Rows(0).Item("customer_tel")
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub txtRPsnADD_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRPsnADD.KeyDown
        If e.KeyCode = Keys.Enter Then
            For g As Integer = 0 To dgRPsendProSN.Rows.Count - 1
                If Me.dgRPsendProSN.Rows(g).Cells(0).Value = Me.txtRPsnADD.Text Then
                    MsgBox("มีข้อมูล '" & Me.txtRPsnADD.Text & "' อยู่ในตารางแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                    Me.txtRPsnADD.Clear()
                    Me.txtRPsnADD.Focus()
                    Exit Sub
                End If
            Next
            Call getDataSN()
        End If
    End Sub

    'Private Sub cbbRPstatus_Click(sender As Object, e As EventArgs) Handles cbbRPstatus.Click
    '    Me.cbbRPstatus.Items.Clear()
    '    Me.cbbRPstatus.Items.Add("คืนเป็นเงินสด")
    '    Me.cbbRPstatus.Items.Add("คืนเป็นเครดิต")
    'End Sub

    Private Sub btnRPsnOK_Click(sender As Object, e As EventArgs) Handles btnRPsnOK.Click
        Call getDataSN()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblRPsale_id_show.ForeColor = Color.DarkRed
        If lblRPsale_id_show.Visible = True Then
            lblRPsale_id_show.Visible = False
        Else
            lblRPsale_id_show.Visible = True
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.lblRPsale_id_show.ForeColor = Color.DarkRed
        Me.lblRPsale_id_show.Text = "ไม่พบข้อมูลบิลขายนี้"
        If lblRPsale_id_show.Visible = True Then
            lblRPsale_id_show.Visible = False
        Else
            lblRPsale_id_show.Visible = True
        End If
    End Sub

    Private Sub btnRPcancel_Click(sender As Object, e As EventArgs) Handles btnRPcancel.Click
        Me.Close()
    End Sub

    'Private Sub dgRPproBarcode_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRPproBarcode.CellDoubleClick
    '    If Me.lblRPproductStatus.Text = "เครดิต" Then
    '        If Me.dgRPproBarcode.SelectedRows.Count <= 0 Then
    '        Else
    '            Try
    '                strSQL = "SELECT count(code_pro) from sale_serial where code_pro='" & Me.dgRPproBarcode.SelectedCells.Item(0).Value & "' and sale_id='" & Me.lblRPsale_id_show.Text & "' "
    '                Mainfrm.lblMainStatus.Text = strSQL
    '                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
    '                    Call open_connection()
    '                    Dr = cmd.ExecuteReader
    '                    Dr.Read()
    '                    If Dr(0) > 0 Then
    '                        MiniReturnProductFrm.txtMRPnumPro.Text = Dr(0) - CInt(Me.dgRPproBarcode.SelectedCells.Item(3).Value)
    '                    ElseIf Dr(0) = 0 Then
    '                        MiniReturnProductFrm.txtMRPnumPro.Text = Me.dgRPproBarcode.SelectedCells.Item(3).Value
    '                    End If
    '                    'MiniReturnProductFrm.MdiParent = Mainfrm
    '                    MiniReturnProductFrm.Show()
    '                    Me.Enabled = False
    '                End Using
    '            Catch ex As Exception
    '                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
    '            End Try
    '        End If
    '    ElseIf Me.lblRPproductStatus.Text = "เงินสด" Then
    '        If Me.dgRPproBarcode.SelectedRows.Count <= 0 Then
    '        Else
    '            Try
    '                strSQL = "SELECT count(code_pro) from cash_sale_serial where code_pro='" & Me.dgRPproBarcode.SelectedCells.Item(0).Value & "' and sale_id='" & Me.lblRPsale_id_show.Text & "' "
    '                Mainfrm.lblMainStatus.Text = strSQL
    '                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
    '                    Call open_connection()
    '                    Dr = cmd.ExecuteReader
    '                    Dr.Read()
    '                    If Dr(0) > 0 Then
    '                        MiniReturnProductFrm.txtMRPnumPro.Text = Dr(0) - CInt(Me.dgRPproBarcode.SelectedCells.Item(3).Value)
    '                    ElseIf Dr(0) = 0 Then
    '                        MiniReturnProductFrm.txtMRPnumPro.Text = Me.dgRPproBarcode.SelectedCells.Item(3).Value
    '                    End If
    '                    'MiniReturnProductFrm.MdiParent = Mainfrm
    '                    MiniReturnProductFrm.Show()
    '                    Me.Enabled = False
    '                End Using
    '            Catch ex As Exception
    '                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
    '            End Try
    '        End If
    '    End If
    'End Sub
    '  สินค้าที่เป็นเครดิต ยังไม่จ่ายเงิน *****************************************************************************************************************************
    Private Sub saveDataReturn()
        Try

            'insert to returnproduct_id
            strSQL = "insert into returnproduct_id(return_id,datetime_save)" _
                    & "values(@return_id,@datetime_save)"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            End Using
            'insert to returnproduct  

            strSQL = "insert into returnproduct(return_id,sale_id,fix_id,customer_id,customer_name,total_all,total_barcode,total_sn,return_status,return_note,datetime_save,employee)" _
                 & "values(@return_id,@sale_id,@fix_id,@customer_id,@customer_name,@total_all,@total_barcode,@total_sn,@return_status,@return_note,@datetime_save,@employee)"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Dim TbarCode As Integer = Me.dgRPsendProBarcode.RowCount
                Dim Tsn As Integer = Me.dgRPsendProSN.RowCount
                With cmd
                    .Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
                    .Parameters.Add(New MySqlParameter("@sale_id", Me.lblRPsale_id_show.Text))
                    .Parameters.Add(New MySqlParameter("@fix_id", fixid))
                    .Parameters.Add(New MySqlParameter("@customer_id", Me.txtRPcustomerID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_name", Me.txtRPcustomerName.Text))
                    .Parameters.Add(New MySqlParameter("@total_all", Me.txtRPsumall.Text))
                    .Parameters.Add(New MySqlParameter("@total_barcode", TbarCode))
                    .Parameters.Add(New MySqlParameter("@total_sn", Tsn))
                    .Parameters.Add(New MySqlParameter("@return_status", Me.lblRPproductStatus.Text))
                    .Parameters.Add(New MySqlParameter("@return_note", Me.txtRPreturnNote.Text))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub saveANDdelDataSN()
        Try
            'insert to product_serial
            For SNnum As Integer = 0 To Me.dgRPsendProSN.Rows.Count - 1
                strSQL = "insert into product_serial(code_pro,serial_pro,name_pro,date_in)" _
                            & "values(@code_pro,@serial_pro,@name_pro,@date_in)"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(1).Value))
                        .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value))
                        .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(2).Value))
                        .Parameters.Add(New MySqlParameter("@date_in", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                        Call open_connection()
                        .ExecuteNonQuery()
                    End With
                End Using
                'insert to returnproduct_serial
                strSQL = "insert into returnproduct_serial(return_id,sale_id,fix_id,customer_id,customer_name,code_pro,name_pro,serial_pro,datetime_save,employee)" _
                           & "values(@return_id,@sale_id,@fix_id,@customer_id,@customer_name,@code_pro,@name_pro,@serial_pro,@datetime_save,@employee)"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
                        .Parameters.Add(New MySqlParameter("@sale_id", Me.lblRPsale_id_show.Text))
                        .Parameters.Add(New MySqlParameter("@fix_id", fixid))
                        .Parameters.Add(New MySqlParameter("@customer_id", Me.txtRPcustomerID.Text))
                        .Parameters.Add(New MySqlParameter("@customer_name", Me.txtRPcustomerName.Text))
                        .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(1).Value))
                        .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(2).Value))
                        .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value))
                        .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                        .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                        Call open_connection()
                        .ExecuteNonQuery()
                    End With
                End Using
                'ลบ sn
                strSQL = "delete from sale_serial where serial_pro='" & Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value & "' and sale_id='" & Me.lblRPsale_id_show.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub saveANDdelDataBarcode()
        Try
            For BCnum As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                'get count_num from product
                strSQL = "select count_num from product where code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                End Using
                Dim cn As Decimal = Dr(0)
                Dim cnt As Decimal = cn + CDec(Me.dgRPproBarcode.Rows(BCnum).Cells(3).Value)
                'update count_num from product
                strSQL = "update product set count_num='" & cnt & "' where code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                'insert to returnproduct_barcode
                strSQL = "insert into returnproduct_barcode(return_id,sale_id,fix_id,code_pro,name_pro,unit,price_buy,total,employee,datetime_save)values(@return_id,@sale_id,@fix_id,@code_pro,@name_pro,@unit,@price_buy,@total,@employee,@datetime_save);"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
                    cmd.Parameters.Add(New MySqlParameter("@sale_id", Me.lblRPsale_id_show.Text))
                    cmd.Parameters.Add(New MySqlParameter("@fix_id", fixid))
                    cmd.Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value))
                    cmd.Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsendProBarcode.Rows(BCnum).Cells(1).Value))
                    cmd.Parameters.Add(New MySqlParameter("@unit", Me.dgRPsendProBarcode.Rows(BCnum).Cells(4).Value))
                    cmd.Parameters.Add(New MySqlParameter("@price_buy", Me.dgRPsendProBarcode.Rows(BCnum).Cells(2).Value))
                    cmd.Parameters.Add(New MySqlParameter("@total", Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value))
                    cmd.Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                    cmd.Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                'update sale_barcode กรณีคืนทั้งหมด ก็ลบบาร์โค๊ตนั้นทิ้งไปเลย ถ้าคืนไม่หมดก็ ลบ สินค้าออก จากนั้นคำนวนในฐานข้อมูล sale ในตาราง total_all ใหม่
                strSQL = "select total_pro,code_pro from sale_barcode where code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "' and sale_id='" & Me.lblRPsale_id_show.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                End Using
                Dim TA As Integer = Dr(0)
                Dim bcta As String = Dr(1)
                Dim TTA As Integer = TA - CInt(Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value)
                If TTA > 0 Then
                    'update total_pro from sale_barcode
                    strSQL = "update sale_barcode set total_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value & "',return_id='" & Me.txtRP_ID.Text & "'" _
                        & ",employee='" & LoginFrm.txtLoginUsername.Text & "' where code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                ElseIf TTA = 0 Then
                    'del sale_barcode
                    strSQL = "delete from sale_barcode where code_pro='" & bcta & "' and sale_id='" & Me.lblRPsale_id_show.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            'get total_all
            Dim Dr1 As MySqlDataReader
            strSQL = "select total_all from sale where sale_id='" & Me.lblRPsale_id_show.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr1 = cmd.ExecuteReader
            Dr1.Read()
            Dim total_all As Decimal = Dr1(0)
            Dim a As Decimal = total_all - CDec(Me.txtRPsumall.Text)

            'update and del sale
            If a > 0 Then
                Try
                    strSQL = "update sale set total_all= '" & a & "',employee='" & LoginFrm.txtLoginUsername.Text & "',return_id='" & Me.txtRP_ID.Text & "',date_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "' where sale_id='" & Me.lblRPsale_id_show.Text & "' "
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            ElseIf a = 0 Then
                Try
                    strSQL = "delete from sale where sale_id='" & Me.lblRPsale_id_show.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    '  สิค้าที่เป็นเงินสด จ่ายเงินแล้ว *****************************************************************************************************************************
    Private Sub saveDataReturnCash()
        Try
            'insert to returnproduct_id
            strSQL = "insert into returnproduct_id(return_id,datetime_save)" _
                    & "values(@return_id,@datetime_save)"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            End Using
            'insert to returnproduct  
            strSQL = "insert into returnproduct(return_id,sale_id,fix_id,customer_id,customer_name,total_all,total_barcode,total_sn,return_status,return_note,datetime_save,employee)" _
                 & "values(@return_id,@sale_id,@fix_id,@customer_id,@customer_name,@total_all,@total_barcode,@total_sn,@return_status,@return_note,@datetime_save,@employee)"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Dim TbarCode As Integer = Me.dgRPsendProBarcode.RowCount
                Dim Tsn As Integer = Me.dgRPsendProSN.RowCount
                With cmd
                    .Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
                    .Parameters.Add(New MySqlParameter("@sale_id", Me.lblRPsale_id_show.Text))
                    .Parameters.Add(New MySqlParameter("@fix_id", fixid))
                    .Parameters.Add(New MySqlParameter("@customer_id", Me.txtRPcustomerID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_name", Me.txtRPcustomerName.Text))
                    .Parameters.Add(New MySqlParameter("@total_all", Me.txtRPsumall.Text))
                    .Parameters.Add(New MySqlParameter("@total_barcode", TbarCode))
                    .Parameters.Add(New MySqlParameter("@total_sn", Tsn))
                    .Parameters.Add(New MySqlParameter("@return_status", Me.lblRPproductStatus.Text))
                    .Parameters.Add(New MySqlParameter("@return_note", Me.txtRPreturnNote.Text))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub saveANDdelDataSNcash()
        Try
            'insert to product_serial
            For SNnum As Integer = 0 To Me.dgRPsendProSN.Rows.Count - 1
                Mainfrm.lblMainStatus.Text = "insert into product_serial "
                strSQL = "insert into product_serial(code_pro,serial_pro,name_pro,date_in)" _
                            & "values(@code_pro,@serial_pro,@name_pro,@date_in)"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(1).Value))
                        .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value))
                        .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(2).Value))
                        .Parameters.Add(New MySqlParameter("@date_in", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                        Call open_connection()
                        .ExecuteNonQuery()
                    End With
                End Using
                'insert to returnproduct_serial
                Mainfrm.lblMainStatus.Text = "insert into returnproduct_serial "
                strSQL = "insert into returnproduct_serial(return_id,sale_id,fix_id,customer_id,customer_name,code_pro,name_pro,serial_pro,datetime_save,employee)" _
                           & "values(@return_id,@sale_id,@fix_id,@customer_id,@customer_name,@code_pro,@name_pro,@serial_pro,@datetime_save,@employee)"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
                        .Parameters.Add(New MySqlParameter("@sale_id", Me.lblRPsale_id_show.Text))
                        .Parameters.Add(New MySqlParameter("@fix_id", fixid))
                        .Parameters.Add(New MySqlParameter("@customer_id", Me.txtRPcustomerID.Text))
                        .Parameters.Add(New MySqlParameter("@customer_name", Me.txtRPcustomerName.Text))
                        .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(1).Value))
                        .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(2).Value))
                        .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value))
                        .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                        .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                        Call open_connection()
                        .ExecuteNonQuery()
                    End With
                End Using
                'ลบ sn
                Mainfrm.lblMainStatus.Text = "delete from cash_sale_serial"
                strSQL = "delete from cash_sale_serial where serial_pro='" & Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value & "' and sale_id='" & Me.lblRPsale_id_show.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub saveANDdelDataBarcodecash()
        Try
            For BCnum As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                'get count_num from product
                strSQL = "select count_num from product where code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                End Using
                Dim cn As Decimal = Dr(0)
                Dim cnt As Decimal = cn + CDec(Me.dgRPproBarcode.Rows(BCnum).Cells(3).Value)
                'update count_num from product
                strSQL = "update product set count_num='" & cnt & "' where code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                'insert to returnproduct_barcode
                strSQL = "insert into returnproduct_barcode(return_id,sale_id,fix_id,code_pro,name_pro,unit,price_buy,total,employee,datetime_save)values(@return_id,@sale_id,@fix_id,@code_pro,@name_pro,@unit,@price_buy,@total,@employee,@datetime_save);"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
                    cmd.Parameters.Add(New MySqlParameter("@sale_id", Me.lblRPsale_id_show.Text))
                    cmd.Parameters.Add(New MySqlParameter("@fix_id", fixid))
                    cmd.Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value))
                    cmd.Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsendProBarcode.Rows(BCnum).Cells(1).Value))
                    cmd.Parameters.Add(New MySqlParameter("@unit", Me.dgRPsendProBarcode.Rows(BCnum).Cells(4).Value))
                    cmd.Parameters.Add(New MySqlParameter("@price_buy", Me.dgRPsendProBarcode.Rows(BCnum).Cells(2).Value))
                    cmd.Parameters.Add(New MySqlParameter("@total", Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value))
                    cmd.Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                    cmd.Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                'update sale_barcode กรณีคืนทั้งหมด ก็ลบบาร์โค๊ตนั้นทิ้งไปเลย ถ้าคืนไม่หมดก็ ลบ สินค้าออก จากนั้นคำนวนในฐานข้อมูล sale ในตาราง total_all ใหม่
                strSQL = "select total_pro,code_pro from cash_sale_barcode where code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "' and sale_id='" & Me.lblRPsale_id_show.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                End Using
                Dim TA As Decimal = Dr(0)
                Dim bcta As String = Dr(1)
                Dim TTA As Decimal = TA - CDec(Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value)
                If TTA > 0 Then
                    'update total_pro from sale_barcode
                    strSQL = "update cash_sale_barcode set total_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value & "',return_id='" & Me.txtRP_ID.Text & "'" _
                        & ",employee='" & LoginFrm.txtLoginUsername.Text & "' where code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                ElseIf TTA = 0 Then
                    'del sale_barcode
                    strSQL = "delete from cash_sale_barcode where code_pro='" & bcta & "' and sale_id='" & Me.lblRPsale_id_show.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            'get total_all
            Dim Dr1 As MySqlDataReader
            strSQL = "select total_all from cash_sale where sale_id='" & Me.lblRPsale_id_show.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr1 = cmd.ExecuteReader
            Dr1.Read()
            Dim total_all As Decimal = Dr1(0)
            Dim a As Decimal = total_all - CDec(Me.txtRPsumall.Text)

            'update and del sale
            If a > 0 Then
                Try
                    strSQL = "update cash_sale set total_all= '" & a & "',employee='" & LoginFrm.txtLoginUsername.Text & "',return_id='" & Me.txtRP_ID.Text & "',date_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "' where sale_id='" & Me.lblRPsale_id_show.Text & "' "
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            ElseIf a = 0 Then
                Try
                    strSQL = "delete from cash_sale where sale_id='" & Me.lblRPsale_id_show.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    ' **********************************************************************************************************************************************************
    Friend bar_code, np As String
    Friend price_by, total, total_price As Decimal
    Private Sub btnRPsave_Click(sender As Object, e As EventArgs) Handles btnRPsave.Click
        If Me.dgRPsendProBarcode.RowCount = 0 Then
            MsgBox("ยังไม่มีรายการสินค้าที่จะรับคืนกรุณาทำรายการสินค้าที่ต้องการคืนด้วย", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            If Me.txtRPreturnNote.Text = "" Then
                MsgBox("กรุณาระบุสาเหตุที่คืนสินค้า", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Me.lblRPreturnNote.BackColor = Color.Orange
                Me.txtRPreturnNote.BackColor = Color.Orange
                Me.txtRPreturnNote.Focus()

            Else
                Dim Ans As String
                Ans = MsgBox("โปรดตรวจสอบความถูกต้องให้เรียบร้อย จากนี้ไปจะไม่สามารถแก้ไขได้อีก", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
                Mainfrm.lblMainStatus.Text = "โปรดตรวจสอบความถูกต้องให้เรียบร้อย จากนี้ไปจะไม่สามารถแก้ไขได้อีก"
                If Ans = System.Windows.Forms.DialogResult.No Then
                    Exit Sub
                Else
                    bar_code = Me.dgRPsendProBarcode.Rows(0).Cells(0).Value
                    np = Me.dgRPsendProBarcode.Rows(0).Cells(1).Value
                    price_by = Me.dgRPsendProBarcode.Rows(0).Cells(2).Value
                    total = Me.dgRPsendProBarcode.Rows(0).Cells(3).Value
                    total_price = Me.dgRPsendProBarcode.Rows(0).Cells(5).Value
                    If Me.lblRPproductStatus.Text = "เครดิต" Then
                        Call saveDataReturn()
                        Call saveANDdelDataSN()
                        Call saveANDdelDataBarcode()
                        MsgBox("คืนสินค้าเรียบร้อย หน้าต่างนี้จะปิดเมื่อคืนสินค้าเรียบร้อย", MsgBoxStyle.Information, "แจ้งเตือน")
                        Call changStatusClaims()
                        ClaimsStatusFrm.strsqlSelect = 200
                        Call ClaimsStatusFrm.getdataClaims()
                        Me.Enabled = False
                        SendMoneyReportPrintFrm.MdiParent = Mainfrm
                        SendMoneyReportPrintFrm.Show()
                        'Call clear()


                    ElseIf Me.lblRPproductStatus.Text = "เงินสด" Then
                        Call saveDataReturnCash()
                        Call saveANDdelDataSNcash()
                        Call saveANDdelDataBarcodecash()
                        MsgBox("คืนสินค้าเรียบร้อย หน้าต่างนี้จะปิดเมื่อคืนสินค้าเรียบร้อย", MsgBoxStyle.Information, "แจ้งเตือน")
                        Call changStatusClaims()
                        ClaimsStatusFrm.strsqlSelect = 200
                        Call ClaimsStatusFrm.getdataClaims()
                        'Call clear()
                        Me.Enabled = False
                        SendMoneyReportPrintFrm.MdiParent = Mainfrm
                        SendMoneyReportPrintFrm.Show()
                    End If
                End If
            End If
            bar_code = Nothing
            np = Nothing
            price_by = Nothing
            total = Nothing
            total_price = Nothing
        End If
    End Sub

    Private Sub changStatusClaims()
        Try
            strSQL = "UPDATE claims SET datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',status='" & "ส่งคืนแล้ว" & "',employee='" & ClaimsStatusFrm.lblemployee.Text & "' WHERE serial_pro='" & Me.dgRPsendProSN.Rows(0).Cells(0).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtRPsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRPsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDatatodgRPproBySN()
        End If
    End Sub

    Private Sub txtRPreturnNote_Click(sender As Object, e As EventArgs) Handles txtRPreturnNote.Click
        Me.txtRPreturnNote.BackColor = SystemColors.Window
        Me.lblRPreturnNote.BackColor = SystemColors.Control
    End Sub
End Class