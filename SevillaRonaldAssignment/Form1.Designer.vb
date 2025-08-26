<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        passwordTextBox = New TextBox()
        usernameTextBox = New TextBox()
        PasswordLabel = New Label()
        Usernamelabel = New Label()
        SignInLabel = New Label()
        LoginInButton = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-3, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(745, 427)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(passwordTextBox)
        Panel1.Controls.Add(usernameTextBox)
        Panel1.Controls.Add(PasswordLabel)
        Panel1.Controls.Add(Usernamelabel)
        Panel1.Controls.Add(SignInLabel)
        Panel1.Controls.Add(LoginInButton)
        Panel1.ForeColor = SystemColors.Control
        Panel1.Location = New Point(462, 58)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(240, 309)
        Panel1.TabIndex = 2
        ' 
        ' passwordTextBox
        ' 
        passwordTextBox.Location = New Point(15, 189)
        passwordTextBox.Name = "passwordTextBox"
        passwordTextBox.PasswordChar = "*"c
        passwordTextBox.Size = New Size(208, 23)
        passwordTextBox.TabIndex = 5
        ' 
        ' usernameTextBox
        ' 
        usernameTextBox.Location = New Point(15, 106)
        usernameTextBox.Name = "usernameTextBox"
        usernameTextBox.Size = New Size(208, 23)
        usernameTextBox.TabIndex = 4
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordLabel.Location = New Point(15, 159)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(73, 17)
        PasswordLabel.TabIndex = 3
        PasswordLabel.Text = "Password:"
        ' 
        ' Usernamelabel
        ' 
        Usernamelabel.AutoSize = True
        Usernamelabel.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Usernamelabel.Location = New Point(13, 77)
        Usernamelabel.Name = "Usernamelabel"
        Usernamelabel.Size = New Size(75, 17)
        Usernamelabel.TabIndex = 2
        Usernamelabel.Text = "Username:"
        ' 
        ' SignInLabel
        ' 
        SignInLabel.AutoSize = True
        SignInLabel.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignInLabel.Location = New Point(76, 16)
        SignInLabel.Name = "SignInLabel"
        SignInLabel.Size = New Size(100, 32)
        SignInLabel.TabIndex = 1
        SignInLabel.Text = "Sign In"
        ' 
        ' LoginInButton
        ' 
        LoginInButton.BackColor = Color.RoyalBlue
        LoginInButton.ForeColor = Color.Transparent
        LoginInButton.Location = New Point(76, 240)
        LoginInButton.Name = "LoginInButton"
        LoginInButton.Size = New Size(82, 40)
        LoginInButton.TabIndex = 0
        LoginInButton.Text = "Login In"
        LoginInButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(741, 424)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SignInLabel As Label
    Friend WithEvents LoginInButton As Button
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Usernamelabel As Label
    Friend WithEvents passwordTextBox As TextBox

End Class
