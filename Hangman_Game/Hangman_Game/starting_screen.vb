Public Class starting_screen
	Private Sub Leavebtn_Click(sender As Object, e As EventArgs) Handles Leavebtn.Click
		Me.Close()
		MsgBox("come back soon ;)")
	End Sub

	Private Sub startbtn_Click(sender As Object, e As EventArgs) Handles startbtn.Click
		MsgBox("Let the hangman game begins...........")
		Me.Hide()
		MainWindow.Show()


	End Sub


End Class