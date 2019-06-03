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
    }
}
