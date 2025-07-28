<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class serviceUpdate
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
        DgvShowServiceRecords = New DataGridView()
        BtnOpenServiceDashboard = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        BtnSubmit = New Button()
        BtnReset = New Button()
        TxtDescription = New TextBox()
        TxtName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        TxtID = New TextBox()
        CType(DgvShowServiceRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvShowServiceRecords
        ' 
        DgvShowServiceRecords.AllowUserToAddRows = False
        DgvShowServiceRecords.AllowUserToDeleteRows = False
        DgvShowServiceRecords.AllowUserToOrderColumns = True
        DgvShowServiceRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvShowServiceRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvShowServiceRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvShowServiceRecords.EditMode = DataGridViewEditMode.EditProgrammatically
        DgvShowServiceRecords.Location = New Point(40, 12)
        DgvShowServiceRecords.Name = "DgvShowServiceRecords"
        DgvShowServiceRecords.ReadOnly = True
        DgvShowServiceRecords.RowHeadersWidth = 51
        DgvShowServiceRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvShowServiceRecords.Size = New Size(698, 207)
        DgvShowServiceRecords.TabIndex = 0
        ' 
        ' BtnOpenServiceDashboard
        ' 
        BtnOpenServiceDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenServiceDashboard.Location = New Point(509, 427)
        BtnOpenServiceDashboard.Name = "BtnOpenServiceDashboard"
        BtnOpenServiceDashboard.Size = New Size(261, 54)
        BtnOpenServiceDashboard.TabIndex = 8
        BtnOpenServiceDashboard.Text = "⬅️ Back"
        BtnOpenServiceDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(509, 346)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(261, 54)
        BtnTestConnection.TabIndex = 7
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(509, 270)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(261, 54)
        BtnOpenDashboard.TabIndex = 6
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 15F)
        BtnSubmit.Location = New Point(313, 500)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(131, 54)
        BtnSubmit.TabIndex = 5
        BtnSubmit.Text = "Update"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(98, 500)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(131, 54)
        BtnReset.TabIndex = 4
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' TxtDescription
        ' 
        TxtDescription.Location = New Point(208, 396)
        TxtDescription.Multiline = True
        TxtDescription.Name = "TxtDescription"
        TxtDescription.Size = New Size(265, 50)
        TxtDescription.TabIndex = 3
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(208, 324)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(178, 27)
        TxtName.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(28, 388)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 35)
        Label2.TabIndex = 25
        Label2.Text = "Description : "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(28, 316)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 35)
        Label1.TabIndex = 24
        Label1.Text = "Name : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(28, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 35)
        Label3.TabIndex = 26
        Label3.Text = "ID : "
        ' 
        ' TxtID
        ' 
        TxtID.Location = New Point(208, 252)
        TxtID.Name = "TxtID"
        TxtID.ReadOnly = True
        TxtID.Size = New Size(61, 27)
        TxtID.TabIndex = 1
        ' 
        ' serviceUpdate
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 566)
        Controls.Add(TxtID)
        Controls.Add(Label3)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnReset)
        Controls.Add(TxtDescription)
        Controls.Add(TxtName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnOpenServiceDashboard)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(DgvShowServiceRecords)
        Name = "serviceUpdate"
        Text = "serviceUpdate"
        CType(DgvShowServiceRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvShowServiceRecords As DataGridView
    Friend WithEvents BtnOpenServiceDashboard As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtID As TextBox
End Class
