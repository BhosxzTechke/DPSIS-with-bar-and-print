Public Class frmrecords

    'Sub stockinventory()
    '    Try
    '        Dim i As Integer, total As Double
    '        Guna2DataGridView1.Rows.Clear()
    '        con.Open()
    '        cmd = New SqlClient.SqlCommand("select * from tblproduct as p inner join tblbrand as b on p.bid = b.brandID  inner join tblcategory as c on p.cid =	c.id inner join tblformulations as f on p.fid = f.formID inner join tbldosage as d on p.did = d.dosageID inner join tblgeneric as g on p.gid = g.genericID inner join tblType as t on p.tid = T.TypeID inner join tblSupplier as sp on p.sid = sp.SupplierID where qty > 0 and " & cbofilter.Text & " like '" & txtsearch.Text & "%'", con)
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            i += 1
    '            total += CInt(dr.Item("qty").ToString)
    '            Guna2DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("barcode").ToString, dr.Item("brand").ToString, dr.Item("generic").ToString, dr.Item("Category").ToString, dr.Item("Type").ToString, dr.Item("Formulations").ToString, dr.Item("Dosage").ToString, dr.Item("CompanyName").ToString, dr.Item("qty").ToString)
    '        End While

    '        dr.Close()
    '        cmd = Nothing
    '        con.Close()
    '        lblstock.Text = "Record count : " & Guna2DataGridView1.Rows.Count & vbTab & " Available Stock(s): " & total

    '    Catch ex As Exception
    '        con.Close()
    '        MsgBox(ex.Message, vbCritical)
    '    Finally
    '        If con.State = ConnectionState.Open Then
    '            con.Close()
    '        End If
    '    End Try


    'End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Dispose()
    End Sub

    Private Sub cbofilter_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs)
        'If Walanglaman(txtsearch) = True Then Return
        'If Walanglaman(cbofilter) = True Then Return
        'stockinventory()

    End Sub

    Private Sub cboselect_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboselect.KeyPress
        e.Handled = True
    End Sub


    Private Sub cboselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboselect.SelectedIndexChanged
        CriticalStock()

    End Sub

    Sub CriticalStock()       ' FOR CRITICAL STOCK UNDER STOCK / OUT OF STOCK
        Guna2DataGridView2.Rows.Clear()
        Dim i As Integer = 0
        Dim total As Double = 0

        con.Open()

        If Walanglaman(cboselect) = True Then
            con.Close()
            Return
        End If

        If cboselect.Text = "Under Stock" Then
            cmd = New SqlClient.SqlCommand("select * from tblproduct as p inner join tblbrand as b on p.bid = b.brandID  inner join tblcategory as c on p.cid = c.catID inner join tblformulations as f on p.fid = f.formID inner join tbldosage as d on p.did = d.dosageID inner join tblgeneric as g on p.gid = g.genericID inner join tblType as t on p.tid = T.TypeID  where (qty <= reorder and qty > 0)", con)

        ElseIf cboselect.Text = "Out of Stock" Then
            cmd = New SqlClient.SqlCommand("select * from tblproduct as p inner join tblbrand as b on p.bid = b.brandID  inner join tblcategory as c on p.cid = c.catID inner join tblformulations as f on p.fid = f.formID inner join tbldosage as d on p.did = d.dosageID inner join tblgeneric as g on p.gid = g.genericID inner join tblType as t on p.tid = T.TypeID  where qty = 0", con)
        End If

        dr = cmd.ExecuteReader

        While dr.Read
            i += 1
            total += CInt(dr.Item("qty").ToString)
            Guna2DataGridView2.Rows.Add(i, dr.Item("id").ToString, dr.Item("barcode").ToString, dr.Item("brand").ToString, dr.Item("generic").ToString, dr.Item("Category").ToString, dr.Item("Type").ToString, dr.Item("Formulations").ToString, dr.Item("Dosage").ToString, dr.Item("reorder").ToString, dr.Item("qty").ToString)
        End While

        dr.Close()
        cmd = Nothing
        con.Close()

        'lblstock.Text = "Record count : " & Format(CLng(Guna2DataGridView2.Rows.Count), "#,##0")
    End Sub




    Sub SalesInventory()
        Dim i As Integer = 0
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        Guna2DataGridView3.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("Select * from tblpayment where sdate between '" & date1 & "' and '" & date2 & "'  order by id", con)
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            Guna2DataGridView3.Rows.Add(i, dr.Item("invoice").ToString, dr.Item("subtotal").ToString, dr.Item("vat").ToString, dr.Item("discount").ToString, dr.Item("amountdue").ToString, Format(CDate(dr.Item("sdate").ToString), "MM-dd-yyyy"), dr.Item("users").ToString)

        End While
        dr.Close()
        con.Close()

        lblsalesinvent.Text = "Record Count: " & Format(Guna2DataGridView3.RowCount _
                    & Space(10) & "Sub total: " & Format(GetTotalData("Select ISNULL(sum(subtotal),0) from tblpayment where sdate between '" & date1 & "' and '" & date2 & "'"), "#,##0.00") _
                    & Space(10) & "VATable: " & Format(GetTotalData("Select ISNULL(sum(vat),0) from tblpayment where sdate between '" & date1 & "' and '" & date2 & "'"), "#,##0.00") _
                    & Space(10) & "Discount: " & Format(GetTotalData("Select ISNULL(sum(discount),0) from tblpayment where sdate between '" & date1 & "' and '" & date2 & "'"), "#,##0.00") _
                    & Space(10) & "Total: " & Format(GetTotalData("Select ISNULL(sum(amountdue),0) from tblpayment where sdate between '" & date1 & "' and '" & date2 & "'"), "#,##0.00"))

        lbltotaldue.Text = "Total : " & Format(GetTotalData("Select ISNULL(sum(amountdue),0) from tblpayment where sdate between '" & date1 & "' and '" & date2 & "'"), "#,##0.00")
    End Sub
