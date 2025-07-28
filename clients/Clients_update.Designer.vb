<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients_update
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
        DgvUpdateClients = New DataGridView()
        TxtAddress = New TextBox()
        TxtPhone = New TextBox()
        TxtEmail = New TextBox()
        TxtName = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TxtID = New TextBox()
        Label5 = New Label()
        BtnOpenClientDashboard = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        BtnUpdate = New Button()
        BtnReset = New Button()
        CType(DgvUpdateClients, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvUpdateClients
        ' 
        DgvUpdateClients.AllowUserToAddRows = False
        DgvUpdateClients.AllowUserToDeleteRows = False
        DgvUpdateClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvUpdateClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvUpdateClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvUpdateClients.EditMode = DataGridViewEditMode.EditProgrammatically
        DgvUpdateClients.Location = New Point(29, 21)
        DgvUpdateClients.MultiSelect = False
        DgvUpdateClients.Name = "DgvUpdateClients"
        DgvUpdateClients.RowHeadersWidth = 51
        DgvUpdateClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvUpdateClients.Size = New Size(837, 241)
        DgvUpdateClients.TabIndex = 0
        ' 
        ' TxtAddress
        ' 
        TxtAddress.Location = New Point(236, 562)
        TxtAddress.Name = "TxtAddress"
        TxtAddress.Size = New Size(203, 27)
        TxtAddress.TabIndex = 5
        ' 
        ' TxtPhone
        ' 
        TxtPhone.Location = New Point(236, 490)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.Size = New Size(203, 27)
        TxtPhone.TabIndex = 4
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(236, 423)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(203, 27)
        TxtEmail.TabIndex = 3
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(236, 355)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(203, 27)
        TxtName.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(92, 554)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 35)
        Label4.TabIndex = 11
        Label4.Text = "Address : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(92, 482)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 35)
        Label3.TabIndex = 10
        Label3.Text = "Phone : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(92, 415)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 35)
        Label2.TabIndex = 9
        Label2.Text = "Email : "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(92, 347)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 35)
        Label1.TabIndex = 8
        Label1.Text = "Name : "
        ' 
        ' TxtID
        ' 
        TxtID.Location = New Point(236, 299)
        TxtID.Name = "TxtID"
        TxtID.ReadOnly = True
        TxtID.Size = New Size(58, 27)
        TxtID.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.Location = New Point(92, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 35)
        Label5.TabIndex = 16
        Label5.Text = "ClientID : "
        ' 
        ' BtnOpenClientDashboard
        ' 
        BtnOpenClientDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenClientDashboard.Location = New Point(587, 504)
        BtnOpenClientDashboard.Name = "BtnOpenClientDashboard"
        BtnOpenClientDashboard.Size = New Size(261, 54)
        BtnOpenClientDashboard.TabIndex = 10
        BtnOpenClientDashboard.Text = "⬅️ Back"
        BtnOpenClientDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(587, 423)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(261, 54)
        BtnTestConnection.TabIndex = 9
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(587, 347)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(261, 54)
        BtnOpenDashboard.TabIndex = 8
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Font = New Font("Segoe UI", 15F)
        BtnUpdate.Location = New Point(511, 628)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(131, 54)
        BtnUpdate.TabIndex = 7
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(295, 628)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(131, 54)
        BtnReset.TabIndex = 6
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' Clients_update
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(902, 694)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnReset)
        Controls.Add(BtnOpenClientDashboard)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(TxtID)
        Controls.Add(Label5)
        Controls.Add(TxtAddress)
        Controls.Add(TxtPhone)
        Controls.Add(TxtEmail)
        Controls.Add(TxtName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DgvUpdateClients)
        Name = "Clients_update"
        Text = "Clients_update"
        CType(DgvUpdateClients, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvUpdateClients As DataGridView
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnOpenClientDashboard As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnReset As Button
End Class
