using System;
using System.Linq;
using System.Collections.Generic;

namespace DeckLib
{
    /// <summary>Class <c>Deck</c> represents a deck of cards. It consists of a list of cards.</summary>
    public class Deck
    {
        private List<Card> cardList;

        /// <summary>Constructor initialize cardList and calls to InitializeDeck.</summary>
        public Deck()
        {
            cardList = new List<Card>();
            InitializeDeck();
        }

        /// <summary>Initialize an ordered deck.</summary>
        public void InitializeDeck()
        {
            // TODO: initialize cardList with all 52 cards
            cardList.Add(new Card(FrenchDeckNumber.CA, FrenchDeckSuit.CLOVERS));
        }

        /// <summary>Shuffle the cards in the deck.</summary>
        public void ShuffleDeck()
        {
            var rand = new Random(DateTime.Now.Millisecond);
            var randomList = cardList.OrderBy(c => rand.Next()).ToList();
            cardList.Clear();
            cardList = randomList;
        }

        /// <summary>Return the last card and remove it.</summary>
        /// <returns>The last <c>Card</c> in the deck.</returns>
        public Card getNextCard()
        {
            int lastIndex = cardList.Count()-1;
            Card nextCard = cardList.ElementAt(lastIndex);
            cardList.RemoveAt(lastIndex);

            return nextCard;
        }
    }
}