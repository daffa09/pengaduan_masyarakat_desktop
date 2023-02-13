Imports MySql.Data.MySqlClient

Public Class FormTanggapanAdmin

	Sub kondisiAwal()

		RichTextBox1.Text = ""
		RichTextBox2.Text = ""
		PictureBox1.ImageLocation = ""
		RichTextBox1.Enabled = False
		Button1.Text = "Buat Tanggapan"
		Button2.Text = "Kembali"
		RichTextBox2.Enabled = False
		PictureBox1.Enabled = False
	End Sub

	Sub autoNumeric()

		Dim urutanKode As String
		Dim hitung As Long
		Call koneksi()
		cmd = New MySqlCommand("SELECT * FROM tanggapan WHERE id_tanggapan IN (SELECT MAX(id_tanggapan) FROM tanggapan)", conn)
		dr = cmd.ExecuteReader
		dr.Read()

		If Not dr.HasRows Then

			urutanKode = "01"
			Label6.Text = urutanKode


		Else

			hitung = Microsoft.VisualBasic.Right(dr.GetInt32(0), 2) + 1
			urutanKode = Microsoft.VisualBasic.Right("0" & hitung, 1)
			Label6.Text = urutanKode

		End If

		dr.Close()
		cmd.Dispose()
		conn.Close()
	End Sub

	Sub munculDataGridView()

		Call koneksi()
		da = New MySqlDataAdapter("SELECT * FROM pengaduan WHERE status = 'proses'", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "pengaduan")
		DataGridView1.DataSource = (ds.Tables("pengaduan"))

		dr.Close()
		da.Dispose()
		conn.Close()
	End Sub

	Sub cekIdAdmin()

		Call koneksi()
		cmd = New MySqlCommand("Select * from petugas where nama_petugas = '" & Label4.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()
		If dr.HasRows Then
			Label5.Text = dr.Item("id_petugas")
		End If

		dr.Close()
		cmd.Dispose()
		conn.Close()

	End Sub

	Private Sub FormTanggapanAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		munculDataGridView()
		kondisiAwal()
	End Sub

	Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
		Try

			If DataGridView1.RowCount > 0 Then

				DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
				PictureBox1.ImageLocation = DataGridView1.Rows(e.RowIndex).Cells(4).Value
				PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
				RichTextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
				Label3.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value


			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If Button2.Text = "Cancel" Then
			kondisiAwal()
		Else
			If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then

				Me.Hide()
				MainMenuAdmin.Show()

			End If
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		If Button1.Text = "Buat Tanggapan" Then

			Button1.Text = "Kirim Tanggapan"
			Button2.Text = "Cancel"
			RichTextBox2.Enabled = True

		Else

			If RichTextBox2.Text = "" Or RichTextBox1.Text = "" Then
				MsgBox("Harap Isi pesan Tanggapanya")
			Else
				MsgBox("Anda yakin dengan pesan pengeaduan ini?", MsgBoxStyle.OkCancel)
				If MsgBoxResult.Ok Then
					cekIdAdmin()
					autoNumeric()
					Call koneksi()
					Dim simpanData As String = "INSERT INTO tanggapan VALUES('" & Label6.Text & "', '" & Label3.Text & "', '" & Convert.ToDateTime(Date.Now).ToString("yyyy-MM-dd") & "', '" & RichTextBox2.Text & "', '" & Label5.Text & "')"
					cmd = New MySqlCommand(simpanData, conn)
					cmd.ExecuteNonQuery()
					cmd.Dispose()
					conn.Close()
					MsgBox("Pesan pengaduan berhasil dikirim", MsgBoxStyle.Information)
					Call koneksi()
					cmd = New MySqlCommand("UPDATE pengaduan SET status='selesai' WHERE id_pengaduan='" & Label3.Text & "'", conn)
					cmd.ExecuteNonQuery()
					kondisiAwal()
					munculDataGridView()
				End If

			End If

		End If



	End Sub

	Private Sub FormTanggapanAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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