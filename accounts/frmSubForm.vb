Imports System.Configuration
Imports System.Data.SqlTypes
Imports Microsoft.Data.SqlClient

Public Class frmSubForm
    Public Property accountID As Integer
    Private connectionString As String = "Data source = localhost\SQLEXPRESS;Database=Cyber_Secure_Db;Integrated Security=True;TrustServerCertificate=True"

    Private Sub frmSubForm_load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        LoadServices()
        LoadAccounts()
    End Sub

    Private Sub LoadData()
        Try
            Dim query As String = "usp_getData"
            Dim table As New DataTable()
            Using connection As New SqlConnection(connectionString)

                connection.Open()

                Dim adapter As New SqlDataAdapter(query, connection)

                adapter.SelectCommand.CommandType = CommandType.StoredProcedure

                adapter.SelectCommand.Parameters.AddWithValue("@accountID", accountID)

                adapter.Fill(table)

                DgvShowAccountRecords.DataSource = table
            End Using
        Catch ex As Exception

        End Try
    End Sub



    'this routine loads the data in the services combo box
    Private Sub LoadServices()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "select serviceid, servicename from services"
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim table As New DataTable()

                adapter.Fill(table)

                CboServices.DataSource = table
                CboServices.DisplayMember = "servicename"
                CboServices.ValueMember = "serviceid"
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error Loading Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'Used to get accounts info from the database to fill the combo box
    Private Sub LoadAccounts()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim Query As String = $"select accountname from accounts where accountID = {accountID.ToString}"
                Dim adapter As New SqlDataAdapter(Query, connection)
                Dim table As New DataTable()

                adapter.Fill(table)

                TxtaccountName.Text = table.Rows(0).Item(0).ToString

            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this routine is used to fill the textbox and comboboxes when a cell is clicked in the datagrid view
    Private Sub DgvShowAccountRecords_cellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvShowAccountRecords.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgvShowAccountRecords.Rows(e.RowIndex)
            CboServices.Text = row.Cells("ServiceName").Value
            DtpSubDate.Value = row.Cells("SubscriptionDate").Value
        End If
    End Sub



    'Submit button to submit the data in the database server
    Private Sub btninsertSubscription_click(sender As Object, e As EventArgs) Handles BtnInsertSubscription.Click
        If accountID <= 0 OrElse CboServices.SelectedIndex = -1 OrElse DtpSubDate.Value > Today Then
            MessageBox.Show("Please select a record from the table and choose a valid service, date before adding a service", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim query As String = "usp_insertSubscription"
        Dim parameters As New Dictionary(Of String, Object) From
            {
            {"@accountid", accountID},
            {"@serviceid", CType(CboServices.SelectedValue, Integer)},
            {"@date", DtpSubDate.Value}
        }
        insertProcedure(query, parameters)
        LoadData()
    End Sub



    'This function handles the connection and submition of the data
    Private Sub insertProcedure(query As String, parameters As Dictionary(Of String, Object))

        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.CommandType = CommandType.StoredProcedure
                    For Each param In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    connection.Open()

                    command.ExecuteNonQuery()

                    MessageBox.Show("Subscription Managed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'this button is used to delete the records using the selected row from dgv
    Private Sub BtnDeleteSubscription_click(sender As Object, e As EventArgs) Handles BtnDeleteSusbcription.Click
        If DgvShowAccountRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim query As String = "usp_deletesubscription"
        Dim parameter As New Dictionary(Of String, Object) From {{"@subscriptionid", DgvShowAccountRecords.SelectedRows(0).Cells("ID").Value}}
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this result?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            insertProcedure(query, parameter)
            LoadData()
            DgvShowAccountRecords.ClearSelection()
        Else
            Return
        End If
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



    'this sub routine runs when the back button is clickes
    Private Sub BtnOpenAccountupdate_Click(sender As Object, e As EventArgs) Handles BtnOpenAccountUpdate.Click
        AccountUpdate.Show()
        AccountUpdate.StartPosition = FormStartPosition.Manual
        AccountUpdate.Location = Me.Location
        MyBase.Close()
    End Sub



    'this sub routine handles when the user presses the X button at the top
    Private isHandlingClose As Boolean = False

    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Tag <> "SafeClose" AndAlso e.CloseReason = CloseReason.UserClosing AndAlso Not isHandlingClose Then
            isHandlingClose = True

            ' Perform the action once, but avoid re-entering this event
            BtnOpenAccountUpdate.PerformClick()

            isHandlingClose = False
        End If
    End Sub
End Class