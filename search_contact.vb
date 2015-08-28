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



        ' Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ruben\Documents\GitHub\Team_CRM\db\crm_db.accdb

        Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" & Environment.CurrentDirectory & "\crm_db.accdb"



        Dim MyConnection As New OleDbCommand("INSERT INTO  (patient")



    End Sub




End Class