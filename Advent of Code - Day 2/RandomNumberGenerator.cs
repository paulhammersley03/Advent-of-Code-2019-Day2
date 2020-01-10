using System;

namespace Advent_of_Code___Day_2
{
    public class RandomNumberGenerator
    {
        public Random Random()
        { 
            var random = new Random();
            return random;
        }

        public int Noun(Random random)
        {
            int noun = random.Next(0, 99);
            return noun;
        }

        public int Verb(Random random)
        {
            int verb = random.Next(0, 99);
            return verb;
        }
    }
}
