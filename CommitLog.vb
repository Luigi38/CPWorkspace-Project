Imports System.IO
Imports System.Text.Encoding
Public Class CommitLog
    Dim fs As FileStream
    Private Sub CommitLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CLogPathTextBox.Text = "Select Your Commit Log File"
            CLogText.Text = "If you select your Commit Log File, I'll show you about Commit Log File's Description! :D"

            If Rini("CLPath") = "N/A" Then
                If MessageBox.Show("You didn't create Commit Log. Would you like to create it?", Me.Text,
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                    sfd1.Title = "Creating Commit Log File ..."
                    If sfd1.ShowDialog() = DialogResult.OK Then
                        fs = File.Create(sfd1.FileName)
                        fs.Close()
                        Wini("CLPath", sfd1.FileName)
                        CLogPathTextBox.Text = sfd1.FileName
                        CLogText.Text = "Now, you can write and save the Commit Log! :D"
                        MessageBox.Show("Created Commit Log File!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                ElseIf DialogResult.Cancel Then
                    Me.Hide()
                End If
            Else CLogPathTextBox.Text = Rini("CLPath")
            End If

            If File.Exists(CLogPathTextBox.Text) Then
                CLogText.Text = File.ReadAllText(CLogPathTextBox.Text)
            End If

        Catch ex As Exception
            MessageBox.Show("Error! - " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CLogPathButton_Click(sender As Object, e As EventArgs) Handles CLogPathButton.Click
        ofd1.Title = "Select Your Commit Log File"
        If ofd1.ShowDialog() = DialogResult.OK Then
            Wini("CLPath", ofd1.FileName)
            CLogPathTextBox.Text = ofd1.FileName
            CLogText.Text = File.ReadAllText(CLogPathTextBox.Text)
        End If
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        sfd1.Title = "Creating Commit Log File ..."
        If sfd1.ShowDialog() = DialogResult.OK Then
            fs = File.Create(sfd1.FileName)
            fs.Close()
            Wini("CLPath", sfd1.FileName)
            CLogPathTextBox.Text = sfd1.FileName
            CLogText.Text = "Now, you can write and save the Commit Log! :D"
            MessageBox.Show("Created Commit Log File!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If MessageBox.Show("Are you sure about Delete Commit Log File?", Me.Text,
MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            File.Delete(CLogPathTextBox.Text)
            Wini("CLPath", "N\A")
            CLogPathTextBox.Text = "Select Your Commit Log File"
            CLogText.Text = "If you select your Commit Log File, I'll show you about Commit Log File's Description! :D"
            MessageBox.Show("Deleted Commit Log File!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        CLogText.Text = Nothing
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If CLogText.Text = "/def /path" Then
                If MessageBox.Show("Are you sure about Setting Path to Default (N/A)?", Me.Text,
MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Wini("CLPath", "N\A")
                    CLogPathTextBox.Text = "Select Your Commit Log File"
                    CLogText.Text = "If you select your Commit Log File, I'll show you about Commit Log File's Description! :D"
                    MessageBox.Show("Set Path to Default!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else GoTo CreatingCLPathLine
                End If
            Else
CreatingCLPathLine:
                If CLogText.Text = "/reset /text" Then
                    If MessageBox.Show("Are you sure about Reseting Text?", Me.Text,
MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        File.WriteAllText(CLogPathTextBox.Text, "", UTF8)
                        CLogText.Text = "If you select your Commit Log File, I'll show you about Commit Log File's Description! :D"
                        MessageBox.Show("Reseted Text!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

                If Rini("CLPath") = "N/A" Then
                    If MessageBox.Show("You didn't create Commit Log. Would you like to create it?", Me.Text,
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                        sfd1.Title = "Creating & Saving Commit Log File ..."
                        If sfd1.ShowDialog() = DialogResult.OK Then
                            File.WriteAllText(sfd1.FileName, CLogText.Text)
                            Wini("CLPath", sfd1.FileName)
                            CLogPathTextBox.Text = sfd1.FileName
                            MessageBox.Show("Created Commit Log File!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    ElseIf DialogResult.Cancel Then
                        Me.Hide()
                    End If
                Else

                    File.WriteAllText(CLogPathTextBox.Text, CLogText.Text)
                    MessageBox.Show("Saved Commit Log File!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error! - " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class