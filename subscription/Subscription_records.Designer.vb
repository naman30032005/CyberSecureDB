<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subscription_records
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
        DGVSubscriptionRecords = New DataGridView()
        BtnopenSubscrpitions = New Button()
        CType(DGVSubscriptionRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGVSubscriptionRecords
        ' 
        DGVSubscriptionRecords.AllowUserToAddRows = False
        DGVSubscriptionRecords.AllowUserToDeleteRows = False
        DGVSubscriptionRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVSubscriptionRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGVSubscriptionRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVSubscriptionRecords.EditMode = DataGridViewEditMode.EditProgrammatically
        DGVSubscriptionRecords.Location = New Point(47, 34)
        DGVSubscriptionRecords.MultiSelect = False
        DGVSubscriptionRecords.Name = "DGVSubscriptionRecords"
        DGVSubscriptionRecords.RowHeadersWidth = 51
        DGVSubscriptionRecords.Size = New Size(849, 418)
        DGVSubscriptionRecords.TabIndex = 0
        ' 
        ' BtnopenSubscrpitions
        ' 
        BtnopenSubscrpitions.Font = New Font("Segoe UI", 15F)
        BtnopenSubscrpitions.Location = New Point(315, 493)
        BtnopenSubscrpitions.Name = "BtnopenSubscrpitions"
        BtnopenSubscrpitions.Size = New Size(302, 55)
        BtnopenSubscrpitions.TabIndex = 1
        BtnopenSubscrpitions.Text = "⬅️ Back"
        BtnopenSubscrpitions.UseVisualStyleBackColor = True
        ' 
        ' Subscription_records
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(937, 588)
        Controls.Add(BtnopenSubscrpitions)
        Controls.Add(DGVSubscriptionRecords)
        Name = "Subscription_records"
        Text = "Subscription records"
        CType(DGVSubscriptionRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DGVSubscriptionRecords As DataGridView
    Friend WithEvents BtnopenSubscrpitions As Button
End Class
