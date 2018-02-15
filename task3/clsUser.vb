Imports System.IO
Imports System.Security.Cryptography

Public Class clsUser

    Public Property Name() As String
    Public Property LoginName() As String
    Public Property Password() As String
    Public Property IsLocked() As Boolean

    Dim filewriter As StreamWriter
    Dim fileReader As StreamReader
    Dim newGuid As String
    Private output As FileStream
    Private input As FileStream

    Const PATH As String = "D:\vb\Task3 folders\Users"

    Public Sub New()
        MyClass.New(String.Empty, String.Empty, String.Empty)
    End Sub

    Public Sub New(ByVal newName As String, ByVal newlogName As String, ByVal newPass As String)
        Name = newName
        LoginName = newlogName
        Password = newPass
    End Sub

    Public Sub saveDataToFile()
        Try

            newGuid = System.Guid.NewGuid().ToString()
            Dim newFileName As String = PATH & "\" & newGuid & ".txt"
            File.Create(newFileName).Dispose()
            output = New FileStream(newFileName, FileMode.Open, FileAccess.Write)
            filewriter = New StreamWriter(output)
            filewriter.WriteLine(Name & "%%$$##" & LoginName & "%%$$##" & Password)
        Catch ex As IOException
            MessageBox.Show("Error saving information. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            filewriter.Close()
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


    Public Sub LockUser()
        Try
            IsLocked = True
        Catch ex As Exception
            MessageBox.Show("Can't Lock user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
