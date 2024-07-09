Public Class User
    Public Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call vbConnects()
        Call disAbler(True)
        Call dgvloaders("SELECT * FROM returned")
    End Sub
    Private Sub dgvloaders(ByVal sql As String)
        Dim da As New Odbc.OdbcDataAdapter(sql, cons)
        Dim dt As New DataTable
        da.Fill(dt)
        BandR.dgvbr.DataSource = dt
        da.Dispose()
    End Sub
    Private Sub disAbler(ByVal bool As Boolean)
        btnsub.Enabled = bool
        btnret.Enabled = bool
        btnritem.Enabled = Not bool
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Login.Show()
        Me.Hide()
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnsub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsub.Click
        switchPanel(Borrow)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnret.Click
        Call disAbler(False)
        switchPanel(BandR)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Close()
            Items.Close()
            Login.Show()
            Login.txtuser.Focus()
        End If
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Borrow.txtqnty.Clear()
            Borrow.txtii.Text = ""
            Borrow.txtids.Text = ""
            Borrow.txtname.Clear()
            Call disAbler(True)
            Items.Close()
        End If
    End Sub

    Private Sub btnritem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnritem.Click
        Dim cmd As Odbc.OdbcCommand
        Dim sql As String
        If Val(BandR.dgvbr.Tag) = 0 Then
            MsgBox("Please select a record first!", vbCritical)
        ElseIf MsgBox("Do you want to return this item?", vbYesNo, "Return") = vbYes Then
            sql = "INSERT INTO returnies (item_ID, lastname, iborrow, dborrow, dreturn, bqnty) SELECT item_ID, lastname, iborrow, dborrow, dreturn, bqnty FROM returned WHERE item_ID=" & Val(BandR.dgvbr.Tag)
            cmd = New Odbc.OdbcCommand(sql, cons)
            cmd.ExecuteNonQuery()
            sql = "DELETE FROM returned WHERE item_ID=" & Val(BandR.dgvbr.Tag)
            cmd = New Odbc.OdbcCommand(sql, cons)
            cmd.ExecuteNonQuery()
            Call dgvloaders("SELECT * FROM returned")
            Call disAbler(True)
            Form1.dgvbr.Tag = 0
        End If
    End Sub
End Class
