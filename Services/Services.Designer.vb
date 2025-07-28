<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Services
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
        BtnOpenServiceDashboard = New Button()
        BtnOpenServiceRecords = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TxtName = New TextBox()
        TxtDescription = New TextBox()
        BtnSubmit = New Button()
        BtnReset = New Button()
        SuspendLayout()
        ' 
        ' BtnOpenServiceDashboard
        ' 
        BtnOpenServiceDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenServiceDashboard.Location = New Point(570, 273)
        BtnOpenServiceDashboard.Name = "BtnOpenServiceDashboard"
        BtnOpenServiceDashboard.Size = New Size(261, 54)
        BtnOpenServiceDashboard.TabIndex = 17
        BtnOpenServiceDashboard.Text = "⬅️ Back"
        BtnOpenServiceDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenServiceRecords
        ' 
        BtnOpenServiceRecords.Font = New Font("Segoe UI", 12F)
        BtnOpenServiceRecords.Location = New Point(570, 183)
        BtnOpenServiceRecords.Name = "BtnOpenServiceRecords"
        BtnOpenServiceRecords.Size = New Size(261, 54)
        BtnOpenServiceRecords.TabIndex = 16
        BtnOpenServiceRecords.Text = "Show Services"
        BtnOpenServiceRecords.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(570, 103)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(261, 54)
        BtnTestConnection.TabIndex = 15
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(570, 27)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(261, 54)
        BtnOpenDashboard.TabIndex = 14
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(23, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 35)
        Label1.TabIndex = 18
        Label1.Text = "Name : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(23, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 35)
        Label2.TabIndex = 19
        Label2.Text = "Description : "
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(203, 85)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(178, 27)
        TxtName.TabIndex = 0
        ' 
        ' TxtDescription
        ' 
        TxtDescription.Location = New Point(203, 157)
        TxtDescription.Multiline = True
        TxtDescription.Name = "TxtDescription"
        TxtDescription.Size = New Size(308, 50)
        TxtDescription.TabIndex = 1
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 15F)
        BtnSubmit.Location = New Point(308, 261)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(131, 54)
        BtnSubmit.TabIndex = 3
        BtnSubmit.Text = "Create"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(92, 261)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(131, 54)
        BtnReset.TabIndex = 2
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' Services
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(853, 362)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnReset)
        Controls.Add(TxtDescription)
        Controls.Add(TxtName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnOpenServiceDashboard)
        Controls.Add(BtnOpenServiceRecords)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Name = "Services"
        Text = "Add Services"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnOpenServiceDashboard As Button
    Friend WithEvents BtnOpenServiceRecords As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
End Class
