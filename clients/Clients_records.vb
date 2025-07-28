Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Data.SqlTypes

Public Class Clients_records

    'connection String used to connect to the database
    Public connectionString As String = "Data source=localhost\SQLEXPRESS;Database=Cyber_Secure_Db;TrustServerCertificate=True;Integrated Security=True"

    'This sub routine works whne the form is loaded
    Private Sub Clients_records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
    End Sub

    'This sub routine tries to connect to the database and retrieve data to fill in DataGridView
    Private Sub Load_Data()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "Select * from vw_Clients"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter(query, connection)

                adapter.Fill(table)

                DgvClientRecords.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'This Sub routine opens the clientDashBoardForm
    Private Sub BtnOpenClientDashboard_click(sender As Object, e As EventArgs) Handles BtnOpenClientsDashboard.Click
        client_dashboard.Show()
        client_dashboard.StartPosition = FormStartPosition.Manual
        client_dashboard.Location = Me.Location
        MyBase.Close()
    End Sub


    'this sub routine handles when the user presses the X button at the top
    Private isHandlingClose As Boolean = False

    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing AndAlso Not isHandlingClose Then
            isHandlingClose = True

            ' Perform the action once, but avoid re-entering this event
            BtnOpenClientsDashboard.PerformClick()

            isHandlingClose = False
        End If
    End Sub
End Class