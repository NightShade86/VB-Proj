<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherUIForm
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
        Me.lblTeacherName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblTeachingLoad = New System.Windows.Forms.Label()
        Me.dgvTeachingLoad = New System.Windows.Forms.DataGridView()
        Me.btnViewTeachingLoad = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvTeachingLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTeacherName
        '
        Me.lblTeacherName.Location = New System.Drawing.Point(15, 198)
        Me.lblTeacherName.Name = "lblTeacherName"
        Me.lblTeacherName.Size = New System.Drawing.Size(349, 23)
        Me.lblTeacherName.TabIndex = 0
        '
        'lblPhone
        '
        Me.lblPhone.Location = New System.Drawing.Point(15, 230)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(349, 23)
        Me.lblPhone.TabIndex = 1
        '
        'lblTeachingLoad
        '
        Me.lblTeachingLoad.Location = New System.Drawing.Point(15, 253)
        Me.lblTeachingLoad.Name = "lblTeachingLoad"
        Me.lblTeachingLoad.Size = New System.Drawing.Size(349, 23)
        Me.lblTeachingLoad.TabIndex = 2
        '
        'dgvTeachingLoad
        '
        Me.dgvTeachingLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeachingLoad.Location = New System.Drawing.Point(11, 45)
        Me.dgvTeachingLoad.Name = "dgvTeachingLoad"
        Me.dgvTeachingLoad.Size = New System.Drawing.Size(353, 150)
        Me.dgvTeachingLoad.TabIndex = 3
        '
        'btnViewTeachingLoad
        '
        Me.btnViewTeachingLoad.BackColor = System.Drawing.Color.White
        Me.btnViewTeachingLoad.Location = New System.Drawing.Point(18, 279)
        Me.btnViewTeachingLoad.Name = "btnViewTeachingLoad"
        Me.btnViewTeachingLoad.Size = New System.Drawing.Size(126, 23)
        Me.btnViewTeachingLoad.TabIndex = 4
        Me.btnViewTeachingLoad.Text = "View Teaching Load"
        Me.btnViewTeachingLoad.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLogout.Location = New System.Drawing.Point(18, 308)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(126, 23)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Teacher Dashboard"
        '
        'TeacherUIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(376, 346)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnViewTeachingLoad)
        Me.Controls.Add(Me.dgvTeachingLoad)
        Me.Controls.Add(Me.lblTeachingLoad)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblTeacherName)
        Me.Name = "TeacherUIForm"
        Me.Text = "TeacherUIForm"
        CType(Me.dgvTeachingLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTeacherName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblTeachingLoad As Label
    Friend WithEvents dgvTeachingLoad As DataGridView
    Friend WithEvents btnViewTeachingLoad As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
End Class
