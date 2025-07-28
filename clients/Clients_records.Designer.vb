<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients_records
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
        DgvClientRecords = New DataGridView()
        BtnOpenClientsDashboard = New Button()
        CType(DgvClientRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvClientRecords
        ' 
        DgvClientRecords.AllowUserToAddRows = False
        DgvClientRecords.AllowUserToDeleteRows = False
        DgvClientRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvClientRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvClientRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvClientRecords.EditMode = DataGridViewEditMode.EditProgrammatically
        DgvClientRecords.Location = New Point(41, 28)
        DgvClientRecords.MultiSelect = False
        DgvClientRecords.Name = "DgvClientRecords"
        DgvClientRecords.RowHeadersWidth = 51
        DgvClientRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvClientRecords.Size = New Size(842, 428)
        DgvClientRecords.TabIndex = 0
        ' 
        ' BtnOpenClientsDashboard
        ' 
        BtnOpenClientsDashboard.Font = New Font("Segoe UI", 15F)
        BtnOpenClientsDashboard.Location = New Point(361, 500)
        BtnOpenClientsDashboard.Name = "BtnOpenClientsDashboard"
        BtnOpenClientsDashboard.Size = New Size(203, 60)
        BtnOpenClientsDashboard.TabIndex = 1
        BtnOpenClientsDashboard.Text = "⬅️ Back"
        BtnOpenClientsDashboard.UseVisualStyleBackColor = True
        ' 
        ' Clients_records
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(934, 599)
        Controls.Add(BtnOpenClientsDashboard)
        Controls.Add(DgvClientRecords)
        Name = "Clients_records"
        Text = "Clients Records"
        CType(DgvClientRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvClientRecords As DataGridView
    Friend WithEvents BtnOpenClientsDashboard As Button
End Class
