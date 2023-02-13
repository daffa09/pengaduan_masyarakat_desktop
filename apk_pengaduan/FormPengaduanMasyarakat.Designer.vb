<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengaduanMasyarakat
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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.FilePhoto = New System.Windows.Forms.OpenFileDialog()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(253, 408)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(144, 36)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Kirim Pengaduan"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(413, 408)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(144, 36)
		Me.Button2.TabIndex = 0
		Me.Button2.Text = "Kembali"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'FilePhoto
		'
		Me.FilePhoto.FileName = "FilePhoto"
		'
		'RichTextBox1
		'
		Me.RichTextBox1.Location = New System.Drawing.Point(75, 241)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(663, 138)
		Me.RichTextBox1.TabIndex = 8
		Me.RichTextBox1.Text = ""
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(315, 472)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(129, 13)
		Me.Label1.TabIndex = 9
		Me.Label1.Text = "tangkapNamaMasyarakat"
		Me.Label1.Visible = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(450, 472)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(67, 13)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "tangkapFoto"
		Me.Label2.Visible = False
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(532, 472)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(109, 13)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "tangkapIdpengaduan"
		Me.Label4.Visible = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(647, 472)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(113, 13)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "tankapNIKMasyarakat"
		Me.Label5.Visible = False
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(340, 206)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(128, 29)
		Me.Button3.TabIndex = 10
		Me.Button3.Text = "Tambah Foto"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Cross
		Me.PictureBox1.Enabled = False
		Me.PictureBox1.Location = New System.Drawing.Point(318, 31)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(177, 159)
		Me.PictureBox1.TabIndex = 7
		Me.PictureBox1.TabStop = False
		'
		'FormPengaduanMasyarakat
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(777, 493)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.RichTextBox1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Name = "FormPengaduanMasyarakat"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Menulis Pengaduan Masyarakat"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents FilePhoto As OpenFileDialog
	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Button3 As Button
End Class
