using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace DeckManager.Tests
{
    public class DeckBuilderTests
    {
        private IDeckBuilder builder;

        [SetUp]
        public void SetUp()
        {
            builder = new DeckBuilder();
        }

        [Test]
        public void Generate52CardDeck_CountIs52()
        {
            var actual = builder.Generate52CardDeck();
            Assert.AreEqual(52, actual.Count());
        }

        [Test]
        public void Generate52CardDeck_CorrectNumberOfSuits()
        {
            var actual = builder.Generate52CardDeck();

            var clubCount = 0;
            var diamondCount = 0;
            var heartCount = 0;
            var spadeCount = 0;

            foreach (var card in actual)
            {
                if (card.Suit == 0) clubCount++;
                if (card.Suit == 1) diamondCount++;
                if (card.Suit == 2) heartCount++;
                if (card.Suit == 3) spadeCount++;
            }

            Assert.AreEqual(13, clubCount);
            Assert.AreEqual(13, diamondCount);
            Assert.AreEqual(13, heartCount);
            Assert.AreEqual(13, spadeCount);
        }

        [Test]
        public void Generate52CardDeck_OnlyValidSuits()
        {
            var expectedValues = new List<int> { 0, 1, 2, 3 };
            var actual = builder.Generate52CardDeck();
            
            foreach (var card in actual)
            {
                Assert.IsTrue(expectedValues.Contains(card.Suit));
            }
        }

        [Test]
        public void Generate52CardDeck_CorrectNumberOfValues()
        {
            var actual = builder.Generate52CardDeck();

            var Count0 = 0;
            var Count1 = 0;
            var Count2 = 0;
            var Count3 = 0;
            var Count4 = 0;
            var Count5 = 0;
            var Count6 = 0;
            var Count7 = 0;
            var Count8 = 0;
            var Count9 = 0;
            var Count10 = 0;
            var Count11 = 0;
            var Count12 = 0;

            foreach (var card in actual)
            {
                if (card.Value == 0) Count0++;
                if (card.Value == 1) Count1++;
                if (card.Value == 2) Count2++;
                if (card.Value == 3) Count3++;
                if (card.Value == 4) Count4++;
                if (card.Value == 5) Count5++;
                if (card.Value == 6) Count6++;
                if (card.Value == 7) Count7++;
                if (card.Value == 8) Count8++;
                if (card.Value == 9) Count9++;
                if (card.Value == 10) Count10++;
                if (card.Value == 11) Count11++;
                if (card.Value == 12) Count12++;
            }

            Assert.AreEqual(4, Count0);
            Assert.AreEqual(4, Count1);
            Assert.AreEqual(4, Count2);
            Assert.AreEqual(4, Count3);
            Assert.AreEqual(4, Count4);
            Assert.AreEqual(4, Count5);
            Assert.AreEqual(4, Count6);
            Assert.AreEqual(4, Count7);
            Assert.AreEqual(4, Count8);
            Assert.AreEqual(4, Count9);
            Assert.AreEqual(4, Count10);
            Assert.AreEqual(4, Count11);
            Assert.AreEqual(4, Count12);
        }

        [Test]
        public void Generate52CardDeck_OnlyValidValues()
        {
            var expectedValues = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var actual = builder.Generate52CardDeck();

            foreach (var card in actual)
            {
                Assert.IsTrue(expectedValues.Contains(card.Value));
            }
        }
    }
}
