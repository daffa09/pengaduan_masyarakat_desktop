Public Class MainMenuMasyarakat

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If MsgBox("Anda yakin ingin keluar dari menu ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
			Me.Hide()
			Form1.Show()
		Else

		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		FormPengaduanMasyarakat.Show()
		FormPengaduanMasyarakat.Label1.Text = Label3.Text
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		FormTanggapanPengaduanMasyarakat.Show()
		FormTanggapanPengaduanMasyarakat.Label4.Text = Label3.Text
	End Sub

	Private Sub MainMenuMasyarakat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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