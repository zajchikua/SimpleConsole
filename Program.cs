using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using SimpleMath;
namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please enter either literal or numeric value, sentence or array: ...");

                //read the input, split on spaces
                var inputValue = Console.ReadLine();

                if (inputValue == "quit")
                {
                    Environment.Exit(0);
                }

                //determine whether input is in correct format
                if (inputValue == null || string.IsNullOrWhiteSpace(inputValue))
                {
                    Console.Out.WriteLine("An incorrect value was entered. Please try again...");
                }

                StringActions sAct = new StringActions();
                MathActions mathAct = new MathActions();
                //verify if the input is all numbers
                List<int> numbers = mathAct.readNum(inputValue);

                //debugging statement
                //Console.Out.WriteLine(string.Join(",", readNum(inputValue)));

                //in case input was mixed, call function to count characters and letters
                if (numbers.Count() == 0)
                {
                    //call alphabetic handling here
                    Dictionary<char, int> alphabeticChar = new Dictionary<char, int>();
                    alphabeticChar = sAct.getCount(inputValue);

                    //order in alphabetic order and print out without spaces
                    alphabeticChar.OrderBy(orK => orK.Key);

                    foreach (var pair in alphabeticChar)
                    {
                        if (pair.Key.ToString() == " ")
                        {
                            continue;
                        }
                        Console.WriteLine("{0} = {1}", pair.Key, pair.Value);
                    }
                }
                else
                {
                    Console.WriteLine("average = {0} \n" +
                        "median = {1} \nmode = {2} \nmin is {3} and max is {4}," +
                        " therefore range is {5}",
                        numbers.Average(), mathAct.findMedian(numbers), mathAct.findMode(numbers), numbers.Min(), numbers.Max(),
                        (numbers.Max() - numbers.Min())
                        );

                }

                Console.WriteLine();

            }

        }

    }
}
