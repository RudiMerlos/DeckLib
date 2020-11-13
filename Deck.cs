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
            /*FrenchDeckNumber myNumber = new FrenchDeckNumber();
            FrenchDeckSuit mySuit = new FrenchDeckSuit();*/

            for (int SuitCount = 0; SuitCount < 4; SuitCount++/*FrenchDeckSuit*/)
            {
                for (int NumberCount = 0; NumberCount < 13; NumberCount++/*FrenchDeckNumber*/)
                {
                    cardList.Add(new Card((FrenchDeckNumber)NumberCount, (FrenchDeckSuit)SuitCount));
                }

                /*foreach (Card cards in cardList)
                {
                    Console.WriteLine(cards);
                }*/
            }
            
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
            return null;
        }
    }
}