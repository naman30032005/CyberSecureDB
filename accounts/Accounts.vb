Imports Microsoft.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class Accounts
    'this is the connection string used to connect to the sqlserver
    Public connectionString As String = "Data source = localhost\SQLEXPRESS;Database=Cyber_Secure_Db;Integrated Security=True;TrustServerCertificate=True"



    'this sub routine loads data in combo box from sql server
    Private Sub Accounts_load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub



    'this sub routine communicates with the sql server to fetch data
    Private Sub LoadData()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "select clientID, ClientName from Clients"
            Dim table As New DataTable()
            Dim adapter As New SqlDataAdapter(query, connection)

            adapter.Fill(table)

            CboClient.DataSource = table
            CboClient.DisplayMember = "ClientName"
            CboClient.ValueMember = "ClientID"
        End Using
    End Sub



    'this button resets the form
    Private Sub BtnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtName.Clear()
        CboClient.SelectedIndex = -1
        DtpAccountDate.Value = Today
    End Sub



    'this sub routine checks the fields before running the execute procedure sub routine
    Private Sub BtnSubmit_click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If String.IsNullOrWhiteSpace(TxtName.Text) OrElse CboClient.SelectedIndex = -1 OrElse DtpAccountDate.Value > Today Then
            MessageBox.Show("Please make sure all the fields are correctly filled.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "usp_insertAccount"
        Dim parameters As New Dictionary(Of String, Object) From {{"@AccountName", TxtName.Text}, {"@ClientID", CType(CboClient.SelectedValue, Integer)}, {"@SUbscriptionDAte", DtpAccountDate.Value}}

        ExecuteProcedure(query, parameters)
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
                    MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnReset.PerformClick()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this sub routine uses the open form sub routine from Account dashboardform to open the dashboard form 
    Private Sub BtnOpenDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
        Me.Tag = "SafeClose"
        AccountDashboard.openForm(Dashboard)
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


    'this form uses the open form subroutine from te Account dashboard to open the Account records form
    Private Sub BtnOpenAccountRecords_Click(sender As Object, e As EventArgs) Handles BtnOpenAccountRecords.Click
        Me.Tag = "SafeClose"
        AccountDashboard.openForm(AccountRecords)
        MyBase.Close()
    End Sub



    'this sub routine runs when the back button is clickes
    Private Sub BtnOpenAccountDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenAccountDashboard.Click
        AccountDashboard.Show()
        AccountDashboard.StartPosition = FormStartPosition.Manual
        AccountDashboard.Location = Me.Location
        MyBase.Hide()
    End Sub



    'this sub routine handles when the user presses the X button at the top
    Private isHandlingClose As Boolean = False

    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Tag <> "SafeClose" AndAlso e.CloseReason = CloseReason.UserClosing AndAlso Not isHandlingClose Then
            e.Cancel = True
            isHandlingClose = True

            ' Perform the action once, but avoid re-entering this event
            BtnOpenAccountDashboard.PerformClick()

            isHandlingClose = False
        End If
    End Sub
End Class