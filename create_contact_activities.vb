Imports System.Data.OleDb

Public Class create_contact_activities

    'Variables for the Access database connection
    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" & Environment.CurrentDirectory & "\crm_db.accdb"

    Dim myConnection As New OleDbConnection(myConnString)


    'Dim employeeid
    Dim typeid As Integer

    'Save button

    Private Sub cca_btn_update_Click(sender As Object, e As EventArgs) Handles cca_btn_update.Click


        Try
            If Not cca_cb_employee.SelectedItem = String.Empty And Not cca_txt_comment.Text = String.Empty And Not cca_cb_contact_type.SelectedItem = String.Empty Then
                myConnection.Open()
                Dim myCommand As New OleDbCommand("INSERT INTO crm_activities (account_number, type, employee, created_on, comment) VALUES (@account_number, @type, @employee, @created_on, @comment)", myConnection)

                myCommand.Parameters.AddWithValue("@account_number", CType(Dashboard.ci_txt_account.Text, Int32))
                myCommand.Parameters.AddWithValue("@type", CType(cca_cb_contact_type.SelectedItem, String))
                myCommand.Parameters.AddWithValue("@employee", CType(cca_cb_employee.SelectedItem, String))
                myCommand.Parameters.AddWithValue("@created_on", CType(cca_dp_created_on.Text, Date))
                myCommand.Parameters.AddWithValue("@comment", CType(cca_txt_comment.Text, String))

                myCommand.ExecuteNonQuery()

                myCommand.Dispose()


                myConnection.Close()

                'Displays saved message
                MessageBox.Show("Activity Saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)


                'Clears the form

                cca_cb_contact_type.ResetText()
                cca_cb_employee.ResetText()
                cca_dp_created_on.ResetText()
                cca_txt_comment.ResetText()



            Else

                MessageBox.Show("All Fields are required. Please complete fields.", "Fields Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If

        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)




        End Try






    End Sub


    'Cancel Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cca_btn_cancel.Click
        Me.Close()

    End Sub

    'Loads combobox employees from database
    Private Sub cca_cb_employee_Click(sender As Object, e As EventArgs) Handles cca_cb_employee.Click

        'clears the combobox
        cca_cb_employee.Items.Clear()

        'used to see count now many records found in the db
        Dim recordCount As Integer = 0


        'Used to get the record from the db and then add it to the combobox
        Dim fname, lname As String


        Try
            myConnection.Open()
            Dim myCommand As New OleDbCommand("SELECT * FROM crm_employee", myConnection)
            Dim myReader As OleDbDataReader = myCommand.ExecuteReader


            'reads the query
            While myReader.Read
                recordCount = recordCount + 1

                'Adds items to the combobox
                Dim sc_listviewitem As New ListViewItem

                fname = myReader.GetString(1)
                lname = myReader.GetString(2)
                cca_cb_employee.Items.Add(fname & " " & lname)

            End While
            myConnection.Close()


            'checks for the records
            If recordCount = 0 Then
                MessageBox.Show("No employees found in the database. Please add employees via the employees tab and try again", "No Employees Found", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)




        End Try




    End Sub


    'Loads contact type combobox from database
    Private Sub cca_cb_contact_type_Click(sender As Object, e As EventArgs) Handles cca_cb_contact_type.Click

        'Clears the combobox
        cca_cb_contact_type.Items.Clear()

        'used to see count now many records found in the db
        Dim recordCount As Integer = 0

        'Used to get the record from the db and then add it to the combobox



        Try
            myConnection.Open()
            Dim myCommand As New OleDbCommand("SELECT * FROM crm_contact_type", myConnection)
            Dim myReader As OleDbDataReader = myCommand.ExecuteReader


            'reads the query
            While myReader.Read
                recordCount = recordCount + 1

                'Adds items to the combobox
                Dim sc_listviewitem As New ListViewItem
                typeid = myReader.GetInt32(0)
                cca_cb_contact_type.Items.Add(myReader.GetString(1))


            End While

            myConnection.Close()

            'checks for the records
            If recordCount = 0 Then
                MessageBox.Show("No contacts types found in the database.", "No contact types Found", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)




        End Try

    End Sub


    Private Sub cca_txt_comment_TextChanged(sender As Object, e As EventArgs) Handles cca_txt_comment.TextChanged

        Dim limit As Integer = 140
        Dim chars_left As Integer = 0
        'Counts the caracthers entered
        If cca_txt_comment.TextLength < limit Then

            chars_left = limit - cca_txt_comment.TextLength
            cca_lbl_char_left.ForeColor = Color.White
            cca_lbl_char_left.Text = chars_left

        ElseIf cca_txt_comment.TextLength = limit Then

            cca_lbl_char_left.ForeColor = Color.Coral
            cca_lbl_char_left.Text = "0"


        End If



    End Sub
End Class