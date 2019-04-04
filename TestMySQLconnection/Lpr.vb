


Public Class Lpr

    Public SQL As New sqlControl()

    Public Sub LoadPlates()

        Dim Query As String = "SELECT KeyTime,KeyFrame, Thumbnail, ReservedSTR, UID_STR, oServerID, oCameraID FROM dbo.VideoFilesLog WHERE LogTypeID = 1001 AND KeyTime BETWEEN DATEADD(DD,-1,GETDATE()) AND GETDATE()"

        SQL.ExecQuery(Query)

        If SQL.HasException(True) Then Exit Sub

        Dim model As String = Nothing

        'Loop Through Each Row and Add To ComboBox
        For Each r As DataRow In SQL.DBDT.Rows
            Dim n As Integer = dgvLpr.Rows.Add()
            dgvLpr.Rows(n).Cells(0).Value = r("KeyTime").ToString()
            dgvLpr.Rows(n).Cells(1).Value = r("UID_STR").ToString()
            dgvLpr.Rows(n).Cells(2).Value = r("oCameraID").ToString()
            dgvLpr.Rows(n).Cells(3).Value = r("Thumbnail").ToString

        Next

    End Sub

    Private Sub Lpr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call LoadPlates()
        'timerRefresh.Start()

    End Sub

    Private Sub timerRefresh_Tick(sender As Object, e As EventArgs) Handles timerRefresh.Tick

        'Call LoadPlates()


    End Sub
End Class