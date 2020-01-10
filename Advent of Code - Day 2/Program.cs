using System;
using System.Collections.Generic;

namespace Advent_of_Code___Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int answer2 = 0;
            int noun = 0;
            int verb = 0;

            if (answer != 0)
            {
                Console.WriteLine("Day 2, task 1 answer is: " + answer);
            }

            else
            {
                while (answer2 != 19690720)
                {
                    int[] numberArray = new GetData().GetArray();
                    //answer = new Calculation().GetAnswer(numberArray);//tried nullble noun and verb, couldn't get to work
                    var random = new RandomNumberGenerator().Random();
                    noun = new RandomNumberGenerator().Noun(random);
                    verb = new RandomNumberGenerator().Verb(random);
                    answer2 = new Calculation().GetAnswer(numberArray, noun, verb);
                }
                Console.WriteLine("Day 2, task 2 answer is: " + noun + " " + verb + " makes " + answer2);
            }
            Console.ReadLine();
        }
    }
}
