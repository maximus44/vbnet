<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item_Det
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
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.gbdet = New System.Windows.Forms.GroupBox()
        Me.txtqnty = New System.Windows.Forms.TextBox()
        Me.cbava = New System.Windows.Forms.ComboBox()
        Me.cbdesk = New System.Windows.Forms.ComboBox()
        Me.txtiname = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel12.SuspendLayout()
        Me.gbdet.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel12.Controls.Add(Me.gbdet)
        Me.Panel12.Location = New System.Drawing.Point(2, 2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(431, 477)
        Me.Panel12.TabIndex = 7
        '
        'gbdet
        '
        Me.gbdet.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbdet.Controls.Add(Me.txtqnty)
        Me.gbdet.Controls.Add(Me.cbava)
        Me.gbdet.Controls.Add(Me.cbdesk)
        Me.gbdet.Controls.Add(Me.txtiname)
        Me.gbdet.Controls.Add(Me.Label15)
        Me.gbdet.Controls.Add(Me.Label14)
        Me.gbdet.Controls.Add(Me.Label13)
        Me.gbdet.Controls.Add(Me.Label12)
        Me.gbdet.Location = New System.Drawing.Point(3, 3)
        Me.gbdet.Name = "gbdet"
        Me.gbdet.Size = New System.Drawing.Size(425, 471)
        Me.gbdet.TabIndex = 0
        Me.gbdet.TabStop = False
        '
        'txtqnty
        '
        Me.txtqnty.Location = New System.Drawing.Point(146, 219)
        Me.txtqnty.Name = "txtqnty"
        Me.txtqnty.Size = New System.Drawing.Size(176, 23)
        Me.txtqnty.TabIndex = 9
        Me.txtqnty.Tag = "*"
        '
        'cbava
        '
        Me.cbava.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbava.FormattingEnabled = True
        Me.cbava.Items.AddRange(New Object() {"Available", "Not Available"})
        Me.cbava.Location = New System.Drawing.Point(146, 161)
        Me.cbava.Name = "cbava"
        Me.cbava.Size = New System.Drawing.Size(176, 25)
        Me.cbava.TabIndex = 8
        '
        'cbdesk
        '
        Me.cbdesk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdesk.FormattingEnabled = True
        Me.cbdesk.Items.AddRange(New Object() {"Working", "Not Working"})
        Me.cbdesk.Location = New System.Drawing.Point(146, 104)
        Me.cbdesk.Name = "cbdesk"
        Me.cbdesk.Size = New System.Drawing.Size(176, 25)
        Me.cbdesk.TabIndex = 7
        '
        'txtiname
        '
        Me.txtiname.Location = New System.Drawing.Point(146, 48)
        Me.txtiname.Name = "txtiname"
        Me.txtiname.Size = New System.Drawing.Size(176, 23)
        Me.txtiname.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 23)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Quantity:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 161)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 23)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Availability:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 23)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Description:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 23)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Item Name:"
        '
        'Item_Det
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 483)
        Me.Controls.Add(Me.Panel12)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Item_Det"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Details"
        Me.Panel12.ResumeLayout(False)
        Me.gbdet.ResumeLayout(False)
        Me.gbdet.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents gbdet As System.Windows.Forms.GroupBox
    Friend WithEvents txtqnty As System.Windows.Forms.TextBox
    Friend WithEvents cbava As System.Windows.Forms.ComboBox
    Friend WithEvents cbdesk As System.Windows.Forms.ComboBox
    Friend WithEvents txtiname As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
