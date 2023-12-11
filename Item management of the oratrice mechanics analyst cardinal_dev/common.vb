Imports MySql.Data.MySqlClient


Public Class Common

    Private Shared _myDBConnection As MySqlConnection

    Public Shared Property MyDBConnection As MySqlConnection
        Get
            Return _myDBConnection
        End Get
        Set(value As MySqlConnection)
            _myDBConnection = value
        End Set
    End Property

    Public Shared Function GetDBConnectionX() As MySqlConnection
        MyDBConnection = New MySqlConnection(
        "Database=omac;" &
        "Data Source=localhost;" &
        "User id=root;" &
        "Password=root;" &
        "Port=3306;Command Timeout=600;")
        Return MyDBConnection
    End Function
End Class
