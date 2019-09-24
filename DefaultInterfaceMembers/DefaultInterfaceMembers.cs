using System;

namespace DefaultInterfaceMembers
{
    class DefaultInterfaceMembers
    {
        public interface IFigure
        {
            public string Print() => $"This is IFigure: {this.ToString()}";

        }

        public interface IRectangle : IFigure
        {
            public new string Print() => $"This is IRectangle: {this.ToString()}";
        }

        public interface ISquare : IFigure
        {
            public new string Print() => $"This is ISquare: {this.ToString()}";
        }

        public interface ITetragon : IRectangle, ISquare { }

        public class Tetragon : ITetragon { }

        static void Main(string[] args)
        {
            ITetragon tetragon = new Tetragon();
            // C# 8.0 will solve this issue by introducing the most specific override rule. 
            // It means that in our case illustrated above, the compiler will issue an error and won’t let us do this.
            //Console.WriteLine(value: $"{tetragon.Print()}");
        }
    }
}
