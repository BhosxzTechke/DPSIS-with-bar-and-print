Public Class frmformulationlist


    Sub formulationview()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("Select * from tblformulations order by Formulations", con)
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(dr.Item("formID").ToString, i, dr.Item("Formulations").ToString)

        End While
        dr.Close()
        con.Close()
        rc1.Text = "Record Found.(" & DataGridView1.Rows.Count & ")"


    End Sub



    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "Column4" Then
            With frmformulation
                .lblID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
                .txtformulation.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .btnsave.Enabled = False
                .btnupdate.Enabled = True
                .ShowDialog()

            End With
        ElseIf colname = "Column5" Then
            If (MsgBox("Are you sure you want to delete this record", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                cmd = New SqlClient.SqlCommand("Delete from tblformulations WHERE  formID = " & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString(), con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                formulationview()

            End If


        End If
    End Sub


    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
        With frmformulation
            .btnupdate.Enabled = False
            .btnsave.Enabled = True
            .txtformulation.Focus()
            .ShowDialog()

        End With
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub
End Class