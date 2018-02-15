Imports System.IO
Public Class clsNews

    Public Property Title() As String
    Public Property Desc() As String
    Public Property Category() As String
    Public Property Body() As String
    Public Property fileName() As String

    Dim filewriter As StreamWriter
    Dim fileReader As StreamReader
    Dim newGuid As String
    Private output As FileStream
    Private input As FileStream


    Const PATH As String = "D:\vb\Task3 folders\News"

    Public Sub New()
        MyClass.New(String.Empty, String.Empty, String.Empty, String.Empty)
    End Sub

    Public Sub New(ByVal newTitle As String, ByVal newDesc As String, ByVal newCategory As String, ByVal newBody As String)
        Title = newTitle
        Desc = newDesc
        Category = newCategory
        Body = newBody
    End Sub

    Public Sub New(ByVal newTitle As String, ByVal newDesc As String, ByVal newCategory As String, ByVal newBody As String, ByVal myFile As String)
        Title = newTitle
        Desc = newDesc
        Category = newCategory
        Body = newBody
        fileName = myFile
    End Sub

    Public Sub New(ByVal file As String)
        fileName = file
    End Sub


    Public Sub saveDataToFile()
        Try
            If fileName IsNot Nothing Then
                editNews()
            Else
                newGuid = System.Guid.NewGuid().ToString()
                Dim newFileName As String = PATH & "\" & newGuid & ".txt"
                File.Create(newFileName).Dispose()
                File.WriteAllText(newFileName, Title & "%%$$##" & Desc & "%%$$##" & Category & "%%$$##" & Body)
                fileName = newFileName
            End If
        Catch ex As Exception
            MessageBox.Show("Error saving information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub editNews()
        Try
            System.IO.File.WriteAllText(fileName, Title & "%%$$##" & Desc & "%%$$##" & Category & "%%$$##" & Body)
        Catch ex As Exception
            MessageBox.Show("Failed to modify data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
