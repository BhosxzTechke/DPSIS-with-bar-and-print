﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstaffboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmstaffboard))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.lbluser = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.Command2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2ContextMenuStrip2 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.toolstripmaint = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnew = New System.Windows.Forms.Button()
        Me.btnproduct = New System.Windows.Forms.Button()
        Me.btnrecords = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnsales = New System.Windows.Forms.Button()
        Me.btnsadjust = New System.Windows.Forms.Button()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.Guna2ContextMenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'lbluser
        '
        Me.lbluser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Font = New System.Drawing.Font("Segoe UI Historic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.Black
        Me.lbluser.Location = New System.Drawing.Point(981, 12)
        Me.lbluser.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(86, 23)
        Me.lbluser.TabIndex = 20
        Me.lbluser.Text = "Nickname"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnproduct)
        Me.Panel1.Controls.Add(Me.btnrecords)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnsales)
        Me.Panel1.Controls.Add(Me.btnsadjust)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 806)
        Me.Panel1.TabIndex = 33
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(16, 20)
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Command2ToolStripMenuItem, Me.AToolStripMenuItem})
        Me.Guna2ContextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.Guna2ContextMenuStrip1.Margin = New System.Windows.Forms.Padding(3, 5, 0, 0)
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(156, 56)
        '
        'Command2ToolStripMenuItem
        '
        Me.Command2ToolStripMenuItem.Name = "Command2ToolStripMenuItem"
        Me.Command2ToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.Command2ToolStripMenuItem.Text = "Command2"
        '
        'Guna2ContextMenuStrip2
        '
        Me.Guna2ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripmaint})
        Me.Guna2ContextMenuStrip2.Name = "Guna2ContextMenuStrip2"
        Me.Guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip2.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip2.Size = New System.Drawing.Size(198, 28)
        '
        'toolstripmaint
        '
        Me.toolstripmaint.Name = "toolstripmaint"
        Me.toolstripmaint.Size = New System.Drawing.Size(197, 24)
        Me.toolstripmaint.Text = "Manage Inventory"
        '
        'lbltime
        '
        Me.lbltime.BackColor = System.Drawing.Color.Teal
        Me.lbltime.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.lbltime.Location = New System.Drawing.Point(0, 27)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(297, 41)
        Me.lbltime.TabIndex = 39
        Me.lbltime.Text = "00:00:00"
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.Color.Teal
        Me.lbldate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.lbldate.Location = New System.Drawing.Point(0, 0)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(297, 27)
        Me.lbldate.TabIndex = 40
        Me.lbldate.Text = "Today Is"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DimGray
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(446, 30)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(258, 34)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "   Maintenance"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(716, 30)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 33)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "   POS"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1181, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnew
        '
        Me.btnew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnew.BackColor = System.Drawing.Color.Transparent
        Me.btnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnew.FlatAppearance.BorderSize = 0
        Me.btnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnew.ForeColor = System.Drawing.Color.White
        Me.btnew.Image = CType(resources.GetObject("btnew.Image"), System.Drawing.Image)
        Me.btnew.Location = New System.Drawing.Point(1250, 12)
        Me.btnew.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btnew.Name = "btnew"
        Me.btnew.Size = New System.Drawing.Size(58, 39)
        Me.btnew.TabIndex = 21
        Me.btnew.UseVisualStyleBackColor = False
        '
        'btnproduct
        '
        Me.btnproduct.BackColor = System.Drawing.Color.Transparent
        Me.btnproduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnproduct.FlatAppearance.BorderSize = 0
        Me.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproduct.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproduct.ForeColor = System.Drawing.Color.Black
        Me.btnproduct.Image = CType(resources.GetObject("btnproduct.Image"), System.Drawing.Image)
        Me.btnproduct.Location = New System.Drawing.Point(6, 134)
        Me.btnproduct.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btnproduct.Name = "btnproduct"
        Me.btnproduct.Size = New System.Drawing.Size(285, 163)
        Me.btnproduct.TabIndex = 22
        Me.btnproduct.Text = "   Manage Product"
        Me.btnproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnproduct.UseVisualStyleBackColor = False
        '
        'btnrecords
        '
        Me.btnrecords.BackColor = System.Drawing.Color.Transparent
        Me.btnrecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrecords.FlatAppearance.BorderSize = 0
        Me.btnrecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrecords.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrecords.ForeColor = System.Drawing.Color.Black
        Me.btnrecords.Image = CType(resources.GetObject("btnrecords.Image"), System.Drawing.Image)
        Me.btnrecords.Location = New System.Drawing.Point(3, 629)
        Me.btnrecords.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btnrecords.Name = "btnrecords"
        Me.btnrecords.Size = New System.Drawing.Size(285, 153)
        Me.btnrecords.TabIndex = 24
        Me.btnrecords.Text = "   View Records"
        Me.btnrecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnrecords.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(285, 128)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "   Dashboard"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnsales
        '
        Me.btnsales.BackColor = System.Drawing.Color.Transparent
        Me.btnsales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsales.FlatAppearance.BorderSize = 0
        Me.btnsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsales.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsales.ForeColor = System.Drawing.Color.Black
        Me.btnsales.Image = CType(resources.GetObject("btnsales.Image"), System.Drawing.Image)
        Me.btnsales.Location = New System.Drawing.Point(3, 303)
        Me.btnsales.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btnsales.Name = "btnsales"
        Me.btnsales.Size = New System.Drawing.Size(285, 163)
        Me.btnsales.TabIndex = 21
        Me.btnsales.Text = "   View Supplier"
        Me.btnsales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsales.UseVisualStyleBackColor = False
        '
        'btnsadjust
        '
        Me.btnsadjust.BackColor = System.Drawing.Color.Transparent
        Me.btnsadjust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsadjust.FlatAppearance.BorderSize = 0
        Me.btnsadjust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsadjust.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsadjust.ForeColor = System.Drawing.Color.Black
        Me.btnsadjust.Image = CType(resources.GetObject("btnsadjust.Image"), System.Drawing.Image)
        Me.btnsadjust.Location = New System.Drawing.Point(3, 472)
        Me.btnsadjust.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btnsadjust.Name = "btnsadjust"
        Me.btnsadjust.Size = New System.Drawing.Size(285, 151)
        Me.btnsadjust.TabIndex = 28
        Me.btnsadjust.Text = "   Stock Updates"
        Me.btnsadjust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsadjust.UseVisualStyleBackColor = False
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Image = CType(resources.GetObject("AToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.AToolStripMenuItem.Text = "a"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbluser)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1332, 68)
        Me.Panel2.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(297, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1035, 806)
        Me.Panel3.TabIndex = 42
        '
        'frmstaffboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1332, 874)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnew)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmstaffboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmstaffboard"
        Me.Panel1.ResumeLayout(False)
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.Guna2ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnrecords As System.Windows.Forms.Button
    Friend WithEvents btnsadjust As System.Windows.Forms.Button
    Friend WithEvents btnsales As System.Windows.Forms.Button
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents btnproduct As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnew As System.Windows.Forms.Button
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Command2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Guna2ContextMenuStrip2 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents toolstripmaint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class