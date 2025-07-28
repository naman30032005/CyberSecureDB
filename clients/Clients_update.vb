Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Data.SqlTypes

Public Class Clients_update
    'this is the connection string used to connect to database
    Public connectionString As String = "Data Source=localhost\SQLEXPRESS;Database=Cyber_Secure_Db;TrustServerCertificate=True;Integrated Security=True"



    'this sub routine runs the run data sub routine to fetch data from the sql server when the form is loaded
    Private Sub Clients_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
    End Sub



    'This sub routine fetches the data from the sql server and fills the data grid view
    Private Sub Load_Data()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "Select * from vw_clients"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter(query, connection)

                adapter.Fill(table)
                DgvUpdateClients.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error Loading Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'This sub routine auto adds the info of the client in the text boxes to update info
    Private Sub DgvUpdateClients_cellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUpdateClients.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgvUpdateClients.Rows(e.RowIndex)
            TxtID.Text = row.Cells("ID").Value.ToString()
            TxtName.Text = row.Cells("Name").Value.ToString()
            TxtEmail.Text = row.Cells("Email").Value.ToString()
            TxtPhone.Text = row.Cells("Phone").Value.ToString()
            TxtAddress.Text = row.Cells("Address").Value.ToString()
        End If
    End Sub



    'this sub routine applies validation rules and makes sure everything is correct befpre running the update procedure sub routine
    Private Sub BtnUpdate_click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrWhiteSpace(TxtID.Text) Then
            MessageBox.Show($"Please select an entry from the given records to update", "Record Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf Not Clients.NameValidation(TxtName.text) Then
            MessageBox.Show($"Apply following rules when naming the clients:{System.Environment.NewLine}1. Name must not be empty or whitespace{System.Environment.NewLine}2. Name must not contain any symbols or numbers", "Name not valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtName.Focus()
            Return
        ElseIf Not Clients.EmailValidation(TxtEmail.text) Then
            MessageBox.Show($"Apply following rules while entering the Email:{System.Environment.NewLine}1. Email must not be empty or whitespace{System.Environment.NewLine}2. Email must not have spaces or more than one @ symbol{System.Environment.NewLine}3. Ex: contact@domain.com", "Email not valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEmail.Focus()
            Return
        ElseIf Not Clients.PhoneValidation(TxtPhone.text) Then
            MessageBox.Show($"Apply following rules while entering the Phone number:{System.Environment.NewLine}1. Number must not be empty or whitespace{System.Environment.NewLine}2. Number may conatain the country code at the Start{System.Environment.NewLine}3.Number must not contain any spaces{System.Environment.NewLine}4. Ex: +640123456789", "Phone not valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPhone.Focus()
            Return
        ElseIf String.IsNullOrWhiteSpace(TxtAddress.Text) Then
            MessageBox.Show($"The address should not be empty", "Address not valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtAddress.Focus()
            Return
        End If

        Dim query As String = "usp_updateClients"
        Dim parameters As New Dictionary(Of String, Object) From
            {
            {"@ClientID", CType(TxtID.Text, Integer)},
            {"@ClientName", TxtName.Text},
            {"@ContactEmail", TxtEmail.Text},
            {"@ContactPhone", TxtPhone.Text},
            {"@HomeAddress", TxtAddress.Text}
        }
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            ExecuteProcedure(query, parameters)
        Else
            Return
        End If
    End Sub



    'this sub routine handles the communication with sqlserver and update the data there
    Private Sub ExecuteProcedure(query As String, parameters As Dictionary(Of String, Object))
        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.CommandType = CommandType.StoredProcedure
                    For Each param In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Client Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_Data()
                    BtnReset.PerformClick()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'This resets all the fields in the form
    Private Sub BtnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        DgvUpdateClients.ClearSelection()
        TxtID.Clear()
        TxtName.Clear()
        TxtPhone.Clear()
        TxtEmail.Clear()
        TxtAddress.Clear()
    End Sub



    'This sub routine is used to open the dashboard form using a method from client dashboard class
    Private Sub BtnOpenDashboard_click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
        Me.Tag = "SafeClose"
        client_dashboard.OpenForm(Dashboard)
        MyBase.Close()
    End Sub



    'this sub routine programms the button to communicate with the database and check if the connection is working 
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



    'This sub routine is used to open client dashboard form 
    Private Sub BtnOpenClientDashboard_click(sender As Object, e As EventArgs) Handles BtnOpenClientDashboard.Click
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