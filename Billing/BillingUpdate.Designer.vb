<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingUpdate
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
        DgvShowBillingRecords = New DataGridView()
        BtnOpenBillingDashboard = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        Label5 = New Label()
        TxtAmount = New MaskedTextBox()
        BtnSubmit = New Button()
        BtnReset = New Button()
        RBUnpaid = New RadioButton()
        RBPaid = New RadioButton()
        DTPSubDate = New DateTimePicker()
        CboSubscription = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label6 = New Label()
        TxtID = New TextBox()
        CType(DgvShowBillingRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvShowBillingRecords
        ' 
        DgvShowBillingRecords.AllowUserToAddRows = False
        DgvShowBillingRecords.AllowUserToDeleteRows = False
        DgvShowBillingRecords.AllowUserToOrderColumns = True
        DgvShowBillingRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvShowBillingRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvShowBillingRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvShowBillingRecords.EditMode = DataGridViewEditMode.EditProgrammatically
        DgvShowBillingRecords.Location = New Point(52, 12)
        DgvShowBillingRecords.MultiSelect = False
        DgvShowBillingRecords.Name = "DgvShowBillingRecords"
        DgvShowBillingRecords.ReadOnly = True
        DgvShowBillingRecords.RowHeadersWidth = 51
        DgvShowBillingRecords.RowTemplate.Height = 50
        DgvShowBillingRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvShowBillingRecords.Size = New Size(968, 288)
        DgvShowBillingRecords.TabIndex = 0
        ' 
        ' BtnOpenBillingDashboard
        ' 
        BtnOpenBillingDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenBillingDashboard.Location = New Point(765, 561)
        BtnOpenBillingDashboard.Margin = New Padding(3, 5, 3, 5)
        BtnOpenBillingDashboard.Name = "BtnOpenBillingDashboard"
        BtnOpenBillingDashboard.Size = New Size(294, 62)
        BtnOpenBillingDashboard.TabIndex = 11
        BtnOpenBillingDashboard.Text = "⬅️ Back"
        BtnOpenBillingDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(765, 456)
        BtnTestConnection.Margin = New Padding(3, 5, 3, 5)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(294, 62)
        BtnTestConnection.TabIndex = 10
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(765, 368)
        BtnOpenDashboard.Margin = New Padding(3, 5, 3, 5)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(294, 62)
        BtnOpenDashboard.TabIndex = 9
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(410, 533)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 30)
        Label5.TabIndex = 41
        Label5.Text = "$ "
        ' 
        ' TxtAmount
        ' 
        TxtAmount.Location = New Point(312, 533)
        TxtAmount.Margin = New Padding(3, 5, 3, 5)
        TxtAmount.Mask = "000.00"
        TxtAmount.Name = "TxtAmount"
        TxtAmount.PromptChar = "X"c
        TxtAmount.RightToLeft = RightToLeft.No
        TxtAmount.Size = New Size(106, 27)
        TxtAmount.TabIndex = 4
        TxtAmount.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 15F)
        BtnSubmit.Location = New Point(447, 675)
        BtnSubmit.Margin = New Padding(3, 5, 3, 5)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(147, 62)
        BtnSubmit.TabIndex = 8
        BtnSubmit.Text = "Update"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(138, 675)
        BtnReset.Margin = New Padding(3, 5, 3, 5)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(147, 62)
        BtnReset.TabIndex = 7
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' RBUnpaid
        ' 
        RBUnpaid.AutoSize = True
        RBUnpaid.Location = New Point(471, 586)
        RBUnpaid.Margin = New Padding(3, 5, 3, 5)
        RBUnpaid.Name = "RBUnpaid"
        RBUnpaid.Size = New Size(78, 24)
        RBUnpaid.TabIndex = 6
        RBUnpaid.TabStop = True
        RBUnpaid.Text = "Unpaid"
        RBUnpaid.UseVisualStyleBackColor = True
        ' 
        ' RBPaid
        ' 
        RBPaid.AutoSize = True
        RBPaid.Location = New Point(312, 586)
        RBPaid.Margin = New Padding(3, 5, 3, 5)
        RBPaid.Name = "RBPaid"
        RBPaid.Size = New Size(58, 24)
        RBPaid.TabIndex = 5
        RBPaid.TabStop = True
        RBPaid.Text = "Paid"
        RBPaid.UseVisualStyleBackColor = True
        ' 
        ' DTPSubDate
        ' 
        DTPSubDate.Location = New Point(312, 463)
        DTPSubDate.Margin = New Padding(3, 5, 3, 5)
        DTPSubDate.Name = "DTPSubDate"
        DTPSubDate.Size = New Size(376, 27)
        DTPSubDate.TabIndex = 3
        ' 
        ' CboSubscription
        ' 
        CboSubscription.AccessibleName = ""
        CboSubscription.DropDownStyle = ComboBoxStyle.DropDownList
        CboSubscription.FormattingEnabled = True
        CboSubscription.Location = New Point(312, 406)
        CboSubscription.Margin = New Padding(3, 5, 3, 5)
        CboSubscription.Name = "CboSubscription"
        CboSubscription.Size = New Size(376, 28)
        CboSubscription.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(54, 575)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 35)
        Label4.TabIndex = 40
        Label4.Text = "Status : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(54, 523)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 35)
        Label3.TabIndex = 39
        Label3.Text = "Amount : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(54, 463)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 35)
        Label2.TabIndex = 38
        Label2.Text = "Date : "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(54, 398)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 35)
        Label1.TabIndex = 37
        Label1.Text = "Subscription : "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(52, 342)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 35)
        Label6.TabIndex = 42
        Label6.Text = "ID : "
        ' 
        ' TxtID
        ' 
        TxtID.Location = New Point(312, 350)
        TxtID.Name = "TxtID"
        TxtID.ReadOnly = True
        TxtID.Size = New Size(58, 27)
        TxtID.TabIndex = 1
        ' 
        ' BillingUpdate
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1081, 767)
        Controls.Add(TxtID)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TxtAmount)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnReset)
        Controls.Add(RBUnpaid)
        Controls.Add(RBPaid)
        Controls.Add(DTPSubDate)
        Controls.Add(CboSubscription)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnOpenBillingDashboard)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Controls.Add(DgvShowBillingRecords)
        Name = "BillingUpdate"
        Text = "BillingUpdate"
        CType(DgvShowBillingRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvShowBillingRecords As DataGridView
    Friend WithEvents BtnOpenBillingDashboard As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAmount As MaskedTextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents RBUnpaid As RadioButton
    Friend WithEvents RBPaid As RadioButton
    Friend WithEvents DTPSubDate As DateTimePicker
    Friend WithEvents CboSubscription As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtID As TextBox
End Class
