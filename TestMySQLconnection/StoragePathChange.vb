Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Public Class StoragePathChange

    Private Sub CameraFirmware_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set Parent
        MdiParent = LandingPad

        Call LoadCBX()

        'Set Server Combobox
        'cbxServerList.SelectedIndex = 0

    End Sub

    Public SQL As New sqlControl()

    Private Sub LoadCBX()

        'Reload ComboBox
        cbxServerList.Items.Clear()

        'Run Query
        SQL.ExecQuery("SELECT ServerName FROM dbo.Servers;")

        If SQL.HasException(True) Then Exit Sub

        'Loop Through Each Row and Add To ComboBox
        For Each r As DataRow In SQL.DBDT.Rows

            cbxServerList.Items.Add(r("ServerName").ToString)

        Next

    End Sub

    Private Sub cbxServerList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxServerList.SelectedIndexChanged

        'Clear new storage path
        txtPath.Text = ""

        'Populate DGV when server selected
        dgvCameras.Rows.Clear()

        SQL.AddParams("@CamName", "%" & cbxServerList.Text & "%")
        LoadCameras("SELECT CameraName, IPAddress, RecordingLocalDataPath, CameraID FROM dbo.Cameras WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxServerList.Text & "');")

    End Sub





    Public Sub LoadCameras(Optional Query As String = "")


        SQL.ExecQuery(Query)

        If SQL.HasException(True) Then Exit Sub

        'Dim model As String = Nothing

        'Loop Through Each Row and Add To ComboBox
        For Each r As DataRow In SQL.DBDT.Rows
            Dim n As Integer = dgvCameras.Rows.Add()
            dgvCameras.Rows(n).Cells(0).Value = "false"
            dgvCameras.Rows(n).Cells(1).Value = r("CameraName").ToString()
            dgvCameras.Rows(n).Cells(2).Value = r("IPAddress").ToString()
            dgvCameras.Rows(n).Cells(3).Value = r("RecordingLocalDataPath").ToString()
            dgvCameras.Rows(n).Cells(4).Value = r("CameraID")

        Next

    End Sub

    Private Sub btnUpgrade_Click(sender As Object, e As EventArgs) Handles btnUpgrade.Click

        Dim path As String = txtPath.Text
        Dim Query As String = ""
        Dim CameraID As Int32

        Try

            For Each r In dgvCameras.Rows

                If (Boolean.Parse(r.Cells(0).Value.ToString())) Then

                    CameraID = r.Cells(4).Value()

                    Call StorageUpdate(CameraID, Query)

                End If
            Next

        Catch ex As Exception

        End Try

        MsgBox("Storage Path Update Complete")

    End Sub

    Public Sub StorageUpdate(CameraID As Int32, Optional Query As String = "")

        If Query = "" Then
            SQL.ExecQuery("
                USE InsightEnt
                UPDATE dbo.Cameras
                SET RecordingLocalDataPath = '" & txtPath.Text & "'
                WHERE CameraID = " & CameraID & ";")

        Else

            SQL.ExecQuery(Query)

        End If

        If SQL.HasException(True) Then Exit Sub

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        'open the openfile dialog so the user can search for a file
        Dim openFileDialog1 As New OpenFileDialog()
        Dim openFolderDialog1 As New FolderBrowserDialog()

        'show the dialog
        openFolderDialog1.ShowDialog()

        'Populate textbox with selected path
        txtPath.Text = openFolderDialog1.SelectedPath

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Close button function
        Me.Close()

    End Sub


End Class