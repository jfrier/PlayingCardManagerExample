using System;
using System.Collections.Generic;

namespace CardManager
{
    public class Deck
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        public Deck()
        {
            //Initialize the deck with 52 cards
            for (var suit = 0; suit < 4; suit ++ )
            {
                for (var value = 0; value < 13; value ++)
                {
                    var card = new Card(suit, value);
                    Cards.Add(card);
                }
            }
        }

        public void Shuffle()
        {
            var rnd = new Random();
     
            for (var i =0; i < Cards.Count; i++)
            {
                int index = rnd.Next(0, 52);

                var currentValue = Cards[i];
                Cards[i] = Cards[index];
                Cards[index] = currentValue;
            }
        }

        public void Sort()
        {
            //Just use .net's quicksort
            Cards.Sort();
        }
    }
}
