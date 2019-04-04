Imports System.IO

Public Class Bitrate
    Private Sub Bitrate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set Parent
        MdiParent = LandingPad
        LoadGrid()

    End Sub

    Public SQL As New sqlControl()

    Public Sub LoadGrid(Optional Query As String = "")



        If Query = "" Then
            SQL.ExecQuery("SELECT CameraName, IPAddress FROM dbo.Cameras WHERE IPTypeKey Like 'advidiaa%' AND ServerID <> 0;")

        Else

            SQL.ExecQuery(Query)

        End If

        If SQL.HasException(True) Then Exit Sub

        dgvCameras.DataSource = SQL.DBDT

    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click

        'open the openfile dialog so the user can search for a file
        Dim openFileDialog1 As New OpenFileDialog()
        'set the root to the z drive
        openFileDialog1.InitialDirectory = "C:\"
        'make sure the root goes back to where the user started
        'openFileDialog1.RestoreDirectory = True
        'show the dialog
        openFileDialog1.ShowDialog()

        tb_path.Text = openFileDialog1.FileName

    End Sub

    Private Sub btn_changeBitrate_Click(sender As Object, e As EventArgs) Handles btn_changeBitrate.Click

        Dim login As String = tb_Login.Text
        Dim password As String = tb_password.Text
        Dim path As String = tb_path.Text
        Dim ipAddress As String
        Dim camName As String

        Try

            For Each r In dgvCameras.Rows

                ipAddress = r.Cells(1).Value.ToString()
                camName = r.Cells(0).Value.ToString()

                MsgBox("Settings: IP Address: " + ipAddress + ", Camera Name: " + camName)

                Call BitrateChange("http://" + ipAddress + "/Streaming/channels/1", login, password, path)
                MsgBox("Bitrate update complete for camera" + camName + ", rebooting camera")
            Next

        Catch ex As Exception

        End Try

        MsgBox("Firmware Update Complete")

    End Sub

    Public Shared Function BitrateChange(ByVal Url As String, ByVal Username As String, ByVal Password As String, ByVal Path As String) As Boolean

        Dim bRet As Boolean = True
        Dim WebStream As IO.Stream = Nothing
        Dim WebReq As Net.HttpWebRequest = Nothing


        Try

            'create request object
            WebReq = CType(Net.WebRequest.Create(Url), Net.HttpWebRequest)

            'set the username and password
            Dim UserPass As New Net.NetworkCredential(Username, Password)
            WebReq.Credentials = UserPass

            'set method
            WebReq.Method = "PUT"

            'disable expect-100-continue
            WebReq.ServicePoint.Expect100Continue = False

            'get the content array
            Dim ContentArr As Byte() = File.ReadAllBytes(Path)

            'set the content length
            WebReq.ContentLength = ContentArr.Length

            'get the stream
            WebStream = WebReq.GetRequestStream

            'write the content
            WebStream.Write(ContentArr, 0, ContentArr.Length)

            'get the response
            Dim WebResp As Net.HttpWebResponse = CType(WebReq.GetResponse(), Net.HttpWebResponse)

            'verify the response
            If Not WebResp.StatusCode = 7 Then


            End If

        Catch ex As Exception
            bRet = False
        Finally

            'close the stream
            If WebStream IsNot Nothing Then

                Try
                    WebStream.Close()
                Catch ex As Exception
                End Try

                WebStream = Nothing

            End If

            'close the request
            If WebReq IsNot Nothing Then

                Try
                    WebReq.Abort()
                Catch ex As Exception
                End Try

                WebReq = Nothing

            End If

        End Try

        Return bRet

    End Function

    Public Shared Function Reboot(ByVal Url As String, ByVal Username As String, ByVal Password As String) As Boolean

        Dim bRet As Boolean = True
        Dim WebStream As IO.Stream = Nothing
        Dim WebReq As Net.HttpWebRequest = Nothing

        Try

            'create request object
            WebReq = CType(Net.WebRequest.Create(Url), Net.HttpWebRequest)

            'set the username and password
            Dim UserPass As New Net.NetworkCredential(Username, Password)
            WebReq.Credentials = UserPass

            'set method
            WebReq.Method = "PUT"

            'disable expect-100-continue
            WebReq.ServicePoint.Expect100Continue = False

            'get the stream
            WebStream = WebReq.GetRequestStream

            'get the response
            Dim WebResp As Net.HttpWebResponse = CType(WebReq.GetResponse(), Net.HttpWebResponse)

            'verify the response
            If Not WebResp.StatusCode = 1 Then
                'MsgBox("Reboot Sent")

            End If

        Catch ex As Exception
            bRet = False
        Finally

            'close the stream
            If WebStream IsNot Nothing Then

                Try
                    WebStream.Close()
                Catch ex As Exception
                End Try

                WebStream = Nothing

            End If

            'close the request
            If WebReq IsNot Nothing Then

                Try
                    WebReq.Abort()
                Catch ex As Exception
                End Try

                WebReq = Nothing

            End If

        End Try

        Return bRet

    End Function

End Class