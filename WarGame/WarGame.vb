﻿'Rahiel Rodriguez
'RCET 3371
'Fall 2024
'War Game
'https://github.com/rahielrodriguez/WarGame.git
Public Class WarGame
    Private deck As Deck
    Private player1Deck As New List(Of Card)()
    Private player2Deck As New List(Of Card)()
    Private random As New Random()
    Private roundCounter As Integer = 0
    Private player1Wins As Integer = 0
    Private player2Wins As Integer = 0
    Private isTie As Boolean = False
    Private isGameInProgress As Boolean = False ' Track if a game is in progress

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeGame()
    End Sub

    Private Sub ThrowButton_Click(sender As Object, e As EventArgs) Handles DrawButton.Click, DrawCardToolStripButton.Click
        If player1Deck.Count = 0 Or player2Deck.Count = 0 Then
            CheckGameOver()
            Return
        End If

        ' Draw one card for each player
        Dim player1Card As Card = DrawCardForPlayer(player1Deck)
        Dim player2Card As Card = DrawCardForPlayer(player2Deck)

        'Stretches the picture boxes images to math their bounds
        Player1PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        Player2PictureBox.SizeMode = PictureBoxSizeMode.StretchImage

        ' Display the card images in the PictureBoxes
        Player1PictureBox.Image = GetCardImage(player1Card)
        Player2PictureBox.Image = GetCardImage(player2Card)

        ' Get the values of both cards
        Dim player1Value As Integer = player1Card.GetCardValue()
        Dim player2Value As Integer = player2Card.GetCardValue()

        ' Check for a tie
        If player1Value = player2Value Then
            ResultTextBox.Text = "It's a tie! Press the Tie button to resolve."
            SolveTieButton.Enabled = True ' Enable the tie resolution button
            DrawButton.Enabled = False ' Disable the throw button during the tie
            isTie = True ' Set the tie flag to true
        Else
            ' Normal game mechanics: determine the winner
            If player1Value > player2Value Then
                ResultTextBox.Text = "Player 1 wins!"
                player1Wins += 1
            ElseIf player1Value < player2Value Then
                ResultTextBox.Text = "Player 2 wins!"
                player2Wins += 1
            End If

            UpdateScores()
            roundCounter += 1
            RoundsTextBox.Text = "Rounds: " & roundCounter.ToString()
        End If

        ' Check if the game is over after each round
        CheckGameOver()
    End Sub

    ' Handle the Tie button click
    Private Sub SolveTieButton_Click(sender As Object, e As EventArgs) Handles SolveTieButton.Click, SolveTieToolStripButton.Click
        ' Continue resolving ties until a winner is found
        Dim winnerFound As Boolean = False

        While Not winnerFound
            ' Check if there are enough cards left to solve the tie
            If player1Deck.Count < 2 Or player2Deck.Count < 2 Then
                CheckGameOver()
                Return
            End If

            ' Skip the next card for both players (cards face down)
            Dim player1SkipCard As Card = DrawCardForPlayer(player1Deck)
            Dim player2SkipCard As Card = DrawCardForPlayer(player2Deck)

            ' Draw new cards to compare
            Dim player1NewCard As Card = DrawCardForPlayer(player1Deck)
            Dim player2NewCard As Card = DrawCardForPlayer(player2Deck)

            ' Display the new cards in the PictureBoxes
            Player1PictureBox.Image = GetCardImage(player1NewCard)
            Player2PictureBox.Image = GetCardImage(player2NewCard)

            ' Compare the new cards
            Dim player1NewValue As Integer = player1NewCard.GetCardValue()
            Dim player2NewValue As Integer = player2NewCard.GetCardValue()

            ' Determine the winner of the tie round
            If player1NewValue > player2NewValue Then
                ResultTextBox.Text = "Player 1 wins the tie round!"
                player1Wins += 1
                winnerFound = True ' Break out of the loop since a winner is found
            ElseIf player1NewValue < player2NewValue Then
                ResultTextBox.Text = "Player 2 wins the tie round!"
                player2Wins += 1
                winnerFound = True ' Break out of the loop since a winner is found
            Else
                ResultTextBox.Text = "It's another tie, resolving again..."
                ' Continue drawing cards to resolve tie
            End If
        End While

        ' Disable the tie button and re-enable the throw button after tie resolution
        SolveTieButton.Enabled = False
        DrawButton.Enabled = True ' Re-enable the throw button
        isTie = False

        ' Update the scores and round count
        UpdateScores()
        roundCounter += 1
        RoundsTextBox.Text = "Rounds: " & roundCounter.ToString()

        ' Check if the game is over after tie resolution
        CheckGameOver()
    End Sub

    ' Helper function to draw a card for each player
    Private Function DrawCardForPlayer(playerDeck As List(Of Card)) As Card
        If playerDeck.Count > 0 Then
            Dim cardIndex As Integer = random.Next(playerDeck.Count)
            Dim card As Card = playerDeck(cardIndex)
            playerDeck.RemoveAt(cardIndex) ' Remove the drawn card from the player's deck
            Return card
        Else
            Return Nothing ' No cards left in the deck
        End If
    End Function

    ' Reset game
    Private Sub NewGameButton_Click(sender As Object, e As EventArgs) Handles NewGameButton.Click, NewGameToolStripButton.Click
        If isGameInProgress Then
            MessageBox.Show("Please finish the current game before starting a new one.")
            Return
        End If
        InitializeGame()
    End Sub

    ' Initialize game
    Private Sub InitializeGame()
        deck = New Deck()
        deck.Shuffle()

        player1Deck = deck.GetCards(26)
        player2Deck = deck.GetCards(26)

        player1Wins = 0
        player2Wins = 0
        roundCounter = 0
        isTie = False ' Reset the tie flag

        SolveTieButton.Enabled = False ' Disable the tie button at the start
        DrawButton.Enabled = True ' Ensure the throw button is enabled at game start
        NewGameButton.Enabled = False ' Disable the New Game button after a new game starts
        isGameInProgress = True ' Set the flag indicating that a game is in progress

        UpdateScores()
        ResultTextBox.Text = ""
    End Sub

    ' End the game and enable the New Game button
    Private Sub EndGame()
        isGameInProgress = False
        DrawButton.Enabled = False ' Disable the throw button
        SolveTieButton.Enabled = False ' Disable the solve tie button
        NewGameButton.Enabled = True ' Enable the New Game button when the game is over
    End Sub

    ' Check if the game is over (when both decks are empty)
    Private Sub CheckGameOver()
        If player1Deck.Count = 0 And player2Deck.Count = 0 Then
            EndGame()

            ' Determine the winner based on player wins
            If player1Wins > player2Wins Then
                MessageBox.Show("Player 1 wins the game!")
            ElseIf player1Wins < player2Wins Then
                MessageBox.Show("Player 2 wins the game!")
            Else
                MessageBox.Show("It's a tie game!")
            End If
        End If
    End Sub

    ' Update player scores
    Private Sub UpdateScores()
        Player1WinsTextBox.Text = "Player 1 Wins: " & player1Wins.ToString()
        Player2WinsTextBox.Text = "Player 2 Wins: " & player2Wins.ToString()
    End Sub

    ' Function to retrieve the image resource for a given card
    Private Function GetCardImage(card As Card) As Image
        Dim cardFileName As String = card.GetCardFileName() ' Assume GetCardFileName returns the filename like "ace_of_spades"
        Return My.Resources.ResourceManager.GetObject(cardFileName)
    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripButton.Click
        Me.Close()
    End Sub
End Class
