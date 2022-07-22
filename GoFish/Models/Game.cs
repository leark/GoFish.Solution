using System.Collections.Generic;

namespace GoFish.Models
{
  public class Game
  {
    public List<Player> Players = new List<Player> { };
    public Deck GameDeck { get; }
    private int TurnNum { get; set; }
    public static int _initialHandSize = 5;
    public Game(int numPlayers)
    {
      Deck gameDeck = new Deck();
      GameDeck = gameDeck;
      for (int i = 1; i <= numPlayers; i++)
      {
        Player player = new Player("Player" + i);
        for (int j = 0; j < _initialHandSize; j++)
        {
          Card card = GameDeck.Draw();
          player.TakeCard("deck", card);
          if (player.GetCardOfSameColor(card, true) != null)
          {
            player.TakeCard("hand", card);
          }
        }
        Players.Add(player);
      }
      TurnNum = 1;
    }

    public Player currentTurnPlayer()
    {
      //turn player# totalPlayers  turn % count
      // 1    1          3            1
      // 2    2          3            2
      // 3    3          3            0
      // 4    1          3            1
      // 5    2          3            2
      int x = TurnNum % Players.Count;
      if (x == 0)
      {
        return Players[Players.Count - 1];
      }
      else
      {
        return Players[x - 1];
      }
    }

    public bool AskOtherPlayer(Player player, Player otherPlayer, Card card)
    {
      if (player.HandCount() > 0 || otherPlayer.HandCount() > 0)
      {
        if (player.CheckHand(card))
        {
          if (otherPlayer.CheckHand(card))
          {
            player.TakeCard("hand", otherPlayer.GiveCard(otherPlayer.GetCardOfSameColor(card, false)));
            return true;
          }
          else
          {
            TurnNum++;
            return false;
          }
        }
        else
        {
          TurnNum++;
          return false;
        }
      }
      else
      {
        TurnNum++;
        return false;
      }
    }

    public int ShowCurrTurnNum()
    {
      return TurnNum;
    }

    public bool End()
    {
      if (GetWinner() != null)
      {
        return true;
      }
      else if (GameDeck.DeckCount() == 0)
      {
        return true;
      }
      return false;
    }

    public Player GetWinner()
    {
      foreach (Player player in Players)
      {
        if (player.HandCount() == 0 || player.GetNumOfPairs() == 13)
        {
          return player;
        }
      }
      return null;
    }
  }
}
