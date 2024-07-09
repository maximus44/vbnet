Imports System.Data.Odbc
Public Class Login
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call registerr("SELECT * FROM register")
    End Sub

    Private Sub registerr(ByVal sql As String)
        Dim da As OdbcDataAdapter
        Dim dt As New DataTable
        Using connection As New OdbcConnection("dsn=yuki")
            da = New OdbcDataAdapter(sql, connection)
            da.Fill(dt)
        End Using
        da.Dispose()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If (txtuser.Text = "") Then
            Dim result As DialogResult = MessageBox.Show("Enter the username", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtuser.Focus()
            txtuser.Clear()
            Exit Sub
        End If
        If (txtpass.Text = "") Then
            Dim result As DialogResult = MessageBox.Show("Enter the password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpass.Focus()
            txtpass.Clear()
            Exit Sub
        End If
        If txtuser.Text = "admin" AndAlso txtpass.Text = "password" Then
            txtpass.Clear()
            txtuser.Clear()
            Admin.Show()
            Me.Hide()
            Exit Sub
        End If
        Dim username As String = txtuser.Text
        Dim password As String = txtpass.Text
        Dim query As String = "SELECT * FROM register WHERE Username = ? AND Password = ?"
        Using connection As New OdbcConnection("dsn=yuki")
            Using command As New OdbcCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)
                connection.Open()
                Dim reader As OdbcDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Dim result As DialogResult = MessageBox.Show("Login successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpass.Clear()
                    txtuser.Clear()
                    User.Show()
                    Me.Hide()
                Else
                    Dim result As DialogResult = MessageBox.Show("Invalid username or password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpass.Clear()
                    txtuser.Clear()
                    txtuser.Focus()
                End If
            End Using
        End Using
    End Sub
    Private Sub cbshow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbshow.CheckedChanged
        If cbshow.Checked = False Then
            txtpass.PasswordChar = "*"
        Else
            txtpass.PasswordChar = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Register.Show()
        Me.Hide()
    End Sub

End Class
