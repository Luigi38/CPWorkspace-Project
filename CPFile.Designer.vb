<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CPFile
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
        Me.GazuaButton = New System.Windows.Forms.Button()
        Me.PF_Info = New System.Windows.Forms.Label()
        Me.CF_Info = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CM_ComboBox = New System.Windows.Forms.ComboBox()
        Me.PF_TextBox = New System.Windows.Forms.TextBox()
        Me.PF_Button = New System.Windows.Forms.Button()
        Me.CM_CheckBox = New System.Windows.Forms.CheckBox()
        Me.CF_TextBox = New System.Windows.Forms.TextBox()
        Me.CF_Button = New System.Windows.Forms.Button()
        Me.ofd_path = New System.Windows.Forms.OpenFileDialog()
        Me.fbd_path = New System.Windows.Forms.FolderBrowserDialog()
        Me.sfd_path = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'GazuaButton
        '
        Me.GazuaButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GazuaButton.Location = New System.Drawing.Point(415, 169)
        Me.GazuaButton.Name = "GazuaButton"
        Me.GazuaButton.Size = New System.Drawing.Size(159, 72)
        Me.GazuaButton.TabIndex = 32
        Me.GazuaButton.Text = "Ctrl + C/V"
        Me.GazuaButton.UseVisualStyleBackColor = True
        '
        'PF_Info
        '
        Me.PF_Info.AutoSize = True
        Me.PF_Info.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PF_Info.Location = New System.Drawing.Point(54, 104)
        Me.PF_Info.Name = "PF_Info"
        Me.PF_Info.Size = New System.Drawing.Size(239, 17)
        Me.PF_Info.TabIndex = 31
        Me.PF_Info.Text = "To Paste File (ex: Project/Ctrl_V\C.dll)"
        '
        'CF_Info
        '
        Me.CF_Info.AutoSize = True
        Me.CF_Info.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CF_Info.Location = New System.Drawing.Point(54, 48)
        Me.CF_Info.Name = "CF_Info"
        Me.CF_Info.Size = New System.Drawing.Size(236, 17)
        Me.CF_Info.TabIndex = 30
        Me.CF_Info.Text = "To Copy File (ex: Project\Ctrl_C\C.dll)"
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(262, 174)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(116, 67)
        Me.SaveButton.TabIndex = 29
        Me.SaveButton.Text = "Save SETTINGS!"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CM_ComboBox
        '
        Me.CM_ComboBox.Enabled = False
        Me.CM_ComboBox.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CM_ComboBox.FormattingEnabled = True
        Me.CM_ComboBox.Location = New System.Drawing.Point(47, 197)
        Me.CM_ComboBox.Name = "CM_ComboBox"
        Me.CM_ComboBox.Size = New System.Drawing.Size(184, 25)
        Me.CM_ComboBox.TabIndex = 28
        Me.CM_ComboBox.Text = "CustomMode_Item"
        '
        'PF_TextBox
        '
        Me.PF_TextBox.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PF_TextBox.Location = New System.Drawing.Point(47, 124)
        Me.PF_TextBox.Name = "PF_TextBox"
        Me.PF_TextBox.Size = New System.Drawing.Size(284, 26)
        Me.PF_TextBox.TabIndex = 27
        Me.PF_TextBox.Text = "PasteFile"
        '
        'PF_Button
        '
        Me.PF_Button.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PF_Button.Location = New System.Drawing.Point(349, 124)
        Me.PF_Button.Name = "PF_Button"
        Me.PF_Button.Size = New System.Drawing.Size(103, 26)
        Me.PF_Button.TabIndex = 26
        Me.PF_Button.Text = "Select Path"
        Me.PF_Button.UseVisualStyleBackColor = True
        '
        'CM_CheckBox
        '
        Me.CM_CheckBox.AutoSize = True
        Me.CM_CheckBox.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CM_CheckBox.Location = New System.Drawing.Point(47, 228)
        Me.CM_CheckBox.Name = "CM_CheckBox"
        Me.CM_CheckBox.Size = New System.Drawing.Size(156, 21)
        Me.CM_CheckBox.TabIndex = 25
        Me.CM_CheckBox.Text = "Enable Custom Mode"
        Me.CM_CheckBox.UseVisualStyleBackColor = True
        '
        'CF_TextBox
        '
        Me.CF_TextBox.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CF_TextBox.Location = New System.Drawing.Point(47, 68)
        Me.CF_TextBox.Name = "CF_TextBox"
        Me.CF_TextBox.Size = New System.Drawing.Size(284, 26)
        Me.CF_TextBox.TabIndex = 24
        Me.CF_TextBox.Text = "CopyFile"
        '
        'CF_Button
        '
        Me.CF_Button.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CF_Button.Location = New System.Drawing.Point(349, 68)
        Me.CF_Button.Name = "CF_Button"
        Me.CF_Button.Size = New System.Drawing.Size(103, 26)
        Me.CF_Button.TabIndex = 23
        Me.CF_Button.Text = "Select Path"
        Me.CF_Button.UseVisualStyleBackColor = True
        '
        'ofd_path
        '
        Me.ofd_path.Filter = "All Files|*.*"
        Me.ofd_path.Multiselect = True
        '
        'CPFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 306)
        Me.Controls.Add(Me.GazuaButton)
        Me.Controls.Add(Me.PF_Info)
        Me.Controls.Add(Me.CF_Info)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CM_ComboBox)
        Me.Controls.Add(Me.PF_TextBox)
        Me.Controls.Add(Me.PF_Button)
        Me.Controls.Add(Me.CM_CheckBox)
        Me.Controls.Add(Me.CF_TextBox)
        Me.Controls.Add(Me.CF_Button)
        Me.Name = "CPFile"
        Me.Text = "Copy/Paste Files for Git"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GazuaButton As Button
    Friend WithEvents PF_Info As Label
    Friend WithEvents CF_Info As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents CM_ComboBox As ComboBox
    Friend WithEvents PF_TextBox As TextBox
    Friend WithEvents PF_Button As Button
    Friend WithEvents CM_CheckBox As CheckBox
    Friend WithEvents CF_TextBox As TextBox
    Friend WithEvents CF_Button As Button
    Friend WithEvents ofd_path As OpenFileDialog
    Friend WithEvents fbd_path As FolderBrowserDialog
    Friend WithEvents sfd_path As SaveFileDialog
End Class
