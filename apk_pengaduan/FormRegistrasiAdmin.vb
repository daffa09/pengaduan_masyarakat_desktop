Imports MySql.Data.MySqlClient

Public Class FormRegistrasiAdmin

	Sub kondisiAwal()

		TextBox1.Text = ""
		TextBox2.Text = ""
		TextBox3.Text = ""
		TextBox4.Text = ""
		TextBox5.Text = ""
		TextBox7.Text = ""


		TextBox2.Enabled = False
		TextBox3.Enabled = False
		TextBox4.Enabled = False
		TextBox5.Enabled = False
		TextBox7.Enabled = False

		CheckBox1.Enabled = False
		ComboBox1.Text = "Level User.."
		ComboBox1.Enabled = False

		btn_insert.Enabled = True
		btn_update.Enabled = True
		btn_delete.Enabled = True
		btn_search.Enabled = False
		btn_insert.Text = "Insert"
		btn_update.Text = "Update"
		btn_close.Text = "Close"
	End Sub

	Sub munculDataGridView()

		koneksi()
		da = New MySqlDataAdapter("SELECT * FROM petugas", conn)
		ds = New DataSet
		ds.Clear()
		da.Fill(ds, "petugas")
		DataGridView1.DataSource = (ds.Tables("petugas"))
		DataGridView1.ReadOnly = True
		DataGridView1.Columns(3).Visible = False

	End Sub


	Sub autoNumeric()

		Dim urutanKode As String
		Dim hitung As Long
		cmd = New MySqlCommand("SELECT * FROM petugas WHERE id_petugas IN (SELECT MAX(id_petugas) FROM petugas)", conn)
		dr = cmd.ExecuteReader
		dr.Read()

		If Not dr.HasRows Then

			urutanKode = "01"
			TextBox7.Text = urutanKode


		Else

			hitung = Microsoft.VisualBasic.Right(dr.GetInt32(0), 2) + 1
			urutanKode = Microsoft.VisualBasic.Right("0" & hitung, 1)
			TextBox7.Text = urutanKode

		End If

	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

		If CheckBox1.Checked = True Then

			TextBox4.PasswordChar = ""

		Else

			TextBox4.PasswordChar = "*"


		End If

	End Sub

	Private Sub FormRegistrasiAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		munculDataGridView()
		kondisiAwal()
		ComboBox1.Items.Add("Admin")
		ComboBox1.Items.Add("Petugas")
	End Sub

	Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

		Try

			If DataGridView1.RowCount > 0 Then

				DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
				TextBox7.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
				TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
				TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
				TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
				TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
				ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value


			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Information)
		End Try

	End Sub

	Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click

		If btn_close.Text = "Close" Then

			If MsgBox("Anda yakin ingin keluar menu ini?", MsgBoxStyle.YesNo, "Peringatan!") = MsgBoxResult.Yes Then

				Me.Hide()
				MainMenuAdmin.Show()

			End If

		Else

			kondisiAwal()
			munculDataGridView()

		End If

	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

		Call koneksi()
		cmd = New MySqlCommand("SELECT * FROM petugas WHERE	nama_petugas='" & TextBox1.Text & "' OR username='" & TextBox1.Text & "' OR telp='" & TextBox1.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()

		If dr.HasRows Then

			koneksi()
			da = New MySqlDataAdapter("SELECT * FROM petugas WHERE	nama_petugas='" & TextBox1.Text & "' OR username='" & TextBox1.Text & "' OR telp='" & TextBox1.Text & "'", conn)
			ds = New DataSet
			da.Fill(ds, "petugas")
			DataGridView1.DataSource = ds.Tables("petugas")

		Else
			munculDataGridView()
			kondisiAwal()
		End If
	End Sub

	Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

		If btn_insert.Text = "Insert" Then

			btn_insert.Text = "Save"
			btn_update.Enabled = False
			btn_delete.Enabled = False
			btn_close.Text = "Cancel"

			TextBox2.Enabled = True
			TextBox3.Enabled = True
			TextBox4.Enabled = True
			TextBox5.Enabled = True
			CheckBox1.Enabled = True
			ComboBox1.Enabled = True

			TextBox2.Text = ""
			TextBox3.Text = ""
			TextBox4.Text = ""
			TextBox5.Text = ""
			ComboBox1.Text = "Level User.."

			autoNumeric()

		Else

			If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "Level User.." Or TextBox7.Text = "" Then

				MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

			Else

				If MsgBox("Apakah anda yakin ingin menyimpan data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

					Call koneksi()
					cmd = New MySqlCommand("INSERT INTO petugas VALUES('" & TextBox7.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & ComboBox1.Text & "')", conn)
					cmd.ExecuteNonQuery()
					MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
					kondisiAwal()
					munculDataGridView()

				ElseIf MsgBoxResult.Cancel Then
				End If


			End If

		End If

	End Sub

	Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

		If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "Level User.." Or TextBox7.Text = "" Then
			MsgBox("Silahkan pilih data pada tabel, lalu edit")
		Else

			If btn_update.Text = "Update" Then

				btn_update.Text = "Save"
				btn_delete.Enabled = False
				btn_insert.Enabled = False
				btn_close.Text = "Cancel"

				TextBox2.Enabled = True
				TextBox3.Enabled = True
				TextBox4.Enabled = True
				TextBox5.Enabled = True
				CheckBox1.Enabled = True
				ComboBox1.Enabled = True

			Else

				If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "Level User.." Or TextBox7.Text = "" Then

					MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

				Else

					If MsgBox("Apakah anda yakin ingin merubah data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

						Call koneksi()
						cmd = New MySqlCommand("UPDATE petugas SET nama_petugas='" & TextBox2.Text & "', username='" & TextBox3.Text & "', password='" & TextBox4.Text & "', telp='" & TextBox5.Text & "', level='" & ComboBox1.Text & "' WHERE id_petugas='" & TextBox7.Text & "'", conn)
						cmd.ExecuteNonQuery()
						MsgBox("Data berhasil diupdate", MsgBoxStyle.Information, "Informasi")
						kondisiAwal()
						munculDataGridView()

					ElseIf MsgBoxResult.Cancel Then
					End If

				End If


			End If
		End If
	End Sub

	Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

		If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "Level User.." Or TextBox7.Text = "" Then
			MsgBox("Silahkan pilih data pada tabel, lalu hapus")
		Else

			If btn_update.Text = "Delete" Then

				btn_update.Enabled = False
				btn_insert.Enabled = False
				btn_close.Text = "Cancel"

			Else

				If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "Level User.." Or TextBox7.Text = "" Then

					MsgBox("Harap isi semua data terlebih dahulu!", MsgBoxStyle.Exclamation, "Perhatian!")

				Else

					If MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

						koneksi()
						cmd = New MySqlCommand("DELETE FROM petugas WHERE id_petugas='" & TextBox7.Text & "'", conn)
						cmd.ExecuteNonQuery()
						MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
						kondisiAwal()
						munculDataGridView()

					ElseIf MsgBoxResult.Cancel Then
					End If

				End If
			End If
		End If

	End Sub

	Private Sub FormRegistrasiAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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