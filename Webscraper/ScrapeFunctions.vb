Imports System.IO
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
    Function AddAuthHeader(Request As HttpWebRequest, Username As String, Password As String) As HttpWebRequest
        ' Concatenate the username and password with a ":" and convert to Bytes
        Dim AuthInfo As String = Username + ":" + Password
        Dim AuthBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(AuthInfo)
        ' Convert the Bytes to a Base64 string
        AuthInfo = Convert.ToBase64String(AuthBytes)
        ' Add the string to the Authorization header of the request
        Request.Headers("Authorization") = "Basic " + AuthInfo
        ' Return the Authenticated request instance
        Return Request
    End Function
    Function InsatiateUser(Username As String, Password As String) As String
        ' Create a request instance with the main loreto URL
        Request = HttpWebRequest.Create(LoretoURLs("main"))
        ' Add the user authentication using Base64
        Request = AddAuthHeader(Request, Username, Password)
        ' Return the response source text
        Return ReadResponse(Request.GetResponse())
    End Function
    Function CheckCredentials(Username As String, Password As String) As Boolean
        Try
            ' Try to get the Response with those credentials
            InsatiateUser(Username, Password)
            Return True
        Catch ex As System.Net.WebException When ex.Message.Contains("401")
            ' Only catch the exception if it is a 401
            Return False
        End Try
    End Function
    Function RegexMatch(Pattern As String, Input As String) As String
        ' Declare Regex pattern while ignoring character case
        Dim R As Regex = New Regex(Pattern, RegexOptions.IgnoreCase)
        ' Declare Match object and return Group 1
        Dim M As Match = R.Match(Input)
        Return M.Groups(1).Value
    End Function
    Function ParseImage(SourceText As String) As Image
        ' Declare Regex pattern and make matches
        Dim Pattern As String = """studentPhotoShielded"" src=""data: image/jpeg;base64,(.*)"">"
        ' Get the Base64 portion of the HTML tag
        Dim Avatar64 = RegexMatch(Pattern, SourceText)
        ' Convert the Base64 string into a MemoryStream
        Dim Bytes() As Byte = Convert.FromBase64String(Avatar64)
        Dim Stream As New System.IO.MemoryStream(Bytes)
        ' Return an image instance from the Base64 MemoryStream
        Return Image.FromStream(Stream)
    End Function
End Module

Public Class User
    ' Pairs of friendly names to source HTML
    Public sources As New Dictionary(Of String, String) From {
        {"main", Nothing}
    }
    ' User Avatar Image
    Public Avatar As Image
    ' Full Name of User
    Public Name(2) As String
    Dim Authentication(2) As String
    Dim ID As Integer
    Sub New(Username As String, Password As String)
        ' Declare user attributes
        Me.Authentication = {Username, Password}
        Dim Soup As String = InsatiateUser(Username, Password)
        Me.sources("main") = Soup
        Me.Avatar = ParseImage(Soup)
        Me.Name = RegexMatch("fullName: ""(.*)""", Soup).Split(" ")
        Me.ID = CInt(RegexMatch("thisUserId = ""(.*)""", Soup))
    End Sub
End Class
