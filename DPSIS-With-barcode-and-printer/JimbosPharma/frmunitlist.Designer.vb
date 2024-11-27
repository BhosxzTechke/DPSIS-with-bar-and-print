<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmunitlist
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmunitlist))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnew = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Productsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.rc1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'DataView
        '
        Me.DataView.AllowUserToAddRows = False
        Me.DataView.AllowUserToDeleteRows = False
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Edit, Me.Delete})
        Me.DataView.Location = New System.Drawing.Point(69, 80)
        Me.DataView.Margin = New System.Windows.Forms.Padding(4)
        Me.DataView.Name = "DataView"
        Me.DataView.ReadOnly = True
        Me.DataView.RowTemplate.Height = 24
        Me.DataView.Size = New System.Drawing.Size(1179, 445)
        Me.DataView.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Unit"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Edit
        '
        Me.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = "Edit"
        Me.Edit.DefaultCellStyle = DataGridViewCellStyle3
        Me.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit.HeaderText = ""
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Width = 5
        '
        'Delete
        '
        Me.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.NullValue = "Delete"
        Me.Delete.DefaultCellStyle = DataGridViewCellStyle4
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Width = 5
        '
        'btnew
        '
        Me.btnew.BackColor = System.Drawing.Color.Teal
        Me.btnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnew.FlatAppearance.BorderSize = 0
        Me.btnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnew.ForeColor = System.Drawing.Color.White
        Me.btnew.Location = New System.Drawing.Point(1079, 45)
        Me.btnew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnew.Name = "btnew"
        Me.btnew.Size = New System.Drawing.Size(169, 27)
        Me.btnew.TabIndex = 8
        Me.btnew.Text = "New Unit"
        Me.btnew.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1332, 39)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Unit"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Productsearch)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1332, 641)
        Me.Panel2.TabIndex = 24
        '
        'Productsearch
        '
        Me.Productsearch.BackColor = System.Drawing.Color.Transparent
        Me.Productsearch.BorderColor = System.Drawing.Color.Transparent
        Me.Productsearch.BorderRadius = 1
        Me.Productsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Productsearch.DefaultText = ""
        Me.Productsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Productsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Productsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Productsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Productsearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Productsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Productsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Productsearch.ForeColor = System.Drawing.Color.Black
        Me.Productsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Productsearch.IconLeft = CType(resources.GetObject("Productsearch.IconLeft"), System.Drawing.Image)
        Me.Productsearch.Location = New System.Drawing.Point(69, 45)
        Me.Productsearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Productsearch.Name = "Productsearch"
        Me.Productsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Productsearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Productsearch.PlaceholderText = "Search Product Here"
        Me.Productsearch.SelectedText = ""
        Me.Productsearch.Size = New System.Drawing.Size(410, 27)
        Me.Productsearch.TabIndex = 10
        Me.Productsearch.WordWrap = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.DataView)
        Me.Panel3.Controls.Add(Me.btnew)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1332, 641)
        Me.Panel3.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.rc1)
        Me.Panel5.Location = New System.Drawing.Point(1095, 532)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(153, 26)
        Me.Panel5.TabIndex = 23
        '
        'rc1
        '
        Me.rc1.BackColor = System.Drawing.Color.Transparent
        Me.rc1.ForeColor = System.Drawing.Color.White
        Me.rc1.Location = New System.Drawing.Point(23, 0)
        Me.rc1.Name = "rc1"
        Me.rc1.Size = New System.Drawing.Size(76, 18)
        Me.rc1.TabIndex = 17
        Me.rc1.Text = "No Records"
        '
        'frmunitlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 641)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmunitlist"
        Me.Text = "frmunitlist"
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents DataView As System.Windows.Forms.DataGridView
    Friend WithEvents btnew As System.Windows.Forms.Button
    Friend WithEvents Productsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Edit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents rc1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
