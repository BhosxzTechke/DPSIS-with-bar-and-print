Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing

Public Class frmproductlists

    Private Sub frmproductlists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prodrecord()
    End Sub

    Sub prodrecord()
        Dim i As Integer = 0
        dataprod.Rows.Clear()

        Try
            ' Ensure the connection is closed before opening
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            ' Open connection
            con.Open()

            ' Define the query to fetch product records
            Dim query As String = "SELECT * FROM tblproduct AS p " &
                                  "INNER JOIN tblbrand AS b ON p.bid = b.brandID " &
                                  "INNER JOIN tblcategory AS c ON p.cid = c.catID " &
                                  "INNER JOIN tblformulations AS f ON p.fid = f.formID " &
                                  "INNER JOIN tbldosage AS d ON p.did = d.dosageID " &
                                  "INNER JOIN tblgeneric AS g ON p.gid = g.genericID " &
                                  "INNER JOIN tblunit AS u ON p.uid = u.unitID"

            ' Create and execute the command
            cmd = New SqlClient.SqlCommand(query, con)
            dr = cmd.ExecuteReader()

            '' Ensure the image column is added to DataGridView
            'If Not dataprod.Columns.Contains("image") Then
            '    Dim imgColumn As New DataGridViewImageColumn()
            '    imgColumn.Name = "image"
            '    imgColumn.HeaderText = "Product Image"
            '    imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch
            '    dataprod.Columns.Add(imgColumn)
            'End If

            ' Loop through data and populate DataGridView
            While dr.Read()
                i += 1

                ' Check if the image is stored as binary data or a file path


                ' Retrieve and convert the ImageSpl column
                Dim img As Image = Nothing
                If Not IsDBNull(dr("imagepath")) Then
                    Dim imgData As Byte() = DirectCast(dr("imagepath"), Byte())
                    img = ByteArrayToImage(imgData)
                Else
                    img = My.Resources.eye_close_up
                End If


                ' Add data to DataGridView
                dataprod.Rows.Add(i, dr("id").ToString(), img, dr("barcode").ToString(), dr("item_des").ToString(),
                                  dr("brand").ToString(), dr("generic").ToString(), dr("Category").ToString(),
                                  dr("Formulations").ToString(), dr("Dosage").ToString(), dr("unit").ToString(),
                                  dr("price").ToString())
            End While

            ' Set row height
            For Each r As DataGridViewRow In dataprod.Rows
                r.Height = 40
            Next

            ' Display the record count
            rc1.Text = "Record Found: (" & dataprod.RowCount & ")"

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)

        Finally
            ' Close reader and connection
            If dr IsNot Nothing Then dr.Close()
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub




    Private Function ByteArrayToImage(ByVal byteArray As Byte()) As Image
        ' Check if byteArray is valid and has data
        If byteArray Is Nothing OrElse byteArray.Length = 0 Then
            Return Nothing
        End If

        Try
            Using ms As New MemoryStream(byteArray)
                Dim originalImage As System.Drawing.Image = System.Drawing.Image.FromStream(ms)

                ' Resize the image to specific dimensions, e.g., 100x130 pixels
                Dim resizedImage As New Bitmap(100, 130) ' Adjust the width and height as needed
                Using g As Graphics = Graphics.FromImage(resizedImage)
                    g.DrawImage(originalImage, 0, 0, 100, 130) ' Draw the image at specified size
                End Using

                Return resizedImage
            End Using
        Catch ex As ArgumentException
            ' Handle invalid image format
            Return Nothing
        End Try
    End Function


    Private Sub frmproductlists_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        With frmproduct
            .txtbarcode.Clear()
            .txtsales.Clear()
            .itemdes.Clear()

            .PictureBox1.Image = Nothing

            .btnsave.Visible = True
            .btnupdate.Visible = False
        End With
    End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
        Dim frm As New frmproduct()
        frm.ActiveControl = frm.txtbarcode ' Set focus to txtbarcode
        frm.btnsave.Visible = True
        frm.ShowDialog()
    End Sub

    'Sub SearchItem()
    '    Dim i As Integer = 0
    '    DataView.Rows.Clear()

    '    ' Open database connection
    '    con.Open()

    '    ' Use parameterized query to avoid SQL injection
    '    Dim query As String = "SELECT * FROM tblbrand WHERE brand LIKE @searchText"
    '    cmd = New SqlClient.SqlCommand(query, con)
    '    cmd.Parameters.AddWithValue("@searchText", Productsearch.Text & "%")

    '    ' Execute the reader
    '    dr = cmd.ExecuteReader()
    '    While dr.Read()
    '        i += 1
    '        datapro.Rows.Add(i, dr.Item("brandID").ToString(), dr.Item("brand").ToString())
    '    End While

    '    ' Close the reader and connection
    '    dr.Close()
    '    con.Close()
    'End Sub
    Sub SearchBarcode()
        Try
            ' Initialize variables
            Dim i As Integer = 0
            dataprod.Rows.Clear() ' Clear existing rows in DataGridView

            ' Open database connection
            If con.State = ConnectionState.Closed Then con.Open()

            ' Query with INNER JOINs and parameterized search
            Dim query As String = "SELECT p.id, p.barcode, p.item_des, b.brand, g.generic, c.Category, f.Formulations, d.Dosage, " &
                                  "p.price, u.unit, p.imagepath, p.barcode_image " &
                                  "FROM tblproduct AS p " &
                                  "INNER JOIN tblbrand AS b ON p.bid = b.brandID " &
                                  "INNER JOIN tblcategory AS c ON p.cid = c.catID " &
                                  "INNER JOIN tblformulations AS f ON p.fid = f.formID " &
                                  "INNER JOIN tbldosage AS d ON p.did = d.dosageID " &
                                  "INNER JOIN tblgeneric AS g ON p.gid = g.genericID " &
                                  "INNER JOIN tblunit AS u ON p.uid = u.unitID " &
                                  "WHERE p.barcode LIKE @barcode OR b.brand LIKE @brand OR g.generic LIKE @generic"
            ' Create SQL command and parameters
            cmd = New SqlClient.SqlCommand(query, con)
            cmd.Parameters.Add("@barcode", SqlDbType.VarChar).Value = "%" & Productsearch.Text.Trim() & "%"
            cmd.Parameters.Add("@brand", SqlDbType.VarChar).Value = "%" & Productsearch.Text.Trim() & "%"
            cmd.Parameters.Add("@generic", SqlDbType.VarChar).Value = "%" & Productsearch.Text.Trim() & "%"

            ' Execute reader
            dr = cmd.ExecuteReader()

            ' Process data
            While dr.Read()
                i += 1
                Dim img As Image = Nothing
                If Not IsDBNull(dr("imagepath")) Then
                    Dim imgData As Byte() = DirectCast(dr("imagepath"), Byte())
                    img = ByteArrayToImage(imgData)
                Else
                    img = Nothing
                End If


                ' Add row to DataGridView
                dataprod.Rows.Add(i,
                                  dr("id").ToString(),
                                  img,
                                  dr("barcode").ToString(),
                                  dr("item_des").ToString(),
                                  dr("brand").ToString(),
                                  dr("generic").ToString(),
                                  dr("Category").ToString(),
                                  dr("Formulations").ToString(),
                                  dr("Dosage").ToString(),
                                  dr("unit").ToString(),
                                  Convert.ToDecimal(dr("price")).ToString("C2")) ' Format price
            End While

            ' Adjust row height in DataGridView
            For Each r As DataGridViewRow In dataprod.Rows
                r.Height = 40
            Next

            dr.Close()

        Catch ex As Exception
            ' Display error message
            MsgBox("Error: {ex.Message}", vbCritical, "Search Error")
        Finally
            ' Ensure connection is closed
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    'Private Sub Productsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Productsearch.KeyDown
    '    SearchBarcode()

    'End Sub

    Private Sub dataprod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataprod.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim colname As String = dataprod.Columns(e.ColumnIndex).Name

        If colname = "View" Then
            MessageBox.Show("View logic not implemented yet.")

        ElseIf colname = "Edit" Then
            With frmproduct
                .lblid.Text = dataprod.Rows(e.RowIndex).Cells(1).Value.ToString()
                .txtbarcode.Text = dataprod.Rows(e.RowIndex).Cells(2).Value.ToString()
                .itemdes.Text = dataprod.Rows(e.RowIndex).Cells(3).Value.ToString()

                Dim brandId As Integer = CInt(dataprod.Rows(e.RowIndex).Cells(5).Value)
                .brandcbx.SelectedValue = brandId

                '.txtgeneric.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()


                '.txtcategory.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
                '.txtformu.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString()
                '.txtdosage.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString()
                '.txtunit.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString()
                '.txtprice.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString()

                .btnupdate.Visible = True
                .btnsave.Visible = False

                Dim imageData As Byte() = Nothing
                If Not IsDBNull(dataprod.Rows(e.RowIndex).Cells(12).Value) Then
                    Dim bitmap As Bitmap = TryCast(dataprod.Rows(e.RowIndex).Cells(12).Value, Bitmap)
                    If bitmap IsNot Nothing Then
                        Using ms As New MemoryStream()
                            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                            imageData = ms.ToArray()
                        End Using
                    End If
                End If

                .SetImageData(imageData)

                .ShowDialog()
            End With

        ElseIf colname = "Delete" Then
            If (MsgBox("Are you sure you want to delete this record", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                cmd = New SqlClient.SqlCommand("delete from tblproduct where id =" & dataprod.Rows(e.RowIndex).Cells(0).Value.ToString(), con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                prodrecord()

            End If

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Productsearch_TextChanged(sender As Object, e As EventArgs) Handles Productsearch.TextChanged
        SearchBarcode()

    End Sub
End Class