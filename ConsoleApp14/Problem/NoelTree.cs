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
            var nbLine = int.Parse(Console.ReadLine());
            maxColumn = Console.LargestWindowHeight - 1;
            int centerOfScreen = maxColumn / 2;

      
            for (int i = 0; i < nbLine; i++)
            {
                var numberOfCharToWrite = (i * 2) + 1;
                var position = centerOfScreen - i;
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
