using System;
using System.Linq;
using System.Collections.Generic;

namespace DeckLib
{
    /// <summary>Class <c>Deck</c> represents a deck of cards. It consists of a list of cards and a pointer to current
    ///  card.</summary>
    public class Deck
    {
        private List<Card> cardList;
        private int deckPointer;

        /// <summary>Constructor initialize an ordered deck and set deckPointer to 0.</summary>
        public Deck()
        {
            deckPointer = 0;
            // TODO: initialize cardList with all 52 cards
            cardList.Add(new Card(FrenchDeckNumber.CA, FrenchDeckSuit.CLOVERS));
        }

        /// <summary>Reset deck by setting card's state to false and deckPointer to 0.</summary>
        public void ResetDeck()
        {
            deckPointer = 0;
            cardList.ForEach(c => c.DealState = false);
        }

        /// <summary>Shuffle the cards in the deck.</summary>
        public void ShuffleDeck()
        {
            var rand = new Random();
            var randomList = cardList.OrderBy(c => rand.Next()).ToList();
            cardList.Clear();
            cardList = randomList;
        }

        /// <summary>Return the card pointed to by deckPointer and increments by one deckPointer.</summary>
        /// <returns>The current <c>Card</c> which is pointed by deckPointer.</returns>
        public Card getNextCard()
        {
            cardList[deckPointer].DealState = true;
            return cardList[deckPointer++];
        }
    }
}