using System;
using System.Collections.Generic;
using static System.Console;

namespace DataStructProjectOne
{

    public static class Methods
    {
        //This is the methods class where the bulk of the programs methods are executed.
        //The list on line 11 is a list using c# generics. It is a list of Student objects created in the Student class constructor.
        private static List<Student> StudentList = new List<Student>();
        public static void SystemMethod()
        {
            /*
            SystemMethod is the "main menu" of the program which allows the user to navigate the program. 
            The user can choose to add a new student and it will run the StudentAddMethod.
            The user can choose to look at a student's information and it will run the StudentFindMethod.
            Or the user can choose to exit the and end the program.
            */
            bool ExitSystem = false;
            do
            {
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
            /*
            StudentFindMethod allows the user to find a student and access their information. 
            This only works if the student already exists in the program, so students must be added first.
            The student's information is accessed by entering their ID.
            */
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

                //This if-else statement stops the program from exploding if they enter an ID of a Student object that doesn't yet exist.
                if (UserInput <= StudentList.Count & UserInput > 0)
                {
                    //This looks at the StudentList index number that matches the ID the user entered and gives the user the information of the student at the ID they entered.
                    //This fulfills the methods that return the Name, ID, credits and GPA.
                    WriteLine($"\nName: {StudentList[UserInput - 1].Name}");
                    WriteLine($"ID: {StudentList[UserInput - 1].ID}");
                    WriteLine($"Credits earned: {StudentList[UserInput - 1].Credits}");
                    WriteLine($"GPA: {StudentList[UserInput - 1].GPA}");
                }
                else
                {
                    WriteLine("There is no student at that ID. ");
                }

                //The user then has the choice to access another student or to go back to the "main menu."
                WriteLine("\nWould you like to access another student or return to the main menu? ");
                Write("Enter [1] to look up another student and [2] to return to the main menu: ");
                do
                {
                    string SecondUserInput = ReadLine().ToString().ToLower();
                    if (SecondUserInput == "2")
                    {
                        ExitOrNotInputCorrect = true;
                        Exit = true;
                    }
                    else if (SecondUserInput == "1")
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
            /*
            StudentAddMethod allows the user to add a Student object to the StudentList. 
            They enter the students name, credits earned, and their GPA. 
            The student will then have an ID assigned to them based on the index number they are in the StudentList plus one.
            The ID is plus one so that the IDs start at 1 not 0.
            I choose to do it this way so that no student can have the same ID. 
            This also means that all Student objects will be unique, as they could be the same in every way except ID.
            The user is also told the student's ID after they create the student so they can access the student's information with thier ID.
            */
            bool StudentAddedSuccessfully = false;
            bool Confirmation = false;
            WriteLine();
            do
            {
                Write("\nPlease enter the student name: ");
                string name = ReadLine().ToString().ToLower();

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
                    /*
                    This specific do-while loop allows the user to check that they have entered the correct information,
                    before they officially create the new Student object and enter the student into the system giving them an ID.
                    */
                    WriteLine("\nIs this correct for the student name and ID? ");
                    WriteLine($"Name: {name}");
                    WriteLine($"Credits earned: {credits}");
                    WriteLine($"GPA: {gpa}");
                    Write("Enter [1] if it is correct and [2] if it isn't: ");

                    string userInput = ReadLine().ToString().ToLower();
                    if (userInput == "1")
                    {
                        //Each new student added to the database is a Student object in the StudentList.
                        //This fulfills the ablility for the user to set the Name, Credits earned, and GPA.
                        StudentList.Add(new Student(name, StudentList.Count + 1, credits, gpa));
                        WriteLine("Student successfully added. ");
                        WriteLine($"That individual student's ID is: {StudentList.Count}");
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