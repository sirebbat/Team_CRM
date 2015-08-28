Imports System.Data.OleDb

Public Class create_contact
    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles ci_btn_cancel.MouseClick
        Me.Close()
        Dashboard.BringToFront()


    End Sub

    Private Sub ci_btn_update_MouseClick(sender As Object, e As MouseEventArgs) Handles ci_btn_update.MouseClick






        'Convert text box to characthers

        Dim fname As Char = ci_txt_fname.Text
        Dim lname As Char = ci_txt_lname.Text
        Dim company As Char = ci_txt_company.Text
        Dim office_number As Char = ci_txt_officen.Text
        Dim cell_phone As Char = ci_txt_cellp.Text
        Dim url As Char = ci_txt_url.Text
        Dim addrone As Char = ci_txt_addrone.Text
        Dim addrtwo As Char = ci_txt_addrtwo.Text
        Dim city As Char = adr_txt_city.Text
        Dim state As Char = adr_txt_state.Text
        Dim zip_code As Char = adr_txt_zip.Text


        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="

        'Change the following to your access database location

        dataFile = "C:\Users\ruben\Documents\GitHub\Team_CRM\db\crm_db.accdb"

        connString = provider & dataFile

        myConnection.ConnectionString = connString



        myConnection.Open()

        Dim str As String

        str = "insert into crm_contact ([fname], [lname], [company], [office_number], [cell_phone], [url], [street_one], [street_two], [city], [state], [zip_code]) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.Parameters.Add(New OleDbParameter("fname", CType(ci_txt_fname.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("lname", CType(ci_txt_lname.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("company", CType(ci_txt_company.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("office_number", CType(ci_txt_officen.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("cell_phone", CType(ci_txt_cellp.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("url", CType(ci_txt_url.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("street_one", CType(ci_txt_addrone.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("street_two", CType(ci_txt_addrtwo.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("city", CType(adr_txt_city.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("state", CType(adr_txt_state.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("zip_code", CType(adr_txt_zip.Text, String)))
        Try

            cmd.ExecuteNonQuery()

            cmd.Dispose()

            myConnection.Close()

            ci_txt_fname.Clear()
            ci_txt_lname.Clear()
            ci_txt_company.Clear()
            ci_txt_officen.Clear()
            ci_txt_cellp.Clear()
            ci_txt_url.Clear()
            ci_txt_addrone.Clear()
            ci_txt_addrtwo.Clear()
            adr_txt_city.Clear()
            adr_txt_state.Clear()
            adr_txt_zip.Clear()



        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
- See more at: http : //www.visual-basic-tutorials.com/writeToAccessTable.htm#sthash.phfFTl1Y.dpuf

        MessageBox.Show("Contact Saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)



        con.Close()



    End Sub
End Class