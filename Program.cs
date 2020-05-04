using System;

namespace csharp_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            var person2 = new StructPerson();

            System.Console.WriteLine(person1.ToString());
            person1.Print();
            var person3 = person1;
            person1.Age = 26;
            person3.Print();
            System.Console.WriteLine(person2.ToString());
            person2.Print();
            var person4 = person2;
            person2.Age = 26;
            person4.Print();
        }
    }
}
