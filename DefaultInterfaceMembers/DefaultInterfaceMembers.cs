using System;

namespace DefaultInterfaceMembers
{
    /// <summary>
    /// Be careful when using default implementations
    /// </summary>
    class DefaultInterfaceMembers
    {

        public interface IRectangle
        {
            public string Print() => "This is Print() from IRectangle";
        }

        public interface ISquare
        {
            //public string Print() => "This is Print() from ISquare";
        }

        public interface ITetragon : IRectangle, ISquare { }

        public class Tetragon : ITetragon { }

        static void Main(string[] args)
        {
            ITetragon tetragon = new Tetragon();

            // C# 8.0 will solve this issue by introducing the most specific override rule. 
            // It means that in our case illustrated above, the compiler will issue an error and won’t let us do this.
            Console.WriteLine(value: $"{tetragon.Print()}");
        }
    }
}
