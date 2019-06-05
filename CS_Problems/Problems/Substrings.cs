using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems.Problems
{
    class Substrings
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int currLen = 0;
            int maxLen = 1;

            if (s == "") return 0;

            for (int i = 0; i < s.Length; i++)
            {
                Dictionary<char, int> letters = new Dictionary<char, int>();
                letters.Add(s[i], 1);
                currLen = 1;

                for (int j = i + 1; j < s.Length; j++)
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

        public static string LongestCommonPrefix(string[] strs)
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
    }
}
