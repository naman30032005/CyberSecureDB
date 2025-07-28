Imports Microsoft.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Configuration

Public Class Billing
    'this is the connection string used to connect to the sqlserver
    Public connectionString As String = "Data source = localhost\SQLEXPRESS;Database=Cyber_Secure_Db;Integrated Security=True;TrustServerCertificate=True"



    'this sub routine loads data in combo box from sql server
    Private Sub Billing_load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub



    'this sub routine communicates with the sql server to fetch data
    Private Sub LoadData()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "select * from vw_BillingSubName"
            Dim table As New DataTable()
            Dim adapter As New SqlDataAdapter(query, connection)

            adapter.Fill(table)

            CboSubscription.DataSource = table
            CboSubscription.DisplayMember = "SubscriptionName"
            CboSubscription.ValueMember = "subscriptionID"
        End Using
    End Sub



    'this button resets the form
    Private Sub BtnReset_click(sender As Object, e As EventArgs) Handles BtnReset.Click
        CboSubscription.SelectedIndex = -1
        DTPSubDate.Value = Today
        TxtAmount.Clear()
        RBPaid.Checked = False
        RBUnpaid.Checked = False
    End Sub



    'this button checks the fields before running execute procedure sub routine
    Private Sub btnSubmit_click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If CboSubscription.SelectedIndex = 1 OrElse DTPSubDate.Value > Today OrElse (RBPaid.Checked = False AndAlso RBUnpaid.Checked = False) OrElse Not TxtAmount.MaskCompleted Then
            MessageBox.Show("Please make sure all the fields are correctly filled.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim radioResult As Char
        If RBPaid.Checked = True Then
            radioResult = "P"c
        Else
            radioResult = "U"c
        End If

        Dim query As String = "usp_insertBilling"
        Dim parameters As New Dictionary(Of String, Object) From
            {
            {"subscriptionID", CType(CboSubscription.SelectedValue, Integer)},
            {"billingDate", DTPSubDate.Value},
            {"Amount", Decimal.Parse(TxtAmount.Text)},
            {"Status", radioResult}
        }

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
                    MessageBox.Show("Billing Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnReset.PerformClick()
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


    'this form uses the open form subroutine from te billing dashboard to open the billing records form
    Private Sub BtnOpenBillingRecords_Click(sender As Object, e As EventArgs) Handles BtnOpenBillingtRecords.Click
        Me.Tag = "SafeClose"
        BIllingDashboard.openForm(billingRecords)
        MyBase.Close()
    End Sub



    'this sub routine runs when the back button is clickes
    Private Sub BtnOpenBillingDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenBillingDashboard.Click
        BIllingDashboard.Show()
        BIllingDashboard.StartPosition = FormStartPosition.Manual
        BIllingDashboard.Location = Me.Location
        MyBase.Hide()
    End Sub


    'this sub routine handles when the user tries to close the form
    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Tag <> "SafeClose" AndAlso e.CloseReason = CloseReason.UserClosing Then
            BtnOpenBillingDashboard.PerformClick()
        End If
    End Sub
End Class