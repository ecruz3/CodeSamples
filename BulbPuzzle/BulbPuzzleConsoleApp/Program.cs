using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulbPuzzleLibrary;

namespace BulbPuzzleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Missing arguments!");
                Console.WriteLine("Usage: BulbPuzzleConsoleApp <Number of People> <Number of Bulbs>");
            }
            else
            {
                int people = Convert.ToInt32(args[0]); ;
                int bulbs = Convert.ToInt32(args[1]);

                RunPuzzle(people, bulbs);
            }
#if DEBUG
            Console.WriteLine("Press <Enter> to exit.");
            Console.ReadLine();
#endif
        }

        private static void RunPuzzle(int numberOfPeople, int numberOfBulbs)
        {
            Console.WriteLine("New puzzle run with {0} people and {1} bulbs.", numberOfPeople, numberOfBulbs);

            BulbPuzzle puzzle = new BulbPuzzle(numberOfPeople, numberOfBulbs);
            int numberOfBulbsOn = puzzle.Run();
            Console.WriteLine("Bulbs on: {0}", numberOfBulbsOn);
            bool[] bulbs = puzzle.Bulbs;

            Console.WriteLine("Bulbs turned on are:");
            int counter = 1;
            for (int i = 0; i < puzzle.Bulbs.Length; i++)
            {
                if (bulbs[i])
                {
                    Console.WriteLine("{0,2}) {1}", counter++, i + 1);
                }
            }
        }
    }
}
