<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrationForm
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
        Me.cmbStudent = New System.Windows.Forms.ComboBox()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.btnRegisterSubject = New System.Windows.Forms.Button()
        Me.btnDisplaySubjects = New System.Windows.Forms.Button()
        Me.btnPrintSlip = New System.Windows.Forms.Button()
        Me.btnTotalCredit = New System.Windows.Forms.Button()
        Me.btnCalculateFee = New System.Windows.Forms.Button()
        Me.btnEmailSlip = New System.Windows.Forms.Button()
        Me.btnPrintSubjectList = New System.Windows.Forms.Button()
        Me.dgvRegistration = New System.Windows.Forms.DataGridView()
        Me.lblTotalCredits = New System.Windows.Forms.Label()
        Me.lblTotalFee = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvRegistration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbStudent
        '
        Me.cmbStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStudent.FormattingEnabled = True
        Me.cmbStudent.Location = New System.Drawing.Point(400, 89)
        Me.cmbStudent.Name = "cmbStudent"
        Me.cmbStudent.Size = New System.Drawing.Size(235, 26)
        Me.cmbStudent.TabIndex = 0
        '
        'cmbSubject
        '
        Me.cmbSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Location = New System.Drawing.Point(400, 130)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(235, 26)
        Me.cmbSubject.TabIndex = 1
        '
        'btnRegisterSubject
        '
        Me.btnRegisterSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegisterSubject.Location = New System.Drawing.Point(512, 175)
        Me.btnRegisterSubject.Name = "btnRegisterSubject"
        Me.btnRegisterSubject.Size = New System.Drawing.Size(112, 38)
        Me.btnRegisterSubject.TabIndex = 2
        Me.btnRegisterSubject.Text = "Register Subject"
        Me.btnRegisterSubject.UseVisualStyleBackColor = False
        '
        'btnDisplaySubjects
        '
        Me.btnDisplaySubjects.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDisplaySubjects.Location = New System.Drawing.Point(394, 175)
        Me.btnDisplaySubjects.Name = "btnDisplaySubjects"
        Me.btnDisplaySubjects.Size = New System.Drawing.Size(112, 38)
        Me.btnDisplaySubjects.TabIndex = 3
        Me.btnDisplaySubjects.Text = "Display Subjects"
        Me.btnDisplaySubjects.UseVisualStyleBackColor = False
        '
        'btnPrintSlip
        '
        Me.btnPrintSlip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrintSlip.Location = New System.Drawing.Point(394, 233)
        Me.btnPrintSlip.Name = "btnPrintSlip"
        Me.btnPrintSlip.Size = New System.Drawing.Size(112, 38)
        Me.btnPrintSlip.TabIndex = 4
        Me.btnPrintSlip.Text = "Print Slip"
        Me.btnPrintSlip.UseVisualStyleBackColor = False
        '
        'btnTotalCredit
        '
        Me.btnTotalCredit.BackColor = System.Drawing.Color.Yellow
        Me.btnTotalCredit.Location = New System.Drawing.Point(512, 233)
        Me.btnTotalCredit.Name = "btnTotalCredit"
        Me.btnTotalCredit.Size = New System.Drawing.Size(112, 38)
        Me.btnTotalCredit.TabIndex = 5
        Me.btnTotalCredit.Text = "Total CHours"
        Me.btnTotalCredit.UseVisualStyleBackColor = False
        '
        'btnCalculateFee
        '
        Me.btnCalculateFee.BackColor = System.Drawing.Color.Fuchsia
        Me.btnCalculateFee.Location = New System.Drawing.Point(394, 291)
        Me.btnCalculateFee.Name = "btnCalculateFee"
        Me.btnCalculateFee.Size = New System.Drawing.Size(112, 38)
        Me.btnCalculateFee.TabIndex = 6
        Me.btnCalculateFee.Text = "Calculate Fee"
        Me.btnCalculateFee.UseVisualStyleBackColor = False
        '
        'btnEmailSlip
        '
        Me.btnEmailSlip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEmailSlip.Location = New System.Drawing.Point(512, 291)
        Me.btnEmailSlip.Name = "btnEmailSlip"
        Me.btnEmailSlip.Size = New System.Drawing.Size(112, 38)
        Me.btnEmailSlip.TabIndex = 7
        Me.btnEmailSlip.Text = "Email Slip"
        Me.btnEmailSlip.UseVisualStyleBackColor = False
        '
        'btnPrintSubjectList
        '
        Me.btnPrintSubjectList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrintSubjectList.Location = New System.Drawing.Point(394, 346)
        Me.btnPrintSubjectList.Name = "btnPrintSubjectList"
        Me.btnPrintSubjectList.Size = New System.Drawing.Size(230, 38)
        Me.btnPrintSubjectList.TabIndex = 9
        Me.btnPrintSubjectList.Text = "Print Subject List"
        Me.btnPrintSubjectList.UseVisualStyleBackColor = False
        '
        'dgvRegistration
        '
        Me.dgvRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistration.Location = New System.Drawing.Point(12, 89)
        Me.dgvRegistration.Name = "dgvRegistration"
        Me.dgvRegistration.Size = New System.Drawing.Size(240, 209)
        Me.dgvRegistration.TabIndex = 10
        '
        'lblTotalCredits
        '
        Me.lblTotalCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCredits.Location = New System.Drawing.Point(167, 326)
        Me.lblTotalCredits.Name = "lblTotalCredits"
        Me.lblTotalCredits.Size = New System.Drawing.Size(179, 23)
        Me.lblTotalCredits.TabIndex = 11
        Me.lblTotalCredits.Text = "Total Credit Hours:"
        '
        'lblTotalFee
        '
        Me.lblTotalFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFee.Location = New System.Drawing.Point(167, 370)
        Me.lblTotalFee.Name = "lblTotalFee"
        Me.lblTotalFee.Size = New System.Drawing.Size(179, 27)
        Me.lblTotalFee.TabIndex = 12
        Me.lblTotalFee.Text = "Total Fee: RM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Select Student:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(271, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Select Subject:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 41)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Registration"
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(769, 427)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotalFee)
        Me.Controls.Add(Me.lblTotalCredits)
        Me.Controls.Add(Me.dgvRegistration)
        Me.Controls.Add(Me.btnPrintSubjectList)
        Me.Controls.Add(Me.btnEmailSlip)
        Me.Controls.Add(Me.btnCalculateFee)
        Me.Controls.Add(Me.btnTotalCredit)
        Me.Controls.Add(Me.btnPrintSlip)
        Me.Controls.Add(Me.btnDisplaySubjects)
        Me.Controls.Add(Me.btnRegisterSubject)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.cmbStudent)
        Me.Name = "RegistrationForm"
        Me.Text = "RegistrationForm"
        CType(Me.dgvRegistration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbStudent As ComboBox
    Friend WithEvents cmbSubject As ComboBox
    Friend WithEvents btnRegisterSubject As Button
    Friend WithEvents btnDisplaySubjects As Button
    Friend WithEvents btnPrintSlip As Button
    Friend WithEvents btnTotalCredit As Button
    Friend WithEvents btnCalculateFee As Button
    Friend WithEvents btnEmailSlip As Button
    Friend WithEvents btnPrintSubjectList As Button
    Friend WithEvents dgvRegistration As DataGridView
    Friend WithEvents lblTotalCredits As Label
    Friend WithEvents lblTotalFee As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
