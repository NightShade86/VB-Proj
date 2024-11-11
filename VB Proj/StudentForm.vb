Imports MySql.Data.MySqlClient

Public Class StudentForm
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        DisplayStudentList()
    End Sub

    Private Sub DisplayStudentList()
        Dim query As String = "SELECT * FROM Student"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvStudent.DataSource = table
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = "INSERT INTO Student (ICNumber, Name, Age, Gender, Address, Phone) VALUES (@ICNumber, @Name, @Age, @Gender, @Address, @Phone)"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Name", txtName.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Age", txtAge.Text)
        cmd.Parameters.AddWithValue("@Gender", txtGender.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Student added successfully!")
            DisplayStudentList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim query As String = "UPDATE Student SET Name=@Name, Age=@Age, Gender=@Gender, Address=@Address, Phone=@Phone WHERE ICNumber=@ICNumber"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Name", txtName.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Age", txtAge.Text)
        cmd.Parameters.AddWithValue("@Gender", txtGender.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Student updated successfully!")
            DisplayStudentList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim query As String = "DELETE FROM Student WHERE ICNumber=@ICNumber"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Student deleted successfully!")
            DisplayStudentList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearchIC_Click(sender As Object, e As EventArgs) Handles btnSearchIC.Click
        Dim query As String = "SELECT * FROM Student WHERE UPPER(ICNumber) = UPPER(@ICNumber)"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text.ToUpper()) ' Ensure input is uppercase

        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            txtName.Text = reader("Name").ToString()
            txtAge.Text = reader("Age").ToString()
            txtGender.Text = reader("Gender").ToString()
            txtAddress.Text = reader("Address").ToString()
            txtPhone.Text = reader("Phone").ToString()
        Else
            MessageBox.Show("Student not found!")
        End If
        reader.Close()
    End Sub



    Private Sub btnSearchName_Click(sender As Object, e As EventArgs) Handles btnSearchName.Click
        Dim query As String = "SELECT * FROM Student WHERE UPPER(Name) LIKE UPPER(@Name)"
        Dim adapter As New MySqlDataAdapter(query, conn)
        adapter.SelectCommand.Parameters.AddWithValue("@Name", "%" & txtName.Text.ToUpper() & "%") ' Ensure input is uppercase

        Dim table As New DataTable()
        adapter.Fill(table)
        dgvStudent.DataSource = table
    End Sub


    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Clear all textboxes
        txtICNumber.Clear()
        txtName.Clear()
        txtAge.Clear()
        txtGender.Clear()
        txtAddress.Clear()
        txtPhone.Clear()

        ' Display all students in the DataGridView
        DisplayStudentList()
    End Sub

End Class
