'Imports System.IO
'Imports System.Data.SqlClient
'Imports System.Drawing

'Public Class frmproductlist


'    Sub prodrecord()
'        Dim i As Integer = 0
'        dataprod.Rows.Clear()

'        Try
'            ' Ensure the connection is closed before opening
'            If con.State = ConnectionState.Open Then
'                con.Close()
'            End If

'            ' Open connection
'            con.Open()

'            ' Define the query to fetch product records with INNER JOIN on related tables, excluding the Type column
'            Dim query As String = "SELECT * " &
'                                  "FROM tblproduct AS p " &
'                                  "INNER JOIN tblbrand AS b ON p.bid = b.brandID " &
'                                  "INNER JOIN tblcategory AS c ON p.cid = c.catID " &
'                                  "INNER JOIN tblformulations AS f ON p.fid = f.formID " &
'                                  "INNER JOIN tbldosage AS d ON p.did = d.dosageID " &
'                                  "INNER JOIN tblgeneric AS g ON p.gid = g.genericID " &
'                                  "INNER JOIN tblunit AS u ON p.uid = u.unitID"

'            ' Create and execute the command
'            cmd = New SqlClient.SqlCommand(query, con)
'            dr = cmd.ExecuteReader()

'            ' Loop through data and populate DataGridView
'            While dr.Read()
'                i += 1

'                ' Check if the image is stored as binary data or a file path


'                ' Retrieve and convert the ImageSpl column
'                Dim img As Image = Nothing
'                If Not IsDBNull(dr("imagepath")) Then
'                    Dim imgData As Byte() = DirectCast(dr("imagepath"), Byte())
'                    img = ByteArrayToImage(imgData)
'                Else
'                    ' Optional: Set a placeholder image if ImageSpl is NULL
'                    img = My.Resources.eye_close_up ' Ensure this resource exists, or replace it
'                End If


'                ' Add data to DataGridView
'                dataprod.Rows.Add(i, dr("id").ToString(), dr("barcode").ToString(), dr("item_des").ToString(), dr("brand").ToString(), dr("generic").ToString(), dr("Category").ToString(), dr("Formulations").ToString(), dr("Dosage").ToString(), dr("unit").ToString(), dr("price").ToString(), img)
'            End While

'            ' Set row height
'            For i = 0 To dataprod.Rows.Count - 1
'                Dim r As DataGridViewRow = dataprod.Rows(i)
'                r.Height = 40
'            Next

'            ' Set image layout for the image column
'            Dim imageColumn = DirectCast(dataprod.Columns("image"), DataGridViewImageColumn)
'            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch



'            ' Display the record count
'            Label2.Text = "Record Found: (" & dataprod.RowCount & ")"

'        Catch ex As Exception
'            MsgBox("Error: " & ex.Message, vbCritical)

'        Finally
'            ' Close reader and connection
'            If dr IsNot Nothing Then dr.Close()
'            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then con.Close()
'        End Try
'    End Sub

'    Private Function ByteArrayToImage(ByVal byteArray As Byte()) As Image
'        ' Check if byteArray is valid and has data
'        If byteArray Is Nothing OrElse byteArray.Length = 0 Then
'            Return Nothing
'        End If

'        Try
'            Using ms As New MemoryStream(byteArray)
'                Dim originalImage As System.Drawing.Image = System.Drawing.Image.FromStream(ms)

'                ' Resize the image to specific dimensions, e.g., 100x130 pixels
'                Dim resizedImage As New Bitmap(100, 130) ' Adjust the width and height as needed
'                Using g As Graphics = Graphics.FromImage(resizedImage)
'                    g.DrawImage(originalImage, 0, 0, 100, 130) ' Draw the image at specified size
'                End Using

'                Return resizedImage
'            End Using
'        Catch ex As ArgumentException
'            ' Handle invalid image format
'            Return Nothing
'        End Try
'    End Function

'    Private Sub Button10_Click_1(sender As Object, e As EventArgs)
'        Me.Dispose()

'    End Sub

'    Private Sub btnew_Click(sender As Object, e As EventArgs)
'        Dim frm As New frmproduct()
'        frm.ActiveControl = frm.txtbarcode ' Set focus to txtbarcode
'        frm.btnsave.Visible = True
'        frm.ShowDialog()

'    End Sub

