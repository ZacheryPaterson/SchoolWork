' Name: Zachery Paterson
' Class: NETD2201
' Date: April 3 2020
' This is a text-editor that has been created to have simple but expandable design

Option Strict On

Imports System.IO

Public Class frmTextEditor

    'Block of variables that will be used with tracking data

    Dim isEditedFile As Boolean = False

    Public copiedText As String = ""
    Public fileName As String = ""


    Private Sub miHelp_About_Click(sender As Object, e As EventArgs) Handles miHelp_About.Click
        ' A brief about page that is designed to explain my name, the date created, and other information about the project

        MessageBox.Show("Basic Text Editor" & vbCrLf & vbCrLf &
            "By Zachery Paterson" & vbCrLf & vbCrLf &
            "For NETD2201" & vbCrLf & vbCrLf &
            "Made on April 2nd, 2020")
    End Sub
    Private Sub miFile_Exit_Click(sender As Object, e As EventArgs) Handles miFile_Exit.Click

        ' An 'areYouSure' integer to show whether the ConfirmClose() returned a cancel, no, or yes. We don't want the program to close
        ' If someone presses cancel
        Dim areYouSure As Integer = ConfirmClose()

        If areYouSure = 1 Then
            Me.Close()
        End If
        areYouSure = 0
    End Sub

    Private Sub miFile_New_Click(sender As Object, e As EventArgs) Handles miFile_New.Click
        ' Another check to see what the ConfirmClose() returned. We don't want to change anything if cancel is input

        Dim areYouSure As Integer = ConfirmClose()

        If areYouSure = 2 Then

        Else
            tbContents.Clear()
            fileName = ""

            UpdateFormName()
        End If

    End Sub

    Private Sub miFile_Open_Click(sender As Object, e As EventArgs) Handles miFile_Open.Click

        ' Another check for the cancel button input.

        Dim areYouSure As Integer = ConfirmClose()

        If areYouSure = 2 Then

        Else
            If opdOpen.ShowDialog() = DialogResult.OK Then

                ' Creating the FileStream and StreamReader variables so you can use the OpenFileDialog to load in a text file.
                Dim openFile As FileStream
                Dim fileReader As StreamReader

                ' The opened file will become the filename and will be saved to the top of the application.
                fileName = opdOpen.FileName


                openFile = New FileStream(fileName, FileMode.Open, FileAccess.Read)
                fileReader = New StreamReader(openFile)

                tbContents.Text = fileReader.ReadToEnd

                ' Remembering to close the file reader
                fileReader.Close()
            End If

            isEditedFile = False
            UpdateFormName()
        End If

    End Sub

    Private Sub tbContents_TextChanged(sender As Object, e As EventArgs) Handles tbContents.TextChanged

        ' A small bit of code to check whether or not the file has been edited at all. In the event it has this info is used to initiate
        ' ConfirmClose()
        If tbContents.Text = "" Then

        Else
            isEditedFile = True
        End If
    End Sub

    Private Sub miEdit_Copy_Click(sender As Object, e As EventArgs) Handles miEdit_Copy.Click
        ' Compying the contents of the selection to the clipboard
        tbContents.Copy()
    End Sub

    Private Sub miEdit_Paste_Click(sender As Object, e As EventArgs) Handles miEdit_Paste.Click
        ' Checking to see what is contained in the clipboard and pasting it if it is text. As is currently shouldnt be able to support
        ' Images is can't
        If Clipboard.ContainsText Then
            tbContents.Paste()
        ElseIf Clipboard.ContainsImage Then
            MessageBox.Show("This is a text editor, you shouldn't be trying to place images in here.")
        Else
            MessageBox.Show("There is nothing currently saved to the Clipboard.")
        End If
    End Sub

    Private Sub miEdit_Cut_Click(sender As Object, e As EventArgs) Handles miEdit_Cut.Click
        ' Removing the selection from the textbox and storing it to the clipboard
        tbContents.Cut()
    End Sub

    Private Sub miFile_Save_Click(sender As Object, e As EventArgs) Handles miFile_Save.Click

        ' Checking to see if the filename has been established to open a dialog before opening the SaaveFileDialog
        If fileName = "" Then
            If sfdSave.ShowDialog() = DialogResult.OK Then
                fileName = sfdSave.FileName

                SaveFile(fileName)
            End If
        Else
            SaveFile(fileName)
        End If
        isEditedFile = False

        UpdateFormName()
    End Sub

    Private Sub miFile_SaveAs_Click(sender As Object, e As EventArgs) Handles miFile_SaveAs.Click
        ' Opens up the SaveFileDialog and then askes the user where they would like to save the text file.
        If sfdSave.ShowDialog() = DialogResult.OK Then
            fileName = sfdSave.FileName

            SaveFile(fileName)
        End If
        isEditedFile = False

        UpdateFormName()
    End Sub

#Region "methods"

    Friend Sub SaveFile(file As String)

        'Creates a filter to ensure that the file will be saved as a .txt file.
        sfdSave.Filter = "Text files (*.txt)|*.txt|All files (*,*)|*,*"
        ' Writes to the system with the file location and the contents of the textbox.

        My.Computer.FileSystem.WriteAllText(fileName, "" & tbContents.Text, True)

    End Sub

    Friend Function ConfirmClose() As Integer
        'Checks to see if the file has been edited and then promps the user on whether they would like to save the file or not.

        If isEditedFile Then
            Dim result As DialogResult = MessageBox.Show(
            "You have unsaved work. Would you like to save it before opening a new file?",
            "Open new file?",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                If fileName = "" Then
                    If sfdSave.ShowDialog() = DialogResult.OK Then
                        fileName = sfdSave.FileName

                        SaveFile(fileName)
                    End If
                Else
                    SaveFile(fileName)

                    Return 0
                End If
            ElseIf result = DialogResult.No Then
                Return 1
            ElseIf result = DialogResult.Cancel Then
                Return 2
            End If

        End If
        Return 0
    End Function
    Friend Sub UpdateFormName()

        ' Updates the form name based on whther the fileName has been set or not.
        Me.Text = "Text Editor "

        If Not fileName = String.Empty Then

            Me.Text &= " - " & fileName

        End If

    End Sub
#End Region
End Class
