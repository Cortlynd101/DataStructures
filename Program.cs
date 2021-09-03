using System;
using System.Collections.Generic;
using static System.Console;

namespace DataStructProjectOne
{
    public static class MainProgram
    {
        static void Main(string[] args)
        {
            Beep();
            WriteLine("Hello World!");
            WriteLine();

            var studentOne = new Student("Cortlynd Cox", 334557, 13, 3.3M);
            WriteLine("Name: " + studentOne.Name);
            WriteLine("ID: " + studentOne.ID);
            WriteLine("Credits: " + studentOne.Credits);
            WriteLine("GPA: " + studentOne.GPA);
            WriteLine();

            WriteLine("Welcome to the Student Data Portal. ");
            
            Methods.SystemMethod();
        }
    }
}