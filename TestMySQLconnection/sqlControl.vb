Imports System.Data.SqlClient


Public Class sqlControl

    'Create connection
    Private DBCon As New SqlConnection(DataConnection)

    'Database command
    Private DBCmd As SqlCommand

    'Data storage
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    'Query params
    Public Params As New List(Of SqlParameter)

    'Query Stats
    Public RecordCount As Integer
    Public Exception As String

    Public Sub New()

    End Sub

    ' Allow Connection Override
    Public Sub New(ConnectionString As String)

        DBCon = New SqlConnection(ConnectionString)

    End Sub

    'SQL Execution
    Public Sub ExecQuery(Query As String)

        'Reset Query Stats
        RecordCount = 0
        Exception = ""

        Try

            'Open Connection
            DBCon.Open()

            'DB Command
            DBCmd = New SqlCommand(Query, DBCon)

            'Load DB params into DB Command
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Clear Params List
            Params.Clear()

            'Execute SQL Command
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)

        Catch ex As Exception

            'Capture Errors
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message

        Finally

            'Close Connection
            If DBCon.State = ConnectionState.Open Then DBCon.Close()

        End Try

    End Sub

    'Sub for Adding Params
    Public Sub AddParams(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)

    End Sub

    'Error Checking
    Public Function HasException(Optional Report As Boolean = False) As Boolean

        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception: ")
        Return True

    End Function

End Class
