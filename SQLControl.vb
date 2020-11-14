
Imports MySql.Data.MySqlClient


Public Class SQLControl
    Private DBCon As New MySqlConnection("server=localhost;user id=all;password=1234;database=parking")
    Private DBCmd As MySqlCommand
    'DB DATA
    Public DBDA As MySqlDataAdapter
    Public DBDT As DataTable
    'QUERY PARAMETERS
    Public Params As New List(Of MySqlParameter)

    'QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub New()

    End Sub

    'ALLOW CONNECTION STRING OVERRIDE
    Public Sub New(ConnectionString As String)
        DBCon = New MySqlConnection(ConnectionString)
    End Sub
    'EXECUTE QUERY SUB
    Public Sub ExecQuery(Query As String)
        'RESET QUERY
        RecordCount = 0
        Exception = ""

        Try
            DBCon.Open()

            'CREATE DB COMMAND
            DBCmd = New MySqlCommand(Query, DBCon)

            'LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'CLEAR PARAMETERS
            Params.Clear()

            'EXECUTE COMMAND & FILL DATASET
            DBDT = New DataTable
            DBDA = New MySqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)

        Catch ex As Exception
            'CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            'CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()

        End Try
    End Sub


    'ADD PARAMS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New MySqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    'ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function
End Class