using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an ordered deck of cards
            var deck = new Deck();

            //foreach (var card in deck.Cards)
            //{
            //    Console.WriteLine(card.ToString());
            //}

            Console.WriteLine("Shuffling");
            deck.Shuffle();

            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card.ToString());
            }

            Console.WriteLine("Sorting");
            deck.Sort();

            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card.ToString());
            }
            
        }
    }
}
