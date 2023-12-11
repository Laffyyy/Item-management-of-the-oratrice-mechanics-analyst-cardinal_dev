Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class FrmCustomer

    Public Shared Property Frmcustomereditmode As Boolean = True



    Private Sub DisplayCustomers()
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                Using myCommand As New MySqlCommand()
                    myCommand.Connection = myConnection

                    myCommand.CommandText = "SELECT " &
                    "dcustomerid , " &
                    "dcustomerln , " &
                    "dcustomerfn , " &
                    "dcompanyname  " &
                    "FROM " &
                    "omac.tblcustomers"

                    Using myAdapter As New MySqlDataAdapter()
                        myAdapter.SelectCommand = myCommand

                        Using myDataSet As New DataSet()
                            myAdapter.Fill(myDataSet, "myData")

                            dgvCustomers.Columns("dgvcID").DataPropertyName = "dcustomerid"
                            dgvCustomers.Columns("dgvcCustomerLastName").DataPropertyName = "dcustomerln"
                            dgvCustomers.Columns("dgvcCustomerFirstName").DataPropertyName = "dcustomerfn"
                            dgvCustomers.Columns("dgvcCompanyName").DataPropertyName = "dcompanyname"


                            dgvCustomers.DataSource = myDataSet.Tables("myData")



                        End Using ' Dispose of DataSet
                    End Using ' Dispose of DataAdapter
                End Using ' Dispose of MySqlCommand
            End Using ' Dispose of MySqlConnection
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Try
            Dim dataTable As DataTable = CType(dgvCustomers.DataSource, DataTable)

            If dataTable IsNot Nothing Then
                dataTable.DefaultView.RowFilter = $"[dcustomerid] LIKE '%{tbSearch.Text}%' OR " &
                                             $"[dcustomerln] LIKE '%{tbSearch.Text}%' OR " &
                                             $"[dcustomerfn] LIKE '%{tbSearch.Text}%' OR " &
                                             $"[dcompanyname] LIKE '%{tbSearch.Text}%'"
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertCustomer(ByVal customerID As String, ByVal lastName As String, ByVal firstName As String, ByVal companyName As String)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Using myCommand As New MySqlCommand()
                    myCommand.Connection = myConnection

                    myCommand.CommandText = "INSERT INTO omac.tblcustomers (dcustomerid, dcustomerfn, dcustomerln, dcompanyname) " &
                           "VALUES (@customerID, @firstName, @lastName, @companyName)"

                    myCommand.Parameters.AddWithValue("@customerID", customerID)
                    myCommand.Parameters.AddWithValue("@firstName", firstName)
                    myCommand.Parameters.AddWithValue("@lastName", lastName)
                    myCommand.Parameters.AddWithValue("@companyName", companyName)

                    myCommand.ExecuteNonQuery()
                End Using ' Dispose of MySqlCommand

                ' Create a string with the new data
                Dim editedData As String = $"{customerID} || {firstName} || {lastName} || {companyName}"

                ' Insert into tbllogs
                LogCustomerAction("Add", customerID, editedData)

            End Using ' Dispose of MySqlConnection

            ' After insertion, refresh the DataGridView
            DisplayCustomers()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub UpdateCustomerInDatabase(oldCustomerID As String, newCustomerID As String, lastName As String, firstName As String, companyName As String)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Using myCommand As New MySqlCommand()
                    myCommand.Connection = myConnection

                    Dim updateQuery As String = "UPDATE omac.tblcustomers " &
                   "SET dcustomerfn = @firstName, " &
                   "    dcustomerln = @lastName, " &
                   "    dcompanyname = @companyName "

                    If Not String.IsNullOrEmpty(newCustomerID) Then
                        updateQuery &= ", dcustomerid = @newCustomerID "
                        myCommand.Parameters.AddWithValue("@newCustomerID", newCustomerID)


                    End If

                    updateQuery &= "WHERE dcustomerid = @oldCustomerID"

                    myCommand.CommandText = updateQuery
                    myCommand.Parameters.AddWithValue("@oldCustomerID", oldCustomerID)
                    myCommand.Parameters.AddWithValue("@firstName", firstName)
                    myCommand.Parameters.AddWithValue("@lastName", lastName)
                    myCommand.Parameters.AddWithValue("@companyName", companyName)

                    myCommand.ExecuteNonQuery()
                End Using ' Dispose of MySqlCommand
            End Using ' Dispose of MySqlConnection

            'Create a string with the new data
            Dim editedData As String = $"Old: {oldCustomerID} || {oldfirsName} || {oldlastname} || {oldcompany} || ---- New: {newCustomerID} || {firstName} || {lastName} || {companyName}"


            ' Insert into tbllogs
            LogCustomerAction("Update", oldCustomerID, editedData)

            ' After update, refresh the DataGridView
            DisplayCustomers()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub










    Private Sub LogCustomerAction(action As String, customerID As String, editedData As String)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Dim logId As String = Guid.NewGuid().ToString().Substring(0, 20).ToUpper()
                Dim userId As String = frmLogin.UserIDusing ' Assuming that you have a Public Shared Property UserIDusing in frmLogin
                Dim location As String = "Customer"
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





    Private Sub Clear()
        tbCustomerID.Text = ""
        tbLastName.Text = ""
        tbFirstName.Text = ""
        tbCompanyName.Text = ""
    End Sub

    Private Sub OnEdit()
        btnEdit.ForeColor = Color.FromArgb(255, 249, 144)
        btnEdit.FillColor = Color.FromArgb(153, 180, 209)
        btnEdit.Text = "EDIT MODE"
        Frmcustomereditmode = False



        btnAdd.Text = "Save"
        btnAdd.ForeColor = Color.FromArgb(255, 249, 144)
        btnAdd.FillColor2 = Color.FromArgb(153, 180, 209)

        lblID.ForeColor = Color.FromArgb(255, 249, 144)
        lblLastName.ForeColor = Color.FromArgb(255, 249, 144)
        lblfirstname.ForeColor = Color.FromArgb(255, 249, 144)
        lblCompanyName.ForeColor = Color.FromArgb(255, 249, 144)



    End Sub

    Private Sub NotOnEdit()
        btnEdit.FillColor2 = Color.FromArgb(94, 148, 255)
        btnEdit.ForeColor = Color.White
        btnEdit.Text = "Edit"
        Frmcustomereditmode = True

        btnAdd.Text = "Add"
        btnAdd.FillColor2 = Color.FromArgb(94, 148, 255)
        btnAdd.ForeColor = Color.White

        lblID.ForeColor = Color.FromArgb(153, 180, 209)
        lblLastName.ForeColor = Color.FromArgb(153, 180, 209)
        lblfirstname.ForeColor = Color.FromArgb(153, 180, 209)
        lblCompanyName.ForeColor = Color.FromArgb(153, 180, 209)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Frmcustomereditmode Then
            OnEdit()
        Else
            NotOnEdit()
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim customerID = tbCustomerID.Text
        Dim lastName = tbLastName.Text
        Dim firstName = tbFirstName.Text
        Dim companyName = tbCompanyName.Text

        If Not Frmcustomereditmode Then
            'edit fuction here
            UpdateCustomerInDatabase(oldID, customerID, lastName, firstName, companyName)
            DisplayCustomers()
            Clear()
            NotOnEdit()

        Else
            'adding fuction here 

            InsertCustomer(customerID, lastName, firstName, companyName)
            Clear()
            MessageBox.Show("Magic")
        End If

    End Sub

    Private Sub FrmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCustomers()
    End Sub

    Private oldID As String
    Private oldlastname As String
    Private oldfirsName As String
    Private oldcompany As String
    Private Sub DgvCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick
        If Not Frmcustomereditmode AndAlso e.RowIndex >= 0 Then
            ' Access the data from the clicked row
            Dim selectedRow As DataGridViewRow = dgvCustomers.Rows(e.RowIndex)

            ' Assuming you have columns named dgvcID, dgvcCustomerLastName, dgvcCustomerFirstName, dgvcCompanyName
            Dim customerID As String = selectedRow.Cells("dgvcID").Value.ToString()
            Dim lastName As String = selectedRow.Cells("dgvcCustomerLastName").Value.ToString()
            Dim firstName As String = selectedRow.Cells("dgvcCustomerFirstName").Value.ToString()
            Dim companyName As String = selectedRow.Cells("dgvcCompanyName").Value.ToString()

            ' Display the data in textboxes
            tbCustomerID.Text = customerID
            tbLastName.Text = lastName
            tbFirstName.Text = firstName
            tbCompanyName.Text = companyName

            oldID = customerID
            oldlastname = lastName
            oldfirsName = firstName
            oldcompany = companyName
        End If
    End Sub



End Class