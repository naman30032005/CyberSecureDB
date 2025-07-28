Public Class AccountDashboard

    'this sub routine uses the open form sub routine to open add Account form
    Private Sub BtnopenAccount_Click(sender As Object, e As EventArgs) Handles BtnopenAccount.Click
        openForm(Accounts)
    End Sub



    'this sub routine uses the open form sub routine to open update Account form
    Private Sub BtnOpenUpdateAccount_Click(sender As Object, e As EventArgs) Handles BtnOpenUpdateAccount.Click
        openForm(AccountUpdate)
    End Sub



    'this sub routine uses the open form sub routine to open delete Account form
    Private Sub BtnOpenDeleteAccount_Click(sender As Object, e As EventArgs) Handles BtnOpenDeleteAccount.Click
        openForm(AccountDelete)
    End Sub



    'this sub routine uses the open form sub routine to open Account record form
    Private Sub BtnOpenAccountRecords_Click(sender As Object, e As EventArgs) Handles BtnOpenAccountRecords.Click
        openForm(AccountRecords)
    End Sub



    'this sub routine uses the open form sub routine to open dashboard form
    Private Sub BtnOpenDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
        openForm(Dashboard)
    End Sub



    'this sub routine is used by other sub routines to open different forms
    Public Sub openForm(target As Form)
        Try
            target.Show()
            target.StartPosition = FormStartPosition.Manual
            target.Location = Me.Location
            MyBase.Hide()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'this sub routine handles when the user tries to close the form
    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            BtnOpenDashboard.PerformClick()
        End If
    End Sub
End Class