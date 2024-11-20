Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing

Public Class frmproductlist

    Sub prodrecord()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()

        Try
            ' Ensure the connection is closed before opening
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            ' Open connection
            con.Open()

            ' Define the query to fetch product records with INNER JOIN on related tables, excluding the Type column
            Dim query As String = "SELECT p.id, p.barcode, p.item_des, b.brand, g.generic, c.Category, f.Formulations, d.Dosage, p.reorder, p.price, u.unit, p.imagepath " &
                                  "FROM tblproduct AS p " &
                                  "INNER JOIN tblbrand AS b ON p.bid = b.brandID " &
                                  "INNER JOIN tblcategory AS c ON p.cid = c.catID " &
                                  "INNER JOIN tblformulations AS f ON p.fid = f.formID " &
                                  "INNER JOIN tbldosage AS d ON p.did = d.dosageID " &
                                  "INNER JOIN tblgeneric AS g ON p.gid = g.genericID " &
                                  "INNER JOIN tblunit AS u ON p.uid = u.unitID"

            ' Create and execute the command
            cmd = New SqlClient.SqlCommand(query, con)
            dr = cmd.ExecuteReader()

            ' Loop through data and populate DataGridView
            While dr.Read()
                i += 1

                ' Check if the image is stored as binary data or a file path
                Dim img As Image = Nothing
                If Not IsDBNull(dr("imagepath")) Then
                    Dim imageData As Object = dr("imagepath")

                    If TypeOf imageData Is Byte() Then
                        ' Convert binary data to image
                        img = ByteArrayToImage(DirectCast(imageData, Byte()))
                    ElseIf TypeOf imageData Is String AndAlso Not String.IsNullOrEmpty(imageData.ToString()) Then
                        ' Load image from file path if it exists
                        Dim imgPath As String = imageData.ToString()
                        If IO.File.Exists(imgPath) Then
                            img = Image.FromFile(imgPath)
                        Else
                            img = My.Resources.eye_close_up ' Placeholder image if file is missing
                        End If
                    End If
                Else
                    ' Placeholder image if imagepath is NULL
                    img = My.Resources.eye_close_up
                End If

                ' Add data to DataGridView
                DataGridView1.Rows.Add(i, dr("id").ToString(), dr("barcode").ToString(), dr("item_des").ToString(), dr("brand").ToString(), dr("generic").ToString(), dr("Category").ToString(), dr("Formulations").ToString(), dr("Dosage").ToString(), dr("reorder").ToString(), dr("unit").ToString(), dr("price").ToString(), img)
            End While

            ' Display the record count
            Label2.Text = "Record Found: (" & DataGridView1.RowCount & ")"

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
            Return My.Resources.eye_close_up
        End If

        Try
            Using ms As New MemoryStream(byteArray)
                Dim originalImage As Image = Image.FromStream(ms)

                ' Resize the image to specific dimensions, e.g., 100x130 pixels
                Dim resizedImage As New Bitmap(100, 130)
                Using g As Graphics = Graphics.FromImage(resizedImage)
                    g.DrawImage(originalImage, 0, 0, resizedImage.Width, resizedImage.Height)
                End Using

                Return resizedImage
            End Using
        Catch ex As ArgumentException
            ' Return placeholder image in case of invalid format
            Return My.Resources.eye_close_up
        End Try
    End Function


Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
    Me.Dispose()

End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click

        With frmproduct
            ' Clear TextBox
            .txtprice.Clear()

            ' Clear ComboBox selections
            .unitcbx.SelectedIndex = -1
            .GenCbx.SelectedIndex = -1
            .BranCBx.SelectedIndex = -1

            ' Refresh ComboBoxes to apply changes
            .unitcbx.Refresh()
            .GenCbx.Refresh()
            .BranCBx.Refresh()

            ' Set buttons' visibility
            .btnsave.Visible = True
            .btnupdate.Visible = False

            ' Show the form as a dialog
            .ShowDialog()
        End With
    End Sub




