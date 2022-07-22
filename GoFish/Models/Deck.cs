using System.Collections.Generic;
using System;

namespace GoFish.Models
{
  public class Deck
  {
    private List<Card> Cards;
    private List<Card> Drawn;
    private static string[] _suites = new string[4] { "Spades", "Hearts", "Diamonds", "Clubs" };
    private static string[] _values = new string[13] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

    public Deck()
    {
      List<Card> cards = new List<Card> { };

      for (int i = 0; i < _suites.Length; i++)
      {
        for (int j = 0; j < _values.Length; j++)
        {
          // Console.WriteLine("Position " + k + " is " + _suites[i] + " " + _values[j]);
          cards.Add(new Card(_values[j], _suites[i]));

        }
      }
      Cards = cards;
      Drawn = new List<Card> { };
    }

    // draw random card
    public Card Draw()
    {
      if (Cards.Count != 0)
      {
        Random rnd = new Random();
        int stat = rnd.Next(0, Cards.Count - 1);
        Card drawn = Cards[stat];
        Drawn.Add(drawn);
        Cards.Remove(drawn);
        return drawn;
      }
      else
      {
        return null;
      }
    }

    public List<Card> GetDrawn()
    {
      return Drawn;
    }

    public void ReShuffle()
    {
      Cards = Drawn;
      Drawn = new List<Card> { };
    }

    public int DeckCount()
    {
      return Cards.Count;
    }
  }
}
