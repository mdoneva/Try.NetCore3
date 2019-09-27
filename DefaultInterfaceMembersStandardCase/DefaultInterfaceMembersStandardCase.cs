using System;

namespace DefaultInterfaceMembersStandardCase
{
    class DefaultInterfaceMembersStandardCase
    {
        public interface IFigure
        {
            public double Area();
            //public string Print() => $"Print() of IFigure: {this.ToString()} at {DateTime.Now}";
        }

        public class Rectangle : IFigure
        {
            public double SideA { get; set; }
            public double SideB { get; set; }

            public double Area() => SideA * SideB;
        }

        public class Square : IFigure
        {
            public double SideA { get; set; }

            public double Area() => SideA * SideA;
        }

        static void Main(string[] args)
        {
            IFigure rectangle = new Rectangle { SideA = 4, SideB = 5 };
            Console.WriteLine($"Area of rectangle is {rectangle.Area()}");
            //Console.WriteLine($"{rectangle.Print()}");

            IFigure square = new Square { SideA = 4 };
            Console.WriteLine($"Area of square is {square.Area()}");
            //Console.WriteLine($"{square.Print()}");
        }
    }
}
