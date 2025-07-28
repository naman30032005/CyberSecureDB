<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients_delete
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
        DgvDeleteClient = New DataGridView()
        BtnOpenClientDashboard = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        BtnDelete = New Button()
        BtnReset = New Button()
        CType(DgvDeleteClient, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvDeleteClient
        ' 
        DgvDeleteClient.AllowUserToAddRows = False
        DgvDeleteClient.AllowUserToDeleteRows = False
        DgvDeleteClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvDeleteClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvDeleteClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvDeleteClient.EditMode = DataGridViewEditMode.EditProgrammatically
        DgvDeleteClient.Location = New Point(44, 12)
        DgvDeleteClient.MultiSelect = False
        DgvDeleteClient.Name = "DgvDeleteClient"
        DgvDeleteClient.RowHeadersWidth = 51
        DgvDeleteClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvDeleteClient.Size = New Size(871, 353)
        DgvDeleteClient.TabIndex = 1
        ' 
        ' BtnOpenClientDashboard
        ' 
        BtnOpenClientDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenClientDashboard.Location = New Point(690, 549)
        BtnOpenClientDashboard.Name = "BtnOpenClientDashboard"
        BtnOpenClientDashboard.Size = New Size(229, 56)
        BtnOpenClientDashboard.TabIndex = 10
        BtnOpenClientDashboard.Text = "⬅️ Back"
        BtnOpenClientDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(690, 473)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(229, 56)
        BtnTestConnection.TabIndex = 9
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(690, 398)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(229, 56)
        BtnOpenDashboard.TabIndex = 8
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Font = New Font("Segoe UI", 12F)
        BtnDelete.Location = New Point(409, 473)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(191, 56)
        BtnDelete.TabIndex = 7
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 12F)
        BtnReset.Location = New Point(88, 473)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(191, 56)
        BtnReset.TabIndex = 6
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' Clients_delete
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 633)
        Controls.Add(BtnOpenClientDashboard)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(BtnDelete)
        Controls.Add(BtnReset)
        Controls.Add(DgvDeleteClient)
        Name = "Clients_delete"
        Text = "Clients_delete"
        CType(DgvDeleteClient, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvDeleteClient As DataGridView
    Friend WithEvents BtnOpenClientDashboard As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnReset As Button
End Class
