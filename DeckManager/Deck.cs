using System.Collections.Generic;
using System.Linq;

namespace DeckManager
{
    public class Deck
    {
        public List<Card> Cards { get; private set; } = new List<Card>();

        private IDeckBuilder Builder { get; set; }
        private IRandomWrapper Generator { get; set; }

        public Deck(IDeckBuilder builder, IRandomWrapper generator)
        {
            this.Builder = builder;
            this.Generator = generator;

            Cards = Builder.Generate52CardDeck().ToList();
        }

        public void Shuffle()
        {
            for (var i =0; i < Cards.Count; i++)
            {
                int index = Generator.Next(0, Cards.Count);

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
