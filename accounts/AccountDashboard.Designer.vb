<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountDashboard
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
        BtnOpenAccountRecords = New Button()
        BtnOpenDeleteAccount = New Button()
        BtnOpenUpdateAccount = New Button()
        BtnopenAccount = New Button()
        SuspendLayout()
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 15F)
        BtnOpenDashboard.Location = New Point(285, 339)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(213, 64)
        BtnOpenDashboard.TabIndex = 24
        BtnOpenDashboard.Text = "⬅️ Back"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenAccountRecords
        ' 
        BtnOpenAccountRecords.Font = New Font("Segoe UI", 15F)
        BtnOpenAccountRecords.Location = New Point(233, 192)
        BtnOpenAccountRecords.Name = "BtnOpenAccountRecords"
        BtnOpenAccountRecords.Size = New Size(355, 64)
        BtnOpenAccountRecords.TabIndex = 23
        BtnOpenAccountRecords.Text = "See All Accounts"
        BtnOpenAccountRecords.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDeleteAccount
        ' 
        BtnOpenDeleteAccount.Font = New Font("Segoe UI", 15F)
        BtnOpenDeleteAccount.Location = New Point(570, 47)
        BtnOpenDeleteAccount.Name = "BtnOpenDeleteAccount"
        BtnOpenDeleteAccount.Size = New Size(213, 64)
        BtnOpenDeleteAccount.TabIndex = 22
        BtnOpenDeleteAccount.Text = "Delete Account"
        BtnOpenDeleteAccount.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenUpdateAccount
        ' 
        BtnOpenUpdateAccount.Font = New Font("Segoe UI", 15F)
        BtnOpenUpdateAccount.Location = New Point(285, 47)
        BtnOpenUpdateAccount.Name = "BtnOpenUpdateAccount"
        BtnOpenUpdateAccount.Size = New Size(213, 64)
        BtnOpenUpdateAccount.TabIndex = 21
        BtnOpenUpdateAccount.Text = "Update Account"
        BtnOpenUpdateAccount.UseVisualStyleBackColor = True
        ' 
        ' BtnopenAccount
        ' 
        BtnopenAccount.Font = New Font("Segoe UI", 15F)
        BtnopenAccount.Location = New Point(17, 47)
        BtnopenAccount.Name = "BtnopenAccount"
        BtnopenAccount.Size = New Size(213, 64)
        BtnopenAccount.TabIndex = 20
        BtnopenAccount.Text = "Add Account"
        BtnopenAccount.UseVisualStyleBackColor = True
        ' 
        ' AccountDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(821, 449)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(BtnOpenAccountRecords)
        Controls.Add(BtnOpenDeleteAccount)
        Controls.Add(BtnOpenUpdateAccount)
        Controls.Add(BtnopenAccount)
        Name = "AccountDashboard"
        Text = "AccountDashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnOpenAccountRecords As Button
    Friend WithEvents BtnOpenDeleteAccount As Button
    Friend WithEvents BtnOpenUpdateAccount As Button
    Friend WithEvents BtnopenAccount As Button
End Class
