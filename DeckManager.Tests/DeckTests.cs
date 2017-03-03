using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Diagnostics;

namespace CardManager.Tests
{
    public class DeckTests
    {
        private Deck deck;

        [SetUp]
        public void SetUp()
        {
            deck = new Deck();
        }

        #region constructor
        /// <summary>
        /// The deck is initialized with the order of D1, D2, D3...,C1, C2, C3...,H1, H2, H3...,S1, S2, S3...
        /// </summary>
        [Test]
        public void Initialize_DeckValuesAreSorted()
        {
            int expectedValue = 0;
            int expectedSuit = 0;
            foreach (var card in deck.Cards)
            {
                Assert.AreEqual(expectedSuit, card.Suit);
                Assert.AreEqual(expectedValue, card.Value);

                if (expectedValue == 12)
                {
                    expectedValue = 0;
                    expectedSuit++;
                }
                else
                    expectedValue++;
            }
        }

        /// <summary>
        /// Deck contains 52 cards.
        /// </summary>
        [Test]
        public void Initialize_DeckContains52Cards()
        {
            Assert.AreEqual(52, deck.Cards.Count);
        }
        #endregion

        [Test]
        public void blah()
        {
            foreach (var card in deck.Cards)
            {
                Debug.WriteLine(card.ToString());
            }

            Debug.WriteLine("Shuffling");
            deck.Shuffle();

            foreach (var card in deck.Cards)
            {
                Debug.WriteLine(card.ToString());
            }

            Debug.WriteLine("Sorting");
            deck.Sort();

            foreach (var card in deck.Cards)
            {
                Debug.WriteLine(card.ToString());
            }
        }



        #region shuffle
        

        #endregion
    }
}
