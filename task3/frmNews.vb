Imports System.IO

Public Class frmNews

    Const PATH As String = "D:\vb\Task3 folders\News"
    Dim NewsObject As New clsNews()
    Dim filename As String
    Dim isEdit As Boolean = False

    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        Try
            Dim values As String()
            values = GetTextBoxesValues()
            If values(0) <> String.Empty And values(1) <> String.Empty And values(2) <> String.Empty And values(3) <> String.Empty Then
                NewsObject.Title = values(0)
                NewsObject.Desc = values(1)
                NewsObject.Category = values(2)
                NewsObject.Body = values(3)
                NewsObject.saveDataToFile()
            else
                MessageBox.Show("Please fill all information before submitting", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            clearAllTextBoxes()
            frmFileWorks.viewNewsAndPhotos()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NewNews_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            save_btn.Enabled = True
            category.DropDownStyle = ComboBoxStyle.DropDownList
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function GetTextBoxesValues()
        Dim values(4) As String
        Try
            values(0) = title.Text
            values(1) = desc.Text
            values(2) = category.SelectedItem
            values(3) = body.Text
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return values
    End Function

    Private Sub clearAllTextBoxes()
        Try
            title.Text = String.Empty
            desc.Text = String.Empty
            body.Text = String.Empty
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_btn.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub body_TextChanged(sender As Object, e As EventArgs) Handles body.TextChanged
        Try
            body.ScrollBars = ScrollBars.Vertical
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub displayNews(ByVal filename As String)
        Try
            NewsObject.fileName = filename
            Dim values() = NewsObject.getData(filename)
            title.Text = values(0)
            desc.Text = values(1)
            category.SelectedItem = values(2)
            body.Text = values(3)
        Catch ex As NullReferenceException
            MessageBox.Show("Can't display data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
