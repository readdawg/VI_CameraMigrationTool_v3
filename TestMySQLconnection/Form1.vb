Public Class LandingPad
    Private Sub miInventory_Click(sender As Object, e As EventArgs) Handles miHardware.Click

    End Sub

    Private Sub ConnectionInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionInfoToolStripMenuItem.Click

        'Load Settings form
        SettingsForm.Show()

    End Sub

    Private Sub CameraListingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CameraListingToolStripMenuItem.Click

        'Load inventory form
        Cameras.Show()

    End Sub

    Private Sub ChangeRecordingTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeRecordingTypeToolStripMenuItem.Click

        'Load Recording Settings
        CameraProperties.Show()

    End Sub

    Private Sub ChangeServerPropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeServerPropertiesToolStripMenuItem.Click

        'Load Server Properties
        ServerProperties.Show()

    End Sub

    Private Sub SQLQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SQLQueryToolStripMenuItem.Click

        'Load SQLQuery

        SQLPanel.Show()

    End Sub

    Private Sub ServiceRestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceRestartToolStripMenuItem.Click

        'Load Service Restart
        ServiceRestart.Show()


    End Sub

    Private Sub LandingPad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'SettingsForm.WindowState = FormWindowState.Maximized
        If (My.Settings.isConfigured = False) Then

            SettingsForm.Show()

        End If

    End Sub

    Private Sub FirmwareUpgradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FirmwareUpgradeToolStripMenuItem.Click

        'Load Camera Tool
        CameraMig2.Show()

    End Sub

    Private Sub LPRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LPRToolStripMenuItem.Click

        Lpr.Show()

    End Sub

    Private Sub BitrateUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitrateUpdateToolStripMenuItem.Click

        Bitrate.Show()

    End Sub


End Class
