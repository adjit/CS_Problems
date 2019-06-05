using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems.Problems
{
    class Palindromes
    {
        public static bool isPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            s = s.ToLower();
            int head = 0;
            int tail = s.Length - 1;

            while (head < tail)
            {
                if (!char.IsLetterOrDigit(s[head])) head++;
                else if (!char.IsLetterOrDigit(s[tail])) tail--;
                else if (s[head++] != s[tail--]) return false;
            }

            return true;
        }
    }
}
