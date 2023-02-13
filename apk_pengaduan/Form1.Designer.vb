<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(389, 294)
		Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(97, 33)
		Me.Button3.TabIndex = 10
		Me.Button3.Text = "Registrasi"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(241, 294)
		Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(97, 33)
		Me.Button4.TabIndex = 9
		Me.Button4.Text = "Login"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(241, 182)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBox2.Size = New System.Drawing.Size(241, 22)
		Me.TextBox2.TabIndex = 8
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(244, 130)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(241, 22)
		Me.TextBox1.TabIndex = 6
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(163, 134)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(73, 17)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Username"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(163, 190)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(69, 17)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Password"
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(272, 246)
		Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(179, 24)
		Me.ComboBox1.TabIndex = 11
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(247, 214)
		Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(129, 21)
		Me.CheckBox1.TabIndex = 12
		Me.CheckBox1.Text = "Show Password"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(43, 32)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(588, 46)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Aplikasi Pengaduan Masyarakat"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(692, 421)
		Me.Controls.Add(Me.CheckBox1)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Aplikasi Pengaduan Masyarakat"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents Label3 As Label
End Class
