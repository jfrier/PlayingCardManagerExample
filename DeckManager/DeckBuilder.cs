using System.Collections.Generic;

namespace DeckManager
{
    public interface IDeckBuilder
    {
        IEnumerable<Card> Generate52CardDeck();
    }

    public class DeckBuilder : IDeckBuilder
    {
        public IEnumerable<Card> Generate52CardDeck()
        {
            var result = new List<Card>();

            //Initialize the deck with 52 cards
            for (var suit = 0; suit < 4; suit++)
            {
                for (var value = 0; value < 13; value++)
                {
                    var card = new Card(suit, value);
                    result.Add(card);
                }
            }

            return result;
        }
    }
}
