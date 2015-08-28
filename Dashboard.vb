'Dashboard
Imports System.Globalization

Public Class Dashboard


    'Dashboard - Create Button
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Me.SendToBack()
        create_contact.Visible = True
        create_contact.BringToFront()


    End Sub

    'Dashboard - Search Button
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        search_contact.Visible = True
        search_contact.BringToFront()

    End Sub

    'Add button - Employee tab
    Private Sub emp_btn_add_Click(sender As Object, e As EventArgs) Handles emp_btn_add.Click
        Me.SendToBack()
        add_employee.Visible = True
    End Sub


End Class
