Imports MySql.Data.MySqlClient
Public Class frmNewOrders

    Private selectedCustomerID As String ' Class-level variable to store selected customer ID
    Private myDataSet As New DataSet ' Class-level variable to store the dataset

    Private Sub DisplayCustomerNames(searchText As String)
        Dim myConnection As MySqlConnection
        Dim myCommand As MySqlCommand
        Dim myAdapter As New MySqlDataAdapter

        myConnection = Common.getDBConnectionX()

        Try
            myConnection.Open()

            ' SQL query to get customer names and IDs based on the search text
            Dim query As String = "SELECT CONCAT(tc.dcustomerln, ', ', tc.dcustomerfn) AS customer_name, CAST(tc.dcustomerid AS CHAR) AS dcustomerid FROM tblcustomers tc WHERE CONCAT(tc.dcustomerln, ', ', tc.dcustomerfn) LIKE @searchText"
            myCommand = New MySqlCommand(query, myConnection)
            myCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myDataSet, "Customers")

            ' Create a list to store customer names
            Dim customerNames As New List(Of String)

            ' Populate the list with customer names and IDs from the dataset
            For Each row As DataRow In myDataSet.Tables("Customers").Rows
                Dim customerName As String = row("customer_name").ToString()
                Dim customerId As String = row("dcustomerid").ToString()
                customerNames.Add(customerName)
            Next

            ' Set AutoComplete properties for the Guna2TextBox
            ' Assuming tbCustomerName is the Guna2TextBox control
            tbCustomerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            tbCustomerName.AutoCompleteCustomSource.Clear()
            tbCustomerName.AutoCompleteCustomSource.AddRange(customerNames.ToArray())

            ' Set selectedCustomerID based on the selected item in AutoCompleteCustomSource
            If customerNames.Contains(tbCustomerName.Text.Trim) Then
                selectedCustomerID = myDataSet.Tables("Customers").Rows(customerNames.IndexOf(tbCustomerName.Text.Trim))("dcustomerid").ToString()
            Else
                ' If the entered text does not match any item, set selectedCustomerID to an empty string or handle it as appropriate for your application logic.
                selectedCustomerID = String.Empty
            End If


        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection.Close()
        End Try
    End Sub


    Private Sub tbCustomerName_TextChanged(sender As Object, e As EventArgs) Handles tbCustomerName.TextChanged
        ' Call the method to dynamically display customer names based on the search text
        DisplayCustomerNames(tbCustomerName.Text.Trim)
    End Sub

    Private selectedProductID As String ' Class-level variable to store selected product ID

    Private Sub DisplayProductName()
        Dim myConnection As MySqlConnection
        Dim myCommand As MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myDataSet As New DataSet

        myConnection = Common.getDBConnectionX()

        Try
            myConnection.Open()

            ' SQL query to get product names
            myCommand = New MySqlCommand("SELECT dproductname, dproductid FROM tblproducts", myConnection)
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myDataSet, "Products")

            ' Bind the DataSet to the ComboBox
            cbProductName.DataSource = myDataSet.Tables("Products")
            cbProductName.DisplayMember = "dproductname"
            cbProductName.ValueMember = "dproductid"

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection.Close()
        End Try
    End Sub

    Private Sub cbProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProductName.SelectedIndexChanged
        ' Store the selected product ID in the class-level variable
        If cbProductName.SelectedIndex <> -1 Then
            selectedProductID = cbProductName.SelectedValue.ToString()
        End If
    End Sub

    Private Function IsOrderIdUnique(orderId As String) As Boolean
        Dim myConnection As MySqlConnection = Common.getDBConnectionX()
        Dim isUnique As Boolean = True

        Try
            myConnection.Open()

            Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblorders WHERE dorderid = @orderId", myConnection)
            checkCommand.Parameters.AddWithValue("@orderId", orderId)

            Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
            isUnique = (count = 0)

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            myConnection.Close()
        End Try

        Return isUnique
    End Function

    Private Sub SaveOrder()
        Dim myConnection As MySqlConnection
        Dim myCommand As MySqlCommand

        myConnection = Common.getDBConnectionX()

        Try
            myConnection.Open()

            ' Generate a random order ID with a maximum length of 15 characters (uppercase letters)
            Dim orderId As String

            ' Ensure that the generated order ID is unique
            Do
                orderId = Guid.NewGuid().ToString().Substring(0, 15).ToUpper()
            Loop While Not IsOrderIdUnique(orderId)

            ' Get values from textboxes
            Dim quantityOrdered As Integer = Integer.Parse(tbQuantity.Text)
            Dim dateOrdered As DateTime = DateTime.Now

            ' Add debugging statements
            Console.WriteLine("Length of Product ID being inserted: " & selectedProductID.Length)
            Console.WriteLine("Product ID being inserted: " & selectedProductID)

            ' Insert data into tblorders
            myCommand = New MySqlCommand("INSERT INTO tblorders (dorderid, dcustomerid, dproductid, dquantityordered, ddateordered, dshippingdate, dstatus) " &
                         "VALUES (@orderId, @customerId, @productId, @quantityOrdered, @dateOrdered, NULL, 'Queued')", myConnection)
            myCommand.Parameters.AddWithValue("@orderId", orderId)
            myCommand.Parameters.AddWithValue("@customerId", selectedCustomerID)
            myCommand.Parameters.AddWithValue("@productId", selectedProductID)
            myCommand.Parameters.AddWithValue("@quantityOrdered", quantityOrdered)
            myCommand.Parameters.AddWithValue("@dateOrdered", dateOrdered)

            ' Execute the SQL command
            myCommand.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection.Close()
            MessageBox.Show("Success")
        End Try
    End Sub


    Private Sub bttnOrder_Click(sender As Object, e As EventArgs) Handles bttnOrder.Click
        SaveOrder()
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmNewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayProductName()
    End Sub

    Private Sub dgvNewOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNewOrders.CellContentClick

    End Sub


End Class