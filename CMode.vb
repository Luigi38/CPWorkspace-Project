Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Xml

Module modX
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
        Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String,
        ByVal lpKeyName As String, ByVal lpString As String,
        ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
        Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String,
        ByVal lpKeyName As String, ByVal lpDefault As String,
        ByVal lpReturnedString As String, ByVal nSize As Int32,
        ByVal lpFileName As String) As Int32

    ''' <summary>
    ''' Helping Code with easily and simply from Writeini().
    ''' </summary>
    Public Sub WX(ByVal PName As String, ByVal PValue As String)
        Dim iniFile As String = Application.StartupPath + "\XMLinfo.ini"
        Dim sec As String = "XML_info"

        Dim Result As Integer = WritePrivateProfileString(sec, PName, PValue, iniFile)
    End Sub

    ''' <summary>
    ''' Helping Code with easily and simply from Readini().
    ''' </summary>
    Public Function RX(ByVal PName As String) As String
        Dim iniFile As String = Application.StartupPath + "\XMLinfo.ini"
        Dim sec As String = "XML_info"

        Dim ParamVal As String = Space$(1024)
        Dim LenParamVal As Long = GetPrivateProfileString(sec, PName, "", ParamVal, Len(ParamVal), iniFile)
        RX = Left$(ParamVal, LenParamVal)
    End Function
End Module

