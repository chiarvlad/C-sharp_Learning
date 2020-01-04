using System;
using static System.Console;
namespace myApp
{
    class Program
    {
    public class ParentClass 
    {
        string parentString;

        public ParentClass()
        {
            WriteLine("This is a ParentClass constructor.");
        }

        public ParentClass(string myString)
        {
            parentString = myString;
            WriteLine("This is an overload ParentClass constructor");
            WriteLine($"Set the ParentClass.parentString to {parentString}.");
        }
        public void ParentPrint()
        {
            WriteLine("This is a ParentClass Method.");
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Some String") => WriteLine("This is a ChildClass constructor.");

        public void ChildPrint()
        {
            WriteLine("This is a ChildClass Method");
        }
    }
    static void Main()
    {
        ChildClass c1 = new ChildClass();

        c1.ChildPrint();
        c1.ParentPrint();
        ReadLine();
    }
    
    }
}
