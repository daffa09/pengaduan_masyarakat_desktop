<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanAdmin
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
		Me.Label7 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(262, 26)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(289, 33)
		Me.Label7.TabIndex = 23
		Me.Label7.Text = "Form Laporan Admin"
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(38, 66)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(724, 167)
		Me.DataGridView1.TabIndex = 22
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(336, 632)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(141, 49)
		Me.Button1.TabIndex = 24
		Me.Button1.Text = "Kembali"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(45, 506)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(95, 13)
		Me.Label2.TabIndex = 28
		Me.Label2.Text = "Pesan Tanggapan"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(92, 254)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(37, 13)
		Me.Label1.TabIndex = 29
		Me.Label1.Text = "Status"
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Cross
		Me.PictureBox1.Location = New System.Drawing.Point(336, 251)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(112, 108)
		Me.PictureBox1.TabIndex = 27
		Me.PictureBox1.TabStop = False
		'
		'RichTextBox2
		'
		Me.RichTextBox2.Location = New System.Drawing.Point(38, 522)
		Me.RichTextBox2.Name = "RichTextBox2"
		Me.RichTextBox2.Size = New System.Drawing.Size(724, 91)
		Me.RichTextBox2.TabIndex = 25
		Me.RichTextBox2.Text = ""
		'
		'RichTextBox1
		'
		Me.RichTextBox1.Location = New System.Drawing.Point(38, 375)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(724, 91)
		Me.RichTextBox1.TabIndex = 26
		Me.RichTextBox1.Text = ""
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(143, 251)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(135, 21)
		Me.ComboBox1.TabIndex = 30
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(45, 359)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(95, 13)
		Me.Label3.TabIndex = 28
		Me.Label3.Text = "Pesan Pengaduan"
		'
		'FormLaporanAdmin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 719)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.RichTextBox2)
		Me.Controls.Add(Me.RichTextBox1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "FormLaporanAdmin"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Laporan Admin"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label7 As Label
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Button1 As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents RichTextBox2 As RichTextBox
	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label3 As Label
End Class
