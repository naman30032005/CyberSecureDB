Public Class BIllingDashboard

    'this sub routine uses the open form sub routine to open add billing form
    Private Sub BtnopenBilling_Click(sender As Object, e As EventArgs) Handles BtnopenBilling.Click
        openForm(Billing)
    End Sub



    'this sub routine uses the open form sub routine to open update billing form
    Private Sub BtnOpenUpdateBilling_Click(sender As Object, e As EventArgs) Handles BtnOpenUpdateBilling.Click
        openForm(BillingUpdate)
    End Sub



    'this sub routine uses the open form sub routine to open delete billing form
    Private Sub BtnOpenDeleteBilling_Click(sender As Object, e As EventArgs) Handles BtnOpenDeleteBilling.Click
        openForm(BillingDelete)
    End Sub



    'this sub routine uses the open form sub routine to open billing record form
    Private Sub BtnOpenBillingRecords_Click(sender As Object, e As EventArgs) Handles BtnOpenBillingRecords.Click
        openForm(billingRecords)
    End Sub



    'this sub routine uses the open form sub routine to open dashboard form
    Private Sub BtnOpenDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
        openForm(Dashboard)
    End Sub



    'this sub routine is used by other sub routines to open different forms
    Public Sub openForm(target As Form)
        target.Show()
        target.StartPosition = FormStartPosition.Manual
        target.Location = Me.Location
        MyBase.Hide()
    End Sub


    'this sub routine handles when the user tries to close the form
    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            BtnOpenDashboard.PerformClick()
        End If
    End Sub
End Class