Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class VarunteeCheckSNFrm
  
    Private Sub VarunteeCheckFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub

    Friend Sub searchData()
        Try
            Me.rbVCforSale.Enabled = True
            Dim cp As String
            If Me.txtVCSNsearch.Text = "" Then
                Exit Sub
            Else
                strSQL = "SELECT sale_id,fix_id,customer_id,customer_name,name_pro,code_pro,bar_code,serial_pro,date_in,datetime_save,employee FROM cash_sale_serial WHERE serial_pro='" & Me.txtVCSNsearch.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Me.txtVCSNsn.Text = Dr.GetString("serial_pro")
                    Me.txtVCSNsalea_id.Text = Dr.GetString("sale_id")
                    Me.txtVCSNfix_id.Text = Dr.GetString("fix_id")
                    Me.txtVCSNcus_id.Text = Dr.GetString("customer_id")
                    Me.txtVCSNcus_name.Text = Dr.GetString("customer_name")
                    Me.txtVCSNbar_code.Text = Dr.GetString("bar_code")
                    Me.txtVCSNname_pro.Text = Dr.GetString("name_pro")
                    cp = Dr.GetString("code_pro")
                    Me.txtVCSNdatetime_save.Text = Dr.GetString("datetime_save")
                    Me.txtVCSNdate_in.Text = Dr.GetString("date_in")
                    Me.txtVCSNemployee.Text = Dr.GetString("employee")
                    strSQL = "SELECT varuntee FROM product WHERE code_pro='" & cp & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    If Dr.HasRows Then
                        Me.txtVCSNvaruntee.Text = Dr.GetString("varuntee")
                        Mainfrm.lblMainStatus.Text = "ค้นข้อมูลมาจากรายการสินค้าที่ชำระเงินแล้ว"
                        Me.lblVCnote.Text = "ค้นข้อมูลมาจากรายการสินค้าที่ชำระเงินแล้ว"
                    End If
                Else
                    strSQL = "SELECT sale_id,fix_id,customer_id,customer_name,name_pro,code_pro,bar_code,serial_pro,date_in,datetime_save,employee FROM sale_serial WHERE serial_pro='" & Me.txtVCSNsearch.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    If Dr.HasRows Then
                        Me.txtVCSNsn.Text = Dr.GetString("serial_pro")
                        Me.txtVCSNsalea_id.Text = Dr.GetString("sale_id")
                        Me.txtVCSNfix_id.Text = Dr.GetString("fix_id")
                        Me.txtVCSNcus_id.Text = Dr.GetString("customer_id")
                        Me.txtVCSNcus_name.Text = Dr.GetString("customer_name")
                        Me.txtVCSNbar_code.Text = Dr.GetString("bar_code")
                        Me.txtVCSNname_pro.Text = Dr.GetString("name_pro")
                        cp = Dr.GetString("code_pro")
                        Me.txtVCSNdatetime_save.Text = Dr.GetString("datetime_save")
                        Me.txtVCSNdate_in.Text = Dr.GetString("date_in")
                        Me.txtVCSNemployee.Text = Dr.GetString("employee")
                        strSQL = "SELECT varuntee FROM product WHERE code_pro='" & cp & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader
                        Dr.Read()
                        If Dr.HasRows Then
                            Me.txtVCSNvaruntee.Text = Dr.GetString("varuntee")
                            Mainfrm.lblMainStatus.Text = "ค้นข้อมูลมาจากรายการสินค้าที่ยังไม่ชำระเงิน"
                            Me.lblVCnote.Text = "ค้นข้อมูลมาจากรายการสินค้าที่ยังไม่ชำระเงิน"
                        End If
                    Else
                        Me.rbVCforSale.Enabled = False
                        'หาจากสินค้าที่ยังไม่ขาย
                        strSQL = "SELECT code_pro,serial_pro,name_pro,date_in FROM product_serial WHERE serial_pro='" & Me.txtVCSNsearch.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader
                        Dr.Read()
                        If Dr.HasRows Then
                            Me.txtVCSNsn.Text = Dr.GetString("serial_pro")
                            Me.txtVCSNsalea_id.Text = "-"
                            Me.txtVCSNfix_id.Text = "-"
                            Me.txtVCSNcus_id.Text = "-"
                            Me.txtVCSNcus_name.Text = "-"
                            cp = Dr.GetString("code_pro")
                            Me.txtVCSNbar_code.Text = cp
                            Me.txtVCSNname_pro.Text = Dr.GetString("name_pro")
                            Me.txtVCSNdatetime_save.Text = "0"
                            Me.txtVCSNdate_in.Text = Dr.GetString("date_in")
                            Me.txtVCSNemployee.Text = "-"

                            strSQL = "SELECT varuntee FROM product WHERE code_pro='" & cp & "'"
                            Mainfrm.lblMainStatus.Text = strSQL
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader
                            Dr.Read()
                            If Dr.HasRows Then
                                Me.txtVCSNvaruntee.Text = Dr.GetString("varuntee")
                                Mainfrm.lblMainStatus.Text = "ค้นข้อมูลมาจากรายการสินค้าที่ยังไม่ได้ขาย"
                                Me.lblVCnote.Text = "ค้นข้อมูลมาจากรายการสินค้าที่ยังไม่ได้ขาย"
                            Else
                                Mainfrm.lblMainStatus.Text = "ไม่พบข้อมูล "
                                MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Exclamation, "แจ้งเตือน")

                            End If
                        End If
                    End If
                End If
            End If
            strSQL = "SELECT day FROM varuntee WHERE varuntee_status='" & Me.txtVCSNvaruntee.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            dateNum = Dr.GetString("day")
            Call checkExpri()
            cp = Nothing
            Me.txtVCSNsearch.Text = ""
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Dim dateNum As Integer
    Dim msg, datevrt As String
    Dim secondDate As Date
    Private Sub checkExpri()
        If Me.txtVCSNsn.Text = "" Then
            Exit Sub
        End If
        Dim dayPro As Date
        If Me.rbVCforSale.Checked Then
            dayPro = Me.txtVCSNdatetime_save.Text
        ElseIf Me.rbVCforIN.Checked Then
            dayPro = Me.txtVCSNdate_in.Text
        End If
        msg = DateAdd(DateInterval.Day, dateNum, dayPro)
        Me.txtVCSNexprice.Text = msg
        dayPro = Nothing
    End Sub
    Private Sub txtVCsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVCSNsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call searchData()

        End If
    End Sub

    Private Sub btnVCsearch_Click(sender As Object, e As EventArgs) Handles btnVCsearch.Click
        Call searchData()

    End Sub

    Private Sub rbVCforIN_CheckedChanged(sender As Object, e As EventArgs) Handles rbVCforIN.CheckedChanged
        Call checkExpri()
    End Sub

    Private Sub rbVCforSale_CheckedChanged(sender As Object, e As EventArgs) Handles rbVCforSale.CheckedChanged
        Call checkExpri()
    End Sub
End Class