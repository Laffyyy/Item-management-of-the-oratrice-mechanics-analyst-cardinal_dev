Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frmAccountAdjustment

    Public Shared Property Frmaccountadjustmentedit As Boolean = False

    Private Sub HandleException(ex As Exception)
        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub ExportDataTableToCSV(dataTable As DataTable, filePath As String)
        Try
            Using writer As New StreamWriter(filePath)
                ' Write the column headers to the CSV file
                Dim headerLine As String = String.Join(",", dataTable.Columns.Cast(Of DataColumn).Select(Function(column) column.ColumnName))
                writer.WriteLine(headerLine)

                ' Write each row of data to the CSV file
                For Each row As DataRow In dataTable.Rows
                    Dim dataLine As String = String.Join(",", row.ItemArray.Select(Function(cell) cell.ToString()))
                    writer.WriteLine(dataLine)
                Next
            End Using
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub


    Private Sub DisplayAccounts()
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                Using myCommand As New MySqlCommand()
                    myCommand.Connection = myConnection

                    myCommand.CommandText = "SELECT 
                    duid as 'ID', 
                    demployeefn as 'emplfn',
                    demployeeln as 'employeeln',
                    dpassword as 'pass',  
                    daccesslvl as 'Access Level' 
                FROM omac.tblusers;"

                    Using myAdapter As New MySqlDataAdapter()
                        myAdapter.SelectCommand = myCommand

                        Using myDataSet As New DataSet()
                            myAdapter.Fill(myDataSet, "myData")

                            dgvUserInfo.Columns("dgvcID").DataPropertyName = "ID"
                            dgvUserInfo.Columns("dgvcFirstname").DataPropertyName = "emplfn"
                            dgvUserInfo.Columns("dgvcLastName").DataPropertyName = "employeeln"
                            dgvUserInfo.Columns("dgvcPassword").DataPropertyName = "pass"
                            dgvUserInfo.Columns("dgvcAccesslvl").DataPropertyName = "Access Level"

                            dgvUserInfo.DataSource = myDataSet.Tables("myData")

                            ' Handle the CellFormatting event to convert integer to string
                            AddHandler dgvUserInfo.CellFormatting, AddressOf dgvUserInfo_CellFormatting
                        End Using ' Dispose of DataSet
                    End Using ' Dispose of DataAdapter
                End Using ' Dispose of MySqlCommand
            End Using ' Dispose of MySqlConnection
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvUserInfo_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUserInfo.CellFormatting
        If e.ColumnIndex = dgvUserInfo.Columns("dgvcAccesslvl").Index AndAlso e.Value IsNot Nothing Then
            ' Attempt to convert the value to an integer using a safer method
            Dim accessLevel As Integer
            If Integer.TryParse(e.Value.ToString(), accessLevel) Then
                ' Conversion successful, update the display value
                Select Case accessLevel
                    Case 1
                        e.Value = "Admin"
                    Case 2
                        e.Value = "Manager"
                    Case 3
                        e.Value = "Employee"
                        ' Add more cases if needed
                    Case Else
                        ' Handle other cases or leave it as is
                End Select
            Else
                ' Unable to convert to integer, leave it as is
                e.Value = e.Value.ToString()
            End If
        End If
    End Sub




    Private Sub InsertNewuser(ByVal userID As String, ByVal lastName As String, ByVal firstName As String, ByVal Password As String, ByVal role As Int16)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Using myCommand As New MySqlCommand()
                    myCommand.Connection = myConnection

                    myCommand.CommandText = "INSERT INTO `omac`.`tblusers` 
                       (`duid`, `demployeefn`, `demployeeln`, `dpassword`, `daccesslvl`) 
                        VALUES ('@id', '@firstname', '@lastname', '@password', '@access');
