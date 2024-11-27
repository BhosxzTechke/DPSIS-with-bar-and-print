<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginform))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtuser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 13
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.BorderRadius = 13
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(113, 245)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(431, 45)
        Me.Guna2GradientButton1.TabIndex = 8
        Me.Guna2GradientButton1.Text = " LOGIN"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2GradientButton2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2GradientButton1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtuser)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtpass)
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(-2, -1)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(635, 380)
        Me.Guna2CustomGradientPanel1.TabIndex = 9
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(-5, -2)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(648, 10)
        Me.Guna2CustomGradientPanel2.TabIndex = 24
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Navy
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(126, 50)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(418, 40)
        Me.Guna2HtmlLabel1.TabIndex = 22
        Me.Guna2HtmlLabel1.Text = "Doc Care's Pharmacy"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.JimbosPharma.My.Resources.Resources.eye
        Me.PictureBox1.Location = New System.Drawing.Point(553, 198)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton2.BorderRadius = 13
        Me.Guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2GradientButton2.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(113, 296)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(431, 45)
        Me.Guna2GradientButton2.TabIndex = 19
        Me.Guna2GradientButton2.Text = "Exit"
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.Transparent
        Me.txtuser.BorderColor = System.Drawing.Color.Transparent
        Me.txtuser.BorderRadius = 10
        Me.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtuser.DefaultText = ""
        Me.txtuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuser.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtuser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtuser.ForeColor = System.Drawing.Color.Black
        Me.txtuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtuser.IconLeft = CType(resources.GetObject("txtuser.IconLeft"), System.Drawing.Image)
        Me.txtuser.Location = New System.Drawing.Point(113, 141)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtuser.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtuser.PlaceholderText = "Enter your Username"
        Me.txtuser.SelectedText = ""
        Me.txtuser.Size = New System.Drawing.Size(431, 40)
        Me.txtuser.TabIndex = 0
        Me.txtuser.WordWrap = False
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.Transparent
        Me.txtpass.BorderColor = System.Drawing.Color.Transparent
        Me.txtpass.BorderRadius = 10
        Me.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpass.DefaultText = ""
        Me.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpass.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpass.ForeColor = System.Drawing.Color.Black
        Me.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpass.IconLeft = CType(resources.GetObject("txtpass.IconLeft"), System.Drawing.Image)
        Me.txtpass.Location = New System.Drawing.Point(113, 198)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtpass.PlaceholderText = "Enter your Password"
        Me.txtpass.SelectedText = ""
        Me.txtpass.Size = New System.Drawing.Size(431, 40)
        Me.txtpass.TabIndex = 7
        Me.txtpass.WordWrap = False
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "loginform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".........."
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtuser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
End Class
