Imports MySql.Data.MySqlClient

Module DBConnection
    Public conn As MySqlConnection

    Public Sub ConnectDB()
        Dim connectionString As String = "Server=localhost;Database=vbdb;User ID=root;Password=;"
        conn = New MySqlConnection(connectionString)

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MessageBox.Show("Database connected successfully!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        End Try
    End Sub
End Module
