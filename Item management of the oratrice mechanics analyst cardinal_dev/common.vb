Imports MySql.Data.MySqlClient


Public Class Common

        Public Shared myDBConnection As MySqlConnection

        Public Shared Function getDBConnectionX() As MySqlConnection
            '@Yasuo123
            myDBConnection = New MySqlConnection(
            "Database=omac;" &
            "Data Source=localhost;" &
            "User id=root;" &
            "Password=root;" &
            "Port=3306;Command Timeout=600;")
            Return myDBConnection
        End Function
    End Class
