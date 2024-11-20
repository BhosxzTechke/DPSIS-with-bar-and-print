Public Class frmproductinquiry

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Dispose()

    End Sub

    Sub ProductInventoryCart()  '   READING ATTRIBUTES FROM TABLE PRODUCT WITH USING INNER JOIN
        Dim i As Integer = 0
        Guna2DataGridView1.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("select * from tblproduct as p inner join tblbrand as b on p.bid = b.brandID inner join tblcategory as c on p.cid =	c.catID inner join tblformulations as f on p.fid = f.formID inner join tbldosage as d on p.did = d.dosageID inner join tblgeneric as g on p.gid = g.genericID inner join tblType as t on p.tid = t.TypeID inner join tblSupplier as sp on p.sid = sp.SupplierID where qty <> 0 and (brand like '" & txtsearch.Text & "%' or generic like '" & txtsearch.Text & "%' or Category like '" & txtsearch.Text & "%')", con)
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            Guna2DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("barcode").ToString, dr.Item("brand").ToString, dr.Item("generic").ToString, dr.Item("Category").ToString, dr.Item("Type").ToString, dr.Item("Formulations").ToString, dr.Item("Dosage").ToString, dr.Item("CompanyName").ToString, dr.Item("reorder").ToString, dr.Item("price").ToString, dr.Item("qty").ToString)
        End While
        dr.Close()
        con.Close()


    End Sub

    'Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.Escape
    '            Me.Dispose()

    '    End Select
    'End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        '    Select Case Asc(e.KeyChar)
        '        Case 13
        '            ProductInventoryCart()
        '    End Select
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        ProductInventoryCart()
    End Sub


    ' ESC KEY
    Private Sub frmproductinquiry_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Dispose()

        End Select
    End Sub

    Private Sub frmproductinquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

    End Sub

    Sub searchproduct(ByVal search As String)
        Try
            If search = String.Empty Then Return
            con.Open()

            cmd = New SqlClient.SqlCommand("SELECT * FROM tblproduct WHERE id LIKE '" & search & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then

                ' so kapag pinindut ung nasa datagridview pupunta sa form na qty

                With frmqty
                    .lblprice.Text = dr.Item("price").ToString   '  INSERTING A VALUE FOR LABEL PRICE 
                    .lblPid.Text = dr.Item("id").ToString        '  INSERTING A VALUE ID FOR LABEL PROD 

                    dr.Close()
                    con.Close()
                    .ShowDialog() '           SHOWING A DIALOG FORM FOR QTY
                End With
                ' Show your form or perform other actions here
            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Dim colname As String = Guna2DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "Coladd" Then
            searchproduct(Guna2DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString)

            With cashier  '  real time na mag cacart
                .loadcart()
            End With

        End If


    End Sub
End Class