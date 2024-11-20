<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproddelivery
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.txtqty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPid = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblPid)
        Me.Panel1.Controls.Add(Me.txtqty)
        Me.Panel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(681, 431)
        Me.Panel1.TabIndex = 0
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.ImageRotate = 0.0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(207, 15)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(227, 204)
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'txtqty
        '
        Me.txtqty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtqty.DefaultText = "1"
        Me.txtqty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtqty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtqty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqty.Font = New System.Drawing.Font("MS Reference Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.ForeColor = System.Drawing.Color.Black
        Me.txtqty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqty.Location = New System.Drawing.Point(180, 245)
        Me.txtqty.Margin = New System.Windows.Forms.Padding(8, 11, 8, 11)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtqty.PlaceholderText = ""
        Me.txtqty.SelectedText = ""
        Me.txtqty.Size = New System.Drawing.Size(288, 175)
        Me.txtqty.TabIndex = 8
        Me.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPid
        '
        Me.lblPid.AutoSize = True
        Me.lblPid.BackColor = System.Drawing.Color.FloralWhite
        Me.lblPid.Location = New System.Drawing.Point(12, 15)
        Me.lblPid.Name = "lblPid"
        Me.lblPid.Size = New System.Drawing.Size(41, 17)
        Me.lblPid.TabIndex = 9
        Me.lblPid.Text = "lblpid"
        Me.lblPid.Visible = False
        '
        'frmproddelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 443)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmproddelivery"
        Me.Text = "frmproddelivery"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents txtqty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPid As System.Windows.Forms.Label
End Class
