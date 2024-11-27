Imports System.Data.SqlClient
Public Class frmunit

    Private Sub frmunit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()

    End Sub

    Private Function ValidateDuplicateEntry(query As String, value As String) As Boolean
        Using cmd As New SqlClient.SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@unit", value)
            con.Open()
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            con.Close()
            Return count > 0
        End Using
    End Function
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            ' Validate input
            If String.IsNullOrWhiteSpace(txtunit.Text) Then
                MsgBox("Brand cannot be empty.", vbExclamation)
                Return
            End If

            ' Check for duplicate entry
            If ValidateDuplicateEntry("SELECT COUNT(*) FROM tblunit WHERE unit = @unit", txtunit.Text) Then
                MsgBox("Error: Duplicate entry.", vbCritical)
                Return
            End If

            ' Confirm save
            If MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbNo Then
                Return
            End If

            ' Insert new brand
            Using cmd As New SqlClient.SqlCommand("INSERT INTO tblunit (unit) VALUES (@unit)", con)
                cmd.Parameters.AddWithValue("@unit", txtunit.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            MsgBox("Unit has been successfully saved.", vbInformation)

            clear()
            Me.Close()
            With frmunitlist
                .unitview()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub clear()
        txtunit.Clear()
        txtunit.Focus()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try

            ' Check for duplicate entry
            If ValidateDuplicateEntry("SELECT COUNT(*) FROM tblunit WHERE unit = @unit", txtunit.Text) Then
                MsgBox("Error: Duplicate entry.", vbCritical)
                Return
            End If
            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                cmd = New SqlClient.SqlCommand("update tblunit set unit =  @unit where unitID like @unitID", con)
                cmd.Parameters.AddWithValue("@unit", txtunit.Text)
                cmd.Parameters.AddWithValue("@unitID", lblid.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                MsgBox("Error: Duplicate entry,", vbCritical)
            End If

            MsgBox("Unit has been successfully updated.", vbInformation)
            With frmunitlist
                .unitview()

            End With
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtunit_KeyDown(sender As Object, e As KeyEventArgs) Handles txtunit.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the 'ding' sound
            btnsave.PerformClick() ' Simulate a click on the save button
        End If
    End Sub

End Class