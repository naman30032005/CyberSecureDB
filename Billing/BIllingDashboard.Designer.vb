<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BIllingDashboard
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
        BtnOpenBillingRecords = New Button()
        BtnOpenDeleteBilling = New Button()
        BtnOpenUpdateBilling = New Button()
        BtnopenBilling = New Button()
        SuspendLayout()
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 15F)
        BtnOpenDashboard.Location = New Point(285, 339)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(213, 64)
        BtnOpenDashboard.TabIndex = 19
        BtnOpenDashboard.Text = "⬅️ Back"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenBillingRecords
        ' 
        BtnOpenBillingRecords.Font = New Font("Segoe UI", 15F)
        BtnOpenBillingRecords.Location = New Point(233, 192)
        BtnOpenBillingRecords.Name = "BtnOpenBillingRecords"
        BtnOpenBillingRecords.Size = New Size(355, 64)
        BtnOpenBillingRecords.TabIndex = 18
        BtnOpenBillingRecords.Text = "See All Bills Records"
        BtnOpenBillingRecords.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDeleteBilling
        ' 
        BtnOpenDeleteBilling.Font = New Font("Segoe UI", 15F)
        BtnOpenDeleteBilling.Location = New Point(570, 47)
        BtnOpenDeleteBilling.Name = "BtnOpenDeleteBilling"
        BtnOpenDeleteBilling.Size = New Size(213, 64)
        BtnOpenDeleteBilling.TabIndex = 17
        BtnOpenDeleteBilling.Text = "Delete Bills"
        BtnOpenDeleteBilling.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenUpdateBilling
        ' 
        BtnOpenUpdateBilling.Font = New Font("Segoe UI", 15F)
        BtnOpenUpdateBilling.Location = New Point(285, 47)
        BtnOpenUpdateBilling.Name = "BtnOpenUpdateBilling"
        BtnOpenUpdateBilling.Size = New Size(213, 64)
        BtnOpenUpdateBilling.TabIndex = 16
        BtnOpenUpdateBilling.Text = "Update Bills"
        BtnOpenUpdateBilling.UseVisualStyleBackColor = True
        ' 
        ' BtnopenBilling
        ' 
        BtnopenBilling.Font = New Font("Segoe UI", 15F)
        BtnopenBilling.Location = New Point(17, 47)
        BtnopenBilling.Name = "BtnopenBilling"
        BtnopenBilling.Size = New Size(213, 64)
        BtnopenBilling.TabIndex = 15
        BtnopenBilling.Text = "Add Bills"
        BtnopenBilling.UseVisualStyleBackColor = True
        ' 
        ' BIllingDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(840, 446)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(BtnOpenBillingRecords)
        Controls.Add(BtnOpenDeleteBilling)
        Controls.Add(BtnOpenUpdateBilling)
        Controls.Add(BtnopenBilling)
        Name = "BIllingDashboard"
        Text = "BIllingDashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnOpenBillingRecords As Button
    Friend WithEvents BtnOpenDeleteBilling As Button
    Friend WithEvents BtnOpenUpdateBilling As Button
    Friend WithEvents BtnopenBilling As Button
End Class
