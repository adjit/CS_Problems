using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems
{
    interface ITesterInterface
    {
        int LengthOfLongestSubstring(string s);
        bool isPalindrome(string s);
        string zigZagConvert(string s, int numRows);
        bool regex_isMatch(string s, string p);
        string IntToRoman(int num);
        int RomanToInt(string s);
        string LongestCommonPrefix(string[] strs);
        IList<string> LetterCombinations(string digits);

    }
}
