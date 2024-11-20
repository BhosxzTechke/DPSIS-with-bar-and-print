Public Class frmchangepass

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If Walanglaman(txtold) = True Then Return
            If Walanglaman(txtnewpass) = True Then Return
            If Walanglaman(txtconfpass) = True Then Return
            If txtold.Text <> strPass Then ' IF NOT EQUAL THE RETURN
                MsgBox("Old password is not matched!", vbExclamation)
                Return
            End If
            If txtnewpass.Text <> txtconfpass.Text Then
                MsgBox("Confirm new password did not matched!", vbExclamation)
                Return
            End If
            If MsgBox("Are you sure you want to save changes?", vbYesNo + vbQuestion) = vbYes Then
                con.Open()
                cmd = New SqlClient.SqlCommand("Update tbluser set password = @password where username like @username", con)
                cmd.Parameters.AddWithValue("@password", txtnewpass.Text)
                cmd.Parameters.AddWithValue("@username", struser)
                cmd.ExecuteNonQuery()
                con.Close()
                strPass = txtnewpass.Text
                MsgBox("New Password has been succesfully save,", vbInformation)
                clear()
            End If


        Catch ex As Exception

        End Try
    End Sub
    Sub clear()
        txtold.Clear()
        txtnewpass.Clear()
        txtconfpass.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        clear()

    End Sub
End Class