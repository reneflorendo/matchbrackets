using System;

namespace MatchingBracketsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchingBrackets matchingBrackets = new MatchingBrackets();

            Console.WriteLine($"{"<>"}-{matchingBrackets.HasMatchingBrackets("<>")}");
            Console.WriteLine($"{"><"}- {matchingBrackets.HasMatchingBrackets("><")}");
            Console.WriteLine($"{"<<>"}-{matchingBrackets.HasMatchingBrackets("<<>")}");
            Console.WriteLine($"\"\"-{matchingBrackets.HasMatchingBrackets("")}");
            Console.WriteLine($"{"<abc...xyz>"}-{matchingBrackets.HasMatchingBrackets("<abc...xyz>")}");

            Console.ReadLine();

        }
    }
}
