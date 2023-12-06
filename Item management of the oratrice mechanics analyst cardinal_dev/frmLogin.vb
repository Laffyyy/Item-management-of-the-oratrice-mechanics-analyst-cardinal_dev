Imports MySql.Data.MySqlClient


Public Class frmLogin

    Public Shared Property UserIDusing As String

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub



    Private Sub pnlLogin_Paint(sender As Object, e As PaintEventArgs) Handles pnlLogin.Paint

    End Sub

    Private visisibility As Boolean = False

    Private Sub visibilityison()
        tbPassword.PasswordChar = ""
        tbPassword.BackgroundImage = My.Resources.visible
        tbPassword.Invalidate()

    End Sub

    Private Sub visibilityisoff()
        tbPassword.PasswordChar = "*"
        tbPassword.BackgroundImage = My.Resources.hide

        tbPassword.Invalidate()

    End Sub

    Private Sub btVisibility_Click(sender As Object, e As EventArgs) Handles btVisibility.Click
        If visisibility Then
            visibilityison()
        Else
            visibilityisoff()
        End If

        visisibility = Not visisibility
    End Sub

    'Private Sub pbvisible_Click(sender As Object, e As EventArgs) Handles pbvisible.Click
    '    If visisibility Then
    '        visibilityison()
    '    Else
    '        visibilityisoff()
    '    End If

    '    visisibility = Not visisibility

    'End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        ' Get the username and password from the textboxes
        Dim username As String = tbEmployeeID.Text
        Dim password As String = tbPassword.Text

        ' Validate the credentials against the database
        If ValidateCredentials(username, password) Then
            ' Successful login
            MessageBox.Show("Login Successful")
            frmMain.Show()
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

    Private Function ValidateCredentials(username As String, password As String) As Boolean
        Try
            ' Create a connection using the Common method
            Using connection As MySqlConnection = Common.getDBConnectionX()
                connection.Open()

                ' SQL query to retrieve user information
                Dim query As String = "SELECT COUNT(*) FROM omac.tblusers WHERE BINARY duid = @username AND BINARY dpassword = @password"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)

                    ' ExecuteScalar returns the number of matching rows
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' If count is 1 or more, credentials are valid
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

End Class
