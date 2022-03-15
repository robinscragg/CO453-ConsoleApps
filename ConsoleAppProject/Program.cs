using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Robin Scragg 07/03/2022
    /// </summary>
    public static class Program
    {
        // Header is printed
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2021-2022!");

            SelectApp();
        }

        // User selects which app they want to use
        private static void SelectApp()
        {
            Console.WriteLine("Which app do you want to select? : ");
            string[] choices = { "Distance Converter", "BMI Calculator", "Student Marks" };
            int choice = ConsoleHelper.SelectChoice(choices);
                       
            if (choice == 1)
            {
                DistanceConverter converter = new DistanceConverter();
                converter.ConvertDistance();
            }

            else if (choice == 2)
            {
                BMI bmi = new BMI();
                bmi.Run();
            } 
            
            else
            {
                StudentGrades grades = new StudentGrades();
                grades.Run();
            }
        }
    }
}
