using System;

namespace Advent_of_Code___Day_2
{
    class Calculation
    {
        public int GetAnswer(int[] numberArray, int noun, int verb)//tried nullable inputs, couldn't get to work
        {
            //numberArray[1] = 12;
            //numberArray[2] = 2;

            //if (noun != 0 && verb != 0)
            //{
                numberArray[1] = noun;
                numberArray[2] = verb;
            //}

            int positionZero;
            int positionOne;
            int positionOneValue;
            int positionTwo;
            int positionTwoValue;
            int positionThree;
            int calculation;

            try
            {
                for (int i = 0; i < numberArray.Length; i += 4)
                {
                    positionZero = numberArray[i];
                    positionOne = numberArray[i + 1];
                    positionOneValue = numberArray[positionOne];
                    positionTwo = numberArray[i + 2];
                    positionTwoValue = numberArray[positionTwo];
                    positionThree = numberArray[i + 3];

                    if (positionZero == 1)
                    {
                        calculation = positionOneValue + positionTwoValue;
                        numberArray[positionThree] = calculation;
                    }
                    if (positionZero == 2)
                    {
                        calculation = positionOneValue * positionTwoValue;
                        numberArray[positionThree] = calculation;
                    }
                    if (positionZero == 99)
                    {
                        break;
                    }
                }
            }
            catch (IndexOutOfRangeException) { }

            var answer = numberArray[0];
            return answer;
        }
    }
}
    


