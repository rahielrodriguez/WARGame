Public Class Card
    Public Property Suit As String
    Public Property Rank As String

    Public Sub New(rank As String, suit As String)
        Me.Rank = rank
        Me.Suit = suit
    End Sub
    ' Convert rank to a numeric value for comparison
    Public Function GetCardValue() As Integer
        Select Case Rank
            Case "A"
                Return 1
            Case "2"
                Return 2
            Case "3"
                Return 3
            Case "4"
                Return 4
            Case "5"
                Return 5
            Case "6"
                Return 6
            Case "7"
                Return 7
            Case "8"
                Return 8
            Case "9"
                Return 9
            Case "10"
                Return 10
            Case "J"
                Return 11
            Case "Q"
                Return 12
            Case "K"
                Return 13
            Case Else
                Return 0
        End Select
    End Function
    ' Override ToString to display the card
    Public Overrides Function ToString() As String
        Return $"{Rank} of {Suit}"
    End Function
    Public Function GetCardFileName() As String
        ' Return a PascalCase filename if your resources use that convention
        Return Char.ToUpper(Rank(0)) & Rank.Substring(1).ToLower() & "_of_" & Char.ToUpper(Suit(0)) & Suit.Substring(1).ToLower()
    End Function
End Class
