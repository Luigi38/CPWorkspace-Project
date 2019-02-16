<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainProject
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainProject))
        Me.CW_Button = New System.Windows.Forms.Button()
        Me.CW_TextBox = New System.Windows.Forms.TextBox()
        Me.CM_CheckBox = New System.Windows.Forms.CheckBox()
        Me.PW_TextBox = New System.Windows.Forms.TextBox()
        Me.PW_Button = New System.Windows.Forms.Button()
        Me.CM_ComboBox = New System.Windows.Forms.ComboBox()
        Me.fbd_path = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CW_Info = New System.Windows.Forms.Label()
        Me.VCW_Info = New System.Windows.Forms.Label()
        Me.GazuaButton = New System.Windows.Forms.Button()
        Me.GazuaTCheckBox = New System.Windows.Forms.CheckBox()
        Me.CLogButton = New System.Windows.Forms.Button()
        Me.EDITCModeButton = New System.Windows.Forms.Button()
        Me.OpenGITCheckBox = New System.Windows.Forms.CheckBox()
        Me.GITPathTextBox = New System.Windows.Forms.TextBox()
        Me.GITPathButton = New System.Windows.Forms.Button()
        Me.ofd_path = New System.Windows.Forms.OpenFileDialog()
        Me.VerText = New System.Windows.Forms.Label()
        Me.InfoText1 = New System.Windows.Forms.Label()
        Me.CPFileButton = New System.Windows.Forms.Button()
        Me.CPW_Icon = New System.Windows.Forms.PictureBox()
        CType(Me.CPW_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CW_Button
        '
        Me.CW_Button.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CW_Button.Location = New System.Drawing.Point(341, 33)
        Me.CW_Button.Name = "CW_Button"
        Me.CW_Button.Size = New System.Drawing.Size(103, 26)
        Me.CW_Button.TabIndex = 0
        Me.CW_Button.Text = "Select Path"
        Me.CW_Button.UseVisualStyleBackColor = True
        '
        'CW_TextBox
        '
        Me.CW_TextBox.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CW_TextBox.Location = New System.Drawing.Point(39, 33)
        Me.CW_TextBox.Name = "CW_TextBox"
        Me.CW_TextBox.Size = New System.Drawing.Size(284, 26)
        Me.CW_TextBox.TabIndex = 1
        Me.CW_TextBox.Text = "CWorkspace"
        '
        'CM_CheckBox
        '
        Me.CM_CheckBox.AutoSize = True
        Me.CM_CheckBox.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CM_CheckBox.Location = New System.Drawing.Point(39, 193)
        Me.CM_CheckBox.Name = "CM_CheckBox"
        Me.CM_CheckBox.Size = New System.Drawing.Size(156, 21)
        Me.CM_CheckBox.TabIndex = 3
        Me.CM_CheckBox.Text = "Enable Custom Mode"
        Me.CM_CheckBox.UseVisualStyleBackColor = True
        '
        'PW_TextBox
        '
        Me.PW_TextBox.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PW_TextBox.Location = New System.Drawing.Point(39, 89)
        Me.PW_TextBox.Name = "PW_TextBox"
        Me.PW_TextBox.Size = New System.Drawing.Size(284, 26)
        Me.PW_TextBox.TabIndex = 5
        Me.PW_TextBox.Text = "PWorkspace"
        '
        'PW_Button
        '
        Me.PW_Button.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PW_Button.Location = New System.Drawing.Point(341, 89)
        Me.PW_Button.Name = "PW_Button"
        Me.PW_Button.Size = New System.Drawing.Size(103, 26)
        Me.PW_Button.TabIndex = 4
        Me.PW_Button.Text = "Select Path"
        Me.PW_Button.UseVisualStyleBackColor = True
        '
        'CM_ComboBox
        '
        Me.CM_ComboBox.Enabled = False
        Me.CM_ComboBox.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CM_ComboBox.FormattingEnabled = True
        Me.CM_ComboBox.Location = New System.Drawing.Point(39, 162)
        Me.CM_ComboBox.Name = "CM_ComboBox"
        Me.CM_ComboBox.Size = New System.Drawing.Size(184, 25)
        Me.CM_ComboBox.TabIndex = 8
        Me.CM_ComboBox.Text = "CustomMode_Item"
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(246, 126)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(116, 67)
        Me.SaveButton.TabIndex = 9
        Me.SaveButton.Text = "Save SETTINGS!"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CW_Info
        '
        Me.CW_Info.AutoSize = True
        Me.CW_Info.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CW_Info.Location = New System.Drawing.Point(46, 13)
        Me.CW_Info.Name = "CW_Info"
        Me.CW_Info.Size = New System.Drawing.Size(221, 17)
        Me.CW_Info.TabIndex = 10
        Me.CW_Info.Text = "To Copy Folder (ex: Project\Ctrl_C)"
        '
        'VCW_Info
        '
        Me.VCW_Info.AutoSize = True
        Me.VCW_Info.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VCW_Info.Location = New System.Drawing.Point(46, 69)
        Me.VCW_Info.Name = "VCW_Info"
        Me.VCW_Info.Size = New System.Drawing.Size(224, 17)
        Me.VCW_Info.TabIndex = 11
        Me.VCW_Info.Text = "To Paste Folder (ex: Project\Ctrl_V)"
        '
        'GazuaButton
        '
        Me.GazuaButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GazuaButton.Location = New System.Drawing.Point(474, 98)
        Me.GazuaButton.Name = "GazuaButton"
        Me.GazuaButton.Size = New System.Drawing.Size(159, 64)
        Me.GazuaButton.TabIndex = 12
        Me.GazuaButton.Text = "Ctrl + C/V"
        Me.GazuaButton.UseVisualStyleBackColor = True
        '
        'GazuaTCheckBox
        '
        Me.GazuaTCheckBox.AutoSize = True
        Me.GazuaTCheckBox.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GazuaTCheckBox.Location = New System.Drawing.Point(12, 297)
        Me.GazuaTCheckBox.Name = "GazuaTCheckBox"
        Me.GazuaTCheckBox.Size = New System.Drawing.Size(183, 21)
        Me.GazuaTCheckBox.TabIndex = 13
        Me.GazuaTCheckBox.Text = "Save Settings + Ctrl + C/V"
        Me.GazuaTCheckBox.UseVisualStyleBackColor = True
        '
        'CLogButton
        '
        Me.CLogButton.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLogButton.Location = New System.Drawing.Point(507, 8)
        Me.CLogButton.Name = "CLogButton"
        Me.CLogButton.Size = New System.Drawing.Size(126, 27)
        Me.CLogButton.TabIndex = 14
        Me.CLogButton.Text = "Commit Log"
        Me.CLogButton.UseVisualStyleBackColor = True
        '
        'EDITCModeButton
        '
        Me.EDITCModeButton.Enabled = False
        Me.EDITCModeButton.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDITCModeButton.Location = New System.Drawing.Point(507, 45)
        Me.EDITCModeButton.Name = "EDITCModeButton"
        Me.EDITCModeButton.Size = New System.Drawing.Size(126, 47)
        Me.EDITCModeButton.TabIndex = 15
        Me.EDITCModeButton.Text = "Edit Custom Mode"
        Me.EDITCModeButton.UseVisualStyleBackColor = True
        '
        'OpenGITCheckBox
        '
        Me.OpenGITCheckBox.AutoSize = True
        Me.OpenGITCheckBox.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenGITCheckBox.Location = New System.Drawing.Point(12, 270)
        Me.OpenGITCheckBox.Name = "OpenGITCheckBox"
        Me.OpenGITCheckBox.Size = New System.Drawing.Size(191, 21)
        Me.OpenGITCheckBox.TabIndex = 16
        Me.OpenGITCheckBox.Text = "Open GIT After ""Ctrl + C/V"""
        Me.OpenGITCheckBox.UseVisualStyleBackColor = True
        '
        'GITPathTextBox
        '
        Me.GITPathTextBox.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GITPathTextBox.Location = New System.Drawing.Point(12, 238)
        Me.GITPathTextBox.Name = "GITPathTextBox"
        Me.GITPathTextBox.Size = New System.Drawing.Size(284, 26)
        Me.GITPathTextBox.TabIndex = 18
        Me.GITPathTextBox.Text = "OpenGIT_Path"
        Me.GITPathTextBox.Visible = False
        '
        'GITPathButton
        '
        Me.GITPathButton.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GITPathButton.Location = New System.Drawing.Point(209, 266)
        Me.GITPathButton.Name = "GITPathButton"
        Me.GITPathButton.Size = New System.Drawing.Size(103, 26)
        Me.GITPathButton.TabIndex = 17
        Me.GITPathButton.Text = "Select Path"
        Me.GITPathButton.UseVisualStyleBackColor = True
        Me.GITPathButton.Visible = False
        '
        'ofd_path
        '
        Me.ofd_path.Filter = "Executable File|*.exe"
        '
        'VerText
        '
        Me.VerText.AutoSize = True
        Me.VerText.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerText.Location = New System.Drawing.Point(471, 294)
        Me.VerText.Name = "VerText"
        Me.VerText.Size = New System.Drawing.Size(162, 24)
        Me.VerText.TabIndex = 21
        Me.VerText.Text = "     Version. 1.0.0.0"
        '
        'InfoText1
        '
        Me.InfoText1.AutoSize = True
        Me.InfoText1.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoText1.Location = New System.Drawing.Point(432, 274)
        Me.InfoText1.Name = "InfoText1"
        Me.InfoText1.Size = New System.Drawing.Size(201, 20)
        Me.InfoText1.TabIndex = 20
        Me.InfoText1.Text = "By MineEric64 (최에릭) - Git"
        '
        'CPFileButton
        '
        Me.CPFileButton.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPFileButton.Location = New System.Drawing.Point(246, 199)
        Me.CPFileButton.Name = "CPFileButton"
        Me.CPFileButton.Size = New System.Drawing.Size(116, 27)
        Me.CPFileButton.TabIndex = 22
        Me.CPFileButton.Text = "CP Files"
        Me.CPFileButton.UseVisualStyleBackColor = True
        '
        'CPW_Icon
        '
        Me.CPW_Icon.Image = Global.CPWorkspace.My.Resources.Resources.CPWorkspace
        Me.CPW_Icon.Location = New System.Drawing.Point(474, 168)
        Me.CPW_Icon.Name = "CPW_Icon"
        Me.CPW_Icon.Size = New System.Drawing.Size(159, 150)
        Me.CPW_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CPW_Icon.TabIndex = 19
        Me.CPW_Icon.TabStop = False
        '
        'MainProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 330)
        Me.Controls.Add(Me.CPFileButton)
        Me.Controls.Add(Me.VerText)
        Me.Controls.Add(Me.InfoText1)
        Me.Controls.Add(Me.CPW_Icon)
        Me.Controls.Add(Me.GITPathTextBox)
        Me.Controls.Add(Me.GITPathButton)
        Me.Controls.Add(Me.OpenGITCheckBox)
        Me.Controls.Add(Me.EDITCModeButton)
        Me.Controls.Add(Me.CLogButton)
        Me.Controls.Add(Me.GazuaTCheckBox)
        Me.Controls.Add(Me.GazuaButton)
        Me.Controls.Add(Me.VCW_Info)
        Me.Controls.Add(Me.CW_Info)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CM_ComboBox)
        Me.Controls.Add(Me.PW_TextBox)
        Me.Controls.Add(Me.PW_Button)
        Me.Controls.Add(Me.CM_CheckBox)
        Me.Controls.Add(Me.CW_TextBox)
        Me.Controls.Add(Me.CW_Button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainProject"
        Me.Text = "Workspace Git: The Final Version."
        CType(Me.CPW_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CW_Button As Button
    Friend WithEvents CW_TextBox As TextBox
    Friend WithEvents CM_CheckBox As CheckBox
    Friend WithEvents PW_TextBox As TextBox
    Friend WithEvents PW_Button As Button
    Friend WithEvents CM_ComboBox As ComboBox
    Friend WithEvents fbd_path As FolderBrowserDialog
    Friend WithEvents SaveButton As Button
    Friend WithEvents CW_Info As Label
    Friend WithEvents VCW_Info As Label
    Friend WithEvents GazuaButton As Button
    Friend WithEvents GazuaTCheckBox As CheckBox
    Friend WithEvents CLogButton As Button
    Friend WithEvents EDITCModeButton As Button
    Friend WithEvents OpenGITCheckBox As CheckBox
    Friend WithEvents GITPathTextBox As TextBox
    Friend WithEvents GITPathButton As Button
    Friend WithEvents ofd_path As OpenFileDialog
    Friend WithEvents CPW_Icon As PictureBox
    Friend WithEvents VerText As Label
    Friend WithEvents InfoText1 As Label
    Friend WithEvents CPFileButton As Button
End Class
