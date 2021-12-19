using System;

namespace ExerciseRadius
{
    class Program
    {
        static void Main(string[] args)
        {
            //Allow user to input radius
            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            //Use our public method to calculate area of circle
            double areaCircle = AreaOfCircle(radius);

            //Write out area for user
            Console.WriteLine($"The area of a circle with radius of {radius} is {areaCircle}!");

        }

        public static double AreaOfCircle(double radius)
        {
            //Calculates the area of the circle using radius inputted by user
            return Math.PI * (radius * radius);

        }

    }
}
