Imports MySql.Data.MySqlClient

Public Class FormTanggapanPengaduanMasyarakat

	Sub cekNik()
		Call koneksi()
		cmd = New MySqlCommand("Select * from masyarakat where nama = '" & Label4.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()
		If dr.HasRows Then
			Label3.Text = dr.Item("nik")
		End If

		dr.Close()
		cmd.Dispose()
		conn.Close()
	End Sub

	Sub munculDataGridView()

		Call koneksi()
		da = New MySqlDataAdapter("SELECT pengaduan.isi_laporan, pengaduan.foto, tanggapan.tanggapan, pengaduan.tgl_pengaduan, tanggapan.tgl_penanggapan, pengaduan.status
									FROM tanggapan INNER JOIN pengaduan
									ON tanggapan.id_pengaduan = pengaduan.id_pengaduan 
									WHERE nik = '" & Label3.Text & "'", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "tanggapan")
		DataGridView1.DataSource = (ds.Tables("tanggapan"))

	End Sub

	Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
		Try

			If DataGridView1.RowCount > 0 Then

				DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
				PictureBox1.ImageLocation = DataGridView1.Rows(e.RowIndex).Cells(1).Value
				PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
				RichTextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
				RichTextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value

			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then

			Me.Hide()
			MainMenuMasyarakat.Show()

		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		cekNik()
		munculDataGridView()
	End Sub

	Private Sub FormTanggapanPengaduanMasyarakat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		RichTextBox1.Enabled = False
		RichTextBox2.Enabled = False
		PictureBox1.ImageLocation = ""
		MsgBox("tekan 'lihat tanggapan' jika ingin melihat tanggapan dari pesan yang pengaduan yang ada kirim!")
	End Sub

	Private Sub FormTanggapanPengaduanMasyarakat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Dim msg As String = "Anda yakin ingin keluar dari aplikasi ini?"
		Dim title As String = "Form closing"
		Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
		If result = DialogResult.Cancel Then
			e.Cancel = True
		Else
			MainMenuMasyarakat.Show()
		End If
	End Sub
End Class