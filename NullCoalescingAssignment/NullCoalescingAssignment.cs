using System;
using System.Collections.Generic;

namespace NullCoalescingAssignment
{
    class NullCoalescingAssignment
    {
        static void Main(string[] args)
        {
            List<int> numbers = null;
            int? i = null;


            //numbers = numbers ?? new List<int>();
            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(' ', numbers));  // output: 17 17
        }
    }
}
