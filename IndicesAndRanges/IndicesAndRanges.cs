using System;

namespace IndicesAndRanges
{
    class ProgramIndicesAndRanges
    {
        internal static string[] words = new string[]
        {
                            // Index from start     Index from end
            "This",         // 0                    9
            "is",           // 1                    8   
            "just",         // 2                    7
            "a",            // 3                    6
            "simple",       // 4                    5
            "example",      // 5                    4
            "of",           // 6                    3
            "random",       // 7                    2
            "words"         // 8                    1
        };

        static void Main(string[] args)
        {
            Console.WriteLine($"The last word is <{words[^1]}>");
            Console.WriteLine();

            Index index = ^2;
            Console.WriteLine($"The word before the last one is<{words[index]}>");
            Console.WriteLine();

            Console.WriteLine("Words in the range [2..4] are:");
            foreach (var word in words[2..4])
            {
                Console.WriteLine($"<{word}>");
            }
            Console.WriteLine();

            Range range = ^2..;
            Console.WriteLine($"Last exclusive end index of range [^2..] is: {range.End}");
            Console.WriteLine("Last two words are:");
            foreach (var word in words[range])
            {
                Console.WriteLine($"<{word}>");
            }
            Console.WriteLine();

            Console.WriteLine("Words from start to index [..5] are:");
            foreach (var word in words[..5])
            {
                Console.WriteLine($"<{word}>");
            }
        }
    }
}
