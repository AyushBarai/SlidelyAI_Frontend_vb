<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.previous = New System.Windows.Forms.Button()
        Me.nextform = New System.Windows.Forms.Button()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.useremail = New System.Windows.Forms.TextBox()
        Me.userphno = New System.Windows.Forms.TextBox()
        Me.usergithub = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'previous
        '
        Me.previous.BackColor = System.Drawing.Color.Moccasin
        Me.previous.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.previous.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previous.Location = New System.Drawing.Point(44, 342)
        Me.previous.Name = "previous"
        Me.previous.Size = New System.Drawing.Size(148, 30)
        Me.previous.TabIndex = 0
        Me.previous.Text = "Previous (CTRL+P)"
        Me.previous.UseVisualStyleBackColor = False
        '
        'nextform
        '
        Me.nextform.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.nextform.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.nextform.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextform.Location = New System.Drawing.Point(217, 342)
        Me.nextform.Name = "nextform"
        Me.nextform.Size = New System.Drawing.Size(142, 30)
        Me.nextform.TabIndex = 1
        Me.nextform.Text = "Next (CTRL + N)"
        Me.nextform.UseVisualStyleBackColor = False
        '
        'uname
        '
        Me.uname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uname.Location = New System.Drawing.Point(44, 92)
        Me.uname.Name = "uname"
        Me.uname.ReadOnly = True
        Me.uname.Size = New System.Drawing.Size(315, 22)
        Me.uname.TabIndex = 2
        '
        'useremail
        '
        Me.useremail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.useremail.Location = New System.Drawing.Point(44, 142)
        Me.useremail.Name = "useremail"
        Me.useremail.ReadOnly = True
        Me.useremail.Size = New System.Drawing.Size(315, 22)
        Me.useremail.TabIndex = 3
        '
        'userphno
        '
        Me.userphno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userphno.Location = New System.Drawing.Point(44, 192)
        Me.userphno.Name = "userphno"
        Me.userphno.ReadOnly = True
        Me.userphno.Size = New System.Drawing.Size(315, 22)
        Me.userphno.TabIndex = 4
        '
        'usergithub
        '
        Me.usergithub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usergithub.Location = New System.Drawing.Point(44, 242)
        Me.usergithub.Name = "usergithub"
        Me.usergithub.ReadOnly = True
        Me.usergithub.Size = New System.Drawing.Size(315, 22)
        Me.usergithub.TabIndex = 5
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(151, 285)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(208, 22)
        Me.TextBox5.TabIndex = 6
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(44, 389)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(148, 30)
        Me.BtnEdit.TabIndex = 7
        Me.BtnEdit.Text = "Edit (CTRL+ E)"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ayush Barai, Slidely Task 2 - View Submissions"
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Red
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(217, 389)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(142, 30)
        Me.btndelete.TabIndex = 9
        Me.btndelete.Text = "Delete (CTRL + D)"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name -"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Email -"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Phone No. -"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Github Link For Task 2 -"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Stopwatch -"
        '
        'Form2
        '
        Me.ClientSize = New System.Drawing.Size(430, 449)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.usergithub)
        Me.Controls.Add(Me.userphno)
        Me.Controls.Add(Me.useremail)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.nextform)
        Me.Controls.Add(Me.previous)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form2"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents previous As Button
    Friend WithEvents nextform As Button
    Friend WithEvents uname As TextBox
    Friend WithEvents useremail As TextBox
    Friend WithEvents userphno As TextBox
    Friend WithEvents usergithub As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btndelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class