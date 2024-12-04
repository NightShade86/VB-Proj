Public Class Dashboard
    ' Form Load event to initialize DB connection or other initial setups
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optionally, you can add any initialization code here.
    End Sub

    ' Button click event to open ClassForm and hide Dashboard
    Private Sub btnClassForm_Click(sender As Object, e As EventArgs) Handles btnClassForm.Click
        Dim classForm As New ClassForm()
        classForm.Show() ' Show ClassForm
        Me.Hide() ' Hide Dashboard while ClassForm is open
        AddHandler classForm.FormClosed, AddressOf ClassForm_FormClosed ' Add handler for form close
    End Sub

    ' Button click event to open RegistrationForm and hide Dashboard
    Private Sub btnRegistrationForm_Click(sender As Object, e As EventArgs) Handles btnRegistrationForm.Click
        Dim registrationForm As New RegistrationForm()
        registrationForm.Show() ' Show RegistrationForm
        Me.Hide() ' Hide Dashboard while RegistrationForm is open
        AddHandler registrationForm.FormClosed, AddressOf RegistrationForm_FormClosed ' Add handler for form close
    End Sub

    ' Button click event to open StudentForm and hide Dashboard
    Private Sub btnStudentForm_Click(sender As Object, e As EventArgs) Handles btnStudentForm.Click
        Dim studentForm As New StudentForm()
        studentForm.Show() ' Show StudentForm
        Me.Hide() ' Hide Dashboard while StudentForm is open
        AddHandler studentForm.FormClosed, AddressOf StudentForm_FormClosed ' Add handler for form close
    End Sub

    ' Button click event to open SubjectForm and hide Dashboard
    Private Sub btnSubjectForm_Click(sender As Object, e As EventArgs) Handles btnSubjectForm.Click
        Dim subjectForm As New SubjectForm()
        subjectForm.Show() ' Show SubjectForm
        Me.Hide() ' Hide Dashboard while SubjectForm is open
        AddHandler subjectForm.FormClosed, AddressOf SubjectForm_FormClosed ' Add handler for form close
    End Sub

    ' Button click event to open TeacherForm and hide Dashboard
    Private Sub btnTeacherForm_Click(sender As Object, e As EventArgs) Handles btnTeacherForm.Click
        Dim teacherForm As New TeacherForm()
        teacherForm.Show() ' Show TeacherForm
        Me.Hide() ' Hide Dashboard while TeacherForm is open
        AddHandler teacherForm.FormClosed, AddressOf TeacherForm_FormClosed ' Add handler for form close
    End Sub

    ' Button click event to open StaffForm and hide Dashboard
    Private Sub ButtonManageStaff_Click(sender As Object, e As EventArgs) Handles ButtonManageStaff.Click
        Dim staffForm As New StaffForm()
        staffForm.Show() ' Show StaffForm
        Me.Hide() ' Hide Dashboard while StaffForm is open
        AddHandler staffForm.FormClosed, AddressOf StaffForm_FormClosed ' Add handler for form close
    End Sub

    ' Event handler for when ClassForm is closed
    Private Sub ClassForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        Me.Show() ' Show Dashboard again when ClassForm is closed
    End Sub

    ' Event handler for when RegistrationForm is closed
    Private Sub RegistrationForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        Me.Show() ' Show Dashboard again when RegistrationForm is closed
    End Sub

    ' Event handler for when StudentForm is closed
    Private Sub StudentForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        Me.Show() ' Show Dashboard again when StudentForm is closed
    End Sub

    ' Event handler for when SubjectForm is closed
    Private Sub SubjectForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        Me.Show() ' Show Dashboard again when SubjectForm is closed
    End Sub

    ' Event handler for when TeacherForm is closed
    Private Sub TeacherForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        Me.Show() ' Show Dashboard again when TeacherForm is closed
    End Sub

    ' Event handler for when StaffForm is closed
    Private Sub StaffForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        Me.Show() ' Show Dashboard again when StaffForm is closed
    End Sub

    ' FormClosing event to open LoginForm when Dashboard is closed
    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LoginForm.Show() ' Show the LoginForm when Dashboard is closed
    End Sub
End Class
