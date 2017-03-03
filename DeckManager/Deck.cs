using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckManager
{
    public class Deck
    {
        private IDeckBuilder Builder { get; set; }
        public List<Card> Cards { get; private set; } = new List<Card>();

        public Deck(IDeckBuilder builder)
        {
            this.Builder = builder;
            Cards = Builder.Generate52CardDeck().ToList();
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
