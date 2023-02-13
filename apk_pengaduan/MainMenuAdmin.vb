Public Class MainMenuAdmin
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If MsgBox("Anda yakin ingin keluar dari menu ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
			Me.Hide()
			Form1.Show()
		Else

		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		FormRegistrasiAdmin.Show()
		Me.Hide()
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		FormTanggapanAdmin.Show()
		Me.Hide()
		FormTanggapanAdmin.Label4.Text = Label3.Text

	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		FormLaporanAdmin.Show()
		Me.Hide()
	End Sub

	Private Sub MainMenuAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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