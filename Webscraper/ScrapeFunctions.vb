﻿Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Module ScrapeFunctions
    ' URLs for various use-cases
    Dim LoretoURLs As New Dictionary(Of String, String) From {
        {"main", "https://my.loreto.ac.uk/"}
    }
    ' Temporary Response and Request objects
    Dim Response As WebResponse
    Dim Request As WebRequest
    Function ReadResponse(ResponseObject As WebResponse) As String
        Dim ResponseText As String
        ' Read a web response
        Using File As New StreamReader(ResponseObject.GetResponseStream())
            ResponseText = File.ReadToEnd()
            File.Close()
        End Using
        ' Return the source string
        Return ResponseText
    End Function
    Function InsatiateUser(Username As String, Password As String)
        ' Create a request instance with the main loreto URL
        Request = HttpWebRequest.Create(LoretoURLs("main"))
        ' Set user authentication and enable default authentication
        Request.Credentials = New NetworkCredential(Username, Password)
        Request.UseDefaultCredentials = True
        ' Return the response source text
        Return ReadResponse(Request.GetResponse())
    End Function
    Function ParseImage(SourceText As String) As Image
        ' Declare Regex pattern and make matches
        Dim Pattern As String = """studentPhotoShielded"" src=""data: image/jpeg;base64,(.*)"">"
        Dim R As Regex = New Regex(Pattern, RegexOptions.IgnoreCase)
        Dim M As Match = R.Match(SourceText)
        ' Get the Base64 portion of the HTML tag
        Dim Avatar64 = M.Groups(1).Value
        ' Convert the Base64 string into a MemoryStream
        Dim Bytes() As Byte = Convert.FromBase64String(Avatar64)
        Dim Stream As New System.IO.MemoryStream(Bytes)
        ' Return an image instance from the Base64 MemoryStream
        Return Image.FromStream(Stream)
    End Function
End Module

Public Class User
    ' Pairs of name to source text
    Public sources As New Dictionary(Of String, String) From {
        {"main", Nothing}
    }
    ' User Avatar Image
    Public Avatar As Image
    ' User Authentication
    Dim Authentication(2) As String
    Sub New(Username As String, Password As String)
        ' Declare user attributes
        Me.Authentication = {Username, Password}
        Me.sources("main") = InsatiateUser(Username, Password)
        Me.Avatar = ParseImage(Me.sources("main"))
    End Sub
End Class