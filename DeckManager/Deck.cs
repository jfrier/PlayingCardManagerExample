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
                    var card = new Card();
                    card.Suit = suit;
                    card.Value = value;
                    Cards.Add(card);
                }
            }
        }

        public void Shuffle()
        {
            var rnd = new Random();
            Card[] cards = new Card[52];

            //The easiest (probably least efficient way) first
            foreach (var card in Cards)
            {
                int index = rnd.Next(0, 52);

                //deal with collisions
                while (cards[index] != null)
                {
                    index = rnd.Next(0, 52);
                }

                cards[index] = card;
            }

            Cards.Clear();
            Cards.AddRange(cards);
        }

        public void Sort()
        {
            //Just use .net's quicksort
            Cards.Sort();
        }
    }
}
