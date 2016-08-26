Imports MySql.Data.MySqlClient

Module updateDatabase1450
    Friend Sub updateDatabase_1450()
        Try
            strSQL = "CREATE TABLE `reportuserrepair` (" _
                    & "`no` VARCHAR(50) NULL," _
                    & "`fix_id` VARCHAR(50) NULL," _
                    & "`cus_name` VARCHAR(200) NULL," _
                    & "`code_pro` VARCHAR(50) NULL," _
                    & "`name_pro` VARCHAR(50) NULL," _
                    & "`total` VARCHAR(50) NULL," _
                    & "`price_cost` VARCHAR(50) NULL," _
                    & "`price_buy` VARCHAR(50) NULL," _
                    & "`discount` VARCHAR(50) NULL," _
                    & "`total_cost` VARCHAR(50) NULL," _
                    & "`total_buy` VARCHAR(50) NULL," _
                    & "`datetime_save` VARCHAR(50) NULL" _
                    & ")" _
                    & "COLLATE='utf8_general_ci'" _
                    & "ENGINE = MyISAM;"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `claims_copy`" _
                & "ADD COLUMN `price_wholesale` VARCHAR(100) NULL DEFAULT '-' AFTER `price_buy`," _
                & "ADD COLUMN `price_technician` VARCHAR(100) NULL DEFAULT '-' AFTER `price_wholesale`," _
                & "ADD COLUMN `price_loyel` VARCHAR(100) NULL DEFAULT '-' AFTER `price_technician`," _
                & "ADD COLUMN `price_members` VARCHAR(100) NULL DEFAULT '-' AFTER `price_loyel`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        'ย้ายงานเคลม ที่เคลมเสร็จส่งคืนแล้ว ไปไว้ที่ claims_copy
        Try
            Mainfrm.lblMainStatus.Text = "ย้ายข้อมูลเคลม"
            strSQL = "INSERT INTO claims_copy(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyel,price_members,`type`,unit,datetime_sale,datetime_return,datetime_edit,claims_money,employee_claims_return,tel_to_cus,employee_sale,symptom,accressory,note,note2,`status`,employee,datetime_save,claims_id_pic)" _
                & "SELECT * FROM claims WHERE `status`='" & "ส่งคืนแล้ว" & "'"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()


            strSQL = "DELETE FROM claims WHERE `status`='" & "ส่งคืนแล้ว" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='2.9';"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Call updateDatabase_1500()
    End Sub
End Module
