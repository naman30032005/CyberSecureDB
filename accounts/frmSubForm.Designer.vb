<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubForm
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
        CboServices = New ComboBox()
        Label2 = New Label()
        DtpSubDate = New DateTimePicker()
        DgvShowAccountRecords = New DataGridView()
        BtnInsertSubscription = New Button()
        BtnDeleteSusbcription = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        BtnOpenAccountUpdate = New Button()
        Label3 = New Label()
        TxtaccountName = New TextBox()
        CType(DgvShowAccountRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(41, 383)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 35)
        Label1.TabIndex = 39
        Label1.Text = "Service :"
        ' 
        ' CboServices
        ' 
        CboServices.FormattingEnabled = True
        CboServices.Location = New Point(360, 390)
        CboServices.Name = "CboServices"
        CboServices.Size = New Size(261, 28)
        CboServices.TabIndex = 40
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(41, 434)
        Label2.Name = "Label2"
        Label2.Size = New Size(224, 35)
        Label2.TabIndex = 41
        Label2.Text = "Subscription Date :"
        ' 
        ' DtpSubDate
        ' 
        DtpSubDate.Location = New Point(360, 445)
        DtpSubDate.Name = "DtpSubDate"
        DtpSubDate.Size = New Size(261, 27)
        DtpSubDate.TabIndex = 42
        ' 
        ' DgvShowAccountRecords
        ' 
        DgvShowAccountRecords.AllowUserToAddRows = False
        DgvShowAccountRecords.AllowUserToDeleteRows = False
        DgvShowAccountRecords.AllowUserToOrderColumns = True
        DgvShowAccountRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvShowAccountRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvShowAccountRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvShowAccountRecords.EditMode = DataGridViewEditMode.EditProgrammatically
        DgvShowAccountRecords.Location = New Point(39, 12)
        DgvShowAccountRecords.MultiSelect = False
        DgvShowAccountRecords.Name = "DgvShowAccountRecords"
        DgvShowAccountRecords.ReadOnly = True
        DgvShowAccountRecords.RowHeadersWidth = 51
        DgvShowAccountRecords.RowTemplate.Height = 50
        DgvShowAccountRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvShowAccountRecords.Size = New Size(968, 279)
        DgvShowAccountRecords.TabIndex = 43
        ' 
        ' BtnInsertSubscription
        ' 
        BtnInsertSubscription.Font = New Font("Segoe UI", 12F)
        BtnInsertSubscription.Location = New Point(41, 495)
        BtnInsertSubscription.Name = "BtnInsertSubscription"
        BtnInsertSubscription.Size = New Size(216, 48)
        BtnInsertSubscription.TabIndex = 44
        BtnInsertSubscription.Text = "Add Subscription"
        BtnInsertSubscription.UseVisualStyleBackColor = True
        ' 
        ' BtnDeleteSusbcription
        ' 
        BtnDeleteSusbcription.Font = New Font("Segoe UI", 12F)
        BtnDeleteSusbcription.Location = New Point(403, 495)
        BtnDeleteSusbcription.Name = "BtnDeleteSusbcription"
        BtnDeleteSusbcription.Size = New Size(218, 48)
        BtnDeleteSusbcription.TabIndex = 45
        BtnDeleteSusbcription.Text = "Delete Subscription"
        BtnDeleteSusbcription.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(726, 410)
        BtnTestConnection.Margin = New Padding(3, 5, 3, 5)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(294, 62)
        BtnTestConnection.TabIndex = 47
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(726, 322)
        BtnOpenDashboard.Margin = New Padding(3, 5, 3, 5)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(294, 62)
        BtnOpenDashboard.TabIndex = 46
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenAccountUpdate
        ' 
        BtnOpenAccountUpdate.Font = New Font("Segoe UI", 12F)
        BtnOpenAccountUpdate.Location = New Point(726, 488)
        BtnOpenAccountUpdate.Margin = New Padding(3, 5, 3, 5)
        BtnOpenAccountUpdate.Name = "BtnOpenAccountUpdate"
        BtnOpenAccountUpdate.Size = New Size(294, 62)
        BtnOpenAccountUpdate.TabIndex = 48
        BtnOpenAccountUpdate.Text = "⬅️ Back"
        BtnOpenAccountUpdate.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(41, 334)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 35)
        Label3.TabIndex = 49
        Label3.Text = "Account :"
        ' 
        ' TxtaccountName
        ' 
        TxtaccountName.Location = New Point(360, 343)
        TxtaccountName.Name = "TxtaccountName"
        TxtaccountName.ReadOnly = True
        TxtaccountName.Size = New Size(261, 27)
        TxtaccountName.TabIndex = 50
        ' 
        ' frmSubForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1032, 594)
        Controls.Add(TxtaccountName)
        Controls.Add(Label3)
        Controls.Add(BtnOpenAccountUpdate)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(BtnDeleteSusbcription)
        Controls.Add(BtnInsertSubscription)
        Controls.Add(DgvShowAccountRecords)
        Controls.Add(DtpSubDate)
        Controls.Add(Label2)
        Controls.Add(CboServices)
        Controls.Add(Label1)
        Name = "frmSubForm"
        Text = "Manage Services"
        CType(DgvShowAccountRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents CboServices As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpSubDate As DateTimePicker
    Friend WithEvents DgvShowAccountRecords As DataGridView
    Friend WithEvents BtnInsertSubscription As Button
    Friend WithEvents BtnDeleteSusbcription As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnOpenAccountUpdate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtaccountName As TextBox
End Class
