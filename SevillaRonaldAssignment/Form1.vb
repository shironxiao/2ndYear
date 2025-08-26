Public Class Form1


    Private Sub usernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles usernameTextBox.TextChanged

    End Sub

    Private Sub passwordTextBox_TextChanged(sender As Object, e As EventArgs) Handles passwordTextBox.TextChanged

    End Sub

    Private Sub LoginInButton_Click(sender As Object, e As EventArgs) Handles LoginInButton.Click
        If usernameTextBox.Text = "admin" And passwordTextBox.Text = "1234" Then
            MessageBox.Show("Login Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
