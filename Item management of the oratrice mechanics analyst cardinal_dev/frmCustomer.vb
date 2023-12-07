Imports MySql.Data.MySqlClient
Public Class frmCustomer

    Public Shared Property frmcustomereditmode As Boolean = False



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







    Private Sub OnEdit()
        btnEdit.ForeColor = Color.FromArgb(255, 249, 144)
        btnEdit.FillColor = Color.FromArgb(153, 180, 209)
        btnEdit.Text = "EDIT MODE"
        frmcustomereditmode = False


        bnAdd.Text = "Save"
        bnAdd.ForeColor = Color.FromArgb(255, 249, 144)
        bnAdd.FillColor2 = Color.FromArgb(153, 180, 209)
    End Sub

    Private Sub notOnEdit()
        btnEdit.FillColor2 = Color.FromArgb(94, 148, 255)
        btnEdit.ForeColor = Color.White
        btnEdit.Text = "Edit"
        frmcustomereditmode = True

        bnAdd.Text = "Add"
        bnAdd.FillColor2 = Color.FromArgb(94, 148, 255)
        bnAdd.ForeColor = Color.White
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If frmcustomereditmode Then
            OnEdit()
        Else
            notOnEdit()
        End If
    End Sub

    Private Sub bnAdd_Click(sender As Object, e As EventArgs) Handles bnAdd.Click
        If frmcustomereditmode Then
            'edit fuction here
        Else
            'adding fuction here 
        End If
    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCustomers()
    End Sub
End Class