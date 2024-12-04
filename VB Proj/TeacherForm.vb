Imports MySql.Data.MySqlClient

Public Class TeacherForm
    ' Load teacher list into the DataGridView
    Private Sub LoadTeacherList()
        ' Open the connection
        ConnectDB()

        Dim query As String = "SELECT t.ICNumber, t.Name, t.Subject, t.Phone, u.Username, u.UserType FROM teacher t INNER JOIN users u ON t.UserID = u.UserID"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                adapter.Fill(dt)
                dgvTeachers.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading teacher list: " & ex.Message)
            End Try
        End Using

        ' Close the connection
        DBConnection.conn.Close()
    End Sub

    ' Add new teacher (REQ402)
    Private Sub btnAddTeacher_Click(sender As Object, e As EventArgs) Handles btnAddTeacher.Click
        ' Ensure all fields are filled
        If txtICNumber.Text = "" Or txtName.Text = "" Or cmbSubject.Text = "" Or txtPhone.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Open the connection
        ConnectDB()

        ' Insert new user into users table
        Dim userQuery As String = "INSERT INTO users (Username, Password, UserType, FullName) VALUES (@Username, @Password, 'Teacher', @FullName)"

        Using cmd As New MySqlCommand(userQuery, DBConnection.conn)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@FullName", txtName.Text)

            Try
                cmd.ExecuteNonQuery()
                ' Get the UserID of the newly added user
                Dim userID As Integer
                cmd.CommandText = "SELECT LAST_INSERT_ID()"
                userID = Convert.ToInt32(cmd.ExecuteScalar())

                ' Insert new teacher into teacher table
                Dim teacherQuery As String = "INSERT INTO teacher (ICNumber, Name, Subject, Phone, UserID) VALUES (@ICNumber, @Name, @Subject, @Phone, @UserID)"
                cmd.CommandText = teacherQuery
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text)
                cmd.Parameters.AddWithValue("@Name", txtName.Text)
                cmd.Parameters.AddWithValue("@Subject", cmbSubject.Text)
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@UserID", userID)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Teacher Added Successfully!")
                LoadTeacherList() ' Refresh the DataGridView
            Catch ex As Exception
                MessageBox.Show("Error adding teacher: " & ex.Message)
            End Try
        End Using

        ' Close the connection
        DBConnection.conn.Close()
    End Sub

    ' Delete teacher (REQ403)
    Private Sub btnDeleteTeacher_Click(sender As Object, e As EventArgs) Handles btnDeleteTeacher.Click
        ' Ensure a teacher is selected
        If dgvTeachers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a teacher to delete.")
            Return
        End If

        ' Get the necessary values from the selected row
        Dim teacherICNumber As String = dgvTeachers.SelectedRows(0).Cells("ICNumber").Value.ToString()
        Dim userID As Integer = Convert.ToInt32(dgvTeachers.SelectedRows(0).Cells("UserID").Value.ToString()) ' Get UserID directly

        ' Confirm delete action
        Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this teacher?", "Confirm Delete", MessageBoxButtons.YesNo)
        If confirmDelete = DialogResult.No Then
            Return
        End If

        ' Open the connection
        ConnectDB()

        ' Start a transaction to ensure atomicity of the delete operation
        Dim transaction As MySqlTransaction = DBConnection.conn.BeginTransaction()

        Try
            ' Delete teacher from the teacher table
            Dim deleteTeacherQuery As String = "DELETE FROM teacher WHERE ICNumber = @ICNumber"
            Using cmd As New MySqlCommand(deleteTeacherQuery, DBConnection.conn, transaction)
                cmd.Parameters.AddWithValue("@ICNumber", teacherICNumber)
                cmd.ExecuteNonQuery()
            End Using

            ' Now delete user from the users table
            Dim deleteUserQuery As String = "DELETE FROM users WHERE UserID = @UserID"
            Using cmd As New MySqlCommand(deleteUserQuery, DBConnection.conn, transaction)
                cmd.Parameters.AddWithValue("@UserID", userID)
                cmd.ExecuteNonQuery()
            End Using

            ' Commit the transaction
            transaction.Commit()

            MessageBox.Show("Teacher Deleted Successfully!")
            LoadTeacherList() ' Refresh the DataGridView
        Catch ex As Exception
            ' Rollback transaction in case of an error
            transaction.Rollback()
            MessageBox.Show("Error deleting teacher: " & ex.Message)
        Finally
            ' Close the connection
            DBConnection.conn.Close()
        End Try
    End Sub



    ' Update teacher information (REQ404)
    Private Sub btnUpdateTeacher_Click(sender As Object, e As EventArgs) Handles btnUpdateTeacher.Click
        ' Ensure a teacher is selected and fields are filled
        If dgvTeachers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a teacher to update.")
            Return
        End If

        If txtICNumber.Text = "" Or txtName.Text = "" Or cmbSubject.Text = "" Or txtPhone.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim teacherID As String = dgvTeachers.SelectedRows(0).Cells("ICNumber").Value.ToString()
        Dim userID As String = dgvTeachers.SelectedRows(0).Cells("UserID").Value.ToString() ' UserID for update

        ' Open the connection
        ConnectDB()

        Try
            ' Update teacher in teacher table
            Dim updateTeacherQuery As String = "UPDATE teacher SET ICNumber = @ICNumber, Name = @Name, Subject = @Subject, Phone = @Phone WHERE ICNumber = @OldICNumber"

            Using cmd As New MySqlCommand(updateTeacherQuery, DBConnection.conn)
                cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text)
                cmd.Parameters.AddWithValue("@Name", txtName.Text)
                cmd.Parameters.AddWithValue("@Subject", cmbSubject.Text)
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@OldICNumber", teacherID)

                cmd.ExecuteNonQuery()
            End Using

            ' Update user details in users table, including password (plain text)
            Dim updateUserQuery As String = "UPDATE users SET Username = @Username, Password = @Password, FullName = @FullName WHERE UserID = @UserID"

            Using cmd As New MySqlCommand(updateUserQuery, DBConnection.conn)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text) ' Update password as plain text
                cmd.Parameters.AddWithValue("@FullName", txtName.Text)
                cmd.Parameters.AddWithValue("@UserID", userID)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Teacher Updated Successfully!")
            LoadTeacherList() ' Refresh the DataGridView
        Catch ex As Exception
            MessageBox.Show("Error updating teacher: " & ex.Message)
        Finally
            ' Close the connection
            DBConnection.conn.Close()
        End Try
    End Sub



    ' Search teacher by IC number (REQ405)
    Private Sub btnSearchByIC_Click(sender As Object, e As EventArgs) Handles btnSearchByIC.Click
        ' Open the connection
        ConnectDB()

        Dim query As String = "SELECT t.ICNumber, t.Name, t.Subject, t.Phone, u.Username, u.UserType FROM teacher t INNER JOIN users u ON t.UserID = u.UserID WHERE t.ICNumber LIKE @Search"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@Search", "%" & txtICNumber.Text & "%")
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                adapter.Fill(dt)
                dgvTeachers.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error searching teachers: " & ex.Message)
            End Try
        End Using

        ' Close the connection
        DBConnection.conn.Close()
    End Sub

    ' Search teacher by name (REQ406)
    Private Sub btnSearchByName_Click(sender As Object, e As EventArgs) Handles btnSearchByName.Click
        ' Open the connection
        ConnectDB()

        Dim query As String = "SELECT t.ICNumber, t.Name, t.Subject, t.Phone, u.Username, u.UserType FROM teacher t INNER JOIN users u ON t.UserID = u.UserID WHERE t.Name LIKE @Search"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@Search", "%" & txtName.Text & "%")
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                adapter.Fill(dt)
                dgvTeachers.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error searching teachers: " & ex.Message)
            End Try
        End Using

        ' Close the connection
        DBConnection.conn.Close()
    End Sub

    ' Form Load event to initialize DB connection and load teacher list
    Private Sub TeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        LoadTeacherList() ' Load all teachers when the form loads
        LoadSubjects()    ' Load subjects into the ComboBox
    End Sub


    ' Clear all textboxes
    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        txtICNumber.Clear()
        txtName.Clear()
        cmbSubject.SelectedIndex = -1 ' Clear ComboBox selection
        txtPhone.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    ' Load subject names into the ComboBox
    Private Sub LoadSubjects()
        ConnectDB()
        Dim query As String = "SELECT SubjectName FROM subject"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            Dim reader As MySqlDataReader

            Try
                reader = cmd.ExecuteReader()
                cmbSubject.Items.Clear() ' Clear existing items

                ' Add subject names to the ComboBox
                While reader.Read()
                    cmbSubject.Items.Add(reader("SubjectName").ToString())
                End While

            Catch ex As Exception
                MessageBox.Show("Error loading subjects: " & ex.Message)
            Finally
                DBConnection.conn.Close()
            End Try
        End Using
    End Sub
    ' Handle DataGridView CellClick event to fill textboxes with selected teacher's data
    Private Sub dgvTeachers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeachers.CellClick
        If e.RowIndex >= 0 Then
            ' Get the selected teacher's details from the DataGridView row
            Dim row As DataGridViewRow = dgvTeachers.Rows(e.RowIndex)

            ' Populate the textboxes with the selected teacher's data
            txtICNumber.Text = row.Cells("ICNumber").Value.ToString()
            txtName.Text = row.Cells("Name").Value.ToString()
            txtPhone.Text = row.Cells("Phone").Value.ToString()
            txtUsername.Text = row.Cells("Username").Value.ToString()

            ' Set the subject in the ComboBox
            Dim subject As String = row.Cells("Subject").Value.ToString()
            If cmbSubject.Items.Contains(subject) Then
                cmbSubject.SelectedItem = subject
            End If
        End If
    End Sub



End Class
