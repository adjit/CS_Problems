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

            Console.Write("Please enter a string to find length of longest substring: ");
            Console.WriteLine(tester.LengthOfLongestSubstring(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
