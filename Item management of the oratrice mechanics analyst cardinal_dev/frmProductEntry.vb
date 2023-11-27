Imports MySql.Data.MySqlClient
Public Class frmProductEntry

    Private Sub SaveProductEntry()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet

        myConnection1 = Common.getDBConnectionX()

        Try
            myConnection1.Open()

            ' Generate a random product ID with a maximum length of 15 characters (uppercase letters)
            Dim productId As String = Guid.NewGuid().ToString().Substring(0, 15).ToUpper()

            ' Get values from textboxes
            Dim productName As String = tbProductNameEntry.Text
            Dim productPrice As Single = Single.Parse(tbProductPriceEntry.Text)
            Dim txtDescription As String = tbProductDescriptionEntry.Text

            ' Insert data into tblProducts
            myCommand1 = New MySqlCommand("INSERT INTO tblProducts (dproductid, dproductname, dprice, dtxtdescription) VALUES (@productId, @productName, @productPrice, @txtDescription)", myConnection1)
            myCommand1.Parameters.AddWithValue("@productId", productId)
            myCommand1.Parameters.AddWithValue("@productName", productName)
            myCommand1.Parameters.AddWithValue("@productPrice", productPrice)
            myCommand1.Parameters.AddWithValue("@txtDescription", txtDescription)

            ' Execute the SQL command
            myCommand1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
            MessageBox.Show("Success")
        End Try
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles lblProductName.Click

    End Sub

    Private Sub btnProductNameEntry_TextChanged(sender As Object, e As EventArgs) Handles btnProductNameEntry.TextChanged, tbProductNameEntry.TextChanged

    End Sub

    Private Sub btnProductPriceEntry_TextChanged(sender As Object, e As EventArgs) Handles btnProductPriceEntry.TextChanged, tbProductPriceEntry.TextChanged

    End Sub

    Private Sub btnProductDescriptionEntry_TextChanged(sender As Object, e As EventArgs) Handles btnProductDescriptionEntry.TextChanged, tbProductDescriptionEntry.TextChanged

    End Sub

    Private Sub frmProductEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveProductEntry()
    End Sub
End Class