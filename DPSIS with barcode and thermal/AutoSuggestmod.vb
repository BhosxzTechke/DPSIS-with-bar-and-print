Module AutoSuggestmod


    Sub SupplierCBXdelivery()        '       AUTOMATIC TO FILL IN COMBOBOX IN SUPPLIER
        con.Open()

        cmd = New SqlClient.SqlCommand("Select * from tblSupplier order by CompanyName", con)
        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "CompanyName")
        Dim col As New List(Of String)
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("CompanyName").ToString)
        Next
        With frmdeliverylist
            .suppliercombo.DataSource = col
            .suppliercombo.AutoCompleteMode = AutoCompleteMode.None
            .suppliercombo.DropDownStyle = ComboBoxStyle.DropDownList
        End With
        cmd = Nothing
        con.Close()
    End Sub

    Sub brandcombobox()        '       AUTOMATIC TO FILL IN COMBOBOX IN BRAND
        con.Open()

        cmd = New SqlClient.SqlCommand("Select * from tblbrand order by brand", con)
        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "brand")
        Dim col As New List(Of String)
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("brand").ToString)
        Next
        With frmproduct
            .BranCBx.DataSource = col
            .BranCBx.AutoCompleteMode = AutoCompleteMode.None
            .BranCBx.DropDownStyle = ComboBoxStyle.DropDownList
        End With
        cmd = Nothing
        con.Close()
    End Sub




    Sub genericcombobox()        '       AUTOMATIC TO FILL IN COMBOBOX IN GENERIC
        con.Open()

        cmd = New SqlClient.SqlCommand("Select * from tblgeneric order by generic", con)
        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "generic")
        Dim col As New List(Of String)
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("generic").ToString)
        Next
        With frmproduct
            .GenCbx.DataSource = col
            .GenCbx.AutoCompleteMode = AutoCompleteMode.None
            .GenCbx.DropDownStyle = ComboBoxStyle.DropDownList
        End With
        cmd = Nothing
        con.Close()
    End Sub





    Sub categorycombobox()        '       AUTOMATIC TO FILL IN COMBOBOX IN CATEGORY
        con.Open()

        cmd = New SqlClient.SqlCommand("Select * from tblcategory order by Category", con)
        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "Category")
        Dim col As New List(Of String)
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Category").ToString)
        Next
        With frmproduct
            .CatCBx.DataSource = col
            .CatCBx.AutoCompleteMode = AutoCompleteMode.None
            .CatCBx.DropDownStyle = ComboBoxStyle.DropDownList
        End With
        cmd = Nothing
        con.Close()
    End Sub


    Sub formulationCombobox()        '       AUTOMATIC TO FILL IN COMBOBOX IN FORMULATIONS
        con.Open()

        cmd = New SqlClient.SqlCommand("Select * from tblformulations order by Formulations", con)
        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "Formulations")
        Dim col As New List(Of String)
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Formulations").ToString)
        Next
        With frmproduct
            .FormCBx.DataSource = col
            .FormCBx.AutoCompleteMode = AutoCompleteMode.None
            .FormCBx.DropDownStyle = ComboBoxStyle.DropDownList
        End With
        cmd = Nothing
        con.Close()
    End Sub

    Sub unitcombobox()
        con.Open()

        cmd = New SqlClient.SqlCommand("Select * from tblunit order by unit", con)
        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "unit")
        Dim col As New List(Of String)
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("unit").ToString)
        Next

        With frmproduct
            .unitcbx.DataSource = col
            .unitcbx.AutoCompleteMode = AutoCompleteMode.None
            .unitcbx.DropDownStyle = ComboBoxStyle.DropDownList
        End With
        cmd = Nothing
        con.Close()

    End Sub


    Sub dosageCBX()        '       AUTOMATIC TO FILL IN COMBOBOX IN DOSAGE
        con.Open()

        cmd = New SqlClient.SqlCommand("Select * from tbldosage order by Dosage", con)
        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        da.Fill(ds, "Dosage")
        Dim col As New List(Of String)
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Dosage").ToString)
        Next
        With frmproduct
            .DosCBx.DataSource = col
            .DosCBx.AutoCompleteMode = AutoCompleteMode.None
            .DosCBx.DropDownStyle = ComboBoxStyle.DropDownList
        End With
        cmd = Nothing
        con.Close()
    End Sub







    'Sub Dosagesuggest()          '        AUTOMATIC TO FILL IN COMBOBOX IN DOSAGE

    '    con.Open()
    '    cmd = New SqlClient.SqlCommand("Select * from tbldosage order by Dosage", con)
    '    Dim ds As New DataSet
    '    Dim da As New SqlClient.SqlDataAdapter(cmd)
    '    da.Fill(ds, "Dosage")
    '    Dim col As New AutoCompleteStringCollection
    '    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
    '        col.Add(ds.Tables(0).Rows(i)("Dosage").ToString)
    '    Next
    '    With frmproduct
    '        .txtdosage.AutoCompleteSource = AutoCompleteSource.CustomSource
    '        .txtdosage.AutoCompleteCustomSource = col
    '        .txtdosage.AutoCompleteMode = AutoCompleteMode.Suggest
    '        cmd = Nothing
    '        con.Close()
    '    End With

    'End Sub



    'Sub Typename()

    '    con.Open()
    '    cmd = New SqlClient.SqlCommand("Select * from tblType order by Type", con)
    '    Dim ds As New DataSet
    '    Dim da As New SqlClient.SqlDataAdapter(cmd)
    '    da.Fill(ds, "Type")
    '    Dim col As New AutoCompleteStringCollection
    '    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
    '        col.Add(ds.Tables(0).Rows(i)("Type").ToString)
    '    Next
    '    With frmproduct
    '        .txttype.AutoCompleteSource = AutoCompleteSource.CustomSource
    '        .txttype.AutoCompleteCustomSource = col
    '        .txttype.AutoCompleteMode = AutoCompleteMode.Suggest
    '        cmd = Nothing
    '        con.Close()
    '    End With

    'End Sub


    'Sub Formulationname()

    '    con.Open()
    '    cmd = New SqlClient.SqlCommand("Select * from tblformulations order by Formulations", con)
    '    Dim ds As New DataSet
    '    Dim da As New SqlClient.SqlDataAdapter(cmd)
    '    da.Fill(ds, "Formulations")
    '    Dim col As New AutoCompleteStringCollection
    '    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
    '        col.Add(ds.Tables(0).Rows(i)("Formulations").ToString)
    '    Next
    '    With frmproduct
    '        .txtformu.AutoCompleteSource = AutoCompleteSource.CustomSource
    '        .txtformu.AutoCompleteCustomSource = col
    '        .txtformu.AutoCompleteMode = AutoCompleteMode.Suggest
    '        cmd = Nothing
    '        con.Close()
    '    End With

    'End Sub

    'Sub loadbrand()    '         AUTO SUGGEST
    '    con.Open()
    '    cmd = New SqlClient.SqlCommand("Select * from tblbrand order by brand", con)
    '    Dim ds As New DataSet
    '    Dim da As New SqlClient.SqlDataAdapter(cmd)
    '    da.Fill(ds, "brand")
    '    Dim col As New AutoCompleteStringCollection
    '    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
    '        col.Add(ds.Tables(0).Rows(i)("brand").ToString)
    '    Next
    '    With frmproduct
    '        .txtbrand.AutoCompleteSource = AutoCompleteSource.CustomSource
    '        .txtbrand.AutoCompleteCustomSource = col
    '        .txtbrand.AutoCompleteMode = AutoCompleteMode.Suggest
    '        cmd = Nothing
    '        con.Close()
    '    End With

    'End Sub

    'Sub loadgenericname()

    '    con.Open()
    '    cmd = New SqlClient.SqlCommand("Select * from tblgeneric order by generic", con)
    '    Dim ds As New DataSet
    '    Dim da As New SqlClient.SqlDataAdapter(cmd)
    '    da.Fill(ds, "generic")
    '    Dim col As New AutoCompleteStringCollection
    '    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
    '        col.Add(ds.Tables(0).Rows(i)("generic").ToString)
    '    Next
    '    With frmproduct
    '        .txtgeneric.AutoCompleteSource = AutoCompleteSource.CustomSource
    '        .txtgeneric.AutoCompleteCustomSource = col
    '        .txtgeneric.AutoCompleteMode = AutoCompleteMode.Suggest
    '        cmd = Nothing
    '        con.Close()
    '    End With

    'End Sub


    'Sub loadcatname()

    '    con.Open()
    '    cmd = New SqlClient.SqlCommand("Select * from tblcategory order by Category", con)
    '    Dim ds As New DataSet
    '    Dim da As New SqlClient.SqlDataAdapter(cmd)
    '    da.Fill(ds, "Category")
    '    Dim col As New AutoCompleteStringCollection
    '    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
    '        col.Add(ds.Tables(0).Rows(i)("Category").ToString)
    '    Next
    '    With frmproduct
    '        .txtcat.AutoCompleteSource = AutoCompleteSource.CustomSource
    '        .txtcat.AutoCompleteCustomSource = col
    '        .txtcat.AutoCompleteMode = AutoCompleteMode.Suggest
    '        cmd = Nothing
    '        con.Close()
    '    End With
    'End Sub

End Module
