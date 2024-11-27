Imports System.Data.SqlClient
Public Class dashboard

    ' Flag to toggle colors
    Private isColorCyan As Boolean = True




    Private Sub btncategory_Click(sender As Object, e As EventArgs) Handles btncategory.Click
        Guna2ContextMenuStrip2.Show(btncategory, 2, btncategory.Height)

        ''FORM NI CATEGORY
        'With frmmaintenance
        '    .TopLevel = False
        '    Panel3.Controls.Add(frmmaintenance)
        '    .BringToFront()
        '    .Show()
        'End With



    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnaccount.Click
        With frmuser
            .loaduserlist()
            .ShowDialog()

        End With
    End Sub



    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Timer1.Start()

        With frmdashboard
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmdashboard)
            .BringToFront()
            .Show()
        End With

        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable

        Timer5.Start()

    End Sub

    Private Sub btnproduct_Click(sender As Object, e As EventArgs) Handles btnproduct.Click


        ' FORM NI PRODUCT
        With frmproductlists
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmproductlists)
            .prodrecord()
            .BringToFront()
            .Show()

        End With


    End Sub
    Private Sub btnstock_Click(sender As Object, e As EventArgs) Handles btnstock.Click
        ' FORM NI supplier
        With frmsupplierlist
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmsupplierlist)
            .BringToFront()
            .Show()
            '.supplierrecord()
        End With
    End Sub


    Private Sub btnsales_Click(sender As Object, e As EventArgs) Handles btnsales.Click
        With cashier
            '.btnexit.Visible = True
            '.btnpass.Enabled = False
            .ShowDialog()

        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Me.Dispose()

    End Sub




    Private Sub dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


    End Sub





    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    tiktok.Text = Date.Now.ToString("hh:mm:ss")
    '    ampm.Text = Date.Now.ToString("tt")

    '    Guna2CircleProgressBar1.Value = Date.Now.ToString("ss")

    '    day.Text = Date.Now.ToString("dddd")
    '    calendar.Text = Date.Now.Date

    'End Sub


    Private Sub Guna2ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Guna2ContextMenuStrip1.Opening
        ' Check the current color mode and update the menu item text
        Command1ToolStripMenuItem.Text = "System Lock"
        Command2ToolStripMenuItem.Text = "Change Password"
        AToolStripMenuItem.Text = "Logout"
    End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
        Guna2ContextMenuStrip1.Show(btnew, 0, btnew.Height)

    End Sub


    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click

        loginform.Show()

        Me.Dispose()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        With frmdashboard
            .ProductCount()
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmdashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnrecords_Click(sender As Object, e As EventArgs) Handles btnrecords.Click

        With frmrecords
            '.stockinventory()
            .ShowDialog()

        End With

    End Sub

    Private Sub btnsadjust_Click(sender As Object, e As EventArgs) Handles btnsadjust.Click
        With frmstockadjustment
            '.txtadjusted.Text = struser
            .ShowDialog()

        End With
    End Sub




    Private Sub Command1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Command1ToolStripMenuItem.Click
        With frmlock
            .ShowDialog()        ' LOCK THE SYSTEM
        End With
    End Sub


    Private Sub Command2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Command2ToolStripMenuItem.Click
        With frmchangepass
            .ShowDialog()        '      CHANGE PASSWORD
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        With loadchart
            .ShowDialog()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        With frmSalesReport
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmSalesReport)
            .BringToFront()
            .Show()
        End With
    End Sub


    Private Sub VatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VatToolStripMenuItem.Click
        With frmvat
            .txtvat.Text = getvat()
            .ShowDialog()

        End With
    End Sub

    Private Sub DiscountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscountToolStripMenuItem.Click
        With frmdiscount
            .loaddiscount()
            .ShowDialog()

        End With
    End Sub

    Private Sub toolstripmaint_Click(sender As Object, e As EventArgs) Handles toolstripmaint.Click
        'FORM NI maintanance
        With frmmaintenance
            .ShowDialog()

        End With
    End Sub

    Private Sub Guna2CircleProgressBar2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Label1.Text = Now.ToLongDateString
        Label2.Text = Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub OtherMaintananceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherMaintananceToolStripMenuItem.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' FORM NI Delivery
        With frmdeliverylist
            .Opacity = 0
            .TopLevel = False
            Panel3.Controls.Add(frmdeliverylist)
            .BringToFront()
            .Show()

        End With

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With frminventorylist
            .ShowDialog()

        End With
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
End Class
