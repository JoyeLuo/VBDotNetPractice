Public Module TestDbSession
    Public Function GetConnection(ByRef connString As String) As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection(connString)
    End Function

    Public Function GetDataSet(ByRef oleDbConnection As OleDb.OleDbConnection, ByRef sql As String) As DataSet
        Try
            If oleDbConnection.State = ConnectionState.Closed Then oleDbConnection.Open()

            Dim dataSet As New DataSet
            Dim dataAdapter As New OleDb.OleDbDataAdapter(sql, oleDbConnection)

            dataAdapter.Fill(dataSet)
            dataAdapter.Dispose()

            Return dataSet

        Catch ex As SystemException
            MsgBox(ex.ToString)
        Finally
            If oleDbConnection IsNot Nothing And oleDbConnection.State = ConnectionState.Open Then
                oleDbConnection.Close()
            End If
        End Try

        Return Nothing
    End Function

    Public Function GetDataTable(ByRef oleDbConnection As OleDb.OleDbConnection, ByRef sql As String) As DataTable
        Try
            If oleDbConnection.State = ConnectionState.Closed Then oleDbConnection.Open()

            Dim dataSet As New DataSet
            Dim dataAdapter As New OleDb.OleDbDataAdapter(sql, oleDbConnection)
            Dim dataTable As DataTable

            dataAdapter.Fill(dataSet)
            dataTable = dataSet.Tables(0)

            dataAdapter.Dispose()

            Return dataTable

        Catch ex As SystemException
            MsgBox(ex.ToString)
        Finally
            If oleDbConnection IsNot Nothing And oleDbConnection.State = ConnectionState.Open Then
                oleDbConnection.Close()
            End If
        End Try

        Return Nothing
    End Function

    Public Function ExecuteQuery(ByRef oleDbConnection As OleDb.OleDbConnection, ByRef sql As String) As Boolean
        Try
            If oleDbConnection.State = ConnectionState.Closed Then oleDbConnection.Open()

            Dim oleDbCommand As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, oleDbConnection)

            oleDbCommand.ExecuteNonQuery()
            oleDbCommand.Dispose()

            Return True

        Catch ex As SystemException
            MsgBox(ex.ToString)
        Finally
            If oleDbConnection IsNot Nothing And oleDbConnection.State = ConnectionState.Open Then
                oleDbConnection.Close()
            End If
        End Try

        Return False
    End Function

End Module
