Imports Microsoft.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class Incidents
    'this is the connection string used to connect to the sqlserver
    Public connectionString As String = "Data source = localhost\SQLEXPRESS;Database=Cyber_Secure_Db;Integrated Security=True;TrustServerCertificate=True"



    'this runs the sub routine when the form is loaded
    Private Sub Incidents_load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccounts()
    End Sub



    'this sub routine fetches the account names from the sql server
    Private Sub LoadAccounts()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim Query As String = "select accountid, accountname from accounts"
                Dim adapter As New SqlDataAdapter(Query, connection)
                Dim table As New DataTable()

                adapter.Fill(table)

                CboAccounts.DataSource = table
                CboAccounts.DisplayMember = "accountname"
                CboAccounts.ValueMember = "accountid"
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this sub routine checks if the fields are properly filled and runs the execute procedure sub routine
    Private Sub BtnSubmit_click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If String.IsNullOrWhiteSpace(TxtName.Text) OrElse String.IsNullOrWhiteSpace(TxtDesc.Text) OrElse DtpDate.Value > Today OrElse (RbResolved.Checked = False AndAlso RbPending.Checked = False) OrElse CboAccounts.SelectedIndex = -1 Then
            MessageBox.Show("Please make sure all the fields are correctly filled.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim query As String = "usp_insertIncident"

        Dim radioresult As Char
        If RbPending.Checked = True Then
            radioresult = "P"
        Else
            radioresult = "R"
        End If

        Dim parameters As New Dictionary(Of String, Object) From
            {
        {"incidentType", TxtName.Text},
        {"incidentDesc", TxtDesc.Text},
        {"incidentDate", DtpDate.Value},
        {"Status", radioresult},
        {"AccountID", CType(CboAccounts.SelectedValue, Integer)}
        }

        executeProcedure(query, parameters)
    End Sub



    'this sub routine communicates wth the sql server to add incidents
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
                    MessageBox.Show("Incident Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnReset.PerformClick()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this sub routine clears the form for the new entry
    Private Sub BtnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtName.Clear()
        TxtDesc.Clear()
        DtpDate.Value = Today
        RbResolved.Checked = False
        RbPending.Checked = False
        CboAccounts.SelectedIndex = -1
    End Sub



    'this sub routine uses the open form sub routine from incident dashboardform to open the dashboard form 
    Private Sub BtnOpenDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
        Me.Tag = "SafeClose"
        incidentDashboard.openForm(Dashboard)
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


    'this form uses the open form subroutine from te incident dashboard to open the incident records form
    Private Sub BtnOpenIncidentRecords_Click(sender As Object, e As EventArgs) Handles BtnOpenIncidentRecords.Click
        Me.Tag = "SafeClose"
        incidentDashboard.openForm(incidentrecords)
        MyBase.Close()
    End Sub



    'this sub routine runs when the back button is clickes
    Private Sub BtnOpenIncidentDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenIncidentDashboard.Click
        incidentDashboard.Show()
        incidentDashboard.StartPosition = FormStartPosition.Manual
        incidentDashboard.Location = Me.Location
        MyBase.Hide()
    End Sub


    'this sub routine handles when the user tries to close the form
    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Tag <> "SafeClose" AndAlso e.CloseReason = CloseReason.UserClosing Then
            BtnOpenIncidentDashboard.PerformClick()
        End If
    End Sub
End Class