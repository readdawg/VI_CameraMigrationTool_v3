Public Class ServiceRestart





    Private Sub Restart_Loader(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set Parent
        MdiParent = LandingPad
        dgvServerList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Call LoadServerList()

    End Sub

    Public SQL As New sqlControl()

    Public Sub LoadServerList() 'Optional Query As String = "")

        Dim Query As String = "SELECT ServerName, IPAddress FROM dbo.Servers"

        SQL.ExecQuery(Query)

        If SQL.HasException(True) Then Exit Sub

        Dim model As String = Nothing

        'Loop Through Each Row and Add To ComboBox
        For Each r As DataRow In SQL.DBDT.Rows
            Dim n As Integer = dgvServerList.Rows.Add()
            dgvServerList.Rows(n).Cells(0).Value = "false"
            dgvServerList.Rows(n).Cells(1).Value = r("ServerName").ToString()
            dgvServerList.Rows(n).Cells(2).Value = r("IPAddress").ToString()

        Next

    End Sub



    Private Sub btn_servStop_Click(sender As Object, e As EventArgs) Handles btn_servStop.Click

        Call StopServer()

    End Sub

    Private Sub btn_servStart_Click(sender As Object, e As EventArgs) Handles btn_servStart.Click

        Call StartService()

    End Sub

    Public Function StopServer()

        Try

            For Each r In dgvServerList.Rows

                If (Boolean.Parse(r.Cells(0).Value.ToString())) Then

                    netIP = r.Cells(2).Value.ToString()
                    netConn = "net use \\" + netIP + " V4in$ight /user:viadmin"
                    netStop = "sc \\" + netIP + " stop VIEntService"

                    Shell("cmd.exe /c " + netConn)
                    Delay(15)
                    Shell("cmd.exe /c " + netStop)
                    Delay(20)

                    MsgBox("Service Stop Complete")

                End If
            Next

        Catch ex As Exception

        End Try

        Return True

    End Function

    Public Function StartService()

        Try

            For Each r In dgvServerList.Rows

                If (Boolean.Parse(r.Cells(0).Value.ToString())) Then

                    netIP = r.Cells(2).Value.ToString()
                    netConn = "net use \\" + netIP + " V4in$ight /user:viadmin"
                    netStart = "sc \\" + netIP + " start VIEntService"

                    Shell("cmd.exe /c " + netConn)
                    Delay(15)
                    Shell("cmd.exe /c " + netStart)
                    Delay(20)
                    MsgBox("Service Start Complete")
                    'Shell("cmd.exe exit")

                    'Dim cmd As String = "cmd.exe"

                    'For Each prog As Process In Process.GetProcesses

                    'If prog.ProcessName = cmd Then
                    'prog.Kill()
                    'End If

                    'Next



                End If
            Next

        Catch ex As Exception

        End Try

        Return True

    End Function

    Private Sub cbAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbAll.CheckedChanged

        If cbAll.Checked = True Then

            Dim i As Integer = 0
            For i = 0 To dgvServerList.RowCount - 1
                dgvServerList.Rows(i).Cells(0).Value = True
            Next

        ElseIf cbAll.Checked = False Then

            Dim i As Integer = 0
            For i = 0 To dgvServerList.RowCount - 1
                dgvServerList.Rows(i).Cells(0).Value = False
            Next

        End If

    End Sub
End Class