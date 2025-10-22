Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub LoginInButton_Click(sender As Object, e As EventArgs) Handles LoginInButton.Click
        Dim username As String = usernameTextBox.Text
        Dim password As String = passwordTextBox.Text

        ' ✅ Validate empty fields
        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.")
            Exit Sub
        End If

        Try
            ' ✅ Open connection using modDB
            openConn(db_name)

            cmd = New MySqlCommand("SELECT * FROM users WHERE username=@username", conn)
            cmd.Parameters.AddWithValue("@username", username)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' ✅ Decrypt stored password
                Dim storedPassword As String = Decrypt(reader("password").ToString())

                If storedPassword = password Then
                    MessageBox.Show("Login successful!")

                    ' (Optional) Save current logged-in user
                    CurrentLoggedUser.id = Convert.ToInt32(reader("id"))
                    CurrentLoggedUser.username = reader("username").ToString()
                    CurrentLoggedUser.name = reader("name").ToString()

                Else
                    MessageBox.Show("Invalid password.")
                End If
            Else
                MessageBox.Show("Username not found.")
            End If

            reader.Close()

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        End Try
    End Sub

    Private Sub Register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Register.LinkClicked
        Dim registerForm As New RegisterForm()
        registerForm.Show()
        Me.Hide()
    End Sub

End Class
