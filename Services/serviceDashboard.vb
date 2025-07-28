Public Class serviceDashboard
    'this sub routine uses open forms sub routine to open services form that add services
    Private Sub btnOpenServices_click(sender As Object, e As EventArgs) Handles Btnopenservices.Click
        openForm(Services)
    End Sub



    'this sub routine uses open forms sub routine to open the serviceUPadte form
    Private Sub btnOpenUpdateServices_click(sender As Object, e As EventArgs) Handles BtnOpenUpdateServices.Click
        openForm(serviceUpdate)
    End Sub



    'this sub routine uses open forms sub routine to open the serviceDelete form
    Private Sub btnOpenDeleteServices_click(sender As Object, e As EventArgs) Handles BtnOpenDeleteServices.Click
        openForm(serviceDelete)
    End Sub



    'this sub routine uses open forms sub routine to open the serviceRecords form
    Private Sub btnOpenServiceRecords_click(sender As Object, e As EventArgs) Handles BtnOpenServiceRecords.Click
        openForm(serviceRecords)
    End Sub



    'this sub routine uses open forms sub routine to open the Dashboard form
    Private Sub btnOpenDashboard_click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
        openForm(Dashboard)
    End Sub



    'this sub routine is used by other sub routines to open different forms
    Public Sub openForm(target As Form)
        target.Show()
        target.StartPosition = FormStartPosition.Manual
        target.Location = Me.Location
        MyBase.Hide()
    End Sub


    'this sub routine handles when the user tries to close the form
    Private Sub CloseButtonClicked_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            BtnOpenDashboard.PerformClick()
        End If
    End Sub
End Class