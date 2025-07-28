<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subscription_delete
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
        DgvDeleteSubscription = New DataGridView()
        BtnReset = New Button()
        BtnDelete = New Button()
        BtnOpenDashboard = New Button()
        BtnTestConnection = New Button()
        BtnOpenSubDashboard = New Button()
        CType(DgvDeleteSubscription, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvDeleteSubscription
        ' 
        DgvDeleteSubscription.AllowUserToAddRows = False
        DgvDeleteSubscription.AllowUserToDeleteRows = False
        DgvDeleteSubscription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvDeleteSubscription.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvDeleteSubscription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvDeleteSubscription.EditMode = DataGridViewEditMode.EditProgrammatically
        DgvDeleteSubscription.Location = New Point(50, 24)
        DgvDeleteSubscription.MultiSelect = False
        DgvDeleteSubscription.Name = "DgvDeleteSubscription"
        DgvDeleteSubscription.RowHeadersWidth = 51
        DgvDeleteSubscription.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvDeleteSubscription.Size = New Size(871, 353)
        DgvDeleteSubscription.TabIndex = 0
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 12F)
        BtnReset.Location = New Point(90, 469)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(191, 56)
        BtnReset.TabIndex = 1
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Font = New Font("Segoe UI", 12F)
        BtnDelete.Location = New Point(411, 469)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(191, 56)
        BtnDelete.TabIndex = 2
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(692, 394)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(229, 56)
        BtnOpenDashboard.TabIndex = 3
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(692, 469)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(229, 56)
        BtnTestConnection.TabIndex = 4
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenSubDashboard
        ' 
        BtnOpenSubDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenSubDashboard.Location = New Point(692, 545)
        BtnOpenSubDashboard.Name = "BtnOpenSubDashboard"
        BtnOpenSubDashboard.Size = New Size(229, 56)
        BtnOpenSubDashboard.TabIndex = 5
        BtnOpenSubDashboard.Text = "⬅️ Back"
        BtnOpenSubDashboard.UseVisualStyleBackColor = True
        ' 
        ' Subscription_delete
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(949, 613)
        Controls.Add(BtnOpenSubDashboard)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(BtnDelete)
        Controls.Add(BtnReset)
        Controls.Add(DgvDeleteSubscription)
        Name = "Subscription_delete"
        Text = "Delete Subscription"
        CType(DgvDeleteSubscription, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvDeleteSubscription As DataGridView
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenSubDashboard As Button
End Class