Function GetTotalData(ByVal sql As String) As Double
        con.Open()
        cmd = New SqlClient.SqlCommand(sql, con)
        GetTotalData = CDbl(cmd.ExecuteScalar)
        con.Close()
        Return GetTotalData
    End Function




    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        SalesInventory()
    End Sub


    Sub SoldItem()

        Dim i As Integer = 0
        Dim date1 As String = DateTimePicker4.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker3.Value.ToString("yyyy-MM-dd")

        Guna2DataGridView4.Rows.Clear()
        con.Open()                     '       THIS QUERY IS RETRIEVE ALL HAVE THE SAME PRODUCT ID AND ALSO CALCULATE ONLY THE 'SOLD' STATUS AND COMBINE IN QTY 
        cmd = New SqlClient.SqlCommand("SELECT ca.pid, b.brand, g.generic, c.Category, tp.Type, f.Formulations, d.Dosage, SUM(ca.qty) as qty FROM tblcart as ca INNER JOIN tblproduct as p on ca.pid = p.id INNER JOIN tblbrand as b on p.bid = b.brandID INNER JOIN tblgeneric as g on p.gid = g.genericID INNER JOIN tblcategory as c on p.cid = c.catID INNER JOIN tblType as tp on p.tid = tp.TypeID INNER JOIN tblformulations as f on p.fid = f.formID INNER JOIN tbldosage as d on p.did = d.dosageID WHERE ca.sdate BETWEEN '" & date1 & "' AND '" & date2 & "' AND ca.status = 'Sold' GROUP BY ca.pid, b.brand, g.generic, c.Category, tp.Type, f.Formulations, d.Dosage", con)
        dr = cmd.ExecuteReader()
        While dr.Read
            i += 1
            Guna2DataGridView4.Rows.Add(i, dr.Item(0).ToString, dr.Item(1).ToString, dr.Item(2).ToString, dr.Item(3).ToString, dr.Item(4).ToString, dr.Item(5).ToString, dr.Item(6).ToString, dr.Item(7).ToString)
        End While
        dr.Close()
        con.Close()

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        SoldItem()
    End Sub


    Sub ExpiredItem()
        Dim i As Integer = 0
        Dim date1 As String = DateTimePicker6.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker5.Value.ToString("yyyy-MM-dd")

        Guna2DataGridView4.Rows.Clear()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd = New SqlClient.SqlCommand("SELECT * FROM tblproduct AS p INNER JOIN tblbrand AS b ON p.bid = b.brandID INNER JOIN tblgeneric AS g ON p.gid = g.genericID INNER JOIN tblcategory AS c ON p.cid = c.catID INNER JOIN tblType AS tp ON p.tid = tp.TypeID INNER JOIN tblformulations AS f ON p.fid = f.formID INNER JOIN tbldosage AS d ON p.did = d.dosageID INNER JOIN tbldelivery as div on p.delID = div.deliveryID INNER JOIN tblsupplier as sp on p.sid = sp.SupplierID WHERE expdate BETWEEN @StartDate AND @EndDate ORDER BY expdate DESC;", con)
            cmd.Parameters.AddWithValue("@StartDate", date1)
            cmd.Parameters.AddWithValue("@EndDate", date2)
            dr = cmd.ExecuteReader()

            While dr.Read
                i += 1
                Guna2DataGridView5.Rows.Add(i, dr.Item("id").ToString, dr.Item("barcode").ToString, dr.Item("OrderR").ToString, dr.Item("CompanyName").ToString, dr.Item("brand").ToString, dr.Item("generic").ToString, dr.Item("category").ToString, dr.Item("daterel").ToString, dr.Item("expdate").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        ExpiredItem()
    End Sub

    Private Sub Guna2DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView3.CellContentClick

    End Sub
End Class