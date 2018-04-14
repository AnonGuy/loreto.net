<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(17, 108)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(89, 32)
        Me.LoginButton.TabIndex = 0
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'UsernameBox
        '
        Me.UsernameBox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameBox.Location = New System.Drawing.Point(14, 21)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(180, 26)
        Me.UsernameBox.TabIndex = 1
        '
        'PasswordBox
        '
        Me.PasswordBox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBox.Location = New System.Drawing.Point(14, 65)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PasswordBox.Size = New System.Drawing.Size(180, 26)
        Me.PasswordBox.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(114, 117)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Use Default"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 153)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.LoginButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginButton As Button
    Friend WithEvents UsernameBox As TextBox
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
