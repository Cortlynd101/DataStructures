using System;

namespace DataStructProjectOne
{
    public class Person
    {
        //This is the base class Person from which student inherits from.
        public Person()
        {
            Name = "unkown";
            ID = 0;
            Credits = 0;
            GPA = 0;
        }
        public Person(string name, int id, decimal credits, decimal gPA)
        {
            Name = name;
            ID = id;
            Credits = credits;
            GPA = gPA;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public decimal Credits { get; set; }
        public decimal GPA { get; set; }
    }
}