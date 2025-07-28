<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TxtName = New TextBox()
        TxtEmail = New TextBox()
        TxtPhone = New TextBox()
        TxtAddress = New TextBox()
        BtnReset = New Button()
        BtnSubmit = New Button()
        BtnOpenDashboard = New Button()
        BtnTestConnection = New Button()
        BtnOpenClientRecords = New Button()
        BtnOpenClientDashboard = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(98, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 35)
        Label1.TabIndex = 0
        Label1.Text = "Name : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(98, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 35)
        Label2.TabIndex = 1
        Label2.Text = "Email : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(98, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 35)
        Label3.TabIndex = 2
        Label3.Text = "Phone : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(98, 261)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 35)
        Label4.TabIndex = 3
        Label4.Text = "Address : "
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(242, 62)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(203, 27)
        TxtName.TabIndex = 4
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(242, 130)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(203, 27)
        TxtEmail.TabIndex = 5
        ' 
        ' TxtPhone
        ' 
        TxtPhone.Location = New Point(242, 197)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.Size = New Size(203, 27)
        TxtPhone.TabIndex = 6
        ' 
        ' TxtAddress
        ' 
        TxtAddress.Location = New Point(242, 269)
        TxtAddress.Name = "TxtAddress"
        TxtAddress.Size = New Size(203, 27)
        TxtAddress.TabIndex = 7
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(98, 357)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(131, 54)
        BtnReset.TabIndex = 8
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 15F)
        BtnSubmit.Location = New Point(314, 357)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(131, 54)
        BtnSubmit.TabIndex = 9
        BtnSubmit.Text = "Create"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(553, 27)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(261, 54)
        BtnOpenDashboard.TabIndex = 10
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(553, 103)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(261, 54)
        BtnTestConnection.TabIndex = 11
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenClientRecords
        ' 
        BtnOpenClientRecords.Font = New Font("Segoe UI", 12F)
        BtnOpenClientRecords.Location = New Point(553, 183)
        BtnOpenClientRecords.Name = "BtnOpenClientRecords"
        BtnOpenClientRecords.Size = New Size(261, 54)
        BtnOpenClientRecords.TabIndex = 12
        BtnOpenClientRecords.Text = "Show Clients"
        BtnOpenClientRecords.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenClientDashboard
        ' 
        BtnOpenClientDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenClientDashboard.Location = New Point(553, 273)
        BtnOpenClientDashboard.Name = "BtnOpenClientDashboard"
        BtnOpenClientDashboard.Size = New Size(261, 54)
        BtnOpenClientDashboard.TabIndex = 13
        BtnOpenClientDashboard.Text = "⬅️ Back"
        BtnOpenClientDashboard.UseVisualStyleBackColor = True
        ' 
        ' Clients
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(856, 460)
        Controls.Add(BtnOpenClientDashboard)
        Controls.Add(BtnOpenClientRecords)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnReset)
        Controls.Add(TxtAddress)
        Controls.Add(TxtPhone)
        Controls.Add(TxtEmail)
        Controls.Add(TxtName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Clients"
        Text = "Clients"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenClientRecords As Button
    Friend WithEvents BtnOpenClientDashboard As Button
End Class
