Imports MySql.Data.MySqlClient

Public Class FormRegistrasiMasyarakat

	Sub kondisiAwal()
		TextBox1.Text = ""
		TextBox2.Text = ""
		TextBox3.Text = ""
		TextBox4.Text = ""
		TextBox5.Text = ""
		TextBox4.PasswordChar = "*"

	End Sub
	Private Sub FormRegistrasiMasyarakat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TextBox4.PasswordChar = "*"
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If MsgBox("Anda yakin ingin keluar dari menu ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
			Me.Hide()
			Form1.Show()
		Else

		End If
	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

		If CheckBox1.Checked = True Then

			TextBox4.PasswordChar = ""

		Else

			TextBox4.PasswordChar = "*"


		End If

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
			MsgBox("Silahkan isi data dengan benar")
		Else
			If MsgBox("Apakah anda yakin ingin menyimpan data ini?", MsgBoxStyle.OkCancel, "Informasi") = MsgBoxResult.Ok Then

				Call koneksi()
				cmd = New MySqlCommand("INSERT INTO masyarakat(nik,nama,username,password,telp) VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "')", conn)
				cmd.ExecuteNonQuery()
				MsgBox("Data Berhasil Tersimpan")
				kondisiAwal()

			ElseIf MsgBoxResult.Cancel Then
			End If
		End If
    End Sub

	Private Sub FormRegistrasiMasyarakat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Dim msg As String = "Anda yakin ingin keluar dari aplikasi ini?"
		Dim title As String = "Form closing"
		Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
		If result = DialogResult.Cancel Then
			e.Cancel = True
		Else
			Form1.Show()
		End If
	End Sub
End Class