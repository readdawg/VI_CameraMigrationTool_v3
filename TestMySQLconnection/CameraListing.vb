Public Class Cameras




    Public SQL As New sqlControl()

    Public Sub LoadGrid(Optional Query As String = "")



        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM dbo.Cameras;")

        Else

            SQL.ExecQuery(Query)

        End If

        If SQL.HasException(True) Then Exit Sub

        dgvData.DataSource = SQL.DBDT

    End Sub

    Private Sub LoadCBX()

        'Reload ComboBox
        cbxServers.Items.Clear()

        'Run Query
        SQL.ExecQuery("SELECT ServerName FROM dbo.Servers;")

        If SQL.HasException(True) Then Exit Sub

        'Loop Through Each Row and Add To ComboBox
        For Each r As DataRow In SQL.DBDT.Rows
            cbxServers.Items.Add(r("ServerName").ToString)

        Next

    End Sub

    Private Sub FindItem()

        SQL.AddParams("@CamName", "%" & txtSearch.Text & "%")
        LoadGrid("SELECT * FROM dbo.Cameras WHERE CameraName LIKE @CamName;")

    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set Parent
        MdiParent = LandingPad
        LoadGrid()
        LoadCBX()

    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click

        FindItem()

    End Sub

    Private Sub cbxItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxServers.SelectedIndexChanged

    End Sub


    Private Sub btnServerSearch_Click(sender As Object, e As EventArgs) Handles btnServerSearch.Click

        SQL.AddParams("@CamName", "%" & cbxServers.Text & "%")
        LoadGrid("SELECT * FROM dbo.Cameras WHERE ServerID = (SELECT ServerID FROM dbo.Servers WHERE ServerName = '" & cbxServers.Text & "');")

    End Sub
End Class