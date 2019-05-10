using System;
using System.Linq;

namespace FindTriangleType
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Triangle.GetTriangleType(1, 1, 0);

            Console.WriteLine(type);
            Console.ReadLine();
        }
    }

    public enum TriangleType
    {
        Scalene = 1,
        Isosceles = 2,
        Equilateral = 3,
        Error = 4
    }

    public class Triangle
    {
        public static TriangleType GetTriangleType(int a, int b, int c)
        {
            TriangleType type = new TriangleType();

            int[] values = new int[3] { a, b, c };

            if ((a + b) > c || (b + c) > a || (a + c) > b)
            {
                if (values.Distinct().Count() == 1)
                {
                    type = TriangleType.Equilateral;
                }
                else if (values.Distinct().Count() == 2)
                {
                    type = TriangleType.Isosceles;
                }
                else if (values.Distinct().Count() == 3)
                {
                    type = TriangleType.Scalene;
                }
            }
            else
            {
                type = TriangleType.Error;
            }

            if (a <= 0 || b <= 0 || c <= 0)
            {
                type = TriangleType.Error;
            }

            return type;
        }
    }
}
