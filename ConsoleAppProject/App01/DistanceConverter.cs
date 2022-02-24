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

        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;

        public DistanceConverter()
        {
            fromUnit = DistanceUnits.Miles;
            toUnit = DistanceUnits.Feet;

        }

        public void ConvertDistance()
        {
            OutputHeading();
            do
            {
                fromUnit = SelectUnit("Please select the unit to convert from : ");
            }
            while (fromUnit == DistanceUnits.NoUnit);
           
            Console.WriteLine($"You are converting from {fromUnit}");

            do
            {
                toUnit = SelectUnit("Please select the unit to convert to : ");                               
            }
            while (toUnit == DistanceUnits.NoUnit);
            
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
            
            else if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Miles)
            {
                toDistance =  fromDistance / FEET_IN_MILES;
            }

            else if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }

            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Miles)
            {
                toDistance =  fromDistance / METRES_IN_MILES;
            }

            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Metres)
            {
                toDistance =  fromDistance * FEET_IN_METRES;
            }

            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }

        }

        private DistanceUnits SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            if (fromUnit == DistanceUnits.NoUnit)
            {
                return ExecuteChoice(choice, fromUnit);
            }
            else
            {
                return ExecuteChoice(choice, toUnit);
            }
            

        }

        private DistanceUnits ExecuteChoice(string choice, DistanceUnits unit)
        {
            switch(choice)
            {
                case "1": unit = DistanceUnits.Feet; break;
                case "2": unit = DistanceUnits.Metres; break;
                case "3": unit = DistanceUnits.Miles; break;

                default: unit = DistanceUnits.NoUnit; break;
            }

            if(unit==DistanceUnits.NoUnit)
            {
                Console.WriteLine("Please select a correct option");
            }
            return unit;

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

        public string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($"1. {DistanceUnits.Feet}");
            Console.WriteLine($"2. {DistanceUnits.Metres}");
            Console.WriteLine($"3. {DistanceUnits.Miles}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }


    }
}
