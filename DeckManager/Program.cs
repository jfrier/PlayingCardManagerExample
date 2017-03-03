using System;

namespace CardManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an ordered deck of cards
            var deck = new Deck();

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
