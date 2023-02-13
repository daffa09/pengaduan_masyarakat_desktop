<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTanggapanAdmin
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
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(35, 52)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(724, 161)
		Me.DataGridView1.TabIndex = 0
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(251, 632)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(113, 40)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Buat Tanggapan"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'RichTextBox1
		'
		Me.RichTextBox1.Location = New System.Drawing.Point(35, 354)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(724, 91)
		Me.RichTextBox1.TabIndex = 2
		Me.RichTextBox1.Text = ""
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Cross
		Me.PictureBox1.Location = New System.Drawing.Point(333, 230)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(112, 108)
		Me.PictureBox1.TabIndex = 8
		Me.PictureBox1.TabStop = False
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(409, 632)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(113, 40)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "Kembali"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'RichTextBox2
		'
		Me.RichTextBox2.Location = New System.Drawing.Point(35, 501)
		Me.RichTextBox2.Name = "RichTextBox2"
		Me.RichTextBox2.Size = New System.Drawing.Size(724, 91)
		Me.RichTextBox2.TabIndex = 2
		Me.RichTextBox2.Text = ""
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(42, 338)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(95, 13)
		Me.Label1.TabIndex = 9
		Me.Label1.Text = "Pesan Pengaduan"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(42, 485)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(95, 13)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Pesan Tanggapan"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(641, 253)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(104, 13)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "tankapIdPengaduan"
		Me.Label3.Visible = False
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(585, 266)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(203, 13)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "tangkapNamaAdminDariFormSebelumnya"
		Me.Label4.Visible = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(657, 279)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(88, 13)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "TangkapIdAdmin"
		Me.Label5.Visible = False
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(657, 292)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(114, 13)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "TangkapIdTanggapan"
		Me.Label6.Visible = False
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(116, 14)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(552, 33)
		Me.Label7.TabIndex = 9
		Me.Label7.Text = "Form Tanggapan Pengaduan Masyarakat"
		'
		'FormTanggapanAdmin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 714)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.RichTextBox2)
		Me.Controls.Add(Me.RichTextBox1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "FormTanggapanAdmin"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Tanggapan Admin"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Button1 As Button
	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Button2 As Button
	Friend WithEvents RichTextBox2 As RichTextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
End Class
