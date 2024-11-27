
Imports System.Data.SqlClient
Imports System.IO

Public Class frmdeliverylist



    ' Connection string
    Private connectionString As String = "Data Source=TECHQUINA\SQLEXPRESS;Initial Catalog=JimbospharmaDB;Integrated Security=True;MultipleActiveResultSets=True;"



    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Function GetBatchNo() As String
        ' A FUNCTION TO RETURN A STRING BATCH NUMBER
        Try
            ' Open the connection to the database
            Using con As New SqlConnection("Data Source=TECHQUINA\SQLEXPRESS;Initial Catalog=JimbospharmaDB;Integrated Security=True;MultipleActiveResultSets=True;")
                con.Open()

                ' Query to find the latest batch number, sorted by ID (assuming batch numbers are stored in tblDelivery)
                Using cmd As New SqlCommand("SELECT TOP 1 BatchNumber FROM tblDelivery ORDER BY DeliveryID DESC", con)
                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        ' Read the first row
                        If dr.HasRows Then
                            dr.Read()
                            Dim lastBatch As String = dr.Item("BatchNumber").ToString()
                            ' Extract the numeric part and increment it
                            Dim numericPart As Integer = CInt(lastBatch.Substring(5))
                            Return "Batch" & (numericPart + 1).ToString("D3")
                        Else
                            ' If no batch number exists, start from Batch001
                            Return "Batch001"
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' In case of an error, display the error message
            MsgBox(ex.Message, vbCritical)
            Return String.Empty
        End Try
    End Function


    Private Sub DataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub suppliercombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles suppliercombo.SelectedIndexChanged
        Dim supplierid As Integer

        If suppliercombo.SelectedIndex <> -1 Then
            Try
                con.Open()
                cmd = New SqlClient.SqlCommand("Select * from tblSupplier where CompanyName = @supplier", con)
                cmd.Parameters.AddWithValue("@supplier", suppliercombo.SelectedItem.ToString())
                supplierid = Convert.ToInt32(cmd.ExecuteScalar())

                dr = cmd.ExecuteReader
                If dr.Read() Then
                    supid.Text = dr("SupplierID").ToString()
                    supid.Text = supplierid.ToString()

                Else
                    supid.Text = String.Empty
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

    Private Sub frmdeliverylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Fetch the next batch number and assign it to the text box
            txtbatch.Text = GetBatchNo()
        Catch ex As Exception
            ' Handle any errors that occur while loading the batch number
            MsgBox("Error loading batch number: " & ex.Message, vbCritical)
        End Try


        SupplierCBXdelivery()

        ' Create the custom calendar column
        Dim expirationDateColumn As New DataGridViewCalendarColumn()
        expirationDateColumn.HeaderText = "Expiration Date"
        expirationDateColumn.Name = "ExpirationDate"

        ' Add the custom column to the DataGridView
        Guna2DataGridView1.Columns.Add(expirationDateColumn)

        Guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub



    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            ' Validate input fields
            If String.IsNullOrWhiteSpace(txtbatch.Text) Then
                MessageBox.Show("Batch Number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If suppliercombo.SelectedIndex = -1 Then
                MessageBox.Show("Please select a supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Perform database operation within a transaction
            Dim connectionString As String = "Data Source=TECHQUINA\SQLEXPRESS;Initial Catalog=JimbospharmaDB;Integrated Security=True;MultipleActiveResultSets=True;"

            Using con As New SqlConnection(connectionString)
                con.Open()
                Using transaction = con.BeginTransaction()
                    Try
                        ' Insert new delivery and retrieve the DeliveryID
                        Dim deliveryQuery As String = "INSERT INTO tblDelivery (BatchNumber, Supplier, DeliveryDate, CostPrice) OUTPUT INSERTED.DeliveryID VALUES (@BatchNumber, @Supplier, @DeliveryDate, @CostPrice)"
                        Dim deliveryID As Integer

                        Using cmd As New SqlCommand(deliveryQuery, con, transaction)
                            ' Add parameters explicitly
                            cmd.Parameters.Add("@BatchNumber", SqlDbType.VarChar).Value = txtbatch.Text.Trim()
                            cmd.Parameters.Add("@Supplier", SqlDbType.VarChar).Value = suppliercombo.Text.Trim()
                            cmd.Parameters.Add("@DeliveryDate", SqlDbType.Date).Value = ddate.Value
                            cmd.Parameters.Add("@CostPrice", SqlDbType.Decimal).Value = txtcost.Text.Trim()
                            deliveryID = Convert.ToInt32(cmd.ExecuteScalar())
                        End Using

                        ' Commit the transaction
                        transaction.Commit()

                        ' Display success message
                        lbldelid.Text = deliveryID.ToString()
                        MessageBox.Show("Delivery saved successfully! Delivery ID: " & deliveryID.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Disable inputs to prevent redundant saves
                        ToggleInputs(False)

                    Catch ex As Exception
                        ' Roll back transaction in case of error
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            ' Confirm reset action
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to reset? This will delete the current unsaved delivery record.", "Reset Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                ' Perform deletion if a DeliveryID exists
                If Not String.IsNullOrEmpty(lbldelid.Text) Then
                    DeleteRecentDelivery(lbldelid.Text)
                End If

                ' Clear all input fields and reset controls
                ResetForm()

                MessageBox.Show("Form has been reset and the current unsaved delivery record has been deleted.", "Reset Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during reset: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ResetForm()
        ' Clear input fields
        txtbatch.Text = String.Empty
        suppliercombo.SelectedIndex = -1
        ddate.Value = DateTime.Now
        lbldelid.Text = String.Empty

        ' Generate a new batch number
        txtbatch.Text = GetBatchNo()

        ' Re-enable inputs
        ToggleInputs(True)

        Guna2DataGridView1.Rows.Clear() ' This will remove all rows from the DataGridView

    End Sub

    Private Sub ToggleInputs(enabled As Boolean)
        txtbatch.Enabled = enabled
        suppliercombo.Enabled = enabled
        ddate.Enabled = enabled
        btnsave.Enabled = enabled
    End Sub

    ' Delete the most recent delivery record (associated with the current form's delivery ID)
    Private Sub DeleteRecentDelivery(currentDeliveryID As String)
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Check if the current delivery is the last one added
                Dim checkQuery As String = "SELECT TOP 1 DeliveryID FROM tblDelivery ORDER BY DeliveryID DESC"
                Dim recentID As Integer = 0

                Using cmd As New SqlCommand(checkQuery, con)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        recentID = Convert.ToInt32(result)
                    End If
                End Using

                ' Only delete if the current ID matches the most recent ID
                If recentID.ToString() = currentDeliveryID Then
                    Dim deleteQuery As String = "DELETE FROM tblDelivery WHERE DeliveryID = @DeliveryID"
                    Using cmd As New SqlCommand(deleteQuery, con)
                        cmd.Parameters.AddWithValue("@DeliveryID", currentDeliveryID)
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the delivery record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' Open browse delivery form
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Using frm As New frmbrowsedelivery
            frm.ShowDialog()
        End Using
    End Sub




    ' Toggle input controls






    Private Sub Guna2DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Guna2DataGridView1.EditingControlShowing
        Dim txtBox As TextBox = TryCast(e.Control, TextBox)

        If txtBox IsNot Nothing Then
            RemoveHandler txtBox.KeyPress, AddressOf NumericOnly_KeyPress ' Prevent multiple handlers
            If Guna2DataGridView1.CurrentCell.ColumnIndex = 6 Or Guna2DataGridView1.CurrentCell.ColumnIndex = 7 Then ' Adjust indices for Quantity and Cost Price
                AddHandler txtBox.KeyPress, AddressOf NumericOnly_KeyPress
            End If
        End If
    End Sub


    Private Sub NumericOnly_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Allow numbers, backspace, and period (decimal point)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        Dim txtBox As TextBox = CType(sender, TextBox)
        If e.KeyChar = "." AndAlso txtBox.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub



    Private Sub ValidateAndSave()
        Dim isValid As Boolean = True

        ' Loop through each row in the DataGridView
        For Each row As DataGridViewRow In Guna2DataGridView1.Rows
            If row.IsNewRow Then Continue For

            ' Validate Quantity (Column 2)
            Dim quantityCell = row.Cells(6)
            If quantityCell.Value Is Nothing OrElse String.IsNullOrWhiteSpace(quantityCell.Value.ToString()) OrElse Not IsNumeric(quantityCell.Value.ToString()) Then
                quantityCell.Style.BackColor = Color.Red
                isValid = False
            Else
                quantityCell.Style.BackColor = Color.White
            End If

            ' Validate Cost Price (Column 3)
            Dim costPriceCell = row.Cells(7)
            If costPriceCell.Value Is Nothing OrElse String.IsNullOrWhiteSpace(costPriceCell.Value.ToString()) OrElse Not IsNumeric(costPriceCell.Value.ToString()) Then
                costPriceCell.Style.BackColor = Color.Red
                isValid = False
            Else
                costPriceCell.Style.BackColor = Color.White
            End If
        Next

        ' Prompt the user based on the validation result
        If Not isValid Then
            MsgBox("Please correct the highlighted cells before saving.", vbExclamation)
        Else
            MsgBox("All rows are valid. Proceeding to save.", vbInformation)

            ' Call the save logic here
            SaveData()
        End If
    End Sub

    ' Save logic placeholder
    Private Sub SaveData()
        ' Add your code to save the data to a database or file here
        MsgBox("Data saved successfully!", vbInformation)
    End Sub



    ' Function to check if the product batch exists in the inventory
    Private Function BatchExistsInInventory(productID As Integer, expirationDate As Date) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM tblInventory WHERE id = @ProductID AND ExpirationDate = @ExpirationDate"
        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductID", productID)
                    cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate)
                    conn.Open()
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking product batch in inventory: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Function to update the inventory (quantity and batch)
    Private Sub UpdateInventory(productID As Integer, quantity As Integer, expirationDate As Date, reorderLevel As Integer)
        Try
            If BatchExistsInInventory(productID, expirationDate) Then
                ' Update quantity if the batch exists
                Dim query As String = "UPDATE tblInventory SET Quantity = Quantity + @Quantity WHERE id = @ProductID AND ExpirationDate = @ExpirationDate"
                Using conn As New SqlConnection(connectionString)
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Quantity", quantity)
                        cmd.Parameters.AddWithValue("@ProductID", productID)
                        cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate)
                        conn.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Inventory batch updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Insert new batch if it does not exist
                InsertNewBatchToInventory(productID, quantity, expirationDate, reorderLevel)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating inventory: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to insert a new batch into inventory
    Private Sub InsertNewBatchToInventory(productID As Integer, quantity As Integer, expirationDate As Date, reorderLevel As Integer)
        Try
            Dim query As String = "INSERT INTO tblInventory (id, Quantity, ExpirationDate, ReorderLevel) VALUES (@ProductID, @Quantity, @ExpirationDate, @ReorderLevel)"
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductID", productID)
                    cmd.Parameters.AddWithValue("@Quantity", quantity)
                    cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate)
                    cmd.Parameters.AddWithValue("@ReorderLevel", reorderLevel)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("New batch added to inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error adding new batch to inventory: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to save delivery line item details
    Private Sub SaveDeliveryLineItem(deliveryID As Integer, productID As Integer, productName As String, quantity As Integer, costPrice As Decimal, supplierID As Integer, expirationDate As Date, reorderLevel As Integer)
        Try
            ' Insert delivery line item
            Dim query As String = "INSERT INTO tblDeliveryLineItem (DeliveryID, id, ProductName, Quantity, CostPrice, SupplierID, ExpirationDate) VALUES (@DeliveryID, @ProductID, @ProductName, @Quantity, @CostPrice, @SupplierID, @ExpirationDate)"
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@DeliveryID", deliveryID)
                    cmd.Parameters.AddWithValue("@ProductID", productID)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    cmd.Parameters.AddWithValue("@Quantity", quantity)
                    cmd.Parameters.AddWithValue("@CostPrice", costPrice)
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID)
                    cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Delivery line item saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Update inventory after saving delivery
            UpdateInventory(productID, quantity, expirationDate, reorderLevel)
        Catch ex As Exception
            MessageBox.Show("Error saving delivery line item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnsavinginvent_Click(sender As Object, e As EventArgs) Handles btnsavinginvent.Click
        Try
            ' Declare the variable once at the start of the method.
            Dim totalLineItemsCost As Decimal = 0
            Dim quantity As Integer ' Declare this variable once outside the loop
            Dim costPrice As Decimal ' Use Decimal for costPrice instead of Integer

            ' Calculate the total cost from the Delivery Line Items
            For Each row As DataGridViewRow In Guna2DataGridView1.Rows
                If Not row.IsNewRow Then
                    ' Validate quantity and cost price for each row
                    If row.Cells("Quantity").Value Is Nothing OrElse row.Cells("CostPrice").Value Is Nothing Then
                        MessageBox.Show("Quantity and Cost Price are required for all line items.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    ' Use the already declared 'quantity' variable here
                    quantity = Convert.ToInt32(row.Cells("Quantity").Value)

                    ' Parse the cost price correctly, remove non-numeric characters before converting
                    Dim rowCostPrice As String = row.Cells("CostPrice").Value.ToString().Replace("₱", "").Trim()
                    If Not Decimal.TryParse(rowCostPrice, costPrice) Then
                        MessageBox.Show("Invalid cost price format in the line item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    ' Calculate total for each product
                    totalLineItemsCost += quantity * costPrice
                End If
            Next

            ' Now handle the delivery cost price and remove the Peso sign
            Dim deliveryCostPrice As Decimal
            Dim currentText As String = txtcost.Text.Replace("₱", "").Trim() ' Remove the Peso sign from text

            ' Try to parse the cleaned string into a decimal
            If Not Decimal.TryParse(currentText, deliveryCostPrice) Then
                MessageBox.Show("Invalid cost price format in the Delivery section.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Validate if the total line item cost matches the delivery cost
            If totalLineItemsCost <> deliveryCostPrice Then
                MessageBox.Show("The total cost of items (" & totalLineItemsCost.ToString("₱0.00") & ") does not match the Delivery Cost Price (" & deliveryCostPrice.ToString("₱0.00") & ").", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Validate required fields before saving
            If String.IsNullOrEmpty(lbldelid.Text) Then
                MessageBox.Show("Delivery ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                lbldelid.Focus()
                Exit Sub
            End If

            If String.IsNullOrEmpty(supid.Text) Then
                MessageBox.Show("Supplier ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                supid.Focus()
                Exit Sub
            End If

            ' Ensure at least one row is selected in the DataGridView
            If Guna2DataGridView1.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a product row from the data grid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Extract details from the selected row
            Dim selectedRow = Guna2DataGridView1.SelectedRows(0)

            ' Validate required columns in the DataGridView for the selected row
            If Not ValidateGridCell(selectedRow, "ProductID") OrElse
               Not ValidateGridCell(selectedRow, "ProductNamecolumn") OrElse
               Not ValidateGridCell(selectedRow, "Quantity") OrElse
               Not ValidateGridCell(selectedRow, "CostPrice") OrElse
               Not ValidateGridCell(selectedRow, "Reorder") OrElse
               Not ValidateGridCell(selectedRow, "ExpirationDate") Then
                Exit Sub
            End If

            ' Parse the validated data
            Dim deliveryID As Integer = Integer.Parse(lbldelid.Text)
            Dim productID As Integer = Integer.Parse(selectedRow.Cells("ProductID").Value.ToString())
            Dim productName As String = selectedRow.Cells("ProductNamecolumn").Value.ToString()
            quantity = Integer.Parse(selectedRow.Cells("Quantity").Value.ToString()) ' Use the same 'quantity' here
            costPrice = Decimal.Parse(selectedRow.Cells("CostPrice").Value.ToString()) ' Correct the type to Decimal
            Dim reorderLevel As Integer = Integer.Parse(selectedRow.Cells("Reorder").Value.ToString())
            Dim expirationDate As Date = Date.Parse(selectedRow.Cells("ExpirationDate").Value.ToString())
            Dim supplierID As Integer = Integer.Parse(supid.Text)

            ' Save the delivery and update the inventory
            SaveDeliveryLineItem(deliveryID, productID, productName, quantity, costPrice, supplierID, expirationDate, reorderLevel)
            UpdateInventory(productID, quantity, expirationDate, reorderLevel)
            ' Optionally, refresh the inventory list
            ' inventorylist()

            MessageBox.Show("Delivery and inventory updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function ValidateGridCell(row As DataGridViewRow, columnName As String) As Boolean
        If row.Cells(columnName).Value Is Nothing OrElse String.IsNullOrEmpty(row.Cells(columnName).Value.ToString()) Then
            MessageBox.Show("Please fill in the " & columnName & " for all line items.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function





    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub
    'Sub inventorylist()
    '    Guna2DataGridView3.Rows.Clear()
    '    Dim i As Integer = 0

    '    Try
    '        ' Ensure the connection is closed before opening
    '        If con.State = ConnectionState.Open Then
    '            con.Close()
    '        End If
    '        con.Open()
    '        cmd = New SqlCommand("select * from tblInventory as iv inner join tblproduct as p on iv.id = p.id ", con)
    '        dr = cmd.ExecuteReader

    '        While dr.Read
    '            i += 1

    '            '' Combine FirstName, MiddleName, and LastName to form FullName
    '            'Dim fullName As String = String.Format("{0} {1} {2}", dr("FirstName").ToString(), dr("MiddleName").ToString(), dr("LastName").ToString()).Trim()

    '            ' Retrieve and convert the ImageSpl column
    '            Dim img As Image = Nothing
    '            If Not IsDBNull(dr("imagepath")) Then
    '                Dim imgData As Byte() = DirectCast(dr("imagepath"), Byte())
    '                img = ByteArrayToImage(imgData)
    '            Else
    '                ' Optional: Set a placeholder image if ImageSpl is NULL
    '                img = My.Resources.eye_close_up ' Ensure this resource exists, or replace it
    '            End If

    '            ' Add row with FullName and other fields, including img
    '            Guna2DataGridView3.Rows.Add(dr("InventoryID").ToString(), i, dr("id").ToString(), img, dr("barcode").ToString(), dr("item_des").ToString(), dr("Quantity").ToString(), dr("ExpirationDate").ToString(), dr("price").ToString())
    '        End While

    '        dr.Close()

    '        ' Set row height
    '        For i = 0 To Guna2DataGridView3.Rows.Count - 1
    '            Dim r As DataGridViewRow = Guna2DataGridView3.Rows(i)
    '            r.Height = 75
    '        Next

    '        ' Set image layout for the image column
    '        Dim imageColumn = DirectCast(Guna2DataGridView3.Columns("image"), DataGridViewImageColumn)
    '        imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

    '    Catch ex As Exception
    '        MessageBox.Show("Error loading user list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        con.Close()
    '    End Try
    'End Sub

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
    Private Sub Guna2DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    'Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
    '    If e.RowIndex >= 0 Then
    '        ' Assuming "Quantity" is in the third column (index 2)
    '        ' Create the custom calendar column
    '        Dim expirationDateColumn As New DataGridViewCalendarColumn()
    '        expirationDateColumn.HeaderText = "Expiration Date"
    '        expirationDateColumn.Name = "ExpirationDate"

    '        ' Add the custom column to the DataGridView
    '        Guna2DataGridView1.Columns.Add(expirationDateColumn)

    '        Guna2DataGridView1.CurrentCell = Guna2DataGridView1.Rows(e.RowIndex).Cells("Quantity")
    '        Guna2DataGridView1.BeginEdit(True) ' Start editing to focus
    '    End If
    'End Sub



    '                                                               CUSTOMIZING DATAGRID AND TEXTBOX
    Private Sub Guna2DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Guna2DataGridView1.CellFormatting
        ' Check if the column is "Cost Price" and format accordingly
        If Guna2DataGridView1.Columns(e.ColumnIndex).Name = "CostPrice" AndAlso e.Value IsNot Nothing Then
            ' Format with ₱ symbol if not already formatted
            Dim costValue As Decimal
            If Decimal.TryParse(e.Value.ToString(), costValue) Then
                e.Value = "₱" & costValue.ToString("N2") ' Format to currency with 2 decimal places
                e.FormattingApplied = True
            End If
        End If
    End Sub

    Private Sub Guna2DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2DataGridView1.KeyDown
        ' Check if Enter key was pressed
        If e.KeyCode = Keys.Enter Then
            ' Prevent the Enter key from moving to the next row
            e.SuppressKeyPress = True

            ' Get the current cell
            Dim currentCell As DataGridViewCell = Guna2DataGridView1.CurrentCell
            If currentCell IsNot Nothing Then
                Dim nextColumnIndex As Integer = currentCell.ColumnIndex + 1
                Dim currentRowIndex As Integer = currentCell.RowIndex

                ' Move to the next cell in the same row
                If nextColumnIndex < Guna2DataGridView1.ColumnCount Then
                    Guna2DataGridView1.CurrentCell = Guna2DataGridView1.Rows(currentRowIndex).Cells(nextColumnIndex)
                Else
                    ' If it's the last column, move to the first column of the next row
                    If currentRowIndex + 1 < Guna2DataGridView1.RowCount Then
                        Guna2DataGridView1.CurrentCell = Guna2DataGridView1.Rows(currentRowIndex + 1).Cells(0)
                    End If
                End If

                ' Begin editing the new cell
                Guna2DataGridView1.BeginEdit(True)
            End If
        End If
    End Sub

    Private Sub Guna2DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellEnter
        ' Ensure the row index is greater than 0 and that we're in the "Expiration Date" column
        If e.RowIndex > 0 AndAlso Guna2DataGridView1.Columns(e.ColumnIndex).Name = "ExpirationDate" Then
            ' Start editing the cell to show the calendar
            Guna2DataGridView1.BeginEdit(True)
        End If
    End Sub

    Private Sub Guna2DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles Guna2DataGridView1.CellBeginEdit
        ' Check if we are in the "Expiration Date" column
        If e.RowIndex > 0 AndAlso Guna2DataGridView1.Columns(e.ColumnIndex).Name = "ExpirationDate" Then

            ' Optionally set a default value if the cell is empty
            If Guna2DataGridView1(e.ColumnIndex, e.RowIndex).Value Is Nothing OrElse Guna2DataGridView1(e.ColumnIndex, e.RowIndex).Value Is DBNull.Value Then
                Guna2DataGridView1(e.ColumnIndex, e.RowIndex).Value = DateTime.Now
            End If
        End If
    End Sub



    'Private Sub txtcost_TextChanged(sender As Object, e As EventArgs) Handles txtcost.TextChanged
    '    Dim currentText As String = txtcost.Text.Replace("₱", "").Trim()

    '    If Not String.IsNullOrEmpty(currentText) Then
    '        ' Re-add the Peso sign while maintaining cursor position
    '        txtcost.Text = "₱" & currentText
    '        txtcost.SelectionStart = txtcost.Text.Length
    '    End If
    'End Sub

    Private Sub Guna2DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2DataGridView1.KeyPress
        ' Allow only digits, the backspace, and the period for decimal values.
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        ' Only allow one decimal point
        If e.KeyChar = "." AndAlso txtcost.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
End Class