Imports MySql.Data.MySqlClient

Module Module2
    Public conn As New MySqlConnection
    Public trans As MySqlTransaction
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As New DataSet
    Public cmd As New MySqlCommand
    Public id As Integer
    Public database As Integer = 1
    Public flag As Boolean
    Public discount As Integer = 0
    Public penalty As Integer = 0
    Public slot As String
    Public total As String
    Public summ As Integer
    Public STID As String
    Public cid As String
    Public tid As String
    Public prices As String
    Public diss As String
    Public penn As String
    Public finalprice As Integer
    Public Mode As String = "New"
    Public hhr As Integer = 0
    Public uid As Integer = 0
    Public wagwag As Integer = 0
    Public stat As Integer = 0
    Public tag As String = ""


    '5250489



    Public Sub connect(ByVal database As String)

        conn.Close()
        conn.ConnectionString = "server=localhost;user id=all;password=1234;database=parking"
        Try
            conn.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Function MD5(ByRef upass As String) As String

        Dim MD5Service As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim Bytes() As Byte = MD5Service.ComputeHash(System.Text.Encoding.ASCII.GetBytes(upass))
        Dim sss As String
        For Each By As Byte In Bytes

#Disable Warning BC42104 ' Variable is used before it has been assigned a value
            sss += By.ToString("x2")
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
        Next
        Return sss
    End Function

    Public Function sqlquery(ByVal qry As String)
        connect(database)

        Try

            cmd.CommandText = qry
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            dr = cmd.ExecuteReader


        Catch ex As Exception
            If ex.Message.ToString.Substring(0, 6) = "DELETE" Or ex.Message.ToString.Substring(0, 6) = "INSERT" Or ex.Message.ToString.Substring(0, 6) = "UPDATE" Then
                MsgBox("Permission Denied", MsgBoxStyle.Exclamation, "Parking System")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Parking System")

            End If
        End Try

        Return dr

        conn.Close()

    End Function

    Public Function sqltransaction(ByVal qry As String)

        Try

            cmd.CommandText = qry
            cmd.CommandType = CommandType.Text
            cmd.Transaction = trans
            dr = cmd.ExecuteReader

        Catch ex As Exception

            flag = False

            If ex.Message.ToString.Substring(0, 6) = "DELETE" Or ex.Message.ToString.Substring(0, 6) = "INSERT" Or ex.Message.ToString.Substring(0, 6) = "UPDATE" Then
                MsgBox("Permission Denied", MsgBoxStyle.Exclamation, "Parking System")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Parking System")

            End If
        End Try

        Return dr

    End Function

    Public Function bl(ByVal txt As String)
        Dim flag As Boolean

        If txt = "" Then
            flag = True
        Else
            flag = False

        End If

        Return flag
    End Function



End Module
