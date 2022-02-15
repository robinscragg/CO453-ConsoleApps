using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Converts from a user selected unit of 
    /// distance to another
    /// </summary>
    /// <author>
    /// Lottie Scragg
    /// </author>
    public class DistanceConverter
    {
        private const int FEET_IN_MILES = 5280;
        private const double METRES_IN_MILES = 1609.34;

        private double miles;
        private double feet;
        private double metres;

        
        public void MilesToFeet()
        {
            OutputHeading("Converting miles to feet");
            miles = InputDistance("Input the distance in miles : ");
            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));

        }

        public void FeetToMiles()
        {
            OutputHeading("Converting feet to miles");
            feet = InputDistance("Input the distance in feet : ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));

        }

        public void MilesToMetres()
        {
            OutputHeading("Converting miles to metres");
            miles = InputDistance("Input the distance in miles : ");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));

        }
        /// <summary>
        /// Prints a heading
        /// </summary>
        public void OutputHeading(string prompt)
        {
            Console.WriteLine(" ======================== ");
            Console.WriteLine(" App01 Distance Converter ");
            Console.WriteLine("     by Lottie Scragg     ");
            Console.WriteLine(" ======================== ");

            Console.WriteLine(prompt);
            Console.WriteLine();

        }

        /// <summary>
        /// Asks the user to input the distance 
        /// </summary>
        public double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Turns the miles input into feet
        /// </summary>
        public void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// Prints the output
        /// </summary>
        public void OutputDistance(double fromDistance, string fromUnit, double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}");
        }


        /// <summary>
        /// Converts feet to miles
        /// </summary>
        public void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /// <summary>
        /// Converts miles to metres
        /// </summary>
        public void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

    }
}
