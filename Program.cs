using System;
using static System.Console;
namespace myApp
{
    class Program
    {
    public class ParentClass 
    {
        private string BaseOuput = null;

        public ParentClass ()
        {
            WriteLine("A ParentClass object is created w/out data properties.");
           
        }

        public ParentClass (string ParentString)
        {
            WriteLine("A ParentClass object is created w/ data properties.");
            BaseOuput = ParentString;
        }

        public void ParentPrintLine()
        {
            WriteLine(BaseOuput);
        }
    }

    public class ChildClass : ParentClass
    {
       private string DerivedOutput = null;

       public ChildClass (ParentClass Parent, string ChildString) : base()
       {
           DerivedOutput = ChildString;
       }

       public void ChildPrintLine()
       {
           WriteLine(DerivedOutput);
       }
    }

        static void Main()
        {
            ParentClass theParent = new ParentClass("Text for ParentClass");
            ChildClass theChild = new ChildClass(Parent: theParent, "Text for ChildClass");

            theParent.ParentPrintLine();
            theChild.ParentPrintLine();
            theChild.ChildPrintLine();

        }
    
    
    }
}
