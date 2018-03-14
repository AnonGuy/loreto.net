Public Class GUI
    Sub LoadGUI(UserObject As User)
        AvatarBox.Image = UserObject.Avatar
        Me.Show()
    End Sub

    Private Sub GUI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
End Class