Public Class Deck

    Private Cards As New List(Of Card)()
    Private RandomGenerator As New Random()

    Public Sub New()
        Dim suits As String() = {"Hearts", "Diamonds", "Clubs", "Spades"}
        Dim ranks As String() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"}

        ' Initialize deck with 52 cards
        For Each suit As String In suits
            For Each rank As String In ranks
                Cards.Add(New Card(rank, suit))
            Next
        Next
    End Sub

    ' Shuffle the deck using Fisher-Yates algorithm
    Public Sub Shuffle()
        For i As Integer = Cards.Count - 1 To 1 Step -1
            Dim j As Integer = RandomGenerator.Next(i + 1)
            Dim temp As Card = Cards(i)
            Cards(i) = Cards(j)
            Cards(j) = temp
        Next
    End Sub

    ' Draw a random card
    Public Function GetCards(count As Integer) As List(Of Card)
        Dim cardSet As List(Of Card) = Cards.Take(count).ToList()
        Cards.RemoveRange(0, count) ' Remove the selected cards from the deck
        Return cardSet
    End Function

End Class
