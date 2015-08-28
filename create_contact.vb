Imports System.Data.OleDb
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class create_contact
    Dim secs = "00"
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

            If ci_txt_fname.Text IsNot String.Empty And ci_txt_lname.Text IsNot String.Empty And ci_txt_email IsNot String.Empty Then
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


                'Saved message

                MessageBox.Show("Contact Saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                MessageBox.Show("Contact Not Saved. Please Enter Required Fields", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If



        Catch ex As Exception

            MsgBox(ex.Message)

        End Try











    End Sub

    Private Sub create_contact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As Date = Date.Today

        ci_created_date.Text = dt.ToString("MM/dd/yyyy", CultureInfo.CurrentCulture)
    End Sub



    'Validates email entered is in correct format and not empty 
    Private Sub ci_txt_email_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ci_txt_email.Validating
        Dim email As String = ci_txt_email.Text

        'If not in correct format changes email label to red
        If EmailAddressCheck(email) = False Then
            ci_lbl_email.ForeColor = ColorTranslator.FromHtml("#e74c3c")

        Else
            'If not in correct format changes email label to White
            ci_lbl_email.ForeColor = Color.White

        End If

        'Checks email  is not empty
        If ci_txt_email.Text Is String.Empty Then
            ci_lbl_email.ForeColor = ColorTranslator.FromHtml("#e74c3c")

        Else
            'If not in correct format changes email label to White
            ci_lbl_email.ForeColor = Color.White
        End If

    End Sub

    'Function to get correct email format
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

    'Validates required first name textbox is not empty
    Private Sub ci_txt_fname_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ci_txt_fname.Validating


        If ci_txt_fname.Text Is String.Empty Then
            ci_lbl_fname.ForeColor = ColorTranslator.FromHtml("#e74c3c")  ' if empty then first name label to red


        Else
            ci_lbl_fname.ForeColor = Color.White ' if empty then first name label to white

        End If

    End Sub


    'Validates required last name textbox is not empty
    Private Sub ci_txt_lname_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ci_txt_lname.Validating

        If ci_txt_lname.Text Is String.Empty Then
            ci_lbl_lname.ForeColor = ColorTranslator.FromHtml("#e74c3c")  ' if empty then last name label to red


        Else
            ci_lbl_lname.ForeColor = Color.White ' if empty then last name label to white

        End If

    End Sub

    'Validates required office number textbox is not empty
    Private Sub ci_txt_officen_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ci_txt_officen.Validating

        If ci_txt_officen.Text Is String.Empty Then
            ci_lbl_officen.ForeColor = ColorTranslator.FromHtml("#e74c3c")  ' if empty then office number label to red


        Else
            ci_lbl_officen.ForeColor = Color.White ' if empty then office number label to white

        End If
    End Sub


End Class