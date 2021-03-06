﻿'search contact class
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

                    'Adds items to the dashboard
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
                    Dashboard.adr_txt_state.SelectedText = myReader.GetString(11)
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

            End If




            'gets activities
            Dim myActivity As New OleDbCommand("SELECT * FROM crm_activities WHERE account_number=" & account_number.Text, myConnection)
            Dim ActivityReader As OleDbDataReader = myActivity.ExecuteReader





            'reads the query
            While ActivityReader.Read


                'Adds items to the combobox
                Dim act_listviewitem As New ListViewItem
                act_listviewitem.Text = ActivityReader.GetInt32(0)
                act_listviewitem.SubItems.Add(ActivityReader.GetString(2))
                act_listviewitem.SubItems.Add(ActivityReader.GetString(3))
                act_listviewitem.SubItems.Add(ActivityReader.GetDateTime(4))
                act_listviewitem.SubItems.Add(ActivityReader.GetString(5))

                Dashboard.act_lv.Items.Add(act_listviewitem)

            End While
            myConnection.Close()
            account_number.ResetText()













            'closes the connection
            myConnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try







    End Sub

    Public Sub sc_btn_ok_Click(sender As Object, e As EventArgs) Handles sc_btn_ok.Click
        Me.Close()

        'makes contact info update button in dashboard visible
        Dashboard.ci_btn_update.Enabled = True
        Dashboard.ci_btn_update.Visible = True

        'makes activities add button in dashboard visible
        Dashboard.act_btn_create.Enabled = True
        Dashboard.act_btn_create.Visible = True


        Dashboard.act_refresh.Enabled = True
        Dashboard.act_refresh.Visible = True

    End Sub
End Class