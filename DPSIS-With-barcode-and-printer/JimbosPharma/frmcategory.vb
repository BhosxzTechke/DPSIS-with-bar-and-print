
Public Class frmcategory

    Private Sub btncancel_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Sub clear()
        txtcategory.Clear()
        btnsave.Enabled = True
        btnupdate.Enabled = False


    End Sub
    Private Function ValidateDuplicateEntry(query As String, value As String) As Boolean
        Using cmd As New SqlClient.SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Category", value)
            con.Open()
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            con.Close()
            Return count > 0
        End Using
    End Function

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim found As Boolean = False

                ' Check for duplicate entry
                Using cmd As New SqlClient.SqlCommand("SELECT COUNT(*) FROM tblcategory WHERE Category = @Category", con)
                    cmd.Parameters.AddWithValue("@Category", txtcategory.Text)
                    con.Open()
                    Dim count As Integer = CInt(cmd.ExecuteScalar())
                    found = (count > 0)
                End Using


                If Not found Then
                    ' Insert new generic
                    Using cmd As New SqlClient.SqlCommand("INSERT INTO tblcategory (Category) VALUES (@Category)", con)
                        cmd.Parameters.AddWithValue("@Category", txtcategory.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    MsgBox("Category has been successfully saved.", vbInformation)
                    con.Close()
                    Me.Close()
                    With frmcategorylist
                        .catview()
                    End With
                Else
                    MsgBox("Error: Duplicate entry.", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub frmcategory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the 'ding' sound
            btnsave.PerformClick() ' Simulate a click on the save button
        End If
    End Sub

    Private Sub frmcategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtcategory_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the 'ding' sound
            btnsave.PerformClick() ' Simulate a click on the save button
        End If
    End Sub

    Private Sub txtcategory_TextChanged(sender As Object, e As EventArgs)
        txtcategory.Focus()
    End Sub

    Private Sub txtcategory_MouseClick(sender As Object, e As MouseEventArgs)
        If txtcategory.Text <> "" Then
            txtcategory.Text = ""
        End If
    End Sub


    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        Try
            ' Check for duplicate entry
            If ValidateDuplicateEntry("SELECT COUNT(*) FROM tblcategory WHERE Category = @Category", txtcategory.Text) Then
                MsgBox("Error: Duplicate entry.", vbCritical)
                Return
            End If

            If MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes Then
                con.Open()
                cmd = New SqlClient.SqlCommand("update tblcategory set Category =  @Category where catID like @catID", con)
                cmd.Parameters.AddWithValue("@Category", txtcategory.Text)
                cmd.Parameters.AddWithValue("@catID", lblID.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                MsgBox("Error: Duplicate entry,", vbCritical)
            End If

            MsgBox("Category has been successfully updated.", vbInformation)
            With frmcategorylist
                .catview()
                clear()

            End With
            Me.Dispose()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub lblID_Click(sender As Object, e As EventArgs) Handles lblID.Click

    End Sub

    Private Sub btnsave_KeyDown(sender As Object, e As KeyEventArgs) Handles btnsave.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the 'ding' sound
            btnsave.PerformClick() ' Simulate a click on the save button

        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()

    End Sub
End Class