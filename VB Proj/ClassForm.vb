Imports MySql.Data.MySqlClient
Public Class ClassForm
    Private Sub ClassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        DisplayClassList()
    End Sub

    ' Method to display the list of classes in the DataGridView
    Private Sub DisplayClassList()
        Dim query As String = "SELECT * FROM Class"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvClassList.DataSource = table
    End Sub

    ' Method to add a new class
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = "INSERT INTO Class (ClassName, Description) VALUES (@ClassName, @Description)"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@ClassName", txtClassName.Text.ToUpper())
        cmd.Parameters.AddWithValue("@Description", txtDescription.Text)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Class added successfully!")
            DisplayClassList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Method to update class information
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtClassID.Text) Then
            MessageBox.Show("Please select a class to update.")
            Return
        End If

        Dim query As String = "UPDATE Class SET ClassName=@ClassName, Description=@Description WHERE ClassID=@ClassID"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@ClassID", txtClassID.Text)
        cmd.Parameters.AddWithValue("@ClassName", txtClassName.Text.ToUpper())
        cmd.Parameters.AddWithValue("@Description", txtDescription.Text)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Class updated successfully!")
            DisplayClassList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Method to delete a class
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(txtClassID.Text) Then
            MessageBox.Show("Please select a class to delete.")
            Return
        End If

        Dim query As String = "DELETE FROM Class WHERE ClassID=@ClassID"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@ClassID", txtClassID.Text)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Class deleted successfully!")
            DisplayClassList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Method to display class information when a row is clicked in the DataGridView
    Private Sub dgvClassList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClassList.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvClassList.Rows(e.RowIndex)
            txtClassID.Text = row.Cells("ClassID").Value.ToString()
            txtClassName.Text = row.Cells("ClassName").Value.ToString()
            txtDescription.Text = row.Cells("Description").Value.ToString()
        End If
    End Sub

    ' Method to clear input fields
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        txtClassID.Clear()
        txtClassName.Clear()
        txtDescription.Clear()
        DisplayClassList()
    End Sub
End Class
