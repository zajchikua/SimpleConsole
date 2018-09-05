using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleMath
{
    class MathActions
    {
        /// <summary>
        /// read input from numbers exclusively 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<int> readNum(string input)
        {
            List<int> numbers = new List<int>();
            var m = Regex.Matches(input, @"[-]?\d+");
            int tmpInt;
            foreach (Match match in m)
            {
                if (int.TryParse((match.Value), out tmpInt))
                {
                    numbers.Add(tmpInt);
                };

            }

            if (input != string.Join(" ", numbers))
            {
                //for the debug
                //Console.Out.WriteLine("Input is not a list of numbers");
                return new List<int>();
            }
            return numbers;
        }

        /// <summary>
        /// median is a number in the middle of the array
        /// handle even/ odd number of the digits in the array
        /// </summary>
        /// <param name="numList"></param>
        /// <returns></returns>
        public  double findMedian(List<int> numList)
        {
            double median;
            int numCount = numList.Count();
            int halfIndex = numList.Count() / 2;

            //sort
            var sortedList = numList.OrderBy(n => n);
            if ((numCount % 2) == 0)
            {
                median = ((sortedList.ElementAt(halfIndex) +
                    sortedList.ElementAt(halfIndex - 1)) / 2);
            }
            else
            {
                median = sortedList.ElementAt(halfIndex);
            }
            return median;
        }

        /// <summary>
        /// Mode is the number that occurs the largest number of times.
        /// </summary>
        /// <param name="numList"></param>
        /// <returns></returns>
        public  int findMode(List<int> numList)
        {
            var mode = numList.GroupBy(n => n).
                 OrderByDescending(g => g.Count()).ThenBy(g => g.Key).
                 Select(g => g.Key).FirstOrDefault();
            return mode;
        }
    }
}
