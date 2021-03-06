﻿Imports System.IO

Module modINI
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String,
    ByVal lpKeyName As String, ByVal lpString As String,
    ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String,
    ByVal lpKeyName As String, ByVal lpDefault As String,
    ByVal lpReturnedString As String, ByVal nSize As Int32,
    ByVal lpFileName As String) As Int32

    Public Sub WriteIni(ByVal iniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamVal As String)
        Dim Result As Integer = WritePrivateProfileString(Section, ParamName, ParamVal, iniFileName)
    End Sub

    Public Function ReadIni(ByVal IniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamDefault As String) As String
        Dim ParamVal As String = Space$(1024)
        Dim LenParamVal As Long = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamVal, Len(ParamVal), IniFileName)
        ReadIni = Left$(ParamVal, LenParamVal)
    End Function

    ''' <summary>
    ''' Helping Code with easily and simply from Writeini().
    ''' </summary>
    Public Sub Wini(ByVal PName As String, ByVal PValue As String)
        Dim iniFile As String = Application.StartupPath + "\settings.ini"
        Dim sec As String = "CPW_Path"

        Dim Result As Integer = WritePrivateProfileString(sec, PName, PValue, iniFile)
    End Sub

    ''' <summary>
    ''' Helping Code with easily and simply from Readini().
    ''' </summary>
    Public Function Rini(ByVal PName As String) As String
        Dim iniFile As String = Application.StartupPath + "\settings.ini"
        Dim sec As String = "CPW_Path"

        Dim ParamVal As String = Space$(1024)
        Dim LenParamVal As Long = GetPrivateProfileString(sec, PName, "", ParamVal, Len(ParamVal), iniFile)
        Rini = Left$(ParamVal, LenParamVal)
    End Function
