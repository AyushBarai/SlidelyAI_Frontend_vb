Imports System.Text
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form4
    Private currentIndex As Integer

    Public Sub New(index As Integer)
        InitializeComponent()
        currentIndex = index
    End Sub

    Private Sub BtnViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnUpdate.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            BtnSave_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Async Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission(currentIndex)
        BtnUpdate.Focus()
    End Sub


    Private Async Function LoadSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Dim response = Await client.GetStringAsync($"http://localhost:3000/read?index={index}")
            Dim submission = JsonConvert.DeserializeObject(Of Submission)(response)
            uname.Text = submission.Name
            useremail.Text = submission.Email
            userphno.Text = submission.Phone
            usergithub.Text = submission.GithubLink
            TextBox5.Text = submission.StopwatchTime
        End Using
    End Function

    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim updatedSubmission = New Submission() With {
            .Name = uname.Text,
            .Email = useremail.Text,
            .Phone = userphno.Text,
            .GithubLink = usergithub.Text,
            .StopwatchTime = TextBox5.Text
        }

        Dim submissionData = New With {
            .index = currentIndex,
            .submission = updatedSubmission
        }

        Using client As New HttpClient()
            Dim content = New StringContent(JsonConvert.SerializeObject(submissionData), Encoding.UTF8, "application/json")
            Dim response = Await client.PutAsync("http://localhost:3000/update", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission updated successfully.")
                Me.Close()
            Else
                MessageBox.Show("Error updating submission.")
            End If
        End Using
    End Sub

End Class
