Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class frmOrderManagement

    Public Shared Property ordermanagementstateEdit As Boolean = False


    Private Sub DisplayOrders()
        Try
            Using myConnection As MySqlConnection = Common.getDBConnectionX()
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
                        End Using ' Dispose of DataSet
                    End Using ' Dispose of DataAdapter
                End Using ' Dispose of MySqlCommand
            End Using ' Dispose of MySqlConnection
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Onedit()
        btnEdit.ForeColor = Color.FromArgb(255, 249, 144)
        btnEdit.FillColor = Color.FromArgb(153, 180, 209)
        'remove left
        btnEdit.Text = "EDIT MODE"

        btnDelete.Hide()
        'if on edit mode its ok to go to other form but not log out and close program
        ordermanagementstateEdit = True

        lblOrderID.ForeColor = Color.FromArgb(255, 249, 144)
        lblCustomerName.ForeColor = Color.FromArgb(255, 249, 144)
        lblProduct.ForeColor = Color.FromArgb(255, 249, 144)
        lblQuantity.ForeColor = Color.FromArgb(255, 249, 144)
        bntSave.Text = "Save"
    End Sub

    Private Sub NotEdit()
        btnEdit.ForeColor = Color.White
        btnEdit.FillColor = Color.FromArgb(94, 148, 255)
        dgvOrderManagement.DefaultCellStyle.BackColor = Color.FromArgb(90, 163, 216)
        btnEdit.Text = "Edit Order"

        btnDelete.Show()

        ordermanagementstateEdit = False

        lblOrderID.ForeColor = Color.FromArgb(153, 180, 209)
        lblCustomerName.ForeColor = Color.FromArgb(153, 180, 209)
        lblProduct.ForeColor = Color.FromArgb(153, 180, 209)
        lblQuantity.ForeColor = Color.FromArgb(153, 180, 209)
        bntSave.Text = "Add"


    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not ordermanagementstateEdit Then

            Onedit()
        Else

            NotEdit()
        End If

    End Sub

    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click

    End Sub

    'Private Sub btnNeworders_Click(sender As Object, e As EventArgs) Handles btnNeworders.Click
    '    If Not frmOrderManagement.ordermanagementstateEdit Then


    '        frmMain.OpenChildrenform(New frmNewOrders)
    '        frmMain.pubreset()

    '    Else

    '        MessageBox.Show("Exit edit mode")
    '    End If

    'End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCustomerName.Click, lblProduct.Click, lblQuantity.Click

    End Sub

    Private Sub frmOrderManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayOrders()
    End Sub

    Private Sub dgvOrderManagement_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderManagement.CellContentClick, dgvOrderManagement.CellContentClick

    End Sub


End Class