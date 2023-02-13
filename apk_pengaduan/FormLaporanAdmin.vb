Imports MySql.Data.MySqlClient

Public Class FormLaporanAdmin

	Sub munculDataGridView_statusSelesai()

		Call koneksi()
		da = New MySqlDataAdapter("SELECT pengaduan.isi_laporan, pengaduan.foto, tanggapan.tanggapan, pengaduan.tgl_pengaduan, tanggapan.tgl_penanggapan, pengaduan.status
									FROM tanggapan INNER JOIN pengaduan
									ON tanggapan.id_pengaduan = pengaduan.id_pengaduan
									WHERE status = 'selesai'", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "tanggapan_selesai")
		DataGridView1.DataSource = (ds.Tables("tanggapan_selesai"))
		DataGridView1.ReadOnly = True

		dr.Close()
		da.Dispose()
		conn.Close()

	End Sub

	Sub munculDataGridView_statusProses()

		Call koneksi()
		da = New MySqlDataAdapter("SELECT * FROM pengaduan WHERE status = 'proses'", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "tanggapan_proses")
		DataGridView1.DataSource = (ds.Tables("tanggapan_proses"))
		DataGridView1.ReadOnly = True

		dr.Close()
		da.Dispose()
		conn.Close()

	End Sub

	Private Sub FormLaporanAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MsgBox("Silahkan pilih status laporan yang ingin di lihat")
		ComboBox1.Items.Add("Proses")
		ComboBox1.Items.Add("Selesai")
		RichTextBox1.Enabled = False
		RichTextBox2.Enabled = False
		PictureBox1.Enabled = False

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then

			Me.Hide()
			MainMenuAdmin.Show()

		End If
	End Sub

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

		If ComboBox1.Text = "Proses" Then
			munculDataGridView_statusProses()
		ElseIf ComboBox1.Text = "Selesai" Then
			munculDataGridView_statusSelesai()
		Else
			MsgBox("Input tidak valid")
		End If

	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
		Try
			If ComboBox1.Text = "Proses" Then

				If DataGridView1.RowCount > 0 Then

					DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
					PictureBox1.ImageLocation = DataGridView1.Rows(e.RowIndex).Cells(4).Value
					PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
					RichTextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
					RichTextBox2.Text = ""


				End If

			ElseIf ComboBox1.Text = "Selesai" Then

				If DataGridView1.RowCount > 0 Then

					DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
					PictureBox1.ImageLocation = DataGridView1.Rows(e.RowIndex).Cells(1).Value
					PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
					RichTextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
					RichTextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value

				End If

			End If


		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try
	End Sub

	Private Sub FormLaporanAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Dim msg As String = "Anda yakin ingin keluar dari aplikasi ini?"
		Dim title As String = "Form closing"
		Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
		If result = DialogResult.Cancel Then
			e.Cancel = True
		Else
			MainMenuAdmin.Show()
		End If
	End Sub
End Class