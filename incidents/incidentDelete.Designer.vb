<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class incidentDelete
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
        BtnSubmit = New Button()
        BtnReset = New Button()
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
        DgvShowIncidentRecords.Location = New Point(12, 12)
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
        BtnOpenIncidentDashboard.Location = New Point(799, 471)
        BtnOpenIncidentDashboard.Name = "BtnOpenIncidentDashboard"
        BtnOpenIncidentDashboard.Size = New Size(261, 54)
        BtnOpenIncidentDashboard.TabIndex = 5
        BtnOpenIncidentDashboard.Text = "⬅️ Back"
        BtnOpenIncidentDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(799, 386)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(261, 54)
        BtnTestConnection.TabIndex = 4
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(799, 310)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(261, 54)
        BtnOpenDashboard.TabIndex = 3
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 15F)
        BtnSubmit.Location = New Point(444, 384)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(131, 54)
        BtnSubmit.TabIndex = 2
        BtnSubmit.Text = "Delete"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(169, 384)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(131, 54)
        BtnReset.TabIndex = 1
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' incidentDelete
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1096, 568)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnReset)
        Controls.Add(BtnOpenIncidentDashboard)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(DgvShowIncidentRecords)
        Name = "incidentDelete"
        Text = "incidentDelete"
        CType(DgvShowIncidentRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvShowIncidentRecords As DataGridView
    Friend WithEvents BtnOpenIncidentDashboard As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
End Class
