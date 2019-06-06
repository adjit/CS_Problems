using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester_Singleton tester = Tester_Singleton.Instance();

            int[,] area = new int[3, 3]
            {
                { 1, 1, 1 },
                { 0, 1, 0 },
                { 0, 9, 0 }
            };


            int distance = tester.minimumDistance(3, 3, area);

            Console.WriteLine(distance);

            tester.RomanToInt("III");

            Console.Write("Please enter a string to find length of longest substring: ");
            Console.WriteLine(tester.LengthOfLongestSubstring(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
