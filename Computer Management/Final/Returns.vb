Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Borrow.txtname.Text = dgvbr.Item(1, e.RowIndex).Value
            Borrow.txtii.Text = dgvbr.Item(2, e.RowIndex).Value
            Borrow.dtpidate.Text = dgvbr.Item(3, e.RowIndex).Value
            Borrow.dtprd.Text = dgvbr.Item(4, e.RowIndex).Value
            Borrow.txtqnty.Text = dgvbr.Item(5, e.RowIndex).Value
            MsgBox(dgvbr.Item(1, e.RowIndex).Value)
        End If
    End Sub


End Class