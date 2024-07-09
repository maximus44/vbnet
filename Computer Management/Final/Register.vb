Public Class Register

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call vbConnects()
        Call dgvloaderss("SELECT * FROM tblinventory")
        Call dgvemerut("SELECT * FROM register")
    End Sub
    Public Sub dgvloaderss(ByVal sql As String)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        da = New Odbc.OdbcDataAdapter(sql, cons)
        da.Fill(dt)
        da.Dispose()
    End Sub
    Public Sub dgvemerut(ByVal sql As String)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        da = New Odbc.OdbcDataAdapter(sql, cons)
        da.Fill(dt)
        da.Dispose()
    End Sub
    Private Sub btnsub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsub.Click
        Dim sql As String
        Dim cmd As Odbc.OdbcCommand
        Call dgvloaderss("SELECT * FROM tblinventory")
        Sql = "INSERT INTO tblinventory(fname,mname,lname,location,contno) VALUES('" & txtfname.Text & "','" & txtmname.Text & "','" & txtlname.Text & "','" & txtloc.Text & "','" & txtconct.Text & "')"
        cmd = New Odbc.OdbcCommand(Sql, cons)
        cmd.ExecuteNonQuery()
        sql = "INSERT INTO register(Username,Password) VALUES('" & txtuname.Text & "','" & txtupass.Text & "')"
        cmd = New Odbc.OdbcCommand(sql, cons)
        cmd.ExecuteNonQuery()
        txtfname.Clear()
        txtmname.Clear()
        txtlname.Clear()
        txtloc.Clear()
        txtconct.Clear()
        txtfname.Focus()
        Call dgvloaderss("SELECT * FROM tblinventory")
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbreg.CheckedChanged
        If cbreg.Checked = False Then
            txtupass.PasswordChar = "*"
            cbreg.Text = "Show"
        Else
            txtupass.PasswordChar = ""
            cbreg.Text = "Hide"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class