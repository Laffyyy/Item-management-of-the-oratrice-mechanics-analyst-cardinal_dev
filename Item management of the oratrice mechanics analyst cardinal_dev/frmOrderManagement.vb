Imports System.Windows
Imports MySql.Data.MySqlClient

Public Class FrmOrderManagement
    Public Shared Property OrdermanagementstateEdit As Boolean = False



    Private Sub HandleException(ex As Exception)
        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If OrdermanagementstateEdit Then
                ' If in edit mode, update the existing order
                ' Implement the update logic here if needed
            Else
                ' If in add mode, insert a new order
                Dim orderID As String = GenerateUniqueOrderID()
                Dim customerID As String = tbCustomerID.Text
                Dim productID As String = tbProductID.Text
                Dim quantityOrdered As Integer = Convert.ToInt32(tbQuantity.Text)
                Dim status As String = "Queued"

                ' Insert into tblorders
                InsertOrder(orderID, customerID, productID, quantityOrdered, status)

                ' Refresh the DataGridView after insertion
                DisplayOrders()
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertOrder(orderID As String, customerID As String, productID As String, quantityOrdered As Integer, status As String)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                ' Generate the dateOrdered here
                Dim dateOrdered As DateTime = DateTime.Now

                Dim insertCommand As New MySqlCommand("INSERT INTO omac.tblorders (dorderid, dcustomerid, dproductid, dquantityordered, ddateordered, dstatus) VALUES (@orderID, @customerID, @productID, @quantityOrdered, @dateOrdered, @status)", myConnection)
                insertCommand.Parameters.AddWithValue("@orderID", orderID)
                insertCommand.Parameters.AddWithValue("@customerID", customerID)
                insertCommand.Parameters.AddWithValue("@productID", productID)
                insertCommand.Parameters.AddWithValue("@quantityOrdered", quantityOrdered)
                insertCommand.Parameters.AddWithValue("@dateOrdered", dateOrdered)
                insertCommand.Parameters.AddWithValue("@status", status)

                insertCommand.ExecuteNonQuery()

                ' Log the action in tbllogs
                Dim editedData As String = $"{orderID} || {customerID} || {productID} || {quantityOrdered} || {dateOrdered} || {status}"
                LogCustomerAction("Add Order", customerID, editedData)
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred during order insertion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LogCustomerAction(action As String, customerID As String, editedData As String)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Dim logId As String = Guid.NewGuid().ToString().Substring(0, 20).ToUpper()
                Dim userId As String = frmLogin.UserIDusing ' Assuming that you have a Public Shared Property UserIDusing in frmLogin
                Dim location As String = "Order"
                Dim timestamp As DateTime = DateTime.Now

                Dim logCommand As New MySqlCommand("INSERT INTO tbllogs (dlogid, duid, dlocation, dedit, ttimestamp) VALUES (@logId, @userId, @location, @editedData, @timestamp)", myConnection)
                logCommand.Parameters.AddWithValue("@logId", logId)
                logCommand.Parameters.AddWithValue("@userId", userId)
                logCommand.Parameters.AddWithValue("@location", location)
                logCommand.Parameters.AddWithValue("@editedData", editedData)
                logCommand.Parameters.AddWithValue("@timestamp", timestamp)

                logCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred during log insertion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Try
            Dim dataTable As DataTable = CType(dgvOrderManagement.DataSource, DataTable)

            If dataTable IsNot Nothing Then
                Dim filterExpression As String = String.Join(" OR ",
                dataTable.Columns.Cast(Of DataColumn)().Select(
                    Function(column)
                        If column.DataType Is GetType(String) Then
                            Return $"[{column.ColumnName}] LIKE '%{tbSearch.Text}%'"
                        ElseIf column.DataType Is GetType(Integer) Then
                            Return $"Convert([{column.ColumnName}], 'System.String') LIKE '%{tbSearch.Text}%'"
                        Else
                            Return String.Empty
                        End If
                    End Function).Where(Function(filter) Not String.IsNullOrEmpty(filter)))

                dataTable.DefaultView.RowFilter = filterExpression
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DisplayOrders()
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                Using myCommand As New MySqlCommand()
                    myCommand.Connection = myConnection
                    myCommand.CommandText = "SELECT " &
                    "tbo.dorderid AS 'Order ID', " &
                    "tbc.dcustomerid AS 'Customer ID', " &
                    "CONCAT(tbc.dcustomerln, ', ', tbc.dcustomerfn) AS 'Customer Name', " &
                    "tbo.dproductid AS 'Product ID', " &
                    "tbp.dproductname AS 'Product Name', " &
                    "tbo.dquantityordered AS 'Quantity Ordered', " &
                    "tbo.ddateordered AS 'Date Ordered', " &
                    "tbo.dstatus AS 'Status' " &
                    "FROM " &
                    "omac.tblorders AS tbo " &
                    "INNER JOIN omac.tblcustomers AS tbc ON tbc.dcustomerid = tbo.dcustomerid " &
                    "INNER JOIN omac.tblproducts AS tbp ON tbp.dproductid = tbo.dproductid"

                    Using myAdapter As New MySqlDataAdapter()
                        myAdapter.SelectCommand = myCommand

                        Using myDataSet As New DataSet()
                            myAdapter.Fill(myDataSet, "myData")

                            dgvOrderManagement.Columns("dgvcOrderID").DataPropertyName = "Order ID"
                            dgvOrderManagement.Columns("dgvcCustomerID").DataPropertyName = "Customer ID"
                            dgvOrderManagement.Columns("dgvcCustomerName").DataPropertyName = "Customer Name"
                            dgvOrderManagement.Columns("dgvcProductID").DataPropertyName = "Product ID"
                            dgvOrderManagement.Columns("dgvcProductName").DataPropertyName = "Product Name"
                            dgvOrderManagement.Columns("dgvcQuantity").DataPropertyName = "Quantity Ordered"
                            dgvOrderManagement.Columns("dgvcDateOrdered").DataPropertyName = "Date Ordered"
                            dgvOrderManagement.Columns("dgvcStatus").DataPropertyName = "Status"

                            dgvOrderManagement.DataSource = myDataSet.Tables("myData")
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub




    Private Sub TbCustomerName_TextChanged(sender As Object, e As EventArgs) Handles tbCustomerName.TextChanged
        AutoFillCustomerName(tbCustomerName.Text)
        FetchCustomerID(tbCustomerName.Text)
    End Sub

    Private Sub FetchCustomerID(customerName As String)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Dim query As String = "SELECT dcustomerid FROM omac.tblcustomers tc WHERE CONCAT(tc.dcustomerln, ', ', tc.dcustomerfn) = @customerName"
                Using myCommand As New MySqlCommand(query, myConnection)
                    myCommand.Parameters.AddWithValue("@customerName", customerName)

                    Dim customerID As Object = myCommand.ExecuteScalar()

                    If customerID IsNot Nothing Then
                        tbCustomerID.Text = customerID.ToString()
                    Else
                        tbCustomerID.Text = String.Empty
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TbProductName_TextChanged(sender As Object, e As EventArgs) Handles tbProductName.TextChanged
        AutoFillProductName(tbProductName.Text)
        FetchProductID(tbProductName.Text)
    End Sub

    Private Sub FetchProductID(productName As String)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Dim query As String = "SELECT dproductid FROM omac.tblproducts WHERE dproductname = @productName"
                Using myCommand As New MySqlCommand(query, myConnection)
                    myCommand.Parameters.AddWithValue("@productName", productName)

                    Dim productID As Object = myCommand.ExecuteScalar()

                    If productID IsNot Nothing Then
                        tbProductID.Text = productID.ToString()
                    Else
                        tbProductID.Text = String.Empty
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub AutoFillCustomerName(searchText As String)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Dim query As String = "SELECT CONCAT(tc.dcustomerln, ', ', tc.dcustomerfn) AS customer_name FROM tblcustomers tc WHERE CONCAT(tc.dcustomerln, ', ', tc.dcustomerfn) LIKE @searchText"
                Using myCommand As New MySqlCommand(query, myConnection)
                    myCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")

                    Using myAdapter As New MySqlDataAdapter(myCommand)
                        Using myDataSet As New DataSet()
                            myAdapter.Fill(myDataSet, "Customers")

                            If myDataSet.Tables("Customers").Rows.Count > 0 Then
                                ' Autofill textbox and provide a dropdown list
                                Dim autoComplete As New AutoCompleteStringCollection()
                                For Each row As DataRow In myDataSet.Tables("Customers").Rows
                                    autoComplete.Add(row("customer_name").ToString())
                                Next
                                tbCustomerName.AutoCompleteCustomSource = autoComplete
                                tbCustomerName.AutoCompleteMode = AutoCompleteMode.Suggest
                                tbCustomerName.AutoCompleteSource = AutoCompleteSource.CustomSource
                            Else
                                tbCustomerName.AutoCompleteCustomSource = Nothing
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AutoFillProductName(searchText As String)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Dim query As String = "SELECT dproductname FROM tblproducts WHERE dproductname LIKE @searchText"
                Using myCommand As New MySqlCommand(query, myConnection)
                    myCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")

                    Using myAdapter As New MySqlDataAdapter(myCommand)
                        Using myDataSet As New DataSet()
                            myAdapter.Fill(myDataSet, "Products")

                            If myDataSet.Tables("Products").Rows.Count > 0 Then
                                ' Autofill textbox and provide a dropdown list
                                Dim autoComplete As New AutoCompleteStringCollection()
                                For Each row As DataRow In myDataSet.Tables("Products").Rows
                                    autoComplete.Add(row("dproductname").ToString())
                                Next
                                tbProductName.AutoCompleteCustomSource = autoComplete
                                tbProductName.AutoCompleteMode = AutoCompleteMode.Suggest
                                tbProductName.AutoCompleteSource = AutoCompleteSource.CustomSource
                            Else
                                tbProductName.AutoCompleteCustomSource = Nothing
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Function GenerateUniqueOrderID() As String
        Dim charsAndNumbers As String = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim orderID As String = ""

        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Dim checkCommand As New MySqlCommand("SELECT MAX(CAST(SUBSTRING(dorderid, 1, 10) AS UNSIGNED)) FROM omac.tblorders", myConnection)

                Dim maxOrderNumber As Object = checkCommand.ExecuteScalar()

                If maxOrderNumber Is DBNull.Value Then
                    maxOrderNumber = 0
                End If

                Dim maxOrderNumberInt As Integer = Convert.ToInt32(maxOrderNumber)

                ' Increment the maximum order number
                maxOrderNumberInt += 1

                ' Convert the number to base 36 (A-Z and 0-9)
                Do While maxOrderNumberInt > 0
                    Dim remainder As Integer = maxOrderNumberInt Mod 36
                    orderID = charsAndNumbers(remainder) & orderID
                    maxOrderNumberInt \= 36
                Loop

                ' Ensure the order ID is 10 characters long
                orderID = orderID.PadLeft(10, "0"c)

                ' Check uniqueness
                Dim isUnique As Boolean = IsOrderIDUnique(orderID, checkCommand)

                ' If not unique, recursively call the function to generate a new one
                If Not isUnique Then
                    orderID = GenerateUniqueOrderID()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred during order ID generation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return orderID
    End Function

    Private Function IsOrderIDUnique(orderID As String, checkCommand As MySqlCommand) As Boolean
        Dim isUnique As Boolean = True
        checkCommand.Parameters.Clear()
        checkCommand.Parameters.AddWithValue("@orderID", orderID)

        Try
            Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
            isUnique = (count = 0)
        Catch ex As Exception
            MessageBox.Show($"An error occurred during order ID uniqueness check: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return isUnique
    End Function





    Private Function GetCustomerID(customerName As String) As String
        Return GetCustomerIDByName(customerName)
    End Function

    Private Function GetProductID(productName As String) As String
        Return GetProductIDByName(productName)
    End Function

    Private Sub SearchCustomerByName(customerName As String)
        Dim customerID As String = GetCustomerIDByName(customerName)
        tbCustomerID.Text = customerID
    End Sub

    Private Sub SearchProductByName(productName As String)
        Dim productID As String = GetProductIDByName(productName)
        tbProductID.Text = productID
    End Sub

    Private Function GetCustomerIDByName(customerName As String) As String
        Dim customerID As String = ""

        Return customerID
    End Function

    Private Function GetProductIDByName(productName As String) As String
        Dim productID As String = ""

        Return productID
    End Function













    Private Sub Onedit()
        btnEdit.ForeColor = Color.FromArgb(255, 249, 144)
        btnEdit.FillColor = Color.FromArgb(153, 180, 209)
        btnEdit.Text = "EDIT MODE"
        btnDelete.Hide()
        OrdermanagementstateEdit = True
        lblOrderID.ForeColor = Color.FromArgb(255, 249, 144)
        lblProductName.ForeColor = Color.FromArgb(255, 249, 144)
        lblProductID.ForeColor = Color.FromArgb(255, 249, 144)
        lblCustomerName.ForeColor = Color.FromArgb(255, 249, 144)
        lblCustomerID.ForeColor = Color.FromArgb(255, 249, 144)
        lblQuantity.ForeColor = Color.FromArgb(255, 249, 144)
        btnSave.Text = "Save"
    End Sub



    Private Sub NotEdit()
        btnEdit.ForeColor = Color.White
        btnEdit.FillColor = Color.FromArgb(94, 148, 255)
        dgvOrderManagement.DefaultCellStyle.BackColor = Color.FromArgb(90, 163, 216)
        btnEdit.Text = "Edit Order"

        btnDelete.Show()

        OrdermanagementstateEdit = False

        lblOrderID.ForeColor = Color.FromArgb(153, 180, 209)
        lblProductName.ForeColor = Color.FromArgb(153, 180, 209)
        lblProductID.ForeColor = Color.FromArgb(153, 180, 209)
        lblCustomerName.ForeColor = Color.FromArgb(153, 180, 209)
        lblCustomerID.ForeColor = Color.FromArgb(153, 180, 209)
        lblQuantity.ForeColor = Color.FromArgb(153, 180, 209)
        btnSave.Text = "Add"


    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not OrdermanagementstateEdit Then

            Onedit()
        Else

            NotEdit()
        End If

    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCustomerName.Click, lblProduct.Click, lblQuantity.Click, lblProductName.Click

    End Sub

    Private Sub FrmOrderManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayOrders()
    End Sub

    Private Sub DgvOrderManagement_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderManagement.CellContentClick, dgvOrderManagement.CellContentClick

    End Sub


End Class