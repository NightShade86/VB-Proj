Imports MySql.Data.MySqlClient

Public Class StaffForm
    ' Load staff list into the DataGridView
    Private Sub LoadStaffList()
        ' Open the connection
        ConnectDB()

        Dim query As String = "SELECT s.ICNumber, s.Name, s.Phone, u.Username, u.UserType, u.Password FROM staff s INNER JOIN users u ON s.UserID = u.UserID"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                adapter.Fill(dt)
                dgvStaff.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading staff list: " & ex.Message)
            End Try
        End Using

        ' Close the connection
        DBConnection.conn.Close()
    End Sub

    ' Add new staff member
    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        ' Ensure all fields are filled
        If txtICNumber.Text = "" Or txtName.Text = "" Or txtPhone.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Open the connection
        ConnectDB()

        ' Insert new user into users table
        Dim userQuery As String = "INSERT INTO users (Username, Password, UserType, FullName) VALUES (@Username, @Password, 'Staff', @FullName)"

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

                ' Insert new staff member into staff table
                Dim staffQuery As String = "INSERT INTO staff (ICNumber, Name, Phone, UserID) VALUES (@ICNumber, @Name, @Phone, @UserID)"
                cmd.CommandText = staffQuery
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text)
                cmd.Parameters.AddWithValue("@Name", txtName.Text)
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@UserID", userID)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Staff Added Successfully!")
                LoadStaffList() ' Refresh the DataGridView
            Catch ex As Exception
                MessageBox.Show("Error adding staff: " & ex.Message)
            End Try
        End Using

        ' Close the connection
        DBConnection.conn.Close()
    End Sub

    ' Delete staff member
    Private Sub btnDeleteStaff_Click(sender As Object, e As EventArgs) Handles btnDeleteStaff.Click
        ' Ensure a staff member is selected
        If dgvStaff.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a staff member to delete.")
            Return
        End If

        ' Get the necessary values from the selected row
        Dim staffICNumber As String = dgvStaff.SelectedRows(0).Cells("ICNumber").Value.ToString()
        Dim userID As Integer = Convert.ToInt32(dgvStaff.SelectedRows(0).Cells("UserID").Value.ToString()) ' Get UserID directly

        ' Confirm delete action
        Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirm Delete", MessageBoxButtons.YesNo)
        If confirmDelete = DialogResult.No Then
            Return
        End If

        ' Open the connection
        ConnectDB()

        ' Start a transaction to ensure atomicity of the delete operation
        Dim transaction As MySqlTransaction = DBConnection.conn.BeginTransaction()

        Try
            ' Delete staff from the staff table
            Dim deleteStaffQuery As String = "DELETE FROM staff WHERE ICNumber = @ICNumber"
            Using cmd As New MySqlCommand(deleteStaffQuery, DBConnection.conn, transaction)
                cmd.Parameters.AddWithValue("@ICNumber", staffICNumber)
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

            MessageBox.Show("Staff Deleted Successfully!")
            LoadStaffList() ' Refresh the DataGridView
        Catch ex As Exception
            ' Rollback transaction in case of an error
            transaction.Rollback()
            MessageBox.Show("Error deleting staff: " & ex.Message)
        Finally
            ' Close the connection
            DBConnection.conn.Close()
        End Try
    End Sub

    ' Update staff information
    Private Sub btnUpdateStaff_Click(sender As Object, e As EventArgs) Handles btnUpdateStaff.Click
        ' Ensure a staff member is selected and fields are filled
        If dgvStaff.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a staff member to update.")
            Return
        End If

        If txtICNumber.Text = "" Or txtName.Text = "" Or txtPhone.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim staffID As String = dgvStaff.SelectedRows(0).Cells(0).Value.ToString()
        Dim userID As String = dgvStaff.SelectedRows(0).Cells(4).Value.ToString() ' UserID for update

        ' Open the connection
        ConnectDB()

        Try
            ' Update staff in staff table
            Dim updateStaffQuery As String = "UPDATE staff SET ICNumber = @ICNumber, Name = @Name, Phone = @Phone WHERE ICNumber = @OldICNumber"

            Using cmd As New MySqlCommand(updateStaffQuery, DBConnection.conn)
                cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text)
                cmd.Parameters.AddWithValue("@Name", txtName.Text)
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@OldICNumber", staffID)

                cmd.ExecuteNonQuery()
            End Using

            ' Update user details in users table, including password
            Dim updateUserQuery As String = "UPDATE users SET Username = @Username, Password = @Password, FullName = @FullName WHERE UserID = @UserID"

            Using cmd As New MySqlCommand(updateUserQuery, DBConnection.conn)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text) ' Update password as well
                cmd.Parameters.AddWithValue("@FullName", txtName.Text)
                cmd.Parameters.AddWithValue("@UserID", userID)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Staff Updated Successfully!")
            LoadStaffList() ' Refresh the DataGridView
        Catch ex As Exception
            MessageBox.Show("Error updating staff: " & ex.Message)
        Finally
            ' Close the connection
            DBConnection.conn.Close()
        End Try
    End Sub

    ' Search staff by IC number
    Private Sub btnSearchByIC_Click(sender As Object, e As EventArgs) Handles btnSearchByIC.Click
        ' Open the connection
        ConnectDB()

        Dim query As String = "SELECT s.ICNumber, s.Name, s.Phone, u.Username, u.UserType FROM staff s INNER JOIN users u ON s.UserID = u.UserID WHERE s.ICNumber LIKE @Search"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@Search", "%" & txtICNumber.Text & "%")
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                adapter.Fill(dt)
                dgvStaff.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error searching staff: " & ex.Message)
            End Try
        End Using

        ' Close the connection
        DBConnection.conn.Close()
    End Sub

    ' Search staff by name
    Private Sub btnSearchByName_Click(sender As Object, e As EventArgs) Handles btnSearchByName.Click
        ' Open the connection
        ConnectDB()

        Dim query As String = "SELECT s.ICNumber, s.Name, s.Phone, u.Username, u.UserType FROM staff s INNER JOIN users u ON s.UserID = u.UserID WHERE s.Name LIKE @Search"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@Search", "%" & txtName.Text & "%")
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                adapter.Fill(dt)
                dgvStaff.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error searching staff: " & ex.Message)
            End Try
        End Using

        ' Close the connection
        DBConnection.conn.Close()
    End Sub

    ' Form Load event to initialize DB connection and load staff list
    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        LoadStaffList() ' Load all staff when the form loads
    End Sub

    ' Clear all textboxes
    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        txtICNumber.Clear()
        txtName.Clear()
        txtPhone.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    ' Handle DataGridView CellClick event to fill textboxes with selected staff's data
    Private Sub dgvStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellClick
        If e.RowIndex >= 0 Then
            ' Get the selected staff's details from the DataGridView row
            Dim row As DataGridViewRow = dgvStaff.Rows(e.RowIndex)

            ' Populate the textboxes with the selected staff's data
            txtICNumber.Text = row.Cells("ICNumber").Value.ToString()
            txtName.Text = row.Cells("Name").Value.ToString()
            txtPhone.Text = row.Cells("Phone").Value.ToString()
            txtUsername.Text = row.Cells("Username").Value.ToString()
            txtPassword.Text = row.Cells("Password").Value.ToString() ' Display the password
        End If
    End Sub

End Class
