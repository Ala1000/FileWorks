Public Class frmUser

    Const PATH As String = "D:\vb\Task3 folders\Users"

    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        Try
            Dim values As String() = GetTextBoxesValues()
            Dim record As New clsUser()
            If values(0) <> String.Empty And values(1) <> String.Empty And values(2) <> String.Empty Then
                record.Name = name_txt.Text
                record.LoginName = logname_txt.Text
                record.Password = pass_txt.Text
                record.saveDataToFile()
            Else
                MessageBox.Show("Please fill all information before submitting", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            clearAllTextBoxes()
            name_txt.Select()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetTextBoxesValues()
        Dim values(3) As String
        Try
            values(0) = name_txt.Text
            values(1) = logname_txt.Text
            values(2) = pass_txt.Text
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return values
    End Function

    Private Sub clearAllTextBoxes()
        Try
            name_txt.Text = String.Empty
            logname_txt.Text = String.Empty
            pass_txt.Text = String.Empty
        Catch ex As Exception
            MessageBox.Show("Not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            pass_txt.UseSystemPasswordChar = True
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
End Class