using System;
using System.Collections.Generic;

namespace csharp_test
{
    class Person
    {
        public Person()
        {
            Knowledge = new List<string>();
        }
        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, int id) : this(name)
        {
            Id = id;
        }
        public Person(string name, int id, int age) : this(name, id)
        {
            Age = age;
        }
        public string Name;
        public int Id;
        public int Age;
        public List<string> Knowledge;
        public void Print()
        {
            System.Console.WriteLine(Name);
            System.Console.WriteLine(Id);
            System.Console.WriteLine(Age);
        }
    }
    struct StructPerson
    {
        public string Name;
        public int Id;
        public int Age;
        public void Print()
        {
            System.Console.WriteLine(Name);
            System.Console.WriteLine(Id);
            System.Console.WriteLine(Age);
        }
    }
}
