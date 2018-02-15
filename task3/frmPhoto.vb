Imports System.IO

Public Class frmPhoto

    Dim PhotoObject As New clsPhoto()
    Const PATH As String = "D:\vb\Task3 folders\Photos"
    Dim filename As String
    Dim isEdit As Boolean = False

    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        Try
            Dim values As String() = GetTextBoxesValues()
            If values(0) <> String.Empty And values(1) <> String.Empty And values(2) <> String.Empty Then
                    PhotoObject.Title = values(0)
                    PhotoObject.Desc = values(1)
                    PhotoObject.Body = values(2)
                    PhotoObject.Photo = values(3)
                    PhotoObject.saveDataToFile()
            Else
                MessageBox.Show("Please fill all information before submitting", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            clearAllTextBoxes()
            frmFileWorks.viewNewsAndPhotos()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to save data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NewPhoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            save_btn.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error loading program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function GetTextBoxesValues()
        Dim values(4) As String
        Try
            values(0) = photo_title.Text
            values(1) = photo_desc.Text
            values(2) = photo_body.Text
            values(3) = browse_file.Text
        Catch ex As Exception
            MessageBox.Show("Can't get data from the form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return values
    End Function

    Private Sub clearAllTextBoxes()
        Try
            photo_title.Text = String.Empty
            photo_body.Text = String.Empty
            photo_desc.Text = String.Empty
            browse_file.Text = String.Empty
            pic_view.ImageLocation = String.Empty
        Catch ex As Exception
            MessageBox.Show("Can't clear form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub browse_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browse_btn.Click
        Try
            Dim result As DialogResult
            Using fileChooser As New OpenFileDialog()
                fileChooser.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
                result = fileChooser.ShowDialog()
                filename = fileChooser.FileName
            End Using
            If result <> Windows.Forms.DialogResult.Cancel Then
                browse_file.Text = filename
                pic_view.ImageLocation = filename
            End If
        Catch ex As Exception
            MessageBox.Show("Error getting the image. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_btn.Click
        Try
            frmFileWorks.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub photo_body_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles photo_body.TextChanged
        Try
            photo_body.ScrollBars = ScrollBars.Vertical
        Catch ex As Exception
            MessageBox.Show("Form not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub displayPhotos(ByVal filename As String)
        Try
            PhotoObject.fileName = filename
            Dim values() = PhotoObject.getData(filename)
            photo_title.Text = values(0)
            photo_desc.Text = values(1)
            photo_body.Text = values(2)
            browse_file.Text = values(3)
            pic_view.ImageLocation = values(3)
        Catch ex As NullReferenceException
            MessageBox.Show("Can't display data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class