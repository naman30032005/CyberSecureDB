<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client_dashboard
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
        Btnopenclients = New Button()
        BtnOpenUpdateClients = New Button()
        BtnOpenDeleteClients = New Button()
        BtnOpenClientRecords = New Button()
        BtnOpenDashboard = New Button()
        SuspendLayout()
        ' 
        ' Btnopenclients
        ' 
        Btnopenclients.Font = New Font("Segoe UI", 15F)
        Btnopenclients.Location = New Point(43, 99)
        Btnopenclients.Name = "Btnopenclients"
        Btnopenclients.Size = New Size(213, 64)
        Btnopenclients.TabIndex = 0
        Btnopenclients.Text = "Add Clients"
        Btnopenclients.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenUpdateClients
        ' 
        BtnOpenUpdateClients.Font = New Font("Segoe UI", 15F)
        BtnOpenUpdateClients.Location = New Point(311, 99)
        BtnOpenUpdateClients.Name = "BtnOpenUpdateClients"
        BtnOpenUpdateClients.Size = New Size(213, 64)
        BtnOpenUpdateClients.TabIndex = 1
        BtnOpenUpdateClients.Text = "Update Clients"
        BtnOpenUpdateClients.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDeleteClients
        ' 
        BtnOpenDeleteClients.Font = New Font("Segoe UI", 15F)
        BtnOpenDeleteClients.Location = New Point(596, 99)
        BtnOpenDeleteClients.Name = "BtnOpenDeleteClients"
        BtnOpenDeleteClients.Size = New Size(213, 64)
        BtnOpenDeleteClients.TabIndex = 2
        BtnOpenDeleteClients.Text = "Delete Clients"
        BtnOpenDeleteClients.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenClientRecords
        ' 
        BtnOpenClientRecords.Font = New Font("Segoe UI", 15F)
        BtnOpenClientRecords.Location = New Point(259, 244)
        BtnOpenClientRecords.Name = "BtnOpenClientRecords"
        BtnOpenClientRecords.Size = New Size(355, 64)
        BtnOpenClientRecords.TabIndex = 3
        BtnOpenClientRecords.Text = "See All Client Records"
        BtnOpenClientRecords.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 15F)
        BtnOpenDashboard.Location = New Point(311, 391)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(213, 64)
        BtnOpenDashboard.TabIndex = 4
        BtnOpenDashboard.Text = "⬅️ Back"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' client_dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(859, 491)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(BtnOpenClientRecords)
        Controls.Add(BtnOpenDeleteClients)
        Controls.Add(BtnOpenUpdateClients)
        Controls.Add(Btnopenclients)
        Name = "client_dashboard"
        Text = "Client Dashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btnopenclients As Button
    Friend WithEvents BtnOpenUpdateClients As Button
    Friend WithEvents BtnOpenDeleteClients As Button
    Friend WithEvents BtnOpenClientRecords As Button
    Friend WithEvents BtnOpenDashboard As Button
End Class
