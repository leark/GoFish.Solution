using System.Collections.Generic;

namespace GoFish.Models
{
  public class Card
  {
    public string Value { get; }
    public string Suite { get; }
    public string Color { get; }
    public static List<string> _reds = new List<string> { "Hearts", "Diamonds" };
    public static List<string> _blacks = new List<string> { "Spades", "Clubs" };
    public Card(string value, string suite)
    {
      Value = value;
      Suite = suite;
      Color = _reds.Contains(suite) ? "Red" : "Black";
    }

    public bool SameColor(Card card)
    {
      return Color == card.Color;
    }

    public bool Equals(Card card)
    {
      if (Value == card.Value && Color == card.Color)
      {
        return true;
      }
      return false;
    }

    public override string ToString()
    {
      return Value + " of " + Suite;
    }
  }
}