Imports System.Net
Public Class Login
    Sub PostData()
        If CheckCredentials(UsernameBox.Text, PasswordBox.Text) Then
            Dim user = New User(UsernameBox.Text, PasswordBox.Text)
            GUI.LoadGUI(user)
            Me.Hide()
        Else
            MsgBox("Those credentials are not valid.")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        PostData()
    End Sub
    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
    Private Sub PasswordBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PostData()
        End If
    End Sub
End Class