"

                    myCommand.Parameters.AddWithValue("@id", userID)
                    myCommand.Parameters.AddWithValue("@firstname", firstName)
                    myCommand.Parameters.AddWithValue("@lastName", lastName)
                    myCommand.Parameters.AddWithValue("@password", Password)
                    myCommand.Parameters.AddWithValue("@access", role)

                    myCommand.ExecuteNonQuery()
                End Using ' Dispose of MySqlCommand

                ' Create a string with the new data
                Dim editedData As String = $""

                ' Insert into tbllogs
                LogAccountAdjustment("Add", editedData)

            End Using ' Dispose of MySqlConnection

            ' After insertion, refresh the DataGridView
            DisplayAccounts()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertUserInfo(newUserID As String, firstName As String, lastName As String, password As String, accessLevel As Integer)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Using myCommand As New MySqlCommand()
                    myCommand.Connection = myConnection

                    myCommand.CommandText = "INSERT INTO omac.tblusers (duid, demployeefn, demployeeln, dpassword, daccesslvl) VALUES (@duid, @firstName, @lastName, @password, @accessLevel)"

                    ' Assuming duid is an auto-incremented primary key
                    ' You might want to adjust this logic based on your actual database schema

                    myCommand.Parameters.AddWithValue("@duid", newUserID)
                    myCommand.Parameters.AddWithValue("@firstName", firstName)
                    myCommand.Parameters.AddWithValue("@lastName", lastName)
                    myCommand.Parameters.AddWithValue("@password", password)
                    myCommand.Parameters.AddWithValue("@accessLevel", accessLevel)

                    myCommand.ExecuteNonQuery()
                End Using ' Dispose of MySqlCommand
            End Using ' Dispose of MySqlConnection

            ' Create a string with the new data
            Dim editedData As String = $"ADDED:{newUserID} || {firstName} || {lastName} || {password} || {cmbAccessLevel.SelectedItem}"

            ' Insert into tbllogs
            LogAccountAdjustment("ADD", editedData)

            ' After insertion, refresh the DataGridView
            DisplayAccounts()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UpdateUserInDatabase(oldUserID As String, newUserID As String, firstName As String, lastName As String, password As String)
        Try
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                myConnection.Open()

                Using myCommand As New MySqlCommand()
                    myCommand.Connection = myConnection

                    Dim updateQuery As String = "UPDATE omac.tblusers " &
                "SET demployeefn = @firstName, " &
                "    demployeeln = @lastName, " &
                "    dpassword = @password, " &
                "    daccesslvl = @role "

                    If Not String.IsNullOrEmpty(newUserID) Then
                        updateQuery &= ", duid = @newUserID "
                        myCommand.Parameters.AddWithValue("@newUserID", newUserID)
                    End If

                    updateQuery &= "WHERE duid = @oldUserID"

                    myCommand.CommandText = updateQuery
                    myCommand.Parameters.AddWithValue("@oldUserID", oldUserID)
                    myCommand.Parameters.AddWithValue("@firstName", firstName)
                    myCommand.Parameters.AddWithValue("@lastName", lastName)
                    myCommand.Parameters.AddWithValue("@password", password)
                    myCommand.Parameters.AddWithValue("@role", MapRoleToIndex(cmbAccessLevel.SelectedItem.ToString()))

                    myCommand.ExecuteNonQuery()
                End Using ' Dispose of MySqlCommand
            End Using ' Dispose of MySqlConnection



            ' Create a string with the new data
            Dim editedData As String = $"Old: {oldID} || {oldfirstname} || {oldlastname} || {oldpass} || {oldrole} || ---- New: {newUserID} || {firstName} || {lastName} || {password} || {cmbAccessLevel.SelectedItem}"

            ' Insert into tbllogs
            LogAccountAdjustment("Update", editedData)

            ' After update, refresh the DataGridView
            DisplayAccounts()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function MapIndexToRole(index As Integer) As String
        ' Map index to the corresponding role string
        Select Case index
            Case 1
                Return "Admin"
            Case 2
                Return "Manager"
            Case 3
                Return "Employee"
            Case Else
                ' Handle other cases or return a default value
                Return ""
        End Select
    End Function



    Private Sub LogAccountAdjustment(action As String, editedData As String)
        Try
            Using myConnection As MySqlConnection = Common.getDBConnectionX()
                myConnection.Open()

                Dim logId As String = Guid.NewGuid().ToString().Substring(0, 20).ToUpper()
                Dim userId As String = frmLogin.UserIDusing ' Assuming that you have a Public Shared Property UserIDusing in frmLogin
                Dim location As String = "AccountAdjustment"
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



    Private Function MapRoleToIndex(role As String) As Integer
        ' Map role to index
        Select Case role.ToLower()
            Case "admin"
                Return 1
            Case "manager"
                Return 2
            Case "employee"
                Return 3
            Case Else
                ' Handle other cases or return a default value
                Return 0
        End Select
    End Function



    Private Sub Onedit()
        frmaccountadjustmentedit = True
        btnEdit.ForeColor = Color.FromArgb(255, 249, 144)
        btnEdit.FillColor = Color.FromArgb(153, 180, 209)
        btnEdit.Text = "EDIT MODE"

        btnAdd.Text = "Save"
        btnAdd.ForeColor = Color.FromArgb(255, 249, 144)
        btnAdd.FillColor2 = Color.FromArgb(153, 180, 209)

        lblID.ForeColor = Color.FromArgb(255, 249, 144)
        lblPassword.ForeColor = Color.FromArgb(255, 249, 144)
        lblLastName.ForeColor = Color.FromArgb(255, 249, 144)
        lblFirstName.ForeColor = Color.FromArgb(255, 249, 144)
        lblrole.ForeColor = Color.FromArgb(255, 249, 144)


    End Sub

    Private Sub NotEdit()
        Frmaccountadjustmentedit = False
        btnEdit.ForeColor = Color.White
        btnEdit.FillColor = Color.FromArgb(94, 148, 255)
        btnEdit.Text = "Edit Account"

        btnAdd.Text = "Add"
        btnAdd.ForeColor = Color.White
        btnAdd.FillColor2 = Color.FromArgb(94, 148, 255)

        lblID.ForeColor = Color.FromArgb(153, 180, 209)
        lblPassword.ForeColor = Color.FromArgb(153, 180, 209)
        lblLastName.ForeColor = Color.FromArgb(153, 180, 209)
        lblFirstName.ForeColor = Color.FromArgb(153, 180, 209)
        lblrole.ForeColor = Color.FromArgb(153, 180, 209)



    End Sub


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If frmaccountadjustmentedit Then
            notEdit()

        Else

            Onedit()
        End If
    End Sub

    Private Sub Add(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not frmaccountadjustmentedit Then
            ' add user
            Try
                ' Check if an item is selected in the ComboBox
                If cmbAccessLevel.SelectedItem IsNot Nothing Then
                    ' Convert the selected role name to the corresponding integer value
                    Dim selectedRole As String = cmbAccessLevel.SelectedItem.ToString()
                    Dim accessLevel As Integer = accessLevelMapping(selectedRole)

                    ' Insert the user information into the database
                    InsertUserInfo(tbID.Text, tbFirstname.Text, tbLastname.Text, tbPassword.Text, accessLevel)
                Else
                    MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            UpdateUserInDatabase(oldID, tbID.Text, tbFirstname.Text, tbLastname.Text, tbPassword.Text)

        End If
    End Sub


    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbLastname.TextChanged, tbPassword.TextChanged

    End Sub

    Private Sub FrmAccountAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAccounts()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbFirstname.TextChanged, tbID.TextChanged

    End Sub

    Private oldID As String
    Private oldfirstname As String
    Private oldlastname As String
    Private oldpass As String
    Private oldrole As String

    Private accessLevelMapping As New Dictionary(Of String, Integer) From {
    {"Admin", 1},
    {"Manager", 2},
    {"Employee", 3}
}
    Private Sub Cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserInfo.CellClick
        If frmaccountadjustmentedit AndAlso e.RowIndex >= 0 Then
            ' Access the data from the clicked row
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dgvUserInfo.SelectedRows(0)

            'for oldID
            oldID = selectedRow.Cells("dgvcID").Value.ToString()
            oldfirstname = selectedRow.Cells("dgvcFirstname").Value.ToString()
            oldlastname = selectedRow.Cells("dgvcLastName").Value.ToString()
            oldpass = selectedRow.Cells("dgvcPassword").Value.ToString()
            ' Populate TextBoxes
            tbID.Text = selectedRow.Cells("dgvcID").Value.ToString()
            tbFirstname.Text = selectedRow.Cells("dgvcFirstname").Value.ToString()
            tbLastname.Text = selectedRow.Cells("dgvcLastName").Value.ToString()
            tbPassword.Text = selectedRow.Cells("dgvcPassword").Value.ToString()

            ' Populate ComboBox for Access Level
            Dim accessLevel As Integer = Convert.ToInt32(selectedRow.Cells("dgvcAccesslvl").Value)
            Dim roleName As String = accessLevelMapping.FirstOrDefault(Function(pair) pair.Value = accessLevel).Key
            cmbAccessLevel.SelectedItem = roleName

            oldrole = roleName
        End If

    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            ' Fetch the data from the database and store it in a DataTable
            Dim dataTable As New DataTable()
            Using myConnection As MySqlConnection = Common.GetDBConnectionX()
                Using myCommand As New MySqlCommand("SELECT * FROM omac.tbllogs", myConnection)
                    Using myAdapter As New MySqlDataAdapter(myCommand)
                        myAdapter.Fill(dataTable)
                    End Using
                End Using
            End Using

            ' Show a SaveFileDialog to specify the path for the CSV file
            Using saveDialog As New SaveFileDialog()
                saveDialog.Filter = "CSV files (*.csv)|*.csv"
                saveDialog.Title = "Export to CSV"
                If saveDialog.ShowDialog() = DialogResult.OK Then
                    ' Get the file path chosen by the user
                    Dim filePath As String = saveDialog.FileName

                    ' Export the DataTable data to the CSV file
                    ExportDataTableToCSV(dataTable, filePath)

                    MessageBox.Show("Data exported successfully!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

End Class