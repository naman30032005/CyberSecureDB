Public Class client_dashboard

    'This sub routine opens the add clients form when user clicks the button
    Private Sub BtnOpenClients_click(sender As Object, e As EventArgs) Handles Btnopenclients.Click
        OpenForm(Clients)
    End Sub

    'this sub routine opens the update clients form when user clicks the button
    Private Sub BtnOpenUpdateClients_click(sender As Object, e As EventArgs) Handles BtnOpenUpdateClients.Click
        OpenForm(Clients_update)
    End Sub

    'this sub routine opens the delete clients form when user cliicks the button
    Private Sub BtnOpenDeleteClients_click(sender As Object, e As EventArgs) Handles BtnOpenDeleteClients.Click
        OpenForm(Clients_delete)
    End Sub

    'this sub routine opens the clients record form when user clicks the button
    Private Sub BtnOpenClientRecords_click(sender As Object, e As EventArgs) Handles BtnOpenClientRecords.Click
        OpenForm(Clients_records)
    End Sub

    'This button reopens the dashboard when the back button is clicked
    Private Sub BtnOpenDashboard_click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
        OpenForm(Dashboard)
    End Sub

    'This sub routine makes the code reusable by other routines to open form
    Public Sub OpenForm(target As Form)
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