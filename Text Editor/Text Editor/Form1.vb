Option Strict On

Imports System.IO

Public Class frmTextEditor

    'Block of variables that will be used with tracking data

    Dim isFileOpen As Boolean = False
    Dim isEditedFile As Boolean = False

    Dim copiedText As String = ""
    Dim fileName As String = ""

    Function SaveFile(file As String) As Boolean

    End Function

    Private Sub miHelp_About_Click(sender As Object, e As EventArgs) Handles miHelp_About.Click
        MessageBox.Show("Basic Text Editor" & vbCrLf & vbCrLf &
            "By Zachery Paterson" & vbCrLf & vbCrLf &
            "For NETD2201" & vbCrLf & vbCrLf &
            "Made on April 2nd, 2020")
    End Sub
    Private Sub miFile_Exit_Click(sender As Object, e As EventArgs) Handles miFile_Exit.Click

        If isEditedFile Then
            Dim result As DialogResult = MessageBox.Show(
            "You have unsaved work. Would you like to save it before exiting?",
            "Exit Text Editor?",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' TODO FILL this with save prompt

            ElseIf result = DialogResult.No Then
                Me.Close()
            ElseIf result = DialogResult.Cancel Then
                Return
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub miFile_New_Click(sender As Object, e As EventArgs) Handles miFile_New.Click
        tbContents.Clear()
        fileName = ""

    End Sub

    Private Sub miFile_Open_Click(sender As Object, e As EventArgs) Handles miFile_Open.Click

        Dim openFile As FileStream
        Dim fileReader As StreamReader

        If opdOpen.ShowDialog() = DialogResult.OK Then
            fileName = opdOpen.FileName
            isFileOpen = True

            openFile = New FileStream(fileName, FileMode.Open, FileAccess.Read)
            fileReader = New StreamReader(openFile)

            tbContents.Text = fileReader.ReadToEnd
        End If

    End Sub

    Private Sub tbContents_TextChanged(sender As Object, e As EventArgs) Handles tbContents.TextChanged
        isEditedFile = True
    End Sub

    Private Sub miEdit_Copy_Click(sender As Object, e As EventArgs) Handles miEdit_Copy.Click

        tbContents.Copy()

    End Sub

    Private Sub miEdit_Paste_Click(sender As Object, e As EventArgs) Handles miEdit_Paste.Click

        tbContents.Paste()
    End Sub

    Private Sub miEdit_Cut_Click(sender As Object, e As EventArgs) Handles miEdit_Cut.Click
        tbContents.Cut()
    End Sub
End Class
