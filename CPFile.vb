Imports System.IO
Imports System.Text.RegularExpressions

Public Class CPFile
    Dim iniFile As String = Application.StartupPath + "\settings.ini"
    Dim sec As String = "CPW_Path"

    Dim CuStr(2) As String 'Items of Custom Mode.
    Dim CMInt As Integer '(0 = Not Enabled, 1 = Enabled)
    Dim OMbool As Boolean
    Dim OMstr() As String
    Dim LOMbool As Boolean
    Dim CFTrue As Boolean
    Dim CFext As String
    Dim PFTrue As Boolean
    Private Sub CPFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOMbool = False
        OMbool = False
        CFTrue = False
        PFTrue = False

        CF_TextBox.Text = "Select To Copy File"
        PF_TextBox.Text = "Select To Paste File"

        If Not Rini("CFPath") = "N/A" Then 'Reading "To Copy File" Path
            If Regex.IsMatch(Rini("CFPath"), "(Multi Files)") = True Then
                CF_TextBox.Text = Rini("CFPath")
                LOMbool = True
            Else
                CF_TextBox.Text = Rini("CFPath")
                CFTrue = True
            End If
        End If

        If Not Rini("PFPath") = "N/A" Then 'Reading "To Paste File" Path
            PF_TextBox.Text = Rini("PFPath")
            PFTrue = True
        End If

        If Rini("CModeEnabled") = "True" Then 'Custom Mode Enabled
            CM_CheckBox.Checked = True
        Else
            CM_CheckBox.Checked = False
        End If

        If Rini("GTwEnabled") = "True" Then 'Save SETTINGS! + Ctrl + C/V
            SaveButton.Enabled = False
            GazuaButton.Text = "Save SETTINGS!" & vbNewLine & "Ctrl + C/V"
        End If

        If LOMbool = True Then 'Checking about Loading One More Boolean
            If PF_TextBox.Text = "Select To Paste File" Then PF_TextBox.Text = "Select To Paste Folder"
            PF_Info.Text = "To Paste Folder (ex: Project\Ctrl_V)"
                OMbool = True
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

    Private Sub CW_Button_Click(sender As Object, e As EventArgs) Handles CF_Button.Click
        ofd_path.Title = "Select your Files"
        If ofd_path.ShowDialog = DialogResult.OK Then
            If ofd_path.FileNames.Count - 1 < 1 Then
                CF_TextBox.Text = ofd_path.FileNames(0)
                CFext = Path.GetExtension(ofd_path.FileNames(0))
                OMbool = False
                If Not OMstr Is Nothing Then OMstr = Nothing
            Else
                CF_TextBox.Text = Path.GetDirectoryName(ofd_path.FileNames(0)) + "\(Multi Files)"
                If PF_TextBox.Text = "Select To Paste File" Then
                    PF_TextBox.Text = "Select To Paste Folder"
                End If
                PF_Info.Text = "To Paste Folder (ex: Project\Ctrl_V)"
                OMbool = True
                OMstr = ofd_path.FileNames
            End If
            CFTrue = True
            If LOMbool = True Then LOMbool = False
        End If
    End Sub

    Private Sub PF_Button_Click(sender As Object, e As EventArgs) Handles PF_Button.Click
        If OMbool = True Then
            fbd_path.Description = "Select your Folder"
            If fbd_path.ShowDialog = DialogResult.OK Then
                PF_TextBox.Text = fbd_path.SelectedPath
                PFTrue = True
            End If
        Else
            sfd_path.Filter = CFext.Replace(".", "").ToUpper + " File|*" + CFext
            If sfd_path.ShowDialog = DialogResult.OK Then
                PF_TextBox.Text = sfd_path.FileName
                PFTrue = True
            End If
        End If
    End Sub

    Private Sub CM_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CM_CheckBox.CheckedChanged
        If CM_CheckBox.Checked = True Then
            CMInt = 1 'Check Value
            CM_ComboBox.Enabled = True
        Else
            If CMInt = 1 Then
                CM_ComboBox.Enabled = False
                CMInt = 0
            End If
        End If
    End Sub

    Private Sub GazuaButton_Click(sender As Object, e As EventArgs) Handles GazuaButton.Click
        If MainProject.GazuaTCheckBox.Checked = True Then
            SaveButton_Click(Nothing, Nothing)
            GoTo GazuaLine
        Else
GazuaLine:
            If CFTrue And PFTrue = True Then
                If LOMbool = True Then
                    MessageBox.Show("Select the To Copy File again.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    If ofd_path.ShowDialog() = DialogResult.OK Then
                        If ofd_path.FileNames.Count < 1 Then
                            CF_TextBox.Text = ofd_path.FileNames(0)
                            If OMbool = True Then OMbool = False
                            If Not OMstr Is Nothing Then OMstr = Nothing
                        Else
                            CF_TextBox.Text = Path.GetDirectoryName(ofd_path.FileNames(0)) + "\(Multi Files)"
                            If PF_TextBox.Text = "Select To Paste File" Then
                                PF_TextBox.Text = "Select To Paste Folder"
                            End If
                            PF_Info.Text = "To Paste Folder (ex: Project\Ctrl_V)"
                            OMbool = True
                            OMstr = ofd_path.FileNames
                        End If
                        CFTrue = True
                    End If
                Else
                    If OMbool = True Then
                        For i As Integer = 0 To OMstr.Length - 1 'Copy Multi Files.
                            Dim f As New FileInfo(OMstr(i))
                            Dim fD As String = Path.Combine(PF_TextBox.Text, f.Name)

                            If Not File.Exists(fD) Then
                                f.CopyTo(fD, True)
                            End If
                            File.Copy(f.FullName, fD, True)
                        Next
                    Else
                        If Path.GetFileName(CF_TextBox.Text) = Path.GetFileName(PF_TextBox.Text) Then
                            Dim f As New FileInfo(CF_TextBox.Text) 'Copy File.
                            Dim fD As String = Path.Combine(Path.GetDirectoryName(PF_TextBox.Text), f.Name)

                            If Not File.Exists(fD) Then
                                f.CopyTo(fD, True)
                            End If
                            File.Copy(f.FullName, fD, True)
                        Else
                            Dim fC As New FileInfo(CF_TextBox.Text)
                            Dim fP As New FileInfo(PF_TextBox.Text) 'Copy File.

                            If Not File.Exists(fP.FullName) Then
                                fC.CopyTo(fP.FullName, True)
                            End If
                            File.Copy(fC.FullName, fP.FullName, True)
                        End If
                    End If
                End If
                MessageBox.Show("Copied & Pasted The Files sucessfully!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error - You should select File Path!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If Not CF_TextBox.Text = "Select To Copy File" Then
                Wini("CFPath", CF_TextBox.Text)
            Else
                Wini("CFPath", "N/A")
            End If

            If CF_TextBox.Text = "/def" Then
                Wini("CFPath", "N/A")
                CF_TextBox.Text = "Select To Copy File"
                OMbool = False
                OMstr = Nothing
            End If

            If Not PF_TextBox.Text = "Select To Paste File" Then
                Wini("PFPath", PF_TextBox.Text)
            Else
                Wini("PFPath", "N/A")
            End If

            If PF_TextBox.Text = "/def" Then
                Wini("PFPath", "N/A")
                PF_TextBox.Text = "Select To Paste File"
                OMbool = False
                OMstr = Nothing
            End If

            MessageBox.Show("Saved Settings!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error! - " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class