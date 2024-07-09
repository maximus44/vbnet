Public Class Items
    Public Sub Items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call vbConnects()
        Call dgvitemss("SELECT * FROM tblitems")
    End Sub
    Private Sub dgvitemss(ByVal sql As String)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        da = New Odbc.OdbcDataAdapter(sql, cons)
        da.Fill(dt)
        dgvitems.DataSource = dt
        da.Dispose()
    End Sub

    Public Sub dgvitems_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvitems.CellClick
        If e.RowIndex >= 0 Then
            dgvitems.Tag = dgvitems.Item(0, e.RowIndex).Value
            Borrow.txtids.Text = dgvitems.Item(0, e.RowIndex).Value
            Borrow.txtii.Text = dgvitems.Item(1, e.RowIndex).Value
            Me.Hide()
        End If
    End Sub
End Class