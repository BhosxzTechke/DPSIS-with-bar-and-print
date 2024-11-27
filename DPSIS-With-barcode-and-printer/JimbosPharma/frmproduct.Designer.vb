<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmproduct))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ckbarcode = New System.Windows.Forms.CheckBox()
        Me.txtsales = New Guna.UI2.WinForms.Guna2TextBox()
        Me.unitcbx = New System.Windows.Forms.ComboBox()
        Me.formucbx = New System.Windows.Forms.ComboBox()
        Me.categorycbx = New System.Windows.Forms.ComboBox()
        Me.dosagecbx = New System.Windows.Forms.ComboBox()
        Me.gencbx = New System.Windows.Forms.ComboBox()
        Me.brandcbx = New System.Windows.Forms.ComboBox()
        Me.txtbarcode = New System.Windows.Forms.TextBox()
        Me.picbarcode = New System.Windows.Forms.PictureBox()
        Me.unitid = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.itemdes = New Guna.UI2.WinForms.Guna2TextBox()
        Me.labelprice = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbldos = New System.Windows.Forms.Label()
        Me.labeldosage = New System.Windows.Forms.Label()
        Me.labelformu = New System.Windows.Forms.Label()
        Me.labelcateg = New System.Windows.Forms.Label()
        Me.labelgeneric = New System.Windows.Forms.Label()
        Me.labelbrand = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lblbarcode = New System.Windows.Forms.Label()
        Me.lblreor = New System.Windows.Forms.Label()
        Me.lblformul = New System.Windows.Forms.Label()
        Me.lblclass = New System.Windows.Forms.Label()
        Me.lblgeneric = New System.Windows.Forms.Label()
        Me.lblbrand = New System.Windows.Forms.Label()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picbarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ckbarcode)
        Me.Panel1.Controls.Add(Me.txtsales)
        Me.Panel1.Controls.Add(Me.unitcbx)
        Me.Panel1.Controls.Add(Me.formucbx)
        Me.Panel1.Controls.Add(Me.categorycbx)
        Me.Panel1.Controls.Add(Me.dosagecbx)
        Me.Panel1.Controls.Add(Me.gencbx)
        Me.Panel1.Controls.Add(Me.brandcbx)
        Me.Panel1.Controls.Add(Me.txtbarcode)
        Me.Panel1.Controls.Add(Me.picbarcode)
        Me.Panel1.Controls.Add(Me.unitid)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.itemdes)
        Me.Panel1.Controls.Add(Me.labelprice)
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lbldos)
        Me.Panel1.Controls.Add(Me.labeldosage)
        Me.Panel1.Controls.Add(Me.labelformu)
        Me.Panel1.Controls.Add(Me.labelcateg)
        Me.Panel1.Controls.Add(Me.labelgeneric)
        Me.Panel1.Controls.Add(Me.labelbrand)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblid)
        Me.Panel1.Controls.Add(Me.lblprice)
        Me.Panel1.Controls.Add(Me.lblbarcode)
        Me.Panel1.Controls.Add(Me.lblreor)
        Me.Panel1.Controls.Add(Me.lblformul)
        Me.Panel1.Controls.Add(Me.lblclass)
        Me.Panel1.Controls.Add(Me.lblgeneric)
        Me.Panel1.Controls.Add(Me.lblbrand)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnupdate)
        Me.Panel1.Location = New System.Drawing.Point(0, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(898, 542)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(314, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 22)
        Me.Button1.TabIndex = 94
        Me.Button1.Text = "Generate unique barcode"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ckbarcode
        '
        Me.ckbarcode.AutoSize = True
        Me.ckbarcode.Location = New System.Drawing.Point(157, 55)
        Me.ckbarcode.Name = "ckbarcode"
        Me.ckbarcode.Size = New System.Drawing.Size(134, 22)
        Me.ckbarcode.TabIndex = 91
        Me.ckbarcode.Text = "Saving Barcode"
        Me.ckbarcode.UseVisualStyleBackColor = True
        '
        'txtsales
        '
        Me.txtsales.BackColor = System.Drawing.Color.Transparent
        Me.txtsales.BorderColor = System.Drawing.Color.Gray
        Me.txtsales.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsales.DefaultText = ""
        Me.txtsales.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsales.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsales.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsales.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsales.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsales.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsales.Location = New System.Drawing.Point(157, 407)
        Me.txtsales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsales.Name = "txtsales"
        Me.txtsales.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsales.PlaceholderText = ""
        Me.txtsales.SelectedText = ""
        Me.txtsales.Size = New System.Drawing.Size(346, 33)
        Me.txtsales.TabIndex = 90
        '
        'unitcbx
        '
        Me.unitcbx.FormattingEnabled = True
        Me.unitcbx.Location = New System.Drawing.Point(157, 373)
        Me.unitcbx.Name = "unitcbx"
        Me.unitcbx.Size = New System.Drawing.Size(346, 26)
        Me.unitcbx.TabIndex = 89
        '
        'formucbx
        '
        Me.formucbx.FormattingEnabled = True
        Me.formucbx.Location = New System.Drawing.Point(157, 332)
        Me.formucbx.Name = "formucbx"
        Me.formucbx.Size = New System.Drawing.Size(346, 26)
        Me.formucbx.TabIndex = 88
        '
        'categorycbx
        '
        Me.categorycbx.FormattingEnabled = True
        Me.categorycbx.Location = New System.Drawing.Point(157, 285)
        Me.categorycbx.Name = "categorycbx"
        Me.categorycbx.Size = New System.Drawing.Size(346, 26)
        Me.categorycbx.TabIndex = 87
        '
        'dosagecbx
        '
        Me.dosagecbx.FormattingEnabled = True
        Me.dosagecbx.Location = New System.Drawing.Point(157, 239)
        Me.dosagecbx.Name = "dosagecbx"
        Me.dosagecbx.Size = New System.Drawing.Size(346, 26)
        Me.dosagecbx.TabIndex = 86
        '
        'gencbx
        '
        Me.gencbx.FormattingEnabled = True
        Me.gencbx.Location = New System.Drawing.Point(157, 156)
        Me.gencbx.Name = "gencbx"
        Me.gencbx.Size = New System.Drawing.Size(346, 26)
        Me.gencbx.TabIndex = 85
        '
        'brandcbx
        '
        Me.brandcbx.FormattingEnabled = True
        Me.brandcbx.Location = New System.Drawing.Point(157, 196)
        Me.brandcbx.Name = "brandcbx"
        Me.brandcbx.Size = New System.Drawing.Size(346, 26)
        Me.brandcbx.TabIndex = 84
        '
        'txtbarcode
        '
        Me.txtbarcode.Location = New System.Drawing.Point(157, 83)
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(346, 24)
        Me.txtbarcode.TabIndex = 75
        '
        'picbarcode
        '
        Me.picbarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picbarcode.Location = New System.Drawing.Point(561, 37)
        Me.picbarcode.Name = "picbarcode"
        Me.picbarcode.Size = New System.Drawing.Size(308, 160)
        Me.picbarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbarcode.TabIndex = 74
        Me.picbarcode.TabStop = False
        '
        'unitid
        '
        Me.unitid.AutoSize = True
        Me.unitid.Location = New System.Drawing.Point(131, 381)
        Me.unitid.Name = "unitid"
        Me.unitid.Size = New System.Drawing.Size(0, 18)
        Me.unitid.TabIndex = 73
        Me.unitid.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 18)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Unit:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 18)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Item Description:"
        '
        'itemdes
        '
        Me.itemdes.BackColor = System.Drawing.Color.Transparent
        Me.itemdes.BorderColor = System.Drawing.Color.Gray
        Me.itemdes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.itemdes.DefaultText = ""
        Me.itemdes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.itemdes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.itemdes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itemdes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.itemdes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itemdes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.itemdes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.itemdes.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.itemdes.Location = New System.Drawing.Point(157, 114)
        Me.itemdes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.itemdes.Name = "itemdes"
        Me.itemdes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.itemdes.PlaceholderText = ""
        Me.itemdes.SelectedText = ""
        Me.itemdes.Size = New System.Drawing.Size(346, 33)
        Me.itemdes.TabIndex = 69
        '
        'labelprice
        '
        Me.labelprice.AutoSize = True
        Me.labelprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelprice.ForeColor = System.Drawing.Color.Black
        Me.labelprice.Location = New System.Drawing.Point(13, 422)
        Me.labelprice.Name = "labelprice"
        Me.labelprice.Size = New System.Drawing.Size(87, 18)
        Me.labelprice.TabIndex = 68
        Me.labelprice.Text = "Sales Price:"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Brown
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(561, 421)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(308, 27)
        Me.Guna2Button1.TabIndex = 66
        Me.Guna2Button1.Text = "SELECT PHOTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(107, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Entry"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(561, 203)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'lbldos
        '
        Me.lbldos.AutoSize = True
        Me.lbldos.Location = New System.Drawing.Point(128, 239)
        Me.lbldos.Name = "lbldos"
        Me.lbldos.Size = New System.Drawing.Size(0, 18)
        Me.lbldos.TabIndex = 34
        Me.lbldos.Visible = False
        '
        'labeldosage
        '
        Me.labeldosage.AutoSize = True
        Me.labeldosage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeldosage.ForeColor = System.Drawing.Color.Black
        Me.labeldosage.Location = New System.Drawing.Point(13, 254)
        Me.labeldosage.Name = "labeldosage"
        Me.labeldosage.Size = New System.Drawing.Size(64, 18)
        Me.labeldosage.TabIndex = 30
        Me.labeldosage.Text = "Dosage:"
        '
        'labelformu
        '
        Me.labelformu.AutoSize = True
        Me.labelformu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelformu.ForeColor = System.Drawing.Color.Black
        Me.labelformu.Location = New System.Drawing.Point(13, 340)
        Me.labelformu.Name = "labelformu"
        Me.labelformu.Size = New System.Drawing.Size(91, 18)
        Me.labelformu.TabIndex = 29
        Me.labelformu.Text = "Formulation:"
        '
        'labelcateg
        '
        Me.labelcateg.AutoSize = True
        Me.labelcateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcateg.ForeColor = System.Drawing.Color.Black
        Me.labelcateg.Location = New System.Drawing.Point(11, 293)
        Me.labelcateg.Name = "labelcateg"
        Me.labelcateg.Size = New System.Drawing.Size(116, 18)
        Me.labelcateg.TabIndex = 27
        Me.labelcateg.Text = "Category Name:"
        '
        'labelgeneric
        '
        Me.labelgeneric.AutoSize = True
        Me.labelgeneric.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelgeneric.ForeColor = System.Drawing.Color.Black
        Me.labelgeneric.Location = New System.Drawing.Point(13, 164)
        Me.labelgeneric.Name = "labelgeneric"
        Me.labelgeneric.Size = New System.Drawing.Size(108, 18)
        Me.labelgeneric.TabIndex = 26
        Me.labelgeneric.Text = "Generic Name:"
        '
        'labelbrand
        '
        Me.labelbrand.AutoSize = True
        Me.labelbrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbrand.ForeColor = System.Drawing.Color.Black
        Me.labelbrand.Location = New System.Drawing.Point(12, 211)
        Me.labelbrand.Name = "labelbrand"
        Me.labelbrand.Size = New System.Drawing.Size(95, 18)
        Me.labelbrand.TabIndex = 25
        Me.labelbrand.Text = "Brand Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Barcode:"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.Transparent
        Me.lblid.Location = New System.Drawing.Point(15, 43)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(0, 18)
        Me.lblid.TabIndex = 20
        Me.lblid.Visible = False
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Location = New System.Drawing.Point(121, 418)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(0, 18)
        Me.lblprice.TabIndex = 19
        '
        'lblbarcode
        '
        Me.lblbarcode.AutoSize = True
        Me.lblbarcode.Location = New System.Drawing.Point(104, 88)
        Me.lblbarcode.Name = "lblbarcode"
        Me.lblbarcode.Size = New System.Drawing.Size(0, 18)
        Me.lblbarcode.TabIndex = 18
        '
        'lblreor
        '
        Me.lblreor.AutoSize = True
        Me.lblreor.Location = New System.Drawing.Point(127, 418)
        Me.lblreor.Name = "lblreor"
        Me.lblreor.Size = New System.Drawing.Size(0, 18)
        Me.lblreor.TabIndex = 15
        '
        'lblformul
        '
        Me.lblformul.AutoSize = True
        Me.lblformul.Location = New System.Drawing.Point(117, 311)
        Me.lblformul.Name = "lblformul"
        Me.lblformul.Size = New System.Drawing.Size(0, 18)
        Me.lblformul.TabIndex = 14
        Me.lblformul.Visible = False
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.Location = New System.Drawing.Point(137, 275)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(0, 18)
        Me.lblclass.TabIndex = 12
        Me.lblclass.Visible = False
        '
        'lblgeneric
        '
        Me.lblgeneric.AutoSize = True
        Me.lblgeneric.Location = New System.Drawing.Point(127, 164)
        Me.lblgeneric.Name = "lblgeneric"
        Me.lblgeneric.Size = New System.Drawing.Size(0, 18)
        Me.lblgeneric.TabIndex = 11
        Me.lblgeneric.Visible = False
        '
        'lblbrand
        '
        Me.lblbrand.AutoSize = True
        Me.lblbrand.Location = New System.Drawing.Point(123, 199)
        Me.lblbrand.Name = "lblbrand"
        Me.lblbrand.Size = New System.Drawing.Size(0, 18)
        Me.lblbrand.TabIndex = 10
        '
        'btnsave
        '
        Me.btnsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsave.FillColor = System.Drawing.Color.Teal
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(780, 515)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(115, 27)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "SUBMIT"
        '
        'btnupdate
        '
        Me.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnupdate.FillColor = System.Drawing.Color.Teal
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(783, 515)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(115, 27)
        Me.btnupdate.TabIndex = 9
        Me.btnupdate.Text = "UPDATE"
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
        Me.Guna2Button2.Location = New System.Drawing.Point(842, -1)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(56, 20)
        Me.Guna2Button2.TabIndex = 71
        '
        'frmproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(898, 559)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmproduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmproduct"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picbarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblbrand As System.Windows.Forms.Label
    Friend WithEvents lblformul As System.Windows.Forms.Label
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents lblgeneric As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents lblbarcode As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents labeldosage As System.Windows.Forms.Label
    Friend WithEvents labelformu As System.Windows.Forms.Label
    Friend WithEvents labelcateg As System.Windows.Forms.Label
    Friend WithEvents labelgeneric As System.Windows.Forms.Label
    Friend WithEvents labelbrand As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbldos As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents itemdes As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents labelprice As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents unitid As System.Windows.Forms.Label
    Friend WithEvents picbarcode As System.Windows.Forms.PictureBox
    Friend WithEvents txtbarcode As System.Windows.Forms.TextBox
    Friend WithEvents brandcbx As System.Windows.Forms.ComboBox
    Friend WithEvents lblreor As System.Windows.Forms.Label
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtsales As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents unitcbx As System.Windows.Forms.ComboBox
    Friend WithEvents formucbx As System.Windows.Forms.ComboBox
    Friend WithEvents categorycbx As System.Windows.Forms.ComboBox
    Friend WithEvents dosagecbx As System.Windows.Forms.ComboBox
    Friend WithEvents gencbx As System.Windows.Forms.ComboBox
    Friend WithEvents ckbarcode As System.Windows.Forms.CheckBox
    Public WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
