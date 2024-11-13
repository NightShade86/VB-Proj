<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectForm
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
        Me.btnSearchSubject = New System.Windows.Forms.Button()
        Me.btnUpdateSubject = New System.Windows.Forms.Button()
        Me.btnDeleteSubject = New System.Windows.Forms.Button()
        Me.btnAddSubject = New System.Windows.Forms.Button()
        Me.txtSubjectName = New System.Windows.Forms.TextBox()
        Me.txtCreditHours = New System.Windows.Forms.TextBox()
        Me.txtSubjectCode = New System.Windows.Forms.TextBox()
        Me.dgvSubjects = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClassListLabel = New System.Windows.Forms.Label()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearchSubject
        '
        Me.btnSearchSubject.Location = New System.Drawing.Point(351, 121)
        Me.btnSearchSubject.Name = "btnSearchSubject"
        Me.btnSearchSubject.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchSubject.TabIndex = 0
        Me.btnSearchSubject.Text = "Search"
        Me.btnSearchSubject.UseVisualStyleBackColor = True
        '
        'btnUpdateSubject
        '
        Me.btnUpdateSubject.Location = New System.Drawing.Point(405, 150)
        Me.btnUpdateSubject.Name = "btnUpdateSubject"
        Me.btnUpdateSubject.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateSubject.TabIndex = 1
        Me.btnUpdateSubject.Text = "Update"
        Me.btnUpdateSubject.UseVisualStyleBackColor = True
        '
        'btnDeleteSubject
        '
        Me.btnDeleteSubject.Location = New System.Drawing.Point(311, 174)
        Me.btnDeleteSubject.Name = "btnDeleteSubject"
        Me.btnDeleteSubject.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteSubject.TabIndex = 2
        Me.btnDeleteSubject.Text = "Delete Subject"
        Me.btnDeleteSubject.UseVisualStyleBackColor = True
        '
        'btnAddSubject
        '
        Me.btnAddSubject.Location = New System.Drawing.Point(405, 193)
        Me.btnAddSubject.Name = "btnAddSubject"
        Me.btnAddSubject.Size = New System.Drawing.Size(75, 23)
        Me.btnAddSubject.TabIndex = 3
        Me.btnAddSubject.Text = "Add"
        Me.btnAddSubject.UseVisualStyleBackColor = True
        '
        'txtSubjectName
        '
        Me.txtSubjectName.Location = New System.Drawing.Point(396, 13)
        Me.txtSubjectName.Name = "txtSubjectName"
        Me.txtSubjectName.Size = New System.Drawing.Size(100, 20)
        Me.txtSubjectName.TabIndex = 4
        '
        'txtCreditHours
        '
        Me.txtCreditHours.Location = New System.Drawing.Point(396, 39)
        Me.txtCreditHours.Name = "txtCreditHours"
        Me.txtCreditHours.Size = New System.Drawing.Size(100, 20)
        Me.txtCreditHours.TabIndex = 5
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.Location = New System.Drawing.Point(396, 65)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.Size = New System.Drawing.Size(100, 20)
        Me.txtSubjectCode.TabIndex = 6
        '
        'dgvSubjects
        '
        Me.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubjects.Location = New System.Drawing.Point(15, 32)
        Me.dgvSubjects.Name = "dgvSubjects"
        Me.dgvSubjects.Size = New System.Drawing.Size(240, 150)
        Me.dgvSubjects.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(316, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Subject Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Credit Hours"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Subject Code"
        '
        'ClassListLabel
        '
        Me.ClassListLabel.AutoSize = True
        Me.ClassListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassListLabel.Location = New System.Drawing.Point(11, 9)
        Me.ClassListLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ClassListLabel.Name = "ClassListLabel"
        Me.ClassListLabel.Size = New System.Drawing.Size(92, 20)
        Me.ClassListLabel.TabIndex = 15
        Me.ClassListLabel.Text = "Subject List"
        '
        'SubjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 293)
        Me.Controls.Add(Me.ClassListLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSubjects)
        Me.Controls.Add(Me.txtSubjectCode)
        Me.Controls.Add(Me.txtCreditHours)
        Me.Controls.Add(Me.txtSubjectName)
        Me.Controls.Add(Me.btnAddSubject)
        Me.Controls.Add(Me.btnDeleteSubject)
        Me.Controls.Add(Me.btnUpdateSubject)
        Me.Controls.Add(Me.btnSearchSubject)
        Me.Name = "SubjectForm"
        Me.Text = "SubjectForm"
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearchSubject As Button
    Friend WithEvents btnUpdateSubject As Button
    Friend WithEvents btnDeleteSubject As Button
    Friend WithEvents btnAddSubject As Button
    Friend WithEvents txtSubjectName As TextBox
    Friend WithEvents txtCreditHours As TextBox
    Friend WithEvents txtSubjectCode As TextBox
    Friend WithEvents dgvSubjects As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ClassListLabel As Label
End Class
