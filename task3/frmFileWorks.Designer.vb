<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileWorks
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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.preview_tab = New System.Windows.Forms.TabPage()
        Me.prev_txt = New System.Windows.Forms.TextBox()
        Me.Preview = New System.Windows.Forms.TabControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CreationDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.img = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cat_label = New System.Windows.Forms.Label()
        Me.cdate_label = New System.Windows.Forms.Label()
        Me.title_label = New System.Windows.Forms.Label()
        Me.creationDate_Labl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.preview_tab.SuspendLayout()
        Me.Preview.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Arabic Typesetting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(41, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.PhotoToolStripMenuItem, Me.NewsToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(112, 26)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'PhotoToolStripMenuItem
        '
        Me.PhotoToolStripMenuItem.Name = "PhotoToolStripMenuItem"
        Me.PhotoToolStripMenuItem.Size = New System.Drawing.Size(112, 26)
        Me.PhotoToolStripMenuItem.Text = "Photo"
        '
        'NewsToolStripMenuItem
        '
        Me.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        Me.NewsToolStripMenuItem.Size = New System.Drawing.Size(112, 26)
        Me.NewsToolStripMenuItem.Text = "News"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem})
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.ShowToolStripMenuItem.Text = "Settings"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arabic Typesetting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ShowToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(742, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'preview_tab
        '
        Me.preview_tab.AutoScroll = True
        Me.preview_tab.Controls.Add(Me.prev_txt)
        Me.preview_tab.Location = New System.Drawing.Point(4, 24)
        Me.preview_tab.Name = "preview_tab"
        Me.preview_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.preview_tab.Size = New System.Drawing.Size(703, 173)
        Me.preview_tab.TabIndex = 0
        Me.preview_tab.Text = "Preview"
        Me.preview_tab.UseVisualStyleBackColor = True
        '
        'prev_txt
        '
        Me.prev_txt.Location = New System.Drawing.Point(3, 3)
        Me.prev_txt.Multiline = True
        Me.prev_txt.Name = "prev_txt"
        Me.prev_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.prev_txt.Size = New System.Drawing.Size(691, 167)
        Me.prev_txt.TabIndex = 0
        '
        'Preview
        '
        Me.Preview.Controls.Add(Me.preview_tab)
        Me.Preview.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Preview.Location = New System.Drawing.Point(13, 399)
        Me.Preview.Name = "Preview"
        Me.Preview.SelectedIndex = 0
        Me.Preview.Size = New System.Drawing.Size(711, 201)
        Me.Preview.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 213)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of news and photos"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Title, Me.CreationDate, Me.Description, Me.img, Me.ID})
        Me.ListView1.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(9, 24)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(711, 183)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Title
        '
        Me.Title.Text = "Title"
        Me.Title.Width = 93
        '
        'CreationDate
        '
        Me.CreationDate.Text = "Creation date"
        Me.CreationDate.Width = 168
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 250
        '
        'img
        '
        Me.img.Text = "reference"
        Me.img.Width = 0
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cat_label)
        Me.GroupBox2.Controls.Add(Me.cdate_label)
        Me.GroupBox2.Controls.Add(Me.title_label)
        Me.GroupBox2.Controls.Add(Me.creationDate_Labl)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(705, 142)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Category"
        '
        'cat_label
        '
        Me.cat_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cat_label.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat_label.Location = New System.Drawing.Point(137, 101)
        Me.cat_label.Name = "cat_label"
        Me.cat_label.Size = New System.Drawing.Size(562, 23)
        Me.cat_label.TabIndex = 13
        '
        'cdate_label
        '
        Me.cdate_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cdate_label.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdate_label.Location = New System.Drawing.Point(137, 64)
        Me.cdate_label.Name = "cdate_label"
        Me.cdate_label.Size = New System.Drawing.Size(562, 23)
        Me.cdate_label.TabIndex = 13
        '
        'title_label
        '
        Me.title_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.title_label.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_label.Location = New System.Drawing.Point(137, 33)
        Me.title_label.Name = "title_label"
        Me.title_label.Size = New System.Drawing.Size(562, 23)
        Me.title_label.TabIndex = 12
        '
        'creationDate_Labl
        '
        Me.creationDate_Labl.AutoSize = True
        Me.creationDate_Labl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creationDate_Labl.Location = New System.Drawing.Point(6, 70)
        Me.creationDate_Labl.Name = "creationDate_Labl"
        Me.creationDate_Labl.Size = New System.Drawing.Size(107, 17)
        Me.creationDate_Labl.TabIndex = 12
        Me.creationDate_Labl.Text = "Creation date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Title"
        '
        'frmFileWorks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 612)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Preview)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFileWorks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileWorks"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.preview_tab.ResumeLayout(False)
        Me.preview_tab.PerformLayout()
        Me.Preview.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents preview_tab As System.Windows.Forms.TabPage
    Friend WithEvents Preview As System.Windows.Forms.TabControl
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents prev_txt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Title As System.Windows.Forms.ColumnHeader
    Friend WithEvents CreationDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents img As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cat_label As System.Windows.Forms.Label
    Friend WithEvents cdate_label As System.Windows.Forms.Label
    Friend WithEvents title_label As System.Windows.Forms.Label
    Friend WithEvents creationDate_Labl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
End Class
