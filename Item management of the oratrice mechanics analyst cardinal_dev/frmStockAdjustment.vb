﻿Imports MySql.Data.MySqlClient
Public Class frmStockAdjustment
    Private Sub SaveStock()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet

        myConnection1 = Common.getDBConnectionX()

        Try
            myConnection1.Open()

            ' Generate a random stock ID with a maximum length of 15 characters
            Dim stockId As String = Guid.NewGuid().ToString().Substring(0, 15)

            ' Get values from textboxes
            Dim productId As String = tbProductID.Text
            Dim quantityStocked As Integer = Integer.Parse(tbProductQuantity.Text)
            Dim restockedDate As DateTime = DateTime.Now

            ' Insert data into tblStock
            myCommand1 = New MySqlCommand("INSERT INTO tblStock (dstockid, dproductid, dquantitystocked, drestockeddate) VALUES (@stockId, @productId, @quantityStocked, @restockedDate)", myConnection1)
            myCommand1.Parameters.AddWithValue("@stockId", stockId)
            myCommand1.Parameters.AddWithValue("@productId", productId)
            myCommand1.Parameters.AddWithValue("@quantityStocked", quantityStocked)
            myCommand1.Parameters.AddWithValue("@restockedDate", restockedDate)

            ' Execute the SQL command
            myCommand1.ExecuteNonQuery()

            DisplayStock()

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try
    End Sub


    Private Sub DisplayStock()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet

        myConnection1 = Common.getDBConnectionX()

        Try
            myConnection1.Open()

            myCommand1 = New MySqlCommand("SELECT tp.dproductname, ts.drestockeddate, ts.dquantitystocked FROM tblproducts tp JOIN tblstock ts ON ts.dproductid = tp.dproductid", myConnection1)

            myAdapter2.SelectCommand = myCommand1
            myAdapter2.Fill(myDataSet2, "myData")

            myDataSet2.Tables("myData").Columns("dproductname").ColumnName = "Product Name"
            myDataSet2.Tables("myData").Columns("drestockeddate").ColumnName = "Date of Restock"
            myDataSet2.Tables("myData").Columns("dquantitystocked").ColumnName = "Quantity"

            dgvstockad.DataSource = myDataSet2.Tables("myData")

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try
    End Sub

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




    Private Sub dgvstockad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvstockad.CellContentClick

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        SaveStock()
    End Sub

    Private Sub frmStockAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayStock()
        DisplayProductName()
    End Sub

    Private Sub tbProductID_TextChanged(sender As Object, e As EventArgs) Handles tbProductID.TextChanged

    End Sub

    Private Sub cbProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProductName.SelectedIndexChanged
        DisplayProductID()
    End Sub
End Class