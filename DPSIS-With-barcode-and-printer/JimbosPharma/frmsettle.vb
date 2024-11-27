Public Class frmsettle

    Private Sub frmsettle_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select e.KeyCode
            Case Keys.Escape
                With cashier
                    .txtsearch.Focus()
                    .txtsearch.SelectionStart = 0
                    .txtsearch.SelectionLength = .txtsearch.Text.Length
                End With
                Me.Dispose()
        End Select


    End Sub

    'Private Sub frmsettle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
    '    Select Case Keys.KeyCode
    '        Case Keys.Escape          ' Escape key to esc
    '            Me.Dispose()
    '    End Select
    'End Sub


    Private Sub frmsettle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True    'When KeyPreview is set to True, the form's KeyPress, KeyDown, and KeyUp events will be raised before the same events occur for the active control on the form.

    End Sub

    Private Sub txtcash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcash.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                settlepayment() ' Enter key is pressed
            Case 48 To 57   ' 0 to 9
            Case 46  ' allows decimal (.)
            Case 8    ' backspace
            Case Else
                e.Handled = True

        End Select

    End Sub
    Sub settlepayment()
        Try
            Dim sdate As String = Now.ToString("yyyy-MM-dd")
            If CDbl(lbltotalitem.Text) > CDbl(txtcash.Text) Then      ' Kapag mas mataas si ung total due sa binayad mag wawarning
                MsgBox("Insufficient cash! Please input correct amount.", vbExclamation)
                Return
            End If


            If MsgBox("Are you sure you want to save this payment?", vbYesNo + vbQuestion) = vbYes Then
                con.Open()
                cmd = Nothing
                cmd = New SqlClient.SqlCommand("insert into tblpayment (invoice, subtotal, vat, discount, amountdue, sdate, users) VALUES(@invoice, @subtotal, @vat, @discount, @amountdue, @sdate, @users)", con)
                With cashier
                    cmd.Parameters.AddWithValue("@invoice", .lblinvoice.Text)
                    cmd.Parameters.AddWithValue("@subtotal", CDbl(.lblsubtotal.Text))
                    cmd.Parameters.AddWithValue("@vat", CDbl(.lblvat.Text))
                    cmd.Parameters.AddWithValue("@discount", CDbl(.lbldics.Text))
                    cmd.Parameters.AddWithValue("@amountdue", CDbl(.lbldue.Text))
                    cmd.Parameters.AddWithValue("@sdate", sdate)
                    cmd.Parameters.AddWithValue("@users", lblsettle.Text)
                    cmd.ExecuteNonQuery()
                    con.Close()

                    MinusStockQty() '  AFTER PAID IT UPDATES THE QTY OF PRODUCT AND UPDATE 'PENDING' TO 'SOLD'

                    MsgBox("Payment has been succesfully saved.", vbInformation)
                    .lblinvoice.Text = .getinvoiceNo  '  TO CREATE NEW INVOICE WHEN SUCCESFULLY PAID
                    .loadcart()
                    .txtsearch.Focus()
                    .txtsearch.Clear()
                    .ClearAfterPaid()
                    Me.Dispose()


                End With

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        End Try


    End Sub

    Sub MinusStockQty()

        Try
            With cashier
                For i = 0 To .Guna2DataGridView1.RowCount - 1
                    con.Open()
                    cmd = New SqlClient.SqlCommand("Update tblinventory set Quantity = Quantity - " & CInt(.Guna2DataGridView1.Rows(i).Cells(6).Value.ToString) & "where InventoryID like '" & .Guna2DataGridView1.Rows(i).Cells(2).Value.ToString & "'", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                Next

                con.Open()
                cmd = New SqlClient.SqlCommand("update tblcart set status  = 'Sold' where invoice like '" & Trim(.lblinvoice.Text) & "'", con)
                cmd.ExecuteNonQuery()
                con.Close()
                .lblinvoice.Text = .getinvoiceNo  '  TO CREATE NEW INVOICE WHEN SUCCESFULLY PAID
                .loadcart()
            End With



        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub


    Private Sub txtcash_TextChanged(sender As Object, e As EventArgs) Handles txtcash.TextChanged  ' CALCULATOR
        Try
            Dim change As Double = CDbl(txtcash.Text) - CDbl(lbltotalitem.Text)
            If change < 0 Then
                lblchange.Text = "0.00"     ' IF MAS MABABA ANG SUKLI SA 0
            Else
                lblchange.Text = Format(change, "#,##0.00")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblchange_Click(sender As Object, e As EventArgs) Handles lblchange.Click

    End Sub
End Class

