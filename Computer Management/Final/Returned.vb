Public Class Returned

    Private Sub Returned_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call vbConnects()
        Call dgbreturn("SELECT * FROM returnies")
    End Sub

    Private Sub dgbreturn(ByVal sql As String)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        da = New Odbc.OdbcDataAdapter(sql, cons)
        da.Fill(dt)
        dgvret.DataSource = dt
        da.Dispose()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Dim sql As String
        Dim cmd As Odbc.OdbcCommand
        sql = "TRUNCATE TABLE returnies"
        cmd = New Odbc.OdbcCommand(sql, cons)
        cmd.ExecuteNonQuery()
        Call dgbreturn("SELECT * FROM returnies")
    End Sub

    Private Sub bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bclose.Click
        Me.Hide()
    End Sub
End Class
