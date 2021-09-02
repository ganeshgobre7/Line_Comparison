using System;

namespace Line_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation Program");
            int x1, x2, y1, y2;
            double line_One;
            x1 = 2; y1 = 3; x2 = 3;y2 = 2;

            int Equation = ((x2 - x1) ^ 2 * (y2 - y1) ^ 2);
            line_One = Math.Abs((0.5) * Equation);

            Console.WriteLine("Length of line :" + line_One);

        }
    }
}
