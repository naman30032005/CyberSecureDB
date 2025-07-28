Public Class Dashboard

    'Button to open Clients Form
    Private Sub BtnOpenClients_click(sender As Object, e As EventArgs) Handles BtnOpenClients.Click
        OpenForm(client_dashboard)
    End Sub



    'Button to open accounts Form
    Private Sub BtnOpenAccounts_click(sender As Object, e As EventArgs) Handles BtnOpenAccounts.Click
        OpenForm(AccountDashboard)
        MyBase.Hide()
    End Sub



    'Button to open Services Form
    Private Sub BtnOpenServices_click(sender As Object, e As EventArgs) Handles BtnOpenServices.Click
        OpenForm(serviceDashboard)
    End Sub



    'Button to open Subscription Form
    Private Sub btnOpenSubscription_click(sender As Object, e As EventArgs) Handles BtnOpenSubscriptions.Click
        OpenForm(Subscription_DashBoard)
    End Sub



    'Button to open Incidents Form
    Private Sub btnOpenIncidents_click(sender As Object, e As EventArgs) Handles BtnOpenIncidents.Click
        OpenForm(incidentDashboard)
    End Sub



    'Button to open the billing form
    Private Sub BtnOpenBilling_click(Sender As Object, e As EventArgs) Handles BtnOpenBilling.Click
        OpenForm(BIllingDashboard)
    End Sub




    'button to the close the application
    Private Sub btnClose_click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub



    'a subroutine that handles the opening of the form
    Private Sub OpenForm(target As Form)
        Try
            target.Show()
            target.StartPosition = FormStartPosition.Manual
            target.Location = Me.Location
            MyBase.Hide()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
