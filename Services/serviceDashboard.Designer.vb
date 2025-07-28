<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class serviceDashboard
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
        BtnOpenServiceRecords = New Button()
        BtnOpenDeleteServices = New Button()
        BtnOpenUpdateServices = New Button()
        Btnopenservices = New Button()
        SuspendLayout()
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 15F)
        BtnOpenDashboard.Location = New Point(334, 361)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(213, 64)
        BtnOpenDashboard.TabIndex = 9
        BtnOpenDashboard.Text = "⬅️ Back"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenServiceRecords
        ' 
        BtnOpenServiceRecords.Font = New Font("Segoe UI", 15F)
        BtnOpenServiceRecords.Location = New Point(282, 214)
        BtnOpenServiceRecords.Name = "BtnOpenServiceRecords"
        BtnOpenServiceRecords.Size = New Size(355, 64)
        BtnOpenServiceRecords.TabIndex = 8
        BtnOpenServiceRecords.Text = "See All Service Records"
        BtnOpenServiceRecords.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDeleteServices
        ' 
        BtnOpenDeleteServices.Font = New Font("Segoe UI", 15F)
        BtnOpenDeleteServices.Location = New Point(619, 69)
        BtnOpenDeleteServices.Name = "BtnOpenDeleteServices"
        BtnOpenDeleteServices.Size = New Size(213, 64)
        BtnOpenDeleteServices.TabIndex = 7
        BtnOpenDeleteServices.Text = "Delete Services"
        BtnOpenDeleteServices.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenUpdateServices
        ' 
        BtnOpenUpdateServices.Font = New Font("Segoe UI", 15F)
        BtnOpenUpdateServices.Location = New Point(334, 69)
        BtnOpenUpdateServices.Name = "BtnOpenUpdateServices"
        BtnOpenUpdateServices.Size = New Size(213, 64)
        BtnOpenUpdateServices.TabIndex = 6
        BtnOpenUpdateServices.Text = "Update Services"
        BtnOpenUpdateServices.UseVisualStyleBackColor = True
        ' 
        ' Btnopenservices
        ' 
        Btnopenservices.Font = New Font("Segoe UI", 15F)
        Btnopenservices.Location = New Point(66, 69)
        Btnopenservices.Name = "Btnopenservices"
        Btnopenservices.Size = New Size(213, 64)
        Btnopenservices.TabIndex = 5
        Btnopenservices.Text = "Add Services"
        Btnopenservices.UseVisualStyleBackColor = True
        ' 
        ' serviceDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(899, 494)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(BtnOpenServiceRecords)
        Controls.Add(BtnOpenDeleteServices)
        Controls.Add(BtnOpenUpdateServices)
        Controls.Add(Btnopenservices)
        Name = "serviceDashboard"
        Text = "Services"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnOpenServiceRecords As Button
    Friend WithEvents BtnOpenDeleteServices As Button
    Friend WithEvents BtnOpenUpdateServices As Button
    Friend WithEvents Btnopenservices As Button
End Class
