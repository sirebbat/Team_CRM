Public Class create_contact
    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles ci_btn_cancel.MouseClick
        Me.Close()
        Dashboard.BringToFront()


    End Sub

    Private Sub ci_btn_update_MouseClick(sender As Object, e As MouseEventArgs) Handles ci_btn_update.MouseClick
        MessageBox.Show("Contact Saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Dim con As New OleDb.OleDbConnection

        Dim cmd As New OleDb.OleDbCommand


        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ruben\Documents\GitHub\Team_CRM\db\crm_db.accdb"

        con.Open()

        Sql = "INSERT INTO crm_contact(fname, lname, company, office_number, cell_phone, url, created_date,street_one, street_two, city, state, zip_code)  VALUES('" & ci_txt_fname.Text & "','" & ci_txt_lname.Text & "','" & ci_txt_company.Text & "','" & ci_txt_officen.Text & "','" & ci_txt_cellp.Text & "','" & ci_txt_url.Text & "','" & ci_created_date.Value & "','" & ci_txt_addrone.Text & "','" & ci_txt_addrtwo.Text & "','" & adr_txt_city.Text & "','" & adr_txt_state.Text & "','" & adr_txt_zip.Text & "')"
        cmd = New OleDb.OleDbCommand(Sql, con)
        cmd.ExecuteNonQuery()
        MsgBox("saved")



        con.Close()



    End Sub
End Class