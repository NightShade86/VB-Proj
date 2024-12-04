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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonManageStaff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTeacherForm
        '
        Me.btnTeacherForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTeacherForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacherForm.Location = New System.Drawing.Point(344, 360)
        Me.btnTeacherForm.Name = "btnTeacherForm"
        Me.btnTeacherForm.Size = New System.Drawing.Size(154, 48)
        Me.btnTeacherForm.TabIndex = 0
        Me.btnTeacherForm.Text = "Manage Teachers"
        Me.btnTeacherForm.UseVisualStyleBackColor = False
        '
        'btnSubjectForm
        '
        Me.btnSubjectForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSubjectForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubjectForm.Location = New System.Drawing.Point(344, 288)
        Me.btnSubjectForm.Name = "btnSubjectForm"
        Me.btnSubjectForm.Size = New System.Drawing.Size(154, 48)
        Me.btnSubjectForm.TabIndex = 1
        Me.btnSubjectForm.Text = "Manage Subject"
        Me.btnSubjectForm.UseVisualStyleBackColor = False
        '
        'btnStudentForm
        '
        Me.btnStudentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStudentForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentForm.Location = New System.Drawing.Point(140, 288)
        Me.btnStudentForm.Name = "btnStudentForm"
        Me.btnStudentForm.Size = New System.Drawing.Size(154, 48)
        Me.btnStudentForm.TabIndex = 2
        Me.btnStudentForm.Text = "Manage Student"
        Me.btnStudentForm.UseVisualStyleBackColor = False
        '
        'btnRegistrationForm
        '
        Me.btnRegistrationForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegistrationForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrationForm.Location = New System.Drawing.Point(560, 360)
        Me.btnRegistrationForm.Name = "btnRegistrationForm"
        Me.btnRegistrationForm.Size = New System.Drawing.Size(154, 48)
        Me.btnRegistrationForm.TabIndex = 3
        Me.btnRegistrationForm.Text = "Manage Student's Subject"
        Me.btnRegistrationForm.UseVisualStyleBackColor = False
        '
        'btnClassForm
        '
        Me.btnClassForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClassForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassForm.Location = New System.Drawing.Point(554, 288)
        Me.btnClassForm.Name = "btnClassForm"
        Me.btnClassForm.Size = New System.Drawing.Size(154, 48)
        Me.btnClassForm.TabIndex = 4
        Me.btnClassForm.Text = "Manage Class"
        Me.btnClassForm.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 41)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome to Sri KDU Schools"
        '
        'ButtonManageStaff
        '
        Me.ButtonManageStaff.BackColor = System.Drawing.Color.Silver
        Me.ButtonManageStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonManageStaff.Location = New System.Drawing.Point(140, 360)
        Me.ButtonManageStaff.Name = "ButtonManageStaff"
        Me.ButtonManageStaff.Size = New System.Drawing.Size(154, 48)
        Me.ButtonManageStaff.TabIndex = 6
        Me.ButtonManageStaff.Text = "Manage Staff"
        Me.ButtonManageStaff.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(852, 479)
        Me.Controls.Add(Me.ButtonManageStaff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClassForm)
        Me.Controls.Add(Me.btnRegistrationForm)
        Me.Controls.Add(Me.btnStudentForm)
        Me.Controls.Add(Me.btnSubjectForm)
        Me.Controls.Add(Me.btnTeacherForm)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTeacherForm As Button
    Friend WithEvents btnSubjectForm As Button
    Friend WithEvents btnStudentForm As Button
    Friend WithEvents btnRegistrationForm As Button
    Friend WithEvents btnClassForm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonManageStaff As Button
End Class
