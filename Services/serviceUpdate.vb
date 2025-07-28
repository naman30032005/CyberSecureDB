Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Data.SqlTypes
Public Class serviceUpdate
    'this is the connection string used to connect to the sql server
    Public connectionString As String = "Data source = localhost\SQLEXPRESS;Database=Cyber_Secure_Db;Integrated Security=True;TrustServerCertificate=True"



    Private Sub serviceUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub



    'This sub rouutine fetches the data from the sql server
    Private Sub LoadData()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "select serviceid as 'Service ID', servicename as 'Service Name', servicedesc as 'Service Description' from services "
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter(query, connection)

                adapter.Fill(table)

                DgvShowServiceRecords.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this sub routine fills the textboxes when a row is delected in the records
    Private Sub DgvShowServiceRecords_cellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvShowServiceRecords.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgvShowServiceRecords.Rows(e.RowIndex)
            TxtID.Text = row.Cells("Service ID").Value
            TxtName.Text = row.Cells("Service Name").Value.ToString
            TxtDescription.Text = row.Cells("Service Description").Value.ToString
        End If
    End Sub



    'this sub routine is used to reset all the selections
    Private Sub BtnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtID.Clear()
        TxtName.Clear()
        TxtDescription.Clear()
        DgvShowServiceRecords.ClearSelection()
    End Sub



    'this sub routine checks the fields before running execute procedure sub routine
    Private Sub btnSubmit_click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If DgvShowServiceRecords.SelectedRows.Count < 1 OrElse String.IsNullOrWhiteSpace(TxtName.Text) OrElse String.IsNullOrWhiteSpace(TxtDescription.Text) Then
            MessageBox.Show("Please choose an entry from the given records and fill all the fields before submitting", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "usp_updateServices"
        Dim parameters As New Dictionary(Of String, Object) From {{"ServiceID", CType(TxtID.Text, Integer)}, {"Servicename", TxtName.Text}, {"ServiceDesc", TxtDescription.Text}}

        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            ExecuteProcedure(query, parameters)
        Else
            Return
        End If
    End Sub



    'this sub routine communicates with the sql server and updates the info
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
                    MessageBox.Show("Service Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadData()
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
        If Me.Tag <> "SafeClose" AndAlso e.CloseReason = CloseReason.UserClosing AndAlso Not isHandlingClose Then
            isHandlingClose = True

            ' Perform the action once, but avoid re-entering this event
            BtnOpenServiceDashboard.PerformClick()

            isHandlingClose = False
        End If
    End Sub
End Class