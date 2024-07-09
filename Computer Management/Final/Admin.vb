Public Class Admin
    Private Sub Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call vbConnects()
        Call dgvitemss("SELECT * FROM tblitems")
        Call dgbreturn("SELECT * FROM returnies")
        Call disAbler(True)
    End Sub
    Private Sub dgbreturn(ByVal sql As String)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        da = New Odbc.OdbcDataAdapter(sql, cons)
        da.Fill(dt)
        Returned.dgvret.DataSource = dt
        da.Dispose()
    End Sub
    Private Sub disAbler(ByVal bool As Boolean)
        btnadd.Enabled = bool
        btndel.Enabled = bool
        btnedit.Enabled = bool
        dgvitems.Enabled = bool
        btnsave.Enabled = Not bool
        btncan.Enabled = Not bool
        Item_Det.gbdet.Enabled = Not bool
    End Sub
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Returned.Hide()
            User_Info.Hide()
            BandR.Hide()
            Form1.Hide()
            Login.Show()
            Login.txtuser.Focus()
            Me.Close()
        End If
        Me.Close()
    End Sub
    Private Sub dgvitemss(ByVal sql As String)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        da = New Odbc.OdbcDataAdapter(sql, cons)
        da.Fill(dt)
        dgvitems.DataSource = dt
        da.Dispose()
    End Sub
    Private Sub dgvitems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvitems.CellClick
        If e.RowIndex >= 0 Then
            dgvitems.Tag = dgvitems.Item(0, e.RowIndex).Value
            Item_Det.txtiname.Text = dgvitems.Item(1, e.RowIndex).Value
            Item_Det.cbdesk.Text = dgvitems.Item(2, e.RowIndex).Value
            Item_Det.cbava.Text = dgvitems.Item(3, e.RowIndex).Value
            Item_Det.txtqnty.Text = dgvitems.Item(4, e.RowIndex).Value
            MsgBox(dgvitems.Item(1, e.RowIndex).Value)
        End If
    End Sub

    Friend Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim sql As String
        Dim cmd As Odbc.OdbcCommand
        If Val(dgvitems.Tag) = 0 Then
            sql = "INSERT INTO tblitems(itemn,desk,avail,qnty)VALUES('" & Item_Det.txtiname.Text & "','" & Item_Det.cbdesk.Text & "','" & Item_Det.cbava.Text & "','" & Item_Det.txtqnty.Text & "')"
            cmd = New Odbc.OdbcCommand(sql, cons)
            cmd.ExecuteNonQuery()
            Call dgvitemss("SELECT * FROM tblitems")
            Item_Det.txtiname.Clear()
            Item_Det.cbdesk.SelectedIndex = -1
            Item_Det.cbava.SelectedIndex = -1
            Item_Det.txtqnty.Clear()
            Call disAbler(True)
            dgvitems.Tag = 0
        Else
            sql = "UPDATE tblitems set itemn='" & Item_Det.txtiname.Text & "',desk='" & Item_Det.cbdesk.Text & "',avail='" & Item_Det.cbava.Text & "',qnty='" & Item_Det.txtqnty.Text & "' where iiid=" & Val(dgvitems.Tag)
            cmd = New Odbc.OdbcCommand(sql, cons)
            cmd.ExecuteNonQuery()
            Call dgvitemss("SELECT * FROM tblitems")
            Item_Det.txtiname.Clear()
            Item_Det.cbdesk.SelectedIndex = -1
            Item_Det.cbava.SelectedIndex = -1
            Item_Det.txtqnty.Clear()
            Call disAbler(True)
            dgvitems.Tag = 0
        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If Val(dgvitems.Tag) = 0 Then
            Item_Det.Close()
            MsgBox("Please select a record first!", vbCritical)
        Else
            Call disAbler(False)
            Item_Det.Show()
            Item_Det.txtiname.Focus()
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Item_Det.Show()
        Call disAbler(False)
        Item_Det.txtiname.Focus()
        Item_Det.txtiname.Clear()
        Item_Det.cbdesk.SelectedIndex = -1
        Item_Det.cbava.SelectedIndex = -1
        Item_Det.txtqnty.Clear()
        dgvitems.Tag = 0
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        Dim cmd As Odbc.OdbcCommand
        Dim sql As String
        If Val(dgvitems.Tag) = 0 Then
            Item_Det.Close()
            MsgBox("Please select a record first!", vbCritical)
        ElseIf MsgBox("Do you want to delete this record?", vbYesNo) = vbYes Then
            Item_Det.Show()
            sql = "DELETE FROM tblitems WHERE iiid=" & Val(dgvitems.Tag)
            cmd = New Odbc.OdbcCommand(sql, cons)
            cmd.ExecuteNonQuery()
            Item_Det.txtiname.Clear()
            Item_Det.cbdesk.SelectedIndex = -1
            Item_Det.cbava.SelectedIndex = -1
            Item_Det.txtqnty.Clear()
            Call dgvitemss("SELECT * FROM tblitems")
            dgvitems.Tag = 0
        Else
            Item_Det.txtiname.Clear()
            Item_Det.cbdesk.SelectedIndex = -1
            Item_Det.cbava.SelectedIndex = -1
            Item_Det.txtqnty.Clear()
            dgvitems.Tag = 0
        End If
    End Sub

    Private Sub btncan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncan.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Item_Det.txtiname.Clear()
            Item_Det.cbdesk.Text = String.Empty
            Item_Det.cbava.Text = String.Empty
            Item_Det.txtqnty.Clear()
            Call disAbler(True)
            dgvitems.Tag = 0
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        User_Info.Show()
        BandR.Hide()
        Form1.Hide()
        Returned.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BandR.Show()
        User_Info.Hide()
        Form1.Hide()
        Returned.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Show()
        User_Info.Hide()
        BandR.Hide()
        Returned.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Returned.Show()
        User_Info.Hide()
        BandR.Hide()
        Form1.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        User.Show()
        Returned.Hide()
        User_Info.Hide()
        BandR.Hide()
        Form1.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Call dgvitemss("SELECT * FROM tblitems WHERE itemn like '%" & Trim(txtser.Text) & "%'")
        txtser.Clear()
    End Sub

    Private Sub btref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btref.Click
        Call dgvitemss("SELECT * FROM tblitems")
    End Sub
End Class