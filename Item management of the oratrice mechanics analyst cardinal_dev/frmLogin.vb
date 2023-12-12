Imports MySql.Data.MySqlClient

Public Class FrmLogin
    Public Shared Property UserIDusing As String
    Public Shared Property UUserAccessLevel As Integer
    Public Shared Property UUserFirstName As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.ControlBox = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PnlLogin_Paint(sender As Object, e As PaintEventArgs) Handles pnlLogin.Paint

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        ' Get the username and password from the textboxes
        Dim username As String = tbEmployeeID.Text
        Dim password As String = tbPassword.Text

        ' Validate the credentials against the database
        If ValidateCredentials(username, password) Then
            ' Successful login
            MessageBox.Show("Login Successful")
            FrmMain.Show()
            Me.Hide()
            UserIDusing = username
            ' Add code to open the main application form or perform other actions
            tbEmployeeID.Text = ""
            tbPassword.Text = ""
        Else
            ' Failed login
            MessageBox.Show("Invalid Username or Password")
        End If
    End Sub

    ' Public property to access the user access level
    Public Shared ReadOnly Property UserAccessLevel As Integer
        Get
            Return UUserAccessLevel
        End Get
    End Property

    Private Function ValidateCredentials(username As String, password As String) As Boolean
        Try
            ' Create a connection using the Common method
            Using connection As MySqlConnection = Common.GetDBConnectionX()
                connection.Open()

                ' SQL query to retrieve user information
                Dim query As String = "SELECT COUNT(*), MAX(daccesslvl), MAX(demployeefn) FROM omac.tblusers WHERE BINARY duid = @username AND BINARY dpassword = @password"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)

                    ' ExecuteScalar returns the number of matching rows and maximum access level
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim count As Integer = Convert.ToInt32(reader(0))
                            UUserAccessLevel = If(reader.IsDBNull(1), 0, Convert.ToInt32(reader(1)))

                            ' Check if there is a matching row
                            If count > 0 Then
                                ' Retrieve the first name
                                If Not reader.IsDBNull(2) Then
                                    Dim firstName As String = reader.GetString(2)
                                    ' You can use the firstName variable as needed
                                    UUserFirstName = firstName
                                End If

                                ' Credentials are valid
                                Return True
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try

        ' If an exception occurs, set access level to 0 and return false
        UUserAccessLevel = 0
        Return False
    End Function

    Private Sub Guna2ImageCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            tbPassword.PasswordChar = ""
        Else
            tbPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
