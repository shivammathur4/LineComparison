using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Line Comparison Computation Program!");

            int[] firstPoint = new int[2];
            int[] secondPoint = new int[2];
            StorePoints(ref firstPoint, ref secondPoint);
            double lineLength;
            lineLength = FindLength(firstPoint, secondPoint);
            Console.WriteLine("Length of the line is " + lineLength);
            return;
        }

        static void StorePoints(ref int[] p1, ref int[] p2)
        {
            Console.WriteLine("Enter X-Coordinate of 1st point");
            p1[0] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y-Coordinate of 1st point");
            p1[1] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter X-Coordinate of 2nd point");
            p2[0] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y-Coordinate of 2nd point");
            p2[1] = Int32.Parse(Console.ReadLine());
            return;
        }
        static double FindLength(int[] p1, int[] p2)
        {
            double length;
            length = Math.Sqrt((p2[0] - p1[0]) ^ 2 + (p2[1] - p1[1]) ^ 2);
            return Math.Round(length, 2);
        }
    }
}
