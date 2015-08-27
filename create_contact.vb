Public Class create_contact
    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles btn_cancel.MouseClick
        Me.Close()
        Dashboard.BringToFront()


    End Sub

    Private Sub ci_btn_update_MouseClick(sender As Object, e As MouseEventArgs) Handles ci_btn_update.MouseClick
        MessageBox.Show("Contact Saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
End Class