<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmviewuser))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.fullname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.usertype = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.picture = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lbluser = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblpass = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblstatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblstatus)
        Me.Panel1.Controls.Add(Me.Guna2Button2)
        Me.Panel1.Controls.Add(Me.lblpass)
        Me.Panel1.Controls.Add(Me.lbluser)
        Me.Panel1.Controls.Add(Me.usertype)
        Me.Panel1.Controls.Add(Me.picture)
        Me.Panel1.Controls.Add(Me.fullname)
        Me.Panel1.Location = New System.Drawing.Point(6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 408)
        Me.Panel1.TabIndex = 0
        '
        'fullname
        '
        Me.fullname.BackColor = System.Drawing.Color.Transparent
        Me.fullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname.ForeColor = System.Drawing.Color.DimGray
        Me.fullname.Location = New System.Drawing.Point(21, 92)
        Me.fullname.Name = "fullname"
        Me.fullname.Size = New System.Drawing.Size(81, 24)
        Me.fullname.TabIndex = 0
        Me.fullname.Text = "Full name"
        '
        'usertype
        '
        Me.usertype.BackColor = System.Drawing.Color.Transparent
        Me.usertype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertype.ForeColor = System.Drawing.Color.DimGray
        Me.usertype.Location = New System.Drawing.Point(20, 148)
        Me.usertype.Name = "usertype"
        Me.usertype.Size = New System.Drawing.Size(87, 24)
        Me.usertype.TabIndex = 2
        Me.usertype.Text = "User Type"
        '
        'picture
        '
        Me.picture.BackColor = System.Drawing.Color.White
        Me.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picture.Image = CType(resources.GetObject("picture.Image"), System.Drawing.Image)
        Me.picture.ImageRotate = 0.0!
        Me.picture.Location = New System.Drawing.Point(356, 136)
        Me.picture.Name = "picture"
        Me.picture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.picture.Size = New System.Drawing.Size(176, 163)
        Me.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture.TabIndex = 1
        Me.picture.TabStop = False
        '
        'lbluser
        '
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.DimGray
        Me.lbluser.Location = New System.Drawing.Point(20, 203)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(85, 24)
        Me.lbluser.TabIndex = 3
        Me.lbluser.Text = "Username"
        '
        'lblpass
        '
        Me.lblpass.BackColor = System.Drawing.Color.Transparent
        Me.lblpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.ForeColor = System.Drawing.Color.DimGray
        Me.lblpass.Location = New System.Drawing.Point(20, 259)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(82, 24)
        Me.lblpass.TabIndex = 4
        Me.lblpass.Text = "Password"
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
        Me.Guna2Button2.Location = New System.Drawing.Point(506, 0)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(66, 13)
        Me.Guna2Button2.TabIndex = 75
        '
        'lblstatus
        '
        Me.lblstatus.BackColor = System.Drawing.Color.Transparent
        Me.lblstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.DimGray
        Me.lblstatus.Location = New System.Drawing.Point(21, 321)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(54, 24)
        Me.lblstatus.TabIndex = 76
        Me.lblstatus.Text = "Status"
        '
        'frmviewuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(578, 406)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmviewuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmviewuser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents usertype As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents picture As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents fullname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblpass As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbluser As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblstatus As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
