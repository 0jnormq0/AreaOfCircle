using System;

namespace ExerciseRadius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            //Use our public method to calculate area
            double areaCircle = AreaOfCircle(radius);

            //Write out area for user
            Console.WriteLine($"The area of a circle with radius of {radius} is {areaCircle}!");

        }

        public static double AreaOfCircle(double radius)
        {
            var r = 20;
            var pi = Math.PI;

            //Calculates the area of the circle using radius inputted by user
            var areaOfCircle = pi * (r * r);

            return areaOfCircle;

        }

    }
}
