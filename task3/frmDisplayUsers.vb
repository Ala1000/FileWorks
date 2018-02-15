Imports System.IO

Public Class frmDisplayUsers

    Const USERS_PATH As String = "D:\vb\Task3 folders\Users"

    Private Sub FormDisplayUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            viewAllUsers()
        Catch ex As Exception
            MessageBox.Show("Error getting data from files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub viewAllUsers()
        Try
            ListView1.Items.Clear()
            Dim usersFiles = Directory.GetFiles(USERS_PATH)
            Dim name As String
            Dim logName As String
            Dim isLocked As Boolean
            Dim reference As String
            For Each userFile In usersFiles
                Dim user As New clsUser()
                'Dim line = File.ReadAllText(userFile)
                Dim data() = user.getData(userFile)
                name = data(0)
                logName = data(1)
                reference = userFile
                isLocked = False
                Dim i As New ListViewItem(name)
                i.SubItems.Add(logName)
                i.SubItems.Add(isLocked.ToString())
                i.SubItems.Add(userFile)
                ListView1.Items.Add(i)
            Next
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class