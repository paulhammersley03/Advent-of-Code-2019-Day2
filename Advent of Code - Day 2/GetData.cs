using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Advent_of_Code___Day_2
{
    public class GetData
    {
        public int[] GetArray()
        {
            var numberArray = File.ReadAllText("C:/Users/minim/Documents/C# Projects/Advent of Code - Day 2/Day 2 Data.txt").Split(',').Select(int.Parse).ToArray();
            return numberArray;
        }  
    }
}
