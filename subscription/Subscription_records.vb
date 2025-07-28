Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Data.SqlTypes


Public Class Subscription_records
    'this is the connection string used to connect to the database
    Public connectionString As String = "Data Source= localhost\SQLEXPRESS;Database=Cyber_Secure_Db;TrustServerCertificate=True;Integrated Security=True"

    'This sub routine runs the loadRecords Sub routine when the form loads
    Private Sub Subscription_records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecords()
    End Sub

    'This sub routine loads all the records from the database into the Datagridview
    Private Sub LoadRecords()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim table As New DataTable
                Dim query As String = "Select * from vw_Subscription"
                Dim adapter As New SqlDataAdapter(query, connection)

                adapter.Fill(table)

                DGVSubscriptionRecords.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'This subroutine reopens the subscriptions Dashboard form
    Private Sub btnopenSubscription_click(sender As Object, e As EventArgs) Handles BtnopenSubscrpitions.Click
        Subscription_DashBoard.Show()
        Subscription_DashBoard.StartPosition = FormStartPosition.Manual
        Subscription_DashBoard.Location = Me.Location
        MyBase.Close()
    End Sub

    'this sub routine handles when the user presses the X button at the top
    Private isHandlingClose As Boolean = False

    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing AndAlso Not isHandlingClose Then
            isHandlingClose = True

            ' Perform the action once, but avoid re-entering this event
            BtnopenSubscrpitions.PerformClick()

            isHandlingClose = False
        End If
    End Sub
End Class