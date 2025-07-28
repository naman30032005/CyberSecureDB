Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Data.SqlTypes
Public Class serviceRecords
    'this is the connection string used to connect to the sql server
    Public connectionString As String = "Data source = localhost\SQLEXPRESS;Database=Cyber_Secure_Db;Integrated Security=True;TrustServerCertificate=True"



    'this sub routine runs another sub routine when the form is loaded
    Private Sub serviceRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub



    'This sub rouutine fetches the data from the sql server
    Private Sub LoadData()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "select serviceid as 'Service ID', servicename as 'Service Name', servicedesc as 'Service description' from services "
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter(query, connection)

                adapter.Fill(table)

                DgvShowServiceRecords.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this sub routine opens the service dashboard form
    Private Sub BtnOpenServiceDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenServiceDashboard.Click
        serviceDashboard.Show()
        serviceDashboard.StartPosition = FormStartPosition.Manual
        serviceDashboard.Location = Me.Location
        MyBase.Close()
    End Sub



    'this sub routine handles when the user presses the X button at the top
    Private isHandlingClose As Boolean = False

    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing AndAlso Not isHandlingClose Then
            isHandlingClose = True

            ' Perform the action once, but avoid re-entering this event
            BtnOpenServiceDashboard.PerformClick()

            isHandlingClose = False
        End If
    End Sub
End Class