using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GoFish.Models;
using System;

namespace GoFish.Tests
{
  [TestClass]
  public class DeckTests : IDisposable
  {
    public void Dispose()
    {
      // Deck.ClearAll();
    }

    [TestMethod]
    public void Deck_CreatesInstanceOfDeck_Deck()
    {
      Deck deck = new Deck();
      Assert.AreEqual(typeof(Deck), deck.GetType());
    }

    [TestMethod]
    public void Deck_FirstCardOfDeck_Card()
    {
      Deck deck = new Deck();
      // Console.WriteLine(deck.Cards[0].ToString());
      Card aceSpades = deck.Cards[0];
      Card correct = new Card("Ace", "Spades");
      Assert.AreEqual(correct.ToString(), aceSpades.ToString());
    }

    [TestMethod]
    public void Drawn_DrawRandomCard_Card()
    {
      Deck deck = new Deck();
      // Console.WriteLine(deck.Cards[0].ToString());
      Card randomCard = deck.Draw();
      // Console.WriteLine(randomCard);
      Assert.AreEqual("Ace of Spades", randomCard.ToString());
    }

    [TestMethod]
    public void GetDrawn_GetListOfCardsDrawn_CardList()
    {
      Deck deck = new Deck();
      // Console.WriteLine(deck.Cards[0].ToString());
      Card randomCard1 = deck.Draw();
      Card randomCard2 = deck.Draw();
      List<Card> drawn = new List<Card> { randomCard1, randomCard2 };

      // Console.WriteLine(randomCard);
      CollectionAssert.AreEqual(drawn, deck.GetDrawn());
    }
  }
}