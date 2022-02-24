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
        private const double FEET_IN_METRES = 0.3048;

        private const string FEET = "feet";
        private const string METRES = "metres";
        private const string MILES = "miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;

        }

        public void ConvertDistance()
        {
            OutputHeading();
            do
            {
                fromUnit = SelectUnit("Please select the unit to convert from : ");
                Console.WriteLine("Please enter the right option");
                
            }
            while (fromUnit == null);
           
            Console.WriteLine($"You are converting from {fromUnit}");

            do
            {
                toUnit = SelectUnit("Please select the unit to convert to : ");
                Console.WriteLine("Please enter the right option");
            }
            while (toUnit == null);
            
            Console.WriteLine($"You are converting to {toUnit}");
            Console.WriteLine();

            Console.WriteLine($"You are converting from {fromUnit} to {toUnit}");
            Console.WriteLine();

            fromDistance = InputDistance($"Input the distance in {fromUnit} : ");

            CalculateDistance();

            OutputDistance();

        }

        private void CalculateDistance()
        {
            if (fromUnit == toUnit)
            {
                toDistance = fromDistance;
            }
            
            else if (fromUnit.Equals(MILES) && toUnit.Equals(FEET))
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            
            else if (fromUnit.Equals(FEET) && toUnit.Equals(MILES))
            {
                toDistance =  fromDistance / FEET_IN_MILES;
            }

            else if (fromUnit.Equals(MILES) && toUnit.Equals(METRES))
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }

            else if (fromUnit.Equals(METRES) && toUnit.Equals(MILES))
            {
                toDistance =  fromDistance / METRES_IN_MILES;
            }

            else if (fromUnit.Equals(FEET) && toUnit.Equals(METRES))
            {
                toDistance =  fromDistance * FEET_IN_METRES;
            }

            else if (fromUnit.Equals(METRES) && toUnit.Equals(FEET))
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }

        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            return ExecuteChoice(choice);

        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }

            else if (choice.Equals("2"))
            {
                return METRES;
            }

            else if (choice.Equals("3"))
            {
                return MILES;
            }
            else
            {
                return null;
            }

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
        /// Asks the user to input the distance 
        /// </summary>
        public double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            if(Double.TryParse(value, out double fromDistance))
            {
                fromDistance = Convert.ToDouble(value);
                
                if(fromDistance <0)
                {
                    fromDistance = InputDistance("Input a valid distance");
                }
                return fromDistance;
            }
            else
            {
                fromDistance = InputDistance("Input a valid distance");
                return fromDistance;
            }
                
        }

        /// <summary>
        /// Prints the output
        /// </summary>
        public void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}");
        }

        public static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($"1. {FEET}");
            Console.WriteLine($"2. {METRES}");
            Console.WriteLine($"3. {MILES}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }


    }
}
