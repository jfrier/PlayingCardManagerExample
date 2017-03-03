﻿using NUnit.Framework;
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
