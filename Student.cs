using System;

namespace DataStructProjectOne
{
    public class Student : Person
    {
        /*
        This is the Student class which inherits from Person. 
        It has a constructor which makes a Student object that has a Name, ID, Credits, and a GPA.
        */
        public Student(string name, int id, decimal credits, decimal gPA)
        {
            Name = name;
            ID = id;
            Credits = credits;
            GPA = gPA;
        }
    }
}