<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountUpdate
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
        DgvShowAccountRecords = New DataGridView()
        BtnSubmit = New Button()
        BtnReset = New Button()
        DtpAccountDate = New DateTimePicker()
        CboClient = New ComboBox()
        TxtName = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        BtnOpenAccountDashboard = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        Label4 = New Label()
        TxtID = New TextBox()
        BtnOpenSubMenu = New Button()
        CType(DgvShowAccountRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvShowAccountRecords
        ' 
        DgvShowAccountRecords.AllowUserToAddRows = False
        DgvShowAccountRecords.AllowUserToDeleteRows = False
        DgvShowAccountRecords.AllowUserToOrderColumns = True
        DgvShowAccountRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvShowAccountRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvShowAccountRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvShowAccountRecords.EditMode = DataGridViewEditMode.EditProgrammatically
        DgvShowAccountRecords.Location = New Point(47, 12)
        DgvShowAccountRecords.MultiSelect = False
        DgvShowAccountRecords.Name = "DgvShowAccountRecords"
        DgvShowAccountRecords.ReadOnly = True
        DgvShowAccountRecords.RowHeadersWidth = 51
        DgvShowAccountRecords.RowTemplate.Height = 50
        DgvShowAccountRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvShowAccountRecords.Size = New Size(968, 279)
        DgvShowAccountRecords.TabIndex = 0
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 15F)
        BtnSubmit.Location = New Point(450, 604)
        BtnSubmit.Margin = New Padding(3, 5, 3, 5)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(147, 62)
        BtnSubmit.TabIndex = 5
        BtnSubmit.Text = "Update"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(141, 604)
        BtnReset.Margin = New Padding(3, 5, 3, 5)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(147, 62)
        BtnReset.TabIndex = 4
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' DtpAccountDate
        ' 
        DtpAccountDate.Location = New Point(276, 509)
        DtpAccountDate.Name = "DtpAccountDate"
        DtpAccountDate.Size = New Size(261, 27)
        DtpAccountDate.TabIndex = 3
        ' 
        ' CboClient
        ' 
        CboClient.FormattingEnabled = True
        CboClient.Location = New Point(276, 443)
        CboClient.Name = "CboClient"
        CboClient.Size = New Size(261, 28)
        CboClient.TabIndex = 2
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(276, 390)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(261, 27)
        TxtName.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(65, 501)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 35)
        Label3.TabIndex = 40
        Label3.Text = "Date :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(65, 443)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 35)
        Label2.TabIndex = 39
        Label2.Text = "Client :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(65, 388)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 35)
        Label1.TabIndex = 38
        Label1.Text = "Name :"
        ' 
        ' BtnOpenAccountDashboard
        ' 
        BtnOpenAccountDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenAccountDashboard.Location = New Point(760, 573)
        BtnOpenAccountDashboard.Margin = New Padding(3, 5, 3, 5)
        BtnOpenAccountDashboard.Name = "BtnOpenAccountDashboard"
        BtnOpenAccountDashboard.Size = New Size(294, 62)
        BtnOpenAccountDashboard.TabIndex = 9
        BtnOpenAccountDashboard.Text = "⬅️ Back"
        BtnOpenAccountDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(760, 409)
        BtnTestConnection.Margin = New Padding(3, 5, 3, 5)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(294, 62)
        BtnTestConnection.TabIndex = 7
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(760, 321)
        BtnOpenDashboard.Margin = New Padding(3, 5, 3, 5)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(294, 62)
        BtnOpenDashboard.TabIndex = 6
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(65, 333)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 35)
        Label4.TabIndex = 41
        Label4.Text = "ID :"
        ' 
        ' TxtID
        ' 
        TxtID.Location = New Point(276, 333)
        TxtID.Name = "TxtID"
        TxtID.ReadOnly = True
        TxtID.Size = New Size(63, 27)
        TxtID.TabIndex = 42
        ' 
        ' BtnOpenSubMenu
        ' 
        BtnOpenSubMenu.Font = New Font("Segoe UI", 12F)
        BtnOpenSubMenu.Location = New Point(760, 490)
        BtnOpenSubMenu.Margin = New Padding(3, 5, 3, 5)
        BtnOpenSubMenu.Name = "BtnOpenSubMenu"
        BtnOpenSubMenu.Size = New Size(294, 62)
        BtnOpenSubMenu.TabIndex = 8
        BtnOpenSubMenu.Text = "Manage Services"
        BtnOpenSubMenu.UseVisualStyleBackColor = True
        ' 
        ' AccountUpdate
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1066, 716)
        Controls.Add(BtnOpenSubMenu)
        Controls.Add(TxtID)
        Controls.Add(Label4)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnReset)
        Controls.Add(DtpAccountDate)
        Controls.Add(CboClient)
        Controls.Add(TxtName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnOpenAccountDashboard)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(DgvShowAccountRecords)
        Name = "AccountUpdate"
        Text = "AccountUpdate"
        CType(DgvShowAccountRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvShowAccountRecords As DataGridView
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents DtpAccountDate As DateTimePicker
    Friend WithEvents CboClient As ComboBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnOpenAccountDashboard As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents BtnOpenSubMenu As Button
End Class
