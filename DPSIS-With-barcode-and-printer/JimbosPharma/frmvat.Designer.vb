<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvat
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
        Me.savebtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtvat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.Transparent
        Me.savebtn.BorderRadius = 2
        Me.savebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.savebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.savebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.savebtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.savebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.savebtn.FillColor = System.Drawing.Color.DarkSlateGray
        Me.savebtn.FillColor2 = System.Drawing.Color.DarkSlateGray
        Me.savebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.savebtn.ForeColor = System.Drawing.Color.White
        Me.savebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.savebtn.Location = New System.Drawing.Point(270, 181)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(180, 41)
        Me.savebtn.TabIndex = 66
        Me.savebtn.Text = "SAVE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 46)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "VAT"
        '
        'txtvat
        '
        Me.txtvat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtvat.DefaultText = ""
        Me.txtvat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtvat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtvat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtvat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtvat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtvat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtvat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtvat.Location = New System.Drawing.Point(139, 63)
        Me.txtvat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtvat.Name = "txtvat"
        Me.txtvat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvat.PlaceholderText = ""
        Me.txtvat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtvat.SelectedText = ""
        Me.txtvat.Size = New System.Drawing.Size(278, 61)
        Me.txtvat.TabIndex = 67
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtvat)
        Me.Panel1.Controls.Add(Me.savebtn)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(-1, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 222)
        Me.Panel1.TabIndex = 70
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
        Me.Guna2Button2.Location = New System.Drawing.Point(402, -1)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(47, 13)
        Me.Guna2Button2.TabIndex = 75
        '
        'frmvat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(450, 233)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmvat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmvat"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents savebtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtvat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
