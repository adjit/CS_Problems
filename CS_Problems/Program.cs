using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Problems.Cards;

namespace CS_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester_Singleton tester = Tester_Singleton.Instance();

            int[,] area = new int[5, 5]
            {
                { 1, 1, 1, 0, 0 },
                { 1, 0, 1, 1, 1 },
                { 1, 1, 0, 0, 1 },
                { 0, 1, 1, 9, 1 },
                { 1, 0, 0, 0, 1 }
            };


            int distance = tester.minimumDistance(5, 5, area);

            Console.WriteLine(distance);

            Console.ReadKey();
            // tester.RomanToInt("III");

            Deck deck = new Deck(TypeOfCardDeck.PlayingCards);

            Console.Write("Please enter a string to find length of longest substring: ");
            Console.WriteLine(tester.LengthOfLongestSubstring(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