Public Class CMode
    Dim ItmCnt As Integer
    Dim OMbool As Boolean
    Dim LOMbool As Boolean
    Dim CFext As String
    Dim OMstr() As String

    Private Sub CMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ItemName.Text = "My Amazing Item!"
            CW_TextBox.Text = "Select your Workspace Folder"
            PW_TextBox.Text = "Select your Repos Folder"
            CF_TextBox.Text = "Select To Copy File"
            PF_TextBox.Text = "Select To Paste File"
            CLogPath_TextBox.Text = "Select Your Commit Log File"

            If File.Exists(Application.StartupPath & "\CItem.xml") = True Then
                Dim xml = XDocument.Load(Application.StartupPath & "\CItem.xml")

                ItmCnt = Cntstr(File.ReadAllText(Application.StartupPath & "\CItem.xml"), "<Item_>") / 2 '아이템 인덱스 수 가져오기.

                ItemName.Text = xml.<CMode_Items>.<Item_>.<Name>.Value
                CW_TextBox.Text = xml.<CMode_Items>.<Item_>.<CWPath>.Value
                PW_TextBox.Text = xml.<CMode_Items>.<Item_>.<PWPath>.Value
                CF_TextBox.Text = xml.<CMode_Items>.<Item_>.<CFPath>.Value
                PF_TextBox.Text = xml.<CMode_Items>.<Item_>.<PFPath>.Value
                CLogPath_TextBox.Text = xml.<CMode_Items>.<Item_>.<CLPath>.Value

                Dim q As Integer = 3
                For i As Integer = 0 To ItmCnt - 1 'q를 이용해 수학연칙을 이용한 각 아이템 이름 가져오기
                    Dim itm As New ListViewItem(File.ReadAllLines(Application.StartupPath & "\CItem.xml")(q).Replace("<Name>", "").Replace("</Name>", "").Trim())
                    CMode_ListView.Items.Add(itm)
                    q = q + 8
                Next
            End If

        Catch ex As Exception
            MessageBox.Show("Error! - " & ex.Message & vbNewLine & ex.StackTrace, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            CMode_ListView.Items.Add("Item_" & CMode_ListView.Items.Count)
            ItemName.Text = "My Amazing Item!"
            CW_TextBox.Text = "Select your Workspace Folder"
            PW_TextBox.Text = "Select your Repos Folder"
            CF_TextBox.Text = "Select To Copy File"
            PF_TextBox.Text = "Select To Paste File"
            CLogPath_TextBox.Text = "Select Your Commit Log File"

        Catch ex As Exception
            MessageBox.Show("Error! - " & ex.Message & vbNewLine & ex.StackTrace, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click
        Try
            CMode_ListView.Items.Remove(CMode_ListView.SelectedItems.Item(0))
            ItemName.Text = "My Amazing Item!"
            CW_TextBox.Text = "Select your Workspace Folder"
            PW_TextBox.Text = "Select your Repos Folder"
            CF_TextBox.Text = "Select To Copy File"
            PF_TextBox.Text = "Select To Paste File"
            CLogPath_TextBox.Text = "Select Your Commit Log File"

        Catch ex As Exception
            MessageBox.Show("Error! - " & ex.Message & vbNewLine & ex.StackTrace, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' String의 수를 세줍니다. 결과는 Integer.
    ''' </summary>
    Public Function Cntstr(ByVal inputString As String, ByVal pattern As String) As Integer
        Return Regex.Split(inputString, pattern).Length - 1
    End Function

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim sets As XmlWriterSettings = New XmlWriterSettings()
            sets.Indent = True

            Using writer As XmlWriter = XmlWriter.Create(Application.StartupPath & "\CItem.xml", sets)
                writer.WriteStartDocument()
                writer.WriteStartElement("CMode_Items")

                If CMode_ListView.Items.Count > 1 Then
                    For i As Integer = 0 To CMode_ListView.Items.Count - 1
                        CMode_ListView.Items.Item(i).Text = RX("Name_" & i)
                        writer.WriteStartElement("Item_")
                        writer.WriteElementString("Name", RX("Name_" & i))
                        writer.WriteElementString("CWPath", RX("CWPath_" & i))
                        writer.WriteElementString("PWPath", RX("PWPath_" & i))
                        writer.WriteElementString("CFPath", RX("CFPath_" & i))
                        writer.WriteElementString("PFPath", RX("PFPath_" & i))
                        writer.WriteElementString("CLPath", RX("CLPath_" & i))
                        writer.WriteEndElement()
                    Next

                    writer.WriteEndElement()
                    writer.WriteEndDocument()
                    File.Delete(Application.StartupPath & "\XMLinfo.ini")

                    MessageBox.Show("Custom Mode Saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf CMode_ListView.Items.Count = 1 Then
                    writer.WriteStartElement("Item_")
                    writer.WriteElementString("Name", ItemName.Text)
                    writer.WriteElementString("CWPath", CW_TextBox.Text)
                    writer.WriteElementString("PWPath", PW_TextBox.Text)
                    writer.WriteElementString("CFPath", CF_TextBox.Text)
                    writer.WriteElementString("PFPath", PF_TextBox.Text)
                    writer.WriteElementString("CLPath", CLogPath_TextBox.Text)
                    writer.WriteEndElement()
                    writer.WriteEndElement()
                    writer.WriteEndDocument()
                    MessageBox.Show("Custom Mode Saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf CMode_ListView.Items.Count < 1 Then
                    MessageBox.Show("Error! - You didn't add any Items.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error! - " & ex.Message & vbNewLine & ex.StackTrace, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SelButton1_Click(sender As Object, e As EventArgs) Handles SelButton1.Click
        If Not Rini("CWPath") = "N/A" Then
            fbd_path.SelectedPath = Rini("CWPath")
        End If
        fbd_path.Description = "Select your Workspace Folder"
        If fbd_path.ShowDialog = DialogResult.OK Then
            CW_TextBox.Text = fbd_path.SelectedPath
        End If
    End Sub

    Private Sub SelButton2_Click(sender As Object, e As EventArgs) Handles SelButton2.Click
        If Not Rini("PWPath") = "N/A" Then
            fbd_path.SelectedPath = Rini("PWPath")
        End If
        fbd_path.Description = "Select your Repos Folder"
        If fbd_path.ShowDialog = DialogResult.OK Then
            PW_TextBox.Text = fbd_path.SelectedPath
        End If
    End Sub

    Private Sub SelButton3_Click(sender As Object, e As EventArgs) Handles SelButton3.Click
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
                OMbool = True
                OMstr = ofd_path.FileNames
            End If
            If LOMbool = True Then LOMbool = False
        End If
    End Sub

    Private Sub SelButton4_Click(sender As Object, e As EventArgs) Handles SelButton4.Click
        If OMbool = True Then
            fbd_path.Description = "Select your Folder"
            If fbd_path.ShowDialog = DialogResult.OK Then
                PF_TextBox.Text = fbd_path.SelectedPath
            End If
        Else
            sfd_path.Filter = CFext.Replace(".", "").ToUpper + " File|*" + CFext
            If sfd_path.ShowDialog = DialogResult.OK Then
                PF_TextBox.Text = sfd_path.FileName
            End If
        End If
    End Sub

    Private Sub SelButton5_Click(sender As Object, e As EventArgs) Handles SelButton5.Click
        ofd_path.Title = "Select Your Commit Log File"
        If ofd_path.ShowDialog() = DialogResult.OK Then
            CLogPath_TextBox.Text = ofd_path.FileName
        End If
    End Sub

    Private Sub CMode_ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMode_ListView.SelectedIndexChanged
        Try
            Dim i As Integer = CMode_ListView.SelectedIndices(0)
            Dim q As Integer = 3

            If CMode_ListView.Items.Count > 1 Then
                WX("Name_" & i + 1, ItemName.Text)
                WX("CWPath_" & i + 1, CW_TextBox.Text)
                WX("PWPath_" & i + 1, PW_TextBox.Text)
                WX("CFPath_" & i + 1, CF_TextBox.Text)
                WX("PFPath_" & i + 1, PF_TextBox.Text)
                WX("CLPath_" & i + 1, CLogPath_TextBox.Text)
            End If

            If File.Exists(Application.StartupPath & "\CItem.xml") Then
                Dim xml = XDocument.Load(Application.StartupPath & "\CItem.xml")
                If Not i = 0 Then
                    q = q + 8 * i
                    Dim itmN As String = File.ReadAllLines(Application.StartupPath & "\CItem.xml")(q).Replace("<Name>", "").Replace("</Name>", "").Trim()
                    Dim itmCW As String = File.ReadAllLines(Application.StartupPath & "\CItem.xml")(q + 1).Replace("<CWPath>", "").Trim().Replace("</CWPath>", "").Trim()
                    itmCW.Replace("</CWPath>", "").Trim()
                    Dim itmPW As String = File.ReadAllLines(Application.StartupPath & "\CItem.xml")(q + 2).Replace("<PWPath>", "").Trim().Replace("</PWPath>", "").Trim()
                    itmPW.Replace("</PWPath>", "").Trim()
                    Dim itmCF As String = File.ReadAllLines(Application.StartupPath & "\CItem.xml")(q + 3).Replace("<CFPath>", "").Trim().Replace("</CFPath>", "").Trim()
                    itmCF.Replace("</CFPath>", "").Trim()
                    Dim itmPF As String = File.ReadAllLines(Application.StartupPath & "\CItem.xml")(q + 4).Replace("<PFPath>", "").Trim().Replace("</PFPath>", "").Trim()
                    itmPF.Replace("</PFPath>", "").Trim()
                    Dim itmCL As String = File.ReadAllLines(Application.StartupPath & "\CItem.xml")(q + 5).Replace("<CLPath>", "").Trim().Replace("</CLPath>", "").Trim()
                    itmCL.Replace("</CLPath>", "").Trim()

                    ItemName.Text = itmN
                    CW_TextBox.Text = itmCW
                    PW_TextBox.Text = itmPW
                    CF_TextBox.Text = itmCF
                    PF_TextBox.Text = itmPF
                    CLogPath_TextBox.Text = itmCL
                Else
                    q = 3
                    Dim itmN As String = File.ReadAllLines(Application.StartupPath & "\CItem.xml")(q).Replace("<Name>", "").Trim().Replace("</Name>", "").Trim()
                    Dim itmCW As String = File.ReadAllLines(Application.StartupPath & "\CItem.xml")(q + 1).Replace("<CWPath>", "").Trim().Replace("</CWPath>", "").Trim()
                    Dim itmPW As String = File.ReadAllLines(Application.StartupPath & "\CItem.xml")(q + 2).Replace("<PWPath>", "").Trim().Replace("</PWPath>", "").Trim()
                    Dim itmCF As String = File.ReadAllLines(Application.StartupPath & "\CItem.xml")(q + 3).Replace("<CFPath>", "").Trim().Replace("</CFPath>", "").Trim()
                    Dim itmPF As String = File.ReadAllLines(Application.StartupPath & "\CItem.xml")(q + 4).Replace("<PFPath>", "").Trim().Replace("</PFPath>", "").Trim()
                    Dim itmCL As String = File.ReadAllLines(Application.StartupPath & "\CItem.xml")(q + 5).Replace("<CLPath>", "").Trim().Replace("</CLPath>", "").Trim()

                    ItemName.Text = itmN
                    CW_TextBox.Text = itmCW
                    PW_TextBox.Text = itmPW
                    CF_TextBox.Text = itmCF
                    PF_TextBox.Text = itmPF
                    CLogPath_TextBox.Text = itmCL
                End If
            End If

        Catch ex_arg As ArgumentOutOfRangeException
            ItemName.Text = "My Amazing Item!"
            CW_TextBox.Text = "Select your Workspace Folder"
            PW_TextBox.Text = "Select your Repos Folder"
            CF_TextBox.Text = "Select To Copy File"
            PF_TextBox.Text = "Select To Paste File"
            CLogPath_TextBox.Text = "Select Your Commit Log File"

        Catch ex_ind As IndexOutOfRangeException
            CW_TextBox.Text = "Select your Workspace Folder"
            PW_TextBox.Text = "Select your Repos Folder"
            CF_TextBox.Text = "Select To Copy File"
            PF_TextBox.Text = "Select To Paste File"
            CLogPath_TextBox.Text = "Select Your Commit Log File"
        End Try
    End Sub
End Class