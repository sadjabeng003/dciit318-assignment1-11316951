using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first side of the triangle:");
            double side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second side of the triangle:");
            double side2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third side of the triangle:");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
    }
}
