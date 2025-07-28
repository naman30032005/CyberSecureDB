<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class incidentrecords
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
        DgvShowIncidentRecords.Location = New Point(21, 21)
        DgvShowIncidentRecords.MultiSelect = False
        DgvShowIncidentRecords.Name = "DgvShowIncidentRecords"
        DgvShowIncidentRecords.ReadOnly = True
        DgvShowIncidentRecords.RowHeadersWidth = 51
        DgvShowIncidentRecords.RowTemplate.Height = 50
        DgvShowIncidentRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvShowIncidentRecords.Size = New Size(1067, 502)
        DgvShowIncidentRecords.TabIndex = 1
        ' 
        ' BtnOpenIncidentDashboard
        ' 
        BtnOpenIncidentDashboard.Font = New Font("Segoe UI", 15F)
        BtnOpenIncidentDashboard.Location = New Point(469, 559)
        BtnOpenIncidentDashboard.Name = "BtnOpenIncidentDashboard"
        BtnOpenIncidentDashboard.Size = New Size(203, 60)
        BtnOpenIncidentDashboard.TabIndex = 3
        BtnOpenIncidentDashboard.Text = "⬅️ Back"
        BtnOpenIncidentDashboard.UseVisualStyleBackColor = True
        ' 
        ' incidentrecords
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1100, 641)
        Controls.Add(BtnOpenIncidentDashboard)
        Controls.Add(DgvShowIncidentRecords)
        Name = "incidentrecords"
        Text = "Incident Records"
        CType(DgvShowIncidentRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvShowIncidentRecords As DataGridView
    Friend WithEvents BtnOpenIncidentDashboard As Button
End Class
