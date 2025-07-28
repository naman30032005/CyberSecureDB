Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Data.SqlTypes

Public Class Clients
    'this is the connection string used to connect to database
    Public connectionString As String = "Data Source=localhost\SQLEXPRESS;Database=Cyber_Secure_Db;TrustServerCertificate=True;Integrated Security=True"



    'This function validates the name and makes sure the name is not empty and does not contain any number or symbols
    Public Shared Function NameValidation(name As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z\s]+$") And Not String.IsNullOrWhiteSpace(name)
    End Function



    'This function validates the email and makes sure it is not empty and adheres to general email rules
    Public Shared Function EmailValidation(email As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") And Not String.IsNullOrWhiteSpace(email)
    End Function



    'This function validates the phone number and makes sure it is not empty and adheres to the convention
    Public Shared Function PhoneValidation(phone As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(phone, "^(\+\d{1,3})?\d{10}$") And Not String.IsNullOrWhiteSpace(phone)
    End Function



    'this sub routine handles the flow when the user enters the create button, it uses the functions defined above to validate user input and call the sub routine execute procedure to communicate with the database
    Private Sub BtnSubmit_click(Sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If Not NameValidation(TxtName.Text) Then
            MessageBox.Show($"Apply following rules when naming the clients:{System.Environment.NewLine}1. Name must not be empty or whitespace{System.Environment.NewLine}2. Name must not contain any symbols or numbers", "Name not valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtName.Select()
            Return
        ElseIf Not EmailValidation(TxtEmail.text) Then
            MessageBox.Show($"Apply following rules while entering the Email:{System.Environment.NewLine}1. Email must not be empty or whitespace{System.Environment.NewLine}2. Email must not have spaces or more than one @ symbol{System.Environment.NewLine}3. Ex: contact@domain.com", "Email not valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEmail.Select()
            Return
        ElseIf Not PhoneValidation(TxtPhone.text) Then
            MessageBox.Show($"Apply following rules while entering the Phone number:{System.Environment.NewLine}1. Number must not be empty or whitespace{System.Environment.NewLine}2. Number may conatain the country code at the Start{System.Environment.NewLine}3.Number must not contain any spaces{System.Environment.NewLine}4. Ex: +640123456789 or 0123456789", "Phone not valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPhone.Select()
            Return
        ElseIf String.IsNullOrWhiteSpace(TxtAddress.Text) Then
            MessageBox.Show($"The address should not be empty", "Address not valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtAddress.Select()
            Return
        End If
        Dim query As String = "usp_insertClient"
        Dim paramters As New Dictionary(Of String, Object) From {
        {"@clientName", TxtName.Text},
        {"@ContactEmail", TxtEmail.Text},
        {"@ContactPhone", TxtPhone.Text},
        {"@HomeAddress", TxtAddress.Text}
        }
        ExecuteProcedure(query, paramters)
    End Sub




    'this clears all the fields in the form
    Private Sub BtnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtName.Clear()
        TxtPhone.Clear()
        TxtEmail.Clear()
        TxtAddress.Clear()
    End Sub




    'this dubroutine communicates with the databse to input data in the clients table 
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
                    MessageBox.Show("Client Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnReset.PerformClick()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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




    'this sub routine is used to open the client records form using the method in client dashboard class
    Private Sub BtnOpenclientRecords_click(sender As Object, e As EventArgs) Handles BtnOpenClientRecords.Click
        Me.Tag = "SafeClose"
        client_dashboard.OpenForm(Clients_records)
        MyBase.Close()
    End Sub




    'This sub routine is used to open client dashboard form 
    Private Sub BtnOpenClientDashboard_click(sender As Object, e As EventArgs) Handles BtnOpenClientDashboard.Click
        client_dashboard.Show()
        client_dashboard.StartPosition = FormStartPosition.Manual
        client_dashboard.Location = Me.Location
        MyBase.Hide()
    End Sub


    'this sub routine handles when the user tries to close the form
    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Tag <> "SafeClose" AndAlso e.CloseReason = CloseReason.UserClosing Then
            BtnOpenClientDashboard.PerformClick()
        End If
    End Sub
End Class