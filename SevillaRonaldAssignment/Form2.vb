Imports MySql.Data.MySqlClient

Public Class RegisterForm

    Dim connString As String = "server=localhost;user=root;password=;database=login;"

    Private Sub BackToLogin_Click(sender As Object, e As EventArgs) Handles BackToLogin.Click

        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click

        Dim username As String = txtbxUsername.Text
        Dim name As String = txtbxName.Text
        Dim age As Integer
        Dim password As String = txtBxPassword.Text


        If Not Integer.TryParse(txtBxAge.Text, age) Then
            MessageBox.Show("Please enter a valid number for age.")
            Exit Sub
        End If

        If username = "" Or name = "" Or password = "" Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO users (username, name, age, password) VALUES (@username, @name, @age, @password)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@age", age)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Account created successfully!")

            Catch ex As MySqlException
                MessageBox.Show("Error while creating account: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
