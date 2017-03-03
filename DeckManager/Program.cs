using System;

namespace DeckManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set up the deck dependencies
            var builder = new DeckBuilder();
            var generator = new RandomGenerator();

            //Create the deck
            var deck = new Deck(builder, generator);

            //Print out the results of the shuffle and sort methods
            Console.WriteLine("Initializing");
            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card.ToString());
            }

            Console.WriteLine("\nShuffling:");
            deck.Shuffle();

            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card.ToString());
            }

            Console.WriteLine("\nSorting:");
            deck.Sort();

            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
