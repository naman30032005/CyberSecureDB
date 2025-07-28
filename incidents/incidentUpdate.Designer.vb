<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class incidentUpdate
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
        DgvShowIncidentRecords = New DataGridView()
        BtnOpenIncidentDashboard = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        CboAccounts = New ComboBox()
        RbPending = New RadioButton()
        RbResolved = New RadioButton()
        DtpDate = New DateTimePicker()
        TxtDesc = New TextBox()
        TxtName = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        BtnSubmit = New Button()
        BtnReset = New Button()
        Label6 = New Label()
        TxtID = New TextBox()
        CType(DgvShowIncidentRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvShowIncidentRecords
        ' 
        DgvShowIncidentRecords.AllowUserToAddRows = False
        DgvShowIncidentRecords.AllowUserToDeleteRows = False
        DgvShowIncidentRecords.AllowUserToOrderColumns = True
        DgvShowIncidentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvShowIncidentRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvShowIncidentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvShowIncidentRecords.EditMode = DataGridViewEditMode.EditProgrammatically
        DgvShowIncidentRecords.Location = New Point(17, 12)
        DgvShowIncidentRecords.MultiSelect = False
        DgvShowIncidentRecords.Name = "DgvShowIncidentRecords"
        DgvShowIncidentRecords.ReadOnly = True
        DgvShowIncidentRecords.RowHeadersWidth = 51
        DgvShowIncidentRecords.RowTemplate.Height = 50
        DgvShowIncidentRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvShowIncidentRecords.Size = New Size(1067, 267)
        DgvShowIncidentRecords.TabIndex = 0
        ' 
        ' BtnOpenIncidentDashboard
        ' 
        BtnOpenIncidentDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenIncidentDashboard.Location = New Point(782, 527)
        BtnOpenIncidentDashboard.Name = "BtnOpenIncidentDashboard"
        BtnOpenIncidentDashboard.Size = New Size(261, 54)
        BtnOpenIncidentDashboard.TabIndex = 12
        BtnOpenIncidentDashboard.Text = "⬅️ Back"
        BtnOpenIncidentDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(782, 442)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(261, 54)
        BtnTestConnection.TabIndex = 11
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(782, 366)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(261, 54)
        BtnOpenDashboard.TabIndex = 10
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' CboAccounts
        ' 
        CboAccounts.FormattingEnabled = True
        CboAccounts.Location = New Point(292, 585)
        CboAccounts.Name = "CboAccounts"
        CboAccounts.Size = New Size(250, 28)
        CboAccounts.TabIndex = 7
        ' 
        ' RbPending
        ' 
        RbPending.AutoSize = True
        RbPending.Location = New Point(426, 534)
        RbPending.Name = "RbPending"
        RbPending.Size = New Size(83, 24)
        RbPending.TabIndex = 6
        RbPending.TabStop = True
        RbPending.Text = "Pending"
        RbPending.UseVisualStyleBackColor = True
        ' 
        ' RbResolved
        ' 
        RbResolved.AutoSize = True
        RbResolved.Location = New Point(296, 534)
        RbResolved.Name = "RbResolved"
        RbResolved.Size = New Size(90, 24)
        RbResolved.TabIndex = 5
        RbResolved.TabStop = True
        RbResolved.Text = "Resolved"
        RbResolved.UseVisualStyleBackColor = True
        ' 
        ' DtpDate
        ' 
        DtpDate.Location = New Point(292, 484)
        DtpDate.Name = "DtpDate"
        DtpDate.Size = New Size(250, 27)
        DtpDate.TabIndex = 4
        ' 
        ' TxtDesc
        ' 
        TxtDesc.Location = New Point(292, 405)
        TxtDesc.Multiline = True
        TxtDesc.Name = "TxtDesc"
        TxtDesc.Size = New Size(250, 61)
        TxtDesc.TabIndex = 3
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(292, 360)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(250, 27)
        TxtName.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.Location = New Point(82, 576)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 35)
        Label5.TabIndex = 41
        Label5.Text = "Account : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(82, 527)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 35)
        Label4.TabIndex = 40
        Label4.Text = "Status : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(82, 476)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 35)
        Label3.TabIndex = 39
        Label3.Text = "Date : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(82, 405)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 35)
        Label2.TabIndex = 38
        Label2.Text = "Description : "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(82, 354)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 35)
        Label1.TabIndex = 37
        Label1.Text = "Type : "
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 15F)
        BtnSubmit.Location = New Point(356, 642)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(131, 54)
        BtnSubmit.TabIndex = 9
        BtnSubmit.Text = "Update"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(81, 642)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(131, 54)
        BtnReset.TabIndex = 8
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(82, 301)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 35)
        Label6.TabIndex = 48
        Label6.Text = "ID : "
        ' 
        ' TxtID
        ' 
        TxtID.Location = New Point(296, 303)
        TxtID.Name = "TxtID"
        TxtID.ReadOnly = True
        TxtID.Size = New Size(60, 27)
        TxtID.TabIndex = 1
        ' 
        ' incidentUpdate
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1096, 722)
        Controls.Add(TxtID)
        Controls.Add(Label6)
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
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(DgvShowIncidentRecords)
        Name = "incidentUpdate"
        Text = "incidentUpdate"
        CType(DgvShowIncidentRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvShowIncidentRecords As DataGridView
    Friend WithEvents BtnOpenIncidentDashboard As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents CboAccounts As ComboBox
    Friend WithEvents RbPending As RadioButton
    Friend WithEvents RbResolved As RadioButton
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtID As TextBox
End Class
