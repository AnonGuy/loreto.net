Imports System.Text.RegularExpressions
Module ParseTimetable
    ' Dictionary of Timetable Patterns
    Dim Patterns As New Dictionary(Of String, MatchCollection) From {
        {"<div class=""pull-left""><strong>(.*)</strong></div>", Nothing},
        {"<div>(.*) </div>", Nothing},
        {"<div class=""pull-right"">(.*)</div>", Nothing}
    }
    Sub GetMatches(UserObject As User)
        ' Loop through Field Patterns
        Dim SinglePatterns As New List(Of String)
        ' Make a Copy of the Dictionary keys
        For Each Pattern In Patterns.Keys
            SinglePatterns.Add(Pattern)
        Next
        For Each Pattern In SinglePatterns
            ' Create Regex and assign value to the Matches
            Dim R As New Regex(Pattern)
            Patterns(Pattern) = R.Matches(UserObject.sources("main"))
        Next
    End Sub
    Function GetShortTimetable(UserObject As User) As String()()
        Dim Timetable As New List(Of String())
        ' Set the Dictionary Pattern Collections
        GetMatches(UserObject)
        ' Number of Lessons
        Dim LessonCount As Integer = Patterns.Values(0).Count
        ' Go through the Lesson Matches and add to Timetable
        For Row As Integer = 0 To LessonCount - 1
            ' Time, Room, Lesson Match Values for each Lesson
            Dim LessonName() As String = Patterns(
                Patterns.Keys(1))(Row).Groups(1).Value.Replace(
                   "GCE A Level ", ""
            ).Split("-")
            Timetable.Add(
                {
                Patterns(Patterns.Keys(0))(Row).Groups(1).Value,
                LessonName(LessonName.Length - 2).Trim(),
                Patterns(Patterns.Keys(2))(Row).Groups(1).Value
                }
            )
        Next
        Return Timetable.ToArray
    End Function
    Function GetFullTimetable(UserObject As User) As String()()
        Dim Timetable As New List(Of String())
        Return Nothing
    End Function
End Module