
Public Class WarGame

    Private deck As Deck
    Private player1Deck As List(Of Card)
    Private player2Deck As List(Of Card)
    Private random As New Random()

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the deck and shuffle
        deck = New Deck()
        deck.Shuffle()

        ' Split the deck into two halves, 26 cards for each player
        player1Deck = deck.GetCards(26) ' First half for Player 1
        player2Deck = deck.GetCards(26) ' Second half for Player 2
    End Sub

    Private Sub btnDrawCards_Click(sender As Object, e As EventArgs) Handles ThrowButton.Click
        ' Draw one card for each player
        Dim player1Card As Card = DrawCardForPlayer(player1Deck)
        Dim player2Card As Card = DrawCardForPlayer(player2Deck)

        ' Display the cards in the respective TextBoxes
        Card1TextBox.Text = player1Card.ToString()
        Card2TextBox.Text = player2Card.ToString()

        ' Compare the card values and display the result
        Dim player1Value As Integer = player1Card.GetCardValue()
        Dim player2Value As Integer = player2Card.GetCardValue()

        If player1Value > player2Value Then
            ResultTextBox.Text = "Player 1 wins!"
        ElseIf player1Value < player2Value Then
            ResultTextBox.Text = "Player 2 wins!"
        Else
            ResultTextBox.Text = "It's a tie!"
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
End Class