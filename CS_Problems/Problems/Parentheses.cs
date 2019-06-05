using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems.Problems
{
    class Parentheses
    {
        public static bool IsValid(string s)
        {
            char[] stack = new char[s.Length];
            int head = 0;

            foreach(char par in s)
            {
                switch (par)
                {
                    case '(' :
                        stack[head++] = ')';
                        break;
                    case '{':
                        stack[head++] = '}';
                        break;
                    case '[':
                        stack[head++] = ']';
                        break;
                    default:
                        if (head == 0 || stack[--head] != par) return false; break;
                }
            }
            return head == 0;
        }

        public static IList<string> GenerateParenthesis(int n)
        {
            allParenthesis = new List<string>();
            string parentehsis = "";
            for(int i = 0; i < n*2; i++)
            {
                string p = "(";
                if (i == n) p = ")";

                parentehsis += p;
            }
            allParenthesis.Add(parentehsis);

            swap(parentehsis, n);

            return allParenthesis;
        }

        private static List<string> allParenthesis;

        private static void swap(string s, int swap_idx)
        {

        }
    }
}
