<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billingRecords
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
        DgvShowBillingRecords.Location = New Point(51, 30)
        DgvShowBillingRecords.MultiSelect = False
        DgvShowBillingRecords.Name = "DgvShowBillingRecords"
        DgvShowBillingRecords.ReadOnly = True
        DgvShowBillingRecords.RowHeadersWidth = 51
        DgvShowBillingRecords.RowTemplate.Height = 50
        DgvShowBillingRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvShowBillingRecords.Size = New Size(968, 464)
        DgvShowBillingRecords.TabIndex = 2
        ' 
        ' BtnOpenBillingDashboard
        ' 
        BtnOpenBillingDashboard.Font = New Font("Segoe UI", 15F)
        BtnOpenBillingDashboard.Location = New Point(433, 538)
        BtnOpenBillingDashboard.Name = "BtnOpenBillingDashboard"
        BtnOpenBillingDashboard.Size = New Size(203, 60)
        BtnOpenBillingDashboard.TabIndex = 4
        BtnOpenBillingDashboard.Text = "⬅️ Back"
        BtnOpenBillingDashboard.UseVisualStyleBackColor = True
        ' 
        ' billingRecords
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1068, 628)
        Controls.Add(BtnOpenBillingDashboard)
        Controls.Add(DgvShowBillingRecords)
        Name = "billingRecords"
        Text = "Billing Records"
        CType(DgvShowBillingRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvShowBillingRecords As DataGridView
    Friend WithEvents BtnOpenBillingDashboard As Button
End Class
