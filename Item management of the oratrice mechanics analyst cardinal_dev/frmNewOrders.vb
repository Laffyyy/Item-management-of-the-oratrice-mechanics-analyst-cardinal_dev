Imports MySql.Data.MySqlClient
Public Class frmNewOrders

    Private Sub DisplayCustomerName()
        Dim myConnection As MySqlConnection
        Dim myCommand As MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myDataSet As New DataSet

        myConnection = Common.getDBConnectionX()

        Try
            myConnection.Open()

            ' SQL query to get concatenated customer names
            myCommand = New MySqlCommand("SELECT CONCAT(tc.dcustomerln, ', ', tc.dcustomerfn) AS customer_name, CAST(tc.dcustomerid AS CHAR) AS dcustomerid FROM tblcustomers tc", myConnection)
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myDataSet, "Customers")

            ' Bind the DataSet to the ComboBox
            cbCustomerName.DataSource = myDataSet.Tables("Customers")
            cbCustomerName.DisplayMember = "customer_name"
            cbCustomerName.ValueMember = "dcustomerid"

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection.Close()
        End Try
    End Sub
    Private Sub cbCustomerName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustomerName.SelectedIndexChanged
        ' Display the corresponding customer ID in the TextBox when a name is selected in the ComboBox
        If cbCustomerName.SelectedIndex <> -1 Then
            Dim selectedName = cbCustomerName.Text.Trim ' Get the selected name from the ComboBox

            Dim myConnection As MySqlConnection
            Dim myCommand As MySqlCommand

            myConnection = Common.getDBConnectionX

            Try
                myConnection.Open()

                ' SQL query to get customer ID based on the selected name
                myCommand = New MySqlCommand("SELECT tc.dcustomerid FROM tblcustomers tc WHERE CONCAT(tc.dcustomerln, ', ', tc.dcustomerfn) = @selectedName", myConnection)
                myCommand.Parameters.AddWithValue("@selectedName", selectedName)

                ' Execute the query
                Dim customerId = myCommand.ExecuteScalar

                ' Display the corresponding customer ID in the TextBox
                If customerId IsNot Nothing Then
                    tbCustomerID.Text = customerId.ToString
                Else
                    tbCustomerID.Text = "Customer ID not found"
                End If

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                myConnection.Close()
            End Try
        End If
    End Sub


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
        ' Display the corresponding product ID in the TextBox when a name is selected in the ComboBox
        If cbProductName.SelectedIndex <> -1 Then
            Dim selectedProductName As String = cbProductName.Text.Trim() ' Get the selected product name from the ComboBox

            Dim myConnection As MySqlConnection
            Dim myCommand As MySqlCommand
            Dim myAdapter As New MySqlDataAdapter
            Dim myDataSet As New DataSet

            myConnection = Common.getDBConnectionX()

            Try
                myConnection.Open()

                ' SQL query to get product ID based on the selected product name
                myCommand = New MySqlCommand("SELECT dproductid FROM tblproducts WHERE dproductname = @selectedProductName", myConnection)
                myCommand.Parameters.AddWithValue("@selectedProductName", selectedProductName)

                ' Execute the query
                Dim productId As Object = myCommand.ExecuteScalar()

                ' Display the corresponding product ID in the TextBox
                If productId IsNot Nothing Then
                    tbProductID.Text = productId.ToString()
                Else
                    tbProductID.Text = "Product ID not found"
                End If

            Catch ex As Exception
                MsgBox(Err.Description)
            Finally
                myConnection.Close()
            End Try
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
            Dim customerId As String = tbCustomerID.Text
            Dim productId As String = tbProductID.Text
            Dim quantityOrdered As Integer = Integer.Parse(tbQuantityOrdered.Text)
            Dim dateOrdered As DateTime = DateTime.Now

            ' Insert data into tblorders
            myCommand = New MySqlCommand("INSERT INTO tblorders (dorderid, dcustomerid, dproductid, dquantityordered, ddateordered, dshippingdate, dstatus) " &
                                     "VALUES (@orderId, @customerId, @productId, @quantityOrdered, @dateOrdered, NULL, 'Queued')", myConnection)
            myCommand.Parameters.AddWithValue("@orderId", orderId)
            myCommand.Parameters.AddWithValue("@customerId", customerId)
            myCommand.Parameters.AddWithValue("@productId", productId)
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




    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustomerName.SelectedIndexChanged

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click, btnSaveNewOrder.Click
        SaveOrder()
    End Sub

    Private Sub frmNewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCustomerName()
        DisplayProductName()
    End Sub
End Class