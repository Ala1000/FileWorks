<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhoto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabWindow = New System.Windows.Forms.TabControl()
        Me.Title = New System.Windows.Forms.TabPage()
        Me.photo_desc = New System.Windows.Forms.TextBox()
        Me.photo_body = New System.Windows.Forms.TextBox()
        Me.photo_title = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Photo = New System.Windows.Forms.TabPage()
        Me.pic_view = New System.Windows.Forms.PictureBox()
        Me.browse_file = New System.Windows.Forms.Label()
        Me.browse_btn = New System.Windows.Forms.Button()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.TabWindow.SuspendLayout()
        Me.Title.SuspendLayout()
        Me.Photo.SuspendLayout()
        CType(Me.pic_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabWindow
        '
        Me.TabWindow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabWindow.Controls.Add(Me.Title)
        Me.TabWindow.Controls.Add(Me.Photo)
        Me.TabWindow.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabWindow.Location = New System.Drawing.Point(12, 12)
        Me.TabWindow.Name = "TabWindow"
        Me.TabWindow.SelectedIndex = 0
        Me.TabWindow.Size = New System.Drawing.Size(608, 463)
        Me.TabWindow.TabIndex = 0
        '
        'Title
        '
        Me.Title.Controls.Add(Me.photo_desc)
        Me.Title.Controls.Add(Me.photo_body)
        Me.Title.Controls.Add(Me.photo_title)
        Me.Title.Controls.Add(Me.Label3)
        Me.Title.Controls.Add(Me.Label2)
        Me.Title.Controls.Add(Me.Label1)
        Me.Title.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(4, 37)
        Me.Title.Name = "Title"
        Me.Title.Padding = New System.Windows.Forms.Padding(3)
        Me.Title.Size = New System.Drawing.Size(600, 422)
        Me.Title.TabIndex = 0
        Me.Title.Text = "File Description"
        Me.Title.UseVisualStyleBackColor = True
        '
        'photo_desc
        '
        Me.photo_desc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.photo_desc.Location = New System.Drawing.Point(180, 80)
        Me.photo_desc.Name = "photo_desc"
        Me.photo_desc.Size = New System.Drawing.Size(394, 36)
        Me.photo_desc.TabIndex = 5
        '
        'photo_body
        '
        Me.photo_body.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.photo_body.Location = New System.Drawing.Point(180, 149)
        Me.photo_body.Multiline = True
        Me.photo_body.Name = "photo_body"
        Me.photo_body.Size = New System.Drawing.Size(394, 188)
        Me.photo_body.TabIndex = 4
        '
        'photo_title
        '
        Me.photo_title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.photo_title.Location = New System.Drawing.Point(180, 20)
        Me.photo_title.Name = "photo_title"
        Me.photo_title.Size = New System.Drawing.Size(394, 36)
        Me.photo_title.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Body"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title"
        '
        'Photo
        '
        Me.Photo.Controls.Add(Me.pic_view)
        Me.Photo.Controls.Add(Me.browse_file)
        Me.Photo.Controls.Add(Me.browse_btn)
        Me.Photo.Location = New System.Drawing.Point(4, 37)
        Me.Photo.Name = "Photo"
        Me.Photo.Padding = New System.Windows.Forms.Padding(3)
        Me.Photo.Size = New System.Drawing.Size(600, 422)
        Me.Photo.TabIndex = 1
        Me.Photo.Text = "Photo"
        Me.Photo.UseVisualStyleBackColor = True
        '
        'pic_view
        '
        Me.pic_view.Location = New System.Drawing.Point(13, 58)
        Me.pic_view.Name = "pic_view"
        Me.pic_view.Size = New System.Drawing.Size(583, 398)
        Me.pic_view.TabIndex = 2
        Me.pic_view.TabStop = False
        '
        'browse_file
        '
        Me.browse_file.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browse_file.Location = New System.Drawing.Point(119, 15)
        Me.browse_file.Name = "browse_file"
        Me.browse_file.Size = New System.Drawing.Size(472, 20)
        Me.browse_file.TabIndex = 1
        '
        'browse_btn
        '
        Me.browse_btn.Location = New System.Drawing.Point(6, 6)
        Me.browse_btn.Name = "browse_btn"
        Me.browse_btn.Size = New System.Drawing.Size(110, 35)
        Me.browse_btn.TabIndex = 0
        Me.browse_btn.Text = "Browse"
        Me.browse_btn.UseVisualStyleBackColor = True
        '
        'cancel_btn
        '
        Me.cancel_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cancel_btn.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_btn.Location = New System.Drawing.Point(449, 481)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(131, 39)
        Me.cancel_btn.TabIndex = 7
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.save_btn.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.Location = New System.Drawing.Point(283, 481)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(131, 39)
        Me.save_btn.TabIndex = 6
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'Frm_Photo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 524)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.TabWindow)
        Me.Controls.Add(Me.save_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Photo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Photo"
        Me.TabWindow.ResumeLayout(False)
        Me.Title.ResumeLayout(False)
        Me.Title.PerformLayout()
        Me.Photo.ResumeLayout(False)
        CType(Me.pic_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabWindow As System.Windows.Forms.TabControl
    Friend WithEvents Title As System.Windows.Forms.TabPage
    Friend WithEvents Photo As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cancel_btn As System.Windows.Forms.Button
    Friend WithEvents save_btn As System.Windows.Forms.Button
    Friend WithEvents photo_desc As System.Windows.Forms.TextBox
    Friend WithEvents photo_body As System.Windows.Forms.TextBox
    Friend WithEvents photo_title As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pic_view As System.Windows.Forms.PictureBox
    Friend WithEvents browse_file As System.Windows.Forms.Label
    Friend WithEvents browse_btn As System.Windows.Forms.Button
End Class
