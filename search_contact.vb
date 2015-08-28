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
    Private Sub sc_btn_search_Click(sender As Object, e As EventArgs) Handles sc_btn_search.Click

        'variable to check if records found
        Dim recordCount As Integer

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

            'query
            Dim myCommand As New OleDbCommand("SELECT account, fname, lname FROM crm_contact WHERE account=" & account_number.Text, myConnection)
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

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try







    End Sub




End Class