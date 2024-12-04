Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Connect to the database
        ConnectDB()

        ' SQL query to fetch Username, Password, UserType, and UserID
        Dim query As String = "SELECT UserID, UserType, FullName FROM Users WHERE Username=@Username AND Password=@Password"
        Dim cmd As New MySqlCommand(query, conn)

        ' Using parameters to prevent SQL injection
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

        ' Declare the reader outside the try block so it can be closed in the Finally block
        Dim reader As MySqlDataReader = Nothing

        Try
            ' Execute the query
            reader = cmd.ExecuteReader()

            ' Check if user exists
            If reader.Read() Then
                Dim userID As Integer = Convert.ToInt32(reader("UserID"))
                Dim userType As String = reader("UserType").ToString()
                Dim fullName As String = reader("FullName").ToString()
                MessageBox.Show("Welcome, " & fullName & "!", "Login Successful")

                ' Redirect based on UserType
                Select Case userType
                    Case "Staff"
                        Dim staffForm As New Dashboard()
                        staffForm.Show()
                    Case "Registrar"
                        Dim registrarForm As New Dashboard()
                        registrarForm.Show()
                    Case "Teacher"
                        ' Pass the actual UserID to TeacherUIForm
                        Dim teacherForm As New TeacherUIForm(userID) ' Pass UserID (integer)
                        teacherForm.Show()
                        Me.Hide()
                    Case Else
                        MessageBox.Show("Unknown UserType!")
                End Select

                ' Hide the login form
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password!", "Login Failed")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Ensure the reader is closed if it was opened
            If reader IsNot Nothing Then
                reader.Close()
            End If

            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

End Class
