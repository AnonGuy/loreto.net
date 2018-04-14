Imports System.Text.RegularExpressions
Module ParseTimetable
    ' Dictionary of Timetable Patterns
    Dim ShortPatterns As New Dictionary(Of String, MatchCollection) From {
        {"""pull-left""><strong>(.*)</strong></div>", Nothing}, ' Time
        {"<div>(.*) </div>", Nothing},                          ' Lesson
        {"<div class=""pull-right"">(.*)</div>", Nothing}       ' Room
    }
    Dim FullPatterns As New Dictionary(Of String, MatchCollection) From {
        {"periodTimes pull-left"">(.*)<", Nothing},                                  ' Time
        {"periodClassStaff""> (.*) <", Nothing},                                     ' Staff
        {"""periodClassRoom pull-right"">" & vbCrLf & "		(.*)        <", Nothing} ' Room
    }
    Sub GetMatches(UserObject As User)
        ' Loop through Field Patterns
        Dim SinglePatterns As New List(Of String)
        ' Make a Copy of the Dictionary keys
        For Each Pattern In ShortPatterns.Keys
            SinglePatterns.Add(Pattern)
        Next
        For Each Pattern In SinglePatterns
            ' Create Regex and assign value to the Matches
            Dim R As New Regex(Pattern)
            ShortPatterns(Pattern) = R.Matches(UserObject.sources("main"))
        Next
    End Sub
    Function GetShortTimetable(UserObject As User) As String()()
        Dim Timetable As New List(Of String())
        ' Set the Dictionary Pattern Collections
        GetMatches(UserObject)
        ' Number of Lessons
        Dim LessonCount As Integer = ShortPatterns.Values(0).Count
        ' Go through the Lesson Matches and add to Timetable
        For Row As Integer = 0 To LessonCount - 1
            ' Time, Room, Lesson Match Values for each Lesson
            Dim LessonName() As String = ShortPatterns(
                ShortPatterns.Keys(1))(Row).Groups(1).Value.Replace(
                   "GCE A Level ", ""
            ).Split("-")
            ' Rows in Datagrid: { Time, Lesson, Room }
            Timetable.Add(
                {
                ShortPatterns(ShortPatterns.Keys(0))(Row).Groups(1).Value,
                LessonName(LessonName.Length - 2).Trim(),
                ShortPatterns(ShortPatterns.Keys(2))(Row).Groups(1).Value
                }
            )
        Next
        Return Timetable.ToArray
    End Function
    Function GetFullTimetable(UserObject As User) As String
        Dim Timetable As String
        Timetable = "a"
        Return Timetable
    End Function
End Module