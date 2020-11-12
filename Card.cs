﻿namespace DeckLib
{
    /// <summary>Enumeration <c>FrenchDeckNumber</c> to manage the 13 numbers of a french deck.</summary>
    public enum FrenchDeckNumber
    {
        CA, C2, C3, C4, C5, C6, C7, C8, C9, C10, CJ, CQ, CK
    }

    /// <summary>Enumeration <c>FrenchDeckSuit</c> to manage the 4 suits of a french deck.</summary>
    public enum FrenchDeckSuit
    {
        SPADES, HEARTS, CLOVERS, DIAMONDS
    }

    /// <summary>Class <c>Card</c> represents a card of deck. It consists of a number and a suit.</summary>
    public class Card
    {
        private FrenchDeckNumber number;
        private FrenchDeckSuit suit;
        private bool dealState;

        /// <summary>Constructor initialize the new Card to (<paramref name="number"/>, <paramref name="suit"/>).</summary>
        /// <param name="number">the new Card's number.</param>
        /// <param name="suit">the new Card's suit.</param>
        public Card(FrenchDeckNumber number, FrenchDeckSuit suit)
        {
            this.number = number;
            this.suit = suit;
            this.dealState = false;
        }

        /// <value>Property <c>Number</c> represents the card's number.</value>
        public FrenchDeckNumber Number { get; set; }

        /// <value>Property <c>Suit</c> represents the card's suit.</value>
        public FrenchDeckSuit Suit { get; set; }

        /// <value>Property <c>DealState</c> represents the card's state, in or out of the deck.</value>
        public bool DealState { get; set; }

        /// <summary>Report a card as a string.</summary>
        /// <returns>A string representing a card in the form [number,suit].</returns>
        public override string ToString() {
            // TODO: return number and suit as a string (i.e. [2,♥])
            return null;
        }

        /// <summary>Generates a string array to draw in console the current card.</summary>
        /// <returns>A string array representing the drawing of a deck card line by line.</returns>
        public string[] ToArray() {
            // TODO: return an array with lines of entire card
            return null;
        }
    }
}