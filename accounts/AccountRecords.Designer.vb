<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountRecords
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
        DgvShowAccountRecords.Location = New Point(62, 12)
        DgvShowAccountRecords.MultiSelect = False
        DgvShowAccountRecords.Name = "DgvShowAccountRecords"
        DgvShowAccountRecords.ReadOnly = True
        DgvShowAccountRecords.RowHeadersWidth = 51
        DgvShowAccountRecords.RowTemplate.Height = 50
        DgvShowAccountRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvShowAccountRecords.Size = New Size(968, 464)
        DgvShowAccountRecords.TabIndex = 3
        ' 
        ' BtnOpenAccountDashboard
        ' 
        BtnOpenAccountDashboard.Font = New Font("Segoe UI", 15F)
        BtnOpenAccountDashboard.Location = New Point(449, 506)
        BtnOpenAccountDashboard.Name = "BtnOpenAccountDashboard"
        BtnOpenAccountDashboard.Size = New Size(203, 60)
        BtnOpenAccountDashboard.TabIndex = 5
        BtnOpenAccountDashboard.Text = "⬅️ Back"
        BtnOpenAccountDashboard.UseVisualStyleBackColor = True
        ' 
        ' AccountRecords
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1086, 578)
        Controls.Add(BtnOpenAccountDashboard)
        Controls.Add(DgvShowAccountRecords)
        Name = "AccountRecords"
        Text = "AccountRecords"
        CType(DgvShowAccountRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvShowAccountRecords As DataGridView
    Friend WithEvents BtnOpenAccountDashboard As Button
End Class
