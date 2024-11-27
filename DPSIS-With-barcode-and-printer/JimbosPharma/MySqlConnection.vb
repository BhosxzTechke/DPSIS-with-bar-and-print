Imports System.Data
Imports System.Data.SqlClient

Module Dbsql

    Public con As New SqlConnection("Data Source=TECHQUINA\SQLEXPRESS;Initial Catalog=JimbospharmaDB;Integrated Security=True;MultipleActiveResultSets=True;")
    Public cmd As New SqlCommand
    Public dr As SqlDataReader


Public struser As String
Public strPass As String
Public strtype As String
Public stremail As String
Public strstat As String
Public strcontact As String
Public strvat As String
    Public strlastname As String



    ' #1 for vat 
    Function getvat() As Double
        con.Open()
        cmd = New SqlClient.SqlCommand("select * from tblVat", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then getvat = CDbl(dr.Item("vat").ToString) Else getvat = 0.0
        dr.Close()
        con.Close()
        Return getvat

    End Function


Public Function Walanglaman(ByVal sText As Object) As Boolean

    On Error Resume Next
    If sText.Text = "" Then
        Walanglaman = True
        MsgBox("Warning: Required missing field", vbExclamation)
        sText.FillColor = Color.LemonChiffon
        sText.Focus()
    Else
        Walanglaman = False
        sText.FillColor = Color.White
    End If

End Function
Public Function Walanglamanuser(ByVal sText As Object) As Boolean

    On Error Resume Next
    If sText.Text = "" Then
        Walanglamanuser = True
        MsgBox("Warning: Required missing field", vbExclamation)
        sText.Bordercolor = Color.White
        sText.Focus()
    Else
        Walanglamanuser = False
        sText.FillColor = Color.White
    End If

    End Function



    Public Function ValidateDuplicateEntry(ByVal sql As String) As Boolean ' FUNCTION NA PWEDENG TAWAGIN IN VALIDATION
        con.Open()
        cmd = New SqlClient.SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            ValidateDuplicateEntry = True
            MsgBox("Warning: Duplicate entry.", vbExclamation)
        Else
            ValidateDuplicateEntry = False
        End If

        dr.Close()
        con.Close()
    End Function






'Sub connection()
'    With con
'        .ConnectionString = "Data Source=TECHQUINA\SQLEXPRESS;Initial Catalog=JimbospharmaDB;Integrated Security=True"
'    End With
'End Sub


'Public da As New SqlDataAdapter
'Public ds As New DataSet
' Public dt As New DataTable
' Public qr As String
' Public i As Integer




'FOR SEARCHING
''  Public Function searchdata(ByVal qr As String) As DataSet
''      da = New sqldataadapter(qr, con)
'    ds = New dataset
'    da.fill(ds)
'    Return ds



'End Function

''for Insert Update and Delete Record
'Public Function InserData(ByVal qr As String) As Integer
'    cmd = New SqlCommand(qr, con)
'    con.Open()
'    i = cmd.ExecuteNonQuery()
'    con.Close()
'    Return i
'End Function



End Module