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
        Dim query As String = "SELECT Student.ICNumber, Student.Name, Student.Gender, Student.Address, Student.Phone, Student.Email, Student.Class 
                               FROM Student"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvStudent.DataSource = table
    End Sub

    ' Handle DataGridView CellClick event to fill textboxes with selected student's data
    Private Sub dgvStudent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellClick
        If e.RowIndex >= 0 Then
            ' Get the selected student's details from the DataGridView row
            Dim row As DataGridViewRow = dgvStudent.Rows(e.RowIndex)

            ' Populate the textboxes with the selected student's data
            txtICNumber.Text = row.Cells("ICNumber").Value.ToString()
            txtName.Text = row.Cells("Name").Value.ToString()
            txtGender.Text = row.Cells("Gender").Value.ToString()
            txtAddress.Text = row.Cells("Address").Value.ToString()
            txtPhone.Text = row.Cells("Phone").Value.ToString()
            txtEmail.Text = row.Cells("Email").Value.ToString()

            ' Set ComboBox selection based on the selected student's class
            Dim className As String = row.Cells("Class").Value.ToString()

            ' Ensure that the className is not null or empty
            If Not String.IsNullOrEmpty(className) Then
                For Each item In CMBclass.Items
                    If item.ClassName = className Then
                        CMBclass.SelectedItem = item
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub


    ' Add a new student record
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Get selected Class from ComboBox
        Dim selectedClass = CType(CMBclass.SelectedItem, Object)

        ' Insert using the Class name from ComboBox, not ClassID
        Dim query As String = "INSERT INTO Student (ICNumber, Name, Gender, Address, Phone, Email, Class) 
                               VALUES (@ICNumber, @Name, @Gender, @Address, @Phone, @Email, @Class)"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Name", txtName.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Gender", txtGender.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text) ' Added Email parameter
        cmd.Parameters.AddWithValue("@Class", selectedClass.ClassName) ' Insert class name, not ClassID

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Student added successfully!")
            DisplayStudentList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Update an existing student record
    ' Update an existing student record
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if an ICNumber is selected
        If String.IsNullOrEmpty(txtICNumber.Text) Then
            MessageBox.Show("Please select a student from the list to update.")
            Return
        End If

        ' Get selected Class from ComboBox
        Dim selectedClass = CType(CMBclass.SelectedItem, Object)

        ' Update using the Class name from ComboBox, not ClassID
        Dim query As String = "UPDATE Student SET Name=@Name, Gender=@Gender, Address=@Address, Phone=@Phone, Email=@Email, Class=@Class WHERE ICNumber=@ICNumber"
        Dim cmd As New MySqlCommand(query, conn)

        ' Ensure input is uppercase and prevent SQL injection
        cmd.Parameters.AddWithValue("@ICNumber", txtICNumber.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Name", txtName.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Gender", txtGender.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.ToUpper()) ' Ensure input is uppercase
        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text) ' Added Email parameter
        cmd.Parameters.AddWithValue("@Class", selectedClass.ClassName) ' Update class with ClassName

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Student updated successfully!")
            DisplayStudentList() ' Refresh the student list
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

            ' Set ComboBox selection based on Class name
            Dim className = reader("Class").ToString()
            For Each item In CMBclass.Items
                If item.ClassName = className Then
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
