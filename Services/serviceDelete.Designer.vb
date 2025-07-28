<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class serviceDelete
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
        DgvShowServiceRecords = New DataGridView()
        BtnOpenServiceDashboard = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        BtnSubmit = New Button()
        BtnReset = New Button()
        CType(DgvShowServiceRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvShowServiceRecords
        ' 
        DgvShowServiceRecords.AllowUserToAddRows = False
        DgvShowServiceRecords.AllowUserToDeleteRows = False
        DgvShowServiceRecords.AllowUserToOrderColumns = True
        DgvShowServiceRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvShowServiceRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvShowServiceRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvShowServiceRecords.EditMode = DataGridViewEditMode.EditProgrammatically
        DgvShowServiceRecords.Location = New Point(40, 12)
        DgvShowServiceRecords.Name = "DgvShowServiceRecords"
        DgvShowServiceRecords.ReadOnly = True
        DgvShowServiceRecords.RowHeadersWidth = 51
        DgvShowServiceRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvShowServiceRecords.Size = New Size(712, 207)
        DgvShowServiceRecords.TabIndex = 0
        ' 
        ' BtnOpenServiceDashboard
        ' 
        BtnOpenServiceDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenServiceDashboard.Location = New Point(508, 426)
        BtnOpenServiceDashboard.Name = "BtnOpenServiceDashboard"
        BtnOpenServiceDashboard.Size = New Size(261, 54)
        BtnOpenServiceDashboard.TabIndex = 5
        BtnOpenServiceDashboard.Text = "⬅️ Back"
        BtnOpenServiceDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(508, 345)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(261, 54)
        BtnTestConnection.TabIndex = 4
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(508, 262)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(261, 54)
        BtnOpenDashboard.TabIndex = 3
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 15F)
        BtnSubmit.Location = New Point(294, 362)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(172, 64)
        BtnSubmit.TabIndex = 2
        BtnSubmit.Text = "Delete"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(40, 362)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(185, 64)
        BtnReset.TabIndex = 1
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' serviceDelete
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 492)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnReset)
        Controls.Add(BtnOpenServiceDashboard)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(DgvShowServiceRecords)
        Name = "serviceDelete"
        Text = "serviceDelete"
        CType(DgvShowServiceRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvShowServiceRecords As DataGridView
    Friend WithEvents BtnOpenServiceDashboard As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
End Class
