using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Converts distances
    /// </summary>
    /// <author>
    /// Lottie Scragg
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;

        /// <summary>
        /// Runs the app
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// <summary>
        /// Prints a heading
        /// </summary>
        public void OutputHeading()
        {
            Console.WriteLine(" ======================== ");
            Console.WriteLine(" App01 Distance Converter ");
            Console.WriteLine("     by Lottie Scragg     ");
            Console.WriteLine(" ======================== ");
        }

        /// <summary>
        /// Asks the user to input the distance in miles
        /// </summary>
        public void InputMiles()
        {
            Console.WriteLine(" Input the distance in miles: ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// Turns the miles input into feet
        /// </summary>
        public void CalculateFeet()
        {
            feet = miles * 5280;
        }
        /// <summary>
        /// Prints the miles in feet
        /// </summary>
        public void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet ");
        }
    }
}
