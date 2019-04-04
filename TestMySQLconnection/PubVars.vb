Module PubVars

    'Public Vairables

    'Data  conncection string
    Public Instance As String = My.Settings.instance
    Public UserName As String = My.Settings.userName
    Public Password As String = My.Settings.password
    Public Database As String = My.Settings.database
    Public DataConnection As String

    'Service Restart Variables
    Public netIP As String
    Public netConn As String
    Public netStop As String
    Public netStart As String

    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop

    End Sub

End Module
