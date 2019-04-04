Public Class SQLPanel


    Public SQL As New sqlControl()

    Public Sub LoadSQL(Optional Query As String = "")

        If Query = "" Then
            SQL.ExecQuery("" & sqlQuery.Text & "")

            dgvSql.DataSource = SQL.DBDT

        End If
    End Sub

    Private Sub sqlExecute_Click(sender As Object, e As EventArgs) Handles sqlExecute.Click

        LoadSQL()

    End Sub

    Private Sub sqlClear_Click(sender As Object, e As EventArgs) Handles sqlClear.Click

        sqlQuery.Clear()

    End Sub

End Class