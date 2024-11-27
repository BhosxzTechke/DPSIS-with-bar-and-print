<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmqty
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
        Me.txtqty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPid = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
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
        Me.txtqty.Location = New System.Drawing.Point(8, 5)
        Me.txtqty.Margin = New System.Windows.Forms.Padding(8, 11, 8, 11)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtqty.PlaceholderText = ""
        Me.txtqty.SelectedText = ""
        Me.txtqty.Size = New System.Drawing.Size(288, 175)
        Me.txtqty.TabIndex = 0
        Me.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPid
        '
        Me.lblPid.AutoSize = True
        Me.lblPid.BackColor = System.Drawing.Color.FloralWhite
        Me.lblPid.Location = New System.Drawing.Point(26, 85)
        Me.lblPid.Name = "lblPid"
        Me.lblPid.Size = New System.Drawing.Size(41, 17)
        Me.lblPid.TabIndex = 1
        Me.lblPid.Text = "lblpid"
        Me.lblPid.Visible = False
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.BackColor = System.Drawing.Color.OldLace
        Me.lblprice.Location = New System.Drawing.Point(26, 113)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(53, 17)
        Me.lblprice.TabIndex = 2
        Me.lblprice.Text = "lblprice"
        Me.lblprice.Visible = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(29, 39)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(51, 17)
        Me.lblname.TabIndex = 3
        Me.lblname.Text = "Label1"
        Me.lblname.Visible = False
        '
        'frmqty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Olive
        Me.ClientSize = New System.Drawing.Size(301, 188)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.lblPid)
        Me.Controls.Add(Me.txtqty)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmqty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmqty"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents txtqty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPid As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
End Class
