﻿using System;

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

        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public DistanceUnits FromUnit { get; set; }
        public DistanceUnits ToUnit { get; set; }

        public DistanceConverter()
        {
            FromUnit = DistanceUnits.Miles;
            ToUnit = DistanceUnits.Feet;

        }

        public void ConvertDistance()
        {
            OutputHeading();
            do
            {
                FromUnit = SelectUnit("Please select the unit to convert from : ");
            }
            while (FromUnit == DistanceUnits.NoUnit);
           
            Console.WriteLine($"You are converting from {FromUnit}");

            do
            {
                ToUnit = SelectUnit("Please select the unit to convert to : ");                               
            }
            while (ToUnit == DistanceUnits.NoUnit);
            
            Console.WriteLine($"You are converting to {ToUnit}");
            Console.WriteLine();

            Console.WriteLine($"You are converting from {FromUnit} to {ToUnit}");
            Console.WriteLine();

            FromDistance = InputDistance($"Input the distance in {FromUnit} : ");

            CalculateDistance();

            OutputDistance();

        }

        public void CalculateDistance()
        {
            if (FromUnit == ToUnit)
            {
                ToDistance = FromDistance;
            }
            
            else if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Miles)
            {
                ToDistance =  FromDistance / FEET_IN_MILES;
            }

            else if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }

            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Miles)
            {
                ToDistance =  FromDistance / METRES_IN_MILES;
            }

            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Metres)
            {
                ToDistance =  FromDistance * FEET_IN_METRES;
            }

            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }

        }

        private DistanceUnits SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            if (FromUnit == DistanceUnits.NoUnit)
            {
                return ExecuteChoice(choice, FromUnit);
            }
            else
            {
                return ExecuteChoice(choice, ToUnit);
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
            Console.WriteLine($" {FromDistance} {FromUnit} is {ToDistance} {ToUnit}");
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
