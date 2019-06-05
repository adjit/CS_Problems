using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Problems.Problems;

namespace CS_Problems
{
    class Tester_Singleton : ITesterInterface
    {
        private static Tester_Singleton _instance;

        protected Tester_Singleton() { }

        public static Tester_Singleton Instance()
        {
            if (_instance == null)
                _instance = new Tester_Singleton();

            return _instance;
        }

        public int RomanToInt(string s)
        {
            return RomanNumerals.RomanToInt(s);
        }

        public string IntToRoman(int num)
        {
            return RomanNumerals.IntToRoman(num);
        }

        public bool isPalindrome(string s)
        {
            return Palindromes.isPalindrome(s);
        }

        public int LengthOfLongestSubstring(string s)
        {
            return Substrings.LengthOfLongestSubstring(s);
        }

        //https://leetcode.com/problems/regular-expression-matching/
        public bool regex_isMatch(string s, string p)
        {
            throw new NotImplementedException();
        }

        public string zigZagConvert(string s, int numRows)
        {            
            return ZigZag.zigZagConvert(s, numRows);
        }

        public string LongestCommonPrefix(string[] strs)
        {
            return Substrings.LongestCommonPrefix(strs);
        }

        public IList<string> LetterCombinations(string digits)
        {
            return Telephones.LetterCombinations(digits);
        }

        public bool validParentheses(string s)
        {
            return Parentheses.IsValid(s);
        }

        public IList<string> GenerateParenthesis(int n)
        {
            return Parentheses.GenerateParenthesis(n);
        }
    }
}
