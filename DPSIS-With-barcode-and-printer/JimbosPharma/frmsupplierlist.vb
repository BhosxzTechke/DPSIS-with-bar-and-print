
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing

Public Class frmsupplierlist

    ' Helper function to convert byte array to Image and resize it
    Private Function ByteArrayToImage(ByVal byteArray As Byte()) As Image
        ' Check if byteArray is valid and has data
        If byteArray Is Nothing OrElse byteArray.Length = 0 Then
            Return Nothing
        End If

    Try
            Using ms As New MemoryStream(byteArray)
                Dim originalImage As Image = Image.FromStream(ms)

                ' Resize the image to specific dimensions, e.g., 100x100 pixels
                Dim resizedImage As New Bitmap(100, 130) ' Adjust the width and height as needed
                Using g As Graphics = Graphics.FromImage(resizedImage)
                    g.DrawImage(originalImage, 0, 0, 100, 100) ' Draw the image at specified size
                End Using

                Return resizedImage
            End Using
        Catch ex As ArgumentException
            ' Handle invalid image format
            Return Nothing
        End Try
    End Function

    Sub LoadUserList()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()

        Try
            ' Ensure the connection is closed before opening
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            ' Open the connection and execute the query
            con.Open()

            Using cmd As New SqlCommand("Select * from tblSupplier order by CompanyName", con)
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        i += 1

                        ' Retrieve and convert the ImageSpl column
                        Dim img As Image = Nothing
                        If Not IsDBNull(dr("ImageSpl")) Then
                            Dim imgData As Byte() = DirectCast(dr("ImageSpl"), Byte())
                            img = ByteArrayToImage(imgData)
                        Else
                            ' Optional: Set a placeholder image if ImageSpl is NULL
                            img = My.Resources.eye_close_up ' Use your own placeholder image here
                        End If

                        ' Add row to DataGridView
                        DataGridView1.Rows.Add(
                            dr("SupplierID").ToString(),
                            i,
                            dr("CompanyName").ToString(),
                            dr("Address").ToString(),
                            img,
                            dr("Contact_Person").ToString(),
                            dr("Mobile_no").ToString(),
                            dr("Tel_no").ToString()
                        )
                    End While
                End Using
            End Using

            ' Update record count label
            rc1.Text = " Record Found.(" & DataGridView1.RowCount & ") "

        Catch ex As Exception
            MsgBox("Error loading supplier list: " & ex.Message, vbCritical)
        Finally
            ' Close the connection in case it's still open
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


Private Sub frmsupplierlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserList()
End Sub

' Create a new supplier
Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
    With frmmodifsupplier
            .btnupdate.Visible = False
            .btnsave.Visible = True
        .ShowDialog()
    End With
End Sub



   
Private Sub datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Prevent processing if the header row is clicked
        If e.RowIndex < 0 Then Return

        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "View" Then
            ' View logic here
            MessageBox.Show("View logic not implemented yet.")

        ElseIf colname = "Edit" Then
            ' Populate the frmmodifsupplier form with retrieved data from the DataGridView
            With frmmodifsupplier
                .lblid.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
                .txtcompany.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
                .txtaddress.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
                .txtcontact.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
                .txtmob.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
                .txttel.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
                .btnupdate.Visible = True
                .btnsave.Visible = False



                Dim imageData As Byte() = Nothing
                If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(4).Value) Then
                    Dim bitmap As Bitmap = TryCast(DataGridView1.Rows(e.RowIndex).Cells(4).Value, Bitmap)
                    If bitmap IsNot Nothing Then
                        Using ms As New MemoryStream()
                            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png) ' You can also use other formats like .Jpeg
                            imageData = ms.ToArray()
                        End Using
                    End If
                End If

                ' Pass the image data to the frmmodifsupplier form
                frmmodifsupplier.SetImageData(imageData)

                ' Show the modification form as a dialog
                .ShowDialog()
            End With
        ElseIf colname = "Delete" Then
            If (MsgBox("Are you sure you want to delete this record", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                cmd = New SqlClient.SqlCommand("delete from tblSupplier where SupplierID =" & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString(), con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                LoadUserList()
            End If
        End If
    End Sub


    Private Sub DataGridView1_Leave(sender As Object, e As EventArgs) Handles DataGridView1.Leave


        With frmmodifsupplier
            .txtcompany.Clear()
            .txtaddress.Clear()
            .txtmob.Clear()
            .txttel.Clear()
            .PictureBox1.Image = Nothing ' Or set a default image
            .txtcontact.Clear()
            .btnsave.Visible = True
            .btnupdate.Visible = False
        End With


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class







'Private Sub Guna2DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
'    ' Check if the clicked row is valid (ignores header row clicks)
'    If e.RowIndex < 0 Then Return

'    ' Get the column name where the click occurred
'    Dim colname As String = Guna2DataGridView1.Columns(e.ColumnIndex).Name

'    ' Check if the clicked column is "Edit" or "Delete"
'    If colname = "Action" Then
'        ' Store the row index in the ContextMenuStrip's Tag for later use
'        Guna2ContextMenuStrip1.Tag = e.RowIndex

'        ' Show the context menu at the mouse position
'        Dim mousePosition As Point = Guna2DataGridView1.PointToClient(Cursor.Position)
'        Guna2ContextMenuStrip1.Show(Guna2DataGridView1, mousePosition)
'    End If
'End Sub

'Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
'    ' Get the row index from the ContextMenuStrip's Tag property
'    If Guna2ContextMenuStrip1.Tag IsNot Nothing Then
'        Dim rowIndex As Integer = CType(Guna2ContextMenuStrip1.Tag, Integer)

'        ' Confirm delete operation
'        If MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
'            con.Open()
'            Dim cmd As New SqlCommand("DELETE FROM tblSupplier WHERE SupplierID = @SupplierID", con)
'            cmd.Parameters.AddWithValue("@SupplierID", Guna2DataGridView1.Rows(rowIndex).Cells(0).Value.ToString())
'            cmd.ExecuteNonQuery()
'            con.Close()

'            ' Notify user
'            MessageBox.Show("Record has been successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            supplierrecord() ' Refresh grid or view
'        End If
'    End If
'End Sub
