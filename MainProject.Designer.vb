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
        Me.CW_Button = New System.Windows.Forms.Button()
        Me.CW_TextBox = New System.Windows.Forms.TextBox()
        Me.CM_CheckBox = New System.Windows.Forms.CheckBox()
        Me.VCW_TextBox = New System.Windows.Forms.TextBox()
        Me.VCW_Button = New System.Windows.Forms.Button()
        Me.InfoText1 = New System.Windows.Forms.Label()
        Me.VerText = New System.Windows.Forms.Label()
        Me.CM_ComboBox = New System.Windows.Forms.ComboBox()
        Me.fbd_path = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'CW_Button
        '
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
        Me.CM_CheckBox.Location = New System.Drawing.Point(39, 178)
        Me.CM_CheckBox.Name = "CM_CheckBox"
        Me.CM_CheckBox.Size = New System.Drawing.Size(156, 21)
        Me.CM_CheckBox.TabIndex = 3
        Me.CM_CheckBox.Text = "Enable Custom Mode"
        Me.CM_CheckBox.UseVisualStyleBackColor = True
        '
        'VCW_TextBox
        '
        Me.VCW_TextBox.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VCW_TextBox.Location = New System.Drawing.Point(39, 76)
        Me.VCW_TextBox.Name = "VCW_TextBox"
        Me.VCW_TextBox.Size = New System.Drawing.Size(284, 26)
        Me.VCW_TextBox.TabIndex = 5
        Me.VCW_TextBox.Text = "VCWorkspace"
        '
        'VCW_Button
        '
        Me.VCW_Button.Location = New System.Drawing.Point(341, 76)
        Me.VCW_Button.Name = "VCW_Button"
        Me.VCW_Button.Size = New System.Drawing.Size(103, 26)
        Me.VCW_Button.TabIndex = 4
        Me.VCW_Button.Text = "Select Path"
        Me.VCW_Button.UseVisualStyleBackColor = True
        '
        'InfoText1
        '
        Me.InfoText1.AutoSize = True
        Me.InfoText1.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoText1.Location = New System.Drawing.Point(432, 274)
        Me.InfoText1.Name = "InfoText1"
        Me.InfoText1.Size = New System.Drawing.Size(201, 20)
        Me.InfoText1.TabIndex = 6
        Me.InfoText1.Text = "By MineEric64 (최에릭) - Git"
        '
        'VerText
        '
        Me.VerText.AutoSize = True
        Me.VerText.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerText.Location = New System.Drawing.Point(491, 297)
        Me.VerText.Name = "VerText"
        Me.VerText.Size = New System.Drawing.Size(142, 24)
        Me.VerText.TabIndex = 7
        Me.VerText.Text = "Version. 1.0.0.0"
        '
        'CM_ComboBox
        '
        Me.CM_ComboBox.Enabled = False
        Me.CM_ComboBox.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CM_ComboBox.FormattingEnabled = True
        Me.CM_ComboBox.Location = New System.Drawing.Point(39, 147)
        Me.CM_ComboBox.Name = "CM_ComboBox"
        Me.CM_ComboBox.Size = New System.Drawing.Size(184, 25)
        Me.CM_ComboBox.TabIndex = 8
        Me.CM_ComboBox.Text = "CustomMode_Item"
        '
        'fbd_path
        '
        Me.fbd_path.RootFolder = System.Environment.SpecialFolder.MyDocuments
        '
        'MainProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 330)
        Me.Controls.Add(Me.CM_ComboBox)
        Me.Controls.Add(Me.VerText)
        Me.Controls.Add(Me.InfoText1)
        Me.Controls.Add(Me.VCW_TextBox)
        Me.Controls.Add(Me.VCW_Button)
        Me.Controls.Add(Me.CM_CheckBox)
        Me.Controls.Add(Me.CW_TextBox)
        Me.Controls.Add(Me.CW_Button)
        Me.Name = "MainProject"
        Me.Text = "Copy/Paste Workspace for Git"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CW_Button As Button
    Friend WithEvents CW_TextBox As TextBox
    Friend WithEvents CM_CheckBox As CheckBox
    Friend WithEvents VCW_TextBox As TextBox
    Friend WithEvents VCW_Button As Button
    Friend WithEvents InfoText1 As Label
    Friend WithEvents VerText As Label
    Friend WithEvents CM_ComboBox As ComboBox
    Friend WithEvents fbd_path As FolderBrowserDialog
End Class
