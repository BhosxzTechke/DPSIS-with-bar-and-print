Public Class frmcategorylist

    'Dim id, _category As String

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs)

        With frmcategory
            .btnupdate.Enabled = False
            .ShowDialog()

        End With
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Dispose()


    End Sub

    Private Sub frmcategorylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



     Sub catview()    ' a subroutine or subprocedure to create a specific task in this case is we will open a connection and read a table in tblcategory and ang purpose ng while loop is to read each row from the database result set and add it to the DataGridView.
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("Select * from tblcategory order by Category", con)
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(dr.Item("catID").ToString, i, dr.Item("Category").ToString)
        End While
        dr.Close()
        con.Close()
        rc1.Text = " Record Found.(" & DataGridView1.RowCount & ") "

    End Sub


    Private Sub rc1_TextChanged(sender As Object, e As EventArgs)
        rc1.Enabled = False

    End Sub


    Private Sub Button10_Click_1(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' ilalabas nito yung form na dialog "frmcategory" but in this case is mapipindot mo sia sa column 4 or an update button na nilagay natin 
        ' then magshoshow si update and mahahide si save                                                                                                                                                             
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "Column4" Then ' FOR UPDATE IT MEANS YOU NEED TO AN ID TO FIND OUT  
            With frmcategory
                .lblID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString() 'THIS IS FOR ID
                .txtcategory.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .btnsave.Visible = False
                .btnupdate.Visible = True

                .ShowDialog()
            End With
        ElseIf colname = "Column5" Then
            If (MsgBox("Are you sure you want to delete this record", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                cmd = New SqlClient.SqlCommand("delete from tblcategory where catID =" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString(), con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                catview()
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmcategory
            .btnupdate.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub DataGridView1_Leave(sender As Object, e As EventArgs) Handles DataGridView1.Leave
        With frmcategory
            .txtcategory.Clear()
            .btnupdate.Visible = False
            .btnsave.Visible = True

        End With
    End Sub

    Sub Searchcat()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()

        ' Open database connection
        con.Open()

        ' Use parameterized query to avoid SQL injection
        Dim query As String = "SELECT * FROM tblcategory WHERE Category LIKE @searchText"
        cmd = New SqlClient.SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@searchText", Guna2TextBox1.Text & "%")

        ' Execute the reader
        dr = cmd.ExecuteReader()
        While dr.Read()
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("catID").ToString(), dr.Item("Category").ToString())
        End While

        ' Close the reader and connection
        dr.Close()
        con.Close()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Searchcat()
    End Sub
End Class