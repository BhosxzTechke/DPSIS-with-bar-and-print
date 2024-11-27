Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient

Public Class frmdashboard

    Dim cn As New SqlConnection

    Sub loadchart()
        Try
            cn.ConnectionString = "Data Source=TECHQUINA\SQLEXPRESS;Initial Catalog=JimbospharmaDB;Integrated Security=True;MultipleActiveResultSets=True;"
            If cn.State = ConnectionState.Closed Then cn.Open()

            With Chart1
                .Series.Clear()
                .Series.Add("Series1")
            End With

            Dim query As String = "SELECT CompanyName, COUNT(*) AS TotalSuppliers FROM tblSupplier GROUP BY CompanyName"
            Dim da As New SqlDataAdapter(query, cn)
            Dim ds As New DataSet

            da.Fill(ds, "tblSupplier")

            If ds.Tables("tblSupplier").Rows.Count = 0 Then
                MessageBox.Show("No data found for the chart.")
                Return
            End If

            Chart1.DataSource = ds.Tables("tblSupplier")
            Dim series1 As Series = Chart1.Series("Series1")

            series1.ChartType = SeriesChartType.Pie
            series1.XValueMember = "CompanyName"  ' Column for X values (categories)
            series1.YValueMembers = "TotalSuppliers"  ' Column for Y values (numeric)
            series1.Label = "#PERCENT{P0}"
            series1.LegendText = "#VALX"

            ' Refresh the chart
            Chart1.DataBind()

        Catch ex As Exception
            MessageBox.Show("Error loading chart: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub


Private Sub Button10_Click(sender As Object, e As EventArgs)
    Me.Dispose()

End Sub
Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    supplierCount()
    usercounts()
    'GetExpiredItemCount()
    ProductCount()
    'purchaseamount()
    'deliverycost()
    loadchart()

End Sub


Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Me.Dispose()

End Sub

'Sub loadchart()
'    With Chart1
'        .Series.Clear()
'        .Series.Add("Series1")
'    End With

'    Dim da As New SqlDataAdapter("SELECT Address1, COUNT(Address2) AS AddressCount FROM tblSupplier WHERE Suburb LIKE 'Metro Manila' GROUP BY Address1", con)
'    Dim ds As New DataSet

'    da.Fill(ds, "Address1")
'    Chart1.DataSource = ds.Tables("Address1")
'    Dim series1 As Series = Chart1.Series("Series1")
'    series1.ChartType = SeriesChartType.Pie

'    series1.Name = "POPULATION"

'    With Chart1
'        .Series(series1.Name).XValueMember = "Address1"
'        .Series(series1.Name).YValueMembers = "AddressCount"
'        .Series(0).LabelFormat = "(#,##0)"
'    End With




Sub supplierCount()
    Try
        Dim i As Integer = 0
        con.Open()
        cmd = New SqlClient.SqlCommand("SELECT COUNT(*) FROM tblSupplier", con)
        i = CInt(cmd.ExecuteScalar())
        con.Close()

        lblsupplier.Text = i.ToString()

    Catch ex As Exception
        MsgBox(ex.Message, vbCritical)
    End Try

End Sub

Sub ProductCount()
    Try
        Dim i As Integer = 0
        con.Open()
        cmd = New SqlClient.SqlCommand("SELECT COUNT(*) FROM tblproduct", con)
        i = CInt(cmd.ExecuteScalar())
        con.Close()

        itemcount.Text = i.ToString()

    Catch ex As Exception
        MsgBox(ex.Message, vbCritical)
    End Try

End Sub

Sub usercounts()
    Try
        Dim i As Integer = 0
        con.Open()
        cmd = New SqlClient.SqlCommand("SELECT COUNT(*) FROM tbluser WHERE User_Type <> 'System Administrator' ", con)
        i = CInt(cmd.ExecuteScalar())
        con.Close()

        userlbl.Text = i.ToString()

    Catch ex As Exception
        MsgBox(ex.Message, vbCritical)
    End Try
End Sub


Private Sub lbltotalsales_Click(sender As Object, e As EventArgs) Handles lbltotalsales.Click

    With frmdailysales
        .loadsales()
        .lbltotal.Text = lbltotalsales.Text

    End With


End Sub

Private Sub lbltotalsales_TextChanged(sender As Object, e As EventArgs) Handles lbltotalsales.TextChanged

    With frmdailysales
        Dim sdate As String = .DateTime.Value.ToString("yyyy-MM-dd")

        lbltotalsales.Text = Format(.GetData("select sum(amountdue) from tblpayment where sdate between '" & sdate & "' and '" & sdate & "'"), "#,#00.00")
    End With

End Sub




'Function GetExpiredItemCount() As Integer  ' PURPOSE IS TO  COUNT ALL EXPIRED THAT = TO OUR CURRENT DATE
'    Dim count As Integer = 0
'    Dim currentDate As Date = Date.Today

'    If con.State = ConnectionState.Closed Then
'        con.Open()
'    End If


'    cmd = New SqlClient.SqlCommand("SELECT COUNT(*) FROM tblproduct WHERE expdate = @CurrentDate", con)
'    cmd.Parameters.AddWithValue("@CurrentDate", currentDate)
'    count = Convert.ToInt32(cmd.ExecuteScalar())
'    con.Close()

'    lblexp.Text = count.ToString()


'    If con.State = ConnectionState.Open Then
'        con.Close()
'    End If
'    Return count
'End Function



'Sub purchaseamount()
'    Try
'        con.Open()

'        cmd = New SqlClient.SqlCommand("select top 1 deliveryid, orderr, supid, daterel, receivedby, priceperunit, priceperunit * qty as totalprice, shippingcost, taxcost, qty, othercost, shippingcost + taxcost + othercost as totaldeliverycost, [status] from tbldelivery order by deliveryid desc", con)
'        dr = cmd.ExecuteReader()

'        con.Close()

'        ' Process the data if needed

'        lblpurchamount.Text = Format(gettotaldata("select isnull(sum(priceperunit * qty),0) from tbldelivery"), "#,##0.00")

'    Catch ex As Exception
'        MessageBox.Show("Error: " & ex.Message)
'    Finally
'        If con.State = ConnectionState.Open Then
'            con.Close()
'            MessageBox.Show("Connection closed successfully.")
'        End If
'    End Try
'End Sub

'Sub deliverycost()
'    Try
'        con.Open()

'        cmd = New SqlClient.SqlCommand("select top 1 deliveryid, orderr, supid, daterel, receivedby, priceperunit, priceperunit * qty as totalprice, shippingcost, taxcost, qty, othercost, shippingcost + taxcost + othercost as totaldeliverycost, [status] from tbldelivery order by deliveryid desc", con)
'        dr = cmd.ExecuteReader()

'        con.Close()

'        ' Process the data if needed

'        Dim totalDeliveryCost As Decimal = gettotaldata("select isnull(sum(shippingcost + taxcost + othercost),0) from tbldelivery")
'        divcost.Text = Format(totalDeliveryCost, "#,##0.00")

'    Catch ex As Exception
'        MessageBox.Show("Error: " & ex.Message)
'    Finally
'        If con.State = ConnectionState.Open Then
'            con.Close()
'            MessageBox.Show("Connection closed successfully.")
'        End If
'    End Try
'End Sub




Function gettotaldata(ByVal sql As String) As Double
    Try
        con.Open()
        cmd = New SqlClient.SqlCommand(sql, con)
        Dim result As Object = cmd.ExecuteScalar()
        Return If(result IsNot Nothing AndAlso Not IsDBNull(result), Convert.ToDouble(result), 0)
    Catch ex As Exception
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return 0
    Finally
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Try
End Function


Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

End Sub

Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

End Sub
End Class