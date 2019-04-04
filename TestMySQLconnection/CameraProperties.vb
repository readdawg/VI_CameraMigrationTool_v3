Public Class CameraProperties


    Dim Database As String = "InsightEnt"
    Public SQL As New sqlControl()

    Private Sub LoadCamServer()

        'Clear Combobox
        cbxCamServer.Items.Clear()

        'Run Query
        SQL.ExecQuery("SELECT ServerName FROM dbo.Servers;")

        If SQL.HasException(True) Then Exit Sub

        'Loop Through Each Row and Add To ComboBox
        For Each r As DataRow In SQL.DBDT.Rows
            cbxCamServer.Items.Add(r("ServerName").ToString)

        Next


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub cbxCamServer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbxCamServer.SelectedIndexChanged

    End Sub

    Private Sub CamProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set Parent
        MdiParent = LandingPad
        LoadCamServer()

    End Sub

    Private Sub btnRecType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecType.Click

        If cbxRecType.Text = "Record Off" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET RecordingType = 1 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

        If cbxRecType.Text = "Record Always" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET RecordingType = 2 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

        If cbxRecType.Text = "Motion Only" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET RecordingType = 3 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")


    End Sub

    Private Sub btnCapRes_Click(sender As Object, e As EventArgs) Handles btnCapRes.Click

        If cbxCapRes.Text = "Camera Settings" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET IPCaptureResolution = 0 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

        If cbxCapRes.Text = "Low" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET IPCaptureResolution = 1 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

        If cbxCapRes.Text = "Normal" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET IPCaptureResolution = 2 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

        If cbxCapRes.Text = "High" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET IPCaptureResolution = 3 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

        If cbxCapRes.Text = "Highest" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET IPCaptureResolution = 4 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

    End Sub

    Private Sub btnCapQual_Click(sender As Object, e As EventArgs) Handles btnCapQual.Click

        If cbxCapQual.Text = "Camera Settings" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET IPCaptureQuality = 0 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

        If cbxCapQual.Text = "Lowest" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET IPCaptureQuality = 1 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

        If cbxCapQual.Text = "Low" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET IPCaptureQuality = 2 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

        If cbxCapQual.Text = "Normal" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET IPCaptureQuality = 3 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

        If cbxCapQual.Text = "High" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET IPCaptureQuality = 4 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

        If cbxCapQual.Text = "Highest" Then SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET IPCaptureQuality = 5 WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

    End Sub

    Private Sub btnCapFps_Click(sender As Object, e As EventArgs) Handles btnCapFps.Click

        Dim vFps As Integer
        Dim cFps As Integer

        If Integer.TryParse(txtFps.Text, vFps) Then cFps = vFps * 1000000 Else MsgBox("Please Enter a valid frame rate")

        SQL.ExecQuery("
               USE InsightEnt
               Update dbo.Cameras
               SET RecordingFrameRate = " & cFps & "WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

    End Sub

    Public Sub CameraMD(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET IPUseCameraMD = 'True'
                WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxCamServer.Text & "');")

        Else

            SQL.ExecQuery(Query)

        End If

        If SQL.HasException(True) Then Exit Sub

    End Sub

    Private Sub bnCamMD_Click(sender As Object, e As EventArgs) Handles btnCamMD.Click

        CameraMD()

    End Sub
End Class