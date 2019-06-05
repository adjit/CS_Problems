using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems.Problems
{
    class ZigZag
    {
        public static string zigZagConvert(string s, int numRows)
        {
            if (numRows <= 1 || numRows >= s.Length) return s;

            StringBuilder[] sRows = new StringBuilder[numRows];

            for (int x = 0; x < numRows; x++) sRows[x] = new StringBuilder();

            StringBuilder response = new StringBuilder();

            int i = 0;
            int currRow = 0;
            int incrementer = 1;

            while (i < s.Length)
            {
                if (currRow == numRows - 1 || (currRow == 0 && incrementer < 0)) incrementer *= -1;

                sRows[currRow].Append(s[i++]);

                currRow += incrementer;
            }

            for (int j = 0; j < numRows; j++) response.Append(sRows[j]);

            return response.ToString();
        }
    }
}
