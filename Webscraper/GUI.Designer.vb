<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI))
        Me.AvatarBox = New System.Windows.Forms.PictureBox()
        Me.StudentName = New System.Windows.Forms.Label()
        Me.DummyBox = New System.Windows.Forms.PictureBox()
        Me.TimetableBox = New System.Windows.Forms.DataGridView()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lesson = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Room = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimetableButton = New System.Windows.Forms.Button()
        CType(Me.AvatarBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DummyBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimetableBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AvatarBox
        '
        Me.AvatarBox.Location = New System.Drawing.Point(22, 20)
        Me.AvatarBox.Name = "AvatarBox"
        Me.AvatarBox.Size = New System.Drawing.Size(137, 167)
        Me.AvatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AvatarBox.TabIndex = 0
        Me.AvatarBox.TabStop = False
        '
        'StudentName
        '
        Me.StudentName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentName.AutoSize = True
        Me.StudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentName.Location = New System.Drawing.Point(26, 195)
        Me.StudentName.Name = "StudentName"
        Me.StudentName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StudentName.Size = New System.Drawing.Size(127, 20)
        Me.StudentName.TabIndex = 1
        Me.StudentName.Text = "Jeremiah Boby"
        Me.StudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DummyBox
        '
        Me.DummyBox.Location = New System.Drawing.Point(22, 20)
        Me.DummyBox.Name = "DummyBox"
        Me.DummyBox.Size = New System.Drawing.Size(137, 167)
        Me.DummyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DummyBox.TabIndex = 2
        Me.DummyBox.TabStop = False
        '
        'TimetableBox
        '
        Me.TimetableBox.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.TimetableBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TimetableBox.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Time, Me.Lesson, Me.Room})
        Me.TimetableBox.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TimetableBox.Location = New System.Drawing.Point(181, 20)
        Me.TimetableBox.Name = "TimetableBox"
        Me.TimetableBox.RowHeadersVisible = False
        Me.TimetableBox.RowHeadersWidth = 5
        Me.TimetableBox.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.TimetableBox.Size = New System.Drawing.Size(303, 167)
        Me.TimetableBox.TabIndex = 3
        '
        'Time
        '
        Me.Time.HeaderText = "Time"
        Me.Time.Name = "Time"
        '
        'Lesson
        '
        Me.Lesson.HeaderText = "Lesson"
        Me.Lesson.Name = "Lesson"
        '
        'Room
        '
        Me.Room.HeaderText = "Room"
        Me.Room.Name = "Room"
        '
        'TimetableButton
        '
        Me.TimetableButton.Location = New System.Drawing.Point(183, 194)
        Me.TimetableButton.Name = "TimetableButton"
        Me.TimetableButton.Size = New System.Drawing.Size(301, 23)
        Me.TimetableButton.TabIndex = 4
        Me.TimetableButton.Text = "Full Timetable"
        Me.TimetableButton.UseVisualStyleBackColor = True
        '
        'GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 236)
        Me.Controls.Add(Me.TimetableButton)
        Me.Controls.Add(Me.TimetableBox)
        Me.Controls.Add(Me.DummyBox)
        Me.Controls.Add(Me.StudentName)
        Me.Controls.Add(Me.AvatarBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GUI"
        Me.Text = "GUI"
        CType(Me.AvatarBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DummyBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimetableBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AvatarBox As PictureBox
    Friend WithEvents StudentName As Label
    Friend WithEvents DummyBox As PictureBox
    Friend WithEvents TimetableBox As DataGridView
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents Lesson As DataGridViewTextBoxColumn
    Friend WithEvents Room As DataGridViewTextBoxColumn
    Friend WithEvents TimetableButton As Button
End Class
