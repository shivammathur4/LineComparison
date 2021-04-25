using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Welcome to the Line Comparision Computation");
            Console.WriteLine("===========================================");
            int[] line1Point1 = new int[2];
            int[] line1Point2 = new int[2];
            int[] line2Point1 = new int[2];
            int[] line2Point2 = new int[2];
            StorePoints(ref line1Point1, ref line1Point2);
            double line1Length;
            line1Length = FindLength(line1Point1, line1Point2);
            Console.WriteLine("Length of first line is " + line1Length);
            StorePoints(ref line2Point1, ref line2Point2);
            double line2Length;
            line2Length = FindLength(line2Point1, line2Point2);
            Console.WriteLine("Length of first line is " + line2Length);
            if (line1Length == line2Length)
                Console.WriteLine("Both lines have equal length");
            else if (line1Length > line2Length)
                Console.WriteLine("First line is longer than the second one");
            else
                Console.WriteLine("First line is sorter than the second one");
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
            length = Math.Sqrt(Math.Pow((p2[0] - p1[0]), 2) + Math.Pow((p2[1] - p1[1]), 2));
            return length;
        }
    }
}
