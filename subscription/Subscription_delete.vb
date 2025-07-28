Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Data.SqlTypes

Public Class Subscription_delete
    'this is the connection string used to connect to the database
    Public connectionString As String = "Data Source=localhost\SQLEXPRESS;Database=Cyber_Secure_Db;TrustServerCertificate=True;Integrated Security= True"



    'this routine runs another routines when the form is loaded
    Private Sub Subscription_delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub



    'this routine is used to load data in the datagrid view
    Private Sub loadData()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "select * from vw_Subscription"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter(query, connection)

                adapter.Fill(table)

                DgvDeleteSubscription.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error Loading Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this routine is used to Test connection with the database
    Private Sub BtnTestConnection_Click(sender As Object, e As EventArgs) Handles BtnTestConnection.Click
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                MessageBox.Show("Connection Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Connection Failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



    'this routine is used to open the dashboard form when the back to dashboard button is pressed
    Private Sub BtnOpenDashboard_click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
        Me.Tag = "SafeClose"
        Dashboard.Show()
        Dashboard.StartPosition = FormStartPosition.Manual
        Dashboard.Location = Me.Location
        MyBase.Close()
    End Sub



    'this routine is used to open the subscription dashboard form when the button is pressed
    Private Sub BtnOpenSubDashboard_click(sender As Object, e As EventArgs) Handles BtnOpenSubDashboard.Click
        Subscription_DashBoard.Show()
        Subscription_DashBoard.StartPosition = FormStartPosition.Manual
        Subscription_DashBoard.Location = Me.Location
        MyBase.Close()
    End Sub



    'this routine is used to reset the selection when reset button is pressed
    Private Sub BtnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        DgvDeleteSubscription.ClearSelection()
    End Sub



    'this button is used to delete the records using the selected row from dgv
    Private Sub BtnDelete_click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DgvDeleteSubscription.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim query As String = "usp_deletesubscription"
        Dim parameter As New Dictionary(Of String, Object) From {{"@subscriptionid", DgvDeleteSubscription.SelectedRows(0).Cells("SubscriptionID").Value}}
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this result?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            executeProcedure(query, parameter)
            loadData()
            DgvDeleteSubscription.ClearSelection()
        Else
            Return
        End If
    End Sub



    'this routine communicates in the back with the database to delete the records
    Private Sub executeProcedure(query As String, parameter As Dictionary(Of String, Object))
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.CommandType = CommandType.StoredProcedure

                For Each param In parameter
                    command.Parameters.AddWithValue(param.Key, param.Value)
                Next

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Subscription Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
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