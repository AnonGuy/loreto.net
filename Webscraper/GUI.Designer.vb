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
        Me.AvatarBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DummyBox = New System.Windows.Forms.PictureBox()
        CType(Me.AvatarBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DummyBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AvatarBox
        '
        Me.AvatarBox.Location = New System.Drawing.Point(12, 12)
        Me.AvatarBox.Name = "AvatarBox"
        Me.AvatarBox.Size = New System.Drawing.Size(137, 167)
        Me.AvatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AvatarBox.TabIndex = 0
        Me.AvatarBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(107, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jeremiah Boby"
        '
        'DummyBox
        '
        Me.DummyBox.Location = New System.Drawing.Point(12, 12)
        Me.DummyBox.Name = "DummyBox"
        Me.DummyBox.Size = New System.Drawing.Size(137, 167)
        Me.DummyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DummyBox.TabIndex = 2
        Me.DummyBox.TabStop = False
        '
        'GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 315)
        Me.Controls.Add(Me.DummyBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AvatarBox)
        Me.Name = "GUI"
        Me.Text = "GUI"
        CType(Me.AvatarBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DummyBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AvatarBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DummyBox As PictureBox
End Class