Private Sub frmproductlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prodrecord()
        brandcombobox()
        genericcombobox()
        categorycombobox()
        formulationCombobox()
        dosageCBX()
        unitcombobox()

        With frmproduct
            .GenCbx.SelectedIndex = -1
            .BranCBx.SelectedIndex = -1
            .DosCBx.SelectedIndex = -1
            .CatCBx.SelectedIndex = -1
            .FormCBx.SelectedIndex = -1
            .unitcbx.SelectedIndex = -1
        End With

    End Sub
    Private Sub FillComboBoxFromDataGridViewColumn(comboBoxColumn As DataGridViewComboBoxColumn, columnIndex As Integer)
        ' Clear existing items in the ComboBox column
        comboBoxColumn.Items.Clear()

        ' Use a HashSet to ensure unique items
        Dim uniqueItems As New HashSet(Of String)

        ' Loop through each row in the DataGridView to add unique items
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then ' Skip the new row placeholder
                Dim value As Object = row.Cells(columnIndex).Value
                If value IsNot Nothing AndAlso Not uniqueItems.Contains(value.ToString()) Then
                    uniqueItems.Add(value.ToString())
                End If
            End If
        Next

        ' Add unique items to the ComboBox column
        comboBoxColumn.Items.AddRange(uniqueItems.ToArray())
    End Sub
    Private Sub SetComboBoxSelection(cbx As ComboBox, value As String)
        For Each item As Object In cbx.Items
            If item.ToString() = value Then
                cbx.SelectedItem = item
                Exit Sub
            End If
        Next
        cbx.SelectedIndex = -1 ' Clear selection if not found
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex < 0 Then Return

        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "View" Then
            ' View logic here
            MessageBox.Show("View logic not implemented yet.")

        ElseIf colname = "Edit" Then
            With frmproduct
                .lblid.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
                .txtbarcode.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
                .itemdes.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()

                ' Set ComboBox selections using helper function

                .BranCBx.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
                .GenCbx.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
                .CatCBx.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
                .FormCBx.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
                .DosCBx.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString()
                .txtreorder.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString()
                .unitcbx.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString()
                .txtprice.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString()
                ' Set button visibility
                .btnupdate.Visible = True
                .btnsave.Visible = False
                ' Retrieve image data if available
                Dim imageData As Byte() = Nothing
                If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(12).Value) Then
                    Dim bitmap As Bitmap = TryCast(DataGridView1.Rows(e.RowIndex).Cells(12).Value, Bitmap)
                    If bitmap IsNot Nothing Then
                        Using ms As New MemoryStream()
                            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                            imageData = ms.ToArray()
                        End Using
                    End If
                End If

                ' Pass the image data to frmproduct
                .SetImageData(imageData)

                ' Show the form as a dialog
                .ShowDialog()
            End With

        ElseIf colname = "Delete" Then
            ' Confirm deletion
            Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this Product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirmation = DialogResult.Yes Then
                Try
                    con.Open()
                    cmd = New SqlClient.SqlCommand("DELETE FROM tblproduct WHERE id = @ID", con)
                    cmd.Parameters.AddWithValue("@ID", DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString())
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User has been deleted successfully.", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    prodrecord() ' Refresh the table
                Catch ex As Exception
                    MessageBox.Show("Error deleting user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub DataGridView1_Leave(sender As Object, e As EventArgs) Handles DataGridView1.Leave
        '' Clear fields when leaving DataGridView1
        'With frmproduct
        '    .txtbarcode.Clear()
        '    .txtprice.Clear()
        '    .txtreorder.Clear()
        '    .itemdes.Clear()

        '    ' Clear image
        '    .PictureBox1.Image = Nothing ' Or set a default image

        '    ' Clear ComboBox selections
        '    .GenCbx.SelectedIndex = -1
        '    .BranCBx.SelectedIndex = -1
        '    .DosCBx.SelectedIndex = -1
        '    .CatCBx.SelectedIndex = -1
        '    .FormCBx.SelectedIndex = -1
        '    .unitcbx.SelectedIndex = -1

        '    ' Set button visibility
        '    .btnsave.Visible = True
        '    .btnupdate.Visible = False
        'End With
    End Sub








    Private Sub FillComboBoxFromDataGridViewColumn(comboBox As ComboBox, columnIndex As Integer)
        ' Clear existing items in the ComboBox
        comboBox.Items.Clear()

        ' Loop through each row in the DataGridView to add unique items
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim value As Object = row.Cells(columnIndex).Value
            If value IsNot Nothing AndAlso Not comboBox.Items.Contains(value.ToString()) Then
                comboBox.Items.Add(value.ToString())
            End If
        Next
        ' Set the ComboBox's selected item to the value in the current row
        Dim selectedValue As String = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(columnIndex).Value.ToString()
        If comboBox.Items.Contains(selectedValue) Then
            comboBox.SelectedItem = selectedValue
        Else
            comboBox.SelectedIndex = -1 ' If not found, reset selection
        End If
    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub
End Class





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

