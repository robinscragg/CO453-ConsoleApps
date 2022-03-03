using System;
namespace ConsoleAppProject.App02

{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
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
        public void Run()
        {
            OutputHeading();

            do
            {
                Choice = ChooseUnits();
            }
            while (Choice == null);

            Console.WriteLine();
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
        }

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

            Console.WriteLine();
            Console.WriteLine("If you are Black, Asian, or other ethnic minority groups, you have a higher risk.");
            Console.WriteLine("Adults 23.0 or more are at an increased risk.");
            Console.WriteLine("Adults 27.5 or more are at a high risk.");
        }

        public void CalculateBMI()
        {
            if (Weight == 0)
            {
               Weight = (WeightStones * 14 + WeightPounds) * 703;
               Height = HeightFeet * 12 + HeightInches;
            }
            Bmi = (int)(Weight / (Height * Height));
        }
        private void InputImperialMeasurements()
        {
            Console.WriteLine("Your weight will be entered in stones and pounds");
            Console.WriteLine("Your height will be entered in feet and inches");
            Console.WriteLine();

            WeightStones = InputMeasurement("Please enter your weight in stones: ", WeightStones);
            WeightPounds = InputMeasurement("Please enter your weight in pounds: ", WeightPounds);

            Console.WriteLine();

            HeightFeet = InputMeasurement("Please enter your height in feet: ", HeightFeet);
            HeightInches = InputMeasurement("Please enter your height in inches: ", HeightInches);
        }

        private void InputMetricMeasurements()
        {
            Console.WriteLine("Your weight will be entered in kilograms");
            Console.WriteLine("Your height will be entered in metres");
            Console.WriteLine();

            Weight = InputMeasurement("Please enter your weight in kilograms: ", Weight);

            Console.WriteLine();

            Height = InputMeasurement("Please enter your height in metres: ", Height);
        }

        public void OutputHeading()
        {
            Console.WriteLine(" ====================================== ");
            Console.WriteLine(" App02 Body Mass Index (BMI) Calculator ");
            Console.WriteLine("            by Lottie Scragg            ");
            Console.WriteLine(" ====================================== ");
            Console.WriteLine();
            Console.WriteLine("BMI is an estimate of your risk to weight-related health risk");
            Console.WriteLine();
        }

        public string ChooseUnits()
        {
            
            Console.WriteLine("Imperial Units: weight in stones and pounds, height in feet and inches");
            Console.WriteLine("Metric Units: weight in Kilograms, height in metres");
            Console.WriteLine();
            Console.WriteLine("Do you want to use imperial units or metric units? ");
            Console.WriteLine("Please enter either i or m ");
            Choice = Console.ReadLine();
            if (Choice == "i")
            {
                 return "imperial"; 
            }
            else if (Choice == "m")
            {
                return "metric";
            }
            else
            {
                Console.WriteLine("Please enter either i for imperial units or m for metric units");
                return null;
            }           
        }

        public double InputMeasurement(string prompt, double measurement)
        {   
           Console.WriteLine(prompt);
           string value = Console.ReadLine();
           if(Double.TryParse(value, out measurement))
           {
               measurement = Convert.ToDouble(value);

               if(measurement < 0)
               {
                  measurement = InputMeasurement("Please enter a valid number ", measurement);     
               }
                return measurement;
           }
           else
           {
                measurement = InputMeasurement("Please enter a valid number ", measurement);
                return measurement;
           }
        }
    }
}
