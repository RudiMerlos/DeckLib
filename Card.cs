using System;

namespace DeckLib
{
    /// <summary>Enumeration <c>FrenchDeckNumber</c> to manage the 13 numbers of a french deck.</summary>
    public enum FrenchDeckNumber
    {
        CA = 1,
        C2,
        C3,
        C4,
        C5,
        C6,
        C7,
        C8,
        C9,
        C10,
        CJ,
        CQ,
        CK
    }

    /// <summary>Enumeration <c>FrenchDeckSuit</c> to manage the 4 suits of a french deck.</summary>
    public enum FrenchDeckSuit
    {
        SPADES,
        HEARTS,
        CLUBS,
        DIAMONDS
    }

    /// <summary>Class <c>Card</c> represents a card of deck. It consists of a number and a suit.</summary>
    public class Card : IComparable<Card>
    {
        /// <summary>Constructor initialize the new Card to (<paramref name="number"/>, <paramref name="suit"/>).</summary>
        /// <param name="number">the new Card's number.</param>
        /// <param name="suit">the new Card's suit.</param>
        public Card(FrenchDeckNumber number, FrenchDeckSuit suit)
        {
            Number = number;
            Suit = suit;
        }

        /// <value>Property <c>Number</c> represents the card's number.</value>
        public FrenchDeckNumber Number { get; private set; }

        /// <value>Property <c>Suit</c> represents the card's suit.</value>
        public FrenchDeckSuit Suit { get; private set; }

        /// <summary>Report a card as a string.</summary>
        /// <returns>A string representing a card in the form [number,suit].</returns>
        public override string ToString()
        {
            return NumberToString() + " of " + Suit;
        }

        /// <summary>Generates a string array to draw in console the current card.</summary>
        /// <returns>A string array representing the drawing of a deck card line by line.</returns>
        public string[] ToArray()
        {
            string[] draw = new string[9];
            string number = NumberToString();
            string spaceAdd = number.Length > 1 ? "" : " ";
            draw[0] = "┌───────────┐";
            draw[1] = "│" + number + spaceAdd + "         │";
            draw[2] = "│           │";
            draw[3] = "│           │";
            draw[4] = "│     " + SuitToChar() + "     │";
            draw[5] = "│           │";
            draw[6] = "│           │";
            draw[7] = "│         " + spaceAdd + number + "│";
            draw[8] = "└───────────┘";

            return draw;
        }

        /// <summary>Convert card number to string.</summary>
        /// <returns>A string which contains the number or letter of card.</returns>
        private string NumberToString()
        {
            string result;

            switch (Number)
            {
                case FrenchDeckNumber.CA:
                    result = "A";
                    break;
                case FrenchDeckNumber.CJ:
                    result = "J";
                    break;
                case FrenchDeckNumber.CQ:
                    result = "Q";
                    break;
                case FrenchDeckNumber.CK:
                    result = "K";
                    break;
                default:
                    result = ((int) Number).ToString();
                    break;
            }

            return result;
        }

        /// <summary>Convert Suit enum to char.</summary>
        /// <returns>A suit char.</returns>
        private char SuitToChar()
        {
            char suitChr = ' ';
            switch (Suit)
            {
                case FrenchDeckSuit.SPADES:
                    suitChr = '♠';
                    break;
                case FrenchDeckSuit.HEARTS:
                    suitChr = '♥';
                    break;
                case FrenchDeckSuit.CLUBS:
                    suitChr = '♣';
                    break;
                case FrenchDeckSuit.DIAMONDS:
                    suitChr = '♦';
                    break;
            }

            return suitChr;
        }
        // <summary> Define the rule to compare cards <summary>
        public int CompareTo(Card other)
        {
            if (this.Suit == other.Suit)
            {
                return this.Number.CompareTo(other.Number);
            }
            return this.Suit.CompareTo(other.Suit);
        }
    }
}
