Imports Microsoft.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class BillingDelete
    'this is the connection string used to connect to the sqlserver
    Public connectionString As String = "Data source = localhost\SQLEXPRESS;Database=Cyber_Secure_Db;Integrated Security=True;TrustServerCertificate=True"



    'this sub routine loads data in combo box from sql server
    Private Sub BillingUpdate_load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub



    'This sub rouutine fetches the data from the sql server
    Private Sub LoadData()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "select * from vw_billing"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter(query, connection)

                adapter.Fill(table)

                DgvShowBillingRecords.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this sub routine clears the form for the new entry
    Private Sub BtnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        DgvShowBillingRecords.ClearSelection()
    End Sub



    Private Sub BtnSubmit_click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If DgvShowBillingRecords.SelectedRows.Count < 1 Then
            MessageBox.Show("Please choose an entry to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim row As DataGridViewRow = DgvShowBillingRecords.SelectedRows(0)

        Dim query As String = "usp_deleteBilling"
        Dim parameters As New Dictionary(Of String, Object) From {{"BillingID", CType(row.Cells(0).Value, Integer)}}
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            executeProcedure(query, parameters)
            LoadData()
            BtnReset.PerformClick()
        Else
            Return
        End If
    End Sub



    'this sub routine communicates wth the sql server to add Billing 
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
                    MessageBox.Show("Bill Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnReset.PerformClick()
                    LoadData()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this sub routine uses the open form sub routine from billing dashboardform to open the dashboard form 
    Private Sub BtnOpenDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
        Me.Tag = "SafeClose"
        BIllingDashboard.openForm(Dashboard)
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



    'this sub routine runs when the back button is clickes
    Private Sub BtnOpenBillingDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenBillingDashboard.Click
        BIllingDashboard.Show()
        BIllingDashboard.StartPosition = FormStartPosition.Manual
        BIllingDashboard.Location = Me.Location
        MyBase.Close()
    End Sub


    'this sub routine handles when the user presses the X button at the top
    Private isHandlingClose As Boolean = False

    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Tag <> "SafeClose" AndAlso e.CloseReason = CloseReason.UserClosing AndAlso Not isHandlingClose Then
            isHandlingClose = True

            ' Perform the action once, but avoid re-entering this event
            BtnOpenBillingDashboard.PerformClick()

            isHandlingClose = False
        End If
    End Sub
End Class