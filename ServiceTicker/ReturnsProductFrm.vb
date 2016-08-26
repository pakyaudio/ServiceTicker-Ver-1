Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ReturnsProductFrm
    Private Sub loadbill()
        Try
            Using dt = New DataTable
                strSQL = "SELECT ver_PartsWithdrawal FROM ver_detail"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Dim idBill As String = dt.Rows(0).Item("ver_PartsWithdrawal")
                Me.lblRPSale_id.Text = "เลขที่บิลขาย รหัสขึ้นต้นด้วย " & idBill
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
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
        Call loadbill()
        Call AutoNumberNo()
        Timer1.Enabled = False
    End Sub
    'by search sale ****************************************************************************************************************************************
    Private Sub getDatatodgRPproBarcode()
        Try
            'หาข้อมูลจาก barcode
            Me.dgRPproBarcode.Refresh()
            Using ds = New DataSet
                dt = New DataTable
                Dim r As Integer = 0
                strSQL = "select code_pro,name_pro,price_buy,total_pro,unit from sale_barcode where sale_id='" & Me.txtRPsale_id.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(ds, "sale_serial")
                Me.dgRPproBarcode.DataSource = ds.Tables(0)
                If Me.dgRPproBarcode.RowCount > 0 Then
                    Timer1.Enabled = True
                    Timer2.Enabled = False
                    Me.lblRPsale_id_show.Text = Me.txtRPsale_id.Text
                    Me.lblRPproductStatus.Text = "เครดิต"
                    Me.lblRPnoteDetail.Text = "เครดิต คือ ลูกค้ายังไม่ได้จ่ายเงิน"
                ElseIf Me.dgRPproBarcode.RowCount = 0 Then

                    Timer2.Enabled = True
                    Timer1.Enabled = False
                    Me.txtRPsale_id.Clear()
                End If
                Dim ds1 As New DataSet
                Dim dt1 As New DataTable
                strSQL = "select serial_pro,code_pro,name_pro from sale_serial where sale_id='" & Me.txtRPsale_id.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(ds1, "sale_serial")
                Me.dgRPproSN.DataSource = ds1.Tables(0)
            End Using
        Catch ex As Exception
            Me.txtRPsale_id.Clear()
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Dim ckCSsn As String
    Dim seSN As String
    Private Sub getDatatodgRPproBySN()
        Try
        'หาข้อมูลจาก SN
            strSQL = "SELECT sale_id FROM sale_serial WHERE serial_pro='" & Me.txtRPsearchSN.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                ckCSsn = 100
                seSN = Dr.Item("sale_id")
            Else
                strSQL = "SELECT sale_id FROM cash_sale_serial WHERE serial_pro='" & Me.txtRPsearchSN.Text & "'"
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
                    Me.txtRPsearchSN.Text = Nothing
                End If
            End If
        Catch ex As Exception
            Me.txtRPsearchSN.Text = Nothing
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        If ckCSsn = 100 Then
            'sale
            Me.dgRPproBarcode.Refresh()
            Try
                ds = New DataSet
                dt = New DataTable
                Dim r As Integer = 0
                strSQL = "SELECT code_pro,name_pro,price_buy,total_pro,unit FROM sale_barcode WHERE sale_id='" & seSN & "'"
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
            Catch ex As Exception
                Me.txtRPsearchSN.Clear()
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            Try
                Dim ds1 As New DataSet
                Dim dt1 As New DataTable
                strSQL = "SELECT serial_pro,code_pro,name_pro FROM sale_serial WHERE sale_id='" & seSN & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(ds1, "sale_serial")
                Me.dgRPproSN.DataSource = ds1.Tables(0)
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            Try
                strSQL = "SELECT customer_id,fix_id FROM sale WHERE sale_id='" & seSN & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Me.txtRPcustomerID.Text = Dr.Item("customer_id")
                    fixid = Dr.Item("fix_id")
                Else
                    strSQL = "SELECT customer_id,fix_id FROM sale_barcode WHERE sale_id='" & seSN & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    Me.txtRPcustomerID.Text = Dr.Item("customer_id")
                    fixid = Dr.Item("fix_id")
                End If
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            Call clear()
            Call getDataCustomer()
            Me.lblRPproductStatus.Text = "เครดิต"
            Me.lblRPnoteDetail.Text = "เครดิต คือ ลูกค้ายังไม่ได้จ่ายเงิน"
            Me.txtRPsearchSN.Text = Nothing

        ElseIf ckCSsn = 200 Then
            ' cash sale
            Me.dgRPproBarcode.Refresh()
            Try
                ds = New DataSet
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
            Catch ex As Exception
                Me.txtRPsearchSN.Clear()
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            Try
                Dim ds1 As New DataSet
                Dim dt1 As New DataTable
                strSQL = "select serial_pro,code_pro,name_pro from cash_sale_serial where sale_id='" & seSN & "'"
                 Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(ds1, "sale_serial")
                Me.dgRPproSN.DataSource = ds1.Tables(0)
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            Try
                strSQL = "SELECT customer_id,fix_id from cash_sale where sale_id='" & seSN & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Me.txtRPcustomerID.Text = Dr.Item("customer_id")
                    fixid = Dr.Item("fix_id")
                Else
                    strSQL = "SELECT customer_id,fix_id FROM cash_sale_barcode WHERE sale_id='" & seSN & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    Me.txtRPcustomerID.Text = Dr.Item("customer_id")
                    fixid = Dr.Item("fix_id")
                End If
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            Call clear()
            Call getDataCustomer()
            Me.lblRPproductStatus.Text = "เงินสด"
            Me.lblRPnoteDetail.Text = "เงินสด คือ ลูกค้าจ่ายเงินแล้ว ต้องทำการคืนเงินสดให้ลูกค้า"
            Me.txtRPsearchSN.Text = ""
        End If
        'seSN = Nothing
    End Sub
    'by search cash sale ****************************************************************************************************************************
    Private Sub getDatatodgRPproBarcodeCash()
        Try
            'หาข้อมูลจาก barcode
            Me.dgRPproBarcode.Refresh()
            Using ds = New DataSet
                dt = New DataTable
                Dim r As Integer = 0
                strSQL = "select code_pro,name_pro,price_buy,total_pro,unit from cash_sale_barcode where sale_id='" & Me.txtRPsale_id.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(ds, "sale_serial")
                Me.dgRPproBarcode.DataSource = ds.Tables(0)
                If Me.dgRPproBarcode.RowCount > 0 Then
                    Timer1.Enabled = True
                    Timer2.Enabled = False
                    Me.lblRPsale_id_show.Text = Me.txtRPsale_id.Text
                    Me.lblRPproductStatus.Text = "เงินสด"
                    Me.lblRPnoteDetail.Text = "เงินสด คือ ลูกค้าจ่ายเงินแล้ว ต้องทำการคืนเงินสดให้ลูกค้า"
                ElseIf Me.dgRPproBarcode.RowCount = 0 Then

                    Timer2.Enabled = True
                    Timer1.Enabled = False
                    Me.txtRPsale_id.Clear()
                End If
                Dim ds1 As New DataSet
                Dim dt1 As New DataTable
                strSQL = "select serial_pro,code_pro,name_pro from cash_sale_serial where sale_id='" & Me.txtRPsale_id.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(ds1, "sale_serial")
                Me.dgRPproSN.DataSource = ds1.Tables(0)
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
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
                    .Rows(rr).Cells(4).Value = dr1.Item(3)
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
                    .Rows(rr).Cells(4).Value = dr1.Item(3)
                    .Rows(rr).Cells(5).Value = CDec(.Rows(rr).Cells(3).Value) * CDec(.Rows(rr).Cells(2).Value)
                    Call sumDG()
                End With
                Me.txtRPsnADD.Clear()
            End If
        Catch ex As Exception
            Me.txtRPsnADD.Clear()
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Public Sub sumDG()
        Me.txtRPsumall.Text = 0
        Dim oop As Decimal
        For iii As Integer = 0 To dgRPsendProBarcode.RowCount - 1
            Me.dgRPsendProBarcode.Rows(iii).Cells(5).Value = CDec(Me.dgRPsendProBarcode.Rows(iii).Cells(2).Value) * CDec(Me.dgRPsendProBarcode.Rows(iii).Cells(3).Value)
            oop += CDec(Me.dgRPsendProBarcode.Rows(iii).Cells(5).Value)
            Me.txtRPsumall.Text = oop.ToString
        Next

    End Sub
    Private Sub clear()
        Me.txtRPsumall.Clear()
        Me.dgRPsendProBarcode.Rows.Clear()
        Me.dgRPsendProSN.Rows.Clear()
    End Sub
    Dim fixid As String
    Private Sub getDataCustomer()

        If Me.lblRPproductStatus.Text = "เครดิต" Then
            Try
                strSQL = "SELECT customer_id,fix_id FROM sale WHERE sale_id='" & Me.txtRPsale_id.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Me.txtRPcustomerID.Text = Dr.Item("customer_id")
                    fixid = Dr.Item("fix_id")
                End If
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            Me.txtRPsale_id.Clear()

        ElseIf Me.lblRPproductStatus.Text = "เงินสด" Then
            Try
                strSQL = "SELECT customer_id,fix_id FROM cash_sale WHERE sale_id='" & Me.txtRPsale_id.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Me.txtRPcustomerID.Text = Dr.Item("customer_id")
                    fixid = Dr.Item("fix_id")
                End If
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            Me.txtRPsale_id.Clear()
        End If
    End Sub
    'Dim ckCS As String
    Private Sub txtRPsale_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRPsale_id.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                strSQL = "SELECT sale_id FROM sale WHERE sale_id='" & Me.txtRPsale_id.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Call clear()
                    Call getDatatodgRPproBarcode()
                    Call getDataCustomer()
                Else
                    Call clear()
                    Call getDatatodgRPproBarcodeCash()
                    Call getDataCustomer()
                End If

              
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

            Catch ex As Exception
                Call clear()
                Mainfrm.lblMainStatus.Text = "ไม่พบข้อมูล " & ex.Message
                Me.txtRPsale_id.Text = ""
            End Try
            'ckCS = Nothing
        End If
    End Sub

    Private Sub txtRPcustomerID_TextChanged(sender As Object, e As EventArgs) Handles txtRPcustomerID.TextChanged
        Try
            strSQL = "SELECT customer_name,customer_address,customer_tel FROM customer WHERE customer_id='" & Me.txtRPcustomerID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                'Me.txtRPcustomerID.Text = dt.Rows(0).Item("customer_id")
                Me.txtRPcustomerName.Text = Dr.GetString("customer_name")
                Me.txtRPcustomerAddress.Text = Dr.GetString("customer_address")
                Me.txtRPcustomerTel.Text = Dr.GetString("customer_tel")
            Else
                Me.txtRPcustomerID.Clear()
            End If
        Catch ex As Exception
            Me.txtRPcustomerID.Clear()
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

    Private Sub dgRPproBarcode_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRPproBarcode.CellDoubleClick
        'If Me.lblRPproductStatus.Text = "เครดิต" Then
        '    If Me.dgRPproBarcode.SelectedRows.Count <= 0 Then
        '    Else
        '        Try
        '            strSQL = "SELECT count(code_pro) from sale_serial where code_pro='" & Me.dgRPproBarcode.SelectedCells.Item(0).Value & "' and sale_id='" & Me.lblRPsale_id_show.Text & "' "
        '            Mainfrm.lblMainStatus.Text = strSQL
        '            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
        '                Call open_connection()
        '                Dr = cmd.ExecuteReader
        '                Dr.Read()
        '                If Dr(0) > 0 Then
        '                    MiniReturnProductFrm.txtMRPnumPro.Text = Dr(0) - CInt(Me.dgRPproBarcode.SelectedCells.Item(3).Value)
        '                ElseIf Dr(0) = 0 Then
        '                    MiniReturnProductFrm.txtMRPnumPro.Text = Me.dgRPproBarcode.SelectedCells.Item(3).Value
        '                End If
        '                'MiniReturnProductFrm.MdiParent = Mainfrm
        '                MiniReturnProductFrm.Show()
        '                Me.Enabled = False
        '            End Using
        '        Catch ex As Exception
        '            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        '        End Try
        '    End If
        'ElseIf Me.lblRPproductStatus.Text = "เงินสด" Then
        '    If Me.dgRPproBarcode.SelectedRows.Count <= 0 Then
        '    Else
        '        Try
        '            strSQL = "SELECT count(code_pro) from cash_sale_serial where code_pro='" & Me.dgRPproBarcode.SelectedCells.Item(0).Value & "' and sale_id='" & Me.lblRPsale_id_show.Text & "' "
        '            Mainfrm.lblMainStatus.Text = strSQL
        '            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
        '                Call open_connection()
        '                Dr = cmd.ExecuteReader
        '                Dr.Read()
        '                If Dr(0) > 0 Then
        '                    MiniReturnProductFrm.txtMRPnumPro.Text = Dr(0) - CInt(Me.dgRPproBarcode.SelectedCells.Item(3).Value)
        '                ElseIf Dr(0) = 0 Then
        '                    MiniReturnProductFrm.txtMRPnumPro.Text = Me.dgRPproBarcode.SelectedCells.Item(3).Value
        '                End If
        '                'MiniReturnProductFrm.MdiParent = Mainfrm
        '                MiniReturnProductFrm.Show()
        '                Me.Enabled = False
        '            End Using
        '        Catch ex As Exception
        '            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        '        End Try
        '    End If
        'End If
        If Me.dgRPproBarcode.SelectedRows.Count <= 0 Then
        Else
            For dgc As Integer = 0 To Me.dgRPproSN.Rows.Count - 1
                If Me.dgRPproBarcode.SelectedCells.Item(0).Value = Me.dgRPproSN.Rows(dgc).Cells(1).Value Then
                    MsgBox("สินค้านี้มีอยู่ในระบบ SN กรุณา ป้อน SN สินค้า", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                End If
            Next

            For opq As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                If Me.dgRPproBarcode.SelectedCells.Item(0).Value = Me.dgRPsendProBarcode.Rows(opq).Cells(0).Value Then
                    MiniReturnProductFrm.txtMRPnumPro.Text = CDec(Me.dgRPproBarcode.Rows(opq).Cells(3).Value) - CDec(Me.dgRPsendProBarcode.Rows(opq).Cells(3).Value)
                    MiniReturnProductFrm.Show()
                    Me.Enabled = False
                    Exit Sub
                End If
            Next
            MiniReturnProductFrm.txtMRPnumPro.Text = Me.dgRPproBarcode.SelectedCells.Item(3).Value
            MiniReturnProductFrm.Show()
            Me.Enabled = False
        End If

    End Sub
    '  สินค้าที่เป็นเครดิต ยังไม่จ่ายเงิน *****************************************************************************************************************************
    Private Sub saveDataReturn()
        Try
            'insert to returnproduct_id
            strSQL = "INSERT INTO returnproduct_id(return_id,datetime_save)" _
                    & "VALUES(@return_id,@datetime_save)"
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
            strSQL = "INSERT INTO returnproduct(return_id,sale_id,fix_id,customer_id,customer_name,total_all,total_barcode,total_sn,return_status,return_note,datetime_save,employee)" _
                 & "VALUES(@return_id,@sale_id,@fix_id,@customer_id,@customer_name,@total_all,@total_barcode,@total_sn,@return_status,@return_note,@datetime_save,@employee)"
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
                    .Parameters.Add(New MySqlParameter("@employee", Me.lblemployee.Text))
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
                strSQL = "INSERT INTO product_serial(code_pro,serial_pro,name_pro,date_in)" _
                            & "VALUES(@code_pro,@serial_pro,@name_pro,@date_in)"
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
                strSQL = "INSERT INTO returnproduct_serial(return_id,sale_id,fix_id,customer_id,customer_name,code_pro,name_pro,serial_pro,datetime_save,employee)" _
                           & "VALUES(@return_id,@sale_id,@fix_id,@customer_id,@customer_name,@code_pro,@name_pro,@serial_pro,@datetime_save,@employee)"
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
                        .Parameters.Add(New MySqlParameter("@employee", Me.lblemployee.Text))
                        Call open_connection()
                        .ExecuteNonQuery()
                    End With
                End Using
                'ลบ sn
                strSQL = "DELETE FROM sale_serial WHERE serial_pro='" & Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value & "' AND sale_id='" & Me.lblRPsale_id_show.Text & "'"
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
            'edit แล้ว 20151025
            For BCnum As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                'get count_num from product
                strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                End Using
                Dim cn As Decimal = Dr(0)
                Dim cnt As Decimal = cn + CDec(Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value)
                'update count_num from product
                strSQL = "UPDATE product SET count_num='" & cnt & "' WHERE code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                'insert to returnproduct_barcode
                strSQL = "INSERT INTO returnproduct_barcode(return_id,sale_id,fix_id,code_pro,name_pro,unit,price_buy,total,employee,datetime_save)VALUES(@return_id,@sale_id,@fix_id,@code_pro,@name_pro,@unit,@price_buy,@total,@employee,@datetime_save);"
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
                    cmd.Parameters.Add(New MySqlParameter("@employee", Me.lblemployee.Text))
                    cmd.Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                'update sale_barcode กรณีคืนทั้งหมด ก็ลบบาร์โค๊ตนั้นทิ้งไปเลย ถ้าคืนไม่หมดก็ ลบ สินค้าออก จากนั้นคำนวนในฐานข้อมูล sale ในตาราง total_all ใหม่
                strSQL = "SELECT total_pro,code_pro FROM sale_barcode WHERE code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "' AND sale_id='" & Me.lblRPsale_id_show.Text & "'"
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
                    strSQL = "UPDATE sale_barcode SET total_pro='" & TTA & "',return_id='" & Me.txtRP_ID.Text & "'" _
                        & ",employee='" & LoginFrm.txtLoginUsername.Text & "' WHERE code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "' AND sale_id='" & Me.lblRPsale_id_show.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                ElseIf TTA = 0 Then
                    'del sale_barcode
                    strSQL = "DELETE FROM sale_barcode WHERE code_pro='" & bcta & "' AND sale_id='" & Me.lblRPsale_id_show.Text & "'"
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
        'get total_all        *************************************  แก้ไข 20160110
        Dim a As Decimal
        Try
            Dim Dr1 As MySqlDataReader
            strSQL = "SELECT total_all FROM sale WHERE sale_id='" & Me.lblRPsale_id_show.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr1 = cmd.ExecuteReader
            Dr1.Read()
            Dim total_all As Decimal = Dr1(0)
            a = total_all - CDec(Me.txtRPsumall.Text)
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        a = Nothing

        'นับจำนวน sn(cash_sale_serial) และบาร์โค๊ต(cash_sal_barcode) ว่ามีเหลือหรือไม่ ถ้าไม่มีลบ
        Dim cidBC As Decimal
        Dim cidSN As Decimal
        Try
            strSQL = "SELECT COUNT(sale_id) AS SIDBC FROM sale_barcode WHERE sale_id='" & Me.lblRPsale_id_show.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cidBC = Dr.GetDecimal("SIDBC")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            strSQL = "SELECT COUNT(sale_id) AS SIDSN FROM sale_serial WHERE sale_id='" & Me.lblRPsale_id_show.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cidSN = Dr.GetDecimal("SIDSN")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        If cidBC = 0 And cidSN = 0 Then
            Try
                strSQL = "DELETE FROM sale WHERE sale_id='" & Me.lblRPsale_id_show.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        End If
        cidBC = Nothing
        cidSN = Nothing
    End Sub
    '  สิค้าที่เป็นเงินสด จ่ายเงินแล้ว *****************************************************************************************************************************
    Private Sub saveDataReturnCash()
        Try
            'edit แล้ว 20151025
            Mainfrm.lblMainStatus.Text = "insert into returnproduct_id"
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
            Mainfrm.lblMainStatus.Text = "insert into returnproduct"
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
                    .Parameters.Add(New MySqlParameter("@employee", Me.lblemployee.Text))
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
                strSQL = "INSERT INTO product_serial(code_pro,serial_pro,name_pro,date_in)" _
                            & "VALUES(@code_pro,@serial_pro,@name_pro,@date_in)"
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
                strSQL = "INSERT INTO returnproduct_serial(return_id,sale_id,fix_id,customer_id,customer_name,code_pro,name_pro,serial_pro,datetime_save,employee)" _
                           & "VALUES(@return_id,@sale_id,@fix_id,@customer_id,@customer_name,@code_pro,@name_pro,@serial_pro,@datetime_save,@employee)"
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
                strSQL = "DELETE FROM cash_sale_serial WHERE serial_pro='" & Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value & "' and sale_id='" & Me.lblRPsale_id_show.Text & "'"
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
            'edit แล้ว
            For BCnum As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                'get count_num from product
                strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                End Using
                Dim cn As Integer = Dr(0)
                Dim cnt As Integer = cn + CInt(Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value)
                'update count_num from product
                strSQL = "UPDATE product SET count_num='" & cnt & "' WHERE code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                'insert to returnproduct_barcode
                strSQL = "INSERT INTO returnproduct_barcode(return_id,sale_id,fix_id,code_pro,name_pro,unit,price_buy,total,employee,datetime_save)VALUES(@return_id,@sale_id,@fix_id,@code_pro,@name_pro,@unit,@price_buy,@total,@employee,@datetime_save);"
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
                strSQL = "SELECT total_pro,code_pro FROM cash_sale_barcode WHERE code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "' AND sale_id='" & Me.lblRPsale_id_show.Text & "'"
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
                    strSQL = "UPDATE cash_sale_barcode SET total_pro='" & TTA & "',return_id='" & Me.txtRP_ID.Text & "'" _
                        & ",employee='" & Me.lblemployee.Text & "' WHERE code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "' AND sale_id='" & Me.lblRPsale_id_show.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                ElseIf TTA = 0 Then
                    'del sale_barcode
                    strSQL = "DELETE FROM cash_sale_barcode WHERE code_pro='" & bcta & "' AND sale_id='" & Me.lblRPsale_id_show.Text & "'"
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
        'get total_all *************************************  แก้ไข 20160110
        Dim a As Decimal
        Try
            Dim Dr1 As MySqlDataReader
            strSQL = "SELECT total_all FROM cash_sale WHERE sale_id='" & Me.lblRPsale_id_show.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr1 = cmd.ExecuteReader
            Dr1.Read()
            Dim total_all As Decimal = Dr1(0)
            a = total_all - CDec(Me.txtRPsumall.Text)
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        'update and del sale
        Try
            strSQL = "UPDATE cash_sale SET total_all= '" & a & "',employee='" & Me.lblemployee.Text & "',return_id='" & Me.txtRP_ID.Text & "',date_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "' where sale_id='" & Me.lblRPsale_id_show.Text & "' "
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        a = Nothing
        'นับจำนวน sn(cash_sale_serial) และบาร์โค๊ต(cash_sal_barcode) ว่ามีเหลือหรือไม่ ถ้าไม่มีลบ
        Dim cidBC As Decimal
        Dim cidSN As Decimal
        Try
            strSQL = "SELECT COUNT(sale_id) AS SIDBC FROM cash_sale_barcode WHERE sale_id='" & Me.lblRPsale_id_show.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cidBC = Dr.GetDecimal("SIDBC")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            strSQL = "SELECT COUNT(sale_id) AS SIDSN FROM cash_sale_serial WHERE sale_id='" & Me.lblRPsale_id_show.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cidSN = Dr.GetDecimal("SIDSN")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        If cidBC = 0 And cidSN = 0 Then
            Try
                strSQL = "DELETE FROM cash_sale WHERE sale_id='" & Me.lblRPsale_id_show.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        End If
        cidBC = Nothing
        cidSN = Nothing
    End Sub
    ' **********************************************************************************************************************************************************
    Friend txtRPID As String
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
                If Me.lblRPproductStatus.Text = "เครดิต" Then
                    txtRPID = Me.txtRP_ID.Text
                    Call saveDataReturn()
                    Call saveANDdelDataSN()
                    Call saveANDdelDataBarcode()
                    ReturnProductReportPrintFrm.MdiParent = Mainfrm
                    ReturnProductReportPrintFrm.Show()
                    MsgBox("คืนสินค้าเรียบร้อย หน้าต่างนี้จะปิดเมื่อคืนสินค้าเรียบร้อย", MsgBoxStyle.Information, "แจ้งเตือน")
                    Call clear()
                    Me.Close()
                ElseIf Me.lblRPproductStatus.Text = "เงินสด" Then
                    txtRPID = Me.txtRP_ID.Text
                    Call saveDataReturnCash()
                    Call saveANDdelDataSNcash()
                    Call saveANDdelDataBarcodecash()
                    ReturnProductReportPrintFrm.MdiParent = Mainfrm
                    ReturnProductReportPrintFrm.Show()
                    MsgBox("คืนสินค้าเรียบร้อย หน้าต่างนี้จะปิดเมื่อคืนสินค้าเรียบร้อย", MsgBoxStyle.Information, "แจ้งเตือน")
                    Call clear()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub txtRPsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRPsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDatatodgRPproBySN()
        End If
    End Sub

    Private Sub btnRPdelsendProSN_Click(sender As Object, e As EventArgs) Handles btnRPdelsendProSN.Click
        If Me.dgRPsendProSN.Rows.Count = 0 Then
        Else
            For del As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                If Me.dgRPsendProBarcode.Rows(del).Cells(0).Value = Me.dgRPsendProSN.SelectedCells.Item(1).Value Then
                    If CDec(Me.dgRPsendProBarcode.Rows(del).Cells(3).Value) > 1 Then
                        Me.dgRPsendProBarcode.Rows(del).Cells(3).Value = CDec(Me.dgRPsendProBarcode.Rows(del).Cells(3).Value) - 1
                        Call sumDG()
                    ElseIf CDec(Me.dgRPsendProBarcode.Rows(del).Cells(3).Value) = 1 Then
                        Me.dgRPsendProBarcode.Rows.RemoveAt(del)
                        Call sumDG()
                    End If
                End If
            Next
        End If
        If Me.dgRPsendProSN.Rows.Count = 0 Then
        Else
            Me.dgRPsendProSN.Rows.Remove(Me.dgRPsendProSN.SelectedRows(0))
            Call sumDG()
        End If
    End Sub

    Private Sub btnRPdelsendPro_Click(sender As Object, e As EventArgs) Handles btnRPdelsendPro.Click
        If Me.dgRPsendProBarcode.Rows.Count = 0 Then
        Else
            For del As Integer = 0 To Me.dgRPsendProSN.Rows.Count - 1
                If Me.dgRPsendProSN.Rows(del).Cells(1).Value = Me.dgRPsendProBarcode.SelectedCells.Item(0).Value Then
                    MsgBox("รายการที่จะลบนี้ มีรายการที่เป็น SN อยู่ กรุณาลบรายการในช่อง SN", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                End If
            Next
        End If
        If Me.dgRPsendProBarcode.Rows.Count = 0 Then
        Else
            Me.dgRPsendProBarcode.Rows.Remove(Me.dgRPsendProBarcode.SelectedRows(0))
            Call sumDG()
        End If
    End Sub
End Class