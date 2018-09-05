using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SimpleMath
{
    class StringActions
    {  /// <summary>
       /// count letters, special characters and numbers in a mixed string 
       /// </summary>
       /// <param name="input"></param>
       /// <returns>Dictionary of letters and number occurenciess for the letter</returns>
        public Dictionary<char, int> getCount(string input)
        {
            Dictionary<char, int> alphabeticChar = new Dictionary<char, int>();
           
            return input.GroupBy(c => c)
                       .OrderBy(c => c.Key)
                       .ToDictionary(grp => grp.Key, grp => grp.Count());
        }

    }
}
