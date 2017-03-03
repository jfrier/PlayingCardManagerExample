using System;
using NUnit.Framework;

namespace CardManager.Tests
{
    public class CardTests
    {
        #region ToString
        [Test]
        public void ToString_ClubSuitIsTranslatedCorrectly()
        {
            var card = new Card(0, 0);
            var actual = card.ToString();
            Assert.IsTrue(actual.EndsWith("of Clubs"));
        }

        [Test]
        public void ToString_DiamondSuitIsTranslatedCorrectly()
        {
            var card = new Card(1, 0);
            var actual = card.ToString();
            Assert.IsTrue(actual.EndsWith("of Diamonds"));
        }

        [Test]
        public void ToString_HeartSuitIsTranslatedCorrectly()
        {
            var card = new Card(2, 0);
            var actual = card.ToString();
            Assert.IsTrue(actual.EndsWith("of Hearts"));
        }

        [Test]
        public void ToString_SpadeSuitIsTranslatedCorrectly()
        {
            var card = new Card(3, 0);
            var actual = card.ToString();
            Assert.IsTrue(actual.EndsWith("of Spades"));
        }

        [Test]
        public void ToString_AceValueIsTranslatedCorrectly()
        {
            var card = new Card(0, 0);
            var actual = card.ToString();
            Assert.IsTrue(actual.StartsWith("Ace"));
        }

        [Test]
        public void ToString_JackValueIsTranslatedCorrectly()
        {
            var card = new Card(0, 10);
            var actual = card.ToString();
            Assert.IsTrue(actual.StartsWith("Jack"));
        }

        [Test]
        public void ToString_QueenValueIsTranslatedCorrectly()
        {
            var card = new Card(0, 11);
            var actual = card.ToString();
            Assert.IsTrue(actual.StartsWith("Queen"));
        }

        [Test]
        public void ToString_KingValueIsTranslatedCorrectly()
        {
            var card = new Card(0, 12);
            var actual = card.ToString();
            Assert.IsTrue(actual.StartsWith("King"));
        }

        [Test]
        public void ToString_2Through10AreTranslatedCorrectly()
        {
            for (int i = 1; i < 10; i++)
            {
                var card = new Card(0, i);
                var actual = card.ToString();
                Assert.IsTrue(actual.StartsWith((i + 1).ToString()));
            }
        }

        [Test]
        public void ToString_SuitAndValueAreConcatenatedCorrectly()
        {
            var card = new Card(0, 0);
            var actual = card.ToString();
            Assert.AreEqual("Ace of Clubs", actual);
        }
        #endregion

        #region CompareTo
        [Test]
        public void CompareTo_SuitGreater_ValueNotConsidered()
        {
            var c0 = new Card(1, 0);
            var c1 = new Card(0, 1);

            Assert.AreEqual(1, c0.CompareTo(c1));
        }

        [Test]
        public void CompareTo_SuitLess_ValueNotConsidered()
        {

            var c0 = new Card(0, 1);
            var c1 = new Card(1, 0);

            Assert.AreEqual(-1, c0.CompareTo(c1));
        }

        [Test]
        public void CompareTo_SuitEqual_ValueGreater()
        {

            var c0 = new Card(0, 1);
            var c1 = new Card(0, 0);

            Assert.AreEqual(1, c0.CompareTo(c1));
        }

        [Test]
        public void CompareTo_SuitEqual_ValueLess()
        {

            var c0 = new Card(0, 0);
            var c1 = new Card(0, 1);

            Assert.AreEqual(-1, c0.CompareTo(c1));
        }

        [Test]
        public void CompareTo_SuitEqual_ValueEqual()
        {

            var c0 = new Card(0, 0);
            var c1 = new Card(0, 0);

            Assert.AreEqual(0, c0.CompareTo(c1));
        }

        #endregion

        #region Constructor

        [Test]
        public void Constructor_SuitOutOfUpperBound_Throws()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Card(4, 0));
        }

        [Test]
        public void Constructor_SuitOutOfLowerBound_Throws()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Card(-1, 0));
        }

        [Test]
        public void Constructor_ValueOutOfUpperBound_Throws()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Card(0, 13));
        }

        [Test]
        public void Constructor_ValueOutOfLowerBound_Throws()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Card(0, -1));
        }

        #endregion
    }
}
