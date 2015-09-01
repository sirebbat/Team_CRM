Imports System.Text.RegularExpressions

Public Class add_employee

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
            add_emp_lbl_fname.ForeColor = ColorTranslator.FromHtml("#e74c3c")  ' if empty then first name label to red

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

        If (add_emp_txt_phone.MaskCompleted) Then
            add_emp_lbl_phone.ForeColor = ColorTranslator.FromHtml("#e74c3c")

        Else
            'If not in correct format changes email label to White
            add_emp_lbl_phone.ForeColor = Color.White

        End If

    End Sub
End Class