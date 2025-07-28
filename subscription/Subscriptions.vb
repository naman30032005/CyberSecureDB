
'Impoting the main nuget Libraries
Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Data.SqlTypes

Public Class Subscriptions
    'Connection String to connect to the database
    Public connectionString As String = "Data Source=localhost\SQLEXPRESS;Database=Cyber_Secure_Db;Integrated Security=True;TrustServerCertificate=True"

    ' This function gets the values to fill in the accounts combo box and services combobox
    Private Sub Subscriptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccount()
        LoadServices()
    End Sub


    'Used to get accounts info from the database to fill the combo box
    Private Sub LoadAccount()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim Query As String = "select accountid, accountname from accounts"
                Dim adapter As New SqlDataAdapter(Query, connection)
                Dim table As New DataTable()

                adapter.Fill(table)

                CboChooseAccount.DataSource = table
                CboChooseAccount.DisplayMember = "accountname"
                CboChooseAccount.ValueMember = "accountid"
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Used to get the service info form the database to fill the combo box
    Private Sub LoadServices()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "select serviceid, servicename from services"
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim table As New DataTable()

                adapter.Fill(table)

                CboChooseService.DataSource = table
                CboChooseService.DisplayMember = "servicename"
                CboChooseService.ValueMember = "serviceid"
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'reset button that resets the values of each field
    Private Sub btnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        CboChooseAccount.SelectedIndex = -1
        CboChooseService.SelectedIndex = -1
        BtnDate.Value = Today
    End Sub

    'Submit button to submit the data in the database server
    Private Sub btnSubmit_click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If CboChooseAccount.SelectedIndex = -1 OrElse CboChooseService.SelectedIndex = -1 OrElse BtnDate.Value > Today Then
            MessageBox.Show("Please select both an account and a service and make sure the date is correct.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim query As String = "usp_insertSubscription"
        Dim parameters As New Dictionary(Of String, Object) From
            {
            {"@accountid", CType(CboChooseAccount.SelectedValue, Integer)},
            {"@serviceid", CType(CboChooseService.SelectedValue, Integer)},
            {"@date", BtnDate.Value}
        }
        insertProcedure(query, parameters)
    End Sub

    'This function handles the connection and submition of the data
    Private Sub insertProcedure(query As String, parameters As Dictionary(Of String, Object))

        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.CommandType = CommandType.StoredProcedure
                    For Each param In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    connection.Open()

                    command.ExecuteNonQuery()

                    MessageBox.Show("Subscription Inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnReset.PerformClick()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Used to test Connection with the database server
    Private Sub BtnTestConnection_click(sender As Object, e As EventArgs) Handles BtnTestConnection.Click
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                MessageBox.Show("Connection Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Connection Failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    'This function reopens the Dashboard Menu Form
    Private Sub BtnBack_click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Tag = "SafeClose"
        Dashboard.Show()
        Dashboard.StartPosition = FormStartPosition.Manual
        Dashboard.Location = Me.Location
        MyBase.Close()
    End Sub

    'This sub routine opens the form that shows all the records in the subscription table
    Private Sub BtnShowRecords_click(sender As Object, e As EventArgs) Handles BtnShowRecords.Click
        Me.Tag = "SafeClose"
        Subscription_records.Show()
        Subscription_records.StartPosition = FormStartPosition.Manual
        Subscription_records.Location = Me.Location
        MyBase.Close()
    End Sub

    'This sub routine reopen Subscription dashboard form
    Private Sub BtnOpenSubDashboard_click(sender As Object, e As EventArgs) Handles BtnOpenSubDashboard.Click
        Subscription_DashBoard.Show()
        Subscription_DashBoard.StartPosition = FormStartPosition.Manual
        Subscription_DashBoard.Location = Me.Location
        MyBase.Hide()
    End Sub

    'this sub routine handles when the user tries to close the form
    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Tag <> "SafeClose" AndAlso e.CloseReason = CloseReason.UserClosing Then
            BtnOpenSubDashboard.PerformClick()
        End If
    End Sub
End Class