﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        SignUpButton = New Button()
        Label5 = New Label()
        txtbxName = New TextBox()
        Label4 = New Label()
        txtBxAge = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtBxPassword = New TextBox()
        txtbxUsername = New TextBox()
        BackToLogin = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, -5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(755, 438)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(SignUpButton)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtbxName)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtBxAge)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtBxPassword)
        Panel1.Controls.Add(txtbxUsername)
        Panel1.Location = New Point(242, 46)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(255, 310)
        Panel1.TabIndex = 1
        ' 
        ' SignUpButton
        ' 
        SignUpButton.BackColor = Color.SlateBlue
        SignUpButton.Location = New Point(89, 270)
        SignUpButton.Name = "SignUpButton"
        SignUpButton.Size = New Size(75, 23)
        SignUpButton.TabIndex = 9
        SignUpButton.Text = "Sign Up"
        SignUpButton.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.White
        Label5.Location = New Point(25, 112)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 8
        Label5.Text = "Name:"
        ' 
        ' txtbxName
        ' 
        txtbxName.Location = New Point(26, 130)
        txtbxName.Name = "txtbxName"
        txtbxName.Size = New Size(204, 23)
        txtbxName.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
        Label4.Location = New Point(25, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 6
        Label4.Text = "Age:"
        ' 
        ' txtBxAge
        ' 
        txtBxAge.Location = New Point(26, 174)
        txtBxAge.Name = "txtBxAge"
        txtBxAge.Size = New Size(204, 23)
        txtBxAge.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(91, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 19)
        Label3.TabIndex = 4
        Label3.Text = "Register"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.White
        Label2.Location = New Point(25, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 3
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label1.Location = New Point(22, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 2
        Label1.Text = "Username:"
        ' 
        ' txtBxPassword
        ' 
        txtBxPassword.Location = New Point(26, 228)
        txtBxPassword.Name = "txtBxPassword"
        txtBxPassword.Size = New Size(204, 23)
        txtBxPassword.TabIndex = 1
        ' 
        ' txtbxUsername
        ' 
        txtbxUsername.Location = New Point(26, 76)
        txtbxUsername.Name = "txtbxUsername"
        txtbxUsername.Size = New Size(204, 23)
        txtbxUsername.TabIndex = 0
        ' 
        ' BackToLogin
        ' 
        BackToLogin.BackColor = Color.MediumPurple
        BackToLogin.Location = New Point(12, 12)
        BackToLogin.Name = "BackToLogin"
        BackToLogin.Size = New Size(99, 23)
        BackToLogin.TabIndex = 2
        BackToLogin.Text = "Back to login"
        BackToLogin.UseVisualStyleBackColor = False
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(753, 423)
        Controls.Add(BackToLogin)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BackToLogin As Button
    Friend WithEvents SignUpButton As Button
    Friend WithEvents txtbxName As TextBox
    Friend WithEvents txtBxAge As TextBox
    Friend WithEvents txtBxPassword As TextBox
    Friend WithEvents txtbxUsername As TextBox
End Class
