using System;
using System.Collections.Generic;
using static System.Console;

namespace DataStructProjectOne
{

    public static class Methods
    {
        private static List<Student> StudentList = new List<Student>();
        private static int id {get; set;}
        public static void SystemMethod()
        {
            bool ExitSystem = false;
            do
            {
                id = 0;
                WriteLine("\nWould you like to add a new student? [1] ");
                WriteLine("Find the data on a student already in the system? [2]");
                WriteLine("Or exit the system and shut down the program? [3] ");

                string userInput = ReadLine().ToString().ToLower();
                if (userInput == "1")
                {
                    StudentAddMethod();
                }
                else if (userInput == "2")
                {
                    StudentFindMethod();
                }
                else if (userInput == "3")
                {
                    WriteLine("Thank you for using the Student Data Portal.");
                    System.Threading.Thread.Sleep(50);
                    ExitSystem = true;
                }
                else
                {
                    WriteLine("That is an incorrect input, please enter a correct input. ");
                }

            } while (ExitSystem == false);
        }

        public static void StudentFindMethod()
        {
            bool Exit = false;
            bool ExitOrNotInputCorrect = false;
            do
            {
                Write("\nWhich student would you like to access by ID: ");
                int UserInput;

                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out UserInput))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input please try again: ");
                    }
                }
                //StudentList.ToString().Contains(UserInput); //Find(UserInput, UserInput, UserInput, UserInput) .Contains(UserInput);
                Write(StudentList[UserInput-1].Name);

                WriteLine("\nWould you like to access another student or return to the main menu? ");
                Write("Enter [1] to return and [2] to look up another student: ");
                do 
                {
                    string SecondUserInput = ReadLine().ToString().ToLower();
                if (SecondUserInput == "1")
                    {
                        ExitOrNotInputCorrect = true;
                        Exit = true;
                    }
                    else if (SecondUserInput == "2")
                    {
                        ExitOrNotInputCorrect = true;
                    }
                    else
                    {
                        WriteLine("That is an incorrect input, please enter a correct input: ");
                    }
                } while (ExitOrNotInputCorrect == false);
            } while (Exit == false);
        }
        public static void StudentAddMethod()
        {
            
            bool StudentAddedSuccessfully = false;
            bool Confirmation = false;
            WriteLine();
            do
            {
                Write("\nPlease enter the student name: ");
                string name = ReadLine().ToString().ToLower();

                // Write("Please enter the student ID: ");
                // int id;

                // while (true)
                // {
                //     string input = Console.ReadLine();
                //     if (int.TryParse(input, out id))
                //     {
                //         break;
                //     }
                //     else
                //     {
                //         Console.Write("Invalid input please try again: ");
                //     }
                // }

                Write("Please enter the student's credits earned: ");
                decimal credits;

                while (true)
                {
                    string input = Console.ReadLine();
                    if (decimal.TryParse(input, out credits))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input please try again: ");
                    }
                }

                Write("Please enter the student's GPA: ");
                decimal gpa;

                while (true)
                {
                    string input = Console.ReadLine();
                    if (decimal.TryParse(input, out gpa))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input please try again: ");
                    }
                }

                do
                {
                    WriteLine("\nIs this correct for the student name and ID? ");
                    WriteLine($"Name: {name}");
                    //WriteLine($"ID: {id}");
                    WriteLine($"Credits earned: {credits}");
                    WriteLine($"GPA: {gpa}");
                    Write("Enter [1] if it is correct and [2] if it isn't: ");

                    string userInput = ReadLine().ToString().ToLower();
                    if (userInput == "1")
                    {
                        id++;
                        StudentList.Add(new Student(name, id, credits, gpa));
                        WriteLine("Student successfully added. ");
                        WriteLine($"That individual student's ID is: {id}");
                        WriteLine();
                        StudentAddedSuccessfully = true;
                        Confirmation = true;
                    }
                    else if (userInput == "2")
                    {
                        Confirmation = true;
                    }
                    else
                    {
                        WriteLine("That is an incorrect input, please enter a correct input: ");
                    }

                } while (Confirmation == false);
            } while (StudentAddedSuccessfully == false);
        }
    }
}