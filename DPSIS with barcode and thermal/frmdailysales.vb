Imports System.Data.SqlClient
Public Class frmdailysales

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Sub loadsales()

        Dim sdate As String = DateTime.Value.ToString("yyyy-MM-dd")

        Dim i As Integer = 0
        Guna2DataGridView1.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("select * from tblcart as ca inner join tblproduct as p on ca.pid = p.id inner join tblbrand as b on p.bid = b.brandID inner join tblcategory as c on p.cid =c.catID inner join tblformulations as f on p.fid = f.formID inner join tbldosage as d on p.did = d.dosageID inner join tblgeneric as g on p.gid = g.genericID inner join tblType as t on p.tid = t.TypeID inner join tblSupplier as sp on p.sid = sp.SupplierID where sdate between '" & sdate & "' and '" & sdate & "'", con)
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            Guna2DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("invoice").ToString, dr.Item("brand").ToString, dr.Item("generic").ToString, dr.Item("Category").ToString, dr.Item("Type").ToString, dr.Item("Formulations").ToString, dr.Item("Dosage").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString)
        End While
        dr.Close()
        con.Close()


        lblTot.Text = Format(GetData("select sum(total) from tblcart where sdate between '" & sdate & "' and '" & sdate & "'and status like 'Sold'"), "#,#00.00")
        lbldiscount.Text = Format(GetData("select sum(Discount) from tblpayment where sdate between '" & sdate & "' and '" & sdate & "'"), "#,#00.00")
        lblsubtotal.Text = Format(GetData("select sum(subtotal) from tblpayment where sdate between '" & sdate & "' and '" & sdate & "'"), "#,#00.00")
        lblvat.Text = Format(GetData("select sum(vat) from tblpayment where sdate between '" & sdate & "' and '" & sdate & "'"), "#,#00.00")
        lbltotsales.Text = Format(GetData("select sum(amountdue) from tblpayment where sdate between '" & sdate & "' and '" & sdate & "'"), "#,#00.00")
        lbltotal.Text = "Total Daily Sales " & lbltotsales.Text
        Guna2DataGridView1.Rows.Add("", "", "", "", "", "", "", "", "", "", "TOTAL", lblTot.Text)
    End Sub

    Function GetData(ByVal sql As String) As Double
        Try
            con.Open()
            cmd = New SqlClient.SqlCommand(sql, con)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return CDbl(result)
            Else
                Return 0
            End If
        Catch ex As Exception
            ' Handle exception (e.g., log error)
            Return 0
        Finally
            con.Close()
        End Try
    End Function




    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub

    Private Sub DateTime_ValueChanged(sender As Object, e As EventArgs) Handles DateTime.ValueChanged
        loadsales()
    End Sub
End Class