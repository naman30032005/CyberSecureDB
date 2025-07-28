Imports Microsoft.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class incidentUpdate
    'this is the connection string used to connect to the sqlserver
    Public connectionString As String = "Data source = localhost\SQLEXPRESS;Database=Cyber_Secure_Db;Integrated Security=True;TrustServerCertificate=True"



    'this sub routine runs other sub routines when the form is loaded
    Private Sub incidentUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        LoadAccounts()
    End Sub



    'This sub rouutine fetches the data from the sql server
    Private Sub LoadData()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "select * from vw_incidents"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter(query, connection)

                adapter.Fill(table)

                DgvShowIncidentRecords.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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



    'this sub routine automaticaaly fills out the fields when a cell is clicked in the data grid view
    Private Sub DgvShowIncidentRecords_cellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvShowIncidentRecords.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgvShowIncidentRecords.Rows(e.RowIndex)
            TxtID.Text = row.Cells(0).Value
            TxtName.Text = row.Cells(1).Value.ToString
            TxtDesc.Text = row.Cells(2).Value.ToString
            DtpDate.Value = row.Cells(3).Value
            If (row.Cells(4).Value = "R") Then
                RbResolved.Checked = True
            Else
                RbPending.Checked = True
            End If
            CboAccounts.Text = row.Cells(5).Value
        End If
    End Sub



    'this sub routine clears the form for the new entry
    Private Sub BtnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtName.Clear()
        TxtDesc.Clear()
        DtpDate.Value = Today
        RbResolved.Checked = False
        RbPending.Checked = False
        CboAccounts.SelectedIndex = -1
        DgvShowIncidentRecords.ClearSelection()
    End Sub



    'this sub routine checks if the fields are properly filled before running the execute procedure
    Private Sub btnSubmit_click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If DgvShowIncidentRecords.SelectedRows.Count < 1 OrElse String.IsNullOrWhiteSpace(TxtName.Text) OrElse String.IsNullOrWhiteSpace(TxtDesc.Text) OrElse DtpDate.Value > Today OrElse (RbResolved.Checked = False AndAlso RbPending.Checked = False) OrElse CboAccounts.SelectedIndex = -1 Then
            MessageBox.Show("Please make sure all the fields are correctly filled.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "usp_updateIncidents"

        Dim radioresult As Char
        If RbPending.Checked = True Then
            radioresult = "P"
        Else
            radioresult = "R"
        End If

        Dim parameters As New Dictionary(Of String, Object) From
            {
        {"incidentID", CType(TxtID.Text, Integer)},
        {"incidentType", TxtName.Text},
        {"incidentDesc", TxtDesc.Text},
        {"incidentDate", DtpDate.Value},
        {"Status", radioresult},
        {"AccountID", CType(CboAccounts.SelectedValue, Integer)}
        }

        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            ExecuteProcedure(query, parameters)
        Else
            Return
        End If
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
                    MessageBox.Show("Incident updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnReset.PerformClick()
                    LoadData()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this sub routine uses the open form sub routine from client dashboardform to open the dashboard form 
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



    'this sub routine runs when the back button is clickes
    Private Sub BtnOpenIncidentDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenIncidentDashboard.Click
        incidentDashboard.Show()
        incidentDashboard.StartPosition = FormStartPosition.Manual
        incidentDashboard.Location = Me.Location
        MyBase.Close()
    End Sub



    'this sub routine handles when the user presses the X button at the top
    Private isHandlingClose As Boolean = False

    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Tag <> "SafeClose" AndAlso e.CloseReason = CloseReason.UserClosing AndAlso Not isHandlingClose Then
            isHandlingClose = True

            ' Perform the action once, but avoid re-entering this event
            BtnOpenIncidentDashboard.PerformClick()

            isHandlingClose = False
        End If
    End Sub
End Class