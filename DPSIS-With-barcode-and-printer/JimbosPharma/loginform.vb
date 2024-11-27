Imports Guna.UI2.WinForms
Imports System.Data.SqlClient


Public Class loginform

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        ' Check if username or password fields are empty
        If Walanglamanuser(txtuser) OrElse Walanglamanuser(txtpass) Then Return

        ' SQL command to select user details
        cmd = New SqlClient.SqlCommand("SELECT * FROM tbluser WHERE Username = @username AND Password = @password", con)
        cmd.Parameters.AddWithValue("@username", txtuser.Text.Trim())
        cmd.Parameters.AddWithValue("@password", txtpass.Text.Trim())

        Try
            ' Open connection and execute command
            con.Open()
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                ' Retrieve user information
                Dim struser As String = dr("Username").ToString()
                Dim strPass As String = dr("Password").ToString()
                Dim strlastname As String = dr("LastName").ToString()
                Dim strType As String = dr("User_Type").ToString()
                Dim strStat As String = dr("Status").ToString()
                Dim strEmail As String = dr("EmailAddress").ToString()
                Dim strContact As String = dr("Contact").ToString()
                Dim strId As String = dr("ID").ToString()

                ' Close the DataReader after reading the user information
                dr.Close()

                ' Check account status
                If strStat.Equals("active", StringComparison.OrdinalIgnoreCase) Then
                    ' Clear login fields
                    txtuser.Clear()
                    txtpass.Clear()

                    ' Handle user based on type
                    HandleUserType(struser, strType, strlastname, strEmail, strContact, strId)
                Else
                    MsgBox("Access Denied! Inactive account.", vbExclamation)
                End If
            Else
                dr.Close()
                MsgBox("Access Denied! Invalid username or password.", vbExclamation)
            End If

        Catch ex As SqlClient.SqlException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("Unexpected error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            ' Ensure connection is properly closed
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub


    Private Sub HandleUserType(struser As String, userType As String, lastname As String, email As String, contact As String, userId As String)

        MsgBox("Access Granted! Welcome " & lastname, vbInformation)

        Select Case userType
            Case "Cashier"
                'cashier.btnexit.Enabled = False
                'cashier.btnpass.Enabled = True
                cashier.ShowDialog()


            Case "Staff"
                frmstaffboard.lbluser.Text = "Welcome, " & lastname
                frmstaffboard.ShowDialog()
                frmstockadjustment.txtadjusted.Text = struser

            Case Else
                'dashboard.lbluser.Text = userType

                dashboard.lblcont.Text = contact
                dashboard.lbl2.Text = email
                dashboard.lblname.Text = struser
                frmqty.lblname.Text = struser
                frmsettle.lblsettle.Text = struser
                With frmstockadjustment
                    .txtadjusted.Text = struser
                End With
                'dashboard.lblname.Text = struser


                LoadUserImage(dashboard.userpic, userId) ' Now userId is available
                dashboard.ShowDialog()

        End Select
    End Sub


    Private Sub LoadUserImage(pictureBox As PictureBox, userId As String)
        Dim imagePath As String = GetUserImagePath(userId)
        If Not String.IsNullOrEmpty(imagePath) AndAlso System.IO.File.Exists(imagePath) Then
            pictureBox.Image = Image.FromFile(imagePath)
        Else
            pictureBox.Image = Nothing
        End If
    End Sub

    Private Function GetUserImagePath(userId As String) As String
        Dim imagePath As String = String.Empty
        Dim query As String = "SELECT imagepath FROM tbluser WHERE ID = @userId"

        ' Use a separate SqlCommand instance
        Using cmdGetPath As New SqlCommand(query, con)
            cmdGetPath.Parameters.AddWithValue("@userId", userId)

            Try
                ' Open the connection if it's closed
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                ' Execute the command and retrieve the result
                Dim result = cmdGetPath.ExecuteScalar()
                If result IsNot Nothing Then
                    imagePath = result.ToString()
                End If

            Catch ex As Exception
                MessageBox.Show("Error retrieving image path: " & ex.Message)
            End Try
        End Using

        Return imagePath
    End Function


    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub


    Private Sub loginform_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2GradientButton1.PerformClick() ' Simulate a click  if ENTER on the login button

        End If
    End Sub


    Private Sub Button10_Click_1(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Guna2GradientButton2_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Application.Exit()
    End Sub

    Private Sub txtpass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpass.KeyDown
        txtpass.PasswordChar = "*"c

    End Sub




    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub


    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub



    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If txtpass.PasswordChar = ControlChars.NullChar Then
            ' Hide the password and change icon to "closed eye"
            txtpass.PasswordChar = "*"c
            PictureBox1.Image = My.Resources.eye ' Replace with your actual closed eye image
        Else
            ' Show the password and change icon to "open eye"
            txtpass.PasswordChar = ControlChars.NullChar
            PictureBox1.Image = My.Resources.eye_close_up ' Replace with your actual open eye image
        End If
    End Sub
End Class