<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
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
        BtnOpenBillingDashboard = New Button()
        BtnOpenBillingtRecords = New Button()
        BtnTestConnection = New Button()
        BtnOpenDashboard = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        Label3 = New Label()
        Label4 = New Label()
        CboSubscription = New ComboBox()
        DTPSubDate = New DateTimePicker()
        RBPaid = New RadioButton()
        RBUnpaid = New RadioButton()
        BtnSubmit = New Button()
        BtnReset = New Button()
        TxtAmount = New MaskedTextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' BtnOpenBillingDashboard
        ' 
        BtnOpenBillingDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenBillingDashboard.Location = New Point(713, 331)
        BtnOpenBillingDashboard.Margin = New Padding(3, 5, 3, 5)
        BtnOpenBillingDashboard.Name = "BtnOpenBillingDashboard"
        BtnOpenBillingDashboard.Size = New Size(294, 62)
        BtnOpenBillingDashboard.TabIndex = 10
        BtnOpenBillingDashboard.Text = "⬅️ Back"
        BtnOpenBillingDashboard.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenBillingtRecords
        ' 
        BtnOpenBillingtRecords.Font = New Font("Segoe UI", 12F)
        BtnOpenBillingtRecords.Location = New Point(713, 228)
        BtnOpenBillingtRecords.Margin = New Padding(3, 5, 3, 5)
        BtnOpenBillingtRecords.Name = "BtnOpenBillingtRecords"
        BtnOpenBillingtRecords.Size = New Size(294, 62)
        BtnOpenBillingtRecords.TabIndex = 9
        BtnOpenBillingtRecords.Text = "Show Bills"
        BtnOpenBillingtRecords.UseVisualStyleBackColor = True
        ' 
        ' BtnTestConnection
        ' 
        BtnTestConnection.Font = New Font("Segoe UI", 12F)
        BtnTestConnection.Location = New Point(713, 136)
        BtnTestConnection.Margin = New Padding(3, 5, 3, 5)
        BtnTestConnection.Name = "BtnTestConnection"
        BtnTestConnection.Size = New Size(294, 62)
        BtnTestConnection.TabIndex = 8
        BtnTestConnection.Text = "Test Connection"
        BtnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' BtnOpenDashboard
        ' 
        BtnOpenDashboard.Font = New Font("Segoe UI", 12F)
        BtnOpenDashboard.Location = New Point(713, 48)
        BtnOpenDashboard.Margin = New Padding(3, 5, 3, 5)
        BtnOpenDashboard.Name = "BtnOpenDashboard"
        BtnOpenDashboard.Size = New Size(294, 62)
        BtnOpenDashboard.TabIndex = 7
        BtnOpenDashboard.Text = "Back To Dashboard"
        BtnOpenDashboard.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(24, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 35)
        Label1.TabIndex = 25
        Label1.Text = "Subscription : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(24, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 35)
        Label2.TabIndex = 26
        Label2.Text = "Date : "
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(24, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 35)
        Label3.TabIndex = 27
        Label3.Text = "Amount : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(24, 289)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 35)
        Label4.TabIndex = 28
        Label4.Text = "Status : "
        ' 
        ' CboSubscription
        ' 
        CboSubscription.AccessibleName = ""
        CboSubscription.DropDownStyle = ComboBoxStyle.DropDownList
        CboSubscription.FormattingEnabled = True
        CboSubscription.Location = New Point(282, 56)
        CboSubscription.Margin = New Padding(3, 5, 3, 5)
        CboSubscription.Name = "CboSubscription"
        CboSubscription.Size = New Size(376, 31)
        CboSubscription.TabIndex = 0
        ' 
        ' DTPSubDate
        ' 
        DTPSubDate.Location = New Point(282, 128)
        DTPSubDate.Margin = New Padding(3, 5, 3, 5)
        DTPSubDate.Name = "DTPSubDate"
        DTPSubDate.Size = New Size(376, 30)
        DTPSubDate.TabIndex = 1
        ' 
        ' RBPaid
        ' 
        RBPaid.AutoSize = True
        RBPaid.Location = New Point(282, 300)
        RBPaid.Margin = New Padding(3, 5, 3, 5)
        RBPaid.Name = "RBPaid"
        RBPaid.Size = New Size(63, 27)
        RBPaid.TabIndex = 3
        RBPaid.TabStop = True
        RBPaid.Text = "Paid"
        RBPaid.UseVisualStyleBackColor = True
        ' 
        ' RBUnpaid
        ' 
        RBUnpaid.AutoSize = True
        RBUnpaid.Location = New Point(441, 300)
        RBUnpaid.Margin = New Padding(3, 5, 3, 5)
        RBUnpaid.Name = "RBUnpaid"
        RBUnpaid.Size = New Size(86, 27)
        RBUnpaid.TabIndex = 4
        RBUnpaid.TabStop = True
        RBUnpaid.Text = "Unpaid"
        RBUnpaid.UseVisualStyleBackColor = True
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Font = New Font("Segoe UI", 15F)
        BtnSubmit.Location = New Point(417, 389)
        BtnSubmit.Margin = New Padding(3, 5, 3, 5)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(147, 62)
        BtnSubmit.TabIndex = 6
        BtnSubmit.Text = "Add"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Segoe UI", 15F)
        BtnReset.Location = New Point(108, 389)
        BtnReset.Margin = New Padding(3, 5, 3, 5)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(147, 62)
        BtnReset.TabIndex = 5
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' TxtAmount
        ' 
        TxtAmount.Location = New Point(282, 212)
        TxtAmount.Margin = New Padding(3, 5, 3, 5)
        TxtAmount.Mask = "000.00"
        TxtAmount.Name = "TxtAmount"
        TxtAmount.PromptChar = "X"c
        TxtAmount.RightToLeft = RightToLeft.No
        TxtAmount.Size = New Size(106, 30)
        TxtAmount.TabIndex = 2
        TxtAmount.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(380, 212)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 30)
        Label5.TabIndex = 29
        Label5.Text = "$ "
        ' 
        ' Billing
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1035, 476)
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
        Controls.Add(BtnOpenBillingtRecords)
        Controls.Add(BtnTestConnection)
        Controls.Add(BtnOpenDashboard)
        Font = New Font("Segoe UI", 10F)
        Margin = New Padding(3, 5, 3, 5)
        Name = "Billing"
        Text = "Billing"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnOpenBillingDashboard As Button
    Friend WithEvents BtnOpenBillingtRecords As Button
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents BtnOpenDashboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CboSubscription As ComboBox
    Friend WithEvents DTPSubDate As DateTimePicker
    Friend WithEvents RBPaid As RadioButton
    Friend WithEvents RBUnpaid As RadioButton
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents TxtAmount As MaskedTextBox
    Friend WithEvents Label5 As Label
End Class
