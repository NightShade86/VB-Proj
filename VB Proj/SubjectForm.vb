Imports MySql.Data.MySqlClient

Public Class SubjectForm
    ' Ensure the database connection uses the DBConnection module
    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        ' Ensure the input fields are filled
        If txtSubjectCode.Text = "" Or txtSubjectName.Text = "" Or txtCreditHours.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' SQL Query to Insert new subject
        Dim query As String = "INSERT INTO subject (SubjectCode, SubjectName, CreditHours) VALUES (@SubjectCode, @SubjectName, @CreditHours)"

        ' Use the global connection from the DBConnection module
        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@SubjectCode", txtSubjectCode.Text)
            cmd.Parameters.AddWithValue("@SubjectName", txtSubjectName.Text)
            cmd.Parameters.AddWithValue("@CreditHours", txtCreditHours.Text)

            Try
                DBConnection.ConnectDB()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Subject Added Successfully!")
                LoadSubjectList()
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnDeleteSubject_Click(sender As Object, e As EventArgs) Handles btnDeleteSubject.Click
        ' Ensure a subject is selected
        If dgvSubjects.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a subject to delete.")
            Return
        End If

        Dim subjectID As Integer = Convert.ToInt32(dgvSubjects.SelectedRows(0).Cells(0).Value)

        ' SQL Query to Delete subject
        Dim query As String = "DELETE FROM subject WHERE SubjectID = @SubjectID"

        ' Use the global connection from the DBConnection module
        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@SubjectID", subjectID)

            Try
                DBConnection.ConnectDB()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Subject Deleted Successfully!")
                LoadSubjectList()
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnUpdateSubject_Click(sender As Object, e As EventArgs) Handles btnUpdateSubject.Click
        ' Ensure a subject is selected and fields are filled
        If dgvSubjects.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a subject to update.")
            Return
        End If

        If txtSubjectCode.Text = "" Or txtSubjectName.Text = "" Or txtCreditHours.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim subjectID As Integer = Convert.ToInt32(dgvSubjects.SelectedRows(0).Cells(0).Value)

        ' SQL Query to Update subject
        Dim query As String = "UPDATE subject SET SubjectCode = @SubjectCode, SubjectName = @SubjectName, CreditHours = @CreditHours WHERE SubjectID = @SubjectID"

        ' Use the global connection from the DBConnection module
        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@SubjectCode", txtSubjectCode.Text)
            cmd.Parameters.AddWithValue("@SubjectName", txtSubjectName.Text)
            cmd.Parameters.AddWithValue("@CreditHours", txtCreditHours.Text)
            cmd.Parameters.AddWithValue("@SubjectID", subjectID)

            Try
                DBConnection.ConnectDB()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Subject Updated Successfully!")
                LoadSubjectList()
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSearchSubject_Click(sender As Object, e As EventArgs) Handles btnSearchSubject.Click
        ' SQL Query to Search by SubjectCode or SubjectName
        Dim query As String = "SELECT * FROM subject WHERE SubjectCode LIKE @Search OR SubjectName LIKE @Search"

        ' Use the global connection from the DBConnection module
        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@Search", "%" & txtSubjectCode.Text & "%")

            Try
                DBConnection.ConnectDB()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Clear DataGridView before adding new rows
                dgvSubjects.Rows.Clear()

                While reader.Read()
                    dgvSubjects.Rows.Add(reader("SubjectID"), reader("SubjectCode"), reader("SubjectName"), reader("CreditHours"))
                End While
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadSubjectList()
        ' SQL Query to get all subjects
        Dim query As String = "SELECT * FROM subject"

        ' Use the global connection from the DBConnection module
        Using cmd As New MySqlCommand(query, DBConnection.conn)
            Try
                DBConnection.ConnectDB()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Clear DataGridView before adding new rows
                dgvSubjects.Rows.Clear()

                While reader.Read()
                    dgvSubjects.Rows.Add(reader("SubjectID"), reader("SubjectCode"), reader("SubjectName"), reader("CreditHours"))
                End While
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
