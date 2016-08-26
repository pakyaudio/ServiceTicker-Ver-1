Imports MySql.Data.MySqlClient

Module updateDatabase1500
    Friend Sub updateDatabase_1500()
        Try
            strSQL = "ALTER TABLE `ver_detail`" & _
                            " ALTER `ver_icon` DROP DEFAULT;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "ALTER TABLE `ver_detail`" & _
                        " CHANGE COLUMN `ver_icon` `ver_icon` LONGBLOB NULL AFTER `ver_version`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `check_stock_bc` (" & _
                        "`csbc_id` VARCHAR(50) NULL DEFAULT '-'," & _
                        "`code_pro` VARCHAR(200) NULL DEFAULT '-'," & _
                        "`bar_code` VARCHAR(200) NULL DEFAULT '-'," & _
                        "`name_pro` VARCHAR(500) NULL DEFAULT '-'," & _
                        "`price_buy` VARCHAR(100) NULL DEFAULT '-'," & _
                        "`count_num` VARCHAR(100) NULL DEFAULT '-'," & _
                        "`count` VARCHAR(100) NULL DEFAULT '-'," & _
                        "`datetime_save` VARCHAR(50) NULL DEFAULT '-'" & _
                        ")" & _
                        "COLLATE='utf8_general_ci'" & _
                        "ENGINE = MyISAM" & _
                        ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `check_stock_bc_id` (" & _
                        "`id` INT UNSIGNED NOT NULL AUTO_INCREMENT," & _
                        "`csbc_id` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`total_pro_bc` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`count_num` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`disappear` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`over` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`csbc_status` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`datetime_save` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`datetime_last` VARCHAR(50) NULL DEFAULT '0'," & _
                        "`employee` VARCHAR(200) NULL DEFAULT '0'," & _
                        "PRIMARY KEY (`id`)" & _
                        ")" & _
                        "COLLATE='utf8_general_ci'" & _
                        "ENGINE = MyISAM" & _
                        ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `check_stock_bc_id` (`csbc_id`) VALUES ('start');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='3.0';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub
End Module
