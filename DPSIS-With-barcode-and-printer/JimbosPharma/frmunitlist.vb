Imports System.Data.SqlClient

Public Class frmunitlist

    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
        With frmunit
            .btnsave.Visible = True
            .btnupdate.Visible = False
            .ShowDialog()
        End With
    End Sub


    Sub unitview()    ' a subroutine or subprocedure to create a specific task in this case is we will open a connection and read a table in tblcategory and ang purpose ng while loop is to read each row from the database result set and add it to the DataGridView.
        Dim i As Integer = 0
        DataView.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("Select * from tblunit order by unit", con)
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            DataView.Rows.Add(dr.Item("unitID").ToString, i, dr.Item("unit").ToString)
        End While
        dr.Close()
        con.Close()
        rc1.Text = " Record Found.(" & DataView.RowCount & ") "

        ' bro im cooked

    End Sub

    Private Sub DataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataView.CellContentClick
        ' ilalabas nito yung form na dialog "frmcategory" but in this case is mapipindot mo sia sa column 4 or an update button na nilagay natin 
        ' then magshoshow si update and mahahide si save                                                                                                                                                             
        Dim colname As String = DataView.Columns(e.ColumnIndex).Name

        If colname = "Edit" Then
            With frmunit
                .lblid.Text = DataView.Rows(e.RowIndex).Cells(0).Value.ToString()
                .txtunit.Text = DataView.Rows(e.RowIndex).Cells(2).Value.ToString()
                .btnsave.Visible = False
                .btnupdate.Visible = True
                .ShowDialog()
            End With
        ElseIf colname = "Delete" Then
            If (MsgBox("Are you sure you want to delete this record", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                cmd = New SqlClient.SqlCommand("delete from tblunit where unitID =" & DataView.Rows(e.RowIndex).Cells(1).Value.ToString(), con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                unitview()
            End If

        End If
    End Sub

    Private Sub frmunitlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        unitview()
    End Sub

    Private Sub DataView_Leave(sender As Object, e As EventArgs) Handles DataView.Leave
        With frmunit
            .txtunit.Clear()
            .btnupdate.Visible = False
            .btnsave.Visible = True

        End With
    End Sub
    Sub SearchUNIT()
        Dim i As Integer = 0
        DataView.Rows.Clear()

        ' Open database connection
        con.Open()

        ' Use parameterized query to avoid SQL injection
        Dim query As String = "SELECT * FROM tblunit WHERE unit LIKE @searchText"
        cmd = New SqlClient.SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@searchText", Productsearch.Text & "%")

        ' Execute the reader
        dr = cmd.ExecuteReader()
        While dr.Read()
            i += 1
            DataView.Rows.Add(i, dr.Item("unitID").ToString(), dr.Item("unit").ToString())
        End While

        ' Close the reader and connection
        dr.Close()
        con.Close()
    End Sub

    Private Sub Productsearch_TextChanged(sender As Object, e As EventArgs) Handles Productsearch.TextChanged
        SearchUNIT()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class