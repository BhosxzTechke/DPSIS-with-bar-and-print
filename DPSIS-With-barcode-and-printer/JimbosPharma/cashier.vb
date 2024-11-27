Imports System.Data.SqlClient

Public Class cashier

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        loginform.Show()
        Me.Close()

    End Sub

    Private Sub cashier_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                btnnewing_Click(sender, e)
            Case Keys.F2
                btbprodinqu_Click(sender, e)
            Case Keys.F3
                btndiscountan_Click(sender, e)
            Case Keys.F4
                btnset_Click(sender, e)
            Case Keys.F5
                btndaily_Click(sender, e)
            Case Keys.F9
                btnpass_Click(sender, e)
        End Select
    End Sub

    Private Sub cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.WindowState = FormWindowState.Maximized
        Panel1.Dock = DockStyle.Fill
        Timer2.Start()

    End Sub


    Sub loadcart()
        Guna2DataGridView1.Rows.Clear()
        Dim _total As Double = 0, i As Integer = 0
        Try

            ' Ensure the connection is closed before opening
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New SqlCommand("select * from tblcart as ct inner join tblInventory as iv on ct.pid = iv.InventoryID inner join tblproduct as p on iv.id = p.id inner join tblbrand as b on p.bid = b.brandID inner join tblcategory as c on p.cid =	c.catID inner join tblformulations as f on p.fid = f.formID inner join tbldosage as d on p.did = d.dosageID inner join tblgeneric as g on p.gid = g.genericID  inner join tblunit as un on p.uid = un.unitID where invoice like'" & lblinvoice.Text & "'", con)
            dr = cmd.ExecuteReader

            While dr.Read
                i += 1
                ' Combine fields to create a short item description
                Dim itemDescription As String = String.Format("{0} ({1}) {2} {3}",
                                                               dr("brand").ToString(),
                                                               dr("generic").ToString(),
                                                               dr("Dosage").ToString(),
                                                               dr("Formulations").ToString())

                ' Add row with FullName and other fields, including img
                Guna2DataGridView1.Rows.Add(dr("id").ToString(), i, dr("InventoryID").ToString(), dr("id").ToString(), dr("invoice").ToString(), itemDescription, dr("qty").ToString(), dr("price").ToString(), dr.Item("total").ToString)
                _total += CDbl(dr.Item("total").ToString)


            End While

            con.Close()
            dr.Close()


            computesalesdetail(CDbl(_total))
            If Guna2DataGridView1.RowCount > 0 Then btnset.Enabled = True Else btnset.Enabled = False
            If Guna2DataGridView1.RowCount > 0 Then btndiscountan.Enabled = True Else btndiscountan.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & "StackTrace: " & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()
        End Try
    End Sub



    'Sub loadcart()
    '    Try
    '        Dim _total As Double = 0, i As Integer = 0
    '        con.Open()
    '        Guna2DataGridView1.Rows.Clear()
    '        cmd = New SqlClient.SqlCommand("select * from tblcart as ct inner join tblproduct as p on ct.pid = p.id inner join tblbrand as b on p.bid = b.brandID inner join tblcategory as c on p.cid =c.catID inner join tblformulations as f on p.fid = f.formID inner join tblgeneric as g on p.gid = g.genericID     inner join tbldosage as d on p.did = d.dosageID where invoice like'" & lblinvoice.Text & "'", con)
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            i += 1
    '            Guna2DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("pid").ToString, dr.Item("invoice").ToString, dr.Item("brand").ToString, dr.Item("generic").ToString, dr.Item("Category").ToString, dr.Item("Type").ToString, dr.Item("Formulations").ToString, dr.Item("Dosage").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString)

    '            _total += CDbl(dr.Item("total").ToString)

    '        End While
    '        dr.Close()
    '        con.Close()


    '        computesalesdetail(CDbl(_total))
    '        If Guna2DataGridView1.RowCount > 0 Then btnset.Enabled = True Else btnset.Enabled = False
    '        If Guna2DataGridView1.RowCount > 0 Then btndiscountan.Enabled = True Else btndiscountan.Enabled = False

    '    Catch ex As Exception
    '        con.Close()
    '        MsgBox(ex.Message, vbCritical)
    '    End Try

    'End Sub

    Sub computesalesdetail(ByVal _total As Double)
        lbltotal.Text = Format(_total, "#,##0.00")

        lblsubtotal.Text = Format(CDbl(lbltotal.Text) - CDbl(lbldics.Text), "#,##0.00")

        lblvat.Text = Format(CDbl(lblsubtotal.Text) * getvat(), "#,##0.00")    ' Display on the lbl vat the function of getvat that insert on every item the vat
        lbldue.Text = Format(CDbl(lblsubtotal.Text) - CDbl(lblvat.Text), "#,##0.00")

        lbldisplaytot.Text = lblsubtotal.Text
    End Sub


    Function getinvoiceNo() As String          '            A FUNCTION TO RETURN A STRING

        Try
            Dim sdate As String = Now.ToString("yyyyMMdd")     '   THIS LINE GETS THE CURRENT DATE AND TIME (Now) AND CONVERTS IT TO A STRING IN THE FORMAT "yyyyMMdd"

            con.Open()            '                        like is a keyword % and a symbol wildcard para mahanap sa lahat ng row ang nagiisang sdate  
            cmd = New SqlClient.SqlCommand("select top 1 invoice from tblcart where invoice like '%" & sdate & "%' order by id desc ", con) ' THIS QUERY IS USED TO FIND THE LATEST INVOICE NUMBER FOR THE CURRENT DATE.
            dr = cmd.ExecuteReader
            dr.Read()

            ' IF 
            If dr.HasRows Then getinvoiceNo = dr.Item("invoice").ToString Else getinvoiceNo = String.Empty
            dr.Close()
            con.Close()

            If getinvoiceNo = String.Empty Then
                getinvoiceNo = sdate & "0001"
                Return getinvoiceNo

            Else
                getinvoiceNo = Trim(Str(CLng(getinvoiceNo) + 1)) '  DEBUG IN SOLD OR PENDING
                Return getinvoiceNo
            End If


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
            Return getinvoiceNo()
        End Try

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick  '       LIVE DATE AND TIME
        lbldate.Text = Now.ToLongDateString
        lbltime.Text = Now.ToString("hh:mm:ss tt")
    End Sub

    Sub searchproduct(ByVal search As String)
        Try
            ' Exit if the search input is empty
            If String.IsNullOrWhiteSpace(search) Then
                MsgBox("Search input is empty.")
                Return
            End If

            ' Debugging - Confirm search input
            MsgBox("Searching for: " & search)

            ' Use the connection in a Using block
            Using con As New SqlClient.SqlConnection("Data Source=TECHQUINA\SQLEXPRESS;Initial Catalog=JimbospharmaDB;Integrated Security=True;MultipleActiveResultSets=True;")
                con.Open()

                ' SQL query with parameterized input
                Dim query As String = "select * from tblInventory as iv " &
                                      "inner join tblproduct as p on iv.id = p.id " &
                                      "WHERE barcode = @search"

                Using cmd As New SqlClient.SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@search", search)

                    Using dr As SqlClient.SqlDataReader = cmd.ExecuteReader()
                        ' Check if any rows are returned
                        If dr.Read() Then
                            MsgBox("Product found!")

                            ' Pass the retrieved values to frmqty
                            With frmqty
                                .lblprice.Text = dr("price").ToString()
                                .lblPid.Text = dr("InventoryID").ToString()
                                .ShowDialog()
                            End With
                        Else
                            MsgBox("No product found for the given barcode.", vbExclamation)
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try
    End Sub





    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Dim colname As String = Guna2DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "Column13" Then
            If MsgBox("Remove this Item? Please confirm", vbYesNo + vbQuestion) + vbYes Then
                con.Open()
                cmd = New SqlClient.SqlCommand("Delete from tblcart where id=" & Guna2DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString(), con)
                cmd.ExecuteNonQuery()
                con.Close()
                loadcart()
            End If
        End If
    End Sub

    Private Sub btnproduct_Click(sender As Object, e As EventArgs)
        'With frmproductinquiry
        '    .ProductInventoryCart()
        '    .ShowDialog()
        'End With
    End Sub

    Private Sub btndiscount_Click(sender As Object, e As EventArgs)  ' CLICK TO SHOW DISCOUNT FORM
        'With frmdiscountcashier
        '    .GetDiscount()
        '    .ShowDialog()

        'End With
    End Sub




    Private Sub btndailysales_Click(sender As Object, e As EventArgs)
        With frmdailysales
            .loadsales()
            .ShowDialog()

        End With
    End Sub


    Sub ClearAfterPaid()
        lbldisplaytot.Text = "0.00"
        lbldics.Text = "0.00"
        lblvat.Text = "0.00"
        lblsubtotal.Text = "0.00"
        lbldue.Text = "0.00"

    End Sub



    'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
    '    tiktok.Text = Date.Now.ToString("hh:mm:ss")
    '    ampm.Text = Date.Now.ToString("tt")

    '    Guna2CircleProgressBar1.Value = Date.Now.ToString("ss")

    '    day.Text = Date.Now.ToString("dddd")
    '    calendar.Text = Date.Now.Date
    'End Sub


    'shortcut key SA BABA


    ' NEW TRANSACTION
    Private Sub btnnewing_Click(sender As Object, e As EventArgs) Handles btnnewing.Click

        If Guna2DataGridView1.RowCount > 0 Then Return ' IF may laman na sa datagrid di na mageexecute yung whole code if wala pang laman pedeng mag new uli
        lblinvoice.Text = getinvoiceNo() ' THIS LINE IS RETURNING A STRING TO UPDATE THE lblinvoice.text 
        btbprodinqu.Enabled = True
        txtsearch.Enabled = True
        txtsearch.Focus()
    End Sub

    ' PRODUCT INQUIRY
    Private Sub btbprodinqu_Click(sender As Object, e As EventArgs) Handles btbprodinqu.Click
        With frmproductinquiry
            .loadinventory()
            .ShowDialog()
        End With
    End Sub

    ' ADD DISCOUNT
    Private Sub btndiscountan_Click(sender As Object, e As EventArgs) Handles btndiscountan.Click
        With frmdiscountcashier
            .GetDiscount()
            .ShowDialog()

        End With
    End Sub

    ' SETTLE
    Private Sub btnset_Click(sender As Object, e As EventArgs) Handles btnset.Click
        With frmsettle
            .lbltotalitem.Text = lblsubtotal.Text     ' Para ilagay niya sa form yung total due 
            .ShowDialog()
        End With
    End Sub

    ' DAILY SALES
    Private Sub btndaily_Click(sender As Object, e As EventArgs) Handles btndaily.Click
        With frmdailysales
            .loadsales()
            .ShowDialog()

        End With


    End Sub

    Private Sub btnpass_Click(sender As Object, e As EventArgs)
        With frmchangepass
            .ShowDialog()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()

        dashboard.Show()
    End Sub



    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Call the search function with the full barcode
            searchproduct(txtsearch.Text)

            ' Prevent the beep sound when pressing Enter
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class