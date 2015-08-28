'search contact class
Imports System.Data.OleDb

Public Class search_contact
    'search contact - cancel button
    Private Sub sc_btn_cancel_Click(sender As Object, e As EventArgs) Handles sc_btn_cancel.Click
        Me.Close()
        Dashboard.BringToFront()

    End Sub

    'search contact - search button
    Private Sub sc_btn_search_Click(sender As Object, e As EventArgs) Handles sc_btn_search.Click
        'sc_lbl_found.Enabled = True
        'sc_lbl_found.Visible = True


        'Variables for the Access database
        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="



        dataFile = "C:\Users\ruben\Documents\GitHub\Team_CRM\db\crm_db.accdb"

        connString = provider & dataFile

        myConnection.ConnectionString = connString

        ' starts the connection

        myConnection.Open()

        Dim str As String
        Dim dr As OleDbDataReader
        'creates SQL expression
        If account_number IsNot String.Empty Then
            str = "SELECT * FROM accunt WHERE (account = '" & account_number.Text & "')"

            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

            dr = cmd.ExecuteReader

        End If
        If dr.Read() = False Then

            sc_lbl_notfound.Enabled = True
            sc_lbl_notfound.Visible = True
            'While dr.Read()

            '    'DescriptionText.Text = dr("Description").ToString

            '    'CostText.Text = dr("Cost").ToString

            '    'PriceText.Text = dr("Price").ToString

            'End While

        End If

        myConnection.Close()



    End Sub




End Class