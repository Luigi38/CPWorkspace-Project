<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CMode
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CMode_ListView = New System.Windows.Forms.ListView()
        Me.ItmName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DelButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ItemName = New System.Windows.Forms.TextBox()
        Me.LabelTip1 = New System.Windows.Forms.Label()
        Me.LabelTip2 = New System.Windows.Forms.Label()
        Me.CW_TextBox = New System.Windows.Forms.TextBox()
        Me.LabelTip3 = New System.Windows.Forms.Label()
        Me.PW_TextBox = New System.Windows.Forms.TextBox()
        Me.LabelTip4 = New System.Windows.Forms.Label()
        Me.CF_TextBox = New System.Windows.Forms.TextBox()
        Me.LabelTip5 = New System.Windows.Forms.Label()
        Me.PF_TextBox = New System.Windows.Forms.TextBox()
        Me.LabelTip6 = New System.Windows.Forms.Label()
        Me.CLogPath_TextBox = New System.Windows.Forms.TextBox()
        Me.SelButton1 = New System.Windows.Forms.Button()
        Me.SelButton2 = New System.Windows.Forms.Button()
        Me.SelButton3 = New System.Windows.Forms.Button()
        Me.SelButton4 = New System.Windows.Forms.Button()
        Me.SelButton5 = New System.Windows.Forms.Button()
        Me.ofd_path = New System.Windows.Forms.OpenFileDialog()
        Me.fbd_path = New System.Windows.Forms.FolderBrowserDialog()
        Me.sfd_path = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'CMode_ListView
        '
        Me.CMode_ListView.AllowDrop = True
        Me.CMode_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ItmName})
        Me.CMode_ListView.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMode_ListView.FullRowSelect = True
        Me.CMode_ListView.Location = New System.Drawing.Point(12, 12)
        Me.CMode_ListView.MultiSelect = False
        Me.CMode_ListView.Name = "CMode_ListView"
        Me.CMode_ListView.Size = New System.Drawing.Size(234, 356)
        Me.CMode_ListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.CMode_ListView.TabIndex = 24
        Me.CMode_ListView.UseCompatibleStateImageBehavior = False
        Me.CMode_ListView.View = System.Windows.Forms.View.Details
        '
        'ItmName
        '
        Me.ItmName.Text = "Custom Mode Item Name"
        Me.ItmName.Width = 229
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(265, 297)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(156, 71)
        Me.AddButton.TabIndex = 25
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'DelButton
        '
        Me.DelButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelButton.Location = New System.Drawing.Point(439, 297)
        Me.DelButton.Name = "DelButton"
        Me.DelButton.Size = New System.Drawing.Size(156, 71)
        Me.DelButton.TabIndex = 26
        Me.DelButton.Text = "Delete"
        Me.DelButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(612, 297)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(156, 71)
        Me.SaveButton.TabIndex = 27
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ItemName
        '
        Me.ItemName.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemName.Location = New System.Drawing.Point(359, 24)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(409, 26)
        Me.ItemName.TabIndex = 28
        Me.ItemName.Text = "ItemName"
        '
        'LabelTip1
        '
        Me.LabelTip1.AutoSize = True
        Me.LabelTip1.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTip1.Location = New System.Drawing.Point(264, 27)
        Me.LabelTip1.Name = "LabelTip1"
        Me.LabelTip1.Size = New System.Drawing.Size(89, 20)
        Me.LabelTip1.TabIndex = 29
        Me.LabelTip1.Text = "Item Name:"
        '
        'LabelTip2
        '
        Me.LabelTip2.AutoSize = True
        Me.LabelTip2.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTip2.Location = New System.Drawing.Point(264, 71)
        Me.LabelTip2.Name = "LabelTip2"
        Me.LabelTip2.Size = New System.Drawing.Size(138, 20)
        Me.LabelTip2.TabIndex = 31
        Me.LabelTip2.Text = "Copy Folder Path:"
        '
        'CW_TextBox
        '
        Me.CW_TextBox.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CW_TextBox.Location = New System.Drawing.Point(408, 68)
        Me.CW_TextBox.Name = "CW_TextBox"
        Me.CW_TextBox.Size = New System.Drawing.Size(259, 26)
        Me.CW_TextBox.TabIndex = 30
        Me.CW_TextBox.Text = "CWorkspace"
        '
        'LabelTip3
        '
        Me.LabelTip3.AutoSize = True
        Me.LabelTip3.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTip3.Location = New System.Drawing.Point(264, 114)
        Me.LabelTip3.Name = "LabelTip3"
        Me.LabelTip3.Size = New System.Drawing.Size(141, 20)
        Me.LabelTip3.TabIndex = 33
        Me.LabelTip3.Text = "Paste Folder Path:"
        '
        'PW_TextBox
        '
        Me.PW_TextBox.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PW_TextBox.Location = New System.Drawing.Point(408, 111)
        Me.PW_TextBox.Name = "PW_TextBox"
        Me.PW_TextBox.Size = New System.Drawing.Size(259, 26)
        Me.PW_TextBox.TabIndex = 32
        Me.PW_TextBox.Text = "PWorkspace"
        '
        'LabelTip4
        '
        Me.LabelTip4.AutoSize = True
        Me.LabelTip4.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTip4.Location = New System.Drawing.Point(261, 157)
        Me.LabelTip4.Name = "LabelTip4"
        Me.LabelTip4.Size = New System.Drawing.Size(116, 20)
        Me.LabelTip4.TabIndex = 35
        Me.LabelTip4.Text = "Copy File Path:"
        '
        'CF_TextBox
        '
        Me.CF_TextBox.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CF_TextBox.Location = New System.Drawing.Point(383, 154)
        Me.CF_TextBox.Name = "CF_TextBox"
        Me.CF_TextBox.Size = New System.Drawing.Size(284, 26)
        Me.CF_TextBox.TabIndex = 34
        Me.CF_TextBox.Text = "CFile"
        '
        'LabelTip5
        '
        Me.LabelTip5.AutoSize = True
        Me.LabelTip5.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTip5.Location = New System.Drawing.Point(261, 203)
        Me.LabelTip5.Name = "LabelTip5"
        Me.LabelTip5.Size = New System.Drawing.Size(119, 20)
        Me.LabelTip5.TabIndex = 37
        Me.LabelTip5.Text = "Paste File Path:"
        '
        'PF_TextBox
        '
        Me.PF_TextBox.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PF_TextBox.Location = New System.Drawing.Point(383, 200)
        Me.PF_TextBox.Name = "PF_TextBox"
        Me.PF_TextBox.Size = New System.Drawing.Size(284, 26)
        Me.PF_TextBox.TabIndex = 36
        Me.PF_TextBox.Text = "PFile"
        '
        'LabelTip6
        '
        Me.LabelTip6.AutoSize = True
        Me.LabelTip6.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTip6.Location = New System.Drawing.Point(261, 243)
        Me.LabelTip6.Name = "LabelTip6"
        Me.LabelTip6.Size = New System.Drawing.Size(166, 20)
        Me.LabelTip6.TabIndex = 39
        Me.LabelTip6.Text = "Commit Log File Path:"
        '
        'CLogPath_TextBox
        '
        Me.CLogPath_TextBox.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLogPath_TextBox.Location = New System.Drawing.Point(428, 242)
        Me.CLogPath_TextBox.Name = "CLogPath_TextBox"
        Me.CLogPath_TextBox.Size = New System.Drawing.Size(239, 26)
        Me.CLogPath_TextBox.TabIndex = 38
        Me.CLogPath_TextBox.Text = "CLog_Path"
        '
        'SelButton1
        '
        Me.SelButton1.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelButton1.Location = New System.Drawing.Point(676, 68)
        Me.SelButton1.Name = "SelButton1"
        Me.SelButton1.Size = New System.Drawing.Size(92, 26)
        Me.SelButton1.TabIndex = 40
        Me.SelButton1.Text = "Select Path"
        Me.SelButton1.UseVisualStyleBackColor = True
        '
        'SelButton2
        '
        Me.SelButton2.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelButton2.Location = New System.Drawing.Point(676, 111)
        Me.SelButton2.Name = "SelButton2"
        Me.SelButton2.Size = New System.Drawing.Size(92, 26)
        Me.SelButton2.TabIndex = 41
        Me.SelButton2.Text = "Select Path"
        Me.SelButton2.UseVisualStyleBackColor = True
        '
        'SelButton3
        '
        Me.SelButton3.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelButton3.Location = New System.Drawing.Point(676, 154)
        Me.SelButton3.Name = "SelButton3"
        Me.SelButton3.Size = New System.Drawing.Size(92, 26)
        Me.SelButton3.TabIndex = 42
        Me.SelButton3.Text = "Select Path"
        Me.SelButton3.UseVisualStyleBackColor = True
        '
        'SelButton4
        '
        Me.SelButton4.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelButton4.Location = New System.Drawing.Point(676, 200)
        Me.SelButton4.Name = "SelButton4"
        Me.SelButton4.Size = New System.Drawing.Size(92, 26)
        Me.SelButton4.TabIndex = 43
        Me.SelButton4.Text = "Select Path"
        Me.SelButton4.UseVisualStyleBackColor = True
        '
        'SelButton5
        '
        Me.SelButton5.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelButton5.Location = New System.Drawing.Point(676, 242)
        Me.SelButton5.Name = "SelButton5"
        Me.SelButton5.Size = New System.Drawing.Size(92, 26)
        Me.SelButton5.TabIndex = 44
        Me.SelButton5.Text = "Select Path"
        Me.SelButton5.UseVisualStyleBackColor = True
        '
        'CMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 385)
        Me.Controls.Add(Me.SelButton5)
        Me.Controls.Add(Me.SelButton4)
        Me.Controls.Add(Me.SelButton3)
        Me.Controls.Add(Me.SelButton2)
        Me.Controls.Add(Me.SelButton1)
        Me.Controls.Add(Me.LabelTip6)
        Me.Controls.Add(Me.CLogPath_TextBox)
        Me.Controls.Add(Me.LabelTip5)
        Me.Controls.Add(Me.PF_TextBox)
        Me.Controls.Add(Me.LabelTip4)
        Me.Controls.Add(Me.CF_TextBox)
        Me.Controls.Add(Me.LabelTip3)
        Me.Controls.Add(Me.PW_TextBox)
        Me.Controls.Add(Me.LabelTip2)
        Me.Controls.Add(Me.CW_TextBox)
        Me.Controls.Add(Me.LabelTip1)
        Me.Controls.Add(Me.ItemName)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.CMode_ListView)
        Me.Name = "CMode"
        Me.Text = "Edit Custom Mode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CMode_ListView As ListView
    Friend WithEvents ItmName As ColumnHeader
    Friend WithEvents AddButton As Button
    Friend WithEvents DelButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents ItemName As TextBox
    Friend WithEvents LabelTip1 As Label
    Friend WithEvents LabelTip2 As Label
    Friend WithEvents CW_TextBox As TextBox
    Friend WithEvents LabelTip3 As Label
    Friend WithEvents PW_TextBox As TextBox
    Friend WithEvents LabelTip4 As Label
    Friend WithEvents CF_TextBox As TextBox
    Friend WithEvents LabelTip5 As Label
    Friend WithEvents PF_TextBox As TextBox
    Friend WithEvents LabelTip6 As Label
    Friend WithEvents CLogPath_TextBox As TextBox
    Friend WithEvents SelButton1 As Button
    Friend WithEvents SelButton2 As Button
    Friend WithEvents SelButton3 As Button
    Friend WithEvents SelButton4 As Button
    Friend WithEvents SelButton5 As Button
    Friend WithEvents ofd_path As OpenFileDialog
    Friend WithEvents fbd_path As FolderBrowserDialog
    Friend WithEvents sfd_path As SaveFileDialog
End Class
