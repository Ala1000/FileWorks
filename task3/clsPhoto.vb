Imports System.IO

Public Class clsPhoto
    Public Property Title() As String
    Public Property Desc() As String
    Public Property Body() As String
    Public Property Photo() As String 'Path of the photo
    Public Property fileName

    Dim filewriter As StreamWriter
    Dim fileReader As StreamReader
    Dim newGuid As String
    Private output As FileStream
    Private input As FileStream

    Const PATH As String = "D:\vb\Task3 folders\Photos"

    Public Sub New()
        MyClass.New(String.Empty, String.Empty, String.Empty, String.Empty)
    End Sub

    Public Sub New(ByVal newTitle As String, ByVal newDesc As String, ByVal newBody As String, ByVal newPhoto As String)
        Title = newTitle
        Desc = newDesc
        Body = newBody
        Photo = newPhoto
    End Sub

    Public Sub New(ByVal newTitle As String, ByVal newDesc As String, ByVal newBody As String, ByVal newPhoto As String, ByVal myFile As String)
        Title = newTitle
        Desc = newDesc
        Body = newBody
        Photo = newPhoto
        fileName = myFile
    End Sub

    Public Sub New(ByVal file As String)
        fileName = file
    End Sub


    Public Sub saveDataToFile()
        Try
            If fileName IsNot Nothing Then
                editPhoto()
            Else
                newGuid = System.Guid.NewGuid().ToString()
                Dim newFileName As String = PATH & "\" & newGuid & ".txt"
                File.Create(newFileName).Dispose()
                File.WriteAllText(newFileName, Title & "%%$$##" & Desc & "%%$$##" & Body & "%%$$##" & Photo)
                fileName = newFileName
            End If
        Catch ex As IOException
            MessageBox.Show("Error saving information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub editPhoto()
        Try
            System.IO.File.WriteAllText(fileName, Title & "%%$$##" & Desc & "%%$$##" & Body & "%%$$##" & Photo)
        Catch ex As Exception
            MessageBox.Show("Error saving information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function getData(ByVal filename) As String()
        Try
            Dim data = System.IO.File.ReadAllText(filename)
            Dim values() = data.Split(New String() {"%%$$##"}, StringSplitOptions.None)
            Return values
        Catch ex As Exception
            MessageBox.Show("Failed to get original data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

End Class

