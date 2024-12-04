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
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvTeachers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtICNumber
        '
        Me.txtICNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtICNumber.Location = New System.Drawing.Point(394, 128)
        Me.txtICNumber.Name = "txtICNumber"
        Me.txtICNumber.Size = New System.Drawing.Size(207, 26)
        Me.txtICNumber.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(394, 331)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(207, 26)
        Me.txtPassword.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(394, 167)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(207, 26)
        Me.txtName.TabIndex = 2
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(394, 251)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(207, 26)
        Me.txtPhone.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(394, 292)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(207, 26)
        Me.txtUsername.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "IC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(284, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Subject"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(284, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(284, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Password"
        '
        'btnSearchByName
        '
        Me.btnSearchByName.Location = New System.Drawing.Point(612, 167)
        Me.btnSearchByName.Name = "btnSearchByName"
        Me.btnSearchByName.Size = New System.Drawing.Size(114, 26)
        Me.btnSearchByName.TabIndex = 12
        Me.btnSearchByName.Text = "Search by Name"
        Me.btnSearchByName.UseVisualStyleBackColor = True
        '
        'btnSearchByIC
        '
        Me.btnSearchByIC.Location = New System.Drawing.Point(612, 128)
        Me.btnSearchByIC.Name = "btnSearchByIC"
        Me.btnSearchByIC.Size = New System.Drawing.Size(114, 26)
        Me.btnSearchByIC.TabIndex = 13
        Me.btnSearchByIC.Text = "Search by IC"
        Me.btnSearchByIC.UseVisualStyleBackColor = True
        '
        'btnUpdateTeacher
        '
        Me.btnUpdateTeacher.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdateTeacher.Location = New System.Drawing.Point(445, 376)
        Me.btnUpdateTeacher.Name = "btnUpdateTeacher"
        Me.btnUpdateTeacher.Size = New System.Drawing.Size(97, 35)
        Me.btnUpdateTeacher.TabIndex = 14
        Me.btnUpdateTeacher.Text = "Update"
        Me.btnUpdateTeacher.UseVisualStyleBackColor = False
        '
        'btnDeleteTeacher
        '
        Me.btnDeleteTeacher.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDeleteTeacher.Location = New System.Drawing.Point(330, 376)
        Me.btnDeleteTeacher.Name = "btnDeleteTeacher"
        Me.btnDeleteTeacher.Size = New System.Drawing.Size(97, 35)
        Me.btnDeleteTeacher.TabIndex = 15
        Me.btnDeleteTeacher.Text = "Delete"
        Me.btnDeleteTeacher.UseVisualStyleBackColor = False
        '
        'btnAddTeacher
        '
        Me.btnAddTeacher.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddTeacher.Location = New System.Drawing.Point(564, 376)
        Me.btnAddTeacher.Name = "btnAddTeacher"
        Me.btnAddTeacher.Size = New System.Drawing.Size(97, 35)
        Me.btnAddTeacher.TabIndex = 16
        Me.btnAddTeacher.Text = "Add"
        Me.btnAddTeacher.UseVisualStyleBackColor = False
        '
        'dgvTeachers
        '
        Me.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeachers.Location = New System.Drawing.Point(12, 128)
        Me.dgvTeachers.Name = "dgvTeachers"
        Me.dgvTeachers.Size = New System.Drawing.Size(225, 229)
        Me.dgvTeachers.TabIndex = 17
        '
        'btnClearFields
        '
        Me.btnClearFields.BackColor = System.Drawing.Color.White
        Me.btnClearFields.Location = New System.Drawing.Point(330, 429)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(331, 47)
        Me.btnClearFields.TabIndex = 18
        Me.btnClearFields.Text = "Clear"
        Me.btnClearFields.UseVisualStyleBackColor = False
        '
        'cmbSubject
        '
        Me.cmbSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Location = New System.Drawing.Point(394, 211)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(207, 28)
        Me.cmbSubject.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(211, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(344, 41)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Teacher Information"
        '
        'TeacherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(780, 514)
        Me.Controls.Add(Me.Label7)
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
    Friend WithEvents Label7 As Label
End Class
