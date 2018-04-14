Public Class GUI
    Dim RealImage As Image
    Dim GlobalUser As User
    Sub LoadGUI(UserObject As User)
        GlobalUser = UserObject
        DummyBox.Image = My.Resources.DummyImage
        AvatarBox.Image = UserObject.Avatar
        StudentName.Text = Join(UserObject.Name, " ")
        For Each Row In GetShortTimetable(UserObject)
            TimetableBox.Rows.Add(Row)
        Next
        Me.Show()
    End Sub
    Private Sub DummyBox_Click(sender As Object, e As EventArgs) Handles DummyBox.Click
        DummyBox.Visible = False
        AvatarBox.Visible = True
    End Sub
    Private Sub AvatarBox_Click(sender As Object, e As EventArgs) Handles AvatarBox.Click
        AvatarBox.Visible = False
        DummyBox.Visible = True
    End Sub
    Private Sub GUI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
    Private Sub TimetableButton_Click(sender As Object, e As EventArgs) Handles TimetableButton.Click
        TimetableGUI.LoadGUI(GlobalUser)
    End Sub
End Class