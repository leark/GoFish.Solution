using System.Collections.Generic;

namespace GoFish.Models
{
  public class Player
  {
    public string Name { get; }
    public List<Card> Hand { get; }
    private int Pairs { get; set; }
    public Player(string name)
    {
      Name = name;
      Hand = new List<Card> { };
      Pairs = 0;
    }

    // returns true if successfully drawn a card
    public Card PlayerDraw(Deck deck)
    {
      Card drawn = deck.Draw();
      if (drawn == null)
      {
        return drawn;
      }
      else
      {
        Hand.Add(drawn);
        return drawn;
      }
    }

    public int HandCount()
    {
      return Hand.Count;
    }

    public bool CheckHand(Card card)
    {
      for (int i = 0; i < Hand.Count; i++)
      {
        if (Hand[i].Equals(card))
        {
          return true;
        }
      }
      return false;
    }

    public Card GetCardOfSameColor(Card card, bool suite)
    {
      for (int i = 0; i < Hand.Count; i++)
      {
        // check if any card in your hand matches with card in value and color
        if (Hand[i].Equals(card))
        {
          if (suite)
          {
            // check if they have different suites
            if (Hand[i].Suite != card.Suite)
            {
              return Hand[i];
            }
            else
            {
              return null;
            }
          }
          else
          {
            return Hand[i];
          }
        }
      }
      return null;
    }

    public Card GiveCard(Card card)
    {
      if (CheckHand(card))
      {
        Hand.Remove(card);
        return card;
      }
      else
      {
        return null;
      }
    }

    public Card TakeCard(string from, Card card)
    {
      if (from == "deck")
      {
        Hand.Add(card);
      }
      else if (from == "hand")
      {
        Pairs++;
        Hand.Remove(card);
        Card targetCard = GetCardOfSameColor(card, true);
        Hand.Remove(targetCard);
        return targetCard;
      }
      return card;
    }

    public int GetNumOfPairs()
    {
      return Pairs;
    }
  }
}
