using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Program
    {
        static double Area(double l, double w)
        {
            return l * w;
        }
        static double Area(double R)
        {
            const double PI = 3.14159;
            return R * R * PI;
        }
        static void Main(string[] args)
        {
            double length, width;
            double Radius;
            Console.WriteLine("Enter the sides of Rectangle");

            Console.WriteLine("Length : ");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("width :");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Area of Rectangle");
            Console.WriteLine(Area(length, width));

            //Area
            Console.WriteLine("Enter the Radius");
            Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Area Of Circle");
            Console.WriteLine(Area(Radius));
            Console.ReadLine();

        }
    }
}