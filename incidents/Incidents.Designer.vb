<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Incidents
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
        BtnOpenIncidentDashboard = New Button()
        BtnOpenIncidentRecords = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        BtnSubmit = New Button()
        BtnReset = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TxtName = New TextBox()
        TxtDesc = New TextBox()
        DtpDate = New DateTimePicker()
        RbResolved = New RadioButton()
        RbPending = New RadioButton()
        CboAccounts = New ComboBox()
        SuspendLayout()
        ' 
        ' BtnOpenIncidentDashboard
        ' 
        BtnOpenIncidentDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenIncidentDashboard.Location = New Point(579, 292)
        BtnOpenIncidentDashboard.Name = "BtnOpenIncidentDashboard"
        BtnOpenIncidentDashboard.Size = New Size(261, 54)
        BtnOpenIncidentDashboard.TabIndex = 11
        BtnOpenIncidentDashboard.Text = "⬅️ Back"
        BtnOpenIncidentDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenIncidentRecords
        ' 
        BtnOpenIncidentRecords.Font = New Font("Segoe UI", 12F)
        BtnOpenIncidentRecords.Location = New Point(579, 202)
        BtnOpenIncidentRecords.Name = "BtnOpenIncidentRecords"
        BtnOpenIncidentRecords.Size = New Size(261, 54)
        BtnOpenIncidentRecords.TabIndex = 10
        BtnOpenIncidentRecords.Text = "Show Incidents"
        BtnOpenIncidentRecords.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(579, 122)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(261, 54)
        BtnTestConnection.TabIndex = 9
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(579, 46)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(261, 54)
        BtnOpenDashboard.TabIndex = 8
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 15F)
        BtnSubmit.Location = New Point(368, 416)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(131, 54)
        BtnSubmit.TabIndex = 7
        BtnSubmit.Text = "Create"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(93, 416)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(131, 54)
        BtnReset.TabIndex = 6
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(34, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 35)
        Label1.TabIndex = 24
        Label1.Text = "Type : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(34, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 35)
        Label2.TabIndex = 25
        Label2.Text = "Description : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(34, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 35)
        Label3.TabIndex = 26
        Label3.Text = "Date : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(34, 242)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 35)
        Label4.TabIndex = 27
        Label4.Text = "Status : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.Location = New Point(34, 311)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 35)
        Label5.TabIndex = 28
        Label5.Text = "Account : "
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(244, 41)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(250, 27)
        TxtName.TabIndex = 0
        ' 
        ' TxtDesc
        ' 
        TxtDesc.Location = New Point(244, 97)
        TxtDesc.Multiline = True
        TxtDesc.Name = "TxtDesc"
        TxtDesc.Size = New Size(250, 61)
        TxtDesc.TabIndex = 1
        ' 
        ' DtpDate
        ' 
        DtpDate.Location = New Point(244, 189)
        DtpDate.Name = "DtpDate"
        DtpDate.Size = New Size(250, 27)
        DtpDate.TabIndex = 2
        ' 
        ' RbResolved
        ' 
        RbResolved.AutoSize = True
        RbResolved.Location = New Point(248, 249)
        RbResolved.Name = "RbResolved"
        RbResolved.Size = New Size(90, 24)
        RbResolved.TabIndex = 3
        RbResolved.TabStop = True
        RbResolved.Text = "Resolved"
        RbResolved.UseVisualStyleBackColor = True
        ' 
        ' RbPending
        ' 
        RbPending.AutoSize = True
        RbPending.Location = New Point(378, 249)
        RbPending.Name = "RbPending"
        RbPending.Size = New Size(83, 24)
        RbPending.TabIndex = 4
        RbPending.TabStop = True
        RbPending.Text = "Pending"
        RbPending.UseVisualStyleBackColor = True
        ' 
        ' CboAccounts
        ' 
        CboAccounts.FormattingEnabled = True
        CboAccounts.Location = New Point(244, 320)
        CboAccounts.Name = "CboAccounts"
        CboAccounts.Size = New Size(250, 28)
        CboAccounts.TabIndex = 5
        ' 
        ' Incidents
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(869, 503)
        Controls.Add(CboAccounts)
        Controls.Add(RbPending)
        Controls.Add(RbResolved)
        Controls.Add(DtpDate)
        Controls.Add(TxtDesc)
        Controls.Add(TxtName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnReset)
        Controls.Add(BtnOpenIncidentDashboard)
        Controls.Add(BtnOpenIncidentRecords)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Name = "Incidents"
        Text = "Incidents"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnOpenIncidentDashboard As Button
    Friend WithEvents BtnOpenIncidentRecords As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents RbResolved As RadioButton
    Friend WithEvents RbPending As RadioButton
    Friend WithEvents CboAccounts As ComboBox
End Class
