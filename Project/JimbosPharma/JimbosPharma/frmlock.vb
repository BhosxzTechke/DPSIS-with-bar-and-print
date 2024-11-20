Public Class frmlock

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If strPass <> txtpass.Text Then
            MsgBox("Invalid password. unable to unlock", vbExclamation)
            Return
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmlock_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsave.PerformClick()         ' Simulate a click on the save button

        End If
    End Sub


    Private Sub frmlock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

    End Sub
End Class