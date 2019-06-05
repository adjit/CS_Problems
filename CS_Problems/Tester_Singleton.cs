using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public enum RomanFull
        {
            I = 1,
            IV = 4,
            V = 5,
            IX = 9,
            X = 10,
            XL = 40,
            L = 50,
            XC = 90,
            C = 100,
            CD = 400,
            D = 500,
            CM = 900,
            M = 1000
        }

        public enum Roman
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }

        public int RomanToInt(string s)
        {
            var romanValues = (Roman[])Enum.GetValues(typeof(Roman));
            int num = 0;
            int maxRange = s.Length;
            int j = 0;
            int incrementor = 0;
            string one = "";
            string two = "";
            string romanVal = "";
            string prev = "";

            for(int r = s.Length-1; r >= 0; r--)
            {
                romanVal = s[r].ToString();

                while(romanValues[j].ToString() == s[r].ToString())
                {
                    num += (int)romanValues[j];
                    r--;
                }
                

                if((Roman)s[r-1] < (Roman)romanValues[j])
                {

                }
            }
            
            while(s[maxRange-1].ToString() == RomanFull.I.ToString())
            {
                num++;
                maxRange--;
                if (maxRange == 0) return num;
            }

            for (int i = romanValues.Length - 1; i >= 0 && j < maxRange; i--)
            {
                one = s[j].ToString();
                two = one + s[j+1].ToString();

                romanVal = romanValues[i].ToString();

                if (one != romanVal && two != romanVal) continue;

                if (one == romanVal) incrementor = 0;
                else if (two == romanVal) incrementor = 1;

                num += (int)romanValues[i];
                i++;
                j += incrementor;
            }

            throw new NotImplementedException();
            return num;
        }

        public string IntToRoman(int num)
        {
            var romanValues = (RomanFull[])Enum.GetValues(typeof(RomanFull));
            int romanVal;
            string roman = "";

            for(int i = romanValues.Length-1; i >= 0; i--)
            {
                romanVal = (int)romanValues[i];

                if (num / romanVal < 1) continue;

                roman += (RomanFull)romanVal;
                i++;
                num -= romanVal;
            }

            return roman;
        }

        public bool isPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            s = s.ToLower();
            int head = 0;
            int tail = s.Length - 1;

            while(head < tail)
            {
                if (!char.IsLetterOrDigit(s[head])) head++;
                else if (!char.IsLetterOrDigit(s[tail])) tail--;
                else if (s[head++] != s[tail--]) return false;
            }

            return true;
        }

        public int LengthOfLongestSubstring(string s)
        {
            int currLen = 0;
            int maxLen = 1;

            if (s == "") return 0;

            for(int i = 0; i < s.Length; i++)
            {
                Dictionary<char, int> letters = new Dictionary<char, int>();
                letters.Add(s[i], 1);
                currLen = 1;

                for(int j = i+1; j < s.Length; j++)
                {
                    if (letters.ContainsKey(s[j]))
                        break;

                    letters.Add(s[j], 1);
                    currLen++;

                    if (currLen > maxLen) maxLen = currLen;
                }
            }

            return maxLen;
        }

        //https://leetcode.com/problems/regular-expression-matching/
        public bool regex_isMatch(string s, string p)
        {
            throw new NotImplementedException();
        }

        public string zigZagConvert(string s, int numRows)
        {
            if (numRows <= 1 || numRows >= s.Length) return s;

            StringBuilder[] sRows = new StringBuilder[numRows];

            for (int x = 0; x < numRows; x++) sRows[x] = new StringBuilder();

            StringBuilder response = new StringBuilder();

            int i = 0;
            int currRow = 0;
            int incrementer = 1;

            while(i < s.Length)
            {
                if (currRow == numRows-1 || (currRow == 0 && incrementer < 0)) incrementer *= -1;

                sRows[currRow].Append(s[i++]);

                currRow += incrementer;
            }

            for (int j = 0; j < numRows; j++) response.Append(sRows[j]);

            return response.ToString();
        }

        public string LongestCommonPrefix(string[] strs)
        {
            int shortest = int.MaxValue;
            int i = 0;
            int j = 0;
            string prefix = "";

            if (strs.Length == 0) return prefix;

            for (i = 0; i < strs.Length; i++)
            {
                if (string.IsNullOrEmpty(strs[i])) return prefix;
                if (shortest > strs[i].Length) shortest = strs[i].Length;
            }

            for (j = 0; j < shortest; j++)
            {
                char first = strs[0][j];
                for (i = 1; i < strs.Length; i++)
                {
                    if (first != strs[i][j]) return prefix;
                }
                prefix += first;
            }
            return prefix;
        }

        public IList<string> LetterCombinations(string digits)
        {
            Dictionary<int, string> keypad = new Dictionary<int, string>();
            keypad.Add(0, "");
            keypad.Add(1, "");
            keypad.Add(2, "abc");
            keypad.Add(3, "def");
            keypad.Add(4, "ghi");
            keypad.Add(5, "jkl");
            keypad.Add(6, "mno");
            keypad.Add(7, "pqrs");
            keypad.Add(8, "tuv");
            keypad.Add(9, "wxyz");



            throw new NotImplementedException();
        }
    }
}
