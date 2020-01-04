using System;
using static System.Console;
namespace myApp
{
    public class ParentClass 
    {
        public ParentClass()
        {
            WriteLine("This is a ParentClass constructor.");
        }
        public void PrintMe()
        {
            WriteLine("This is a ParentClass method.");
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            WriteLine("This is a ChildClass constructor.");
        }
    

    public static void Main()
    {
        ChildClass c1 = new ChildClass();

        c1.PrintMe();
        ReadLine();
    }
    }
}
