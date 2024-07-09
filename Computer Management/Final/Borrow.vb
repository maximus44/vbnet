Public Class Borrow
    Private Sub Borrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call dgvloaders("SELECT * FROM returned")
        Call dgvitemss("SELECT * FROM tblitems")
    End Sub

    Private Sub dgvitemss(ByVal sql As String)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        da = New Odbc.OdbcDataAdapter(sql, cons)
        da.Fill(dt)
        da.Dispose()
    End Sub
    Private Sub subt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subt.Click
        Dim sql As String
        Dim cmd As Odbc.OdbcCommand
        Dim ql As Double
        Dim qnty As Double
        Dim rowIndex As Integer = Items.dgvitems.CurrentCell.RowIndex
        If Items.dgvitems.SelectedRows.Count = 0 Then
            MessageBox.Show("invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If rowIndex < 0 OrElse rowIndex >= Items.dgvitems.Rows.Count Then
            MessageBox.Show("Invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not Double.TryParse(Items.dgvitems.Rows(rowIndex).Cells(4).Value.ToString(), ql) Then
            MessageBox.Show("Invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not Double.TryParse(txtqnty.Text, qnty) Then
            MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If qnty > ql Then
            MessageBox.Show("Item Quantity to borrow exceeds available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        sql = "INSERT INTO returned(lastname, iborrow, dborrow, dreturn, bqnty) VALUES('" & txtname.Text & "','" & txtii.Text & "','" & dtpidate.Text & "','" & dtprd.Text & "','" & txtqnty.Text & "')"
        cmd = New Odbc.OdbcCommand(sql, cons)
        cmd.ExecuteNonQuery()
        Dim newQuantityAvailable As Double = ql - qnty
        sql = "UPDATE tblitems SET qnty = '" & newQuantityAvailable & "' where iiid=" & Val(Items.dgvitems.Tag)
        cmd = New Odbc.OdbcCommand(sql, cons)
        cmd.ExecuteNonQuery()
        If rowIndex >= 0 AndAlso rowIndex < Admin.dgvitems.Rows.Count Then
            Admin.dgvitems.Rows(rowIndex).Cells(4).Value = newQuantityAvailable
            Admin.dgvitems.Refresh()
        End If
        If rowIndex >= 0 AndAlso rowIndex < Items.dgvitems.Rows.Count Then
            Items.dgvitems.Rows(rowIndex).Cells(4).Value = newQuantityAvailable
            Items.dgvitems.Refresh()
        End If
        txtqnty.Clear()
        txtii.Text = ""
        txtids.Text = ""
        txtname.Clear()
        MessageBox.Show("Data Submitted!", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Items.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call dgvitemss("SELECT * FROM tblitems")
        Items.Show()
    End Sub

    Private Sub dgvloaders(ByVal sql As String)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        da = New Odbc.OdbcDataAdapter(sql, cons)
        da.Fill(dt)
        da.Dispose()
        Form1.dgvbr.DataSource = dt
        Form1.dgvbr.Refresh()
    End Sub
End Class
