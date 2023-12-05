Imports MySql.Data.MySqlClient
Public Class frmStockAdjustment

    Public Shared Property replenishorexhauset As Boolean = False
    'false = replenish
    'true = exhaust


    Private Sub DisplayStockAdjustment()
        Try
            ' Create a new MySqlConnection object using Using statement
            Using myConnection As MySqlConnection = Common.getDBConnectionX()
                ' Create a new MySqlCommand object
                Using myCommand As New MySqlCommand()
                    ' Set the MySqlCommand's Connection property
                    myCommand.Connection = myConnection

                    ' Set the MySqlCommand's CommandText property to the given query
                    myCommand.CommandText = "SELECT " &
                "dorigin as 'Origin', " &
                "dstockid as 'Stock ID', " &
                "tp.dproductname as 'Product Name', " &
                "tp.dproductid as 'Product ID', " &
                "dstockchangedate as 'Stock Change Date', " &
                "ABS(dquantitychanged) AS 'Quantity', " &
                "CONCAT(IF(dquantitychanged >= 0, '+', '-'), ABS(dquantitychanged)) AS 'Change', " &
                "SUM(dquantitychanged) OVER (PARTITION BY tp.dproductid ORDER BY dstockchangedate) AS 'Final Quantity' " &
                "FROM " &
                "tblstock ts " &
                "JOIN tblproducts tp ON ts.dproductid = tp.dproductid " &
                "ORDER BY " &
                "dstockchangedate"

                    ' Create a new MySqlDataAdapter object
                    Using myAdapter As New MySqlDataAdapter()
                        ' Set the MySqlDataAdapter's SelectCommand property
                        myAdapter.SelectCommand = myCommand

                        ' Create a new DataSet object
                        Using myDataSet As New DataSet()
                            ' Fill the DataSet object with the results of the query
                            myAdapter.Fill(myDataSet, "myData")

                            ' Clear existing columns in the DataGridView
                            dgvstockad.Columns.Clear()

                            ' Bind the DataSet object to the datagrid
                            dgvstockad.DataSource = myDataSet.Tables("myData")
                        End Using ' Dispose of DataSet
                    End Using ' Dispose of DataAdapter
                End Using ' Dispose of MySqlCommand
            End Using ' Dispose of MySqlConnection
        Catch ex As Exception
            ' Handle the exception (e.g., display an error message)
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






    Private Function IsStockIdUnique(stockId As String) As Boolean
        Dim myConnection As MySqlConnection = Common.getDBConnectionX()
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

    Private Sub SaveStock()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet

        myConnection1 = Common.getDBConnectionX()

        Try
            myConnection1.Open()

            ' Generate a random stock ID with a maximum length of 15 characters (uppercase letters)
            Dim stockId As String

            ' Ensure that the generated stockId is unique
            Do
                stockId = Guid.NewGuid().ToString().Substring(0, 15).ToUpper()
            Loop While Not IsStockIdUnique(stockId)

            ' Get values from textboxes
            Dim productId As String = tbProductID.Text
            Dim quantityChanged As Integer = Integer.Parse(tbProductQuantity.Text)
            Dim stockChangeDate As DateTime = DateTime.Now

            ' Set origin based on the text of btnReplenish
            Dim origin As String
            If btnReplenish.Text.Contains("Replenish") Then
                ' Only accept positive values for replenish
                If quantityChanged < 0 Then
                    MsgBox("Please enter a positive quantity for replenishing.")
                    Exit Sub
                End If
                origin = "Stock Adjustment (Replenish)"
            ElseIf btnReplenish.Text.Contains("Exhaust") Then
                ' Check if the latest sum is less than 0
                Dim latestSum As Integer = GetLatestSum(productId)

                ' Ensure that exhaust accepts only non-positive values
                If quantityChanged > 0 Then
                    MsgBox("Exhaust quantity is not allowed. Please enter a non-positive quantity.")
                    Exit Sub
                End If

                origin = "Stock Adjustment (Exhaust)"
            Else
                ' Handle other cases if needed
                MsgBox("Invalid operation.")
                Exit Sub
            End If

            ' Insert data into tblStock
            myCommand1 = New MySqlCommand("INSERT INTO tblStock (dorigin, dstockid, dproductid, dquantitychanged, dstockchangedate) VALUES (@origin, @stockId, @productId, @quantityChanged, @stockChangeDate)", myConnection1)
            myCommand1.Parameters.AddWithValue("@origin", origin)
            myCommand1.Parameters.AddWithValue("@stockId", stockId)
            myCommand1.Parameters.AddWithValue("@productId", productId)
            myCommand1.Parameters.AddWithValue("@quantityChanged", quantityChanged)
            myCommand1.Parameters.AddWithValue("@stockChangeDate", stockChangeDate)

            ' Execute the SQL command
            myCommand1.ExecuteNonQuery()

            DisplayStockAdjustment()

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try
    End Sub

    Private Function GetLatestSum(productId As String) As Integer
        ' Query the database to get the latest sum of dquantitychanged
        Dim query As String = "SELECT COALESCE(SUM(dquantitychanged), 0) AS latestSum FROM tblStock WHERE dproductid = @productId"

        Using myConnection As MySqlConnection = Common.getDBConnectionX()
            myConnection.Open()

            Using command As New MySqlCommand(query, myConnection)
                command.Parameters.AddWithValue("@productId", productId)

                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Return Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return 0
    End Function












    Private Sub DisplayProductName()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet

        myConnection1 = Common.getDBConnectionX()

        Try
            myConnection1.Open()
            myCommand1 = New MySqlCommand("SELECT dproductname FROM tblproducts", myConnection1)

            myAdapter2.SelectCommand = myCommand1
            myAdapter2.Fill(myDataSet2, "myData")


            ' Set the DataSource property to the DataTable
            cbProductName.DataSource = myDataSet2.Tables("myData")

            ' Set the DisplayMember property to the column you want to display in the ComboBox
            cbProductName.DisplayMember = "dproductname"

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try
    End Sub

    Private Sub DisplayProductID()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet

        myConnection1 = Common.getDBConnectionX()

        Try
            myConnection1.Open()

            ' Get the selected product name from the ComboBox
            Dim selectedProductName As String = cbProductName.Text

            ' Query to get the product ID based on the selected product name
            Dim productIdQuery As String = "SELECT dproductid FROM tblproducts WHERE dproductname = @productName"

            ' Use a MySqlCommand to execute the query
            myCommand1 = New MySqlCommand(productIdQuery, myConnection1)
            myCommand1.Parameters.AddWithValue("@productName", selectedProductName)

            ' Execute the query and get the result
            Dim productIdResult As Object = myCommand1.ExecuteScalar()

            ' Display the result in the TextBox
            If productIdResult IsNot Nothing Then
                tbProductID.Text = productIdResult.ToString()
            Else
                tbProductID.Text = "Product ID not found" ' or any default value
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            myConnection1.Close()
        End Try
    End Sub

    Private Sub replenish()
        replenishorexhauset = False
        btnReplenish.Text = "Replenish"
    End Sub

    Private Sub exhaust()
        replenishorexhauset = True
        btnReplenish.Text = "Exhaust"
    End Sub

    Private Sub btnReplenish_Click(sender As Object, e As EventArgs) Handles btnReplenish.Click
        If replenishorexhauset Then
            replenish()
        Else
            exhaust()
        End If
    End Sub

    Private Sub dgvstockad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvstockad.CellContentClick

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        SaveStock()
    End Sub

    Private Sub frmStockAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayStockAdjustment()
        DisplayProductName()
        replenish()

    End Sub

    Private Sub tbProductID_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProductName.SelectedIndexChanged
        DisplayProductID()
    End Sub


End Class