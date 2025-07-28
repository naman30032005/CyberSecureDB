<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountDelete
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
        DgvShowAccountRecords = New DataGridView()
        BtnOpenAccountDashboard = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        BtnSubmit = New Button()
        BtnReset = New Button()
        CType(DgvShowAccountRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        DgvShowAccountRecords.Location = New Point(45, 12)
        DgvShowAccountRecords.MultiSelect = False
        DgvShowAccountRecords.Name = "DgvShowAccountRecords"
        DgvShowAccountRecords.ReadOnly = True
        DgvShowAccountRecords.RowHeadersWidth = 51
        DgvShowAccountRecords.RowTemplate.Height = 50
        DgvShowAccountRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvShowAccountRecords.Size = New Size(968, 279)
        DgvShowAccountRecords.TabIndex = 1
        ' 
        ' BtnOpenAccountDashboard
        ' 
        BtnOpenAccountDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenAccountDashboard.Location = New Point(719, 514)
        BtnOpenAccountDashboard.Margin = New Padding(3, 5, 3, 5)
        BtnOpenAccountDashboard.Name = "BtnOpenAccountDashboard"
        BtnOpenAccountDashboard.Size = New Size(294, 62)
        BtnOpenAccountDashboard.TabIndex = 11
        BtnOpenAccountDashboard.Text = "⬅️ Back"
        BtnOpenAccountDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(719, 433)
        BtnTestConnection.Margin = New Padding(3, 5, 3, 5)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(294, 62)
        BtnTestConnection.TabIndex = 10
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(719, 345)
        BtnOpenDashboard.Margin = New Padding(3, 5, 3, 5)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(294, 62)
        BtnOpenDashboard.TabIndex = 9
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 15F)
        BtnSubmit.Location = New Point(467, 433)
        BtnSubmit.Margin = New Padding(3, 5, 3, 5)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(147, 62)
        BtnSubmit.TabIndex = 13
        BtnSubmit.Text = "Delete"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(158, 433)
        BtnReset.Margin = New Padding(3, 5, 3, 5)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(147, 62)
        BtnReset.TabIndex = 12
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' AccountDelete
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1080, 621)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnReset)
        Controls.Add(BtnOpenAccountDashboard)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(DgvShowAccountRecords)
        Name = "AccountDelete"
        Text = "AccountDelete"
        CType(DgvShowAccountRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvShowAccountRecords As DataGridView
    Friend WithEvents BtnOpenAccountDashboard As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
End Class
