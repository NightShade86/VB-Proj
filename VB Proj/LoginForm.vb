Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Connect to the database
        ConnectDB()

        ' SQL query to fetch Username, Password, and UserType
        Dim query As String = "SELECT UserType, FullName FROM Users WHERE Username=@Username AND Password=@Password"
        Dim cmd As New MySqlCommand(query, conn)

        ' Using parameters to prevent SQL injection
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

        Try
            ' Execute the query
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Check if user exists
            If reader.Read() Then
                Dim userType As String = reader("UserType").ToString()
                Dim fullName As String = reader("FullName").ToString()
                MessageBox.Show("Welcome, " & fullName & "!", "Login Successful")

                ' Redirect based on UserType
                Select Case userType
                    Case "Staff"
                        Dim staffForm As New StudentForm()
                        staffForm.Show()
                    Case "Registrar"
                        Dim registrarForm As New StudentForm()
                        registrarForm.Show()
                    Case "Teacher"
                        Dim teacherForm As New StudentForm()
                        teacherForm.Show()
                    Case Else
                        MessageBox.Show("Unknown UserType!")
                End Select

                ' Hide the login form
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password!", "Login Failed")
            End If

            ' Close the reader
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
