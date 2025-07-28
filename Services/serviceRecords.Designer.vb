<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class serviceRecords
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
        DgvShowServiceRecords.Location = New Point(51, 27)
        DgvShowServiceRecords.MultiSelect = False
        DgvShowServiceRecords.Name = "DgvShowServiceRecords"
        DgvShowServiceRecords.ReadOnly = True
        DgvShowServiceRecords.RowHeadersWidth = 51
        DgvShowServiceRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvShowServiceRecords.Size = New Size(698, 306)
        DgvShowServiceRecords.TabIndex = 0
        ' 
        ' BtnOpenServiceDashboard
        ' 
        BtnOpenServiceDashboard.Font = New Font("Segoe UI", 15F)
        BtnOpenServiceDashboard.Location = New Point(277, 368)
        BtnOpenServiceDashboard.Name = "BtnOpenServiceDashboard"
        BtnOpenServiceDashboard.Size = New Size(203, 60)
        BtnOpenServiceDashboard.TabIndex = 2
        BtnOpenServiceDashboard.Text = "⬅️ Back"
        BtnOpenServiceDashboard.UseVisualStyleBackColor = True
        ' 
        ' serviceRecords
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnOpenServiceDashboard)
        Controls.Add(DgvShowServiceRecords)
        Name = "serviceRecords"
        Text = "Service Records"
        CType(DgvShowServiceRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvShowServiceRecords As DataGridView
    Friend WithEvents BtnOpenServiceDashboard As Button
End Class
