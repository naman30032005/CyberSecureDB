<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subscription_DashBoard
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
        BtnInsertSubscription = New Button()
        BtnUpdateSubscription = New Button()
        BtnDeleteSusbcription = New Button()
        BtnOpenDashboard = New Button()
        BtnShowRecords = New Button()
        SuspendLayout()
        ' 
        ' BtnInsertSubscription
        ' 
        BtnInsertSubscription.Font = New Font("Segoe UI", 12F)
        BtnInsertSubscription.Location = New Point(12, 91)
        BtnInsertSubscription.Name = "BtnInsertSubscription"
        BtnInsertSubscription.Size = New Size(216, 48)
        BtnInsertSubscription.TabIndex = 0
        BtnInsertSubscription.Text = "New Subscription"
        BtnInsertSubscription.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdateSubscription
        ' 
        BtnUpdateSubscription.Font = New Font("Segoe UI", 12F)
        BtnUpdateSubscription.Location = New Point(282, 91)
        BtnUpdateSubscription.Name = "BtnUpdateSubscription"
        BtnUpdateSubscription.Size = New Size(216, 48)
        BtnUpdateSubscription.TabIndex = 1
        BtnUpdateSubscription.Text = "Update Subscription"
        BtnUpdateSubscription.UseVisualStyleBackColor = True
        ' 
        ' BtnDeleteSusbcription
        ' 
        BtnDeleteSusbcription.Font = New Font("Segoe UI", 12F)
        BtnDeleteSusbcription.Location = New Point(536, 91)
        BtnDeleteSusbcription.Name = "BtnDeleteSusbcription"
        BtnDeleteSusbcription.Size = New Size(218, 48)
        BtnDeleteSusbcription.TabIndex = 2
        BtnDeleteSusbcription.Text = "Delete Subscription"
        BtnDeleteSusbcription.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 15F)
        BtnOpenDashboard.Location = New Point(282, 350)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(216, 59)
        BtnOpenDashboard.TabIndex = 4
        BtnOpenDashboard.Text = "⬅Back"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnShowRecords
        ' 
        BtnShowRecords.Font = New Font("Segoe UI", 12F)
        BtnShowRecords.Location = New Point(252, 201)
        BtnShowRecords.Name = "BtnShowRecords"
        BtnShowRecords.Size = New Size(280, 48)
        BtnShowRecords.TabIndex = 3
        BtnShowRecords.Text = "Show Subscription Records"
        BtnShowRecords.UseVisualStyleBackColor = True
        ' 
        ' Subscription_DashBoard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnShowRecords)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(BtnDeleteSusbcription)
        Controls.Add(BtnUpdateSubscription)
        Controls.Add(BtnInsertSubscription)
        Name = "Subscription_DashBoard"
        Text = "Subscriptions"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnInsertSubscription As Button
    Friend WithEvents BtnUpdateSubscription As Button
    Friend WithEvents BtnDeleteSusbcription As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnShowRecords As Button
End Class
