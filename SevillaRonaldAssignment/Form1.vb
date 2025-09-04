Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connString As String = "server=localhost;user=root;password=;database=login;"

    Private Sub LoginInButton_Click(sender As Object, e As EventArgs) Handles LoginInButton.Click
        Dim username As String = usernameTextBox.Text
        Dim password As String = passwordTextBox.Text

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.")
            Exit Sub
        End If

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM users WHERE username=@username AND password=@password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        MessageBox.Show("Login successful!")
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                    reader.Close()
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Register.LinkClicked
        Dim registerForm As New RegisterForm()
        registerForm.Show()
        Me.Hide()
    End Sub
End Class
