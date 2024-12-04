Imports MySql.Data.MySqlClient

Public Class TeacherUIForm
    Private teacherUserID As Integer ' Store as Integer

    ' Constructor that accepts the UserID
    Public Sub New(userID As Integer) ' Use Integer for UserID
        InitializeComponent()
        teacherUserID = userID
    End Sub

    ' Load the teacher's information and teaching load
    Private Sub TeacherUIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConnectDB()
            DisplayTeacherInfo()
            DisplayTeachingLoad()
        Catch ex As Exception
            MessageBox.Show("Error loading teacher information: " & ex.Message)
        Finally
            DBConnection.conn.Close()
        End Try
    End Sub

    ' Display teacher's basic info using UserID
    ' Display teacher's basic info using UserID
    Private Sub DisplayTeacherInfo()
        Try
            ConnectDB()

            ' Query now joins teacher and subject tables to get detailed teaching load info
            Dim query As String = "SELECT t.Name, t.Phone, s.SubjectCode, s.SubjectName, s.CreditHours 
                               FROM teacher t 
                               INNER JOIN subject s ON t.Subject = s.SubjectName 
                               WHERE t.UserID = @UserID"

            Using cmd As New MySqlCommand(query, DBConnection.conn)
                cmd.Parameters.AddWithValue("@UserID", teacherUserID) ' Pass integer

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    lblTeacherName.Text = "Name: " & reader("Name").ToString()
                    lblPhone.Text = "Phone: " & reader("Phone").ToString()

                    ' Constructing a detailed teaching load string
                    Dim subjectCode As String = reader("SubjectCode").ToString()
                    Dim subjectName As String = reader("SubjectName").ToString()
                    Dim creditHours As String = reader("CreditHours").ToString()

                    lblTeachingLoad.Text = "Teaching Load: " & subjectName & " (" & subjectCode & ") - " & creditHours & " Credit Hours"
                Else
                    MessageBox.Show("Teacher information not found for UserID: " & teacherUserID)
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error displaying teacher info: " & ex.Message)
        Finally
            DBConnection.conn.Close()
        End Try
    End Sub



    ' Display the teacher's teaching load using UserID
    Private Sub DisplayTeachingLoad()
        Try
            ConnectDB()

            ' Updated query to join on SubjectName instead of SubjectCode
            Dim query As String = "SELECT s.SubjectCode, s.SubjectName, s.CreditHours 
                               FROM teacher t 
                               INNER JOIN subject s ON t.Subject = s.SubjectName 
                               WHERE t.UserID = @UserID"

            Using cmd As New MySqlCommand(query, DBConnection.conn)
                cmd.Parameters.AddWithValue("@UserID", teacherUserID)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                If table.Rows.Count > 0 Then
                    dgvTeachingLoad.DataSource = table
                Else
                    MessageBox.Show("No teaching load found for this teacher.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error displaying teaching load: " & ex.Message)
        Finally
            DBConnection.conn.Close()
        End Try
    End Sub



    ' View Teaching Load Button (Optional functionality)
    Private Sub btnViewTeachingLoad_Click(sender As Object, e As EventArgs) Handles btnViewTeachingLoad.Click
        DisplayTeachingLoad()
    End Sub

    ' Logout Button
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginForm.Show() ' Assuming you have a LoginForm to return to
    End Sub

    ' FormClosing event to open LoginForm when TeacherUIForm is closed
    Private Sub TeacherUIForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LoginForm.Show() ' Show the LoginForm when TeacherUIForm is closed
    End Sub

End Class
