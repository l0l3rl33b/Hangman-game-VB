Public Class MainWindow
	Public Shared word As String
	Public Shared ct As Int16
	Public Shared ft As Int16
	Public Shared att As Int16
	Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		word = InputBox("Insert the word to guess!!, The hangman game")
		Call restarWord()
		ctlb.Text = 0
		falb.Text = 0
		attlb.Text = 0
	End Sub

	Private Sub finishbtn_Click(sender As Object, e As EventArgs) Handles finishbtn.Click

		Me.Close()
	End Sub

	Private Sub MainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		starting_screen.Show()
	End Sub

	Private Sub Restartbtn_Click(sender As Object, e As EventArgs) Handles Restartbtn.Click
		MsgBox("The word was: " + word)

		MsgBox("Game Restarted")
		ctlb.Text = 0
		falb.Text = 0
		attlb.Text = 0
		word = InputBox("Insert the word to guess!!, The hangman game")
		Call restarWord()

	End Sub

	Private Sub restarWord()
		'Restart the word to the origin form -- ????? --
		wordtoguesslb.Text = vbNullString
		For i = 0 To word.Length()
			wordtoguesslb.Text = wordtoguesslb.Text + "?"
		Next
	End Sub

	Private Sub trybtn_Click(sender As Object, e As EventArgs) Handles trybtn.Click
		Dim countSimbol As Int16
		countSimbol = 0

		If (word.Contains(lettertxt.Text)) Then
			att += 1
			ct += 1
			For i = 0 To word.Length() - 1
				If (word.Substring(i, 1) = lettertxt.Text) Then
					wordtoguesslb.Text() = wordtoguesslb.Text().Remove(i, 1)
					wordtoguesslb.Text() = wordtoguesslb.Text().Insert(i, lettertxt.Text)
				End If
			Next
			For i = 0 To word.Length() - 1
				If (wordtoguesslb.Text().Substring(i, 1) = "?") Then
					countSimbol += 1
				End If
			Next
			If (countSimbol = 0) Then
				MsgBox("you discovered the word CONGRATULATIONS")
			End If
		Else
			MsgBox("The letter is not found")
			att += 1
			ft += 1
		End If
		lettertxt.Text = vbNullString
		attlb.Text = att
		ctlb.Text() = ct
		falb.Text() = ft
	End Sub
End Class
