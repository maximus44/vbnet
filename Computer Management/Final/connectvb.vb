Module connectvb
    Public cons As Odbc.OdbcConnection
    Public Sub vbConnects()
        Try
            cons = New Odbc.OdbcConnection("dsn=yuki")
            cons.Open()
        Catch ex As Exception
        End Try
    End Sub
End Module
