<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subscriptions
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
        Label1 = New Label()
        Label2 = New Label()
        CboChooseAccount = New ComboBox()
        CboChooseService = New ComboBox()
        BtnTestConnection = New Button()
        BtnReset = New Button()
        Label3 = New Label()
        BtnDate = New DateTimePicker()
        BtnSubmit = New Button()
        BtnBack = New Button()
        BtnShowRecords = New Button()
        BtnOpenSubDashboard = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(70, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 35)
        Label1.TabIndex = 0
        Label1.Text = "Account : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(70, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 35)
        Label2.TabIndex = 1
        Label2.Text = "Service : "
        ' 
        ' CboChooseAccount
        ' 
        CboChooseAccount.FormattingEnabled = True
        CboChooseAccount.Location = New Point(271, 68)
        CboChooseAccount.Name = "CboChooseAccount"
        CboChooseAccount.Size = New Size(194, 28)
        CboChooseAccount.TabIndex = 2
        ' 
        ' CboChooseService
        ' 
        CboChooseService.FormattingEnabled = True
        CboChooseService.Location = New Point(271, 140)
        CboChooseService.Name = "CboChooseService"
        CboChooseService.Size = New Size(194, 28)
        CboChooseService.TabIndex = 3
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(551, 107)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(224, 61)
        BtnTestConnection.TabIndex = 9
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 12F)
        BtnReset.Location = New Point(70, 354)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(134, 49)
        BtnReset.TabIndex = 5
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(70, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 35)
        Label3.TabIndex = 6
        Label3.Text = "Date : "
        ' 
        ' BtnDate
        ' 
        BtnDate.Location = New Point(271, 222)
        BtnDate.Name = "BtnDate"
        BtnDate.Size = New Size(194, 27)
        BtnDate.TabIndex = 4
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 12F)
        BtnSubmit.Location = New Point(331, 354)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(134, 49)
        BtnSubmit.TabIndex = 6
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnBack
        ' 
        BtnBack.Font = New Font("Segoe UI", 12F)
        BtnBack.Location = New Point(551, 27)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(224, 54)
        BtnBack.TabIndex = 8
        BtnBack.Text = "Back To Dashboard"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' BtnShowRecords
        ' 
        BtnShowRecords.Font = New Font("Segoe UI", 12F)
        BtnShowRecords.Location = New Point(551, 193)
        BtnShowRecords.Name = "BtnShowRecords"
        BtnShowRecords.Size = New Size(224, 56)
        BtnShowRecords.TabIndex = 10
        BtnShowRecords.Text = "Show Subscriptions"
        BtnShowRecords.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenSubDashboard
        ' 
        BtnOpenSubDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenSubDashboard.Location = New Point(551, 282)
        BtnOpenSubDashboard.Name = "BtnOpenSubDashboard"
        BtnOpenSubDashboard.Size = New Size(224, 51)
        BtnOpenSubDashboard.TabIndex = 11
        BtnOpenSubDashboard.Text = "⬅️ Back"
        BtnOpenSubDashboard.UseVisualStyleBackColor = True
        ' 
        ' Subscriptions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnOpenSubDashboard)
        Controls.Add(BtnShowRecords)
        Controls.Add(BtnBack)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnDate)
        Controls.Add(Label3)
        Controls.Add(BtnReset)
        Controls.Add(BtnTestConnection)
        Controls.Add(CboChooseService)
        Controls.Add(CboChooseAccount)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Subscriptions"
        Text = "Add Subscriptions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CboChooseAccount As ComboBox
    Friend WithEvents CboChooseService As ComboBox
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnDate As DateTimePicker
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnShowRecords As Button
    Friend WithEvents BtnOpenSubDashboard As Button
End Class
