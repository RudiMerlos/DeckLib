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

        /// <summary>Constructor initialize an ordered deck and set deckPointer to 0.</summary>
        public Deck()
        {
            cardList = new List<Card>();
            initializeDeck();
        }

        public void initializeDeck()
        {
            // TODO: initialize cardList with all 52 cards
            cardList.Add(new Card(FrenchDeckNumber.CA, FrenchDeckSuit.CLOVERS));
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

            // TODO: get next card
            int lastIndex = cardList.Count()-1;
            Card nextCard = cardList.ElementAt(lastIndex);
            cardList.RemoveAt(lastIndex);

            return nextCard;
        }
    }
}