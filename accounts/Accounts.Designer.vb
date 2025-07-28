<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnOpenAccountDashboard = New Button()
        BtnOpenAccountRecords = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TxtName = New TextBox()
        CboClient = New ComboBox()
        DtpAccountDate = New DateTimePicker()
        BtnSubmit = New Button()
        BtnReset = New Button()
        SuspendLayout()
        ' 
        ' BtnOpenAccountDashboard
        ' 
        BtnOpenAccountDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenAccountDashboard.Location = New Point(719, 329)
        BtnOpenAccountDashboard.Margin = New Padding(3, 5, 3, 5)
        BtnOpenAccountDashboard.Name = "BtnOpenAccountDashboard"
        BtnOpenAccountDashboard.Size = New Size(294, 62)
        BtnOpenAccountDashboard.TabIndex = 8
        BtnOpenAccountDashboard.Text = "⬅️ Back"
        BtnOpenAccountDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenAccountRecords
        ' 
        BtnOpenAccountRecords.Font = New Font("Segoe UI", 12F)
        BtnOpenAccountRecords.Location = New Point(719, 226)
        BtnOpenAccountRecords.Margin = New Padding(3, 5, 3, 5)
        BtnOpenAccountRecords.Name = "BtnOpenAccountRecords"
        BtnOpenAccountRecords.Size = New Size(294, 62)
        BtnOpenAccountRecords.TabIndex = 7
        BtnOpenAccountRecords.Text = "Show Accounts"
        BtnOpenAccountRecords.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(719, 134)
        BtnTestConnection.Margin = New Padding(3, 5, 3, 5)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(294, 62)
        BtnTestConnection.TabIndex = 6
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(719, 46)
        BtnOpenDashboard.Margin = New Padding(3, 5, 3, 5)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(294, 62)
        BtnOpenDashboard.TabIndex = 5
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(24, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 35)
        Label1.TabIndex = 26
        Label1.Text = "Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(24, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 35)
        Label2.TabIndex = 27
        Label2.Text = "Client :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(24, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 35)
        Label3.TabIndex = 28
        Label3.Text = "Date :"
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(235, 60)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(261, 27)
        TxtName.TabIndex = 0
        ' 
        ' CboClient
        ' 
        CboClient.FormattingEnabled = True
        CboClient.Location = New Point(235, 146)
        CboClient.Name = "CboClient"
        CboClient.Size = New Size(261, 28)
        CboClient.TabIndex = 1
        ' 
        ' DtpAccountDate
        ' 
        DtpAccountDate.Location = New Point(235, 234)
        DtpAccountDate.Name = "DtpAccountDate"
        DtpAccountDate.Size = New Size(261, 27)
        DtpAccountDate.TabIndex = 2
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 15F)
        BtnSubmit.Location = New Point(409, 329)
        BtnSubmit.Margin = New Padding(3, 5, 3, 5)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(147, 62)
        BtnSubmit.TabIndex = 4
        BtnSubmit.Text = "Add"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(100, 329)
        BtnReset.Margin = New Padding(3, 5, 3, 5)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(147, 62)
        BtnReset.TabIndex = 3
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' Accounts
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1035, 428)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnReset)
        Controls.Add(DtpAccountDate)
        Controls.Add(CboClient)
        Controls.Add(TxtName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnOpenAccountDashboard)
        Controls.Add(BtnOpenAccountRecords)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Name = "Accounts"
        Text = "Accounts"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnOpenAccountDashboard As Button
    Friend WithEvents BtnOpenAccountRecords As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents CboClient As ComboBox
    Friend WithEvents DtpAccountDate As DateTimePicker
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
End Class
