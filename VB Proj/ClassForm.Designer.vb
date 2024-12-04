<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassForm
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.dgvClassList = New System.Windows.Forms.DataGridView()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblClassName = New System.Windows.Forms.Label()
        Me.lblClassID = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtClassName = New System.Windows.Forms.TextBox()
        Me.txtClassID = New System.Windows.Forms.TextBox()
        Me.ClassListLabel = New System.Windows.Forms.Label()
        CType(Me.dgvClassList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(331, 259)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 36)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Class"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(455, 259)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 36)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update Class"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(579, 259)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(106, 36)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete Class"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.White
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(331, 311)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(354, 35)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Clear"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'dgvClassList
        '
        Me.dgvClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClassList.Location = New System.Drawing.Point(66, 166)
        Me.dgvClassList.Name = "dgvClassList"
        Me.dgvClassList.Size = New System.Drawing.Size(240, 173)
        Me.dgvClassList.TabIndex = 4
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(343, 218)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 18)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "Description"
        '
        'lblClassName
        '
        Me.lblClassName.AutoSize = True
        Me.lblClassName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassName.Location = New System.Drawing.Point(343, 192)
        Me.lblClassName.Name = "lblClassName"
        Me.lblClassName.Size = New System.Drawing.Size(90, 18)
        Me.lblClassName.TabIndex = 6
        Me.lblClassName.Text = "Class Name"
        '
        'lblClassID
        '
        Me.lblClassID.AutoSize = True
        Me.lblClassID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassID.Location = New System.Drawing.Point(343, 166)
        Me.lblClassID.Name = "lblClassID"
        Me.lblClassID.Size = New System.Drawing.Size(64, 18)
        Me.lblClassID.TabIndex = 7
        Me.lblClassID.Text = "Class ID"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(439, 218)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(246, 20)
        Me.txtDescription.TabIndex = 8
        '
        'txtClassName
        '
        Me.txtClassName.Location = New System.Drawing.Point(439, 192)
        Me.txtClassName.Name = "txtClassName"
        Me.txtClassName.Size = New System.Drawing.Size(246, 20)
        Me.txtClassName.TabIndex = 9
        '
        'txtClassID
        '
        Me.txtClassID.Location = New System.Drawing.Point(439, 164)
        Me.txtClassID.Name = "txtClassID"
        Me.txtClassID.Size = New System.Drawing.Size(246, 20)
        Me.txtClassID.TabIndex = 10
        '
        'ClassListLabel
        '
        Me.ClassListLabel.AutoSize = True
        Me.ClassListLabel.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassListLabel.Location = New System.Drawing.Point(254, 57)
        Me.ClassListLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ClassListLabel.Name = "ClassListLabel"
        Me.ClassListLabel.Size = New System.Drawing.Size(307, 41)
        Me.ClassListLabel.TabIndex = 14
        Me.ClassListLabel.Text = "Class Information"
        '
        'ClassForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(822, 496)
        Me.Controls.Add(Me.ClassListLabel)
        Me.Controls.Add(Me.txtClassID)
        Me.Controls.Add(Me.txtClassName)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblClassID)
        Me.Controls.Add(Me.lblClassName)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.dgvClassList)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "ClassForm"
        Me.Text = "ClassForm"
        CType(Me.dgvClassList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents dgvClassList As DataGridView
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblClassName As Label
    Friend WithEvents lblClassID As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtClassName As TextBox
    Friend WithEvents txtClassID As TextBox
    Friend WithEvents ClassListLabel As Label
End Class
