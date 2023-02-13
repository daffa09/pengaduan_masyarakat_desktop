<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTanggapanPengaduanMasyarakat
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Button1 = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(41, 478)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(95, 13)
		Me.Label2.TabIndex = 16
		Me.Label2.Text = "Pesan Tanggapan"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(584, 259)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(203, 13)
		Me.Label4.TabIndex = 19
		Me.Label4.Text = "tangkapNamaAdminDariFormSebelumnya"
		Me.Label4.Visible = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(640, 246)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(117, 13)
		Me.Label3.TabIndex = 20
		Me.Label3.Text = "tangkapNikMasyarakat"
		Me.Label3.Visible = False
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(130, 8)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(537, 33)
		Me.Label7.TabIndex = 21
		Me.Label7.Text = "Tanggapan Pengaduan Dari Masyarakat"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(41, 331)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(95, 13)
		Me.Label1.TabIndex = 22
		Me.Label1.Text = "Pesan Pengaduan"
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Cross
		Me.PictureBox1.Location = New System.Drawing.Point(332, 223)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(112, 108)
		Me.PictureBox1.TabIndex = 15
		Me.PictureBox1.TabStop = False
		'
		'RichTextBox2
		'
		Me.RichTextBox2.Location = New System.Drawing.Point(34, 494)
		Me.RichTextBox2.Name = "RichTextBox2"
		Me.RichTextBox2.Size = New System.Drawing.Size(724, 91)
		Me.RichTextBox2.TabIndex = 13
		Me.RichTextBox2.Text = ""
		'
		'RichTextBox1
		'
		Me.RichTextBox1.Location = New System.Drawing.Point(34, 347)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(724, 91)
		Me.RichTextBox1.TabIndex = 14
		Me.RichTextBox1.Text = ""
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(405, 623)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(113, 40)
		Me.Button2.TabIndex = 11
		Me.Button2.Text = "Kembali"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(34, 45)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(724, 161)
		Me.DataGridView1.TabIndex = 10
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(260, 623)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(113, 40)
		Me.Button1.TabIndex = 11
		Me.Button1.Text = "Lihat Tanggapan"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'FormTanggapanPengaduanMasyarakat
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 690)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.RichTextBox2)
		Me.Controls.Add(Me.RichTextBox1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "FormTanggapanPengaduanMasyarakat"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Tanggapan Pengaduan Masyarakat"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label2 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents RichTextBox2 As RichTextBox
	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents Button2 As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Button1 As Button
End Class
