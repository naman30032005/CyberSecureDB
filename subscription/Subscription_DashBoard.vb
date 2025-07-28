Public Class Subscription_DashBoard
    'This sub routine opens the insert form
    Private Sub BtnInsertSubscription_click(sender As Object, e As EventArgs) Handles BtnInsertSubscription.Click
        openForm(Subscriptions)
    End Sub

    'This subroutine opens update form for subscription table
    Private Sub BtnUpdateSubscription_click(sender As Object, e As EventArgs) Handles BtnUpdateSubscription.Click
        openForm(Subscription_update)
    End Sub

    'this sub routine opens delete form for subscriptions table
    Private Sub BtnDeleteSubscription_click(sender As Object, e As EventArgs) Handles BtnDeleteSusbcription.Click
        openForm(Subscription_delete)
    End Sub

    'This Sub routine opens the subscription records form
    Private Sub BtnShowRecords_click(sender As Object, e As EventArgs) Handles BtnShowRecords.Click
        openForm(Subscription_records)
    End Sub

    'This sub routine reopen the dashboard form
    Private Sub BtnOpenDashboard_click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
        openForm(Dashboard)
    End Sub

    'this sub routine helps opening the form 
    Private Sub openForm(target As Form)
        Try
            target.Show()
            target.StartPosition = FormStartPosition.Manual
            target.Location = Me.Location
            MyBase.Hide()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'this sub routine handles when the user tries to close the form
    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            BtnOpenDashboard.PerformClick()
        End If
    End Sub
End Class