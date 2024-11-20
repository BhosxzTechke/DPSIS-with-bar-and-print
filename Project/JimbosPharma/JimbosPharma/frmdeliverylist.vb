
Imports System.Data.SqlClient

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

        ' Load Supplier data into ComboBox (if applicable)
        SupplierCBXdelivery()

        ' Create the custom calendar column
        Dim expirationDateColumn As New DataGridViewCalendarColumn()
        expirationDateColumn.HeaderText = "Expiration Date"
        expirationDateColumn.Name = "ExpirationDate"

        ' Add the custom column to the DataGridView
        Guna2DataGridView1.Columns.Add(expirationDateColumn)
    End Sub









    Private Sub txtbatch_TextChanged(sender As Object, e As EventArgs) Handles txtbatch.TextChanged

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
    End Sub

    ' Toggle input controls
    Private Sub ToggleInputs(enabled As Boolean)
        txtbatch.Enabled = enabled
        suppliercombo.Enabled = enabled
        ddate.Enabled = enabled
        btnsave.Enabled = enabled
    End Sub



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

    ' Button click event to save delivery and update inventory
    Private Sub btnsavinginvent_Click(sender As Object, e As EventArgs) Handles btnsavinginvent.Click
        Try
            ' Validate required inputs
            If String.IsNullOrEmpty(lbldelid.Text) Then
                MessageBox.Show("Delivery ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Guna2DataGridView1.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a product row from the data grid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If String.IsNullOrEmpty(supid.Text) Then
                MessageBox.Show("Supplier ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Extract details from the selected row
            Dim deliveryID As Integer = Integer.Parse(lbldelid.Text)
            Dim productID As Integer = Integer.Parse(Guna2DataGridView1.SelectedRows(0).Cells("ProductID").Value.ToString())
            Dim productName As String = Guna2DataGridView1.SelectedRows(0).Cells("ProductNamecolumn").Value.ToString()
            Dim quantity As Integer = Integer.Parse(Guna2DataGridView1.SelectedRows(0).Cells("Quantity").Value.ToString())
            Dim costPrice As Decimal = Decimal.Parse(Guna2DataGridView1.SelectedRows(0).Cells("CostPrice").Value.ToString())
            Dim reorderLevel As Integer = Integer.Parse(Guna2DataGridView1.SelectedRows(0).Cells("Reorder").Value.ToString())
            Dim expirationDate As Date = Date.Parse(Guna2DataGridView1.SelectedRows(0).Cells("ExpirationDate").Value.ToString())
            Dim supplierID As Integer = Integer.Parse(supid.Text)

            ' Save delivery and update inventory
            SaveDeliveryLineItem(deliveryID, productID, productName, quantity, costPrice, supplierID, expirationDate, reorderLevel)
            UpdateInventory(productID, quantity, expirationDate, reorderLevel)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub
End Class