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
        private void InitializeDeck()
        {
            for (int SuitCount = 0; SuitCount < 4; SuitCount++)
            {
                for (int NumberCount = 1; NumberCount <= 13; NumberCount++)
                {
                    cardList.Add(new Card((FrenchDeckNumber)NumberCount, (FrenchDeckSuit)SuitCount));
                }
            }
        }

        /// <summary>Shuffle the cards in the deck.</summary>
        public void ShuffleDeck()
        {
            var rand = new Random(DateTime.Now.Millisecond);
            var randomList = cardList.OrderBy(c => rand.Next()).ToList();
            cardList.Clear();
            cardList = randomList;
        }

        /// <summary>Returns the last card and remove it.</summary>
        /// <returns>The last <c>Card</c> in the deck or null if card list is empty.</returns>
        public Card GetNextCard()
        {
            Card nextCard = null;

            if (GetSize() > 0)
            {
                int lastIndex = cardList.Count() - 1;
                nextCard = cardList.ElementAt(lastIndex);
                cardList.RemoveAt(lastIndex);
            }

            return nextCard;
        }

        /// <summary>Returns card list size.</summary>
        /// <returns>An integer which contains the card list size.</returns>
        public int GetSize()
        {
            return cardList.Count();
        }
    }
}