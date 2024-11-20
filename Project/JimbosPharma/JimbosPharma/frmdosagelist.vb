Public Class frmdosagelist

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        Dim colname As String = DataView.Columns(e.ColumnIndex).Name

        If colname = "Column4" Then
            With frmdosage
                .lblid.Text = DataView.Rows(e.RowIndex).Cells(0).Value.ToString
                .txtdosage.Text = DataView.Rows(e.RowIndex).Cells(2).Value.ToString
                .btnsave.Enabled = False
                .btnupdate.Enabled = True
                .ShowDialog()
            End With

        ElseIf colname = "Column5" Then
            If (MsgBox("Are you sure you want to Delete this record", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                cmd = New SqlClient.SqlCommand("Delete from tbldosage where dosageID=" & DataView.Rows(e.RowIndex).Cells(0).Value.ToString(), con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been succesfully Deleted", vbInformation)
                loaddosage()
            End If

        End If

    End Sub



    Sub loaddosage()
        Dim i As Integer = 0
        DataView.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("Select * from tbldosage", con)
        dr = cmd.ExecuteReader()
        While dr.Read
            i += 1
            DataView.Rows.Add(dr.Item("dosageID").ToString, i, dr.Item("dosage").ToString)
        End While
        dr.Close()
        con.Close()
        rc1.Text = " Record Found.(" & DataView.RowCount & ") "


    End Sub
 

    Private Sub btnew_Click(sender As Object, e As EventArgs)
        With frmdosage
            .btnsave.Enabled = True
            .btnupdate.Enabled = False
            .ShowDialog()

        End With
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
End Class
