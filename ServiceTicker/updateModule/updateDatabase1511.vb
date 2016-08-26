Imports MySql.Data.MySqlClient

Module updateDatabase1511
    Friend Sub updateDatabase_1511()
        Try
            strSQL = "CREATE TABLE `shelf` (`s` VARCHAR(255) NULL)COLLATE='utf8_general_ci'ENGINE = MyISAM;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Try
            strSQL = "CREATE TABLE `credit_card` (`card_type` VARCHAR(50) NULL DEFAULT 'none')COLLATE='utf8_general_ci'ENGINE = MyISAM;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Try
            strSQL = "INSERT INTO `credit_card` (`card_type`) VALUES ('MasterCard');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card` (`card_type`) VALUES ('Visa');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card` (`card_type`) VALUES ('American Express');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card` (`card_type`) VALUES ('Discover');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "CREATE TABLE `credit_card_bank` (`bank_name` VARCHAR(200) NULL DEFAULT 'none')COLLATE='utf8_general_ci'ENGINE = MyISAM;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('กรุงไทย');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('กรุงเทพ');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('กสิกรไทย');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ไทยพานิชย์');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ซิตี้แบงก์');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('กรุงศรีอยุธยา');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('อิออน');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ธนชาติ');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ทหารไทย');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ยูโอบี');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ซีไอเอ็มบี');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ธนาคารแห่งประเทศจีน');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('สแตนดาร์ดชาร์เตอร์');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try


        Try
            strSQL = "INSERT INTO `credit_card_bank` (`bank_name`) VALUES ('ไอซีบีซี');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "UPDATE `database_version` SET `version`='3.1';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub
End Module
