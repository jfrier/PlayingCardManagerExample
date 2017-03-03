using System;

namespace DeckManager
{
    /// <summary>
    /// Class used to wrap .net's random number generator so it can be mocked out in unit tests.
    /// </summary>
    public interface IRandomGenerator
    {
        int Next(int minValue, int maxValue);
    }

    /// <summary>
    /// Class used to wrap .net's random number generator so it can be mocked out in unit tests.
    /// </summary>
    public class RandomGenerator : IRandomGenerator
    {
        private Random random;

        public RandomGenerator()
        {
            random = new Random();
        }

        public int Next(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }
    }
}
