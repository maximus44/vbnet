<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrow
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
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtqnty = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtprd = New System.Windows.Forms.DateTimePicker()
        Me.dtpidate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.subt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtii = New System.Windows.Forms.Label()
        Me.txtids = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 163)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 23)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Item ID:"
        '
        'txtqnty
        '
        Me.txtqnty.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqnty.Location = New System.Drawing.Point(180, 249)
        Me.txtqnty.Name = "txtqnty"
        Me.txtqnty.Size = New System.Drawing.Size(275, 27)
        Me.txtqnty.TabIndex = 37
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(461, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 26)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "View"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(28, 247)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(140, 23)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Item Quantity:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(28, 205)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 23)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Item Name:"
        '
        'dtprd
        '
        Me.dtprd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtprd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtprd.Location = New System.Drawing.Point(180, 118)
        Me.dtprd.Name = "dtprd"
        Me.dtprd.Size = New System.Drawing.Size(275, 27)
        Me.dtprd.TabIndex = 33
        '
        'dtpidate
        '
        Me.dtpidate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpidate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpidate.Location = New System.Drawing.Point(180, 75)
        Me.dtpidate.Name = "dtpidate"
        Me.dtpidate.Size = New System.Drawing.Size(275, 27)
        Me.dtpidate.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(28, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 23)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Return Date:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(28, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 23)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Issue Date:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 23)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Borrow"
        '
        'subt
        '
        Me.subt.BackColor = System.Drawing.SystemColors.Control
        Me.subt.FlatAppearance.BorderSize = 0
        Me.subt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subt.Location = New System.Drawing.Point(454, 348)
        Me.subt.Name = "subt"
        Me.subt.Size = New System.Drawing.Size(82, 32)
        Me.subt.TabIndex = 40
        Me.subt.Text = "Submit"
        Me.subt.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Name:"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(180, 288)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(275, 27)
        Me.txtname.TabIndex = 42
        '
        'txtii
        '
        Me.txtii.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtii.Location = New System.Drawing.Point(180, 207)
        Me.txtii.Name = "txtii"
        Me.txtii.Size = New System.Drawing.Size(275, 27)
        Me.txtii.TabIndex = 43
        Me.txtii.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtids
        '
        Me.txtids.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtids.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtids.Location = New System.Drawing.Point(180, 164)
        Me.txtids.Name = "txtids"
        Me.txtids.Size = New System.Drawing.Size(275, 27)
        Me.txtids.TabIndex = 44
        Me.txtids.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 429)
        Me.Controls.Add(Me.txtids)
        Me.Controls.Add(Me.txtii)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.subt)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtqnty)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtprd)
        Me.Controls.Add(Me.dtpidate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Borrow"
        Me.Text = "Borrow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtqnty As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtprd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpidate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents subt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtii As System.Windows.Forms.Label
    Friend WithEvents txtids As System.Windows.Forms.Label
End Class
