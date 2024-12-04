Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Net
Imports System.Net.Mail

Public Class RegistrationForm
    Private WithEvents PrintDoc As New PrintDocument()
    Private PrintPreview As New PrintPreviewDialog()
    Private PrintContent As String

    ' Form Load event to initialize DB connection and load data
    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        LoadStudents()
        LoadSubjects()
    End Sub

    ' Load all students into ComboBox
    Private Sub LoadStudents()
        Dim query As String = "SELECT StudentID, Name FROM student"
        Using cmd As New MySqlCommand(query, DBConnection.conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            cmbStudent.Items.Clear()
            While reader.Read()
                cmbStudent.Items.Add(New With {.Text = reader("Name").ToString(), .Value = reader("StudentID")})
            End While
            reader.Close()
        End Using
    End Sub

    ' Load all subjects into ComboBox
    Private Sub LoadSubjects()
        Dim query As String = "SELECT SubjectID, SubjectName FROM subject"
        Using cmd As New MySqlCommand(query, DBConnection.conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            cmbSubject.Items.Clear()
            While reader.Read()
                cmbSubject.Items.Add(New With {.Text = reader("SubjectName").ToString(), .Value = reader("SubjectID")})
            End While
            reader.Close()
        End Using
    End Sub

    ' Register subject for student
    Private Sub btnRegisterSubject_Click(sender As Object, e As EventArgs) Handles btnRegisterSubject.Click
        If cmbStudent.SelectedItem Is Nothing Or cmbSubject.SelectedItem Is Nothing Then
            MessageBox.Show("Please select both student and subject.")
            Return
        End If

        Dim studentID As Integer = CType(cmbStudent.SelectedItem, Object).Value
        Dim subjectID As Integer = CType(cmbSubject.SelectedItem, Object).Value
        Dim query As String = "INSERT INTO registration (StudentID, SubjectID) VALUES (@StudentID, @SubjectID)"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@StudentID", studentID)
            cmd.Parameters.AddWithValue("@SubjectID", subjectID)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Subject registered successfully!")
            Catch ex As Exception
                MessageBox.Show("Error registering subject: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Display registered subjects for selected student
    Private Sub btnDisplaySubjects_Click(sender As Object, e As EventArgs) Handles btnDisplaySubjects.Click
        If cmbStudent.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a student.")
            Return
        End If

        Dim studentID As Integer = CType(cmbStudent.SelectedItem, Object).Value
        Dim query As String = "SELECT s.SubjectCode, s.SubjectName, s.CreditHours FROM registration r INNER JOIN subject s ON r.SubjectID = s.SubjectID WHERE r.StudentID = @StudentID"
        Dim adapter As New MySqlDataAdapter(query, DBConnection.conn)
        Dim dt As New DataTable()

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@StudentID", studentID)
            adapter.SelectCommand = cmd
            adapter.Fill(dt)
            dgvRegistration.DataSource = dt
        End Using
    End Sub

    ' Calculate and display total credit hours
    Private Sub btnTotalCredit_Click(sender As Object, e As EventArgs) Handles btnTotalCredit.Click
        If cmbStudent.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a student.")
            Return
        End If

        Dim studentID As Integer = CType(cmbStudent.SelectedItem, Object).Value
        Dim query As String = "SELECT SUM(s.CreditHours) FROM registration r INNER JOIN subject s ON r.SubjectID = s.SubjectID WHERE r.StudentID = @StudentID"

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@StudentID", studentID)
            Dim totalCredits As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblTotalCredits.Text = "Total Credit Hours: " & totalCredits.ToString()
        End Using
    End Sub

    ' Calculate and display total fee amount (Example: Fee per credit hour = $100)
    Private Sub btnCalculateFee_Click(sender As Object, e As EventArgs) Handles btnCalculateFee.Click
        If String.IsNullOrEmpty(lblTotalCredits.Text) Then
            MessageBox.Show("Please calculate total credits first.")
            Return
        End If

        Dim totalCredits As Integer = Convert.ToInt32(lblTotalCredits.Text.Split(": ")(1))
        Dim totalFee As Integer = totalCredits * 100
        lblTotalFee.Text = "Total Fee: $" & totalFee.ToString()
    End Sub

    ' Prepare the registration slip content for printing
    Private Sub PrepareRegistrationSlip()
        If cmbStudent.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a student.")
            Return
        End If

        Dim studentID As Integer = CType(cmbStudent.SelectedItem, Object).Value
        Dim studentName As String = CType(cmbStudent.SelectedItem, Object).Text
        Dim totalCredits As String = lblTotalCredits.Text
        Dim totalFee As String = lblTotalFee.Text

        ' Fetch registered subjects
        Dim query As String = "SELECT s.SubjectCode, s.SubjectName, s.CreditHours FROM registration r INNER JOIN subject s ON r.SubjectID = s.SubjectID WHERE r.StudentID = @StudentID"
        Dim contentBuilder As New System.Text.StringBuilder()

        contentBuilder.AppendLine("Student Registration Slip")
        contentBuilder.AppendLine($"Student Name: {studentName}")
        contentBuilder.AppendLine($"Student ID: {studentID}")
        contentBuilder.AppendLine("===================================")
        contentBuilder.AppendLine("Subject Code    Subject Name    Credit Hours")
        contentBuilder.AppendLine("-----------------------------------")

        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@StudentID", studentID)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                contentBuilder.AppendLine($"{reader("SubjectCode"),-15} {reader("SubjectName"),-20} {reader("CreditHours"),-5}")
            End While
            reader.Close()
        End Using

        contentBuilder.AppendLine("===================================")
        contentBuilder.AppendLine(totalCredits)
        contentBuilder.AppendLine(totalFee)

        ' Set the content for printing
        PrintContent = contentBuilder.ToString()
    End Sub

    ' Handle the printing of the registration slip
    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        ' Set the font and margins
        Dim font As New Font("Arial", 12)
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top

        ' Print the content
        e.Graphics.DrawString(PrintContent, font, Brushes.Black, leftMargin, topMargin)
    End Sub

    ' Show the print preview of the registration slip
    Private Sub btnPrintSlip_Click(sender As Object, e As EventArgs) Handles btnPrintSlip.Click
        PrepareRegistrationSlip()
        PrintPreview.Document = PrintDoc
        PrintPreview.ShowDialog()
    End Sub

    ' Send an email with the registration slip
    Private Sub SendEmail(toEmail As String, subject As String, body As String)
        Try
            ' Set up the email message
            Dim mail As New MailMessage()
            mail.From = New MailAddress("narreskhumar@gmail.com") ' Use valid email here
            mail.To.Add(toEmail)
            mail.Subject = subject
            mail.Body = body
            mail.IsBodyHtml = False

            ' Set up the SMTP client
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587 ' Use 465 for SSL
            smtp.Credentials = New NetworkCredential("narreskhumar@gmail.com", "srvxyxhxdwxgskme") ' Replace with actual email and password
            smtp.EnableSsl = True

            ' Send the email
            smtp.Send(mail)
            MessageBox.Show("Email sent successfully!")
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message)
        End Try
    End Sub

    ' Prepare email content with registration slip details
    Private Function PrepareEmailContent() As String
        If cmbStudent.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a student.")
            Return String.Empty
        End If

        Dim studentID As Integer = CType(cmbStudent.SelectedItem, Object).Value
        Dim studentName As String = CType(cmbStudent.SelectedItem, Object).Text
        Dim totalCredits As String = lblTotalCredits.Text
        Dim totalFee As String = lblTotalFee.Text

        Dim contentBuilder As New System.Text.StringBuilder()

        contentBuilder.AppendLine("Student Registration Slip")
        contentBuilder.AppendLine($"Student Name: {studentName}")
        contentBuilder.AppendLine($"Student ID: {studentID}")
        contentBuilder.AppendLine("===================================")
        contentBuilder.AppendLine("Subject Code    Subject Name    Credit Hours")
        contentBuilder.AppendLine("-----------------------------------")

        ' Fetch registered subjects
        Dim query As String = "SELECT s.SubjectCode, s.SubjectName, s.CreditHours FROM registration r INNER JOIN subject s ON r.SubjectID = s.SubjectID WHERE r.StudentID = @StudentID"
        Using cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@StudentID", studentID)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                contentBuilder.AppendLine($"{reader("SubjectCode"),-15} {reader("SubjectName"),-20} {reader("CreditHours"),-5}")
            End While
            reader.Close()
        End Using

        contentBuilder.AppendLine("===================================")
        contentBuilder.AppendLine(totalCredits)
        contentBuilder.AppendLine(totalFee)

        ' Get student email address
        Dim emailQuery As String = "SELECT Email FROM student WHERE StudentID = @StudentID"
        Dim email As String = String.Empty
        Using cmd As New MySqlCommand(emailQuery, DBConnection.conn)
            cmd.Parameters.AddWithValue("@StudentID", studentID)
            email = Convert.ToString(cmd.ExecuteScalar())
        End Using

        ' Send the email if email is found
        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Student email not found.")
            Return String.Empty
        End If

        ' Return email body and student email address
        SendEmail(email, "Student Registration Slip", contentBuilder.ToString())
        Return contentBuilder.ToString()
    End Function

    ' Send the email with registration slip
    Private Sub btnEmailSlip_Click(sender As Object, e As EventArgs) Handles btnEmailSlip.Click
        PrepareEmailContent()
    End Sub

End Class
