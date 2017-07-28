using System;

public class Card: IComparable<Card>
{
    public Rank Rank { get; set; }

    public Suit Suit { get; set; }

    public Card(string rank, string suit)
    {
        this.Rank = (Rank)Enum.Parse(typeof(Rank),rank);
        this.Suit = (Suit)Enum.Parse(typeof(Suit),suit);
    }

    public int GetCardPower()
    {
        return (int) this.Rank + (int) this.Suit;
    }

    public int CompareTo(Card other)
    {
        return this.GetCardPower() - other.GetCardPower();
    }

    public override string ToString()
    {
        return $"{this.Rank} of {this.Suit}";
    }
}