'    'Public Sub ResetFields()
'    '        txtprice.Clear()
'    '        GenCbx.SelectedIndex = -1
'    '        BranCBx.SelectedIndex = -1
'    '        DosCBx.SelectedIndex = -1
'    '        CatCBx.SelectedIndex = -1
'    '        FormCBx.SelectedIndex = -1
'    '        unitcbx.SelectedIndex = -1
'    '    End Sub

'    Private Sub frmproductlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        prodrecord()


'    End Sub



'    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)



'    End Sub

'    '                                                                       Clear fields when leaving DataGridView1

'    Private Sub DataGridView1_Leave(sender As Object, e As EventArgs)
'        With frmproduct
'            .txtbarcode.Clear()
'            .txtsales.Clear()
'            .itemdes.Clear()

'            .PictureBox1.Image = Nothing

'            .btnsave.Visible = True
'            .btnupdate.Visible = False
'        End With
'    End Sub








'    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs)

'    End Sub




'    Sub SearchBarcode()  ' CONNECTION NOT CLOSED PA

'        Try
'            Dim i As Integer = 0
'            dataprod.Rows.Clear()

'            con.Open()

'            Dim query As String = "SELECT p.id, p.barcode, p.item_des, b.brand, b.brandID, g.generic, c.Category, f.Formulations, d.Dosage,  p.price, u.unit, p.imagepath, p.barcode_image " &
'                          "FROM tblproduct AS p " &
'                          "INNER JOIN tblbrand AS b ON p.bid = b.brandID " &
'                          "INNER JOIN tblcategory AS c ON p.cid = c.catID " &
'                          "INNER JOIN tblformulations AS f ON p.fid = f.formID " &
'                          "INNER JOIN tbldosage AS d ON p.did = d.dosageID " &
'                          "INNER JOIN tblgeneric AS g ON p.gid = g.genericID " &
'                          "INNER JOIN tblunit AS u ON p.uid = u.unitID WHERE barcode LIKE @barcode"


'            cmd = New SqlClient.SqlCommand(query, con)
'            cmd.Parameters.AddWithValue("@barcode", Productsearch.Text & "%")

'            dr = cmd.ExecuteReader()
'            While dr.Read()
'                i += 1


'                Dim img As Image = Nothing
'                If Not IsDBNull(dr("barcode_image")) Then
'                    Dim imgData As Byte() = DirectCast(dr("barcode_image"), Byte())
'                    img = ByteArrayToImage(imgData)
'                Else
'                    img = Nothing
'                End If

'                dataprod.Rows.Add(i, dr.Item("id").ToString(), dr("barcode").ToString(), dr("item_des").ToString(), dr("brand").ToString(), dr("brandID").ToString(), dr("generic").ToString(), dr("Category").ToString(), dr("Formulations").ToString(), dr("Dosage").ToString(), dr("unit").ToString(), dr("price").ToString(), img)
'            End While

'            dr.Close()
'            con.Close()

'        Catch ex As Exception
'            MsgBox(ex.Message, vbCritical)
'        Finally
'            If con.State = ConnectionState.Open Then
'                con.Close()
'            End If
'        End Try
'    End Sub
'    Private Sub Productsearch_TextChanged(sender As Object, e As EventArgs)
'        SearchBarcode()

'    End Sub



'    Private Sub Productsearch_KeyDown(sender As Object, e As KeyEventArgs)

'    End Sub

'    Private Sub dataprod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

'        If e.RowIndex < 0 Then Return

'        Dim colname As String = dataprod.Columns(e.ColumnIndex).Name

'        If colname = "View" Then
'            MessageBox.Show("View logic not implemented yet.")

'        ElseIf colname = "Edit" Then
'            With frmproduct
'                .lblid.Text = dataprod.Rows(e.RowIndex).Cells(1).Value.ToString()
'                .txtbarcode.Text = dataprod.Rows(e.RowIndex).Cells(2).Value.ToString()
'                .itemdes.Text = dataprod.Rows(e.RowIndex).Cells(3).Value.ToString()

'                Dim brandId As Integer = CInt(dataprod.Rows(e.RowIndex).Cells(5).Value)
'                .brandcbx.SelectedValue = brandId

'                '.txtgeneric.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()


'                '.txtcategory.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
'                '.txtformu.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString()
'                '.txtdosage.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString()
'                '.txtunit.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString()
'                '.txtprice.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString()

'                .btnupdate.Visible = True
'                .btnsave.Visible = False

