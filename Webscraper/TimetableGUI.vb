Public Class TimetableGUI
    Sub LoadGUI(UserObject As User)
        Me.Show()
        Dim Panels As List(Of Object) = GetPanels()
        ' Go through ordered Panels and fill each Panel
        For Each Panel In Panels
            FillPanel(
                Panel, {"Physics (Present)", "B328", "09:00 - 10:15"}
            )
        Next
    End Sub
    Sub FillPanel(Panel As Panel, Data As String())
        ' Fill a Timetable Panel with Data from an Array
        For Index As Integer = 0 To 2
            Panel.Controls(Index).Text = Data(Index)
        Next
    End Sub
    Function GetPanels() As List(Of Object)
        ' Array of Objects, allows different Form Items to be added
        Dim Items(145) As Object
        ' Copy all Timetable elements to the Array
        TimetableLayout.Controls.CopyTo(Items, 0)
        ' Create a List of Panels, by filtering the Items by Class Type
        Dim Panels = Items.Where(Function(Item) TypeOf (Item) Is Panel)
        ' Order the Panels by the number appended to it, e.g. "P0" before "P1"
        Panels = Panels.OrderBy(
            Function(Panel) CInt(Panel.Name.Substring(1))
        ).ToList()
        ' Return the ordered Panels
        Return Panels
    End Function
End Class