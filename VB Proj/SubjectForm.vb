Imports MySql.Data.MySqlClient

Public Class SubjectForm
    ' Database connection module
    Private Sub ConnectDB()
        DBConnection.ConnectDB()
    End Sub

    ' Load subject list into the DataGridView
    Private Sub LoadSubjectList()
        Dim query As String = "SELECT * FROM subject"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                adapter.Fill(dt)
                dgvSubjects.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading subject list: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Add new subject (REQ502)
    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        If txtSubjectCode.Text = "" Or txtSubjectName.Text = "" Or txtCreditHours.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim query As String = "INSERT INTO subject (SubjectCode, SubjectName, CreditHours) VALUES (@SubjectCode, @SubjectName, @CreditHours)"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@SubjectCode", txtSubjectCode.Text)
            cmd.Parameters.AddWithValue("@SubjectName", txtSubjectName.Text)
            cmd.Parameters.AddWithValue("@CreditHours", txtCreditHours.Text)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Subject Added Successfully!")
                LoadSubjectList() ' Refresh the DataGridView
            Catch ex As Exception
                MessageBox.Show("Error adding subject: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Delete subject (REQ503)
    Private Sub btnDeleteSubject_Click(sender As Object, e As EventArgs) Handles btnDeleteSubject.Click
        If dgvSubjects.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a subject to delete.")
            Return
        End If

        Dim subjectID As Integer = Convert.ToInt32(dgvSubjects.SelectedRows(0).Cells(0).Value)
        Dim query As String = "DELETE FROM subject WHERE SubjectID = @SubjectID"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@SubjectID", subjectID)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Subject Deleted Successfully!")
                LoadSubjectList() ' Refresh the DataGridView
            Catch ex As Exception
                MessageBox.Show("Error deleting subject: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Update subject information (REQ504)
    Private Sub btnUpdateSubject_Click(sender As Object, e As EventArgs) Handles btnUpdateSubject.Click
        If dgvSubjects.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a subject to update.")
            Return
        End If

        If txtSubjectCode.Text = "" Or txtSubjectName.Text = "" Or txtCreditHours.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim subjectID As Integer = Convert.ToInt32(dgvSubjects.SelectedRows(0).Cells(0).Value)
        Dim query As String = "UPDATE subject SET SubjectCode = @SubjectCode, SubjectName = @SubjectName, CreditHours = @CreditHours WHERE SubjectID = @SubjectID"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@SubjectCode", txtSubjectCode.Text)
            cmd.Parameters.AddWithValue("@SubjectName", txtSubjectName.Text)
            cmd.Parameters.AddWithValue("@CreditHours", txtCreditHours.Text)
            cmd.Parameters.AddWithValue("@SubjectID", subjectID)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Subject Updated Successfully!")
                LoadSubjectList() ' Refresh the DataGridView
            Catch ex As Exception
                MessageBox.Show("Error updating subject: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Search subject by subject code or name (REQ505/REQ506)
    Private Sub btnSearchSubject_Click(sender As Object, e As EventArgs) Handles btnSearchSubject.Click
        Dim query As String = "SELECT * FROM subject WHERE SubjectCode LIKE @Search OR SubjectName LIKE @Search"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@Search", "%" & txtSubjectCode.Text & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                adapter.Fill(dt)
                dgvSubjects.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error searching subjects: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Form Load event to load all subjects when the form opens
    Private Sub SubjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        LoadSubjectList() ' Load subject list when the form loads
    End Sub
End Class
