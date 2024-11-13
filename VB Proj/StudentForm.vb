Imports MySql.Data.MySqlClient

Public Class StudentForm
    ' Add a ClassID field for the student
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        DisplayStudentList()
        PopulateClassComboBox()
    End Sub

    ' Populate ComboBox with Class Names from the Class table
    Private Sub PopulateClassComboBox()
        Dim query As String = "SELECT ClassID, ClassName FROM Class"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        CMBclass.Items.Clear()
        While reader.Read()
            CMBclass.Items.Add(New With {
                Key .ClassID = reader("ClassID"),
                Key .ClassName = reader("ClassName")
            })
        End While
        reader.Close()

        ' Set the default selection if needed
        If CMBclass.Items.Count > 0 Then
            CMBclass.SelectedIndex = 0
        End If
    End Sub

    ' Display students in the DataGridView
    Private Sub DisplayStudentList()
        Dim query As String = "SELECT Student.ICNumber, Student.Name, Student.Gender, Student.Address, Student.Phone, Student.Email, Class.ClassName 
                               FROM Student 
                               INNER JOIN Class ON Student.ClassID = Class.ClassID"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvStudent.DataSource = table
    End Sub

    ' Add a new student record
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Get selected ClassID from ComboBox
        Dim selectedClass = CType(CMBclass.SelectedItem, Object)

        Dim query As String = "INSERT INTO Student (ICNumber, Name, Gender, Address, Phone, Email, ClassID) 
                               VALUES (@ICNumber, @Name, @Gender, @Address, @Phone, @Email, @ClassID)"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Name", txtName.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Gender", txtGender.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text) ' Added Email parameter
        cmd.Parameters.AddWithValue("@ClassID", selectedClass.ClassID)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Student added successfully!")
            DisplayStudentList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Update an existing student record
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Get selected ClassID from ComboBox
        Dim selectedClass = CType(CMBclass.SelectedItem, Object)

        Dim query As String = "UPDATE Student SET Name=@Name, Gender=@Gender, Address=@Address, Phone=@Phone, Email=@Email, ClassID=@ClassID WHERE ICNumber=@ICNumber"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Name", txtName.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Gender", txtGender.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text) ' Added Email parameter
        cmd.Parameters.AddWithValue("@ClassID", selectedClass.ClassID)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Student updated successfully!")
            DisplayStudentList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Delete a student record
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

    ' Search by IC Number
    Private Sub btnSearchIC_Click(sender As Object, e As EventArgs) Handles btnSearchIC.Click
        Dim query As String = "SELECT * FROM Student WHERE UPPER(ICNumber) = UPPER(@ICNumber)"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text.ToUpper()) ' Ensure input is uppercase

        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            txtName.Text = reader("Name").ToString()
            txtGender.Text = reader("Gender").ToString()
            txtAddress.Text = reader("Address").ToString()
            txtPhone.Text = reader("Phone").ToString()
            txtEmail.Text = reader("Email").ToString() ' Added Email field handling

            ' Set ComboBox selection based on ClassID
            Dim classID = Convert.ToInt32(reader("ClassID"))
            For Each item In CMBclass.Items
                If item.ClassID = classID Then
                    CMBclass.SelectedItem = item
                    Exit For
                End If
            Next
        Else
            MessageBox.Show("Student not found!")
        End If
        reader.Close()
    End Sub

    ' Search by Name
    Private Sub btnSearchName_Click(sender As Object, e As EventArgs) Handles btnSearchName.Click
        Dim query As String = "SELECT * FROM Student WHERE UPPER(Name) LIKE UPPER(@Name)"
        Dim adapter As New MySqlDataAdapter(query, conn)
        adapter.SelectCommand.Parameters.AddWithValue("@Name", "%" & txtName.Text.ToUpper() & "%") ' Ensure input is uppercase

        Dim table As New DataTable()
        adapter.Fill(table)
        dgvStudent.DataSource = table
    End Sub

    ' Display all students in the DataGridView
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Clear all textboxes
        txtICNumber.Clear()
        txtName.Clear()
        CMBclass.SelectedIndex = -1
        txtGender.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtEmail.Clear() ' Clear Email field as well

        ' Display all students in the DataGridView
        DisplayStudentList()
    End Sub
End Class
