using System;

namespace LeetCode.Problem
{
    internal static class NoelTree
    {
        static int maxColumn;
        static string treeChar = "*";

        public static void Write()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter max line  : ");
            var res = int.TryParse(Console.ReadLine(), out int nbLine);

            if (!res)
                Console.WriteLine("You must enter a valid numeric value");

            maxColumn = Console.LargestWindowHeight - 1;
            int centerOfScreen = maxColumn / 2;


            for (int i = 0; i < nbLine; i++)
            {
                var numberOfCharToWrite = (i * 2) + 1;
                var position = centerOfScreen - i;

                if (numberOfCharToWrite > maxColumn)
                {
                    Console.WriteLine();
                    Console.WriteLine($"We have cut your tree because is too BUG for my screen !, You cant exceed {maxColumn} columns");
                    break;
                }



                WriteAtPosition(position, numberOfCharToWrite);
                Console.WriteLine();
            }

            WriteRetry();

        }

        private static void WriteAtPosition(int pos, int number)
        {
            for (int i = 0; i < maxColumn; i++)
            {
                if (i == pos || (i > pos && i < (pos + number)))
                {
                    Console.Write(treeChar);
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }

        private static void WriteRetry()
        {
            Console.WriteLine();
            Console.WriteLine("Retry");
            Write();
        }

    }
}
