'search contact class
Imports System.Data.OleDb

Public Class search_contact


    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" & Environment.CurrentDirectory & "\crm_db.accdb"

    'search contact - cancel button
    Private Sub sc_btn_cancel_Click(sender As Object, e As EventArgs) Handles sc_btn_cancel.Click
        Me.Close()
        Dashboard.BringToFront()

    End Sub

    'search contact - search button
    Public Sub sc_btn_search_Click(sender As Object, e As EventArgs) Handles sc_btn_search.Click

        'variable to check if records found
        Dim recordCount As Integer

        ' sets ok button not to visible
        sc_btn_ok.Visible = False

        'sets found and not found to not visible
        sc_lbl_notfound.Enabled = False
        sc_lbl_notfound.Visible = False

        sc_lbl_found.Enabled = False
        sc_lbl_found.Visible = False

        'Variables for the Access database
        Dim myConnection As New OleDbConnection(myConnString)
        Try

            'opens the connection
            myConnection.Open()

            'Search by account number
            If account_number.Text IsNot String.Empty Then
                'query
                Dim myCommand As New OleDbCommand("SELECT * FROM crm_contact WHERE account=" & account_number.Text, myConnection)
                Dim myReader As OleDbDataReader = myCommand.ExecuteReader

                'reads the query
                While myReader.Read
                    sc_lbl_found.Enabled = True
                    sc_lbl_found.Visible = True
                    recordCount = recordCount + 1

                    Dim sc_listviewitem As New ListViewItem
                    Dashboard.ci_txt_account.Text = myReader.GetInt32(0)
                    Dashboard.ci_txt_fname.Text = myReader.GetString(1)
                    Dashboard.ci_txt_lname.Text = myReader.GetString(2)
                    Dashboard.ci_txt_company.Text = myReader.GetString(3)
                    Dashboard.ci_txt_officen.Text = myReader.GetString(4)
                    Dashboard.ci_txt_cellp.Text = myReader.GetString(5)
                    Dashboard.ci_txt_url.Text = myReader.GetString(6)
                    Dashboard.ci_created_date.Text = myReader.GetDateTime(7)
                    Dashboard.adr_txt_streetad.Text = myReader.GetString(8)
                    Dashboard.adr_txt_streetadd.Text = myReader.GetString(9)
                    Dashboard.adr_txt_city.Text = myReader.GetString(10)
                    Dashboard.adr_txt_state.Text = myReader.GetString(11)
                    Dashboard.adr_txt_zip.Text = myReader.GetString(12)
                    Dashboard.ci_txt_email.Text = myReader.GetString(13)
                End While
                sc_lbl_notfound.Enabled = True
                sc_lbl_notfound.Enabled = True

                'checks for the records
                If recordCount = 0 Then

                    sc_lbl_notfound.Enabled = True
                    sc_lbl_notfound.Visible = True
                Else
                    sc_lbl_found.Enabled = True
                    sc_lbl_found.Visible = True
                    sc_btn_ok.Visible = True





                End If
                account_number.ResetText()
            End If


            'search by first name
            If sc_txt_fname.Text IsNot String.Empty Then
                Dim myCommand As New OleDbCommand("SELECT * FROM crm_contact WHERE fname='" & sc_txt_fname.Text & "'", myConnection)
                Dim myReader As OleDbDataReader = myCommand.ExecuteReader

                'reads the query
                While myReader.Read
                    sc_lbl_found.Enabled = True
                    sc_lbl_found.Visible = True
                    recordCount = recordCount + 1

                End While
                sc_lbl_notfound.Enabled = True
                sc_lbl_notfound.Enabled = True

                'checks for the records
                If recordCount = 0 Then

                    sc_lbl_notfound.Enabled = True
                    sc_lbl_notfound.Visible = True
                Else
                    sc_lbl_found.Enabled = True
                    sc_lbl_found.Visible = True
                    sc_btn_ok.Visible = True

                End If
                sc_txt_fname.ResetText()
            End If

            'search by last name
            If sc_txt_lname.Text IsNot String.Empty Then
                Dim myCommand As New OleDbCommand("SELECT * FROM crm_contact WHERE lname= '" & sc_txt_lname.Text & "'", myConnection)
                Dim myReader As OleDbDataReader = myCommand.ExecuteReader

                'reads the query
                While myReader.Read
                    sc_lbl_found.Enabled = True
                    sc_lbl_found.Visible = True
                    recordCount = recordCount + 1

                End While
                sc_lbl_notfound.Enabled = True
                sc_lbl_notfound.Enabled = True

                'checks for the records
                If recordCount = 0 Then

                    sc_lbl_notfound.Enabled = True
                    sc_lbl_notfound.Visible = True
                Else
                    sc_lbl_found.Enabled = True
                    sc_lbl_found.Visible = True
                    sc_btn_ok.Visible = True

                End If
                sc_txt_lname.ResetText()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try







    End Sub

    Public Sub sc_btn_ok_Click(sender As Object, e As EventArgs) Handles sc_btn_ok.Click
        Me.Close()
        Dashboard.ci_btn_update.Enabled = True
        Dashboard.ci_btn_update.Visible = True





    End Sub
End Class