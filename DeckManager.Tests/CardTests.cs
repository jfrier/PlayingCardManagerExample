using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CardManager.Tests
{
    public class CardTests
    {
        #region ToString
        [Test]
        public void ToString_ClubSuitIsTranslatedCorrectly()
        {
            var card = new Card() { Suit = 0, Value = 0 };
            var actual = card.ToString();
            Assert.IsTrue(actual.EndsWith("of Clubs"));
        }

        [Test]
        public void ToString_DiamondSuitIsTranslatedCorrectly()
        {
            var card = new Card() { Suit = 1, Value = 0 };
            var actual = card.ToString();
            Assert.IsTrue(actual.EndsWith("of Diamonds"));
        }

        [Test]
        public void ToString_HeartSuitIsTranslatedCorrectly()
        {
            var card = new Card() { Suit = 2, Value = 0 };
            var actual = card.ToString();
            Assert.IsTrue(actual.EndsWith("of Hearts"));
        }

        [Test]
        public void ToString_SpadeSuitIsTranslatedCorrectly()
        {
            var card = new Card() { Suit = 3, Value = 0 };
            var actual = card.ToString();
            Assert.IsTrue(actual.EndsWith("of Spades"));
        }

        [Test]
        public void ToString_AceValueIsTranslatedCorrectly()
        {
            var card = new Card() { Suit = 0, Value = 0 };
            var actual = card.ToString();
            Assert.IsTrue(actual.StartsWith("Ace"));
        }

        [Test]
        public void ToString_JackValueIsTranslatedCorrectly()
        {
            var card = new Card() { Suit = 0, Value = 10 };
            var actual = card.ToString();
            Assert.IsTrue(actual.StartsWith("Jack"));
        }

        [Test]
        public void ToString_QueenValueIsTranslatedCorrectly()
        {
            var card = new Card() { Suit = 0, Value = 11 };
            var actual = card.ToString();
            Assert.IsTrue(actual.StartsWith("Queen"));
        }

        [Test]
        public void ToString_KingValueIsTranslatedCorrectly()
        {
            var card = new Card() { Suit = 0, Value = 12 };
            var actual = card.ToString();
            Assert.IsTrue(actual.StartsWith("King"));
        }

        [Test]
        public void ToString_2Through10AreTranslatedCorrectly()
        {
            for (int i = 1; i < 10; i ++)
            {
                var card = new Card { Suit = 0, Value = i };
                var actual = card.ToString();
                Assert.IsTrue(actual.StartsWith((i + 1).ToString()));
            }
        }

        [Test]
        public void ToString_SuitAndValueAreConcatenatedCorrectly()
        {
            var card = new Card { Suit = 0, Value = 0 };
            var actual = card.ToString();
            Assert.AreEqual("Ace of Clubs", actual);
        }
        
        [Test]
        public void ToString_ExceptionThrownWhenSuitOutOfRange()
        {
            var card = new Card() { Suit = 4, Value = 0 };
            var ex = Assert.Throws<InvalidCastException>(() => card.ToString());
            Assert.AreEqual("Unrecognized suite.", ex.Message);
        }

        [Test]
        public void ToString_ExceptionThrownWhenValueOutOfRange()
        {
            var card = new Card() { Suit = 0, Value = 13 };
            var ex = Assert.Throws<InvalidCastException>(() => card.ToString());
            Assert.AreEqual("Unrecognized value.", ex.Message);
        }
        #endregion

        #region CompareTo
        [Test]
        public void CompareTo_SuitGreater_ValueNotConsidered()
        {

        }

        [Test]
        public void CompareTo_SuitLess_ValueNotConsidered()
        {

        }

        [Test]
        public void CompareTo_SuitEqual_ValueGreater()
        {

        }

        [Test]
        public void CompareTo_SuitEqual_ValueLess()
        {

        }

        [Test]
        public void CompareTo_SuitEqual_ValueEqual()
        {

        }

        #endregion
    }
}
