Imports Microsoft.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class Clients_delete
    'this is the connection string used to connect to the database
    Public connectionString As String = "Data source=localhost\SQLEXPRESS;Database=Cyber_Secure_Db;TrustServerCertificate=True;Integrated Security=True"



    'this sub routine runs when the form ius loaded and executes the load data sub routine to load data from the sql server
    Private Sub Clients_delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
    End Sub



    'this sub routine communicates with the sql serevre and load the data is data grid view
    Private Sub Load_Data()
        Using connection As New SqlConnection(connectionString)
            Try
                Dim query As String = "select * from clients"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter(query, connection)

                adapter.Fill(table)

                DgvDeleteClient.DataSource = table
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error Loading Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



    'this sub routine check if a row is selected before calling the execute procedure sub routine
    Private Sub BtnDelete_click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DgvDeleteClient.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim query As String = "usp_deleteClient"
        Dim parameter As New Dictionary(Of String, Object) From {{"@clientID", DgvDeleteClient.SelectedRows(0).Cells("ClientID").Value}}
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            executeProcedure(query, parameter)
            Load_Data()
            BtnReset.PerformClick()
        Else
            Return
        End If
    End Sub



    'this sub routine handles the communication with the sql server and uses the usp_deleteclient stired procedure to delete a client using client id
    Private Sub executeProcedure(query As String, parameters As Dictionary(Of String, Object))
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.CommandType = CommandType.StoredProcedure

                For Each param In parameters
                    command.Parameters.AddWithValue(param.Key, param.Value)
                Next

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Client Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub



    'this sub routine clears the selection in the data grid view
    Private Sub BtnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        DgvDeleteClient.ClearSelection()
    End Sub



    'this sub routine reopens the dashboard form
    Private Sub BtnOpenDashboard_click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
        Me.Tag = "SafeClose"
        client_dashboard.OpenForm(Dashboard)
        MyBase.Close()
    End Sub



    'this sub routine check the connection btween the sql server and the applpication
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



    'this sub routine reopens the client dashboard form 
    Private Sub Btnopenclientdashboard_click(sender As Object, e As EventArgs) Handles BtnOpenClientDashboard.Click
        client_dashboard.Show()
        client_dashboard.StartPosition = FormStartPosition.Manual
        client_dashboard.Location = Me.Location
        MyBase.Close()
    End Sub


    'this sub routine handles when the user presses the X button at the top
    Private isHandlingClose As Boolean = False

    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Tag <> "SafeClose" AndAlso e.CloseReason = CloseReason.UserClosing AndAlso Not isHandlingClose Then
            isHandlingClose = True

            ' Perform the action once, but avoid re-entering this event
            BtnOpenClientDashboard.PerformClick()

            isHandlingClose = False
        End If
    End Sub
End Class