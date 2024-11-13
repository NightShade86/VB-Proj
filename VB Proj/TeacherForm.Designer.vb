<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherForm
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
        Me.txtICNumber = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSearchByName = New System.Windows.Forms.Button()
        Me.btnSearchByIC = New System.Windows.Forms.Button()
        Me.btnUpdateTeacher = New System.Windows.Forms.Button()
        Me.btnDeleteTeacher = New System.Windows.Forms.Button()
        Me.btnAddTeacher = New System.Windows.Forms.Button()
        Me.dgvTeachers = New System.Windows.Forms.DataGridView()
        Me.btnClearFields = New System.Windows.Forms.Button()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        CType(Me.dgvTeachers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtICNumber
        '
        Me.txtICNumber.Location = New System.Drawing.Point(435, 31)
        Me.txtICNumber.Name = "txtICNumber"
        Me.txtICNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtICNumber.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(435, 162)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(121, 20)
        Me.txtPassword.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(435, 57)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 20)
        Me.txtName.TabIndex = 2
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(435, 109)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(121, 20)
        Me.txtPhone.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(435, 136)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(121, 20)
        Me.txtUsername.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "IC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(374, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Subject"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(374, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(374, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(374, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Password"
        '
        'btnSearchByName
        '
        Me.btnSearchByName.Location = New System.Drawing.Point(322, 202)
        Me.btnSearchByName.Name = "btnSearchByName"
        Me.btnSearchByName.Size = New System.Drawing.Size(118, 23)
        Me.btnSearchByName.TabIndex = 12
        Me.btnSearchByName.Text = "Search by Name"
        Me.btnSearchByName.UseVisualStyleBackColor = True
        '
        'btnSearchByIC
        '
        Me.btnSearchByIC.Location = New System.Drawing.Point(390, 243)
        Me.btnSearchByIC.Name = "btnSearchByIC"
        Me.btnSearchByIC.Size = New System.Drawing.Size(114, 23)
        Me.btnSearchByIC.TabIndex = 13
        Me.btnSearchByIC.Text = "Search by IC"
        Me.btnSearchByIC.UseVisualStyleBackColor = True
        '
        'btnUpdateTeacher
        '
        Me.btnUpdateTeacher.Location = New System.Drawing.Point(216, 225)
        Me.btnUpdateTeacher.Name = "btnUpdateTeacher"
        Me.btnUpdateTeacher.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateTeacher.TabIndex = 14
        Me.btnUpdateTeacher.Text = "Update"
        Me.btnUpdateTeacher.UseVisualStyleBackColor = True
        '
        'btnDeleteTeacher
        '
        Me.btnDeleteTeacher.Location = New System.Drawing.Point(272, 155)
        Me.btnDeleteTeacher.Name = "btnDeleteTeacher"
        Me.btnDeleteTeacher.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteTeacher.TabIndex = 15
        Me.btnDeleteTeacher.Text = "Delete"
        Me.btnDeleteTeacher.UseVisualStyleBackColor = True
        '
        'btnAddTeacher
        '
        Me.btnAddTeacher.Location = New System.Drawing.Point(258, 112)
        Me.btnAddTeacher.Name = "btnAddTeacher"
        Me.btnAddTeacher.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTeacher.TabIndex = 16
        Me.btnAddTeacher.Text = "Add"
        Me.btnAddTeacher.UseVisualStyleBackColor = True
        '
        'dgvTeachers
        '
        Me.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeachers.Location = New System.Drawing.Point(12, 28)
        Me.dgvTeachers.Name = "dgvTeachers"
        Me.dgvTeachers.Size = New System.Drawing.Size(240, 150)
        Me.dgvTeachers.TabIndex = 17
        '
        'btnClearFields
        '
        Me.btnClearFields.Location = New System.Drawing.Point(121, 202)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(75, 23)
        Me.btnClearFields.TabIndex = 18
        Me.btnClearFields.Text = "Clear"
        Me.btnClearFields.UseVisualStyleBackColor = True
        '
        'cmbSubject
        '
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Location = New System.Drawing.Point(435, 82)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(121, 21)
        Me.cmbSubject.TabIndex = 19
        '
        'TeacherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 293)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.btnClearFields)
        Me.Controls.Add(Me.dgvTeachers)
        Me.Controls.Add(Me.btnAddTeacher)
        Me.Controls.Add(Me.btnDeleteTeacher)
        Me.Controls.Add(Me.btnUpdateTeacher)
        Me.Controls.Add(Me.btnSearchByIC)
        Me.Controls.Add(Me.btnSearchByName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtICNumber)
        Me.Name = "TeacherForm"
        Me.Text = "TeacherForm"
        CType(Me.dgvTeachers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtICNumber As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSearchByName As Button
    Friend WithEvents btnSearchByIC As Button
    Friend WithEvents btnUpdateTeacher As Button
    Friend WithEvents btnDeleteTeacher As Button
    Friend WithEvents btnAddTeacher As Button
    Friend WithEvents dgvTeachers As DataGridView
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnClearFields As Button
    Friend WithEvents cmbSubject As ComboBox
End Class
