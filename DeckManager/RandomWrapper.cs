using System;

namespace DeckManager
{
    /// <summary>
    /// Class used to wrap .net's random number generator so it can be mocked out in unit tests.
    /// </summary>
    public interface IRandomWrapper
    {
        int Next(int minValue, int maxValue);
    }

    /// <summary>
    /// Class used to wrap .net's random number generator so it can be mocked out in unit tests.
    /// </summary>
    public class RandomWrapper : IRandomWrapper
    {
        private Random random;

        public RandomWrapper()
        {
            random = new Random();
        }

        public int Next(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }
    }
}
