<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingDelete
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
        DgvShowBillingRecords = New DataGridView()
        BtnOpenBillingDashboard = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        BtnSubmit = New Button()
        BtnReset = New Button()
        CType(DgvShowBillingRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvShowBillingRecords
        ' 
        DgvShowBillingRecords.AllowUserToAddRows = False
        DgvShowBillingRecords.AllowUserToDeleteRows = False
        DgvShowBillingRecords.AllowUserToOrderColumns = True
        DgvShowBillingRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvShowBillingRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvShowBillingRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvShowBillingRecords.EditMode = DataGridViewEditMode.EditProgrammatically
        DgvShowBillingRecords.Location = New Point(57, 21)
        DgvShowBillingRecords.MultiSelect = False
        DgvShowBillingRecords.Name = "DgvShowBillingRecords"
        DgvShowBillingRecords.ReadOnly = True
        DgvShowBillingRecords.RowHeadersWidth = 51
        DgvShowBillingRecords.RowTemplate.Height = 50
        DgvShowBillingRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvShowBillingRecords.Size = New Size(968, 288)
        DgvShowBillingRecords.TabIndex = 1
        ' 
        ' BtnOpenBillingDashboard
        ' 
        BtnOpenBillingDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenBillingDashboard.Location = New Point(753, 511)
        BtnOpenBillingDashboard.Margin = New Padding(3, 5, 3, 5)
        BtnOpenBillingDashboard.Name = "BtnOpenBillingDashboard"
        BtnOpenBillingDashboard.Size = New Size(294, 62)
        BtnOpenBillingDashboard.TabIndex = 14
        BtnOpenBillingDashboard.Text = "⬅️ Back"
        BtnOpenBillingDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(753, 421)
        BtnTestConnection.Margin = New Padding(3, 5, 3, 5)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(294, 62)
        BtnTestConnection.TabIndex = 13
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(753, 333)
        BtnOpenDashboard.Margin = New Padding(3, 5, 3, 5)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(294, 62)
        BtnOpenDashboard.TabIndex = 12
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 15F)
        BtnSubmit.Location = New Point(448, 445)
        BtnSubmit.Margin = New Padding(3, 5, 3, 5)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(147, 62)
        BtnSubmit.TabIndex = 16
        BtnSubmit.Text = "Delete"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(190, 443)
        BtnReset.Margin = New Padding(3, 5, 3, 5)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(147, 62)
        BtnReset.TabIndex = 15
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' BillingDelete
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1078, 597)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnReset)
        Controls.Add(BtnOpenBillingDashboard)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(DgvShowBillingRecords)
        Name = "BillingDelete"
        Text = "BillingDelete"
        CType(DgvShowBillingRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvShowBillingRecords As DataGridView
    Friend WithEvents BtnOpenBillingDashboard As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
End Class
