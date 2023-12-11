Imports System.IO
Imports System.Windows
Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class FrmOrderManagement
    Public Shared Property OrdermanagementstateEdit As Boolean = False



    Private Sub HandleException(ex As Exception)
        ' Log the exception for debugging purposes
        ' Consider using a logging library for better flexibility
        Console.WriteLine($"An error occurred: {ex.Message}")
        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub ExportDataGridViewToCSV(dataGridView As DataGridView, filePath As String)
        Try
            Using writer As New StreamWriter(filePath)
                ' Write the column headers to the CSV file
                Dim headerLine As String = String.Join(",", dataGridView.Columns.Cast(Of DataGridViewColumn).Select(Function(column) column.HeaderText))
                writer.WriteLine(headerLine)

                ' Write each row of data to the CSV file
                For Each row As DataGridViewRow In dataGridView.Rows
                    Dim dataLine As String = String.Join(",", row.Cells.Cast(Of DataGridViewCell)().Select(Function(cell) If(cell.Value IsNot Nothing, cell.Value.ToString(), "")))
                    writer.WriteLine(dataLine)
                Next
            End Using
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If OrdermanagementstateEdit Then
                ' If in edit mode, update the existing order
                Dim orderID As String = dgvOrderManagement.SelectedRows(0).Cells("dgvcOrderID").Value.ToString()
                Dim customerID As String = tbCustomerID.Text
                Dim productID As String = cmbProductID.Text
                Dim quantityOrdered As Integer = Convert.ToInt32(tbQuantity.Text)
                Dim status As String = dgvOrderManagement.SelectedRows(0).Cells("dgvcStatus").Value.ToString()


                UpdateOrderInDatabase(oldCustomerID, oldProductID, oldQuantityOrdered,
                                      customerID, productID, quantityOrdered)

                DisplayOrders()
                    ResetTextBoxes()


                    NotEdit()
            Else
                ' If not in edit mode, insert a new order
                Dim orderID As String = GenerateUniqueOrderID()
                Dim customerID As String = tbCustomerID.Text
                Dim productID As String = cmbProductID.Text
                Dim quantityOrdered As Integer = Convert.ToInt32(tbQuantity.Text)
                Dim status As String = "Queued"

                Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                    myConnection.Open()
                    InsertOrder(orderID, customerID, productID, quantityOrdered, status, myConnection)
                    DisplayOrders()
                    ResetTextBoxes()
                End Using
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub



    Private Sub UpdateOrder(orderID As String, customerID As String, productID As String, quantityOrdered As Integer, status As String, connection As MySqlConnection)
        ' Implement the update logic here if needed
        ' You can use a similar approach as in the InsertOrder method
        ' to update the order in tblorders and log the action in tbllogs
        ' ...
    End Sub

    Private Sub ResetTextBoxes()
        ' Reset and unlock textboxes
        tbCustomerID.Text = String.Empty
        tbCustomerName.Text = String.Empty
        cmbProductID.Text = String.Empty
        tbProductName.Text = String.Empty
        tbQuantity.Text = String.Empty

        tbCustomerID.Enabled = True
        tbCustomerName.Enabled = True
        cmbProductID.Enabled = True
        tbProductName.Enabled = True
        tbQuantity.Enabled = True
    End Sub

    Private Function IsStockIdUnique(stockId As String) As Boolean
        Dim myConnection As MySqlConnection = Common.GetDBConnectionX()
        Dim isUnique As Boolean = True

        Try
            myConnection.Open()

            Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblStock WHERE dstockid = @stockId", myConnection)
            checkCommand.Parameters.AddWithValue("@stockId", stockId)

            Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
            isUnique = (count = 0)

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            myConnection.Close()
        End Try

        Return isUnique
    End Function

    Private Sub InsertOrder(orderID As String, customerID As String, productID As String, quantityOrdered As Integer, status As String, connection As MySqlConnection)
        Try
            ' Generate the dateOrdered here
            Dim dateOrdered As DateTime = DateTime.Now

            Dim insertCommand As New MySqlCommand("INSERT INTO omac.tblorders (dorderid, dcustomerid, dproductid, dquantityordered, ddateordered, dstatus) VALUES (@orderID, @customerID, @productID, @quantityOrdered, @dateOrdered, @status)", connection)
            insertCommand.Parameters.AddWithValue("@orderID", orderID)
            insertCommand.Parameters.AddWithValue("@customerID", customerID)
            insertCommand.Parameters.AddWithValue("@productID", productID)
            insertCommand.Parameters.AddWithValue("@quantityOrdered", quantityOrdered)
            insertCommand.Parameters.AddWithValue("@dateOrdered", dateOrdered)
            insertCommand.Parameters.AddWithValue("@status", status)

            insertCommand.ExecuteNonQuery()

            Dim stockId As String

            Do
                stockId = Guid.NewGuid().ToString().Substring(0, 15).ToUpper()
            Loop While Not IsStockIdUnique(stockId)

            Dim origin As String = "Orders Managment"
            Dim productIdStock As String = productID
            Dim quantityChanged As Integer = quantityOrdered * -1
            Dim stockChangeDate As DateTime = DateTime.Now

            ' Insert data into tblStock
            insertCommand.CommandText = "INSERT INTO tblStock (dorigin, dstockid, dproductid, dquantitychanged, dstockchangedate) " &
                                    "VALUES (@origin, @stockId, @productIdStock, @quantityChanged, @stockChangeDate)"

            insertCommand.Parameters.AddWithValue("@origin", origin)
            insertCommand.Parameters.AddWithValue("@stockId", stockId)
            insertCommand.Parameters.AddWithValue("@productIdStock", productIdStock)
            insertCommand.Parameters.AddWithValue("@quantityChanged", quantityChanged)
            insertCommand.Parameters.AddWithValue("@stockChangeDate", stockChangeDate)

            insertCommand.ExecuteNonQuery()

            ' Log the action in tbllogs
            Dim editedData As String = $"{orderID} || {customerID} || {productID} || {quantityOrdered} || {dateOrdered} || {status}"
            LogCustomerAction("Add Order", customerID, editedData, connection)
        Catch ex As Exception
            MessageBox.Show($"An error occurred during order insertion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LogCustomerAction(action As String, customerID As String, editedData As String, connection As MySqlConnection)
        Try
            Dim logId As String = Guid.NewGuid().ToString().Substring(0, 20).ToUpper()
            Dim userId As String = frmLogin.UserIDusing ' Assuming that you have a Public Shared Property UserIDusing in frmLogin
            Dim location As String = "Order"
            Dim timestamp As DateTime = DateTime.Now

            Dim logCommand As New MySqlCommand("INSERT INTO tbllogs (dlogid, duid, dlocation, dedit, ttimestamp) VALUES (@logId, @userId, @location, @editedData, @timestamp)", connection)
            logCommand.Parameters.AddWithValue("@logId", logId)
            logCommand.Parameters.AddWithValue("@userId", userId)
            logCommand.Parameters.AddWithValue("@location", location)
            logCommand.Parameters.AddWithValue("@editedData", editedData)
            logCommand.Parameters.AddWithValue("@timestamp", timestamp)

            logCommand.ExecuteNonQuery()
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
                        ElseIf column.DataType Is GetType(DateTime) Then
                            ' Allow searching by date in the format dd/MM/yyyy hh:mmtt
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


    Private Sub DgvOrderManagement_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If Not OrdermanagementstateEdit Then
                ' If not in edit mode, toggle between "Queued" and "Delivered" for the "Status" column
                If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvOrderManagement.Columns("dgvcStatus").Index Then
                    Dim currentValue = dgvOrderManagement.Rows(e.RowIndex).Cells("dgvcStatus").Value.ToString

                    If currentValue = "Queued" Then
                        dgvOrderManagement.Rows(e.RowIndex).Cells("dgvcStatus").Value = "Delivered"
                    ElseIf currentValue = "Delivered" Then
                        dgvOrderManagement.Rows(e.RowIndex).Cells("dgvcStatus").Value = "Queued"
                    End If
                End If
            Else
                ' If in edit mode, populate textboxes with data from the clicked row
                If e.RowIndex >= 0 Then
                    tbCustomerID.Text = dgvOrderManagement.Rows(e.RowIndex).Cells("dgvcCustomerID").Value.ToString
                    tbCustomerName.Text = dgvOrderManagement.Rows(e.RowIndex).Cells("dgvcCustomerName").Value.ToString
                    cmbProductID.Text = dgvOrderManagement.Rows(e.RowIndex).Cells("dgvcProductID").Value.ToString
                    tbProductName.Text = dgvOrderManagement.Rows(e.RowIndex).Cells("dgvcProductName").Value.ToString
                    tbQuantity.Text = dgvOrderManagement.Rows(e.RowIndex).Cells("dgvcQuantity").Value.ToString

                    ' Lock textboxes
                    tbCustomerID.Enabled = False
                    tbCustomerName.Enabled = False
                    cmbProductID.Enabled = False
                    tbProductName.Enabled = False
                    tbQuantity.Enabled = False
                End If
            End If
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    Private Sub DisplayOrders()
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()
                Using myCommand As New MySqlCommand()
                    myCommand.Connection = myConnection
                    myCommand.CommandText = "SELECT " &
                    "tbo.dorderid AS 'Order ID', " &
                    "tbc.dcustomerid AS 'Customer ID', " &
                    "CONCAT(tbc.dcustomerfn, ' ', tbc.dcustomerln) AS 'Customer Name', " & ' Updated line
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




    Private Sub LoadCustomerNames()
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()
                Dim query As String = "SELECT CONCAT(tbc.dcustomerfn, ' ', tbc.dcustomerln) AS 'CustomerName' FROM omac.tblcustomers tbc"
                Using myCommand As New MySqlCommand(query, myConnection)
                    Using reader As MySqlDataReader = myCommand.ExecuteReader()
                        While reader.Read()
                            tbCustomerName.AutoCompleteCustomSource.Add(reader("CustomerName").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    Private Sub TbCustomerName_TextChanged(sender As Object, e As EventArgs) Handles tbCustomerName.TextChanged
        tbCustomerName.Text = tbCustomerName.Text.Trim()
        If tbCustomerName.AutoCompleteCustomSource.Contains(tbCustomerName.Text) Then
            ' Suggestion selected, fill the textbox
            FetchCustomerID(tbCustomerName.Text)
        End If
    End Sub


    Private Sub TbCustomerID_TextChanged(sender As Object, e As EventArgs) Handles tbCustomerID.TextChanged
        Try
            ' Use the FetchCustomerName method to get the corresponding customer name
            Dim customerName As String = FetchNameByID("tblcustomers", "dcustomerid", "CONCAT(dcustomerfn, ' ', dcustomerln)", tbCustomerID.Text)
            tbCustomerName.Text = customerName
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

    ' Add TextChanged event for tbProductName

    Private Sub TbProductName_TextChanged(sender As Object, e As EventArgs) Handles tbProductName.TextChanged
        tbProductName.Text = tbProductName.Text.Trim()
        If tbProductName.AutoCompleteCustomSource.Contains(tbProductName.Text) Then
            ' Suggestion selected, fill the textbox
            'FetchProductID(tbProductName.Text)
            FillProductIdComboBox(tbProductName.Text)
        End If
    End Sub

    ' Add TextChanged event for tbProductID
    'Private Sub TbProductID_TextChanged(sender As Object, e As EventArgs) Handles tbProductID.TextChanged
    '    Try
    '        ' Use the FetchProductName method to get the corresponding product name
    '        Dim productName As String = FetchNameByID("tblproducts", "dproductid", "dproductname", tbProductID.Text)
    '        tbProductName.Text = productName
    '    Catch ex As Exception
    '        HandleException(ex)
    '    End Try
    'End Sub

    ' Common method to fetch names by ID
    Private Function FetchNameByID(tableName As String, idColumn As String, nameColumn As String, id As String) As String
        Dim result As String = ""

        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Dim query As String = $"SELECT {nameColumn} FROM omac.{tableName} WHERE {idColumn} = @id"
                Using myCommand As New MySqlCommand(query, myConnection)
                    myCommand.Parameters.AddWithValue("@id", id)

                    Dim name As Object = myCommand.ExecuteScalar()

                    If name IsNot Nothing Then
                        result = name.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            HandleException(ex)
        End Try

        Return result
    End Function







    Private Sub LoadProductNames()
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Dim query As String = "SELECT dproductname FROM omac.tblproducts"
                Using myCommand As New MySqlCommand(query, myConnection)
                    Using reader As MySqlDataReader = myCommand.ExecuteReader()
                        While reader.Read()
                            tbProductName.AutoCompleteCustomSource.Add(reader("dproductname").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub






    Private Sub FetchCustomerID(customerName As String)
        tbCustomerID.Text = FetchIDByName("tblcustomers", "CONCAT(dcustomerfn, ' ', dcustomerln)", "dcustomerid", customerName)
    End Sub

    'Private Sub FetchProductID(productName As String)
    '    tbProductID.Text = FetchIDByName("tblproducts", "dproductname", "dproductid", productName)
    'End Sub





    Private Function FetchIDByName(tableName As String, nameColumn As String, idColumn As String, name As String) As String
        Dim result As String = ""

        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Dim query As String = $"SELECT {idColumn} FROM omac.{tableName} WHERE {nameColumn} = @name"
                Using myCommand As New MySqlCommand(query, myConnection)
                    myCommand.Parameters.AddWithValue("@name", name)

                    Dim id As Object = myCommand.ExecuteScalar()

                    If id IsNot Nothing Then
                        result = id.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            HandleException(ex)
        End Try

        Return result
    End Function







    Private Function GenerateUniqueOrderID() As String
        Dim orderID As String = ""
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()
                Dim query As String = "SELECT MAX(CAST(SUBSTRING(dorderid, 1, 15) AS UNSIGNED)) FROM omac.tblorders"
                Using getMaxOrderCommand As New MySqlCommand(query, myConnection)
                    Dim maxOrderNumber As Object = getMaxOrderCommand.ExecuteScalar()
                    Dim maxOrderNumberInt As Integer = If(maxOrderNumber Is DBNull.Value, 0, Convert.ToInt32(maxOrderNumber))
                    maxOrderNumberInt += 1
                    orderID = maxOrderNumberInt.ToString().PadLeft(15, "0"c)
                    If Not IsOrderIDUnique(orderID, myConnection) Then
                        orderID = GenerateUniqueOrderID()
                    End If
                End Using
            End Using
        Catch ex As Exception
            HandleException(ex)
        End Try
        Return orderID
    End Function



    Private Function GetAlphanumericOrderID(orderNumber As Integer) As String
        Dim letters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim result As String = ""

        While orderNumber > 0
            Dim remainder As Integer = (orderNumber - 1) Mod 26
            result = letters(remainder) & result
            orderNumber = (orderNumber - 1) \ 26
        End While

        Return result.PadLeft(10, "0"c)
    End Function



    Private Function IsOrderIDUnique(orderID As String, connection As MySqlConnection) As Boolean
        Dim isUnique As Boolean = True
        Try
            Dim query As String = "SELECT COUNT(*) FROM omac.tblorders WHERE dorderid = @orderID"
            Using checkCommand As New MySqlCommand(query, connection)
                checkCommand.Parameters.AddWithValue("@orderID", orderID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                isUnique = (count = 0)
            End Using
        Catch ex As Exception
            HandleException(ex)
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

    'Private Sub SearchProductByName(productName As String)
    '    Dim productID As String = GetProductIDByName(productName)
    '    tbProductID.Text = productID
    'End Sub

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

        btnEdit.Text = "Edit Order"

        btnDelete.Show()
        cmbProductID.Text = ""
        OrdermanagementstateEdit = False
        lblProductName.ForeColor = Color.FromArgb(153, 180, 209)
        lblProductID.ForeColor = Color.FromArgb(153, 180, 209)
        lblCustomerName.ForeColor = Color.FromArgb(153, 180, 209)
        lblCustomerID.ForeColor = Color.FromArgb(153, 180, 209)
        lblQuantity.ForeColor = Color.FromArgb(153, 180, 209)
        btnSave.Text = "Add"



    End Sub

    Private Sub deletemode()
        btnSave.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Private Sub notdeletemode()
        btnSave.Enabled = True
        btnEdit.Enabled = True

    End Sub

    Private Sub DeleteOrderRow()
        Try
            ' Ask user for OrderID using InputBox
            Dim orderID As String = InputBox("Enter OrderID to delete:", "Delete Order", "")

            ' Check if OrderID is provided
            If Not String.IsNullOrEmpty(orderID) Then
                ' Replace the sample query with your actual SQL DELETE query
                Dim deleteQuery As String = $"DELETE FROM omac.tblorders WHERE dorderid = '{orderID}'"

                ' Perform deletion in the database
                Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                    myConnection.Open()

                    Using myCommand As New MySqlCommand(deleteQuery, myConnection)
                        ' Execute the DELETE query
                        myCommand.ExecuteNonQuery()
                    End Using
                End Using

                ' Display success message
                MessageBox.Show($"Order with OrderID {orderID} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Display a message if OrderID is not provided
                MessageBox.Show("OrderID cannot be empty. Deletion canceled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Display an error message if an exception occurs
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteOrderRow()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCustomerName.Click, lblProduct.Click, lblQuantity.Click, lblProductName.Click

    End Sub

    Private Sub CheckUserAccessLevel()
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Dim checkCommand As New MySqlCommand("SELECT daccesslvl FROM omac.tblusers WHERE duid = @userId", myConnection)
                checkCommand.Parameters.AddWithValue("@userId", FrmLogin.UserIDusing)

                Dim accessLevel As String = Convert.ToString(checkCommand.ExecuteScalar())

                If accessLevel = "3" Then

                    ' Change the color of the buttons to indicate disabled state
                    btnExport.BackColor = Color.FromArgb(200, 200, 200)
                    btnEdit.BackColor = Color.FromArgb(200, 200, 200)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while checking user access level: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If Not frmOrderManagement.OrdermanagementstateEdit AndAlso Not FrmProductEntry.ProductentryEditmode Then
            If FrmLogin.UUserAccessLevel = 3 Then
                ' Display message box for access denied
                MessageBox.Show("Access Denied. Insufficient Privileges", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    ' Show a SaveFileDialog to specify the path for the CSV file
                    Using saveDialog As New SaveFileDialog()
                        saveDialog.Filter = "CSV files (*.csv)|*.csv"
                        saveDialog.Title = "Export to CSV"
                        If saveDialog.ShowDialog() = DialogResult.OK Then
                            ' Get the file path chosen by the user
                            Dim filePath As String = saveDialog.FileName

                            ' Export the DataGridView data to the CSV file
                            ExportDataGridViewToCSV(dgvOrderManagement, filePath)

                            MessageBox.Show("Data exported successfully!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                Catch ex As Exception
                    HandleException(ex)
                End Try
            End If
        Else
            MessageBox.Show("Exit edit mode")
        End If
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not OrdermanagementstateEdit Then
            ' Check access level
            If FrmLogin.UUserAccessLevel = 3 Then
                ' Display message box for access denied
                MessageBox.Show("Access Denied. Insufficient Privileges", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Onedit()
            End If
        Else
            NotEdit()
        End If
    End Sub

    Private Sub FrmOrderManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayOrders()
        LoadCustomerNames()
        LoadProductNames()
        CheckUserAccessLevel()
    End Sub



    Private Sub LogCustomerAction(action As String, customerID As String, editedData As String)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Dim logId As String = Guid.NewGuid().ToString().Substring(0, 20).ToUpper()
                Dim userId As String = FrmLogin.UserIDusing ' Assuming that you have a Public Shared Property UserIDusing in frmLogin
                Dim location As String = "Order Management"
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
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UpdateOrderInDatabase(oldCustomerID As String, oldProductID As String, oldQuantityOrdered As Integer,
                                  newCustomerID As String, newProductID As String, newQuantityOrdered As Integer)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Using myCommand As New MySqlCommand()
                    myCommand.Connection = myConnection

                    Dim updateQuery As String = "UPDATE omac.tblorders " &
                            "SET dcustomerid = @newCustomerID, " &
                            "    dproductid = @newProductID, " &
                            "    dquantityordered = @newQuantityOrdered " &
                            "WHERE dcustomerid = @oldCustomerID"



                    myCommand.CommandText = updateQuery
                    myCommand.Parameters.AddWithValue("@oldCustomerID", oldCustomerID)
                    myCommand.Parameters.AddWithValue("@newCustomerID", newCustomerID)
                    myCommand.Parameters.AddWithValue("@newProductID", newProductID)
                    myCommand.Parameters.AddWithValue("@newQuantityOrdered", newQuantityOrdered)



                    myCommand.ExecuteNonQuery()

                    'plan minus the old and new and add it in the data base
                End Using ' Dispose of MySqlCommand
            End Using ' Dispose of MySqlConnection

            ' Create a string with the new data
            Dim editedData As String = $"Old: {oldCustomerID} || {oldProductID} || {oldQuantityOrdered}|| ---- " &
                                   $"New: {newCustomerID} || {newProductID} || {newQuantityOrdered}"

            ' Insert into tbllogs
            LogCustomerAction("Update", oldCustomerID, editedData)

            ' After update, refresh the DataGridView
            DisplayOrders()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private oldCustomerID As String
    Private oldProductID As String
    Private oldQuantityOrdered As Integer


    Private Sub cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderManagement.CellClick
        If OrdermanagementstateEdit Then
            If dgvOrderManagement.SelectedRows.Count > 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = dgvOrderManagement.SelectedRows(0)

                ' Update textboxes with data from the selected row
                Dim seletedIDrow As String = selectedRow.Cells("dgvcOrderID").Value.ToString()
                oldCustomerID = selectedRow.Cells("dgvcCustomerID").Value.ToString()
                oldProductID = selectedRow.Cells("dgvcProductID").Value.ToString()
                oldQuantityOrdered = selectedRow.Cells("dgvcQuantity").Value


                tbCustomerName.Text = selectedRow.Cells("dgvcCustomerName").Value.ToString()
                tbCustomerID.Text = selectedRow.Cells("dgvcCustomerID").Value.ToString()
                tbProductName.Text = selectedRow.Cells("dgvcProductName").Value.ToString()
                cmbProductID.Text = selectedRow.Cells("dgvcProductID").Value.ToString()
                tbQuantity.Text = selectedRow.Cells("dgvcQuantity").Value
            End If

        End If
    End Sub

    '



    Private Sub FillProductIdComboBox(productName As String)
        Try
            ' Fetch product IDs from the database based on the product name
            Dim productIds As List(Of String) = GetProductIdsFromDatabase(productName)

            ' Bind the product IDs to the ComboBox
            cmbProductID.DataSource = productIds
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetProductIdsFromDatabase(productName As String) As List(Of String)
        Dim result As New List(Of String)

        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                ' Replace "YourTableName" with the actual name of the table
                ' Replace "ProductNameColumn" and "ProductIdColumn" with the actual column names
                Dim query As String = $"SELECT DISTINCT dproductid FROM tblproducts WHERE dproductname = @productName"

                Using myCommand As New MySqlCommand(query, myConnection)
                    myCommand.Parameters.AddWithValue("@productName", productName)

                    Using reader As MySqlDataReader = myCommand.ExecuteReader()
                        While reader.Read()
                            ' Add each product ID to the list
                            result.Add(reader("dproductid").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return result
    End Function




End Class