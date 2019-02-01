<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommitLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CommitLog))
        Me.CLogPathTextBox = New System.Windows.Forms.TextBox()
        Me.CLogPathButton = New System.Windows.Forms.Button()
        Me.CLogText = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.sfd1 = New System.Windows.Forms.SaveFileDialog()
        Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.CM_ComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'CLogPathTextBox
        '
        Me.CLogPathTextBox.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLogPathTextBox.Location = New System.Drawing.Point(30, 25)
        Me.CLogPathTextBox.Name = "CLogPathTextBox"
        Me.CLogPathTextBox.Size = New System.Drawing.Size(304, 26)
        Me.CLogPathTextBox.TabIndex = 0
        Me.CLogPathTextBox.Text = "CLog_Path"
        '
        'CLogPathButton
        '
        Me.CLogPathButton.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLogPathButton.Location = New System.Drawing.Point(350, 25)
        Me.CLogPathButton.Name = "CLogPathButton"
        Me.CLogPathButton.Size = New System.Drawing.Size(90, 26)
        Me.CLogPathButton.TabIndex = 1
        Me.CLogPathButton.Text = "Select Path"
        Me.CLogPathButton.UseVisualStyleBackColor = True
        '
        'CLogText
        '
        Me.CLogText.Font = New System.Drawing.Font("-윤디자인웹돋움", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CLogText.Location = New System.Drawing.Point(30, 69)
        Me.CLogText.Multiline = True
        Me.CLogText.Name = "CLogText"
        Me.CLogText.Size = New System.Drawing.Size(646, 242)
        Me.CLogText.TabIndex = 2
        Me.CLogText.Text = "CLog_Text"
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(572, 317)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(104, 60)
        Me.SaveButton.TabIndex = 3
        Me.SaveButton.Text = "Save!"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.DeleteButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(132, 317)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(104, 60)
        Me.DeleteButton.TabIndex = 4
        Me.DeleteButton.Text = "Delete File"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(451, 317)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(104, 60)
        Me.ResetButton.TabIndex = 5
        Me.ResetButton.Text = "Reset Text"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'sfd1
        '
        Me.sfd1.Filter = "Text FIle|*.txt|Markup Data FIle|*.md|All Files|*.*"
        '
        'ofd1
        '
        Me.ofd1.Filter = "Text FIle|*.txt|Markup Data FIle|*.md|All Files|*.*"
        '
        'CreateButton
        '
        Me.CreateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CreateButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateButton.Location = New System.Drawing.Point(12, 317)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(104, 60)
        Me.CreateButton.TabIndex = 6
        Me.CreateButton.Text = "Create File"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'CM_ComboBox
        '
        Me.CM_ComboBox.Enabled = False
        Me.CM_ComboBox.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CM_ComboBox.FormattingEnabled = True
        Me.CM_ComboBox.Location = New System.Drawing.Point(492, 25)
        Me.CM_ComboBox.Name = "CM_ComboBox"
        Me.CM_ComboBox.Size = New System.Drawing.Size(184, 25)
        Me.CM_ComboBox.TabIndex = 9
        Me.CM_ComboBox.Text = "CustomMode_Item"
        '
        'CommitLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 386)
        Me.Controls.Add(Me.CM_ComboBox)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CLogText)
        Me.Controls.Add(Me.CLogPathButton)
        Me.Controls.Add(Me.CLogPathTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CommitLog"
        Me.Text = "CPWorkspace - Commit Log"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CLogPathTextBox As TextBox
    Friend WithEvents CLogPathButton As Button
    Friend WithEvents CLogText As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents sfd1 As SaveFileDialog
    Friend WithEvents ofd1 As OpenFileDialog
    Friend WithEvents CreateButton As Button
    Friend WithEvents CM_ComboBox As ComboBox
End Class
