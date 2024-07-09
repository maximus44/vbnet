Public Class BandR

    Private Sub BandR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call vbConnects()
        Call dgvloaders("SELECT * FROM returned")
    End Sub
    Private Sub dgvloaders(ByVal sql As String)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        da = New Odbc.OdbcDataAdapter(sql, cons)
        da.Fill(dt)
        dgvbr.DataSource = dt
        da.Dispose()
    End Sub

    Private Sub dgvbr_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbr.CellClick
        If e.RowIndex >= 0 Then
            dgvbr.Tag = dgvbr.Item(0, e.RowIndex).Value
            MsgBox(dgvbr.Tag)
        End If
    End Sub

    Private Sub bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bclose.Click
        Me.Hide()
    End Sub
End Class