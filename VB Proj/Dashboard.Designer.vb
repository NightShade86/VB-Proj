<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTeacherForm = New System.Windows.Forms.Button()
        Me.btnSubjectForm = New System.Windows.Forms.Button()
        Me.btnStudentForm = New System.Windows.Forms.Button()
        Me.btnRegistrationForm = New System.Windows.Forms.Button()
        Me.btnClassForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTeacherForm
        '
        Me.btnTeacherForm.Location = New System.Drawing.Point(37, 31)
        Me.btnTeacherForm.Name = "btnTeacherForm"
        Me.btnTeacherForm.Size = New System.Drawing.Size(117, 23)
        Me.btnTeacherForm.TabIndex = 0
        Me.btnTeacherForm.Text = "Manage Teachers"
        Me.btnTeacherForm.UseVisualStyleBackColor = True
        '
        'btnSubjectForm
        '
        Me.btnSubjectForm.Location = New System.Drawing.Point(89, 76)
        Me.btnSubjectForm.Name = "btnSubjectForm"
        Me.btnSubjectForm.Size = New System.Drawing.Size(117, 23)
        Me.btnSubjectForm.TabIndex = 1
        Me.btnSubjectForm.Text = "Manage Subject"
        Me.btnSubjectForm.UseVisualStyleBackColor = True
        '
        'btnStudentForm
        '
        Me.btnStudentForm.Location = New System.Drawing.Point(205, 105)
        Me.btnStudentForm.Name = "btnStudentForm"
        Me.btnStudentForm.Size = New System.Drawing.Size(117, 23)
        Me.btnStudentForm.TabIndex = 2
        Me.btnStudentForm.Text = "Manage Student"
        Me.btnStudentForm.UseVisualStyleBackColor = True
        '
        'btnRegistrationForm
        '
        Me.btnRegistrationForm.Location = New System.Drawing.Point(434, 186)
        Me.btnRegistrationForm.Name = "btnRegistrationForm"
        Me.btnRegistrationForm.Size = New System.Drawing.Size(154, 23)
        Me.btnRegistrationForm.TabIndex = 3
        Me.btnRegistrationForm.Text = "Manage Student's Subject"
        Me.btnRegistrationForm.UseVisualStyleBackColor = True
        '
        'btnClassForm
        '
        Me.btnClassForm.Location = New System.Drawing.Point(322, 146)
        Me.btnClassForm.Name = "btnClassForm"
        Me.btnClassForm.Size = New System.Drawing.Size(117, 23)
        Me.btnClassForm.TabIndex = 4
        Me.btnClassForm.Text = "Manage Class"
        Me.btnClassForm.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 293)
        Me.Controls.Add(Me.btnClassForm)
        Me.Controls.Add(Me.btnRegistrationForm)
        Me.Controls.Add(Me.btnStudentForm)
        Me.Controls.Add(Me.btnSubjectForm)
        Me.Controls.Add(Me.btnTeacherForm)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTeacherForm As Button
    Friend WithEvents btnSubjectForm As Button
    Friend WithEvents btnStudentForm As Button
    Friend WithEvents btnRegistrationForm As Button
    Friend WithEvents btnClassForm As Button
End Class
