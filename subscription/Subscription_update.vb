Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Data.SqlTypes

Public Class Subscription_update
    'connection string to connect to the database
    Public connectionString As String = "Data Source = localhost\SQLEXPRESS;Database=Cyber_Secure_Db;TrustServerCertificate=True;Integrated Security=True"



    'This routine runs other routines on form load 
    Private Sub Subscription_update_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_data()
        LoadAccount()
        LoadServices()
    End Sub



    'this routine loads the data in datagridview
    Private Sub Load_data()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "Select * from vw_subscription"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter(query, connection)

                adapter.Fill(table)
                DgvUpdateSubscription.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error Loading Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' this routine load the data in accounts combo box
    Private Sub LoadAccount()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim Query As String = "select accountid, accountname from accounts"
                Dim adapter As New SqlDataAdapter(Query, connection)
                Dim table As New DataTable()

                adapter.Fill(table)

                CboUpdateAccount.DataSource = table
                CboUpdateAccount.DisplayMember = "accountname"
                CboUpdateAccount.ValueMember = "accountid"
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error Loading Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this routine loads the data in the services combo box
    Private Sub LoadServices()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "select serviceid, servicename from services"
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim table As New DataTable()

                adapter.Fill(table)

                CboUpdateServices.DataSource = table
                CboUpdateServices.DisplayMember = "servicename"
                CboUpdateServices.ValueMember = "serviceid"
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error Loading Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this routine opens the dashboard form when back to dashboard button is pressed
    Private Sub BtnOpenDashBoard_click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
        Me.Tag = "SafeClose"
        Dashboard.Show()
        Dashboard.StartPosition = FormStartPosition.Manual
        Dashboard.Location = Me.Location
        MyBase.Close()
    End Sub



    'this routines is used to test the connection between databse and application
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



    'this routine is used to open the subscription dashboard form when the user presses the back button
    Private Sub BtnOpenSubDashboard_click(sender As Object, e As EventArgs) Handles BtnOpenSubDashboard.Click
        Subscription_DashBoard.Show()
        Subscription_DashBoard.StartPosition = FormStartPosition.Manual
        Subscription_DashBoard.Location = Me.Location
        MyBase.Close()
    End Sub



    'this routine is used to fill the textbox and comboboxes when a cell is clicked in the datagrid view
    Private Sub DgvUpdateSubscription_cellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUpdateSubscription.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgvUpdateSubscription.Rows(e.RowIndex)
            TxtID.Text = row.Cells("SubscriptionID").Value.ToString
            CboUpdateAccount.Text = row.Cells("AccountName").Value
            CboUpdateServices.Text = row.Cells("ServiceName").Value
            DtpUpdateDate.Value = row.Cells("SubscriptionDate").Value
        End If
    End Sub



    'this routine resets the selections when the reset button is pressed
    Private Sub BtnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtID.Clear()
        DgvUpdateSubscription.ClearSelection()
        CboUpdateAccount.SelectedIndex = -1
        CboUpdateAccount.SelectedIndex = -1
        DtpUpdateDate.Value = Today
    End Sub



    'this routine is used to validate user input and handle error when the submit button is pressed
    Private Sub BtnSubmit_click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If String.IsNullOrWhiteSpace(TxtID.Text) OrElse
   CboUpdateAccount.SelectedIndex = -1 OrElse
   CboUpdateServices.SelectedIndex = -1 Then
            MessageBox.Show("Please select one of the records presented above.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            Dim query As String = "usp_updateSubscription"
            Dim parameters As New Dictionary(Of String, Object) From
                {
                {"@subscriptionID", CType(TxtID.Text, Integer)},
                {"@Accountid", CType(CboUpdateAccount.SelectedValue, Integer)},
                {"@serviceid", CType(CboUpdateServices.SelectedValue, Integer)},
                {"@date", DtpUpdateDate.Value}
                }
            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmResult = DialogResult.Yes Then
                executeProcedure(query, parameters)
                MessageBox.Show("Data Updated Successfully")
                Load_data()
                BtnReset.PerformClick()
            Else
                Return
            End If
        Catch ex As Exception
            MessageBox.Show($"Update Failed: {ex.Message}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this routine handles the backend when the submit button is pressed and communicates with the databse to update the record
    Private Sub executeProcedure(query As String, parameters As Dictionary(Of String, Object))
        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.CommandType = CommandType.StoredProcedure

                    For Each param In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    connection.Open()

                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'this sub routine handles when the user tries to close the form
    Private isHandlingClose As Boolean = False

    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Tag <> "SafeClose" AndAlso e.CloseReason = CloseReason.UserClosing AndAlso Not isHandlingClose Then
            isHandlingClose = True

            ' Perform the action once, but avoid re-entering this event
            BtnOpenSubDashboard.PerformClick()

            isHandlingClose = False
        End If
    End Sub
End Class