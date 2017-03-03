using NUnit.Framework;
using System.Collections.Generic;
using Moq;

namespace DeckManager.Tests
{
    public class DeckTests
    {
        private Deck deck;
        private Mock<IDeckBuilder> builder;

        [SetUp]
        public void SetUp()
        {
            builder = new Mock<IDeckBuilder>();
            deck = new Deck(builder.Object);
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

        #endregion

        #region sort

        [Test]
        public void Sort_SuitsOrderedCorrectly()
        {
            var card0 = new Card(1, 0);
            var card1 = new Card(0, 0);
            var card2 = new Card(2, 0);

            var unorderedDeck = new List<Card>() { card0, card1, card2 };
            builder.Setup(x => x.Generate52CardDeck()).Returns(unorderedDeck);

            deck = new Deck(builder.Object);
            deck.Sort();

            Assert.AreEqual(card1, deck.Cards[0]);
            Assert.AreEqual(card0, deck.Cards[1]);
            Assert.AreEqual(card2, deck.Cards[2]);
        }

        [Test]
        public void Sort_ValuesOrderedCorrectly()
        {
            var card0 = new Card(0, 1);
            var card1 = new Card(0, 0);
            var card2 = new Card(0, 2);

            var unorderedDeck = new List<Card>() { card0, card1, card2 };
            builder.Setup(x => x.Generate52CardDeck()).Returns(unorderedDeck);

            deck = new Deck(builder.Object);
            deck.Sort();

            Assert.AreEqual(card1, deck.Cards[0]);
            Assert.AreEqual(card0, deck.Cards[1]);
            Assert.AreEqual(card2, deck.Cards[2]);
        }

        [Test]
        public void Sort_SuitsAndValuesOrderedCorrectly()
        {
            var card0 = new Card(1, 1);
            var card1 = new Card(2, 0);
            var card2 = new Card(1, 0);

            var unorderedDeck = new List<Card>() { card0, card1, card2 };
            builder.Setup(x => x.Generate52CardDeck()).Returns(unorderedDeck);

            deck = new Deck(builder.Object);
            deck.Sort();

            Assert.AreEqual(card2, deck.Cards[0]);
            Assert.AreEqual(card0, deck.Cards[1]);
            Assert.AreEqual(card1, deck.Cards[2]);
        }

        #endregion


        #region shuffle


        #endregion
    }
}
