Imports System.Data.SqlClient
Imports System.IO


Public Class frmproduct
    Dim imagePath As String ' To store selected photo path

    Private Sub frmproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        brandcombobox()
        genericcombobox()
        categorycombobox()
        formulationCombobox()
        dosageCBX()
        unitcombobox()

        GenCbx.SelectedIndex = -1
        BranCBx.SelectedIndex = -1
        DosCBx.SelectedIndex = -1
        CatCBx.SelectedIndex = -1
        FormCBx.SelectedIndex = -1
        unitcbx.SelectedIndex = -1



    End Sub
    '                             FOR CATEGORY 
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Sub clear()


        txtbarcode.Clear()
        txtprice.Clear()
        DosCBx.SelectedIndex = -1
        BranCBx.SelectedIndex = -1
        GenCbx.SelectedIndex = -1
        FormCBx.SelectedIndex = -1
        CatCBx.SelectedIndex = -1
        unitcbx.SelectedIndex = -1

        btnsave.Enabled = True
        btnupdate.Enabled = False
        txtbarcode.Focus()

    End Sub

    'Sub displaydeliveryprice()
    '    Try
    '        Dim totalDeliveryCost As Double = 0
    '        Dim totalprice As Double = 0

    '        con.Open()
    '        cmd = New SqlClient.SqlCommand("SELECT TOP 1 deliveryID, OrderR, SupID, daterel, Receivedby, PricePerUnit, PricePerUnit * qty AS TotalPrice, ShippingCost, TaxCost, qty, OtherCost, ShippingCost + TaxCost + OtherCost AS totalDeliveryCost, [status] FROM tbldelivery ORDER BY deliveryID DESC;", con)
    '        dr = cmd.ExecuteReader

    '        If dr.Read() Then
    '            totalDeliveryCost = Convert.ToDecimal(dr("totalDeliveryCost"))
    '            totalprice = Convert.ToDecimal(dr("TotalPrice"))
    '        End If

    '        dr.Close()
    '        cmd = Nothing
    '        con.Close()

    '        lbldivcost.Text = "Total Delivery Cost: " & totalDeliveryCost.ToString("C2") ' Display totalDeliveryCost as currency
    '        lblitemprice.Text = "Total Purchase Amount: " & totalprice.ToString("C2") ' Display totalDeliveryCost as currency

    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical)
    '    End Try
    'End Sub




    Private Function ValidateDuplicateEntry(query As String) As Boolean
        Try
            cmd = New SqlClient.SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@barcode", txtbarcode.Text.Trim()) ' Ensure the parameter is added
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Return reader.HasRows ' Return true if the barcode exists
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
            Return False
        Finally
            con.Close()
        End Try
    End Function


 
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            ' Validate numeric input for reorder level and price
            If Not IsNumeric(txtreorder.Text) OrElse Not IsNumeric(txtprice.Text) Then
                MsgBox("Please enter valid numeric values for reorder level and price.", vbExclamation)
                Return
            End If

            ' Check for empty fields using the Walanglaman function
            If Walanglaman(txtbarcode) Then Return
            If Walanglaman(itemdes) Then Return
            If Walanglaman(BranCBx) Then Return
            If Walanglaman(GenCbx) Then Return
            If Walanglaman(CatCBx) Then Return
            If Walanglaman(FormCBx) Then Return
            If Walanglaman(DosCBx) Then Return
            If Walanglaman(txtreorder) Then Return
            If Walanglaman(txtprice) Then Return
            If Walanglaman(unitcbx) Then Return

            ' Validate for duplicate barcode entries
            If ValidateDuplicateEntry("SELECT * FROM tblproduct WHERE barcode = @barcode") Then
                MsgBox("A product with this barcode already exists.", vbExclamation)
                Return
            End If

            ' Confirm save action
            If MsgBox("Are you sure you want to save this Product?", vbYesNo + vbQuestion) = MsgBoxResult.No Then Return

            ' Convert image to byte array, or set to DBNull if imagePath is empty

            Dim imageBytes As Byte() = Nothing
            If Not String.IsNullOrEmpty(imagePath) Then
                imageBytes = File.ReadAllBytes(imagePath)
            End If

            ' Insert data into the database
            con.Open()
            Dim query As String = "INSERT INTO tblproduct (barcode, item_des, bid, gid, cid, fid, did, reorder, price, imagepath, uid) VALUES (@barcode, @item_des, @bid, @gid, @cid, @fid, @did, @reorder, @price, @imagepath, @uid)"
            cmd = New SqlClient.SqlCommand(query, con)

            ' Set parameter values
            With cmd
                .Parameters.AddWithValue("@barcode", txtbarcode.Text.Trim())
                .Parameters.AddWithValue("@item_des", itemdes.Text.Trim())
                .Parameters.AddWithValue("@bid", CInt(lblbrand.Text))
                .Parameters.AddWithValue("@gid", CInt(lblgeneric.Text))
                .Parameters.AddWithValue("@cid", CInt(lblclass.Text))
                .Parameters.AddWithValue("@fid", CInt(lblformul.Text))
                .Parameters.AddWithValue("@did", CInt(lbldos.Text))
                .Parameters.AddWithValue("@reorder", CInt(txtreorder.Text))
                .Parameters.AddWithValue("@price", CDbl(txtprice.Text))


                ' Add image as BLOB or set to DBNull if no image is provided
                If imageBytes IsNot Nothing Then
                    .Parameters.Add("@imagepath", SqlDbType.VarBinary).Value = imageBytes
                Else
                    .Parameters.Add("@imagepath", SqlDbType.VarBinary).Value = DBNull.Value
                End If

                .Parameters.AddWithValue("@uid", CInt(unitid.Text))

            End With

            ' Execute the query and confirm success
            cmd.ExecuteNonQuery()
            MsgBox("Record has been successfully saved.", vbInformation)

            ' Close the connection
            con.Close()

            ' Clear form fields and dispose of the form
            clear()
            Me.Close()

            ' Refresh product list (assuming the form has a method for this)
            frmproductlist.prodrecord()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub



    '.Parameters.AddWithValue("@price", CDbl(txtprice.Text))
    '.Parameters.AddWithValue("@expdate", daterel.Value.ToString("yyyy-MM-dd"))




    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Open file dialog to select a photo
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Select a Photo"

        If openFileDialog.ShowDialog = DialogResult.OK Then
            imagePath = openFileDialog.FileName
            ' Optionally display the image in a picture box (assuming you have PictureBox1)
            PictureBox1.Image = Image.FromFile(imagePath)
        End If
    End Sub


    Public Sub SetImageData(ByVal imageData As Byte())
        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
            Try
                ' Convert byte array to Image and set it to PictureBox
                Using ms As New MemoryStream(imageData)
                    PictureBox1.Image = Image.FromStream(ms)
                End Using
            Catch ex As Exception
                ' Handle any errors (e.g., invalid image format)
                MessageBox.Show("Error loading image: " & ex.Message)
                PictureBox1.Image = Nothing ' Optional: Set default image if error occurs
            End Try
        Else
            ' If no image data is available, clear the PictureBox
            PictureBox1.Image = Nothing
        End If
    End Sub
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            If MsgBox("Are you sure you want to update this Record?", vbYesNo + vbQuestion) = vbYes Then
                Dim imageBytes As Byte() = Nothing
                If Not String.IsNullOrEmpty(imagePath) Then
                    imageBytes = File.ReadAllBytes(imagePath)
                End If

                con.Open()
                cmd = New SqlClient.SqlCommand("UPDATE tblproduct SET barcode=@barcode, item_des=@item_des, bid=@bid, gid=@gid, cid=@cid, fid=@fid, did=@did, reorder=@reorder, price=@price, imagepath=@imagepath WHERE id=@id", con)

                With cmd
                    .Parameters.AddWithValue("@barcode", txtbarcode.Text)
                    .Parameters.AddWithValue("@item_des", itemdes.Text)
                    .Parameters.AddWithValue("@bid", CInt(lblbrand.Text))
                    .Parameters.AddWithValue("@gid", CInt(lblgeneric.Text))
                    .Parameters.AddWithValue("@cid", CInt(lblclass.Text))
                    .Parameters.AddWithValue("@fid", CInt(lblformul.Text))
                    .Parameters.AddWithValue("@did", CInt(lbldos.Text))
                    .Parameters.AddWithValue("@reorder", CInt(txtreorder.Text))
                    .Parameters.AddWithValue("@price", CDbl(txtprice.Text))
                    .Parameters.AddWithValue("@id", CInt(lblid.Text))

                    ' Check if image data is provided; if not, pass DBNull
                    If imageBytes IsNot Nothing Then
                        .Parameters.Add("@imagepath", SqlDbType.VarBinary).Value = imageBytes
                    Else
                        .Parameters.Add("@imagepath", SqlDbType.VarBinary).Value = DBNull.Value
                    End If

                    ' Execute the query after all parameters have been added
                    .ExecuteNonQuery()
                End With

                MsgBox("Product has been successfully updated.", vbInformation)
                con.Close()
                clear()

                ' Refresh the product list
                With frmproductlist
                    .prodrecord() ' for REFRESH
                End With
            End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub txtqty_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the 'ding' sound
            btnsave.PerformClick() ' Simulate a click on the save button
        End If
    End Sub


    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtbarcode.TextChanged


    End Sub



    Private Sub GenCbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenCbx.SelectedIndexChanged
        If GenCbx.SelectedIndex <> -1 Then
            Try
                con.Open()
                cmd = New SqlClient.SqlCommand("Select * from tblgeneric where generic = @generic", con)
                cmd.Parameters.AddWithValue("@generic", GenCbx.SelectedItem.ToString())
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    lblgeneric.Text = dr("genericID").ToString()
                Else
                    lblgeneric.Text = String.Empty
                End If
            Catch ex As Exception
                ' Handle the exception, if needed
            Finally
                If dr IsNot Nothing Then dr.Close()
                If cmd IsNot Nothing Then cmd.Dispose() ' Dispose the command to release resources
                If con.State = ConnectionState.Open Then con.Close() ' Close the connection
            End Try
        End If
    End Sub



    Private Sub BranCBx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BranCBx.SelectedIndexChanged
        If BranCBx.SelectedIndex <> -1 Then
            Try
                con.Open()
                cmd = New SqlClient.SqlCommand("Select * from tblbrand where brand = @brand", con)
                cmd.Parameters.AddWithValue("@brand", BranCBx.SelectedItem.ToString())
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    lblbrand.Text = dr("brandID").ToString()
                Else
                    lblbrand.Text = String.Empty
                End If
            Catch ex As Exception
                ' Handle the exception, if needed
            Finally
                If dr IsNot Nothing Then dr.Close()
                If cmd IsNot Nothing Then cmd.Dispose() ' Dispose the command to release resources
                If con.State = ConnectionState.Open Then con.Close() ' Close the connection
            End Try
        End If
    End Sub


  

    Private Sub DosCBx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DosCBx.SelectedIndexChanged
        If DosCBx.SelectedIndex <> -1 Then
            Try
                con.Open()
                cmd = New SqlClient.SqlCommand("Select * from tbldosage where Dosage = @Dosage", con)
                cmd.Parameters.AddWithValue("@Dosage", DosCBx.SelectedItem.ToString())
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    lbldos.Text = dr("dosageID").ToString()
                Else
                    lbldos.Text = String.Empty
                End If
            Catch ex As Exception
                ' Handle the exception, if needed
            Finally
                If dr IsNot Nothing Then dr.Close()
                If cmd IsNot Nothing Then cmd.Dispose() ' Dispose the command to release resources
                If con.State = ConnectionState.Open Then con.Close() ' Close the connection
            End Try
        End If
    End Sub

    Private Sub CatCBx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CatCBx.SelectedIndexChanged
        If CatCBx.SelectedIndex <> -1 Then
            Try
                con.Open()
                cmd = New SqlClient.SqlCommand("Select * from tblcategory where Category = @Category", con)
                cmd.Parameters.AddWithValue("@Category", CatCBx.SelectedItem.ToString())
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    lblclass.Text = dr("catID").ToString()
                Else
                    lblclass.Text = String.Empty
                End If
            Catch ex As Exception
                ' Handle the exception, if needed
            Finally
                If dr IsNot Nothing Then dr.Close()
                If cmd IsNot Nothing Then cmd.Dispose() ' Dispose the command to release resources
                If con.State = ConnectionState.Open Then con.Close() ' Close the connection
            End Try
        End If
    End Sub

    Private Sub FormCBx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FormCBx.SelectedIndexChanged
        If FormCBx.SelectedIndex <> -1 Then
            Try
                con.Open()
                cmd = New SqlClient.SqlCommand("Select * from tblformulations where Formulations = @Formulations", con)
                cmd.Parameters.AddWithValue("@Formulations", FormCBx.SelectedItem.ToString())
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    lblformul.Text = dr("formID").ToString()
                Else
                    lblformul.Text = String.Empty
                End If
            Catch ex As Exception
                ' Handle the exception, if needed
            Finally
                If dr IsNot Nothing Then dr.Close()
                If cmd IsNot Nothing Then cmd.Dispose() ' Dispose the command to release resources
                If con.State = ConnectionState.Open Then con.Close() ' Close the connection
            End Try
        End If
    End Sub


    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub



    Private Sub unitcbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles unitcbx.SelectedIndexChanged
        If unitcbx.SelectedIndex <> -1 Then
            Try
                con.Open()
                cmd = New SqlClient.SqlCommand("Select * from tblunit where unit = @unit", con)
                cmd.Parameters.AddWithValue("@unit", unitcbx.SelectedItem.ToString())
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    unitid.Text = dr("unitID").ToString()
                Else
                    unitid.Text = String.Empty
                End If
            Catch ex As Exception
                ' Handle the exception, if needed
            Finally
                If dr IsNot Nothing Then dr.Close()
                If cmd IsNot Nothing Then cmd.Dispose() ' Dispose the command to release resources
                If con.State = ConnectionState.Open Then con.Close() ' Close the connection
            End Try
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmproduct_MenuComplete(sender As Object, e As EventArgs) Handles Me.MenuComplete

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class



''                                FOR FORMULATION

'Private Sub txtformu_TextChanged(sender As Object, e As EventArgs) Handles txtformu.TextChanged
'    txtformu.Focus()

'    con.Open()
'    cmd = New SqlClient.SqlCommand("Select * from tblformulations where Formulations like @Formulations", con)
'    cmd.Parameters.AddWithValue("@Formulations", txtformu.Text)
'    dr = cmd.ExecuteReader
'    dr.Read()
'    If dr.HasRows Then lblformul.Text = dr.Item(0).ToString Else lblformul.Text = String.Empty
'    cmd = Nothing
'    dr.Close()
'    con.Close()
'End Sub
