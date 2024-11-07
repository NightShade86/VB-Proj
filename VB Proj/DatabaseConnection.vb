Imports MySql.Data.MySqlClient

Public Class DatabaseConnection
    Private conn As MySqlConnection

    ' Constructor to initialize connection
    Public Sub New()
        Dim connectionString As String = "server=localhost;user id=root;password=;database=school_crs;"
        conn = New MySqlConnection(connectionString)
    End Sub

    ' Method to open connection
    Public Function OpenConnection() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Return True
        Catch ex As MySqlException
            MessageBox.Show("Database connection error: " & ex.Message)
            Return False
        End Try
    End Function

    ' Method to close connection
    Public Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    ' Sample method to retrieve data
    Public Function GetStudents() As DataTable
        Dim dt As New DataTable()
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM Students"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error retrieving students: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return dt
    End Function
End Class
