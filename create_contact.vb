Imports System.Data.OleDb



Public Class create_contact

    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" & Environment.CurrentDirectory & "\crm_db.accdb"


    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles ci_btn_cancel.MouseClick
        Me.Close()
        Dashboard.BringToFront()


    End Sub

    Private Sub ci_btn_update_MouseClick(sender As Object, e As MouseEventArgs) Handles ci_btn_update.MouseClick




        'Variables for the Access database
        Dim myConnection As New OleDbConnection(myConnString)

        Try

            'opens the connection
            myConnection.Open()

            'Creates the INSERT query
            Dim myCommand As New OleDbCommand("INSERT INTO crm_contact (fname, lname, company, office_number, cell_phone, url, created_date, street_one, street_two, city, state, zip_code) VALUES (@fname, @lname, @company, @office_number, @cell_phone, @url, @created_date, @street_one, @street_two, @city, @state, @zip_code)", myConnection)

            'VALUES of the INSERT query

            myCommand.Parameters.AddWithValue("@fname", CType(ci_txt_fname.Text, String))

            myCommand.Parameters.AddWithValue("@lname", CType(ci_txt_lname.Text, String))

            myCommand.Parameters.AddWithValue("@company", CType(ci_txt_company.Text, String))

            myCommand.Parameters.AddWithValue("@office_number", CType(ci_txt_officen.Text, String))

            myCommand.Parameters.AddWithValue("@cell_phone", CType(ci_txt_cellp.Text, String))

            myCommand.Parameters.AddWithValue("@url", CType(ci_txt_url.Text, String))

            myCommand.Parameters.AddWithValue("@created_date", CType(ci_created_date.Text, String))

            myCommand.Parameters.AddWithValue("@street_one", CType(ci_txt_addrone.Text, String))

            myCommand.Parameters.AddWithValue("@street_two", CType(ci_txt_addrtwo.Text, String))

            myCommand.Parameters.AddWithValue("@city", CType(adr_txt_city.Text, String))

            myCommand.Parameters.AddWithValue("@state", CType(adr_txt_state.Text, String))

            myCommand.Parameters.AddWithValue("@zip_code", CType(adr_txt_zip.Text, String))


            ' excute SQL expression
            myCommand.ExecuteNonQuery()

            myCommand.Dispose()

            myConnection.Close()

            'clears the form

            ci_txt_fname.Clear()
            ci_txt_lname.Clear()
            ci_txt_company.Clear()
            ci_txt_officen.Clear()
            ci_txt_cellp.Clear()
            ci_txt_url.Clear()
            ci_created_date.Clear()
            ci_txt_addrone.Clear()
            ci_txt_addrtwo.Clear()
            adr_txt_city.Clear()
            adr_txt_state.ResetText()
            adr_txt_zip.Clear()




        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


        MessageBox.Show("Contact Saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)







    End Sub

End Class