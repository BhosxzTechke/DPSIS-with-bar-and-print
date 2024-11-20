<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cashier
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cashier))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbldisplaytot = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbldue = New System.Windows.Forms.Label()
        Me.lbldics = New System.Windows.Forms.Label()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.labelll = New System.Windows.Forms.Label()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblvat = New System.Windows.Forms.Label()
        Me.txtsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblinvoice = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelKey = New System.Windows.Forms.Panel()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnpass = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btndaily = New System.Windows.Forms.Button()
        Me.btnset = New System.Windows.Forms.Button()
        Me.btndiscountan = New System.Windows.Forms.Button()
        Me.btbprodinqu = New System.Windows.Forms.Button()
        Me.btnnewing = New System.Windows.Forms.Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelKey.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbldisplaytot)
        Me.Panel2.Location = New System.Drawing.Point(1128, 254)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(337, 94)
        Me.Panel2.TabIndex = 4
        '
        'lbldisplaytot
        '
        Me.lbldisplaytot.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisplaytot.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbldisplaytot.Location = New System.Drawing.Point(100, 1)
        Me.lbldisplaytot.Name = "lbldisplaytot"
        Me.lbldisplaytot.Size = New System.Drawing.Size(113, 23)
        Me.lbldisplaytot.TabIndex = 5
        Me.lbldisplaytot.Text = "0.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbldisplaytot.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1130, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 67)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sub - Total"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1130, 566)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 67)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Dics. (Less)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1130, 498)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(338, 67)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total Due"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Teal
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1131, 636)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(338, 75)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "VATable"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltime
        '
        Me.lbltime.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbltime.BackColor = System.Drawing.Color.Teal
        Me.lbltime.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.lbltime.Location = New System.Drawing.Point(7, 80)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(337, 79)
        Me.lbltime.TabIndex = 13
        Me.lbltime.Text = "00:00:00"
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldate
        '
        Me.lbldate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbldate.BackColor = System.Drawing.Color.Teal
        Me.lbldate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.lbldate.Location = New System.Drawing.Point(7, 53)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(337, 27)
        Me.lbldate.TabIndex = 14
        Me.lbldate.Text = "Today Is"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbldue
        '
        Me.lbldue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldue.BackColor = System.Drawing.Color.Teal
        Me.lbldue.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldue.ForeColor = System.Drawing.Color.Black
        Me.lbldue.Location = New System.Drawing.Point(1337, 514)
        Me.lbldue.Name = "lbldue"
        Me.lbldue.Size = New System.Drawing.Size(131, 35)
        Me.lbldue.TabIndex = 15
        Me.lbldue.Text = "0.00"
        Me.lbldue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldics
        '
        Me.lbldics.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldics.BackColor = System.Drawing.Color.Teal
        Me.lbldics.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldics.ForeColor = System.Drawing.Color.Black
        Me.lbldics.Location = New System.Drawing.Point(1337, 580)
        Me.lbldics.Name = "lbldics"
        Me.lbldics.Size = New System.Drawing.Size(128, 38)
        Me.lbldics.TabIndex = 17
        Me.lbldics.Text = "0.00"
        Me.lbldics.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsubtotal.BackColor = System.Drawing.Color.Teal
        Me.lblsubtotal.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.ForeColor = System.Drawing.Color.Black
        Me.lblsubtotal.Location = New System.Drawing.Point(1337, 444)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(131, 39)
        Me.lblsubtotal.TabIndex = 18
        Me.lblsubtotal.Text = "0.00"
        Me.lblsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Location = New System.Drawing.Point(0, 1041)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1524, 93)
        Me.Panel3.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.labelll)
        Me.Panel1.Controls.Add(Me.Guna2DataGridView1)
        Me.Panel1.Controls.Add(Me.lblvat)
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Controls.Add(Me.lbldue)
        Me.Panel1.Controls.Add(Me.lblsubtotal)
        Me.Panel1.Controls.Add(Me.lbldics)
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.PanelKey)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1528, 1045)
        Me.Panel1.TabIndex = 24
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.SystemColors.Window
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label8)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(51, 254)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1032, 39)
        Me.Guna2CustomGradientPanel1.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(393, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(215, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Customer Shopping Cart"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.BackColor = System.Drawing.Color.Teal
        Me.lbltotal.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Black
        Me.lbltotal.Location = New System.Drawing.Point(1337, 372)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(131, 39)
        Me.lbltotal.TabIndex = 33
        Me.lbltotal.Text = "0.00"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelll
        '
        Me.labelll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelll.BackColor = System.Drawing.Color.Teal
        Me.labelll.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelll.ForeColor = System.Drawing.Color.Black
        Me.labelll.Location = New System.Drawing.Point(1130, 362)
        Me.labelll.Name = "labelll"
        Me.labelll.Size = New System.Drawing.Size(338, 67)
        Me.labelll.TabIndex = 32
        Me.labelll.Text = "Total"
        Me.labelll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 20
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column14, Me.Column12, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column10, Me.Column9, Me.Column3, Me.Column11, Me.Column13})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(51, 292)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowTemplate.Height = 24
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(1032, 421)
        Me.Guna2DataGridView1.TabIndex = 31
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 20
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.DividerWidth = 1
        Me.Column1.HeaderText = "#                "
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 108
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.DividerWidth = 1
        Me.Column2.HeaderText = "ID"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        Me.Column2.Width = 50
        '
        'Column14
        '
        Me.Column14.HeaderText = "Pid"
        Me.Column14.Name = "Column14"
        Me.Column14.Visible = False
        Me.Column14.Width = 56
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column12.HeaderText = "Invoice No.                 "
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 177
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.DividerWidth = 1
        Me.Column4.HeaderText = "Brand Name         "
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 155
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.DividerWidth = 1
        Me.Column5.HeaderText = "Generic Name      "
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 156
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.DividerWidth = 1
        Me.Column6.HeaderText = "Classification        "
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 156
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.DividerWidth = 1
        Me.Column7.HeaderText = "Type                  "
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 140
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.DividerWidth = 1
        Me.Column8.HeaderText = "Formulation        "
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 147
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.DividerWidth = 1
        Me.Column10.HeaderText = "Dosage   "
        Me.Column10.Name = "Column10"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Price           "
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 113
        '
        'Column3
        '
        Me.Column3.DividerWidth = 1
        Me.Column3.HeaderText = "Qty"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 59
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "Total                             "
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 184
        '
        'Column13
        '
        Me.Column13.HeaderText = "                            "
        Me.Column13.Image = CType(resources.GetObject("Column13.Image"), System.Drawing.Image)
        Me.Column13.Name = "Column13"
        Me.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column13.Width = 147
        '
        'lblvat
        '
        Me.lblvat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblvat.BackColor = System.Drawing.Color.Teal
        Me.lblvat.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvat.ForeColor = System.Drawing.Color.Black
        Me.lblvat.Location = New System.Drawing.Point(1317, 658)
        Me.lblvat.Name = "lblvat"
        Me.lblvat.Size = New System.Drawing.Size(148, 35)
        Me.lblvat.TabIndex = 28
        Me.lblvat.Text = "0.00"
        Me.lblvat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.DefaultText = ""
        Me.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.IconLeft = CType(resources.GetObject("txtsearch.IconLeft"), System.Drawing.Image)
        Me.txtsearch.Location = New System.Drawing.Point(51, 217)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.PlaceholderText = "Search Box"
        Me.txtsearch.SelectedText = ""
        Me.txtsearch.Size = New System.Drawing.Size(1032, 31)
        Me.txtsearch.TabIndex = 20
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.lblinvoice)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1531, 51)
        Me.Panel4.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1360, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'lblinvoice
        '
        Me.lblinvoice.AutoSize = True
        Me.lblinvoice.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvoice.ForeColor = System.Drawing.Color.White
        Me.lblinvoice.Location = New System.Drawing.Point(81, 19)
        Me.lblinvoice.Name = "lblinvoice"
        Me.lblinvoice.Size = New System.Drawing.Size(130, 22)
        Me.lblinvoice.TabIndex = 33
        Me.lblinvoice.Text = "000000000000"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'PanelKey
        '
        Me.PanelKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelKey.BackColor = System.Drawing.Color.Silver
        Me.PanelKey.Controls.Add(Me.btnexit)
        Me.PanelKey.Controls.Add(Me.Button1)
        Me.PanelKey.Controls.Add(Me.btnpass)
        Me.PanelKey.Controls.Add(Me.Button8)
        Me.PanelKey.Controls.Add(Me.Button7)
        Me.PanelKey.Controls.Add(Me.Button6)
        Me.PanelKey.Controls.Add(Me.btndaily)
        Me.PanelKey.Controls.Add(Me.btnset)
        Me.PanelKey.Controls.Add(Me.btndiscountan)
        Me.PanelKey.Controls.Add(Me.btbprodinqu)
        Me.PanelKey.Controls.Add(Me.btnnewing)
        Me.PanelKey.Location = New System.Drawing.Point(51, 875)
        Me.PanelKey.Name = "PanelKey"
        Me.PanelKey.Size = New System.Drawing.Size(1409, 146)
        Me.PanelKey.TabIndex = 37
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.Black
        Me.btnexit.Image = CType(resources.GetObject("btnexit.Image"), System.Drawing.Image)
        Me.btnexit.Location = New System.Drawing.Point(1280, 0)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(128, 146)
        Me.btnexit.TabIndex = 46
        Me.btnexit.Text = "                                                Close "
        Me.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1152, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 146)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "                                             Change Password"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnpass
        '
        Me.btnpass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpass.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpass.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpass.ForeColor = System.Drawing.Color.Black
        Me.btnpass.Image = CType(resources.GetObject("btnpass.Image"), System.Drawing.Image)
        Me.btnpass.Location = New System.Drawing.Point(1024, 0)
        Me.btnpass.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btnpass.Name = "btnpass"
        Me.btnpass.Size = New System.Drawing.Size(128, 146)
        Me.btnpass.TabIndex = 44
        Me.btnpass.Text = "                                             Change Password"
        Me.btnpass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnpass.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(896, 0)
        Me.Button8.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(128, 146)
        Me.Button8.TabIndex = 43
        Me.Button8.Text = "                                             Daily Sales"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(768, 0)
        Me.Button7.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(128, 146)
        Me.Button7.TabIndex = 42
        Me.Button7.Text = "                                             Daily Sales"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(640, 0)
        Me.Button6.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(128, 146)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "                                             Daily Sales"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btndaily
        '
        Me.btndaily.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btndaily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btndaily.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndaily.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btndaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndaily.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndaily.ForeColor = System.Drawing.Color.Black
        Me.btndaily.Image = CType(resources.GetObject("btndaily.Image"), System.Drawing.Image)
        Me.btndaily.Location = New System.Drawing.Point(512, 0)
        Me.btndaily.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btndaily.Name = "btndaily"
        Me.btndaily.Size = New System.Drawing.Size(128, 146)
        Me.btndaily.TabIndex = 40
        Me.btndaily.Text = "                                             Daily Sales"
        Me.btndaily.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btndaily.UseVisualStyleBackColor = False
        '
        'btnset
        '
        Me.btnset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnset.Enabled = False
        Me.btnset.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnset.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnset.ForeColor = System.Drawing.Color.Black
        Me.btnset.Image = CType(resources.GetObject("btnset.Image"), System.Drawing.Image)
        Me.btnset.Location = New System.Drawing.Point(384, 0)
        Me.btnset.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btnset.Name = "btnset"
        Me.btnset.Size = New System.Drawing.Size(128, 146)
        Me.btnset.TabIndex = 39
        Me.btnset.Text = "                                              Settle"
        Me.btnset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnset.UseVisualStyleBackColor = False
        '
        'btndiscountan
        '
        Me.btndiscountan.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btndiscountan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btndiscountan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndiscountan.Enabled = False
        Me.btndiscountan.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btndiscountan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndiscountan.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndiscountan.ForeColor = System.Drawing.Color.Black
        Me.btndiscountan.Image = CType(resources.GetObject("btndiscountan.Image"), System.Drawing.Image)
        Me.btndiscountan.Location = New System.Drawing.Point(256, 0)
        Me.btndiscountan.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btndiscountan.Name = "btndiscountan"
        Me.btndiscountan.Size = New System.Drawing.Size(128, 146)
        Me.btndiscountan.TabIndex = 38
        Me.btndiscountan.Text = "                         " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Discount"
        Me.btndiscountan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btndiscountan.UseVisualStyleBackColor = False
        '
        'btbprodinqu
        '
        Me.btbprodinqu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btbprodinqu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btbprodinqu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btbprodinqu.Enabled = False
        Me.btbprodinqu.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btbprodinqu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btbprodinqu.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbprodinqu.ForeColor = System.Drawing.Color.Black
        Me.btbprodinqu.Image = CType(resources.GetObject("btbprodinqu.Image"), System.Drawing.Image)
        Me.btbprodinqu.Location = New System.Drawing.Point(128, 0)
        Me.btbprodinqu.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btbprodinqu.Name = "btbprodinqu"
        Me.btbprodinqu.Size = New System.Drawing.Size(128, 145)
        Me.btbprodinqu.TabIndex = 37
        Me.btbprodinqu.Text = "               Product Inquiry"
        Me.btbprodinqu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btbprodinqu.UseVisualStyleBackColor = False
        '
        'btnnewing
        '
        Me.btnnewing.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnnewing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnnewing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnewing.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnnewing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewing.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewing.ForeColor = System.Drawing.Color.Black
        Me.btnnewing.Image = CType(resources.GetObject("btnnewing.Image"), System.Drawing.Image)
        Me.btnnewing.Location = New System.Drawing.Point(0, 0)
        Me.btnnewing.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btnnewing.Name = "btnnewing"
        Me.btnnewing.Size = New System.Drawing.Size(128, 145)
        Me.btnnewing.TabIndex = 36
        Me.btnnewing.Text = "                   New Transaction"
        Me.btnnewing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnnewing.UseVisualStyleBackColor = False
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "                            "
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 147
        '
        'Timer2
        '
        '
        'cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1524, 1100)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cashier"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelKey.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbldisplaytot As System.Windows.Forms.Label
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents lbldics As System.Windows.Forms.Label
    Friend WithEvents lbldue As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents lblvat As System.Windows.Forms.Label
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents labelll As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnnewing As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PanelKey As System.Windows.Forms.Panel
    Friend WithEvents btbprodinqu As System.Windows.Forms.Button
    Friend WithEvents btnset As System.Windows.Forms.Button
    Friend WithEvents btndiscountan As System.Windows.Forms.Button
    Friend WithEvents btnpass As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btndaily As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblinvoice As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
