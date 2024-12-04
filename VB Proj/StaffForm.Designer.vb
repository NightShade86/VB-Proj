<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClearFields = New System.Windows.Forms.Button()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.btnAddStaff = New System.Windows.Forms.Button()
        Me.btnDeleteStaff = New System.Windows.Forms.Button()
        Me.btnUpdateStaff = New System.Windows.Forms.Button()
        Me.btnSearchByIC = New System.Windows.Forms.Button()
        Me.btnSearchByName = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtICNumber = New System.Windows.Forms.TextBox()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(232, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(294, 41)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Staff Information"
        '
        'btnClearFields
        '
        Me.btnClearFields.BackColor = System.Drawing.Color.White
        Me.btnClearFields.Location = New System.Drawing.Point(352, 383)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(331, 47)
        Me.btnClearFields.TabIndex = 38
        Me.btnClearFields.Text = "Clear"
        Me.btnClearFields.UseVisualStyleBackColor = False
        '
        'dgvStaff
        '
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Location = New System.Drawing.Point(33, 127)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.Size = New System.Drawing.Size(225, 229)
        Me.dgvStaff.TabIndex = 37
        '
        'btnAddStaff
        '
        Me.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddStaff.Location = New System.Drawing.Point(586, 330)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(97, 35)
        Me.btnAddStaff.TabIndex = 36
        Me.btnAddStaff.Text = "Add"
        Me.btnAddStaff.UseVisualStyleBackColor = False
        '
        'btnDeleteStaff
        '
        Me.btnDeleteStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDeleteStaff.Location = New System.Drawing.Point(352, 330)
        Me.btnDeleteStaff.Name = "btnDeleteStaff"
        Me.btnDeleteStaff.Size = New System.Drawing.Size(97, 35)
        Me.btnDeleteStaff.TabIndex = 35
        Me.btnDeleteStaff.Text = "Delete"
        Me.btnDeleteStaff.UseVisualStyleBackColor = False
        '
        'btnUpdateStaff
        '
        Me.btnUpdateStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdateStaff.Location = New System.Drawing.Point(467, 330)
        Me.btnUpdateStaff.Name = "btnUpdateStaff"
        Me.btnUpdateStaff.Size = New System.Drawing.Size(97, 35)
        Me.btnUpdateStaff.TabIndex = 34
        Me.btnUpdateStaff.Text = "Update"
        Me.btnUpdateStaff.UseVisualStyleBackColor = False
        '
        'btnSearchByIC
        '
        Me.btnSearchByIC.Location = New System.Drawing.Point(633, 127)
        Me.btnSearchByIC.Name = "btnSearchByIC"
        Me.btnSearchByIC.Size = New System.Drawing.Size(114, 26)
        Me.btnSearchByIC.TabIndex = 33
        Me.btnSearchByIC.Text = "Search by IC"
        Me.btnSearchByIC.UseVisualStyleBackColor = True
        '
        'btnSearchByName
        '
        Me.btnSearchByName.Location = New System.Drawing.Point(633, 166)
        Me.btnSearchByName.Name = "btnSearchByName"
        Me.btnSearchByName.Size = New System.Drawing.Size(114, 26)
        Me.btnSearchByName.TabIndex = 32
        Me.btnSearchByName.Text = "Search by Name"
        Me.btnSearchByName.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(306, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(306, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(306, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(305, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "IC"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(416, 246)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(207, 26)
        Me.txtUsername.TabIndex = 25
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(416, 205)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(207, 26)
        Me.txtPhone.TabIndex = 24
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(415, 166)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(207, 26)
        Me.txtName.TabIndex = 23
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(416, 285)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(207, 26)
        Me.txtPassword.TabIndex = 22
        '
        'txtICNumber
        '
        Me.txtICNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtICNumber.Location = New System.Drawing.Point(415, 127)
        Me.txtICNumber.Name = "txtICNumber"
        Me.txtICNumber.Size = New System.Drawing.Size(207, 26)
        Me.txtICNumber.TabIndex = 21
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(780, 514)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnClearFields)
        Me.Controls.Add(Me.dgvStaff)
        Me.Controls.Add(Me.btnAddStaff)
        Me.Controls.Add(Me.btnDeleteStaff)
        Me.Controls.Add(Me.btnUpdateStaff)
        Me.Controls.Add(Me.btnSearchByIC)
        Me.Controls.Add(Me.btnSearchByName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtICNumber)
        Me.Name = "StaffForm"
        Me.Text = "StaffForm"
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents btnClearFields As Button
    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents btnDeleteStaff As Button
    Friend WithEvents btnUpdateStaff As Button
    Friend WithEvents btnSearchByIC As Button
    Friend WithEvents btnSearchByName As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtICNumber As TextBox
End Class