End Module
Public Class MainProject
    Dim iniFile As String = Application.StartupPath + "\settings.ini"
    Dim sec As String = "CPW_Path"

    Dim CuStr(2) As String 'Items of Custom Mode.
    Dim GTwInt As Integer '(0 = Default, 1 = Fail!)
    Dim CMInt As Integer '(0 = Not Enabled, 1 = Enabled)
    Dim CWTrue As Boolean
    Dim PWTrue As Boolean
    Dim GITTrue As Boolean
    Dim GTwTrue As Boolean
    Dim BakTrue As Boolean

    Private Sub MainProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CM_ComboBox.Items.Item(0).ToString 'Output: Hello, World!
        CWTrue = False
        PWTrue = False
        GITTrue = False
        BakTrue = False

        '-Load Settings
        VerText.Text = "     Version. " + My.Application.Info.Version.ToString

        If Not Rini("CWPath") = "N/A" Then 'Reading "To Copy Folder" Path
            CW_TextBox.Text = Rini("CWPath")
            CWTrue = True
        Else
            CW_TextBox.Text = "Select your Workspace Folder"
        End If

        If Not Rini("PWPath") = "N/A" Then 'Reading "To Paste Folder" Path
            PW_TextBox.Text = Rini("PWPath")
            PWTrue = True
        Else
            PW_TextBox.Text = "Select your Repos Folder"
        End If

        If Rini("CModeEnabled") = "True" Then 'Custom Mode Enabled
            CM_CheckBox.Checked = True
        Else
            CM_CheckBox.Checked = False
        End If

        If Rini("GTwEnabled") = "True" Then 'Save SETTINGS! + Ctrl + C/V
            GazuaTCheckBox.Checked = True
            SaveButton.Enabled = False
            GazuaButton.Text = "Save SETTINGS!" & vbNewLine & "Ctrl + C/V"
        Else
            GazuaTCheckBox.Checked = False
        End If

        If Rini("OpenGITEnabled") = "True" Then 'Open GIT Program After Ctrl + C/V
            OpenGITCheckBox.Checked = True
            GITPathTextBox.Visible = True
            If Not Rini("GITPath") = "N/A" Then
                GITPathTextBox.Text = Rini("GITPath")
                GITTrue = True
            Else GITPathTextBox.Text = "Select GIT Program Path"
            End If
            GITPathButton.Visible = True
        Else
            OpenGITCheckBox.Checked = False
        End If

        If Rini("BakEnabled") = "True" Then 'Backup Folder
            BakCheckBox.Checked = True
            BW_TextBox.Visible = True
            If Not Rini("BWPath") = "N/A" Then
                BW_TextBox.Text = Rini("BWPath")
                BakTrue = True
            Else BW_TextBox.Text = "Select Bakup Folder Path"
            End If
            BakButton.Visible = True
        Else
            BakCheckBox.Checked = False
        End If

        If Rini("DelDirEnabled") = "True" Then 'Delete Paste Directory Before Copy it
            DelDirCheckBox.Checked = True
        Else DelDirCheckBox.Checked = False
        End If

        If Rini("AutoExitEnabled") = "True" Then 'Auto Exit
            ExitCheckBox.Checked = True
        Else ExitCheckBox.Checked = False
        End If

        If Rini("WeAreTheChampions") = "True" Then
            WeRCheckBox.Checked = True
        Else WeRCheckBox.Checked = False
        End If

        'Custom Mode Items (BETA)
        CuStr(0) = "Hello, World!"
        CuStr(1) = "Launchpad MK2"
        CuStr(2) = "UniConverter V1.1.0.3"

        For Each q As String In CuStr
            Dim itm As New ListViewItem(New String() {q})
            CM_ComboBox.Items.Add(itm.Text)
        Next
    End Sub

    Private Sub CW_Button_Click(sender As Object, e As EventArgs) Handles CW_Button.Click
        If Not Rini("CWPath") = "N/A" Then
            fbd_path.SelectedPath = Rini("CWPath")
        End If
        fbd_path.Description = "Select your Workspace Folder"
        If fbd_path.ShowDialog = DialogResult.OK Then
            CW_TextBox.Text = fbd_path.SelectedPath
            CWTrue = True
        End If
    End Sub

    Private Sub PW_Button_Click(sender As Object, e As EventArgs) Handles PW_Button.Click
        If Not Rini("PWPath") = "N/A" Then
            fbd_path.SelectedPath = Rini("PWPath")
        End If
        fbd_path.Description = "Select your Repos Folder"
        If fbd_path.ShowDialog = DialogResult.OK Then
            PW_TextBox.Text = fbd_path.SelectedPath
            PWTrue = True
        End If
    End Sub

    Private Sub CM_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CM_CheckBox.CheckedChanged
        If CM_CheckBox.Checked = True Then
            CMInt = 1 'Check Value
            CM_ComboBox.Enabled = True
            EDITCModeButton.Enabled = True
        Else
            If CMInt = 1 Then
                CM_ComboBox.Enabled = False
                EDITCModeButton.Enabled = False
                CMInt = 0
            End If
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If Not CW_TextBox.Text = "Select your Workspace Folder" Then
                Wini("CWPath", CW_TextBox.Text)
            Else
                Wini("CWPath", "N/A")
            End If

            If CW_TextBox.Text = "/def" Then
                Wini("CWPath", "N/A")
                CW_TextBox.Text = "Select Your Workspace Folder"
            End If

            If Not PW_TextBox.Text = "Select your Repos Folder" Then
                Wini("PWPath", PW_TextBox.Text)
            Else
                Wini("PWPath", "N/A")
            End If

            If PW_TextBox.Text = "/def" Then
                Wini("PWPath", "N/A")
                PW_TextBox.Text = "Select your Repos Folder"
            End If

            If Rini("GTwEnabled") = "True" Then
                GTwTrue = True
            Else GTwTrue = False
            End If

            If CM_CheckBox.Checked = True Then
                Wini("CModeEnabled", "True")
            Else
                Wini("CModeEnabled", "False")
            End If

            If GTwTrue = True Then
                If GazuaTCheckBox.Checked = True Then
                    Wini("GTwEnabled", "True")
                    SaveButton.Enabled = False
                    GazuaButton.Text = "Save SETTINGS!" & vbNewLine & "Ctrl + C/V"
                    GTwInt = 1
                Else
                    Wini("GTwEnabled", "False")
                    SaveButton.Enabled = True
                    GazuaButton.Text = "Ctrl + C/V"
                    GTwInt = 0
                End If
            Else
                If GazuaTCheckBox.Checked = True Then
                    Wini("GTwEnabled", "True")
                    SaveButton.Enabled = False
                    GazuaButton.Text = "Save SETTINGS!" & vbNewLine & "Ctrl + C/V"
                    GTwInt = 0
                End If
            End If

            If OpenGITCheckBox.Checked = True Then
                Wini("OpenGITEnabled", "True")
                If GITTrue = True Then
                    Wini("GITPath", GITPathTextBox.Text)
                Else Wini("GITPath", "N/A")
                End If
            Else
                Wini("OpenGITEnabled", "False")
                Wini("GITPath", "N/A")
            End If

            If BakCheckBox.Checked = True Then
                Wini("BakEnabled", "True")
                If BakTrue = True Then
                    Wini("BWPath", BW_TextBox.Text)
                Else Wini("BWPath", "N/A")
                End If
            Else
                Wini("BakEnabled", "False")
                Wini("BWPath", "N/A")
            End If

            If DelDirCheckBox.Checked = True Then
                Wini("DelDirEnabled", "True")
            Else
                Wini("DelDirEnabled", "False")
            End If

            If ExitCheckBox.Checked = True Then
                Wini("AutoExitEnabled", "True")
            Else
                Wini("AutoExitEnabled", "False")
            End If

            If WeRCheckBox.Checked = True Then
                Wini("WeAreTheChampions", "True")
            Else
                Wini("WeAreTheChampions", "False")
            End If

            If Not GTwInt = 1 Then
                MessageBox.Show("Saved Settings!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error! - " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GazuaButton_Click(sender As Object, e As EventArgs) Handles GazuaButton.Click
        Try
            Dim GoUpBak As Boolean
            Dim CopyDirInfo As New DirectoryInfo(CW_TextBox.Text)
            Dim PasDirInfo As New DirectoryInfo(PW_TextBox.Text)
            Dim SubDir As DirectoryInfo

            If Rini("GTwEnabled") = "True" Then
                SaveButton_Click(Nothing, Nothing)
            End If

            If Rini("BakEnabled") = "True" Then
                If Not Rini("BWPath") = "N/A" Then
                    GoUpBak = True
                Else GoUpBak = False
                End If
            Else GoUpBak = False
            End If

            If CWTrue And PWTrue = True Then 'Check If Directory Exists & Selects.
                '-Copy & Paste Directory Code (BETA)
                If GoUpBak = True Then
                    Dim BakDirInfo As New DirectoryInfo(BW_TextBox.Text)

                    For Each GetFolders In PasDirInfo.GetFiles()
                        GetFolders.CopyTo(Path.Combine(BakDirInfo.FullName, GetFolders.Name), True)
                    Next

                    For Each SubDir In PasDirInfo.GetDirectories()
                        My.Computer.FileSystem.CopyDirectory(SubDir.FullName, Path.Combine(BakDirInfo.FullName, SubDir.Name), True)
                    Next
                End If

                If Rini("DelDirEnabled") = "True" Then
                    Try
                        My.Computer.FileSystem.DeleteDirectory(PasDirInfo.FullName, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.CreateDirectory(PasDirInfo.FullName)
                    Catch ex As IOException
                    End Try
                End If

                If Rini("WeAreTheChampions") = "True" Then
                    For Each GetFiles In PasDirInfo.GetFiles()
                        If File.Exists(Path.Combine(CopyDirInfo.FullName, GetFiles.Name)) = False Then
                            If GetFiles.IsReadOnly = False Then
                                If Not GetFiles.FullName.Contains(".git") Then
                                    If Not GetFiles.Name = "README.md" Then
                                        If Not GetFiles.Name = ".gitattributes" Then
                                            If Not GetFiles.Name.Contains(".sln") Then
                                                If Not GetFiles.Name = ".gitignore" Then File.Delete(GetFiles.FullName)
                                            End If
                                        End If
                                    End If
                                    End If
                            End If
                        End If
                    Next

                    For Each SubDir In PasDirInfo.GetDirectories()
                        If My.Computer.FileSystem.DirectoryExists(Path.Combine(CopyDirInfo.FullName, SubDir.Name)) = False Then
                            If Not (SubDir.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                                If Not SubDir.FullName.Contains(".git") Then My.Computer.FileSystem.DeleteDirectory(SubDir.FullName, FileIO.DeleteDirectoryOption.DeleteAllContents)
                            End If
                        End If
                    Next
                End If

                For Each GetFiles In CopyDirInfo.GetFiles()
                    GetFiles.CopyTo(Path.Combine(PasDirInfo.FullName, GetFiles.Name), True)
                Next

                For Each SubDir In CopyDirInfo.GetDirectories()
                        My.Computer.FileSystem.CopyDirectory(SubDir.FullName, Path.Combine(PasDirInfo.FullName, SubDir.Name), True)
                    Next

                    MessageBox.Show("Copied & Pasted Repos Folder!" & vbNewLine & "LET'S GO TO THE GIT AND PUSH THE REPOSITORY!",
    Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                If Rini("AutoExitEnabled") = "True" Then Application.Exit()

            Else
                    MessageBox.Show("Error - You should select Folder Path!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                If OpenGITCheckBox.Checked = True Then 'Open Git Program!
                    If GITTrue = True Then
                        '-Process "Git Program"
                        Process.Start(GITPathTextBox.Text)
                    Else
                        MessageBox.Show("Error! - No such Git Program. Did you select the GIT path properly?", Me.Text,
    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            Catch ex As Exception
            MessageBox.Show("Error - " & ex.Message & vbNewLine & "Error Message: " & ex.StackTrace, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CLogButton_Click(sender As Object, e As EventArgs) Handles CLogButton.Click
        CommitLog.Show()
    End Sub

    Private Sub OpenGITCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles OpenGITCheckBox.CheckedChanged
        If OpenGITCheckBox.Checked = True Then
            GITPathTextBox.Visible = True
            GITPathButton.Visible = True
        Else
            GITPathTextBox.Visible = False
            GITPathButton.Visible = False
            GITTrue = False
        End If
    End Sub

    Private Sub GITPathButton_Click(sender As Object, e As EventArgs) Handles GITPathButton.Click
        ofd_path.Title = "Select GIT Program Path"
        If ofd_path.ShowDialog() = DialogResult.OK Then
            GITPathTextBox.Text = ofd_path.FileName
            GITTrue = True
        End If
    End Sub

    Private Sub CPFileButton_Click(sender As Object, e As EventArgs) Handles CPFileButton.Click
        CPFile.Show()
    End Sub

    Private Sub GazuaTCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles GazuaTCheckBox.CheckedChanged
        If GazuaTCheckBox.Checked = False Then
            Wini("GTwEnabled", "False")
            SaveButton.Enabled = True
            GazuaButton.Text = "Ctrl + C/V"
        End If
    End Sub

    Private Sub EDITCModeButton_Click(sender As Object, e As EventArgs) Handles EDITCModeButton.Click
        CMode.Show()
    End Sub

    Private Sub VerText_Click(sender As Object, e As EventArgs) Handles VerText.DoubleClick
        MessageBox.Show("Workspace Git V" & My.Application.Info.Version.ToString & ": The Final Version." & vbNewLine &
                        "Support Only For Developers.", Me.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BakCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BakCheckBox.CheckedChanged
        If BakCheckBox.Checked = True Then
            BW_TextBox.Visible = True
            BakButton.Visible = True
        Else
            BW_TextBox.Visible = False
            BakButton.Visible = False
            BakTrue = False
        End If
    End Sub

    Private Sub BakButton_Click(sender As Object, e As EventArgs) Handles BakButton.Click
        If Not Rini("BWPath") = "N/A" Then
            fbd_path.SelectedPath = Rini("BWPath")
        End If

        fbd_path.Description = "Select to your Backup Folder"
        If fbd_path.ShowDialog = DialogResult.OK Then
            BW_TextBox.Text = fbd_path.SelectedPath
            BakTrue = True
        End If
    End Sub

    Private Sub DelDirButton_Click(sender As Object, e As EventArgs) Handles DelDirButton.Click
        If PWTrue = True Then
            Process.Start("explorer.exe", PW_TextBox.Text)
        Else
            MessageBox.Show("You have to select Workspace Folder first!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub WeRCheckBox_MouseHover(sender As Object, e As EventArgs) Handles WeRCheckBox.MouseHover
        WeRLabel.Visible = True
    End Sub

    Private Sub WeRCheckBox_MouseLeave(sender As Object, e As EventArgs) Handles WeRCheckBox.MouseLeave
        WeRLabel.Visible = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub
End Class
