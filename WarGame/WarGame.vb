
Public Class WarGame

    Private deck As Deck
    Private player1Deck As List(Of Card)
    Private player2Deck As List(Of Card)
    Private random As New Random()
    Private roundCounter As Integer = 0 ' Initialize the round counter
    Private player1Wins As Integer = 0 ' Count Player 1's wins
    Private player2Wins As Integer = 0 ' Count Player 2's wins
    Private player1GameWins As Integer = 0 ' Count Player 1's game wins
    Private player2GameWins As Integer = 0 ' Count Player 2's game wins
    Private isGameInProgress As Boolean = False ' Track if a game is in progress

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the deck and shuffle
        InitializeGame()
    End Sub

    Private Sub ThrowButton_Click(sender As Object, e As EventArgs) Handles ThrowButton.Click
        ' Check if a game is in progress
        If Not isGameInProgress Then
            MessageBox.Show("Please start a new game before drawing cards.")
            Return
        End If

        ' Draw one card for each player
        Dim player1Card As Card = DrawCardForPlayer(player1Deck)
        Dim player2Card As Card = DrawCardForPlayer(player2Deck)

        ' If both decks have cards, proceed to the next round
        If player1Card IsNot Nothing And player2Card IsNot Nothing Then
            ' Display the cards in the respective TextBoxes
            Card1TextBox.Text = player1Card.ToString()
            Card2TextBox.Text = player2Card.ToString()

            ' Compare the card values and display the result
            Dim player1Value As Integer = player1Card.GetCardValue()
            Dim player2Value As Integer = player2Card.GetCardValue()

            If player1Value > player2Value Then
                ResultTextBox.Text = "Player 1 wins!"
                player1Wins += 1 ' Increment Player 1's win counter
                Player1WinsTextBox.Text = "Player 1 Wins: " & player1Wins.ToString() ' Update Player 1's win count
            ElseIf player1Value < player2Value Then
                ResultTextBox.Text = "Player 2 wins!"
                player2Wins += 1 ' Increment Player 2's win counter
                Player2WinsTextBox.Text = "Player 2 Wins: " & player2Wins.ToString() ' Update Player 2's win count
            Else
                ResultTextBox.Text = "It's a tie!"
            End If

            ' Increment the round counter and display it
            roundCounter += 1
            RoundsTextBox.Text = "Rounds: " & roundCounter.ToString()

        Else
            ' If one or both players have no more cards, determine the game winner
            DetermineGameWinner()

            ' End the game and show game over message
            ResultTextBox.Text = "No more cards to draw. Game over!"
            isGameInProgress = False ' Mark the game as not in progress
        End If
    End Sub

    ' Helper function to draw a card from a player's deck
    Private Function DrawCardForPlayer(playerDeck As List(Of Card)) As Card
            If playerDeck.Count > 0 Then
                Dim cardIndex As Integer = random.Next(playerDeck.Count)
                Dim card As Card = playerDeck(cardIndex)
                playerDeck.RemoveAt(cardIndex) ' Remove the drawn card from the player's deck
                Return card
            Else
                Return Nothing ' Return nothing if the deck is empty
            End If
        End Function

    ' Reset game when reset button is clicked
    Private Sub NewGameButton_Click(sender As Object, e As EventArgs) Handles NewGameButton.Click
        If isGameInProgress Then
            MessageBox.Show("Please finish the current game before starting a new one.")
            Return
        End If
        InitializeGame() ' Call the method to initialize a new game
    End Sub

    ' Method to reset the game state but keep track of game wins and total games played
    Private Sub InitializeGame()
            ' Initialize a new deck and shuffle it
            deck = New Deck()
            deck.Shuffle()

            ' Split the deck into two halves, 26 cards for each player
            player1Deck = deck.GetCards(26) ' First half for Player 1
            player2Deck = deck.GetCards(26) ' Second half for Player 2

            ' Reset the round counter and win counters for the new game
            roundCounter = 0
            player1Wins = 0
            player2Wins = 0

        ' Update the display
        RoundsTextBox.Text = "Rounds: 0"
        Player1WinsTextBox.Text = "Player 1 Wins: 0"
        Player2WinsTextBox.Text = "Player 2 Wins: 0"

        ' Clear the textboxes for player cards and result
        Card1TextBox.Clear()
        Card2TextBox.Clear()
        ResultTextBox.Clear()

        ' Set the game in progress flag to true
        isGameInProgress = True
        End Sub

        ' Determine which player won the game based on the number of rounds won
        Private Sub DetermineGameWinner()
            If player1Wins > player2Wins Then
                player1GameWins += 1 ' Player 1 wins the game
            Player1WinsTextBox.Text = "Player 1 Game Wins: " & player1GameWins.ToString()
            ResultTextBox.Text = "Player 1 wins the game!"
        ElseIf player1Wins < player2Wins Then
                player2GameWins += 1 ' Player 2 wins the game
            Player2WinsTextBox.Text = "Player 2 Game Wins: " & player2GameWins.ToString()
            ResultTextBox.Text = "Player 2 wins the game!"
        Else
            ResultTextBox.Text = "The game is a tie!"
        End If
        End Sub
End Class