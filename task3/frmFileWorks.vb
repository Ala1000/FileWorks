Imports System.IO
Imports Oracle.DataAccess.Client

Public Class frmFileWorks

    Const USERS_PATH As String = "D:\vb\Task3 folders\Users"
    Const PHOTOS_PATH As String = "D:\vb\Task3 folders\Photos"
    Const NEWS_PATH As String = "D:\vb\Task3 folders\News"
    Const NEWS_CLASS_ID = 0
    Const PHOTO_CLASS_ID = 1


    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Try
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersToolStripMenuItem.Click
        Try
            Dim displayUsers As New frmDisplayUsers
            displayUsers.Show()
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NewsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            viewNewsAndPhotos()
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        
        Try
            clearLables()
            If (Preview.TabPages.Count > 1) Then
                Preview.TabPages.RemoveAt(1)
            End If
            If ListView1.SelectedItems.Count > 0 Then
                title_label.Text = ListView1.SelectedItems(0).Text
                cdate_label.Text = ListView1.SelectedItems(0).SubItems(1).Text
                Dim file = ListView1.SelectedItems(0).SubItems(3).Text
                Dim txt = System.IO.File.ReadAllText(file)
                Dim data() = txt.Split(New String() {"%%$$##"}, StringSplitOptions.None)

                If Path.GetDirectoryName(file).ToString().Contains("News") Then
                    cat_label.Text = data(2)
                    prev_txt.Text = data(3)
                Else
                    cat_label.Text = String.Empty
                    Preview.TabPages.Add("Image")
                    Dim pb As PictureBox = New PictureBox()
                    pb.Size = New System.Drawing.Size(300, 300)
                    pb.SizeMode = PictureBoxSizeMode.CenterImage
                    Dim imgTab As TabPage = Preview.TabPages.Item(1)
                    imgTab.Controls.Add(pb)
                    imgTab.AutoScroll = True
                    pb.ImageLocation = data(3)
                    prev_txt.Text = data(2)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub clearLables()
        Try
            title_label.Text = String.Empty
            cdate_label.Text = String.Empty
            prev_txt.Text = String.Empty
            cat_label.Text = String.Empty
            If (Preview.TabPages.Count > 1) Then
                Preview.TabPages.RemoveAt(1)
            End If
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        Try
            Dim userForm As New frmUser
            userForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PhotoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhotoToolStripMenuItem.Click
        Try
            Dim photoForm As New frmPhoto
            photoForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NewsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewsToolStripMenuItem.Click
        Try
            Dim newsForm As New frmNews
            newsForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListView1_DoubleClicked(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Try
            If ListView1.SelectedItems.Count > 0 Then
                Dim file = ListView1.SelectedItems(0).SubItems(3).Text
                If ListView1.SelectedItems(0).SubItems(4).Text = "0" Then
                    Dim newsForm As New frmNews
                    Dim news As New clsNews(file)
                    newsForm.displayNews(file)
                    newsForm.ShowDialog()
                Else
                    Dim photoForm As New frmPhoto
                    Dim photo As New clsPhoto(file)
                    photoForm.displayPhotos(file)
                    photoForm.ShowDialog()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub viewNewsAndPhotos()
        
        Try

            ListView1.Items.Clear()
            clearLables()

            Dim photofiles() = Directory.GetFiles(PHOTOS_PATH)
            Dim newsfiles() = Directory.GetFiles(NEWS_PATH)

            Dim title As String
            Dim body As String
            Dim desc As String
            Dim img As String
            Dim creationDate As Date

            For Each photo In photofiles
                Dim record As New clsPhoto()
                'Dim line = File.ReadAllText(photo)
                Dim data() = record.getData(photo)
                title = data(0)
                desc = data(1)
                body = data(2)
                img = photo
                creationDate = File.GetCreationTime(photo)
                Dim i As New ListViewItem(title)
                i.SubItems.Add(creationDate.ToString())
                i.SubItems.Add(desc)
                i.SubItems.Add(img)
                i.SubItems.Add(1)
                ListView1.Items.Add(i)
            Next

            For Each news In newsfiles
                Dim record As New clsNews()
                'Dim line = File.ReadAllText(news)
                Dim data() = record.getData(news)
                title = data(0)
                desc = data(1)
                body = data(2)
                img = news
                creationDate = File.GetCreationTime(news)
                Dim i As New ListViewItem(title)
                i.SubItems.Add(creationDate.ToString())
                i.SubItems.Add(desc)
                i.SubItems.Add(img)
                i.SubItems.Add(0)
                ListView1.Items.Add(i)
            Next

        Catch ex As IOException
            MessageBox.Show("Unable to retrieve data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex2 As UnauthorizedAccessException
            MessageBox.Show("Permission to access dara was denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex3 As ArgumentNullException
            MessageBox.Show("Wrong data path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ListView1_Delete(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then

                If ListView1.SelectedItems.Count > 0 Then
                    Dim listMenu As New ContextMenuStrip()
                    Dim item As New ToolStripMenuItem("Delete", Nothing, AddressOf del_clk)
                    Dim item2 As New ToolStripMenuItem("Edit", Nothing, AddressOf edit_clk)
                    listMenu.Items.Add(item)
                    listMenu.Items.Add(item2)
                    listMenu.Show(ListView1, New Point(e.X, e.Y))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to delete this item from the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Frm_FileWorks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            viewNewsAndPhotos()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub del_clk(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim result = MessageBox.Show("Are you sure that you want to delete this from the system?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
            If result = Windows.Forms.DialogResult.Yes Then
                Dim file = ListView1.SelectedItems(0).SubItems(3).Text
                System.IO.File.Delete(file)
                clearLables()
                If (Preview.TabPages.Count > 1) Then
                    Preview.TabPages.RemoveAt(1)
                End If
                viewNewsAndPhotos()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to delete file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub edit_clk(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If ListView1.SelectedItems.Count > 0 Then
                Dim file = ListView1.SelectedItems(0).SubItems(3).Text
                If ListView1.SelectedItems(0).SubItems(4).Text = "0" Then
                    Dim newsForm As New frmNews
                    Dim news As New clsNews(file)
                    newsForm.displayNews(file)
                    newsForm.ShowDialog()
                Else
                    Dim photoForm As New frmPhoto
                    Dim photo As New clsPhoto(file)
                    photoForm.displayPhotos(file)
                    photoForm.ShowDialog()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class