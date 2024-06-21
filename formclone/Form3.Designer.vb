<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.useremail = New System.Windows.Forms.TextBox()
        Me.userphno = New System.Windows.Forms.TextBox()
        Me.usergithub = New System.Windows.Forms.TextBox()
        Me.counter = New System.Windows.Forms.TextBox()
        Me.toggle = New System.Windows.Forms.Button()
        Me.submit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(52, 92)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(334, 20)
        Me.uname.TabIndex = 0
        '
        'useremail
        '
        Me.useremail.Location = New System.Drawing.Point(52, 142)
        Me.useremail.Name = "useremail"
        Me.useremail.Size = New System.Drawing.Size(334, 20)
        Me.useremail.TabIndex = 1
        '
        'userphno
        '
        Me.userphno.Location = New System.Drawing.Point(52, 192)
        Me.userphno.Name = "userphno"
        Me.userphno.Size = New System.Drawing.Size(334, 20)
        Me.userphno.TabIndex = 2
        '
        'usergithub
        '
        Me.usergithub.Location = New System.Drawing.Point(52, 242)
        Me.usergithub.Name = "usergithub"
        Me.usergithub.Size = New System.Drawing.Size(334, 20)
        Me.usergithub.TabIndex = 3
        '
        'counter
        '
        Me.counter.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.counter.Cursor = System.Windows.Forms.Cursors.No
        Me.counter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.counter.Location = New System.Drawing.Point(273, 287)
        Me.counter.Name = "counter"
        Me.counter.Size = New System.Drawing.Size(113, 22)
        Me.counter.TabIndex = 4
        '
        'toggle
        '
        Me.toggle.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.toggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.toggle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toggle.Location = New System.Drawing.Point(52, 280)
        Me.toggle.Name = "toggle"
        Me.toggle.Size = New System.Drawing.Size(212, 37)
        Me.toggle.TabIndex = 5
        Me.toggle.Text = "TOGGLE STOPWATCH (CTRL+T)"
        Me.toggle.UseVisualStyleBackColor = False
        '
        'submit
        '
        Me.submit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.Location = New System.Drawing.Point(53, 341)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(333, 41)
        Me.submit.TabIndex = 6
        Me.submit.Text = "Submit (CTRL + S)"
        Me.submit.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Ayush Barai, Slidely Task 2 - Create Submission"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Github Link For Task 2 -"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Phone No. -"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Email -"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Name -"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 452)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.toggle)
        Me.Controls.Add(Me.counter)
        Me.Controls.Add(Me.usergithub)
        Me.Controls.Add(Me.userphno)
        Me.Controls.Add(Me.useremail)
        Me.Controls.Add(Me.uname)
        Me.Name = "Form3"
        Me.Text = "Create New Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uname As TextBox
    Friend WithEvents useremail As TextBox
    Friend WithEvents userphno As TextBox
    Friend WithEvents usergithub As TextBox
    Friend WithEvents counter As TextBox
    Friend WithEvents toggle As Button
    Friend WithEvents submit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class