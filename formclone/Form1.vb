Public Class Form1
    Private Sub BtnViewSubmissions_Click(sender As Object, e As EventArgs) Handles BtnViewSubmissions.Click
        Dim viewSubmissionsForm As New Form2()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub BtnCreateSubmission_Click(sender As Object, e As EventArgs) Handles BtnCreateSubmission.Click
        Dim createSubmissionForm As New Form3()
        createSubmissionForm.Show()
    End Sub

    Private Sub BtnViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnViewSubmissions.KeyDown, BtnCreateSubmission.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            BtnViewSubmissions_Click(Me, EventArgs.Empty)
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            BtnCreateSubmission_Click(Me, EventArgs.Empty)
        End If
    End Sub

End Class
