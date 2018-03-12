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
        CType(Me.AvatarBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(158, 190)
        Me.Controls.Add(Me.AvatarBox)
        Me.Name = "GUI"
        Me.Text = "GUI"
        CType(Me.AvatarBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AvatarBox As PictureBox
End Class
