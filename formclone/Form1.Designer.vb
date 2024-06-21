<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnViewSubmissions = New System.Windows.Forms.Button()
        Me.BtnCreateSubmission = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnViewSubmissions
        '
        Me.BtnViewSubmissions.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnViewSubmissions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnViewSubmissions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewSubmissions.Location = New System.Drawing.Point(85, 69)
        Me.BtnViewSubmissions.Name = "BtnViewSubmissions"
        Me.BtnViewSubmissions.Size = New System.Drawing.Size(226, 50)
        Me.BtnViewSubmissions.TabIndex = 0
        Me.BtnViewSubmissions.Text = "View Submissions (CTRL + V)"
        Me.BtnViewSubmissions.UseVisualStyleBackColor = False
        '
        'BtnCreateSubmission
        '
        Me.BtnCreateSubmission.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnCreateSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCreateSubmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateSubmission.Location = New System.Drawing.Point(85, 150)
        Me.BtnCreateSubmission.Name = "BtnCreateSubmission"
        Me.BtnCreateSubmission.Size = New System.Drawing.Size(226, 50)
        Me.BtnCreateSubmission.TabIndex = 1
        Me.BtnCreateSubmission.Text = "Create New Submission (CTRL + N)"
        Me.BtnCreateSubmission.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ayush Barai, Slidely Task 2 - Slidely Form App"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(410, 420)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnViewSubmissions)
        Me.Controls.Add(Me.BtnCreateSubmission)
        Me.Name = "Form1"
        Me.Text = "Google Forms Clone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnViewSubmissions As Button
    Friend WithEvents BtnCreateSubmission As Button
    Friend WithEvents Label1 As Label
End Class