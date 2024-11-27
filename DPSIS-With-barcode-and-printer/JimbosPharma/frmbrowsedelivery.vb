Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing

Public Class frmbrowsedelivery
    Private DeliveryID As Integer

    ' Constructor to initialize the form with the delivery ID
    'Public Sub New(deliveryId As Integer)
    '    InitializeComponent()
    '    Me.DeliveryID = deliveryId
    'End Sub

    ' Method to load products into the DataGridView
    Sub browseprod()
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
            Dim query As String = "SELECT p.id, p.barcode, p.item_des, b.brand, g.generic, c.Category, f.Formulations, d.Dosage, p.price, u.unit, p.imagepath " &
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
                        img = ByteArrayToImages(DirectCast(imageData, Byte()))
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
                DataGridView1.Rows.Add(i, dr("id").ToString(), img, dr("barcode").ToString(), dr("item_des").ToString(), dr("brand").ToString(), dr("generic").ToString(), dr("Category").ToString(), dr("Formulations").ToString(), dr("Dosage").ToString(), dr("unit").ToString())
            End While


        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)

        Finally
            ' Close reader and connection
            If dr IsNot Nothing Then dr.Close()
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    ' Form load event to load products
    Private Sub frmbrowsedelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        browseprod()
    End Sub


    Private Function ByteArrayToImages(ByVal byteArray As Byte()) As Image
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


Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

            If colname = "colselect" Then
                ' Extract the data from the selected row
                Dim itemId As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString() ' Assume ID is in Cell(0)
                Dim data As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                Dim arr() As String = data.Split("|")

                ' Confirmation prompt
                If MsgBox("Item Description: " & arr(0).ToString & vbCrLf &
                          "Please confirm.", vbYesNo + vbQuestion) = vbYes Then

                    ' Check if the target form is already open
                    Dim targetForm As frmdeliverylist = Nothing

                    For Each frm As Form In Application.OpenForms
                        If TypeOf frm Is frmdeliverylist Then
                            targetForm = CType(frm, frmdeliverylist)
                            Exit For
                        End If
                    Next

                    ' If the form is not open, create a new instance
                    If targetForm Is Nothing Then
                        targetForm = New frmdeliverylist()
                        targetForm.Show()
                    End If

                    ' Check for duplicate ID in the target DataGridView
                    Dim isDuplicate As Boolean = False
                    For Each row As DataGridViewRow In targetForm.Guna2DataGridView1.Rows
                        If row.Cells(3).Value IsNot Nothing AndAlso row.Cells(3).Value.ToString() = itemId Then
                            isDuplicate = True
                            Exit For
                        End If
                    Next

                    If isDuplicate Then
                        MsgBox("This item is already in the list.", vbExclamation)
                    Else
                        ' Add row data to specific columns in the target form's DataGridView
                        Dim newRowIndex As Integer = targetForm.Guna2DataGridView1.Rows.Add()
                        With targetForm.Guna2DataGridView1.Rows(newRowIndex)
                            .Cells(3).Value = itemId ' Add to column 4 (zero-based index) 
                            .Cells(4).Value = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString() ' Barcode
                            .Cells(5).Value = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString() ' Item Description

                        End With
                    End If

                    ' Optionally close the current form (only if needed)
                    'Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, vbCritical)
        End Try
    End Sub






    'Sub prodrecord()
    '    Dim i As Integer = 0
    '    DataGridView1.Rows.Clear()

    '    Try
    '        ' Ensure the connection is closed before opening
    '        If con.State = ConnectionState.Open Then
    '            con.Close()
    '        End If

    '        ' Open connection
    '        con.Open()

    '        ' Define the query to fetch product records with INNER JOIN on related tables, excluding the Type column
    '        Dim query As String = "SELECT p.id, p.barcode, p.item_des, b.brand, g.generic, c.Category, f.Formulations, d.Dosage, p.reorder, p.price, u.unit, p.imagepath " &
    '                              "FROM tblproduct AS p " &
    '                              "INNER JOIN tblbrand AS b ON p.bid = b.brandID " &
    '                              "INNER JOIN tblcategory AS c ON p.cid = c.catID " &
    '                              "INNER JOIN tblformulations AS f ON p.fid = f.formID " &
    '                              "INNER JOIN tbldosage AS d ON p.did = d.dosageID " &
    '                              "INNER JOIN tblgeneric AS g ON p.gid = g.genericID " &
    '                              "INNER JOIN tblunit AS u ON p.uid = u.unitID"

    '        ' Create and execute the command
    '        cmd = New SqlClient.SqlCommand(query, con)
    '        dr = cmd.ExecuteReader()

    '        ' Loop through data and populate DataGridView
    '        While dr.Read()
    '            i += 1

    '            ' Check if the image is stored as binary data or a file path
    '            Dim img As Image = Nothing
    '            If Not IsDBNull(dr("imagepath")) Then
    '                Dim imageData As Object = dr("imagepath")

    '                If TypeOf imageData Is Byte() Then
    '                    ' Convert binary data to image
    '                    img = ByteArrayToImage(DirectCast(imageData, Byte()))
    '                ElseIf TypeOf imageData Is String AndAlso Not String.IsNullOrEmpty(imageData.ToString()) Then
    '                    ' Load image from file path if it exists
    '                    Dim imgPath As String = imageData.ToString()
    '                    If IO.File.Exists(imgPath) Then
    '                        img = Image.FromFile(imgPath)
    '                    Else
    '                        img = My.Resources.eye_close_up ' Placeholder image if file is missing
    '                    End If
    '                End If
    '            Else
    '                ' Placeholder image if imagepath is NULL
    '                img = My.Resources.eye_close_up
    '            End If

    '            ' Add data to DataGridView
    '            DataGridView1.Rows.Add(i, dr("id").ToString(), dr("barcode").ToString(), dr("item_des").ToString(), dr("brand").ToString(), dr("generic").ToString(), dr("Category").ToString(), dr("Formulations").ToString(), dr("Dosage").ToString(), dr("reorder").ToString(), dr("unit").ToString(), dr("price").ToString(), img)
    '        End While

    '    Catch ex As Exception
    '        MsgBox("Error: " & ex.Message, vbCritical)

    '    Finally
    '        ' Close reader and connection
    '        If dr IsNot Nothing Then dr.Close()
    '        If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then con.Close()
    '    End Try
    'End Sub

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

    'Sub searchproduct(ByVal search As String)
    '    Try
    '        If search = String.Empty Then Return
    '        con.Open()

    '        cmd = New SqlClient.SqlCommand("SELECT * FROM tblproduct WHERE id LIKE '" & search & "'", con)
    '        dr = cmd.ExecuteReader
    '        dr.Read()
    '        If dr.HasRows Then

    '            ' so kapag pinindut ung nasa datagridview pupunta sa form na qty

    '            With frmproddelivery

    '                ' Load image if available
    '                If Not IsDBNull(dr("imagepath")) Then
    '                    Dim imgData As Byte() = DirectCast(dr("imagepath"), Byte())
    '                    Dim img As Image = ByteArrayToImage(imgData)
    '                    .Guna2CirclePictureBox1.Image = img
    '                Else
    '                    .Guna2CirclePictureBox1.Image = My.Resources.eye_close_up ' Default or placeholder image
    '                End If
    '                .lblPid.Text = dr.Item("id").ToString        '  INSERTING A VALUE ID FOR LABEL PROD 

    '                dr.Close()
    '                con.Close()
    '                .ShowDialog() '           SHOWING A DIALOG FORM FOR QTY
    '            End With
    '            ' Show your form or perform other actions here
    '        End If
    '        dr.Close()
    '        con.Close()

    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical)
    '    Finally
    '        If con.State = ConnectionState.Open Then
    '            con.Close()
    '        End If
    ''    End Try
    'End Sub

    'Sub browseproduct()
    '    ' Validate filter and search input
    '    If String.IsNullOrWhiteSpace(cbofilter.Text) OrElse String.IsNullOrWhiteSpace(txtsearch.Text) Then
    '        Return
    '    End If

    '    Try
    '        Dim i As Integer = 0
    '        DataGridView1.Rows.Clear()

    '        con.Open()

    '        ' Use parameterized query to prevent SQL injection
    '        Dim query As String = "SELECT * FROM tblproduct AS p " &
    '                              "INNER JOIN tblbrand AS b ON p.bid = b.brandID " &
    '                              "INNER JOIN tblcategory AS c ON p.cid = c.catID " &
    '                              "INNER JOIN tblformulations AS f ON p.fid = f.formID " &
    '                              "INNER JOIN tblgeneric AS g ON p.gid = g.genericID " &
    '                              "INNER JOIN tbldosage AS ds ON p.did = ds.dosageID " &
    '                              "INNER JOIN tblunit AS u ON p.uid = u.unitID " &
    '                              "WHERE " & cbofilter.Text & " LIKE @search"

    '        cmd = New SqlClient.SqlCommand(query, con)
    '        cmd.Parameters.AddWithValue("@search", txtsearch.Text & "%")

    '        dr = cmd.ExecuteReader()

    '        While dr.Read()
    '            i += 1
    '            Dim img As Image = Nothing

    '            ' Handle image loading
    '            If Not IsDBNull(dr("imagepath")) Then
    '                Dim imageData As Object = dr("imagepath")

    '                If TypeOf imageData Is Byte() Then
    '                    ' Convert binary data to image
    '                    img = ByteArrayToImage(DirectCast(imageData, Byte()))
    '                ElseIf TypeOf imageData Is String AndAlso Not String.IsNullOrWhiteSpace(imageData.ToString()) Then
    '                    Dim imgPath As String = imageData.ToString()
    '                    If IO.File.Exists(imgPath) Then
    '                        img = Image.FromFile(imgPath)
    '                    Else
    '                        img = My.Resources.eye_close_up ' Placeholder image
    '                    End If
    '                End If
    '            Else
    '                img = My.Resources.eye_close_up ' Placeholder image
    '            End If

    '            ' Concatenate strings for the DataGridView row
    '            Dim productDetails As String = dr("brand").ToString() & " | " & dr("generic").ToString() & " | " &
    '                                           dr("Category").ToString() & " | " & dr("dosage").ToString() & " | " &
    '                                           dr("Formulations").ToString() & " | " & dr("unit").ToString()

    '            ' Add data to DataGridView
    '            DataGridView1.Rows.Add(i, dr("id").ToString(), dr("barcode").ToString(), productDetails, img)
    '        End While

    '    Catch ex As Exception
    '        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        ' Ensure resources are released
    '        If dr IsNot Nothing AndAlso Not dr.IsClosed Then
    '            dr.Close()
    '        End If
    '        If con.State = ConnectionState.Open Then
    '            con.Close()
    '        End If
    '    End Try
    'End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub cbofilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbofilter.KeyPress
        ' Prevent typing in the filter ComboBox
        e.Handled = True
    End Sub











    'Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
    'Dim data As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
    'Dim arr() As String = data.Split("|")

    'If colname = "Colselect" Then
    '    '#1
    '    If MsgBox("brand:  " & arr(0).ToString & vbCr &
    '              "Generic: " & arr(1).ToString & vbCr &
    '              "Category: " & arr(2).ToString & vbCr &
    '              "unit: " & arr(3).ToString & vbCr &
    '              "Formulations: " & arr(4).ToString & vbCr &
    '             "Dosage: " & arr(5).ToString & vbCr & "Please confirm. ", vbYesNo + vbQuestion) = vbYes Then

    '        With frmdeliverylist
    '            DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, .DataView.Rows(e.RowIndex).Cells(1).Value.ToString, .DataView.Rows(e.RowIndex).Cells(2).Value.ToString, arr(0).ToString, arr(1).ToString, arr(2).ToString, arr(3).ToString, arr(4).ToString, arr(5).ToString)

    '        End With
    '    End If

    'End If


    Private Sub cbofilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofilter.SelectedIndexChanged

    End Sub
    'Private Sub LoadProducts()
    '    Dim query As String = "SELECT ProductID, Barcode, Brand + ' - ' + GenericName AS ProductName FROM tblProduct"
    '    Dim dt As New DataTable()

    '    con.Open()
    '    Using cmd As New SqlCommand(query, con)
    '        Using da As New SqlDataAdapter(cmd)
    '            da.Fill(dt)
    '        End Using
    '    End Using

    '    DataGridView1.DataSource = dt
    'End Sub
    'Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    '    Dim connectionString As String = "YourConnectionStringHere"
    '    Dim lineItemQuery As String = "INSERT INTO tblDeliveryLineItem (DeliveryID, ProductID, Quantity, CostPrice) VALUES (@DeliveryID, @ProductID, @Quantity, @CostPrice)"
    '    Dim updateInventoryQuery As String = "UPDATE tblInventory SET Quantity = Quantity + @Quantity WHERE ProductID = @ProductID"

    '    For Each row As DataGridViewRow In DataGridView1.SelectedRows
    '        con.Open()

    '        ' Insert line item
    '        Using cmd As New SqlCommand(lineItemQuery, con)
    '            cmd.Parameters.AddWithValue("@DeliveryID", DeliveryID)
    '            cmd.Parameters.AddWithValue("@ProductID", row.Cells("ProductID").Value)
    '            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells("Quantity").Value))
    '            cmd.Parameters.AddWithValue("@CostPrice", Convert.ToDecimal(row.Cells("CostPrice").Value))
    '            cmd.ExecuteNonQuery()
    '        End Using

    '        ' Update inventory
    '        Using cmd As New SqlCommand(updateInventoryQuery, con)
    '            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells("Quantity").Value))
    '            cmd.Parameters.AddWithValue("@ProductID", row.Cells("ProductID").Value)
    '            cmd.ExecuteNonQuery()
    '        End Using
    '    Next

    '    MessageBox.Show("Products added to delivery successfully!")

    Private Sub frmbrowsedelivery_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                With frmdeliverylist

                End With
                Me.Dispose()
        End Select
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()

    End Sub
End Class