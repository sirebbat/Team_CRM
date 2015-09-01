'Dashboard


Imports System.Data.OleDb

Public Class Dashboard


    'Dashboard - Create Button
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Me.SendToBack()
        create_contact.Visible = True
        create_contact.BringToFront()


    End Sub

    'Dashboard - Search Button
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.SendToBack()
        search_contact.Visible = True
        search_contact.BringToFront()


        'Enables the save and delete buttons

        ci_btn_save.Enabled = False
        ci_btn_delete.Enabled = False
        ci_btn_save.Visible = False
        ci_btn_delete.Visible = False

        ci_btn_cancel.Enabled = False
        ci_btn_cancel.Visible = False

        ci_btn_save.Enabled = False
        ci_btn_delete.Enabled = False

        'disables the update button
        ci_btn_update.Enabled = False
        ci_btn_update.Visible = False

    End Sub

    'Add button - Employee tab
    Private Sub emp_btn_add_Click(sender As Object, e As EventArgs) Handles emp_btn_add.Click
        Me.SendToBack()
        add_employee.Visible = True
    End Sub

    Private Sub ci_btn_update_Click(sender As Object, e As EventArgs) Handles ci_btn_update.Click

        'Makes contact information editable.

        ci_txt_fname.ReadOnly = False
        ci_txt_lname.ReadOnly = False
        ci_txt_company.ReadOnly = False
        ci_txt_url.ReadOnly = False
        adr_txt_streetad.ReadOnly = False
        adr_txt_streetadd.ReadOnly = False
        ci_txt_officen.ReadOnly = False
        ci_txt_cellp.ReadOnly = False
        ci_txt_email.ReadOnly = False
        adr_txt_state.Enabled = True
        adr_txt_zip.ReadOnly = False
        adr_txt_city.ReadOnly = False

        'changes color of the 


        ci_txt_fname.BackColor = Color.Honeydew
        ci_txt_lname.BackColor = Color.Honeydew
        ci_txt_company.BackColor = Color.Honeydew
        ci_txt_url.BackColor = Color.Honeydew
        adr_txt_streetad.BackColor = Color.Honeydew
        adr_txt_streetadd.BackColor = Color.Honeydew
        ci_txt_officen.BackColor = Color.Honeydew
        ci_txt_cellp.BackColor = Color.Honeydew
        ci_txt_email.BackColor = Color.Honeydew
        adr_txt_state.BackColor = Color.Honeydew
        adr_txt_zip.BackColor = Color.Honeydew
        adr_txt_city.BackColor = Color.Honeydew

        'Enables the save and delete buttons

        ci_btn_save.Enabled = True
        ci_btn_delete.Enabled = True
        ci_btn_save.Visible = True
        ci_btn_delete.Visible = True

        ci_btn_cancel.Enabled = True
        ci_btn_cancel.Visible = True

        ci_btn_save.Enabled = True
        ci_btn_delete.Enabled = True

        'disables the update button
        ci_btn_update.Enabled = False


    End Sub

    'contact information save button
    Private Sub ci_btn_save_Click(sender As Object, e As EventArgs) Handles ci_btn_save.Click

        Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" & Environment.CurrentDirectory & "\crm_db.accdb"

        'Variables for the Access database
        Dim myConnection As New OleDbConnection(myConnString)

        Try

            'opens the connection
            myConnection.Open()

            If ci_txt_fname.Text IsNot String.Empty And ci_txt_lname.Text IsNot String.Empty And ci_txt_email IsNot String.Empty Then
                'Creates the INSERT query
                Dim myCommand As New OleDbCommand("UPDATE crm_contact SET fname = @fname, lname = @lname, company = @company, office_number = @office_number, cell_phone = @cell_phone, email = @email,  url = @url, street_one = @street_one, street_two = @street_two, city = @city, state = @state, zip_code = @zip_code WHERE account = @account", myConnection)

                'VALUES of the UPDATE query

                myCommand.Parameters.AddWithValue("@fname", CType(ci_txt_fname.Text, String))

                myCommand.Parameters.AddWithValue("@lname", CType(ci_txt_lname.Text, String))

                myCommand.Parameters.AddWithValue("@company", CType(ci_txt_company.Text, String))

                myCommand.Parameters.AddWithValue("@office_number", CType(ci_txt_officen.Text, String))

                myCommand.Parameters.AddWithValue("@cell_phone", CType(ci_txt_cellp.Text, String))

                myCommand.Parameters.AddWithValue("@email", CType(ci_txt_email.Text, String))

                myCommand.Parameters.AddWithValue("@url", CType(ci_txt_url.Text, String))

                myCommand.Parameters.AddWithValue("@street_one", CType(adr_txt_streetad.Text, String))

                myCommand.Parameters.AddWithValue("@street_two", CType(adr_txt_streetadd.Text, String))

                myCommand.Parameters.AddWithValue("@city", CType(adr_txt_city.Text, String))

                myCommand.Parameters.AddWithValue("@state", CType(adr_txt_state.Text, String))

                myCommand.Parameters.AddWithValue("@zip_code", CType(adr_txt_zip.Text, String))
                myCommand.Parameters.AddWithValue("@account", CType(ci_txt_account.Text, Integer))


                ' excute SQL expression
                myCommand.ExecuteNonQuery()

                myCommand.Dispose()

                myConnection.Close()


                'Saved message

                MessageBox.Show("Contact Saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Makes contact information NOT editable.

                ci_txt_fname.ReadOnly = True
                ci_txt_lname.ReadOnly = True
                ci_txt_company.ReadOnly = True
                ci_txt_url.ReadOnly = True
                adr_txt_streetad.ReadOnly = True
                adr_txt_streetadd.ReadOnly = True
                ci_txt_officen.ReadOnly = True
                ci_txt_cellp.ReadOnly = True
                ci_txt_email.ReadOnly = True
                adr_txt_state.Enabled = True
                adr_txt_zip.ReadOnly = True
                adr_txt_city.ReadOnly = True

                'changes color of the 


                ci_txt_fname.BackColor = Color.WhiteSmoke
                ci_txt_lname.BackColor = Color.WhiteSmoke
                ci_txt_company.BackColor = Color.WhiteSmoke
                ci_txt_url.BackColor = Color.WhiteSmoke
                adr_txt_streetad.BackColor = Color.WhiteSmoke
                adr_txt_streetadd.BackColor = Color.WhiteSmoke
                ci_txt_officen.BackColor = Color.WhiteSmoke
                ci_txt_cellp.BackColor = Color.WhiteSmoke
                ci_txt_email.BackColor = Color.WhiteSmoke
                adr_txt_state.BackColor = Color.WhiteSmoke
                adr_txt_zip.BackColor = Color.WhiteSmoke
                adr_txt_city.BackColor = Color.WhiteSmoke


                'Makes update button enbled

                ci_btn_update.Enabled = True

                'hides save and delete buttons


                ci_btn_save.Enabled = False
                ci_btn_delete.Enabled = False

                ci_btn_save.Visible = False
                ci_btn_delete.Visible = False
                ci_btn_cancel.Enabled = False
                ci_btn_cancel.Visible = False

                ci_txt_fname.Focus()


            Else

                MessageBox.Show("Contact Not Saved. Please Enter Required Fields", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If



        Catch ex As Exception

            MsgBox(ex.Message)

        End Try









    End Sub

    Private Sub ci_btn_cancel_Click(sender As Object, e As EventArgs) Handles ci_btn_cancel.Click

        'Makes contact information NOT editable.

        ci_txt_fname.ReadOnly = True
        ci_txt_lname.ReadOnly = True
        ci_txt_company.ReadOnly = True
        ci_txt_url.ReadOnly = True
        adr_txt_streetad.ReadOnly = True
        adr_txt_streetadd.ReadOnly = True
        ci_txt_officen.ReadOnly = True
        ci_txt_cellp.ReadOnly = True
        ci_txt_email.ReadOnly = True
        adr_txt_state.Enabled = True
        adr_txt_zip.ReadOnly = True
        adr_txt_city.ReadOnly = True

        'changes color of the 


        ci_txt_fname.BackColor = Color.WhiteSmoke
        ci_txt_lname.BackColor = Color.WhiteSmoke
        ci_txt_company.BackColor = Color.WhiteSmoke
        ci_txt_url.BackColor = Color.WhiteSmoke
        adr_txt_streetad.BackColor = Color.WhiteSmoke
        adr_txt_streetadd.BackColor = Color.WhiteSmoke
        ci_txt_officen.BackColor = Color.WhiteSmoke
        ci_txt_cellp.BackColor = Color.WhiteSmoke
        ci_txt_email.BackColor = Color.WhiteSmoke
        adr_txt_state.BackColor = Color.WhiteSmoke
        adr_txt_zip.BackColor = Color.WhiteSmoke
        adr_txt_city.BackColor = Color.WhiteSmoke


        'Makes update button enbled

        ci_btn_update.Enabled = True

        'hides save and delete buttons


        ci_btn_save.Enabled = False
        ci_btn_delete.Enabled = False

        ci_btn_save.Visible = False
        ci_btn_delete.Visible = False
        ci_btn_cancel.Enabled = False
        ci_btn_cancel.Visible = False




    End Sub

    Private Sub ci_btn_delete_Click(sender As Object, e As EventArgs) Handles ci_btn_delete.Click

        Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" & Environment.CurrentDirectory & "\crm_db.accdb"

        'Variables for the Access database
        Dim myConnection As New OleDbConnection(myConnString)

        Try

            'opens the connection
            myConnection.Open()


            'Creates the INSERT query
            Dim myCommand As New OleDbCommand("DELETE FROM crm_contact WHERE account = @account", myConnection)

            'VALUES of the DELETE query



            myCommand.Parameters.AddWithValue("@account", CType(ci_txt_account.Text, Integer))


                ' excute SQL expression
                myCommand.ExecuteNonQuery()

                myCommand.Dispose()

                myConnection.Close()


            'Removed message

            MessageBox.Show("Contact Removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Makes contact information NOT editable.

            ci_txt_fname.ReadOnly = True
                ci_txt_lname.ReadOnly = True
                ci_txt_company.ReadOnly = True
                ci_txt_url.ReadOnly = True
                adr_txt_streetad.ReadOnly = True
                adr_txt_streetadd.ReadOnly = True
                ci_txt_officen.ReadOnly = True
                ci_txt_cellp.ReadOnly = True
                ci_txt_email.ReadOnly = True
                adr_txt_state.Enabled = True
                adr_txt_zip.ReadOnly = True
                adr_txt_city.ReadOnly = True

                'changes color of the 


                ci_txt_fname.BackColor = Color.WhiteSmoke
                ci_txt_lname.BackColor = Color.WhiteSmoke
                ci_txt_company.BackColor = Color.WhiteSmoke
                ci_txt_url.BackColor = Color.WhiteSmoke
                adr_txt_streetad.BackColor = Color.WhiteSmoke
                adr_txt_streetadd.BackColor = Color.WhiteSmoke
                ci_txt_officen.BackColor = Color.WhiteSmoke
                ci_txt_cellp.BackColor = Color.WhiteSmoke
                ci_txt_email.BackColor = Color.WhiteSmoke
                adr_txt_state.BackColor = Color.WhiteSmoke
                adr_txt_zip.BackColor = Color.WhiteSmoke
                adr_txt_city.BackColor = Color.WhiteSmoke


            'hides update button 

            ci_btn_update.Enabled = False

            ci_btn_update.Visible = False

            'hides save and delete buttons


            ci_btn_save.Enabled = False
                ci_btn_delete.Enabled = False

                ci_btn_save.Visible = False
                ci_btn_delete.Visible = False
                ci_btn_cancel.Enabled = False
                ci_btn_cancel.Visible = False

            ci_txt_fname.Focus()

            'clears the form

            ci_txt_fname.Clear()
            ci_txt_lname.Clear()
            ci_txt_company.Clear()
            ci_txt_url.Clear()
            adr_txt_streetad.Clear()
            adr_txt_streetadd.Clear()
            ci_txt_officen.Clear()
            ci_txt_cellp.Clear()
            ci_txt_email.Clear()
            adr_txt_state.ResetText()
            adr_txt_zip.Clear()
            adr_txt_city.Clear()
            ci_txt_account.Clear()
            ci_created_date.Clear()




        Catch ex As Exception

            MsgBox(ex.Message)

        End Try



    End Sub
    '|------------ EMPLOYEE TAB - LOAD BUTTON-------------|
    Private Sub emp_btn_load_Click(sender As Object, e As EventArgs) Handles emp_btn_load.Click

        Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" & Environment.CurrentDirectory & "\crm_db.accdb"

        'clears list view items
        emp_lv.Items.Clear()


        'Variables for the Access database
        Dim myConnection As New OleDbConnection(myConnString)
        Try

            'opens the connection
            myConnection.Open()

            'Search by account number

            'query
            Dim myCommand As New OleDbCommand("SELECT * FROM crm_employee", myConnection)
            Dim myReader As OleDbDataReader = myCommand.ExecuteReader

            'reads the query
            While myReader.Read

                'Adds items to the dashboard
                Dim emp_listviewitem As New ListViewItem
                emp_listviewitem.Text = myReader.GetInt32(0)
                emp_listviewitem.SubItems.Add(myReader.GetString(1))
                emp_listviewitem.SubItems.Add(myReader.GetString(2))
                emp_listviewitem.SubItems.Add(myReader.GetString(3))
                emp_listviewitem.SubItems.Add(myReader.GetString(4))


                emp_lv.Items.Add(emp_listviewitem)
            End While

            emp_btn_delete.Visible = True
            emp_btn_cancel.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try




    End Sub

    '|-----------------CANCEL BUTTON-------------------------|
    Private Sub emp_btn_cancel_Click(sender As Object, e As EventArgs) Handles emp_btn_cancel.Click

        'hides delete and cancel button
        emp_btn_delete.Visible = False
        emp_btn_cancel.Visible = False



    End Sub

    '|----DELETE BUTTON ----|
    Private Sub emp_btn_delete_Click(sender As Object, e As EventArgs) Handles emp_btn_delete.Click

        Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" & Environment.CurrentDirectory & "\crm_db.accdb"

        If (emp_lv.SelectedItems.Count > 0) Then



            For Each i As ListViewItem In emp_lv.SelectedItems
                Try

                    Dim myConnection As New OleDbConnection(myConnString)
                    myConnection.Open()
                    Dim myCommand As New OleDbCommand("DELETE FROM crm_employee WHERE ID =@employeeID", myConnection)
                    myCommand.Parameters.AddWithValue("@employeeID", i.Text)


                    myCommand.ExecuteNonQuery()

                    emp_lv.Items.Remove(i)


                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try




                'Removes the item for the list view




            Next





        End If



    End Sub
End Class
