Public Class frmmaintenance

    Private Sub Guna2TabControl1_Click(sender As Object, e As EventArgs) Handles Guna2TabControl1.Click
        If Guna2TabControl1.SelectedIndex = 3 Then
            With frmcategorylist
                .TopLevel = False
                Panel5.Controls.Add(frmcategorylist)
                .BringToFront()
                .catview()
                .Show()
            End With
        ElseIf Guna2TabControl1.SelectedIndex = 0 Then
            With frmbrandlist
                .TopLevel = False
                Panel2.Controls.Add(frmbrandlist)
                .BringToFront()
                .brandview()
                .Show()
            End With
        ElseIf Guna2TabControl1.SelectedIndex = 1 Then
            With frmgenerikalist
                .TopLevel = False
                Panel3.Controls.Add(frmgenerikalist)
                .BringToFront()
                .genericview()
                .Show()
            End With
        ElseIf Guna2TabControl1.SelectedIndex = 2 Then ' FORM FORMULATION
            With frmformulationlist
                .TopLevel = False
                Panel4.Controls.Add(frmformulationlist)
                .BringToFront()
                .formulationview()
                .Show()
            End With

        ElseIf Guna2TabControl1.SelectedIndex = 4 Then '    FORM DOSAGE
            With frmdosagelist
                .TopLevel = False
                Panel6.Controls.Add(frmdosagelist)
                .BringToFront()
                .loaddosage()
                .Show()

            End With

        ElseIf Guna2TabControl1.SelectedIndex = 5 Then '    FORM Unit
            With frmunitlist
                .TopLevel = False
                Panel10.Controls.Add(frmunitlist)
                .BringToFront()
                .unitview()
                .Show()

            End With

        End If
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub frmmaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2TabControl1.SelectedIndex = 0
        With frmbrandlist
            .TopLevel = False
            Panel2.Controls.Add(frmbrandlist)
            .brandview()
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs)

        With frmvat
            .txtvat.Text = getvat()
            .ShowDialog()

        End With




    End Sub

    Private Sub txtvat_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57        '         (0 to 9) 
            Case 46              '           (.)
            Case 8               '       backspace key,
            Case Else
                e.Handled = True           ' to block other characters  

        End Select
    End Sub


    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs)
        With frmdiscount
            .loaddiscount()
            .ShowDialog()

        End With

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class