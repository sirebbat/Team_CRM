Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class add_employee
    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" & Environment.CurrentDirectory & "\crm_db.accdb"


    'Add Employee - Cancel Button
    Private Sub adde_btn_cancel_Click(sender As Object, e As EventArgs) Handles add_emp_btn_cancel.Click
        Me.Close()
        Dashboard.BringToFront()
    End Sub

    '-------------------------------FIELD VALIDATION---------------------------------------------
    'Firstname Field
    Private Sub add_emp_txt_fname_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles add_emp_txt_fname.Validating


        If (add_emp_txt_fname.Text Is String.Empty Or Not Regex.Match(add_emp_txt_fname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success) Then
            add_emp_lbl_fname.ForeColor = ColorTranslator.FromHtml("#e74c3c")  ' if empty then first name label to red

        Else
            add_emp_lbl_fname.ForeColor = Color.White

        End If

    End Sub

    'Last Name Field
    Private Sub add_emp_txt_lname_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles add_emp_txt_lname.Validating

        If (add_emp_txt_lname.Text Is String.Empty Or Not Regex.Match(add_emp_txt_lname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success) Then
            add_emp_lbl_lname.ForeColor = ColorTranslator.FromHtml("#e74c3c")  ' if empty then first name label to red

        Else
            add_emp_lbl_lname.ForeColor = Color.White

        End If
    End Sub

    'Email Field
    Private Sub add_emp_txt_email_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles add_emp_txt_email.Validating
        Dim email As String = add_emp_txt_email.Text

        'If not in correct format changes email label to red
        If EmailAddressCheck(email) = False Or email Is String.Empty Then
            add_emp_lbl_email.ForeColor = ColorTranslator.FromHtml("#e74c3c")

        Else
            'If not in correct format changes email label to White
            add_emp_lbl_email.ForeColor = Color.White

        End If
    End Sub


    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" &
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True

        Else
            EmailAddressCheck = False

        End If
    End Function


    'Phone field
    Private Sub add_emp_txt_phone_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles add_emp_txt_phone.Validating

        If (Not add_emp_txt_phone.MaskCompleted) Then
            add_emp_lbl_phone.ForeColor = ColorTranslator.FromHtml("#e74c3c")

        Else
            'If not in correct format changes email label to White
            add_emp_lbl_phone.ForeColor = Color.White

        End If

    End Sub


    '|----------------------SAVE BUTTON --------------------------|
    Private Sub add_emp_btn_save_Click(sender As Object, e As EventArgs) Handles add_emp_btn_save.Click

        'Variables for the Access database
        Dim myConnection As New OleDbConnection(myConnString)

        Try

            'opens the connection
            myConnection.Open()
            Dim recordCount As New Integer
            Dim myFirstCommand As New OleDbCommand("SELECT * FROM crm_employee WHERE fname =@fname AND lname =@lname AND phone = @phone", myConnection)
            myFirstCommand.Parameters.AddWithValue("@fname", CType(add_emp_txt_fname.Text, String))
            myFirstCommand.Parameters.AddWithValue("@lname", CType(add_emp_txt_fname.Text, String))
            myFirstCommand.Parameters.AddWithValue("@phone", CType(add_emp_txt_phone.Text, String))
            Dim myReader As OleDbDataReader = myFirstCommand.ExecuteReader

            'reads the query
            While myReader.Read

                recordCount = recordCount + 1
            End While
            'checks for the records

            If recordCount <> 0 Then

                Throw New ApplicationException


            End If

            myConnection.Close()

            If add_emp_txt_fname.Text IsNot String.Empty And Regex.Match(add_emp_txt_fname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success And add_emp_txt_lname.Text IsNot String.Empty And Regex.Match(add_emp_txt_lname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success And add_emp_txt_email.Text IsNot String.Empty And add_emp_txt_phone.MaskCompleted Then

                myConnection.Open()
                'Creates the INSERT query
                Dim myCommand As New OleDbCommand("INSERT INTO crm_employee (fname, lname, phone, email) VALUES (@fname, @lname, @phone, @email)", myConnection)

                'VALUES of the INSERT query

                myCommand.Parameters.AddWithValue("@fname", CType(add_emp_txt_fname.Text, String))
                myCommand.Parameters.AddWithValue("@lname", CType(add_emp_txt_lname.Text, String))
                myCommand.Parameters.AddWithValue("@phone", CType(add_emp_txt_phone.Text, String))
                myCommand.Parameters.AddWithValue("@email", CType(add_emp_txt_email.Text, String))




                ' excute SQL expression
                myCommand.ExecuteNonQuery()

                myCommand.Dispose()


                myConnection.Close()

                'clears the form

                add_emp_txt_fname.Clear()
                add_emp_txt_lname.Clear()
                add_emp_txt_phone.Clear()
                add_emp_txt_email.Clear()





                MessageBox.Show("Employee Saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                add_emp_txt_fname.Focus()
            Else

                MessageBox.Show("Employee Not Saved. Please Enter Required Fields", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)

                add_emp_txt_fname.Focus()
            End If

        Catch xe As ApplicationException
            MessageBox.Show("Employee " & add_emp_txt_fname.Text & " " & add_emp_txt_lname.Text & " found in the database." & vbNewLine & "Please correct name.", "Employee Found", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try




    End Sub
End Class