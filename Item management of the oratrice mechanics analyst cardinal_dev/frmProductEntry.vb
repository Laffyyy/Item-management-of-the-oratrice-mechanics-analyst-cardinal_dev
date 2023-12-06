Imports MySql.Data.MySqlClient
Public Class frmProductEntry

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Displayproduct()
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Function IsProductIdUnique(productId As String) As Boolean
        Dim myConnection As MySqlConnection = Common.getDBConnectionX()
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

    Private Sub SaveProductEntry()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet

        myConnection1 = Common.getDBConnectionX()

        Try
            myConnection1.Open()

            ' Generate a random product ID with a maximum length of 10 characters (uppercase letters)
            Dim productId As String

            ' Ensure that the generated productId is unique
            Do
                productId = Guid.NewGuid().ToString().Substring(0, 10).ToUpper()
            Loop While Not IsProductIdUnique(productId)

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





    Public Shared Property productentryEditmode As Boolean = False

    Private Sub Onedit()
        btnEdit.ForeColor = Color.FromArgb(255, 249, 144)
        btnEdit.FillColor = Color.FromArgb(153, 180, 209)
        btnEdit.Text = "EDIT MODE"

        productentryEditmode = True

        tbQuantity.Enabled = False

        btnSave.Text = "Edit"
    End Sub

    Private Sub notOnedit()
        btnEdit.ForeColor = Color.White
        btnEdit.FillColor = Color.FromArgb(94, 148, 255)
        btnEdit.Text = "Edit product"

        productentryEditmode = False

        tbQuantity.Enabled = True

        btnSave.Text = "Save"
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not productentryEditmode Then
            Onedit()
        Else
            notOnedit()
        End If
    End Sub

    Private Sub Displayproduct()
        Dim myConnection1 As MySqlConnection
        Dim myCommand1 As MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim myDataSet2 As New DataSet


        myConnection1 = Common.getDBConnectionX()

        Try
            myConnection1.Open()

            myCommand1 = New MySqlCommand("SELECT dproductname, dprice, dtxtdescription FROM tblproducts", myConnection1)

            myAdapter2.SelectCommand = myCommand1
            myAdapter2.Fill(myDataSet2, "myData")

            ''myDataSet2.Tables("myData").Columns("dproductname").ColumnName = "Product Name"
            ''myDataSet2.Tables("myData").Columns("dprice").ColumnName = "Price"
            dgvProducts.Columns("dgvcPrice").DataPropertyName = "dprice"
            dgvProducts.Columns("dgvcProductName").DataPropertyName = "dproductname"
            dgvProducts.Columns("dgvcdescription").DataPropertyName = "dtxtdescription"


            dgvProducts.DataSource = myDataSet2.Tables("myData")

        Catch ex As Exception
            MsgBox(Err.Description)
            Exit Sub
        Finally
            myConnection1.Close()
        End Try
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveProductEntry()
    End Sub


    Private Sub frmProductEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub





    Private Sub lblProductName_Click(sender As Object, e As EventArgs) Handles lblProductName.Click

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles lblQuantity.Click

    End Sub
End Class