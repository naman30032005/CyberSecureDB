<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class incidentDashboard
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
        BtnOpenDashboard = New Button()
        BtnOpenIncidentRecords = New Button()
        BtnOpenDeleteIncidents = New Button()
        BtnOpenUpdateIncidents = New Button()
        BtnopenIncidents = New Button()
        SuspendLayout()
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 15F)
        BtnOpenDashboard.Location = New Point(319, 339)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(213, 64)
        BtnOpenDashboard.TabIndex = 14
        BtnOpenDashboard.Text = "⬅️ Back"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenIncidentRecords
        ' 
        BtnOpenIncidentRecords.Font = New Font("Segoe UI", 15F)
        BtnOpenIncidentRecords.Location = New Point(267, 192)
        BtnOpenIncidentRecords.Name = "BtnOpenIncidentRecords"
        BtnOpenIncidentRecords.Size = New Size(355, 64)
        BtnOpenIncidentRecords.TabIndex = 13
        BtnOpenIncidentRecords.Text = "See All Incident Records"
        BtnOpenIncidentRecords.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDeleteIncidents
        ' 
        BtnOpenDeleteIncidents.Font = New Font("Segoe UI", 15F)
        BtnOpenDeleteIncidents.Location = New Point(604, 47)
        BtnOpenDeleteIncidents.Name = "BtnOpenDeleteIncidents"
        BtnOpenDeleteIncidents.Size = New Size(213, 64)
        BtnOpenDeleteIncidents.TabIndex = 12
        BtnOpenDeleteIncidents.Text = "Delete Incidents"
        BtnOpenDeleteIncidents.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenUpdateIncidents
        ' 
        BtnOpenUpdateIncidents.Font = New Font("Segoe UI", 15F)
        BtnOpenUpdateIncidents.Location = New Point(319, 47)
        BtnOpenUpdateIncidents.Name = "BtnOpenUpdateIncidents"
        BtnOpenUpdateIncidents.Size = New Size(213, 64)
        BtnOpenUpdateIncidents.TabIndex = 11
        BtnOpenUpdateIncidents.Text = "Update Incidents"
        BtnOpenUpdateIncidents.UseVisualStyleBackColor = True
        ' 
        ' BtnopenIncidents
        ' 
        BtnopenIncidents.Font = New Font("Segoe UI", 15F)
        BtnopenIncidents.Location = New Point(51, 47)
        BtnopenIncidents.Name = "BtnopenIncidents"
        BtnopenIncidents.Size = New Size(213, 64)
        BtnopenIncidents.TabIndex = 10
        BtnopenIncidents.Text = "Add Incidents"
        BtnopenIncidents.UseVisualStyleBackColor = True
        ' 
        ' incidentDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(869, 450)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(BtnOpenIncidentRecords)
        Controls.Add(BtnOpenDeleteIncidents)
        Controls.Add(BtnOpenUpdateIncidents)
        Controls.Add(BtnopenIncidents)
        Name = "incidentDashboard"
        Text = "Incidents"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnOpenIncidentRecords As Button
    Friend WithEvents BtnOpenDeleteIncidents As Button
    Friend WithEvents BtnOpenUpdateIncidents As Button
    Friend WithEvents BtnopenIncidents As Button
End Class
