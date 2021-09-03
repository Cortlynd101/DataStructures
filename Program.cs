using System;
using System.Collections.Generic;
using static System.Console;

namespace DataStructProjectOne
{
    public static class MainProgram
    {
        //This is the Main of the program. All it does is give the inital welcome, and then launch the SystemMethod method.
        static void Main(string[] args)
        {
            WriteLine("\nWelcome to the Student Data Portal. ");
            Methods.SystemMethod();
        }
    }
}