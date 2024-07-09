<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BandR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.bclose = New System.Windows.Forms.Button()
        Me.dgvbr = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvbr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.Controls.Add(Me.bclose)
        Me.Panel6.Controls.Add(Me.dgvbr)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(668, 464)
        Me.Panel6.TabIndex = 2
        '
        'bclose
        '
        Me.bclose.FlatAppearance.BorderSize = 0
        Me.bclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bclose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bclose.Location = New System.Drawing.Point(527, 429)
        Me.bclose.Name = "bclose"
        Me.bclose.Size = New System.Drawing.Size(123, 33)
        Me.bclose.TabIndex = 5
        Me.bclose.Text = "Close"
        Me.bclose.UseVisualStyleBackColor = True
        '
        'dgvbr
        '
        Me.dgvbr.AllowUserToAddRows = False
        Me.dgvbr.AllowUserToDeleteRows = False
        Me.dgvbr.AllowUserToResizeColumns = False
        Me.dgvbr.AllowUserToResizeRows = False
        Me.dgvbr.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvbr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column9, Me.Column1, Me.Column2, Me.Column3, Me.Column17})
        Me.dgvbr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvbr.Location = New System.Drawing.Point(0, 0)
        Me.dgvbr.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvbr.Name = "dgvbr"
        Me.dgvbr.ReadOnly = True
        Me.dgvbr.RowHeadersVisible = False
        Me.dgvbr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvbr.Size = New System.Drawing.Size(668, 464)
        Me.dgvbr.TabIndex = 0
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "item_ID"
        Me.Column4.HeaderText = "ID"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.DataPropertyName = "iborrow"
        Me.Column9.HeaderText = "Item Borrowed"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "lastname"
        Me.Column1.HeaderText = "Last Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "dborrow"
        Me.Column2.HeaderText = "Date Borrowed"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "dreturn"
        Me.Column3.HeaderText = "Due Return"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column17
        '
        Me.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column17.DataPropertyName = "bqnty"
        Me.Column17.HeaderText = "Quantity"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        '
        'BandR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 464)
        Me.Controls.Add(Me.Panel6)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BandR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrows"
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgvbr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents dgvbr As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bclose As System.Windows.Forms.Button
End Class
