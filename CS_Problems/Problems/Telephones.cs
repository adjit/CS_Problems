using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems.Problems
{
    class Telephones
    {
        public static IList<string> LetterCombinations(string digits)
        {
            List<string> permutations = new List<string>();

            if (digits == null || digits.Length == 0) return permutations;

            Dictionary<char, string> keypad = new Dictionary<char, string>();
            keypad.Add('0', "");
            keypad.Add('1', "");
            keypad.Add('2', "abc");
            keypad.Add('3', "def");
            keypad.Add('4', "ghi");
            keypad.Add('5', "jkl");
            keypad.Add('6', "mno");
            keypad.Add('7', "pqrs");
            keypad.Add('8', "tuv");
            keypad.Add('9', "wxyz");

            permutations.Add("");

            foreach(char digit in digits)
            {
                List<string> temp_result = new List<string>();
                string alphabet = keypad[digit];
                
                foreach(string permutation in permutations)
                {
                    foreach(char letter in alphabet)
                    {
                        temp_result.Add(permutation + letter);
                    }
                }

                permutations = temp_result;
            }

            return permutations;
        }
    }
}
