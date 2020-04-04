<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTextEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.miFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFile_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFile_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFile_Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFile_SaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFile_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEdit_Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEdit_Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEdit_Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miHelp_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbContents = New System.Windows.Forms.TextBox()
        Me.ttpEditorTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.opdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFile, Me.miEdit, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "miTopMenu"
        '
        'miFile
        '
        Me.miFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFile_New, Me.miFile_Open, Me.miFile_Save, Me.miFile_SaveAs, Me.miFile_Exit})
        Me.miFile.Name = "miFile"
        Me.miFile.Size = New System.Drawing.Size(37, 20)
        Me.miFile.Text = "&File"
        Me.miFile.ToolTipText = "Open or Close Files"
        '
        'miFile_New
        '
        Me.miFile_New.Name = "miFile_New"
        Me.miFile_New.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.miFile_New.Size = New System.Drawing.Size(146, 22)
        Me.miFile_New.Text = "&New"
        Me.miFile_New.ToolTipText = "Create a New File"
        '
        'miFile_Open
        '
        Me.miFile_Open.Name = "miFile_Open"
        Me.miFile_Open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.miFile_Open.Size = New System.Drawing.Size(146, 22)
        Me.miFile_Open.Text = "&Open"
        Me.miFile_Open.ToolTipText = "Open an Existing File"
        '
        'miFile_Save
        '
        Me.miFile_Save.Name = "miFile_Save"
        Me.miFile_Save.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.miFile_Save.Size = New System.Drawing.Size(146, 22)
        Me.miFile_Save.Text = "&Save"
        Me.miFile_Save.ToolTipText = "Save the Current File"
        '
        'miFile_SaveAs
        '
        Me.miFile_SaveAs.Name = "miFile_SaveAs"
        Me.miFile_SaveAs.Size = New System.Drawing.Size(146, 22)
        Me.miFile_SaveAs.Text = "Save &As..."
        Me.miFile_SaveAs.ToolTipText = "Save the Current File Under a New Name"
        '
        'miFile_Exit
        '
        Me.miFile_Exit.Name = "miFile_Exit"
        Me.miFile_Exit.Size = New System.Drawing.Size(146, 22)
        Me.miFile_Exit.Text = "E&xit"
        Me.miFile_Exit.ToolTipText = "Exit the Application"
        '
        'miEdit
        '
        Me.miEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miEdit_Copy, Me.miEdit_Cut, Me.miEdit_Paste})
        Me.miEdit.Name = "miEdit"
        Me.miEdit.Size = New System.Drawing.Size(39, 20)
        Me.miEdit.Text = "&Edit"
        Me.miEdit.ToolTipText = "Modify Current File"
        '
        'miEdit_Copy
        '
        Me.miEdit_Copy.Name = "miEdit_Copy"
        Me.miEdit_Copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.miEdit_Copy.Size = New System.Drawing.Size(180, 22)
        Me.miEdit_Copy.Text = "&Copy"
        Me.miEdit_Copy.ToolTipText = "Save your Current Selection to the Clipboard"
        '
        'miEdit_Cut
        '
        Me.miEdit_Cut.Name = "miEdit_Cut"
        Me.miEdit_Cut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.miEdit_Cut.Size = New System.Drawing.Size(180, 22)
        Me.miEdit_Cut.Text = "Cu&t"
        Me.miEdit_Cut.ToolTipText = "Save the Current Selection to the Clipboard and Erase the Selection"
        '
        'miEdit_Paste
        '
        Me.miEdit_Paste.Name = "miEdit_Paste"
        Me.miEdit_Paste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.miEdit_Paste.Size = New System.Drawing.Size(180, 22)
        Me.miEdit_Paste.Text = "&Paste"
        Me.miEdit_Paste.ToolTipText = "Insert the Contents of your Clipboard at the Selection"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miHelp_About})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        Me.HelpToolStripMenuItem.ToolTipText = "Assistance and Information"
        '
        'miHelp_About
        '
        Me.miHelp_About.Name = "miHelp_About"
        Me.miHelp_About.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.miHelp_About.Size = New System.Drawing.Size(126, 22)
        Me.miHelp_About.Text = "&About"
        Me.miHelp_About.ToolTipText = "Information About the Text Editor"
        '
        'tbContents
        '
        Me.tbContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbContents.Location = New System.Drawing.Point(0, 24)
        Me.tbContents.Multiline = True
        Me.tbContents.Name = "tbContents"
        Me.tbContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbContents.Size = New System.Drawing.Size(800, 426)
        Me.tbContents.TabIndex = 1
        '
        'opdOpen
        '
        Me.opdOpen.FileName = "opdOpen"
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbContents)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents miFile As ToolStripMenuItem
    Friend WithEvents miFile_New As ToolStripMenuItem
    Friend WithEvents miFile_Open As ToolStripMenuItem
    Friend WithEvents miFile_Save As ToolStripMenuItem
    Friend WithEvents miFile_SaveAs As ToolStripMenuItem
    Friend WithEvents miFile_Exit As ToolStripMenuItem
    Friend WithEvents miEdit As ToolStripMenuItem
    Friend WithEvents miEdit_Copy As ToolStripMenuItem
    Friend WithEvents miEdit_Cut As ToolStripMenuItem
    Friend WithEvents miEdit_Paste As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents miHelp_About As ToolStripMenuItem
    Friend WithEvents tbContents As TextBox
    Friend WithEvents ttpEditorTip As ToolTip
    Friend WithEvents opdOpen As OpenFileDialog
    Friend WithEvents sfdSave As SaveFileDialog
End Class
