using System;

namespace CardManager
{
    public class Card : IComparable<Card>
    {
        public int Suit { get; set; }
        public int Value { get; set; }

        public int CompareTo(Card other)
        {
            //handle null comparison
            if (other == null)
                return 1;

            if (Suit > other.Suit) return 1;
            else if (Suit < other.Suit) return -1;
            else
            {
                if (Value > other.Value) return 1;
                else if (Value < other.Value) return -1;
                else return 0;
            }
        }

        public override string ToString()
        {
            var valueString = "";
            var suitString = " of ";

            //Suit value are alphabetical
            if (Suit == 0) suitString += "Clubs";
            else if (Suit == 1) suitString += "Diamonds";
            else if (Suit == 2) suitString += "Hearts";
            else if (Suit == 3) suitString += "Spades";

            else throw new InvalidCastException("Unrecognized suite.");

            //Handle the named values
            if (Value == 0) valueString = "Ace";
            else if (Value == 10) valueString = "Jack";
            else if (Value == 11) valueString = "Queen";
            else if (Value == 12) valueString = "King";
            //Handle the int values
            else if (Value > 0 && Value < 10) valueString = (Value + 1).ToString();
            else throw new InvalidCastException("Unrecognized value.");
            return valueString + suitString;
        }
    }
}
