Public Class GUI
    Sub LoadGUI(UserObject As User)
        AvatarBox.Image = UserObject.Avatar
        Me.Show()
    End Sub
End Class