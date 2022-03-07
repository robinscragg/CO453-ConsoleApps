using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App02

{
    /// <summary>
    /// Calculates the user's BMI.
    /// Asks for height and weight in either
    /// imperial or metric, which the user selects
    /// </summary>
    /// <author>
    /// Robin Scragg 07/03/2022
    /// </author>
    public class BMI
    {
        public string Choice { get; set; }

        public double WeightStones { get; set; }
        public double WeightPounds { get; set; }

        public double HeightFeet { get; set; }
        public double HeightInches { get; set; }

        public double Weight { get; set; }
        public double Height { get; set; }

        public int Bmi { get; set; }

        // Runs the app
        public void Run()
        {
            ConsoleHelper.OutputHeading("App02 Body Mass Index (BMI) Calculator");
            Console.WriteLine("BMI is an estimate of your risk to weight-related health risk");
            Console.WriteLine();

            string [] choices = {"imperial", "metric"};
            int choice = ConsoleHelper.SelectChoice(choices);
            Choice = ChooseUnits(choice);
            
            Console.WriteLine($"You have selected {Choice} units");

            if (Choice == "metric" )
            {
                InputMetricMeasurements();
            }
            else
            {
                InputImperialMeasurements();
            }

            CalculateBMI();

            OutputBMI();

            OutputBAME();
        }

        // Outputs a message for BAME
        private void OutputBAME()
        {
            Console.WriteLine();
            Console.WriteLine("If you are Black, Asian, or other ethnic minority groups, you have a higher risk.");
            Console.WriteLine("Adults 23.0 or more are at an increased risk.");
            Console.WriteLine("Adults 27.5 or more are at a high risk.");
        }

        // Outputs BMI and BMI group
        private void OutputBMI()
        {
            Console.WriteLine();
            Console.WriteLine($"Your BMI is {Bmi}");

            if (Bmi < 18.5)
            {
                Console.WriteLine("Your weight status is: underweight");
            }
            else if (Bmi < 24.9)
            {
                Console.WriteLine("Your weight status is: normal");
            }
            else if(Bmi < 29.9)
            {
                Console.WriteLine("Your weight status is: overweight");
            }
            else if (Bmi < 34.9)
            {
                Console.WriteLine("Your weight status is: obese class I");
            }
            else if (Bmi < 39.9)
            {
                Console.WriteLine("Your weight status is: obese class II");
            }
            else
            {
                Console.WriteLine("Your weight status is: obese class III");
            }

        }

        // Calculates BMI
        public void CalculateBMI()
        {
            if (Weight == 0)
            {
               Weight = (WeightStones * 14 + WeightPounds) * 703;
               Height = HeightFeet * 12 + HeightInches;
            }
            Bmi = (int)(Weight / (Height * Height));
        }

        // Asks for user to enter weight and height in imperial units
        private void InputImperialMeasurements()
        {
            Console.WriteLine("Your weight will be entered in stones and pounds");
            Console.WriteLine("Your height will be entered in feet and inches");
            Console.WriteLine();

            WeightStones = ConsoleHelper.InputNumber("Please enter your weight in stones: ", 0);
            WeightPounds = ConsoleHelper.InputNumber("Please enter your weight in pounds: ", 0, 13);

            Console.WriteLine();

            HeightFeet = ConsoleHelper.InputNumber("Please enter your height in feet: ", 0);
            HeightInches = ConsoleHelper.InputNumber("Please enter your height in inches: ", 0, 11);
        }

        // Asks for user to input weight and height in metric measurements
        private void InputMetricMeasurements()
        {
            Console.WriteLine("Your weight will be entered in kilograms");
            Console.WriteLine("Your height will be entered in metres");
            Console.WriteLine();

            Weight = ConsoleHelper.InputNumber("Please enter your weight in kilograms: ", 0);

            Console.WriteLine();

            Height = ConsoleHelper.InputNumber("Please enter your height in metres: ", 0);
        }

        // Asks user to select which units they want to use
        public string ChooseUnits(int choice)
        {           
            if (choice == 1)
            {
                 return "imperial"; 
            }
            else if (choice == 2)
            {
                return "metric";
            }
            return "";                    
        }       
    }
}
