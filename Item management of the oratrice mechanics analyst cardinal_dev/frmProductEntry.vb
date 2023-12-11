﻿Imports System.IO
Imports MySql.Data.MySqlClient
Public Class FrmProductEntry

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        DisplayProducts()
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Function IsProductIdUnique(productId As String) As Boolean
        Dim myConnection As MySqlConnection = Common.GetDBConnectionX()
        Dim isUnique As Boolean = True

        Try
            myConnection.Open()

            Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM tblProducts WHERE dproductid = @productId", myConnection)
            checkCommand.Parameters.AddWithValue("@productId", productId)

            Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
            isUnique = (count = 0)

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            myConnection.Close()
        End Try

        Return isUnique
    End Function

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



    Private Function SaveProductEntry(ByVal productName As String, ByVal productPrice As Single, ByVal quantity As Integer, ByVal description As String, ByVal status As String, ByVal comments As String) As Boolean
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Using myCommand As New MySqlCommand()
                    myCommand.Connection = myConnection

                    ' Generate a random product ID with a maximum length of 10 characters (uppercase letters)
                    Dim productId As String

                    ' Ensure that the generated productId is unique
                    Do
                        productId = Guid.NewGuid().ToString().Substring(0, 10).ToUpper()
                    Loop While Not IsProductIdUnique(productId)

                    ' Insert data into tblProducts
                    myCommand.CommandText = "INSERT INTO omac.tblproducts (dproductid, dproductname, dprice, dtxtdescription, dstatus, dcomments) " &
                               "VALUES (@productId, @productName, @productPrice, @description, @status, @comments)"

                    myCommand.Parameters.AddWithValue("@productId", productId)
                    myCommand.Parameters.AddWithValue("@productName", productName)
                    myCommand.Parameters.AddWithValue("@productPrice", productPrice)
                    myCommand.Parameters.AddWithValue("@description", description)
                    myCommand.Parameters.AddWithValue("@status", status)
                    myCommand.Parameters.AddWithValue("@comments", comments)

                    myCommand.ExecuteNonQuery()

                    ' Generate a random stock ID with a maximum length of 15 characters (uppercase letters)
                    Dim stockId As String

                    Do
                        stockId = Guid.NewGuid().ToString().Substring(0, 15).ToUpper()
                    Loop While Not IsStockIdUnique(stockId)

                    Dim origin As String = "Product Entry"
                    Dim productIdStock As String = productId
                    Dim quantityChanged As Integer = quantity
                    Dim stockChangeDate As DateTime = DateTime.Now

                    ' Insert data into tblStock
                    myCommand.CommandText = "INSERT INTO tblStock (dorigin, dstockid, dproductid, dquantitychanged, dstockchangedate) " &
                                    "VALUES (@origin, @stockId, @productIdStock, @quantityChanged, @stockChangeDate)"

                    myCommand.Parameters.AddWithValue("@origin", origin)
                    myCommand.Parameters.AddWithValue("@stockId", stockId)
                    myCommand.Parameters.AddWithValue("@productIdStock", productIdStock)
                    myCommand.Parameters.AddWithValue("@quantityChanged", quantityChanged)
                    myCommand.Parameters.AddWithValue("@stockChangeDate", stockChangeDate)

                    myCommand.ExecuteNonQuery()
                End Using ' Dispose of MySqlCommand
            End Using ' Dispose of MySqlConnection

            ' After insertion, refresh the DataGridView or perform any other necessary actions

            Return True ' Indicate success
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Indicate failure
        End Try
    End Function



    Private Sub DisplayProducts()
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                Using myCommand As New MySqlCommand()
                    myCommand.Connection = myConnection

                    myCommand.CommandText = "SELECT " &
                    "tbp.dproductid AS dgvcID, " &
                    "tbp.dproductname AS dgvcProductName, " &
                    "tbp.dprice AS dgvcPrice, " &
                    "tbp.dtxtdescription AS dgvcdescription, " &
                    "tbp.dstatus AS dgvcStatus, " &
                    "COALESCE(SUM(tbs.dquantitychanged), 0) AS dgvcTotalQuantity " &
                    "FROM " &
                    "omac.tblproducts tbp " &
                    "LEFT JOIN " &  ' Use LEFT JOIN to include products without stock entries
                    "tblstock tbs ON tbs.dproductid = tbp.dproductid " &
                    "GROUP BY " &
                    "tbp.dproductid, tbp.dproductname, tbp.dprice, tbp.dtxtdescription, tbp.dstatus"

                    Using myAdapter As New MySqlDataAdapter()
                        myAdapter.SelectCommand = myCommand

                        Using myDataSet As New DataSet()
                            myAdapter.Fill(myDataSet, "myData")

                            dgvProducts.Columns("dgvcID").DataPropertyName = "dgvcID"
                            dgvProducts.Columns("dgvcProductName").DataPropertyName = "dgvcProductName"
                            dgvProducts.Columns("dgvcPrice").DataPropertyName = "dgvcPrice"
                            dgvProducts.Columns("dgvcdescription").DataPropertyName = "dgvcdescription"
                            dgvProducts.Columns("dgvcStatus").DataPropertyName = "dgvcStatus"
                            dgvProducts.Columns("dgvcTotalQuantity").DataPropertyName = "dgvcTotalQuantity"

                            dgvProducts.DataSource = myDataSet.Tables("myData")
                        End Using ' Dispose of DataSet
                    End Using ' Dispose of DataAdapter
                End Using ' Dispose of MySqlCommand
            End Using ' Dispose of MySqlConnection
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Public Shared Property ProductentryEditmode As Boolean = False

    Private Sub Onedit()
        btnEdit.ForeColor = Color.FromArgb(255, 249, 144)
        btnEdit.FillColor = Color.FromArgb(153, 180, 209)
        btnEdit.Text = "EDIT MODE"

        ProductentryEditmode = True

        tbQuantity.Enabled = False

        btnAdd.Text = "Save"
        lblProductName.ForeColor = Color.FromArgb(255, 249, 144)
        lblProductID.ForeColor = Color.FromArgb(255, 249, 144)
        lblProductPrice.ForeColor = Color.FromArgb(255, 249, 144)
        btnProductIDGenerator.Enabled = False
        lblStatus.ForeColor = Color.FromArgb(255, 249, 144)
        lblprodes.ForeColor = Color.FromArgb(255, 249, 144)
        lblComments.ForeColor = Color.FromArgb(255, 249, 144)
    End Sub

    Private Sub NotOnedit()
        btnEdit.ForeColor = Color.White
        btnEdit.FillColor = Color.FromArgb(94, 148, 255)
        btnEdit.Text = "Edit product"

        ProductentryEditmode = False

        tbQuantity.Enabled = True

        btnAdd.Text = "Add"

        lblProductName.ForeColor = Color.FromArgb(153, 180, 209)
        lblProductID.ForeColor = Color.FromArgb(153, 180, 209)
        lblProductPrice.ForeColor = Color.FromArgb(153, 180, 209)
        btnProductIDGenerator.Enabled = True
        lblStatus.ForeColor = Color.FromArgb(153, 180, 209)
        lblprodes.ForeColor = Color.FromArgb(153, 180, 209)
        lblComments.ForeColor = Color.FromArgb(153, 180, 209)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not ProductentryEditmode Then
            If FrmLogin.UUserAccessLevel = 3 Then
                ' Display message box for access denied
                MessageBox.Show("Access Denied. Insufficient Privileges", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Onedit()
            End If
        Else
            NotOnedit()
        End If
    End Sub




    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'If SaveProductEntry(tbProductNameEntry.Text, Convert.ToSingle(tbProductPriceEntry.Text), Convert.ToInt32(tbQuantity.Text), tbProductDescriptionEntry.Text, cbStatus.SelectedItem.ToString(), tbComments.Text) Then
        '    ' Successful insertion, perform any additional actions
        '    DisplayProducts()
        'Else
        '    ' Insertion failed, handle accordingly
        'End If

        Try
            ' Validate and convert input values
            Dim productPrice As Single
            Dim quantity As Integer

            If Single.TryParse(tbProductPriceEntry.Text, productPrice) AndAlso Integer.TryParse(tbQuantity.Text, quantity) Then
                ' Conversion successful, proceed with saving the data
                If SaveProductEntry(tbProductNameEntry.Text, productPrice, quantity, tbProductDescriptionEntry.Text, cbStatus.SelectedItem.ToString(), tbComments.Text) Then
                    ' The data was successfully saved
                    DisplayProducts()

                Else
                    ' Handle the case where saving failed
                End If
            Else
                ' Handle the case where input values are not in a valid numeric format
                MessageBox.Show("Invalid input format. Please enter valid numeric values for Price and Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Handle other exceptions
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub CheckUserAccessLevel()
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Dim checkCommand As New MySqlCommand("SELECT daccesslvl FROM omac.tblusers WHERE duid = @userId", myConnection)
                checkCommand.Parameters.AddWithValue("@userId", FrmLogin.UserIDusing)

                Dim accessLevel As String = Convert.ToString(checkCommand.ExecuteScalar())

                If accessLevel = "3" Then
                    btnExport.BackColor = Color.FromArgb(200, 200, 200)
                    btnEdit.BackColor = Color.FromArgb(200, 200, 200)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while checking user access level: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FrmProductEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbStatus.Items.AddRange({"Active", "Inactive"})
        cbStatus.SelectedIndex = 0 ' Set a default selection if needed
        DisplayProducts()
        CheckUserAccessLevel()
    End Sub





    Private Sub LblProductName_Click(sender As Object, e As EventArgs) Handles lblProductName.Click

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles lblQuantity.Click

    End Sub

    Private Sub TbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Try
            Dim dataTable As DataTable = CType(dgvProducts.DataSource, DataTable)

            If dataTable IsNot Nothing Then
                dataTable.DefaultView.RowFilter = $"CONVERT([dgvcID], 'System.String') LIKE '%{tbSearch.Text}%' OR " &
                                                 $"[dgvcProductName] LIKE '%{tbSearch.Text}%' OR " &
                                                 $"CONVERT([dgvcPrice], 'System.String') LIKE '%{tbSearch.Text}%' OR " &
                                                 $"[dgvcdescription] LIKE '%{tbSearch.Text}%' OR " &
                                                 $"[dgvcStatus] LIKE '%{tbSearch.Text}%' OR " &
                                                 $"CONVERT([dgvcTotalQuantity], 'System.String') LIKE '%{tbSearch.Text}%'"
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If FrmLogin.UUserAccessLevel = 3 Then
            ' Display message box for access denied
            MessageBox.Show("Access Denied. Insufficient Privileges", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Try
                Dim saveFileDialog As New SaveFileDialog With {
                    .Filter = "CSV files (*.csv)|*.csv",
                    .Title = "Export to CSV",
                    .FileName = "ProductsExport.csv"
                }

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    ExportToCSV(dgvProducts, saveFileDialog.FileName)
                    MessageBox.Show("Export completed successfully.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ExportToCSV(dataGridView As DataGridView, filePath As String)
        Using writer As New StreamWriter(filePath)
            ' Write the header
            Dim header = String.Join(",", dataGridView.Columns.Cast(Of DataGridViewColumn).Select(Function(column) column.HeaderText))
            writer.WriteLine(header)

            ' Write the data
            For Each row As DataGridViewRow In dataGridView.Rows
                Dim line = String.Join(",", row.Cells.Cast(Of DataGridViewCell).Select(Function(cell) If(cell.Value IsNot Nothing, cell.Value.ToString(), "")))
                writer.WriteLine(line)
            Next
        End Using
    End Sub
End Class