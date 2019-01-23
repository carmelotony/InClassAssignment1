using System;

namespace ClassNotes012219_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the grade you want in this course");
            
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                if ((value_of_input >= 0) && (value_of_input <= 100)) 
                {
                    Console.WriteLine("Your grade is  " + Class_grade(value_of_input));
                }
                else 
                {
                    Console.WriteLine(" This is NOT a valid number");
                }
                Console.WriteLine("Press any key");
                Console.ReadKey(true);
            }//End try
            catch
            {
                Console.WriteLine(" There was an error ");
                Console.ReadKey(true);
            }//End catch
        }//End of main

        private static string Class_grade(int grade)
        {
            string lettergrade = "";

            if ((grade > 95) && (grade <= 100))
            {
                 lettergrade = "A+";
            }
            else if ((grade > 90) && (grade <= 95))
            {
                 lettergrade = "A";
            }
            else if ((grade > 87) && (grade <= 90))
            {
                 lettergrade = "A-";
            }
            else if ((grade > 84) && (grade <= 90))
            {
                 lettergrade = "B+";
            }
            else if ((grade > 80) && (grade <= 84))
            {
                 lettergrade = "B";
            }
            else if ((grade > 77) && (grade <= 80))
            {
                 lettergrade = "B-";
            }
            else if ((grade > 80) && (grade <= 74))
            {
                 lettergrade = "C+";
            }
            else if ((grade > 70) && (grade <= 74))
            {
                 lettergrade = "C";
            }
            else if ((grade > 67) && (grade <= 70))
            {
                 lettergrade = "C-";
            }
            else if ((grade > 63) && (grade <= 67))
            {
                 lettergrade = "D+";
            }
            else if ((grade > 60) && (grade <= 63))
            {
                 lettergrade = "D";
            }
            else
            {
                 lettergrade = "F";
            }

            return lettergrade;
        }  
    }
}
