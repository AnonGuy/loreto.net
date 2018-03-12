Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim user = New User(UsernameBox.Text, PasswordBox.Text)
        GUI.LoadGUI(user)
        Me.Hide()
    End Sub
End Class
