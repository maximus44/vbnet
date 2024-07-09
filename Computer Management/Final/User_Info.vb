Public Class User_Info

    Private Sub User_Info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call vbConnects()
        Call dgvloader("SELECT * FROM tblinventory")
    End Sub
    Private Sub dgvloader(ByVal sql As String)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        da = New Odbc.OdbcDataAdapter(sql, cons)
        da.Fill(dt)
        dgvpi.DataSource = dt
        da.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        Dim cmd As Odbc.OdbcCommand
        sql = "TRUNCATE TABLE tblinventory"
        cmd = New Odbc.OdbcCommand(sql, cons)
        cmd.ExecuteNonQuery()
        Call dgvloader("SELECT * FROM tblinventory")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class