using System;

namespace Line_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation Program");
            int x1, x2, y1, y2, x3, x4, y3, y4;
            double line_One, line_Two;
            x1 = 2; y1 = 3; x2 = 3;y2 = 2;
            x3 = 2; y3 = 3; x4 = 3; y4 = 2;


            int Equation_one = ((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            line_One = Math.Abs((0.5) * Equation_one);
            Console.WriteLine("Length of line_one :" +line_One);

            int Equation_two = ((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            line_Two = Math.Abs((0.5) * Equation_two);
            Console.WriteLine("Length of line_two :" +line_Two);


            Console.WriteLine(line_One.Equals(line_Two));

            Console.WriteLine(line_One.CompareTo(line_Two));

        }
    }
}
