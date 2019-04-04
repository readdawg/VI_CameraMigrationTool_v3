Public Class ServerProperties

    Dim Database As String = "InsightEnt"
    Public SQL As New sqlControl()

    Private Sub LoadCamServer()

        'Clear Combobox
        cbxServerName.Items.Clear()

        'Run Query
        SQL.ExecQuery("SELECT ServerName FROM dbo.Servers;")

        If SQL.HasException(True) Then Exit Sub

        'Loop Through Each Row and Add To ComboBox
        For Each r As DataRow In SQL.DBDT.Rows
            cbxServerName.Items.Add(r("ServerName").ToString)

        Next

    End Sub

    Private Sub LoadServerName()

        'Reload ComboBox
        cbxServerName.Items.Clear()

        'Run Query
        SQL.ExecQuery("SELECT ServerName FROM dbo.Servers;")

        If SQL.HasException(True) Then Exit Sub

        'Loop Through Each Row and Add To ComboBox
        For Each r As DataRow In SQL.DBDT.Rows
            cbxServerName.Items.Add(r("ServerName").ToString)

        Next

    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click

        SQL.ExecQuery("
               USE InsightEnt
               Update dbo.Servers
               SET Active = '" & cbxServerStatus.Text & "' WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxServerName.Text & "');")

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set Parent
        MdiParent = LandingPad
        LoadServerName()

    End Sub
End Class