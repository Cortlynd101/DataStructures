using System;

namespace DataStructProjectOne
{
    public class Student : Person
    {
        public Student(string name, int id, decimal credits, decimal gPA)
        {
            Name = name;
            ID = id;
            Credits = credits;
            GPA = gPA;
        }
        public int ID { get; set; }
        public decimal Credits { get; set; }
        public decimal GPA { get; set; }
    }
}