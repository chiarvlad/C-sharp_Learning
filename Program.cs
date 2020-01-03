using System;

namespace myApp
{
    class Program
    {
        class Person
        {
            private string firstName;
            private string lastName;
            public string test = "public variable";

            public Person(string First, string Last)
            {
                Console.WriteLine("A new person is created");
                firstName = First;
                lastName = Last;
            }

            public string getFullName() => (firstName + " " + lastName);
        }
        static void Main(string[] args)
        {
           Console.WriteLine("Hello!");

           Person Vlad = new Person("Vlad", "Anastasiei");
           Console.WriteLine($"The name of the new person is {Vlad.getFullName()}");
           Console.WriteLine(Vlad.test);
        
           Console.WriteLine("second commit test");

           
        }
    }
}
