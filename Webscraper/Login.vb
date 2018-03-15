Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If CheckCredentials(UsernameBox.Text, PasswordBox.Text) Then
            Dim user = New User(UsernameBox.Text, PasswordBox.Text)
            GUI.LoadGUI(user)
            Me.Hide()
        Else
            MsgBox("Those credentials are not valid.")
        End If
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
