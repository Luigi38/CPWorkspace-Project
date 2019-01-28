Public Class MainProject
    Dim CuStr() As String 'Items of Custom Mode.
    Dim CWTrue As Boolean
    Dim VCWTrue As Boolean
    Private Sub MainProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CM_ComboBox.Items.Item(0).ToString 'Output: Hello, World!
        CWTrue = False
        VCWTrue = False

        CM_ComboBox.Items.Add("Hello, World!")
        If CM_CheckBox.Checked = True Then
            If CM_ComboBox.Items.Item(0).ToString = "Hello, World!" Then
            End If
        End If
        CW_TextBox.Text = "Select your Workspace"
        VCW_TextBox.Text = "Select your Repos Folder"
    End Sub

    Private Sub CW_Button_Click(sender As Object, e As EventArgs) Handles CW_Button.Click
        fbd_path.Description = "Select your Workspace Folder"
        If fbd_path.ShowDialog = DialogResult.OK Then
            CW_TextBox.Text = fbd_path.SelectedPath
        End If
    End Sub
End Class
