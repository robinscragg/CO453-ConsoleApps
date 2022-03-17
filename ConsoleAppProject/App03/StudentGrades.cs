using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Allows student marks to be entered,
    /// output marks and grades, and calculate
    /// statistics
    /// </summary>
    public class StudentGrades
    {
        public const int NUMBEROFSTUDENTS = 10;

        public string[] Students { get; set; }
        public int[] Marks { get; set;}
        public Grades[] Grades { get; set; }
        public int[] Gradeprofile { get; set; }

        public int Total { get; set; }
        public double Mean { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public StudentGrades()
        {
            //Creates arrays
            Students = new string[NUMBEROFSTUDENTS] {
                "Ash", "Brook", "Charlie", 
                "Devon", "Emery", "Frankie", 
                "Grayson", "Hayden", "Indigo", "Jayden" };
            Marks = new int[NUMBEROFSTUDENTS] {10,20,30,40,50,60,70,80,90,100};
            Grades = new Grades[NUMBEROFSTUDENTS] {App03.Grades.F, App03.Grades.F, App03.Grades.F, 
                                                   App03.Grades.D, App03.Grades.C,App03.Grades.B, 
                                                   App03.Grades.A, App03.Grades.A, App03.Grades.A, App03.Grades.A};
            Gradeprofile = new int[5];
        }

        /// <summary>
        /// Prints out heading then asks user to select what to do
        /// </summary>
        public void Run()
        {
            ConsoleHelper.OutputHeading("App 03 : Student Marks");

            string[] choices = { "Input marks", "Output marks", "Output stats", "Output grade profile", "Exit" };
            int choice = ConsoleHelper.SelectChoice(choices);
            SelectOptions(choice);
        }

        /// <summary>
        /// Runs methods depending on user choice
        /// </summary>
        private void SelectOptions(int choice)
        {
            if (choice == 1)
            {
                InputMarks();               
                Run();
            }
            else if (choice == 2)
            {
                OutputMarks();
                Run();
            }
            else if (choice == 3)
            {
                CalculateMean();
                CalculateMinMax();
                OutputStats();
                Run();
            }
            else if (choice == 4)
            {
                CalculateGradeProfile();
                OutputGradeProfile();
                Run();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Asks user to input marks for each student
        /// Once marks are entered, convert them to a grade
        /// </summary>
        private void InputMarks()
        {
            for (int i=0; i < NUMBEROFSTUDENTS; i++)
            {               
                Marks[i] = (int)ConsoleHelper.InputNumber($"Please enter mark for {Students[i]} ", 0, 100);
                Grades[i] = ConvertMarktoGrade(Marks[i]);
            }            
        }

        /// <summary>
        /// Turns mark into grade
        /// </summary>
        public Grades ConvertMarktoGrade(int mark)
        {
            if (mark < 40)
            {
                return App03.Grades.F;
            }

            else if (mark < 50)
            {
                return App03.Grades.D;
            }

            else if (mark < 60)
            {
                return App03.Grades.C;
            }

            else if (mark < 70)
            {
                return App03.Grades.B;
            }
            
            else
            {
                return App03.Grades.A;
            }
        }

        /// <summary>
        /// Outputs mark for each student
        /// </summary>
        private void OutputMarks()
        {
            for (int i = 0; i < NUMBEROFSTUDENTS; i++)
            {                
                Console.WriteLine($"{Students[i]} mark = {Marks[i]} grade = {Grades[i]}");
            }
        }

        /// <summary>
        /// Outputs mean, minimum and maximum mark
        /// </summary>
        private void OutputStats()
        {
            Console.WriteLine($"The mean mark is {Mean}");
            Console.WriteLine($"The minimum mark is {Min}");
            Console.WriteLine($"The maximum mark is {Max}");
        }

        /// <summary>
        /// Calculates mean
        /// </summary>
        public void CalculateMean()
        {
            foreach (int mark in Marks)
            {
                Total += mark;
            }

            Mean = Total / NUMBEROFSTUDENTS;
        }

        /// <summary>
        /// Calculates minimum and maximum mark
        /// </summary>
        public void CalculateMinMax()
        {
            Min = Marks[0];
            Max = Marks[0];
            foreach (int mark in Marks)
            {            
                if (mark < Min)
                {
                    Min = mark;
                }
                else if (mark > Max)
                {
                    Max = mark;
                }
            }            
        }

        /// <summary>
        /// Outputs percentage of students that got each grade
        /// </summary>
        private void OutputGradeProfile()
        {
            foreach (Grades val in Enum.GetValues(typeof(Grades)))
            {
                Console.WriteLine($"The percentage of students that got {val} is {Gradeprofile[(int)val]} %");
            }          
        }

        /// <summary>
        /// Calculates the percentage of students that got each mark
        /// </summary>
        public void CalculateGradeProfile()
        {
           foreach (Grades grade in Grades)
            {
                Gradeprofile[(int)grade] += 1;
            }

           for (int i = 0; i < Gradeprofile.Length; i++)
            {
                Gradeprofile[i] = Gradeprofile[i] * 100 / NUMBEROFSTUDENTS;
            }
        }
    }
}
