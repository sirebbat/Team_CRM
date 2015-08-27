'search contact class
Public Class search_contact
    'search contact - cancel button
    Private Sub sc_btn_cancel_Click(sender As Object, e As EventArgs) Handles sc_btn_cancel.Click
        Me.Close()
        Dashboard.BringToFront()

    End Sub

    'search contact - search button
    Private Sub sc_btn_search_Click(sender As Object, e As EventArgs) Handles sc_btn_search.Click
        sc_lbl_found.Enabled = True
        sc_lbl_found.Visible = True




    End Sub




End Class