Imports MySql.Data.MySqlClient
Public Class frmCustomer

    Public Shared Property frmcustomereditmode As Boolean = True



    Private Sub DisplayCustomers()
        Try
            Using myConnection As MySqlConnection = Common.getDBConnectionX()
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


    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
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
            Using myConnection As MySqlConnection = Common.getDBConnectionX()
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
            End Using ' Dispose of MySqlConnection

            ' After insertion, refresh the DataGridView
            DisplayCustomers()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateCustomerInDatabase(customerID As String, lastName As String, firstName As String, companyName As String)
        Try
            Using myConnection As MySqlConnection = Common.getDBConnectionX()
                myConnection.Open()

                Using myCommand As New MySqlCommand()
                    myCommand.Connection = myConnection

                    myCommand.CommandText = "UPDATE omac.tblcustomers " &
                                       "SET dcustomerfn = @firstName, " &
                                       "    dcustomerln = @lastName, " &
                                       "    dcompanyname = @companyName " &
                                       "WHERE dcustomerid = @customerID"

                    myCommand.Parameters.AddWithValue("@customerID", customerID)
                    myCommand.Parameters.AddWithValue("@firstName", firstName)
                    myCommand.Parameters.AddWithValue("@lastName", lastName)
                    myCommand.Parameters.AddWithValue("@companyName", companyName)
                    DisplayCustomers()
                    myCommand.ExecuteNonQuery()
                End Using ' Dispose of MySqlCommand
            End Using ' Dispose of MySqlConnection
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub clear()
        tbCustomerID.Text = ""
        tbLastName.Text = ""
        tbFirstName.Text = ""
        tbCompanyName.Text = ""
    End Sub

    Private Sub OnEdit()
        btnEdit.ForeColor = Color.FromArgb(255, 249, 144)
        btnEdit.FillColor = Color.FromArgb(153, 180, 209)
        btnEdit.Text = "EDIT MODE"
        frmcustomereditmode = False



        bnAdd.Text = "Save"
        bnAdd.ForeColor = Color.FromArgb(255, 249, 144)
        bnAdd.FillColor2 = Color.FromArgb(153, 180, 209)

        lblID.ForeColor = Color.FromArgb(255, 249, 144)
        lblLastName.ForeColor = Color.FromArgb(255, 249, 144)
        lblfirstname.ForeColor = Color.FromArgb(255, 249, 144)
        lblCompanyName.ForeColor = Color.FromArgb(255, 249, 144)
    End Sub

    Private Sub notOnEdit()
        btnEdit.FillColor2 = Color.FromArgb(94, 148, 255)
        btnEdit.ForeColor = Color.White
        btnEdit.Text = "Edit"
        frmcustomereditmode = True

        bnAdd.Text = "Add"
        bnAdd.FillColor2 = Color.FromArgb(94, 148, 255)
        bnAdd.ForeColor = Color.White

        lblID.ForeColor = Color.FromArgb(153, 180, 209)
        lblLastName.ForeColor = Color.FromArgb(153, 180, 209)
        lblfirstname.ForeColor = Color.FromArgb(153, 180, 209)
        lblCompanyName.ForeColor = Color.FromArgb(153, 180, 209)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If frmcustomereditmode Then
            OnEdit()
        Else
            notOnEdit()
        End If
    End Sub

    Private Sub bnAdd_Click(sender As Object, e As EventArgs) Handles bnAdd.Click
        Dim customerID As String = tbCustomerID.Text
        Dim lastName As String = tbLastName.Text
        Dim firstName As String = tbFirstName.Text
        Dim companyName As String = tbCompanyName.Text

        If Not frmcustomereditmode Then
            'edit fuction here
            UpdateCustomerInDatabase(customerID, lastName, firstName, companyName)
            DisplayCustomers()
            clear()
            notOnEdit()
        Else
            'adding fuction here 

            InsertCustomer(customerID, lastName, firstName, companyName)
            clear()
        End If
    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCustomers()
    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick
        If Not frmcustomereditmode Then
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
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
            End If
        End If
    End Sub
End Class