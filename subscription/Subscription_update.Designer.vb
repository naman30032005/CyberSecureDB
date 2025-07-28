<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subscription_update
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
        DgvUpdateSubscription = New DataGridView()
        BtnReset = New Button()
        BtnSubmit = New Button()
        BtnOpenDashboard = New Button()
        BtnTestConnection = New Button()
        BtnOpenSubDashboard = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DtpUpdateDate = New DateTimePicker()
        Label4 = New Label()
        TxtID = New TextBox()
        CboUpdateAccount = New ComboBox()
        CboUpdateServices = New ComboBox()
        CType(DgvUpdateSubscription, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvUpdateSubscription
        ' 
        DgvUpdateSubscription.AllowUserToAddRows = False
        DgvUpdateSubscription.AllowUserToDeleteRows = False
        DgvUpdateSubscription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvUpdateSubscription.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvUpdateSubscription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvUpdateSubscription.EditMode = DataGridViewEditMode.EditProgrammatically
        DgvUpdateSubscription.Location = New Point(45, 22)
        DgvUpdateSubscription.MultiSelect = False
        DgvUpdateSubscription.Name = "DgvUpdateSubscription"
        DgvUpdateSubscription.RowHeadersWidth = 51
        DgvUpdateSubscription.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvUpdateSubscription.Size = New Size(817, 226)
        DgvUpdateSubscription.TabIndex = 0
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 12F)
        BtnReset.Location = New Point(68, 551)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(163, 57)
        BtnReset.TabIndex = 5
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 12F)
        BtnSubmit.Location = New Point(351, 551)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(163, 57)
        BtnSubmit.TabIndex = 6
        BtnSubmit.Text = "Update"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(632, 276)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(230, 57)
        BtnOpenDashboard.TabIndex = 7
        BtnOpenDashboard.Text = "Back to Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(632, 359)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(230, 57)
        BtnTestConnection.TabIndex = 8
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenSubDashboard
        ' 
        BtnOpenSubDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenSubDashboard.Location = New Point(632, 445)
        BtnOpenSubDashboard.Name = "BtnOpenSubDashboard"
        BtnOpenSubDashboard.Size = New Size(230, 57)
        BtnOpenSubDashboard.TabIndex = 9
        BtnOpenSubDashboard.Text = "⬅️ Back"
        BtnOpenSubDashboard.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(45, 349)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 35)
        Label1.TabIndex = 6
        Label1.Text = "Account : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(45, 410)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 35)
        Label2.TabIndex = 8
        Label2.Text = "Service : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(45, 459)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 35)
        Label3.TabIndex = 10
        Label3.Text = "Date : "
        ' 
        ' DtpUpdateDate
        ' 
        DtpUpdateDate.Location = New Point(256, 467)
        DtpUpdateDate.Name = "DtpUpdateDate"
        DtpUpdateDate.Size = New Size(222, 27)
        DtpUpdateDate.TabIndex = 4
        DtpUpdateDate.Value = New Date(2025, 5, 12, 14, 3, 24, 0)
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(45, 294)
        Label4.Name = "Label4"
        Label4.Size = New Size(197, 35)
        Label4.TabIndex = 14
        Label4.Text = "SubscriptionID : "
        ' 
        ' TxtID
        ' 
        TxtID.Location = New Point(256, 302)
        TxtID.Name = "TxtID"
        TxtID.ReadOnly = True
        TxtID.Size = New Size(57, 27)
        TxtID.TabIndex = 1
        ' 
        ' CboUpdateAccount
        ' 
        CboUpdateAccount.FormattingEnabled = True
        CboUpdateAccount.Location = New Point(256, 359)
        CboUpdateAccount.Name = "CboUpdateAccount"
        CboUpdateAccount.Size = New Size(222, 28)
        CboUpdateAccount.TabIndex = 2
        ' 
        ' CboUpdateServices
        ' 
        CboUpdateServices.FormattingEnabled = True
        CboUpdateServices.Location = New Point(256, 417)
        CboUpdateServices.Name = "CboUpdateServices"
        CboUpdateServices.Size = New Size(222, 28)
        CboUpdateServices.TabIndex = 3
        ' 
        ' Subscription_update
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(906, 644)
        Controls.Add(CboUpdateServices)
        Controls.Add(CboUpdateAccount)
        Controls.Add(TxtID)
        Controls.Add(Label4)
        Controls.Add(DtpUpdateDate)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnOpenSubDashboard)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnReset)
        Controls.Add(DgvUpdateSubscription)
        Name = "Subscription_update"
        Text = "Subscription_update"
        CType(DgvUpdateSubscription, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvUpdateSubscription As DataGridView
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenSubDashboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpUpdateDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents CboUpdateAccount As ComboBox
    Friend WithEvents CboUpdateServices As ComboBox
End Class
