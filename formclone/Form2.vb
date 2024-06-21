Imports System.Text
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form2
    Private currentIndex As Integer = 0
    Private totalSubmissions As Integer

    Private Async Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalSubmissions = Await GetTotalSubmissions()
        DisplaySubmission(currentIndex)
    End Sub

    Private Async Function GetTotalSubmissions() As Task(Of Integer)
        Using client As New HttpClient()
            Dim response = Await client.GetStringAsync("http://localhost:3000/count")
            Return Integer.Parse(response)
        End Using
    End Function

    Private Async Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < totalSubmissions Then
            Using client As New HttpClient()
                Dim response = Await client.GetStringAsync($"http://localhost:3000/read?index={index}")
                Dim submission = JsonConvert.DeserializeObject(Of Submission)(response)
                uname.Text = submission.Name
                useremail.Text = submission.Email
                userphno.Text = submission.Phone
                usergithub.Text = submission.GithubLink
                TextBox5.Text = submission.StopwatchTime
            End Using
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles previous.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub BtnViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnEdit.KeyDown, btndelete.KeyDown, previous.KeyDown, nextform.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.P Then
            BtnPrevious_Click(Me, EventArgs.Empty)
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            BtnNext_Click(Me, EventArgs.Empty)
        End If
        If e.Control AndAlso e.KeyCode = Keys.E Then
            BtnEdit_Click(Me, EventArgs.Empty)
        End If
        If e.Control AndAlso e.KeyCode = Keys.D Then
            BtnDelete_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles nextform.Click
        If currentIndex < totalSubmissions - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim editSubmissionForm As New Form4(currentIndex)
        editSubmissionForm.Show()
    End Sub

    Private Async Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using client As New HttpClient()
                Dim response = Await client.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}")
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission deleted successfully.")
                    totalSubmissions -= 1
                    If currentIndex >= totalSubmissions Then
                        currentIndex = totalSubmissions - 1
                    End If
                    If totalSubmissions > 0 Then
                        DisplaySubmission(currentIndex)
                    Else
                        uname.Text = ""
                        useremail.Text = ""
                        userphno.Text = ""
                        usergithub.Text = ""
                        TextBox5.Text = ""
                    End If
                Else
                    MessageBox.Show("Error deleting submission.")
                End If
            End Using
        End If
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class
