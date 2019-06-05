using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems.Problems
{
    class RomanNumerals
    {
        private enum RomanFull
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

        private enum Roman
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }

        public static int RomanToInt(string s)
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

            for (int r = s.Length - 1; r >= 0; r--)
            {
                romanVal = s[r].ToString();

                while (romanValues[j].ToString() == s[r].ToString())
                {
                    num += (int)romanValues[j];
                    r--;
                }


                if ((Roman)s[r - 1] < (Roman)romanValues[j])
                {

                }
            }

            while (s[maxRange - 1].ToString() == RomanFull.I.ToString())
            {
                num++;
                maxRange--;
                if (maxRange == 0) return num;
            }

            for (int i = romanValues.Length - 1; i >= 0 && j < maxRange; i--)
            {
                one = s[j].ToString();
                two = one + s[j + 1].ToString();

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

        public static string IntToRoman(int num)
        {
            var romanValues = (RomanFull[])Enum.GetValues(typeof(RomanFull));
            int romanVal;
            string roman = "";

            for (int i = romanValues.Length - 1; i >= 0; i--)
            {
                romanVal = (int)romanValues[i];

                if (num / romanVal < 1) continue;

                roman += (RomanFull)romanVal;
                i++;
                num -= romanVal;
            }

            return roman;
        }
    }
}
