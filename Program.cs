using System;
using wompa.source.rank;
using wompa.source.test;

namespace wompa
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // NUnit inexplicably refused to work for me, so I had to roll my own dirty version of a test suite
            // Please feel free to review these tests.
            TestRunner.RunTests();
            
            // You can also test the code that did get completed by modifying the following hands
            string handA = "AD KC QS JD 10C";
            string handB = "9H 8H 6H 5H J";
            
            HandRanker ranker = new HandRanker();
            int result = ranker.CompareHands(handA, handB);

            switch (result)
            {
                case 1:
                    Console.WriteLine($"{handA} beats {handB}, hands down.");
                    break;
                
                case -1:
                    Console.WriteLine($"{handA} is beaten by {handB}, what an upset!");
                    break;
                
                case 0:
                    Console.WriteLine($"{handA} and {handB} split the pot.");
                    break;
            }
        }
    }
}