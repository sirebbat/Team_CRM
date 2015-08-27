Public Class add_employee

    'Add Employee - Cancel Button
    Private Sub adde_btn_cancel_Click(sender As Object, e As EventArgs) Handles adde_btn_cancel.Click
        Me.Close()
        Dashboard.BringToFront()
    End Sub
End Class