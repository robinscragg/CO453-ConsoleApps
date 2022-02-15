using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Converts from a user selected unit 
    /// to a different user selected unit
    /// </summary>
    /// <author>
    /// Lottie Scragg
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;

        private double miles;
        private double feet;
        private double metres;

        /// <summary>
        /// A distance in miles will be inputted, converted to feet
        /// then the result is outputted
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting miles to feet");
            miles = InputDistance("Please enter the number of miles : ");
            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));

        }

        public void FeetToMiles()
        {
            OutputHeading("Converting feet to miles");
            feet = InputDistance("Please enter the number of feet : ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting miles to metres");
            miles = InputDistance("Please enter the number of miles : ");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        /// <summary>
        /// Prints a heading
        /// </summary>
        public void OutputHeading(String prompt)
        {
            Console.WriteLine(" ======================== ");
            Console.WriteLine(" App01 Distance Converter ");
            Console.WriteLine("     by Lottie Scragg     ");
            Console.WriteLine(" ======================== ");

            Console.WriteLine(prompt);
            Console.WriteLine();

        }

        /// <summary>
        /// Asks the user to input a distance
        /// </summary>
        public double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        public void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        public void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        public void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }


        public void OutputDistance(double fromDistance, string fromUnit, double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}");
        }
       
    }
}
