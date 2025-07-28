<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnOpenClients = New Button()
        BtnOpenAccounts = New Button()
        BtnOpenServices = New Button()
        BtnOpenSubscriptions = New Button()
        BtnOpenIncidents = New Button()
        BtnClose = New Button()
        BtnOpenBilling = New Button()
        SuspendLayout()
        ' 
        ' BtnOpenClients
        ' 
        BtnOpenClients.Font = New Font("Segoe UI", 15F)
        BtnOpenClients.ForeColor = Color.Black
        BtnOpenClients.Location = New Point(66, 71)
        BtnOpenClients.Name = "BtnOpenClients"
        BtnOpenClients.Size = New Size(269, 58)
        BtnOpenClients.TabIndex = 0
        BtnOpenClients.Text = "Clients"
        BtnOpenClients.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenAccounts
        ' 
        BtnOpenAccounts.Font = New Font("Segoe UI", 15F)
        BtnOpenAccounts.ForeColor = Color.Black
        BtnOpenAccounts.Location = New Point(511, 71)
        BtnOpenAccounts.Name = "BtnOpenAccounts"
        BtnOpenAccounts.Size = New Size(269, 58)
        BtnOpenAccounts.TabIndex = 1
        BtnOpenAccounts.Text = "Accounts"
        BtnOpenAccounts.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenServices
        ' 
        BtnOpenServices.Font = New Font("Segoe UI", 15F)
        BtnOpenServices.ForeColor = Color.Black
        BtnOpenServices.Location = New Point(66, 204)
        BtnOpenServices.Name = "BtnOpenServices"
        BtnOpenServices.Size = New Size(269, 58)
        BtnOpenServices.TabIndex = 2
        BtnOpenServices.Text = "Services"
        BtnOpenServices.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenSubscriptions
        ' 
        BtnOpenSubscriptions.Font = New Font("Segoe UI", 15F)
        BtnOpenSubscriptions.ForeColor = Color.Black
        BtnOpenSubscriptions.Location = New Point(511, 204)
        BtnOpenSubscriptions.Name = "BtnOpenSubscriptions"
        BtnOpenSubscriptions.Size = New Size(269, 58)
        BtnOpenSubscriptions.TabIndex = 3
        BtnOpenSubscriptions.Text = "Subscriptions"
        BtnOpenSubscriptions.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenIncidents
        ' 
        BtnOpenIncidents.Font = New Font("Segoe UI", 15F)
        BtnOpenIncidents.ForeColor = Color.Black
        BtnOpenIncidents.Location = New Point(66, 331)
        BtnOpenIncidents.Name = "BtnOpenIncidents"
        BtnOpenIncidents.Size = New Size(269, 58)
        BtnOpenIncidents.TabIndex = 4
        BtnOpenIncidents.Text = "Incidents"
        BtnOpenIncidents.UseVisualStyleBackColor = True
        ' 
        ' BtnClose
        ' 
        BtnClose.Font = New Font("Segoe UI", 15F)
        BtnClose.Location = New Point(297, 453)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(269, 58)
        BtnClose.TabIndex = 6
        BtnClose.Text = "Close"
        BtnClose.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenBilling
        ' 
        BtnOpenBilling.Font = New Font("Segoe UI", 15F)
        BtnOpenBilling.ForeColor = Color.Black
        BtnOpenBilling.Location = New Point(511, 331)
        BtnOpenBilling.Name = "BtnOpenBilling"
        BtnOpenBilling.Size = New Size(269, 58)
        BtnOpenBilling.TabIndex = 5
        BtnOpenBilling.Text = "Billing"
        BtnOpenBilling.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 540)
        Controls.Add(BtnOpenBilling)
        Controls.Add(BtnClose)
        Controls.Add(BtnOpenIncidents)
        Controls.Add(BtnOpenSubscriptions)
        Controls.Add(BtnOpenServices)
        Controls.Add(BtnOpenAccounts)
        Controls.Add(BtnOpenClients)
        Name = "Dashboard"
        Text = "Dashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnOpenClients As Button
    Friend WithEvents BtnOpenAccounts As Button
    Friend WithEvents BtnOpenServices As Button
    Friend WithEvents BtnOpenSubscriptions As Button
    Friend WithEvents BtnOpenIncidents As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnOpenBilling As Button

End Class
