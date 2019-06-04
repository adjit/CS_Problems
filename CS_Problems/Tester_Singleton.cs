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
                if (currRow == numRows-1 || currRow == 0) incrementer *= -1;

                sRows[currRow].Append(s[i++]);

                currRow += incrementer;
            }

            for (int j = 0; i < numRows; i++) response.Append(sRows[i]);

            return response.ToString();
        }
    }
}
