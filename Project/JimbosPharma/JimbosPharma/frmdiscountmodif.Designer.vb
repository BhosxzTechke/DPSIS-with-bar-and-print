<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdiscountmodif
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
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdiscount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtdesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnsave = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnupdate = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Red
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(490, -2)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(47, 15)
        Me.Guna2Button2.TabIndex = 83
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.lblid)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.txtdiscount)
        Me.Guna2Panel1.Controls.Add(Me.txtdesc)
        Me.Guna2Panel1.Controls.Add(Me.btnsave)
        Me.Guna2Panel1.Controls.Add(Me.btnupdate)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-1, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(538, 267)
        Me.Guna2Panel1.TabIndex = 84
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(464, 17)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(33, 17)
        Me.lblid.TabIndex = 85
        Me.lblid.Text = "lblid"
        Me.lblid.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(207, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 32)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Desciption"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(207, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 32)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Discount"
        '
        'txtdiscount
        '
        Me.txtdiscount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdiscount.DefaultText = ""
        Me.txtdiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdiscount.Location = New System.Drawing.Point(20, 154)
        Me.txtdiscount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdiscount.PlaceholderText = ""
        Me.txtdiscount.SelectedText = ""
        Me.txtdiscount.Size = New System.Drawing.Size(495, 52)
        Me.txtdiscount.TabIndex = 82
        '
        'txtdesc
        '
        Me.txtdesc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdesc.DefaultText = ""
        Me.txtdesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdesc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdesc.Location = New System.Drawing.Point(20, 53)
        Me.txtdesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdesc.PlaceholderText = ""
        Me.txtdesc.SelectedText = ""
        Me.txtdesc.Size = New System.Drawing.Size(495, 42)
        Me.txtdesc.TabIndex = 81
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.BorderRadius = 2
        Me.btnsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsave.FillColor = System.Drawing.Color.DarkSlateGray
        Me.btnsave.FillColor2 = System.Drawing.Color.DarkSlateGray
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnsave.Location = New System.Drawing.Point(396, 229)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(142, 38)
        Me.btnsave.TabIndex = 79
        Me.btnsave.Text = "SAVE"
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.BorderRadius = 2
        Me.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnupdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnupdate.FillColor = System.Drawing.Color.DarkSlateGray
        Me.btnupdate.FillColor2 = System.Drawing.Color.DarkSlateGray
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnupdate.Location = New System.Drawing.Point(396, 229)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(142, 38)
        Me.btnupdate.TabIndex = 80
        Me.btnupdate.Text = "UPDATE"
        '
        'frmdiscountmodif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(537, 281)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmdiscountmodif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmdiscountmodif"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtdiscount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtdesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
End Class
