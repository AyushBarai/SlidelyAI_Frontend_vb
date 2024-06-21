Imports System.Text
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class Form3
    Private stopwatchRunning As Boolean = False
    Private stopwatch As New Stopwatch()

    Private Sub BtnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles toggle.Click
        If stopwatchRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        stopwatchRunning = Not stopwatchRunning
        UpdateStopwatchDisplay()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stopwatchRunning Then
            UpdateStopwatchDisplay()
        End If
    End Sub

    Private Sub UpdateStopwatchDisplay()
        counter.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim submission = New NewSubmission() With {
            .Name = uname.Text,
            .Email = useremail.Text,
            .Phone = userphno.Text,
            .GithubLink = usergithub.Text,
            .StopwatchTime = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        }
        Await SubmitForm(submission)
        MessageBox.Show("Submission successful")
        ClearForm()
    End Sub

    Private Async Function SubmitForm(submission As NewSubmission) As Task
        Try
            Using client As New HttpClient()
                Dim jsonContent As String = JsonConvert.SerializeObject(submission)
                Console.WriteLine($"Submitting JSON: {jsonContent}") ' Log the JSON being sent

                Dim httpContent As New StringContent(jsonContent, Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", httpContent)

                If response.IsSuccessStatusCode Then
                    Console.WriteLine("Submission successful")
                Else
                    Console.WriteLine($"Submission failed with status code: {response.StatusCode}")
                    Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                    Console.WriteLine($"Error Response: {responseContent}") ' Log the error response content
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error submitting form: {ex.Message}")
            MessageBox.Show($"Error submitting form: {ex.Message}")
            Throw ' Rethrow the exception if needed for further handling
        End Try
    End Function

    Private Sub ClearForm()
        uname.Clear()
        useremail.Clear()
        userphno.Clear()
        usergithub.Clear()
        stopwatch.Reset()
        UpdateStopwatchDisplay()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
        Me.KeyPreview = True
        submit.Focus()
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, toggle.KeyDown, submit.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            BtnToggleStopwatch_Click(submit, EventArgs.Empty)
        End If
        If e.Control AndAlso e.KeyCode = Keys.S Then
            BtnSubmit_Click(submit, EventArgs.Empty)
        End If
    End Sub

End Class

Public Class NewSubmission
    <JsonProperty("name")>
    Public Property Name As String
    <JsonProperty("email")>
    Public Property Email As String
    <JsonProperty("phone")>
    Public Property Phone As String
    <JsonProperty("githubLink")>
    Public Property GithubLink As String
    <JsonProperty("stopwatchTime")>
    Public Property StopwatchTime As String
End Class
