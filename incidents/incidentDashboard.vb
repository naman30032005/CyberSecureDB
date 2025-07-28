Public Class incidentDashboard
    'this sub routine uses the open form sub routine to open add incident form
    Private Sub BtnopenIncidents_Click(sender As Object, e As EventArgs) Handles BtnopenIncidents.Click
        openForm(Incidents)
    End Sub



    'this sub routine uses the open form sub routine to open update incident form
    Private Sub BtnOpenUpdateIncidents_Click(sender As Object, e As EventArgs) Handles BtnOpenUpdateIncidents.Click
        openForm(incidentUpdate)
    End Sub



    'this sub routine uses the open form sub routine to open delete incident form
    Private Sub BtnOpenDeleteIncidents_Click(sender As Object, e As EventArgs) Handles BtnOpenDeleteIncidents.Click
        openForm(incidentDelete)
    End Sub



    'this sub routine uses the open form sub routine to open incident record form
    Private Sub BtnOpenIncidentRecords_Click(sender As Object, e As EventArgs) Handles BtnOpenIncidentRecords.Click
        openForm(incidentrecords)
    End Sub



    'this sub routine uses the open form sub routine to open dashboard form
    Private Sub BtnOpenDashboard_Click(sender As Object, e As EventArgs) Handles BtnOpenDashboard.Click
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