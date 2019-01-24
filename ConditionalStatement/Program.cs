// Author: Joshua Cordle    
// Date: 1/24/2019
// Comments: Display a different statment determined by user input
using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Using a whole number,enter the grade you expect to earn in ISM 4300...");

            // Start try-catch method
            try
            {
                // Create a variable to read the user's input
                string input = Console.ReadLine();

                //Name the input and declare it as an integer
                int grade = int.Parse(input);

                //Use if method to diplay the grade the user will earn
                if ((grade <= 100) && (grade >= 98))
                {
                    //Diplay the letter grade earned by the user
                    Console.WriteLine("You will earn an A+!");

                    //Exit the program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                if ((grade <= 97) && (grade >= 92))
                {
                    //Diplay the letter grade earned by the user
                    Console.WriteLine("You will earn an A!");

                    //Exit the program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                if ((grade <= 91) && (grade >= 90))
                {
                    //Diplay the letter grade earned by the user
                    Console.WriteLine("You will earn an A-!");

                    //Exit the program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                if ((grade <= 88) && (grade >= 89))
                {
                    //Diplay the letter grade earned by the user
                    Console.WriteLine("You will earn a B+!");

                    //Exit the program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                if ((grade <= 87) && (grade >= 82))
                {
                    //Diplay the letter grade earned by the user
                    Console.WriteLine("You will earn a B!");

                    //Exit the program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                if ((grade <= 81) && (grade >= 80))
                {
                    //Diplay the letter grade earned by the user
                    Console.WriteLine("You will earn a B-!");

                    //Exit the program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                if ((grade <= 79) && (grade >= 78))
                {
                    //Diplay the letter grade earned by the user
                    Console.WriteLine("You will earn a C+!");

                    //Exit the program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                if ((grade <= 77) && (grade >= 72))
                {
                    //Diplay the letter grade earned by the user
                    Console.WriteLine("You will earn a C!");

                    //Exit the program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                if ((grade <= 71) && (grade >= 70))
                {
                    //Diplay the letter grade earned by the user
                    Console.WriteLine("You will earn a C-!");

                    //Exit the program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                if ((grade <= 69) && (grade >= 68))
                {
                    //Diplay the letter grade earned by the user
                    Console.WriteLine("You will earn a D+!");

                    //Exit the program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                if ((grade <= 67) && (grade >= 62))
                {
                    //Diplay the letter grade earned by the user
                    Console.WriteLine("You will earn a D!");

                    //Exit the program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                if ((grade <= 61) && (grade >= 60))
                {
                    //Diplay the letter grade earned by the user
                    Console.WriteLine("You will earn a D-!");

                    //Exit the program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                if ((grade <= 60)
                {
                    //Diplay the letter grade earned by the user
                    Console.WriteLine("You will earn a F!");

                    //Exit the program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
            }
            //Recall catch method
            catch
            {
                //Use catch method to close the program if the wrong data type is entered
                Console.WriteLine("Please enter a whole number...");
                Console.WriteLine("Press any key to exit and try again...");
                Console.ReadKey(true);
            }
        }
    }
}
