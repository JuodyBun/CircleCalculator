using System;

namespace AreaCircleByRad
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine( UserInput());
            Console.WriteLine( Area());
        }

        public static string UserInput()
        {

            Console.WriteLine("Hello! I can help you calculate the area, diameter and circumference of a circle by its' radius. What is the radius?");
            string radius = Console.ReadLine();
            double userRad = Convert.ToDouble(radius);
            return userRad;
            
        }

        public double Area(double userRad)
        {
            double area = 3.14 * Math.Pow(userRad, 2);
            Console.WriteLine($"The area is + {area}.");
            return area;
        }

        public double Diameter(double userRad)
        {
            double diameter = userRad * 2;
            Console.WriteLine($"The diameter is {diameter}.");
            return diameter;
        }

        public double Circumference(double diameter)
        {
            double circumference = 3.14 * diameter;
            Console.WriteLine($"The circumference is {circumference}");
            return circumference;
        }
    }
}
