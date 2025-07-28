Imports Microsoft.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class Services
    'this is the connection string used to connect to the sqlserver
    Public connectionString As String = "Data source = localhost\SQLEXPRESS;Database=Cyber_Secure_Db;Integrated Security=True;TrustServerCertificate=True"



    'this sub routine clears the form for the new entry
    Private Sub BtnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtName.Clear()
        TxtDescription.Clear()
    End Sub



    'this sub routine checks the fields if they are empty before running the execute procedure sub routine
    Private Sub BtnSubmit_click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If String.IsNullOrWhiteSpace(TxtName.Text) OrElse String.IsNullOrWhiteSpace(TxtDescription.Text) Then
            MessageBox.Show("Please fill all the fields before submitting", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "usp_insertServices"
        Dim parameter As New Dictionary(Of String, Object) From {{"serviceName", TxtName.Text}, {"servicesDes", TxtDescription.Text}}

        ExecuteProcedure(query, parameter)
    End Sub



    'this sub routine communicates wth the sql server to add services 
    Private Sub ExecuteProcedure(query As String, Parameters As Dictionary(Of String, Object))
        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.CommandType = CommandType.StoredProcedure

                    For Each param In Parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Service Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnReset.PerformClick()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'this sub routine uses the open form sub routine from client dashboardform to open the dashboard form 
    Private Sub BtnOpenDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
        Me.Tag = "SafeClose"
        serviceDashboard.openForm(Dashboard)
        MyBase.Close()
    End Sub



    'this sub routine checks the connection between the application and the sql server
    Private Sub BtnTestConnection_click(sender As Object, e As EventArgs) Handles BtnTestConnection.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                MessageBox.Show("Connection Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show($"Connection Failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this form uses the open form subroutine from te client dashboard to open the service records form
    Private Sub BtnOpenServiceRecords_Click(sender As Object, e As EventArgs) Handles BtnOpenServiceRecords.Click
        Me.Tag = "SafeClose"
        serviceDashboard.openForm(serviceRecords)
        MyBase.Close()
    End Sub



    'this sub routine runs when the back button is clickes
    Private Sub BtnOpenServiceDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenServiceDashboard.Click
        serviceDashboard.Show()
        serviceDashboard.StartPosition = FormStartPosition.Manual
        serviceDashboard.Location = Me.Location
        MyBase.Hide()
    End Sub


    'this sub routine handles when the user tries to close the form
    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Tag <> "SafeClose" AndAlso e.CloseReason = CloseReason.UserClosing Then
            BtnOpenServiceDashboard.PerformClick()
        End If
    End Sub
End Class