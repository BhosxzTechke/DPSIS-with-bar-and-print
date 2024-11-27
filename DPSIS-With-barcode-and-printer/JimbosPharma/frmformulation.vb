Public Class frmformulation
    Private Function ValidateDuplicateEntry(query As String, value As String) As Boolean
        Using cmd As New SqlClient.SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Fomulations", value)
            con.Open()
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            con.Close()
            Return count > 0
        End Using
    End Function

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If String.IsNullOrEmpty(txtformulation.Text.Trim()) Then
                MsgBox("Please enter a formulation.", vbExclamation)
                Return
            End If

            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim found As Boolean = False
                con.Open()
                cmd = New SqlClient.SqlCommand("select * from tblformulations where Formulations like @Formulations", con)
                cmd.Parameters.AddWithValue("@Formulations", txtformulation.Text)
                dr = cmd.ExecuteReader()
                If dr.HasRows Then found = True
                dr.Close()
                con.Close()

                If found = False Then
                    con.Open()
                    cmd = Nothing
                    cmd = New SqlClient.SqlCommand("insert into tblformulations (Formulations) values(@Formulations)", con)
                    cmd.Parameters.AddWithValue("@Formulations", txtformulation.Text)
                    cmd.ExecuteNonQuery()
                    con.Close()
                Else
                    MsgBox("Error: Duplicate entry.", vbCritical)
                End If
                MsgBox("Formulation has been successfully saved.", vbInformation)
                Me.Close()
                With frmformulationlist
                    .formulationview()
                End With
                clear()
                DialogResult = DialogResult.OK
                Close()
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub txtformulation_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the 'ding' sound
            btnsave.PerformClick() ' Simulate a click on the save button
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            ' Check for duplicate entry
            If ValidateDuplicateEntry("SELECT COUNT(*) FROM tblformulations WHERE Formulations = @Formulations", txtformulation.Text) Then
                MsgBox("Error: Duplicate entry.", vbCritical)
                Return
            End If

            If MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes Then
                con.Open()
                cmd = New SqlClient.SqlCommand("update tblformulations set Formulations =  @Formulations where formID like @formID", con)
                cmd.Parameters.AddWithValue("@Formulations", txtformulation.Text)
                cmd.Parameters.AddWithValue("@formID", lblID.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                MsgBox("Error: Duplicate entry,", vbCritical)
            End If

            MsgBox("Formulation has been successfully updated.", vbInformation)
            With frmformulationlist
                .formulationview()
                clear()

            End With
            Me.Dispose()
        Catch ex As Exception

        End Try


    End Sub
    Sub clear()
        txtformulation.Clear()
        btnsave.Enabled = True
        btnupdate.Enabled = False
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs)
        DialogResult = DialogResult.OK
        Close()
        txtformulation.Clear()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub txtformulation_MouseClick(sender As Object, e As MouseEventArgs)
        If txtformulation.Text <> "" Then
            txtformulation.Text = ""
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()

    End Sub
End Class