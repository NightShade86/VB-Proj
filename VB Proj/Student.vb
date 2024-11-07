Public Class Student
    Private db As New DatabaseConnection()

    Private Sub btnLoadStudents_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim students As DataTable = db.GetStudents()
        DataGridView1.DataSource = students
    End Sub


End Class
