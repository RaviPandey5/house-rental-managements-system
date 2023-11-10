Imports System.Data.OleDb

Module connect
    Public Function strconnection() As OleDbConnection
        Return New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\rent.mdb")
        '"Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\hyara\Documents\rent.mdb"
    End Function
    Public strcon As OleDbConnection = strconnection()
    Public result As String
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public dt As New DataTable


    Public Sub relode(ByVal sql As String, ByVal DTG As Object)
        Try
            strcon.Open()
            dt = New DataTable
            With cmd
                .Connection = strcon
                .CommandText = sql

            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()

        End Try

    End Sub



End Module