'                Dim imageData As Byte() = Nothing
'                If Not IsDBNull(dataprod.Rows(e.RowIndex).Cells(12).Value) Then
'                    Dim bitmap As Bitmap = TryCast(dataprod.Rows(e.RowIndex).Cells(12).Value, Bitmap)
'                    If bitmap IsNot Nothing Then
'                        Using ms As New MemoryStream()
'                            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
'                            imageData = ms.ToArray()
'                        End Using
'                    End If
'                End If

'                .SetImageData(imageData)

'                .ShowDialog()
'            End With

'        ElseIf colname = "Delete" Then
'            If (MsgBox("Are you sure you want to delete this record", vbYesNo + vbQuestion) = vbYes) Then
'                con.Open()
'                cmd = New SqlClient.SqlCommand("delete from tblproduct where id =" & dataprod.Rows(e.RowIndex).Cells(0).Value.ToString(), con)
'                cmd.ExecuteNonQuery()
'                con.Close()
'                MsgBox("Record has been successfully deleted.", vbInformation)
'                prodrecord()

'            End If

'        End If
'    End Sub

'    Private Sub dataprod_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

'    End Sub
'End Class















'Private Sub FillComboBoxFromDataGridViewColumn(comboBox As ComboBox, columnIndex As Integer)
'    ' Clear existing items in the ComboBox
'    comboBox.Items.Clear()

'    ' Loop through each row in the DataGridView to add unique items
'    For Each row As DataGridViewRow In DataGridView1.Rows
'        Dim value As Object = row.Cells(columnIndex).Value
'        If value IsNot Nothing AndAlso Not comboBox.Items.Contains(value.ToString()) Then
'            comboBox.Items.Add(value.ToString())
'        End If
'    Next
'    ' Set the ComboBox's selected item to the value in the current row
'    Dim selectedValue As String = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(columnIndex).Value.ToString()
'    If comboBox.Items.Contains(selectedValue) Then
'        comboBox.SelectedItem = selectedValue
'    Else
'        comboBox.SelectedIndex = -1 ' If not found, reset selection
'    End If
'End Sub










'Sub SearchItem()
'    Try
'        Dim i As Integer = 0
'        DataGridView1.Rows.Clear()

'        ' Open connection
'        con.Open()

'        ' Define the query with parameterized search text to prevent SQL injection
'        Dim query As String = "SELECT p.id, p.barcode, b.brand, g.generic, c.Category, f.Formulations, d.Dosage, p.reorder, p.price, u.unit " &
'                              "FROM tblproduct AS p " &
'                              "INNER JOIN tblbrand AS b ON p.bid = b.brandID " &
'                              "INNER JOIN tblcategory AS c ON p.cid = c.catID " &
'                              "INNER JOIN tblformulations AS f ON p.fid = f.formID " &
'                              "INNER JOIN tbldosage AS d ON p.did = d.dosageID " &
'                              "INNER JOIN tblgeneric AS g ON p.gid = g.genericID " &
'                              "INNER JOIN tblunit AS u ON p.uid = u.unitID " &
'                              "WHERE (b.brand LIKE @searchText OR g.generic LIKE @searchText OR c.Category LIKE @searchText)"

'        ' Create the command and add the parameter for search text
'        cmd = New SqlClient.SqlCommand(query, con)
'        cmd.Parameters.AddWithValue("@searchText", Productsearch.Text.Trim() & "%")

'        ' Execute reader
'        dr = cmd.ExecuteReader()

'        ' Loop through data and populate DataGridView
'        While dr.Read()
'            i += 1
'            DataGridView1.Rows.Add(i, dr("id").ToString(), dr("barcode").ToString(), dr("item_des").ToString(), dr("brand").ToString(), dr("generic").ToString(), dr("Category").ToString(), dr("Formulations").ToString(), dr("Dosage").ToString(), dr("reorder").ToString(), dr("price").ToString(), dr("unit").ToString())
'        End While

'    Catch ex As Exception
'        MsgBox("Error: " & ex.Message, vbCritical)

'    Finally
'        ' Close reader and connection
'        If dr IsNot Nothing Then dr.Close()
'        If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then con.Close()
'    End Try
'End Sub



'Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Productsearch.TextChanged
'    SearchItem()

'End Sub

'Private Sub Productsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Productsearch.KeyPress
'    SearchItem()
'End Sub

