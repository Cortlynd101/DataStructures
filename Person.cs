using System;

namespace DataStructProjectOne
{
    public class Person
    {
        public Person()
        {
            Name = "unkown";
        }
        public Person(string name, int id, decimal credits, decimal gPA)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}