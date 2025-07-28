Imports System.Configuration
Imports System.Data.SqlTypes
Imports Microsoft.Data.SqlClient
Public Class AccountUpdate
    'this is the connection string used to connect to the sql server
    Public connectionString As String = "Data source = localhost\SQLEXPRESS;Database=Cyber_Secure_Db;Integrated Security=True;TrustServerCertificate=True"



    'this sub routine runs another sub routine when the form is loaded
    Private Sub AccountUpdate_load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        LoadClients()
        BtnOpenSubMenu.Enabled = False
    End Sub



    'This sub rouutine fetches the data from the sql server
    Private Sub LoadData()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "select * from vw_accounts"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter(query, connection)

                adapter.Fill(table)

                DgvShowAccountRecords.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this sub routine communicates with the sql server to fetch data
    Private Sub LoadClients()
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



    'this autofills the field when one of the records is selected
    Private Sub DgvShowAccountRecords_cellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvShowAccountRecords.CellClick
        If (e.RowIndex >= 0) Then
            Dim row As DataGridViewRow = DgvShowAccountRecords.Rows(e.RowIndex)
            TxtID.Text = row.Cells(0).Value
            TxtName.Text = row.Cells(1).Value.ToString
            CboClient.Text = row.Cells(2).Value.ToString
            DtpAccountDate.Value = row.Cells(3).Value
            BtnOpenSubMenu.Enabled = True
        End If
    End Sub



    'this button resets the form
    Private Sub BtnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        DgvShowAccountRecords.ClearSelection()
        TxtID.Clear()
        TxtName.Clear()
        CboClient.SelectedIndex = -1
        DtpAccountDate.Value = Today
        BtnOpenSubMenu.Enabled = False
    End Sub



    'this accounts checks the fields before running the execute procedure usb routine
    Private Sub BtnSubmit_click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If DgvShowAccountRecords.SelectedRows.Count < 1 OrElse String.IsNullOrWhiteSpace(TxtID.Text) OrElse String.IsNullOrWhiteSpace(TxtName.Text) OrElse CboClient.SelectedIndex = -1 OrElse DtpAccountDate.Value > Today Then
            MessageBox.Show("Please make sure all the fields are correctly filled.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "usp_updateAccount"
        Dim parameters As New Dictionary(Of String, Object) From {{"@AccountID", CType(TxtID.Text, Integer)}, {"@AccountName", TxtName.Text}, {"@ClientID", CType(CboClient.SelectedValue, Integer)}, {"@SUbscriptionDAte", DtpAccountDate.Value}}

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
                    MessageBox.Show("Account updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnReset.PerformClick()
                    LoadData()
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



    'this button handles the sub form part of the form
    Private Sub BtnOpenSubForm_click(sender As Object, e As EventArgs) Handles BtnOpenSubMenu.Click
        If String.IsNullOrWhiteSpace(TxtID.Text) Then
            MessageBox.Show("Please select a record before pressing the button", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        frmSubForm.accountID = CType(TxtID.Text, Integer)
        frmSubForm.Show()
        frmSubForm.StartPosition = FormStartPosition.Manual
        frmSubForm.Location = Me.Location
        MyBase.Hide()
    End Sub



    'this sub routine runs when the back button is clickes
    Private Sub BtnOpenAccountDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenAccountDashboard.Click
        AccountDashboard.Show()
        AccountDashboard.StartPosition = FormStartPosition.Manual
        AccountDashboard.Location = Me.Location
        MyBase.Close()
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