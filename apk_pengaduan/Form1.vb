Imports MySql.Data.MySqlClient

Public Class Form1

	Sub bersihInput()
		TextBox1.Text = ""
		TextBox2.Text = ""
		ComboBox1.Text = "Level user.."
		TextBox2.PasswordChar = "*"
	End Sub
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		bersihInput()
		ComboBox1.Items.Add("Admin")
		ComboBox1.Items.Add("Petugas")
		ComboBox1.Items.Add("Masyarakat")

	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "Level user.." Then
			MsgBox("Harap isi semua data, dan isi level user dengan baik", MsgBoxStyle.Exclamation, "Perhatian!")
		Else

			If ComboBox1.Text = "Admin" Then
				Call koneksi()
				cmd = New MySqlCommand("Select * from petugas where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", conn)
				dr = cmd.ExecuteReader
				dr.Read()
				If dr.HasRows Then
					If dr.Item("level") = "admin" Then

						MsgBox("Login berhasil", MsgBoxStyle.Information, "Perhatian!")
						Me.Hide()
						bersihInput()
						MainMenuAdmin.Label3.Text = dr.Item("nama_petugas")
						MainMenuAdmin.Show()
					Else
						MsgBox("User tidak terdaftar, silahkan daftar terlebih dahulu!")
					End If
				Else
					MsgBox("Username atau Password salah!")
					bersihInput()
				End If

			ElseIf ComboBox1.Text = "Petugas" Then
				Call koneksi()
				cmd = New MySqlCommand("select * from petugas where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", conn)
				dr = cmd.ExecuteReader
				dr.Read()
				If dr.HasRows Then
					If dr.Item("level") = "petugas" Then

						MsgBox("Login berhasil", MsgBoxStyle.Information, "Perhatian!")
						Me.Hide()
						bersihInput()
						MainMenuPetugas.Label3.Text = dr.Item("nama_petugas")
						MainMenuPetugas.Show()
					Else
						MsgBox("User tidak terdaftar, silahkan daftar terlebih dahulu!")

					End If
				Else
					MsgBox("Username atau Password salah!")
					bersihInput()
				End If

			ElseIf ComboBox1.Text = "Masyarakat" Then

				Call koneksi()
				cmd = New MySqlCommand("select * from masyarakat where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", conn)
				dr = cmd.ExecuteReader
				dr.Read()
				If dr.HasRows Then

					MsgBox("Login berhasil", MsgBoxStyle.Information, "Perhatian!")
					Me.Hide()
					bersihInput()
					MainMenuMasyarakat.Label3.Text = dr.Item("nama")
					MainMenuMasyarakat.Show()

				Else
					MsgBox("User tidak terdaftar, silahkan daftar terlebih dahulu!")
					bersihInput()
				End If

			End If
		End If
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Me.Hide()
		FormRegistrasiMasyarakat.Show()
		bersihInput()
	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

		If CheckBox1.Checked = True Then

			TextBox2.PasswordChar = ""

		Else

			TextBox2.PasswordChar = "*"


		End If

	End Sub

	Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Dim msg As String = "Anda yakin ingin keluar dari aplikasi?"
		Dim title As String = "Form closing"
		Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
		If result = DialogResult.Cancel Then
			e.Cancel = True
		End If
	End Sub
End Class
